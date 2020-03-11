using System;
namespace System.Units.Frequency {
/// <summary>
/// Static class housing si-prefix conversions for the unit "Hertz"
/// </summary>
public static class FrequencyConversions {
	/// <summary>
    /// Extension method to convert Hertz to YottaHertz
    /// </summary>
    /// <param name="val">quantity measured in Hertz</param>
    /// <returns>quantity measured in YottaHertz</returns>
	public static Quantity<double, YottaHertz> ToYottaHertz<T>(this BaseQuantity<T, Hertz> val) where T:IConvertible {
        return new Quantity<double, YottaHertz>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Hertz to ZettaHertz
    /// </summary>
    /// <param name="val">quantity measured in Hertz</param>
    /// <returns>quantity measured in ZettaHertz</returns>
	public static Quantity<double, ZettaHertz> ToZettaHertz<T>(this BaseQuantity<T, Hertz> val) where T:IConvertible {
        return new Quantity<double, ZettaHertz>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Hertz to ExaHertz
    /// </summary>
    /// <param name="val">quantity measured in Hertz</param>
    /// <returns>quantity measured in ExaHertz</returns>
	public static Quantity<double, ExaHertz> ToExaHertz<T>(this BaseQuantity<T, Hertz> val) where T:IConvertible {
        return new Quantity<double, ExaHertz>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Hertz to PetaHertz
    /// </summary>
    /// <param name="val">quantity measured in Hertz</param>
    /// <returns>quantity measured in PetaHertz</returns>
	public static Quantity<double, PetaHertz> ToPetaHertz<T>(this BaseQuantity<T, Hertz> val) where T:IConvertible {
        return new Quantity<double, PetaHertz>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Hertz to TeraHertz
    /// </summary>
    /// <param name="val">quantity measured in Hertz</param>
    /// <returns>quantity measured in TeraHertz</returns>
	public static Quantity<double, TeraHertz> ToTeraHertz<T>(this BaseQuantity<T, Hertz> val) where T:IConvertible {
        return new Quantity<double, TeraHertz>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Hertz to GigaHertz
    /// </summary>
    /// <param name="val">quantity measured in Hertz</param>
    /// <returns>quantity measured in GigaHertz</returns>
	public static Quantity<double, GigaHertz> ToGigaHertz<T>(this BaseQuantity<T, Hertz> val) where T:IConvertible {
        return new Quantity<double, GigaHertz>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Hertz to MegaHertz
    /// </summary>
    /// <param name="val">quantity measured in Hertz</param>
    /// <returns>quantity measured in MegaHertz</returns>
	public static Quantity<double, MegaHertz> ToMegaHertz<T>(this BaseQuantity<T, Hertz> val) where T:IConvertible {
        return new Quantity<double, MegaHertz>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Hertz to KiloHertz
    /// </summary>
    /// <param name="val">quantity measured in Hertz</param>
    /// <returns>quantity measured in KiloHertz</returns>
	public static Quantity<double, KiloHertz> ToKiloHertz<T>(this BaseQuantity<T, Hertz> val) where T:IConvertible {
        return new Quantity<double, KiloHertz>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Hertz to HectoHertz
    /// </summary>
    /// <param name="val">quantity measured in Hertz</param>
    /// <returns>quantity measured in HectoHertz</returns>
	public static Quantity<double, HectoHertz> ToHectoHertz<T>(this BaseQuantity<T, Hertz> val) where T:IConvertible {
        return new Quantity<double, HectoHertz>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hertz to DekaHertz
    /// </summary>
    /// <param name="val">quantity measured in Hertz</param>
    /// <returns>quantity measured in DekaHertz</returns>
	public static Quantity<double, DekaHertz> ToDekaHertz<T>(this BaseQuantity<T, Hertz> val) where T:IConvertible {
        return new Quantity<double, DekaHertz>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Hertz to DeciHertz
    /// </summary>
    /// <param name="val">quantity measured in Hertz</param>
    /// <returns>quantity measured in DeciHertz</returns>
	public static Quantity<double, DeciHertz> ToDeciHertz<T>(this BaseQuantity<T, Hertz> val) where T:IConvertible {
        return new Quantity<double, DeciHertz>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Hertz to CentiHertz
    /// </summary>
    /// <param name="val">quantity measured in Hertz</param>
    /// <returns>quantity measured in CentiHertz</returns>
	public static Quantity<double, CentiHertz> ToCentiHertz<T>(this BaseQuantity<T, Hertz> val) where T:IConvertible {
        return new Quantity<double, CentiHertz>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Hertz to MilliHertz
    /// </summary>
    /// <param name="val">quantity measured in Hertz</param>
    /// <returns>quantity measured in MilliHertz</returns>
	public static Quantity<double, MilliHertz> ToMilliHertz<T>(this BaseQuantity<T, Hertz> val) where T:IConvertible {
        return new Quantity<double, MilliHertz>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Hertz to MicroHertz
    /// </summary>
    /// <param name="val">quantity measured in Hertz</param>
    /// <returns>quantity measured in MicroHertz</returns>
	public static Quantity<double, MicroHertz> ToMicroHertz<T>(this BaseQuantity<T, Hertz> val) where T:IConvertible {
        return new Quantity<double, MicroHertz>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Hertz to NanoHertz
    /// </summary>
    /// <param name="val">quantity measured in Hertz</param>
    /// <returns>quantity measured in NanoHertz</returns>
	public static Quantity<double, NanoHertz> ToNanoHertz<T>(this BaseQuantity<T, Hertz> val) where T:IConvertible {
        return new Quantity<double, NanoHertz>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Hertz to PicoHertz
    /// </summary>
    /// <param name="val">quantity measured in Hertz</param>
    /// <returns>quantity measured in PicoHertz</returns>
	public static Quantity<double, PicoHertz> ToPicoHertz<T>(this BaseQuantity<T, Hertz> val) where T:IConvertible {
        return new Quantity<double, PicoHertz>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Hertz to FemtoHertz
    /// </summary>
    /// <param name="val">quantity measured in Hertz</param>
    /// <returns>quantity measured in FemtoHertz</returns>
	public static Quantity<double, FemtoHertz> ToFemtoHertz<T>(this BaseQuantity<T, Hertz> val) where T:IConvertible {
        return new Quantity<double, FemtoHertz>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Hertz to AttoHertz
    /// </summary>
    /// <param name="val">quantity measured in Hertz</param>
    /// <returns>quantity measured in AttoHertz</returns>
	public static Quantity<double, AttoHertz> ToAttoHertz<T>(this BaseQuantity<T, Hertz> val) where T:IConvertible {
        return new Quantity<double, AttoHertz>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Hertz to ZeptoHertz
    /// </summary>
    /// <param name="val">quantity measured in Hertz</param>
    /// <returns>quantity measured in ZeptoHertz</returns>
	public static Quantity<double, ZeptoHertz> ToZeptoHertz<T>(this BaseQuantity<T, Hertz> val) where T:IConvertible {
        return new Quantity<double, ZeptoHertz>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Hertz to YoctoHertz
    /// </summary>
    /// <param name="val">quantity measured in Hertz</param>
    /// <returns>quantity measured in YoctoHertz</returns>
	public static Quantity<double, YoctoHertz> ToYoctoHertz<T>(this BaseQuantity<T, Hertz> val) where T:IConvertible {
        return new Quantity<double, YoctoHertz>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YottaHertz to ZettaHertz
    /// </summary>
    /// <param name="val">quantity measured in YottaHertz</param>
    /// <returns>quantity measured in ZettaHertz</returns>
	public static Quantity<double, ZettaHertz> ToZettaHertz<T>(this BaseQuantity<T, YottaHertz> val) where T:IConvertible {
        return new Quantity<double, ZettaHertz>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaHertz to ExaHertz
    /// </summary>
    /// <param name="val">quantity measured in YottaHertz</param>
    /// <returns>quantity measured in ExaHertz</returns>
	public static Quantity<double, ExaHertz> ToExaHertz<T>(this BaseQuantity<T, YottaHertz> val) where T:IConvertible {
        return new Quantity<double, ExaHertz>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaHertz to PetaHertz
    /// </summary>
    /// <param name="val">quantity measured in YottaHertz</param>
    /// <returns>quantity measured in PetaHertz</returns>
	public static Quantity<double, PetaHertz> ToPetaHertz<T>(this BaseQuantity<T, YottaHertz> val) where T:IConvertible {
        return new Quantity<double, PetaHertz>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaHertz to TeraHertz
    /// </summary>
    /// <param name="val">quantity measured in YottaHertz</param>
    /// <returns>quantity measured in TeraHertz</returns>
	public static Quantity<double, TeraHertz> ToTeraHertz<T>(this BaseQuantity<T, YottaHertz> val) where T:IConvertible {
        return new Quantity<double, TeraHertz>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaHertz to GigaHertz
    /// </summary>
    /// <param name="val">quantity measured in YottaHertz</param>
    /// <returns>quantity measured in GigaHertz</returns>
	public static Quantity<double, GigaHertz> ToGigaHertz<T>(this BaseQuantity<T, YottaHertz> val) where T:IConvertible {
        return new Quantity<double, GigaHertz>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaHertz to MegaHertz
    /// </summary>
    /// <param name="val">quantity measured in YottaHertz</param>
    /// <returns>quantity measured in MegaHertz</returns>
	public static Quantity<double, MegaHertz> ToMegaHertz<T>(this BaseQuantity<T, YottaHertz> val) where T:IConvertible {
        return new Quantity<double, MegaHertz>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaHertz to KiloHertz
    /// </summary>
    /// <param name="val">quantity measured in YottaHertz</param>
    /// <returns>quantity measured in KiloHertz</returns>
	public static Quantity<double, KiloHertz> ToKiloHertz<T>(this BaseQuantity<T, YottaHertz> val) where T:IConvertible {
        return new Quantity<double, KiloHertz>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaHertz to HectoHertz
    /// </summary>
    /// <param name="val">quantity measured in YottaHertz</param>
    /// <returns>quantity measured in HectoHertz</returns>
	public static Quantity<double, HectoHertz> ToHectoHertz<T>(this BaseQuantity<T, YottaHertz> val) where T:IConvertible {
        return new Quantity<double, HectoHertz>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaHertz to DekaHertz
    /// </summary>
    /// <param name="val">quantity measured in YottaHertz</param>
    /// <returns>quantity measured in DekaHertz</returns>
	public static Quantity<double, DekaHertz> ToDekaHertz<T>(this BaseQuantity<T, YottaHertz> val) where T:IConvertible {
        return new Quantity<double, DekaHertz>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaHertz to DeciHertz
    /// </summary>
    /// <param name="val">quantity measured in YottaHertz</param>
    /// <returns>quantity measured in DeciHertz</returns>
	public static Quantity<double, DeciHertz> ToDeciHertz<T>(this BaseQuantity<T, YottaHertz> val) where T:IConvertible {
        return new Quantity<double, DeciHertz>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaHertz to CentiHertz
    /// </summary>
    /// <param name="val">quantity measured in YottaHertz</param>
    /// <returns>quantity measured in CentiHertz</returns>
	public static Quantity<double, CentiHertz> ToCentiHertz<T>(this BaseQuantity<T, YottaHertz> val) where T:IConvertible {
        return new Quantity<double, CentiHertz>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaHertz to MilliHertz
    /// </summary>
    /// <param name="val">quantity measured in YottaHertz</param>
    /// <returns>quantity measured in MilliHertz</returns>
	public static Quantity<double, MilliHertz> ToMilliHertz<T>(this BaseQuantity<T, YottaHertz> val) where T:IConvertible {
        return new Quantity<double, MilliHertz>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaHertz to MicroHertz
    /// </summary>
    /// <param name="val">quantity measured in YottaHertz</param>
    /// <returns>quantity measured in MicroHertz</returns>
	public static Quantity<double, MicroHertz> ToMicroHertz<T>(this BaseQuantity<T, YottaHertz> val) where T:IConvertible {
        return new Quantity<double, MicroHertz>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaHertz to NanoHertz
    /// </summary>
    /// <param name="val">quantity measured in YottaHertz</param>
    /// <returns>quantity measured in NanoHertz</returns>
	public static Quantity<double, NanoHertz> ToNanoHertz<T>(this BaseQuantity<T, YottaHertz> val) where T:IConvertible {
        return new Quantity<double, NanoHertz>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaHertz to PicoHertz
    /// </summary>
    /// <param name="val">quantity measured in YottaHertz</param>
    /// <returns>quantity measured in PicoHertz</returns>
	public static Quantity<double, PicoHertz> ToPicoHertz<T>(this BaseQuantity<T, YottaHertz> val) where T:IConvertible {
        return new Quantity<double, PicoHertz>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaHertz to FemtoHertz
    /// </summary>
    /// <param name="val">quantity measured in YottaHertz</param>
    /// <returns>quantity measured in FemtoHertz</returns>
	public static Quantity<double, FemtoHertz> ToFemtoHertz<T>(this BaseQuantity<T, YottaHertz> val) where T:IConvertible {
        return new Quantity<double, FemtoHertz>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaHertz to AttoHertz
    /// </summary>
    /// <param name="val">quantity measured in YottaHertz</param>
    /// <returns>quantity measured in AttoHertz</returns>
	public static Quantity<double, AttoHertz> ToAttoHertz<T>(this BaseQuantity<T, YottaHertz> val) where T:IConvertible {
        return new Quantity<double, AttoHertz>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaHertz to ZeptoHertz
    /// </summary>
    /// <param name="val">quantity measured in YottaHertz</param>
    /// <returns>quantity measured in ZeptoHertz</returns>
	public static Quantity<double, ZeptoHertz> ToZeptoHertz<T>(this BaseQuantity<T, YottaHertz> val) where T:IConvertible {
        return new Quantity<double, ZeptoHertz>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaHertz to YoctoHertz
    /// </summary>
    /// <param name="val">quantity measured in YottaHertz</param>
    /// <returns>quantity measured in YoctoHertz</returns>
	public static Quantity<double, YoctoHertz> ToYoctoHertz<T>(this BaseQuantity<T, YottaHertz> val) where T:IConvertible {
        return new Quantity<double, YoctoHertz>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert ZettaHertz to YottaHertz
    /// </summary>
    /// <param name="val">quantity measured in ZettaHertz</param>
    /// <returns>quantity measured in YottaHertz</returns>
	public static Quantity<double, YottaHertz> ToYottaHertz<T>(this BaseQuantity<T, ZettaHertz> val) where T:IConvertible {
        return new Quantity<double, YottaHertz>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaHertz to ExaHertz
    /// </summary>
    /// <param name="val">quantity measured in ZettaHertz</param>
    /// <returns>quantity measured in ExaHertz</returns>
	public static Quantity<double, ExaHertz> ToExaHertz<T>(this BaseQuantity<T, ZettaHertz> val) where T:IConvertible {
        return new Quantity<double, ExaHertz>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaHertz to PetaHertz
    /// </summary>
    /// <param name="val">quantity measured in ZettaHertz</param>
    /// <returns>quantity measured in PetaHertz</returns>
	public static Quantity<double, PetaHertz> ToPetaHertz<T>(this BaseQuantity<T, ZettaHertz> val) where T:IConvertible {
        return new Quantity<double, PetaHertz>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaHertz to TeraHertz
    /// </summary>
    /// <param name="val">quantity measured in ZettaHertz</param>
    /// <returns>quantity measured in TeraHertz</returns>
	public static Quantity<double, TeraHertz> ToTeraHertz<T>(this BaseQuantity<T, ZettaHertz> val) where T:IConvertible {
        return new Quantity<double, TeraHertz>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaHertz to GigaHertz
    /// </summary>
    /// <param name="val">quantity measured in ZettaHertz</param>
    /// <returns>quantity measured in GigaHertz</returns>
	public static Quantity<double, GigaHertz> ToGigaHertz<T>(this BaseQuantity<T, ZettaHertz> val) where T:IConvertible {
        return new Quantity<double, GigaHertz>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaHertz to MegaHertz
    /// </summary>
    /// <param name="val">quantity measured in ZettaHertz</param>
    /// <returns>quantity measured in MegaHertz</returns>
	public static Quantity<double, MegaHertz> ToMegaHertz<T>(this BaseQuantity<T, ZettaHertz> val) where T:IConvertible {
        return new Quantity<double, MegaHertz>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaHertz to KiloHertz
    /// </summary>
    /// <param name="val">quantity measured in ZettaHertz</param>
    /// <returns>quantity measured in KiloHertz</returns>
	public static Quantity<double, KiloHertz> ToKiloHertz<T>(this BaseQuantity<T, ZettaHertz> val) where T:IConvertible {
        return new Quantity<double, KiloHertz>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaHertz to HectoHertz
    /// </summary>
    /// <param name="val">quantity measured in ZettaHertz</param>
    /// <returns>quantity measured in HectoHertz</returns>
	public static Quantity<double, HectoHertz> ToHectoHertz<T>(this BaseQuantity<T, ZettaHertz> val) where T:IConvertible {
        return new Quantity<double, HectoHertz>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaHertz to DekaHertz
    /// </summary>
    /// <param name="val">quantity measured in ZettaHertz</param>
    /// <returns>quantity measured in DekaHertz</returns>
	public static Quantity<double, DekaHertz> ToDekaHertz<T>(this BaseQuantity<T, ZettaHertz> val) where T:IConvertible {
        return new Quantity<double, DekaHertz>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaHertz to DeciHertz
    /// </summary>
    /// <param name="val">quantity measured in ZettaHertz</param>
    /// <returns>quantity measured in DeciHertz</returns>
	public static Quantity<double, DeciHertz> ToDeciHertz<T>(this BaseQuantity<T, ZettaHertz> val) where T:IConvertible {
        return new Quantity<double, DeciHertz>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaHertz to CentiHertz
    /// </summary>
    /// <param name="val">quantity measured in ZettaHertz</param>
    /// <returns>quantity measured in CentiHertz</returns>
	public static Quantity<double, CentiHertz> ToCentiHertz<T>(this BaseQuantity<T, ZettaHertz> val) where T:IConvertible {
        return new Quantity<double, CentiHertz>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaHertz to MilliHertz
    /// </summary>
    /// <param name="val">quantity measured in ZettaHertz</param>
    /// <returns>quantity measured in MilliHertz</returns>
	public static Quantity<double, MilliHertz> ToMilliHertz<T>(this BaseQuantity<T, ZettaHertz> val) where T:IConvertible {
        return new Quantity<double, MilliHertz>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaHertz to MicroHertz
    /// </summary>
    /// <param name="val">quantity measured in ZettaHertz</param>
    /// <returns>quantity measured in MicroHertz</returns>
	public static Quantity<double, MicroHertz> ToMicroHertz<T>(this BaseQuantity<T, ZettaHertz> val) where T:IConvertible {
        return new Quantity<double, MicroHertz>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaHertz to NanoHertz
    /// </summary>
    /// <param name="val">quantity measured in ZettaHertz</param>
    /// <returns>quantity measured in NanoHertz</returns>
	public static Quantity<double, NanoHertz> ToNanoHertz<T>(this BaseQuantity<T, ZettaHertz> val) where T:IConvertible {
        return new Quantity<double, NanoHertz>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaHertz to PicoHertz
    /// </summary>
    /// <param name="val">quantity measured in ZettaHertz</param>
    /// <returns>quantity measured in PicoHertz</returns>
	public static Quantity<double, PicoHertz> ToPicoHertz<T>(this BaseQuantity<T, ZettaHertz> val) where T:IConvertible {
        return new Quantity<double, PicoHertz>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaHertz to FemtoHertz
    /// </summary>
    /// <param name="val">quantity measured in ZettaHertz</param>
    /// <returns>quantity measured in FemtoHertz</returns>
	public static Quantity<double, FemtoHertz> ToFemtoHertz<T>(this BaseQuantity<T, ZettaHertz> val) where T:IConvertible {
        return new Quantity<double, FemtoHertz>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaHertz to AttoHertz
    /// </summary>
    /// <param name="val">quantity measured in ZettaHertz</param>
    /// <returns>quantity measured in AttoHertz</returns>
	public static Quantity<double, AttoHertz> ToAttoHertz<T>(this BaseQuantity<T, ZettaHertz> val) where T:IConvertible {
        return new Quantity<double, AttoHertz>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaHertz to ZeptoHertz
    /// </summary>
    /// <param name="val">quantity measured in ZettaHertz</param>
    /// <returns>quantity measured in ZeptoHertz</returns>
	public static Quantity<double, ZeptoHertz> ToZeptoHertz<T>(this BaseQuantity<T, ZettaHertz> val) where T:IConvertible {
        return new Quantity<double, ZeptoHertz>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaHertz to YoctoHertz
    /// </summary>
    /// <param name="val">quantity measured in ZettaHertz</param>
    /// <returns>quantity measured in YoctoHertz</returns>
	public static Quantity<double, YoctoHertz> ToYoctoHertz<T>(this BaseQuantity<T, ZettaHertz> val) where T:IConvertible {
        return new Quantity<double, YoctoHertz>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ExaHertz to YottaHertz
    /// </summary>
    /// <param name="val">quantity measured in ExaHertz</param>
    /// <returns>quantity measured in YottaHertz</returns>
	public static Quantity<double, YottaHertz> ToYottaHertz<T>(this BaseQuantity<T, ExaHertz> val) where T:IConvertible {
        return new Quantity<double, YottaHertz>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaHertz to ZettaHertz
    /// </summary>
    /// <param name="val">quantity measured in ExaHertz</param>
    /// <returns>quantity measured in ZettaHertz</returns>
	public static Quantity<double, ZettaHertz> ToZettaHertz<T>(this BaseQuantity<T, ExaHertz> val) where T:IConvertible {
        return new Quantity<double, ZettaHertz>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaHertz to PetaHertz
    /// </summary>
    /// <param name="val">quantity measured in ExaHertz</param>
    /// <returns>quantity measured in PetaHertz</returns>
	public static Quantity<double, PetaHertz> ToPetaHertz<T>(this BaseQuantity<T, ExaHertz> val) where T:IConvertible {
        return new Quantity<double, PetaHertz>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaHertz to TeraHertz
    /// </summary>
    /// <param name="val">quantity measured in ExaHertz</param>
    /// <returns>quantity measured in TeraHertz</returns>
	public static Quantity<double, TeraHertz> ToTeraHertz<T>(this BaseQuantity<T, ExaHertz> val) where T:IConvertible {
        return new Quantity<double, TeraHertz>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaHertz to GigaHertz
    /// </summary>
    /// <param name="val">quantity measured in ExaHertz</param>
    /// <returns>quantity measured in GigaHertz</returns>
	public static Quantity<double, GigaHertz> ToGigaHertz<T>(this BaseQuantity<T, ExaHertz> val) where T:IConvertible {
        return new Quantity<double, GigaHertz>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaHertz to MegaHertz
    /// </summary>
    /// <param name="val">quantity measured in ExaHertz</param>
    /// <returns>quantity measured in MegaHertz</returns>
	public static Quantity<double, MegaHertz> ToMegaHertz<T>(this BaseQuantity<T, ExaHertz> val) where T:IConvertible {
        return new Quantity<double, MegaHertz>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaHertz to KiloHertz
    /// </summary>
    /// <param name="val">quantity measured in ExaHertz</param>
    /// <returns>quantity measured in KiloHertz</returns>
	public static Quantity<double, KiloHertz> ToKiloHertz<T>(this BaseQuantity<T, ExaHertz> val) where T:IConvertible {
        return new Quantity<double, KiloHertz>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaHertz to HectoHertz
    /// </summary>
    /// <param name="val">quantity measured in ExaHertz</param>
    /// <returns>quantity measured in HectoHertz</returns>
	public static Quantity<double, HectoHertz> ToHectoHertz<T>(this BaseQuantity<T, ExaHertz> val) where T:IConvertible {
        return new Quantity<double, HectoHertz>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaHertz to DekaHertz
    /// </summary>
    /// <param name="val">quantity measured in ExaHertz</param>
    /// <returns>quantity measured in DekaHertz</returns>
	public static Quantity<double, DekaHertz> ToDekaHertz<T>(this BaseQuantity<T, ExaHertz> val) where T:IConvertible {
        return new Quantity<double, DekaHertz>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaHertz to DeciHertz
    /// </summary>
    /// <param name="val">quantity measured in ExaHertz</param>
    /// <returns>quantity measured in DeciHertz</returns>
	public static Quantity<double, DeciHertz> ToDeciHertz<T>(this BaseQuantity<T, ExaHertz> val) where T:IConvertible {
        return new Quantity<double, DeciHertz>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaHertz to CentiHertz
    /// </summary>
    /// <param name="val">quantity measured in ExaHertz</param>
    /// <returns>quantity measured in CentiHertz</returns>
	public static Quantity<double, CentiHertz> ToCentiHertz<T>(this BaseQuantity<T, ExaHertz> val) where T:IConvertible {
        return new Quantity<double, CentiHertz>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaHertz to MilliHertz
    /// </summary>
    /// <param name="val">quantity measured in ExaHertz</param>
    /// <returns>quantity measured in MilliHertz</returns>
	public static Quantity<double, MilliHertz> ToMilliHertz<T>(this BaseQuantity<T, ExaHertz> val) where T:IConvertible {
        return new Quantity<double, MilliHertz>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaHertz to MicroHertz
    /// </summary>
    /// <param name="val">quantity measured in ExaHertz</param>
    /// <returns>quantity measured in MicroHertz</returns>
	public static Quantity<double, MicroHertz> ToMicroHertz<T>(this BaseQuantity<T, ExaHertz> val) where T:IConvertible {
        return new Quantity<double, MicroHertz>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaHertz to NanoHertz
    /// </summary>
    /// <param name="val">quantity measured in ExaHertz</param>
    /// <returns>quantity measured in NanoHertz</returns>
	public static Quantity<double, NanoHertz> ToNanoHertz<T>(this BaseQuantity<T, ExaHertz> val) where T:IConvertible {
        return new Quantity<double, NanoHertz>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaHertz to PicoHertz
    /// </summary>
    /// <param name="val">quantity measured in ExaHertz</param>
    /// <returns>quantity measured in PicoHertz</returns>
	public static Quantity<double, PicoHertz> ToPicoHertz<T>(this BaseQuantity<T, ExaHertz> val) where T:IConvertible {
        return new Quantity<double, PicoHertz>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaHertz to FemtoHertz
    /// </summary>
    /// <param name="val">quantity measured in ExaHertz</param>
    /// <returns>quantity measured in FemtoHertz</returns>
	public static Quantity<double, FemtoHertz> ToFemtoHertz<T>(this BaseQuantity<T, ExaHertz> val) where T:IConvertible {
        return new Quantity<double, FemtoHertz>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaHertz to AttoHertz
    /// </summary>
    /// <param name="val">quantity measured in ExaHertz</param>
    /// <returns>quantity measured in AttoHertz</returns>
	public static Quantity<double, AttoHertz> ToAttoHertz<T>(this BaseQuantity<T, ExaHertz> val) where T:IConvertible {
        return new Quantity<double, AttoHertz>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaHertz to ZeptoHertz
    /// </summary>
    /// <param name="val">quantity measured in ExaHertz</param>
    /// <returns>quantity measured in ZeptoHertz</returns>
	public static Quantity<double, ZeptoHertz> ToZeptoHertz<T>(this BaseQuantity<T, ExaHertz> val) where T:IConvertible {
        return new Quantity<double, ZeptoHertz>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaHertz to YoctoHertz
    /// </summary>
    /// <param name="val">quantity measured in ExaHertz</param>
    /// <returns>quantity measured in YoctoHertz</returns>
	public static Quantity<double, YoctoHertz> ToYoctoHertz<T>(this BaseQuantity<T, ExaHertz> val) where T:IConvertible {
        return new Quantity<double, YoctoHertz>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert PetaHertz to YottaHertz
    /// </summary>
    /// <param name="val">quantity measured in PetaHertz</param>
    /// <returns>quantity measured in YottaHertz</returns>
	public static Quantity<double, YottaHertz> ToYottaHertz<T>(this BaseQuantity<T, PetaHertz> val) where T:IConvertible {
        return new Quantity<double, YottaHertz>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaHertz to ZettaHertz
    /// </summary>
    /// <param name="val">quantity measured in PetaHertz</param>
    /// <returns>quantity measured in ZettaHertz</returns>
	public static Quantity<double, ZettaHertz> ToZettaHertz<T>(this BaseQuantity<T, PetaHertz> val) where T:IConvertible {
        return new Quantity<double, ZettaHertz>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaHertz to ExaHertz
    /// </summary>
    /// <param name="val">quantity measured in PetaHertz</param>
    /// <returns>quantity measured in ExaHertz</returns>
	public static Quantity<double, ExaHertz> ToExaHertz<T>(this BaseQuantity<T, PetaHertz> val) where T:IConvertible {
        return new Quantity<double, ExaHertz>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaHertz to TeraHertz
    /// </summary>
    /// <param name="val">quantity measured in PetaHertz</param>
    /// <returns>quantity measured in TeraHertz</returns>
	public static Quantity<double, TeraHertz> ToTeraHertz<T>(this BaseQuantity<T, PetaHertz> val) where T:IConvertible {
        return new Quantity<double, TeraHertz>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaHertz to GigaHertz
    /// </summary>
    /// <param name="val">quantity measured in PetaHertz</param>
    /// <returns>quantity measured in GigaHertz</returns>
	public static Quantity<double, GigaHertz> ToGigaHertz<T>(this BaseQuantity<T, PetaHertz> val) where T:IConvertible {
        return new Quantity<double, GigaHertz>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaHertz to MegaHertz
    /// </summary>
    /// <param name="val">quantity measured in PetaHertz</param>
    /// <returns>quantity measured in MegaHertz</returns>
	public static Quantity<double, MegaHertz> ToMegaHertz<T>(this BaseQuantity<T, PetaHertz> val) where T:IConvertible {
        return new Quantity<double, MegaHertz>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaHertz to KiloHertz
    /// </summary>
    /// <param name="val">quantity measured in PetaHertz</param>
    /// <returns>quantity measured in KiloHertz</returns>
	public static Quantity<double, KiloHertz> ToKiloHertz<T>(this BaseQuantity<T, PetaHertz> val) where T:IConvertible {
        return new Quantity<double, KiloHertz>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaHertz to HectoHertz
    /// </summary>
    /// <param name="val">quantity measured in PetaHertz</param>
    /// <returns>quantity measured in HectoHertz</returns>
	public static Quantity<double, HectoHertz> ToHectoHertz<T>(this BaseQuantity<T, PetaHertz> val) where T:IConvertible {
        return new Quantity<double, HectoHertz>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaHertz to DekaHertz
    /// </summary>
    /// <param name="val">quantity measured in PetaHertz</param>
    /// <returns>quantity measured in DekaHertz</returns>
	public static Quantity<double, DekaHertz> ToDekaHertz<T>(this BaseQuantity<T, PetaHertz> val) where T:IConvertible {
        return new Quantity<double, DekaHertz>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaHertz to DeciHertz
    /// </summary>
    /// <param name="val">quantity measured in PetaHertz</param>
    /// <returns>quantity measured in DeciHertz</returns>
	public static Quantity<double, DeciHertz> ToDeciHertz<T>(this BaseQuantity<T, PetaHertz> val) where T:IConvertible {
        return new Quantity<double, DeciHertz>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaHertz to CentiHertz
    /// </summary>
    /// <param name="val">quantity measured in PetaHertz</param>
    /// <returns>quantity measured in CentiHertz</returns>
	public static Quantity<double, CentiHertz> ToCentiHertz<T>(this BaseQuantity<T, PetaHertz> val) where T:IConvertible {
        return new Quantity<double, CentiHertz>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaHertz to MilliHertz
    /// </summary>
    /// <param name="val">quantity measured in PetaHertz</param>
    /// <returns>quantity measured in MilliHertz</returns>
	public static Quantity<double, MilliHertz> ToMilliHertz<T>(this BaseQuantity<T, PetaHertz> val) where T:IConvertible {
        return new Quantity<double, MilliHertz>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaHertz to MicroHertz
    /// </summary>
    /// <param name="val">quantity measured in PetaHertz</param>
    /// <returns>quantity measured in MicroHertz</returns>
	public static Quantity<double, MicroHertz> ToMicroHertz<T>(this BaseQuantity<T, PetaHertz> val) where T:IConvertible {
        return new Quantity<double, MicroHertz>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaHertz to NanoHertz
    /// </summary>
    /// <param name="val">quantity measured in PetaHertz</param>
    /// <returns>quantity measured in NanoHertz</returns>
	public static Quantity<double, NanoHertz> ToNanoHertz<T>(this BaseQuantity<T, PetaHertz> val) where T:IConvertible {
        return new Quantity<double, NanoHertz>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaHertz to PicoHertz
    /// </summary>
    /// <param name="val">quantity measured in PetaHertz</param>
    /// <returns>quantity measured in PicoHertz</returns>
	public static Quantity<double, PicoHertz> ToPicoHertz<T>(this BaseQuantity<T, PetaHertz> val) where T:IConvertible {
        return new Quantity<double, PicoHertz>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaHertz to FemtoHertz
    /// </summary>
    /// <param name="val">quantity measured in PetaHertz</param>
    /// <returns>quantity measured in FemtoHertz</returns>
	public static Quantity<double, FemtoHertz> ToFemtoHertz<T>(this BaseQuantity<T, PetaHertz> val) where T:IConvertible {
        return new Quantity<double, FemtoHertz>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaHertz to AttoHertz
    /// </summary>
    /// <param name="val">quantity measured in PetaHertz</param>
    /// <returns>quantity measured in AttoHertz</returns>
	public static Quantity<double, AttoHertz> ToAttoHertz<T>(this BaseQuantity<T, PetaHertz> val) where T:IConvertible {
        return new Quantity<double, AttoHertz>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaHertz to ZeptoHertz
    /// </summary>
    /// <param name="val">quantity measured in PetaHertz</param>
    /// <returns>quantity measured in ZeptoHertz</returns>
	public static Quantity<double, ZeptoHertz> ToZeptoHertz<T>(this BaseQuantity<T, PetaHertz> val) where T:IConvertible {
        return new Quantity<double, ZeptoHertz>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaHertz to YoctoHertz
    /// </summary>
    /// <param name="val">quantity measured in PetaHertz</param>
    /// <returns>quantity measured in YoctoHertz</returns>
	public static Quantity<double, YoctoHertz> ToYoctoHertz<T>(this BaseQuantity<T, PetaHertz> val) where T:IConvertible {
        return new Quantity<double, YoctoHertz>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert TeraHertz to YottaHertz
    /// </summary>
    /// <param name="val">quantity measured in TeraHertz</param>
    /// <returns>quantity measured in YottaHertz</returns>
	public static Quantity<double, YottaHertz> ToYottaHertz<T>(this BaseQuantity<T, TeraHertz> val) where T:IConvertible {
        return new Quantity<double, YottaHertz>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraHertz to ZettaHertz
    /// </summary>
    /// <param name="val">quantity measured in TeraHertz</param>
    /// <returns>quantity measured in ZettaHertz</returns>
	public static Quantity<double, ZettaHertz> ToZettaHertz<T>(this BaseQuantity<T, TeraHertz> val) where T:IConvertible {
        return new Quantity<double, ZettaHertz>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraHertz to ExaHertz
    /// </summary>
    /// <param name="val">quantity measured in TeraHertz</param>
    /// <returns>quantity measured in ExaHertz</returns>
	public static Quantity<double, ExaHertz> ToExaHertz<T>(this BaseQuantity<T, TeraHertz> val) where T:IConvertible {
        return new Quantity<double, ExaHertz>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraHertz to PetaHertz
    /// </summary>
    /// <param name="val">quantity measured in TeraHertz</param>
    /// <returns>quantity measured in PetaHertz</returns>
	public static Quantity<double, PetaHertz> ToPetaHertz<T>(this BaseQuantity<T, TeraHertz> val) where T:IConvertible {
        return new Quantity<double, PetaHertz>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraHertz to GigaHertz
    /// </summary>
    /// <param name="val">quantity measured in TeraHertz</param>
    /// <returns>quantity measured in GigaHertz</returns>
	public static Quantity<double, GigaHertz> ToGigaHertz<T>(this BaseQuantity<T, TeraHertz> val) where T:IConvertible {
        return new Quantity<double, GigaHertz>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraHertz to MegaHertz
    /// </summary>
    /// <param name="val">quantity measured in TeraHertz</param>
    /// <returns>quantity measured in MegaHertz</returns>
	public static Quantity<double, MegaHertz> ToMegaHertz<T>(this BaseQuantity<T, TeraHertz> val) where T:IConvertible {
        return new Quantity<double, MegaHertz>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraHertz to KiloHertz
    /// </summary>
    /// <param name="val">quantity measured in TeraHertz</param>
    /// <returns>quantity measured in KiloHertz</returns>
	public static Quantity<double, KiloHertz> ToKiloHertz<T>(this BaseQuantity<T, TeraHertz> val) where T:IConvertible {
        return new Quantity<double, KiloHertz>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraHertz to HectoHertz
    /// </summary>
    /// <param name="val">quantity measured in TeraHertz</param>
    /// <returns>quantity measured in HectoHertz</returns>
	public static Quantity<double, HectoHertz> ToHectoHertz<T>(this BaseQuantity<T, TeraHertz> val) where T:IConvertible {
        return new Quantity<double, HectoHertz>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraHertz to DekaHertz
    /// </summary>
    /// <param name="val">quantity measured in TeraHertz</param>
    /// <returns>quantity measured in DekaHertz</returns>
	public static Quantity<double, DekaHertz> ToDekaHertz<T>(this BaseQuantity<T, TeraHertz> val) where T:IConvertible {
        return new Quantity<double, DekaHertz>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraHertz to DeciHertz
    /// </summary>
    /// <param name="val">quantity measured in TeraHertz</param>
    /// <returns>quantity measured in DeciHertz</returns>
	public static Quantity<double, DeciHertz> ToDeciHertz<T>(this BaseQuantity<T, TeraHertz> val) where T:IConvertible {
        return new Quantity<double, DeciHertz>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraHertz to CentiHertz
    /// </summary>
    /// <param name="val">quantity measured in TeraHertz</param>
    /// <returns>quantity measured in CentiHertz</returns>
	public static Quantity<double, CentiHertz> ToCentiHertz<T>(this BaseQuantity<T, TeraHertz> val) where T:IConvertible {
        return new Quantity<double, CentiHertz>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraHertz to MilliHertz
    /// </summary>
    /// <param name="val">quantity measured in TeraHertz</param>
    /// <returns>quantity measured in MilliHertz</returns>
	public static Quantity<double, MilliHertz> ToMilliHertz<T>(this BaseQuantity<T, TeraHertz> val) where T:IConvertible {
        return new Quantity<double, MilliHertz>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraHertz to MicroHertz
    /// </summary>
    /// <param name="val">quantity measured in TeraHertz</param>
    /// <returns>quantity measured in MicroHertz</returns>
	public static Quantity<double, MicroHertz> ToMicroHertz<T>(this BaseQuantity<T, TeraHertz> val) where T:IConvertible {
        return new Quantity<double, MicroHertz>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraHertz to NanoHertz
    /// </summary>
    /// <param name="val">quantity measured in TeraHertz</param>
    /// <returns>quantity measured in NanoHertz</returns>
	public static Quantity<double, NanoHertz> ToNanoHertz<T>(this BaseQuantity<T, TeraHertz> val) where T:IConvertible {
        return new Quantity<double, NanoHertz>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraHertz to PicoHertz
    /// </summary>
    /// <param name="val">quantity measured in TeraHertz</param>
    /// <returns>quantity measured in PicoHertz</returns>
	public static Quantity<double, PicoHertz> ToPicoHertz<T>(this BaseQuantity<T, TeraHertz> val) where T:IConvertible {
        return new Quantity<double, PicoHertz>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraHertz to FemtoHertz
    /// </summary>
    /// <param name="val">quantity measured in TeraHertz</param>
    /// <returns>quantity measured in FemtoHertz</returns>
	public static Quantity<double, FemtoHertz> ToFemtoHertz<T>(this BaseQuantity<T, TeraHertz> val) where T:IConvertible {
        return new Quantity<double, FemtoHertz>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraHertz to AttoHertz
    /// </summary>
    /// <param name="val">quantity measured in TeraHertz</param>
    /// <returns>quantity measured in AttoHertz</returns>
	public static Quantity<double, AttoHertz> ToAttoHertz<T>(this BaseQuantity<T, TeraHertz> val) where T:IConvertible {
        return new Quantity<double, AttoHertz>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraHertz to ZeptoHertz
    /// </summary>
    /// <param name="val">quantity measured in TeraHertz</param>
    /// <returns>quantity measured in ZeptoHertz</returns>
	public static Quantity<double, ZeptoHertz> ToZeptoHertz<T>(this BaseQuantity<T, TeraHertz> val) where T:IConvertible {
        return new Quantity<double, ZeptoHertz>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraHertz to YoctoHertz
    /// </summary>
    /// <param name="val">quantity measured in TeraHertz</param>
    /// <returns>quantity measured in YoctoHertz</returns>
	public static Quantity<double, YoctoHertz> ToYoctoHertz<T>(this BaseQuantity<T, TeraHertz> val) where T:IConvertible {
        return new Quantity<double, YoctoHertz>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert GigaHertz to YottaHertz
    /// </summary>
    /// <param name="val">quantity measured in GigaHertz</param>
    /// <returns>quantity measured in YottaHertz</returns>
	public static Quantity<double, YottaHertz> ToYottaHertz<T>(this BaseQuantity<T, GigaHertz> val) where T:IConvertible {
        return new Quantity<double, YottaHertz>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaHertz to ZettaHertz
    /// </summary>
    /// <param name="val">quantity measured in GigaHertz</param>
    /// <returns>quantity measured in ZettaHertz</returns>
	public static Quantity<double, ZettaHertz> ToZettaHertz<T>(this BaseQuantity<T, GigaHertz> val) where T:IConvertible {
        return new Quantity<double, ZettaHertz>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaHertz to ExaHertz
    /// </summary>
    /// <param name="val">quantity measured in GigaHertz</param>
    /// <returns>quantity measured in ExaHertz</returns>
	public static Quantity<double, ExaHertz> ToExaHertz<T>(this BaseQuantity<T, GigaHertz> val) where T:IConvertible {
        return new Quantity<double, ExaHertz>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaHertz to PetaHertz
    /// </summary>
    /// <param name="val">quantity measured in GigaHertz</param>
    /// <returns>quantity measured in PetaHertz</returns>
	public static Quantity<double, PetaHertz> ToPetaHertz<T>(this BaseQuantity<T, GigaHertz> val) where T:IConvertible {
        return new Quantity<double, PetaHertz>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaHertz to TeraHertz
    /// </summary>
    /// <param name="val">quantity measured in GigaHertz</param>
    /// <returns>quantity measured in TeraHertz</returns>
	public static Quantity<double, TeraHertz> ToTeraHertz<T>(this BaseQuantity<T, GigaHertz> val) where T:IConvertible {
        return new Quantity<double, TeraHertz>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaHertz to MegaHertz
    /// </summary>
    /// <param name="val">quantity measured in GigaHertz</param>
    /// <returns>quantity measured in MegaHertz</returns>
	public static Quantity<double, MegaHertz> ToMegaHertz<T>(this BaseQuantity<T, GigaHertz> val) where T:IConvertible {
        return new Quantity<double, MegaHertz>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaHertz to KiloHertz
    /// </summary>
    /// <param name="val">quantity measured in GigaHertz</param>
    /// <returns>quantity measured in KiloHertz</returns>
	public static Quantity<double, KiloHertz> ToKiloHertz<T>(this BaseQuantity<T, GigaHertz> val) where T:IConvertible {
        return new Quantity<double, KiloHertz>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaHertz to HectoHertz
    /// </summary>
    /// <param name="val">quantity measured in GigaHertz</param>
    /// <returns>quantity measured in HectoHertz</returns>
	public static Quantity<double, HectoHertz> ToHectoHertz<T>(this BaseQuantity<T, GigaHertz> val) where T:IConvertible {
        return new Quantity<double, HectoHertz>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaHertz to DekaHertz
    /// </summary>
    /// <param name="val">quantity measured in GigaHertz</param>
    /// <returns>quantity measured in DekaHertz</returns>
	public static Quantity<double, DekaHertz> ToDekaHertz<T>(this BaseQuantity<T, GigaHertz> val) where T:IConvertible {
        return new Quantity<double, DekaHertz>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaHertz to DeciHertz
    /// </summary>
    /// <param name="val">quantity measured in GigaHertz</param>
    /// <returns>quantity measured in DeciHertz</returns>
	public static Quantity<double, DeciHertz> ToDeciHertz<T>(this BaseQuantity<T, GigaHertz> val) where T:IConvertible {
        return new Quantity<double, DeciHertz>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaHertz to CentiHertz
    /// </summary>
    /// <param name="val">quantity measured in GigaHertz</param>
    /// <returns>quantity measured in CentiHertz</returns>
	public static Quantity<double, CentiHertz> ToCentiHertz<T>(this BaseQuantity<T, GigaHertz> val) where T:IConvertible {
        return new Quantity<double, CentiHertz>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaHertz to MilliHertz
    /// </summary>
    /// <param name="val">quantity measured in GigaHertz</param>
    /// <returns>quantity measured in MilliHertz</returns>
	public static Quantity<double, MilliHertz> ToMilliHertz<T>(this BaseQuantity<T, GigaHertz> val) where T:IConvertible {
        return new Quantity<double, MilliHertz>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaHertz to MicroHertz
    /// </summary>
    /// <param name="val">quantity measured in GigaHertz</param>
    /// <returns>quantity measured in MicroHertz</returns>
	public static Quantity<double, MicroHertz> ToMicroHertz<T>(this BaseQuantity<T, GigaHertz> val) where T:IConvertible {
        return new Quantity<double, MicroHertz>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaHertz to NanoHertz
    /// </summary>
    /// <param name="val">quantity measured in GigaHertz</param>
    /// <returns>quantity measured in NanoHertz</returns>
	public static Quantity<double, NanoHertz> ToNanoHertz<T>(this BaseQuantity<T, GigaHertz> val) where T:IConvertible {
        return new Quantity<double, NanoHertz>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaHertz to PicoHertz
    /// </summary>
    /// <param name="val">quantity measured in GigaHertz</param>
    /// <returns>quantity measured in PicoHertz</returns>
	public static Quantity<double, PicoHertz> ToPicoHertz<T>(this BaseQuantity<T, GigaHertz> val) where T:IConvertible {
        return new Quantity<double, PicoHertz>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaHertz to FemtoHertz
    /// </summary>
    /// <param name="val">quantity measured in GigaHertz</param>
    /// <returns>quantity measured in FemtoHertz</returns>
	public static Quantity<double, FemtoHertz> ToFemtoHertz<T>(this BaseQuantity<T, GigaHertz> val) where T:IConvertible {
        return new Quantity<double, FemtoHertz>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaHertz to AttoHertz
    /// </summary>
    /// <param name="val">quantity measured in GigaHertz</param>
    /// <returns>quantity measured in AttoHertz</returns>
	public static Quantity<double, AttoHertz> ToAttoHertz<T>(this BaseQuantity<T, GigaHertz> val) where T:IConvertible {
        return new Quantity<double, AttoHertz>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaHertz to ZeptoHertz
    /// </summary>
    /// <param name="val">quantity measured in GigaHertz</param>
    /// <returns>quantity measured in ZeptoHertz</returns>
	public static Quantity<double, ZeptoHertz> ToZeptoHertz<T>(this BaseQuantity<T, GigaHertz> val) where T:IConvertible {
        return new Quantity<double, ZeptoHertz>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaHertz to YoctoHertz
    /// </summary>
    /// <param name="val">quantity measured in GigaHertz</param>
    /// <returns>quantity measured in YoctoHertz</returns>
	public static Quantity<double, YoctoHertz> ToYoctoHertz<T>(this BaseQuantity<T, GigaHertz> val) where T:IConvertible {
        return new Quantity<double, YoctoHertz>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert MegaHertz to YottaHertz
    /// </summary>
    /// <param name="val">quantity measured in MegaHertz</param>
    /// <returns>quantity measured in YottaHertz</returns>
	public static Quantity<double, YottaHertz> ToYottaHertz<T>(this BaseQuantity<T, MegaHertz> val) where T:IConvertible {
        return new Quantity<double, YottaHertz>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaHertz to ZettaHertz
    /// </summary>
    /// <param name="val">quantity measured in MegaHertz</param>
    /// <returns>quantity measured in ZettaHertz</returns>
	public static Quantity<double, ZettaHertz> ToZettaHertz<T>(this BaseQuantity<T, MegaHertz> val) where T:IConvertible {
        return new Quantity<double, ZettaHertz>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaHertz to ExaHertz
    /// </summary>
    /// <param name="val">quantity measured in MegaHertz</param>
    /// <returns>quantity measured in ExaHertz</returns>
	public static Quantity<double, ExaHertz> ToExaHertz<T>(this BaseQuantity<T, MegaHertz> val) where T:IConvertible {
        return new Quantity<double, ExaHertz>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaHertz to PetaHertz
    /// </summary>
    /// <param name="val">quantity measured in MegaHertz</param>
    /// <returns>quantity measured in PetaHertz</returns>
	public static Quantity<double, PetaHertz> ToPetaHertz<T>(this BaseQuantity<T, MegaHertz> val) where T:IConvertible {
        return new Quantity<double, PetaHertz>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaHertz to TeraHertz
    /// </summary>
    /// <param name="val">quantity measured in MegaHertz</param>
    /// <returns>quantity measured in TeraHertz</returns>
	public static Quantity<double, TeraHertz> ToTeraHertz<T>(this BaseQuantity<T, MegaHertz> val) where T:IConvertible {
        return new Quantity<double, TeraHertz>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaHertz to GigaHertz
    /// </summary>
    /// <param name="val">quantity measured in MegaHertz</param>
    /// <returns>quantity measured in GigaHertz</returns>
	public static Quantity<double, GigaHertz> ToGigaHertz<T>(this BaseQuantity<T, MegaHertz> val) where T:IConvertible {
        return new Quantity<double, GigaHertz>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaHertz to KiloHertz
    /// </summary>
    /// <param name="val">quantity measured in MegaHertz</param>
    /// <returns>quantity measured in KiloHertz</returns>
	public static Quantity<double, KiloHertz> ToKiloHertz<T>(this BaseQuantity<T, MegaHertz> val) where T:IConvertible {
        return new Quantity<double, KiloHertz>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaHertz to HectoHertz
    /// </summary>
    /// <param name="val">quantity measured in MegaHertz</param>
    /// <returns>quantity measured in HectoHertz</returns>
	public static Quantity<double, HectoHertz> ToHectoHertz<T>(this BaseQuantity<T, MegaHertz> val) where T:IConvertible {
        return new Quantity<double, HectoHertz>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaHertz to DekaHertz
    /// </summary>
    /// <param name="val">quantity measured in MegaHertz</param>
    /// <returns>quantity measured in DekaHertz</returns>
	public static Quantity<double, DekaHertz> ToDekaHertz<T>(this BaseQuantity<T, MegaHertz> val) where T:IConvertible {
        return new Quantity<double, DekaHertz>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaHertz to DeciHertz
    /// </summary>
    /// <param name="val">quantity measured in MegaHertz</param>
    /// <returns>quantity measured in DeciHertz</returns>
	public static Quantity<double, DeciHertz> ToDeciHertz<T>(this BaseQuantity<T, MegaHertz> val) where T:IConvertible {
        return new Quantity<double, DeciHertz>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaHertz to CentiHertz
    /// </summary>
    /// <param name="val">quantity measured in MegaHertz</param>
    /// <returns>quantity measured in CentiHertz</returns>
	public static Quantity<double, CentiHertz> ToCentiHertz<T>(this BaseQuantity<T, MegaHertz> val) where T:IConvertible {
        return new Quantity<double, CentiHertz>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaHertz to MilliHertz
    /// </summary>
    /// <param name="val">quantity measured in MegaHertz</param>
    /// <returns>quantity measured in MilliHertz</returns>
	public static Quantity<double, MilliHertz> ToMilliHertz<T>(this BaseQuantity<T, MegaHertz> val) where T:IConvertible {
        return new Quantity<double, MilliHertz>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaHertz to MicroHertz
    /// </summary>
    /// <param name="val">quantity measured in MegaHertz</param>
    /// <returns>quantity measured in MicroHertz</returns>
	public static Quantity<double, MicroHertz> ToMicroHertz<T>(this BaseQuantity<T, MegaHertz> val) where T:IConvertible {
        return new Quantity<double, MicroHertz>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaHertz to NanoHertz
    /// </summary>
    /// <param name="val">quantity measured in MegaHertz</param>
    /// <returns>quantity measured in NanoHertz</returns>
	public static Quantity<double, NanoHertz> ToNanoHertz<T>(this BaseQuantity<T, MegaHertz> val) where T:IConvertible {
        return new Quantity<double, NanoHertz>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaHertz to PicoHertz
    /// </summary>
    /// <param name="val">quantity measured in MegaHertz</param>
    /// <returns>quantity measured in PicoHertz</returns>
	public static Quantity<double, PicoHertz> ToPicoHertz<T>(this BaseQuantity<T, MegaHertz> val) where T:IConvertible {
        return new Quantity<double, PicoHertz>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaHertz to FemtoHertz
    /// </summary>
    /// <param name="val">quantity measured in MegaHertz</param>
    /// <returns>quantity measured in FemtoHertz</returns>
	public static Quantity<double, FemtoHertz> ToFemtoHertz<T>(this BaseQuantity<T, MegaHertz> val) where T:IConvertible {
        return new Quantity<double, FemtoHertz>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaHertz to AttoHertz
    /// </summary>
    /// <param name="val">quantity measured in MegaHertz</param>
    /// <returns>quantity measured in AttoHertz</returns>
	public static Quantity<double, AttoHertz> ToAttoHertz<T>(this BaseQuantity<T, MegaHertz> val) where T:IConvertible {
        return new Quantity<double, AttoHertz>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaHertz to ZeptoHertz
    /// </summary>
    /// <param name="val">quantity measured in MegaHertz</param>
    /// <returns>quantity measured in ZeptoHertz</returns>
	public static Quantity<double, ZeptoHertz> ToZeptoHertz<T>(this BaseQuantity<T, MegaHertz> val) where T:IConvertible {
        return new Quantity<double, ZeptoHertz>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaHertz to YoctoHertz
    /// </summary>
    /// <param name="val">quantity measured in MegaHertz</param>
    /// <returns>quantity measured in YoctoHertz</returns>
	public static Quantity<double, YoctoHertz> ToYoctoHertz<T>(this BaseQuantity<T, MegaHertz> val) where T:IConvertible {
        return new Quantity<double, YoctoHertz>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert KiloHertz to YottaHertz
    /// </summary>
    /// <param name="val">quantity measured in KiloHertz</param>
    /// <returns>quantity measured in YottaHertz</returns>
	public static Quantity<double, YottaHertz> ToYottaHertz<T>(this BaseQuantity<T, KiloHertz> val) where T:IConvertible {
        return new Quantity<double, YottaHertz>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloHertz to ZettaHertz
    /// </summary>
    /// <param name="val">quantity measured in KiloHertz</param>
    /// <returns>quantity measured in ZettaHertz</returns>
	public static Quantity<double, ZettaHertz> ToZettaHertz<T>(this BaseQuantity<T, KiloHertz> val) where T:IConvertible {
        return new Quantity<double, ZettaHertz>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloHertz to ExaHertz
    /// </summary>
    /// <param name="val">quantity measured in KiloHertz</param>
    /// <returns>quantity measured in ExaHertz</returns>
	public static Quantity<double, ExaHertz> ToExaHertz<T>(this BaseQuantity<T, KiloHertz> val) where T:IConvertible {
        return new Quantity<double, ExaHertz>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloHertz to PetaHertz
    /// </summary>
    /// <param name="val">quantity measured in KiloHertz</param>
    /// <returns>quantity measured in PetaHertz</returns>
	public static Quantity<double, PetaHertz> ToPetaHertz<T>(this BaseQuantity<T, KiloHertz> val) where T:IConvertible {
        return new Quantity<double, PetaHertz>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloHertz to TeraHertz
    /// </summary>
    /// <param name="val">quantity measured in KiloHertz</param>
    /// <returns>quantity measured in TeraHertz</returns>
	public static Quantity<double, TeraHertz> ToTeraHertz<T>(this BaseQuantity<T, KiloHertz> val) where T:IConvertible {
        return new Quantity<double, TeraHertz>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloHertz to GigaHertz
    /// </summary>
    /// <param name="val">quantity measured in KiloHertz</param>
    /// <returns>quantity measured in GigaHertz</returns>
	public static Quantity<double, GigaHertz> ToGigaHertz<T>(this BaseQuantity<T, KiloHertz> val) where T:IConvertible {
        return new Quantity<double, GigaHertz>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloHertz to MegaHertz
    /// </summary>
    /// <param name="val">quantity measured in KiloHertz</param>
    /// <returns>quantity measured in MegaHertz</returns>
	public static Quantity<double, MegaHertz> ToMegaHertz<T>(this BaseQuantity<T, KiloHertz> val) where T:IConvertible {
        return new Quantity<double, MegaHertz>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloHertz to HectoHertz
    /// </summary>
    /// <param name="val">quantity measured in KiloHertz</param>
    /// <returns>quantity measured in HectoHertz</returns>
	public static Quantity<double, HectoHertz> ToHectoHertz<T>(this BaseQuantity<T, KiloHertz> val) where T:IConvertible {
        return new Quantity<double, HectoHertz>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloHertz to DekaHertz
    /// </summary>
    /// <param name="val">quantity measured in KiloHertz</param>
    /// <returns>quantity measured in DekaHertz</returns>
	public static Quantity<double, DekaHertz> ToDekaHertz<T>(this BaseQuantity<T, KiloHertz> val) where T:IConvertible {
        return new Quantity<double, DekaHertz>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloHertz to DeciHertz
    /// </summary>
    /// <param name="val">quantity measured in KiloHertz</param>
    /// <returns>quantity measured in DeciHertz</returns>
	public static Quantity<double, DeciHertz> ToDeciHertz<T>(this BaseQuantity<T, KiloHertz> val) where T:IConvertible {
        return new Quantity<double, DeciHertz>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloHertz to CentiHertz
    /// </summary>
    /// <param name="val">quantity measured in KiloHertz</param>
    /// <returns>quantity measured in CentiHertz</returns>
	public static Quantity<double, CentiHertz> ToCentiHertz<T>(this BaseQuantity<T, KiloHertz> val) where T:IConvertible {
        return new Quantity<double, CentiHertz>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloHertz to MilliHertz
    /// </summary>
    /// <param name="val">quantity measured in KiloHertz</param>
    /// <returns>quantity measured in MilliHertz</returns>
	public static Quantity<double, MilliHertz> ToMilliHertz<T>(this BaseQuantity<T, KiloHertz> val) where T:IConvertible {
        return new Quantity<double, MilliHertz>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloHertz to MicroHertz
    /// </summary>
    /// <param name="val">quantity measured in KiloHertz</param>
    /// <returns>quantity measured in MicroHertz</returns>
	public static Quantity<double, MicroHertz> ToMicroHertz<T>(this BaseQuantity<T, KiloHertz> val) where T:IConvertible {
        return new Quantity<double, MicroHertz>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloHertz to NanoHertz
    /// </summary>
    /// <param name="val">quantity measured in KiloHertz</param>
    /// <returns>quantity measured in NanoHertz</returns>
	public static Quantity<double, NanoHertz> ToNanoHertz<T>(this BaseQuantity<T, KiloHertz> val) where T:IConvertible {
        return new Quantity<double, NanoHertz>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloHertz to PicoHertz
    /// </summary>
    /// <param name="val">quantity measured in KiloHertz</param>
    /// <returns>quantity measured in PicoHertz</returns>
	public static Quantity<double, PicoHertz> ToPicoHertz<T>(this BaseQuantity<T, KiloHertz> val) where T:IConvertible {
        return new Quantity<double, PicoHertz>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloHertz to FemtoHertz
    /// </summary>
    /// <param name="val">quantity measured in KiloHertz</param>
    /// <returns>quantity measured in FemtoHertz</returns>
	public static Quantity<double, FemtoHertz> ToFemtoHertz<T>(this BaseQuantity<T, KiloHertz> val) where T:IConvertible {
        return new Quantity<double, FemtoHertz>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloHertz to AttoHertz
    /// </summary>
    /// <param name="val">quantity measured in KiloHertz</param>
    /// <returns>quantity measured in AttoHertz</returns>
	public static Quantity<double, AttoHertz> ToAttoHertz<T>(this BaseQuantity<T, KiloHertz> val) where T:IConvertible {
        return new Quantity<double, AttoHertz>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloHertz to ZeptoHertz
    /// </summary>
    /// <param name="val">quantity measured in KiloHertz</param>
    /// <returns>quantity measured in ZeptoHertz</returns>
	public static Quantity<double, ZeptoHertz> ToZeptoHertz<T>(this BaseQuantity<T, KiloHertz> val) where T:IConvertible {
        return new Quantity<double, ZeptoHertz>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloHertz to YoctoHertz
    /// </summary>
    /// <param name="val">quantity measured in KiloHertz</param>
    /// <returns>quantity measured in YoctoHertz</returns>
	public static Quantity<double, YoctoHertz> ToYoctoHertz<T>(this BaseQuantity<T, KiloHertz> val) where T:IConvertible {
        return new Quantity<double, YoctoHertz>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert HectoHertz to YottaHertz
    /// </summary>
    /// <param name="val">quantity measured in HectoHertz</param>
    /// <returns>quantity measured in YottaHertz</returns>
	public static Quantity<double, YottaHertz> ToYottaHertz<T>(this BaseQuantity<T, HectoHertz> val) where T:IConvertible {
        return new Quantity<double, YottaHertz>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoHertz to ZettaHertz
    /// </summary>
    /// <param name="val">quantity measured in HectoHertz</param>
    /// <returns>quantity measured in ZettaHertz</returns>
	public static Quantity<double, ZettaHertz> ToZettaHertz<T>(this BaseQuantity<T, HectoHertz> val) where T:IConvertible {
        return new Quantity<double, ZettaHertz>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoHertz to ExaHertz
    /// </summary>
    /// <param name="val">quantity measured in HectoHertz</param>
    /// <returns>quantity measured in ExaHertz</returns>
	public static Quantity<double, ExaHertz> ToExaHertz<T>(this BaseQuantity<T, HectoHertz> val) where T:IConvertible {
        return new Quantity<double, ExaHertz>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoHertz to PetaHertz
    /// </summary>
    /// <param name="val">quantity measured in HectoHertz</param>
    /// <returns>quantity measured in PetaHertz</returns>
	public static Quantity<double, PetaHertz> ToPetaHertz<T>(this BaseQuantity<T, HectoHertz> val) where T:IConvertible {
        return new Quantity<double, PetaHertz>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoHertz to TeraHertz
    /// </summary>
    /// <param name="val">quantity measured in HectoHertz</param>
    /// <returns>quantity measured in TeraHertz</returns>
	public static Quantity<double, TeraHertz> ToTeraHertz<T>(this BaseQuantity<T, HectoHertz> val) where T:IConvertible {
        return new Quantity<double, TeraHertz>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoHertz to GigaHertz
    /// </summary>
    /// <param name="val">quantity measured in HectoHertz</param>
    /// <returns>quantity measured in GigaHertz</returns>
	public static Quantity<double, GigaHertz> ToGigaHertz<T>(this BaseQuantity<T, HectoHertz> val) where T:IConvertible {
        return new Quantity<double, GigaHertz>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoHertz to MegaHertz
    /// </summary>
    /// <param name="val">quantity measured in HectoHertz</param>
    /// <returns>quantity measured in MegaHertz</returns>
	public static Quantity<double, MegaHertz> ToMegaHertz<T>(this BaseQuantity<T, HectoHertz> val) where T:IConvertible {
        return new Quantity<double, MegaHertz>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoHertz to KiloHertz
    /// </summary>
    /// <param name="val">quantity measured in HectoHertz</param>
    /// <returns>quantity measured in KiloHertz</returns>
	public static Quantity<double, KiloHertz> ToKiloHertz<T>(this BaseQuantity<T, HectoHertz> val) where T:IConvertible {
        return new Quantity<double, KiloHertz>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoHertz to DekaHertz
    /// </summary>
    /// <param name="val">quantity measured in HectoHertz</param>
    /// <returns>quantity measured in DekaHertz</returns>
	public static Quantity<double, DekaHertz> ToDekaHertz<T>(this BaseQuantity<T, HectoHertz> val) where T:IConvertible {
        return new Quantity<double, DekaHertz>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoHertz to DeciHertz
    /// </summary>
    /// <param name="val">quantity measured in HectoHertz</param>
    /// <returns>quantity measured in DeciHertz</returns>
	public static Quantity<double, DeciHertz> ToDeciHertz<T>(this BaseQuantity<T, HectoHertz> val) where T:IConvertible {
        return new Quantity<double, DeciHertz>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoHertz to CentiHertz
    /// </summary>
    /// <param name="val">quantity measured in HectoHertz</param>
    /// <returns>quantity measured in CentiHertz</returns>
	public static Quantity<double, CentiHertz> ToCentiHertz<T>(this BaseQuantity<T, HectoHertz> val) where T:IConvertible {
        return new Quantity<double, CentiHertz>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoHertz to MilliHertz
    /// </summary>
    /// <param name="val">quantity measured in HectoHertz</param>
    /// <returns>quantity measured in MilliHertz</returns>
	public static Quantity<double, MilliHertz> ToMilliHertz<T>(this BaseQuantity<T, HectoHertz> val) where T:IConvertible {
        return new Quantity<double, MilliHertz>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoHertz to MicroHertz
    /// </summary>
    /// <param name="val">quantity measured in HectoHertz</param>
    /// <returns>quantity measured in MicroHertz</returns>
	public static Quantity<double, MicroHertz> ToMicroHertz<T>(this BaseQuantity<T, HectoHertz> val) where T:IConvertible {
        return new Quantity<double, MicroHertz>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoHertz to NanoHertz
    /// </summary>
    /// <param name="val">quantity measured in HectoHertz</param>
    /// <returns>quantity measured in NanoHertz</returns>
	public static Quantity<double, NanoHertz> ToNanoHertz<T>(this BaseQuantity<T, HectoHertz> val) where T:IConvertible {
        return new Quantity<double, NanoHertz>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoHertz to PicoHertz
    /// </summary>
    /// <param name="val">quantity measured in HectoHertz</param>
    /// <returns>quantity measured in PicoHertz</returns>
	public static Quantity<double, PicoHertz> ToPicoHertz<T>(this BaseQuantity<T, HectoHertz> val) where T:IConvertible {
        return new Quantity<double, PicoHertz>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoHertz to FemtoHertz
    /// </summary>
    /// <param name="val">quantity measured in HectoHertz</param>
    /// <returns>quantity measured in FemtoHertz</returns>
	public static Quantity<double, FemtoHertz> ToFemtoHertz<T>(this BaseQuantity<T, HectoHertz> val) where T:IConvertible {
        return new Quantity<double, FemtoHertz>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoHertz to AttoHertz
    /// </summary>
    /// <param name="val">quantity measured in HectoHertz</param>
    /// <returns>quantity measured in AttoHertz</returns>
	public static Quantity<double, AttoHertz> ToAttoHertz<T>(this BaseQuantity<T, HectoHertz> val) where T:IConvertible {
        return new Quantity<double, AttoHertz>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoHertz to ZeptoHertz
    /// </summary>
    /// <param name="val">quantity measured in HectoHertz</param>
    /// <returns>quantity measured in ZeptoHertz</returns>
	public static Quantity<double, ZeptoHertz> ToZeptoHertz<T>(this BaseQuantity<T, HectoHertz> val) where T:IConvertible {
        return new Quantity<double, ZeptoHertz>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoHertz to YoctoHertz
    /// </summary>
    /// <param name="val">quantity measured in HectoHertz</param>
    /// <returns>quantity measured in YoctoHertz</returns>
	public static Quantity<double, YoctoHertz> ToYoctoHertz<T>(this BaseQuantity<T, HectoHertz> val) where T:IConvertible {
        return new Quantity<double, YoctoHertz>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert DekaHertz to YottaHertz
    /// </summary>
    /// <param name="val">quantity measured in DekaHertz</param>
    /// <returns>quantity measured in YottaHertz</returns>
	public static Quantity<double, YottaHertz> ToYottaHertz<T>(this BaseQuantity<T, DekaHertz> val) where T:IConvertible {
        return new Quantity<double, YottaHertz>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaHertz to ZettaHertz
    /// </summary>
    /// <param name="val">quantity measured in DekaHertz</param>
    /// <returns>quantity measured in ZettaHertz</returns>
	public static Quantity<double, ZettaHertz> ToZettaHertz<T>(this BaseQuantity<T, DekaHertz> val) where T:IConvertible {
        return new Quantity<double, ZettaHertz>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaHertz to ExaHertz
    /// </summary>
    /// <param name="val">quantity measured in DekaHertz</param>
    /// <returns>quantity measured in ExaHertz</returns>
	public static Quantity<double, ExaHertz> ToExaHertz<T>(this BaseQuantity<T, DekaHertz> val) where T:IConvertible {
        return new Quantity<double, ExaHertz>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaHertz to PetaHertz
    /// </summary>
    /// <param name="val">quantity measured in DekaHertz</param>
    /// <returns>quantity measured in PetaHertz</returns>
	public static Quantity<double, PetaHertz> ToPetaHertz<T>(this BaseQuantity<T, DekaHertz> val) where T:IConvertible {
        return new Quantity<double, PetaHertz>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaHertz to TeraHertz
    /// </summary>
    /// <param name="val">quantity measured in DekaHertz</param>
    /// <returns>quantity measured in TeraHertz</returns>
	public static Quantity<double, TeraHertz> ToTeraHertz<T>(this BaseQuantity<T, DekaHertz> val) where T:IConvertible {
        return new Quantity<double, TeraHertz>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaHertz to GigaHertz
    /// </summary>
    /// <param name="val">quantity measured in DekaHertz</param>
    /// <returns>quantity measured in GigaHertz</returns>
	public static Quantity<double, GigaHertz> ToGigaHertz<T>(this BaseQuantity<T, DekaHertz> val) where T:IConvertible {
        return new Quantity<double, GigaHertz>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaHertz to MegaHertz
    /// </summary>
    /// <param name="val">quantity measured in DekaHertz</param>
    /// <returns>quantity measured in MegaHertz</returns>
	public static Quantity<double, MegaHertz> ToMegaHertz<T>(this BaseQuantity<T, DekaHertz> val) where T:IConvertible {
        return new Quantity<double, MegaHertz>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaHertz to KiloHertz
    /// </summary>
    /// <param name="val">quantity measured in DekaHertz</param>
    /// <returns>quantity measured in KiloHertz</returns>
	public static Quantity<double, KiloHertz> ToKiloHertz<T>(this BaseQuantity<T, DekaHertz> val) where T:IConvertible {
        return new Quantity<double, KiloHertz>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaHertz to HectoHertz
    /// </summary>
    /// <param name="val">quantity measured in DekaHertz</param>
    /// <returns>quantity measured in HectoHertz</returns>
	public static Quantity<double, HectoHertz> ToHectoHertz<T>(this BaseQuantity<T, DekaHertz> val) where T:IConvertible {
        return new Quantity<double, HectoHertz>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaHertz to DeciHertz
    /// </summary>
    /// <param name="val">quantity measured in DekaHertz</param>
    /// <returns>quantity measured in DeciHertz</returns>
	public static Quantity<double, DeciHertz> ToDeciHertz<T>(this BaseQuantity<T, DekaHertz> val) where T:IConvertible {
        return new Quantity<double, DeciHertz>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaHertz to CentiHertz
    /// </summary>
    /// <param name="val">quantity measured in DekaHertz</param>
    /// <returns>quantity measured in CentiHertz</returns>
	public static Quantity<double, CentiHertz> ToCentiHertz<T>(this BaseQuantity<T, DekaHertz> val) where T:IConvertible {
        return new Quantity<double, CentiHertz>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaHertz to MilliHertz
    /// </summary>
    /// <param name="val">quantity measured in DekaHertz</param>
    /// <returns>quantity measured in MilliHertz</returns>
	public static Quantity<double, MilliHertz> ToMilliHertz<T>(this BaseQuantity<T, DekaHertz> val) where T:IConvertible {
        return new Quantity<double, MilliHertz>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaHertz to MicroHertz
    /// </summary>
    /// <param name="val">quantity measured in DekaHertz</param>
    /// <returns>quantity measured in MicroHertz</returns>
	public static Quantity<double, MicroHertz> ToMicroHertz<T>(this BaseQuantity<T, DekaHertz> val) where T:IConvertible {
        return new Quantity<double, MicroHertz>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaHertz to NanoHertz
    /// </summary>
    /// <param name="val">quantity measured in DekaHertz</param>
    /// <returns>quantity measured in NanoHertz</returns>
	public static Quantity<double, NanoHertz> ToNanoHertz<T>(this BaseQuantity<T, DekaHertz> val) where T:IConvertible {
        return new Quantity<double, NanoHertz>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaHertz to PicoHertz
    /// </summary>
    /// <param name="val">quantity measured in DekaHertz</param>
    /// <returns>quantity measured in PicoHertz</returns>
	public static Quantity<double, PicoHertz> ToPicoHertz<T>(this BaseQuantity<T, DekaHertz> val) where T:IConvertible {
        return new Quantity<double, PicoHertz>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaHertz to FemtoHertz
    /// </summary>
    /// <param name="val">quantity measured in DekaHertz</param>
    /// <returns>quantity measured in FemtoHertz</returns>
	public static Quantity<double, FemtoHertz> ToFemtoHertz<T>(this BaseQuantity<T, DekaHertz> val) where T:IConvertible {
        return new Quantity<double, FemtoHertz>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaHertz to AttoHertz
    /// </summary>
    /// <param name="val">quantity measured in DekaHertz</param>
    /// <returns>quantity measured in AttoHertz</returns>
	public static Quantity<double, AttoHertz> ToAttoHertz<T>(this BaseQuantity<T, DekaHertz> val) where T:IConvertible {
        return new Quantity<double, AttoHertz>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaHertz to ZeptoHertz
    /// </summary>
    /// <param name="val">quantity measured in DekaHertz</param>
    /// <returns>quantity measured in ZeptoHertz</returns>
	public static Quantity<double, ZeptoHertz> ToZeptoHertz<T>(this BaseQuantity<T, DekaHertz> val) where T:IConvertible {
        return new Quantity<double, ZeptoHertz>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaHertz to YoctoHertz
    /// </summary>
    /// <param name="val">quantity measured in DekaHertz</param>
    /// <returns>quantity measured in YoctoHertz</returns>
	public static Quantity<double, YoctoHertz> ToYoctoHertz<T>(this BaseQuantity<T, DekaHertz> val) where T:IConvertible {
        return new Quantity<double, YoctoHertz>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DeciHertz to YottaHertz
    /// </summary>
    /// <param name="val">quantity measured in DeciHertz</param>
    /// <returns>quantity measured in YottaHertz</returns>
	public static Quantity<double, YottaHertz> ToYottaHertz<T>(this BaseQuantity<T, DeciHertz> val) where T:IConvertible {
        return new Quantity<double, YottaHertz>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciHertz to ZettaHertz
    /// </summary>
    /// <param name="val">quantity measured in DeciHertz</param>
    /// <returns>quantity measured in ZettaHertz</returns>
	public static Quantity<double, ZettaHertz> ToZettaHertz<T>(this BaseQuantity<T, DeciHertz> val) where T:IConvertible {
        return new Quantity<double, ZettaHertz>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciHertz to ExaHertz
    /// </summary>
    /// <param name="val">quantity measured in DeciHertz</param>
    /// <returns>quantity measured in ExaHertz</returns>
	public static Quantity<double, ExaHertz> ToExaHertz<T>(this BaseQuantity<T, DeciHertz> val) where T:IConvertible {
        return new Quantity<double, ExaHertz>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciHertz to PetaHertz
    /// </summary>
    /// <param name="val">quantity measured in DeciHertz</param>
    /// <returns>quantity measured in PetaHertz</returns>
	public static Quantity<double, PetaHertz> ToPetaHertz<T>(this BaseQuantity<T, DeciHertz> val) where T:IConvertible {
        return new Quantity<double, PetaHertz>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciHertz to TeraHertz
    /// </summary>
    /// <param name="val">quantity measured in DeciHertz</param>
    /// <returns>quantity measured in TeraHertz</returns>
	public static Quantity<double, TeraHertz> ToTeraHertz<T>(this BaseQuantity<T, DeciHertz> val) where T:IConvertible {
        return new Quantity<double, TeraHertz>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciHertz to GigaHertz
    /// </summary>
    /// <param name="val">quantity measured in DeciHertz</param>
    /// <returns>quantity measured in GigaHertz</returns>
	public static Quantity<double, GigaHertz> ToGigaHertz<T>(this BaseQuantity<T, DeciHertz> val) where T:IConvertible {
        return new Quantity<double, GigaHertz>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciHertz to MegaHertz
    /// </summary>
    /// <param name="val">quantity measured in DeciHertz</param>
    /// <returns>quantity measured in MegaHertz</returns>
	public static Quantity<double, MegaHertz> ToMegaHertz<T>(this BaseQuantity<T, DeciHertz> val) where T:IConvertible {
        return new Quantity<double, MegaHertz>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciHertz to KiloHertz
    /// </summary>
    /// <param name="val">quantity measured in DeciHertz</param>
    /// <returns>quantity measured in KiloHertz</returns>
	public static Quantity<double, KiloHertz> ToKiloHertz<T>(this BaseQuantity<T, DeciHertz> val) where T:IConvertible {
        return new Quantity<double, KiloHertz>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciHertz to HectoHertz
    /// </summary>
    /// <param name="val">quantity measured in DeciHertz</param>
    /// <returns>quantity measured in HectoHertz</returns>
	public static Quantity<double, HectoHertz> ToHectoHertz<T>(this BaseQuantity<T, DeciHertz> val) where T:IConvertible {
        return new Quantity<double, HectoHertz>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciHertz to DekaHertz
    /// </summary>
    /// <param name="val">quantity measured in DeciHertz</param>
    /// <returns>quantity measured in DekaHertz</returns>
	public static Quantity<double, DekaHertz> ToDekaHertz<T>(this BaseQuantity<T, DeciHertz> val) where T:IConvertible {
        return new Quantity<double, DekaHertz>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciHertz to CentiHertz
    /// </summary>
    /// <param name="val">quantity measured in DeciHertz</param>
    /// <returns>quantity measured in CentiHertz</returns>
	public static Quantity<double, CentiHertz> ToCentiHertz<T>(this BaseQuantity<T, DeciHertz> val) where T:IConvertible {
        return new Quantity<double, CentiHertz>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciHertz to MilliHertz
    /// </summary>
    /// <param name="val">quantity measured in DeciHertz</param>
    /// <returns>quantity measured in MilliHertz</returns>
	public static Quantity<double, MilliHertz> ToMilliHertz<T>(this BaseQuantity<T, DeciHertz> val) where T:IConvertible {
        return new Quantity<double, MilliHertz>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciHertz to MicroHertz
    /// </summary>
    /// <param name="val">quantity measured in DeciHertz</param>
    /// <returns>quantity measured in MicroHertz</returns>
	public static Quantity<double, MicroHertz> ToMicroHertz<T>(this BaseQuantity<T, DeciHertz> val) where T:IConvertible {
        return new Quantity<double, MicroHertz>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciHertz to NanoHertz
    /// </summary>
    /// <param name="val">quantity measured in DeciHertz</param>
    /// <returns>quantity measured in NanoHertz</returns>
	public static Quantity<double, NanoHertz> ToNanoHertz<T>(this BaseQuantity<T, DeciHertz> val) where T:IConvertible {
        return new Quantity<double, NanoHertz>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciHertz to PicoHertz
    /// </summary>
    /// <param name="val">quantity measured in DeciHertz</param>
    /// <returns>quantity measured in PicoHertz</returns>
	public static Quantity<double, PicoHertz> ToPicoHertz<T>(this BaseQuantity<T, DeciHertz> val) where T:IConvertible {
        return new Quantity<double, PicoHertz>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciHertz to FemtoHertz
    /// </summary>
    /// <param name="val">quantity measured in DeciHertz</param>
    /// <returns>quantity measured in FemtoHertz</returns>
	public static Quantity<double, FemtoHertz> ToFemtoHertz<T>(this BaseQuantity<T, DeciHertz> val) where T:IConvertible {
        return new Quantity<double, FemtoHertz>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciHertz to AttoHertz
    /// </summary>
    /// <param name="val">quantity measured in DeciHertz</param>
    /// <returns>quantity measured in AttoHertz</returns>
	public static Quantity<double, AttoHertz> ToAttoHertz<T>(this BaseQuantity<T, DeciHertz> val) where T:IConvertible {
        return new Quantity<double, AttoHertz>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciHertz to ZeptoHertz
    /// </summary>
    /// <param name="val">quantity measured in DeciHertz</param>
    /// <returns>quantity measured in ZeptoHertz</returns>
	public static Quantity<double, ZeptoHertz> ToZeptoHertz<T>(this BaseQuantity<T, DeciHertz> val) where T:IConvertible {
        return new Quantity<double, ZeptoHertz>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciHertz to YoctoHertz
    /// </summary>
    /// <param name="val">quantity measured in DeciHertz</param>
    /// <returns>quantity measured in YoctoHertz</returns>
	public static Quantity<double, YoctoHertz> ToYoctoHertz<T>(this BaseQuantity<T, DeciHertz> val) where T:IConvertible {
        return new Quantity<double, YoctoHertz>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert CentiHertz to YottaHertz
    /// </summary>
    /// <param name="val">quantity measured in CentiHertz</param>
    /// <returns>quantity measured in YottaHertz</returns>
	public static Quantity<double, YottaHertz> ToYottaHertz<T>(this BaseQuantity<T, CentiHertz> val) where T:IConvertible {
        return new Quantity<double, YottaHertz>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiHertz to ZettaHertz
    /// </summary>
    /// <param name="val">quantity measured in CentiHertz</param>
    /// <returns>quantity measured in ZettaHertz</returns>
	public static Quantity<double, ZettaHertz> ToZettaHertz<T>(this BaseQuantity<T, CentiHertz> val) where T:IConvertible {
        return new Quantity<double, ZettaHertz>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiHertz to ExaHertz
    /// </summary>
    /// <param name="val">quantity measured in CentiHertz</param>
    /// <returns>quantity measured in ExaHertz</returns>
	public static Quantity<double, ExaHertz> ToExaHertz<T>(this BaseQuantity<T, CentiHertz> val) where T:IConvertible {
        return new Quantity<double, ExaHertz>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiHertz to PetaHertz
    /// </summary>
    /// <param name="val">quantity measured in CentiHertz</param>
    /// <returns>quantity measured in PetaHertz</returns>
	public static Quantity<double, PetaHertz> ToPetaHertz<T>(this BaseQuantity<T, CentiHertz> val) where T:IConvertible {
        return new Quantity<double, PetaHertz>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiHertz to TeraHertz
    /// </summary>
    /// <param name="val">quantity measured in CentiHertz</param>
    /// <returns>quantity measured in TeraHertz</returns>
	public static Quantity<double, TeraHertz> ToTeraHertz<T>(this BaseQuantity<T, CentiHertz> val) where T:IConvertible {
        return new Quantity<double, TeraHertz>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiHertz to GigaHertz
    /// </summary>
    /// <param name="val">quantity measured in CentiHertz</param>
    /// <returns>quantity measured in GigaHertz</returns>
	public static Quantity<double, GigaHertz> ToGigaHertz<T>(this BaseQuantity<T, CentiHertz> val) where T:IConvertible {
        return new Quantity<double, GigaHertz>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiHertz to MegaHertz
    /// </summary>
    /// <param name="val">quantity measured in CentiHertz</param>
    /// <returns>quantity measured in MegaHertz</returns>
	public static Quantity<double, MegaHertz> ToMegaHertz<T>(this BaseQuantity<T, CentiHertz> val) where T:IConvertible {
        return new Quantity<double, MegaHertz>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiHertz to KiloHertz
    /// </summary>
    /// <param name="val">quantity measured in CentiHertz</param>
    /// <returns>quantity measured in KiloHertz</returns>
	public static Quantity<double, KiloHertz> ToKiloHertz<T>(this BaseQuantity<T, CentiHertz> val) where T:IConvertible {
        return new Quantity<double, KiloHertz>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiHertz to HectoHertz
    /// </summary>
    /// <param name="val">quantity measured in CentiHertz</param>
    /// <returns>quantity measured in HectoHertz</returns>
	public static Quantity<double, HectoHertz> ToHectoHertz<T>(this BaseQuantity<T, CentiHertz> val) where T:IConvertible {
        return new Quantity<double, HectoHertz>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiHertz to DekaHertz
    /// </summary>
    /// <param name="val">quantity measured in CentiHertz</param>
    /// <returns>quantity measured in DekaHertz</returns>
	public static Quantity<double, DekaHertz> ToDekaHertz<T>(this BaseQuantity<T, CentiHertz> val) where T:IConvertible {
        return new Quantity<double, DekaHertz>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiHertz to DeciHertz
    /// </summary>
    /// <param name="val">quantity measured in CentiHertz</param>
    /// <returns>quantity measured in DeciHertz</returns>
	public static Quantity<double, DeciHertz> ToDeciHertz<T>(this BaseQuantity<T, CentiHertz> val) where T:IConvertible {
        return new Quantity<double, DeciHertz>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiHertz to MilliHertz
    /// </summary>
    /// <param name="val">quantity measured in CentiHertz</param>
    /// <returns>quantity measured in MilliHertz</returns>
	public static Quantity<double, MilliHertz> ToMilliHertz<T>(this BaseQuantity<T, CentiHertz> val) where T:IConvertible {
        return new Quantity<double, MilliHertz>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiHertz to MicroHertz
    /// </summary>
    /// <param name="val">quantity measured in CentiHertz</param>
    /// <returns>quantity measured in MicroHertz</returns>
	public static Quantity<double, MicroHertz> ToMicroHertz<T>(this BaseQuantity<T, CentiHertz> val) where T:IConvertible {
        return new Quantity<double, MicroHertz>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiHertz to NanoHertz
    /// </summary>
    /// <param name="val">quantity measured in CentiHertz</param>
    /// <returns>quantity measured in NanoHertz</returns>
	public static Quantity<double, NanoHertz> ToNanoHertz<T>(this BaseQuantity<T, CentiHertz> val) where T:IConvertible {
        return new Quantity<double, NanoHertz>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiHertz to PicoHertz
    /// </summary>
    /// <param name="val">quantity measured in CentiHertz</param>
    /// <returns>quantity measured in PicoHertz</returns>
	public static Quantity<double, PicoHertz> ToPicoHertz<T>(this BaseQuantity<T, CentiHertz> val) where T:IConvertible {
        return new Quantity<double, PicoHertz>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiHertz to FemtoHertz
    /// </summary>
    /// <param name="val">quantity measured in CentiHertz</param>
    /// <returns>quantity measured in FemtoHertz</returns>
	public static Quantity<double, FemtoHertz> ToFemtoHertz<T>(this BaseQuantity<T, CentiHertz> val) where T:IConvertible {
        return new Quantity<double, FemtoHertz>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiHertz to AttoHertz
    /// </summary>
    /// <param name="val">quantity measured in CentiHertz</param>
    /// <returns>quantity measured in AttoHertz</returns>
	public static Quantity<double, AttoHertz> ToAttoHertz<T>(this BaseQuantity<T, CentiHertz> val) where T:IConvertible {
        return new Quantity<double, AttoHertz>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiHertz to ZeptoHertz
    /// </summary>
    /// <param name="val">quantity measured in CentiHertz</param>
    /// <returns>quantity measured in ZeptoHertz</returns>
	public static Quantity<double, ZeptoHertz> ToZeptoHertz<T>(this BaseQuantity<T, CentiHertz> val) where T:IConvertible {
        return new Quantity<double, ZeptoHertz>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiHertz to YoctoHertz
    /// </summary>
    /// <param name="val">quantity measured in CentiHertz</param>
    /// <returns>quantity measured in YoctoHertz</returns>
	public static Quantity<double, YoctoHertz> ToYoctoHertz<T>(this BaseQuantity<T, CentiHertz> val) where T:IConvertible {
        return new Quantity<double, YoctoHertz>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert MilliHertz to YottaHertz
    /// </summary>
    /// <param name="val">quantity measured in MilliHertz</param>
    /// <returns>quantity measured in YottaHertz</returns>
	public static Quantity<double, YottaHertz> ToYottaHertz<T>(this BaseQuantity<T, MilliHertz> val) where T:IConvertible {
        return new Quantity<double, YottaHertz>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliHertz to ZettaHertz
    /// </summary>
    /// <param name="val">quantity measured in MilliHertz</param>
    /// <returns>quantity measured in ZettaHertz</returns>
	public static Quantity<double, ZettaHertz> ToZettaHertz<T>(this BaseQuantity<T, MilliHertz> val) where T:IConvertible {
        return new Quantity<double, ZettaHertz>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliHertz to ExaHertz
    /// </summary>
    /// <param name="val">quantity measured in MilliHertz</param>
    /// <returns>quantity measured in ExaHertz</returns>
	public static Quantity<double, ExaHertz> ToExaHertz<T>(this BaseQuantity<T, MilliHertz> val) where T:IConvertible {
        return new Quantity<double, ExaHertz>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliHertz to PetaHertz
    /// </summary>
    /// <param name="val">quantity measured in MilliHertz</param>
    /// <returns>quantity measured in PetaHertz</returns>
	public static Quantity<double, PetaHertz> ToPetaHertz<T>(this BaseQuantity<T, MilliHertz> val) where T:IConvertible {
        return new Quantity<double, PetaHertz>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliHertz to TeraHertz
    /// </summary>
    /// <param name="val">quantity measured in MilliHertz</param>
    /// <returns>quantity measured in TeraHertz</returns>
	public static Quantity<double, TeraHertz> ToTeraHertz<T>(this BaseQuantity<T, MilliHertz> val) where T:IConvertible {
        return new Quantity<double, TeraHertz>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliHertz to GigaHertz
    /// </summary>
    /// <param name="val">quantity measured in MilliHertz</param>
    /// <returns>quantity measured in GigaHertz</returns>
	public static Quantity<double, GigaHertz> ToGigaHertz<T>(this BaseQuantity<T, MilliHertz> val) where T:IConvertible {
        return new Quantity<double, GigaHertz>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliHertz to MegaHertz
    /// </summary>
    /// <param name="val">quantity measured in MilliHertz</param>
    /// <returns>quantity measured in MegaHertz</returns>
	public static Quantity<double, MegaHertz> ToMegaHertz<T>(this BaseQuantity<T, MilliHertz> val) where T:IConvertible {
        return new Quantity<double, MegaHertz>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliHertz to KiloHertz
    /// </summary>
    /// <param name="val">quantity measured in MilliHertz</param>
    /// <returns>quantity measured in KiloHertz</returns>
	public static Quantity<double, KiloHertz> ToKiloHertz<T>(this BaseQuantity<T, MilliHertz> val) where T:IConvertible {
        return new Quantity<double, KiloHertz>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliHertz to HectoHertz
    /// </summary>
    /// <param name="val">quantity measured in MilliHertz</param>
    /// <returns>quantity measured in HectoHertz</returns>
	public static Quantity<double, HectoHertz> ToHectoHertz<T>(this BaseQuantity<T, MilliHertz> val) where T:IConvertible {
        return new Quantity<double, HectoHertz>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliHertz to DekaHertz
    /// </summary>
    /// <param name="val">quantity measured in MilliHertz</param>
    /// <returns>quantity measured in DekaHertz</returns>
	public static Quantity<double, DekaHertz> ToDekaHertz<T>(this BaseQuantity<T, MilliHertz> val) where T:IConvertible {
        return new Quantity<double, DekaHertz>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliHertz to DeciHertz
    /// </summary>
    /// <param name="val">quantity measured in MilliHertz</param>
    /// <returns>quantity measured in DeciHertz</returns>
	public static Quantity<double, DeciHertz> ToDeciHertz<T>(this BaseQuantity<T, MilliHertz> val) where T:IConvertible {
        return new Quantity<double, DeciHertz>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliHertz to CentiHertz
    /// </summary>
    /// <param name="val">quantity measured in MilliHertz</param>
    /// <returns>quantity measured in CentiHertz</returns>
	public static Quantity<double, CentiHertz> ToCentiHertz<T>(this BaseQuantity<T, MilliHertz> val) where T:IConvertible {
        return new Quantity<double, CentiHertz>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliHertz to MicroHertz
    /// </summary>
    /// <param name="val">quantity measured in MilliHertz</param>
    /// <returns>quantity measured in MicroHertz</returns>
	public static Quantity<double, MicroHertz> ToMicroHertz<T>(this BaseQuantity<T, MilliHertz> val) where T:IConvertible {
        return new Quantity<double, MicroHertz>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliHertz to NanoHertz
    /// </summary>
    /// <param name="val">quantity measured in MilliHertz</param>
    /// <returns>quantity measured in NanoHertz</returns>
	public static Quantity<double, NanoHertz> ToNanoHertz<T>(this BaseQuantity<T, MilliHertz> val) where T:IConvertible {
        return new Quantity<double, NanoHertz>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliHertz to PicoHertz
    /// </summary>
    /// <param name="val">quantity measured in MilliHertz</param>
    /// <returns>quantity measured in PicoHertz</returns>
	public static Quantity<double, PicoHertz> ToPicoHertz<T>(this BaseQuantity<T, MilliHertz> val) where T:IConvertible {
        return new Quantity<double, PicoHertz>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliHertz to FemtoHertz
    /// </summary>
    /// <param name="val">quantity measured in MilliHertz</param>
    /// <returns>quantity measured in FemtoHertz</returns>
	public static Quantity<double, FemtoHertz> ToFemtoHertz<T>(this BaseQuantity<T, MilliHertz> val) where T:IConvertible {
        return new Quantity<double, FemtoHertz>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliHertz to AttoHertz
    /// </summary>
    /// <param name="val">quantity measured in MilliHertz</param>
    /// <returns>quantity measured in AttoHertz</returns>
	public static Quantity<double, AttoHertz> ToAttoHertz<T>(this BaseQuantity<T, MilliHertz> val) where T:IConvertible {
        return new Quantity<double, AttoHertz>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliHertz to ZeptoHertz
    /// </summary>
    /// <param name="val">quantity measured in MilliHertz</param>
    /// <returns>quantity measured in ZeptoHertz</returns>
	public static Quantity<double, ZeptoHertz> ToZeptoHertz<T>(this BaseQuantity<T, MilliHertz> val) where T:IConvertible {
        return new Quantity<double, ZeptoHertz>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliHertz to YoctoHertz
    /// </summary>
    /// <param name="val">quantity measured in MilliHertz</param>
    /// <returns>quantity measured in YoctoHertz</returns>
	public static Quantity<double, YoctoHertz> ToYoctoHertz<T>(this BaseQuantity<T, MilliHertz> val) where T:IConvertible {
        return new Quantity<double, YoctoHertz>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MicroHertz to YottaHertz
    /// </summary>
    /// <param name="val">quantity measured in MicroHertz</param>
    /// <returns>quantity measured in YottaHertz</returns>
	public static Quantity<double, YottaHertz> ToYottaHertz<T>(this BaseQuantity<T, MicroHertz> val) where T:IConvertible {
        return new Quantity<double, YottaHertz>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroHertz to ZettaHertz
    /// </summary>
    /// <param name="val">quantity measured in MicroHertz</param>
    /// <returns>quantity measured in ZettaHertz</returns>
	public static Quantity<double, ZettaHertz> ToZettaHertz<T>(this BaseQuantity<T, MicroHertz> val) where T:IConvertible {
        return new Quantity<double, ZettaHertz>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroHertz to ExaHertz
    /// </summary>
    /// <param name="val">quantity measured in MicroHertz</param>
    /// <returns>quantity measured in ExaHertz</returns>
	public static Quantity<double, ExaHertz> ToExaHertz<T>(this BaseQuantity<T, MicroHertz> val) where T:IConvertible {
        return new Quantity<double, ExaHertz>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroHertz to PetaHertz
    /// </summary>
    /// <param name="val">quantity measured in MicroHertz</param>
    /// <returns>quantity measured in PetaHertz</returns>
	public static Quantity<double, PetaHertz> ToPetaHertz<T>(this BaseQuantity<T, MicroHertz> val) where T:IConvertible {
        return new Quantity<double, PetaHertz>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroHertz to TeraHertz
    /// </summary>
    /// <param name="val">quantity measured in MicroHertz</param>
    /// <returns>quantity measured in TeraHertz</returns>
	public static Quantity<double, TeraHertz> ToTeraHertz<T>(this BaseQuantity<T, MicroHertz> val) where T:IConvertible {
        return new Quantity<double, TeraHertz>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroHertz to GigaHertz
    /// </summary>
    /// <param name="val">quantity measured in MicroHertz</param>
    /// <returns>quantity measured in GigaHertz</returns>
	public static Quantity<double, GigaHertz> ToGigaHertz<T>(this BaseQuantity<T, MicroHertz> val) where T:IConvertible {
        return new Quantity<double, GigaHertz>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroHertz to MegaHertz
    /// </summary>
    /// <param name="val">quantity measured in MicroHertz</param>
    /// <returns>quantity measured in MegaHertz</returns>
	public static Quantity<double, MegaHertz> ToMegaHertz<T>(this BaseQuantity<T, MicroHertz> val) where T:IConvertible {
        return new Quantity<double, MegaHertz>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroHertz to KiloHertz
    /// </summary>
    /// <param name="val">quantity measured in MicroHertz</param>
    /// <returns>quantity measured in KiloHertz</returns>
	public static Quantity<double, KiloHertz> ToKiloHertz<T>(this BaseQuantity<T, MicroHertz> val) where T:IConvertible {
        return new Quantity<double, KiloHertz>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroHertz to HectoHertz
    /// </summary>
    /// <param name="val">quantity measured in MicroHertz</param>
    /// <returns>quantity measured in HectoHertz</returns>
	public static Quantity<double, HectoHertz> ToHectoHertz<T>(this BaseQuantity<T, MicroHertz> val) where T:IConvertible {
        return new Quantity<double, HectoHertz>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroHertz to DekaHertz
    /// </summary>
    /// <param name="val">quantity measured in MicroHertz</param>
    /// <returns>quantity measured in DekaHertz</returns>
	public static Quantity<double, DekaHertz> ToDekaHertz<T>(this BaseQuantity<T, MicroHertz> val) where T:IConvertible {
        return new Quantity<double, DekaHertz>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroHertz to DeciHertz
    /// </summary>
    /// <param name="val">quantity measured in MicroHertz</param>
    /// <returns>quantity measured in DeciHertz</returns>
	public static Quantity<double, DeciHertz> ToDeciHertz<T>(this BaseQuantity<T, MicroHertz> val) where T:IConvertible {
        return new Quantity<double, DeciHertz>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroHertz to CentiHertz
    /// </summary>
    /// <param name="val">quantity measured in MicroHertz</param>
    /// <returns>quantity measured in CentiHertz</returns>
	public static Quantity<double, CentiHertz> ToCentiHertz<T>(this BaseQuantity<T, MicroHertz> val) where T:IConvertible {
        return new Quantity<double, CentiHertz>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroHertz to MilliHertz
    /// </summary>
    /// <param name="val">quantity measured in MicroHertz</param>
    /// <returns>quantity measured in MilliHertz</returns>
	public static Quantity<double, MilliHertz> ToMilliHertz<T>(this BaseQuantity<T, MicroHertz> val) where T:IConvertible {
        return new Quantity<double, MilliHertz>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroHertz to NanoHertz
    /// </summary>
    /// <param name="val">quantity measured in MicroHertz</param>
    /// <returns>quantity measured in NanoHertz</returns>
	public static Quantity<double, NanoHertz> ToNanoHertz<T>(this BaseQuantity<T, MicroHertz> val) where T:IConvertible {
        return new Quantity<double, NanoHertz>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroHertz to PicoHertz
    /// </summary>
    /// <param name="val">quantity measured in MicroHertz</param>
    /// <returns>quantity measured in PicoHertz</returns>
	public static Quantity<double, PicoHertz> ToPicoHertz<T>(this BaseQuantity<T, MicroHertz> val) where T:IConvertible {
        return new Quantity<double, PicoHertz>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroHertz to FemtoHertz
    /// </summary>
    /// <param name="val">quantity measured in MicroHertz</param>
    /// <returns>quantity measured in FemtoHertz</returns>
	public static Quantity<double, FemtoHertz> ToFemtoHertz<T>(this BaseQuantity<T, MicroHertz> val) where T:IConvertible {
        return new Quantity<double, FemtoHertz>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroHertz to AttoHertz
    /// </summary>
    /// <param name="val">quantity measured in MicroHertz</param>
    /// <returns>quantity measured in AttoHertz</returns>
	public static Quantity<double, AttoHertz> ToAttoHertz<T>(this BaseQuantity<T, MicroHertz> val) where T:IConvertible {
        return new Quantity<double, AttoHertz>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroHertz to ZeptoHertz
    /// </summary>
    /// <param name="val">quantity measured in MicroHertz</param>
    /// <returns>quantity measured in ZeptoHertz</returns>
	public static Quantity<double, ZeptoHertz> ToZeptoHertz<T>(this BaseQuantity<T, MicroHertz> val) where T:IConvertible {
        return new Quantity<double, ZeptoHertz>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroHertz to YoctoHertz
    /// </summary>
    /// <param name="val">quantity measured in MicroHertz</param>
    /// <returns>quantity measured in YoctoHertz</returns>
	public static Quantity<double, YoctoHertz> ToYoctoHertz<T>(this BaseQuantity<T, MicroHertz> val) where T:IConvertible {
        return new Quantity<double, YoctoHertz>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert NanoHertz to YottaHertz
    /// </summary>
    /// <param name="val">quantity measured in NanoHertz</param>
    /// <returns>quantity measured in YottaHertz</returns>
	public static Quantity<double, YottaHertz> ToYottaHertz<T>(this BaseQuantity<T, NanoHertz> val) where T:IConvertible {
        return new Quantity<double, YottaHertz>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoHertz to ZettaHertz
    /// </summary>
    /// <param name="val">quantity measured in NanoHertz</param>
    /// <returns>quantity measured in ZettaHertz</returns>
	public static Quantity<double, ZettaHertz> ToZettaHertz<T>(this BaseQuantity<T, NanoHertz> val) where T:IConvertible {
        return new Quantity<double, ZettaHertz>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoHertz to ExaHertz
    /// </summary>
    /// <param name="val">quantity measured in NanoHertz</param>
    /// <returns>quantity measured in ExaHertz</returns>
	public static Quantity<double, ExaHertz> ToExaHertz<T>(this BaseQuantity<T, NanoHertz> val) where T:IConvertible {
        return new Quantity<double, ExaHertz>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoHertz to PetaHertz
    /// </summary>
    /// <param name="val">quantity measured in NanoHertz</param>
    /// <returns>quantity measured in PetaHertz</returns>
	public static Quantity<double, PetaHertz> ToPetaHertz<T>(this BaseQuantity<T, NanoHertz> val) where T:IConvertible {
        return new Quantity<double, PetaHertz>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoHertz to TeraHertz
    /// </summary>
    /// <param name="val">quantity measured in NanoHertz</param>
    /// <returns>quantity measured in TeraHertz</returns>
	public static Quantity<double, TeraHertz> ToTeraHertz<T>(this BaseQuantity<T, NanoHertz> val) where T:IConvertible {
        return new Quantity<double, TeraHertz>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoHertz to GigaHertz
    /// </summary>
    /// <param name="val">quantity measured in NanoHertz</param>
    /// <returns>quantity measured in GigaHertz</returns>
	public static Quantity<double, GigaHertz> ToGigaHertz<T>(this BaseQuantity<T, NanoHertz> val) where T:IConvertible {
        return new Quantity<double, GigaHertz>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoHertz to MegaHertz
    /// </summary>
    /// <param name="val">quantity measured in NanoHertz</param>
    /// <returns>quantity measured in MegaHertz</returns>
	public static Quantity<double, MegaHertz> ToMegaHertz<T>(this BaseQuantity<T, NanoHertz> val) where T:IConvertible {
        return new Quantity<double, MegaHertz>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoHertz to KiloHertz
    /// </summary>
    /// <param name="val">quantity measured in NanoHertz</param>
    /// <returns>quantity measured in KiloHertz</returns>
	public static Quantity<double, KiloHertz> ToKiloHertz<T>(this BaseQuantity<T, NanoHertz> val) where T:IConvertible {
        return new Quantity<double, KiloHertz>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoHertz to HectoHertz
    /// </summary>
    /// <param name="val">quantity measured in NanoHertz</param>
    /// <returns>quantity measured in HectoHertz</returns>
	public static Quantity<double, HectoHertz> ToHectoHertz<T>(this BaseQuantity<T, NanoHertz> val) where T:IConvertible {
        return new Quantity<double, HectoHertz>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoHertz to DekaHertz
    /// </summary>
    /// <param name="val">quantity measured in NanoHertz</param>
    /// <returns>quantity measured in DekaHertz</returns>
	public static Quantity<double, DekaHertz> ToDekaHertz<T>(this BaseQuantity<T, NanoHertz> val) where T:IConvertible {
        return new Quantity<double, DekaHertz>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoHertz to DeciHertz
    /// </summary>
    /// <param name="val">quantity measured in NanoHertz</param>
    /// <returns>quantity measured in DeciHertz</returns>
	public static Quantity<double, DeciHertz> ToDeciHertz<T>(this BaseQuantity<T, NanoHertz> val) where T:IConvertible {
        return new Quantity<double, DeciHertz>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoHertz to CentiHertz
    /// </summary>
    /// <param name="val">quantity measured in NanoHertz</param>
    /// <returns>quantity measured in CentiHertz</returns>
	public static Quantity<double, CentiHertz> ToCentiHertz<T>(this BaseQuantity<T, NanoHertz> val) where T:IConvertible {
        return new Quantity<double, CentiHertz>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoHertz to MilliHertz
    /// </summary>
    /// <param name="val">quantity measured in NanoHertz</param>
    /// <returns>quantity measured in MilliHertz</returns>
	public static Quantity<double, MilliHertz> ToMilliHertz<T>(this BaseQuantity<T, NanoHertz> val) where T:IConvertible {
        return new Quantity<double, MilliHertz>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoHertz to MicroHertz
    /// </summary>
    /// <param name="val">quantity measured in NanoHertz</param>
    /// <returns>quantity measured in MicroHertz</returns>
	public static Quantity<double, MicroHertz> ToMicroHertz<T>(this BaseQuantity<T, NanoHertz> val) where T:IConvertible {
        return new Quantity<double, MicroHertz>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoHertz to PicoHertz
    /// </summary>
    /// <param name="val">quantity measured in NanoHertz</param>
    /// <returns>quantity measured in PicoHertz</returns>
	public static Quantity<double, PicoHertz> ToPicoHertz<T>(this BaseQuantity<T, NanoHertz> val) where T:IConvertible {
        return new Quantity<double, PicoHertz>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoHertz to FemtoHertz
    /// </summary>
    /// <param name="val">quantity measured in NanoHertz</param>
    /// <returns>quantity measured in FemtoHertz</returns>
	public static Quantity<double, FemtoHertz> ToFemtoHertz<T>(this BaseQuantity<T, NanoHertz> val) where T:IConvertible {
        return new Quantity<double, FemtoHertz>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoHertz to AttoHertz
    /// </summary>
    /// <param name="val">quantity measured in NanoHertz</param>
    /// <returns>quantity measured in AttoHertz</returns>
	public static Quantity<double, AttoHertz> ToAttoHertz<T>(this BaseQuantity<T, NanoHertz> val) where T:IConvertible {
        return new Quantity<double, AttoHertz>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoHertz to ZeptoHertz
    /// </summary>
    /// <param name="val">quantity measured in NanoHertz</param>
    /// <returns>quantity measured in ZeptoHertz</returns>
	public static Quantity<double, ZeptoHertz> ToZeptoHertz<T>(this BaseQuantity<T, NanoHertz> val) where T:IConvertible {
        return new Quantity<double, ZeptoHertz>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoHertz to YoctoHertz
    /// </summary>
    /// <param name="val">quantity measured in NanoHertz</param>
    /// <returns>quantity measured in YoctoHertz</returns>
	public static Quantity<double, YoctoHertz> ToYoctoHertz<T>(this BaseQuantity<T, NanoHertz> val) where T:IConvertible {
        return new Quantity<double, YoctoHertz>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert PicoHertz to YottaHertz
    /// </summary>
    /// <param name="val">quantity measured in PicoHertz</param>
    /// <returns>quantity measured in YottaHertz</returns>
	public static Quantity<double, YottaHertz> ToYottaHertz<T>(this BaseQuantity<T, PicoHertz> val) where T:IConvertible {
        return new Quantity<double, YottaHertz>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoHertz to ZettaHertz
    /// </summary>
    /// <param name="val">quantity measured in PicoHertz</param>
    /// <returns>quantity measured in ZettaHertz</returns>
	public static Quantity<double, ZettaHertz> ToZettaHertz<T>(this BaseQuantity<T, PicoHertz> val) where T:IConvertible {
        return new Quantity<double, ZettaHertz>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoHertz to ExaHertz
    /// </summary>
    /// <param name="val">quantity measured in PicoHertz</param>
    /// <returns>quantity measured in ExaHertz</returns>
	public static Quantity<double, ExaHertz> ToExaHertz<T>(this BaseQuantity<T, PicoHertz> val) where T:IConvertible {
        return new Quantity<double, ExaHertz>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoHertz to PetaHertz
    /// </summary>
    /// <param name="val">quantity measured in PicoHertz</param>
    /// <returns>quantity measured in PetaHertz</returns>
	public static Quantity<double, PetaHertz> ToPetaHertz<T>(this BaseQuantity<T, PicoHertz> val) where T:IConvertible {
        return new Quantity<double, PetaHertz>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoHertz to TeraHertz
    /// </summary>
    /// <param name="val">quantity measured in PicoHertz</param>
    /// <returns>quantity measured in TeraHertz</returns>
	public static Quantity<double, TeraHertz> ToTeraHertz<T>(this BaseQuantity<T, PicoHertz> val) where T:IConvertible {
        return new Quantity<double, TeraHertz>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoHertz to GigaHertz
    /// </summary>
    /// <param name="val">quantity measured in PicoHertz</param>
    /// <returns>quantity measured in GigaHertz</returns>
	public static Quantity<double, GigaHertz> ToGigaHertz<T>(this BaseQuantity<T, PicoHertz> val) where T:IConvertible {
        return new Quantity<double, GigaHertz>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoHertz to MegaHertz
    /// </summary>
    /// <param name="val">quantity measured in PicoHertz</param>
    /// <returns>quantity measured in MegaHertz</returns>
	public static Quantity<double, MegaHertz> ToMegaHertz<T>(this BaseQuantity<T, PicoHertz> val) where T:IConvertible {
        return new Quantity<double, MegaHertz>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoHertz to KiloHertz
    /// </summary>
    /// <param name="val">quantity measured in PicoHertz</param>
    /// <returns>quantity measured in KiloHertz</returns>
	public static Quantity<double, KiloHertz> ToKiloHertz<T>(this BaseQuantity<T, PicoHertz> val) where T:IConvertible {
        return new Quantity<double, KiloHertz>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoHertz to HectoHertz
    /// </summary>
    /// <param name="val">quantity measured in PicoHertz</param>
    /// <returns>quantity measured in HectoHertz</returns>
	public static Quantity<double, HectoHertz> ToHectoHertz<T>(this BaseQuantity<T, PicoHertz> val) where T:IConvertible {
        return new Quantity<double, HectoHertz>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoHertz to DekaHertz
    /// </summary>
    /// <param name="val">quantity measured in PicoHertz</param>
    /// <returns>quantity measured in DekaHertz</returns>
	public static Quantity<double, DekaHertz> ToDekaHertz<T>(this BaseQuantity<T, PicoHertz> val) where T:IConvertible {
        return new Quantity<double, DekaHertz>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoHertz to DeciHertz
    /// </summary>
    /// <param name="val">quantity measured in PicoHertz</param>
    /// <returns>quantity measured in DeciHertz</returns>
	public static Quantity<double, DeciHertz> ToDeciHertz<T>(this BaseQuantity<T, PicoHertz> val) where T:IConvertible {
        return new Quantity<double, DeciHertz>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoHertz to CentiHertz
    /// </summary>
    /// <param name="val">quantity measured in PicoHertz</param>
    /// <returns>quantity measured in CentiHertz</returns>
	public static Quantity<double, CentiHertz> ToCentiHertz<T>(this BaseQuantity<T, PicoHertz> val) where T:IConvertible {
        return new Quantity<double, CentiHertz>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoHertz to MilliHertz
    /// </summary>
    /// <param name="val">quantity measured in PicoHertz</param>
    /// <returns>quantity measured in MilliHertz</returns>
	public static Quantity<double, MilliHertz> ToMilliHertz<T>(this BaseQuantity<T, PicoHertz> val) where T:IConvertible {
        return new Quantity<double, MilliHertz>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoHertz to MicroHertz
    /// </summary>
    /// <param name="val">quantity measured in PicoHertz</param>
    /// <returns>quantity measured in MicroHertz</returns>
	public static Quantity<double, MicroHertz> ToMicroHertz<T>(this BaseQuantity<T, PicoHertz> val) where T:IConvertible {
        return new Quantity<double, MicroHertz>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoHertz to NanoHertz
    /// </summary>
    /// <param name="val">quantity measured in PicoHertz</param>
    /// <returns>quantity measured in NanoHertz</returns>
	public static Quantity<double, NanoHertz> ToNanoHertz<T>(this BaseQuantity<T, PicoHertz> val) where T:IConvertible {
        return new Quantity<double, NanoHertz>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoHertz to FemtoHertz
    /// </summary>
    /// <param name="val">quantity measured in PicoHertz</param>
    /// <returns>quantity measured in FemtoHertz</returns>
	public static Quantity<double, FemtoHertz> ToFemtoHertz<T>(this BaseQuantity<T, PicoHertz> val) where T:IConvertible {
        return new Quantity<double, FemtoHertz>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoHertz to AttoHertz
    /// </summary>
    /// <param name="val">quantity measured in PicoHertz</param>
    /// <returns>quantity measured in AttoHertz</returns>
	public static Quantity<double, AttoHertz> ToAttoHertz<T>(this BaseQuantity<T, PicoHertz> val) where T:IConvertible {
        return new Quantity<double, AttoHertz>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoHertz to ZeptoHertz
    /// </summary>
    /// <param name="val">quantity measured in PicoHertz</param>
    /// <returns>quantity measured in ZeptoHertz</returns>
	public static Quantity<double, ZeptoHertz> ToZeptoHertz<T>(this BaseQuantity<T, PicoHertz> val) where T:IConvertible {
        return new Quantity<double, ZeptoHertz>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoHertz to YoctoHertz
    /// </summary>
    /// <param name="val">quantity measured in PicoHertz</param>
    /// <returns>quantity measured in YoctoHertz</returns>
	public static Quantity<double, YoctoHertz> ToYoctoHertz<T>(this BaseQuantity<T, PicoHertz> val) where T:IConvertible {
        return new Quantity<double, YoctoHertz>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert FemtoHertz to YottaHertz
    /// </summary>
    /// <param name="val">quantity measured in FemtoHertz</param>
    /// <returns>quantity measured in YottaHertz</returns>
	public static Quantity<double, YottaHertz> ToYottaHertz<T>(this BaseQuantity<T, FemtoHertz> val) where T:IConvertible {
        return new Quantity<double, YottaHertz>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoHertz to ZettaHertz
    /// </summary>
    /// <param name="val">quantity measured in FemtoHertz</param>
    /// <returns>quantity measured in ZettaHertz</returns>
	public static Quantity<double, ZettaHertz> ToZettaHertz<T>(this BaseQuantity<T, FemtoHertz> val) where T:IConvertible {
        return new Quantity<double, ZettaHertz>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoHertz to ExaHertz
    /// </summary>
    /// <param name="val">quantity measured in FemtoHertz</param>
    /// <returns>quantity measured in ExaHertz</returns>
	public static Quantity<double, ExaHertz> ToExaHertz<T>(this BaseQuantity<T, FemtoHertz> val) where T:IConvertible {
        return new Quantity<double, ExaHertz>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoHertz to PetaHertz
    /// </summary>
    /// <param name="val">quantity measured in FemtoHertz</param>
    /// <returns>quantity measured in PetaHertz</returns>
	public static Quantity<double, PetaHertz> ToPetaHertz<T>(this BaseQuantity<T, FemtoHertz> val) where T:IConvertible {
        return new Quantity<double, PetaHertz>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoHertz to TeraHertz
    /// </summary>
    /// <param name="val">quantity measured in FemtoHertz</param>
    /// <returns>quantity measured in TeraHertz</returns>
	public static Quantity<double, TeraHertz> ToTeraHertz<T>(this BaseQuantity<T, FemtoHertz> val) where T:IConvertible {
        return new Quantity<double, TeraHertz>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoHertz to GigaHertz
    /// </summary>
    /// <param name="val">quantity measured in FemtoHertz</param>
    /// <returns>quantity measured in GigaHertz</returns>
	public static Quantity<double, GigaHertz> ToGigaHertz<T>(this BaseQuantity<T, FemtoHertz> val) where T:IConvertible {
        return new Quantity<double, GigaHertz>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoHertz to MegaHertz
    /// </summary>
    /// <param name="val">quantity measured in FemtoHertz</param>
    /// <returns>quantity measured in MegaHertz</returns>
	public static Quantity<double, MegaHertz> ToMegaHertz<T>(this BaseQuantity<T, FemtoHertz> val) where T:IConvertible {
        return new Quantity<double, MegaHertz>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoHertz to KiloHertz
    /// </summary>
    /// <param name="val">quantity measured in FemtoHertz</param>
    /// <returns>quantity measured in KiloHertz</returns>
	public static Quantity<double, KiloHertz> ToKiloHertz<T>(this BaseQuantity<T, FemtoHertz> val) where T:IConvertible {
        return new Quantity<double, KiloHertz>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoHertz to HectoHertz
    /// </summary>
    /// <param name="val">quantity measured in FemtoHertz</param>
    /// <returns>quantity measured in HectoHertz</returns>
	public static Quantity<double, HectoHertz> ToHectoHertz<T>(this BaseQuantity<T, FemtoHertz> val) where T:IConvertible {
        return new Quantity<double, HectoHertz>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoHertz to DekaHertz
    /// </summary>
    /// <param name="val">quantity measured in FemtoHertz</param>
    /// <returns>quantity measured in DekaHertz</returns>
	public static Quantity<double, DekaHertz> ToDekaHertz<T>(this BaseQuantity<T, FemtoHertz> val) where T:IConvertible {
        return new Quantity<double, DekaHertz>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoHertz to DeciHertz
    /// </summary>
    /// <param name="val">quantity measured in FemtoHertz</param>
    /// <returns>quantity measured in DeciHertz</returns>
	public static Quantity<double, DeciHertz> ToDeciHertz<T>(this BaseQuantity<T, FemtoHertz> val) where T:IConvertible {
        return new Quantity<double, DeciHertz>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoHertz to CentiHertz
    /// </summary>
    /// <param name="val">quantity measured in FemtoHertz</param>
    /// <returns>quantity measured in CentiHertz</returns>
	public static Quantity<double, CentiHertz> ToCentiHertz<T>(this BaseQuantity<T, FemtoHertz> val) where T:IConvertible {
        return new Quantity<double, CentiHertz>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoHertz to MilliHertz
    /// </summary>
    /// <param name="val">quantity measured in FemtoHertz</param>
    /// <returns>quantity measured in MilliHertz</returns>
	public static Quantity<double, MilliHertz> ToMilliHertz<T>(this BaseQuantity<T, FemtoHertz> val) where T:IConvertible {
        return new Quantity<double, MilliHertz>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoHertz to MicroHertz
    /// </summary>
    /// <param name="val">quantity measured in FemtoHertz</param>
    /// <returns>quantity measured in MicroHertz</returns>
	public static Quantity<double, MicroHertz> ToMicroHertz<T>(this BaseQuantity<T, FemtoHertz> val) where T:IConvertible {
        return new Quantity<double, MicroHertz>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoHertz to NanoHertz
    /// </summary>
    /// <param name="val">quantity measured in FemtoHertz</param>
    /// <returns>quantity measured in NanoHertz</returns>
	public static Quantity<double, NanoHertz> ToNanoHertz<T>(this BaseQuantity<T, FemtoHertz> val) where T:IConvertible {
        return new Quantity<double, NanoHertz>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoHertz to PicoHertz
    /// </summary>
    /// <param name="val">quantity measured in FemtoHertz</param>
    /// <returns>quantity measured in PicoHertz</returns>
	public static Quantity<double, PicoHertz> ToPicoHertz<T>(this BaseQuantity<T, FemtoHertz> val) where T:IConvertible {
        return new Quantity<double, PicoHertz>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoHertz to AttoHertz
    /// </summary>
    /// <param name="val">quantity measured in FemtoHertz</param>
    /// <returns>quantity measured in AttoHertz</returns>
	public static Quantity<double, AttoHertz> ToAttoHertz<T>(this BaseQuantity<T, FemtoHertz> val) where T:IConvertible {
        return new Quantity<double, AttoHertz>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoHertz to ZeptoHertz
    /// </summary>
    /// <param name="val">quantity measured in FemtoHertz</param>
    /// <returns>quantity measured in ZeptoHertz</returns>
	public static Quantity<double, ZeptoHertz> ToZeptoHertz<T>(this BaseQuantity<T, FemtoHertz> val) where T:IConvertible {
        return new Quantity<double, ZeptoHertz>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoHertz to YoctoHertz
    /// </summary>
    /// <param name="val">quantity measured in FemtoHertz</param>
    /// <returns>quantity measured in YoctoHertz</returns>
	public static Quantity<double, YoctoHertz> ToYoctoHertz<T>(this BaseQuantity<T, FemtoHertz> val) where T:IConvertible {
        return new Quantity<double, YoctoHertz>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert AttoHertz to YottaHertz
    /// </summary>
    /// <param name="val">quantity measured in AttoHertz</param>
    /// <returns>quantity measured in YottaHertz</returns>
	public static Quantity<double, YottaHertz> ToYottaHertz<T>(this BaseQuantity<T, AttoHertz> val) where T:IConvertible {
        return new Quantity<double, YottaHertz>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoHertz to ZettaHertz
    /// </summary>
    /// <param name="val">quantity measured in AttoHertz</param>
    /// <returns>quantity measured in ZettaHertz</returns>
	public static Quantity<double, ZettaHertz> ToZettaHertz<T>(this BaseQuantity<T, AttoHertz> val) where T:IConvertible {
        return new Quantity<double, ZettaHertz>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoHertz to ExaHertz
    /// </summary>
    /// <param name="val">quantity measured in AttoHertz</param>
    /// <returns>quantity measured in ExaHertz</returns>
	public static Quantity<double, ExaHertz> ToExaHertz<T>(this BaseQuantity<T, AttoHertz> val) where T:IConvertible {
        return new Quantity<double, ExaHertz>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoHertz to PetaHertz
    /// </summary>
    /// <param name="val">quantity measured in AttoHertz</param>
    /// <returns>quantity measured in PetaHertz</returns>
	public static Quantity<double, PetaHertz> ToPetaHertz<T>(this BaseQuantity<T, AttoHertz> val) where T:IConvertible {
        return new Quantity<double, PetaHertz>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoHertz to TeraHertz
    /// </summary>
    /// <param name="val">quantity measured in AttoHertz</param>
    /// <returns>quantity measured in TeraHertz</returns>
	public static Quantity<double, TeraHertz> ToTeraHertz<T>(this BaseQuantity<T, AttoHertz> val) where T:IConvertible {
        return new Quantity<double, TeraHertz>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoHertz to GigaHertz
    /// </summary>
    /// <param name="val">quantity measured in AttoHertz</param>
    /// <returns>quantity measured in GigaHertz</returns>
	public static Quantity<double, GigaHertz> ToGigaHertz<T>(this BaseQuantity<T, AttoHertz> val) where T:IConvertible {
        return new Quantity<double, GigaHertz>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoHertz to MegaHertz
    /// </summary>
    /// <param name="val">quantity measured in AttoHertz</param>
    /// <returns>quantity measured in MegaHertz</returns>
	public static Quantity<double, MegaHertz> ToMegaHertz<T>(this BaseQuantity<T, AttoHertz> val) where T:IConvertible {
        return new Quantity<double, MegaHertz>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoHertz to KiloHertz
    /// </summary>
    /// <param name="val">quantity measured in AttoHertz</param>
    /// <returns>quantity measured in KiloHertz</returns>
	public static Quantity<double, KiloHertz> ToKiloHertz<T>(this BaseQuantity<T, AttoHertz> val) where T:IConvertible {
        return new Quantity<double, KiloHertz>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoHertz to HectoHertz
    /// </summary>
    /// <param name="val">quantity measured in AttoHertz</param>
    /// <returns>quantity measured in HectoHertz</returns>
	public static Quantity<double, HectoHertz> ToHectoHertz<T>(this BaseQuantity<T, AttoHertz> val) where T:IConvertible {
        return new Quantity<double, HectoHertz>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoHertz to DekaHertz
    /// </summary>
    /// <param name="val">quantity measured in AttoHertz</param>
    /// <returns>quantity measured in DekaHertz</returns>
	public static Quantity<double, DekaHertz> ToDekaHertz<T>(this BaseQuantity<T, AttoHertz> val) where T:IConvertible {
        return new Quantity<double, DekaHertz>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoHertz to DeciHertz
    /// </summary>
    /// <param name="val">quantity measured in AttoHertz</param>
    /// <returns>quantity measured in DeciHertz</returns>
	public static Quantity<double, DeciHertz> ToDeciHertz<T>(this BaseQuantity<T, AttoHertz> val) where T:IConvertible {
        return new Quantity<double, DeciHertz>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoHertz to CentiHertz
    /// </summary>
    /// <param name="val">quantity measured in AttoHertz</param>
    /// <returns>quantity measured in CentiHertz</returns>
	public static Quantity<double, CentiHertz> ToCentiHertz<T>(this BaseQuantity<T, AttoHertz> val) where T:IConvertible {
        return new Quantity<double, CentiHertz>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoHertz to MilliHertz
    /// </summary>
    /// <param name="val">quantity measured in AttoHertz</param>
    /// <returns>quantity measured in MilliHertz</returns>
	public static Quantity<double, MilliHertz> ToMilliHertz<T>(this BaseQuantity<T, AttoHertz> val) where T:IConvertible {
        return new Quantity<double, MilliHertz>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoHertz to MicroHertz
    /// </summary>
    /// <param name="val">quantity measured in AttoHertz</param>
    /// <returns>quantity measured in MicroHertz</returns>
	public static Quantity<double, MicroHertz> ToMicroHertz<T>(this BaseQuantity<T, AttoHertz> val) where T:IConvertible {
        return new Quantity<double, MicroHertz>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoHertz to NanoHertz
    /// </summary>
    /// <param name="val">quantity measured in AttoHertz</param>
    /// <returns>quantity measured in NanoHertz</returns>
	public static Quantity<double, NanoHertz> ToNanoHertz<T>(this BaseQuantity<T, AttoHertz> val) where T:IConvertible {
        return new Quantity<double, NanoHertz>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoHertz to PicoHertz
    /// </summary>
    /// <param name="val">quantity measured in AttoHertz</param>
    /// <returns>quantity measured in PicoHertz</returns>
	public static Quantity<double, PicoHertz> ToPicoHertz<T>(this BaseQuantity<T, AttoHertz> val) where T:IConvertible {
        return new Quantity<double, PicoHertz>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoHertz to FemtoHertz
    /// </summary>
    /// <param name="val">quantity measured in AttoHertz</param>
    /// <returns>quantity measured in FemtoHertz</returns>
	public static Quantity<double, FemtoHertz> ToFemtoHertz<T>(this BaseQuantity<T, AttoHertz> val) where T:IConvertible {
        return new Quantity<double, FemtoHertz>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoHertz to ZeptoHertz
    /// </summary>
    /// <param name="val">quantity measured in AttoHertz</param>
    /// <returns>quantity measured in ZeptoHertz</returns>
	public static Quantity<double, ZeptoHertz> ToZeptoHertz<T>(this BaseQuantity<T, AttoHertz> val) where T:IConvertible {
        return new Quantity<double, ZeptoHertz>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoHertz to YoctoHertz
    /// </summary>
    /// <param name="val">quantity measured in AttoHertz</param>
    /// <returns>quantity measured in YoctoHertz</returns>
	public static Quantity<double, YoctoHertz> ToYoctoHertz<T>(this BaseQuantity<T, AttoHertz> val) where T:IConvertible {
        return new Quantity<double, YoctoHertz>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoHertz to YottaHertz
    /// </summary>
    /// <param name="val">quantity measured in ZeptoHertz</param>
    /// <returns>quantity measured in YottaHertz</returns>
	public static Quantity<double, YottaHertz> ToYottaHertz<T>(this BaseQuantity<T, ZeptoHertz> val) where T:IConvertible {
        return new Quantity<double, YottaHertz>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoHertz to ZettaHertz
    /// </summary>
    /// <param name="val">quantity measured in ZeptoHertz</param>
    /// <returns>quantity measured in ZettaHertz</returns>
	public static Quantity<double, ZettaHertz> ToZettaHertz<T>(this BaseQuantity<T, ZeptoHertz> val) where T:IConvertible {
        return new Quantity<double, ZettaHertz>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoHertz to ExaHertz
    /// </summary>
    /// <param name="val">quantity measured in ZeptoHertz</param>
    /// <returns>quantity measured in ExaHertz</returns>
	public static Quantity<double, ExaHertz> ToExaHertz<T>(this BaseQuantity<T, ZeptoHertz> val) where T:IConvertible {
        return new Quantity<double, ExaHertz>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoHertz to PetaHertz
    /// </summary>
    /// <param name="val">quantity measured in ZeptoHertz</param>
    /// <returns>quantity measured in PetaHertz</returns>
	public static Quantity<double, PetaHertz> ToPetaHertz<T>(this BaseQuantity<T, ZeptoHertz> val) where T:IConvertible {
        return new Quantity<double, PetaHertz>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoHertz to TeraHertz
    /// </summary>
    /// <param name="val">quantity measured in ZeptoHertz</param>
    /// <returns>quantity measured in TeraHertz</returns>
	public static Quantity<double, TeraHertz> ToTeraHertz<T>(this BaseQuantity<T, ZeptoHertz> val) where T:IConvertible {
        return new Quantity<double, TeraHertz>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoHertz to GigaHertz
    /// </summary>
    /// <param name="val">quantity measured in ZeptoHertz</param>
    /// <returns>quantity measured in GigaHertz</returns>
	public static Quantity<double, GigaHertz> ToGigaHertz<T>(this BaseQuantity<T, ZeptoHertz> val) where T:IConvertible {
        return new Quantity<double, GigaHertz>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoHertz to MegaHertz
    /// </summary>
    /// <param name="val">quantity measured in ZeptoHertz</param>
    /// <returns>quantity measured in MegaHertz</returns>
	public static Quantity<double, MegaHertz> ToMegaHertz<T>(this BaseQuantity<T, ZeptoHertz> val) where T:IConvertible {
        return new Quantity<double, MegaHertz>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoHertz to KiloHertz
    /// </summary>
    /// <param name="val">quantity measured in ZeptoHertz</param>
    /// <returns>quantity measured in KiloHertz</returns>
	public static Quantity<double, KiloHertz> ToKiloHertz<T>(this BaseQuantity<T, ZeptoHertz> val) where T:IConvertible {
        return new Quantity<double, KiloHertz>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoHertz to HectoHertz
    /// </summary>
    /// <param name="val">quantity measured in ZeptoHertz</param>
    /// <returns>quantity measured in HectoHertz</returns>
	public static Quantity<double, HectoHertz> ToHectoHertz<T>(this BaseQuantity<T, ZeptoHertz> val) where T:IConvertible {
        return new Quantity<double, HectoHertz>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoHertz to DekaHertz
    /// </summary>
    /// <param name="val">quantity measured in ZeptoHertz</param>
    /// <returns>quantity measured in DekaHertz</returns>
	public static Quantity<double, DekaHertz> ToDekaHertz<T>(this BaseQuantity<T, ZeptoHertz> val) where T:IConvertible {
        return new Quantity<double, DekaHertz>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoHertz to DeciHertz
    /// </summary>
    /// <param name="val">quantity measured in ZeptoHertz</param>
    /// <returns>quantity measured in DeciHertz</returns>
	public static Quantity<double, DeciHertz> ToDeciHertz<T>(this BaseQuantity<T, ZeptoHertz> val) where T:IConvertible {
        return new Quantity<double, DeciHertz>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoHertz to CentiHertz
    /// </summary>
    /// <param name="val">quantity measured in ZeptoHertz</param>
    /// <returns>quantity measured in CentiHertz</returns>
	public static Quantity<double, CentiHertz> ToCentiHertz<T>(this BaseQuantity<T, ZeptoHertz> val) where T:IConvertible {
        return new Quantity<double, CentiHertz>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoHertz to MilliHertz
    /// </summary>
    /// <param name="val">quantity measured in ZeptoHertz</param>
    /// <returns>quantity measured in MilliHertz</returns>
	public static Quantity<double, MilliHertz> ToMilliHertz<T>(this BaseQuantity<T, ZeptoHertz> val) where T:IConvertible {
        return new Quantity<double, MilliHertz>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoHertz to MicroHertz
    /// </summary>
    /// <param name="val">quantity measured in ZeptoHertz</param>
    /// <returns>quantity measured in MicroHertz</returns>
	public static Quantity<double, MicroHertz> ToMicroHertz<T>(this BaseQuantity<T, ZeptoHertz> val) where T:IConvertible {
        return new Quantity<double, MicroHertz>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoHertz to NanoHertz
    /// </summary>
    /// <param name="val">quantity measured in ZeptoHertz</param>
    /// <returns>quantity measured in NanoHertz</returns>
	public static Quantity<double, NanoHertz> ToNanoHertz<T>(this BaseQuantity<T, ZeptoHertz> val) where T:IConvertible {
        return new Quantity<double, NanoHertz>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoHertz to PicoHertz
    /// </summary>
    /// <param name="val">quantity measured in ZeptoHertz</param>
    /// <returns>quantity measured in PicoHertz</returns>
	public static Quantity<double, PicoHertz> ToPicoHertz<T>(this BaseQuantity<T, ZeptoHertz> val) where T:IConvertible {
        return new Quantity<double, PicoHertz>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoHertz to FemtoHertz
    /// </summary>
    /// <param name="val">quantity measured in ZeptoHertz</param>
    /// <returns>quantity measured in FemtoHertz</returns>
	public static Quantity<double, FemtoHertz> ToFemtoHertz<T>(this BaseQuantity<T, ZeptoHertz> val) where T:IConvertible {
        return new Quantity<double, FemtoHertz>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoHertz to AttoHertz
    /// </summary>
    /// <param name="val">quantity measured in ZeptoHertz</param>
    /// <returns>quantity measured in AttoHertz</returns>
	public static Quantity<double, AttoHertz> ToAttoHertz<T>(this BaseQuantity<T, ZeptoHertz> val) where T:IConvertible {
        return new Quantity<double, AttoHertz>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoHertz to YoctoHertz
    /// </summary>
    /// <param name="val">quantity measured in ZeptoHertz</param>
    /// <returns>quantity measured in YoctoHertz</returns>
	public static Quantity<double, YoctoHertz> ToYoctoHertz<T>(this BaseQuantity<T, ZeptoHertz> val) where T:IConvertible {
        return new Quantity<double, YoctoHertz>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert YoctoHertz to YottaHertz
    /// </summary>
    /// <param name="val">quantity measured in YoctoHertz</param>
    /// <returns>quantity measured in YottaHertz</returns>
	public static Quantity<double, YottaHertz> ToYottaHertz<T>(this BaseQuantity<T, YoctoHertz> val) where T:IConvertible {
        return new Quantity<double, YottaHertz>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoHertz to ZettaHertz
    /// </summary>
    /// <param name="val">quantity measured in YoctoHertz</param>
    /// <returns>quantity measured in ZettaHertz</returns>
	public static Quantity<double, ZettaHertz> ToZettaHertz<T>(this BaseQuantity<T, YoctoHertz> val) where T:IConvertible {
        return new Quantity<double, ZettaHertz>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoHertz to ExaHertz
    /// </summary>
    /// <param name="val">quantity measured in YoctoHertz</param>
    /// <returns>quantity measured in ExaHertz</returns>
	public static Quantity<double, ExaHertz> ToExaHertz<T>(this BaseQuantity<T, YoctoHertz> val) where T:IConvertible {
        return new Quantity<double, ExaHertz>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoHertz to PetaHertz
    /// </summary>
    /// <param name="val">quantity measured in YoctoHertz</param>
    /// <returns>quantity measured in PetaHertz</returns>
	public static Quantity<double, PetaHertz> ToPetaHertz<T>(this BaseQuantity<T, YoctoHertz> val) where T:IConvertible {
        return new Quantity<double, PetaHertz>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoHertz to TeraHertz
    /// </summary>
    /// <param name="val">quantity measured in YoctoHertz</param>
    /// <returns>quantity measured in TeraHertz</returns>
	public static Quantity<double, TeraHertz> ToTeraHertz<T>(this BaseQuantity<T, YoctoHertz> val) where T:IConvertible {
        return new Quantity<double, TeraHertz>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoHertz to GigaHertz
    /// </summary>
    /// <param name="val">quantity measured in YoctoHertz</param>
    /// <returns>quantity measured in GigaHertz</returns>
	public static Quantity<double, GigaHertz> ToGigaHertz<T>(this BaseQuantity<T, YoctoHertz> val) where T:IConvertible {
        return new Quantity<double, GigaHertz>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoHertz to MegaHertz
    /// </summary>
    /// <param name="val">quantity measured in YoctoHertz</param>
    /// <returns>quantity measured in MegaHertz</returns>
	public static Quantity<double, MegaHertz> ToMegaHertz<T>(this BaseQuantity<T, YoctoHertz> val) where T:IConvertible {
        return new Quantity<double, MegaHertz>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoHertz to KiloHertz
    /// </summary>
    /// <param name="val">quantity measured in YoctoHertz</param>
    /// <returns>quantity measured in KiloHertz</returns>
	public static Quantity<double, KiloHertz> ToKiloHertz<T>(this BaseQuantity<T, YoctoHertz> val) where T:IConvertible {
        return new Quantity<double, KiloHertz>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoHertz to HectoHertz
    /// </summary>
    /// <param name="val">quantity measured in YoctoHertz</param>
    /// <returns>quantity measured in HectoHertz</returns>
	public static Quantity<double, HectoHertz> ToHectoHertz<T>(this BaseQuantity<T, YoctoHertz> val) where T:IConvertible {
        return new Quantity<double, HectoHertz>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoHertz to DekaHertz
    /// </summary>
    /// <param name="val">quantity measured in YoctoHertz</param>
    /// <returns>quantity measured in DekaHertz</returns>
	public static Quantity<double, DekaHertz> ToDekaHertz<T>(this BaseQuantity<T, YoctoHertz> val) where T:IConvertible {
        return new Quantity<double, DekaHertz>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoHertz to DeciHertz
    /// </summary>
    /// <param name="val">quantity measured in YoctoHertz</param>
    /// <returns>quantity measured in DeciHertz</returns>
	public static Quantity<double, DeciHertz> ToDeciHertz<T>(this BaseQuantity<T, YoctoHertz> val) where T:IConvertible {
        return new Quantity<double, DeciHertz>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoHertz to CentiHertz
    /// </summary>
    /// <param name="val">quantity measured in YoctoHertz</param>
    /// <returns>quantity measured in CentiHertz</returns>
	public static Quantity<double, CentiHertz> ToCentiHertz<T>(this BaseQuantity<T, YoctoHertz> val) where T:IConvertible {
        return new Quantity<double, CentiHertz>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoHertz to MilliHertz
    /// </summary>
    /// <param name="val">quantity measured in YoctoHertz</param>
    /// <returns>quantity measured in MilliHertz</returns>
	public static Quantity<double, MilliHertz> ToMilliHertz<T>(this BaseQuantity<T, YoctoHertz> val) where T:IConvertible {
        return new Quantity<double, MilliHertz>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoHertz to MicroHertz
    /// </summary>
    /// <param name="val">quantity measured in YoctoHertz</param>
    /// <returns>quantity measured in MicroHertz</returns>
	public static Quantity<double, MicroHertz> ToMicroHertz<T>(this BaseQuantity<T, YoctoHertz> val) where T:IConvertible {
        return new Quantity<double, MicroHertz>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoHertz to NanoHertz
    /// </summary>
    /// <param name="val">quantity measured in YoctoHertz</param>
    /// <returns>quantity measured in NanoHertz</returns>
	public static Quantity<double, NanoHertz> ToNanoHertz<T>(this BaseQuantity<T, YoctoHertz> val) where T:IConvertible {
        return new Quantity<double, NanoHertz>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoHertz to PicoHertz
    /// </summary>
    /// <param name="val">quantity measured in YoctoHertz</param>
    /// <returns>quantity measured in PicoHertz</returns>
	public static Quantity<double, PicoHertz> ToPicoHertz<T>(this BaseQuantity<T, YoctoHertz> val) where T:IConvertible {
        return new Quantity<double, PicoHertz>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoHertz to FemtoHertz
    /// </summary>
    /// <param name="val">quantity measured in YoctoHertz</param>
    /// <returns>quantity measured in FemtoHertz</returns>
	public static Quantity<double, FemtoHertz> ToFemtoHertz<T>(this BaseQuantity<T, YoctoHertz> val) where T:IConvertible {
        return new Quantity<double, FemtoHertz>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoHertz to AttoHertz
    /// </summary>
    /// <param name="val">quantity measured in YoctoHertz</param>
    /// <returns>quantity measured in AttoHertz</returns>
	public static Quantity<double, AttoHertz> ToAttoHertz<T>(this BaseQuantity<T, YoctoHertz> val) where T:IConvertible {
        return new Quantity<double, AttoHertz>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoHertz to ZeptoHertz
    /// </summary>
    /// <param name="val">quantity measured in YoctoHertz</param>
    /// <returns>quantity measured in ZeptoHertz</returns>
	public static Quantity<double, ZeptoHertz> ToZeptoHertz<T>(this BaseQuantity<T, YoctoHertz> val) where T:IConvertible {
        return new Quantity<double, ZeptoHertz>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
}
}