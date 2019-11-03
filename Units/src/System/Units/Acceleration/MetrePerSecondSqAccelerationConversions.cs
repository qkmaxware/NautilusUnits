using System;
namespace System.Units.Acceleration {
/// <summary>
/// Static class housing si-prefix conversions for the unit "MetrePerSecondSq"
/// </summary>  
public static class MetrePerSecondSqAccelerationConversions {
	/// <summary>
    /// Extension method to convert MetrePerSecondSq to YottaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecondSq</param>
    /// <returns>quantity measured in YottaMetrePerSecondSq</returns>
	public static Quantity<double, YottaMetrePerSecondSq> ToYottaMetrePerSecondSq<T>(this Quantity<T, MetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecondSq to ZettaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecondSq</param>
    /// <returns>quantity measured in ZettaMetrePerSecondSq</returns>
	public static Quantity<double, ZettaMetrePerSecondSq> ToZettaMetrePerSecondSq<T>(this Quantity<T, MetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecondSq to ExaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecondSq</param>
    /// <returns>quantity measured in ExaMetrePerSecondSq</returns>
	public static Quantity<double, ExaMetrePerSecondSq> ToExaMetrePerSecondSq<T>(this Quantity<T, MetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecondSq to PetaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecondSq</param>
    /// <returns>quantity measured in PetaMetrePerSecondSq</returns>
	public static Quantity<double, PetaMetrePerSecondSq> ToPetaMetrePerSecondSq<T>(this Quantity<T, MetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecondSq to TeraMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecondSq</param>
    /// <returns>quantity measured in TeraMetrePerSecondSq</returns>
	public static Quantity<double, TeraMetrePerSecondSq> ToTeraMetrePerSecondSq<T>(this Quantity<T, MetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecondSq to GigaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecondSq</param>
    /// <returns>quantity measured in GigaMetrePerSecondSq</returns>
	public static Quantity<double, GigaMetrePerSecondSq> ToGigaMetrePerSecondSq<T>(this Quantity<T, MetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecondSq to MegaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecondSq</param>
    /// <returns>quantity measured in MegaMetrePerSecondSq</returns>
	public static Quantity<double, MegaMetrePerSecondSq> ToMegaMetrePerSecondSq<T>(this Quantity<T, MetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecondSq to KiloMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecondSq</param>
    /// <returns>quantity measured in KiloMetrePerSecondSq</returns>
	public static Quantity<double, KiloMetrePerSecondSq> ToKiloMetrePerSecondSq<T>(this Quantity<T, MetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecondSq to HectoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecondSq</param>
    /// <returns>quantity measured in HectoMetrePerSecondSq</returns>
	public static Quantity<double, HectoMetrePerSecondSq> ToHectoMetrePerSecondSq<T>(this Quantity<T, MetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecondSq to DekaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecondSq</param>
    /// <returns>quantity measured in DekaMetrePerSecondSq</returns>
	public static Quantity<double, DekaMetrePerSecondSq> ToDekaMetrePerSecondSq<T>(this Quantity<T, MetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecondSq to DeciMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecondSq</param>
    /// <returns>quantity measured in DeciMetrePerSecondSq</returns>
	public static Quantity<double, DeciMetrePerSecondSq> ToDeciMetrePerSecondSq<T>(this Quantity<T, MetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecondSq to CentiMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecondSq</param>
    /// <returns>quantity measured in CentiMetrePerSecondSq</returns>
	public static Quantity<double, CentiMetrePerSecondSq> ToCentiMetrePerSecondSq<T>(this Quantity<T, MetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecondSq to MilliMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecondSq</param>
    /// <returns>quantity measured in MilliMetrePerSecondSq</returns>
	public static Quantity<double, MilliMetrePerSecondSq> ToMilliMetrePerSecondSq<T>(this Quantity<T, MetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecondSq to MicroMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecondSq</param>
    /// <returns>quantity measured in MicroMetrePerSecondSq</returns>
	public static Quantity<double, MicroMetrePerSecondSq> ToMicroMetrePerSecondSq<T>(this Quantity<T, MetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecondSq to NanoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecondSq</param>
    /// <returns>quantity measured in NanoMetrePerSecondSq</returns>
	public static Quantity<double, NanoMetrePerSecondSq> ToNanoMetrePerSecondSq<T>(this Quantity<T, MetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecondSq to PicoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecondSq</param>
    /// <returns>quantity measured in PicoMetrePerSecondSq</returns>
	public static Quantity<double, PicoMetrePerSecondSq> ToPicoMetrePerSecondSq<T>(this Quantity<T, MetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecondSq to FemtoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecondSq</param>
    /// <returns>quantity measured in FemtoMetrePerSecondSq</returns>
	public static Quantity<double, FemtoMetrePerSecondSq> ToFemtoMetrePerSecondSq<T>(this Quantity<T, MetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecondSq to AttoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecondSq</param>
    /// <returns>quantity measured in AttoMetrePerSecondSq</returns>
	public static Quantity<double, AttoMetrePerSecondSq> ToAttoMetrePerSecondSq<T>(this Quantity<T, MetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecondSq to ZeptoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecondSq</param>
    /// <returns>quantity measured in ZeptoMetrePerSecondSq</returns>
	public static Quantity<double, ZeptoMetrePerSecondSq> ToZeptoMetrePerSecondSq<T>(this Quantity<T, MetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert MetrePerSecondSq to YoctoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MetrePerSecondSq</param>
    /// <returns>quantity measured in YoctoMetrePerSecondSq</returns>
	public static Quantity<double, YoctoMetrePerSecondSq> ToYoctoMetrePerSecondSq<T>(this Quantity<T, MetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecondSq to ZettaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecondSq</param>
    /// <returns>quantity measured in ZettaMetrePerSecondSq</returns>
	public static Quantity<double, ZettaMetrePerSecondSq> ToZettaMetrePerSecondSq<T>(this Quantity<T, YottaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecondSq to ExaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecondSq</param>
    /// <returns>quantity measured in ExaMetrePerSecondSq</returns>
	public static Quantity<double, ExaMetrePerSecondSq> ToExaMetrePerSecondSq<T>(this Quantity<T, YottaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecondSq to PetaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecondSq</param>
    /// <returns>quantity measured in PetaMetrePerSecondSq</returns>
	public static Quantity<double, PetaMetrePerSecondSq> ToPetaMetrePerSecondSq<T>(this Quantity<T, YottaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecondSq to TeraMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecondSq</param>
    /// <returns>quantity measured in TeraMetrePerSecondSq</returns>
	public static Quantity<double, TeraMetrePerSecondSq> ToTeraMetrePerSecondSq<T>(this Quantity<T, YottaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecondSq to GigaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecondSq</param>
    /// <returns>quantity measured in GigaMetrePerSecondSq</returns>
	public static Quantity<double, GigaMetrePerSecondSq> ToGigaMetrePerSecondSq<T>(this Quantity<T, YottaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecondSq to MegaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecondSq</param>
    /// <returns>quantity measured in MegaMetrePerSecondSq</returns>
	public static Quantity<double, MegaMetrePerSecondSq> ToMegaMetrePerSecondSq<T>(this Quantity<T, YottaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecondSq to KiloMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecondSq</param>
    /// <returns>quantity measured in KiloMetrePerSecondSq</returns>
	public static Quantity<double, KiloMetrePerSecondSq> ToKiloMetrePerSecondSq<T>(this Quantity<T, YottaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecondSq to HectoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecondSq</param>
    /// <returns>quantity measured in HectoMetrePerSecondSq</returns>
	public static Quantity<double, HectoMetrePerSecondSq> ToHectoMetrePerSecondSq<T>(this Quantity<T, YottaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecondSq to DekaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecondSq</param>
    /// <returns>quantity measured in DekaMetrePerSecondSq</returns>
	public static Quantity<double, DekaMetrePerSecondSq> ToDekaMetrePerSecondSq<T>(this Quantity<T, YottaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecondSq to DeciMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecondSq</param>
    /// <returns>quantity measured in DeciMetrePerSecondSq</returns>
	public static Quantity<double, DeciMetrePerSecondSq> ToDeciMetrePerSecondSq<T>(this Quantity<T, YottaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecondSq to CentiMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecondSq</param>
    /// <returns>quantity measured in CentiMetrePerSecondSq</returns>
	public static Quantity<double, CentiMetrePerSecondSq> ToCentiMetrePerSecondSq<T>(this Quantity<T, YottaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecondSq to MilliMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecondSq</param>
    /// <returns>quantity measured in MilliMetrePerSecondSq</returns>
	public static Quantity<double, MilliMetrePerSecondSq> ToMilliMetrePerSecondSq<T>(this Quantity<T, YottaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecondSq to MicroMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecondSq</param>
    /// <returns>quantity measured in MicroMetrePerSecondSq</returns>
	public static Quantity<double, MicroMetrePerSecondSq> ToMicroMetrePerSecondSq<T>(this Quantity<T, YottaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecondSq to NanoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecondSq</param>
    /// <returns>quantity measured in NanoMetrePerSecondSq</returns>
	public static Quantity<double, NanoMetrePerSecondSq> ToNanoMetrePerSecondSq<T>(this Quantity<T, YottaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecondSq to PicoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecondSq</param>
    /// <returns>quantity measured in PicoMetrePerSecondSq</returns>
	public static Quantity<double, PicoMetrePerSecondSq> ToPicoMetrePerSecondSq<T>(this Quantity<T, YottaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecondSq to FemtoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecondSq</param>
    /// <returns>quantity measured in FemtoMetrePerSecondSq</returns>
	public static Quantity<double, FemtoMetrePerSecondSq> ToFemtoMetrePerSecondSq<T>(this Quantity<T, YottaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecondSq to AttoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecondSq</param>
    /// <returns>quantity measured in AttoMetrePerSecondSq</returns>
	public static Quantity<double, AttoMetrePerSecondSq> ToAttoMetrePerSecondSq<T>(this Quantity<T, YottaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecondSq to ZeptoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecondSq</param>
    /// <returns>quantity measured in ZeptoMetrePerSecondSq</returns>
	public static Quantity<double, ZeptoMetrePerSecondSq> ToZeptoMetrePerSecondSq<T>(this Quantity<T, YottaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetrePerSecondSq to YoctoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YottaMetrePerSecondSq</param>
    /// <returns>quantity measured in YoctoMetrePerSecondSq</returns>
	public static Quantity<double, YoctoMetrePerSecondSq> ToYoctoMetrePerSecondSq<T>(this Quantity<T, YottaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecondSq to YottaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecondSq</param>
    /// <returns>quantity measured in YottaMetrePerSecondSq</returns>
	public static Quantity<double, YottaMetrePerSecondSq> ToYottaMetrePerSecondSq<T>(this Quantity<T, ZettaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecondSq to ExaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecondSq</param>
    /// <returns>quantity measured in ExaMetrePerSecondSq</returns>
	public static Quantity<double, ExaMetrePerSecondSq> ToExaMetrePerSecondSq<T>(this Quantity<T, ZettaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecondSq to PetaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecondSq</param>
    /// <returns>quantity measured in PetaMetrePerSecondSq</returns>
	public static Quantity<double, PetaMetrePerSecondSq> ToPetaMetrePerSecondSq<T>(this Quantity<T, ZettaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecondSq to TeraMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecondSq</param>
    /// <returns>quantity measured in TeraMetrePerSecondSq</returns>
	public static Quantity<double, TeraMetrePerSecondSq> ToTeraMetrePerSecondSq<T>(this Quantity<T, ZettaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecondSq to GigaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecondSq</param>
    /// <returns>quantity measured in GigaMetrePerSecondSq</returns>
	public static Quantity<double, GigaMetrePerSecondSq> ToGigaMetrePerSecondSq<T>(this Quantity<T, ZettaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecondSq to MegaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecondSq</param>
    /// <returns>quantity measured in MegaMetrePerSecondSq</returns>
	public static Quantity<double, MegaMetrePerSecondSq> ToMegaMetrePerSecondSq<T>(this Quantity<T, ZettaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecondSq to KiloMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecondSq</param>
    /// <returns>quantity measured in KiloMetrePerSecondSq</returns>
	public static Quantity<double, KiloMetrePerSecondSq> ToKiloMetrePerSecondSq<T>(this Quantity<T, ZettaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecondSq to HectoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecondSq</param>
    /// <returns>quantity measured in HectoMetrePerSecondSq</returns>
	public static Quantity<double, HectoMetrePerSecondSq> ToHectoMetrePerSecondSq<T>(this Quantity<T, ZettaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecondSq to DekaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecondSq</param>
    /// <returns>quantity measured in DekaMetrePerSecondSq</returns>
	public static Quantity<double, DekaMetrePerSecondSq> ToDekaMetrePerSecondSq<T>(this Quantity<T, ZettaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecondSq to DeciMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecondSq</param>
    /// <returns>quantity measured in DeciMetrePerSecondSq</returns>
	public static Quantity<double, DeciMetrePerSecondSq> ToDeciMetrePerSecondSq<T>(this Quantity<T, ZettaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecondSq to CentiMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecondSq</param>
    /// <returns>quantity measured in CentiMetrePerSecondSq</returns>
	public static Quantity<double, CentiMetrePerSecondSq> ToCentiMetrePerSecondSq<T>(this Quantity<T, ZettaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecondSq to MilliMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecondSq</param>
    /// <returns>quantity measured in MilliMetrePerSecondSq</returns>
	public static Quantity<double, MilliMetrePerSecondSq> ToMilliMetrePerSecondSq<T>(this Quantity<T, ZettaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecondSq to MicroMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecondSq</param>
    /// <returns>quantity measured in MicroMetrePerSecondSq</returns>
	public static Quantity<double, MicroMetrePerSecondSq> ToMicroMetrePerSecondSq<T>(this Quantity<T, ZettaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecondSq to NanoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecondSq</param>
    /// <returns>quantity measured in NanoMetrePerSecondSq</returns>
	public static Quantity<double, NanoMetrePerSecondSq> ToNanoMetrePerSecondSq<T>(this Quantity<T, ZettaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecondSq to PicoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecondSq</param>
    /// <returns>quantity measured in PicoMetrePerSecondSq</returns>
	public static Quantity<double, PicoMetrePerSecondSq> ToPicoMetrePerSecondSq<T>(this Quantity<T, ZettaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecondSq to FemtoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecondSq</param>
    /// <returns>quantity measured in FemtoMetrePerSecondSq</returns>
	public static Quantity<double, FemtoMetrePerSecondSq> ToFemtoMetrePerSecondSq<T>(this Quantity<T, ZettaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecondSq to AttoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecondSq</param>
    /// <returns>quantity measured in AttoMetrePerSecondSq</returns>
	public static Quantity<double, AttoMetrePerSecondSq> ToAttoMetrePerSecondSq<T>(this Quantity<T, ZettaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecondSq to ZeptoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecondSq</param>
    /// <returns>quantity measured in ZeptoMetrePerSecondSq</returns>
	public static Quantity<double, ZeptoMetrePerSecondSq> ToZeptoMetrePerSecondSq<T>(this Quantity<T, ZettaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetrePerSecondSq to YoctoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetrePerSecondSq</param>
    /// <returns>quantity measured in YoctoMetrePerSecondSq</returns>
	public static Quantity<double, YoctoMetrePerSecondSq> ToYoctoMetrePerSecondSq<T>(this Quantity<T, ZettaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecondSq to YottaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecondSq</param>
    /// <returns>quantity measured in YottaMetrePerSecondSq</returns>
	public static Quantity<double, YottaMetrePerSecondSq> ToYottaMetrePerSecondSq<T>(this Quantity<T, ExaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecondSq to ZettaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecondSq</param>
    /// <returns>quantity measured in ZettaMetrePerSecondSq</returns>
	public static Quantity<double, ZettaMetrePerSecondSq> ToZettaMetrePerSecondSq<T>(this Quantity<T, ExaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecondSq to PetaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecondSq</param>
    /// <returns>quantity measured in PetaMetrePerSecondSq</returns>
	public static Quantity<double, PetaMetrePerSecondSq> ToPetaMetrePerSecondSq<T>(this Quantity<T, ExaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecondSq to TeraMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecondSq</param>
    /// <returns>quantity measured in TeraMetrePerSecondSq</returns>
	public static Quantity<double, TeraMetrePerSecondSq> ToTeraMetrePerSecondSq<T>(this Quantity<T, ExaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecondSq to GigaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecondSq</param>
    /// <returns>quantity measured in GigaMetrePerSecondSq</returns>
	public static Quantity<double, GigaMetrePerSecondSq> ToGigaMetrePerSecondSq<T>(this Quantity<T, ExaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecondSq to MegaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecondSq</param>
    /// <returns>quantity measured in MegaMetrePerSecondSq</returns>
	public static Quantity<double, MegaMetrePerSecondSq> ToMegaMetrePerSecondSq<T>(this Quantity<T, ExaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecondSq to KiloMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecondSq</param>
    /// <returns>quantity measured in KiloMetrePerSecondSq</returns>
	public static Quantity<double, KiloMetrePerSecondSq> ToKiloMetrePerSecondSq<T>(this Quantity<T, ExaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecondSq to HectoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecondSq</param>
    /// <returns>quantity measured in HectoMetrePerSecondSq</returns>
	public static Quantity<double, HectoMetrePerSecondSq> ToHectoMetrePerSecondSq<T>(this Quantity<T, ExaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecondSq to DekaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecondSq</param>
    /// <returns>quantity measured in DekaMetrePerSecondSq</returns>
	public static Quantity<double, DekaMetrePerSecondSq> ToDekaMetrePerSecondSq<T>(this Quantity<T, ExaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecondSq to DeciMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecondSq</param>
    /// <returns>quantity measured in DeciMetrePerSecondSq</returns>
	public static Quantity<double, DeciMetrePerSecondSq> ToDeciMetrePerSecondSq<T>(this Quantity<T, ExaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecondSq to CentiMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecondSq</param>
    /// <returns>quantity measured in CentiMetrePerSecondSq</returns>
	public static Quantity<double, CentiMetrePerSecondSq> ToCentiMetrePerSecondSq<T>(this Quantity<T, ExaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecondSq to MilliMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecondSq</param>
    /// <returns>quantity measured in MilliMetrePerSecondSq</returns>
	public static Quantity<double, MilliMetrePerSecondSq> ToMilliMetrePerSecondSq<T>(this Quantity<T, ExaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecondSq to MicroMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecondSq</param>
    /// <returns>quantity measured in MicroMetrePerSecondSq</returns>
	public static Quantity<double, MicroMetrePerSecondSq> ToMicroMetrePerSecondSq<T>(this Quantity<T, ExaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecondSq to NanoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecondSq</param>
    /// <returns>quantity measured in NanoMetrePerSecondSq</returns>
	public static Quantity<double, NanoMetrePerSecondSq> ToNanoMetrePerSecondSq<T>(this Quantity<T, ExaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecondSq to PicoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecondSq</param>
    /// <returns>quantity measured in PicoMetrePerSecondSq</returns>
	public static Quantity<double, PicoMetrePerSecondSq> ToPicoMetrePerSecondSq<T>(this Quantity<T, ExaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecondSq to FemtoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecondSq</param>
    /// <returns>quantity measured in FemtoMetrePerSecondSq</returns>
	public static Quantity<double, FemtoMetrePerSecondSq> ToFemtoMetrePerSecondSq<T>(this Quantity<T, ExaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecondSq to AttoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecondSq</param>
    /// <returns>quantity measured in AttoMetrePerSecondSq</returns>
	public static Quantity<double, AttoMetrePerSecondSq> ToAttoMetrePerSecondSq<T>(this Quantity<T, ExaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecondSq to ZeptoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecondSq</param>
    /// <returns>quantity measured in ZeptoMetrePerSecondSq</returns>
	public static Quantity<double, ZeptoMetrePerSecondSq> ToZeptoMetrePerSecondSq<T>(this Quantity<T, ExaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetrePerSecondSq to YoctoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ExaMetrePerSecondSq</param>
    /// <returns>quantity measured in YoctoMetrePerSecondSq</returns>
	public static Quantity<double, YoctoMetrePerSecondSq> ToYoctoMetrePerSecondSq<T>(this Quantity<T, ExaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecondSq to YottaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecondSq</param>
    /// <returns>quantity measured in YottaMetrePerSecondSq</returns>
	public static Quantity<double, YottaMetrePerSecondSq> ToYottaMetrePerSecondSq<T>(this Quantity<T, PetaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecondSq to ZettaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecondSq</param>
    /// <returns>quantity measured in ZettaMetrePerSecondSq</returns>
	public static Quantity<double, ZettaMetrePerSecondSq> ToZettaMetrePerSecondSq<T>(this Quantity<T, PetaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecondSq to ExaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecondSq</param>
    /// <returns>quantity measured in ExaMetrePerSecondSq</returns>
	public static Quantity<double, ExaMetrePerSecondSq> ToExaMetrePerSecondSq<T>(this Quantity<T, PetaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecondSq to TeraMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecondSq</param>
    /// <returns>quantity measured in TeraMetrePerSecondSq</returns>
	public static Quantity<double, TeraMetrePerSecondSq> ToTeraMetrePerSecondSq<T>(this Quantity<T, PetaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecondSq to GigaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecondSq</param>
    /// <returns>quantity measured in GigaMetrePerSecondSq</returns>
	public static Quantity<double, GigaMetrePerSecondSq> ToGigaMetrePerSecondSq<T>(this Quantity<T, PetaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecondSq to MegaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecondSq</param>
    /// <returns>quantity measured in MegaMetrePerSecondSq</returns>
	public static Quantity<double, MegaMetrePerSecondSq> ToMegaMetrePerSecondSq<T>(this Quantity<T, PetaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecondSq to KiloMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecondSq</param>
    /// <returns>quantity measured in KiloMetrePerSecondSq</returns>
	public static Quantity<double, KiloMetrePerSecondSq> ToKiloMetrePerSecondSq<T>(this Quantity<T, PetaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecondSq to HectoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecondSq</param>
    /// <returns>quantity measured in HectoMetrePerSecondSq</returns>
	public static Quantity<double, HectoMetrePerSecondSq> ToHectoMetrePerSecondSq<T>(this Quantity<T, PetaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecondSq to DekaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecondSq</param>
    /// <returns>quantity measured in DekaMetrePerSecondSq</returns>
	public static Quantity<double, DekaMetrePerSecondSq> ToDekaMetrePerSecondSq<T>(this Quantity<T, PetaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecondSq to DeciMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecondSq</param>
    /// <returns>quantity measured in DeciMetrePerSecondSq</returns>
	public static Quantity<double, DeciMetrePerSecondSq> ToDeciMetrePerSecondSq<T>(this Quantity<T, PetaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecondSq to CentiMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecondSq</param>
    /// <returns>quantity measured in CentiMetrePerSecondSq</returns>
	public static Quantity<double, CentiMetrePerSecondSq> ToCentiMetrePerSecondSq<T>(this Quantity<T, PetaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecondSq to MilliMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecondSq</param>
    /// <returns>quantity measured in MilliMetrePerSecondSq</returns>
	public static Quantity<double, MilliMetrePerSecondSq> ToMilliMetrePerSecondSq<T>(this Quantity<T, PetaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecondSq to MicroMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecondSq</param>
    /// <returns>quantity measured in MicroMetrePerSecondSq</returns>
	public static Quantity<double, MicroMetrePerSecondSq> ToMicroMetrePerSecondSq<T>(this Quantity<T, PetaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecondSq to NanoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecondSq</param>
    /// <returns>quantity measured in NanoMetrePerSecondSq</returns>
	public static Quantity<double, NanoMetrePerSecondSq> ToNanoMetrePerSecondSq<T>(this Quantity<T, PetaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecondSq to PicoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecondSq</param>
    /// <returns>quantity measured in PicoMetrePerSecondSq</returns>
	public static Quantity<double, PicoMetrePerSecondSq> ToPicoMetrePerSecondSq<T>(this Quantity<T, PetaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecondSq to FemtoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecondSq</param>
    /// <returns>quantity measured in FemtoMetrePerSecondSq</returns>
	public static Quantity<double, FemtoMetrePerSecondSq> ToFemtoMetrePerSecondSq<T>(this Quantity<T, PetaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecondSq to AttoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecondSq</param>
    /// <returns>quantity measured in AttoMetrePerSecondSq</returns>
	public static Quantity<double, AttoMetrePerSecondSq> ToAttoMetrePerSecondSq<T>(this Quantity<T, PetaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecondSq to ZeptoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecondSq</param>
    /// <returns>quantity measured in ZeptoMetrePerSecondSq</returns>
	public static Quantity<double, ZeptoMetrePerSecondSq> ToZeptoMetrePerSecondSq<T>(this Quantity<T, PetaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetrePerSecondSq to YoctoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PetaMetrePerSecondSq</param>
    /// <returns>quantity measured in YoctoMetrePerSecondSq</returns>
	public static Quantity<double, YoctoMetrePerSecondSq> ToYoctoMetrePerSecondSq<T>(this Quantity<T, PetaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecondSq to YottaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecondSq</param>
    /// <returns>quantity measured in YottaMetrePerSecondSq</returns>
	public static Quantity<double, YottaMetrePerSecondSq> ToYottaMetrePerSecondSq<T>(this Quantity<T, TeraMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecondSq to ZettaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecondSq</param>
    /// <returns>quantity measured in ZettaMetrePerSecondSq</returns>
	public static Quantity<double, ZettaMetrePerSecondSq> ToZettaMetrePerSecondSq<T>(this Quantity<T, TeraMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecondSq to ExaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecondSq</param>
    /// <returns>quantity measured in ExaMetrePerSecondSq</returns>
	public static Quantity<double, ExaMetrePerSecondSq> ToExaMetrePerSecondSq<T>(this Quantity<T, TeraMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecondSq to PetaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecondSq</param>
    /// <returns>quantity measured in PetaMetrePerSecondSq</returns>
	public static Quantity<double, PetaMetrePerSecondSq> ToPetaMetrePerSecondSq<T>(this Quantity<T, TeraMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecondSq to GigaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecondSq</param>
    /// <returns>quantity measured in GigaMetrePerSecondSq</returns>
	public static Quantity<double, GigaMetrePerSecondSq> ToGigaMetrePerSecondSq<T>(this Quantity<T, TeraMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecondSq to MegaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecondSq</param>
    /// <returns>quantity measured in MegaMetrePerSecondSq</returns>
	public static Quantity<double, MegaMetrePerSecondSq> ToMegaMetrePerSecondSq<T>(this Quantity<T, TeraMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecondSq to KiloMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecondSq</param>
    /// <returns>quantity measured in KiloMetrePerSecondSq</returns>
	public static Quantity<double, KiloMetrePerSecondSq> ToKiloMetrePerSecondSq<T>(this Quantity<T, TeraMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecondSq to HectoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecondSq</param>
    /// <returns>quantity measured in HectoMetrePerSecondSq</returns>
	public static Quantity<double, HectoMetrePerSecondSq> ToHectoMetrePerSecondSq<T>(this Quantity<T, TeraMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecondSq to DekaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecondSq</param>
    /// <returns>quantity measured in DekaMetrePerSecondSq</returns>
	public static Quantity<double, DekaMetrePerSecondSq> ToDekaMetrePerSecondSq<T>(this Quantity<T, TeraMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecondSq to DeciMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecondSq</param>
    /// <returns>quantity measured in DeciMetrePerSecondSq</returns>
	public static Quantity<double, DeciMetrePerSecondSq> ToDeciMetrePerSecondSq<T>(this Quantity<T, TeraMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecondSq to CentiMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecondSq</param>
    /// <returns>quantity measured in CentiMetrePerSecondSq</returns>
	public static Quantity<double, CentiMetrePerSecondSq> ToCentiMetrePerSecondSq<T>(this Quantity<T, TeraMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecondSq to MilliMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecondSq</param>
    /// <returns>quantity measured in MilliMetrePerSecondSq</returns>
	public static Quantity<double, MilliMetrePerSecondSq> ToMilliMetrePerSecondSq<T>(this Quantity<T, TeraMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecondSq to MicroMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecondSq</param>
    /// <returns>quantity measured in MicroMetrePerSecondSq</returns>
	public static Quantity<double, MicroMetrePerSecondSq> ToMicroMetrePerSecondSq<T>(this Quantity<T, TeraMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecondSq to NanoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecondSq</param>
    /// <returns>quantity measured in NanoMetrePerSecondSq</returns>
	public static Quantity<double, NanoMetrePerSecondSq> ToNanoMetrePerSecondSq<T>(this Quantity<T, TeraMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecondSq to PicoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecondSq</param>
    /// <returns>quantity measured in PicoMetrePerSecondSq</returns>
	public static Quantity<double, PicoMetrePerSecondSq> ToPicoMetrePerSecondSq<T>(this Quantity<T, TeraMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecondSq to FemtoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecondSq</param>
    /// <returns>quantity measured in FemtoMetrePerSecondSq</returns>
	public static Quantity<double, FemtoMetrePerSecondSq> ToFemtoMetrePerSecondSq<T>(this Quantity<T, TeraMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecondSq to AttoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecondSq</param>
    /// <returns>quantity measured in AttoMetrePerSecondSq</returns>
	public static Quantity<double, AttoMetrePerSecondSq> ToAttoMetrePerSecondSq<T>(this Quantity<T, TeraMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecondSq to ZeptoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecondSq</param>
    /// <returns>quantity measured in ZeptoMetrePerSecondSq</returns>
	public static Quantity<double, ZeptoMetrePerSecondSq> ToZeptoMetrePerSecondSq<T>(this Quantity<T, TeraMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetrePerSecondSq to YoctoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in TeraMetrePerSecondSq</param>
    /// <returns>quantity measured in YoctoMetrePerSecondSq</returns>
	public static Quantity<double, YoctoMetrePerSecondSq> ToYoctoMetrePerSecondSq<T>(this Quantity<T, TeraMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecondSq to YottaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecondSq</param>
    /// <returns>quantity measured in YottaMetrePerSecondSq</returns>
	public static Quantity<double, YottaMetrePerSecondSq> ToYottaMetrePerSecondSq<T>(this Quantity<T, GigaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecondSq to ZettaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecondSq</param>
    /// <returns>quantity measured in ZettaMetrePerSecondSq</returns>
	public static Quantity<double, ZettaMetrePerSecondSq> ToZettaMetrePerSecondSq<T>(this Quantity<T, GigaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecondSq to ExaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecondSq</param>
    /// <returns>quantity measured in ExaMetrePerSecondSq</returns>
	public static Quantity<double, ExaMetrePerSecondSq> ToExaMetrePerSecondSq<T>(this Quantity<T, GigaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecondSq to PetaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecondSq</param>
    /// <returns>quantity measured in PetaMetrePerSecondSq</returns>
	public static Quantity<double, PetaMetrePerSecondSq> ToPetaMetrePerSecondSq<T>(this Quantity<T, GigaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecondSq to TeraMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecondSq</param>
    /// <returns>quantity measured in TeraMetrePerSecondSq</returns>
	public static Quantity<double, TeraMetrePerSecondSq> ToTeraMetrePerSecondSq<T>(this Quantity<T, GigaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecondSq to MegaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecondSq</param>
    /// <returns>quantity measured in MegaMetrePerSecondSq</returns>
	public static Quantity<double, MegaMetrePerSecondSq> ToMegaMetrePerSecondSq<T>(this Quantity<T, GigaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecondSq to KiloMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecondSq</param>
    /// <returns>quantity measured in KiloMetrePerSecondSq</returns>
	public static Quantity<double, KiloMetrePerSecondSq> ToKiloMetrePerSecondSq<T>(this Quantity<T, GigaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecondSq to HectoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecondSq</param>
    /// <returns>quantity measured in HectoMetrePerSecondSq</returns>
	public static Quantity<double, HectoMetrePerSecondSq> ToHectoMetrePerSecondSq<T>(this Quantity<T, GigaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecondSq to DekaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecondSq</param>
    /// <returns>quantity measured in DekaMetrePerSecondSq</returns>
	public static Quantity<double, DekaMetrePerSecondSq> ToDekaMetrePerSecondSq<T>(this Quantity<T, GigaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecondSq to DeciMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecondSq</param>
    /// <returns>quantity measured in DeciMetrePerSecondSq</returns>
	public static Quantity<double, DeciMetrePerSecondSq> ToDeciMetrePerSecondSq<T>(this Quantity<T, GigaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecondSq to CentiMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecondSq</param>
    /// <returns>quantity measured in CentiMetrePerSecondSq</returns>
	public static Quantity<double, CentiMetrePerSecondSq> ToCentiMetrePerSecondSq<T>(this Quantity<T, GigaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecondSq to MilliMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecondSq</param>
    /// <returns>quantity measured in MilliMetrePerSecondSq</returns>
	public static Quantity<double, MilliMetrePerSecondSq> ToMilliMetrePerSecondSq<T>(this Quantity<T, GigaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecondSq to MicroMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecondSq</param>
    /// <returns>quantity measured in MicroMetrePerSecondSq</returns>
	public static Quantity<double, MicroMetrePerSecondSq> ToMicroMetrePerSecondSq<T>(this Quantity<T, GigaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecondSq to NanoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecondSq</param>
    /// <returns>quantity measured in NanoMetrePerSecondSq</returns>
	public static Quantity<double, NanoMetrePerSecondSq> ToNanoMetrePerSecondSq<T>(this Quantity<T, GigaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecondSq to PicoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecondSq</param>
    /// <returns>quantity measured in PicoMetrePerSecondSq</returns>
	public static Quantity<double, PicoMetrePerSecondSq> ToPicoMetrePerSecondSq<T>(this Quantity<T, GigaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecondSq to FemtoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecondSq</param>
    /// <returns>quantity measured in FemtoMetrePerSecondSq</returns>
	public static Quantity<double, FemtoMetrePerSecondSq> ToFemtoMetrePerSecondSq<T>(this Quantity<T, GigaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecondSq to AttoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecondSq</param>
    /// <returns>quantity measured in AttoMetrePerSecondSq</returns>
	public static Quantity<double, AttoMetrePerSecondSq> ToAttoMetrePerSecondSq<T>(this Quantity<T, GigaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecondSq to ZeptoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecondSq</param>
    /// <returns>quantity measured in ZeptoMetrePerSecondSq</returns>
	public static Quantity<double, ZeptoMetrePerSecondSq> ToZeptoMetrePerSecondSq<T>(this Quantity<T, GigaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetrePerSecondSq to YoctoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in GigaMetrePerSecondSq</param>
    /// <returns>quantity measured in YoctoMetrePerSecondSq</returns>
	public static Quantity<double, YoctoMetrePerSecondSq> ToYoctoMetrePerSecondSq<T>(this Quantity<T, GigaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecondSq to YottaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecondSq</param>
    /// <returns>quantity measured in YottaMetrePerSecondSq</returns>
	public static Quantity<double, YottaMetrePerSecondSq> ToYottaMetrePerSecondSq<T>(this Quantity<T, MegaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecondSq to ZettaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecondSq</param>
    /// <returns>quantity measured in ZettaMetrePerSecondSq</returns>
	public static Quantity<double, ZettaMetrePerSecondSq> ToZettaMetrePerSecondSq<T>(this Quantity<T, MegaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecondSq to ExaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecondSq</param>
    /// <returns>quantity measured in ExaMetrePerSecondSq</returns>
	public static Quantity<double, ExaMetrePerSecondSq> ToExaMetrePerSecondSq<T>(this Quantity<T, MegaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecondSq to PetaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecondSq</param>
    /// <returns>quantity measured in PetaMetrePerSecondSq</returns>
	public static Quantity<double, PetaMetrePerSecondSq> ToPetaMetrePerSecondSq<T>(this Quantity<T, MegaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecondSq to TeraMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecondSq</param>
    /// <returns>quantity measured in TeraMetrePerSecondSq</returns>
	public static Quantity<double, TeraMetrePerSecondSq> ToTeraMetrePerSecondSq<T>(this Quantity<T, MegaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecondSq to GigaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecondSq</param>
    /// <returns>quantity measured in GigaMetrePerSecondSq</returns>
	public static Quantity<double, GigaMetrePerSecondSq> ToGigaMetrePerSecondSq<T>(this Quantity<T, MegaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecondSq to KiloMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecondSq</param>
    /// <returns>quantity measured in KiloMetrePerSecondSq</returns>
	public static Quantity<double, KiloMetrePerSecondSq> ToKiloMetrePerSecondSq<T>(this Quantity<T, MegaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecondSq to HectoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecondSq</param>
    /// <returns>quantity measured in HectoMetrePerSecondSq</returns>
	public static Quantity<double, HectoMetrePerSecondSq> ToHectoMetrePerSecondSq<T>(this Quantity<T, MegaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecondSq to DekaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecondSq</param>
    /// <returns>quantity measured in DekaMetrePerSecondSq</returns>
	public static Quantity<double, DekaMetrePerSecondSq> ToDekaMetrePerSecondSq<T>(this Quantity<T, MegaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecondSq to DeciMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecondSq</param>
    /// <returns>quantity measured in DeciMetrePerSecondSq</returns>
	public static Quantity<double, DeciMetrePerSecondSq> ToDeciMetrePerSecondSq<T>(this Quantity<T, MegaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecondSq to CentiMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecondSq</param>
    /// <returns>quantity measured in CentiMetrePerSecondSq</returns>
	public static Quantity<double, CentiMetrePerSecondSq> ToCentiMetrePerSecondSq<T>(this Quantity<T, MegaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecondSq to MilliMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecondSq</param>
    /// <returns>quantity measured in MilliMetrePerSecondSq</returns>
	public static Quantity<double, MilliMetrePerSecondSq> ToMilliMetrePerSecondSq<T>(this Quantity<T, MegaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecondSq to MicroMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecondSq</param>
    /// <returns>quantity measured in MicroMetrePerSecondSq</returns>
	public static Quantity<double, MicroMetrePerSecondSq> ToMicroMetrePerSecondSq<T>(this Quantity<T, MegaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecondSq to NanoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecondSq</param>
    /// <returns>quantity measured in NanoMetrePerSecondSq</returns>
	public static Quantity<double, NanoMetrePerSecondSq> ToNanoMetrePerSecondSq<T>(this Quantity<T, MegaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecondSq to PicoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecondSq</param>
    /// <returns>quantity measured in PicoMetrePerSecondSq</returns>
	public static Quantity<double, PicoMetrePerSecondSq> ToPicoMetrePerSecondSq<T>(this Quantity<T, MegaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecondSq to FemtoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecondSq</param>
    /// <returns>quantity measured in FemtoMetrePerSecondSq</returns>
	public static Quantity<double, FemtoMetrePerSecondSq> ToFemtoMetrePerSecondSq<T>(this Quantity<T, MegaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecondSq to AttoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecondSq</param>
    /// <returns>quantity measured in AttoMetrePerSecondSq</returns>
	public static Quantity<double, AttoMetrePerSecondSq> ToAttoMetrePerSecondSq<T>(this Quantity<T, MegaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecondSq to ZeptoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecondSq</param>
    /// <returns>quantity measured in ZeptoMetrePerSecondSq</returns>
	public static Quantity<double, ZeptoMetrePerSecondSq> ToZeptoMetrePerSecondSq<T>(this Quantity<T, MegaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetrePerSecondSq to YoctoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MegaMetrePerSecondSq</param>
    /// <returns>quantity measured in YoctoMetrePerSecondSq</returns>
	public static Quantity<double, YoctoMetrePerSecondSq> ToYoctoMetrePerSecondSq<T>(this Quantity<T, MegaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecondSq to YottaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecondSq</param>
    /// <returns>quantity measured in YottaMetrePerSecondSq</returns>
	public static Quantity<double, YottaMetrePerSecondSq> ToYottaMetrePerSecondSq<T>(this Quantity<T, KiloMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecondSq to ZettaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecondSq</param>
    /// <returns>quantity measured in ZettaMetrePerSecondSq</returns>
	public static Quantity<double, ZettaMetrePerSecondSq> ToZettaMetrePerSecondSq<T>(this Quantity<T, KiloMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecondSq to ExaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecondSq</param>
    /// <returns>quantity measured in ExaMetrePerSecondSq</returns>
	public static Quantity<double, ExaMetrePerSecondSq> ToExaMetrePerSecondSq<T>(this Quantity<T, KiloMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecondSq to PetaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecondSq</param>
    /// <returns>quantity measured in PetaMetrePerSecondSq</returns>
	public static Quantity<double, PetaMetrePerSecondSq> ToPetaMetrePerSecondSq<T>(this Quantity<T, KiloMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecondSq to TeraMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecondSq</param>
    /// <returns>quantity measured in TeraMetrePerSecondSq</returns>
	public static Quantity<double, TeraMetrePerSecondSq> ToTeraMetrePerSecondSq<T>(this Quantity<T, KiloMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecondSq to GigaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecondSq</param>
    /// <returns>quantity measured in GigaMetrePerSecondSq</returns>
	public static Quantity<double, GigaMetrePerSecondSq> ToGigaMetrePerSecondSq<T>(this Quantity<T, KiloMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecondSq to MegaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecondSq</param>
    /// <returns>quantity measured in MegaMetrePerSecondSq</returns>
	public static Quantity<double, MegaMetrePerSecondSq> ToMegaMetrePerSecondSq<T>(this Quantity<T, KiloMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecondSq to HectoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecondSq</param>
    /// <returns>quantity measured in HectoMetrePerSecondSq</returns>
	public static Quantity<double, HectoMetrePerSecondSq> ToHectoMetrePerSecondSq<T>(this Quantity<T, KiloMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecondSq to DekaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecondSq</param>
    /// <returns>quantity measured in DekaMetrePerSecondSq</returns>
	public static Quantity<double, DekaMetrePerSecondSq> ToDekaMetrePerSecondSq<T>(this Quantity<T, KiloMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecondSq to DeciMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecondSq</param>
    /// <returns>quantity measured in DeciMetrePerSecondSq</returns>
	public static Quantity<double, DeciMetrePerSecondSq> ToDeciMetrePerSecondSq<T>(this Quantity<T, KiloMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecondSq to CentiMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecondSq</param>
    /// <returns>quantity measured in CentiMetrePerSecondSq</returns>
	public static Quantity<double, CentiMetrePerSecondSq> ToCentiMetrePerSecondSq<T>(this Quantity<T, KiloMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecondSq to MilliMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecondSq</param>
    /// <returns>quantity measured in MilliMetrePerSecondSq</returns>
	public static Quantity<double, MilliMetrePerSecondSq> ToMilliMetrePerSecondSq<T>(this Quantity<T, KiloMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecondSq to MicroMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecondSq</param>
    /// <returns>quantity measured in MicroMetrePerSecondSq</returns>
	public static Quantity<double, MicroMetrePerSecondSq> ToMicroMetrePerSecondSq<T>(this Quantity<T, KiloMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecondSq to NanoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecondSq</param>
    /// <returns>quantity measured in NanoMetrePerSecondSq</returns>
	public static Quantity<double, NanoMetrePerSecondSq> ToNanoMetrePerSecondSq<T>(this Quantity<T, KiloMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecondSq to PicoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecondSq</param>
    /// <returns>quantity measured in PicoMetrePerSecondSq</returns>
	public static Quantity<double, PicoMetrePerSecondSq> ToPicoMetrePerSecondSq<T>(this Quantity<T, KiloMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecondSq to FemtoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecondSq</param>
    /// <returns>quantity measured in FemtoMetrePerSecondSq</returns>
	public static Quantity<double, FemtoMetrePerSecondSq> ToFemtoMetrePerSecondSq<T>(this Quantity<T, KiloMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecondSq to AttoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecondSq</param>
    /// <returns>quantity measured in AttoMetrePerSecondSq</returns>
	public static Quantity<double, AttoMetrePerSecondSq> ToAttoMetrePerSecondSq<T>(this Quantity<T, KiloMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecondSq to ZeptoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecondSq</param>
    /// <returns>quantity measured in ZeptoMetrePerSecondSq</returns>
	public static Quantity<double, ZeptoMetrePerSecondSq> ToZeptoMetrePerSecondSq<T>(this Quantity<T, KiloMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetrePerSecondSq to YoctoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in KiloMetrePerSecondSq</param>
    /// <returns>quantity measured in YoctoMetrePerSecondSq</returns>
	public static Quantity<double, YoctoMetrePerSecondSq> ToYoctoMetrePerSecondSq<T>(this Quantity<T, KiloMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecondSq to YottaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecondSq</param>
    /// <returns>quantity measured in YottaMetrePerSecondSq</returns>
	public static Quantity<double, YottaMetrePerSecondSq> ToYottaMetrePerSecondSq<T>(this Quantity<T, HectoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecondSq to ZettaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecondSq</param>
    /// <returns>quantity measured in ZettaMetrePerSecondSq</returns>
	public static Quantity<double, ZettaMetrePerSecondSq> ToZettaMetrePerSecondSq<T>(this Quantity<T, HectoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecondSq to ExaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecondSq</param>
    /// <returns>quantity measured in ExaMetrePerSecondSq</returns>
	public static Quantity<double, ExaMetrePerSecondSq> ToExaMetrePerSecondSq<T>(this Quantity<T, HectoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecondSq to PetaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecondSq</param>
    /// <returns>quantity measured in PetaMetrePerSecondSq</returns>
	public static Quantity<double, PetaMetrePerSecondSq> ToPetaMetrePerSecondSq<T>(this Quantity<T, HectoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecondSq to TeraMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecondSq</param>
    /// <returns>quantity measured in TeraMetrePerSecondSq</returns>
	public static Quantity<double, TeraMetrePerSecondSq> ToTeraMetrePerSecondSq<T>(this Quantity<T, HectoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecondSq to GigaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecondSq</param>
    /// <returns>quantity measured in GigaMetrePerSecondSq</returns>
	public static Quantity<double, GigaMetrePerSecondSq> ToGigaMetrePerSecondSq<T>(this Quantity<T, HectoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecondSq to MegaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecondSq</param>
    /// <returns>quantity measured in MegaMetrePerSecondSq</returns>
	public static Quantity<double, MegaMetrePerSecondSq> ToMegaMetrePerSecondSq<T>(this Quantity<T, HectoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecondSq to KiloMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecondSq</param>
    /// <returns>quantity measured in KiloMetrePerSecondSq</returns>
	public static Quantity<double, KiloMetrePerSecondSq> ToKiloMetrePerSecondSq<T>(this Quantity<T, HectoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecondSq to DekaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecondSq</param>
    /// <returns>quantity measured in DekaMetrePerSecondSq</returns>
	public static Quantity<double, DekaMetrePerSecondSq> ToDekaMetrePerSecondSq<T>(this Quantity<T, HectoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecondSq to DeciMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecondSq</param>
    /// <returns>quantity measured in DeciMetrePerSecondSq</returns>
	public static Quantity<double, DeciMetrePerSecondSq> ToDeciMetrePerSecondSq<T>(this Quantity<T, HectoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecondSq to CentiMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecondSq</param>
    /// <returns>quantity measured in CentiMetrePerSecondSq</returns>
	public static Quantity<double, CentiMetrePerSecondSq> ToCentiMetrePerSecondSq<T>(this Quantity<T, HectoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecondSq to MilliMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecondSq</param>
    /// <returns>quantity measured in MilliMetrePerSecondSq</returns>
	public static Quantity<double, MilliMetrePerSecondSq> ToMilliMetrePerSecondSq<T>(this Quantity<T, HectoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecondSq to MicroMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecondSq</param>
    /// <returns>quantity measured in MicroMetrePerSecondSq</returns>
	public static Quantity<double, MicroMetrePerSecondSq> ToMicroMetrePerSecondSq<T>(this Quantity<T, HectoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecondSq to NanoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecondSq</param>
    /// <returns>quantity measured in NanoMetrePerSecondSq</returns>
	public static Quantity<double, NanoMetrePerSecondSq> ToNanoMetrePerSecondSq<T>(this Quantity<T, HectoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecondSq to PicoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecondSq</param>
    /// <returns>quantity measured in PicoMetrePerSecondSq</returns>
	public static Quantity<double, PicoMetrePerSecondSq> ToPicoMetrePerSecondSq<T>(this Quantity<T, HectoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecondSq to FemtoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecondSq</param>
    /// <returns>quantity measured in FemtoMetrePerSecondSq</returns>
	public static Quantity<double, FemtoMetrePerSecondSq> ToFemtoMetrePerSecondSq<T>(this Quantity<T, HectoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecondSq to AttoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecondSq</param>
    /// <returns>quantity measured in AttoMetrePerSecondSq</returns>
	public static Quantity<double, AttoMetrePerSecondSq> ToAttoMetrePerSecondSq<T>(this Quantity<T, HectoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecondSq to ZeptoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecondSq</param>
    /// <returns>quantity measured in ZeptoMetrePerSecondSq</returns>
	public static Quantity<double, ZeptoMetrePerSecondSq> ToZeptoMetrePerSecondSq<T>(this Quantity<T, HectoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetrePerSecondSq to YoctoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in HectoMetrePerSecondSq</param>
    /// <returns>quantity measured in YoctoMetrePerSecondSq</returns>
	public static Quantity<double, YoctoMetrePerSecondSq> ToYoctoMetrePerSecondSq<T>(this Quantity<T, HectoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecondSq to YottaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecondSq</param>
    /// <returns>quantity measured in YottaMetrePerSecondSq</returns>
	public static Quantity<double, YottaMetrePerSecondSq> ToYottaMetrePerSecondSq<T>(this Quantity<T, DekaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecondSq to ZettaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecondSq</param>
    /// <returns>quantity measured in ZettaMetrePerSecondSq</returns>
	public static Quantity<double, ZettaMetrePerSecondSq> ToZettaMetrePerSecondSq<T>(this Quantity<T, DekaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecondSq to ExaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecondSq</param>
    /// <returns>quantity measured in ExaMetrePerSecondSq</returns>
	public static Quantity<double, ExaMetrePerSecondSq> ToExaMetrePerSecondSq<T>(this Quantity<T, DekaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecondSq to PetaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecondSq</param>
    /// <returns>quantity measured in PetaMetrePerSecondSq</returns>
	public static Quantity<double, PetaMetrePerSecondSq> ToPetaMetrePerSecondSq<T>(this Quantity<T, DekaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecondSq to TeraMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecondSq</param>
    /// <returns>quantity measured in TeraMetrePerSecondSq</returns>
	public static Quantity<double, TeraMetrePerSecondSq> ToTeraMetrePerSecondSq<T>(this Quantity<T, DekaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecondSq to GigaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecondSq</param>
    /// <returns>quantity measured in GigaMetrePerSecondSq</returns>
	public static Quantity<double, GigaMetrePerSecondSq> ToGigaMetrePerSecondSq<T>(this Quantity<T, DekaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecondSq to MegaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecondSq</param>
    /// <returns>quantity measured in MegaMetrePerSecondSq</returns>
	public static Quantity<double, MegaMetrePerSecondSq> ToMegaMetrePerSecondSq<T>(this Quantity<T, DekaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecondSq to KiloMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecondSq</param>
    /// <returns>quantity measured in KiloMetrePerSecondSq</returns>
	public static Quantity<double, KiloMetrePerSecondSq> ToKiloMetrePerSecondSq<T>(this Quantity<T, DekaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecondSq to HectoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecondSq</param>
    /// <returns>quantity measured in HectoMetrePerSecondSq</returns>
	public static Quantity<double, HectoMetrePerSecondSq> ToHectoMetrePerSecondSq<T>(this Quantity<T, DekaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecondSq to DeciMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecondSq</param>
    /// <returns>quantity measured in DeciMetrePerSecondSq</returns>
	public static Quantity<double, DeciMetrePerSecondSq> ToDeciMetrePerSecondSq<T>(this Quantity<T, DekaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecondSq to CentiMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecondSq</param>
    /// <returns>quantity measured in CentiMetrePerSecondSq</returns>
	public static Quantity<double, CentiMetrePerSecondSq> ToCentiMetrePerSecondSq<T>(this Quantity<T, DekaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecondSq to MilliMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecondSq</param>
    /// <returns>quantity measured in MilliMetrePerSecondSq</returns>
	public static Quantity<double, MilliMetrePerSecondSq> ToMilliMetrePerSecondSq<T>(this Quantity<T, DekaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecondSq to MicroMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecondSq</param>
    /// <returns>quantity measured in MicroMetrePerSecondSq</returns>
	public static Quantity<double, MicroMetrePerSecondSq> ToMicroMetrePerSecondSq<T>(this Quantity<T, DekaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecondSq to NanoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecondSq</param>
    /// <returns>quantity measured in NanoMetrePerSecondSq</returns>
	public static Quantity<double, NanoMetrePerSecondSq> ToNanoMetrePerSecondSq<T>(this Quantity<T, DekaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecondSq to PicoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecondSq</param>
    /// <returns>quantity measured in PicoMetrePerSecondSq</returns>
	public static Quantity<double, PicoMetrePerSecondSq> ToPicoMetrePerSecondSq<T>(this Quantity<T, DekaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecondSq to FemtoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecondSq</param>
    /// <returns>quantity measured in FemtoMetrePerSecondSq</returns>
	public static Quantity<double, FemtoMetrePerSecondSq> ToFemtoMetrePerSecondSq<T>(this Quantity<T, DekaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecondSq to AttoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecondSq</param>
    /// <returns>quantity measured in AttoMetrePerSecondSq</returns>
	public static Quantity<double, AttoMetrePerSecondSq> ToAttoMetrePerSecondSq<T>(this Quantity<T, DekaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecondSq to ZeptoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecondSq</param>
    /// <returns>quantity measured in ZeptoMetrePerSecondSq</returns>
	public static Quantity<double, ZeptoMetrePerSecondSq> ToZeptoMetrePerSecondSq<T>(this Quantity<T, DekaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetrePerSecondSq to YoctoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DekaMetrePerSecondSq</param>
    /// <returns>quantity measured in YoctoMetrePerSecondSq</returns>
	public static Quantity<double, YoctoMetrePerSecondSq> ToYoctoMetrePerSecondSq<T>(this Quantity<T, DekaMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecondSq to YottaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecondSq</param>
    /// <returns>quantity measured in YottaMetrePerSecondSq</returns>
	public static Quantity<double, YottaMetrePerSecondSq> ToYottaMetrePerSecondSq<T>(this Quantity<T, DeciMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecondSq to ZettaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecondSq</param>
    /// <returns>quantity measured in ZettaMetrePerSecondSq</returns>
	public static Quantity<double, ZettaMetrePerSecondSq> ToZettaMetrePerSecondSq<T>(this Quantity<T, DeciMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecondSq to ExaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecondSq</param>
    /// <returns>quantity measured in ExaMetrePerSecondSq</returns>
	public static Quantity<double, ExaMetrePerSecondSq> ToExaMetrePerSecondSq<T>(this Quantity<T, DeciMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecondSq to PetaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecondSq</param>
    /// <returns>quantity measured in PetaMetrePerSecondSq</returns>
	public static Quantity<double, PetaMetrePerSecondSq> ToPetaMetrePerSecondSq<T>(this Quantity<T, DeciMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecondSq to TeraMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecondSq</param>
    /// <returns>quantity measured in TeraMetrePerSecondSq</returns>
	public static Quantity<double, TeraMetrePerSecondSq> ToTeraMetrePerSecondSq<T>(this Quantity<T, DeciMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecondSq to GigaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecondSq</param>
    /// <returns>quantity measured in GigaMetrePerSecondSq</returns>
	public static Quantity<double, GigaMetrePerSecondSq> ToGigaMetrePerSecondSq<T>(this Quantity<T, DeciMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecondSq to MegaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecondSq</param>
    /// <returns>quantity measured in MegaMetrePerSecondSq</returns>
	public static Quantity<double, MegaMetrePerSecondSq> ToMegaMetrePerSecondSq<T>(this Quantity<T, DeciMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecondSq to KiloMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecondSq</param>
    /// <returns>quantity measured in KiloMetrePerSecondSq</returns>
	public static Quantity<double, KiloMetrePerSecondSq> ToKiloMetrePerSecondSq<T>(this Quantity<T, DeciMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecondSq to HectoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecondSq</param>
    /// <returns>quantity measured in HectoMetrePerSecondSq</returns>
	public static Quantity<double, HectoMetrePerSecondSq> ToHectoMetrePerSecondSq<T>(this Quantity<T, DeciMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecondSq to DekaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecondSq</param>
    /// <returns>quantity measured in DekaMetrePerSecondSq</returns>
	public static Quantity<double, DekaMetrePerSecondSq> ToDekaMetrePerSecondSq<T>(this Quantity<T, DeciMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecondSq to CentiMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecondSq</param>
    /// <returns>quantity measured in CentiMetrePerSecondSq</returns>
	public static Quantity<double, CentiMetrePerSecondSq> ToCentiMetrePerSecondSq<T>(this Quantity<T, DeciMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecondSq to MilliMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecondSq</param>
    /// <returns>quantity measured in MilliMetrePerSecondSq</returns>
	public static Quantity<double, MilliMetrePerSecondSq> ToMilliMetrePerSecondSq<T>(this Quantity<T, DeciMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecondSq to MicroMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecondSq</param>
    /// <returns>quantity measured in MicroMetrePerSecondSq</returns>
	public static Quantity<double, MicroMetrePerSecondSq> ToMicroMetrePerSecondSq<T>(this Quantity<T, DeciMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecondSq to NanoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecondSq</param>
    /// <returns>quantity measured in NanoMetrePerSecondSq</returns>
	public static Quantity<double, NanoMetrePerSecondSq> ToNanoMetrePerSecondSq<T>(this Quantity<T, DeciMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecondSq to PicoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecondSq</param>
    /// <returns>quantity measured in PicoMetrePerSecondSq</returns>
	public static Quantity<double, PicoMetrePerSecondSq> ToPicoMetrePerSecondSq<T>(this Quantity<T, DeciMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecondSq to FemtoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecondSq</param>
    /// <returns>quantity measured in FemtoMetrePerSecondSq</returns>
	public static Quantity<double, FemtoMetrePerSecondSq> ToFemtoMetrePerSecondSq<T>(this Quantity<T, DeciMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecondSq to AttoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecondSq</param>
    /// <returns>quantity measured in AttoMetrePerSecondSq</returns>
	public static Quantity<double, AttoMetrePerSecondSq> ToAttoMetrePerSecondSq<T>(this Quantity<T, DeciMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecondSq to ZeptoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecondSq</param>
    /// <returns>quantity measured in ZeptoMetrePerSecondSq</returns>
	public static Quantity<double, ZeptoMetrePerSecondSq> ToZeptoMetrePerSecondSq<T>(this Quantity<T, DeciMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetrePerSecondSq to YoctoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in DeciMetrePerSecondSq</param>
    /// <returns>quantity measured in YoctoMetrePerSecondSq</returns>
	public static Quantity<double, YoctoMetrePerSecondSq> ToYoctoMetrePerSecondSq<T>(this Quantity<T, DeciMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecondSq to YottaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecondSq</param>
    /// <returns>quantity measured in YottaMetrePerSecondSq</returns>
	public static Quantity<double, YottaMetrePerSecondSq> ToYottaMetrePerSecondSq<T>(this Quantity<T, CentiMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecondSq to ZettaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecondSq</param>
    /// <returns>quantity measured in ZettaMetrePerSecondSq</returns>
	public static Quantity<double, ZettaMetrePerSecondSq> ToZettaMetrePerSecondSq<T>(this Quantity<T, CentiMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecondSq to ExaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecondSq</param>
    /// <returns>quantity measured in ExaMetrePerSecondSq</returns>
	public static Quantity<double, ExaMetrePerSecondSq> ToExaMetrePerSecondSq<T>(this Quantity<T, CentiMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecondSq to PetaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecondSq</param>
    /// <returns>quantity measured in PetaMetrePerSecondSq</returns>
	public static Quantity<double, PetaMetrePerSecondSq> ToPetaMetrePerSecondSq<T>(this Quantity<T, CentiMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecondSq to TeraMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecondSq</param>
    /// <returns>quantity measured in TeraMetrePerSecondSq</returns>
	public static Quantity<double, TeraMetrePerSecondSq> ToTeraMetrePerSecondSq<T>(this Quantity<T, CentiMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecondSq to GigaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecondSq</param>
    /// <returns>quantity measured in GigaMetrePerSecondSq</returns>
	public static Quantity<double, GigaMetrePerSecondSq> ToGigaMetrePerSecondSq<T>(this Quantity<T, CentiMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecondSq to MegaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecondSq</param>
    /// <returns>quantity measured in MegaMetrePerSecondSq</returns>
	public static Quantity<double, MegaMetrePerSecondSq> ToMegaMetrePerSecondSq<T>(this Quantity<T, CentiMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecondSq to KiloMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecondSq</param>
    /// <returns>quantity measured in KiloMetrePerSecondSq</returns>
	public static Quantity<double, KiloMetrePerSecondSq> ToKiloMetrePerSecondSq<T>(this Quantity<T, CentiMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecondSq to HectoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecondSq</param>
    /// <returns>quantity measured in HectoMetrePerSecondSq</returns>
	public static Quantity<double, HectoMetrePerSecondSq> ToHectoMetrePerSecondSq<T>(this Quantity<T, CentiMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecondSq to DekaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecondSq</param>
    /// <returns>quantity measured in DekaMetrePerSecondSq</returns>
	public static Quantity<double, DekaMetrePerSecondSq> ToDekaMetrePerSecondSq<T>(this Quantity<T, CentiMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecondSq to DeciMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecondSq</param>
    /// <returns>quantity measured in DeciMetrePerSecondSq</returns>
	public static Quantity<double, DeciMetrePerSecondSq> ToDeciMetrePerSecondSq<T>(this Quantity<T, CentiMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecondSq to MilliMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecondSq</param>
    /// <returns>quantity measured in MilliMetrePerSecondSq</returns>
	public static Quantity<double, MilliMetrePerSecondSq> ToMilliMetrePerSecondSq<T>(this Quantity<T, CentiMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecondSq to MicroMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecondSq</param>
    /// <returns>quantity measured in MicroMetrePerSecondSq</returns>
	public static Quantity<double, MicroMetrePerSecondSq> ToMicroMetrePerSecondSq<T>(this Quantity<T, CentiMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecondSq to NanoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecondSq</param>
    /// <returns>quantity measured in NanoMetrePerSecondSq</returns>
	public static Quantity<double, NanoMetrePerSecondSq> ToNanoMetrePerSecondSq<T>(this Quantity<T, CentiMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecondSq to PicoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecondSq</param>
    /// <returns>quantity measured in PicoMetrePerSecondSq</returns>
	public static Quantity<double, PicoMetrePerSecondSq> ToPicoMetrePerSecondSq<T>(this Quantity<T, CentiMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecondSq to FemtoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecondSq</param>
    /// <returns>quantity measured in FemtoMetrePerSecondSq</returns>
	public static Quantity<double, FemtoMetrePerSecondSq> ToFemtoMetrePerSecondSq<T>(this Quantity<T, CentiMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecondSq to AttoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecondSq</param>
    /// <returns>quantity measured in AttoMetrePerSecondSq</returns>
	public static Quantity<double, AttoMetrePerSecondSq> ToAttoMetrePerSecondSq<T>(this Quantity<T, CentiMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecondSq to ZeptoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecondSq</param>
    /// <returns>quantity measured in ZeptoMetrePerSecondSq</returns>
	public static Quantity<double, ZeptoMetrePerSecondSq> ToZeptoMetrePerSecondSq<T>(this Quantity<T, CentiMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetrePerSecondSq to YoctoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in CentiMetrePerSecondSq</param>
    /// <returns>quantity measured in YoctoMetrePerSecondSq</returns>
	public static Quantity<double, YoctoMetrePerSecondSq> ToYoctoMetrePerSecondSq<T>(this Quantity<T, CentiMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecondSq to YottaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecondSq</param>
    /// <returns>quantity measured in YottaMetrePerSecondSq</returns>
	public static Quantity<double, YottaMetrePerSecondSq> ToYottaMetrePerSecondSq<T>(this Quantity<T, MilliMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecondSq to ZettaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecondSq</param>
    /// <returns>quantity measured in ZettaMetrePerSecondSq</returns>
	public static Quantity<double, ZettaMetrePerSecondSq> ToZettaMetrePerSecondSq<T>(this Quantity<T, MilliMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecondSq to ExaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecondSq</param>
    /// <returns>quantity measured in ExaMetrePerSecondSq</returns>
	public static Quantity<double, ExaMetrePerSecondSq> ToExaMetrePerSecondSq<T>(this Quantity<T, MilliMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecondSq to PetaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecondSq</param>
    /// <returns>quantity measured in PetaMetrePerSecondSq</returns>
	public static Quantity<double, PetaMetrePerSecondSq> ToPetaMetrePerSecondSq<T>(this Quantity<T, MilliMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecondSq to TeraMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecondSq</param>
    /// <returns>quantity measured in TeraMetrePerSecondSq</returns>
	public static Quantity<double, TeraMetrePerSecondSq> ToTeraMetrePerSecondSq<T>(this Quantity<T, MilliMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecondSq to GigaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecondSq</param>
    /// <returns>quantity measured in GigaMetrePerSecondSq</returns>
	public static Quantity<double, GigaMetrePerSecondSq> ToGigaMetrePerSecondSq<T>(this Quantity<T, MilliMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecondSq to MegaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecondSq</param>
    /// <returns>quantity measured in MegaMetrePerSecondSq</returns>
	public static Quantity<double, MegaMetrePerSecondSq> ToMegaMetrePerSecondSq<T>(this Quantity<T, MilliMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecondSq to KiloMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecondSq</param>
    /// <returns>quantity measured in KiloMetrePerSecondSq</returns>
	public static Quantity<double, KiloMetrePerSecondSq> ToKiloMetrePerSecondSq<T>(this Quantity<T, MilliMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecondSq to HectoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecondSq</param>
    /// <returns>quantity measured in HectoMetrePerSecondSq</returns>
	public static Quantity<double, HectoMetrePerSecondSq> ToHectoMetrePerSecondSq<T>(this Quantity<T, MilliMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecondSq to DekaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecondSq</param>
    /// <returns>quantity measured in DekaMetrePerSecondSq</returns>
	public static Quantity<double, DekaMetrePerSecondSq> ToDekaMetrePerSecondSq<T>(this Quantity<T, MilliMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecondSq to DeciMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecondSq</param>
    /// <returns>quantity measured in DeciMetrePerSecondSq</returns>
	public static Quantity<double, DeciMetrePerSecondSq> ToDeciMetrePerSecondSq<T>(this Quantity<T, MilliMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecondSq to CentiMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecondSq</param>
    /// <returns>quantity measured in CentiMetrePerSecondSq</returns>
	public static Quantity<double, CentiMetrePerSecondSq> ToCentiMetrePerSecondSq<T>(this Quantity<T, MilliMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecondSq to MicroMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecondSq</param>
    /// <returns>quantity measured in MicroMetrePerSecondSq</returns>
	public static Quantity<double, MicroMetrePerSecondSq> ToMicroMetrePerSecondSq<T>(this Quantity<T, MilliMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecondSq to NanoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecondSq</param>
    /// <returns>quantity measured in NanoMetrePerSecondSq</returns>
	public static Quantity<double, NanoMetrePerSecondSq> ToNanoMetrePerSecondSq<T>(this Quantity<T, MilliMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecondSq to PicoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecondSq</param>
    /// <returns>quantity measured in PicoMetrePerSecondSq</returns>
	public static Quantity<double, PicoMetrePerSecondSq> ToPicoMetrePerSecondSq<T>(this Quantity<T, MilliMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecondSq to FemtoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecondSq</param>
    /// <returns>quantity measured in FemtoMetrePerSecondSq</returns>
	public static Quantity<double, FemtoMetrePerSecondSq> ToFemtoMetrePerSecondSq<T>(this Quantity<T, MilliMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecondSq to AttoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecondSq</param>
    /// <returns>quantity measured in AttoMetrePerSecondSq</returns>
	public static Quantity<double, AttoMetrePerSecondSq> ToAttoMetrePerSecondSq<T>(this Quantity<T, MilliMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecondSq to ZeptoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecondSq</param>
    /// <returns>quantity measured in ZeptoMetrePerSecondSq</returns>
	public static Quantity<double, ZeptoMetrePerSecondSq> ToZeptoMetrePerSecondSq<T>(this Quantity<T, MilliMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetrePerSecondSq to YoctoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MilliMetrePerSecondSq</param>
    /// <returns>quantity measured in YoctoMetrePerSecondSq</returns>
	public static Quantity<double, YoctoMetrePerSecondSq> ToYoctoMetrePerSecondSq<T>(this Quantity<T, MilliMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecondSq to YottaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecondSq</param>
    /// <returns>quantity measured in YottaMetrePerSecondSq</returns>
	public static Quantity<double, YottaMetrePerSecondSq> ToYottaMetrePerSecondSq<T>(this Quantity<T, MicroMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecondSq to ZettaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecondSq</param>
    /// <returns>quantity measured in ZettaMetrePerSecondSq</returns>
	public static Quantity<double, ZettaMetrePerSecondSq> ToZettaMetrePerSecondSq<T>(this Quantity<T, MicroMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecondSq to ExaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecondSq</param>
    /// <returns>quantity measured in ExaMetrePerSecondSq</returns>
	public static Quantity<double, ExaMetrePerSecondSq> ToExaMetrePerSecondSq<T>(this Quantity<T, MicroMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecondSq to PetaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecondSq</param>
    /// <returns>quantity measured in PetaMetrePerSecondSq</returns>
	public static Quantity<double, PetaMetrePerSecondSq> ToPetaMetrePerSecondSq<T>(this Quantity<T, MicroMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecondSq to TeraMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecondSq</param>
    /// <returns>quantity measured in TeraMetrePerSecondSq</returns>
	public static Quantity<double, TeraMetrePerSecondSq> ToTeraMetrePerSecondSq<T>(this Quantity<T, MicroMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecondSq to GigaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecondSq</param>
    /// <returns>quantity measured in GigaMetrePerSecondSq</returns>
	public static Quantity<double, GigaMetrePerSecondSq> ToGigaMetrePerSecondSq<T>(this Quantity<T, MicroMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecondSq to MegaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecondSq</param>
    /// <returns>quantity measured in MegaMetrePerSecondSq</returns>
	public static Quantity<double, MegaMetrePerSecondSq> ToMegaMetrePerSecondSq<T>(this Quantity<T, MicroMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecondSq to KiloMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecondSq</param>
    /// <returns>quantity measured in KiloMetrePerSecondSq</returns>
	public static Quantity<double, KiloMetrePerSecondSq> ToKiloMetrePerSecondSq<T>(this Quantity<T, MicroMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecondSq to HectoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecondSq</param>
    /// <returns>quantity measured in HectoMetrePerSecondSq</returns>
	public static Quantity<double, HectoMetrePerSecondSq> ToHectoMetrePerSecondSq<T>(this Quantity<T, MicroMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecondSq to DekaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecondSq</param>
    /// <returns>quantity measured in DekaMetrePerSecondSq</returns>
	public static Quantity<double, DekaMetrePerSecondSq> ToDekaMetrePerSecondSq<T>(this Quantity<T, MicroMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecondSq to DeciMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecondSq</param>
    /// <returns>quantity measured in DeciMetrePerSecondSq</returns>
	public static Quantity<double, DeciMetrePerSecondSq> ToDeciMetrePerSecondSq<T>(this Quantity<T, MicroMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecondSq to CentiMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecondSq</param>
    /// <returns>quantity measured in CentiMetrePerSecondSq</returns>
	public static Quantity<double, CentiMetrePerSecondSq> ToCentiMetrePerSecondSq<T>(this Quantity<T, MicroMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecondSq to MilliMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecondSq</param>
    /// <returns>quantity measured in MilliMetrePerSecondSq</returns>
	public static Quantity<double, MilliMetrePerSecondSq> ToMilliMetrePerSecondSq<T>(this Quantity<T, MicroMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecondSq to NanoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecondSq</param>
    /// <returns>quantity measured in NanoMetrePerSecondSq</returns>
	public static Quantity<double, NanoMetrePerSecondSq> ToNanoMetrePerSecondSq<T>(this Quantity<T, MicroMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecondSq to PicoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecondSq</param>
    /// <returns>quantity measured in PicoMetrePerSecondSq</returns>
	public static Quantity<double, PicoMetrePerSecondSq> ToPicoMetrePerSecondSq<T>(this Quantity<T, MicroMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecondSq to FemtoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecondSq</param>
    /// <returns>quantity measured in FemtoMetrePerSecondSq</returns>
	public static Quantity<double, FemtoMetrePerSecondSq> ToFemtoMetrePerSecondSq<T>(this Quantity<T, MicroMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecondSq to AttoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecondSq</param>
    /// <returns>quantity measured in AttoMetrePerSecondSq</returns>
	public static Quantity<double, AttoMetrePerSecondSq> ToAttoMetrePerSecondSq<T>(this Quantity<T, MicroMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecondSq to ZeptoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecondSq</param>
    /// <returns>quantity measured in ZeptoMetrePerSecondSq</returns>
	public static Quantity<double, ZeptoMetrePerSecondSq> ToZeptoMetrePerSecondSq<T>(this Quantity<T, MicroMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetrePerSecondSq to YoctoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in MicroMetrePerSecondSq</param>
    /// <returns>quantity measured in YoctoMetrePerSecondSq</returns>
	public static Quantity<double, YoctoMetrePerSecondSq> ToYoctoMetrePerSecondSq<T>(this Quantity<T, MicroMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecondSq to YottaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecondSq</param>
    /// <returns>quantity measured in YottaMetrePerSecondSq</returns>
	public static Quantity<double, YottaMetrePerSecondSq> ToYottaMetrePerSecondSq<T>(this Quantity<T, NanoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecondSq to ZettaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecondSq</param>
    /// <returns>quantity measured in ZettaMetrePerSecondSq</returns>
	public static Quantity<double, ZettaMetrePerSecondSq> ToZettaMetrePerSecondSq<T>(this Quantity<T, NanoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecondSq to ExaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecondSq</param>
    /// <returns>quantity measured in ExaMetrePerSecondSq</returns>
	public static Quantity<double, ExaMetrePerSecondSq> ToExaMetrePerSecondSq<T>(this Quantity<T, NanoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecondSq to PetaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecondSq</param>
    /// <returns>quantity measured in PetaMetrePerSecondSq</returns>
	public static Quantity<double, PetaMetrePerSecondSq> ToPetaMetrePerSecondSq<T>(this Quantity<T, NanoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecondSq to TeraMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecondSq</param>
    /// <returns>quantity measured in TeraMetrePerSecondSq</returns>
	public static Quantity<double, TeraMetrePerSecondSq> ToTeraMetrePerSecondSq<T>(this Quantity<T, NanoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecondSq to GigaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecondSq</param>
    /// <returns>quantity measured in GigaMetrePerSecondSq</returns>
	public static Quantity<double, GigaMetrePerSecondSq> ToGigaMetrePerSecondSq<T>(this Quantity<T, NanoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecondSq to MegaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecondSq</param>
    /// <returns>quantity measured in MegaMetrePerSecondSq</returns>
	public static Quantity<double, MegaMetrePerSecondSq> ToMegaMetrePerSecondSq<T>(this Quantity<T, NanoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecondSq to KiloMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecondSq</param>
    /// <returns>quantity measured in KiloMetrePerSecondSq</returns>
	public static Quantity<double, KiloMetrePerSecondSq> ToKiloMetrePerSecondSq<T>(this Quantity<T, NanoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecondSq to HectoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecondSq</param>
    /// <returns>quantity measured in HectoMetrePerSecondSq</returns>
	public static Quantity<double, HectoMetrePerSecondSq> ToHectoMetrePerSecondSq<T>(this Quantity<T, NanoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecondSq to DekaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecondSq</param>
    /// <returns>quantity measured in DekaMetrePerSecondSq</returns>
	public static Quantity<double, DekaMetrePerSecondSq> ToDekaMetrePerSecondSq<T>(this Quantity<T, NanoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecondSq to DeciMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecondSq</param>
    /// <returns>quantity measured in DeciMetrePerSecondSq</returns>
	public static Quantity<double, DeciMetrePerSecondSq> ToDeciMetrePerSecondSq<T>(this Quantity<T, NanoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecondSq to CentiMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecondSq</param>
    /// <returns>quantity measured in CentiMetrePerSecondSq</returns>
	public static Quantity<double, CentiMetrePerSecondSq> ToCentiMetrePerSecondSq<T>(this Quantity<T, NanoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecondSq to MilliMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecondSq</param>
    /// <returns>quantity measured in MilliMetrePerSecondSq</returns>
	public static Quantity<double, MilliMetrePerSecondSq> ToMilliMetrePerSecondSq<T>(this Quantity<T, NanoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecondSq to MicroMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecondSq</param>
    /// <returns>quantity measured in MicroMetrePerSecondSq</returns>
	public static Quantity<double, MicroMetrePerSecondSq> ToMicroMetrePerSecondSq<T>(this Quantity<T, NanoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecondSq to PicoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecondSq</param>
    /// <returns>quantity measured in PicoMetrePerSecondSq</returns>
	public static Quantity<double, PicoMetrePerSecondSq> ToPicoMetrePerSecondSq<T>(this Quantity<T, NanoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecondSq to FemtoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecondSq</param>
    /// <returns>quantity measured in FemtoMetrePerSecondSq</returns>
	public static Quantity<double, FemtoMetrePerSecondSq> ToFemtoMetrePerSecondSq<T>(this Quantity<T, NanoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecondSq to AttoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecondSq</param>
    /// <returns>quantity measured in AttoMetrePerSecondSq</returns>
	public static Quantity<double, AttoMetrePerSecondSq> ToAttoMetrePerSecondSq<T>(this Quantity<T, NanoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecondSq to ZeptoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecondSq</param>
    /// <returns>quantity measured in ZeptoMetrePerSecondSq</returns>
	public static Quantity<double, ZeptoMetrePerSecondSq> ToZeptoMetrePerSecondSq<T>(this Quantity<T, NanoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetrePerSecondSq to YoctoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in NanoMetrePerSecondSq</param>
    /// <returns>quantity measured in YoctoMetrePerSecondSq</returns>
	public static Quantity<double, YoctoMetrePerSecondSq> ToYoctoMetrePerSecondSq<T>(this Quantity<T, NanoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecondSq to YottaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecondSq</param>
    /// <returns>quantity measured in YottaMetrePerSecondSq</returns>
	public static Quantity<double, YottaMetrePerSecondSq> ToYottaMetrePerSecondSq<T>(this Quantity<T, PicoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecondSq to ZettaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecondSq</param>
    /// <returns>quantity measured in ZettaMetrePerSecondSq</returns>
	public static Quantity<double, ZettaMetrePerSecondSq> ToZettaMetrePerSecondSq<T>(this Quantity<T, PicoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecondSq to ExaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecondSq</param>
    /// <returns>quantity measured in ExaMetrePerSecondSq</returns>
	public static Quantity<double, ExaMetrePerSecondSq> ToExaMetrePerSecondSq<T>(this Quantity<T, PicoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecondSq to PetaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecondSq</param>
    /// <returns>quantity measured in PetaMetrePerSecondSq</returns>
	public static Quantity<double, PetaMetrePerSecondSq> ToPetaMetrePerSecondSq<T>(this Quantity<T, PicoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecondSq to TeraMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecondSq</param>
    /// <returns>quantity measured in TeraMetrePerSecondSq</returns>
	public static Quantity<double, TeraMetrePerSecondSq> ToTeraMetrePerSecondSq<T>(this Quantity<T, PicoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecondSq to GigaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecondSq</param>
    /// <returns>quantity measured in GigaMetrePerSecondSq</returns>
	public static Quantity<double, GigaMetrePerSecondSq> ToGigaMetrePerSecondSq<T>(this Quantity<T, PicoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecondSq to MegaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecondSq</param>
    /// <returns>quantity measured in MegaMetrePerSecondSq</returns>
	public static Quantity<double, MegaMetrePerSecondSq> ToMegaMetrePerSecondSq<T>(this Quantity<T, PicoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecondSq to KiloMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecondSq</param>
    /// <returns>quantity measured in KiloMetrePerSecondSq</returns>
	public static Quantity<double, KiloMetrePerSecondSq> ToKiloMetrePerSecondSq<T>(this Quantity<T, PicoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecondSq to HectoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecondSq</param>
    /// <returns>quantity measured in HectoMetrePerSecondSq</returns>
	public static Quantity<double, HectoMetrePerSecondSq> ToHectoMetrePerSecondSq<T>(this Quantity<T, PicoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecondSq to DekaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecondSq</param>
    /// <returns>quantity measured in DekaMetrePerSecondSq</returns>
	public static Quantity<double, DekaMetrePerSecondSq> ToDekaMetrePerSecondSq<T>(this Quantity<T, PicoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecondSq to DeciMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecondSq</param>
    /// <returns>quantity measured in DeciMetrePerSecondSq</returns>
	public static Quantity<double, DeciMetrePerSecondSq> ToDeciMetrePerSecondSq<T>(this Quantity<T, PicoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecondSq to CentiMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecondSq</param>
    /// <returns>quantity measured in CentiMetrePerSecondSq</returns>
	public static Quantity<double, CentiMetrePerSecondSq> ToCentiMetrePerSecondSq<T>(this Quantity<T, PicoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecondSq to MilliMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecondSq</param>
    /// <returns>quantity measured in MilliMetrePerSecondSq</returns>
	public static Quantity<double, MilliMetrePerSecondSq> ToMilliMetrePerSecondSq<T>(this Quantity<T, PicoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecondSq to MicroMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecondSq</param>
    /// <returns>quantity measured in MicroMetrePerSecondSq</returns>
	public static Quantity<double, MicroMetrePerSecondSq> ToMicroMetrePerSecondSq<T>(this Quantity<T, PicoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecondSq to NanoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecondSq</param>
    /// <returns>quantity measured in NanoMetrePerSecondSq</returns>
	public static Quantity<double, NanoMetrePerSecondSq> ToNanoMetrePerSecondSq<T>(this Quantity<T, PicoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecondSq to FemtoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecondSq</param>
    /// <returns>quantity measured in FemtoMetrePerSecondSq</returns>
	public static Quantity<double, FemtoMetrePerSecondSq> ToFemtoMetrePerSecondSq<T>(this Quantity<T, PicoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecondSq to AttoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecondSq</param>
    /// <returns>quantity measured in AttoMetrePerSecondSq</returns>
	public static Quantity<double, AttoMetrePerSecondSq> ToAttoMetrePerSecondSq<T>(this Quantity<T, PicoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecondSq to ZeptoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecondSq</param>
    /// <returns>quantity measured in ZeptoMetrePerSecondSq</returns>
	public static Quantity<double, ZeptoMetrePerSecondSq> ToZeptoMetrePerSecondSq<T>(this Quantity<T, PicoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetrePerSecondSq to YoctoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in PicoMetrePerSecondSq</param>
    /// <returns>quantity measured in YoctoMetrePerSecondSq</returns>
	public static Quantity<double, YoctoMetrePerSecondSq> ToYoctoMetrePerSecondSq<T>(this Quantity<T, PicoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecondSq to YottaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecondSq</param>
    /// <returns>quantity measured in YottaMetrePerSecondSq</returns>
	public static Quantity<double, YottaMetrePerSecondSq> ToYottaMetrePerSecondSq<T>(this Quantity<T, FemtoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecondSq to ZettaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecondSq</param>
    /// <returns>quantity measured in ZettaMetrePerSecondSq</returns>
	public static Quantity<double, ZettaMetrePerSecondSq> ToZettaMetrePerSecondSq<T>(this Quantity<T, FemtoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecondSq to ExaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecondSq</param>
    /// <returns>quantity measured in ExaMetrePerSecondSq</returns>
	public static Quantity<double, ExaMetrePerSecondSq> ToExaMetrePerSecondSq<T>(this Quantity<T, FemtoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecondSq to PetaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecondSq</param>
    /// <returns>quantity measured in PetaMetrePerSecondSq</returns>
	public static Quantity<double, PetaMetrePerSecondSq> ToPetaMetrePerSecondSq<T>(this Quantity<T, FemtoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecondSq to TeraMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecondSq</param>
    /// <returns>quantity measured in TeraMetrePerSecondSq</returns>
	public static Quantity<double, TeraMetrePerSecondSq> ToTeraMetrePerSecondSq<T>(this Quantity<T, FemtoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecondSq to GigaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecondSq</param>
    /// <returns>quantity measured in GigaMetrePerSecondSq</returns>
	public static Quantity<double, GigaMetrePerSecondSq> ToGigaMetrePerSecondSq<T>(this Quantity<T, FemtoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecondSq to MegaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecondSq</param>
    /// <returns>quantity measured in MegaMetrePerSecondSq</returns>
	public static Quantity<double, MegaMetrePerSecondSq> ToMegaMetrePerSecondSq<T>(this Quantity<T, FemtoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecondSq to KiloMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecondSq</param>
    /// <returns>quantity measured in KiloMetrePerSecondSq</returns>
	public static Quantity<double, KiloMetrePerSecondSq> ToKiloMetrePerSecondSq<T>(this Quantity<T, FemtoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecondSq to HectoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecondSq</param>
    /// <returns>quantity measured in HectoMetrePerSecondSq</returns>
	public static Quantity<double, HectoMetrePerSecondSq> ToHectoMetrePerSecondSq<T>(this Quantity<T, FemtoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecondSq to DekaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecondSq</param>
    /// <returns>quantity measured in DekaMetrePerSecondSq</returns>
	public static Quantity<double, DekaMetrePerSecondSq> ToDekaMetrePerSecondSq<T>(this Quantity<T, FemtoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecondSq to DeciMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecondSq</param>
    /// <returns>quantity measured in DeciMetrePerSecondSq</returns>
	public static Quantity<double, DeciMetrePerSecondSq> ToDeciMetrePerSecondSq<T>(this Quantity<T, FemtoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecondSq to CentiMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecondSq</param>
    /// <returns>quantity measured in CentiMetrePerSecondSq</returns>
	public static Quantity<double, CentiMetrePerSecondSq> ToCentiMetrePerSecondSq<T>(this Quantity<T, FemtoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecondSq to MilliMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecondSq</param>
    /// <returns>quantity measured in MilliMetrePerSecondSq</returns>
	public static Quantity<double, MilliMetrePerSecondSq> ToMilliMetrePerSecondSq<T>(this Quantity<T, FemtoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecondSq to MicroMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecondSq</param>
    /// <returns>quantity measured in MicroMetrePerSecondSq</returns>
	public static Quantity<double, MicroMetrePerSecondSq> ToMicroMetrePerSecondSq<T>(this Quantity<T, FemtoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecondSq to NanoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecondSq</param>
    /// <returns>quantity measured in NanoMetrePerSecondSq</returns>
	public static Quantity<double, NanoMetrePerSecondSq> ToNanoMetrePerSecondSq<T>(this Quantity<T, FemtoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecondSq to PicoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecondSq</param>
    /// <returns>quantity measured in PicoMetrePerSecondSq</returns>
	public static Quantity<double, PicoMetrePerSecondSq> ToPicoMetrePerSecondSq<T>(this Quantity<T, FemtoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecondSq to AttoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecondSq</param>
    /// <returns>quantity measured in AttoMetrePerSecondSq</returns>
	public static Quantity<double, AttoMetrePerSecondSq> ToAttoMetrePerSecondSq<T>(this Quantity<T, FemtoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecondSq to ZeptoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecondSq</param>
    /// <returns>quantity measured in ZeptoMetrePerSecondSq</returns>
	public static Quantity<double, ZeptoMetrePerSecondSq> ToZeptoMetrePerSecondSq<T>(this Quantity<T, FemtoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetrePerSecondSq to YoctoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetrePerSecondSq</param>
    /// <returns>quantity measured in YoctoMetrePerSecondSq</returns>
	public static Quantity<double, YoctoMetrePerSecondSq> ToYoctoMetrePerSecondSq<T>(this Quantity<T, FemtoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecondSq to YottaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecondSq</param>
    /// <returns>quantity measured in YottaMetrePerSecondSq</returns>
	public static Quantity<double, YottaMetrePerSecondSq> ToYottaMetrePerSecondSq<T>(this Quantity<T, AttoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecondSq to ZettaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecondSq</param>
    /// <returns>quantity measured in ZettaMetrePerSecondSq</returns>
	public static Quantity<double, ZettaMetrePerSecondSq> ToZettaMetrePerSecondSq<T>(this Quantity<T, AttoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecondSq to ExaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecondSq</param>
    /// <returns>quantity measured in ExaMetrePerSecondSq</returns>
	public static Quantity<double, ExaMetrePerSecondSq> ToExaMetrePerSecondSq<T>(this Quantity<T, AttoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecondSq to PetaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecondSq</param>
    /// <returns>quantity measured in PetaMetrePerSecondSq</returns>
	public static Quantity<double, PetaMetrePerSecondSq> ToPetaMetrePerSecondSq<T>(this Quantity<T, AttoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecondSq to TeraMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecondSq</param>
    /// <returns>quantity measured in TeraMetrePerSecondSq</returns>
	public static Quantity<double, TeraMetrePerSecondSq> ToTeraMetrePerSecondSq<T>(this Quantity<T, AttoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecondSq to GigaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecondSq</param>
    /// <returns>quantity measured in GigaMetrePerSecondSq</returns>
	public static Quantity<double, GigaMetrePerSecondSq> ToGigaMetrePerSecondSq<T>(this Quantity<T, AttoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecondSq to MegaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecondSq</param>
    /// <returns>quantity measured in MegaMetrePerSecondSq</returns>
	public static Quantity<double, MegaMetrePerSecondSq> ToMegaMetrePerSecondSq<T>(this Quantity<T, AttoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecondSq to KiloMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecondSq</param>
    /// <returns>quantity measured in KiloMetrePerSecondSq</returns>
	public static Quantity<double, KiloMetrePerSecondSq> ToKiloMetrePerSecondSq<T>(this Quantity<T, AttoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecondSq to HectoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecondSq</param>
    /// <returns>quantity measured in HectoMetrePerSecondSq</returns>
	public static Quantity<double, HectoMetrePerSecondSq> ToHectoMetrePerSecondSq<T>(this Quantity<T, AttoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecondSq to DekaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecondSq</param>
    /// <returns>quantity measured in DekaMetrePerSecondSq</returns>
	public static Quantity<double, DekaMetrePerSecondSq> ToDekaMetrePerSecondSq<T>(this Quantity<T, AttoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecondSq to DeciMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecondSq</param>
    /// <returns>quantity measured in DeciMetrePerSecondSq</returns>
	public static Quantity<double, DeciMetrePerSecondSq> ToDeciMetrePerSecondSq<T>(this Quantity<T, AttoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecondSq to CentiMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecondSq</param>
    /// <returns>quantity measured in CentiMetrePerSecondSq</returns>
	public static Quantity<double, CentiMetrePerSecondSq> ToCentiMetrePerSecondSq<T>(this Quantity<T, AttoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecondSq to MilliMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecondSq</param>
    /// <returns>quantity measured in MilliMetrePerSecondSq</returns>
	public static Quantity<double, MilliMetrePerSecondSq> ToMilliMetrePerSecondSq<T>(this Quantity<T, AttoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecondSq to MicroMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecondSq</param>
    /// <returns>quantity measured in MicroMetrePerSecondSq</returns>
	public static Quantity<double, MicroMetrePerSecondSq> ToMicroMetrePerSecondSq<T>(this Quantity<T, AttoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecondSq to NanoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecondSq</param>
    /// <returns>quantity measured in NanoMetrePerSecondSq</returns>
	public static Quantity<double, NanoMetrePerSecondSq> ToNanoMetrePerSecondSq<T>(this Quantity<T, AttoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecondSq to PicoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecondSq</param>
    /// <returns>quantity measured in PicoMetrePerSecondSq</returns>
	public static Quantity<double, PicoMetrePerSecondSq> ToPicoMetrePerSecondSq<T>(this Quantity<T, AttoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecondSq to FemtoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecondSq</param>
    /// <returns>quantity measured in FemtoMetrePerSecondSq</returns>
	public static Quantity<double, FemtoMetrePerSecondSq> ToFemtoMetrePerSecondSq<T>(this Quantity<T, AttoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecondSq to ZeptoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecondSq</param>
    /// <returns>quantity measured in ZeptoMetrePerSecondSq</returns>
	public static Quantity<double, ZeptoMetrePerSecondSq> ToZeptoMetrePerSecondSq<T>(this Quantity<T, AttoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetrePerSecondSq to YoctoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in AttoMetrePerSecondSq</param>
    /// <returns>quantity measured in YoctoMetrePerSecondSq</returns>
	public static Quantity<double, YoctoMetrePerSecondSq> ToYoctoMetrePerSecondSq<T>(this Quantity<T, AttoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecondSq to YottaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecondSq</param>
    /// <returns>quantity measured in YottaMetrePerSecondSq</returns>
	public static Quantity<double, YottaMetrePerSecondSq> ToYottaMetrePerSecondSq<T>(this Quantity<T, ZeptoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecondSq to ZettaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecondSq</param>
    /// <returns>quantity measured in ZettaMetrePerSecondSq</returns>
	public static Quantity<double, ZettaMetrePerSecondSq> ToZettaMetrePerSecondSq<T>(this Quantity<T, ZeptoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecondSq to ExaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecondSq</param>
    /// <returns>quantity measured in ExaMetrePerSecondSq</returns>
	public static Quantity<double, ExaMetrePerSecondSq> ToExaMetrePerSecondSq<T>(this Quantity<T, ZeptoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecondSq to PetaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecondSq</param>
    /// <returns>quantity measured in PetaMetrePerSecondSq</returns>
	public static Quantity<double, PetaMetrePerSecondSq> ToPetaMetrePerSecondSq<T>(this Quantity<T, ZeptoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecondSq to TeraMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecondSq</param>
    /// <returns>quantity measured in TeraMetrePerSecondSq</returns>
	public static Quantity<double, TeraMetrePerSecondSq> ToTeraMetrePerSecondSq<T>(this Quantity<T, ZeptoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecondSq to GigaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecondSq</param>
    /// <returns>quantity measured in GigaMetrePerSecondSq</returns>
	public static Quantity<double, GigaMetrePerSecondSq> ToGigaMetrePerSecondSq<T>(this Quantity<T, ZeptoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecondSq to MegaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecondSq</param>
    /// <returns>quantity measured in MegaMetrePerSecondSq</returns>
	public static Quantity<double, MegaMetrePerSecondSq> ToMegaMetrePerSecondSq<T>(this Quantity<T, ZeptoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecondSq to KiloMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecondSq</param>
    /// <returns>quantity measured in KiloMetrePerSecondSq</returns>
	public static Quantity<double, KiloMetrePerSecondSq> ToKiloMetrePerSecondSq<T>(this Quantity<T, ZeptoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecondSq to HectoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecondSq</param>
    /// <returns>quantity measured in HectoMetrePerSecondSq</returns>
	public static Quantity<double, HectoMetrePerSecondSq> ToHectoMetrePerSecondSq<T>(this Quantity<T, ZeptoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecondSq to DekaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecondSq</param>
    /// <returns>quantity measured in DekaMetrePerSecondSq</returns>
	public static Quantity<double, DekaMetrePerSecondSq> ToDekaMetrePerSecondSq<T>(this Quantity<T, ZeptoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecondSq to DeciMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecondSq</param>
    /// <returns>quantity measured in DeciMetrePerSecondSq</returns>
	public static Quantity<double, DeciMetrePerSecondSq> ToDeciMetrePerSecondSq<T>(this Quantity<T, ZeptoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecondSq to CentiMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecondSq</param>
    /// <returns>quantity measured in CentiMetrePerSecondSq</returns>
	public static Quantity<double, CentiMetrePerSecondSq> ToCentiMetrePerSecondSq<T>(this Quantity<T, ZeptoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecondSq to MilliMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecondSq</param>
    /// <returns>quantity measured in MilliMetrePerSecondSq</returns>
	public static Quantity<double, MilliMetrePerSecondSq> ToMilliMetrePerSecondSq<T>(this Quantity<T, ZeptoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecondSq to MicroMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecondSq</param>
    /// <returns>quantity measured in MicroMetrePerSecondSq</returns>
	public static Quantity<double, MicroMetrePerSecondSq> ToMicroMetrePerSecondSq<T>(this Quantity<T, ZeptoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecondSq to NanoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecondSq</param>
    /// <returns>quantity measured in NanoMetrePerSecondSq</returns>
	public static Quantity<double, NanoMetrePerSecondSq> ToNanoMetrePerSecondSq<T>(this Quantity<T, ZeptoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecondSq to PicoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecondSq</param>
    /// <returns>quantity measured in PicoMetrePerSecondSq</returns>
	public static Quantity<double, PicoMetrePerSecondSq> ToPicoMetrePerSecondSq<T>(this Quantity<T, ZeptoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecondSq to FemtoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecondSq</param>
    /// <returns>quantity measured in FemtoMetrePerSecondSq</returns>
	public static Quantity<double, FemtoMetrePerSecondSq> ToFemtoMetrePerSecondSq<T>(this Quantity<T, ZeptoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecondSq to AttoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecondSq</param>
    /// <returns>quantity measured in AttoMetrePerSecondSq</returns>
	public static Quantity<double, AttoMetrePerSecondSq> ToAttoMetrePerSecondSq<T>(this Quantity<T, ZeptoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetrePerSecondSq to YoctoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetrePerSecondSq</param>
    /// <returns>quantity measured in YoctoMetrePerSecondSq</returns>
	public static Quantity<double, YoctoMetrePerSecondSq> ToYoctoMetrePerSecondSq<T>(this Quantity<T, ZeptoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YoctoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecondSq to YottaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecondSq</param>
    /// <returns>quantity measured in YottaMetrePerSecondSq</returns>
	public static Quantity<double, YottaMetrePerSecondSq> ToYottaMetrePerSecondSq<T>(this Quantity<T, YoctoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, YottaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecondSq to ZettaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecondSq</param>
    /// <returns>quantity measured in ZettaMetrePerSecondSq</returns>
	public static Quantity<double, ZettaMetrePerSecondSq> ToZettaMetrePerSecondSq<T>(this Quantity<T, YoctoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZettaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecondSq to ExaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecondSq</param>
    /// <returns>quantity measured in ExaMetrePerSecondSq</returns>
	public static Quantity<double, ExaMetrePerSecondSq> ToExaMetrePerSecondSq<T>(this Quantity<T, YoctoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ExaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecondSq to PetaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecondSq</param>
    /// <returns>quantity measured in PetaMetrePerSecondSq</returns>
	public static Quantity<double, PetaMetrePerSecondSq> ToPetaMetrePerSecondSq<T>(this Quantity<T, YoctoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PetaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecondSq to TeraMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecondSq</param>
    /// <returns>quantity measured in TeraMetrePerSecondSq</returns>
	public static Quantity<double, TeraMetrePerSecondSq> ToTeraMetrePerSecondSq<T>(this Quantity<T, YoctoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, TeraMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecondSq to GigaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecondSq</param>
    /// <returns>quantity measured in GigaMetrePerSecondSq</returns>
	public static Quantity<double, GigaMetrePerSecondSq> ToGigaMetrePerSecondSq<T>(this Quantity<T, YoctoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, GigaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecondSq to MegaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecondSq</param>
    /// <returns>quantity measured in MegaMetrePerSecondSq</returns>
	public static Quantity<double, MegaMetrePerSecondSq> ToMegaMetrePerSecondSq<T>(this Quantity<T, YoctoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MegaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecondSq to KiloMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecondSq</param>
    /// <returns>quantity measured in KiloMetrePerSecondSq</returns>
	public static Quantity<double, KiloMetrePerSecondSq> ToKiloMetrePerSecondSq<T>(this Quantity<T, YoctoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, KiloMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecondSq to HectoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecondSq</param>
    /// <returns>quantity measured in HectoMetrePerSecondSq</returns>
	public static Quantity<double, HectoMetrePerSecondSq> ToHectoMetrePerSecondSq<T>(this Quantity<T, YoctoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, HectoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecondSq to DekaMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecondSq</param>
    /// <returns>quantity measured in DekaMetrePerSecondSq</returns>
	public static Quantity<double, DekaMetrePerSecondSq> ToDekaMetrePerSecondSq<T>(this Quantity<T, YoctoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DekaMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecondSq to DeciMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecondSq</param>
    /// <returns>quantity measured in DeciMetrePerSecondSq</returns>
	public static Quantity<double, DeciMetrePerSecondSq> ToDeciMetrePerSecondSq<T>(this Quantity<T, YoctoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, DeciMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecondSq to CentiMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecondSq</param>
    /// <returns>quantity measured in CentiMetrePerSecondSq</returns>
	public static Quantity<double, CentiMetrePerSecondSq> ToCentiMetrePerSecondSq<T>(this Quantity<T, YoctoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, CentiMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecondSq to MilliMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecondSq</param>
    /// <returns>quantity measured in MilliMetrePerSecondSq</returns>
	public static Quantity<double, MilliMetrePerSecondSq> ToMilliMetrePerSecondSq<T>(this Quantity<T, YoctoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MilliMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecondSq to MicroMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecondSq</param>
    /// <returns>quantity measured in MicroMetrePerSecondSq</returns>
	public static Quantity<double, MicroMetrePerSecondSq> ToMicroMetrePerSecondSq<T>(this Quantity<T, YoctoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, MicroMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecondSq to NanoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecondSq</param>
    /// <returns>quantity measured in NanoMetrePerSecondSq</returns>
	public static Quantity<double, NanoMetrePerSecondSq> ToNanoMetrePerSecondSq<T>(this Quantity<T, YoctoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, NanoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecondSq to PicoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecondSq</param>
    /// <returns>quantity measured in PicoMetrePerSecondSq</returns>
	public static Quantity<double, PicoMetrePerSecondSq> ToPicoMetrePerSecondSq<T>(this Quantity<T, YoctoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, PicoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecondSq to FemtoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecondSq</param>
    /// <returns>quantity measured in FemtoMetrePerSecondSq</returns>
	public static Quantity<double, FemtoMetrePerSecondSq> ToFemtoMetrePerSecondSq<T>(this Quantity<T, YoctoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, FemtoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecondSq to AttoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecondSq</param>
    /// <returns>quantity measured in AttoMetrePerSecondSq</returns>
	public static Quantity<double, AttoMetrePerSecondSq> ToAttoMetrePerSecondSq<T>(this Quantity<T, YoctoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, AttoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetrePerSecondSq to ZeptoMetrePerSecondSq
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetrePerSecondSq</param>
    /// <returns>quantity measured in ZeptoMetrePerSecondSq</returns>
	public static Quantity<double, ZeptoMetrePerSecondSq> ToZeptoMetrePerSecondSq<T>(this Quantity<T, YoctoMetrePerSecondSq> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetrePerSecondSq>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
}
}