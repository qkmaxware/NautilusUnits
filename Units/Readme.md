# CSharp Units
This sub-project contains the source code for the CSharp Units library. 

- [CSharp Units](#csharp-units)
- [Usage](#usage)
- [Simple Example](#simple-example)
- [Predefined Units](#predefined-units)
  - [Velocity Change (System.Units.Acceleration)](#velocity-change-systemunitsacceleration)
  - [Amount Of Substance (System.Units.Amount)](#amount-of-substance-systemunitsamount)
  - [Geometric Angle (System.Units.Angle)](#geometric-angle-systemunitsangle)
  - [Electrical Current (System.Units.Current)](#electrical-current-systemunitscurrent)
  - [Energy (System.Units.Energy)](#energy-systemunitsenergy)
  - [Force (System.Units.Force)](#force-systemunitsforce)
  - [Length (System.Units.Length)](#length-systemunitslength)
  - [Luminosity (System.Units.Luminosity)](#luminosity-systemunitsluminosity)
  - [Mass (System.Units.Mass)](#mass-systemunitsmass)
  - [Power (System.Units.Power)](#power-systemunitspower)
  - [Pressure (System.Units.Pressure)](#pressure-systemunitspressure)
  - [Thermodynamic Temperature (System.Units.Temperature)](#thermodynamic-temperature-systemunitstemperature)
  - [Time (System.Units.Time)](#time-systemunitstime)
  - [Velocity (System.Units.Velocity)](#velocity-systemunitsvelocity)

# Usage
Usage of this units of measure library relies heavily on the `System.Units.Quantity<Type, Unit>` type. This type is a generic type which takes in two parameters, the first of which is the stored type of the measured quantity and the second is the units associated with the measured quantity. For instance `System.Units.Quantity<double, Metre>` would represent any double precision values which are tagged to be measured in the SI unit of metres. There are several predefined units provided by this library crossing many different areas of science. Each of these units also contain relevant conversion functions if it makes sense (such as converting between SI prefixes). You can use this type to restrict certain methods to only accepting formal parameters measured in specific units. Additionally, each unit is provided with an extension method which can allow for raw values to be quickly tagged with a specific unit by using the symbol of that unit. 

# Simple Example
```cs
public Quantity<double, Newton> Force (Quantity<double, KiloGram> mass, Quantity<double, MetresPerSecondSq> acceleration) {
    return (mass.Value * acceleration.Value).N();
}
```

# Predefined Units
## Velocity Change (System.Units.Acceleration)
| Name | Symbol |
|------|--------|
| MetrePerSecondSq | m/s^2|
| YottaMetrePerSecondSq | Ym/s^2|
| ZettaMetrePerSecondSq | Zm/s^2|
| ExaMetrePerSecondSq | Em/s^2|
| PetaMetrePerSecondSq | Pm/s^2|
| TeraMetrePerSecondSq | Tm/s^2|
| GigaMetrePerSecondSq | Gm/s^2|
| MegaMetrePerSecondSq | Mm/s^2|
| KiloMetrePerSecondSq | km/s^2|
| HectoMetrePerSecondSq | hm/s^2|
| DekaMetrePerSecondSq | dam/s^2|
| DeciMetrePerSecondSq | dm/s^2|
| CentiMetrePerSecondSq | cm/s^2|
| MilliMetrePerSecondSq | mm/s^2|
| MicroMetrePerSecondSq | um/s^2|
| NanoMetrePerSecondSq | nm/s^2|
| PicoMetrePerSecondSq | pm/s^2|
| FemtoMetrePerSecondSq | fm/s^2|
| AttoMetrePerSecondSq | am/s^2|
| ZeptoMetrePerSecondSq | zm/s^2|
| YoctoMetrePerSecondSq | ym/s^2|

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

## Force (System.Units.Force)
| Name | Symbol |
|------|--------|
| Newton | N |
| YottaNewton | YN |
| ZettaNewton | ZN |
| ExaNewton | EN |
| PetaNewton | PN |
| TeraNewton | TN |
| GigaNewton | GN |
| MegaNewton | MN |
| KiloNewton | kN |
| HectoNewton | hN |
| DekaNewton | daN |
| DeciNewton | dN |
| CentiNewton | cN |
| MilliNewton | mN |
| MicroNewton | uN |
| NanoNewton | nN |
| PicoNewton | pN |
| FemtoNewton | fN |
| AttoNewton | aN |
| ZeptoNewton | zN |
| YoctoNewton | yN |

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
| Candela | lm |
| YottaCandela | Ylm |
| ZettaCandela | Zlm |
| ExaCandela | Elm |
| PetaCandela | Plm |
| TeraCandela | Tlm |
| GigaCandela | Glm |
| MegaCandela | Mlm |
| KiloCandela | klm |
| HectoCandela | hlm |
| DekaCandela | dalm |
| DeciCandela | dlm |
| CentiCandela | clm |
| MilliCandela | mlm |
| MicroCandela | ulm |
| NanoCandela | nlm |
| PicoCandela | plm |
| FemtoCandela | flm |
| AttoCandela | alm |
| ZeptoCandela | zlm |
| YoctoCandela | ylm |
| Lumen | lm |
| YottaLumen | Ylm |
| ZettaLumen | Zlm |
| ExaLumen | Elm |
| PetaLumen | Plm |
| TeraLumen | Tlm |
| GigaLumen | Glm |
| MegaLumen | Mlm |
| KiloLumen | klm |
| HectoLumen | hlm |
| DekaLumen | dalm |
| DeciLumen | dlm |
| CentiLumen | clm |
| MilliLumen | mlm |
| MicroLumen | ulm |
| NanoLumen | nlm |
| PicoLumen | plm |
| FemtoLumen | flm |
| AttoLumen | alm |
| ZeptoLumen | zlm |
| YoctoLumen | ylm |

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

## Power (System.Units.Power)
| Name | Symbol |
|------|--------|
| Watt | W |
| YottaWatt | YW |
| ZettaWatt | ZW |
| ExaWatt | EW |
| PetaWatt | PW |
| TeraWatt | TW |
| GigaWatt | GW |
| MegaWatt | MW |
| KiloWatt | kW |
| HectoWatt | hW |
| DekaWatt | daW |
| DeciWatt | dW |
| CentiWatt | cW |
| MilliWatt | mW |
| MicroWatt | uW |
| NanoWatt | nW |
| PicoWatt | pW |
| FemtoWatt | fW |
| AttoWatt | aW |
| ZeptoWatt | zW |
| YoctoWatt | yW |

## Pressure (System.Units.Pressure)
| Name | Symbol |
|------|--------|
| Pascal | Pa |
| YottaPascal | YPa |
| ZettaPascal | ZPa |
| ExaPascal | EPa |
| PetaPascal | PPa |
| TeraPascal | TPa |
| GigaPascal | GPa |
| MegaPascal | MPa |
| KiloPascal | kPa |
| HectoPascal | hPa |
| DekaPascal | daPa |
| DeciPascal | dPa |
| CentiPascal | cPa |
| MilliPascal | mPa |
| MicroPascal | uPa |
| NanoPascal | nPa |
| PicoPascal | pPa |
| FemtoPascal | fPa |
| AttoPascal | aPa |
| ZeptoPascal | zPa |
| YoctoPascal | yPa |

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

## Velocity (System.Units.Velocity)
| Name | Symbol |
|------|--------|
| MetrePerSecond | m/s |
| YottaMetrePerSecond | Ym/s |
| ZettaMetrePerSecond | Zm/s |
| ExaMetrePerSecond | Em/s |
| PetaMetrePerSecond | Pm/s |
| TeraMetrePerSecond | Tm/s |
| GigaMetrePerSecond | Gm/s |
| MegaMetrePerSecond | Mm/s |
| KiloMetrePerSecond | km/s |
| HectoMetrePerSecond | hm/s |
| DekaMetrePerSecond | dam/s |
| DeciMetrePerSecond | dm/s |
| CentiMetrePerSecond | cm/s |
| MilliMetrePerSecond | mm/s |
| MicroMetrePerSecond | um/s |
| NanoMetrePerSecond | nm/s |
| PicoMetrePerSecond | pm/s |
| FemtoMetrePerSecond | fm/s |
| AttoMetrePerSecond | am/s |
| ZeptoMetrePerSecond | zm/s |
| YoctoMetrePerSecond | ym/s |