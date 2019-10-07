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

## Examples
See the [Examples](Units.Examples/Readme.md) sub-project. 

## Automatic Unit Tests
See the [Tests](Units.Tests/Readme.md) sub-project. 

## Table Of Contents
- [CSharp Units (CsUnits)](#csharp-units-csunits)
  - [Build Status](#build-status)
  - [License](#license)
  - [Technology](#technology)
  - [Examples](#examples)
  - [Automatic Unit Tests](#automatic-unit-tests)
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
| YottaAmpere | YA |
| ZettaAmpere | ZA |
| ExaAmpere | EA |
| PetaAmpere | PA |
| TeraAmpere | TA |
| GigaAmpere | GA |
| MegaAmpere | MA |
| KiloAmpere | kA |
| HectoAmpere | hA |
| DekaAmpere | daA |
| DeciAmpere | dA |
| CentiAmpere | cA |
| MilliAmpere | mA |
| MicroAmpere | uA |
| NanoAmpere | nA |
| PicoAmpere | pA |
| FemtoAmpere | fA |
| AttoAmpere | aA |
| ZeptoAmpere | zA |
| YoctoAmpere | yA |

## Energy (System.Units.Energy)
| Name | Symbol |
|------|--------|
| Joule | J |
| YottaJoule | YJ |
| ZettaJoule | ZJ |
| ExaJoule | EJ |
| PetaJoule | PJ |
| TeraJoule | TJ |
| GigaJoule | GJ |
| MegaJoule | MJ |
| KiloJoule | kJ |
| HectoJoule | hJ |
| DekaJoule | daJ |
| DeciJoule | dJ |
| CentiJoule | cJ |
| MilliJoule | mJ |
| MicroJoule | uJ |
| NanoJoule | nJ |
| PicoJoule | pJ |
| FemtoJoule | fJ |
| AttoJoule | aJ |
| ZeptoJoule | zJ |
| YoctoJoule | yJ |
| Electronvolt | eV |
| YottaElectronvolt | YeV |
| ZettaElectronvolt | ZeV |
| ExaElectronvolt | EeV |
| PetaElectronvolt | PeV |
| TeraElectronvolt | TeV |
| GigaElectronvolt | GeV |
| MegaElectronvolt | MeV |
| KiloElectronvolt | keV |
| HectoElectronvolt | heV |
| DekaElectronvolt | daeV |
| DeciElectronvolt | deV |
| CentiElectronvolt | ceV |
| MilliElectronvolt | meV |
| MicroElectronvolt | ueV |
| NanoElectronvolt | neV |
| PicoElectronvolt | peV |
| FemtoElectronvolt | feV |
| AttoElectronvolt | aeV |
| ZeptoElectronvolt | zeV |
| YoctoElectronvolt | yeV |

## Length (System.Units.Length)
| Name | Symbol |
|------|--------|
| Metre | m |
| YottaMetre | Ym |
| ZettaMetre | Zm |
| ExaMetre | Em |
| PetaMetre | Pm |
| TeraMetre | Tm |
| GigaMetre | Gm |
| MegaMetre | Mm |
| KiloMetre | km |
| HectoMetre | hm |
| DekaMetre | dam |
| DeciMetre | dm |
| CentiMetre | cm |
| MilliMetre | mm |
| MicroMetre | um |
| NanoMetre | nm |
| PicoMetre | pm |
| FemtoMetre | fm |
| AttoMetre | am |
| ZeptoMetre | zm |
| YoctoMetre | ym |

## Luminosity (System.Units.Luminosity)
| Name | Symbol |
|------|--------|
| Candela | cd |
| YottaCandela | Ycd |
| ZettaCandela | Zcd |
| ExaCandela | Ecd |
| PetaCandela | Pcd |
| TeraCandela | Tcd |
| GigaCandela | Gcd |
| MegaCandela | Mcd |
| KiloCandela | kcd |
| HectoCandela | hcd |
| DekaCandela | dacd |
| DeciCandela | dcd |
| CentiCandela | ccd |
| MilliCandela | mcd |
| MicroCandela | ucd |
| NanoCandela | ncd |
| PicoCandela | pcd |
| FemtoCandela | fcd |
| AttoCandela | acd |
| ZeptoCandela | zcd |
| YoctoCandela | ycd |

## Mass (System.Units.Mass)
| Name | Symbol |
|------|--------|
| Gram | g |
| YottaGram | Yg |
| ZettaGram | Zg |
| ExaGram | Eg |
| PetaGram | Pm |
| TeraGram | Tg |
| GigaGram | Gg |
| MegaGram | Mg |
| KiloGram | kg |
| HectoGram | hg |
| DekaGram | dag |
| DeciGram | dg |
| CentiGram | cg |
| MilliGram | mg |
| MicroGram | ug |
| NanoGram | ng |
| PicoGram | pg |
| FemtoGram | fg |
| AttoGram | ag |
| ZeptoGram | zg |
| YoctoGram | yg |

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