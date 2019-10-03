<p align="center">
  <img width="120" height="120" src="logo.svg">
</p>

# CSharp Units (CsUnits)
CsUnits is a units of measure library for the .net core framework. It is designed for compile time checking of units. This library does this through use of the Quantity class which uses generics for specifying at compile time which units are associated with a given quantity. All predefined units are contained within the `System.Units` namespace. 

## Build Status
![](https://github.com/qkmaxware/CsUnits/workflows/Build/badge.svg)

## License
See [License](LICENSE) for license details.

## Technology
1. Dotnet Standard 2.1+
2. C# 8+

## Table Of Contents
- [CSharp Units (CsUnits)](#csharp-units-csunits)
  - [Build Status](#build-status)
  - [License](#license)
  - [Technology](#technology)
  - [Table Of Contents](#table-of-contents)
- [Predefined Units](#predefined-units)
  - [Amount Of Substance (System.Units.Amount)](#amount-of-substance-systemunitsamount)
  - [Geometric Angle (System.Units.Angle)](#geometric-angle-systemunitsangle)
  - [Electrical Current (System.Units.Current)](#electrical-current-systemunitscurrent)
  - [Energy (System.Units.Energy)](#energy-systemunitsenergy)
  - [Length (System.Units.Length)](#length-systemunitslength)
  - [Luminosity (System.Units.Luminosity)](#luminosity-systemunitsluminosity)
  - [Mass (System.Units.Mass)](#mass-systemunitsmass)
  - [Thermodynamic Temperature (System.Units.Temperature)](#thermodynamic-temperature-systemunitstemperature)
  - [Time (System.Units.Time)](#time-systemunitstime)

# Predefined Units
## Amount Of Substance (System.Units.Amount)
| Name | Symbol |
|------|--------|
| Mole | mol |

## Geometric Angle (System.Units.Angle)
| Name | Symbol |
|------|--------|
| Degrees | ° |
| Radians | rad |

## Electrical Current (System.Units.Current)
| Name | Symbol |
|------|--------|
| Ampere | A |

## Energy (System.Units.Energy)
| Name | Symbol |
|------|--------|

## Length (System.Units.Length)
| Name | Symbol |
|------|--------|
| Yottametre | Ym |
| Zettametre | Zm |
| Exametre | Em |
| Petametre | Pm |
| Terametre | Tm |
| Gigametre | Gm |
| Megametre | Mm |
| Kilometre | km |
| Hectometre | hm |
| Dekametre | dam |
| Decimetre | dm |
| Centimetre | cm |
| Millimetre | mm |
| Micrometre | um |
| Nanometre | nm |
| Picometre | pm |
| Femtometre | fm |
| Attometre | am |
| Zeptometre | zm |
| Yoctometre | ym |

## Luminosity (System.Units.Luminosity)
| Name | Symbol |
|------|--------|
| Yottacandela | Ycd |
| Zettacandela | Zcd |
| Exacandela | Ecd |
| Petacandela | Pcd |
| Teracandela | Tcd |
| Gigacandela | Gcd |
| Megacandela | Mcd |
| Kilocandela | kcd |
| Hectocandela | hcd |
| Dekacandela | dacd |
| Decicandela | dcd |
| Centicandela | ccd |
| Millicandela | mcd |
| Microcandela | ucd |
| Nanocandela | ncd |
| Picocandela | pcd |
| Femtocandela | fcd |
| Attocandela | acd |
| Zeptocandela | zcd |
| Yoctocandela | ycd |

## Mass (System.Units.Mass)
| Name | Symbol |
|------|--------|
| Yottagram | Yg |
| Zettagram | Zg |
| Exagram | Eg |
| Petagram | Pm |
| Teragram | Tg |
| Gigagram | Gg |
| Megagram | Mg |
| Kilogram | kg |
| Hectogram | hg |
| Dekagram | dag |
| Decigram | dg |
| Centigram | cg |
| Milligram | mg |
| Microgram | ug |
| Nanogram | ng |
| Picogram | pg |
| Femtogram | fg |
| Attogram | ag |
| Zeptogram | zg |
| Yoctogram | yg |

## Thermodynamic Temperature (System.Units.Temperature)
| Name | Symbol |
|------|--------|
| Celsius | °C |
| Fahrenheit | °F |
| Kelvin | K |
| Rankine | °R |

## Time (System.Units.Time)
| Name | Symbol |
|------|--------|
| Second | s |
| Minute | min |
| Hour | hr |
| Day | day |
| Year | yr |