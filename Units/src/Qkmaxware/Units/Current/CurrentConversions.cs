using System;
namespace Qkmaxware.Units.Current {
    /// <summary>
/// Static class housing si-prefix conversions for the unit "Ampere"
/// </summary>
public static class CurrentConversions {
	/// <summary>
    /// Extension method to convert Ampere to YottaAmpere
    /// </summary>
    /// <param name="val">quantity measured in Ampere</param>
    /// <returns>quantity measured in YottaAmpere</returns>
	public static Quantity<double, YottaAmpere> ToYottaAmpere<T>(this BaseQuantity<T, Ampere> val) where T:IConvertible {
        return new Quantity<double, YottaAmpere>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Ampere to ZettaAmpere
    /// </summary>
    /// <param name="val">quantity measured in Ampere</param>
    /// <returns>quantity measured in ZettaAmpere</returns>
	public static Quantity<double, ZettaAmpere> ToZettaAmpere<T>(this BaseQuantity<T, Ampere> val) where T:IConvertible {
        return new Quantity<double, ZettaAmpere>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Ampere to ExaAmpere
    /// </summary>
    /// <param name="val">quantity measured in Ampere</param>
    /// <returns>quantity measured in ExaAmpere</returns>
	public static Quantity<double, ExaAmpere> ToExaAmpere<T>(this BaseQuantity<T, Ampere> val) where T:IConvertible {
        return new Quantity<double, ExaAmpere>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Ampere to PetaAmpere
    /// </summary>
    /// <param name="val">quantity measured in Ampere</param>
    /// <returns>quantity measured in PetaAmpere</returns>
	public static Quantity<double, PetaAmpere> ToPetaAmpere<T>(this BaseQuantity<T, Ampere> val) where T:IConvertible {
        return new Quantity<double, PetaAmpere>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Ampere to TeraAmpere
    /// </summary>
    /// <param name="val">quantity measured in Ampere</param>
    /// <returns>quantity measured in TeraAmpere</returns>
	public static Quantity<double, TeraAmpere> ToTeraAmpere<T>(this BaseQuantity<T, Ampere> val) where T:IConvertible {
        return new Quantity<double, TeraAmpere>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Ampere to GigaAmpere
    /// </summary>
    /// <param name="val">quantity measured in Ampere</param>
    /// <returns>quantity measured in GigaAmpere</returns>
	public static Quantity<double, GigaAmpere> ToGigaAmpere<T>(this BaseQuantity<T, Ampere> val) where T:IConvertible {
        return new Quantity<double, GigaAmpere>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Ampere to MegaAmpere
    /// </summary>
    /// <param name="val">quantity measured in Ampere</param>
    /// <returns>quantity measured in MegaAmpere</returns>
	public static Quantity<double, MegaAmpere> ToMegaAmpere<T>(this BaseQuantity<T, Ampere> val) where T:IConvertible {
        return new Quantity<double, MegaAmpere>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Ampere to KiloAmpere
    /// </summary>
    /// <param name="val">quantity measured in Ampere</param>
    /// <returns>quantity measured in KiloAmpere</returns>
	public static Quantity<double, KiloAmpere> ToKiloAmpere<T>(this BaseQuantity<T, Ampere> val) where T:IConvertible {
        return new Quantity<double, KiloAmpere>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Ampere to HectoAmpere
    /// </summary>
    /// <param name="val">quantity measured in Ampere</param>
    /// <returns>quantity measured in HectoAmpere</returns>
	public static Quantity<double, HectoAmpere> ToHectoAmpere<T>(this BaseQuantity<T, Ampere> val) where T:IConvertible {
        return new Quantity<double, HectoAmpere>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Ampere to DekaAmpere
    /// </summary>
    /// <param name="val">quantity measured in Ampere</param>
    /// <returns>quantity measured in DekaAmpere</returns>
	public static Quantity<double, DekaAmpere> ToDekaAmpere<T>(this BaseQuantity<T, Ampere> val) where T:IConvertible {
        return new Quantity<double, DekaAmpere>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Ampere to DeciAmpere
    /// </summary>
    /// <param name="val">quantity measured in Ampere</param>
    /// <returns>quantity measured in DeciAmpere</returns>
	public static Quantity<double, DeciAmpere> ToDeciAmpere<T>(this BaseQuantity<T, Ampere> val) where T:IConvertible {
        return new Quantity<double, DeciAmpere>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Ampere to CentiAmpere
    /// </summary>
    /// <param name="val">quantity measured in Ampere</param>
    /// <returns>quantity measured in CentiAmpere</returns>
	public static Quantity<double, CentiAmpere> ToCentiAmpere<T>(this BaseQuantity<T, Ampere> val) where T:IConvertible {
        return new Quantity<double, CentiAmpere>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Ampere to MilliAmpere
    /// </summary>
    /// <param name="val">quantity measured in Ampere</param>
    /// <returns>quantity measured in MilliAmpere</returns>
	public static Quantity<double, MilliAmpere> ToMilliAmpere<T>(this BaseQuantity<T, Ampere> val) where T:IConvertible {
        return new Quantity<double, MilliAmpere>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Ampere to MicroAmpere
    /// </summary>
    /// <param name="val">quantity measured in Ampere</param>
    /// <returns>quantity measured in MicroAmpere</returns>
	public static Quantity<double, MicroAmpere> ToMicroAmpere<T>(this BaseQuantity<T, Ampere> val) where T:IConvertible {
        return new Quantity<double, MicroAmpere>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Ampere to NanoAmpere
    /// </summary>
    /// <param name="val">quantity measured in Ampere</param>
    /// <returns>quantity measured in NanoAmpere</returns>
	public static Quantity<double, NanoAmpere> ToNanoAmpere<T>(this BaseQuantity<T, Ampere> val) where T:IConvertible {
        return new Quantity<double, NanoAmpere>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Ampere to PicoAmpere
    /// </summary>
    /// <param name="val">quantity measured in Ampere</param>
    /// <returns>quantity measured in PicoAmpere</returns>
	public static Quantity<double, PicoAmpere> ToPicoAmpere<T>(this BaseQuantity<T, Ampere> val) where T:IConvertible {
        return new Quantity<double, PicoAmpere>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Ampere to FemtoAmpere
    /// </summary>
    /// <param name="val">quantity measured in Ampere</param>
    /// <returns>quantity measured in FemtoAmpere</returns>
	public static Quantity<double, FemtoAmpere> ToFemtoAmpere<T>(this BaseQuantity<T, Ampere> val) where T:IConvertible {
        return new Quantity<double, FemtoAmpere>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Ampere to AttoAmpere
    /// </summary>
    /// <param name="val">quantity measured in Ampere</param>
    /// <returns>quantity measured in AttoAmpere</returns>
	public static Quantity<double, AttoAmpere> ToAttoAmpere<T>(this BaseQuantity<T, Ampere> val) where T:IConvertible {
        return new Quantity<double, AttoAmpere>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Ampere to ZeptoAmpere
    /// </summary>
    /// <param name="val">quantity measured in Ampere</param>
    /// <returns>quantity measured in ZeptoAmpere</returns>
	public static Quantity<double, ZeptoAmpere> ToZeptoAmpere<T>(this BaseQuantity<T, Ampere> val) where T:IConvertible {
        return new Quantity<double, ZeptoAmpere>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Ampere to YoctoAmpere
    /// </summary>
    /// <param name="val">quantity measured in Ampere</param>
    /// <returns>quantity measured in YoctoAmpere</returns>
	public static Quantity<double, YoctoAmpere> ToYoctoAmpere<T>(this BaseQuantity<T, Ampere> val) where T:IConvertible {
        return new Quantity<double, YoctoAmpere>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YottaAmpere to ZettaAmpere
    /// </summary>
    /// <param name="val">quantity measured in YottaAmpere</param>
    /// <returns>quantity measured in ZettaAmpere</returns>
	public static Quantity<double, ZettaAmpere> ToZettaAmpere<T>(this BaseQuantity<T, YottaAmpere> val) where T:IConvertible {
        return new Quantity<double, ZettaAmpere>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaAmpere to ExaAmpere
    /// </summary>
    /// <param name="val">quantity measured in YottaAmpere</param>
    /// <returns>quantity measured in ExaAmpere</returns>
	public static Quantity<double, ExaAmpere> ToExaAmpere<T>(this BaseQuantity<T, YottaAmpere> val) where T:IConvertible {
        return new Quantity<double, ExaAmpere>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaAmpere to PetaAmpere
    /// </summary>
    /// <param name="val">quantity measured in YottaAmpere</param>
    /// <returns>quantity measured in PetaAmpere</returns>
	public static Quantity<double, PetaAmpere> ToPetaAmpere<T>(this BaseQuantity<T, YottaAmpere> val) where T:IConvertible {
        return new Quantity<double, PetaAmpere>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaAmpere to TeraAmpere
    /// </summary>
    /// <param name="val">quantity measured in YottaAmpere</param>
    /// <returns>quantity measured in TeraAmpere</returns>
	public static Quantity<double, TeraAmpere> ToTeraAmpere<T>(this BaseQuantity<T, YottaAmpere> val) where T:IConvertible {
        return new Quantity<double, TeraAmpere>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaAmpere to GigaAmpere
    /// </summary>
    /// <param name="val">quantity measured in YottaAmpere</param>
    /// <returns>quantity measured in GigaAmpere</returns>
	public static Quantity<double, GigaAmpere> ToGigaAmpere<T>(this BaseQuantity<T, YottaAmpere> val) where T:IConvertible {
        return new Quantity<double, GigaAmpere>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaAmpere to MegaAmpere
    /// </summary>
    /// <param name="val">quantity measured in YottaAmpere</param>
    /// <returns>quantity measured in MegaAmpere</returns>
	public static Quantity<double, MegaAmpere> ToMegaAmpere<T>(this BaseQuantity<T, YottaAmpere> val) where T:IConvertible {
        return new Quantity<double, MegaAmpere>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaAmpere to KiloAmpere
    /// </summary>
    /// <param name="val">quantity measured in YottaAmpere</param>
    /// <returns>quantity measured in KiloAmpere</returns>
	public static Quantity<double, KiloAmpere> ToKiloAmpere<T>(this BaseQuantity<T, YottaAmpere> val) where T:IConvertible {
        return new Quantity<double, KiloAmpere>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaAmpere to HectoAmpere
    /// </summary>
    /// <param name="val">quantity measured in YottaAmpere</param>
    /// <returns>quantity measured in HectoAmpere</returns>
	public static Quantity<double, HectoAmpere> ToHectoAmpere<T>(this BaseQuantity<T, YottaAmpere> val) where T:IConvertible {
        return new Quantity<double, HectoAmpere>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaAmpere to DekaAmpere
    /// </summary>
    /// <param name="val">quantity measured in YottaAmpere</param>
    /// <returns>quantity measured in DekaAmpere</returns>
	public static Quantity<double, DekaAmpere> ToDekaAmpere<T>(this BaseQuantity<T, YottaAmpere> val) where T:IConvertible {
        return new Quantity<double, DekaAmpere>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaAmpere to DeciAmpere
    /// </summary>
    /// <param name="val">quantity measured in YottaAmpere</param>
    /// <returns>quantity measured in DeciAmpere</returns>
	public static Quantity<double, DeciAmpere> ToDeciAmpere<T>(this BaseQuantity<T, YottaAmpere> val) where T:IConvertible {
        return new Quantity<double, DeciAmpere>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaAmpere to CentiAmpere
    /// </summary>
    /// <param name="val">quantity measured in YottaAmpere</param>
    /// <returns>quantity measured in CentiAmpere</returns>
	public static Quantity<double, CentiAmpere> ToCentiAmpere<T>(this BaseQuantity<T, YottaAmpere> val) where T:IConvertible {
        return new Quantity<double, CentiAmpere>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaAmpere to MilliAmpere
    /// </summary>
    /// <param name="val">quantity measured in YottaAmpere</param>
    /// <returns>quantity measured in MilliAmpere</returns>
	public static Quantity<double, MilliAmpere> ToMilliAmpere<T>(this BaseQuantity<T, YottaAmpere> val) where T:IConvertible {
        return new Quantity<double, MilliAmpere>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaAmpere to MicroAmpere
    /// </summary>
    /// <param name="val">quantity measured in YottaAmpere</param>
    /// <returns>quantity measured in MicroAmpere</returns>
	public static Quantity<double, MicroAmpere> ToMicroAmpere<T>(this BaseQuantity<T, YottaAmpere> val) where T:IConvertible {
        return new Quantity<double, MicroAmpere>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaAmpere to NanoAmpere
    /// </summary>
    /// <param name="val">quantity measured in YottaAmpere</param>
    /// <returns>quantity measured in NanoAmpere</returns>
	public static Quantity<double, NanoAmpere> ToNanoAmpere<T>(this BaseQuantity<T, YottaAmpere> val) where T:IConvertible {
        return new Quantity<double, NanoAmpere>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaAmpere to PicoAmpere
    /// </summary>
    /// <param name="val">quantity measured in YottaAmpere</param>
    /// <returns>quantity measured in PicoAmpere</returns>
	public static Quantity<double, PicoAmpere> ToPicoAmpere<T>(this BaseQuantity<T, YottaAmpere> val) where T:IConvertible {
        return new Quantity<double, PicoAmpere>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaAmpere to FemtoAmpere
    /// </summary>
    /// <param name="val">quantity measured in YottaAmpere</param>
    /// <returns>quantity measured in FemtoAmpere</returns>
	public static Quantity<double, FemtoAmpere> ToFemtoAmpere<T>(this BaseQuantity<T, YottaAmpere> val) where T:IConvertible {
        return new Quantity<double, FemtoAmpere>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaAmpere to AttoAmpere
    /// </summary>
    /// <param name="val">quantity measured in YottaAmpere</param>
    /// <returns>quantity measured in AttoAmpere</returns>
	public static Quantity<double, AttoAmpere> ToAttoAmpere<T>(this BaseQuantity<T, YottaAmpere> val) where T:IConvertible {
        return new Quantity<double, AttoAmpere>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaAmpere to ZeptoAmpere
    /// </summary>
    /// <param name="val">quantity measured in YottaAmpere</param>
    /// <returns>quantity measured in ZeptoAmpere</returns>
	public static Quantity<double, ZeptoAmpere> ToZeptoAmpere<T>(this BaseQuantity<T, YottaAmpere> val) where T:IConvertible {
        return new Quantity<double, ZeptoAmpere>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaAmpere to YoctoAmpere
    /// </summary>
    /// <param name="val">quantity measured in YottaAmpere</param>
    /// <returns>quantity measured in YoctoAmpere</returns>
	public static Quantity<double, YoctoAmpere> ToYoctoAmpere<T>(this BaseQuantity<T, YottaAmpere> val) where T:IConvertible {
        return new Quantity<double, YoctoAmpere>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert ZettaAmpere to YottaAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZettaAmpere</param>
    /// <returns>quantity measured in YottaAmpere</returns>
	public static Quantity<double, YottaAmpere> ToYottaAmpere<T>(this BaseQuantity<T, ZettaAmpere> val) where T:IConvertible {
        return new Quantity<double, YottaAmpere>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaAmpere to ExaAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZettaAmpere</param>
    /// <returns>quantity measured in ExaAmpere</returns>
	public static Quantity<double, ExaAmpere> ToExaAmpere<T>(this BaseQuantity<T, ZettaAmpere> val) where T:IConvertible {
        return new Quantity<double, ExaAmpere>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaAmpere to PetaAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZettaAmpere</param>
    /// <returns>quantity measured in PetaAmpere</returns>
	public static Quantity<double, PetaAmpere> ToPetaAmpere<T>(this BaseQuantity<T, ZettaAmpere> val) where T:IConvertible {
        return new Quantity<double, PetaAmpere>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaAmpere to TeraAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZettaAmpere</param>
    /// <returns>quantity measured in TeraAmpere</returns>
	public static Quantity<double, TeraAmpere> ToTeraAmpere<T>(this BaseQuantity<T, ZettaAmpere> val) where T:IConvertible {
        return new Quantity<double, TeraAmpere>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaAmpere to GigaAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZettaAmpere</param>
    /// <returns>quantity measured in GigaAmpere</returns>
	public static Quantity<double, GigaAmpere> ToGigaAmpere<T>(this BaseQuantity<T, ZettaAmpere> val) where T:IConvertible {
        return new Quantity<double, GigaAmpere>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaAmpere to MegaAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZettaAmpere</param>
    /// <returns>quantity measured in MegaAmpere</returns>
	public static Quantity<double, MegaAmpere> ToMegaAmpere<T>(this BaseQuantity<T, ZettaAmpere> val) where T:IConvertible {
        return new Quantity<double, MegaAmpere>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaAmpere to KiloAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZettaAmpere</param>
    /// <returns>quantity measured in KiloAmpere</returns>
	public static Quantity<double, KiloAmpere> ToKiloAmpere<T>(this BaseQuantity<T, ZettaAmpere> val) where T:IConvertible {
        return new Quantity<double, KiloAmpere>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaAmpere to HectoAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZettaAmpere</param>
    /// <returns>quantity measured in HectoAmpere</returns>
	public static Quantity<double, HectoAmpere> ToHectoAmpere<T>(this BaseQuantity<T, ZettaAmpere> val) where T:IConvertible {
        return new Quantity<double, HectoAmpere>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaAmpere to DekaAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZettaAmpere</param>
    /// <returns>quantity measured in DekaAmpere</returns>
	public static Quantity<double, DekaAmpere> ToDekaAmpere<T>(this BaseQuantity<T, ZettaAmpere> val) where T:IConvertible {
        return new Quantity<double, DekaAmpere>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaAmpere to DeciAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZettaAmpere</param>
    /// <returns>quantity measured in DeciAmpere</returns>
	public static Quantity<double, DeciAmpere> ToDeciAmpere<T>(this BaseQuantity<T, ZettaAmpere> val) where T:IConvertible {
        return new Quantity<double, DeciAmpere>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaAmpere to CentiAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZettaAmpere</param>
    /// <returns>quantity measured in CentiAmpere</returns>
	public static Quantity<double, CentiAmpere> ToCentiAmpere<T>(this BaseQuantity<T, ZettaAmpere> val) where T:IConvertible {
        return new Quantity<double, CentiAmpere>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaAmpere to MilliAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZettaAmpere</param>
    /// <returns>quantity measured in MilliAmpere</returns>
	public static Quantity<double, MilliAmpere> ToMilliAmpere<T>(this BaseQuantity<T, ZettaAmpere> val) where T:IConvertible {
        return new Quantity<double, MilliAmpere>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaAmpere to MicroAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZettaAmpere</param>
    /// <returns>quantity measured in MicroAmpere</returns>
	public static Quantity<double, MicroAmpere> ToMicroAmpere<T>(this BaseQuantity<T, ZettaAmpere> val) where T:IConvertible {
        return new Quantity<double, MicroAmpere>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaAmpere to NanoAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZettaAmpere</param>
    /// <returns>quantity measured in NanoAmpere</returns>
	public static Quantity<double, NanoAmpere> ToNanoAmpere<T>(this BaseQuantity<T, ZettaAmpere> val) where T:IConvertible {
        return new Quantity<double, NanoAmpere>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaAmpere to PicoAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZettaAmpere</param>
    /// <returns>quantity measured in PicoAmpere</returns>
	public static Quantity<double, PicoAmpere> ToPicoAmpere<T>(this BaseQuantity<T, ZettaAmpere> val) where T:IConvertible {
        return new Quantity<double, PicoAmpere>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaAmpere to FemtoAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZettaAmpere</param>
    /// <returns>quantity measured in FemtoAmpere</returns>
	public static Quantity<double, FemtoAmpere> ToFemtoAmpere<T>(this BaseQuantity<T, ZettaAmpere> val) where T:IConvertible {
        return new Quantity<double, FemtoAmpere>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaAmpere to AttoAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZettaAmpere</param>
    /// <returns>quantity measured in AttoAmpere</returns>
	public static Quantity<double, AttoAmpere> ToAttoAmpere<T>(this BaseQuantity<T, ZettaAmpere> val) where T:IConvertible {
        return new Quantity<double, AttoAmpere>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaAmpere to ZeptoAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZettaAmpere</param>
    /// <returns>quantity measured in ZeptoAmpere</returns>
	public static Quantity<double, ZeptoAmpere> ToZeptoAmpere<T>(this BaseQuantity<T, ZettaAmpere> val) where T:IConvertible {
        return new Quantity<double, ZeptoAmpere>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaAmpere to YoctoAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZettaAmpere</param>
    /// <returns>quantity measured in YoctoAmpere</returns>
	public static Quantity<double, YoctoAmpere> ToYoctoAmpere<T>(this BaseQuantity<T, ZettaAmpere> val) where T:IConvertible {
        return new Quantity<double, YoctoAmpere>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ExaAmpere to YottaAmpere
    /// </summary>
    /// <param name="val">quantity measured in ExaAmpere</param>
    /// <returns>quantity measured in YottaAmpere</returns>
	public static Quantity<double, YottaAmpere> ToYottaAmpere<T>(this BaseQuantity<T, ExaAmpere> val) where T:IConvertible {
        return new Quantity<double, YottaAmpere>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaAmpere to ZettaAmpere
    /// </summary>
    /// <param name="val">quantity measured in ExaAmpere</param>
    /// <returns>quantity measured in ZettaAmpere</returns>
	public static Quantity<double, ZettaAmpere> ToZettaAmpere<T>(this BaseQuantity<T, ExaAmpere> val) where T:IConvertible {
        return new Quantity<double, ZettaAmpere>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaAmpere to PetaAmpere
    /// </summary>
    /// <param name="val">quantity measured in ExaAmpere</param>
    /// <returns>quantity measured in PetaAmpere</returns>
	public static Quantity<double, PetaAmpere> ToPetaAmpere<T>(this BaseQuantity<T, ExaAmpere> val) where T:IConvertible {
        return new Quantity<double, PetaAmpere>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaAmpere to TeraAmpere
    /// </summary>
    /// <param name="val">quantity measured in ExaAmpere</param>
    /// <returns>quantity measured in TeraAmpere</returns>
	public static Quantity<double, TeraAmpere> ToTeraAmpere<T>(this BaseQuantity<T, ExaAmpere> val) where T:IConvertible {
        return new Quantity<double, TeraAmpere>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaAmpere to GigaAmpere
    /// </summary>
    /// <param name="val">quantity measured in ExaAmpere</param>
    /// <returns>quantity measured in GigaAmpere</returns>
	public static Quantity<double, GigaAmpere> ToGigaAmpere<T>(this BaseQuantity<T, ExaAmpere> val) where T:IConvertible {
        return new Quantity<double, GigaAmpere>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaAmpere to MegaAmpere
    /// </summary>
    /// <param name="val">quantity measured in ExaAmpere</param>
    /// <returns>quantity measured in MegaAmpere</returns>
	public static Quantity<double, MegaAmpere> ToMegaAmpere<T>(this BaseQuantity<T, ExaAmpere> val) where T:IConvertible {
        return new Quantity<double, MegaAmpere>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaAmpere to KiloAmpere
    /// </summary>
    /// <param name="val">quantity measured in ExaAmpere</param>
    /// <returns>quantity measured in KiloAmpere</returns>
	public static Quantity<double, KiloAmpere> ToKiloAmpere<T>(this BaseQuantity<T, ExaAmpere> val) where T:IConvertible {
        return new Quantity<double, KiloAmpere>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaAmpere to HectoAmpere
    /// </summary>
    /// <param name="val">quantity measured in ExaAmpere</param>
    /// <returns>quantity measured in HectoAmpere</returns>
	public static Quantity<double, HectoAmpere> ToHectoAmpere<T>(this BaseQuantity<T, ExaAmpere> val) where T:IConvertible {
        return new Quantity<double, HectoAmpere>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaAmpere to DekaAmpere
    /// </summary>
    /// <param name="val">quantity measured in ExaAmpere</param>
    /// <returns>quantity measured in DekaAmpere</returns>
	public static Quantity<double, DekaAmpere> ToDekaAmpere<T>(this BaseQuantity<T, ExaAmpere> val) where T:IConvertible {
        return new Quantity<double, DekaAmpere>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaAmpere to DeciAmpere
    /// </summary>
    /// <param name="val">quantity measured in ExaAmpere</param>
    /// <returns>quantity measured in DeciAmpere</returns>
	public static Quantity<double, DeciAmpere> ToDeciAmpere<T>(this BaseQuantity<T, ExaAmpere> val) where T:IConvertible {
        return new Quantity<double, DeciAmpere>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaAmpere to CentiAmpere
    /// </summary>
    /// <param name="val">quantity measured in ExaAmpere</param>
    /// <returns>quantity measured in CentiAmpere</returns>
	public static Quantity<double, CentiAmpere> ToCentiAmpere<T>(this BaseQuantity<T, ExaAmpere> val) where T:IConvertible {
        return new Quantity<double, CentiAmpere>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaAmpere to MilliAmpere
    /// </summary>
    /// <param name="val">quantity measured in ExaAmpere</param>
    /// <returns>quantity measured in MilliAmpere</returns>
	public static Quantity<double, MilliAmpere> ToMilliAmpere<T>(this BaseQuantity<T, ExaAmpere> val) where T:IConvertible {
        return new Quantity<double, MilliAmpere>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaAmpere to MicroAmpere
    /// </summary>
    /// <param name="val">quantity measured in ExaAmpere</param>
    /// <returns>quantity measured in MicroAmpere</returns>
	public static Quantity<double, MicroAmpere> ToMicroAmpere<T>(this BaseQuantity<T, ExaAmpere> val) where T:IConvertible {
        return new Quantity<double, MicroAmpere>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaAmpere to NanoAmpere
    /// </summary>
    /// <param name="val">quantity measured in ExaAmpere</param>
    /// <returns>quantity measured in NanoAmpere</returns>
	public static Quantity<double, NanoAmpere> ToNanoAmpere<T>(this BaseQuantity<T, ExaAmpere> val) where T:IConvertible {
        return new Quantity<double, NanoAmpere>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaAmpere to PicoAmpere
    /// </summary>
    /// <param name="val">quantity measured in ExaAmpere</param>
    /// <returns>quantity measured in PicoAmpere</returns>
	public static Quantity<double, PicoAmpere> ToPicoAmpere<T>(this BaseQuantity<T, ExaAmpere> val) where T:IConvertible {
        return new Quantity<double, PicoAmpere>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaAmpere to FemtoAmpere
    /// </summary>
    /// <param name="val">quantity measured in ExaAmpere</param>
    /// <returns>quantity measured in FemtoAmpere</returns>
	public static Quantity<double, FemtoAmpere> ToFemtoAmpere<T>(this BaseQuantity<T, ExaAmpere> val) where T:IConvertible {
        return new Quantity<double, FemtoAmpere>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaAmpere to AttoAmpere
    /// </summary>
    /// <param name="val">quantity measured in ExaAmpere</param>
    /// <returns>quantity measured in AttoAmpere</returns>
	public static Quantity<double, AttoAmpere> ToAttoAmpere<T>(this BaseQuantity<T, ExaAmpere> val) where T:IConvertible {
        return new Quantity<double, AttoAmpere>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaAmpere to ZeptoAmpere
    /// </summary>
    /// <param name="val">quantity measured in ExaAmpere</param>
    /// <returns>quantity measured in ZeptoAmpere</returns>
	public static Quantity<double, ZeptoAmpere> ToZeptoAmpere<T>(this BaseQuantity<T, ExaAmpere> val) where T:IConvertible {
        return new Quantity<double, ZeptoAmpere>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaAmpere to YoctoAmpere
    /// </summary>
    /// <param name="val">quantity measured in ExaAmpere</param>
    /// <returns>quantity measured in YoctoAmpere</returns>
	public static Quantity<double, YoctoAmpere> ToYoctoAmpere<T>(this BaseQuantity<T, ExaAmpere> val) where T:IConvertible {
        return new Quantity<double, YoctoAmpere>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert PetaAmpere to YottaAmpere
    /// </summary>
    /// <param name="val">quantity measured in PetaAmpere</param>
    /// <returns>quantity measured in YottaAmpere</returns>
	public static Quantity<double, YottaAmpere> ToYottaAmpere<T>(this BaseQuantity<T, PetaAmpere> val) where T:IConvertible {
        return new Quantity<double, YottaAmpere>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaAmpere to ZettaAmpere
    /// </summary>
    /// <param name="val">quantity measured in PetaAmpere</param>
    /// <returns>quantity measured in ZettaAmpere</returns>
	public static Quantity<double, ZettaAmpere> ToZettaAmpere<T>(this BaseQuantity<T, PetaAmpere> val) where T:IConvertible {
        return new Quantity<double, ZettaAmpere>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaAmpere to ExaAmpere
    /// </summary>
    /// <param name="val">quantity measured in PetaAmpere</param>
    /// <returns>quantity measured in ExaAmpere</returns>
	public static Quantity<double, ExaAmpere> ToExaAmpere<T>(this BaseQuantity<T, PetaAmpere> val) where T:IConvertible {
        return new Quantity<double, ExaAmpere>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaAmpere to TeraAmpere
    /// </summary>
    /// <param name="val">quantity measured in PetaAmpere</param>
    /// <returns>quantity measured in TeraAmpere</returns>
	public static Quantity<double, TeraAmpere> ToTeraAmpere<T>(this BaseQuantity<T, PetaAmpere> val) where T:IConvertible {
        return new Quantity<double, TeraAmpere>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaAmpere to GigaAmpere
    /// </summary>
    /// <param name="val">quantity measured in PetaAmpere</param>
    /// <returns>quantity measured in GigaAmpere</returns>
	public static Quantity<double, GigaAmpere> ToGigaAmpere<T>(this BaseQuantity<T, PetaAmpere> val) where T:IConvertible {
        return new Quantity<double, GigaAmpere>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaAmpere to MegaAmpere
    /// </summary>
    /// <param name="val">quantity measured in PetaAmpere</param>
    /// <returns>quantity measured in MegaAmpere</returns>
	public static Quantity<double, MegaAmpere> ToMegaAmpere<T>(this BaseQuantity<T, PetaAmpere> val) where T:IConvertible {
        return new Quantity<double, MegaAmpere>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaAmpere to KiloAmpere
    /// </summary>
    /// <param name="val">quantity measured in PetaAmpere</param>
    /// <returns>quantity measured in KiloAmpere</returns>
	public static Quantity<double, KiloAmpere> ToKiloAmpere<T>(this BaseQuantity<T, PetaAmpere> val) where T:IConvertible {
        return new Quantity<double, KiloAmpere>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaAmpere to HectoAmpere
    /// </summary>
    /// <param name="val">quantity measured in PetaAmpere</param>
    /// <returns>quantity measured in HectoAmpere</returns>
	public static Quantity<double, HectoAmpere> ToHectoAmpere<T>(this BaseQuantity<T, PetaAmpere> val) where T:IConvertible {
        return new Quantity<double, HectoAmpere>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaAmpere to DekaAmpere
    /// </summary>
    /// <param name="val">quantity measured in PetaAmpere</param>
    /// <returns>quantity measured in DekaAmpere</returns>
	public static Quantity<double, DekaAmpere> ToDekaAmpere<T>(this BaseQuantity<T, PetaAmpere> val) where T:IConvertible {
        return new Quantity<double, DekaAmpere>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaAmpere to DeciAmpere
    /// </summary>
    /// <param name="val">quantity measured in PetaAmpere</param>
    /// <returns>quantity measured in DeciAmpere</returns>
	public static Quantity<double, DeciAmpere> ToDeciAmpere<T>(this BaseQuantity<T, PetaAmpere> val) where T:IConvertible {
        return new Quantity<double, DeciAmpere>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaAmpere to CentiAmpere
    /// </summary>
    /// <param name="val">quantity measured in PetaAmpere</param>
    /// <returns>quantity measured in CentiAmpere</returns>
	public static Quantity<double, CentiAmpere> ToCentiAmpere<T>(this BaseQuantity<T, PetaAmpere> val) where T:IConvertible {
        return new Quantity<double, CentiAmpere>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaAmpere to MilliAmpere
    /// </summary>
    /// <param name="val">quantity measured in PetaAmpere</param>
    /// <returns>quantity measured in MilliAmpere</returns>
	public static Quantity<double, MilliAmpere> ToMilliAmpere<T>(this BaseQuantity<T, PetaAmpere> val) where T:IConvertible {
        return new Quantity<double, MilliAmpere>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaAmpere to MicroAmpere
    /// </summary>
    /// <param name="val">quantity measured in PetaAmpere</param>
    /// <returns>quantity measured in MicroAmpere</returns>
	public static Quantity<double, MicroAmpere> ToMicroAmpere<T>(this BaseQuantity<T, PetaAmpere> val) where T:IConvertible {
        return new Quantity<double, MicroAmpere>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaAmpere to NanoAmpere
    /// </summary>
    /// <param name="val">quantity measured in PetaAmpere</param>
    /// <returns>quantity measured in NanoAmpere</returns>
	public static Quantity<double, NanoAmpere> ToNanoAmpere<T>(this BaseQuantity<T, PetaAmpere> val) where T:IConvertible {
        return new Quantity<double, NanoAmpere>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaAmpere to PicoAmpere
    /// </summary>
    /// <param name="val">quantity measured in PetaAmpere</param>
    /// <returns>quantity measured in PicoAmpere</returns>
	public static Quantity<double, PicoAmpere> ToPicoAmpere<T>(this BaseQuantity<T, PetaAmpere> val) where T:IConvertible {
        return new Quantity<double, PicoAmpere>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaAmpere to FemtoAmpere
    /// </summary>
    /// <param name="val">quantity measured in PetaAmpere</param>
    /// <returns>quantity measured in FemtoAmpere</returns>
	public static Quantity<double, FemtoAmpere> ToFemtoAmpere<T>(this BaseQuantity<T, PetaAmpere> val) where T:IConvertible {
        return new Quantity<double, FemtoAmpere>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaAmpere to AttoAmpere
    /// </summary>
    /// <param name="val">quantity measured in PetaAmpere</param>
    /// <returns>quantity measured in AttoAmpere</returns>
	public static Quantity<double, AttoAmpere> ToAttoAmpere<T>(this BaseQuantity<T, PetaAmpere> val) where T:IConvertible {
        return new Quantity<double, AttoAmpere>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaAmpere to ZeptoAmpere
    /// </summary>
    /// <param name="val">quantity measured in PetaAmpere</param>
    /// <returns>quantity measured in ZeptoAmpere</returns>
	public static Quantity<double, ZeptoAmpere> ToZeptoAmpere<T>(this BaseQuantity<T, PetaAmpere> val) where T:IConvertible {
        return new Quantity<double, ZeptoAmpere>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaAmpere to YoctoAmpere
    /// </summary>
    /// <param name="val">quantity measured in PetaAmpere</param>
    /// <returns>quantity measured in YoctoAmpere</returns>
	public static Quantity<double, YoctoAmpere> ToYoctoAmpere<T>(this BaseQuantity<T, PetaAmpere> val) where T:IConvertible {
        return new Quantity<double, YoctoAmpere>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert TeraAmpere to YottaAmpere
    /// </summary>
    /// <param name="val">quantity measured in TeraAmpere</param>
    /// <returns>quantity measured in YottaAmpere</returns>
	public static Quantity<double, YottaAmpere> ToYottaAmpere<T>(this BaseQuantity<T, TeraAmpere> val) where T:IConvertible {
        return new Quantity<double, YottaAmpere>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraAmpere to ZettaAmpere
    /// </summary>
    /// <param name="val">quantity measured in TeraAmpere</param>
    /// <returns>quantity measured in ZettaAmpere</returns>
	public static Quantity<double, ZettaAmpere> ToZettaAmpere<T>(this BaseQuantity<T, TeraAmpere> val) where T:IConvertible {
        return new Quantity<double, ZettaAmpere>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraAmpere to ExaAmpere
    /// </summary>
    /// <param name="val">quantity measured in TeraAmpere</param>
    /// <returns>quantity measured in ExaAmpere</returns>
	public static Quantity<double, ExaAmpere> ToExaAmpere<T>(this BaseQuantity<T, TeraAmpere> val) where T:IConvertible {
        return new Quantity<double, ExaAmpere>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraAmpere to PetaAmpere
    /// </summary>
    /// <param name="val">quantity measured in TeraAmpere</param>
    /// <returns>quantity measured in PetaAmpere</returns>
	public static Quantity<double, PetaAmpere> ToPetaAmpere<T>(this BaseQuantity<T, TeraAmpere> val) where T:IConvertible {
        return new Quantity<double, PetaAmpere>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraAmpere to GigaAmpere
    /// </summary>
    /// <param name="val">quantity measured in TeraAmpere</param>
    /// <returns>quantity measured in GigaAmpere</returns>
	public static Quantity<double, GigaAmpere> ToGigaAmpere<T>(this BaseQuantity<T, TeraAmpere> val) where T:IConvertible {
        return new Quantity<double, GigaAmpere>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraAmpere to MegaAmpere
    /// </summary>
    /// <param name="val">quantity measured in TeraAmpere</param>
    /// <returns>quantity measured in MegaAmpere</returns>
	public static Quantity<double, MegaAmpere> ToMegaAmpere<T>(this BaseQuantity<T, TeraAmpere> val) where T:IConvertible {
        return new Quantity<double, MegaAmpere>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraAmpere to KiloAmpere
    /// </summary>
    /// <param name="val">quantity measured in TeraAmpere</param>
    /// <returns>quantity measured in KiloAmpere</returns>
	public static Quantity<double, KiloAmpere> ToKiloAmpere<T>(this BaseQuantity<T, TeraAmpere> val) where T:IConvertible {
        return new Quantity<double, KiloAmpere>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraAmpere to HectoAmpere
    /// </summary>
    /// <param name="val">quantity measured in TeraAmpere</param>
    /// <returns>quantity measured in HectoAmpere</returns>
	public static Quantity<double, HectoAmpere> ToHectoAmpere<T>(this BaseQuantity<T, TeraAmpere> val) where T:IConvertible {
        return new Quantity<double, HectoAmpere>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraAmpere to DekaAmpere
    /// </summary>
    /// <param name="val">quantity measured in TeraAmpere</param>
    /// <returns>quantity measured in DekaAmpere</returns>
	public static Quantity<double, DekaAmpere> ToDekaAmpere<T>(this BaseQuantity<T, TeraAmpere> val) where T:IConvertible {
        return new Quantity<double, DekaAmpere>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraAmpere to DeciAmpere
    /// </summary>
    /// <param name="val">quantity measured in TeraAmpere</param>
    /// <returns>quantity measured in DeciAmpere</returns>
	public static Quantity<double, DeciAmpere> ToDeciAmpere<T>(this BaseQuantity<T, TeraAmpere> val) where T:IConvertible {
        return new Quantity<double, DeciAmpere>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraAmpere to CentiAmpere
    /// </summary>
    /// <param name="val">quantity measured in TeraAmpere</param>
    /// <returns>quantity measured in CentiAmpere</returns>
	public static Quantity<double, CentiAmpere> ToCentiAmpere<T>(this BaseQuantity<T, TeraAmpere> val) where T:IConvertible {
        return new Quantity<double, CentiAmpere>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraAmpere to MilliAmpere
    /// </summary>
    /// <param name="val">quantity measured in TeraAmpere</param>
    /// <returns>quantity measured in MilliAmpere</returns>
	public static Quantity<double, MilliAmpere> ToMilliAmpere<T>(this BaseQuantity<T, TeraAmpere> val) where T:IConvertible {
        return new Quantity<double, MilliAmpere>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraAmpere to MicroAmpere
    /// </summary>
    /// <param name="val">quantity measured in TeraAmpere</param>
    /// <returns>quantity measured in MicroAmpere</returns>
	public static Quantity<double, MicroAmpere> ToMicroAmpere<T>(this BaseQuantity<T, TeraAmpere> val) where T:IConvertible {
        return new Quantity<double, MicroAmpere>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraAmpere to NanoAmpere
    /// </summary>
    /// <param name="val">quantity measured in TeraAmpere</param>
    /// <returns>quantity measured in NanoAmpere</returns>
	public static Quantity<double, NanoAmpere> ToNanoAmpere<T>(this BaseQuantity<T, TeraAmpere> val) where T:IConvertible {
        return new Quantity<double, NanoAmpere>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraAmpere to PicoAmpere
    /// </summary>
    /// <param name="val">quantity measured in TeraAmpere</param>
    /// <returns>quantity measured in PicoAmpere</returns>
	public static Quantity<double, PicoAmpere> ToPicoAmpere<T>(this BaseQuantity<T, TeraAmpere> val) where T:IConvertible {
        return new Quantity<double, PicoAmpere>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraAmpere to FemtoAmpere
    /// </summary>
    /// <param name="val">quantity measured in TeraAmpere</param>
    /// <returns>quantity measured in FemtoAmpere</returns>
	public static Quantity<double, FemtoAmpere> ToFemtoAmpere<T>(this BaseQuantity<T, TeraAmpere> val) where T:IConvertible {
        return new Quantity<double, FemtoAmpere>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraAmpere to AttoAmpere
    /// </summary>
    /// <param name="val">quantity measured in TeraAmpere</param>
    /// <returns>quantity measured in AttoAmpere</returns>
	public static Quantity<double, AttoAmpere> ToAttoAmpere<T>(this BaseQuantity<T, TeraAmpere> val) where T:IConvertible {
        return new Quantity<double, AttoAmpere>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraAmpere to ZeptoAmpere
    /// </summary>
    /// <param name="val">quantity measured in TeraAmpere</param>
    /// <returns>quantity measured in ZeptoAmpere</returns>
	public static Quantity<double, ZeptoAmpere> ToZeptoAmpere<T>(this BaseQuantity<T, TeraAmpere> val) where T:IConvertible {
        return new Quantity<double, ZeptoAmpere>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraAmpere to YoctoAmpere
    /// </summary>
    /// <param name="val">quantity measured in TeraAmpere</param>
    /// <returns>quantity measured in YoctoAmpere</returns>
	public static Quantity<double, YoctoAmpere> ToYoctoAmpere<T>(this BaseQuantity<T, TeraAmpere> val) where T:IConvertible {
        return new Quantity<double, YoctoAmpere>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert GigaAmpere to YottaAmpere
    /// </summary>
    /// <param name="val">quantity measured in GigaAmpere</param>
    /// <returns>quantity measured in YottaAmpere</returns>
	public static Quantity<double, YottaAmpere> ToYottaAmpere<T>(this BaseQuantity<T, GigaAmpere> val) where T:IConvertible {
        return new Quantity<double, YottaAmpere>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaAmpere to ZettaAmpere
    /// </summary>
    /// <param name="val">quantity measured in GigaAmpere</param>
    /// <returns>quantity measured in ZettaAmpere</returns>
	public static Quantity<double, ZettaAmpere> ToZettaAmpere<T>(this BaseQuantity<T, GigaAmpere> val) where T:IConvertible {
        return new Quantity<double, ZettaAmpere>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaAmpere to ExaAmpere
    /// </summary>
    /// <param name="val">quantity measured in GigaAmpere</param>
    /// <returns>quantity measured in ExaAmpere</returns>
	public static Quantity<double, ExaAmpere> ToExaAmpere<T>(this BaseQuantity<T, GigaAmpere> val) where T:IConvertible {
        return new Quantity<double, ExaAmpere>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaAmpere to PetaAmpere
    /// </summary>
    /// <param name="val">quantity measured in GigaAmpere</param>
    /// <returns>quantity measured in PetaAmpere</returns>
	public static Quantity<double, PetaAmpere> ToPetaAmpere<T>(this BaseQuantity<T, GigaAmpere> val) where T:IConvertible {
        return new Quantity<double, PetaAmpere>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaAmpere to TeraAmpere
    /// </summary>
    /// <param name="val">quantity measured in GigaAmpere</param>
    /// <returns>quantity measured in TeraAmpere</returns>
	public static Quantity<double, TeraAmpere> ToTeraAmpere<T>(this BaseQuantity<T, GigaAmpere> val) where T:IConvertible {
        return new Quantity<double, TeraAmpere>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaAmpere to MegaAmpere
    /// </summary>
    /// <param name="val">quantity measured in GigaAmpere</param>
    /// <returns>quantity measured in MegaAmpere</returns>
	public static Quantity<double, MegaAmpere> ToMegaAmpere<T>(this BaseQuantity<T, GigaAmpere> val) where T:IConvertible {
        return new Quantity<double, MegaAmpere>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaAmpere to KiloAmpere
    /// </summary>
    /// <param name="val">quantity measured in GigaAmpere</param>
    /// <returns>quantity measured in KiloAmpere</returns>
	public static Quantity<double, KiloAmpere> ToKiloAmpere<T>(this BaseQuantity<T, GigaAmpere> val) where T:IConvertible {
        return new Quantity<double, KiloAmpere>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaAmpere to HectoAmpere
    /// </summary>
    /// <param name="val">quantity measured in GigaAmpere</param>
    /// <returns>quantity measured in HectoAmpere</returns>
	public static Quantity<double, HectoAmpere> ToHectoAmpere<T>(this BaseQuantity<T, GigaAmpere> val) where T:IConvertible {
        return new Quantity<double, HectoAmpere>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaAmpere to DekaAmpere
    /// </summary>
    /// <param name="val">quantity measured in GigaAmpere</param>
    /// <returns>quantity measured in DekaAmpere</returns>
	public static Quantity<double, DekaAmpere> ToDekaAmpere<T>(this BaseQuantity<T, GigaAmpere> val) where T:IConvertible {
        return new Quantity<double, DekaAmpere>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaAmpere to DeciAmpere
    /// </summary>
    /// <param name="val">quantity measured in GigaAmpere</param>
    /// <returns>quantity measured in DeciAmpere</returns>
	public static Quantity<double, DeciAmpere> ToDeciAmpere<T>(this BaseQuantity<T, GigaAmpere> val) where T:IConvertible {
        return new Quantity<double, DeciAmpere>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaAmpere to CentiAmpere
    /// </summary>
    /// <param name="val">quantity measured in GigaAmpere</param>
    /// <returns>quantity measured in CentiAmpere</returns>
	public static Quantity<double, CentiAmpere> ToCentiAmpere<T>(this BaseQuantity<T, GigaAmpere> val) where T:IConvertible {
        return new Quantity<double, CentiAmpere>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaAmpere to MilliAmpere
    /// </summary>
    /// <param name="val">quantity measured in GigaAmpere</param>
    /// <returns>quantity measured in MilliAmpere</returns>
	public static Quantity<double, MilliAmpere> ToMilliAmpere<T>(this BaseQuantity<T, GigaAmpere> val) where T:IConvertible {
        return new Quantity<double, MilliAmpere>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaAmpere to MicroAmpere
    /// </summary>
    /// <param name="val">quantity measured in GigaAmpere</param>
    /// <returns>quantity measured in MicroAmpere</returns>
	public static Quantity<double, MicroAmpere> ToMicroAmpere<T>(this BaseQuantity<T, GigaAmpere> val) where T:IConvertible {
        return new Quantity<double, MicroAmpere>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaAmpere to NanoAmpere
    /// </summary>
    /// <param name="val">quantity measured in GigaAmpere</param>
    /// <returns>quantity measured in NanoAmpere</returns>
	public static Quantity<double, NanoAmpere> ToNanoAmpere<T>(this BaseQuantity<T, GigaAmpere> val) where T:IConvertible {
        return new Quantity<double, NanoAmpere>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaAmpere to PicoAmpere
    /// </summary>
    /// <param name="val">quantity measured in GigaAmpere</param>
    /// <returns>quantity measured in PicoAmpere</returns>
	public static Quantity<double, PicoAmpere> ToPicoAmpere<T>(this BaseQuantity<T, GigaAmpere> val) where T:IConvertible {
        return new Quantity<double, PicoAmpere>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaAmpere to FemtoAmpere
    /// </summary>
    /// <param name="val">quantity measured in GigaAmpere</param>
    /// <returns>quantity measured in FemtoAmpere</returns>
	public static Quantity<double, FemtoAmpere> ToFemtoAmpere<T>(this BaseQuantity<T, GigaAmpere> val) where T:IConvertible {
        return new Quantity<double, FemtoAmpere>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaAmpere to AttoAmpere
    /// </summary>
    /// <param name="val">quantity measured in GigaAmpere</param>
    /// <returns>quantity measured in AttoAmpere</returns>
	public static Quantity<double, AttoAmpere> ToAttoAmpere<T>(this BaseQuantity<T, GigaAmpere> val) where T:IConvertible {
        return new Quantity<double, AttoAmpere>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaAmpere to ZeptoAmpere
    /// </summary>
    /// <param name="val">quantity measured in GigaAmpere</param>
    /// <returns>quantity measured in ZeptoAmpere</returns>
	public static Quantity<double, ZeptoAmpere> ToZeptoAmpere<T>(this BaseQuantity<T, GigaAmpere> val) where T:IConvertible {
        return new Quantity<double, ZeptoAmpere>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaAmpere to YoctoAmpere
    /// </summary>
    /// <param name="val">quantity measured in GigaAmpere</param>
    /// <returns>quantity measured in YoctoAmpere</returns>
	public static Quantity<double, YoctoAmpere> ToYoctoAmpere<T>(this BaseQuantity<T, GigaAmpere> val) where T:IConvertible {
        return new Quantity<double, YoctoAmpere>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert MegaAmpere to YottaAmpere
    /// </summary>
    /// <param name="val">quantity measured in MegaAmpere</param>
    /// <returns>quantity measured in YottaAmpere</returns>
	public static Quantity<double, YottaAmpere> ToYottaAmpere<T>(this BaseQuantity<T, MegaAmpere> val) where T:IConvertible {
        return new Quantity<double, YottaAmpere>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaAmpere to ZettaAmpere
    /// </summary>
    /// <param name="val">quantity measured in MegaAmpere</param>
    /// <returns>quantity measured in ZettaAmpere</returns>
	public static Quantity<double, ZettaAmpere> ToZettaAmpere<T>(this BaseQuantity<T, MegaAmpere> val) where T:IConvertible {
        return new Quantity<double, ZettaAmpere>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaAmpere to ExaAmpere
    /// </summary>
    /// <param name="val">quantity measured in MegaAmpere</param>
    /// <returns>quantity measured in ExaAmpere</returns>
	public static Quantity<double, ExaAmpere> ToExaAmpere<T>(this BaseQuantity<T, MegaAmpere> val) where T:IConvertible {
        return new Quantity<double, ExaAmpere>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaAmpere to PetaAmpere
    /// </summary>
    /// <param name="val">quantity measured in MegaAmpere</param>
    /// <returns>quantity measured in PetaAmpere</returns>
	public static Quantity<double, PetaAmpere> ToPetaAmpere<T>(this BaseQuantity<T, MegaAmpere> val) where T:IConvertible {
        return new Quantity<double, PetaAmpere>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaAmpere to TeraAmpere
    /// </summary>
    /// <param name="val">quantity measured in MegaAmpere</param>
    /// <returns>quantity measured in TeraAmpere</returns>
	public static Quantity<double, TeraAmpere> ToTeraAmpere<T>(this BaseQuantity<T, MegaAmpere> val) where T:IConvertible {
        return new Quantity<double, TeraAmpere>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaAmpere to GigaAmpere
    /// </summary>
    /// <param name="val">quantity measured in MegaAmpere</param>
    /// <returns>quantity measured in GigaAmpere</returns>
	public static Quantity<double, GigaAmpere> ToGigaAmpere<T>(this BaseQuantity<T, MegaAmpere> val) where T:IConvertible {
        return new Quantity<double, GigaAmpere>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaAmpere to KiloAmpere
    /// </summary>
    /// <param name="val">quantity measured in MegaAmpere</param>
    /// <returns>quantity measured in KiloAmpere</returns>
	public static Quantity<double, KiloAmpere> ToKiloAmpere<T>(this BaseQuantity<T, MegaAmpere> val) where T:IConvertible {
        return new Quantity<double, KiloAmpere>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaAmpere to HectoAmpere
    /// </summary>
    /// <param name="val">quantity measured in MegaAmpere</param>
    /// <returns>quantity measured in HectoAmpere</returns>
	public static Quantity<double, HectoAmpere> ToHectoAmpere<T>(this BaseQuantity<T, MegaAmpere> val) where T:IConvertible {
        return new Quantity<double, HectoAmpere>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaAmpere to DekaAmpere
    /// </summary>
    /// <param name="val">quantity measured in MegaAmpere</param>
    /// <returns>quantity measured in DekaAmpere</returns>
	public static Quantity<double, DekaAmpere> ToDekaAmpere<T>(this BaseQuantity<T, MegaAmpere> val) where T:IConvertible {
        return new Quantity<double, DekaAmpere>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaAmpere to DeciAmpere
    /// </summary>
    /// <param name="val">quantity measured in MegaAmpere</param>
    /// <returns>quantity measured in DeciAmpere</returns>
	public static Quantity<double, DeciAmpere> ToDeciAmpere<T>(this BaseQuantity<T, MegaAmpere> val) where T:IConvertible {
        return new Quantity<double, DeciAmpere>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaAmpere to CentiAmpere
    /// </summary>
    /// <param name="val">quantity measured in MegaAmpere</param>
    /// <returns>quantity measured in CentiAmpere</returns>
	public static Quantity<double, CentiAmpere> ToCentiAmpere<T>(this BaseQuantity<T, MegaAmpere> val) where T:IConvertible {
        return new Quantity<double, CentiAmpere>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaAmpere to MilliAmpere
    /// </summary>
    /// <param name="val">quantity measured in MegaAmpere</param>
    /// <returns>quantity measured in MilliAmpere</returns>
	public static Quantity<double, MilliAmpere> ToMilliAmpere<T>(this BaseQuantity<T, MegaAmpere> val) where T:IConvertible {
        return new Quantity<double, MilliAmpere>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaAmpere to MicroAmpere
    /// </summary>
    /// <param name="val">quantity measured in MegaAmpere</param>
    /// <returns>quantity measured in MicroAmpere</returns>
	public static Quantity<double, MicroAmpere> ToMicroAmpere<T>(this BaseQuantity<T, MegaAmpere> val) where T:IConvertible {
        return new Quantity<double, MicroAmpere>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaAmpere to NanoAmpere
    /// </summary>
    /// <param name="val">quantity measured in MegaAmpere</param>
    /// <returns>quantity measured in NanoAmpere</returns>
	public static Quantity<double, NanoAmpere> ToNanoAmpere<T>(this BaseQuantity<T, MegaAmpere> val) where T:IConvertible {
        return new Quantity<double, NanoAmpere>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaAmpere to PicoAmpere
    /// </summary>
    /// <param name="val">quantity measured in MegaAmpere</param>
    /// <returns>quantity measured in PicoAmpere</returns>
	public static Quantity<double, PicoAmpere> ToPicoAmpere<T>(this BaseQuantity<T, MegaAmpere> val) where T:IConvertible {
        return new Quantity<double, PicoAmpere>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaAmpere to FemtoAmpere
    /// </summary>
    /// <param name="val">quantity measured in MegaAmpere</param>
    /// <returns>quantity measured in FemtoAmpere</returns>
	public static Quantity<double, FemtoAmpere> ToFemtoAmpere<T>(this BaseQuantity<T, MegaAmpere> val) where T:IConvertible {
        return new Quantity<double, FemtoAmpere>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaAmpere to AttoAmpere
    /// </summary>
    /// <param name="val">quantity measured in MegaAmpere</param>
    /// <returns>quantity measured in AttoAmpere</returns>
	public static Quantity<double, AttoAmpere> ToAttoAmpere<T>(this BaseQuantity<T, MegaAmpere> val) where T:IConvertible {
        return new Quantity<double, AttoAmpere>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaAmpere to ZeptoAmpere
    /// </summary>
    /// <param name="val">quantity measured in MegaAmpere</param>
    /// <returns>quantity measured in ZeptoAmpere</returns>
	public static Quantity<double, ZeptoAmpere> ToZeptoAmpere<T>(this BaseQuantity<T, MegaAmpere> val) where T:IConvertible {
        return new Quantity<double, ZeptoAmpere>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaAmpere to YoctoAmpere
    /// </summary>
    /// <param name="val">quantity measured in MegaAmpere</param>
    /// <returns>quantity measured in YoctoAmpere</returns>
	public static Quantity<double, YoctoAmpere> ToYoctoAmpere<T>(this BaseQuantity<T, MegaAmpere> val) where T:IConvertible {
        return new Quantity<double, YoctoAmpere>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert KiloAmpere to YottaAmpere
    /// </summary>
    /// <param name="val">quantity measured in KiloAmpere</param>
    /// <returns>quantity measured in YottaAmpere</returns>
	public static Quantity<double, YottaAmpere> ToYottaAmpere<T>(this BaseQuantity<T, KiloAmpere> val) where T:IConvertible {
        return new Quantity<double, YottaAmpere>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloAmpere to ZettaAmpere
    /// </summary>
    /// <param name="val">quantity measured in KiloAmpere</param>
    /// <returns>quantity measured in ZettaAmpere</returns>
	public static Quantity<double, ZettaAmpere> ToZettaAmpere<T>(this BaseQuantity<T, KiloAmpere> val) where T:IConvertible {
        return new Quantity<double, ZettaAmpere>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloAmpere to ExaAmpere
    /// </summary>
    /// <param name="val">quantity measured in KiloAmpere</param>
    /// <returns>quantity measured in ExaAmpere</returns>
	public static Quantity<double, ExaAmpere> ToExaAmpere<T>(this BaseQuantity<T, KiloAmpere> val) where T:IConvertible {
        return new Quantity<double, ExaAmpere>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloAmpere to PetaAmpere
    /// </summary>
    /// <param name="val">quantity measured in KiloAmpere</param>
    /// <returns>quantity measured in PetaAmpere</returns>
	public static Quantity<double, PetaAmpere> ToPetaAmpere<T>(this BaseQuantity<T, KiloAmpere> val) where T:IConvertible {
        return new Quantity<double, PetaAmpere>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloAmpere to TeraAmpere
    /// </summary>
    /// <param name="val">quantity measured in KiloAmpere</param>
    /// <returns>quantity measured in TeraAmpere</returns>
	public static Quantity<double, TeraAmpere> ToTeraAmpere<T>(this BaseQuantity<T, KiloAmpere> val) where T:IConvertible {
        return new Quantity<double, TeraAmpere>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloAmpere to GigaAmpere
    /// </summary>
    /// <param name="val">quantity measured in KiloAmpere</param>
    /// <returns>quantity measured in GigaAmpere</returns>
	public static Quantity<double, GigaAmpere> ToGigaAmpere<T>(this BaseQuantity<T, KiloAmpere> val) where T:IConvertible {
        return new Quantity<double, GigaAmpere>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloAmpere to MegaAmpere
    /// </summary>
    /// <param name="val">quantity measured in KiloAmpere</param>
    /// <returns>quantity measured in MegaAmpere</returns>
	public static Quantity<double, MegaAmpere> ToMegaAmpere<T>(this BaseQuantity<T, KiloAmpere> val) where T:IConvertible {
        return new Quantity<double, MegaAmpere>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloAmpere to HectoAmpere
    /// </summary>
    /// <param name="val">quantity measured in KiloAmpere</param>
    /// <returns>quantity measured in HectoAmpere</returns>
	public static Quantity<double, HectoAmpere> ToHectoAmpere<T>(this BaseQuantity<T, KiloAmpere> val) where T:IConvertible {
        return new Quantity<double, HectoAmpere>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloAmpere to DekaAmpere
    /// </summary>
    /// <param name="val">quantity measured in KiloAmpere</param>
    /// <returns>quantity measured in DekaAmpere</returns>
	public static Quantity<double, DekaAmpere> ToDekaAmpere<T>(this BaseQuantity<T, KiloAmpere> val) where T:IConvertible {
        return new Quantity<double, DekaAmpere>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloAmpere to DeciAmpere
    /// </summary>
    /// <param name="val">quantity measured in KiloAmpere</param>
    /// <returns>quantity measured in DeciAmpere</returns>
	public static Quantity<double, DeciAmpere> ToDeciAmpere<T>(this BaseQuantity<T, KiloAmpere> val) where T:IConvertible {
        return new Quantity<double, DeciAmpere>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloAmpere to CentiAmpere
    /// </summary>
    /// <param name="val">quantity measured in KiloAmpere</param>
    /// <returns>quantity measured in CentiAmpere</returns>
	public static Quantity<double, CentiAmpere> ToCentiAmpere<T>(this BaseQuantity<T, KiloAmpere> val) where T:IConvertible {
        return new Quantity<double, CentiAmpere>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloAmpere to MilliAmpere
    /// </summary>
    /// <param name="val">quantity measured in KiloAmpere</param>
    /// <returns>quantity measured in MilliAmpere</returns>
	public static Quantity<double, MilliAmpere> ToMilliAmpere<T>(this BaseQuantity<T, KiloAmpere> val) where T:IConvertible {
        return new Quantity<double, MilliAmpere>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloAmpere to MicroAmpere
    /// </summary>
    /// <param name="val">quantity measured in KiloAmpere</param>
    /// <returns>quantity measured in MicroAmpere</returns>
	public static Quantity<double, MicroAmpere> ToMicroAmpere<T>(this BaseQuantity<T, KiloAmpere> val) where T:IConvertible {
        return new Quantity<double, MicroAmpere>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloAmpere to NanoAmpere
    /// </summary>
    /// <param name="val">quantity measured in KiloAmpere</param>
    /// <returns>quantity measured in NanoAmpere</returns>
	public static Quantity<double, NanoAmpere> ToNanoAmpere<T>(this BaseQuantity<T, KiloAmpere> val) where T:IConvertible {
        return new Quantity<double, NanoAmpere>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloAmpere to PicoAmpere
    /// </summary>
    /// <param name="val">quantity measured in KiloAmpere</param>
    /// <returns>quantity measured in PicoAmpere</returns>
	public static Quantity<double, PicoAmpere> ToPicoAmpere<T>(this BaseQuantity<T, KiloAmpere> val) where T:IConvertible {
        return new Quantity<double, PicoAmpere>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloAmpere to FemtoAmpere
    /// </summary>
    /// <param name="val">quantity measured in KiloAmpere</param>
    /// <returns>quantity measured in FemtoAmpere</returns>
	public static Quantity<double, FemtoAmpere> ToFemtoAmpere<T>(this BaseQuantity<T, KiloAmpere> val) where T:IConvertible {
        return new Quantity<double, FemtoAmpere>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloAmpere to AttoAmpere
    /// </summary>
    /// <param name="val">quantity measured in KiloAmpere</param>
    /// <returns>quantity measured in AttoAmpere</returns>
	public static Quantity<double, AttoAmpere> ToAttoAmpere<T>(this BaseQuantity<T, KiloAmpere> val) where T:IConvertible {
        return new Quantity<double, AttoAmpere>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloAmpere to ZeptoAmpere
    /// </summary>
    /// <param name="val">quantity measured in KiloAmpere</param>
    /// <returns>quantity measured in ZeptoAmpere</returns>
	public static Quantity<double, ZeptoAmpere> ToZeptoAmpere<T>(this BaseQuantity<T, KiloAmpere> val) where T:IConvertible {
        return new Quantity<double, ZeptoAmpere>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloAmpere to YoctoAmpere
    /// </summary>
    /// <param name="val">quantity measured in KiloAmpere</param>
    /// <returns>quantity measured in YoctoAmpere</returns>
	public static Quantity<double, YoctoAmpere> ToYoctoAmpere<T>(this BaseQuantity<T, KiloAmpere> val) where T:IConvertible {
        return new Quantity<double, YoctoAmpere>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert HectoAmpere to YottaAmpere
    /// </summary>
    /// <param name="val">quantity measured in HectoAmpere</param>
    /// <returns>quantity measured in YottaAmpere</returns>
	public static Quantity<double, YottaAmpere> ToYottaAmpere<T>(this BaseQuantity<T, HectoAmpere> val) where T:IConvertible {
        return new Quantity<double, YottaAmpere>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoAmpere to ZettaAmpere
    /// </summary>
    /// <param name="val">quantity measured in HectoAmpere</param>
    /// <returns>quantity measured in ZettaAmpere</returns>
	public static Quantity<double, ZettaAmpere> ToZettaAmpere<T>(this BaseQuantity<T, HectoAmpere> val) where T:IConvertible {
        return new Quantity<double, ZettaAmpere>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoAmpere to ExaAmpere
    /// </summary>
    /// <param name="val">quantity measured in HectoAmpere</param>
    /// <returns>quantity measured in ExaAmpere</returns>
	public static Quantity<double, ExaAmpere> ToExaAmpere<T>(this BaseQuantity<T, HectoAmpere> val) where T:IConvertible {
        return new Quantity<double, ExaAmpere>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoAmpere to PetaAmpere
    /// </summary>
    /// <param name="val">quantity measured in HectoAmpere</param>
    /// <returns>quantity measured in PetaAmpere</returns>
	public static Quantity<double, PetaAmpere> ToPetaAmpere<T>(this BaseQuantity<T, HectoAmpere> val) where T:IConvertible {
        return new Quantity<double, PetaAmpere>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoAmpere to TeraAmpere
    /// </summary>
    /// <param name="val">quantity measured in HectoAmpere</param>
    /// <returns>quantity measured in TeraAmpere</returns>
	public static Quantity<double, TeraAmpere> ToTeraAmpere<T>(this BaseQuantity<T, HectoAmpere> val) where T:IConvertible {
        return new Quantity<double, TeraAmpere>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoAmpere to GigaAmpere
    /// </summary>
    /// <param name="val">quantity measured in HectoAmpere</param>
    /// <returns>quantity measured in GigaAmpere</returns>
	public static Quantity<double, GigaAmpere> ToGigaAmpere<T>(this BaseQuantity<T, HectoAmpere> val) where T:IConvertible {
        return new Quantity<double, GigaAmpere>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoAmpere to MegaAmpere
    /// </summary>
    /// <param name="val">quantity measured in HectoAmpere</param>
    /// <returns>quantity measured in MegaAmpere</returns>
	public static Quantity<double, MegaAmpere> ToMegaAmpere<T>(this BaseQuantity<T, HectoAmpere> val) where T:IConvertible {
        return new Quantity<double, MegaAmpere>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoAmpere to KiloAmpere
    /// </summary>
    /// <param name="val">quantity measured in HectoAmpere</param>
    /// <returns>quantity measured in KiloAmpere</returns>
	public static Quantity<double, KiloAmpere> ToKiloAmpere<T>(this BaseQuantity<T, HectoAmpere> val) where T:IConvertible {
        return new Quantity<double, KiloAmpere>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoAmpere to DekaAmpere
    /// </summary>
    /// <param name="val">quantity measured in HectoAmpere</param>
    /// <returns>quantity measured in DekaAmpere</returns>
	public static Quantity<double, DekaAmpere> ToDekaAmpere<T>(this BaseQuantity<T, HectoAmpere> val) where T:IConvertible {
        return new Quantity<double, DekaAmpere>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoAmpere to DeciAmpere
    /// </summary>
    /// <param name="val">quantity measured in HectoAmpere</param>
    /// <returns>quantity measured in DeciAmpere</returns>
	public static Quantity<double, DeciAmpere> ToDeciAmpere<T>(this BaseQuantity<T, HectoAmpere> val) where T:IConvertible {
        return new Quantity<double, DeciAmpere>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoAmpere to CentiAmpere
    /// </summary>
    /// <param name="val">quantity measured in HectoAmpere</param>
    /// <returns>quantity measured in CentiAmpere</returns>
	public static Quantity<double, CentiAmpere> ToCentiAmpere<T>(this BaseQuantity<T, HectoAmpere> val) where T:IConvertible {
        return new Quantity<double, CentiAmpere>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoAmpere to MilliAmpere
    /// </summary>
    /// <param name="val">quantity measured in HectoAmpere</param>
    /// <returns>quantity measured in MilliAmpere</returns>
	public static Quantity<double, MilliAmpere> ToMilliAmpere<T>(this BaseQuantity<T, HectoAmpere> val) where T:IConvertible {
        return new Quantity<double, MilliAmpere>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoAmpere to MicroAmpere
    /// </summary>
    /// <param name="val">quantity measured in HectoAmpere</param>
    /// <returns>quantity measured in MicroAmpere</returns>
	public static Quantity<double, MicroAmpere> ToMicroAmpere<T>(this BaseQuantity<T, HectoAmpere> val) where T:IConvertible {
        return new Quantity<double, MicroAmpere>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoAmpere to NanoAmpere
    /// </summary>
    /// <param name="val">quantity measured in HectoAmpere</param>
    /// <returns>quantity measured in NanoAmpere</returns>
	public static Quantity<double, NanoAmpere> ToNanoAmpere<T>(this BaseQuantity<T, HectoAmpere> val) where T:IConvertible {
        return new Quantity<double, NanoAmpere>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoAmpere to PicoAmpere
    /// </summary>
    /// <param name="val">quantity measured in HectoAmpere</param>
    /// <returns>quantity measured in PicoAmpere</returns>
	public static Quantity<double, PicoAmpere> ToPicoAmpere<T>(this BaseQuantity<T, HectoAmpere> val) where T:IConvertible {
        return new Quantity<double, PicoAmpere>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoAmpere to FemtoAmpere
    /// </summary>
    /// <param name="val">quantity measured in HectoAmpere</param>
    /// <returns>quantity measured in FemtoAmpere</returns>
	public static Quantity<double, FemtoAmpere> ToFemtoAmpere<T>(this BaseQuantity<T, HectoAmpere> val) where T:IConvertible {
        return new Quantity<double, FemtoAmpere>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoAmpere to AttoAmpere
    /// </summary>
    /// <param name="val">quantity measured in HectoAmpere</param>
    /// <returns>quantity measured in AttoAmpere</returns>
	public static Quantity<double, AttoAmpere> ToAttoAmpere<T>(this BaseQuantity<T, HectoAmpere> val) where T:IConvertible {
        return new Quantity<double, AttoAmpere>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoAmpere to ZeptoAmpere
    /// </summary>
    /// <param name="val">quantity measured in HectoAmpere</param>
    /// <returns>quantity measured in ZeptoAmpere</returns>
	public static Quantity<double, ZeptoAmpere> ToZeptoAmpere<T>(this BaseQuantity<T, HectoAmpere> val) where T:IConvertible {
        return new Quantity<double, ZeptoAmpere>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoAmpere to YoctoAmpere
    /// </summary>
    /// <param name="val">quantity measured in HectoAmpere</param>
    /// <returns>quantity measured in YoctoAmpere</returns>
	public static Quantity<double, YoctoAmpere> ToYoctoAmpere<T>(this BaseQuantity<T, HectoAmpere> val) where T:IConvertible {
        return new Quantity<double, YoctoAmpere>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert DekaAmpere to YottaAmpere
    /// </summary>
    /// <param name="val">quantity measured in DekaAmpere</param>
    /// <returns>quantity measured in YottaAmpere</returns>
	public static Quantity<double, YottaAmpere> ToYottaAmpere<T>(this BaseQuantity<T, DekaAmpere> val) where T:IConvertible {
        return new Quantity<double, YottaAmpere>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaAmpere to ZettaAmpere
    /// </summary>
    /// <param name="val">quantity measured in DekaAmpere</param>
    /// <returns>quantity measured in ZettaAmpere</returns>
	public static Quantity<double, ZettaAmpere> ToZettaAmpere<T>(this BaseQuantity<T, DekaAmpere> val) where T:IConvertible {
        return new Quantity<double, ZettaAmpere>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaAmpere to ExaAmpere
    /// </summary>
    /// <param name="val">quantity measured in DekaAmpere</param>
    /// <returns>quantity measured in ExaAmpere</returns>
	public static Quantity<double, ExaAmpere> ToExaAmpere<T>(this BaseQuantity<T, DekaAmpere> val) where T:IConvertible {
        return new Quantity<double, ExaAmpere>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaAmpere to PetaAmpere
    /// </summary>
    /// <param name="val">quantity measured in DekaAmpere</param>
    /// <returns>quantity measured in PetaAmpere</returns>
	public static Quantity<double, PetaAmpere> ToPetaAmpere<T>(this BaseQuantity<T, DekaAmpere> val) where T:IConvertible {
        return new Quantity<double, PetaAmpere>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaAmpere to TeraAmpere
    /// </summary>
    /// <param name="val">quantity measured in DekaAmpere</param>
    /// <returns>quantity measured in TeraAmpere</returns>
	public static Quantity<double, TeraAmpere> ToTeraAmpere<T>(this BaseQuantity<T, DekaAmpere> val) where T:IConvertible {
        return new Quantity<double, TeraAmpere>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaAmpere to GigaAmpere
    /// </summary>
    /// <param name="val">quantity measured in DekaAmpere</param>
    /// <returns>quantity measured in GigaAmpere</returns>
	public static Quantity<double, GigaAmpere> ToGigaAmpere<T>(this BaseQuantity<T, DekaAmpere> val) where T:IConvertible {
        return new Quantity<double, GigaAmpere>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaAmpere to MegaAmpere
    /// </summary>
    /// <param name="val">quantity measured in DekaAmpere</param>
    /// <returns>quantity measured in MegaAmpere</returns>
	public static Quantity<double, MegaAmpere> ToMegaAmpere<T>(this BaseQuantity<T, DekaAmpere> val) where T:IConvertible {
        return new Quantity<double, MegaAmpere>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaAmpere to KiloAmpere
    /// </summary>
    /// <param name="val">quantity measured in DekaAmpere</param>
    /// <returns>quantity measured in KiloAmpere</returns>
	public static Quantity<double, KiloAmpere> ToKiloAmpere<T>(this BaseQuantity<T, DekaAmpere> val) where T:IConvertible {
        return new Quantity<double, KiloAmpere>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaAmpere to HectoAmpere
    /// </summary>
    /// <param name="val">quantity measured in DekaAmpere</param>
    /// <returns>quantity measured in HectoAmpere</returns>
	public static Quantity<double, HectoAmpere> ToHectoAmpere<T>(this BaseQuantity<T, DekaAmpere> val) where T:IConvertible {
        return new Quantity<double, HectoAmpere>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaAmpere to DeciAmpere
    /// </summary>
    /// <param name="val">quantity measured in DekaAmpere</param>
    /// <returns>quantity measured in DeciAmpere</returns>
	public static Quantity<double, DeciAmpere> ToDeciAmpere<T>(this BaseQuantity<T, DekaAmpere> val) where T:IConvertible {
        return new Quantity<double, DeciAmpere>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaAmpere to CentiAmpere
    /// </summary>
    /// <param name="val">quantity measured in DekaAmpere</param>
    /// <returns>quantity measured in CentiAmpere</returns>
	public static Quantity<double, CentiAmpere> ToCentiAmpere<T>(this BaseQuantity<T, DekaAmpere> val) where T:IConvertible {
        return new Quantity<double, CentiAmpere>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaAmpere to MilliAmpere
    /// </summary>
    /// <param name="val">quantity measured in DekaAmpere</param>
    /// <returns>quantity measured in MilliAmpere</returns>
	public static Quantity<double, MilliAmpere> ToMilliAmpere<T>(this BaseQuantity<T, DekaAmpere> val) where T:IConvertible {
        return new Quantity<double, MilliAmpere>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaAmpere to MicroAmpere
    /// </summary>
    /// <param name="val">quantity measured in DekaAmpere</param>
    /// <returns>quantity measured in MicroAmpere</returns>
	public static Quantity<double, MicroAmpere> ToMicroAmpere<T>(this BaseQuantity<T, DekaAmpere> val) where T:IConvertible {
        return new Quantity<double, MicroAmpere>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaAmpere to NanoAmpere
    /// </summary>
    /// <param name="val">quantity measured in DekaAmpere</param>
    /// <returns>quantity measured in NanoAmpere</returns>
	public static Quantity<double, NanoAmpere> ToNanoAmpere<T>(this BaseQuantity<T, DekaAmpere> val) where T:IConvertible {
        return new Quantity<double, NanoAmpere>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaAmpere to PicoAmpere
    /// </summary>
    /// <param name="val">quantity measured in DekaAmpere</param>
    /// <returns>quantity measured in PicoAmpere</returns>
	public static Quantity<double, PicoAmpere> ToPicoAmpere<T>(this BaseQuantity<T, DekaAmpere> val) where T:IConvertible {
        return new Quantity<double, PicoAmpere>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaAmpere to FemtoAmpere
    /// </summary>
    /// <param name="val">quantity measured in DekaAmpere</param>
    /// <returns>quantity measured in FemtoAmpere</returns>
	public static Quantity<double, FemtoAmpere> ToFemtoAmpere<T>(this BaseQuantity<T, DekaAmpere> val) where T:IConvertible {
        return new Quantity<double, FemtoAmpere>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaAmpere to AttoAmpere
    /// </summary>
    /// <param name="val">quantity measured in DekaAmpere</param>
    /// <returns>quantity measured in AttoAmpere</returns>
	public static Quantity<double, AttoAmpere> ToAttoAmpere<T>(this BaseQuantity<T, DekaAmpere> val) where T:IConvertible {
        return new Quantity<double, AttoAmpere>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaAmpere to ZeptoAmpere
    /// </summary>
    /// <param name="val">quantity measured in DekaAmpere</param>
    /// <returns>quantity measured in ZeptoAmpere</returns>
	public static Quantity<double, ZeptoAmpere> ToZeptoAmpere<T>(this BaseQuantity<T, DekaAmpere> val) where T:IConvertible {
        return new Quantity<double, ZeptoAmpere>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaAmpere to YoctoAmpere
    /// </summary>
    /// <param name="val">quantity measured in DekaAmpere</param>
    /// <returns>quantity measured in YoctoAmpere</returns>
	public static Quantity<double, YoctoAmpere> ToYoctoAmpere<T>(this BaseQuantity<T, DekaAmpere> val) where T:IConvertible {
        return new Quantity<double, YoctoAmpere>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DeciAmpere to YottaAmpere
    /// </summary>
    /// <param name="val">quantity measured in DeciAmpere</param>
    /// <returns>quantity measured in YottaAmpere</returns>
	public static Quantity<double, YottaAmpere> ToYottaAmpere<T>(this BaseQuantity<T, DeciAmpere> val) where T:IConvertible {
        return new Quantity<double, YottaAmpere>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciAmpere to ZettaAmpere
    /// </summary>
    /// <param name="val">quantity measured in DeciAmpere</param>
    /// <returns>quantity measured in ZettaAmpere</returns>
	public static Quantity<double, ZettaAmpere> ToZettaAmpere<T>(this BaseQuantity<T, DeciAmpere> val) where T:IConvertible {
        return new Quantity<double, ZettaAmpere>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciAmpere to ExaAmpere
    /// </summary>
    /// <param name="val">quantity measured in DeciAmpere</param>
    /// <returns>quantity measured in ExaAmpere</returns>
	public static Quantity<double, ExaAmpere> ToExaAmpere<T>(this BaseQuantity<T, DeciAmpere> val) where T:IConvertible {
        return new Quantity<double, ExaAmpere>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciAmpere to PetaAmpere
    /// </summary>
    /// <param name="val">quantity measured in DeciAmpere</param>
    /// <returns>quantity measured in PetaAmpere</returns>
	public static Quantity<double, PetaAmpere> ToPetaAmpere<T>(this BaseQuantity<T, DeciAmpere> val) where T:IConvertible {
        return new Quantity<double, PetaAmpere>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciAmpere to TeraAmpere
    /// </summary>
    /// <param name="val">quantity measured in DeciAmpere</param>
    /// <returns>quantity measured in TeraAmpere</returns>
	public static Quantity<double, TeraAmpere> ToTeraAmpere<T>(this BaseQuantity<T, DeciAmpere> val) where T:IConvertible {
        return new Quantity<double, TeraAmpere>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciAmpere to GigaAmpere
    /// </summary>
    /// <param name="val">quantity measured in DeciAmpere</param>
    /// <returns>quantity measured in GigaAmpere</returns>
	public static Quantity<double, GigaAmpere> ToGigaAmpere<T>(this BaseQuantity<T, DeciAmpere> val) where T:IConvertible {
        return new Quantity<double, GigaAmpere>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciAmpere to MegaAmpere
    /// </summary>
    /// <param name="val">quantity measured in DeciAmpere</param>
    /// <returns>quantity measured in MegaAmpere</returns>
	public static Quantity<double, MegaAmpere> ToMegaAmpere<T>(this BaseQuantity<T, DeciAmpere> val) where T:IConvertible {
        return new Quantity<double, MegaAmpere>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciAmpere to KiloAmpere
    /// </summary>
    /// <param name="val">quantity measured in DeciAmpere</param>
    /// <returns>quantity measured in KiloAmpere</returns>
	public static Quantity<double, KiloAmpere> ToKiloAmpere<T>(this BaseQuantity<T, DeciAmpere> val) where T:IConvertible {
        return new Quantity<double, KiloAmpere>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciAmpere to HectoAmpere
    /// </summary>
    /// <param name="val">quantity measured in DeciAmpere</param>
    /// <returns>quantity measured in HectoAmpere</returns>
	public static Quantity<double, HectoAmpere> ToHectoAmpere<T>(this BaseQuantity<T, DeciAmpere> val) where T:IConvertible {
        return new Quantity<double, HectoAmpere>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciAmpere to DekaAmpere
    /// </summary>
    /// <param name="val">quantity measured in DeciAmpere</param>
    /// <returns>quantity measured in DekaAmpere</returns>
	public static Quantity<double, DekaAmpere> ToDekaAmpere<T>(this BaseQuantity<T, DeciAmpere> val) where T:IConvertible {
        return new Quantity<double, DekaAmpere>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciAmpere to CentiAmpere
    /// </summary>
    /// <param name="val">quantity measured in DeciAmpere</param>
    /// <returns>quantity measured in CentiAmpere</returns>
	public static Quantity<double, CentiAmpere> ToCentiAmpere<T>(this BaseQuantity<T, DeciAmpere> val) where T:IConvertible {
        return new Quantity<double, CentiAmpere>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciAmpere to MilliAmpere
    /// </summary>
    /// <param name="val">quantity measured in DeciAmpere</param>
    /// <returns>quantity measured in MilliAmpere</returns>
	public static Quantity<double, MilliAmpere> ToMilliAmpere<T>(this BaseQuantity<T, DeciAmpere> val) where T:IConvertible {
        return new Quantity<double, MilliAmpere>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciAmpere to MicroAmpere
    /// </summary>
    /// <param name="val">quantity measured in DeciAmpere</param>
    /// <returns>quantity measured in MicroAmpere</returns>
	public static Quantity<double, MicroAmpere> ToMicroAmpere<T>(this BaseQuantity<T, DeciAmpere> val) where T:IConvertible {
        return new Quantity<double, MicroAmpere>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciAmpere to NanoAmpere
    /// </summary>
    /// <param name="val">quantity measured in DeciAmpere</param>
    /// <returns>quantity measured in NanoAmpere</returns>
	public static Quantity<double, NanoAmpere> ToNanoAmpere<T>(this BaseQuantity<T, DeciAmpere> val) where T:IConvertible {
        return new Quantity<double, NanoAmpere>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciAmpere to PicoAmpere
    /// </summary>
    /// <param name="val">quantity measured in DeciAmpere</param>
    /// <returns>quantity measured in PicoAmpere</returns>
	public static Quantity<double, PicoAmpere> ToPicoAmpere<T>(this BaseQuantity<T, DeciAmpere> val) where T:IConvertible {
        return new Quantity<double, PicoAmpere>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciAmpere to FemtoAmpere
    /// </summary>
    /// <param name="val">quantity measured in DeciAmpere</param>
    /// <returns>quantity measured in FemtoAmpere</returns>
	public static Quantity<double, FemtoAmpere> ToFemtoAmpere<T>(this BaseQuantity<T, DeciAmpere> val) where T:IConvertible {
        return new Quantity<double, FemtoAmpere>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciAmpere to AttoAmpere
    /// </summary>
    /// <param name="val">quantity measured in DeciAmpere</param>
    /// <returns>quantity measured in AttoAmpere</returns>
	public static Quantity<double, AttoAmpere> ToAttoAmpere<T>(this BaseQuantity<T, DeciAmpere> val) where T:IConvertible {
        return new Quantity<double, AttoAmpere>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciAmpere to ZeptoAmpere
    /// </summary>
    /// <param name="val">quantity measured in DeciAmpere</param>
    /// <returns>quantity measured in ZeptoAmpere</returns>
	public static Quantity<double, ZeptoAmpere> ToZeptoAmpere<T>(this BaseQuantity<T, DeciAmpere> val) where T:IConvertible {
        return new Quantity<double, ZeptoAmpere>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciAmpere to YoctoAmpere
    /// </summary>
    /// <param name="val">quantity measured in DeciAmpere</param>
    /// <returns>quantity measured in YoctoAmpere</returns>
	public static Quantity<double, YoctoAmpere> ToYoctoAmpere<T>(this BaseQuantity<T, DeciAmpere> val) where T:IConvertible {
        return new Quantity<double, YoctoAmpere>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert CentiAmpere to YottaAmpere
    /// </summary>
    /// <param name="val">quantity measured in CentiAmpere</param>
    /// <returns>quantity measured in YottaAmpere</returns>
	public static Quantity<double, YottaAmpere> ToYottaAmpere<T>(this BaseQuantity<T, CentiAmpere> val) where T:IConvertible {
        return new Quantity<double, YottaAmpere>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiAmpere to ZettaAmpere
    /// </summary>
    /// <param name="val">quantity measured in CentiAmpere</param>
    /// <returns>quantity measured in ZettaAmpere</returns>
	public static Quantity<double, ZettaAmpere> ToZettaAmpere<T>(this BaseQuantity<T, CentiAmpere> val) where T:IConvertible {
        return new Quantity<double, ZettaAmpere>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiAmpere to ExaAmpere
    /// </summary>
    /// <param name="val">quantity measured in CentiAmpere</param>
    /// <returns>quantity measured in ExaAmpere</returns>
	public static Quantity<double, ExaAmpere> ToExaAmpere<T>(this BaseQuantity<T, CentiAmpere> val) where T:IConvertible {
        return new Quantity<double, ExaAmpere>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiAmpere to PetaAmpere
    /// </summary>
    /// <param name="val">quantity measured in CentiAmpere</param>
    /// <returns>quantity measured in PetaAmpere</returns>
	public static Quantity<double, PetaAmpere> ToPetaAmpere<T>(this BaseQuantity<T, CentiAmpere> val) where T:IConvertible {
        return new Quantity<double, PetaAmpere>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiAmpere to TeraAmpere
    /// </summary>
    /// <param name="val">quantity measured in CentiAmpere</param>
    /// <returns>quantity measured in TeraAmpere</returns>
	public static Quantity<double, TeraAmpere> ToTeraAmpere<T>(this BaseQuantity<T, CentiAmpere> val) where T:IConvertible {
        return new Quantity<double, TeraAmpere>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiAmpere to GigaAmpere
    /// </summary>
    /// <param name="val">quantity measured in CentiAmpere</param>
    /// <returns>quantity measured in GigaAmpere</returns>
	public static Quantity<double, GigaAmpere> ToGigaAmpere<T>(this BaseQuantity<T, CentiAmpere> val) where T:IConvertible {
        return new Quantity<double, GigaAmpere>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiAmpere to MegaAmpere
    /// </summary>
    /// <param name="val">quantity measured in CentiAmpere</param>
    /// <returns>quantity measured in MegaAmpere</returns>
	public static Quantity<double, MegaAmpere> ToMegaAmpere<T>(this BaseQuantity<T, CentiAmpere> val) where T:IConvertible {
        return new Quantity<double, MegaAmpere>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiAmpere to KiloAmpere
    /// </summary>
    /// <param name="val">quantity measured in CentiAmpere</param>
    /// <returns>quantity measured in KiloAmpere</returns>
	public static Quantity<double, KiloAmpere> ToKiloAmpere<T>(this BaseQuantity<T, CentiAmpere> val) where T:IConvertible {
        return new Quantity<double, KiloAmpere>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiAmpere to HectoAmpere
    /// </summary>
    /// <param name="val">quantity measured in CentiAmpere</param>
    /// <returns>quantity measured in HectoAmpere</returns>
	public static Quantity<double, HectoAmpere> ToHectoAmpere<T>(this BaseQuantity<T, CentiAmpere> val) where T:IConvertible {
        return new Quantity<double, HectoAmpere>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiAmpere to DekaAmpere
    /// </summary>
    /// <param name="val">quantity measured in CentiAmpere</param>
    /// <returns>quantity measured in DekaAmpere</returns>
	public static Quantity<double, DekaAmpere> ToDekaAmpere<T>(this BaseQuantity<T, CentiAmpere> val) where T:IConvertible {
        return new Quantity<double, DekaAmpere>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiAmpere to DeciAmpere
    /// </summary>
    /// <param name="val">quantity measured in CentiAmpere</param>
    /// <returns>quantity measured in DeciAmpere</returns>
	public static Quantity<double, DeciAmpere> ToDeciAmpere<T>(this BaseQuantity<T, CentiAmpere> val) where T:IConvertible {
        return new Quantity<double, DeciAmpere>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiAmpere to MilliAmpere
    /// </summary>
    /// <param name="val">quantity measured in CentiAmpere</param>
    /// <returns>quantity measured in MilliAmpere</returns>
	public static Quantity<double, MilliAmpere> ToMilliAmpere<T>(this BaseQuantity<T, CentiAmpere> val) where T:IConvertible {
        return new Quantity<double, MilliAmpere>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiAmpere to MicroAmpere
    /// </summary>
    /// <param name="val">quantity measured in CentiAmpere</param>
    /// <returns>quantity measured in MicroAmpere</returns>
	public static Quantity<double, MicroAmpere> ToMicroAmpere<T>(this BaseQuantity<T, CentiAmpere> val) where T:IConvertible {
        return new Quantity<double, MicroAmpere>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiAmpere to NanoAmpere
    /// </summary>
    /// <param name="val">quantity measured in CentiAmpere</param>
    /// <returns>quantity measured in NanoAmpere</returns>
	public static Quantity<double, NanoAmpere> ToNanoAmpere<T>(this BaseQuantity<T, CentiAmpere> val) where T:IConvertible {
        return new Quantity<double, NanoAmpere>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiAmpere to PicoAmpere
    /// </summary>
    /// <param name="val">quantity measured in CentiAmpere</param>
    /// <returns>quantity measured in PicoAmpere</returns>
	public static Quantity<double, PicoAmpere> ToPicoAmpere<T>(this BaseQuantity<T, CentiAmpere> val) where T:IConvertible {
        return new Quantity<double, PicoAmpere>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiAmpere to FemtoAmpere
    /// </summary>
    /// <param name="val">quantity measured in CentiAmpere</param>
    /// <returns>quantity measured in FemtoAmpere</returns>
	public static Quantity<double, FemtoAmpere> ToFemtoAmpere<T>(this BaseQuantity<T, CentiAmpere> val) where T:IConvertible {
        return new Quantity<double, FemtoAmpere>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiAmpere to AttoAmpere
    /// </summary>
    /// <param name="val">quantity measured in CentiAmpere</param>
    /// <returns>quantity measured in AttoAmpere</returns>
	public static Quantity<double, AttoAmpere> ToAttoAmpere<T>(this BaseQuantity<T, CentiAmpere> val) where T:IConvertible {
        return new Quantity<double, AttoAmpere>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiAmpere to ZeptoAmpere
    /// </summary>
    /// <param name="val">quantity measured in CentiAmpere</param>
    /// <returns>quantity measured in ZeptoAmpere</returns>
	public static Quantity<double, ZeptoAmpere> ToZeptoAmpere<T>(this BaseQuantity<T, CentiAmpere> val) where T:IConvertible {
        return new Quantity<double, ZeptoAmpere>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiAmpere to YoctoAmpere
    /// </summary>
    /// <param name="val">quantity measured in CentiAmpere</param>
    /// <returns>quantity measured in YoctoAmpere</returns>
	public static Quantity<double, YoctoAmpere> ToYoctoAmpere<T>(this BaseQuantity<T, CentiAmpere> val) where T:IConvertible {
        return new Quantity<double, YoctoAmpere>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert MilliAmpere to YottaAmpere
    /// </summary>
    /// <param name="val">quantity measured in MilliAmpere</param>
    /// <returns>quantity measured in YottaAmpere</returns>
	public static Quantity<double, YottaAmpere> ToYottaAmpere<T>(this BaseQuantity<T, MilliAmpere> val) where T:IConvertible {
        return new Quantity<double, YottaAmpere>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliAmpere to ZettaAmpere
    /// </summary>
    /// <param name="val">quantity measured in MilliAmpere</param>
    /// <returns>quantity measured in ZettaAmpere</returns>
	public static Quantity<double, ZettaAmpere> ToZettaAmpere<T>(this BaseQuantity<T, MilliAmpere> val) where T:IConvertible {
        return new Quantity<double, ZettaAmpere>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliAmpere to ExaAmpere
    /// </summary>
    /// <param name="val">quantity measured in MilliAmpere</param>
    /// <returns>quantity measured in ExaAmpere</returns>
	public static Quantity<double, ExaAmpere> ToExaAmpere<T>(this BaseQuantity<T, MilliAmpere> val) where T:IConvertible {
        return new Quantity<double, ExaAmpere>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliAmpere to PetaAmpere
    /// </summary>
    /// <param name="val">quantity measured in MilliAmpere</param>
    /// <returns>quantity measured in PetaAmpere</returns>
	public static Quantity<double, PetaAmpere> ToPetaAmpere<T>(this BaseQuantity<T, MilliAmpere> val) where T:IConvertible {
        return new Quantity<double, PetaAmpere>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliAmpere to TeraAmpere
    /// </summary>
    /// <param name="val">quantity measured in MilliAmpere</param>
    /// <returns>quantity measured in TeraAmpere</returns>
	public static Quantity<double, TeraAmpere> ToTeraAmpere<T>(this BaseQuantity<T, MilliAmpere> val) where T:IConvertible {
        return new Quantity<double, TeraAmpere>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliAmpere to GigaAmpere
    /// </summary>
    /// <param name="val">quantity measured in MilliAmpere</param>
    /// <returns>quantity measured in GigaAmpere</returns>
	public static Quantity<double, GigaAmpere> ToGigaAmpere<T>(this BaseQuantity<T, MilliAmpere> val) where T:IConvertible {
        return new Quantity<double, GigaAmpere>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliAmpere to MegaAmpere
    /// </summary>
    /// <param name="val">quantity measured in MilliAmpere</param>
    /// <returns>quantity measured in MegaAmpere</returns>
	public static Quantity<double, MegaAmpere> ToMegaAmpere<T>(this BaseQuantity<T, MilliAmpere> val) where T:IConvertible {
        return new Quantity<double, MegaAmpere>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliAmpere to KiloAmpere
    /// </summary>
    /// <param name="val">quantity measured in MilliAmpere</param>
    /// <returns>quantity measured in KiloAmpere</returns>
	public static Quantity<double, KiloAmpere> ToKiloAmpere<T>(this BaseQuantity<T, MilliAmpere> val) where T:IConvertible {
        return new Quantity<double, KiloAmpere>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliAmpere to HectoAmpere
    /// </summary>
    /// <param name="val">quantity measured in MilliAmpere</param>
    /// <returns>quantity measured in HectoAmpere</returns>
	public static Quantity<double, HectoAmpere> ToHectoAmpere<T>(this BaseQuantity<T, MilliAmpere> val) where T:IConvertible {
        return new Quantity<double, HectoAmpere>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliAmpere to DekaAmpere
    /// </summary>
    /// <param name="val">quantity measured in MilliAmpere</param>
    /// <returns>quantity measured in DekaAmpere</returns>
	public static Quantity<double, DekaAmpere> ToDekaAmpere<T>(this BaseQuantity<T, MilliAmpere> val) where T:IConvertible {
        return new Quantity<double, DekaAmpere>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliAmpere to DeciAmpere
    /// </summary>
    /// <param name="val">quantity measured in MilliAmpere</param>
    /// <returns>quantity measured in DeciAmpere</returns>
	public static Quantity<double, DeciAmpere> ToDeciAmpere<T>(this BaseQuantity<T, MilliAmpere> val) where T:IConvertible {
        return new Quantity<double, DeciAmpere>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliAmpere to CentiAmpere
    /// </summary>
    /// <param name="val">quantity measured in MilliAmpere</param>
    /// <returns>quantity measured in CentiAmpere</returns>
	public static Quantity<double, CentiAmpere> ToCentiAmpere<T>(this BaseQuantity<T, MilliAmpere> val) where T:IConvertible {
        return new Quantity<double, CentiAmpere>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliAmpere to MicroAmpere
    /// </summary>
    /// <param name="val">quantity measured in MilliAmpere</param>
    /// <returns>quantity measured in MicroAmpere</returns>
	public static Quantity<double, MicroAmpere> ToMicroAmpere<T>(this BaseQuantity<T, MilliAmpere> val) where T:IConvertible {
        return new Quantity<double, MicroAmpere>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliAmpere to NanoAmpere
    /// </summary>
    /// <param name="val">quantity measured in MilliAmpere</param>
    /// <returns>quantity measured in NanoAmpere</returns>
	public static Quantity<double, NanoAmpere> ToNanoAmpere<T>(this BaseQuantity<T, MilliAmpere> val) where T:IConvertible {
        return new Quantity<double, NanoAmpere>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliAmpere to PicoAmpere
    /// </summary>
    /// <param name="val">quantity measured in MilliAmpere</param>
    /// <returns>quantity measured in PicoAmpere</returns>
	public static Quantity<double, PicoAmpere> ToPicoAmpere<T>(this BaseQuantity<T, MilliAmpere> val) where T:IConvertible {
        return new Quantity<double, PicoAmpere>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliAmpere to FemtoAmpere
    /// </summary>
    /// <param name="val">quantity measured in MilliAmpere</param>
    /// <returns>quantity measured in FemtoAmpere</returns>
	public static Quantity<double, FemtoAmpere> ToFemtoAmpere<T>(this BaseQuantity<T, MilliAmpere> val) where T:IConvertible {
        return new Quantity<double, FemtoAmpere>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliAmpere to AttoAmpere
    /// </summary>
    /// <param name="val">quantity measured in MilliAmpere</param>
    /// <returns>quantity measured in AttoAmpere</returns>
	public static Quantity<double, AttoAmpere> ToAttoAmpere<T>(this BaseQuantity<T, MilliAmpere> val) where T:IConvertible {
        return new Quantity<double, AttoAmpere>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliAmpere to ZeptoAmpere
    /// </summary>
    /// <param name="val">quantity measured in MilliAmpere</param>
    /// <returns>quantity measured in ZeptoAmpere</returns>
	public static Quantity<double, ZeptoAmpere> ToZeptoAmpere<T>(this BaseQuantity<T, MilliAmpere> val) where T:IConvertible {
        return new Quantity<double, ZeptoAmpere>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliAmpere to YoctoAmpere
    /// </summary>
    /// <param name="val">quantity measured in MilliAmpere</param>
    /// <returns>quantity measured in YoctoAmpere</returns>
	public static Quantity<double, YoctoAmpere> ToYoctoAmpere<T>(this BaseQuantity<T, MilliAmpere> val) where T:IConvertible {
        return new Quantity<double, YoctoAmpere>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MicroAmpere to YottaAmpere
    /// </summary>
    /// <param name="val">quantity measured in MicroAmpere</param>
    /// <returns>quantity measured in YottaAmpere</returns>
	public static Quantity<double, YottaAmpere> ToYottaAmpere<T>(this BaseQuantity<T, MicroAmpere> val) where T:IConvertible {
        return new Quantity<double, YottaAmpere>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroAmpere to ZettaAmpere
    /// </summary>
    /// <param name="val">quantity measured in MicroAmpere</param>
    /// <returns>quantity measured in ZettaAmpere</returns>
	public static Quantity<double, ZettaAmpere> ToZettaAmpere<T>(this BaseQuantity<T, MicroAmpere> val) where T:IConvertible {
        return new Quantity<double, ZettaAmpere>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroAmpere to ExaAmpere
    /// </summary>
    /// <param name="val">quantity measured in MicroAmpere</param>
    /// <returns>quantity measured in ExaAmpere</returns>
	public static Quantity<double, ExaAmpere> ToExaAmpere<T>(this BaseQuantity<T, MicroAmpere> val) where T:IConvertible {
        return new Quantity<double, ExaAmpere>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroAmpere to PetaAmpere
    /// </summary>
    /// <param name="val">quantity measured in MicroAmpere</param>
    /// <returns>quantity measured in PetaAmpere</returns>
	public static Quantity<double, PetaAmpere> ToPetaAmpere<T>(this BaseQuantity<T, MicroAmpere> val) where T:IConvertible {
        return new Quantity<double, PetaAmpere>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroAmpere to TeraAmpere
    /// </summary>
    /// <param name="val">quantity measured in MicroAmpere</param>
    /// <returns>quantity measured in TeraAmpere</returns>
	public static Quantity<double, TeraAmpere> ToTeraAmpere<T>(this BaseQuantity<T, MicroAmpere> val) where T:IConvertible {
        return new Quantity<double, TeraAmpere>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroAmpere to GigaAmpere
    /// </summary>
    /// <param name="val">quantity measured in MicroAmpere</param>
    /// <returns>quantity measured in GigaAmpere</returns>
	public static Quantity<double, GigaAmpere> ToGigaAmpere<T>(this BaseQuantity<T, MicroAmpere> val) where T:IConvertible {
        return new Quantity<double, GigaAmpere>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroAmpere to MegaAmpere
    /// </summary>
    /// <param name="val">quantity measured in MicroAmpere</param>
    /// <returns>quantity measured in MegaAmpere</returns>
	public static Quantity<double, MegaAmpere> ToMegaAmpere<T>(this BaseQuantity<T, MicroAmpere> val) where T:IConvertible {
        return new Quantity<double, MegaAmpere>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroAmpere to KiloAmpere
    /// </summary>
    /// <param name="val">quantity measured in MicroAmpere</param>
    /// <returns>quantity measured in KiloAmpere</returns>
	public static Quantity<double, KiloAmpere> ToKiloAmpere<T>(this BaseQuantity<T, MicroAmpere> val) where T:IConvertible {
        return new Quantity<double, KiloAmpere>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroAmpere to HectoAmpere
    /// </summary>
    /// <param name="val">quantity measured in MicroAmpere</param>
    /// <returns>quantity measured in HectoAmpere</returns>
	public static Quantity<double, HectoAmpere> ToHectoAmpere<T>(this BaseQuantity<T, MicroAmpere> val) where T:IConvertible {
        return new Quantity<double, HectoAmpere>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroAmpere to DekaAmpere
    /// </summary>
    /// <param name="val">quantity measured in MicroAmpere</param>
    /// <returns>quantity measured in DekaAmpere</returns>
	public static Quantity<double, DekaAmpere> ToDekaAmpere<T>(this BaseQuantity<T, MicroAmpere> val) where T:IConvertible {
        return new Quantity<double, DekaAmpere>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroAmpere to DeciAmpere
    /// </summary>
    /// <param name="val">quantity measured in MicroAmpere</param>
    /// <returns>quantity measured in DeciAmpere</returns>
	public static Quantity<double, DeciAmpere> ToDeciAmpere<T>(this BaseQuantity<T, MicroAmpere> val) where T:IConvertible {
        return new Quantity<double, DeciAmpere>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroAmpere to CentiAmpere
    /// </summary>
    /// <param name="val">quantity measured in MicroAmpere</param>
    /// <returns>quantity measured in CentiAmpere</returns>
	public static Quantity<double, CentiAmpere> ToCentiAmpere<T>(this BaseQuantity<T, MicroAmpere> val) where T:IConvertible {
        return new Quantity<double, CentiAmpere>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroAmpere to MilliAmpere
    /// </summary>
    /// <param name="val">quantity measured in MicroAmpere</param>
    /// <returns>quantity measured in MilliAmpere</returns>
	public static Quantity<double, MilliAmpere> ToMilliAmpere<T>(this BaseQuantity<T, MicroAmpere> val) where T:IConvertible {
        return new Quantity<double, MilliAmpere>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroAmpere to NanoAmpere
    /// </summary>
    /// <param name="val">quantity measured in MicroAmpere</param>
    /// <returns>quantity measured in NanoAmpere</returns>
	public static Quantity<double, NanoAmpere> ToNanoAmpere<T>(this BaseQuantity<T, MicroAmpere> val) where T:IConvertible {
        return new Quantity<double, NanoAmpere>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroAmpere to PicoAmpere
    /// </summary>
    /// <param name="val">quantity measured in MicroAmpere</param>
    /// <returns>quantity measured in PicoAmpere</returns>
	public static Quantity<double, PicoAmpere> ToPicoAmpere<T>(this BaseQuantity<T, MicroAmpere> val) where T:IConvertible {
        return new Quantity<double, PicoAmpere>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroAmpere to FemtoAmpere
    /// </summary>
    /// <param name="val">quantity measured in MicroAmpere</param>
    /// <returns>quantity measured in FemtoAmpere</returns>
	public static Quantity<double, FemtoAmpere> ToFemtoAmpere<T>(this BaseQuantity<T, MicroAmpere> val) where T:IConvertible {
        return new Quantity<double, FemtoAmpere>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroAmpere to AttoAmpere
    /// </summary>
    /// <param name="val">quantity measured in MicroAmpere</param>
    /// <returns>quantity measured in AttoAmpere</returns>
	public static Quantity<double, AttoAmpere> ToAttoAmpere<T>(this BaseQuantity<T, MicroAmpere> val) where T:IConvertible {
        return new Quantity<double, AttoAmpere>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroAmpere to ZeptoAmpere
    /// </summary>
    /// <param name="val">quantity measured in MicroAmpere</param>
    /// <returns>quantity measured in ZeptoAmpere</returns>
	public static Quantity<double, ZeptoAmpere> ToZeptoAmpere<T>(this BaseQuantity<T, MicroAmpere> val) where T:IConvertible {
        return new Quantity<double, ZeptoAmpere>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroAmpere to YoctoAmpere
    /// </summary>
    /// <param name="val">quantity measured in MicroAmpere</param>
    /// <returns>quantity measured in YoctoAmpere</returns>
	public static Quantity<double, YoctoAmpere> ToYoctoAmpere<T>(this BaseQuantity<T, MicroAmpere> val) where T:IConvertible {
        return new Quantity<double, YoctoAmpere>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert NanoAmpere to YottaAmpere
    /// </summary>
    /// <param name="val">quantity measured in NanoAmpere</param>
    /// <returns>quantity measured in YottaAmpere</returns>
	public static Quantity<double, YottaAmpere> ToYottaAmpere<T>(this BaseQuantity<T, NanoAmpere> val) where T:IConvertible {
        return new Quantity<double, YottaAmpere>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoAmpere to ZettaAmpere
    /// </summary>
    /// <param name="val">quantity measured in NanoAmpere</param>
    /// <returns>quantity measured in ZettaAmpere</returns>
	public static Quantity<double, ZettaAmpere> ToZettaAmpere<T>(this BaseQuantity<T, NanoAmpere> val) where T:IConvertible {
        return new Quantity<double, ZettaAmpere>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoAmpere to ExaAmpere
    /// </summary>
    /// <param name="val">quantity measured in NanoAmpere</param>
    /// <returns>quantity measured in ExaAmpere</returns>
	public static Quantity<double, ExaAmpere> ToExaAmpere<T>(this BaseQuantity<T, NanoAmpere> val) where T:IConvertible {
        return new Quantity<double, ExaAmpere>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoAmpere to PetaAmpere
    /// </summary>
    /// <param name="val">quantity measured in NanoAmpere</param>
    /// <returns>quantity measured in PetaAmpere</returns>
	public static Quantity<double, PetaAmpere> ToPetaAmpere<T>(this BaseQuantity<T, NanoAmpere> val) where T:IConvertible {
        return new Quantity<double, PetaAmpere>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoAmpere to TeraAmpere
    /// </summary>
    /// <param name="val">quantity measured in NanoAmpere</param>
    /// <returns>quantity measured in TeraAmpere</returns>
	public static Quantity<double, TeraAmpere> ToTeraAmpere<T>(this BaseQuantity<T, NanoAmpere> val) where T:IConvertible {
        return new Quantity<double, TeraAmpere>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoAmpere to GigaAmpere
    /// </summary>
    /// <param name="val">quantity measured in NanoAmpere</param>
    /// <returns>quantity measured in GigaAmpere</returns>
	public static Quantity<double, GigaAmpere> ToGigaAmpere<T>(this BaseQuantity<T, NanoAmpere> val) where T:IConvertible {
        return new Quantity<double, GigaAmpere>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoAmpere to MegaAmpere
    /// </summary>
    /// <param name="val">quantity measured in NanoAmpere</param>
    /// <returns>quantity measured in MegaAmpere</returns>
	public static Quantity<double, MegaAmpere> ToMegaAmpere<T>(this BaseQuantity<T, NanoAmpere> val) where T:IConvertible {
        return new Quantity<double, MegaAmpere>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoAmpere to KiloAmpere
    /// </summary>
    /// <param name="val">quantity measured in NanoAmpere</param>
    /// <returns>quantity measured in KiloAmpere</returns>
	public static Quantity<double, KiloAmpere> ToKiloAmpere<T>(this BaseQuantity<T, NanoAmpere> val) where T:IConvertible {
        return new Quantity<double, KiloAmpere>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoAmpere to HectoAmpere
    /// </summary>
    /// <param name="val">quantity measured in NanoAmpere</param>
    /// <returns>quantity measured in HectoAmpere</returns>
	public static Quantity<double, HectoAmpere> ToHectoAmpere<T>(this BaseQuantity<T, NanoAmpere> val) where T:IConvertible {
        return new Quantity<double, HectoAmpere>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoAmpere to DekaAmpere
    /// </summary>
    /// <param name="val">quantity measured in NanoAmpere</param>
    /// <returns>quantity measured in DekaAmpere</returns>
	public static Quantity<double, DekaAmpere> ToDekaAmpere<T>(this BaseQuantity<T, NanoAmpere> val) where T:IConvertible {
        return new Quantity<double, DekaAmpere>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoAmpere to DeciAmpere
    /// </summary>
    /// <param name="val">quantity measured in NanoAmpere</param>
    /// <returns>quantity measured in DeciAmpere</returns>
	public static Quantity<double, DeciAmpere> ToDeciAmpere<T>(this BaseQuantity<T, NanoAmpere> val) where T:IConvertible {
        return new Quantity<double, DeciAmpere>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoAmpere to CentiAmpere
    /// </summary>
    /// <param name="val">quantity measured in NanoAmpere</param>
    /// <returns>quantity measured in CentiAmpere</returns>
	public static Quantity<double, CentiAmpere> ToCentiAmpere<T>(this BaseQuantity<T, NanoAmpere> val) where T:IConvertible {
        return new Quantity<double, CentiAmpere>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoAmpere to MilliAmpere
    /// </summary>
    /// <param name="val">quantity measured in NanoAmpere</param>
    /// <returns>quantity measured in MilliAmpere</returns>
	public static Quantity<double, MilliAmpere> ToMilliAmpere<T>(this BaseQuantity<T, NanoAmpere> val) where T:IConvertible {
        return new Quantity<double, MilliAmpere>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoAmpere to MicroAmpere
    /// </summary>
    /// <param name="val">quantity measured in NanoAmpere</param>
    /// <returns>quantity measured in MicroAmpere</returns>
	public static Quantity<double, MicroAmpere> ToMicroAmpere<T>(this BaseQuantity<T, NanoAmpere> val) where T:IConvertible {
        return new Quantity<double, MicroAmpere>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoAmpere to PicoAmpere
    /// </summary>
    /// <param name="val">quantity measured in NanoAmpere</param>
    /// <returns>quantity measured in PicoAmpere</returns>
	public static Quantity<double, PicoAmpere> ToPicoAmpere<T>(this BaseQuantity<T, NanoAmpere> val) where T:IConvertible {
        return new Quantity<double, PicoAmpere>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoAmpere to FemtoAmpere
    /// </summary>
    /// <param name="val">quantity measured in NanoAmpere</param>
    /// <returns>quantity measured in FemtoAmpere</returns>
	public static Quantity<double, FemtoAmpere> ToFemtoAmpere<T>(this BaseQuantity<T, NanoAmpere> val) where T:IConvertible {
        return new Quantity<double, FemtoAmpere>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoAmpere to AttoAmpere
    /// </summary>
    /// <param name="val">quantity measured in NanoAmpere</param>
    /// <returns>quantity measured in AttoAmpere</returns>
	public static Quantity<double, AttoAmpere> ToAttoAmpere<T>(this BaseQuantity<T, NanoAmpere> val) where T:IConvertible {
        return new Quantity<double, AttoAmpere>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoAmpere to ZeptoAmpere
    /// </summary>
    /// <param name="val">quantity measured in NanoAmpere</param>
    /// <returns>quantity measured in ZeptoAmpere</returns>
	public static Quantity<double, ZeptoAmpere> ToZeptoAmpere<T>(this BaseQuantity<T, NanoAmpere> val) where T:IConvertible {
        return new Quantity<double, ZeptoAmpere>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoAmpere to YoctoAmpere
    /// </summary>
    /// <param name="val">quantity measured in NanoAmpere</param>
    /// <returns>quantity measured in YoctoAmpere</returns>
	public static Quantity<double, YoctoAmpere> ToYoctoAmpere<T>(this BaseQuantity<T, NanoAmpere> val) where T:IConvertible {
        return new Quantity<double, YoctoAmpere>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert PicoAmpere to YottaAmpere
    /// </summary>
    /// <param name="val">quantity measured in PicoAmpere</param>
    /// <returns>quantity measured in YottaAmpere</returns>
	public static Quantity<double, YottaAmpere> ToYottaAmpere<T>(this BaseQuantity<T, PicoAmpere> val) where T:IConvertible {
        return new Quantity<double, YottaAmpere>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoAmpere to ZettaAmpere
    /// </summary>
    /// <param name="val">quantity measured in PicoAmpere</param>
    /// <returns>quantity measured in ZettaAmpere</returns>
	public static Quantity<double, ZettaAmpere> ToZettaAmpere<T>(this BaseQuantity<T, PicoAmpere> val) where T:IConvertible {
        return new Quantity<double, ZettaAmpere>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoAmpere to ExaAmpere
    /// </summary>
    /// <param name="val">quantity measured in PicoAmpere</param>
    /// <returns>quantity measured in ExaAmpere</returns>
	public static Quantity<double, ExaAmpere> ToExaAmpere<T>(this BaseQuantity<T, PicoAmpere> val) where T:IConvertible {
        return new Quantity<double, ExaAmpere>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoAmpere to PetaAmpere
    /// </summary>
    /// <param name="val">quantity measured in PicoAmpere</param>
    /// <returns>quantity measured in PetaAmpere</returns>
	public static Quantity<double, PetaAmpere> ToPetaAmpere<T>(this BaseQuantity<T, PicoAmpere> val) where T:IConvertible {
        return new Quantity<double, PetaAmpere>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoAmpere to TeraAmpere
    /// </summary>
    /// <param name="val">quantity measured in PicoAmpere</param>
    /// <returns>quantity measured in TeraAmpere</returns>
	public static Quantity<double, TeraAmpere> ToTeraAmpere<T>(this BaseQuantity<T, PicoAmpere> val) where T:IConvertible {
        return new Quantity<double, TeraAmpere>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoAmpere to GigaAmpere
    /// </summary>
    /// <param name="val">quantity measured in PicoAmpere</param>
    /// <returns>quantity measured in GigaAmpere</returns>
	public static Quantity<double, GigaAmpere> ToGigaAmpere<T>(this BaseQuantity<T, PicoAmpere> val) where T:IConvertible {
        return new Quantity<double, GigaAmpere>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoAmpere to MegaAmpere
    /// </summary>
    /// <param name="val">quantity measured in PicoAmpere</param>
    /// <returns>quantity measured in MegaAmpere</returns>
	public static Quantity<double, MegaAmpere> ToMegaAmpere<T>(this BaseQuantity<T, PicoAmpere> val) where T:IConvertible {
        return new Quantity<double, MegaAmpere>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoAmpere to KiloAmpere
    /// </summary>
    /// <param name="val">quantity measured in PicoAmpere</param>
    /// <returns>quantity measured in KiloAmpere</returns>
	public static Quantity<double, KiloAmpere> ToKiloAmpere<T>(this BaseQuantity<T, PicoAmpere> val) where T:IConvertible {
        return new Quantity<double, KiloAmpere>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoAmpere to HectoAmpere
    /// </summary>
    /// <param name="val">quantity measured in PicoAmpere</param>
    /// <returns>quantity measured in HectoAmpere</returns>
	public static Quantity<double, HectoAmpere> ToHectoAmpere<T>(this BaseQuantity<T, PicoAmpere> val) where T:IConvertible {
        return new Quantity<double, HectoAmpere>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoAmpere to DekaAmpere
    /// </summary>
    /// <param name="val">quantity measured in PicoAmpere</param>
    /// <returns>quantity measured in DekaAmpere</returns>
	public static Quantity<double, DekaAmpere> ToDekaAmpere<T>(this BaseQuantity<T, PicoAmpere> val) where T:IConvertible {
        return new Quantity<double, DekaAmpere>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoAmpere to DeciAmpere
    /// </summary>
    /// <param name="val">quantity measured in PicoAmpere</param>
    /// <returns>quantity measured in DeciAmpere</returns>
	public static Quantity<double, DeciAmpere> ToDeciAmpere<T>(this BaseQuantity<T, PicoAmpere> val) where T:IConvertible {
        return new Quantity<double, DeciAmpere>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoAmpere to CentiAmpere
    /// </summary>
    /// <param name="val">quantity measured in PicoAmpere</param>
    /// <returns>quantity measured in CentiAmpere</returns>
	public static Quantity<double, CentiAmpere> ToCentiAmpere<T>(this BaseQuantity<T, PicoAmpere> val) where T:IConvertible {
        return new Quantity<double, CentiAmpere>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoAmpere to MilliAmpere
    /// </summary>
    /// <param name="val">quantity measured in PicoAmpere</param>
    /// <returns>quantity measured in MilliAmpere</returns>
	public static Quantity<double, MilliAmpere> ToMilliAmpere<T>(this BaseQuantity<T, PicoAmpere> val) where T:IConvertible {
        return new Quantity<double, MilliAmpere>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoAmpere to MicroAmpere
    /// </summary>
    /// <param name="val">quantity measured in PicoAmpere</param>
    /// <returns>quantity measured in MicroAmpere</returns>
	public static Quantity<double, MicroAmpere> ToMicroAmpere<T>(this BaseQuantity<T, PicoAmpere> val) where T:IConvertible {
        return new Quantity<double, MicroAmpere>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoAmpere to NanoAmpere
    /// </summary>
    /// <param name="val">quantity measured in PicoAmpere</param>
    /// <returns>quantity measured in NanoAmpere</returns>
	public static Quantity<double, NanoAmpere> ToNanoAmpere<T>(this BaseQuantity<T, PicoAmpere> val) where T:IConvertible {
        return new Quantity<double, NanoAmpere>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoAmpere to FemtoAmpere
    /// </summary>
    /// <param name="val">quantity measured in PicoAmpere</param>
    /// <returns>quantity measured in FemtoAmpere</returns>
	public static Quantity<double, FemtoAmpere> ToFemtoAmpere<T>(this BaseQuantity<T, PicoAmpere> val) where T:IConvertible {
        return new Quantity<double, FemtoAmpere>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoAmpere to AttoAmpere
    /// </summary>
    /// <param name="val">quantity measured in PicoAmpere</param>
    /// <returns>quantity measured in AttoAmpere</returns>
	public static Quantity<double, AttoAmpere> ToAttoAmpere<T>(this BaseQuantity<T, PicoAmpere> val) where T:IConvertible {
        return new Quantity<double, AttoAmpere>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoAmpere to ZeptoAmpere
    /// </summary>
    /// <param name="val">quantity measured in PicoAmpere</param>
    /// <returns>quantity measured in ZeptoAmpere</returns>
	public static Quantity<double, ZeptoAmpere> ToZeptoAmpere<T>(this BaseQuantity<T, PicoAmpere> val) where T:IConvertible {
        return new Quantity<double, ZeptoAmpere>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoAmpere to YoctoAmpere
    /// </summary>
    /// <param name="val">quantity measured in PicoAmpere</param>
    /// <returns>quantity measured in YoctoAmpere</returns>
	public static Quantity<double, YoctoAmpere> ToYoctoAmpere<T>(this BaseQuantity<T, PicoAmpere> val) where T:IConvertible {
        return new Quantity<double, YoctoAmpere>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert FemtoAmpere to YottaAmpere
    /// </summary>
    /// <param name="val">quantity measured in FemtoAmpere</param>
    /// <returns>quantity measured in YottaAmpere</returns>
	public static Quantity<double, YottaAmpere> ToYottaAmpere<T>(this BaseQuantity<T, FemtoAmpere> val) where T:IConvertible {
        return new Quantity<double, YottaAmpere>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoAmpere to ZettaAmpere
    /// </summary>
    /// <param name="val">quantity measured in FemtoAmpere</param>
    /// <returns>quantity measured in ZettaAmpere</returns>
	public static Quantity<double, ZettaAmpere> ToZettaAmpere<T>(this BaseQuantity<T, FemtoAmpere> val) where T:IConvertible {
        return new Quantity<double, ZettaAmpere>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoAmpere to ExaAmpere
    /// </summary>
    /// <param name="val">quantity measured in FemtoAmpere</param>
    /// <returns>quantity measured in ExaAmpere</returns>
	public static Quantity<double, ExaAmpere> ToExaAmpere<T>(this BaseQuantity<T, FemtoAmpere> val) where T:IConvertible {
        return new Quantity<double, ExaAmpere>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoAmpere to PetaAmpere
    /// </summary>
    /// <param name="val">quantity measured in FemtoAmpere</param>
    /// <returns>quantity measured in PetaAmpere</returns>
	public static Quantity<double, PetaAmpere> ToPetaAmpere<T>(this BaseQuantity<T, FemtoAmpere> val) where T:IConvertible {
        return new Quantity<double, PetaAmpere>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoAmpere to TeraAmpere
    /// </summary>
    /// <param name="val">quantity measured in FemtoAmpere</param>
    /// <returns>quantity measured in TeraAmpere</returns>
	public static Quantity<double, TeraAmpere> ToTeraAmpere<T>(this BaseQuantity<T, FemtoAmpere> val) where T:IConvertible {
        return new Quantity<double, TeraAmpere>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoAmpere to GigaAmpere
    /// </summary>
    /// <param name="val">quantity measured in FemtoAmpere</param>
    /// <returns>quantity measured in GigaAmpere</returns>
	public static Quantity<double, GigaAmpere> ToGigaAmpere<T>(this BaseQuantity<T, FemtoAmpere> val) where T:IConvertible {
        return new Quantity<double, GigaAmpere>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoAmpere to MegaAmpere
    /// </summary>
    /// <param name="val">quantity measured in FemtoAmpere</param>
    /// <returns>quantity measured in MegaAmpere</returns>
	public static Quantity<double, MegaAmpere> ToMegaAmpere<T>(this BaseQuantity<T, FemtoAmpere> val) where T:IConvertible {
        return new Quantity<double, MegaAmpere>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoAmpere to KiloAmpere
    /// </summary>
    /// <param name="val">quantity measured in FemtoAmpere</param>
    /// <returns>quantity measured in KiloAmpere</returns>
	public static Quantity<double, KiloAmpere> ToKiloAmpere<T>(this BaseQuantity<T, FemtoAmpere> val) where T:IConvertible {
        return new Quantity<double, KiloAmpere>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoAmpere to HectoAmpere
    /// </summary>
    /// <param name="val">quantity measured in FemtoAmpere</param>
    /// <returns>quantity measured in HectoAmpere</returns>
	public static Quantity<double, HectoAmpere> ToHectoAmpere<T>(this BaseQuantity<T, FemtoAmpere> val) where T:IConvertible {
        return new Quantity<double, HectoAmpere>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoAmpere to DekaAmpere
    /// </summary>
    /// <param name="val">quantity measured in FemtoAmpere</param>
    /// <returns>quantity measured in DekaAmpere</returns>
	public static Quantity<double, DekaAmpere> ToDekaAmpere<T>(this BaseQuantity<T, FemtoAmpere> val) where T:IConvertible {
        return new Quantity<double, DekaAmpere>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoAmpere to DeciAmpere
    /// </summary>
    /// <param name="val">quantity measured in FemtoAmpere</param>
    /// <returns>quantity measured in DeciAmpere</returns>
	public static Quantity<double, DeciAmpere> ToDeciAmpere<T>(this BaseQuantity<T, FemtoAmpere> val) where T:IConvertible {
        return new Quantity<double, DeciAmpere>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoAmpere to CentiAmpere
    /// </summary>
    /// <param name="val">quantity measured in FemtoAmpere</param>
    /// <returns>quantity measured in CentiAmpere</returns>
	public static Quantity<double, CentiAmpere> ToCentiAmpere<T>(this BaseQuantity<T, FemtoAmpere> val) where T:IConvertible {
        return new Quantity<double, CentiAmpere>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoAmpere to MilliAmpere
    /// </summary>
    /// <param name="val">quantity measured in FemtoAmpere</param>
    /// <returns>quantity measured in MilliAmpere</returns>
	public static Quantity<double, MilliAmpere> ToMilliAmpere<T>(this BaseQuantity<T, FemtoAmpere> val) where T:IConvertible {
        return new Quantity<double, MilliAmpere>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoAmpere to MicroAmpere
    /// </summary>
    /// <param name="val">quantity measured in FemtoAmpere</param>
    /// <returns>quantity measured in MicroAmpere</returns>
	public static Quantity<double, MicroAmpere> ToMicroAmpere<T>(this BaseQuantity<T, FemtoAmpere> val) where T:IConvertible {
        return new Quantity<double, MicroAmpere>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoAmpere to NanoAmpere
    /// </summary>
    /// <param name="val">quantity measured in FemtoAmpere</param>
    /// <returns>quantity measured in NanoAmpere</returns>
	public static Quantity<double, NanoAmpere> ToNanoAmpere<T>(this BaseQuantity<T, FemtoAmpere> val) where T:IConvertible {
        return new Quantity<double, NanoAmpere>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoAmpere to PicoAmpere
    /// </summary>
    /// <param name="val">quantity measured in FemtoAmpere</param>
    /// <returns>quantity measured in PicoAmpere</returns>
	public static Quantity<double, PicoAmpere> ToPicoAmpere<T>(this BaseQuantity<T, FemtoAmpere> val) where T:IConvertible {
        return new Quantity<double, PicoAmpere>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoAmpere to AttoAmpere
    /// </summary>
    /// <param name="val">quantity measured in FemtoAmpere</param>
    /// <returns>quantity measured in AttoAmpere</returns>
	public static Quantity<double, AttoAmpere> ToAttoAmpere<T>(this BaseQuantity<T, FemtoAmpere> val) where T:IConvertible {
        return new Quantity<double, AttoAmpere>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoAmpere to ZeptoAmpere
    /// </summary>
    /// <param name="val">quantity measured in FemtoAmpere</param>
    /// <returns>quantity measured in ZeptoAmpere</returns>
	public static Quantity<double, ZeptoAmpere> ToZeptoAmpere<T>(this BaseQuantity<T, FemtoAmpere> val) where T:IConvertible {
        return new Quantity<double, ZeptoAmpere>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoAmpere to YoctoAmpere
    /// </summary>
    /// <param name="val">quantity measured in FemtoAmpere</param>
    /// <returns>quantity measured in YoctoAmpere</returns>
	public static Quantity<double, YoctoAmpere> ToYoctoAmpere<T>(this BaseQuantity<T, FemtoAmpere> val) where T:IConvertible {
        return new Quantity<double, YoctoAmpere>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert AttoAmpere to YottaAmpere
    /// </summary>
    /// <param name="val">quantity measured in AttoAmpere</param>
    /// <returns>quantity measured in YottaAmpere</returns>
	public static Quantity<double, YottaAmpere> ToYottaAmpere<T>(this BaseQuantity<T, AttoAmpere> val) where T:IConvertible {
        return new Quantity<double, YottaAmpere>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoAmpere to ZettaAmpere
    /// </summary>
    /// <param name="val">quantity measured in AttoAmpere</param>
    /// <returns>quantity measured in ZettaAmpere</returns>
	public static Quantity<double, ZettaAmpere> ToZettaAmpere<T>(this BaseQuantity<T, AttoAmpere> val) where T:IConvertible {
        return new Quantity<double, ZettaAmpere>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoAmpere to ExaAmpere
    /// </summary>
    /// <param name="val">quantity measured in AttoAmpere</param>
    /// <returns>quantity measured in ExaAmpere</returns>
	public static Quantity<double, ExaAmpere> ToExaAmpere<T>(this BaseQuantity<T, AttoAmpere> val) where T:IConvertible {
        return new Quantity<double, ExaAmpere>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoAmpere to PetaAmpere
    /// </summary>
    /// <param name="val">quantity measured in AttoAmpere</param>
    /// <returns>quantity measured in PetaAmpere</returns>
	public static Quantity<double, PetaAmpere> ToPetaAmpere<T>(this BaseQuantity<T, AttoAmpere> val) where T:IConvertible {
        return new Quantity<double, PetaAmpere>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoAmpere to TeraAmpere
    /// </summary>
    /// <param name="val">quantity measured in AttoAmpere</param>
    /// <returns>quantity measured in TeraAmpere</returns>
	public static Quantity<double, TeraAmpere> ToTeraAmpere<T>(this BaseQuantity<T, AttoAmpere> val) where T:IConvertible {
        return new Quantity<double, TeraAmpere>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoAmpere to GigaAmpere
    /// </summary>
    /// <param name="val">quantity measured in AttoAmpere</param>
    /// <returns>quantity measured in GigaAmpere</returns>
	public static Quantity<double, GigaAmpere> ToGigaAmpere<T>(this BaseQuantity<T, AttoAmpere> val) where T:IConvertible {
        return new Quantity<double, GigaAmpere>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoAmpere to MegaAmpere
    /// </summary>
    /// <param name="val">quantity measured in AttoAmpere</param>
    /// <returns>quantity measured in MegaAmpere</returns>
	public static Quantity<double, MegaAmpere> ToMegaAmpere<T>(this BaseQuantity<T, AttoAmpere> val) where T:IConvertible {
        return new Quantity<double, MegaAmpere>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoAmpere to KiloAmpere
    /// </summary>
    /// <param name="val">quantity measured in AttoAmpere</param>
    /// <returns>quantity measured in KiloAmpere</returns>
	public static Quantity<double, KiloAmpere> ToKiloAmpere<T>(this BaseQuantity<T, AttoAmpere> val) where T:IConvertible {
        return new Quantity<double, KiloAmpere>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoAmpere to HectoAmpere
    /// </summary>
    /// <param name="val">quantity measured in AttoAmpere</param>
    /// <returns>quantity measured in HectoAmpere</returns>
	public static Quantity<double, HectoAmpere> ToHectoAmpere<T>(this BaseQuantity<T, AttoAmpere> val) where T:IConvertible {
        return new Quantity<double, HectoAmpere>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoAmpere to DekaAmpere
    /// </summary>
    /// <param name="val">quantity measured in AttoAmpere</param>
    /// <returns>quantity measured in DekaAmpere</returns>
	public static Quantity<double, DekaAmpere> ToDekaAmpere<T>(this BaseQuantity<T, AttoAmpere> val) where T:IConvertible {
        return new Quantity<double, DekaAmpere>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoAmpere to DeciAmpere
    /// </summary>
    /// <param name="val">quantity measured in AttoAmpere</param>
    /// <returns>quantity measured in DeciAmpere</returns>
	public static Quantity<double, DeciAmpere> ToDeciAmpere<T>(this BaseQuantity<T, AttoAmpere> val) where T:IConvertible {
        return new Quantity<double, DeciAmpere>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoAmpere to CentiAmpere
    /// </summary>
    /// <param name="val">quantity measured in AttoAmpere</param>
    /// <returns>quantity measured in CentiAmpere</returns>
	public static Quantity<double, CentiAmpere> ToCentiAmpere<T>(this BaseQuantity<T, AttoAmpere> val) where T:IConvertible {
        return new Quantity<double, CentiAmpere>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoAmpere to MilliAmpere
    /// </summary>
    /// <param name="val">quantity measured in AttoAmpere</param>
    /// <returns>quantity measured in MilliAmpere</returns>
	public static Quantity<double, MilliAmpere> ToMilliAmpere<T>(this BaseQuantity<T, AttoAmpere> val) where T:IConvertible {
        return new Quantity<double, MilliAmpere>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoAmpere to MicroAmpere
    /// </summary>
    /// <param name="val">quantity measured in AttoAmpere</param>
    /// <returns>quantity measured in MicroAmpere</returns>
	public static Quantity<double, MicroAmpere> ToMicroAmpere<T>(this BaseQuantity<T, AttoAmpere> val) where T:IConvertible {
        return new Quantity<double, MicroAmpere>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoAmpere to NanoAmpere
    /// </summary>
    /// <param name="val">quantity measured in AttoAmpere</param>
    /// <returns>quantity measured in NanoAmpere</returns>
	public static Quantity<double, NanoAmpere> ToNanoAmpere<T>(this BaseQuantity<T, AttoAmpere> val) where T:IConvertible {
        return new Quantity<double, NanoAmpere>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoAmpere to PicoAmpere
    /// </summary>
    /// <param name="val">quantity measured in AttoAmpere</param>
    /// <returns>quantity measured in PicoAmpere</returns>
	public static Quantity<double, PicoAmpere> ToPicoAmpere<T>(this BaseQuantity<T, AttoAmpere> val) where T:IConvertible {
        return new Quantity<double, PicoAmpere>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoAmpere to FemtoAmpere
    /// </summary>
    /// <param name="val">quantity measured in AttoAmpere</param>
    /// <returns>quantity measured in FemtoAmpere</returns>
	public static Quantity<double, FemtoAmpere> ToFemtoAmpere<T>(this BaseQuantity<T, AttoAmpere> val) where T:IConvertible {
        return new Quantity<double, FemtoAmpere>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoAmpere to ZeptoAmpere
    /// </summary>
    /// <param name="val">quantity measured in AttoAmpere</param>
    /// <returns>quantity measured in ZeptoAmpere</returns>
	public static Quantity<double, ZeptoAmpere> ToZeptoAmpere<T>(this BaseQuantity<T, AttoAmpere> val) where T:IConvertible {
        return new Quantity<double, ZeptoAmpere>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoAmpere to YoctoAmpere
    /// </summary>
    /// <param name="val">quantity measured in AttoAmpere</param>
    /// <returns>quantity measured in YoctoAmpere</returns>
	public static Quantity<double, YoctoAmpere> ToYoctoAmpere<T>(this BaseQuantity<T, AttoAmpere> val) where T:IConvertible {
        return new Quantity<double, YoctoAmpere>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoAmpere to YottaAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZeptoAmpere</param>
    /// <returns>quantity measured in YottaAmpere</returns>
	public static Quantity<double, YottaAmpere> ToYottaAmpere<T>(this BaseQuantity<T, ZeptoAmpere> val) where T:IConvertible {
        return new Quantity<double, YottaAmpere>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoAmpere to ZettaAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZeptoAmpere</param>
    /// <returns>quantity measured in ZettaAmpere</returns>
	public static Quantity<double, ZettaAmpere> ToZettaAmpere<T>(this BaseQuantity<T, ZeptoAmpere> val) where T:IConvertible {
        return new Quantity<double, ZettaAmpere>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoAmpere to ExaAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZeptoAmpere</param>
    /// <returns>quantity measured in ExaAmpere</returns>
	public static Quantity<double, ExaAmpere> ToExaAmpere<T>(this BaseQuantity<T, ZeptoAmpere> val) where T:IConvertible {
        return new Quantity<double, ExaAmpere>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoAmpere to PetaAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZeptoAmpere</param>
    /// <returns>quantity measured in PetaAmpere</returns>
	public static Quantity<double, PetaAmpere> ToPetaAmpere<T>(this BaseQuantity<T, ZeptoAmpere> val) where T:IConvertible {
        return new Quantity<double, PetaAmpere>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoAmpere to TeraAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZeptoAmpere</param>
    /// <returns>quantity measured in TeraAmpere</returns>
	public static Quantity<double, TeraAmpere> ToTeraAmpere<T>(this BaseQuantity<T, ZeptoAmpere> val) where T:IConvertible {
        return new Quantity<double, TeraAmpere>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoAmpere to GigaAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZeptoAmpere</param>
    /// <returns>quantity measured in GigaAmpere</returns>
	public static Quantity<double, GigaAmpere> ToGigaAmpere<T>(this BaseQuantity<T, ZeptoAmpere> val) where T:IConvertible {
        return new Quantity<double, GigaAmpere>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoAmpere to MegaAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZeptoAmpere</param>
    /// <returns>quantity measured in MegaAmpere</returns>
	public static Quantity<double, MegaAmpere> ToMegaAmpere<T>(this BaseQuantity<T, ZeptoAmpere> val) where T:IConvertible {
        return new Quantity<double, MegaAmpere>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoAmpere to KiloAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZeptoAmpere</param>
    /// <returns>quantity measured in KiloAmpere</returns>
	public static Quantity<double, KiloAmpere> ToKiloAmpere<T>(this BaseQuantity<T, ZeptoAmpere> val) where T:IConvertible {
        return new Quantity<double, KiloAmpere>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoAmpere to HectoAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZeptoAmpere</param>
    /// <returns>quantity measured in HectoAmpere</returns>
	public static Quantity<double, HectoAmpere> ToHectoAmpere<T>(this BaseQuantity<T, ZeptoAmpere> val) where T:IConvertible {
        return new Quantity<double, HectoAmpere>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoAmpere to DekaAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZeptoAmpere</param>
    /// <returns>quantity measured in DekaAmpere</returns>
	public static Quantity<double, DekaAmpere> ToDekaAmpere<T>(this BaseQuantity<T, ZeptoAmpere> val) where T:IConvertible {
        return new Quantity<double, DekaAmpere>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoAmpere to DeciAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZeptoAmpere</param>
    /// <returns>quantity measured in DeciAmpere</returns>
	public static Quantity<double, DeciAmpere> ToDeciAmpere<T>(this BaseQuantity<T, ZeptoAmpere> val) where T:IConvertible {
        return new Quantity<double, DeciAmpere>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoAmpere to CentiAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZeptoAmpere</param>
    /// <returns>quantity measured in CentiAmpere</returns>
	public static Quantity<double, CentiAmpere> ToCentiAmpere<T>(this BaseQuantity<T, ZeptoAmpere> val) where T:IConvertible {
        return new Quantity<double, CentiAmpere>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoAmpere to MilliAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZeptoAmpere</param>
    /// <returns>quantity measured in MilliAmpere</returns>
	public static Quantity<double, MilliAmpere> ToMilliAmpere<T>(this BaseQuantity<T, ZeptoAmpere> val) where T:IConvertible {
        return new Quantity<double, MilliAmpere>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoAmpere to MicroAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZeptoAmpere</param>
    /// <returns>quantity measured in MicroAmpere</returns>
	public static Quantity<double, MicroAmpere> ToMicroAmpere<T>(this BaseQuantity<T, ZeptoAmpere> val) where T:IConvertible {
        return new Quantity<double, MicroAmpere>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoAmpere to NanoAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZeptoAmpere</param>
    /// <returns>quantity measured in NanoAmpere</returns>
	public static Quantity<double, NanoAmpere> ToNanoAmpere<T>(this BaseQuantity<T, ZeptoAmpere> val) where T:IConvertible {
        return new Quantity<double, NanoAmpere>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoAmpere to PicoAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZeptoAmpere</param>
    /// <returns>quantity measured in PicoAmpere</returns>
	public static Quantity<double, PicoAmpere> ToPicoAmpere<T>(this BaseQuantity<T, ZeptoAmpere> val) where T:IConvertible {
        return new Quantity<double, PicoAmpere>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoAmpere to FemtoAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZeptoAmpere</param>
    /// <returns>quantity measured in FemtoAmpere</returns>
	public static Quantity<double, FemtoAmpere> ToFemtoAmpere<T>(this BaseQuantity<T, ZeptoAmpere> val) where T:IConvertible {
        return new Quantity<double, FemtoAmpere>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoAmpere to AttoAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZeptoAmpere</param>
    /// <returns>quantity measured in AttoAmpere</returns>
	public static Quantity<double, AttoAmpere> ToAttoAmpere<T>(this BaseQuantity<T, ZeptoAmpere> val) where T:IConvertible {
        return new Quantity<double, AttoAmpere>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoAmpere to YoctoAmpere
    /// </summary>
    /// <param name="val">quantity measured in ZeptoAmpere</param>
    /// <returns>quantity measured in YoctoAmpere</returns>
	public static Quantity<double, YoctoAmpere> ToYoctoAmpere<T>(this BaseQuantity<T, ZeptoAmpere> val) where T:IConvertible {
        return new Quantity<double, YoctoAmpere>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert YoctoAmpere to YottaAmpere
    /// </summary>
    /// <param name="val">quantity measured in YoctoAmpere</param>
    /// <returns>quantity measured in YottaAmpere</returns>
	public static Quantity<double, YottaAmpere> ToYottaAmpere<T>(this BaseQuantity<T, YoctoAmpere> val) where T:IConvertible {
        return new Quantity<double, YottaAmpere>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoAmpere to ZettaAmpere
    /// </summary>
    /// <param name="val">quantity measured in YoctoAmpere</param>
    /// <returns>quantity measured in ZettaAmpere</returns>
	public static Quantity<double, ZettaAmpere> ToZettaAmpere<T>(this BaseQuantity<T, YoctoAmpere> val) where T:IConvertible {
        return new Quantity<double, ZettaAmpere>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoAmpere to ExaAmpere
    /// </summary>
    /// <param name="val">quantity measured in YoctoAmpere</param>
    /// <returns>quantity measured in ExaAmpere</returns>
	public static Quantity<double, ExaAmpere> ToExaAmpere<T>(this BaseQuantity<T, YoctoAmpere> val) where T:IConvertible {
        return new Quantity<double, ExaAmpere>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoAmpere to PetaAmpere
    /// </summary>
    /// <param name="val">quantity measured in YoctoAmpere</param>
    /// <returns>quantity measured in PetaAmpere</returns>
	public static Quantity<double, PetaAmpere> ToPetaAmpere<T>(this BaseQuantity<T, YoctoAmpere> val) where T:IConvertible {
        return new Quantity<double, PetaAmpere>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoAmpere to TeraAmpere
    /// </summary>
    /// <param name="val">quantity measured in YoctoAmpere</param>
    /// <returns>quantity measured in TeraAmpere</returns>
	public static Quantity<double, TeraAmpere> ToTeraAmpere<T>(this BaseQuantity<T, YoctoAmpere> val) where T:IConvertible {
        return new Quantity<double, TeraAmpere>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoAmpere to GigaAmpere
    /// </summary>
    /// <param name="val">quantity measured in YoctoAmpere</param>
    /// <returns>quantity measured in GigaAmpere</returns>
	public static Quantity<double, GigaAmpere> ToGigaAmpere<T>(this BaseQuantity<T, YoctoAmpere> val) where T:IConvertible {
        return new Quantity<double, GigaAmpere>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoAmpere to MegaAmpere
    /// </summary>
    /// <param name="val">quantity measured in YoctoAmpere</param>
    /// <returns>quantity measured in MegaAmpere</returns>
	public static Quantity<double, MegaAmpere> ToMegaAmpere<T>(this BaseQuantity<T, YoctoAmpere> val) where T:IConvertible {
        return new Quantity<double, MegaAmpere>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoAmpere to KiloAmpere
    /// </summary>
    /// <param name="val">quantity measured in YoctoAmpere</param>
    /// <returns>quantity measured in KiloAmpere</returns>
	public static Quantity<double, KiloAmpere> ToKiloAmpere<T>(this BaseQuantity<T, YoctoAmpere> val) where T:IConvertible {
        return new Quantity<double, KiloAmpere>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoAmpere to HectoAmpere
    /// </summary>
    /// <param name="val">quantity measured in YoctoAmpere</param>
    /// <returns>quantity measured in HectoAmpere</returns>
	public static Quantity<double, HectoAmpere> ToHectoAmpere<T>(this BaseQuantity<T, YoctoAmpere> val) where T:IConvertible {
        return new Quantity<double, HectoAmpere>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoAmpere to DekaAmpere
    /// </summary>
    /// <param name="val">quantity measured in YoctoAmpere</param>
    /// <returns>quantity measured in DekaAmpere</returns>
	public static Quantity<double, DekaAmpere> ToDekaAmpere<T>(this BaseQuantity<T, YoctoAmpere> val) where T:IConvertible {
        return new Quantity<double, DekaAmpere>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoAmpere to DeciAmpere
    /// </summary>
    /// <param name="val">quantity measured in YoctoAmpere</param>
    /// <returns>quantity measured in DeciAmpere</returns>
	public static Quantity<double, DeciAmpere> ToDeciAmpere<T>(this BaseQuantity<T, YoctoAmpere> val) where T:IConvertible {
        return new Quantity<double, DeciAmpere>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoAmpere to CentiAmpere
    /// </summary>
    /// <param name="val">quantity measured in YoctoAmpere</param>
    /// <returns>quantity measured in CentiAmpere</returns>
	public static Quantity<double, CentiAmpere> ToCentiAmpere<T>(this BaseQuantity<T, YoctoAmpere> val) where T:IConvertible {
        return new Quantity<double, CentiAmpere>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoAmpere to MilliAmpere
    /// </summary>
    /// <param name="val">quantity measured in YoctoAmpere</param>
    /// <returns>quantity measured in MilliAmpere</returns>
	public static Quantity<double, MilliAmpere> ToMilliAmpere<T>(this BaseQuantity<T, YoctoAmpere> val) where T:IConvertible {
        return new Quantity<double, MilliAmpere>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoAmpere to MicroAmpere
    /// </summary>
    /// <param name="val">quantity measured in YoctoAmpere</param>
    /// <returns>quantity measured in MicroAmpere</returns>
	public static Quantity<double, MicroAmpere> ToMicroAmpere<T>(this BaseQuantity<T, YoctoAmpere> val) where T:IConvertible {
        return new Quantity<double, MicroAmpere>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoAmpere to NanoAmpere
    /// </summary>
    /// <param name="val">quantity measured in YoctoAmpere</param>
    /// <returns>quantity measured in NanoAmpere</returns>
	public static Quantity<double, NanoAmpere> ToNanoAmpere<T>(this BaseQuantity<T, YoctoAmpere> val) where T:IConvertible {
        return new Quantity<double, NanoAmpere>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoAmpere to PicoAmpere
    /// </summary>
    /// <param name="val">quantity measured in YoctoAmpere</param>
    /// <returns>quantity measured in PicoAmpere</returns>
	public static Quantity<double, PicoAmpere> ToPicoAmpere<T>(this BaseQuantity<T, YoctoAmpere> val) where T:IConvertible {
        return new Quantity<double, PicoAmpere>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoAmpere to FemtoAmpere
    /// </summary>
    /// <param name="val">quantity measured in YoctoAmpere</param>
    /// <returns>quantity measured in FemtoAmpere</returns>
	public static Quantity<double, FemtoAmpere> ToFemtoAmpere<T>(this BaseQuantity<T, YoctoAmpere> val) where T:IConvertible {
        return new Quantity<double, FemtoAmpere>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoAmpere to AttoAmpere
    /// </summary>
    /// <param name="val">quantity measured in YoctoAmpere</param>
    /// <returns>quantity measured in AttoAmpere</returns>
	public static Quantity<double, AttoAmpere> ToAttoAmpere<T>(this BaseQuantity<T, YoctoAmpere> val) where T:IConvertible {
        return new Quantity<double, AttoAmpere>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoAmpere to ZeptoAmpere
    /// </summary>
    /// <param name="val">quantity measured in YoctoAmpere</param>
    /// <returns>quantity measured in ZeptoAmpere</returns>
	public static Quantity<double, ZeptoAmpere> ToZeptoAmpere<T>(this BaseQuantity<T, YoctoAmpere> val) where T:IConvertible {
        return new Quantity<double, ZeptoAmpere>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
}
}