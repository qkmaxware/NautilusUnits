using System;

namespace System.Units.Energy {
public static class JouleToElectronvoltConversionsConversions {
	/// <summary>
    /// Extension method to convert Joule to Electronvolt
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in Electronvolt</returns>
	public static Quantity<double, Electronvolt> ToElectronvolt<T>(this Quantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, Electronvolt>(
            Convert.ToDouble(val.Value) * (6.241509E+18)
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to Joule
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in Joule</returns>
	public static Quantity<double, Joule> ToJoule<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, Joule>(
            Convert.ToDouble(val.Value) * (1.0/(6.241509E+18))
        );
    }
	/// <summary>
    /// Extension method to convert Joule to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * 1E-24)
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * 1E-24)
        );
    }
	/// <summary>
    /// Extension method to convert Joule to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * 1E-21)
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * 1E-21)
        );
    }
	/// <summary>
    /// Extension method to convert Joule to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * 1E-18)
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * 1E-18)
        );
    }
	/// <summary>
    /// Extension method to convert Joule to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * 1E-15)
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * 1E-15)
        );
    }
	/// <summary>
    /// Extension method to convert Joule to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * 1E-12)
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * 1E-12)
        );
    }
	/// <summary>
    /// Extension method to convert Joule to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * 1E-9)
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * 1E-9)
        );
    }
	/// <summary>
    /// Extension method to convert Joule to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * 1E-6)
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * 1E-6)
        );
    }
	/// <summary>
    /// Extension method to convert Joule to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * 1E-3)
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * 1E-3)
        );
    }
	/// <summary>
    /// Extension method to convert Joule to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * 1E-2)
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * 1E-2)
        );
    }
	/// <summary>
    /// Extension method to convert Joule to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * 1E-1)
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * 1E-1)
        );
    }
	/// <summary>
    /// Extension method to convert Joule to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * 1E1)
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * 1E1)
        );
    }
	/// <summary>
    /// Extension method to convert Joule to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * 1E2)
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * 1E2)
        );
    }
	/// <summary>
    /// Extension method to convert Joule to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * 1E3)
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * 1E3)
        );
    }
	/// <summary>
    /// Extension method to convert Joule to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * 1E6)
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * 1E6)
        );
    }
	/// <summary>
    /// Extension method to convert Joule to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * 1E9)
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * 1E9)
        );
    }
	/// <summary>
    /// Extension method to convert Joule to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * 1E12)
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * 1E12)
        );
    }
	/// <summary>
    /// Extension method to convert Joule to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * 1E15)
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * 1E15)
        );
    }
	/// <summary>
    /// Extension method to convert Joule to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * 1E18)
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * 1E18)
        );
    }
	/// <summary>
    /// Extension method to convert Joule to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * 1E21)
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * 1E21)
        );
    }
	/// <summary>
    /// Extension method to convert Joule to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * 1E24)
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * 1E24)
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * ((6.241509E+18) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * ((1.0/(6.241509E+18)) * (1E24))
        );
    }
}
}