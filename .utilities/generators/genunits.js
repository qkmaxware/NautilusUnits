// ---------------------------------------------------
// Usage
// ---------------------------------------------------
/*
	From current directory
	> node genunits.js "Qkmaxware.Units.Length" "Mile{mi}" "..\maps\Mile.Length.json"
	
	From root directory
	> node .\.utilities\generators\genunits.js "Qkmaxware.Units.Length" "Mile{mi}" ".utilities\maps\Mile.Length.json"
*/

const os    = require('os');
const fs    = require("fs");
const path  = require("path");
if (!fs.existsSync(path.join(__dirname, "obj"))){
    fs.mkdirSync(path.join(__dirname, "obj"));
}

var rgx = /((?:[a-zA-Z]+\.)+([a-zA-Z]+))/;
var rgp = /([a-zA-Z]+)\{([^\}]+)\}/;

var node    = process.argv[0];
var file    = process.argv[1];
var ns      = process.argv[2];
var conv    = rgx.exec(ns)[2];
var _       = rgp.exec(process.argv[3]);
var symbol  = _[2];
var unit    = _[1];
var mapd    = JSON.parse(fs.readFileSync(process.argv[4], 'utf8'));

// ---------------------------------------------------
// Definitions
// ---------------------------------------------------

function template (namespace, name, symbol, conversionName) {
    var namespace = ToPascalCase(namespace);
    var name = ToPascalCase(name);
    
    // Remove spaces, times signs, and division symbols from symbol to create function name
    var cleaned_symbol = (symbol || "").replace(" ", "").replace("^", "").replace("*", "").replace("/","_");
    
    var useFactory = /^[a-zA-Z_][a-zA-Z_0-9]*$/.test(cleaned_symbol);
    
var tpl1 = `namespace ${namespace} {
/// <summary>
/// Unit of measurement for ${name} (${symbol})
/// </summary>
public struct ${name} : I${conversionName} {
    public static string Name => "${name}";
    public static string Symbol => "${symbol}";
}

/// <summary>
/// Extension method factory for generating ${name} (${symbol})
/// </summary>
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
    public static Quantity<double, ${to}> To${to}<T>(this BaseQuantity<T, ${from}> val) where T:IConvertible {
        return new Quantity<double, ${to}>(
            Convert.ToDouble(val.Value) * ${factor}
        );
    }`;
    return tpl;
}

function CreateClass(namespace, name, data) {
var str = data.join(os.EOL);

return `using System;

namespace ${namespace} {
/// <summary>
/// Static class housing conversions to and from the unit "${name}"
/// </summary>
public static class ${name}Conversions {
${str}
}
}`;
}

function save(file, content) {
    fs.writeFile(file, content, function(err) {
        if(err) {
            return console.log(err);
        }
    });
}

function ToPascalCase(name) {
	return name.charAt(0).toUpperCase() + name.slice(1);
}

// ---------------------------------------------------
// Generation
// ---------------------------------------------------
// Save Base class
save (
	path.join(__dirname, "obj", "I" + conv + ".cs"),
`using Qkmaxware.Units; 

namespace ${ns} {

	public interface I${conv} : IUnit {}

}`
)

// Generate main class
save(
    path.join(__dirname, "obj", ToPascalCase(unit)+".cs"),
    template(ns, unit, symbol, conv)
);

// Save other classes
for (var elem in mapd) {
    var match = rgp.exec(elem);
    var dname = match[1];
    var dsymbol = match[2];
    save(
        path.join(__dirname, "obj", ToPascalCase(dname)+".cs"),
        template(ns, dname, dsymbol, conv)
    );
}

// Save conversion class
var conversions = [];
for (var elem in mapd) {
    var match = rgp.exec(elem);
    var dname = match[1];
    var dsymbol = match[2];
    var factor = mapd[elem];

    // Convert to and from base class
    conversions.push(
        convert(
            ToPascalCase(unit),
            ToPascalCase(dname),
            "(" + factor + ")"
        )
    );
    conversions.push(
        convert(
            ToPascalCase(dname),
            ToPascalCase(unit),
            "(1d/(" + factor + "))"
        )
    );

    for (var elem2 in mapd) {
        if (elem == elem2 ) {
            continue;
        }

        var match2 = rgp.exec(elem2);
        var dname2 = match2[1];
        var dsymbol2 = match2[2];
        var factor2 = mapd[elem2];

        // Convert to and from other classes
        conversions.push(
            convert (
                ToPascalCase(dname),
                ToPascalCase(dname2),
                "((1d/(" + factor + ")) * (" + factor2  + "))"
            )
        );
        /*conversions.push(
            convert (
                ToPascalCase(dname2),
                ToPascalCase(dname),
                "((1d/(" + factor2 + ")) * (" + factor  + "))"
            )
        );*/
    }
}
save(
    path.join(__dirname, "obj", ToPascalCase(unit) + conv + "Conversions.cs"), 
    CreateClass(ns, ToPascalCase(unit) + conv, conversions)
);