// ---------------------------------------------------
// Usage
// ---------------------------------------------------
/*
	From current directory
	> node units.js "Gram{g}@System.Units.Mass"
	
	From root directory
	> node .\.utilities\generators\units.js "Gram{g}@System.Units.Mass"
*/

// ---------------------------------------------------
// Config
// ---------------------------------------------------
var prefixes = [
	{ name: "yotta", symbol: "Y", factor: 24 },
	{ name: "zetta", symbol: "Z", factor: 21 },
	{ name: "exa", symbol: "E", factor: 18 },
	{ name: "peta", symbol: "P", factor: 15 },
	{ name: "tera", symbol: "T", factor: 12 },
	{ name: "giga", symbol: "G", factor: 9 },
	{ name: "mega", symbol: "M", factor: 6 },
	{ name: "kilo", symbol: "k", factor: 3 },
	{ name: "hecto", symbol: "h", factor: 2 },
	{ name: "deka", symbol: "da", factor: 1 },
	
	{ name: "deci", symbol: "d", factor: -1 },
	{ name: "centi", symbol: "c", factor: -2 },
	{ name: "milli", symbol: "m", factor: -3 },
	{ name: "micro", symbol: "u", factor: -6 },
	{ name: "nano", symbol: "n", factor: -9 },
	{ name: "pico", symbol: "p", factor: -12 },
	{ name: "femto", symbol: "f", factor: -15 },
	{ name: "atto", symbol: "a", factor: -18 },
	{ name: "zepto", symbol: "z", factor: -21 },
	{ name: "yocto", symbol: "y", factor: -24 },
]

var regex = /([a-zA-Z]+){([a-zA-Z0-9\+\-\^\\\*\/]+)}@((?:[a-zA-Z]+\.)+([a-zA-Z]+))/;
var map = {
    Unit: 1,
    Symbol: 2,
    Namespace: 3,
    Type: 4
};
var node = process.argv[0];
var file = process.argv[1];
var arg = process.argv[2];
var matches = regex.exec(arg);
if (matches == null) {
    throw new Error("Missing argument in the form of unit{symbol}@namespace.item");
}

var namespace = matches[map.Namespace];
var conversionName = matches[map.Type];
var element = { name: matches[map.Unit], symbol: matches[map.Symbol] }

// ---------------------------------------------------
// Function declarations
// ---------------------------------------------------
function ToPascalCase(name) {
	return name.charAt(0).toUpperCase() + name.slice(1);
}

function template (namespace, name, symbol, conversionName) {
var namespace = ToPascalCase(namespace);
var name = ToPascalCase(name);

// Remove spaces, times signs, and division symbols from symbol to create function name
var cleaned_symbol = symbol.replace(" ", "").replace("^", "").replace("*", "").replace("/","_");

var useFactory = /^[a-zA-Z_][a-zA-Z_0-9]*$/.test(cleaned_symbol);

var tpl1 = `namespace ${namespace} {
	/// <summary>
	/// Unit of measurement for the ${name} (${symbol})
	/// </summary>
	public struct ${name} : I${conversionName} {
        public static string Name => "${name}";
        public static string Symbol => "${symbol}";
    }
	
	public static class ${name}Factory {
		/// <summary>
        /// Create a quantity measured in ${name}s
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ${name}> ${cleaned_symbol}<T>(this T value) {
            return new Quantity<T, ${name}> (value);
        }
	}
}`;
var tpl2 = `namespace ${namespace} {
	/// <summary>
	/// Unit of measurement for the ${name} (${symbol})
	/// </summary>
	public struct ${name} : I${conversionName} {
        public static string Name => "${name}";
        public static string Symbol => "${symbol}";
    }
}`;
return (useFactory ? tpl1 : tpl2);
}

function convert(from, to, factor) {
var from = ToPascalCase(from);
var to = ToPascalCase(to);
var tpl = 
`	/// <summary>
    /// Extension method to convert ${from} to ${to}
    /// </summary>
    /// <param name="val">quantity measured in ${from}</param>
    /// <returns>quantity measured in ${to}</returns>
	public static Quantity<double, ${to}> To${to}<T>(this Quantity<T, ${from}> val) where T:IConvertible {
        return new Quantity<double, ${to}>(
            Convert.ToDouble(val.Value) * ${factor}
        );
    }`;
return tpl;
}

const os = require('os');

function conversionClass(namespace, name, conversions) {
var str = conversions.join(os.EOL);

var tpl = `using System;
namespace ${namespace} {
public static class ${name}Conversions {
${str}
}
}`;
return tpl;
}

const fs = require("fs");
const path = require("path");

if (!fs.existsSync(path.join(__dirname, "obj"))){
    fs.mkdirSync(path.join(__dirname, "obj"));
}

function save(file, content) {
fs.writeFile(file, content, function(err) {
    if(err) {
        return console.log(err);
    }
});
}

function ToDerivedName(prefix, root) {
    return ToPascalCase(prefix + root);
}

// ---------------------------------------------------
// Generation
// ---------------------------------------------------

// Generate main class
save(
    path.join(__dirname, "obj", ToPascalCase(element.name)+".cs"),
    template(namespace, element.name, element.symbol, conversionName)
);

// Generate prefix class
for (var i = 0; i < prefixes.length; i++) {
	var n = ToDerivedName(prefixes[i].name, element.name);
	
	save(
        path.join(__dirname, "obj", n+".cs"), 
        template(namespace, n, prefixes[i].symbol + element.symbol, conversionName)
    );
}

var conversions = [];
// Generate to/from base
for (var i = 0; i < prefixes.length; i++) {
	conversions.push(
		convert(
			element.name, 
			ToDerivedName(prefixes[i].name, element.name), 
			"1E" + -prefixes[i].factor
		)
	);
}

// Generate between derived units
for (var i = 0; i < prefixes.length; i++) {
	for (var j = 0; j < prefixes.length; j++) {
		if (i == j)
			continue;
			
		var factor = prefixes[i].factor - prefixes[j].factor;
		var conversion = convert(
			ToDerivedName(prefixes[i].name, element.name),
			ToDerivedName(prefixes[j].name, element.name),
			"1E" + -prefixes[i].factor
		);
		conversions.push(conversion);
	}
}

// Save Base class
save (
	path.join(__dirname, "obj", "I" + conversionName + ".cs"),
`using System.Units; 

namespace ${namespace} {

	public interface I${conversionName} : IUnit {}

}`
)

// Output conversion class
save(
    path.join(__dirname, "obj", ToPascalCase(element.name) + conversionName + "Conversions.cs"), 
    conversionClass(namespace, ToPascalCase(element.name) + conversionName, conversions)
);