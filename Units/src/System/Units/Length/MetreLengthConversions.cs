using System;
namespace System.Units.Length {
/// <summary>
/// Static class housing si-prefix conversions for the unit "Metre"
/// </summary>
public static class MetreLengthConversions {
	/// <summary>
    /// Extension method to convert Metre to YottaMetre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in YottaMetre</returns>
	public static Quantity<double, YottaMetre> ToYottaMetre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, YottaMetre>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Metre to ZettaMetre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in ZettaMetre</returns>
	public static Quantity<double, ZettaMetre> ToZettaMetre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, ZettaMetre>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Metre to ExaMetre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in ExaMetre</returns>
	public static Quantity<double, ExaMetre> ToExaMetre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, ExaMetre>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Metre to PetaMetre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in PetaMetre</returns>
	public static Quantity<double, PetaMetre> ToPetaMetre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, PetaMetre>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Metre to TeraMetre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in TeraMetre</returns>
	public static Quantity<double, TeraMetre> ToTeraMetre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, TeraMetre>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Metre to GigaMetre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in GigaMetre</returns>
	public static Quantity<double, GigaMetre> ToGigaMetre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, GigaMetre>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Metre to MegaMetre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in MegaMetre</returns>
	public static Quantity<double, MegaMetre> ToMegaMetre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, MegaMetre>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Metre to KiloMetre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in KiloMetre</returns>
	public static Quantity<double, KiloMetre> ToKiloMetre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, KiloMetre>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Metre to HectoMetre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in HectoMetre</returns>
	public static Quantity<double, HectoMetre> ToHectoMetre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, HectoMetre>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Metre to DekaMetre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in DekaMetre</returns>
	public static Quantity<double, DekaMetre> ToDekaMetre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, DekaMetre>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Metre to DeciMetre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in DeciMetre</returns>
	public static Quantity<double, DeciMetre> ToDeciMetre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, DeciMetre>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Metre to CentiMetre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in CentiMetre</returns>
	public static Quantity<double, CentiMetre> ToCentiMetre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, CentiMetre>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Metre to MilliMetre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in MilliMetre</returns>
	public static Quantity<double, MilliMetre> ToMilliMetre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, MilliMetre>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Metre to MicroMetre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in MicroMetre</returns>
	public static Quantity<double, MicroMetre> ToMicroMetre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, MicroMetre>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Metre to NanoMetre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in NanoMetre</returns>
	public static Quantity<double, NanoMetre> ToNanoMetre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, NanoMetre>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Metre to PicoMetre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in PicoMetre</returns>
	public static Quantity<double, PicoMetre> ToPicoMetre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, PicoMetre>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Metre to FemtoMetre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in FemtoMetre</returns>
	public static Quantity<double, FemtoMetre> ToFemtoMetre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, FemtoMetre>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Metre to AttoMetre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in AttoMetre</returns>
	public static Quantity<double, AttoMetre> ToAttoMetre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, AttoMetre>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Metre to ZeptoMetre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in ZeptoMetre</returns>
	public static Quantity<double, ZeptoMetre> ToZeptoMetre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetre>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Metre to YoctoMetre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in YoctoMetre</returns>
	public static Quantity<double, YoctoMetre> ToYoctoMetre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, YoctoMetre>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetre to ZettaMetre
    /// </summary>
    /// <param name="val">quantity measured in YottaMetre</param>
    /// <returns>quantity measured in ZettaMetre</returns>
	public static Quantity<double, ZettaMetre> ToZettaMetre<T>(this Quantity<T, YottaMetre> val) where T:IConvertible {
        return new Quantity<double, ZettaMetre>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetre to ExaMetre
    /// </summary>
    /// <param name="val">quantity measured in YottaMetre</param>
    /// <returns>quantity measured in ExaMetre</returns>
	public static Quantity<double, ExaMetre> ToExaMetre<T>(this Quantity<T, YottaMetre> val) where T:IConvertible {
        return new Quantity<double, ExaMetre>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetre to PetaMetre
    /// </summary>
    /// <param name="val">quantity measured in YottaMetre</param>
    /// <returns>quantity measured in PetaMetre</returns>
	public static Quantity<double, PetaMetre> ToPetaMetre<T>(this Quantity<T, YottaMetre> val) where T:IConvertible {
        return new Quantity<double, PetaMetre>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetre to TeraMetre
    /// </summary>
    /// <param name="val">quantity measured in YottaMetre</param>
    /// <returns>quantity measured in TeraMetre</returns>
	public static Quantity<double, TeraMetre> ToTeraMetre<T>(this Quantity<T, YottaMetre> val) where T:IConvertible {
        return new Quantity<double, TeraMetre>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetre to GigaMetre
    /// </summary>
    /// <param name="val">quantity measured in YottaMetre</param>
    /// <returns>quantity measured in GigaMetre</returns>
	public static Quantity<double, GigaMetre> ToGigaMetre<T>(this Quantity<T, YottaMetre> val) where T:IConvertible {
        return new Quantity<double, GigaMetre>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetre to MegaMetre
    /// </summary>
    /// <param name="val">quantity measured in YottaMetre</param>
    /// <returns>quantity measured in MegaMetre</returns>
	public static Quantity<double, MegaMetre> ToMegaMetre<T>(this Quantity<T, YottaMetre> val) where T:IConvertible {
        return new Quantity<double, MegaMetre>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetre to KiloMetre
    /// </summary>
    /// <param name="val">quantity measured in YottaMetre</param>
    /// <returns>quantity measured in KiloMetre</returns>
	public static Quantity<double, KiloMetre> ToKiloMetre<T>(this Quantity<T, YottaMetre> val) where T:IConvertible {
        return new Quantity<double, KiloMetre>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetre to HectoMetre
    /// </summary>
    /// <param name="val">quantity measured in YottaMetre</param>
    /// <returns>quantity measured in HectoMetre</returns>
	public static Quantity<double, HectoMetre> ToHectoMetre<T>(this Quantity<T, YottaMetre> val) where T:IConvertible {
        return new Quantity<double, HectoMetre>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetre to DekaMetre
    /// </summary>
    /// <param name="val">quantity measured in YottaMetre</param>
    /// <returns>quantity measured in DekaMetre</returns>
	public static Quantity<double, DekaMetre> ToDekaMetre<T>(this Quantity<T, YottaMetre> val) where T:IConvertible {
        return new Quantity<double, DekaMetre>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetre to DeciMetre
    /// </summary>
    /// <param name="val">quantity measured in YottaMetre</param>
    /// <returns>quantity measured in DeciMetre</returns>
	public static Quantity<double, DeciMetre> ToDeciMetre<T>(this Quantity<T, YottaMetre> val) where T:IConvertible {
        return new Quantity<double, DeciMetre>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetre to CentiMetre
    /// </summary>
    /// <param name="val">quantity measured in YottaMetre</param>
    /// <returns>quantity measured in CentiMetre</returns>
	public static Quantity<double, CentiMetre> ToCentiMetre<T>(this Quantity<T, YottaMetre> val) where T:IConvertible {
        return new Quantity<double, CentiMetre>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetre to MilliMetre
    /// </summary>
    /// <param name="val">quantity measured in YottaMetre</param>
    /// <returns>quantity measured in MilliMetre</returns>
	public static Quantity<double, MilliMetre> ToMilliMetre<T>(this Quantity<T, YottaMetre> val) where T:IConvertible {
        return new Quantity<double, MilliMetre>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetre to MicroMetre
    /// </summary>
    /// <param name="val">quantity measured in YottaMetre</param>
    /// <returns>quantity measured in MicroMetre</returns>
	public static Quantity<double, MicroMetre> ToMicroMetre<T>(this Quantity<T, YottaMetre> val) where T:IConvertible {
        return new Quantity<double, MicroMetre>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetre to NanoMetre
    /// </summary>
    /// <param name="val">quantity measured in YottaMetre</param>
    /// <returns>quantity measured in NanoMetre</returns>
	public static Quantity<double, NanoMetre> ToNanoMetre<T>(this Quantity<T, YottaMetre> val) where T:IConvertible {
        return new Quantity<double, NanoMetre>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetre to PicoMetre
    /// </summary>
    /// <param name="val">quantity measured in YottaMetre</param>
    /// <returns>quantity measured in PicoMetre</returns>
	public static Quantity<double, PicoMetre> ToPicoMetre<T>(this Quantity<T, YottaMetre> val) where T:IConvertible {
        return new Quantity<double, PicoMetre>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetre to FemtoMetre
    /// </summary>
    /// <param name="val">quantity measured in YottaMetre</param>
    /// <returns>quantity measured in FemtoMetre</returns>
	public static Quantity<double, FemtoMetre> ToFemtoMetre<T>(this Quantity<T, YottaMetre> val) where T:IConvertible {
        return new Quantity<double, FemtoMetre>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetre to AttoMetre
    /// </summary>
    /// <param name="val">quantity measured in YottaMetre</param>
    /// <returns>quantity measured in AttoMetre</returns>
	public static Quantity<double, AttoMetre> ToAttoMetre<T>(this Quantity<T, YottaMetre> val) where T:IConvertible {
        return new Quantity<double, AttoMetre>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetre to ZeptoMetre
    /// </summary>
    /// <param name="val">quantity measured in YottaMetre</param>
    /// <returns>quantity measured in ZeptoMetre</returns>
	public static Quantity<double, ZeptoMetre> ToZeptoMetre<T>(this Quantity<T, YottaMetre> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetre>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaMetre to YoctoMetre
    /// </summary>
    /// <param name="val">quantity measured in YottaMetre</param>
    /// <returns>quantity measured in YoctoMetre</returns>
	public static Quantity<double, YoctoMetre> ToYoctoMetre<T>(this Quantity<T, YottaMetre> val) where T:IConvertible {
        return new Quantity<double, YoctoMetre>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetre to YottaMetre
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetre</param>
    /// <returns>quantity measured in YottaMetre</returns>
	public static Quantity<double, YottaMetre> ToYottaMetre<T>(this Quantity<T, ZettaMetre> val) where T:IConvertible {
        return new Quantity<double, YottaMetre>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetre to ExaMetre
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetre</param>
    /// <returns>quantity measured in ExaMetre</returns>
	public static Quantity<double, ExaMetre> ToExaMetre<T>(this Quantity<T, ZettaMetre> val) where T:IConvertible {
        return new Quantity<double, ExaMetre>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetre to PetaMetre
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetre</param>
    /// <returns>quantity measured in PetaMetre</returns>
	public static Quantity<double, PetaMetre> ToPetaMetre<T>(this Quantity<T, ZettaMetre> val) where T:IConvertible {
        return new Quantity<double, PetaMetre>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetre to TeraMetre
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetre</param>
    /// <returns>quantity measured in TeraMetre</returns>
	public static Quantity<double, TeraMetre> ToTeraMetre<T>(this Quantity<T, ZettaMetre> val) where T:IConvertible {
        return new Quantity<double, TeraMetre>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetre to GigaMetre
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetre</param>
    /// <returns>quantity measured in GigaMetre</returns>
	public static Quantity<double, GigaMetre> ToGigaMetre<T>(this Quantity<T, ZettaMetre> val) where T:IConvertible {
        return new Quantity<double, GigaMetre>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetre to MegaMetre
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetre</param>
    /// <returns>quantity measured in MegaMetre</returns>
	public static Quantity<double, MegaMetre> ToMegaMetre<T>(this Quantity<T, ZettaMetre> val) where T:IConvertible {
        return new Quantity<double, MegaMetre>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetre to KiloMetre
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetre</param>
    /// <returns>quantity measured in KiloMetre</returns>
	public static Quantity<double, KiloMetre> ToKiloMetre<T>(this Quantity<T, ZettaMetre> val) where T:IConvertible {
        return new Quantity<double, KiloMetre>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetre to HectoMetre
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetre</param>
    /// <returns>quantity measured in HectoMetre</returns>
	public static Quantity<double, HectoMetre> ToHectoMetre<T>(this Quantity<T, ZettaMetre> val) where T:IConvertible {
        return new Quantity<double, HectoMetre>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetre to DekaMetre
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetre</param>
    /// <returns>quantity measured in DekaMetre</returns>
	public static Quantity<double, DekaMetre> ToDekaMetre<T>(this Quantity<T, ZettaMetre> val) where T:IConvertible {
        return new Quantity<double, DekaMetre>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetre to DeciMetre
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetre</param>
    /// <returns>quantity measured in DeciMetre</returns>
	public static Quantity<double, DeciMetre> ToDeciMetre<T>(this Quantity<T, ZettaMetre> val) where T:IConvertible {
        return new Quantity<double, DeciMetre>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetre to CentiMetre
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetre</param>
    /// <returns>quantity measured in CentiMetre</returns>
	public static Quantity<double, CentiMetre> ToCentiMetre<T>(this Quantity<T, ZettaMetre> val) where T:IConvertible {
        return new Quantity<double, CentiMetre>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetre to MilliMetre
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetre</param>
    /// <returns>quantity measured in MilliMetre</returns>
	public static Quantity<double, MilliMetre> ToMilliMetre<T>(this Quantity<T, ZettaMetre> val) where T:IConvertible {
        return new Quantity<double, MilliMetre>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetre to MicroMetre
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetre</param>
    /// <returns>quantity measured in MicroMetre</returns>
	public static Quantity<double, MicroMetre> ToMicroMetre<T>(this Quantity<T, ZettaMetre> val) where T:IConvertible {
        return new Quantity<double, MicroMetre>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetre to NanoMetre
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetre</param>
    /// <returns>quantity measured in NanoMetre</returns>
	public static Quantity<double, NanoMetre> ToNanoMetre<T>(this Quantity<T, ZettaMetre> val) where T:IConvertible {
        return new Quantity<double, NanoMetre>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetre to PicoMetre
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetre</param>
    /// <returns>quantity measured in PicoMetre</returns>
	public static Quantity<double, PicoMetre> ToPicoMetre<T>(this Quantity<T, ZettaMetre> val) where T:IConvertible {
        return new Quantity<double, PicoMetre>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetre to FemtoMetre
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetre</param>
    /// <returns>quantity measured in FemtoMetre</returns>
	public static Quantity<double, FemtoMetre> ToFemtoMetre<T>(this Quantity<T, ZettaMetre> val) where T:IConvertible {
        return new Quantity<double, FemtoMetre>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetre to AttoMetre
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetre</param>
    /// <returns>quantity measured in AttoMetre</returns>
	public static Quantity<double, AttoMetre> ToAttoMetre<T>(this Quantity<T, ZettaMetre> val) where T:IConvertible {
        return new Quantity<double, AttoMetre>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetre to ZeptoMetre
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetre</param>
    /// <returns>quantity measured in ZeptoMetre</returns>
	public static Quantity<double, ZeptoMetre> ToZeptoMetre<T>(this Quantity<T, ZettaMetre> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetre>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaMetre to YoctoMetre
    /// </summary>
    /// <param name="val">quantity measured in ZettaMetre</param>
    /// <returns>quantity measured in YoctoMetre</returns>
	public static Quantity<double, YoctoMetre> ToYoctoMetre<T>(this Quantity<T, ZettaMetre> val) where T:IConvertible {
        return new Quantity<double, YoctoMetre>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetre to YottaMetre
    /// </summary>
    /// <param name="val">quantity measured in ExaMetre</param>
    /// <returns>quantity measured in YottaMetre</returns>
	public static Quantity<double, YottaMetre> ToYottaMetre<T>(this Quantity<T, ExaMetre> val) where T:IConvertible {
        return new Quantity<double, YottaMetre>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetre to ZettaMetre
    /// </summary>
    /// <param name="val">quantity measured in ExaMetre</param>
    /// <returns>quantity measured in ZettaMetre</returns>
	public static Quantity<double, ZettaMetre> ToZettaMetre<T>(this Quantity<T, ExaMetre> val) where T:IConvertible {
        return new Quantity<double, ZettaMetre>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetre to PetaMetre
    /// </summary>
    /// <param name="val">quantity measured in ExaMetre</param>
    /// <returns>quantity measured in PetaMetre</returns>
	public static Quantity<double, PetaMetre> ToPetaMetre<T>(this Quantity<T, ExaMetre> val) where T:IConvertible {
        return new Quantity<double, PetaMetre>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetre to TeraMetre
    /// </summary>
    /// <param name="val">quantity measured in ExaMetre</param>
    /// <returns>quantity measured in TeraMetre</returns>
	public static Quantity<double, TeraMetre> ToTeraMetre<T>(this Quantity<T, ExaMetre> val) where T:IConvertible {
        return new Quantity<double, TeraMetre>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetre to GigaMetre
    /// </summary>
    /// <param name="val">quantity measured in ExaMetre</param>
    /// <returns>quantity measured in GigaMetre</returns>
	public static Quantity<double, GigaMetre> ToGigaMetre<T>(this Quantity<T, ExaMetre> val) where T:IConvertible {
        return new Quantity<double, GigaMetre>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetre to MegaMetre
    /// </summary>
    /// <param name="val">quantity measured in ExaMetre</param>
    /// <returns>quantity measured in MegaMetre</returns>
	public static Quantity<double, MegaMetre> ToMegaMetre<T>(this Quantity<T, ExaMetre> val) where T:IConvertible {
        return new Quantity<double, MegaMetre>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetre to KiloMetre
    /// </summary>
    /// <param name="val">quantity measured in ExaMetre</param>
    /// <returns>quantity measured in KiloMetre</returns>
	public static Quantity<double, KiloMetre> ToKiloMetre<T>(this Quantity<T, ExaMetre> val) where T:IConvertible {
        return new Quantity<double, KiloMetre>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetre to HectoMetre
    /// </summary>
    /// <param name="val">quantity measured in ExaMetre</param>
    /// <returns>quantity measured in HectoMetre</returns>
	public static Quantity<double, HectoMetre> ToHectoMetre<T>(this Quantity<T, ExaMetre> val) where T:IConvertible {
        return new Quantity<double, HectoMetre>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetre to DekaMetre
    /// </summary>
    /// <param name="val">quantity measured in ExaMetre</param>
    /// <returns>quantity measured in DekaMetre</returns>
	public static Quantity<double, DekaMetre> ToDekaMetre<T>(this Quantity<T, ExaMetre> val) where T:IConvertible {
        return new Quantity<double, DekaMetre>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetre to DeciMetre
    /// </summary>
    /// <param name="val">quantity measured in ExaMetre</param>
    /// <returns>quantity measured in DeciMetre</returns>
	public static Quantity<double, DeciMetre> ToDeciMetre<T>(this Quantity<T, ExaMetre> val) where T:IConvertible {
        return new Quantity<double, DeciMetre>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetre to CentiMetre
    /// </summary>
    /// <param name="val">quantity measured in ExaMetre</param>
    /// <returns>quantity measured in CentiMetre</returns>
	public static Quantity<double, CentiMetre> ToCentiMetre<T>(this Quantity<T, ExaMetre> val) where T:IConvertible {
        return new Quantity<double, CentiMetre>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetre to MilliMetre
    /// </summary>
    /// <param name="val">quantity measured in ExaMetre</param>
    /// <returns>quantity measured in MilliMetre</returns>
	public static Quantity<double, MilliMetre> ToMilliMetre<T>(this Quantity<T, ExaMetre> val) where T:IConvertible {
        return new Quantity<double, MilliMetre>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetre to MicroMetre
    /// </summary>
    /// <param name="val">quantity measured in ExaMetre</param>
    /// <returns>quantity measured in MicroMetre</returns>
	public static Quantity<double, MicroMetre> ToMicroMetre<T>(this Quantity<T, ExaMetre> val) where T:IConvertible {
        return new Quantity<double, MicroMetre>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetre to NanoMetre
    /// </summary>
    /// <param name="val">quantity measured in ExaMetre</param>
    /// <returns>quantity measured in NanoMetre</returns>
	public static Quantity<double, NanoMetre> ToNanoMetre<T>(this Quantity<T, ExaMetre> val) where T:IConvertible {
        return new Quantity<double, NanoMetre>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetre to PicoMetre
    /// </summary>
    /// <param name="val">quantity measured in ExaMetre</param>
    /// <returns>quantity measured in PicoMetre</returns>
	public static Quantity<double, PicoMetre> ToPicoMetre<T>(this Quantity<T, ExaMetre> val) where T:IConvertible {
        return new Quantity<double, PicoMetre>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetre to FemtoMetre
    /// </summary>
    /// <param name="val">quantity measured in ExaMetre</param>
    /// <returns>quantity measured in FemtoMetre</returns>
	public static Quantity<double, FemtoMetre> ToFemtoMetre<T>(this Quantity<T, ExaMetre> val) where T:IConvertible {
        return new Quantity<double, FemtoMetre>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetre to AttoMetre
    /// </summary>
    /// <param name="val">quantity measured in ExaMetre</param>
    /// <returns>quantity measured in AttoMetre</returns>
	public static Quantity<double, AttoMetre> ToAttoMetre<T>(this Quantity<T, ExaMetre> val) where T:IConvertible {
        return new Quantity<double, AttoMetre>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetre to ZeptoMetre
    /// </summary>
    /// <param name="val">quantity measured in ExaMetre</param>
    /// <returns>quantity measured in ZeptoMetre</returns>
	public static Quantity<double, ZeptoMetre> ToZeptoMetre<T>(this Quantity<T, ExaMetre> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetre>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaMetre to YoctoMetre
    /// </summary>
    /// <param name="val">quantity measured in ExaMetre</param>
    /// <returns>quantity measured in YoctoMetre</returns>
	public static Quantity<double, YoctoMetre> ToYoctoMetre<T>(this Quantity<T, ExaMetre> val) where T:IConvertible {
        return new Quantity<double, YoctoMetre>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetre to YottaMetre
    /// </summary>
    /// <param name="val">quantity measured in PetaMetre</param>
    /// <returns>quantity measured in YottaMetre</returns>
	public static Quantity<double, YottaMetre> ToYottaMetre<T>(this Quantity<T, PetaMetre> val) where T:IConvertible {
        return new Quantity<double, YottaMetre>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetre to ZettaMetre
    /// </summary>
    /// <param name="val">quantity measured in PetaMetre</param>
    /// <returns>quantity measured in ZettaMetre</returns>
	public static Quantity<double, ZettaMetre> ToZettaMetre<T>(this Quantity<T, PetaMetre> val) where T:IConvertible {
        return new Quantity<double, ZettaMetre>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetre to ExaMetre
    /// </summary>
    /// <param name="val">quantity measured in PetaMetre</param>
    /// <returns>quantity measured in ExaMetre</returns>
	public static Quantity<double, ExaMetre> ToExaMetre<T>(this Quantity<T, PetaMetre> val) where T:IConvertible {
        return new Quantity<double, ExaMetre>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetre to TeraMetre
    /// </summary>
    /// <param name="val">quantity measured in PetaMetre</param>
    /// <returns>quantity measured in TeraMetre</returns>
	public static Quantity<double, TeraMetre> ToTeraMetre<T>(this Quantity<T, PetaMetre> val) where T:IConvertible {
        return new Quantity<double, TeraMetre>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetre to GigaMetre
    /// </summary>
    /// <param name="val">quantity measured in PetaMetre</param>
    /// <returns>quantity measured in GigaMetre</returns>
	public static Quantity<double, GigaMetre> ToGigaMetre<T>(this Quantity<T, PetaMetre> val) where T:IConvertible {
        return new Quantity<double, GigaMetre>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetre to MegaMetre
    /// </summary>
    /// <param name="val">quantity measured in PetaMetre</param>
    /// <returns>quantity measured in MegaMetre</returns>
	public static Quantity<double, MegaMetre> ToMegaMetre<T>(this Quantity<T, PetaMetre> val) where T:IConvertible {
        return new Quantity<double, MegaMetre>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetre to KiloMetre
    /// </summary>
    /// <param name="val">quantity measured in PetaMetre</param>
    /// <returns>quantity measured in KiloMetre</returns>
	public static Quantity<double, KiloMetre> ToKiloMetre<T>(this Quantity<T, PetaMetre> val) where T:IConvertible {
        return new Quantity<double, KiloMetre>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetre to HectoMetre
    /// </summary>
    /// <param name="val">quantity measured in PetaMetre</param>
    /// <returns>quantity measured in HectoMetre</returns>
	public static Quantity<double, HectoMetre> ToHectoMetre<T>(this Quantity<T, PetaMetre> val) where T:IConvertible {
        return new Quantity<double, HectoMetre>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetre to DekaMetre
    /// </summary>
    /// <param name="val">quantity measured in PetaMetre</param>
    /// <returns>quantity measured in DekaMetre</returns>
	public static Quantity<double, DekaMetre> ToDekaMetre<T>(this Quantity<T, PetaMetre> val) where T:IConvertible {
        return new Quantity<double, DekaMetre>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetre to DeciMetre
    /// </summary>
    /// <param name="val">quantity measured in PetaMetre</param>
    /// <returns>quantity measured in DeciMetre</returns>
	public static Quantity<double, DeciMetre> ToDeciMetre<T>(this Quantity<T, PetaMetre> val) where T:IConvertible {
        return new Quantity<double, DeciMetre>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetre to CentiMetre
    /// </summary>
    /// <param name="val">quantity measured in PetaMetre</param>
    /// <returns>quantity measured in CentiMetre</returns>
	public static Quantity<double, CentiMetre> ToCentiMetre<T>(this Quantity<T, PetaMetre> val) where T:IConvertible {
        return new Quantity<double, CentiMetre>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetre to MilliMetre
    /// </summary>
    /// <param name="val">quantity measured in PetaMetre</param>
    /// <returns>quantity measured in MilliMetre</returns>
	public static Quantity<double, MilliMetre> ToMilliMetre<T>(this Quantity<T, PetaMetre> val) where T:IConvertible {
        return new Quantity<double, MilliMetre>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetre to MicroMetre
    /// </summary>
    /// <param name="val">quantity measured in PetaMetre</param>
    /// <returns>quantity measured in MicroMetre</returns>
	public static Quantity<double, MicroMetre> ToMicroMetre<T>(this Quantity<T, PetaMetre> val) where T:IConvertible {
        return new Quantity<double, MicroMetre>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetre to NanoMetre
    /// </summary>
    /// <param name="val">quantity measured in PetaMetre</param>
    /// <returns>quantity measured in NanoMetre</returns>
	public static Quantity<double, NanoMetre> ToNanoMetre<T>(this Quantity<T, PetaMetre> val) where T:IConvertible {
        return new Quantity<double, NanoMetre>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetre to PicoMetre
    /// </summary>
    /// <param name="val">quantity measured in PetaMetre</param>
    /// <returns>quantity measured in PicoMetre</returns>
	public static Quantity<double, PicoMetre> ToPicoMetre<T>(this Quantity<T, PetaMetre> val) where T:IConvertible {
        return new Quantity<double, PicoMetre>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetre to FemtoMetre
    /// </summary>
    /// <param name="val">quantity measured in PetaMetre</param>
    /// <returns>quantity measured in FemtoMetre</returns>
	public static Quantity<double, FemtoMetre> ToFemtoMetre<T>(this Quantity<T, PetaMetre> val) where T:IConvertible {
        return new Quantity<double, FemtoMetre>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetre to AttoMetre
    /// </summary>
    /// <param name="val">quantity measured in PetaMetre</param>
    /// <returns>quantity measured in AttoMetre</returns>
	public static Quantity<double, AttoMetre> ToAttoMetre<T>(this Quantity<T, PetaMetre> val) where T:IConvertible {
        return new Quantity<double, AttoMetre>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetre to ZeptoMetre
    /// </summary>
    /// <param name="val">quantity measured in PetaMetre</param>
    /// <returns>quantity measured in ZeptoMetre</returns>
	public static Quantity<double, ZeptoMetre> ToZeptoMetre<T>(this Quantity<T, PetaMetre> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetre>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaMetre to YoctoMetre
    /// </summary>
    /// <param name="val">quantity measured in PetaMetre</param>
    /// <returns>quantity measured in YoctoMetre</returns>
	public static Quantity<double, YoctoMetre> ToYoctoMetre<T>(this Quantity<T, PetaMetre> val) where T:IConvertible {
        return new Quantity<double, YoctoMetre>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetre to YottaMetre
    /// </summary>
    /// <param name="val">quantity measured in TeraMetre</param>
    /// <returns>quantity measured in YottaMetre</returns>
	public static Quantity<double, YottaMetre> ToYottaMetre<T>(this Quantity<T, TeraMetre> val) where T:IConvertible {
        return new Quantity<double, YottaMetre>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetre to ZettaMetre
    /// </summary>
    /// <param name="val">quantity measured in TeraMetre</param>
    /// <returns>quantity measured in ZettaMetre</returns>
	public static Quantity<double, ZettaMetre> ToZettaMetre<T>(this Quantity<T, TeraMetre> val) where T:IConvertible {
        return new Quantity<double, ZettaMetre>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetre to ExaMetre
    /// </summary>
    /// <param name="val">quantity measured in TeraMetre</param>
    /// <returns>quantity measured in ExaMetre</returns>
	public static Quantity<double, ExaMetre> ToExaMetre<T>(this Quantity<T, TeraMetre> val) where T:IConvertible {
        return new Quantity<double, ExaMetre>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetre to PetaMetre
    /// </summary>
    /// <param name="val">quantity measured in TeraMetre</param>
    /// <returns>quantity measured in PetaMetre</returns>
	public static Quantity<double, PetaMetre> ToPetaMetre<T>(this Quantity<T, TeraMetre> val) where T:IConvertible {
        return new Quantity<double, PetaMetre>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetre to GigaMetre
    /// </summary>
    /// <param name="val">quantity measured in TeraMetre</param>
    /// <returns>quantity measured in GigaMetre</returns>
	public static Quantity<double, GigaMetre> ToGigaMetre<T>(this Quantity<T, TeraMetre> val) where T:IConvertible {
        return new Quantity<double, GigaMetre>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetre to MegaMetre
    /// </summary>
    /// <param name="val">quantity measured in TeraMetre</param>
    /// <returns>quantity measured in MegaMetre</returns>
	public static Quantity<double, MegaMetre> ToMegaMetre<T>(this Quantity<T, TeraMetre> val) where T:IConvertible {
        return new Quantity<double, MegaMetre>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetre to KiloMetre
    /// </summary>
    /// <param name="val">quantity measured in TeraMetre</param>
    /// <returns>quantity measured in KiloMetre</returns>
	public static Quantity<double, KiloMetre> ToKiloMetre<T>(this Quantity<T, TeraMetre> val) where T:IConvertible {
        return new Quantity<double, KiloMetre>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetre to HectoMetre
    /// </summary>
    /// <param name="val">quantity measured in TeraMetre</param>
    /// <returns>quantity measured in HectoMetre</returns>
	public static Quantity<double, HectoMetre> ToHectoMetre<T>(this Quantity<T, TeraMetre> val) where T:IConvertible {
        return new Quantity<double, HectoMetre>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetre to DekaMetre
    /// </summary>
    /// <param name="val">quantity measured in TeraMetre</param>
    /// <returns>quantity measured in DekaMetre</returns>
	public static Quantity<double, DekaMetre> ToDekaMetre<T>(this Quantity<T, TeraMetre> val) where T:IConvertible {
        return new Quantity<double, DekaMetre>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetre to DeciMetre
    /// </summary>
    /// <param name="val">quantity measured in TeraMetre</param>
    /// <returns>quantity measured in DeciMetre</returns>
	public static Quantity<double, DeciMetre> ToDeciMetre<T>(this Quantity<T, TeraMetre> val) where T:IConvertible {
        return new Quantity<double, DeciMetre>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetre to CentiMetre
    /// </summary>
    /// <param name="val">quantity measured in TeraMetre</param>
    /// <returns>quantity measured in CentiMetre</returns>
	public static Quantity<double, CentiMetre> ToCentiMetre<T>(this Quantity<T, TeraMetre> val) where T:IConvertible {
        return new Quantity<double, CentiMetre>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetre to MilliMetre
    /// </summary>
    /// <param name="val">quantity measured in TeraMetre</param>
    /// <returns>quantity measured in MilliMetre</returns>
	public static Quantity<double, MilliMetre> ToMilliMetre<T>(this Quantity<T, TeraMetre> val) where T:IConvertible {
        return new Quantity<double, MilliMetre>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetre to MicroMetre
    /// </summary>
    /// <param name="val">quantity measured in TeraMetre</param>
    /// <returns>quantity measured in MicroMetre</returns>
	public static Quantity<double, MicroMetre> ToMicroMetre<T>(this Quantity<T, TeraMetre> val) where T:IConvertible {
        return new Quantity<double, MicroMetre>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetre to NanoMetre
    /// </summary>
    /// <param name="val">quantity measured in TeraMetre</param>
    /// <returns>quantity measured in NanoMetre</returns>
	public static Quantity<double, NanoMetre> ToNanoMetre<T>(this Quantity<T, TeraMetre> val) where T:IConvertible {
        return new Quantity<double, NanoMetre>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetre to PicoMetre
    /// </summary>
    /// <param name="val">quantity measured in TeraMetre</param>
    /// <returns>quantity measured in PicoMetre</returns>
	public static Quantity<double, PicoMetre> ToPicoMetre<T>(this Quantity<T, TeraMetre> val) where T:IConvertible {
        return new Quantity<double, PicoMetre>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetre to FemtoMetre
    /// </summary>
    /// <param name="val">quantity measured in TeraMetre</param>
    /// <returns>quantity measured in FemtoMetre</returns>
	public static Quantity<double, FemtoMetre> ToFemtoMetre<T>(this Quantity<T, TeraMetre> val) where T:IConvertible {
        return new Quantity<double, FemtoMetre>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetre to AttoMetre
    /// </summary>
    /// <param name="val">quantity measured in TeraMetre</param>
    /// <returns>quantity measured in AttoMetre</returns>
	public static Quantity<double, AttoMetre> ToAttoMetre<T>(this Quantity<T, TeraMetre> val) where T:IConvertible {
        return new Quantity<double, AttoMetre>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetre to ZeptoMetre
    /// </summary>
    /// <param name="val">quantity measured in TeraMetre</param>
    /// <returns>quantity measured in ZeptoMetre</returns>
	public static Quantity<double, ZeptoMetre> ToZeptoMetre<T>(this Quantity<T, TeraMetre> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetre>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraMetre to YoctoMetre
    /// </summary>
    /// <param name="val">quantity measured in TeraMetre</param>
    /// <returns>quantity measured in YoctoMetre</returns>
	public static Quantity<double, YoctoMetre> ToYoctoMetre<T>(this Quantity<T, TeraMetre> val) where T:IConvertible {
        return new Quantity<double, YoctoMetre>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetre to YottaMetre
    /// </summary>
    /// <param name="val">quantity measured in GigaMetre</param>
    /// <returns>quantity measured in YottaMetre</returns>
	public static Quantity<double, YottaMetre> ToYottaMetre<T>(this Quantity<T, GigaMetre> val) where T:IConvertible {
        return new Quantity<double, YottaMetre>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetre to ZettaMetre
    /// </summary>
    /// <param name="val">quantity measured in GigaMetre</param>
    /// <returns>quantity measured in ZettaMetre</returns>
	public static Quantity<double, ZettaMetre> ToZettaMetre<T>(this Quantity<T, GigaMetre> val) where T:IConvertible {
        return new Quantity<double, ZettaMetre>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetre to ExaMetre
    /// </summary>
    /// <param name="val">quantity measured in GigaMetre</param>
    /// <returns>quantity measured in ExaMetre</returns>
	public static Quantity<double, ExaMetre> ToExaMetre<T>(this Quantity<T, GigaMetre> val) where T:IConvertible {
        return new Quantity<double, ExaMetre>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetre to PetaMetre
    /// </summary>
    /// <param name="val">quantity measured in GigaMetre</param>
    /// <returns>quantity measured in PetaMetre</returns>
	public static Quantity<double, PetaMetre> ToPetaMetre<T>(this Quantity<T, GigaMetre> val) where T:IConvertible {
        return new Quantity<double, PetaMetre>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetre to TeraMetre
    /// </summary>
    /// <param name="val">quantity measured in GigaMetre</param>
    /// <returns>quantity measured in TeraMetre</returns>
	public static Quantity<double, TeraMetre> ToTeraMetre<T>(this Quantity<T, GigaMetre> val) where T:IConvertible {
        return new Quantity<double, TeraMetre>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetre to MegaMetre
    /// </summary>
    /// <param name="val">quantity measured in GigaMetre</param>
    /// <returns>quantity measured in MegaMetre</returns>
	public static Quantity<double, MegaMetre> ToMegaMetre<T>(this Quantity<T, GigaMetre> val) where T:IConvertible {
        return new Quantity<double, MegaMetre>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetre to KiloMetre
    /// </summary>
    /// <param name="val">quantity measured in GigaMetre</param>
    /// <returns>quantity measured in KiloMetre</returns>
	public static Quantity<double, KiloMetre> ToKiloMetre<T>(this Quantity<T, GigaMetre> val) where T:IConvertible {
        return new Quantity<double, KiloMetre>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetre to HectoMetre
    /// </summary>
    /// <param name="val">quantity measured in GigaMetre</param>
    /// <returns>quantity measured in HectoMetre</returns>
	public static Quantity<double, HectoMetre> ToHectoMetre<T>(this Quantity<T, GigaMetre> val) where T:IConvertible {
        return new Quantity<double, HectoMetre>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetre to DekaMetre
    /// </summary>
    /// <param name="val">quantity measured in GigaMetre</param>
    /// <returns>quantity measured in DekaMetre</returns>
	public static Quantity<double, DekaMetre> ToDekaMetre<T>(this Quantity<T, GigaMetre> val) where T:IConvertible {
        return new Quantity<double, DekaMetre>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetre to DeciMetre
    /// </summary>
    /// <param name="val">quantity measured in GigaMetre</param>
    /// <returns>quantity measured in DeciMetre</returns>
	public static Quantity<double, DeciMetre> ToDeciMetre<T>(this Quantity<T, GigaMetre> val) where T:IConvertible {
        return new Quantity<double, DeciMetre>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetre to CentiMetre
    /// </summary>
    /// <param name="val">quantity measured in GigaMetre</param>
    /// <returns>quantity measured in CentiMetre</returns>
	public static Quantity<double, CentiMetre> ToCentiMetre<T>(this Quantity<T, GigaMetre> val) where T:IConvertible {
        return new Quantity<double, CentiMetre>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetre to MilliMetre
    /// </summary>
    /// <param name="val">quantity measured in GigaMetre</param>
    /// <returns>quantity measured in MilliMetre</returns>
	public static Quantity<double, MilliMetre> ToMilliMetre<T>(this Quantity<T, GigaMetre> val) where T:IConvertible {
        return new Quantity<double, MilliMetre>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetre to MicroMetre
    /// </summary>
    /// <param name="val">quantity measured in GigaMetre</param>
    /// <returns>quantity measured in MicroMetre</returns>
	public static Quantity<double, MicroMetre> ToMicroMetre<T>(this Quantity<T, GigaMetre> val) where T:IConvertible {
        return new Quantity<double, MicroMetre>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetre to NanoMetre
    /// </summary>
    /// <param name="val">quantity measured in GigaMetre</param>
    /// <returns>quantity measured in NanoMetre</returns>
	public static Quantity<double, NanoMetre> ToNanoMetre<T>(this Quantity<T, GigaMetre> val) where T:IConvertible {
        return new Quantity<double, NanoMetre>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetre to PicoMetre
    /// </summary>
    /// <param name="val">quantity measured in GigaMetre</param>
    /// <returns>quantity measured in PicoMetre</returns>
	public static Quantity<double, PicoMetre> ToPicoMetre<T>(this Quantity<T, GigaMetre> val) where T:IConvertible {
        return new Quantity<double, PicoMetre>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetre to FemtoMetre
    /// </summary>
    /// <param name="val">quantity measured in GigaMetre</param>
    /// <returns>quantity measured in FemtoMetre</returns>
	public static Quantity<double, FemtoMetre> ToFemtoMetre<T>(this Quantity<T, GigaMetre> val) where T:IConvertible {
        return new Quantity<double, FemtoMetre>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetre to AttoMetre
    /// </summary>
    /// <param name="val">quantity measured in GigaMetre</param>
    /// <returns>quantity measured in AttoMetre</returns>
	public static Quantity<double, AttoMetre> ToAttoMetre<T>(this Quantity<T, GigaMetre> val) where T:IConvertible {
        return new Quantity<double, AttoMetre>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetre to ZeptoMetre
    /// </summary>
    /// <param name="val">quantity measured in GigaMetre</param>
    /// <returns>quantity measured in ZeptoMetre</returns>
	public static Quantity<double, ZeptoMetre> ToZeptoMetre<T>(this Quantity<T, GigaMetre> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetre>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaMetre to YoctoMetre
    /// </summary>
    /// <param name="val">quantity measured in GigaMetre</param>
    /// <returns>quantity measured in YoctoMetre</returns>
	public static Quantity<double, YoctoMetre> ToYoctoMetre<T>(this Quantity<T, GigaMetre> val) where T:IConvertible {
        return new Quantity<double, YoctoMetre>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetre to YottaMetre
    /// </summary>
    /// <param name="val">quantity measured in MegaMetre</param>
    /// <returns>quantity measured in YottaMetre</returns>
	public static Quantity<double, YottaMetre> ToYottaMetre<T>(this Quantity<T, MegaMetre> val) where T:IConvertible {
        return new Quantity<double, YottaMetre>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetre to ZettaMetre
    /// </summary>
    /// <param name="val">quantity measured in MegaMetre</param>
    /// <returns>quantity measured in ZettaMetre</returns>
	public static Quantity<double, ZettaMetre> ToZettaMetre<T>(this Quantity<T, MegaMetre> val) where T:IConvertible {
        return new Quantity<double, ZettaMetre>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetre to ExaMetre
    /// </summary>
    /// <param name="val">quantity measured in MegaMetre</param>
    /// <returns>quantity measured in ExaMetre</returns>
	public static Quantity<double, ExaMetre> ToExaMetre<T>(this Quantity<T, MegaMetre> val) where T:IConvertible {
        return new Quantity<double, ExaMetre>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetre to PetaMetre
    /// </summary>
    /// <param name="val">quantity measured in MegaMetre</param>
    /// <returns>quantity measured in PetaMetre</returns>
	public static Quantity<double, PetaMetre> ToPetaMetre<T>(this Quantity<T, MegaMetre> val) where T:IConvertible {
        return new Quantity<double, PetaMetre>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetre to TeraMetre
    /// </summary>
    /// <param name="val">quantity measured in MegaMetre</param>
    /// <returns>quantity measured in TeraMetre</returns>
	public static Quantity<double, TeraMetre> ToTeraMetre<T>(this Quantity<T, MegaMetre> val) where T:IConvertible {
        return new Quantity<double, TeraMetre>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetre to GigaMetre
    /// </summary>
    /// <param name="val">quantity measured in MegaMetre</param>
    /// <returns>quantity measured in GigaMetre</returns>
	public static Quantity<double, GigaMetre> ToGigaMetre<T>(this Quantity<T, MegaMetre> val) where T:IConvertible {
        return new Quantity<double, GigaMetre>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetre to KiloMetre
    /// </summary>
    /// <param name="val">quantity measured in MegaMetre</param>
    /// <returns>quantity measured in KiloMetre</returns>
	public static Quantity<double, KiloMetre> ToKiloMetre<T>(this Quantity<T, MegaMetre> val) where T:IConvertible {
        return new Quantity<double, KiloMetre>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetre to HectoMetre
    /// </summary>
    /// <param name="val">quantity measured in MegaMetre</param>
    /// <returns>quantity measured in HectoMetre</returns>
	public static Quantity<double, HectoMetre> ToHectoMetre<T>(this Quantity<T, MegaMetre> val) where T:IConvertible {
        return new Quantity<double, HectoMetre>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetre to DekaMetre
    /// </summary>
    /// <param name="val">quantity measured in MegaMetre</param>
    /// <returns>quantity measured in DekaMetre</returns>
	public static Quantity<double, DekaMetre> ToDekaMetre<T>(this Quantity<T, MegaMetre> val) where T:IConvertible {
        return new Quantity<double, DekaMetre>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetre to DeciMetre
    /// </summary>
    /// <param name="val">quantity measured in MegaMetre</param>
    /// <returns>quantity measured in DeciMetre</returns>
	public static Quantity<double, DeciMetre> ToDeciMetre<T>(this Quantity<T, MegaMetre> val) where T:IConvertible {
        return new Quantity<double, DeciMetre>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetre to CentiMetre
    /// </summary>
    /// <param name="val">quantity measured in MegaMetre</param>
    /// <returns>quantity measured in CentiMetre</returns>
	public static Quantity<double, CentiMetre> ToCentiMetre<T>(this Quantity<T, MegaMetre> val) where T:IConvertible {
        return new Quantity<double, CentiMetre>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetre to MilliMetre
    /// </summary>
    /// <param name="val">quantity measured in MegaMetre</param>
    /// <returns>quantity measured in MilliMetre</returns>
	public static Quantity<double, MilliMetre> ToMilliMetre<T>(this Quantity<T, MegaMetre> val) where T:IConvertible {
        return new Quantity<double, MilliMetre>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetre to MicroMetre
    /// </summary>
    /// <param name="val">quantity measured in MegaMetre</param>
    /// <returns>quantity measured in MicroMetre</returns>
	public static Quantity<double, MicroMetre> ToMicroMetre<T>(this Quantity<T, MegaMetre> val) where T:IConvertible {
        return new Quantity<double, MicroMetre>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetre to NanoMetre
    /// </summary>
    /// <param name="val">quantity measured in MegaMetre</param>
    /// <returns>quantity measured in NanoMetre</returns>
	public static Quantity<double, NanoMetre> ToNanoMetre<T>(this Quantity<T, MegaMetre> val) where T:IConvertible {
        return new Quantity<double, NanoMetre>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetre to PicoMetre
    /// </summary>
    /// <param name="val">quantity measured in MegaMetre</param>
    /// <returns>quantity measured in PicoMetre</returns>
	public static Quantity<double, PicoMetre> ToPicoMetre<T>(this Quantity<T, MegaMetre> val) where T:IConvertible {
        return new Quantity<double, PicoMetre>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetre to FemtoMetre
    /// </summary>
    /// <param name="val">quantity measured in MegaMetre</param>
    /// <returns>quantity measured in FemtoMetre</returns>
	public static Quantity<double, FemtoMetre> ToFemtoMetre<T>(this Quantity<T, MegaMetre> val) where T:IConvertible {
        return new Quantity<double, FemtoMetre>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetre to AttoMetre
    /// </summary>
    /// <param name="val">quantity measured in MegaMetre</param>
    /// <returns>quantity measured in AttoMetre</returns>
	public static Quantity<double, AttoMetre> ToAttoMetre<T>(this Quantity<T, MegaMetre> val) where T:IConvertible {
        return new Quantity<double, AttoMetre>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetre to ZeptoMetre
    /// </summary>
    /// <param name="val">quantity measured in MegaMetre</param>
    /// <returns>quantity measured in ZeptoMetre</returns>
	public static Quantity<double, ZeptoMetre> ToZeptoMetre<T>(this Quantity<T, MegaMetre> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetre>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaMetre to YoctoMetre
    /// </summary>
    /// <param name="val">quantity measured in MegaMetre</param>
    /// <returns>quantity measured in YoctoMetre</returns>
	public static Quantity<double, YoctoMetre> ToYoctoMetre<T>(this Quantity<T, MegaMetre> val) where T:IConvertible {
        return new Quantity<double, YoctoMetre>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetre to YottaMetre
    /// </summary>
    /// <param name="val">quantity measured in KiloMetre</param>
    /// <returns>quantity measured in YottaMetre</returns>
	public static Quantity<double, YottaMetre> ToYottaMetre<T>(this Quantity<T, KiloMetre> val) where T:IConvertible {
        return new Quantity<double, YottaMetre>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetre to ZettaMetre
    /// </summary>
    /// <param name="val">quantity measured in KiloMetre</param>
    /// <returns>quantity measured in ZettaMetre</returns>
	public static Quantity<double, ZettaMetre> ToZettaMetre<T>(this Quantity<T, KiloMetre> val) where T:IConvertible {
        return new Quantity<double, ZettaMetre>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetre to ExaMetre
    /// </summary>
    /// <param name="val">quantity measured in KiloMetre</param>
    /// <returns>quantity measured in ExaMetre</returns>
	public static Quantity<double, ExaMetre> ToExaMetre<T>(this Quantity<T, KiloMetre> val) where T:IConvertible {
        return new Quantity<double, ExaMetre>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetre to PetaMetre
    /// </summary>
    /// <param name="val">quantity measured in KiloMetre</param>
    /// <returns>quantity measured in PetaMetre</returns>
	public static Quantity<double, PetaMetre> ToPetaMetre<T>(this Quantity<T, KiloMetre> val) where T:IConvertible {
        return new Quantity<double, PetaMetre>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetre to TeraMetre
    /// </summary>
    /// <param name="val">quantity measured in KiloMetre</param>
    /// <returns>quantity measured in TeraMetre</returns>
	public static Quantity<double, TeraMetre> ToTeraMetre<T>(this Quantity<T, KiloMetre> val) where T:IConvertible {
        return new Quantity<double, TeraMetre>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetre to GigaMetre
    /// </summary>
    /// <param name="val">quantity measured in KiloMetre</param>
    /// <returns>quantity measured in GigaMetre</returns>
	public static Quantity<double, GigaMetre> ToGigaMetre<T>(this Quantity<T, KiloMetre> val) where T:IConvertible {
        return new Quantity<double, GigaMetre>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetre to MegaMetre
    /// </summary>
    /// <param name="val">quantity measured in KiloMetre</param>
    /// <returns>quantity measured in MegaMetre</returns>
	public static Quantity<double, MegaMetre> ToMegaMetre<T>(this Quantity<T, KiloMetre> val) where T:IConvertible {
        return new Quantity<double, MegaMetre>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetre to HectoMetre
    /// </summary>
    /// <param name="val">quantity measured in KiloMetre</param>
    /// <returns>quantity measured in HectoMetre</returns>
	public static Quantity<double, HectoMetre> ToHectoMetre<T>(this Quantity<T, KiloMetre> val) where T:IConvertible {
        return new Quantity<double, HectoMetre>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetre to DekaMetre
    /// </summary>
    /// <param name="val">quantity measured in KiloMetre</param>
    /// <returns>quantity measured in DekaMetre</returns>
	public static Quantity<double, DekaMetre> ToDekaMetre<T>(this Quantity<T, KiloMetre> val) where T:IConvertible {
        return new Quantity<double, DekaMetre>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetre to DeciMetre
    /// </summary>
    /// <param name="val">quantity measured in KiloMetre</param>
    /// <returns>quantity measured in DeciMetre</returns>
	public static Quantity<double, DeciMetre> ToDeciMetre<T>(this Quantity<T, KiloMetre> val) where T:IConvertible {
        return new Quantity<double, DeciMetre>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetre to CentiMetre
    /// </summary>
    /// <param name="val">quantity measured in KiloMetre</param>
    /// <returns>quantity measured in CentiMetre</returns>
	public static Quantity<double, CentiMetre> ToCentiMetre<T>(this Quantity<T, KiloMetre> val) where T:IConvertible {
        return new Quantity<double, CentiMetre>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetre to MilliMetre
    /// </summary>
    /// <param name="val">quantity measured in KiloMetre</param>
    /// <returns>quantity measured in MilliMetre</returns>
	public static Quantity<double, MilliMetre> ToMilliMetre<T>(this Quantity<T, KiloMetre> val) where T:IConvertible {
        return new Quantity<double, MilliMetre>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetre to MicroMetre
    /// </summary>
    /// <param name="val">quantity measured in KiloMetre</param>
    /// <returns>quantity measured in MicroMetre</returns>
	public static Quantity<double, MicroMetre> ToMicroMetre<T>(this Quantity<T, KiloMetre> val) where T:IConvertible {
        return new Quantity<double, MicroMetre>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetre to NanoMetre
    /// </summary>
    /// <param name="val">quantity measured in KiloMetre</param>
    /// <returns>quantity measured in NanoMetre</returns>
	public static Quantity<double, NanoMetre> ToNanoMetre<T>(this Quantity<T, KiloMetre> val) where T:IConvertible {
        return new Quantity<double, NanoMetre>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetre to PicoMetre
    /// </summary>
    /// <param name="val">quantity measured in KiloMetre</param>
    /// <returns>quantity measured in PicoMetre</returns>
	public static Quantity<double, PicoMetre> ToPicoMetre<T>(this Quantity<T, KiloMetre> val) where T:IConvertible {
        return new Quantity<double, PicoMetre>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetre to FemtoMetre
    /// </summary>
    /// <param name="val">quantity measured in KiloMetre</param>
    /// <returns>quantity measured in FemtoMetre</returns>
	public static Quantity<double, FemtoMetre> ToFemtoMetre<T>(this Quantity<T, KiloMetre> val) where T:IConvertible {
        return new Quantity<double, FemtoMetre>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetre to AttoMetre
    /// </summary>
    /// <param name="val">quantity measured in KiloMetre</param>
    /// <returns>quantity measured in AttoMetre</returns>
	public static Quantity<double, AttoMetre> ToAttoMetre<T>(this Quantity<T, KiloMetre> val) where T:IConvertible {
        return new Quantity<double, AttoMetre>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetre to ZeptoMetre
    /// </summary>
    /// <param name="val">quantity measured in KiloMetre</param>
    /// <returns>quantity measured in ZeptoMetre</returns>
	public static Quantity<double, ZeptoMetre> ToZeptoMetre<T>(this Quantity<T, KiloMetre> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetre>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloMetre to YoctoMetre
    /// </summary>
    /// <param name="val">quantity measured in KiloMetre</param>
    /// <returns>quantity measured in YoctoMetre</returns>
	public static Quantity<double, YoctoMetre> ToYoctoMetre<T>(this Quantity<T, KiloMetre> val) where T:IConvertible {
        return new Quantity<double, YoctoMetre>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetre to YottaMetre
    /// </summary>
    /// <param name="val">quantity measured in HectoMetre</param>
    /// <returns>quantity measured in YottaMetre</returns>
	public static Quantity<double, YottaMetre> ToYottaMetre<T>(this Quantity<T, HectoMetre> val) where T:IConvertible {
        return new Quantity<double, YottaMetre>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetre to ZettaMetre
    /// </summary>
    /// <param name="val">quantity measured in HectoMetre</param>
    /// <returns>quantity measured in ZettaMetre</returns>
	public static Quantity<double, ZettaMetre> ToZettaMetre<T>(this Quantity<T, HectoMetre> val) where T:IConvertible {
        return new Quantity<double, ZettaMetre>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetre to ExaMetre
    /// </summary>
    /// <param name="val">quantity measured in HectoMetre</param>
    /// <returns>quantity measured in ExaMetre</returns>
	public static Quantity<double, ExaMetre> ToExaMetre<T>(this Quantity<T, HectoMetre> val) where T:IConvertible {
        return new Quantity<double, ExaMetre>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetre to PetaMetre
    /// </summary>
    /// <param name="val">quantity measured in HectoMetre</param>
    /// <returns>quantity measured in PetaMetre</returns>
	public static Quantity<double, PetaMetre> ToPetaMetre<T>(this Quantity<T, HectoMetre> val) where T:IConvertible {
        return new Quantity<double, PetaMetre>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetre to TeraMetre
    /// </summary>
    /// <param name="val">quantity measured in HectoMetre</param>
    /// <returns>quantity measured in TeraMetre</returns>
	public static Quantity<double, TeraMetre> ToTeraMetre<T>(this Quantity<T, HectoMetre> val) where T:IConvertible {
        return new Quantity<double, TeraMetre>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetre to GigaMetre
    /// </summary>
    /// <param name="val">quantity measured in HectoMetre</param>
    /// <returns>quantity measured in GigaMetre</returns>
	public static Quantity<double, GigaMetre> ToGigaMetre<T>(this Quantity<T, HectoMetre> val) where T:IConvertible {
        return new Quantity<double, GigaMetre>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetre to MegaMetre
    /// </summary>
    /// <param name="val">quantity measured in HectoMetre</param>
    /// <returns>quantity measured in MegaMetre</returns>
	public static Quantity<double, MegaMetre> ToMegaMetre<T>(this Quantity<T, HectoMetre> val) where T:IConvertible {
        return new Quantity<double, MegaMetre>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetre to KiloMetre
    /// </summary>
    /// <param name="val">quantity measured in HectoMetre</param>
    /// <returns>quantity measured in KiloMetre</returns>
	public static Quantity<double, KiloMetre> ToKiloMetre<T>(this Quantity<T, HectoMetre> val) where T:IConvertible {
        return new Quantity<double, KiloMetre>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetre to DekaMetre
    /// </summary>
    /// <param name="val">quantity measured in HectoMetre</param>
    /// <returns>quantity measured in DekaMetre</returns>
	public static Quantity<double, DekaMetre> ToDekaMetre<T>(this Quantity<T, HectoMetre> val) where T:IConvertible {
        return new Quantity<double, DekaMetre>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetre to DeciMetre
    /// </summary>
    /// <param name="val">quantity measured in HectoMetre</param>
    /// <returns>quantity measured in DeciMetre</returns>
	public static Quantity<double, DeciMetre> ToDeciMetre<T>(this Quantity<T, HectoMetre> val) where T:IConvertible {
        return new Quantity<double, DeciMetre>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetre to CentiMetre
    /// </summary>
    /// <param name="val">quantity measured in HectoMetre</param>
    /// <returns>quantity measured in CentiMetre</returns>
	public static Quantity<double, CentiMetre> ToCentiMetre<T>(this Quantity<T, HectoMetre> val) where T:IConvertible {
        return new Quantity<double, CentiMetre>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetre to MilliMetre
    /// </summary>
    /// <param name="val">quantity measured in HectoMetre</param>
    /// <returns>quantity measured in MilliMetre</returns>
	public static Quantity<double, MilliMetre> ToMilliMetre<T>(this Quantity<T, HectoMetre> val) where T:IConvertible {
        return new Quantity<double, MilliMetre>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetre to MicroMetre
    /// </summary>
    /// <param name="val">quantity measured in HectoMetre</param>
    /// <returns>quantity measured in MicroMetre</returns>
	public static Quantity<double, MicroMetre> ToMicroMetre<T>(this Quantity<T, HectoMetre> val) where T:IConvertible {
        return new Quantity<double, MicroMetre>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetre to NanoMetre
    /// </summary>
    /// <param name="val">quantity measured in HectoMetre</param>
    /// <returns>quantity measured in NanoMetre</returns>
	public static Quantity<double, NanoMetre> ToNanoMetre<T>(this Quantity<T, HectoMetre> val) where T:IConvertible {
        return new Quantity<double, NanoMetre>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetre to PicoMetre
    /// </summary>
    /// <param name="val">quantity measured in HectoMetre</param>
    /// <returns>quantity measured in PicoMetre</returns>
	public static Quantity<double, PicoMetre> ToPicoMetre<T>(this Quantity<T, HectoMetre> val) where T:IConvertible {
        return new Quantity<double, PicoMetre>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetre to FemtoMetre
    /// </summary>
    /// <param name="val">quantity measured in HectoMetre</param>
    /// <returns>quantity measured in FemtoMetre</returns>
	public static Quantity<double, FemtoMetre> ToFemtoMetre<T>(this Quantity<T, HectoMetre> val) where T:IConvertible {
        return new Quantity<double, FemtoMetre>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetre to AttoMetre
    /// </summary>
    /// <param name="val">quantity measured in HectoMetre</param>
    /// <returns>quantity measured in AttoMetre</returns>
	public static Quantity<double, AttoMetre> ToAttoMetre<T>(this Quantity<T, HectoMetre> val) where T:IConvertible {
        return new Quantity<double, AttoMetre>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetre to ZeptoMetre
    /// </summary>
    /// <param name="val">quantity measured in HectoMetre</param>
    /// <returns>quantity measured in ZeptoMetre</returns>
	public static Quantity<double, ZeptoMetre> ToZeptoMetre<T>(this Quantity<T, HectoMetre> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetre>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoMetre to YoctoMetre
    /// </summary>
    /// <param name="val">quantity measured in HectoMetre</param>
    /// <returns>quantity measured in YoctoMetre</returns>
	public static Quantity<double, YoctoMetre> ToYoctoMetre<T>(this Quantity<T, HectoMetre> val) where T:IConvertible {
        return new Quantity<double, YoctoMetre>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetre to YottaMetre
    /// </summary>
    /// <param name="val">quantity measured in DekaMetre</param>
    /// <returns>quantity measured in YottaMetre</returns>
	public static Quantity<double, YottaMetre> ToYottaMetre<T>(this Quantity<T, DekaMetre> val) where T:IConvertible {
        return new Quantity<double, YottaMetre>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetre to ZettaMetre
    /// </summary>
    /// <param name="val">quantity measured in DekaMetre</param>
    /// <returns>quantity measured in ZettaMetre</returns>
	public static Quantity<double, ZettaMetre> ToZettaMetre<T>(this Quantity<T, DekaMetre> val) where T:IConvertible {
        return new Quantity<double, ZettaMetre>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetre to ExaMetre
    /// </summary>
    /// <param name="val">quantity measured in DekaMetre</param>
    /// <returns>quantity measured in ExaMetre</returns>
	public static Quantity<double, ExaMetre> ToExaMetre<T>(this Quantity<T, DekaMetre> val) where T:IConvertible {
        return new Quantity<double, ExaMetre>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetre to PetaMetre
    /// </summary>
    /// <param name="val">quantity measured in DekaMetre</param>
    /// <returns>quantity measured in PetaMetre</returns>
	public static Quantity<double, PetaMetre> ToPetaMetre<T>(this Quantity<T, DekaMetre> val) where T:IConvertible {
        return new Quantity<double, PetaMetre>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetre to TeraMetre
    /// </summary>
    /// <param name="val">quantity measured in DekaMetre</param>
    /// <returns>quantity measured in TeraMetre</returns>
	public static Quantity<double, TeraMetre> ToTeraMetre<T>(this Quantity<T, DekaMetre> val) where T:IConvertible {
        return new Quantity<double, TeraMetre>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetre to GigaMetre
    /// </summary>
    /// <param name="val">quantity measured in DekaMetre</param>
    /// <returns>quantity measured in GigaMetre</returns>
	public static Quantity<double, GigaMetre> ToGigaMetre<T>(this Quantity<T, DekaMetre> val) where T:IConvertible {
        return new Quantity<double, GigaMetre>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetre to MegaMetre
    /// </summary>
    /// <param name="val">quantity measured in DekaMetre</param>
    /// <returns>quantity measured in MegaMetre</returns>
	public static Quantity<double, MegaMetre> ToMegaMetre<T>(this Quantity<T, DekaMetre> val) where T:IConvertible {
        return new Quantity<double, MegaMetre>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetre to KiloMetre
    /// </summary>
    /// <param name="val">quantity measured in DekaMetre</param>
    /// <returns>quantity measured in KiloMetre</returns>
	public static Quantity<double, KiloMetre> ToKiloMetre<T>(this Quantity<T, DekaMetre> val) where T:IConvertible {
        return new Quantity<double, KiloMetre>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetre to HectoMetre
    /// </summary>
    /// <param name="val">quantity measured in DekaMetre</param>
    /// <returns>quantity measured in HectoMetre</returns>
	public static Quantity<double, HectoMetre> ToHectoMetre<T>(this Quantity<T, DekaMetre> val) where T:IConvertible {
        return new Quantity<double, HectoMetre>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetre to DeciMetre
    /// </summary>
    /// <param name="val">quantity measured in DekaMetre</param>
    /// <returns>quantity measured in DeciMetre</returns>
	public static Quantity<double, DeciMetre> ToDeciMetre<T>(this Quantity<T, DekaMetre> val) where T:IConvertible {
        return new Quantity<double, DeciMetre>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetre to CentiMetre
    /// </summary>
    /// <param name="val">quantity measured in DekaMetre</param>
    /// <returns>quantity measured in CentiMetre</returns>
	public static Quantity<double, CentiMetre> ToCentiMetre<T>(this Quantity<T, DekaMetre> val) where T:IConvertible {
        return new Quantity<double, CentiMetre>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetre to MilliMetre
    /// </summary>
    /// <param name="val">quantity measured in DekaMetre</param>
    /// <returns>quantity measured in MilliMetre</returns>
	public static Quantity<double, MilliMetre> ToMilliMetre<T>(this Quantity<T, DekaMetre> val) where T:IConvertible {
        return new Quantity<double, MilliMetre>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetre to MicroMetre
    /// </summary>
    /// <param name="val">quantity measured in DekaMetre</param>
    /// <returns>quantity measured in MicroMetre</returns>
	public static Quantity<double, MicroMetre> ToMicroMetre<T>(this Quantity<T, DekaMetre> val) where T:IConvertible {
        return new Quantity<double, MicroMetre>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetre to NanoMetre
    /// </summary>
    /// <param name="val">quantity measured in DekaMetre</param>
    /// <returns>quantity measured in NanoMetre</returns>
	public static Quantity<double, NanoMetre> ToNanoMetre<T>(this Quantity<T, DekaMetre> val) where T:IConvertible {
        return new Quantity<double, NanoMetre>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetre to PicoMetre
    /// </summary>
    /// <param name="val">quantity measured in DekaMetre</param>
    /// <returns>quantity measured in PicoMetre</returns>
	public static Quantity<double, PicoMetre> ToPicoMetre<T>(this Quantity<T, DekaMetre> val) where T:IConvertible {
        return new Quantity<double, PicoMetre>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetre to FemtoMetre
    /// </summary>
    /// <param name="val">quantity measured in DekaMetre</param>
    /// <returns>quantity measured in FemtoMetre</returns>
	public static Quantity<double, FemtoMetre> ToFemtoMetre<T>(this Quantity<T, DekaMetre> val) where T:IConvertible {
        return new Quantity<double, FemtoMetre>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetre to AttoMetre
    /// </summary>
    /// <param name="val">quantity measured in DekaMetre</param>
    /// <returns>quantity measured in AttoMetre</returns>
	public static Quantity<double, AttoMetre> ToAttoMetre<T>(this Quantity<T, DekaMetre> val) where T:IConvertible {
        return new Quantity<double, AttoMetre>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetre to ZeptoMetre
    /// </summary>
    /// <param name="val">quantity measured in DekaMetre</param>
    /// <returns>quantity measured in ZeptoMetre</returns>
	public static Quantity<double, ZeptoMetre> ToZeptoMetre<T>(this Quantity<T, DekaMetre> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetre>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaMetre to YoctoMetre
    /// </summary>
    /// <param name="val">quantity measured in DekaMetre</param>
    /// <returns>quantity measured in YoctoMetre</returns>
	public static Quantity<double, YoctoMetre> ToYoctoMetre<T>(this Quantity<T, DekaMetre> val) where T:IConvertible {
        return new Quantity<double, YoctoMetre>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetre to YottaMetre
    /// </summary>
    /// <param name="val">quantity measured in DeciMetre</param>
    /// <returns>quantity measured in YottaMetre</returns>
	public static Quantity<double, YottaMetre> ToYottaMetre<T>(this Quantity<T, DeciMetre> val) where T:IConvertible {
        return new Quantity<double, YottaMetre>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetre to ZettaMetre
    /// </summary>
    /// <param name="val">quantity measured in DeciMetre</param>
    /// <returns>quantity measured in ZettaMetre</returns>
	public static Quantity<double, ZettaMetre> ToZettaMetre<T>(this Quantity<T, DeciMetre> val) where T:IConvertible {
        return new Quantity<double, ZettaMetre>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetre to ExaMetre
    /// </summary>
    /// <param name="val">quantity measured in DeciMetre</param>
    /// <returns>quantity measured in ExaMetre</returns>
	public static Quantity<double, ExaMetre> ToExaMetre<T>(this Quantity<T, DeciMetre> val) where T:IConvertible {
        return new Quantity<double, ExaMetre>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetre to PetaMetre
    /// </summary>
    /// <param name="val">quantity measured in DeciMetre</param>
    /// <returns>quantity measured in PetaMetre</returns>
	public static Quantity<double, PetaMetre> ToPetaMetre<T>(this Quantity<T, DeciMetre> val) where T:IConvertible {
        return new Quantity<double, PetaMetre>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetre to TeraMetre
    /// </summary>
    /// <param name="val">quantity measured in DeciMetre</param>
    /// <returns>quantity measured in TeraMetre</returns>
	public static Quantity<double, TeraMetre> ToTeraMetre<T>(this Quantity<T, DeciMetre> val) where T:IConvertible {
        return new Quantity<double, TeraMetre>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetre to GigaMetre
    /// </summary>
    /// <param name="val">quantity measured in DeciMetre</param>
    /// <returns>quantity measured in GigaMetre</returns>
	public static Quantity<double, GigaMetre> ToGigaMetre<T>(this Quantity<T, DeciMetre> val) where T:IConvertible {
        return new Quantity<double, GigaMetre>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetre to MegaMetre
    /// </summary>
    /// <param name="val">quantity measured in DeciMetre</param>
    /// <returns>quantity measured in MegaMetre</returns>
	public static Quantity<double, MegaMetre> ToMegaMetre<T>(this Quantity<T, DeciMetre> val) where T:IConvertible {
        return new Quantity<double, MegaMetre>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetre to KiloMetre
    /// </summary>
    /// <param name="val">quantity measured in DeciMetre</param>
    /// <returns>quantity measured in KiloMetre</returns>
	public static Quantity<double, KiloMetre> ToKiloMetre<T>(this Quantity<T, DeciMetre> val) where T:IConvertible {
        return new Quantity<double, KiloMetre>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetre to HectoMetre
    /// </summary>
    /// <param name="val">quantity measured in DeciMetre</param>
    /// <returns>quantity measured in HectoMetre</returns>
	public static Quantity<double, HectoMetre> ToHectoMetre<T>(this Quantity<T, DeciMetre> val) where T:IConvertible {
        return new Quantity<double, HectoMetre>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetre to DekaMetre
    /// </summary>
    /// <param name="val">quantity measured in DeciMetre</param>
    /// <returns>quantity measured in DekaMetre</returns>
	public static Quantity<double, DekaMetre> ToDekaMetre<T>(this Quantity<T, DeciMetre> val) where T:IConvertible {
        return new Quantity<double, DekaMetre>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetre to CentiMetre
    /// </summary>
    /// <param name="val">quantity measured in DeciMetre</param>
    /// <returns>quantity measured in CentiMetre</returns>
	public static Quantity<double, CentiMetre> ToCentiMetre<T>(this Quantity<T, DeciMetre> val) where T:IConvertible {
        return new Quantity<double, CentiMetre>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetre to MilliMetre
    /// </summary>
    /// <param name="val">quantity measured in DeciMetre</param>
    /// <returns>quantity measured in MilliMetre</returns>
	public static Quantity<double, MilliMetre> ToMilliMetre<T>(this Quantity<T, DeciMetre> val) where T:IConvertible {
        return new Quantity<double, MilliMetre>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetre to MicroMetre
    /// </summary>
    /// <param name="val">quantity measured in DeciMetre</param>
    /// <returns>quantity measured in MicroMetre</returns>
	public static Quantity<double, MicroMetre> ToMicroMetre<T>(this Quantity<T, DeciMetre> val) where T:IConvertible {
        return new Quantity<double, MicroMetre>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetre to NanoMetre
    /// </summary>
    /// <param name="val">quantity measured in DeciMetre</param>
    /// <returns>quantity measured in NanoMetre</returns>
	public static Quantity<double, NanoMetre> ToNanoMetre<T>(this Quantity<T, DeciMetre> val) where T:IConvertible {
        return new Quantity<double, NanoMetre>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetre to PicoMetre
    /// </summary>
    /// <param name="val">quantity measured in DeciMetre</param>
    /// <returns>quantity measured in PicoMetre</returns>
	public static Quantity<double, PicoMetre> ToPicoMetre<T>(this Quantity<T, DeciMetre> val) where T:IConvertible {
        return new Quantity<double, PicoMetre>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetre to FemtoMetre
    /// </summary>
    /// <param name="val">quantity measured in DeciMetre</param>
    /// <returns>quantity measured in FemtoMetre</returns>
	public static Quantity<double, FemtoMetre> ToFemtoMetre<T>(this Quantity<T, DeciMetre> val) where T:IConvertible {
        return new Quantity<double, FemtoMetre>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetre to AttoMetre
    /// </summary>
    /// <param name="val">quantity measured in DeciMetre</param>
    /// <returns>quantity measured in AttoMetre</returns>
	public static Quantity<double, AttoMetre> ToAttoMetre<T>(this Quantity<T, DeciMetre> val) where T:IConvertible {
        return new Quantity<double, AttoMetre>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetre to ZeptoMetre
    /// </summary>
    /// <param name="val">quantity measured in DeciMetre</param>
    /// <returns>quantity measured in ZeptoMetre</returns>
	public static Quantity<double, ZeptoMetre> ToZeptoMetre<T>(this Quantity<T, DeciMetre> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetre>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciMetre to YoctoMetre
    /// </summary>
    /// <param name="val">quantity measured in DeciMetre</param>
    /// <returns>quantity measured in YoctoMetre</returns>
	public static Quantity<double, YoctoMetre> ToYoctoMetre<T>(this Quantity<T, DeciMetre> val) where T:IConvertible {
        return new Quantity<double, YoctoMetre>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetre to YottaMetre
    /// </summary>
    /// <param name="val">quantity measured in CentiMetre</param>
    /// <returns>quantity measured in YottaMetre</returns>
	public static Quantity<double, YottaMetre> ToYottaMetre<T>(this Quantity<T, CentiMetre> val) where T:IConvertible {
        return new Quantity<double, YottaMetre>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetre to ZettaMetre
    /// </summary>
    /// <param name="val">quantity measured in CentiMetre</param>
    /// <returns>quantity measured in ZettaMetre</returns>
	public static Quantity<double, ZettaMetre> ToZettaMetre<T>(this Quantity<T, CentiMetre> val) where T:IConvertible {
        return new Quantity<double, ZettaMetre>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetre to ExaMetre
    /// </summary>
    /// <param name="val">quantity measured in CentiMetre</param>
    /// <returns>quantity measured in ExaMetre</returns>
	public static Quantity<double, ExaMetre> ToExaMetre<T>(this Quantity<T, CentiMetre> val) where T:IConvertible {
        return new Quantity<double, ExaMetre>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetre to PetaMetre
    /// </summary>
    /// <param name="val">quantity measured in CentiMetre</param>
    /// <returns>quantity measured in PetaMetre</returns>
	public static Quantity<double, PetaMetre> ToPetaMetre<T>(this Quantity<T, CentiMetre> val) where T:IConvertible {
        return new Quantity<double, PetaMetre>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetre to TeraMetre
    /// </summary>
    /// <param name="val">quantity measured in CentiMetre</param>
    /// <returns>quantity measured in TeraMetre</returns>
	public static Quantity<double, TeraMetre> ToTeraMetre<T>(this Quantity<T, CentiMetre> val) where T:IConvertible {
        return new Quantity<double, TeraMetre>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetre to GigaMetre
    /// </summary>
    /// <param name="val">quantity measured in CentiMetre</param>
    /// <returns>quantity measured in GigaMetre</returns>
	public static Quantity<double, GigaMetre> ToGigaMetre<T>(this Quantity<T, CentiMetre> val) where T:IConvertible {
        return new Quantity<double, GigaMetre>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetre to MegaMetre
    /// </summary>
    /// <param name="val">quantity measured in CentiMetre</param>
    /// <returns>quantity measured in MegaMetre</returns>
	public static Quantity<double, MegaMetre> ToMegaMetre<T>(this Quantity<T, CentiMetre> val) where T:IConvertible {
        return new Quantity<double, MegaMetre>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetre to KiloMetre
    /// </summary>
    /// <param name="val">quantity measured in CentiMetre</param>
    /// <returns>quantity measured in KiloMetre</returns>
	public static Quantity<double, KiloMetre> ToKiloMetre<T>(this Quantity<T, CentiMetre> val) where T:IConvertible {
        return new Quantity<double, KiloMetre>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetre to HectoMetre
    /// </summary>
    /// <param name="val">quantity measured in CentiMetre</param>
    /// <returns>quantity measured in HectoMetre</returns>
	public static Quantity<double, HectoMetre> ToHectoMetre<T>(this Quantity<T, CentiMetre> val) where T:IConvertible {
        return new Quantity<double, HectoMetre>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetre to DekaMetre
    /// </summary>
    /// <param name="val">quantity measured in CentiMetre</param>
    /// <returns>quantity measured in DekaMetre</returns>
	public static Quantity<double, DekaMetre> ToDekaMetre<T>(this Quantity<T, CentiMetre> val) where T:IConvertible {
        return new Quantity<double, DekaMetre>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetre to DeciMetre
    /// </summary>
    /// <param name="val">quantity measured in CentiMetre</param>
    /// <returns>quantity measured in DeciMetre</returns>
	public static Quantity<double, DeciMetre> ToDeciMetre<T>(this Quantity<T, CentiMetre> val) where T:IConvertible {
        return new Quantity<double, DeciMetre>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetre to MilliMetre
    /// </summary>
    /// <param name="val">quantity measured in CentiMetre</param>
    /// <returns>quantity measured in MilliMetre</returns>
	public static Quantity<double, MilliMetre> ToMilliMetre<T>(this Quantity<T, CentiMetre> val) where T:IConvertible {
        return new Quantity<double, MilliMetre>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetre to MicroMetre
    /// </summary>
    /// <param name="val">quantity measured in CentiMetre</param>
    /// <returns>quantity measured in MicroMetre</returns>
	public static Quantity<double, MicroMetre> ToMicroMetre<T>(this Quantity<T, CentiMetre> val) where T:IConvertible {
        return new Quantity<double, MicroMetre>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetre to NanoMetre
    /// </summary>
    /// <param name="val">quantity measured in CentiMetre</param>
    /// <returns>quantity measured in NanoMetre</returns>
	public static Quantity<double, NanoMetre> ToNanoMetre<T>(this Quantity<T, CentiMetre> val) where T:IConvertible {
        return new Quantity<double, NanoMetre>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetre to PicoMetre
    /// </summary>
    /// <param name="val">quantity measured in CentiMetre</param>
    /// <returns>quantity measured in PicoMetre</returns>
	public static Quantity<double, PicoMetre> ToPicoMetre<T>(this Quantity<T, CentiMetre> val) where T:IConvertible {
        return new Quantity<double, PicoMetre>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetre to FemtoMetre
    /// </summary>
    /// <param name="val">quantity measured in CentiMetre</param>
    /// <returns>quantity measured in FemtoMetre</returns>
	public static Quantity<double, FemtoMetre> ToFemtoMetre<T>(this Quantity<T, CentiMetre> val) where T:IConvertible {
        return new Quantity<double, FemtoMetre>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetre to AttoMetre
    /// </summary>
    /// <param name="val">quantity measured in CentiMetre</param>
    /// <returns>quantity measured in AttoMetre</returns>
	public static Quantity<double, AttoMetre> ToAttoMetre<T>(this Quantity<T, CentiMetre> val) where T:IConvertible {
        return new Quantity<double, AttoMetre>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetre to ZeptoMetre
    /// </summary>
    /// <param name="val">quantity measured in CentiMetre</param>
    /// <returns>quantity measured in ZeptoMetre</returns>
	public static Quantity<double, ZeptoMetre> ToZeptoMetre<T>(this Quantity<T, CentiMetre> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetre>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiMetre to YoctoMetre
    /// </summary>
    /// <param name="val">quantity measured in CentiMetre</param>
    /// <returns>quantity measured in YoctoMetre</returns>
	public static Quantity<double, YoctoMetre> ToYoctoMetre<T>(this Quantity<T, CentiMetre> val) where T:IConvertible {
        return new Quantity<double, YoctoMetre>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetre to YottaMetre
    /// </summary>
    /// <param name="val">quantity measured in MilliMetre</param>
    /// <returns>quantity measured in YottaMetre</returns>
	public static Quantity<double, YottaMetre> ToYottaMetre<T>(this Quantity<T, MilliMetre> val) where T:IConvertible {
        return new Quantity<double, YottaMetre>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetre to ZettaMetre
    /// </summary>
    /// <param name="val">quantity measured in MilliMetre</param>
    /// <returns>quantity measured in ZettaMetre</returns>
	public static Quantity<double, ZettaMetre> ToZettaMetre<T>(this Quantity<T, MilliMetre> val) where T:IConvertible {
        return new Quantity<double, ZettaMetre>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetre to ExaMetre
    /// </summary>
    /// <param name="val">quantity measured in MilliMetre</param>
    /// <returns>quantity measured in ExaMetre</returns>
	public static Quantity<double, ExaMetre> ToExaMetre<T>(this Quantity<T, MilliMetre> val) where T:IConvertible {
        return new Quantity<double, ExaMetre>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetre to PetaMetre
    /// </summary>
    /// <param name="val">quantity measured in MilliMetre</param>
    /// <returns>quantity measured in PetaMetre</returns>
	public static Quantity<double, PetaMetre> ToPetaMetre<T>(this Quantity<T, MilliMetre> val) where T:IConvertible {
        return new Quantity<double, PetaMetre>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetre to TeraMetre
    /// </summary>
    /// <param name="val">quantity measured in MilliMetre</param>
    /// <returns>quantity measured in TeraMetre</returns>
	public static Quantity<double, TeraMetre> ToTeraMetre<T>(this Quantity<T, MilliMetre> val) where T:IConvertible {
        return new Quantity<double, TeraMetre>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetre to GigaMetre
    /// </summary>
    /// <param name="val">quantity measured in MilliMetre</param>
    /// <returns>quantity measured in GigaMetre</returns>
	public static Quantity<double, GigaMetre> ToGigaMetre<T>(this Quantity<T, MilliMetre> val) where T:IConvertible {
        return new Quantity<double, GigaMetre>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetre to MegaMetre
    /// </summary>
    /// <param name="val">quantity measured in MilliMetre</param>
    /// <returns>quantity measured in MegaMetre</returns>
	public static Quantity<double, MegaMetre> ToMegaMetre<T>(this Quantity<T, MilliMetre> val) where T:IConvertible {
        return new Quantity<double, MegaMetre>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetre to KiloMetre
    /// </summary>
    /// <param name="val">quantity measured in MilliMetre</param>
    /// <returns>quantity measured in KiloMetre</returns>
	public static Quantity<double, KiloMetre> ToKiloMetre<T>(this Quantity<T, MilliMetre> val) where T:IConvertible {
        return new Quantity<double, KiloMetre>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetre to HectoMetre
    /// </summary>
    /// <param name="val">quantity measured in MilliMetre</param>
    /// <returns>quantity measured in HectoMetre</returns>
	public static Quantity<double, HectoMetre> ToHectoMetre<T>(this Quantity<T, MilliMetre> val) where T:IConvertible {
        return new Quantity<double, HectoMetre>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetre to DekaMetre
    /// </summary>
    /// <param name="val">quantity measured in MilliMetre</param>
    /// <returns>quantity measured in DekaMetre</returns>
	public static Quantity<double, DekaMetre> ToDekaMetre<T>(this Quantity<T, MilliMetre> val) where T:IConvertible {
        return new Quantity<double, DekaMetre>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetre to DeciMetre
    /// </summary>
    /// <param name="val">quantity measured in MilliMetre</param>
    /// <returns>quantity measured in DeciMetre</returns>
	public static Quantity<double, DeciMetre> ToDeciMetre<T>(this Quantity<T, MilliMetre> val) where T:IConvertible {
        return new Quantity<double, DeciMetre>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetre to CentiMetre
    /// </summary>
    /// <param name="val">quantity measured in MilliMetre</param>
    /// <returns>quantity measured in CentiMetre</returns>
	public static Quantity<double, CentiMetre> ToCentiMetre<T>(this Quantity<T, MilliMetre> val) where T:IConvertible {
        return new Quantity<double, CentiMetre>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetre to MicroMetre
    /// </summary>
    /// <param name="val">quantity measured in MilliMetre</param>
    /// <returns>quantity measured in MicroMetre</returns>
	public static Quantity<double, MicroMetre> ToMicroMetre<T>(this Quantity<T, MilliMetre> val) where T:IConvertible {
        return new Quantity<double, MicroMetre>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetre to NanoMetre
    /// </summary>
    /// <param name="val">quantity measured in MilliMetre</param>
    /// <returns>quantity measured in NanoMetre</returns>
	public static Quantity<double, NanoMetre> ToNanoMetre<T>(this Quantity<T, MilliMetre> val) where T:IConvertible {
        return new Quantity<double, NanoMetre>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetre to PicoMetre
    /// </summary>
    /// <param name="val">quantity measured in MilliMetre</param>
    /// <returns>quantity measured in PicoMetre</returns>
	public static Quantity<double, PicoMetre> ToPicoMetre<T>(this Quantity<T, MilliMetre> val) where T:IConvertible {
        return new Quantity<double, PicoMetre>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetre to FemtoMetre
    /// </summary>
    /// <param name="val">quantity measured in MilliMetre</param>
    /// <returns>quantity measured in FemtoMetre</returns>
	public static Quantity<double, FemtoMetre> ToFemtoMetre<T>(this Quantity<T, MilliMetre> val) where T:IConvertible {
        return new Quantity<double, FemtoMetre>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetre to AttoMetre
    /// </summary>
    /// <param name="val">quantity measured in MilliMetre</param>
    /// <returns>quantity measured in AttoMetre</returns>
	public static Quantity<double, AttoMetre> ToAttoMetre<T>(this Quantity<T, MilliMetre> val) where T:IConvertible {
        return new Quantity<double, AttoMetre>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetre to ZeptoMetre
    /// </summary>
    /// <param name="val">quantity measured in MilliMetre</param>
    /// <returns>quantity measured in ZeptoMetre</returns>
	public static Quantity<double, ZeptoMetre> ToZeptoMetre<T>(this Quantity<T, MilliMetre> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetre>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliMetre to YoctoMetre
    /// </summary>
    /// <param name="val">quantity measured in MilliMetre</param>
    /// <returns>quantity measured in YoctoMetre</returns>
	public static Quantity<double, YoctoMetre> ToYoctoMetre<T>(this Quantity<T, MilliMetre> val) where T:IConvertible {
        return new Quantity<double, YoctoMetre>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetre to YottaMetre
    /// </summary>
    /// <param name="val">quantity measured in MicroMetre</param>
    /// <returns>quantity measured in YottaMetre</returns>
	public static Quantity<double, YottaMetre> ToYottaMetre<T>(this Quantity<T, MicroMetre> val) where T:IConvertible {
        return new Quantity<double, YottaMetre>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetre to ZettaMetre
    /// </summary>
    /// <param name="val">quantity measured in MicroMetre</param>
    /// <returns>quantity measured in ZettaMetre</returns>
	public static Quantity<double, ZettaMetre> ToZettaMetre<T>(this Quantity<T, MicroMetre> val) where T:IConvertible {
        return new Quantity<double, ZettaMetre>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetre to ExaMetre
    /// </summary>
    /// <param name="val">quantity measured in MicroMetre</param>
    /// <returns>quantity measured in ExaMetre</returns>
	public static Quantity<double, ExaMetre> ToExaMetre<T>(this Quantity<T, MicroMetre> val) where T:IConvertible {
        return new Quantity<double, ExaMetre>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetre to PetaMetre
    /// </summary>
    /// <param name="val">quantity measured in MicroMetre</param>
    /// <returns>quantity measured in PetaMetre</returns>
	public static Quantity<double, PetaMetre> ToPetaMetre<T>(this Quantity<T, MicroMetre> val) where T:IConvertible {
        return new Quantity<double, PetaMetre>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetre to TeraMetre
    /// </summary>
    /// <param name="val">quantity measured in MicroMetre</param>
    /// <returns>quantity measured in TeraMetre</returns>
	public static Quantity<double, TeraMetre> ToTeraMetre<T>(this Quantity<T, MicroMetre> val) where T:IConvertible {
        return new Quantity<double, TeraMetre>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetre to GigaMetre
    /// </summary>
    /// <param name="val">quantity measured in MicroMetre</param>
    /// <returns>quantity measured in GigaMetre</returns>
	public static Quantity<double, GigaMetre> ToGigaMetre<T>(this Quantity<T, MicroMetre> val) where T:IConvertible {
        return new Quantity<double, GigaMetre>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetre to MegaMetre
    /// </summary>
    /// <param name="val">quantity measured in MicroMetre</param>
    /// <returns>quantity measured in MegaMetre</returns>
	public static Quantity<double, MegaMetre> ToMegaMetre<T>(this Quantity<T, MicroMetre> val) where T:IConvertible {
        return new Quantity<double, MegaMetre>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetre to KiloMetre
    /// </summary>
    /// <param name="val">quantity measured in MicroMetre</param>
    /// <returns>quantity measured in KiloMetre</returns>
	public static Quantity<double, KiloMetre> ToKiloMetre<T>(this Quantity<T, MicroMetre> val) where T:IConvertible {
        return new Quantity<double, KiloMetre>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetre to HectoMetre
    /// </summary>
    /// <param name="val">quantity measured in MicroMetre</param>
    /// <returns>quantity measured in HectoMetre</returns>
	public static Quantity<double, HectoMetre> ToHectoMetre<T>(this Quantity<T, MicroMetre> val) where T:IConvertible {
        return new Quantity<double, HectoMetre>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetre to DekaMetre
    /// </summary>
    /// <param name="val">quantity measured in MicroMetre</param>
    /// <returns>quantity measured in DekaMetre</returns>
	public static Quantity<double, DekaMetre> ToDekaMetre<T>(this Quantity<T, MicroMetre> val) where T:IConvertible {
        return new Quantity<double, DekaMetre>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetre to DeciMetre
    /// </summary>
    /// <param name="val">quantity measured in MicroMetre</param>
    /// <returns>quantity measured in DeciMetre</returns>
	public static Quantity<double, DeciMetre> ToDeciMetre<T>(this Quantity<T, MicroMetre> val) where T:IConvertible {
        return new Quantity<double, DeciMetre>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetre to CentiMetre
    /// </summary>
    /// <param name="val">quantity measured in MicroMetre</param>
    /// <returns>quantity measured in CentiMetre</returns>
	public static Quantity<double, CentiMetre> ToCentiMetre<T>(this Quantity<T, MicroMetre> val) where T:IConvertible {
        return new Quantity<double, CentiMetre>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetre to MilliMetre
    /// </summary>
    /// <param name="val">quantity measured in MicroMetre</param>
    /// <returns>quantity measured in MilliMetre</returns>
	public static Quantity<double, MilliMetre> ToMilliMetre<T>(this Quantity<T, MicroMetre> val) where T:IConvertible {
        return new Quantity<double, MilliMetre>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetre to NanoMetre
    /// </summary>
    /// <param name="val">quantity measured in MicroMetre</param>
    /// <returns>quantity measured in NanoMetre</returns>
	public static Quantity<double, NanoMetre> ToNanoMetre<T>(this Quantity<T, MicroMetre> val) where T:IConvertible {
        return new Quantity<double, NanoMetre>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetre to PicoMetre
    /// </summary>
    /// <param name="val">quantity measured in MicroMetre</param>
    /// <returns>quantity measured in PicoMetre</returns>
	public static Quantity<double, PicoMetre> ToPicoMetre<T>(this Quantity<T, MicroMetre> val) where T:IConvertible {
        return new Quantity<double, PicoMetre>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetre to FemtoMetre
    /// </summary>
    /// <param name="val">quantity measured in MicroMetre</param>
    /// <returns>quantity measured in FemtoMetre</returns>
	public static Quantity<double, FemtoMetre> ToFemtoMetre<T>(this Quantity<T, MicroMetre> val) where T:IConvertible {
        return new Quantity<double, FemtoMetre>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetre to AttoMetre
    /// </summary>
    /// <param name="val">quantity measured in MicroMetre</param>
    /// <returns>quantity measured in AttoMetre</returns>
	public static Quantity<double, AttoMetre> ToAttoMetre<T>(this Quantity<T, MicroMetre> val) where T:IConvertible {
        return new Quantity<double, AttoMetre>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetre to ZeptoMetre
    /// </summary>
    /// <param name="val">quantity measured in MicroMetre</param>
    /// <returns>quantity measured in ZeptoMetre</returns>
	public static Quantity<double, ZeptoMetre> ToZeptoMetre<T>(this Quantity<T, MicroMetre> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetre>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroMetre to YoctoMetre
    /// </summary>
    /// <param name="val">quantity measured in MicroMetre</param>
    /// <returns>quantity measured in YoctoMetre</returns>
	public static Quantity<double, YoctoMetre> ToYoctoMetre<T>(this Quantity<T, MicroMetre> val) where T:IConvertible {
        return new Quantity<double, YoctoMetre>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetre to YottaMetre
    /// </summary>
    /// <param name="val">quantity measured in NanoMetre</param>
    /// <returns>quantity measured in YottaMetre</returns>
	public static Quantity<double, YottaMetre> ToYottaMetre<T>(this Quantity<T, NanoMetre> val) where T:IConvertible {
        return new Quantity<double, YottaMetre>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetre to ZettaMetre
    /// </summary>
    /// <param name="val">quantity measured in NanoMetre</param>
    /// <returns>quantity measured in ZettaMetre</returns>
	public static Quantity<double, ZettaMetre> ToZettaMetre<T>(this Quantity<T, NanoMetre> val) where T:IConvertible {
        return new Quantity<double, ZettaMetre>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetre to ExaMetre
    /// </summary>
    /// <param name="val">quantity measured in NanoMetre</param>
    /// <returns>quantity measured in ExaMetre</returns>
	public static Quantity<double, ExaMetre> ToExaMetre<T>(this Quantity<T, NanoMetre> val) where T:IConvertible {
        return new Quantity<double, ExaMetre>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetre to PetaMetre
    /// </summary>
    /// <param name="val">quantity measured in NanoMetre</param>
    /// <returns>quantity measured in PetaMetre</returns>
	public static Quantity<double, PetaMetre> ToPetaMetre<T>(this Quantity<T, NanoMetre> val) where T:IConvertible {
        return new Quantity<double, PetaMetre>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetre to TeraMetre
    /// </summary>
    /// <param name="val">quantity measured in NanoMetre</param>
    /// <returns>quantity measured in TeraMetre</returns>
	public static Quantity<double, TeraMetre> ToTeraMetre<T>(this Quantity<T, NanoMetre> val) where T:IConvertible {
        return new Quantity<double, TeraMetre>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetre to GigaMetre
    /// </summary>
    /// <param name="val">quantity measured in NanoMetre</param>
    /// <returns>quantity measured in GigaMetre</returns>
	public static Quantity<double, GigaMetre> ToGigaMetre<T>(this Quantity<T, NanoMetre> val) where T:IConvertible {
        return new Quantity<double, GigaMetre>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetre to MegaMetre
    /// </summary>
    /// <param name="val">quantity measured in NanoMetre</param>
    /// <returns>quantity measured in MegaMetre</returns>
	public static Quantity<double, MegaMetre> ToMegaMetre<T>(this Quantity<T, NanoMetre> val) where T:IConvertible {
        return new Quantity<double, MegaMetre>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetre to KiloMetre
    /// </summary>
    /// <param name="val">quantity measured in NanoMetre</param>
    /// <returns>quantity measured in KiloMetre</returns>
	public static Quantity<double, KiloMetre> ToKiloMetre<T>(this Quantity<T, NanoMetre> val) where T:IConvertible {
        return new Quantity<double, KiloMetre>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetre to HectoMetre
    /// </summary>
    /// <param name="val">quantity measured in NanoMetre</param>
    /// <returns>quantity measured in HectoMetre</returns>
	public static Quantity<double, HectoMetre> ToHectoMetre<T>(this Quantity<T, NanoMetre> val) where T:IConvertible {
        return new Quantity<double, HectoMetre>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetre to DekaMetre
    /// </summary>
    /// <param name="val">quantity measured in NanoMetre</param>
    /// <returns>quantity measured in DekaMetre</returns>
	public static Quantity<double, DekaMetre> ToDekaMetre<T>(this Quantity<T, NanoMetre> val) where T:IConvertible {
        return new Quantity<double, DekaMetre>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetre to DeciMetre
    /// </summary>
    /// <param name="val">quantity measured in NanoMetre</param>
    /// <returns>quantity measured in DeciMetre</returns>
	public static Quantity<double, DeciMetre> ToDeciMetre<T>(this Quantity<T, NanoMetre> val) where T:IConvertible {
        return new Quantity<double, DeciMetre>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetre to CentiMetre
    /// </summary>
    /// <param name="val">quantity measured in NanoMetre</param>
    /// <returns>quantity measured in CentiMetre</returns>
	public static Quantity<double, CentiMetre> ToCentiMetre<T>(this Quantity<T, NanoMetre> val) where T:IConvertible {
        return new Quantity<double, CentiMetre>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetre to MilliMetre
    /// </summary>
    /// <param name="val">quantity measured in NanoMetre</param>
    /// <returns>quantity measured in MilliMetre</returns>
	public static Quantity<double, MilliMetre> ToMilliMetre<T>(this Quantity<T, NanoMetre> val) where T:IConvertible {
        return new Quantity<double, MilliMetre>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetre to MicroMetre
    /// </summary>
    /// <param name="val">quantity measured in NanoMetre</param>
    /// <returns>quantity measured in MicroMetre</returns>
	public static Quantity<double, MicroMetre> ToMicroMetre<T>(this Quantity<T, NanoMetre> val) where T:IConvertible {
        return new Quantity<double, MicroMetre>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetre to PicoMetre
    /// </summary>
    /// <param name="val">quantity measured in NanoMetre</param>
    /// <returns>quantity measured in PicoMetre</returns>
	public static Quantity<double, PicoMetre> ToPicoMetre<T>(this Quantity<T, NanoMetre> val) where T:IConvertible {
        return new Quantity<double, PicoMetre>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetre to FemtoMetre
    /// </summary>
    /// <param name="val">quantity measured in NanoMetre</param>
    /// <returns>quantity measured in FemtoMetre</returns>
	public static Quantity<double, FemtoMetre> ToFemtoMetre<T>(this Quantity<T, NanoMetre> val) where T:IConvertible {
        return new Quantity<double, FemtoMetre>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetre to AttoMetre
    /// </summary>
    /// <param name="val">quantity measured in NanoMetre</param>
    /// <returns>quantity measured in AttoMetre</returns>
	public static Quantity<double, AttoMetre> ToAttoMetre<T>(this Quantity<T, NanoMetre> val) where T:IConvertible {
        return new Quantity<double, AttoMetre>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetre to ZeptoMetre
    /// </summary>
    /// <param name="val">quantity measured in NanoMetre</param>
    /// <returns>quantity measured in ZeptoMetre</returns>
	public static Quantity<double, ZeptoMetre> ToZeptoMetre<T>(this Quantity<T, NanoMetre> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetre>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoMetre to YoctoMetre
    /// </summary>
    /// <param name="val">quantity measured in NanoMetre</param>
    /// <returns>quantity measured in YoctoMetre</returns>
	public static Quantity<double, YoctoMetre> ToYoctoMetre<T>(this Quantity<T, NanoMetre> val) where T:IConvertible {
        return new Quantity<double, YoctoMetre>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetre to YottaMetre
    /// </summary>
    /// <param name="val">quantity measured in PicoMetre</param>
    /// <returns>quantity measured in YottaMetre</returns>
	public static Quantity<double, YottaMetre> ToYottaMetre<T>(this Quantity<T, PicoMetre> val) where T:IConvertible {
        return new Quantity<double, YottaMetre>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetre to ZettaMetre
    /// </summary>
    /// <param name="val">quantity measured in PicoMetre</param>
    /// <returns>quantity measured in ZettaMetre</returns>
	public static Quantity<double, ZettaMetre> ToZettaMetre<T>(this Quantity<T, PicoMetre> val) where T:IConvertible {
        return new Quantity<double, ZettaMetre>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetre to ExaMetre
    /// </summary>
    /// <param name="val">quantity measured in PicoMetre</param>
    /// <returns>quantity measured in ExaMetre</returns>
	public static Quantity<double, ExaMetre> ToExaMetre<T>(this Quantity<T, PicoMetre> val) where T:IConvertible {
        return new Quantity<double, ExaMetre>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetre to PetaMetre
    /// </summary>
    /// <param name="val">quantity measured in PicoMetre</param>
    /// <returns>quantity measured in PetaMetre</returns>
	public static Quantity<double, PetaMetre> ToPetaMetre<T>(this Quantity<T, PicoMetre> val) where T:IConvertible {
        return new Quantity<double, PetaMetre>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetre to TeraMetre
    /// </summary>
    /// <param name="val">quantity measured in PicoMetre</param>
    /// <returns>quantity measured in TeraMetre</returns>
	public static Quantity<double, TeraMetre> ToTeraMetre<T>(this Quantity<T, PicoMetre> val) where T:IConvertible {
        return new Quantity<double, TeraMetre>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetre to GigaMetre
    /// </summary>
    /// <param name="val">quantity measured in PicoMetre</param>
    /// <returns>quantity measured in GigaMetre</returns>
	public static Quantity<double, GigaMetre> ToGigaMetre<T>(this Quantity<T, PicoMetre> val) where T:IConvertible {
        return new Quantity<double, GigaMetre>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetre to MegaMetre
    /// </summary>
    /// <param name="val">quantity measured in PicoMetre</param>
    /// <returns>quantity measured in MegaMetre</returns>
	public static Quantity<double, MegaMetre> ToMegaMetre<T>(this Quantity<T, PicoMetre> val) where T:IConvertible {
        return new Quantity<double, MegaMetre>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetre to KiloMetre
    /// </summary>
    /// <param name="val">quantity measured in PicoMetre</param>
    /// <returns>quantity measured in KiloMetre</returns>
	public static Quantity<double, KiloMetre> ToKiloMetre<T>(this Quantity<T, PicoMetre> val) where T:IConvertible {
        return new Quantity<double, KiloMetre>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetre to HectoMetre
    /// </summary>
    /// <param name="val">quantity measured in PicoMetre</param>
    /// <returns>quantity measured in HectoMetre</returns>
	public static Quantity<double, HectoMetre> ToHectoMetre<T>(this Quantity<T, PicoMetre> val) where T:IConvertible {
        return new Quantity<double, HectoMetre>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetre to DekaMetre
    /// </summary>
    /// <param name="val">quantity measured in PicoMetre</param>
    /// <returns>quantity measured in DekaMetre</returns>
	public static Quantity<double, DekaMetre> ToDekaMetre<T>(this Quantity<T, PicoMetre> val) where T:IConvertible {
        return new Quantity<double, DekaMetre>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetre to DeciMetre
    /// </summary>
    /// <param name="val">quantity measured in PicoMetre</param>
    /// <returns>quantity measured in DeciMetre</returns>
	public static Quantity<double, DeciMetre> ToDeciMetre<T>(this Quantity<T, PicoMetre> val) where T:IConvertible {
        return new Quantity<double, DeciMetre>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetre to CentiMetre
    /// </summary>
    /// <param name="val">quantity measured in PicoMetre</param>
    /// <returns>quantity measured in CentiMetre</returns>
	public static Quantity<double, CentiMetre> ToCentiMetre<T>(this Quantity<T, PicoMetre> val) where T:IConvertible {
        return new Quantity<double, CentiMetre>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetre to MilliMetre
    /// </summary>
    /// <param name="val">quantity measured in PicoMetre</param>
    /// <returns>quantity measured in MilliMetre</returns>
	public static Quantity<double, MilliMetre> ToMilliMetre<T>(this Quantity<T, PicoMetre> val) where T:IConvertible {
        return new Quantity<double, MilliMetre>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetre to MicroMetre
    /// </summary>
    /// <param name="val">quantity measured in PicoMetre</param>
    /// <returns>quantity measured in MicroMetre</returns>
	public static Quantity<double, MicroMetre> ToMicroMetre<T>(this Quantity<T, PicoMetre> val) where T:IConvertible {
        return new Quantity<double, MicroMetre>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetre to NanoMetre
    /// </summary>
    /// <param name="val">quantity measured in PicoMetre</param>
    /// <returns>quantity measured in NanoMetre</returns>
	public static Quantity<double, NanoMetre> ToNanoMetre<T>(this Quantity<T, PicoMetre> val) where T:IConvertible {
        return new Quantity<double, NanoMetre>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetre to FemtoMetre
    /// </summary>
    /// <param name="val">quantity measured in PicoMetre</param>
    /// <returns>quantity measured in FemtoMetre</returns>
	public static Quantity<double, FemtoMetre> ToFemtoMetre<T>(this Quantity<T, PicoMetre> val) where T:IConvertible {
        return new Quantity<double, FemtoMetre>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetre to AttoMetre
    /// </summary>
    /// <param name="val">quantity measured in PicoMetre</param>
    /// <returns>quantity measured in AttoMetre</returns>
	public static Quantity<double, AttoMetre> ToAttoMetre<T>(this Quantity<T, PicoMetre> val) where T:IConvertible {
        return new Quantity<double, AttoMetre>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetre to ZeptoMetre
    /// </summary>
    /// <param name="val">quantity measured in PicoMetre</param>
    /// <returns>quantity measured in ZeptoMetre</returns>
	public static Quantity<double, ZeptoMetre> ToZeptoMetre<T>(this Quantity<T, PicoMetre> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetre>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoMetre to YoctoMetre
    /// </summary>
    /// <param name="val">quantity measured in PicoMetre</param>
    /// <returns>quantity measured in YoctoMetre</returns>
	public static Quantity<double, YoctoMetre> ToYoctoMetre<T>(this Quantity<T, PicoMetre> val) where T:IConvertible {
        return new Quantity<double, YoctoMetre>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetre to YottaMetre
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetre</param>
    /// <returns>quantity measured in YottaMetre</returns>
	public static Quantity<double, YottaMetre> ToYottaMetre<T>(this Quantity<T, FemtoMetre> val) where T:IConvertible {
        return new Quantity<double, YottaMetre>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetre to ZettaMetre
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetre</param>
    /// <returns>quantity measured in ZettaMetre</returns>
	public static Quantity<double, ZettaMetre> ToZettaMetre<T>(this Quantity<T, FemtoMetre> val) where T:IConvertible {
        return new Quantity<double, ZettaMetre>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetre to ExaMetre
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetre</param>
    /// <returns>quantity measured in ExaMetre</returns>
	public static Quantity<double, ExaMetre> ToExaMetre<T>(this Quantity<T, FemtoMetre> val) where T:IConvertible {
        return new Quantity<double, ExaMetre>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetre to PetaMetre
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetre</param>
    /// <returns>quantity measured in PetaMetre</returns>
	public static Quantity<double, PetaMetre> ToPetaMetre<T>(this Quantity<T, FemtoMetre> val) where T:IConvertible {
        return new Quantity<double, PetaMetre>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetre to TeraMetre
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetre</param>
    /// <returns>quantity measured in TeraMetre</returns>
	public static Quantity<double, TeraMetre> ToTeraMetre<T>(this Quantity<T, FemtoMetre> val) where T:IConvertible {
        return new Quantity<double, TeraMetre>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetre to GigaMetre
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetre</param>
    /// <returns>quantity measured in GigaMetre</returns>
	public static Quantity<double, GigaMetre> ToGigaMetre<T>(this Quantity<T, FemtoMetre> val) where T:IConvertible {
        return new Quantity<double, GigaMetre>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetre to MegaMetre
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetre</param>
    /// <returns>quantity measured in MegaMetre</returns>
	public static Quantity<double, MegaMetre> ToMegaMetre<T>(this Quantity<T, FemtoMetre> val) where T:IConvertible {
        return new Quantity<double, MegaMetre>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetre to KiloMetre
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetre</param>
    /// <returns>quantity measured in KiloMetre</returns>
	public static Quantity<double, KiloMetre> ToKiloMetre<T>(this Quantity<T, FemtoMetre> val) where T:IConvertible {
        return new Quantity<double, KiloMetre>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetre to HectoMetre
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetre</param>
    /// <returns>quantity measured in HectoMetre</returns>
	public static Quantity<double, HectoMetre> ToHectoMetre<T>(this Quantity<T, FemtoMetre> val) where T:IConvertible {
        return new Quantity<double, HectoMetre>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetre to DekaMetre
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetre</param>
    /// <returns>quantity measured in DekaMetre</returns>
	public static Quantity<double, DekaMetre> ToDekaMetre<T>(this Quantity<T, FemtoMetre> val) where T:IConvertible {
        return new Quantity<double, DekaMetre>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetre to DeciMetre
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetre</param>
    /// <returns>quantity measured in DeciMetre</returns>
	public static Quantity<double, DeciMetre> ToDeciMetre<T>(this Quantity<T, FemtoMetre> val) where T:IConvertible {
        return new Quantity<double, DeciMetre>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetre to CentiMetre
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetre</param>
    /// <returns>quantity measured in CentiMetre</returns>
	public static Quantity<double, CentiMetre> ToCentiMetre<T>(this Quantity<T, FemtoMetre> val) where T:IConvertible {
        return new Quantity<double, CentiMetre>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetre to MilliMetre
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetre</param>
    /// <returns>quantity measured in MilliMetre</returns>
	public static Quantity<double, MilliMetre> ToMilliMetre<T>(this Quantity<T, FemtoMetre> val) where T:IConvertible {
        return new Quantity<double, MilliMetre>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetre to MicroMetre
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetre</param>
    /// <returns>quantity measured in MicroMetre</returns>
	public static Quantity<double, MicroMetre> ToMicroMetre<T>(this Quantity<T, FemtoMetre> val) where T:IConvertible {
        return new Quantity<double, MicroMetre>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetre to NanoMetre
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetre</param>
    /// <returns>quantity measured in NanoMetre</returns>
	public static Quantity<double, NanoMetre> ToNanoMetre<T>(this Quantity<T, FemtoMetre> val) where T:IConvertible {
        return new Quantity<double, NanoMetre>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetre to PicoMetre
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetre</param>
    /// <returns>quantity measured in PicoMetre</returns>
	public static Quantity<double, PicoMetre> ToPicoMetre<T>(this Quantity<T, FemtoMetre> val) where T:IConvertible {
        return new Quantity<double, PicoMetre>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetre to AttoMetre
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetre</param>
    /// <returns>quantity measured in AttoMetre</returns>
	public static Quantity<double, AttoMetre> ToAttoMetre<T>(this Quantity<T, FemtoMetre> val) where T:IConvertible {
        return new Quantity<double, AttoMetre>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetre to ZeptoMetre
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetre</param>
    /// <returns>quantity measured in ZeptoMetre</returns>
	public static Quantity<double, ZeptoMetre> ToZeptoMetre<T>(this Quantity<T, FemtoMetre> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetre>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoMetre to YoctoMetre
    /// </summary>
    /// <param name="val">quantity measured in FemtoMetre</param>
    /// <returns>quantity measured in YoctoMetre</returns>
	public static Quantity<double, YoctoMetre> ToYoctoMetre<T>(this Quantity<T, FemtoMetre> val) where T:IConvertible {
        return new Quantity<double, YoctoMetre>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetre to YottaMetre
    /// </summary>
    /// <param name="val">quantity measured in AttoMetre</param>
    /// <returns>quantity measured in YottaMetre</returns>
	public static Quantity<double, YottaMetre> ToYottaMetre<T>(this Quantity<T, AttoMetre> val) where T:IConvertible {
        return new Quantity<double, YottaMetre>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetre to ZettaMetre
    /// </summary>
    /// <param name="val">quantity measured in AttoMetre</param>
    /// <returns>quantity measured in ZettaMetre</returns>
	public static Quantity<double, ZettaMetre> ToZettaMetre<T>(this Quantity<T, AttoMetre> val) where T:IConvertible {
        return new Quantity<double, ZettaMetre>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetre to ExaMetre
    /// </summary>
    /// <param name="val">quantity measured in AttoMetre</param>
    /// <returns>quantity measured in ExaMetre</returns>
	public static Quantity<double, ExaMetre> ToExaMetre<T>(this Quantity<T, AttoMetre> val) where T:IConvertible {
        return new Quantity<double, ExaMetre>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetre to PetaMetre
    /// </summary>
    /// <param name="val">quantity measured in AttoMetre</param>
    /// <returns>quantity measured in PetaMetre</returns>
	public static Quantity<double, PetaMetre> ToPetaMetre<T>(this Quantity<T, AttoMetre> val) where T:IConvertible {
        return new Quantity<double, PetaMetre>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetre to TeraMetre
    /// </summary>
    /// <param name="val">quantity measured in AttoMetre</param>
    /// <returns>quantity measured in TeraMetre</returns>
	public static Quantity<double, TeraMetre> ToTeraMetre<T>(this Quantity<T, AttoMetre> val) where T:IConvertible {
        return new Quantity<double, TeraMetre>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetre to GigaMetre
    /// </summary>
    /// <param name="val">quantity measured in AttoMetre</param>
    /// <returns>quantity measured in GigaMetre</returns>
	public static Quantity<double, GigaMetre> ToGigaMetre<T>(this Quantity<T, AttoMetre> val) where T:IConvertible {
        return new Quantity<double, GigaMetre>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetre to MegaMetre
    /// </summary>
    /// <param name="val">quantity measured in AttoMetre</param>
    /// <returns>quantity measured in MegaMetre</returns>
	public static Quantity<double, MegaMetre> ToMegaMetre<T>(this Quantity<T, AttoMetre> val) where T:IConvertible {
        return new Quantity<double, MegaMetre>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetre to KiloMetre
    /// </summary>
    /// <param name="val">quantity measured in AttoMetre</param>
    /// <returns>quantity measured in KiloMetre</returns>
	public static Quantity<double, KiloMetre> ToKiloMetre<T>(this Quantity<T, AttoMetre> val) where T:IConvertible {
        return new Quantity<double, KiloMetre>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetre to HectoMetre
    /// </summary>
    /// <param name="val">quantity measured in AttoMetre</param>
    /// <returns>quantity measured in HectoMetre</returns>
	public static Quantity<double, HectoMetre> ToHectoMetre<T>(this Quantity<T, AttoMetre> val) where T:IConvertible {
        return new Quantity<double, HectoMetre>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetre to DekaMetre
    /// </summary>
    /// <param name="val">quantity measured in AttoMetre</param>
    /// <returns>quantity measured in DekaMetre</returns>
	public static Quantity<double, DekaMetre> ToDekaMetre<T>(this Quantity<T, AttoMetre> val) where T:IConvertible {
        return new Quantity<double, DekaMetre>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetre to DeciMetre
    /// </summary>
    /// <param name="val">quantity measured in AttoMetre</param>
    /// <returns>quantity measured in DeciMetre</returns>
	public static Quantity<double, DeciMetre> ToDeciMetre<T>(this Quantity<T, AttoMetre> val) where T:IConvertible {
        return new Quantity<double, DeciMetre>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetre to CentiMetre
    /// </summary>
    /// <param name="val">quantity measured in AttoMetre</param>
    /// <returns>quantity measured in CentiMetre</returns>
	public static Quantity<double, CentiMetre> ToCentiMetre<T>(this Quantity<T, AttoMetre> val) where T:IConvertible {
        return new Quantity<double, CentiMetre>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetre to MilliMetre
    /// </summary>
    /// <param name="val">quantity measured in AttoMetre</param>
    /// <returns>quantity measured in MilliMetre</returns>
	public static Quantity<double, MilliMetre> ToMilliMetre<T>(this Quantity<T, AttoMetre> val) where T:IConvertible {
        return new Quantity<double, MilliMetre>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetre to MicroMetre
    /// </summary>
    /// <param name="val">quantity measured in AttoMetre</param>
    /// <returns>quantity measured in MicroMetre</returns>
	public static Quantity<double, MicroMetre> ToMicroMetre<T>(this Quantity<T, AttoMetre> val) where T:IConvertible {
        return new Quantity<double, MicroMetre>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetre to NanoMetre
    /// </summary>
    /// <param name="val">quantity measured in AttoMetre</param>
    /// <returns>quantity measured in NanoMetre</returns>
	public static Quantity<double, NanoMetre> ToNanoMetre<T>(this Quantity<T, AttoMetre> val) where T:IConvertible {
        return new Quantity<double, NanoMetre>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetre to PicoMetre
    /// </summary>
    /// <param name="val">quantity measured in AttoMetre</param>
    /// <returns>quantity measured in PicoMetre</returns>
	public static Quantity<double, PicoMetre> ToPicoMetre<T>(this Quantity<T, AttoMetre> val) where T:IConvertible {
        return new Quantity<double, PicoMetre>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetre to FemtoMetre
    /// </summary>
    /// <param name="val">quantity measured in AttoMetre</param>
    /// <returns>quantity measured in FemtoMetre</returns>
	public static Quantity<double, FemtoMetre> ToFemtoMetre<T>(this Quantity<T, AttoMetre> val) where T:IConvertible {
        return new Quantity<double, FemtoMetre>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetre to ZeptoMetre
    /// </summary>
    /// <param name="val">quantity measured in AttoMetre</param>
    /// <returns>quantity measured in ZeptoMetre</returns>
	public static Quantity<double, ZeptoMetre> ToZeptoMetre<T>(this Quantity<T, AttoMetre> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetre>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoMetre to YoctoMetre
    /// </summary>
    /// <param name="val">quantity measured in AttoMetre</param>
    /// <returns>quantity measured in YoctoMetre</returns>
	public static Quantity<double, YoctoMetre> ToYoctoMetre<T>(this Quantity<T, AttoMetre> val) where T:IConvertible {
        return new Quantity<double, YoctoMetre>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetre to YottaMetre
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetre</param>
    /// <returns>quantity measured in YottaMetre</returns>
	public static Quantity<double, YottaMetre> ToYottaMetre<T>(this Quantity<T, ZeptoMetre> val) where T:IConvertible {
        return new Quantity<double, YottaMetre>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetre to ZettaMetre
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetre</param>
    /// <returns>quantity measured in ZettaMetre</returns>
	public static Quantity<double, ZettaMetre> ToZettaMetre<T>(this Quantity<T, ZeptoMetre> val) where T:IConvertible {
        return new Quantity<double, ZettaMetre>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetre to ExaMetre
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetre</param>
    /// <returns>quantity measured in ExaMetre</returns>
	public static Quantity<double, ExaMetre> ToExaMetre<T>(this Quantity<T, ZeptoMetre> val) where T:IConvertible {
        return new Quantity<double, ExaMetre>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetre to PetaMetre
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetre</param>
    /// <returns>quantity measured in PetaMetre</returns>
	public static Quantity<double, PetaMetre> ToPetaMetre<T>(this Quantity<T, ZeptoMetre> val) where T:IConvertible {
        return new Quantity<double, PetaMetre>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetre to TeraMetre
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetre</param>
    /// <returns>quantity measured in TeraMetre</returns>
	public static Quantity<double, TeraMetre> ToTeraMetre<T>(this Quantity<T, ZeptoMetre> val) where T:IConvertible {
        return new Quantity<double, TeraMetre>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetre to GigaMetre
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetre</param>
    /// <returns>quantity measured in GigaMetre</returns>
	public static Quantity<double, GigaMetre> ToGigaMetre<T>(this Quantity<T, ZeptoMetre> val) where T:IConvertible {
        return new Quantity<double, GigaMetre>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetre to MegaMetre
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetre</param>
    /// <returns>quantity measured in MegaMetre</returns>
	public static Quantity<double, MegaMetre> ToMegaMetre<T>(this Quantity<T, ZeptoMetre> val) where T:IConvertible {
        return new Quantity<double, MegaMetre>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetre to KiloMetre
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetre</param>
    /// <returns>quantity measured in KiloMetre</returns>
	public static Quantity<double, KiloMetre> ToKiloMetre<T>(this Quantity<T, ZeptoMetre> val) where T:IConvertible {
        return new Quantity<double, KiloMetre>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetre to HectoMetre
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetre</param>
    /// <returns>quantity measured in HectoMetre</returns>
	public static Quantity<double, HectoMetre> ToHectoMetre<T>(this Quantity<T, ZeptoMetre> val) where T:IConvertible {
        return new Quantity<double, HectoMetre>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetre to DekaMetre
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetre</param>
    /// <returns>quantity measured in DekaMetre</returns>
	public static Quantity<double, DekaMetre> ToDekaMetre<T>(this Quantity<T, ZeptoMetre> val) where T:IConvertible {
        return new Quantity<double, DekaMetre>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetre to DeciMetre
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetre</param>
    /// <returns>quantity measured in DeciMetre</returns>
	public static Quantity<double, DeciMetre> ToDeciMetre<T>(this Quantity<T, ZeptoMetre> val) where T:IConvertible {
        return new Quantity<double, DeciMetre>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetre to CentiMetre
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetre</param>
    /// <returns>quantity measured in CentiMetre</returns>
	public static Quantity<double, CentiMetre> ToCentiMetre<T>(this Quantity<T, ZeptoMetre> val) where T:IConvertible {
        return new Quantity<double, CentiMetre>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetre to MilliMetre
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetre</param>
    /// <returns>quantity measured in MilliMetre</returns>
	public static Quantity<double, MilliMetre> ToMilliMetre<T>(this Quantity<T, ZeptoMetre> val) where T:IConvertible {
        return new Quantity<double, MilliMetre>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetre to MicroMetre
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetre</param>
    /// <returns>quantity measured in MicroMetre</returns>
	public static Quantity<double, MicroMetre> ToMicroMetre<T>(this Quantity<T, ZeptoMetre> val) where T:IConvertible {
        return new Quantity<double, MicroMetre>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetre to NanoMetre
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetre</param>
    /// <returns>quantity measured in NanoMetre</returns>
	public static Quantity<double, NanoMetre> ToNanoMetre<T>(this Quantity<T, ZeptoMetre> val) where T:IConvertible {
        return new Quantity<double, NanoMetre>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetre to PicoMetre
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetre</param>
    /// <returns>quantity measured in PicoMetre</returns>
	public static Quantity<double, PicoMetre> ToPicoMetre<T>(this Quantity<T, ZeptoMetre> val) where T:IConvertible {
        return new Quantity<double, PicoMetre>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetre to FemtoMetre
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetre</param>
    /// <returns>quantity measured in FemtoMetre</returns>
	public static Quantity<double, FemtoMetre> ToFemtoMetre<T>(this Quantity<T, ZeptoMetre> val) where T:IConvertible {
        return new Quantity<double, FemtoMetre>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetre to AttoMetre
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetre</param>
    /// <returns>quantity measured in AttoMetre</returns>
	public static Quantity<double, AttoMetre> ToAttoMetre<T>(this Quantity<T, ZeptoMetre> val) where T:IConvertible {
        return new Quantity<double, AttoMetre>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoMetre to YoctoMetre
    /// </summary>
    /// <param name="val">quantity measured in ZeptoMetre</param>
    /// <returns>quantity measured in YoctoMetre</returns>
	public static Quantity<double, YoctoMetre> ToYoctoMetre<T>(this Quantity<T, ZeptoMetre> val) where T:IConvertible {
        return new Quantity<double, YoctoMetre>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetre to YottaMetre
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetre</param>
    /// <returns>quantity measured in YottaMetre</returns>
	public static Quantity<double, YottaMetre> ToYottaMetre<T>(this Quantity<T, YoctoMetre> val) where T:IConvertible {
        return new Quantity<double, YottaMetre>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetre to ZettaMetre
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetre</param>
    /// <returns>quantity measured in ZettaMetre</returns>
	public static Quantity<double, ZettaMetre> ToZettaMetre<T>(this Quantity<T, YoctoMetre> val) where T:IConvertible {
        return new Quantity<double, ZettaMetre>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetre to ExaMetre
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetre</param>
    /// <returns>quantity measured in ExaMetre</returns>
	public static Quantity<double, ExaMetre> ToExaMetre<T>(this Quantity<T, YoctoMetre> val) where T:IConvertible {
        return new Quantity<double, ExaMetre>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetre to PetaMetre
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetre</param>
    /// <returns>quantity measured in PetaMetre</returns>
	public static Quantity<double, PetaMetre> ToPetaMetre<T>(this Quantity<T, YoctoMetre> val) where T:IConvertible {
        return new Quantity<double, PetaMetre>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetre to TeraMetre
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetre</param>
    /// <returns>quantity measured in TeraMetre</returns>
	public static Quantity<double, TeraMetre> ToTeraMetre<T>(this Quantity<T, YoctoMetre> val) where T:IConvertible {
        return new Quantity<double, TeraMetre>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetre to GigaMetre
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetre</param>
    /// <returns>quantity measured in GigaMetre</returns>
	public static Quantity<double, GigaMetre> ToGigaMetre<T>(this Quantity<T, YoctoMetre> val) where T:IConvertible {
        return new Quantity<double, GigaMetre>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetre to MegaMetre
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetre</param>
    /// <returns>quantity measured in MegaMetre</returns>
	public static Quantity<double, MegaMetre> ToMegaMetre<T>(this Quantity<T, YoctoMetre> val) where T:IConvertible {
        return new Quantity<double, MegaMetre>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetre to KiloMetre
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetre</param>
    /// <returns>quantity measured in KiloMetre</returns>
	public static Quantity<double, KiloMetre> ToKiloMetre<T>(this Quantity<T, YoctoMetre> val) where T:IConvertible {
        return new Quantity<double, KiloMetre>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetre to HectoMetre
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetre</param>
    /// <returns>quantity measured in HectoMetre</returns>
	public static Quantity<double, HectoMetre> ToHectoMetre<T>(this Quantity<T, YoctoMetre> val) where T:IConvertible {
        return new Quantity<double, HectoMetre>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetre to DekaMetre
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetre</param>
    /// <returns>quantity measured in DekaMetre</returns>
	public static Quantity<double, DekaMetre> ToDekaMetre<T>(this Quantity<T, YoctoMetre> val) where T:IConvertible {
        return new Quantity<double, DekaMetre>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetre to DeciMetre
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetre</param>
    /// <returns>quantity measured in DeciMetre</returns>
	public static Quantity<double, DeciMetre> ToDeciMetre<T>(this Quantity<T, YoctoMetre> val) where T:IConvertible {
        return new Quantity<double, DeciMetre>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetre to CentiMetre
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetre</param>
    /// <returns>quantity measured in CentiMetre</returns>
	public static Quantity<double, CentiMetre> ToCentiMetre<T>(this Quantity<T, YoctoMetre> val) where T:IConvertible {
        return new Quantity<double, CentiMetre>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetre to MilliMetre
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetre</param>
    /// <returns>quantity measured in MilliMetre</returns>
	public static Quantity<double, MilliMetre> ToMilliMetre<T>(this Quantity<T, YoctoMetre> val) where T:IConvertible {
        return new Quantity<double, MilliMetre>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetre to MicroMetre
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetre</param>
    /// <returns>quantity measured in MicroMetre</returns>
	public static Quantity<double, MicroMetre> ToMicroMetre<T>(this Quantity<T, YoctoMetre> val) where T:IConvertible {
        return new Quantity<double, MicroMetre>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetre to NanoMetre
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetre</param>
    /// <returns>quantity measured in NanoMetre</returns>
	public static Quantity<double, NanoMetre> ToNanoMetre<T>(this Quantity<T, YoctoMetre> val) where T:IConvertible {
        return new Quantity<double, NanoMetre>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetre to PicoMetre
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetre</param>
    /// <returns>quantity measured in PicoMetre</returns>
	public static Quantity<double, PicoMetre> ToPicoMetre<T>(this Quantity<T, YoctoMetre> val) where T:IConvertible {
        return new Quantity<double, PicoMetre>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetre to FemtoMetre
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetre</param>
    /// <returns>quantity measured in FemtoMetre</returns>
	public static Quantity<double, FemtoMetre> ToFemtoMetre<T>(this Quantity<T, YoctoMetre> val) where T:IConvertible {
        return new Quantity<double, FemtoMetre>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetre to AttoMetre
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetre</param>
    /// <returns>quantity measured in AttoMetre</returns>
	public static Quantity<double, AttoMetre> ToAttoMetre<T>(this Quantity<T, YoctoMetre> val) where T:IConvertible {
        return new Quantity<double, AttoMetre>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoMetre to ZeptoMetre
    /// </summary>
    /// <param name="val">quantity measured in YoctoMetre</param>
    /// <returns>quantity measured in ZeptoMetre</returns>
	public static Quantity<double, ZeptoMetre> ToZeptoMetre<T>(this Quantity<T, YoctoMetre> val) where T:IConvertible {
        return new Quantity<double, ZeptoMetre>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
}
}