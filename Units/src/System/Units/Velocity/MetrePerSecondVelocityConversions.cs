using System;
namespace System.Units.Velocity {
/// <summary>
/// Static class housing si-prefix conversions for the unit "MetrePerSecond"
/// </summary>
public static class VelocityConversions {
	/// <summary>
    /// Extension method to convert MetrePerSecond to YottaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecond</param>
    /// <returns>quantity measured in YottaMetrePerSecond</returns>
	public static Quantity<double, YottaMetrePerSecond> ToYottaMetrePerSecond<T>(this Quantity<T, MetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecond to ZettaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecond</param>
    /// <returns>quantity measured in ZettaMetrePerSecond</returns>
	public static Quantity<double, ZettaMetrePerSecond> ToZettaMetrePerSecond<T>(this Quantity<T, MetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecond to ExaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecond</param>
    /// <returns>quantity measured in ExaMetrePerSecond</returns>
	public static Quantity<double, ExaMetrePerSecond> ToExaMetrePerSecond<T>(this Quantity<T, MetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecond to PetaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecond</param>
    /// <returns>quantity measured in PetaMetrePerSecond</returns>
	public static Quantity<double, PetaMetrePerSecond> ToPetaMetrePerSecond<T>(this Quantity<T, MetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecond to TeraMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecond</param>
    /// <returns>quantity measured in TeraMetrePerSecond</returns>
	public static Quantity<double, TeraMetrePerSecond> ToTeraMetrePerSecond<T>(this Quantity<T, MetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecond to GigaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecond</param>
    /// <returns>quantity measured in GigaMetrePerSecond</returns>
	public static Quantity<double, GigaMetrePerSecond> ToGigaMetrePerSecond<T>(this Quantity<T, MetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecond to MegaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecond</param>
    /// <returns>quantity measured in MegaMetrePerSecond</returns>
	public static Quantity<double, MegaMetrePerSecond> ToMegaMetrePerSecond<T>(this Quantity<T, MetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecond to KiloMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecond</param>
    /// <returns>quantity measured in KiloMetrePerSecond</returns>
	public static Quantity<double, KiloMetrePerSecond> ToKiloMetrePerSecond<T>(this Quantity<T, MetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecond to HectoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecond</param>
    /// <returns>quantity measured in HectoMetrePerSecond</returns>
	public static Quantity<double, HectoMetrePerSecond> ToHectoMetrePerSecond<T>(this Quantity<T, MetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecond to DekaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecond</param>
    /// <returns>quantity measured in DekaMetrePerSecond</returns>
	public static Quantity<double, DekaMetrePerSecond> ToDekaMetrePerSecond<T>(this Quantity<T, MetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecond to DeciMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecond</param>
    /// <returns>quantity measured in DeciMetrePerSecond</returns>
	public static Quantity<double, DeciMetrePerSecond> ToDeciMetrePerSecond<T>(this Quantity<T, MetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecond to CentiMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecond</param>
    /// <returns>quantity measured in CentiMetrePerSecond</returns>
	public static Quantity<double, CentiMetrePerSecond> ToCentiMetrePerSecond<T>(this Quantity<T, MetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecond to MilliMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecond</param>
    /// <returns>quantity measured in MilliMetrePerSecond</returns>
	public static Quantity<double, MilliMetrePerSecond> ToMilliMetrePerSecond<T>(this Quantity<T, MetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecond to MicroMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecond</param>
    /// <returns>quantity measured in MicroMetrePerSecond</returns>
	public static Quantity<double, MicroMetrePerSecond> ToMicroMetrePerSecond<T>(this Quantity<T, MetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecond to NanoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecond</param>
    /// <returns>quantity measured in NanoMetrePerSecond</returns>
	public static Quantity<double, NanoMetrePerSecond> ToNanoMetrePerSecond<T>(this Quantity<T, MetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecond to PicoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecond</param>
    /// <returns>quantity measured in PicoMetrePerSecond</returns>
	public static Quantity<double, PicoMetrePerSecond> ToPicoMetrePerSecond<T>(this Quantity<T, MetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecond to FemtoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecond</param>
    /// <returns>quantity measured in FemtoMetrePerSecond</returns>
	public static Quantity<double, FemtoMetrePerSecond> ToFemtoMetrePerSecond<T>(this Quantity<T, MetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecond to AttoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecond</param>
    /// <returns>quantity measured in AttoMetrePerSecond</returns>
	public static Quantity<double, AttoMetrePerSecond> ToAttoMetrePerSecond<T>(this Quantity<T, MetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecond to ZeptoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecond</param>
    /// <returns>quantity measured in ZeptoMetrePerSecond</returns>
	public static Quantity<double, ZeptoMetrePerSecond> ToZeptoMetrePerSecond<T>(this Quantity<T, MetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecond to YoctoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecond</param>
    /// <returns>quantity measured in YoctoMetrePerSecond</returns>
	public static Quantity<double, YoctoMetrePerSecond> ToYoctoMetrePerSecond<T>(this Quantity<T, MetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecond to ZettaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecond</param>
    /// <returns>quantity measured in ZettaMetrePerSecond</returns>
	public static Quantity<double, ZettaMetrePerSecond> ToZettaMetrePerSecond<T>(this Quantity<T, YottaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecond to ExaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecond</param>
    /// <returns>quantity measured in ExaMetrePerSecond</returns>
	public static Quantity<double, ExaMetrePerSecond> ToExaMetrePerSecond<T>(this Quantity<T, YottaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecond to PetaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecond</param>
    /// <returns>quantity measured in PetaMetrePerSecond</returns>
	public static Quantity<double, PetaMetrePerSecond> ToPetaMetrePerSecond<T>(this Quantity<T, YottaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecond to TeraMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecond</param>
    /// <returns>quantity measured in TeraMetrePerSecond</returns>
	public static Quantity<double, TeraMetrePerSecond> ToTeraMetrePerSecond<T>(this Quantity<T, YottaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecond to GigaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecond</param>
    /// <returns>quantity measured in GigaMetrePerSecond</returns>
	public static Quantity<double, GigaMetrePerSecond> ToGigaMetrePerSecond<T>(this Quantity<T, YottaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecond to MegaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecond</param>
    /// <returns>quantity measured in MegaMetrePerSecond</returns>
	public static Quantity<double, MegaMetrePerSecond> ToMegaMetrePerSecond<T>(this Quantity<T, YottaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecond to KiloMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecond</param>
    /// <returns>quantity measured in KiloMetrePerSecond</returns>
	public static Quantity<double, KiloMetrePerSecond> ToKiloMetrePerSecond<T>(this Quantity<T, YottaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecond to HectoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecond</param>
    /// <returns>quantity measured in HectoMetrePerSecond</returns>
	public static Quantity<double, HectoMetrePerSecond> ToHectoMetrePerSecond<T>(this Quantity<T, YottaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecond to DekaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecond</param>
    /// <returns>quantity measured in DekaMetrePerSecond</returns>
	public static Quantity<double, DekaMetrePerSecond> ToDekaMetrePerSecond<T>(this Quantity<T, YottaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecond to DeciMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecond</param>
    /// <returns>quantity measured in DeciMetrePerSecond</returns>
	public static Quantity<double, DeciMetrePerSecond> ToDeciMetrePerSecond<T>(this Quantity<T, YottaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecond to CentiMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecond</param>
    /// <returns>quantity measured in CentiMetrePerSecond</returns>
	public static Quantity<double, CentiMetrePerSecond> ToCentiMetrePerSecond<T>(this Quantity<T, YottaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecond to MilliMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecond</param>
    /// <returns>quantity measured in MilliMetrePerSecond</returns>
	public static Quantity<double, MilliMetrePerSecond> ToMilliMetrePerSecond<T>(this Quantity<T, YottaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecond to MicroMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecond</param>
    /// <returns>quantity measured in MicroMetrePerSecond</returns>
	public static Quantity<double, MicroMetrePerSecond> ToMicroMetrePerSecond<T>(this Quantity<T, YottaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecond to NanoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecond</param>
    /// <returns>quantity measured in NanoMetrePerSecond</returns>
	public static Quantity<double, NanoMetrePerSecond> ToNanoMetrePerSecond<T>(this Quantity<T, YottaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecond to PicoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecond</param>
    /// <returns>quantity measured in PicoMetrePerSecond</returns>
	public static Quantity<double, PicoMetrePerSecond> ToPicoMetrePerSecond<T>(this Quantity<T, YottaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecond to FemtoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecond</param>
    /// <returns>quantity measured in FemtoMetrePerSecond</returns>
	public static Quantity<double, FemtoMetrePerSecond> ToFemtoMetrePerSecond<T>(this Quantity<T, YottaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecond to AttoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecond</param>
    /// <returns>quantity measured in AttoMetrePerSecond</returns>
	public static Quantity<double, AttoMetrePerSecond> ToAttoMetrePerSecond<T>(this Quantity<T, YottaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecond to ZeptoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecond</param>
    /// <returns>quantity measured in ZeptoMetrePerSecond</returns>
	public static Quantity<double, ZeptoMetrePerSecond> ToZeptoMetrePerSecond<T>(this Quantity<T, YottaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecond to YoctoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecond</param>
    /// <returns>quantity measured in YoctoMetrePerSecond</returns>
	public static Quantity<double, YoctoMetrePerSecond> ToYoctoMetrePerSecond<T>(this Quantity<T, YottaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecond to YottaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecond</param>
    /// <returns>quantity measured in YottaMetrePerSecond</returns>
	public static Quantity<double, YottaMetrePerSecond> ToYottaMetrePerSecond<T>(this Quantity<T, ZettaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecond to ExaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecond</param>
    /// <returns>quantity measured in ExaMetrePerSecond</returns>
	public static Quantity<double, ExaMetrePerSecond> ToExaMetrePerSecond<T>(this Quantity<T, ZettaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecond to PetaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecond</param>
    /// <returns>quantity measured in PetaMetrePerSecond</returns>
	public static Quantity<double, PetaMetrePerSecond> ToPetaMetrePerSecond<T>(this Quantity<T, ZettaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecond to TeraMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecond</param>
    /// <returns>quantity measured in TeraMetrePerSecond</returns>
	public static Quantity<double, TeraMetrePerSecond> ToTeraMetrePerSecond<T>(this Quantity<T, ZettaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecond to GigaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecond</param>
    /// <returns>quantity measured in GigaMetrePerSecond</returns>
	public static Quantity<double, GigaMetrePerSecond> ToGigaMetrePerSecond<T>(this Quantity<T, ZettaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecond to MegaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecond</param>
    /// <returns>quantity measured in MegaMetrePerSecond</returns>
	public static Quantity<double, MegaMetrePerSecond> ToMegaMetrePerSecond<T>(this Quantity<T, ZettaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecond to KiloMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecond</param>
    /// <returns>quantity measured in KiloMetrePerSecond</returns>
	public static Quantity<double, KiloMetrePerSecond> ToKiloMetrePerSecond<T>(this Quantity<T, ZettaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecond to HectoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecond</param>
    /// <returns>quantity measured in HectoMetrePerSecond</returns>
	public static Quantity<double, HectoMetrePerSecond> ToHectoMetrePerSecond<T>(this Quantity<T, ZettaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecond to DekaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecond</param>
    /// <returns>quantity measured in DekaMetrePerSecond</returns>
	public static Quantity<double, DekaMetrePerSecond> ToDekaMetrePerSecond<T>(this Quantity<T, ZettaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecond to DeciMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecond</param>
    /// <returns>quantity measured in DeciMetrePerSecond</returns>
	public static Quantity<double, DeciMetrePerSecond> ToDeciMetrePerSecond<T>(this Quantity<T, ZettaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecond to CentiMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecond</param>
    /// <returns>quantity measured in CentiMetrePerSecond</returns>
	public static Quantity<double, CentiMetrePerSecond> ToCentiMetrePerSecond<T>(this Quantity<T, ZettaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecond to MilliMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecond</param>
    /// <returns>quantity measured in MilliMetrePerSecond</returns>
	public static Quantity<double, MilliMetrePerSecond> ToMilliMetrePerSecond<T>(this Quantity<T, ZettaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecond to MicroMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecond</param>
    /// <returns>quantity measured in MicroMetrePerSecond</returns>
	public static Quantity<double, MicroMetrePerSecond> ToMicroMetrePerSecond<T>(this Quantity<T, ZettaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecond to NanoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecond</param>
    /// <returns>quantity measured in NanoMetrePerSecond</returns>
	public static Quantity<double, NanoMetrePerSecond> ToNanoMetrePerSecond<T>(this Quantity<T, ZettaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecond to PicoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecond</param>
    /// <returns>quantity measured in PicoMetrePerSecond</returns>
	public static Quantity<double, PicoMetrePerSecond> ToPicoMetrePerSecond<T>(this Quantity<T, ZettaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecond to FemtoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecond</param>
    /// <returns>quantity measured in FemtoMetrePerSecond</returns>
	public static Quantity<double, FemtoMetrePerSecond> ToFemtoMetrePerSecond<T>(this Quantity<T, ZettaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecond to AttoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecond</param>
    /// <returns>quantity measured in AttoMetrePerSecond</returns>
	public static Quantity<double, AttoMetrePerSecond> ToAttoMetrePerSecond<T>(this Quantity<T, ZettaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecond to ZeptoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecond</param>
    /// <returns>quantity measured in ZeptoMetrePerSecond</returns>
	public static Quantity<double, ZeptoMetrePerSecond> ToZeptoMetrePerSecond<T>(this Quantity<T, ZettaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecond to YoctoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecond</param>
    /// <returns>quantity measured in YoctoMetrePerSecond</returns>
	public static Quantity<double, YoctoMetrePerSecond> ToYoctoMetrePerSecond<T>(this Quantity<T, ZettaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecond to YottaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecond</param>
    /// <returns>quantity measured in YottaMetrePerSecond</returns>
	public static Quantity<double, YottaMetrePerSecond> ToYottaMetrePerSecond<T>(this Quantity<T, ExaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecond to ZettaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecond</param>
    /// <returns>quantity measured in ZettaMetrePerSecond</returns>
	public static Quantity<double, ZettaMetrePerSecond> ToZettaMetrePerSecond<T>(this Quantity<T, ExaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecond to PetaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecond</param>
    /// <returns>quantity measured in PetaMetrePerSecond</returns>
	public static Quantity<double, PetaMetrePerSecond> ToPetaMetrePerSecond<T>(this Quantity<T, ExaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecond to TeraMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecond</param>
    /// <returns>quantity measured in TeraMetrePerSecond</returns>
	public static Quantity<double, TeraMetrePerSecond> ToTeraMetrePerSecond<T>(this Quantity<T, ExaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecond to GigaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecond</param>
    /// <returns>quantity measured in GigaMetrePerSecond</returns>
	public static Quantity<double, GigaMetrePerSecond> ToGigaMetrePerSecond<T>(this Quantity<T, ExaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecond to MegaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecond</param>
    /// <returns>quantity measured in MegaMetrePerSecond</returns>
	public static Quantity<double, MegaMetrePerSecond> ToMegaMetrePerSecond<T>(this Quantity<T, ExaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecond to KiloMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecond</param>
    /// <returns>quantity measured in KiloMetrePerSecond</returns>
	public static Quantity<double, KiloMetrePerSecond> ToKiloMetrePerSecond<T>(this Quantity<T, ExaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecond to HectoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecond</param>
    /// <returns>quantity measured in HectoMetrePerSecond</returns>
	public static Quantity<double, HectoMetrePerSecond> ToHectoMetrePerSecond<T>(this Quantity<T, ExaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecond to DekaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecond</param>
    /// <returns>quantity measured in DekaMetrePerSecond</returns>
	public static Quantity<double, DekaMetrePerSecond> ToDekaMetrePerSecond<T>(this Quantity<T, ExaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecond to DeciMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecond</param>
    /// <returns>quantity measured in DeciMetrePerSecond</returns>
	public static Quantity<double, DeciMetrePerSecond> ToDeciMetrePerSecond<T>(this Quantity<T, ExaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecond to CentiMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecond</param>
    /// <returns>quantity measured in CentiMetrePerSecond</returns>
	public static Quantity<double, CentiMetrePerSecond> ToCentiMetrePerSecond<T>(this Quantity<T, ExaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecond to MilliMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecond</param>
    /// <returns>quantity measured in MilliMetrePerSecond</returns>
	public static Quantity<double, MilliMetrePerSecond> ToMilliMetrePerSecond<T>(this Quantity<T, ExaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecond to MicroMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecond</param>
    /// <returns>quantity measured in MicroMetrePerSecond</returns>
	public static Quantity<double, MicroMetrePerSecond> ToMicroMetrePerSecond<T>(this Quantity<T, ExaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecond to NanoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecond</param>
    /// <returns>quantity measured in NanoMetrePerSecond</returns>
	public static Quantity<double, NanoMetrePerSecond> ToNanoMetrePerSecond<T>(this Quantity<T, ExaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecond to PicoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecond</param>
    /// <returns>quantity measured in PicoMetrePerSecond</returns>
	public static Quantity<double, PicoMetrePerSecond> ToPicoMetrePerSecond<T>(this Quantity<T, ExaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecond to FemtoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecond</param>
    /// <returns>quantity measured in FemtoMetrePerSecond</returns>
	public static Quantity<double, FemtoMetrePerSecond> ToFemtoMetrePerSecond<T>(this Quantity<T, ExaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecond to AttoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecond</param>
    /// <returns>quantity measured in AttoMetrePerSecond</returns>
	public static Quantity<double, AttoMetrePerSecond> ToAttoMetrePerSecond<T>(this Quantity<T, ExaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecond to ZeptoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecond</param>
    /// <returns>quantity measured in ZeptoMetrePerSecond</returns>
	public static Quantity<double, ZeptoMetrePerSecond> ToZeptoMetrePerSecond<T>(this Quantity<T, ExaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecond to YoctoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecond</param>
    /// <returns>quantity measured in YoctoMetrePerSecond</returns>
	public static Quantity<double, YoctoMetrePerSecond> ToYoctoMetrePerSecond<T>(this Quantity<T, ExaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecond to YottaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecond</param>
    /// <returns>quantity measured in YottaMetrePerSecond</returns>
	public static Quantity<double, YottaMetrePerSecond> ToYottaMetrePerSecond<T>(this Quantity<T, PetaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecond to ZettaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecond</param>
    /// <returns>quantity measured in ZettaMetrePerSecond</returns>
	public static Quantity<double, ZettaMetrePerSecond> ToZettaMetrePerSecond<T>(this Quantity<T, PetaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecond to ExaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecond</param>
    /// <returns>quantity measured in ExaMetrePerSecond</returns>
	public static Quantity<double, ExaMetrePerSecond> ToExaMetrePerSecond<T>(this Quantity<T, PetaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecond to TeraMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecond</param>
    /// <returns>quantity measured in TeraMetrePerSecond</returns>
	public static Quantity<double, TeraMetrePerSecond> ToTeraMetrePerSecond<T>(this Quantity<T, PetaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecond to GigaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecond</param>
    /// <returns>quantity measured in GigaMetrePerSecond</returns>
	public static Quantity<double, GigaMetrePerSecond> ToGigaMetrePerSecond<T>(this Quantity<T, PetaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecond to MegaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecond</param>
    /// <returns>quantity measured in MegaMetrePerSecond</returns>
	public static Quantity<double, MegaMetrePerSecond> ToMegaMetrePerSecond<T>(this Quantity<T, PetaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecond to KiloMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecond</param>
    /// <returns>quantity measured in KiloMetrePerSecond</returns>
	public static Quantity<double, KiloMetrePerSecond> ToKiloMetrePerSecond<T>(this Quantity<T, PetaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecond to HectoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecond</param>
    /// <returns>quantity measured in HectoMetrePerSecond</returns>
	public static Quantity<double, HectoMetrePerSecond> ToHectoMetrePerSecond<T>(this Quantity<T, PetaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecond to DekaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecond</param>
    /// <returns>quantity measured in DekaMetrePerSecond</returns>
	public static Quantity<double, DekaMetrePerSecond> ToDekaMetrePerSecond<T>(this Quantity<T, PetaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecond to DeciMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecond</param>
    /// <returns>quantity measured in DeciMetrePerSecond</returns>
	public static Quantity<double, DeciMetrePerSecond> ToDeciMetrePerSecond<T>(this Quantity<T, PetaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecond to CentiMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecond</param>
    /// <returns>quantity measured in CentiMetrePerSecond</returns>
	public static Quantity<double, CentiMetrePerSecond> ToCentiMetrePerSecond<T>(this Quantity<T, PetaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecond to MilliMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecond</param>
    /// <returns>quantity measured in MilliMetrePerSecond</returns>
	public static Quantity<double, MilliMetrePerSecond> ToMilliMetrePerSecond<T>(this Quantity<T, PetaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecond to MicroMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecond</param>
    /// <returns>quantity measured in MicroMetrePerSecond</returns>
	public static Quantity<double, MicroMetrePerSecond> ToMicroMetrePerSecond<T>(this Quantity<T, PetaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecond to NanoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecond</param>
    /// <returns>quantity measured in NanoMetrePerSecond</returns>
	public static Quantity<double, NanoMetrePerSecond> ToNanoMetrePerSecond<T>(this Quantity<T, PetaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecond to PicoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecond</param>
    /// <returns>quantity measured in PicoMetrePerSecond</returns>
	public static Quantity<double, PicoMetrePerSecond> ToPicoMetrePerSecond<T>(this Quantity<T, PetaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecond to FemtoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecond</param>
    /// <returns>quantity measured in FemtoMetrePerSecond</returns>
	public static Quantity<double, FemtoMetrePerSecond> ToFemtoMetrePerSecond<T>(this Quantity<T, PetaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecond to AttoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecond</param>
    /// <returns>quantity measured in AttoMetrePerSecond</returns>
	public static Quantity<double, AttoMetrePerSecond> ToAttoMetrePerSecond<T>(this Quantity<T, PetaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecond to ZeptoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecond</param>
    /// <returns>quantity measured in ZeptoMetrePerSecond</returns>
	public static Quantity<double, ZeptoMetrePerSecond> ToZeptoMetrePerSecond<T>(this Quantity<T, PetaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecond to YoctoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecond</param>
    /// <returns>quantity measured in YoctoMetrePerSecond</returns>
	public static Quantity<double, YoctoMetrePerSecond> ToYoctoMetrePerSecond<T>(this Quantity<T, PetaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecond to YottaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecond</param>
    /// <returns>quantity measured in YottaMetrePerSecond</returns>
	public static Quantity<double, YottaMetrePerSecond> ToYottaMetrePerSecond<T>(this Quantity<T, TeraMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecond to ZettaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecond</param>
    /// <returns>quantity measured in ZettaMetrePerSecond</returns>
	public static Quantity<double, ZettaMetrePerSecond> ToZettaMetrePerSecond<T>(this Quantity<T, TeraMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecond to ExaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecond</param>
    /// <returns>quantity measured in ExaMetrePerSecond</returns>
	public static Quantity<double, ExaMetrePerSecond> ToExaMetrePerSecond<T>(this Quantity<T, TeraMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecond to PetaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecond</param>
    /// <returns>quantity measured in PetaMetrePerSecond</returns>
	public static Quantity<double, PetaMetrePerSecond> ToPetaMetrePerSecond<T>(this Quantity<T, TeraMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecond to GigaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecond</param>
    /// <returns>quantity measured in GigaMetrePerSecond</returns>
	public static Quantity<double, GigaMetrePerSecond> ToGigaMetrePerSecond<T>(this Quantity<T, TeraMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecond to MegaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecond</param>
    /// <returns>quantity measured in MegaMetrePerSecond</returns>
	public static Quantity<double, MegaMetrePerSecond> ToMegaMetrePerSecond<T>(this Quantity<T, TeraMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecond to KiloMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecond</param>
    /// <returns>quantity measured in KiloMetrePerSecond</returns>
	public static Quantity<double, KiloMetrePerSecond> ToKiloMetrePerSecond<T>(this Quantity<T, TeraMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecond to HectoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecond</param>
    /// <returns>quantity measured in HectoMetrePerSecond</returns>
	public static Quantity<double, HectoMetrePerSecond> ToHectoMetrePerSecond<T>(this Quantity<T, TeraMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecond to DekaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecond</param>
    /// <returns>quantity measured in DekaMetrePerSecond</returns>
	public static Quantity<double, DekaMetrePerSecond> ToDekaMetrePerSecond<T>(this Quantity<T, TeraMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecond to DeciMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecond</param>
    /// <returns>quantity measured in DeciMetrePerSecond</returns>
	public static Quantity<double, DeciMetrePerSecond> ToDeciMetrePerSecond<T>(this Quantity<T, TeraMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecond to CentiMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecond</param>
    /// <returns>quantity measured in CentiMetrePerSecond</returns>
	public static Quantity<double, CentiMetrePerSecond> ToCentiMetrePerSecond<T>(this Quantity<T, TeraMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecond to MilliMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecond</param>
    /// <returns>quantity measured in MilliMetrePerSecond</returns>
	public static Quantity<double, MilliMetrePerSecond> ToMilliMetrePerSecond<T>(this Quantity<T, TeraMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecond to MicroMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecond</param>
    /// <returns>quantity measured in MicroMetrePerSecond</returns>
	public static Quantity<double, MicroMetrePerSecond> ToMicroMetrePerSecond<T>(this Quantity<T, TeraMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecond to NanoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecond</param>
    /// <returns>quantity measured in NanoMetrePerSecond</returns>
	public static Quantity<double, NanoMetrePerSecond> ToNanoMetrePerSecond<T>(this Quantity<T, TeraMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecond to PicoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecond</param>
    /// <returns>quantity measured in PicoMetrePerSecond</returns>
	public static Quantity<double, PicoMetrePerSecond> ToPicoMetrePerSecond<T>(this Quantity<T, TeraMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecond to FemtoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecond</param>
    /// <returns>quantity measured in FemtoMetrePerSecond</returns>
	public static Quantity<double, FemtoMetrePerSecond> ToFemtoMetrePerSecond<T>(this Quantity<T, TeraMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecond to AttoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecond</param>
    /// <returns>quantity measured in AttoMetrePerSecond</returns>
	public static Quantity<double, AttoMetrePerSecond> ToAttoMetrePerSecond<T>(this Quantity<T, TeraMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecond to ZeptoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecond</param>
    /// <returns>quantity measured in ZeptoMetrePerSecond</returns>
	public static Quantity<double, ZeptoMetrePerSecond> ToZeptoMetrePerSecond<T>(this Quantity<T, TeraMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecond to YoctoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecond</param>
    /// <returns>quantity measured in YoctoMetrePerSecond</returns>
	public static Quantity<double, YoctoMetrePerSecond> ToYoctoMetrePerSecond<T>(this Quantity<T, TeraMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecond to YottaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecond</param>
    /// <returns>quantity measured in YottaMetrePerSecond</returns>
	public static Quantity<double, YottaMetrePerSecond> ToYottaMetrePerSecond<T>(this Quantity<T, GigaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecond to ZettaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecond</param>
    /// <returns>quantity measured in ZettaMetrePerSecond</returns>
	public static Quantity<double, ZettaMetrePerSecond> ToZettaMetrePerSecond<T>(this Quantity<T, GigaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecond to ExaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecond</param>
    /// <returns>quantity measured in ExaMetrePerSecond</returns>
	public static Quantity<double, ExaMetrePerSecond> ToExaMetrePerSecond<T>(this Quantity<T, GigaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecond to PetaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecond</param>
    /// <returns>quantity measured in PetaMetrePerSecond</returns>
	public static Quantity<double, PetaMetrePerSecond> ToPetaMetrePerSecond<T>(this Quantity<T, GigaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecond to TeraMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecond</param>
    /// <returns>quantity measured in TeraMetrePerSecond</returns>
	public static Quantity<double, TeraMetrePerSecond> ToTeraMetrePerSecond<T>(this Quantity<T, GigaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecond to MegaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecond</param>
    /// <returns>quantity measured in MegaMetrePerSecond</returns>
	public static Quantity<double, MegaMetrePerSecond> ToMegaMetrePerSecond<T>(this Quantity<T, GigaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecond to KiloMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecond</param>
    /// <returns>quantity measured in KiloMetrePerSecond</returns>
	public static Quantity<double, KiloMetrePerSecond> ToKiloMetrePerSecond<T>(this Quantity<T, GigaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecond to HectoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecond</param>
    /// <returns>quantity measured in HectoMetrePerSecond</returns>
	public static Quantity<double, HectoMetrePerSecond> ToHectoMetrePerSecond<T>(this Quantity<T, GigaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecond to DekaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecond</param>
    /// <returns>quantity measured in DekaMetrePerSecond</returns>
	public static Quantity<double, DekaMetrePerSecond> ToDekaMetrePerSecond<T>(this Quantity<T, GigaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecond to DeciMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecond</param>
    /// <returns>quantity measured in DeciMetrePerSecond</returns>
	public static Quantity<double, DeciMetrePerSecond> ToDeciMetrePerSecond<T>(this Quantity<T, GigaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecond to CentiMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecond</param>
    /// <returns>quantity measured in CentiMetrePerSecond</returns>
	public static Quantity<double, CentiMetrePerSecond> ToCentiMetrePerSecond<T>(this Quantity<T, GigaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecond to MilliMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecond</param>
    /// <returns>quantity measured in MilliMetrePerSecond</returns>
	public static Quantity<double, MilliMetrePerSecond> ToMilliMetrePerSecond<T>(this Quantity<T, GigaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecond to MicroMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecond</param>
    /// <returns>quantity measured in MicroMetrePerSecond</returns>
	public static Quantity<double, MicroMetrePerSecond> ToMicroMetrePerSecond<T>(this Quantity<T, GigaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecond to NanoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecond</param>
    /// <returns>quantity measured in NanoMetrePerSecond</returns>
	public static Quantity<double, NanoMetrePerSecond> ToNanoMetrePerSecond<T>(this Quantity<T, GigaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecond to PicoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecond</param>
    /// <returns>quantity measured in PicoMetrePerSecond</returns>
	public static Quantity<double, PicoMetrePerSecond> ToPicoMetrePerSecond<T>(this Quantity<T, GigaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecond to FemtoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecond</param>
    /// <returns>quantity measured in FemtoMetrePerSecond</returns>
	public static Quantity<double, FemtoMetrePerSecond> ToFemtoMetrePerSecond<T>(this Quantity<T, GigaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecond to AttoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecond</param>
    /// <returns>quantity measured in AttoMetrePerSecond</returns>
	public static Quantity<double, AttoMetrePerSecond> ToAttoMetrePerSecond<T>(this Quantity<T, GigaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecond to ZeptoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecond</param>
    /// <returns>quantity measured in ZeptoMetrePerSecond</returns>
	public static Quantity<double, ZeptoMetrePerSecond> ToZeptoMetrePerSecond<T>(this Quantity<T, GigaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecond to YoctoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecond</param>
    /// <returns>quantity measured in YoctoMetrePerSecond</returns>
	public static Quantity<double, YoctoMetrePerSecond> ToYoctoMetrePerSecond<T>(this Quantity<T, GigaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecond to YottaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecond</param>
    /// <returns>quantity measured in YottaMetrePerSecond</returns>
	public static Quantity<double, YottaMetrePerSecond> ToYottaMetrePerSecond<T>(this Quantity<T, MegaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecond to ZettaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecond</param>
    /// <returns>quantity measured in ZettaMetrePerSecond</returns>
	public static Quantity<double, ZettaMetrePerSecond> ToZettaMetrePerSecond<T>(this Quantity<T, MegaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecond to ExaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecond</param>
    /// <returns>quantity measured in ExaMetrePerSecond</returns>
	public static Quantity<double, ExaMetrePerSecond> ToExaMetrePerSecond<T>(this Quantity<T, MegaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecond to PetaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecond</param>
    /// <returns>quantity measured in PetaMetrePerSecond</returns>
	public static Quantity<double, PetaMetrePerSecond> ToPetaMetrePerSecond<T>(this Quantity<T, MegaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecond to TeraMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecond</param>
    /// <returns>quantity measured in TeraMetrePerSecond</returns>
	public static Quantity<double, TeraMetrePerSecond> ToTeraMetrePerSecond<T>(this Quantity<T, MegaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecond to GigaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecond</param>
    /// <returns>quantity measured in GigaMetrePerSecond</returns>
	public static Quantity<double, GigaMetrePerSecond> ToGigaMetrePerSecond<T>(this Quantity<T, MegaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecond to KiloMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecond</param>
    /// <returns>quantity measured in KiloMetrePerSecond</returns>
	public static Quantity<double, KiloMetrePerSecond> ToKiloMetrePerSecond<T>(this Quantity<T, MegaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecond to HectoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecond</param>
    /// <returns>quantity measured in HectoMetrePerSecond</returns>
	public static Quantity<double, HectoMetrePerSecond> ToHectoMetrePerSecond<T>(this Quantity<T, MegaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecond to DekaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecond</param>
    /// <returns>quantity measured in DekaMetrePerSecond</returns>
	public static Quantity<double, DekaMetrePerSecond> ToDekaMetrePerSecond<T>(this Quantity<T, MegaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecond to DeciMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecond</param>
    /// <returns>quantity measured in DeciMetrePerSecond</returns>
	public static Quantity<double, DeciMetrePerSecond> ToDeciMetrePerSecond<T>(this Quantity<T, MegaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecond to CentiMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecond</param>
    /// <returns>quantity measured in CentiMetrePerSecond</returns>
	public static Quantity<double, CentiMetrePerSecond> ToCentiMetrePerSecond<T>(this Quantity<T, MegaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecond to MilliMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecond</param>
    /// <returns>quantity measured in MilliMetrePerSecond</returns>
	public static Quantity<double, MilliMetrePerSecond> ToMilliMetrePerSecond<T>(this Quantity<T, MegaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecond to MicroMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecond</param>
    /// <returns>quantity measured in MicroMetrePerSecond</returns>
	public static Quantity<double, MicroMetrePerSecond> ToMicroMetrePerSecond<T>(this Quantity<T, MegaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecond to NanoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecond</param>
    /// <returns>quantity measured in NanoMetrePerSecond</returns>
	public static Quantity<double, NanoMetrePerSecond> ToNanoMetrePerSecond<T>(this Quantity<T, MegaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecond to PicoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecond</param>
    /// <returns>quantity measured in PicoMetrePerSecond</returns>
	public static Quantity<double, PicoMetrePerSecond> ToPicoMetrePerSecond<T>(this Quantity<T, MegaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecond to FemtoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecond</param>
    /// <returns>quantity measured in FemtoMetrePerSecond</returns>
	public static Quantity<double, FemtoMetrePerSecond> ToFemtoMetrePerSecond<T>(this Quantity<T, MegaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecond to AttoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecond</param>
    /// <returns>quantity measured in AttoMetrePerSecond</returns>
	public static Quantity<double, AttoMetrePerSecond> ToAttoMetrePerSecond<T>(this Quantity<T, MegaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecond to ZeptoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecond</param>
    /// <returns>quantity measured in ZeptoMetrePerSecond</returns>
	public static Quantity<double, ZeptoMetrePerSecond> ToZeptoMetrePerSecond<T>(this Quantity<T, MegaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecond to YoctoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecond</param>
    /// <returns>quantity measured in YoctoMetrePerSecond</returns>
	public static Quantity<double, YoctoMetrePerSecond> ToYoctoMetrePerSecond<T>(this Quantity<T, MegaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecond to YottaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecond</param>
    /// <returns>quantity measured in YottaMetrePerSecond</returns>
	public static Quantity<double, YottaMetrePerSecond> ToYottaMetrePerSecond<T>(this Quantity<T, KiloMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecond to ZettaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecond</param>
    /// <returns>quantity measured in ZettaMetrePerSecond</returns>
	public static Quantity<double, ZettaMetrePerSecond> ToZettaMetrePerSecond<T>(this Quantity<T, KiloMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecond to ExaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecond</param>
    /// <returns>quantity measured in ExaMetrePerSecond</returns>
	public static Quantity<double, ExaMetrePerSecond> ToExaMetrePerSecond<T>(this Quantity<T, KiloMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecond to PetaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecond</param>
    /// <returns>quantity measured in PetaMetrePerSecond</returns>
	public static Quantity<double, PetaMetrePerSecond> ToPetaMetrePerSecond<T>(this Quantity<T, KiloMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecond to TeraMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecond</param>
    /// <returns>quantity measured in TeraMetrePerSecond</returns>
	public static Quantity<double, TeraMetrePerSecond> ToTeraMetrePerSecond<T>(this Quantity<T, KiloMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecond to GigaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecond</param>
    /// <returns>quantity measured in GigaMetrePerSecond</returns>
	public static Quantity<double, GigaMetrePerSecond> ToGigaMetrePerSecond<T>(this Quantity<T, KiloMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecond to MegaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecond</param>
    /// <returns>quantity measured in MegaMetrePerSecond</returns>
	public static Quantity<double, MegaMetrePerSecond> ToMegaMetrePerSecond<T>(this Quantity<T, KiloMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecond to HectoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecond</param>
    /// <returns>quantity measured in HectoMetrePerSecond</returns>
	public static Quantity<double, HectoMetrePerSecond> ToHectoMetrePerSecond<T>(this Quantity<T, KiloMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecond to DekaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecond</param>
    /// <returns>quantity measured in DekaMetrePerSecond</returns>
	public static Quantity<double, DekaMetrePerSecond> ToDekaMetrePerSecond<T>(this Quantity<T, KiloMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecond to DeciMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecond</param>
    /// <returns>quantity measured in DeciMetrePerSecond</returns>
	public static Quantity<double, DeciMetrePerSecond> ToDeciMetrePerSecond<T>(this Quantity<T, KiloMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecond to CentiMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecond</param>
    /// <returns>quantity measured in CentiMetrePerSecond</returns>
	public static Quantity<double, CentiMetrePerSecond> ToCentiMetrePerSecond<T>(this Quantity<T, KiloMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecond to MilliMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecond</param>
    /// <returns>quantity measured in MilliMetrePerSecond</returns>
	public static Quantity<double, MilliMetrePerSecond> ToMilliMetrePerSecond<T>(this Quantity<T, KiloMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecond to MicroMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecond</param>
    /// <returns>quantity measured in MicroMetrePerSecond</returns>
	public static Quantity<double, MicroMetrePerSecond> ToMicroMetrePerSecond<T>(this Quantity<T, KiloMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecond to NanoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecond</param>
    /// <returns>quantity measured in NanoMetrePerSecond</returns>
	public static Quantity<double, NanoMetrePerSecond> ToNanoMetrePerSecond<T>(this Quantity<T, KiloMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecond to PicoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecond</param>
    /// <returns>quantity measured in PicoMetrePerSecond</returns>
	public static Quantity<double, PicoMetrePerSecond> ToPicoMetrePerSecond<T>(this Quantity<T, KiloMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecond to FemtoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecond</param>
    /// <returns>quantity measured in FemtoMetrePerSecond</returns>
	public static Quantity<double, FemtoMetrePerSecond> ToFemtoMetrePerSecond<T>(this Quantity<T, KiloMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecond to AttoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecond</param>
    /// <returns>quantity measured in AttoMetrePerSecond</returns>
	public static Quantity<double, AttoMetrePerSecond> ToAttoMetrePerSecond<T>(this Quantity<T, KiloMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecond to ZeptoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecond</param>
    /// <returns>quantity measured in ZeptoMetrePerSecond</returns>
	public static Quantity<double, ZeptoMetrePerSecond> ToZeptoMetrePerSecond<T>(this Quantity<T, KiloMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecond to YoctoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecond</param>
    /// <returns>quantity measured in YoctoMetrePerSecond</returns>
	public static Quantity<double, YoctoMetrePerSecond> ToYoctoMetrePerSecond<T>(this Quantity<T, KiloMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecond to YottaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecond</param>
    /// <returns>quantity measured in YottaMetrePerSecond</returns>
	public static Quantity<double, YottaMetrePerSecond> ToYottaMetrePerSecond<T>(this Quantity<T, HectoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecond to ZettaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecond</param>
    /// <returns>quantity measured in ZettaMetrePerSecond</returns>
	public static Quantity<double, ZettaMetrePerSecond> ToZettaMetrePerSecond<T>(this Quantity<T, HectoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecond to ExaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecond</param>
    /// <returns>quantity measured in ExaMetrePerSecond</returns>
	public static Quantity<double, ExaMetrePerSecond> ToExaMetrePerSecond<T>(this Quantity<T, HectoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecond to PetaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecond</param>
    /// <returns>quantity measured in PetaMetrePerSecond</returns>
	public static Quantity<double, PetaMetrePerSecond> ToPetaMetrePerSecond<T>(this Quantity<T, HectoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecond to TeraMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecond</param>
    /// <returns>quantity measured in TeraMetrePerSecond</returns>
	public static Quantity<double, TeraMetrePerSecond> ToTeraMetrePerSecond<T>(this Quantity<T, HectoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecond to GigaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecond</param>
    /// <returns>quantity measured in GigaMetrePerSecond</returns>
	public static Quantity<double, GigaMetrePerSecond> ToGigaMetrePerSecond<T>(this Quantity<T, HectoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecond to MegaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecond</param>
    /// <returns>quantity measured in MegaMetrePerSecond</returns>
	public static Quantity<double, MegaMetrePerSecond> ToMegaMetrePerSecond<T>(this Quantity<T, HectoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecond to KiloMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecond</param>
    /// <returns>quantity measured in KiloMetrePerSecond</returns>
	public static Quantity<double, KiloMetrePerSecond> ToKiloMetrePerSecond<T>(this Quantity<T, HectoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecond to DekaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecond</param>
    /// <returns>quantity measured in DekaMetrePerSecond</returns>
	public static Quantity<double, DekaMetrePerSecond> ToDekaMetrePerSecond<T>(this Quantity<T, HectoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecond to DeciMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecond</param>
    /// <returns>quantity measured in DeciMetrePerSecond</returns>
	public static Quantity<double, DeciMetrePerSecond> ToDeciMetrePerSecond<T>(this Quantity<T, HectoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecond to CentiMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecond</param>
    /// <returns>quantity measured in CentiMetrePerSecond</returns>
	public static Quantity<double, CentiMetrePerSecond> ToCentiMetrePerSecond<T>(this Quantity<T, HectoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecond to MilliMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecond</param>
    /// <returns>quantity measured in MilliMetrePerSecond</returns>
	public static Quantity<double, MilliMetrePerSecond> ToMilliMetrePerSecond<T>(this Quantity<T, HectoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecond to MicroMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecond</param>
    /// <returns>quantity measured in MicroMetrePerSecond</returns>
	public static Quantity<double, MicroMetrePerSecond> ToMicroMetrePerSecond<T>(this Quantity<T, HectoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecond to NanoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecond</param>
    /// <returns>quantity measured in NanoMetrePerSecond</returns>
	public static Quantity<double, NanoMetrePerSecond> ToNanoMetrePerSecond<T>(this Quantity<T, HectoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecond to PicoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecond</param>
    /// <returns>quantity measured in PicoMetrePerSecond</returns>
	public static Quantity<double, PicoMetrePerSecond> ToPicoMetrePerSecond<T>(this Quantity<T, HectoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecond to FemtoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecond</param>
    /// <returns>quantity measured in FemtoMetrePerSecond</returns>
	public static Quantity<double, FemtoMetrePerSecond> ToFemtoMetrePerSecond<T>(this Quantity<T, HectoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecond to AttoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecond</param>
    /// <returns>quantity measured in AttoMetrePerSecond</returns>
	public static Quantity<double, AttoMetrePerSecond> ToAttoMetrePerSecond<T>(this Quantity<T, HectoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecond to ZeptoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecond</param>
    /// <returns>quantity measured in ZeptoMetrePerSecond</returns>
	public static Quantity<double, ZeptoMetrePerSecond> ToZeptoMetrePerSecond<T>(this Quantity<T, HectoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecond to YoctoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecond</param>
    /// <returns>quantity measured in YoctoMetrePerSecond</returns>
	public static Quantity<double, YoctoMetrePerSecond> ToYoctoMetrePerSecond<T>(this Quantity<T, HectoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecond to YottaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecond</param>
    /// <returns>quantity measured in YottaMetrePerSecond</returns>
	public static Quantity<double, YottaMetrePerSecond> ToYottaMetrePerSecond<T>(this Quantity<T, DekaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecond to ZettaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecond</param>
    /// <returns>quantity measured in ZettaMetrePerSecond</returns>
	public static Quantity<double, ZettaMetrePerSecond> ToZettaMetrePerSecond<T>(this Quantity<T, DekaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecond to ExaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecond</param>
    /// <returns>quantity measured in ExaMetrePerSecond</returns>
	public static Quantity<double, ExaMetrePerSecond> ToExaMetrePerSecond<T>(this Quantity<T, DekaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecond to PetaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecond</param>
    /// <returns>quantity measured in PetaMetrePerSecond</returns>
	public static Quantity<double, PetaMetrePerSecond> ToPetaMetrePerSecond<T>(this Quantity<T, DekaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecond to TeraMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecond</param>
    /// <returns>quantity measured in TeraMetrePerSecond</returns>
	public static Quantity<double, TeraMetrePerSecond> ToTeraMetrePerSecond<T>(this Quantity<T, DekaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecond to GigaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecond</param>
    /// <returns>quantity measured in GigaMetrePerSecond</returns>
	public static Quantity<double, GigaMetrePerSecond> ToGigaMetrePerSecond<T>(this Quantity<T, DekaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecond to MegaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecond</param>
    /// <returns>quantity measured in MegaMetrePerSecond</returns>
	public static Quantity<double, MegaMetrePerSecond> ToMegaMetrePerSecond<T>(this Quantity<T, DekaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecond to KiloMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecond</param>
    /// <returns>quantity measured in KiloMetrePerSecond</returns>
	public static Quantity<double, KiloMetrePerSecond> ToKiloMetrePerSecond<T>(this Quantity<T, DekaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecond to HectoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecond</param>
    /// <returns>quantity measured in HectoMetrePerSecond</returns>
	public static Quantity<double, HectoMetrePerSecond> ToHectoMetrePerSecond<T>(this Quantity<T, DekaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecond to DeciMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecond</param>
    /// <returns>quantity measured in DeciMetrePerSecond</returns>
	public static Quantity<double, DeciMetrePerSecond> ToDeciMetrePerSecond<T>(this Quantity<T, DekaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecond to CentiMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecond</param>
    /// <returns>quantity measured in CentiMetrePerSecond</returns>
	public static Quantity<double, CentiMetrePerSecond> ToCentiMetrePerSecond<T>(this Quantity<T, DekaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecond to MilliMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecond</param>
    /// <returns>quantity measured in MilliMetrePerSecond</returns>
	public static Quantity<double, MilliMetrePerSecond> ToMilliMetrePerSecond<T>(this Quantity<T, DekaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecond to MicroMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecond</param>
    /// <returns>quantity measured in MicroMetrePerSecond</returns>
	public static Quantity<double, MicroMetrePerSecond> ToMicroMetrePerSecond<T>(this Quantity<T, DekaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecond to NanoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecond</param>
    /// <returns>quantity measured in NanoMetrePerSecond</returns>
	public static Quantity<double, NanoMetrePerSecond> ToNanoMetrePerSecond<T>(this Quantity<T, DekaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecond to PicoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecond</param>
    /// <returns>quantity measured in PicoMetrePerSecond</returns>
	public static Quantity<double, PicoMetrePerSecond> ToPicoMetrePerSecond<T>(this Quantity<T, DekaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecond to FemtoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecond</param>
    /// <returns>quantity measured in FemtoMetrePerSecond</returns>
	public static Quantity<double, FemtoMetrePerSecond> ToFemtoMetrePerSecond<T>(this Quantity<T, DekaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecond to AttoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecond</param>
    /// <returns>quantity measured in AttoMetrePerSecond</returns>
	public static Quantity<double, AttoMetrePerSecond> ToAttoMetrePerSecond<T>(this Quantity<T, DekaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecond to ZeptoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecond</param>
    /// <returns>quantity measured in ZeptoMetrePerSecond</returns>
	public static Quantity<double, ZeptoMetrePerSecond> ToZeptoMetrePerSecond<T>(this Quantity<T, DekaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecond to YoctoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecond</param>
    /// <returns>quantity measured in YoctoMetrePerSecond</returns>
	public static Quantity<double, YoctoMetrePerSecond> ToYoctoMetrePerSecond<T>(this Quantity<T, DekaMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecond to YottaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecond</param>
    /// <returns>quantity measured in YottaMetrePerSecond</returns>
	public static Quantity<double, YottaMetrePerSecond> ToYottaMetrePerSecond<T>(this Quantity<T, DeciMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecond to ZettaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecond</param>
    /// <returns>quantity measured in ZettaMetrePerSecond</returns>
	public static Quantity<double, ZettaMetrePerSecond> ToZettaMetrePerSecond<T>(this Quantity<T, DeciMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecond to ExaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecond</param>
    /// <returns>quantity measured in ExaMetrePerSecond</returns>
	public static Quantity<double, ExaMetrePerSecond> ToExaMetrePerSecond<T>(this Quantity<T, DeciMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecond to PetaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecond</param>
    /// <returns>quantity measured in PetaMetrePerSecond</returns>
	public static Quantity<double, PetaMetrePerSecond> ToPetaMetrePerSecond<T>(this Quantity<T, DeciMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecond to TeraMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecond</param>
    /// <returns>quantity measured in TeraMetrePerSecond</returns>
	public static Quantity<double, TeraMetrePerSecond> ToTeraMetrePerSecond<T>(this Quantity<T, DeciMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecond to GigaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecond</param>
    /// <returns>quantity measured in GigaMetrePerSecond</returns>
	public static Quantity<double, GigaMetrePerSecond> ToGigaMetrePerSecond<T>(this Quantity<T, DeciMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecond to MegaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecond</param>
    /// <returns>quantity measured in MegaMetrePerSecond</returns>
	public static Quantity<double, MegaMetrePerSecond> ToMegaMetrePerSecond<T>(this Quantity<T, DeciMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecond to KiloMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecond</param>
    /// <returns>quantity measured in KiloMetrePerSecond</returns>
	public static Quantity<double, KiloMetrePerSecond> ToKiloMetrePerSecond<T>(this Quantity<T, DeciMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecond to HectoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecond</param>
    /// <returns>quantity measured in HectoMetrePerSecond</returns>
	public static Quantity<double, HectoMetrePerSecond> ToHectoMetrePerSecond<T>(this Quantity<T, DeciMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecond to DekaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecond</param>
    /// <returns>quantity measured in DekaMetrePerSecond</returns>
	public static Quantity<double, DekaMetrePerSecond> ToDekaMetrePerSecond<T>(this Quantity<T, DeciMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecond to CentiMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecond</param>
    /// <returns>quantity measured in CentiMetrePerSecond</returns>
	public static Quantity<double, CentiMetrePerSecond> ToCentiMetrePerSecond<T>(this Quantity<T, DeciMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecond to MilliMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecond</param>
    /// <returns>quantity measured in MilliMetrePerSecond</returns>
	public static Quantity<double, MilliMetrePerSecond> ToMilliMetrePerSecond<T>(this Quantity<T, DeciMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecond to MicroMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecond</param>
    /// <returns>quantity measured in MicroMetrePerSecond</returns>
	public static Quantity<double, MicroMetrePerSecond> ToMicroMetrePerSecond<T>(this Quantity<T, DeciMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecond to NanoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecond</param>
    /// <returns>quantity measured in NanoMetrePerSecond</returns>
	public static Quantity<double, NanoMetrePerSecond> ToNanoMetrePerSecond<T>(this Quantity<T, DeciMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecond to PicoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecond</param>
    /// <returns>quantity measured in PicoMetrePerSecond</returns>
	public static Quantity<double, PicoMetrePerSecond> ToPicoMetrePerSecond<T>(this Quantity<T, DeciMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecond to FemtoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecond</param>
    /// <returns>quantity measured in FemtoMetrePerSecond</returns>
	public static Quantity<double, FemtoMetrePerSecond> ToFemtoMetrePerSecond<T>(this Quantity<T, DeciMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecond to AttoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecond</param>
    /// <returns>quantity measured in AttoMetrePerSecond</returns>
	public static Quantity<double, AttoMetrePerSecond> ToAttoMetrePerSecond<T>(this Quantity<T, DeciMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecond to ZeptoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecond</param>
    /// <returns>quantity measured in ZeptoMetrePerSecond</returns>
	public static Quantity<double, ZeptoMetrePerSecond> ToZeptoMetrePerSecond<T>(this Quantity<T, DeciMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecond to YoctoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecond</param>
    /// <returns>quantity measured in YoctoMetrePerSecond</returns>
	public static Quantity<double, YoctoMetrePerSecond> ToYoctoMetrePerSecond<T>(this Quantity<T, DeciMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecond to YottaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecond</param>
    /// <returns>quantity measured in YottaMetrePerSecond</returns>
	public static Quantity<double, YottaMetrePerSecond> ToYottaMetrePerSecond<T>(this Quantity<T, CentiMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecond to ZettaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecond</param>
    /// <returns>quantity measured in ZettaMetrePerSecond</returns>
	public static Quantity<double, ZettaMetrePerSecond> ToZettaMetrePerSecond<T>(this Quantity<T, CentiMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecond to ExaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecond</param>
    /// <returns>quantity measured in ExaMetrePerSecond</returns>
	public static Quantity<double, ExaMetrePerSecond> ToExaMetrePerSecond<T>(this Quantity<T, CentiMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecond to PetaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecond</param>
    /// <returns>quantity measured in PetaMetrePerSecond</returns>
	public static Quantity<double, PetaMetrePerSecond> ToPetaMetrePerSecond<T>(this Quantity<T, CentiMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecond to TeraMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecond</param>
    /// <returns>quantity measured in TeraMetrePerSecond</returns>
	public static Quantity<double, TeraMetrePerSecond> ToTeraMetrePerSecond<T>(this Quantity<T, CentiMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecond to GigaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecond</param>
    /// <returns>quantity measured in GigaMetrePerSecond</returns>
	public static Quantity<double, GigaMetrePerSecond> ToGigaMetrePerSecond<T>(this Quantity<T, CentiMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecond to MegaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecond</param>
    /// <returns>quantity measured in MegaMetrePerSecond</returns>
	public static Quantity<double, MegaMetrePerSecond> ToMegaMetrePerSecond<T>(this Quantity<T, CentiMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecond to KiloMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecond</param>
    /// <returns>quantity measured in KiloMetrePerSecond</returns>
	public static Quantity<double, KiloMetrePerSecond> ToKiloMetrePerSecond<T>(this Quantity<T, CentiMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecond to HectoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecond</param>
    /// <returns>quantity measured in HectoMetrePerSecond</returns>
	public static Quantity<double, HectoMetrePerSecond> ToHectoMetrePerSecond<T>(this Quantity<T, CentiMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecond to DekaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecond</param>
    /// <returns>quantity measured in DekaMetrePerSecond</returns>
	public static Quantity<double, DekaMetrePerSecond> ToDekaMetrePerSecond<T>(this Quantity<T, CentiMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecond to DeciMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecond</param>
    /// <returns>quantity measured in DeciMetrePerSecond</returns>
	public static Quantity<double, DeciMetrePerSecond> ToDeciMetrePerSecond<T>(this Quantity<T, CentiMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecond to MilliMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecond</param>
    /// <returns>quantity measured in MilliMetrePerSecond</returns>
	public static Quantity<double, MilliMetrePerSecond> ToMilliMetrePerSecond<T>(this Quantity<T, CentiMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecond to MicroMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecond</param>
    /// <returns>quantity measured in MicroMetrePerSecond</returns>
	public static Quantity<double, MicroMetrePerSecond> ToMicroMetrePerSecond<T>(this Quantity<T, CentiMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecond to NanoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecond</param>
    /// <returns>quantity measured in NanoMetrePerSecond</returns>
	public static Quantity<double, NanoMetrePerSecond> ToNanoMetrePerSecond<T>(this Quantity<T, CentiMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecond to PicoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecond</param>
    /// <returns>quantity measured in PicoMetrePerSecond</returns>
	public static Quantity<double, PicoMetrePerSecond> ToPicoMetrePerSecond<T>(this Quantity<T, CentiMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecond to FemtoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecond</param>
    /// <returns>quantity measured in FemtoMetrePerSecond</returns>
	public static Quantity<double, FemtoMetrePerSecond> ToFemtoMetrePerSecond<T>(this Quantity<T, CentiMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecond to AttoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecond</param>
    /// <returns>quantity measured in AttoMetrePerSecond</returns>
	public static Quantity<double, AttoMetrePerSecond> ToAttoMetrePerSecond<T>(this Quantity<T, CentiMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecond to ZeptoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecond</param>
    /// <returns>quantity measured in ZeptoMetrePerSecond</returns>
	public static Quantity<double, ZeptoMetrePerSecond> ToZeptoMetrePerSecond<T>(this Quantity<T, CentiMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecond to YoctoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecond</param>
    /// <returns>quantity measured in YoctoMetrePerSecond</returns>
	public static Quantity<double, YoctoMetrePerSecond> ToYoctoMetrePerSecond<T>(this Quantity<T, CentiMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecond to YottaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecond</param>
    /// <returns>quantity measured in YottaMetrePerSecond</returns>
	public static Quantity<double, YottaMetrePerSecond> ToYottaMetrePerSecond<T>(this Quantity<T, MilliMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecond to ZettaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecond</param>
    /// <returns>quantity measured in ZettaMetrePerSecond</returns>
	public static Quantity<double, ZettaMetrePerSecond> ToZettaMetrePerSecond<T>(this Quantity<T, MilliMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecond to ExaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecond</param>
    /// <returns>quantity measured in ExaMetrePerSecond</returns>
	public static Quantity<double, ExaMetrePerSecond> ToExaMetrePerSecond<T>(this Quantity<T, MilliMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecond to PetaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecond</param>
    /// <returns>quantity measured in PetaMetrePerSecond</returns>
	public static Quantity<double, PetaMetrePerSecond> ToPetaMetrePerSecond<T>(this Quantity<T, MilliMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecond to TeraMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecond</param>
    /// <returns>quantity measured in TeraMetrePerSecond</returns>
	public static Quantity<double, TeraMetrePerSecond> ToTeraMetrePerSecond<T>(this Quantity<T, MilliMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecond to GigaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecond</param>
    /// <returns>quantity measured in GigaMetrePerSecond</returns>
	public static Quantity<double, GigaMetrePerSecond> ToGigaMetrePerSecond<T>(this Quantity<T, MilliMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecond to MegaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecond</param>
    /// <returns>quantity measured in MegaMetrePerSecond</returns>
	public static Quantity<double, MegaMetrePerSecond> ToMegaMetrePerSecond<T>(this Quantity<T, MilliMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecond to KiloMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecond</param>
    /// <returns>quantity measured in KiloMetrePerSecond</returns>
	public static Quantity<double, KiloMetrePerSecond> ToKiloMetrePerSecond<T>(this Quantity<T, MilliMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecond to HectoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecond</param>
    /// <returns>quantity measured in HectoMetrePerSecond</returns>
	public static Quantity<double, HectoMetrePerSecond> ToHectoMetrePerSecond<T>(this Quantity<T, MilliMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecond to DekaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecond</param>
    /// <returns>quantity measured in DekaMetrePerSecond</returns>
	public static Quantity<double, DekaMetrePerSecond> ToDekaMetrePerSecond<T>(this Quantity<T, MilliMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecond to DeciMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecond</param>
    /// <returns>quantity measured in DeciMetrePerSecond</returns>
	public static Quantity<double, DeciMetrePerSecond> ToDeciMetrePerSecond<T>(this Quantity<T, MilliMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecond to CentiMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecond</param>
    /// <returns>quantity measured in CentiMetrePerSecond</returns>
	public static Quantity<double, CentiMetrePerSecond> ToCentiMetrePerSecond<T>(this Quantity<T, MilliMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecond to MicroMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecond</param>
    /// <returns>quantity measured in MicroMetrePerSecond</returns>
	public static Quantity<double, MicroMetrePerSecond> ToMicroMetrePerSecond<T>(this Quantity<T, MilliMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecond to NanoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecond</param>
    /// <returns>quantity measured in NanoMetrePerSecond</returns>
	public static Quantity<double, NanoMetrePerSecond> ToNanoMetrePerSecond<T>(this Quantity<T, MilliMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecond to PicoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecond</param>
    /// <returns>quantity measured in PicoMetrePerSecond</returns>
	public static Quantity<double, PicoMetrePerSecond> ToPicoMetrePerSecond<T>(this Quantity<T, MilliMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecond to FemtoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecond</param>
    /// <returns>quantity measured in FemtoMetrePerSecond</returns>
	public static Quantity<double, FemtoMetrePerSecond> ToFemtoMetrePerSecond<T>(this Quantity<T, MilliMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecond to AttoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecond</param>
    /// <returns>quantity measured in AttoMetrePerSecond</returns>
	public static Quantity<double, AttoMetrePerSecond> ToAttoMetrePerSecond<T>(this Quantity<T, MilliMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecond to ZeptoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecond</param>
    /// <returns>quantity measured in ZeptoMetrePerSecond</returns>
	public static Quantity<double, ZeptoMetrePerSecond> ToZeptoMetrePerSecond<T>(this Quantity<T, MilliMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecond to YoctoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecond</param>
    /// <returns>quantity measured in YoctoMetrePerSecond</returns>
	public static Quantity<double, YoctoMetrePerSecond> ToYoctoMetrePerSecond<T>(this Quantity<T, MilliMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecond to YottaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecond</param>
    /// <returns>quantity measured in YottaMetrePerSecond</returns>
	public static Quantity<double, YottaMetrePerSecond> ToYottaMetrePerSecond<T>(this Quantity<T, MicroMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecond to ZettaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecond</param>
    /// <returns>quantity measured in ZettaMetrePerSecond</returns>
	public static Quantity<double, ZettaMetrePerSecond> ToZettaMetrePerSecond<T>(this Quantity<T, MicroMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecond to ExaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecond</param>
    /// <returns>quantity measured in ExaMetrePerSecond</returns>
	public static Quantity<double, ExaMetrePerSecond> ToExaMetrePerSecond<T>(this Quantity<T, MicroMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecond to PetaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecond</param>
    /// <returns>quantity measured in PetaMetrePerSecond</returns>
	public static Quantity<double, PetaMetrePerSecond> ToPetaMetrePerSecond<T>(this Quantity<T, MicroMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecond to TeraMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecond</param>
    /// <returns>quantity measured in TeraMetrePerSecond</returns>
	public static Quantity<double, TeraMetrePerSecond> ToTeraMetrePerSecond<T>(this Quantity<T, MicroMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecond to GigaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecond</param>
    /// <returns>quantity measured in GigaMetrePerSecond</returns>
	public static Quantity<double, GigaMetrePerSecond> ToGigaMetrePerSecond<T>(this Quantity<T, MicroMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecond to MegaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecond</param>
    /// <returns>quantity measured in MegaMetrePerSecond</returns>
	public static Quantity<double, MegaMetrePerSecond> ToMegaMetrePerSecond<T>(this Quantity<T, MicroMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecond to KiloMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecond</param>
    /// <returns>quantity measured in KiloMetrePerSecond</returns>
	public static Quantity<double, KiloMetrePerSecond> ToKiloMetrePerSecond<T>(this Quantity<T, MicroMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecond to HectoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecond</param>
    /// <returns>quantity measured in HectoMetrePerSecond</returns>
	public static Quantity<double, HectoMetrePerSecond> ToHectoMetrePerSecond<T>(this Quantity<T, MicroMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecond to DekaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecond</param>
    /// <returns>quantity measured in DekaMetrePerSecond</returns>
	public static Quantity<double, DekaMetrePerSecond> ToDekaMetrePerSecond<T>(this Quantity<T, MicroMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecond to DeciMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecond</param>
    /// <returns>quantity measured in DeciMetrePerSecond</returns>
	public static Quantity<double, DeciMetrePerSecond> ToDeciMetrePerSecond<T>(this Quantity<T, MicroMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecond to CentiMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecond</param>
    /// <returns>quantity measured in CentiMetrePerSecond</returns>
	public static Quantity<double, CentiMetrePerSecond> ToCentiMetrePerSecond<T>(this Quantity<T, MicroMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecond to MilliMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecond</param>
    /// <returns>quantity measured in MilliMetrePerSecond</returns>
	public static Quantity<double, MilliMetrePerSecond> ToMilliMetrePerSecond<T>(this Quantity<T, MicroMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecond to NanoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecond</param>
    /// <returns>quantity measured in NanoMetrePerSecond</returns>
	public static Quantity<double, NanoMetrePerSecond> ToNanoMetrePerSecond<T>(this Quantity<T, MicroMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecond to PicoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecond</param>
    /// <returns>quantity measured in PicoMetrePerSecond</returns>
	public static Quantity<double, PicoMetrePerSecond> ToPicoMetrePerSecond<T>(this Quantity<T, MicroMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecond to FemtoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecond</param>
    /// <returns>quantity measured in FemtoMetrePerSecond</returns>
	public static Quantity<double, FemtoMetrePerSecond> ToFemtoMetrePerSecond<T>(this Quantity<T, MicroMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecond to AttoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecond</param>
    /// <returns>quantity measured in AttoMetrePerSecond</returns>
	public static Quantity<double, AttoMetrePerSecond> ToAttoMetrePerSecond<T>(this Quantity<T, MicroMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecond to ZeptoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecond</param>
    /// <returns>quantity measured in ZeptoMetrePerSecond</returns>
	public static Quantity<double, ZeptoMetrePerSecond> ToZeptoMetrePerSecond<T>(this Quantity<T, MicroMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecond to YoctoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecond</param>
    /// <returns>quantity measured in YoctoMetrePerSecond</returns>
	public static Quantity<double, YoctoMetrePerSecond> ToYoctoMetrePerSecond<T>(this Quantity<T, MicroMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecond to YottaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecond</param>
    /// <returns>quantity measured in YottaMetrePerSecond</returns>
	public static Quantity<double, YottaMetrePerSecond> ToYottaMetrePerSecond<T>(this Quantity<T, NanoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecond to ZettaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecond</param>
    /// <returns>quantity measured in ZettaMetrePerSecond</returns>
	public static Quantity<double, ZettaMetrePerSecond> ToZettaMetrePerSecond<T>(this Quantity<T, NanoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecond to ExaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecond</param>
    /// <returns>quantity measured in ExaMetrePerSecond</returns>
	public static Quantity<double, ExaMetrePerSecond> ToExaMetrePerSecond<T>(this Quantity<T, NanoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecond to PetaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecond</param>
    /// <returns>quantity measured in PetaMetrePerSecond</returns>
	public static Quantity<double, PetaMetrePerSecond> ToPetaMetrePerSecond<T>(this Quantity<T, NanoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecond to TeraMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecond</param>
    /// <returns>quantity measured in TeraMetrePerSecond</returns>
	public static Quantity<double, TeraMetrePerSecond> ToTeraMetrePerSecond<T>(this Quantity<T, NanoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecond to GigaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecond</param>
    /// <returns>quantity measured in GigaMetrePerSecond</returns>
	public static Quantity<double, GigaMetrePerSecond> ToGigaMetrePerSecond<T>(this Quantity<T, NanoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecond to MegaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecond</param>
    /// <returns>quantity measured in MegaMetrePerSecond</returns>
	public static Quantity<double, MegaMetrePerSecond> ToMegaMetrePerSecond<T>(this Quantity<T, NanoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecond to KiloMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecond</param>
    /// <returns>quantity measured in KiloMetrePerSecond</returns>
	public static Quantity<double, KiloMetrePerSecond> ToKiloMetrePerSecond<T>(this Quantity<T, NanoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecond to HectoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecond</param>
    /// <returns>quantity measured in HectoMetrePerSecond</returns>
	public static Quantity<double, HectoMetrePerSecond> ToHectoMetrePerSecond<T>(this Quantity<T, NanoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecond to DekaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecond</param>
    /// <returns>quantity measured in DekaMetrePerSecond</returns>
	public static Quantity<double, DekaMetrePerSecond> ToDekaMetrePerSecond<T>(this Quantity<T, NanoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecond to DeciMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecond</param>
    /// <returns>quantity measured in DeciMetrePerSecond</returns>
	public static Quantity<double, DeciMetrePerSecond> ToDeciMetrePerSecond<T>(this Quantity<T, NanoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecond to CentiMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecond</param>
    /// <returns>quantity measured in CentiMetrePerSecond</returns>
	public static Quantity<double, CentiMetrePerSecond> ToCentiMetrePerSecond<T>(this Quantity<T, NanoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecond to MilliMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecond</param>
    /// <returns>quantity measured in MilliMetrePerSecond</returns>
	public static Quantity<double, MilliMetrePerSecond> ToMilliMetrePerSecond<T>(this Quantity<T, NanoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecond to MicroMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecond</param>
    /// <returns>quantity measured in MicroMetrePerSecond</returns>
	public static Quantity<double, MicroMetrePerSecond> ToMicroMetrePerSecond<T>(this Quantity<T, NanoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecond to PicoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecond</param>
    /// <returns>quantity measured in PicoMetrePerSecond</returns>
	public static Quantity<double, PicoMetrePerSecond> ToPicoMetrePerSecond<T>(this Quantity<T, NanoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecond to FemtoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecond</param>
    /// <returns>quantity measured in FemtoMetrePerSecond</returns>
	public static Quantity<double, FemtoMetrePerSecond> ToFemtoMetrePerSecond<T>(this Quantity<T, NanoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecond to AttoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecond</param>
    /// <returns>quantity measured in AttoMetrePerSecond</returns>
	public static Quantity<double, AttoMetrePerSecond> ToAttoMetrePerSecond<T>(this Quantity<T, NanoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecond to ZeptoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecond</param>
    /// <returns>quantity measured in ZeptoMetrePerSecond</returns>
	public static Quantity<double, ZeptoMetrePerSecond> ToZeptoMetrePerSecond<T>(this Quantity<T, NanoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecond to YoctoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecond</param>
    /// <returns>quantity measured in YoctoMetrePerSecond</returns>
	public static Quantity<double, YoctoMetrePerSecond> ToYoctoMetrePerSecond<T>(this Quantity<T, NanoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecond to YottaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecond</param>
    /// <returns>quantity measured in YottaMetrePerSecond</returns>
	public static Quantity<double, YottaMetrePerSecond> ToYottaMetrePerSecond<T>(this Quantity<T, PicoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecond to ZettaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecond</param>
    /// <returns>quantity measured in ZettaMetrePerSecond</returns>
	public static Quantity<double, ZettaMetrePerSecond> ToZettaMetrePerSecond<T>(this Quantity<T, PicoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecond to ExaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecond</param>
    /// <returns>quantity measured in ExaMetrePerSecond</returns>
	public static Quantity<double, ExaMetrePerSecond> ToExaMetrePerSecond<T>(this Quantity<T, PicoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecond to PetaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecond</param>
    /// <returns>quantity measured in PetaMetrePerSecond</returns>
	public static Quantity<double, PetaMetrePerSecond> ToPetaMetrePerSecond<T>(this Quantity<T, PicoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecond to TeraMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecond</param>
    /// <returns>quantity measured in TeraMetrePerSecond</returns>
	public static Quantity<double, TeraMetrePerSecond> ToTeraMetrePerSecond<T>(this Quantity<T, PicoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecond to GigaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecond</param>
    /// <returns>quantity measured in GigaMetrePerSecond</returns>
	public static Quantity<double, GigaMetrePerSecond> ToGigaMetrePerSecond<T>(this Quantity<T, PicoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecond to MegaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecond</param>
    /// <returns>quantity measured in MegaMetrePerSecond</returns>
	public static Quantity<double, MegaMetrePerSecond> ToMegaMetrePerSecond<T>(this Quantity<T, PicoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecond to KiloMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecond</param>
    /// <returns>quantity measured in KiloMetrePerSecond</returns>
	public static Quantity<double, KiloMetrePerSecond> ToKiloMetrePerSecond<T>(this Quantity<T, PicoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecond to HectoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecond</param>
    /// <returns>quantity measured in HectoMetrePerSecond</returns>
	public static Quantity<double, HectoMetrePerSecond> ToHectoMetrePerSecond<T>(this Quantity<T, PicoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecond to DekaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecond</param>
    /// <returns>quantity measured in DekaMetrePerSecond</returns>
	public static Quantity<double, DekaMetrePerSecond> ToDekaMetrePerSecond<T>(this Quantity<T, PicoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecond to DeciMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecond</param>
    /// <returns>quantity measured in DeciMetrePerSecond</returns>
	public static Quantity<double, DeciMetrePerSecond> ToDeciMetrePerSecond<T>(this Quantity<T, PicoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecond to CentiMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecond</param>
    /// <returns>quantity measured in CentiMetrePerSecond</returns>
	public static Quantity<double, CentiMetrePerSecond> ToCentiMetrePerSecond<T>(this Quantity<T, PicoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecond to MilliMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecond</param>
    /// <returns>quantity measured in MilliMetrePerSecond</returns>
	public static Quantity<double, MilliMetrePerSecond> ToMilliMetrePerSecond<T>(this Quantity<T, PicoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecond to MicroMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecond</param>
    /// <returns>quantity measured in MicroMetrePerSecond</returns>
	public static Quantity<double, MicroMetrePerSecond> ToMicroMetrePerSecond<T>(this Quantity<T, PicoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecond to NanoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecond</param>
    /// <returns>quantity measured in NanoMetrePerSecond</returns>
	public static Quantity<double, NanoMetrePerSecond> ToNanoMetrePerSecond<T>(this Quantity<T, PicoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecond to FemtoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecond</param>
    /// <returns>quantity measured in FemtoMetrePerSecond</returns>
	public static Quantity<double, FemtoMetrePerSecond> ToFemtoMetrePerSecond<T>(this Quantity<T, PicoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecond to AttoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecond</param>
    /// <returns>quantity measured in AttoMetrePerSecond</returns>
	public static Quantity<double, AttoMetrePerSecond> ToAttoMetrePerSecond<T>(this Quantity<T, PicoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecond to ZeptoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecond</param>
    /// <returns>quantity measured in ZeptoMetrePerSecond</returns>
	public static Quantity<double, ZeptoMetrePerSecond> ToZeptoMetrePerSecond<T>(this Quantity<T, PicoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecond to YoctoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecond</param>
    /// <returns>quantity measured in YoctoMetrePerSecond</returns>
	public static Quantity<double, YoctoMetrePerSecond> ToYoctoMetrePerSecond<T>(this Quantity<T, PicoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecond to YottaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecond</param>
    /// <returns>quantity measured in YottaMetrePerSecond</returns>
	public static Quantity<double, YottaMetrePerSecond> ToYottaMetrePerSecond<T>(this Quantity<T, FemtoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecond to ZettaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecond</param>
    /// <returns>quantity measured in ZettaMetrePerSecond</returns>
	public static Quantity<double, ZettaMetrePerSecond> ToZettaMetrePerSecond<T>(this Quantity<T, FemtoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecond to ExaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecond</param>
    /// <returns>quantity measured in ExaMetrePerSecond</returns>
	public static Quantity<double, ExaMetrePerSecond> ToExaMetrePerSecond<T>(this Quantity<T, FemtoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecond to PetaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecond</param>
    /// <returns>quantity measured in PetaMetrePerSecond</returns>
	public static Quantity<double, PetaMetrePerSecond> ToPetaMetrePerSecond<T>(this Quantity<T, FemtoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecond to TeraMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecond</param>
    /// <returns>quantity measured in TeraMetrePerSecond</returns>
	public static Quantity<double, TeraMetrePerSecond> ToTeraMetrePerSecond<T>(this Quantity<T, FemtoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecond to GigaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecond</param>
    /// <returns>quantity measured in GigaMetrePerSecond</returns>
	public static Quantity<double, GigaMetrePerSecond> ToGigaMetrePerSecond<T>(this Quantity<T, FemtoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecond to MegaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecond</param>
    /// <returns>quantity measured in MegaMetrePerSecond</returns>
	public static Quantity<double, MegaMetrePerSecond> ToMegaMetrePerSecond<T>(this Quantity<T, FemtoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecond to KiloMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecond</param>
    /// <returns>quantity measured in KiloMetrePerSecond</returns>
	public static Quantity<double, KiloMetrePerSecond> ToKiloMetrePerSecond<T>(this Quantity<T, FemtoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecond to HectoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecond</param>
    /// <returns>quantity measured in HectoMetrePerSecond</returns>
	public static Quantity<double, HectoMetrePerSecond> ToHectoMetrePerSecond<T>(this Quantity<T, FemtoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecond to DekaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecond</param>
    /// <returns>quantity measured in DekaMetrePerSecond</returns>
	public static Quantity<double, DekaMetrePerSecond> ToDekaMetrePerSecond<T>(this Quantity<T, FemtoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecond to DeciMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecond</param>
    /// <returns>quantity measured in DeciMetrePerSecond</returns>
	public static Quantity<double, DeciMetrePerSecond> ToDeciMetrePerSecond<T>(this Quantity<T, FemtoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecond to CentiMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecond</param>
    /// <returns>quantity measured in CentiMetrePerSecond</returns>
	public static Quantity<double, CentiMetrePerSecond> ToCentiMetrePerSecond<T>(this Quantity<T, FemtoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecond to MilliMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecond</param>
    /// <returns>quantity measured in MilliMetrePerSecond</returns>
	public static Quantity<double, MilliMetrePerSecond> ToMilliMetrePerSecond<T>(this Quantity<T, FemtoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecond to MicroMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecond</param>
    /// <returns>quantity measured in MicroMetrePerSecond</returns>
	public static Quantity<double, MicroMetrePerSecond> ToMicroMetrePerSecond<T>(this Quantity<T, FemtoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecond to NanoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecond</param>
    /// <returns>quantity measured in NanoMetrePerSecond</returns>
	public static Quantity<double, NanoMetrePerSecond> ToNanoMetrePerSecond<T>(this Quantity<T, FemtoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecond to PicoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecond</param>
    /// <returns>quantity measured in PicoMetrePerSecond</returns>
	public static Quantity<double, PicoMetrePerSecond> ToPicoMetrePerSecond<T>(this Quantity<T, FemtoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecond to AttoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecond</param>
    /// <returns>quantity measured in AttoMetrePerSecond</returns>
	public static Quantity<double, AttoMetrePerSecond> ToAttoMetrePerSecond<T>(this Quantity<T, FemtoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecond to ZeptoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecond</param>
    /// <returns>quantity measured in ZeptoMetrePerSecond</returns>
	public static Quantity<double, ZeptoMetrePerSecond> ToZeptoMetrePerSecond<T>(this Quantity<T, FemtoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecond to YoctoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecond</param>
    /// <returns>quantity measured in YoctoMetrePerSecond</returns>
	public static Quantity<double, YoctoMetrePerSecond> ToYoctoMetrePerSecond<T>(this Quantity<T, FemtoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecond to YottaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecond</param>
    /// <returns>quantity measured in YottaMetrePerSecond</returns>
	public static Quantity<double, YottaMetrePerSecond> ToYottaMetrePerSecond<T>(this Quantity<T, AttoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecond to ZettaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecond</param>
    /// <returns>quantity measured in ZettaMetrePerSecond</returns>
	public static Quantity<double, ZettaMetrePerSecond> ToZettaMetrePerSecond<T>(this Quantity<T, AttoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecond to ExaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecond</param>
    /// <returns>quantity measured in ExaMetrePerSecond</returns>
	public static Quantity<double, ExaMetrePerSecond> ToExaMetrePerSecond<T>(this Quantity<T, AttoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecond to PetaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecond</param>
    /// <returns>quantity measured in PetaMetrePerSecond</returns>
	public static Quantity<double, PetaMetrePerSecond> ToPetaMetrePerSecond<T>(this Quantity<T, AttoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecond to TeraMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecond</param>
    /// <returns>quantity measured in TeraMetrePerSecond</returns>
	public static Quantity<double, TeraMetrePerSecond> ToTeraMetrePerSecond<T>(this Quantity<T, AttoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecond to GigaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecond</param>
    /// <returns>quantity measured in GigaMetrePerSecond</returns>
	public static Quantity<double, GigaMetrePerSecond> ToGigaMetrePerSecond<T>(this Quantity<T, AttoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecond to MegaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecond</param>
    /// <returns>quantity measured in MegaMetrePerSecond</returns>
	public static Quantity<double, MegaMetrePerSecond> ToMegaMetrePerSecond<T>(this Quantity<T, AttoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecond to KiloMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecond</param>
    /// <returns>quantity measured in KiloMetrePerSecond</returns>
	public static Quantity<double, KiloMetrePerSecond> ToKiloMetrePerSecond<T>(this Quantity<T, AttoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecond to HectoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecond</param>
    /// <returns>quantity measured in HectoMetrePerSecond</returns>
	public static Quantity<double, HectoMetrePerSecond> ToHectoMetrePerSecond<T>(this Quantity<T, AttoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecond to DekaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecond</param>
    /// <returns>quantity measured in DekaMetrePerSecond</returns>
	public static Quantity<double, DekaMetrePerSecond> ToDekaMetrePerSecond<T>(this Quantity<T, AttoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecond to DeciMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecond</param>
    /// <returns>quantity measured in DeciMetrePerSecond</returns>
	public static Quantity<double, DeciMetrePerSecond> ToDeciMetrePerSecond<T>(this Quantity<T, AttoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecond to CentiMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecond</param>
    /// <returns>quantity measured in CentiMetrePerSecond</returns>
	public static Quantity<double, CentiMetrePerSecond> ToCentiMetrePerSecond<T>(this Quantity<T, AttoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecond to MilliMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecond</param>
    /// <returns>quantity measured in MilliMetrePerSecond</returns>
	public static Quantity<double, MilliMetrePerSecond> ToMilliMetrePerSecond<T>(this Quantity<T, AttoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecond to MicroMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecond</param>
    /// <returns>quantity measured in MicroMetrePerSecond</returns>
	public static Quantity<double, MicroMetrePerSecond> ToMicroMetrePerSecond<T>(this Quantity<T, AttoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecond to NanoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecond</param>
    /// <returns>quantity measured in NanoMetrePerSecond</returns>
	public static Quantity<double, NanoMetrePerSecond> ToNanoMetrePerSecond<T>(this Quantity<T, AttoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecond to PicoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecond</param>
    /// <returns>quantity measured in PicoMetrePerSecond</returns>
	public static Quantity<double, PicoMetrePerSecond> ToPicoMetrePerSecond<T>(this Quantity<T, AttoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecond to FemtoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecond</param>
    /// <returns>quantity measured in FemtoMetrePerSecond</returns>
	public static Quantity<double, FemtoMetrePerSecond> ToFemtoMetrePerSecond<T>(this Quantity<T, AttoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecond to ZeptoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecond</param>
    /// <returns>quantity measured in ZeptoMetrePerSecond</returns>
	public static Quantity<double, ZeptoMetrePerSecond> ToZeptoMetrePerSecond<T>(this Quantity<T, AttoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecond to YoctoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecond</param>
    /// <returns>quantity measured in YoctoMetrePerSecond</returns>
	public static Quantity<double, YoctoMetrePerSecond> ToYoctoMetrePerSecond<T>(this Quantity<T, AttoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecond to YottaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecond</param>
    /// <returns>quantity measured in YottaMetrePerSecond</returns>
	public static Quantity<double, YottaMetrePerSecond> ToYottaMetrePerSecond<T>(this Quantity<T, ZeptoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecond to ZettaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecond</param>
    /// <returns>quantity measured in ZettaMetrePerSecond</returns>
	public static Quantity<double, ZettaMetrePerSecond> ToZettaMetrePerSecond<T>(this Quantity<T, ZeptoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecond to ExaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecond</param>
    /// <returns>quantity measured in ExaMetrePerSecond</returns>
	public static Quantity<double, ExaMetrePerSecond> ToExaMetrePerSecond<T>(this Quantity<T, ZeptoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecond to PetaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecond</param>
    /// <returns>quantity measured in PetaMetrePerSecond</returns>
	public static Quantity<double, PetaMetrePerSecond> ToPetaMetrePerSecond<T>(this Quantity<T, ZeptoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecond to TeraMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecond</param>
    /// <returns>quantity measured in TeraMetrePerSecond</returns>
	public static Quantity<double, TeraMetrePerSecond> ToTeraMetrePerSecond<T>(this Quantity<T, ZeptoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecond to GigaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecond</param>
    /// <returns>quantity measured in GigaMetrePerSecond</returns>
	public static Quantity<double, GigaMetrePerSecond> ToGigaMetrePerSecond<T>(this Quantity<T, ZeptoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecond to MegaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecond</param>
    /// <returns>quantity measured in MegaMetrePerSecond</returns>
	public static Quantity<double, MegaMetrePerSecond> ToMegaMetrePerSecond<T>(this Quantity<T, ZeptoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecond to KiloMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecond</param>
    /// <returns>quantity measured in KiloMetrePerSecond</returns>
	public static Quantity<double, KiloMetrePerSecond> ToKiloMetrePerSecond<T>(this Quantity<T, ZeptoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecond to HectoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecond</param>
    /// <returns>quantity measured in HectoMetrePerSecond</returns>
	public static Quantity<double, HectoMetrePerSecond> ToHectoMetrePerSecond<T>(this Quantity<T, ZeptoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecond to DekaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecond</param>
    /// <returns>quantity measured in DekaMetrePerSecond</returns>
	public static Quantity<double, DekaMetrePerSecond> ToDekaMetrePerSecond<T>(this Quantity<T, ZeptoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecond to DeciMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecond</param>
    /// <returns>quantity measured in DeciMetrePerSecond</returns>
	public static Quantity<double, DeciMetrePerSecond> ToDeciMetrePerSecond<T>(this Quantity<T, ZeptoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecond to CentiMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecond</param>
    /// <returns>quantity measured in CentiMetrePerSecond</returns>
	public static Quantity<double, CentiMetrePerSecond> ToCentiMetrePerSecond<T>(this Quantity<T, ZeptoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecond to MilliMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecond</param>
    /// <returns>quantity measured in MilliMetrePerSecond</returns>
	public static Quantity<double, MilliMetrePerSecond> ToMilliMetrePerSecond<T>(this Quantity<T, ZeptoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecond to MicroMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecond</param>
    /// <returns>quantity measured in MicroMetrePerSecond</returns>
	public static Quantity<double, MicroMetrePerSecond> ToMicroMetrePerSecond<T>(this Quantity<T, ZeptoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecond to NanoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecond</param>
    /// <returns>quantity measured in NanoMetrePerSecond</returns>
	public static Quantity<double, NanoMetrePerSecond> ToNanoMetrePerSecond<T>(this Quantity<T, ZeptoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecond to PicoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecond</param>
    /// <returns>quantity measured in PicoMetrePerSecond</returns>
	public static Quantity<double, PicoMetrePerSecond> ToPicoMetrePerSecond<T>(this Quantity<T, ZeptoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecond to FemtoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecond</param>
    /// <returns>quantity measured in FemtoMetrePerSecond</returns>
	public static Quantity<double, FemtoMetrePerSecond> ToFemtoMetrePerSecond<T>(this Quantity<T, ZeptoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecond to AttoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecond</param>
    /// <returns>quantity measured in AttoMetrePerSecond</returns>
	public static Quantity<double, AttoMetrePerSecond> ToAttoMetrePerSecond<T>(this Quantity<T, ZeptoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecond to YoctoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecond</param>
    /// <returns>quantity measured in YoctoMetrePerSecond</returns>
	public static Quantity<double, YoctoMetrePerSecond> ToYoctoMetrePerSecond<T>(this Quantity<T, ZeptoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecond to YottaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecond</param>
    /// <returns>quantity measured in YottaMetrePerSecond</returns>
	public static Quantity<double, YottaMetrePerSecond> ToYottaMetrePerSecond<T>(this Quantity<T, YoctoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecond to ZettaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecond</param>
    /// <returns>quantity measured in ZettaMetrePerSecond</returns>
	public static Quantity<double, ZettaMetrePerSecond> ToZettaMetrePerSecond<T>(this Quantity<T, YoctoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecond to ExaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecond</param>
    /// <returns>quantity measured in ExaMetrePerSecond</returns>
	public static Quantity<double, ExaMetrePerSecond> ToExaMetrePerSecond<T>(this Quantity<T, YoctoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecond to PetaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecond</param>
    /// <returns>quantity measured in PetaMetrePerSecond</returns>
	public static Quantity<double, PetaMetrePerSecond> ToPetaMetrePerSecond<T>(this Quantity<T, YoctoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecond to TeraMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecond</param>
    /// <returns>quantity measured in TeraMetrePerSecond</returns>
	public static Quantity<double, TeraMetrePerSecond> ToTeraMetrePerSecond<T>(this Quantity<T, YoctoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecond to GigaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecond</param>
    /// <returns>quantity measured in GigaMetrePerSecond</returns>
	public static Quantity<double, GigaMetrePerSecond> ToGigaMetrePerSecond<T>(this Quantity<T, YoctoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecond to MegaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecond</param>
    /// <returns>quantity measured in MegaMetrePerSecond</returns>
	public static Quantity<double, MegaMetrePerSecond> ToMegaMetrePerSecond<T>(this Quantity<T, YoctoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecond to KiloMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecond</param>
    /// <returns>quantity measured in KiloMetrePerSecond</returns>
	public static Quantity<double, KiloMetrePerSecond> ToKiloMetrePerSecond<T>(this Quantity<T, YoctoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecond to HectoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecond</param>
    /// <returns>quantity measured in HectoMetrePerSecond</returns>
	public static Quantity<double, HectoMetrePerSecond> ToHectoMetrePerSecond<T>(this Quantity<T, YoctoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecond to DekaMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecond</param>
    /// <returns>quantity measured in DekaMetrePerSecond</returns>
	public static Quantity<double, DekaMetrePerSecond> ToDekaMetrePerSecond<T>(this Quantity<T, YoctoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecond to DeciMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecond</param>
    /// <returns>quantity measured in DeciMetrePerSecond</returns>
	public static Quantity<double, DeciMetrePerSecond> ToDeciMetrePerSecond<T>(this Quantity<T, YoctoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecond to CentiMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecond</param>
    /// <returns>quantity measured in CentiMetrePerSecond</returns>
	public static Quantity<double, CentiMetrePerSecond> ToCentiMetrePerSecond<T>(this Quantity<T, YoctoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecond to MilliMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecond</param>
    /// <returns>quantity measured in MilliMetrePerSecond</returns>
	public static Quantity<double, MilliMetrePerSecond> ToMilliMetrePerSecond<T>(this Quantity<T, YoctoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecond to MicroMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecond</param>
    /// <returns>quantity measured in MicroMetrePerSecond</returns>
	public static Quantity<double, MicroMetrePerSecond> ToMicroMetrePerSecond<T>(this Quantity<T, YoctoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecond to NanoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecond</param>
    /// <returns>quantity measured in NanoMetrePerSecond</returns>
	public static Quantity<double, NanoMetrePerSecond> ToNanoMetrePerSecond<T>(this Quantity<T, YoctoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecond to PicoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecond</param>
    /// <returns>quantity measured in PicoMetrePerSecond</returns>
	public static Quantity<double, PicoMetrePerSecond> ToPicoMetrePerSecond<T>(this Quantity<T, YoctoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecond to FemtoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecond</param>
    /// <returns>quantity measured in FemtoMetrePerSecond</returns>
	public static Quantity<double, FemtoMetrePerSecond> ToFemtoMetrePerSecond<T>(this Quantity<T, YoctoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecond to AttoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecond</param>
    /// <returns>quantity measured in AttoMetrePerSecond</returns>
	public static Quantity<double, AttoMetrePerSecond> ToAttoMetrePerSecond<T>(this Quantity<T, YoctoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecond to ZeptoMetrePerSecond
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecond</param>
    /// <returns>quantity measured in ZeptoMetrePerSecond</returns>
	public static Quantity<double, ZeptoMetrePerSecond> ToZeptoMetrePerSecond<T>(this Quantity<T, YoctoMetrePerSecond> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecond>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
}
}