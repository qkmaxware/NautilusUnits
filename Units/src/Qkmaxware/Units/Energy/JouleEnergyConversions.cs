using System;
namespace Qkmaxware.Units.Energy {
/// <summary>
/// Static class housing si-prefix conversions for the unit "JouleEnergy"
/// </summary>
public static class JouleEnergyConversions {
	/// <summary>
    /// Extension method to convert Joule to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this BaseQuantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to Joule
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in Joule</returns>
	public static Quantity<double, Joule> ToJoule<T>(this BaseQuantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, Joule>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Joule to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this BaseQuantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to Joule
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in Joule</returns>
	public static Quantity<double, Joule> ToJoule<T>(this BaseQuantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, Joule>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Joule to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this BaseQuantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to Joule
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in Joule</returns>
	public static Quantity<double, Joule> ToJoule<T>(this BaseQuantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, Joule>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Joule to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this BaseQuantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to Joule
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in Joule</returns>
	public static Quantity<double, Joule> ToJoule<T>(this BaseQuantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, Joule>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Joule to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this BaseQuantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to Joule
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in Joule</returns>
	public static Quantity<double, Joule> ToJoule<T>(this BaseQuantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, Joule>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Joule to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this BaseQuantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to Joule
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in Joule</returns>
	public static Quantity<double, Joule> ToJoule<T>(this BaseQuantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, Joule>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Joule to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this BaseQuantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to Joule
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in Joule</returns>
	public static Quantity<double, Joule> ToJoule<T>(this BaseQuantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, Joule>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Joule to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this BaseQuantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to Joule
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in Joule</returns>
	public static Quantity<double, Joule> ToJoule<T>(this BaseQuantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, Joule>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Joule to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this BaseQuantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to Joule
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in Joule</returns>
	public static Quantity<double, Joule> ToJoule<T>(this BaseQuantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, Joule>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Joule to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this BaseQuantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to Joule
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in Joule</returns>
	public static Quantity<double, Joule> ToJoule<T>(this BaseQuantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, Joule>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Joule to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this BaseQuantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to Joule
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in Joule</returns>
	public static Quantity<double, Joule> ToJoule<T>(this BaseQuantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, Joule>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Joule to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this BaseQuantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to Joule
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in Joule</returns>
	public static Quantity<double, Joule> ToJoule<T>(this BaseQuantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, Joule>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Joule to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this BaseQuantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to Joule
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in Joule</returns>
	public static Quantity<double, Joule> ToJoule<T>(this BaseQuantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, Joule>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Joule to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this BaseQuantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to Joule
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in Joule</returns>
	public static Quantity<double, Joule> ToJoule<T>(this BaseQuantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, Joule>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Joule to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this BaseQuantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to Joule
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in Joule</returns>
	public static Quantity<double, Joule> ToJoule<T>(this BaseQuantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, Joule>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Joule to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this BaseQuantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to Joule
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in Joule</returns>
	public static Quantity<double, Joule> ToJoule<T>(this BaseQuantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, Joule>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Joule to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this BaseQuantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to Joule
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in Joule</returns>
	public static Quantity<double, Joule> ToJoule<T>(this BaseQuantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, Joule>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Joule to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this BaseQuantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to Joule
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in Joule</returns>
	public static Quantity<double, Joule> ToJoule<T>(this BaseQuantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, Joule>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Joule to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this BaseQuantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to Joule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in Joule</returns>
	public static Quantity<double, Joule> ToJoule<T>(this BaseQuantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, Joule>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Joule to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this BaseQuantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to Joule
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in Joule</returns>
	public static Quantity<double, Joule> ToJoule<T>(this BaseQuantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, Joule>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this BaseQuantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this BaseQuantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this BaseQuantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this BaseQuantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this BaseQuantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this BaseQuantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this BaseQuantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this BaseQuantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this BaseQuantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this BaseQuantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this BaseQuantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this BaseQuantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this BaseQuantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this BaseQuantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this BaseQuantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this BaseQuantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this BaseQuantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this BaseQuantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaJoule to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in YottaJoule</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this BaseQuantity<T, YottaJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this BaseQuantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this BaseQuantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this BaseQuantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this BaseQuantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this BaseQuantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this BaseQuantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this BaseQuantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this BaseQuantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this BaseQuantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this BaseQuantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this BaseQuantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this BaseQuantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this BaseQuantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this BaseQuantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this BaseQuantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this BaseQuantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this BaseQuantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this BaseQuantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaJoule to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZettaJoule</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this BaseQuantity<T, ZettaJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this BaseQuantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this BaseQuantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this BaseQuantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this BaseQuantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this BaseQuantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this BaseQuantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this BaseQuantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this BaseQuantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this BaseQuantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this BaseQuantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this BaseQuantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this BaseQuantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this BaseQuantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this BaseQuantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this BaseQuantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this BaseQuantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this BaseQuantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this BaseQuantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaJoule to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in ExaJoule</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this BaseQuantity<T, ExaJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this BaseQuantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this BaseQuantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this BaseQuantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this BaseQuantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this BaseQuantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this BaseQuantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this BaseQuantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this BaseQuantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this BaseQuantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this BaseQuantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this BaseQuantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this BaseQuantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this BaseQuantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this BaseQuantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this BaseQuantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this BaseQuantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this BaseQuantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this BaseQuantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaJoule to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in PetaJoule</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this BaseQuantity<T, PetaJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this BaseQuantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this BaseQuantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this BaseQuantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this BaseQuantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this BaseQuantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this BaseQuantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this BaseQuantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this BaseQuantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this BaseQuantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this BaseQuantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this BaseQuantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this BaseQuantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this BaseQuantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this BaseQuantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this BaseQuantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this BaseQuantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this BaseQuantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this BaseQuantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraJoule to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in TeraJoule</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this BaseQuantity<T, TeraJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this BaseQuantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this BaseQuantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this BaseQuantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this BaseQuantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this BaseQuantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this BaseQuantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this BaseQuantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this BaseQuantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this BaseQuantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this BaseQuantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this BaseQuantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this BaseQuantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this BaseQuantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this BaseQuantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this BaseQuantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this BaseQuantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this BaseQuantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this BaseQuantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaJoule to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in GigaJoule</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this BaseQuantity<T, GigaJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this BaseQuantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this BaseQuantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this BaseQuantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this BaseQuantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this BaseQuantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this BaseQuantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this BaseQuantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this BaseQuantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this BaseQuantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this BaseQuantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this BaseQuantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this BaseQuantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this BaseQuantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this BaseQuantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this BaseQuantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this BaseQuantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this BaseQuantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this BaseQuantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaJoule to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in MegaJoule</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this BaseQuantity<T, MegaJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this BaseQuantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this BaseQuantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this BaseQuantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this BaseQuantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this BaseQuantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this BaseQuantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this BaseQuantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this BaseQuantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this BaseQuantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this BaseQuantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this BaseQuantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this BaseQuantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this BaseQuantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this BaseQuantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this BaseQuantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this BaseQuantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this BaseQuantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this BaseQuantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloJoule to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in KiloJoule</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this BaseQuantity<T, KiloJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this BaseQuantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this BaseQuantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this BaseQuantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this BaseQuantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this BaseQuantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this BaseQuantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this BaseQuantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this BaseQuantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this BaseQuantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this BaseQuantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this BaseQuantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this BaseQuantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this BaseQuantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this BaseQuantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this BaseQuantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this BaseQuantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this BaseQuantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this BaseQuantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoJoule to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in HectoJoule</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this BaseQuantity<T, HectoJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this BaseQuantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this BaseQuantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this BaseQuantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this BaseQuantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this BaseQuantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this BaseQuantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this BaseQuantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this BaseQuantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this BaseQuantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this BaseQuantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this BaseQuantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this BaseQuantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this BaseQuantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this BaseQuantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this BaseQuantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this BaseQuantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this BaseQuantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this BaseQuantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaJoule to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in DekaJoule</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this BaseQuantity<T, DekaJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this BaseQuantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this BaseQuantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this BaseQuantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this BaseQuantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this BaseQuantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this BaseQuantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this BaseQuantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this BaseQuantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this BaseQuantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this BaseQuantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this BaseQuantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this BaseQuantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this BaseQuantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this BaseQuantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this BaseQuantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this BaseQuantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this BaseQuantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this BaseQuantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciJoule to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in DeciJoule</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this BaseQuantity<T, DeciJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this BaseQuantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this BaseQuantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this BaseQuantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this BaseQuantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this BaseQuantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this BaseQuantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this BaseQuantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this BaseQuantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this BaseQuantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this BaseQuantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this BaseQuantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this BaseQuantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this BaseQuantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this BaseQuantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this BaseQuantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this BaseQuantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this BaseQuantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this BaseQuantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiJoule to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in CentiJoule</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this BaseQuantity<T, CentiJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this BaseQuantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this BaseQuantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this BaseQuantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this BaseQuantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this BaseQuantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this BaseQuantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this BaseQuantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this BaseQuantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this BaseQuantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this BaseQuantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this BaseQuantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this BaseQuantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this BaseQuantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this BaseQuantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this BaseQuantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this BaseQuantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this BaseQuantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this BaseQuantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliJoule to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in MilliJoule</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this BaseQuantity<T, MilliJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this BaseQuantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this BaseQuantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this BaseQuantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this BaseQuantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this BaseQuantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this BaseQuantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this BaseQuantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this BaseQuantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this BaseQuantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this BaseQuantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this BaseQuantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this BaseQuantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this BaseQuantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this BaseQuantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this BaseQuantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this BaseQuantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this BaseQuantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this BaseQuantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroJoule to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in MicroJoule</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this BaseQuantity<T, MicroJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this BaseQuantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this BaseQuantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this BaseQuantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this BaseQuantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this BaseQuantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this BaseQuantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this BaseQuantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this BaseQuantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this BaseQuantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this BaseQuantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this BaseQuantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this BaseQuantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this BaseQuantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this BaseQuantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this BaseQuantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this BaseQuantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this BaseQuantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this BaseQuantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoJoule to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in NanoJoule</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this BaseQuantity<T, NanoJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this BaseQuantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this BaseQuantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this BaseQuantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this BaseQuantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this BaseQuantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this BaseQuantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this BaseQuantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this BaseQuantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this BaseQuantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this BaseQuantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this BaseQuantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this BaseQuantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this BaseQuantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this BaseQuantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this BaseQuantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this BaseQuantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this BaseQuantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this BaseQuantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoJoule to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in PicoJoule</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this BaseQuantity<T, PicoJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this BaseQuantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this BaseQuantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this BaseQuantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this BaseQuantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this BaseQuantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this BaseQuantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this BaseQuantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this BaseQuantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this BaseQuantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this BaseQuantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this BaseQuantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this BaseQuantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this BaseQuantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this BaseQuantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this BaseQuantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this BaseQuantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this BaseQuantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this BaseQuantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoJoule to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in FemtoJoule</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this BaseQuantity<T, FemtoJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this BaseQuantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this BaseQuantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this BaseQuantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this BaseQuantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this BaseQuantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this BaseQuantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this BaseQuantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this BaseQuantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this BaseQuantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this BaseQuantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this BaseQuantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this BaseQuantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this BaseQuantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this BaseQuantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this BaseQuantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this BaseQuantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this BaseQuantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this BaseQuantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoJoule to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in AttoJoule</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this BaseQuantity<T, AttoJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this BaseQuantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this BaseQuantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this BaseQuantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this BaseQuantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this BaseQuantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this BaseQuantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this BaseQuantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this BaseQuantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this BaseQuantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this BaseQuantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this BaseQuantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this BaseQuantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this BaseQuantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this BaseQuantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this BaseQuantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this BaseQuantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this BaseQuantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this BaseQuantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoJoule to YoctoJoule
    /// </summary>
    /// <param name="val">quantity measured in ZeptoJoule</param>
    /// <returns>quantity measured in YoctoJoule</returns>
	public static Quantity<double, YoctoJoule> ToYoctoJoule<T>(this BaseQuantity<T, ZeptoJoule> val) where T:IConvertible {
        return new Quantity<double, YoctoJoule>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to YottaJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in YottaJoule</returns>
	public static Quantity<double, YottaJoule> ToYottaJoule<T>(this BaseQuantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, YottaJoule>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to ZettaJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in ZettaJoule</returns>
	public static Quantity<double, ZettaJoule> ToZettaJoule<T>(this BaseQuantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, ZettaJoule>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to ExaJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in ExaJoule</returns>
	public static Quantity<double, ExaJoule> ToExaJoule<T>(this BaseQuantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, ExaJoule>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to PetaJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in PetaJoule</returns>
	public static Quantity<double, PetaJoule> ToPetaJoule<T>(this BaseQuantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, PetaJoule>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to TeraJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in TeraJoule</returns>
	public static Quantity<double, TeraJoule> ToTeraJoule<T>(this BaseQuantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, TeraJoule>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to GigaJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in GigaJoule</returns>
	public static Quantity<double, GigaJoule> ToGigaJoule<T>(this BaseQuantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, GigaJoule>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to MegaJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in MegaJoule</returns>
	public static Quantity<double, MegaJoule> ToMegaJoule<T>(this BaseQuantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, MegaJoule>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to KiloJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in KiloJoule</returns>
	public static Quantity<double, KiloJoule> ToKiloJoule<T>(this BaseQuantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, KiloJoule>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to HectoJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in HectoJoule</returns>
	public static Quantity<double, HectoJoule> ToHectoJoule<T>(this BaseQuantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, HectoJoule>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to DekaJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in DekaJoule</returns>
	public static Quantity<double, DekaJoule> ToDekaJoule<T>(this BaseQuantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, DekaJoule>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to DeciJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in DeciJoule</returns>
	public static Quantity<double, DeciJoule> ToDeciJoule<T>(this BaseQuantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, DeciJoule>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to CentiJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in CentiJoule</returns>
	public static Quantity<double, CentiJoule> ToCentiJoule<T>(this BaseQuantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, CentiJoule>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to MilliJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in MilliJoule</returns>
	public static Quantity<double, MilliJoule> ToMilliJoule<T>(this BaseQuantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, MilliJoule>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to MicroJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in MicroJoule</returns>
	public static Quantity<double, MicroJoule> ToMicroJoule<T>(this BaseQuantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, MicroJoule>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to NanoJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in NanoJoule</returns>
	public static Quantity<double, NanoJoule> ToNanoJoule<T>(this BaseQuantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, NanoJoule>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to PicoJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in PicoJoule</returns>
	public static Quantity<double, PicoJoule> ToPicoJoule<T>(this BaseQuantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, PicoJoule>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to FemtoJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in FemtoJoule</returns>
	public static Quantity<double, FemtoJoule> ToFemtoJoule<T>(this BaseQuantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, FemtoJoule>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to AttoJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in AttoJoule</returns>
	public static Quantity<double, AttoJoule> ToAttoJoule<T>(this BaseQuantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, AttoJoule>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoJoule to ZeptoJoule
    /// </summary>
    /// <param name="val">quantity measured in YoctoJoule</param>
    /// <returns>quantity measured in ZeptoJoule</returns>
	public static Quantity<double, ZeptoJoule> ToZeptoJoule<T>(this BaseQuantity<T, YoctoJoule> val) where T:IConvertible {
        return new Quantity<double, ZeptoJoule>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
}
}