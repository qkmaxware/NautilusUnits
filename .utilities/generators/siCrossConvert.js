// ---------------------------------------------------
// Usage
// ---------------------------------------------------
/*
	From current directory
	> node siCrossConvert.js "System.Units.Energy" "System.Units.Energy.Electronvolt" "System.Units.Energy.Joule" "1.602176565e-19"
	
	From root directory
	> node .\.utilities\generators\siCrossConvert.js "System.Units.Energy" "System.Units.Energy.Electronvolt" "System.Units.Energy.Joule" "1.602176565e-19"
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

var regex = /((?:[a-zA-Z]+\.)+)([a-zA-Z]+)/;
var namespace = process.argv[2];
var arg1 = process.argv[3];
var arg2 = process.argv[4];
var matches = regex.exec(arg1);
if (matches == null) {
    throw new Error("Missing argument 1 in the form of namespace.item");
}
var namespace1 = matches[1].substring(0, matches[1].length - 1);
var unit1 = matches[2];
matches = regex.exec(arg2);
if (matches == null) {
    throw new Error("Missing argument 2 in the form of namespace.item");
}

var namespace2 = matches[1].substring(0, matches[1].length - 1);
var unit2 = matches[2];

var baseexpr = process.argv[5];

const os = require('os');
const fs = require("fs");
const path = require("path");

var outpath = path.join(__dirname, "obj");

if (!fs.existsSync(outpath)){
    fs.mkdirSync(outpath);
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

function ToDerivedName(prefix, root) {
    return ToPascalCase(prefix + root);
}

function CreateConversion(from, to, expr) {
from = ToPascalCase(from);
to = ToPascalCase(to);
return `	/// <summary>
    /// Extension method to convert ${from} to ${to}
    /// </summary>
    /// <param name="val">quantity measured in ${from}</param>
    /// <returns>quantity measured in ${to}</returns>
	public static Quantity<double, ${to}> To${to}<T>(this Quantity<T, ${from}> val) where T:IConvertible {
        return new Quantity<double, ${to}>(
            Convert.ToDouble(val.Value) * ${expr}
        );
    }`;
}

function CreateClass(firstNamespace, secondNamespace, namespace, name, data) {
var str = data.join(os.EOL);
var namespaces = "";
if (firstNamespace != namespace) {
    namespaces += ("using " + firstNamespace + ";" + os.EOL);
}
if (secondNamespace != firstNamespace) {
    namespaces += ("using " + secondNamespace + ";" + os.EOL);
}

return `using System;
${namespaces}
namespace ${namespace} {
public static class ${name}Conversions {
${str}
}
}`;
}

// ---------------------------------------------------
// Generation
// ---------------------------------------------------

var conversions = [];

// Create base conversion
conversions.push(
    CreateConversion(
        unit1, 
        unit2, 
        "(" + baseexpr + ")"
    )
);
conversions.push(
    CreateConversion (
        unit2,
        unit1,
        "(1.0/(" + baseexpr + "))"
    )
);

for (var i = 0; i < prefixes.length; i++) {
    var unit1a = ToDerivedName(prefixes[i].name, unit1);
    var unit2a = ToDerivedName(prefixes[i].name, unit2);
    conversions.push(
        CreateConversion(
            unit1,
            unit2a,
            "((" + baseexpr + ") * " + "1E" + -prefixes[i].factor + ")"
        )
    );
    conversions.push(
        CreateConversion(
            unit2,
            unit1a,
            "((1.0/(" + baseexpr + ")) * " + "1E" + -prefixes[i].factor + ")"
        )
    );
}

// Create derived conversions
for (var i = 0; i < prefixes.length; i++) {
    for (var j = 0; j < prefixes.length; j++) {
        var unitA = ToDerivedName(prefixes[i].name, unit1);
        var factorA = -prefixes[i].factor;
        var unitB = ToDerivedName(prefixes[j].name, unit2);
        var factorB = -prefixes[j].factor;
        // A->B
        conversions.push(
            CreateConversion(
                unitA,
                unitB,
                "((" + baseexpr + ") * (" + "1E" + factorA + "))"
            )
        );
        // B->A
        conversions.push(
            CreateConversion(
                unitB,
                unitA,
                "((1.0/(" + baseexpr + ")) * (" + "1E" + factorA + "))"
            )
        );
    }
}

var conversionName = ToPascalCase(unit1) + "To" + ToPascalCase(unit2) + "Conversions";
save(
    path.join(outpath, conversionName + ".cs"), 
    CreateClass(namespace1, namespace2, namespace, conversionName, conversions)
);