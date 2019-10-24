# Nautilus Units
This sub-project contains the source code for the Nautilus Units library. 

- [Nautilus Units](#nautilus-units)
- [Usage](#usage)
- [Simple Example](#simple-example)
- [Predefined Constants](#predefined-constants)
  - [Physical Constants](#physical-constants)
  - [Solar System Data](#solar-system-data)
- [Predefined Units](#predefined-units)
  - [Velocity Change (System.Units.Acceleration)](#velocity-change-systemunitsacceleration)
  - [Amount Of Substance (System.Units.Amount)](#amount-of-substance-systemunitsamount)
  - [Geometric Angle (System.Units.Angle)](#geometric-angle-systemunitsangle)
  - [Electrical Conductance (System.Units.Conductance)](#electrical-conductance-systemunitsconductance)
  - [Electrical Current (System.Units.Current)](#electrical-current-systemunitscurrent)
  - [Electrical Potential (System.Units.ElectricPotential)](#electrical-potential-systemunitselectricpotential)
  - [Energy (System.Units.Energy)](#energy-systemunitsenergy)
  - [Force (System.Units.Force)](#force-systemunitsforce)
  - [Frequency (System.Units.Frequency)](#frequency-systemunitsfrequency)
  - [Length (System.Units.Length)](#length-systemunitslength)
  - [Luminosity (System.Units.Luminosity)](#luminosity-systemunitsluminosity)
  - [Magnetic Flux Density (System.Units.MagneticFlux)](#magnetic-flux-density-systemunitsmagneticflux)
  - [Mass (System.Units.Mass)](#mass-systemunitsmass)
  - [Power (System.Units.Power)](#power-systemunitspower)
  - [Pressure (System.Units.Pressure)](#pressure-systemunitspressure)
  - [Electrical Resistance (System.Units.Resistance)](#electrical-resistance-systemunitsresistance)
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
# Predefined Constants
All constants are stored in the `System.Units.Constants` static object and can be accessed with dereferencing by name such as `System.Units.Constants.GravitationalConstant`. Each constant is stored as a Quantity of type double with the appropriate units of measure. 

## Physical Constants
| Constant | Symbol | Value | Type |
|----------|--------|-------|------|
| Atomic Mass Unit | u | 1.660538782e-27 kg | Quantity\<double, KiloGram\> |
| AvogadroNumber | N<sub>A</sub> | 6.02214179e23 particles/mol | Quantity\<double, ParticlesPerMol\> | 
| Bohr Magneton | &#956;<sub>B</sub> | 9.27400915e-24 J/T | Quantity\<double, JoulePerTesla\> |
| Bohr Radius | a<sub>0</sub> | 5.2917720859e-11 m | Quantity\<double, Metre\> |
| Compton Wavelength | &#955;<sub>C</sub> | 2.4263102175e-12 m | Quantity\<double, Metre\> |
| Deuteron Mass | m<sub>d</sub> | 3.34358320e-27 kg | Quantity\<double, KiloGram\> |
| Electron Mass | m<sub>e</sub> | 9.10938215e-31 kg | Quantity\<double, KiloGram\> |
| GravitationalConstant | G | 6.67428e-11 Nm<sup>2</sup>/kg<sup>2</sup> | Quantity\<double, NewtonMetreSqPerKiloGramSq\> | 
| Neutron Mass | m<sub>n</sub> | 1.674927211e-27 kg | Quantity\<double, KiloGram\> |
| Planck's Constant | h | 6.62606896e-34 Js | Quantity\<double, JouleSecond\> |
| Proton Mass | m<sub>p</sub> | 1.672621637e-27 kg | Quantity\<double, KiloGram\> |
| Speed of Light in a Vacuum | c | 2.99792458e8 m/s | Quantity\<double, MetrePerSecond\> |
| Standard Atmospheric Pressure | | 1.013e5 Pa | Quantity\<double, Pascal\> |

## Solar System Data
| Constant | Value | Type |
|----------|-------|------|
| Average Earth-Moon Distance | 3.84e8 m | Quantity\<double, Metre\> |
| Average Earth-Sun Distance | 1.496e11 m | Quantity\<double, Metre\> |
| Mercury Mass | 3.30e23 kg | Quantity\<double, KiloGram\> |
| Mercury Mean Radius | 2.44e6 m | Quantity\<double, Metre\> |
| Mercury Orbital Period | 7.60e6 s | Quantity\<double, Second\> |
| Mercury Mean Distance From Sun | 5.79e10 m | Quantity\<double, Metre\> | 
| Venus Mass | 4.87e24 kg | Quantity\<double, KiloGram\> |
| Venus Mean Radius | 6.05e6 m | Quantity\<double, Metre\> |
| Venus Orbital Period | 1.94e7 s | Quantity\<double, Second\> |
| Venus Mean Distance From Sun | 1.08e11 m | Quantity\<double, Metre\> | 
| Earth Mass | 5.97e24 kg | Quantity\<double, KiloGram\> |
| Earth Mean Radius | 6.37e6 m | Quantity\<double, Metre\> |
| Earth Orbital Period | 3.156e7 s | Quantity\<double, Second\> |
| Earth Mean Distance From Sun | 1.496e11 m | Quantity\<double, Metre\> | 
| Mars Mass | 6.42e23 kg | Quantity\<double, KiloGram\> |
| Mars Mean Radius | 3.39e6 m | Quantity\<double, Metre\> |
| Mars Orbital Period | 5.94e7 s | Quantity\<double, Second\> |
| Mars Mean Distance From Sun | 2.28e11 m | Quantity\<double, Metre\> | 
| Jupiter Mass | 1.90e27 kg | Quantity\<double, KiloGram\> |
| Jupiter Mean Radius | 6.99e7 m | Quantity\<double, Metre\> |
| Jupiter Orbital Period | 3.74e8 s | Quantity\<double, Second\> |
| Jupiter Mean Distance From Sun | 7.78e11 m | Quantity\<double, Metre\> | 
| Saturn Mass | 5.68e26 kg | Quantity\<double, KiloGram\> |
| Saturn Mean Radius | 5.82e7 m | Quantity\<double, Metre\> |
| Saturn Orbital Period | 9.29e8 s | Quantity\<double, Second\> |
| Saturn Mean Distance From Sun | 1.43e12 m | Quantity\<double, Metre\> |
| Uranus Mass | 8.68e25 kg | Quantity\<double, KiloGram\> |
| Uranus Mean Radius | 2.54e7 m | Quantity\<double, Metre\> |
| Uranus Orbital Period | 2.65e9 s | Quantity\<double, Second\> |
| Uranus Mean Distance From Sun | 2.87e12 m | Quantity\<double, Metre\> |
| Neptune Mass | 1.02e26 kg | Quantity\<double, KiloGram\> |
| Neptune Mean Radius | 2.46e7 m | Quantity\<double, Metre\> |
| Neptune Orbital Period | 5.18e9 s | Quantity\<double, Second\> |
| Neptune Mean Distance From Sun | 4.50e12 m | Quantity\<double, Metre\> |
| Neptune Mass | 1.02e26 kg | Quantity\<double, KiloGram\> |
| Neptune Mean Radius | 2.46e7 m | Quantity\<double, Metre\> |
| Moon Mass | 7.35e22 kg | Quantity\<double, KiloGram\> |
| Moon Mean Radius | 1.74e6 m | Quantity\<double, Metre\> |
| Moon Mean Distance From Earth | 384400 m | Quantity\<double, Metre\> |
| Sun Mass | 1.989e30 kg | Quantity\<double, KiloGram\> |
| Sun Mean Radius | 6.96e8 m | Quantity\<double, Metre\> |

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
| G | g |

## Amount Of Substance (System.Units.Amount)
| Name | Symbol |
|------|--------|
| Mole | mol |

## Geometric Angle (System.Units.Angle)
| Name | Symbol |
|------|--------|
| Degrees | ° |
| Radians | rad |

## Electrical Conductance (System.Units.Conductance)
| Name | Symbol |
|------|--------|
| Siemen | ℧ |
| YottaSiemen | Y℧ |
| ZettaSiemen | Z℧ |
| ExaSiemen | E℧ |
| PetaSiemen | P℧ |
| TeraSiemen | T℧ |
| GigaSiemen | G℧ |
| MegaSiemen | M℧ |
| KiloSiemen | k℧ |
| HectoSiemen | h℧ |
| DekaSiemen | da℧ |
| DeciSiemen | d℧ |
| CentiSiemen | c℧ |
| MilliSiemen | m℧ |
| MicroSiemen | u℧ |
| NanoSiemen | n℧ |
| PicoSiemen | p℧ |
| FemtoSiemen | f℧ |
| AttoSiemen | a℧ |
| ZeptoSiemen | z℧ |
| YoctoSiemen | y℧ |

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

## Electrical Potential (System.Units.ElectricPotential)
| Name | Symbol |
|------|--------|
| Volt | V |
| YottaVolt | YV |
| ZettaVolt | ZV |
| ExaVolt | EV |
| PetaVolt | PV |
| TeraVolt | TV |
| GigaVolt | GV |
| MegaVolt | MV |
| KiloVolt | kV |
| HectoVolt | hV |
| DekaVolt | daV |
| DeciVolt | dV |
| CentiVolt | cV |
| MilliVolt | mV |
| MicroVolt | uV |
| NanoVolt | nV |
| PicoVolt | pV |
| FemtoVolt | fV |
| AttoVolt | aV |
| ZeptoVolt | zV |
| YoctoVolt | yV |

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

## Frequency (System.Units.Frequency)
| Name | Symbol |
|------|--------|
| Hertz | Hz |
| YottaHertz | YHz |
| ZettaHertz | ZHz |
| ExaHertz | EHz |
| PetaHertz | PHz |
| TeraHertz | THz |
| GigaHertz | GHz |
| MegaHertz | MHz |
| KiloHertz | kHz |
| HectoHertz | hHz |
| DekaHertz | daHz |
| DeciHertz | dHz |
| CentiHertz | cHz |
| MilliHertz | mHz |
| MicroHertz | uHz |
| NanoHertz | nHz |
| PicoHertz | pHz |
| FemtoHertz | fHz |
| AttoHertz | aHz |
| ZeptoHertz | zHz |
| YoctoHertz | yHz |

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
| Mile | mi |
| Inch | " |
| Foot | ft |
| Yard | yd |
| League | lea |

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

## Magnetic Flux Density (System.Units.MagneticFlux)
| Name | Symbol |
|------|--------|
| Tesla | T |
| YottaTesla | YT |
| ZettaTesla | ZT |
| ExaTesla | ET |
| PetaTesla | PT |
| TeraTesla | TT |
| GigaTesla | GT |
| MegaTesla | MT |
| KiloTesla | kT |
| HectoTesla | hT |
| DekaTesla | daT |
| DeciTesla | dT |
| CentiTesla | cT |
| MilliTesla | mT |
| MicroTesla | uT |
| NanoTesla | nT |
| PicoTesla | pT |
| FemtoTesla | fT |
| AttoTesla | aT |
| ZeptoTesla | zT |
| YoctoTesla | yT |

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
| Bar | bar |
| YottaBar | Ybar |
| ZettaBar | Zbar |
| ExaBar | Ebar |
| PetaBar | Pbar |
| TeraBar | Tbar |
| GigaBar | Gbar |
| MegaBar | Mbar |
| KiloBar | kbar |
| HectoBar | hbar |
| DekaBar | dabar |
| DeciBar | dbar |
| CentiBar | cbar |
| MilliBar | mbar |
| MicroBar | ubar |
| NanoBar | nbar |
| PicoBar | pbar |
| FemtoBar | fbar |
| AttoBar | abar |
| ZeptoBar | zbar |
| YoctoBar | ybar |

## Electrical Resistance (System.Units.Resistance)
| Name | Symbol |
|------|--------|
| Ohm | Ω |
| YottaOhm | YΩ |
| ZettaOhm | ZΩ |
| ExaOhm | EΩ |
| PetaOhm | PΩ |
| TeraOhm | TΩ |
| GigaOhm | GΩ |
| MegaOhm | MΩ |
| KiloOhm | kΩ |
| HectoOhm | hΩ |
| DekaOhm | daΩ |
| DeciOhm | dΩ |
| CentiOhm | cΩ |
| MilliOhm | mΩ |
| MicroOhm | uΩ |
| NanoOhm | nΩ |
| PicoOhm | pΩ |
| FemtoOhm | fΩ |
| AttoOhm | aΩ |
| ZeptoOhm | zΩ |
| YoctoOhm | yΩ |

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
| Sidereal Day | sday |
| Year | yr |
| Sidereal Year | syr |

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