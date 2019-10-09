using System;
namespace System.Units.Power {
public static class PowerConversions {
	/// <summary>
    /// Extension method to convert Watt to YottaWatt
    /// </summary>
    /// <param name="val">quantity measured in Watt</param>
    /// <returns>quantity measured in YottaWatt</returns>
	public static Quantity<double, YottaWatt> ToYottaWatt<T>(this Quantity<T, Watt> val) where T:IConvertible {
        return new Quantity<double, YottaWatt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Watt to ZettaWatt
    /// </summary>
    /// <param name="val">quantity measured in Watt</param>
    /// <returns>quantity measured in ZettaWatt</returns>
	public static Quantity<double, ZettaWatt> ToZettaWatt<T>(this Quantity<T, Watt> val) where T:IConvertible {
        return new Quantity<double, ZettaWatt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Watt to ExaWatt
    /// </summary>
    /// <param name="val">quantity measured in Watt</param>
    /// <returns>quantity measured in ExaWatt</returns>
	public static Quantity<double, ExaWatt> ToExaWatt<T>(this Quantity<T, Watt> val) where T:IConvertible {
        return new Quantity<double, ExaWatt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Watt to PetaWatt
    /// </summary>
    /// <param name="val">quantity measured in Watt</param>
    /// <returns>quantity measured in PetaWatt</returns>
	public static Quantity<double, PetaWatt> ToPetaWatt<T>(this Quantity<T, Watt> val) where T:IConvertible {
        return new Quantity<double, PetaWatt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Watt to TeraWatt
    /// </summary>
    /// <param name="val">quantity measured in Watt</param>
    /// <returns>quantity measured in TeraWatt</returns>
	public static Quantity<double, TeraWatt> ToTeraWatt<T>(this Quantity<T, Watt> val) where T:IConvertible {
        return new Quantity<double, TeraWatt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Watt to GigaWatt
    /// </summary>
    /// <param name="val">quantity measured in Watt</param>
    /// <returns>quantity measured in GigaWatt</returns>
	public static Quantity<double, GigaWatt> ToGigaWatt<T>(this Quantity<T, Watt> val) where T:IConvertible {
        return new Quantity<double, GigaWatt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Watt to MegaWatt
    /// </summary>
    /// <param name="val">quantity measured in Watt</param>
    /// <returns>quantity measured in MegaWatt</returns>
	public static Quantity<double, MegaWatt> ToMegaWatt<T>(this Quantity<T, Watt> val) where T:IConvertible {
        return new Quantity<double, MegaWatt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Watt to KiloWatt
    /// </summary>
    /// <param name="val">quantity measured in Watt</param>
    /// <returns>quantity measured in KiloWatt</returns>
	public static Quantity<double, KiloWatt> ToKiloWatt<T>(this Quantity<T, Watt> val) where T:IConvertible {
        return new Quantity<double, KiloWatt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Watt to HectoWatt
    /// </summary>
    /// <param name="val">quantity measured in Watt</param>
    /// <returns>quantity measured in HectoWatt</returns>
	public static Quantity<double, HectoWatt> ToHectoWatt<T>(this Quantity<T, Watt> val) where T:IConvertible {
        return new Quantity<double, HectoWatt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Watt to DekaWatt
    /// </summary>
    /// <param name="val">quantity measured in Watt</param>
    /// <returns>quantity measured in DekaWatt</returns>
	public static Quantity<double, DekaWatt> ToDekaWatt<T>(this Quantity<T, Watt> val) where T:IConvertible {
        return new Quantity<double, DekaWatt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Watt to DeciWatt
    /// </summary>
    /// <param name="val">quantity measured in Watt</param>
    /// <returns>quantity measured in DeciWatt</returns>
	public static Quantity<double, DeciWatt> ToDeciWatt<T>(this Quantity<T, Watt> val) where T:IConvertible {
        return new Quantity<double, DeciWatt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Watt to CentiWatt
    /// </summary>
    /// <param name="val">quantity measured in Watt</param>
    /// <returns>quantity measured in CentiWatt</returns>
	public static Quantity<double, CentiWatt> ToCentiWatt<T>(this Quantity<T, Watt> val) where T:IConvertible {
        return new Quantity<double, CentiWatt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Watt to MilliWatt
    /// </summary>
    /// <param name="val">quantity measured in Watt</param>
    /// <returns>quantity measured in MilliWatt</returns>
	public static Quantity<double, MilliWatt> ToMilliWatt<T>(this Quantity<T, Watt> val) where T:IConvertible {
        return new Quantity<double, MilliWatt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Watt to MicroWatt
    /// </summary>
    /// <param name="val">quantity measured in Watt</param>
    /// <returns>quantity measured in MicroWatt</returns>
	public static Quantity<double, MicroWatt> ToMicroWatt<T>(this Quantity<T, Watt> val) where T:IConvertible {
        return new Quantity<double, MicroWatt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Watt to NanoWatt
    /// </summary>
    /// <param name="val">quantity measured in Watt</param>
    /// <returns>quantity measured in NanoWatt</returns>
	public static Quantity<double, NanoWatt> ToNanoWatt<T>(this Quantity<T, Watt> val) where T:IConvertible {
        return new Quantity<double, NanoWatt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Watt to PicoWatt
    /// </summary>
    /// <param name="val">quantity measured in Watt</param>
    /// <returns>quantity measured in PicoWatt</returns>
	public static Quantity<double, PicoWatt> ToPicoWatt<T>(this Quantity<T, Watt> val) where T:IConvertible {
        return new Quantity<double, PicoWatt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Watt to FemtoWatt
    /// </summary>
    /// <param name="val">quantity measured in Watt</param>
    /// <returns>quantity measured in FemtoWatt</returns>
	public static Quantity<double, FemtoWatt> ToFemtoWatt<T>(this Quantity<T, Watt> val) where T:IConvertible {
        return new Quantity<double, FemtoWatt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Watt to AttoWatt
    /// </summary>
    /// <param name="val">quantity measured in Watt</param>
    /// <returns>quantity measured in AttoWatt</returns>
	public static Quantity<double, AttoWatt> ToAttoWatt<T>(this Quantity<T, Watt> val) where T:IConvertible {
        return new Quantity<double, AttoWatt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Watt to ZeptoWatt
    /// </summary>
    /// <param name="val">quantity measured in Watt</param>
    /// <returns>quantity measured in ZeptoWatt</returns>
	public static Quantity<double, ZeptoWatt> ToZeptoWatt<T>(this Quantity<T, Watt> val) where T:IConvertible {
        return new Quantity<double, ZeptoWatt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Watt to YoctoWatt
    /// </summary>
    /// <param name="val">quantity measured in Watt</param>
    /// <returns>quantity measured in YoctoWatt</returns>
	public static Quantity<double, YoctoWatt> ToYoctoWatt<T>(this Quantity<T, Watt> val) where T:IConvertible {
        return new Quantity<double, YoctoWatt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YottaWatt to ZettaWatt
    /// </summary>
    /// <param name="val">quantity measured in YottaWatt</param>
    /// <returns>quantity measured in ZettaWatt</returns>
	public static Quantity<double, ZettaWatt> ToZettaWatt<T>(this Quantity<T, YottaWatt> val) where T:IConvertible {
        return new Quantity<double, ZettaWatt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaWatt to ExaWatt
    /// </summary>
    /// <param name="val">quantity measured in YottaWatt</param>
    /// <returns>quantity measured in ExaWatt</returns>
	public static Quantity<double, ExaWatt> ToExaWatt<T>(this Quantity<T, YottaWatt> val) where T:IConvertible {
        return new Quantity<double, ExaWatt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaWatt to PetaWatt
    /// </summary>
    /// <param name="val">quantity measured in YottaWatt</param>
    /// <returns>quantity measured in PetaWatt</returns>
	public static Quantity<double, PetaWatt> ToPetaWatt<T>(this Quantity<T, YottaWatt> val) where T:IConvertible {
        return new Quantity<double, PetaWatt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaWatt to TeraWatt
    /// </summary>
    /// <param name="val">quantity measured in YottaWatt</param>
    /// <returns>quantity measured in TeraWatt</returns>
	public static Quantity<double, TeraWatt> ToTeraWatt<T>(this Quantity<T, YottaWatt> val) where T:IConvertible {
        return new Quantity<double, TeraWatt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaWatt to GigaWatt
    /// </summary>
    /// <param name="val">quantity measured in YottaWatt</param>
    /// <returns>quantity measured in GigaWatt</returns>
	public static Quantity<double, GigaWatt> ToGigaWatt<T>(this Quantity<T, YottaWatt> val) where T:IConvertible {
        return new Quantity<double, GigaWatt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaWatt to MegaWatt
    /// </summary>
    /// <param name="val">quantity measured in YottaWatt</param>
    /// <returns>quantity measured in MegaWatt</returns>
	public static Quantity<double, MegaWatt> ToMegaWatt<T>(this Quantity<T, YottaWatt> val) where T:IConvertible {
        return new Quantity<double, MegaWatt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaWatt to KiloWatt
    /// </summary>
    /// <param name="val">quantity measured in YottaWatt</param>
    /// <returns>quantity measured in KiloWatt</returns>
	public static Quantity<double, KiloWatt> ToKiloWatt<T>(this Quantity<T, YottaWatt> val) where T:IConvertible {
        return new Quantity<double, KiloWatt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaWatt to HectoWatt
    /// </summary>
    /// <param name="val">quantity measured in YottaWatt</param>
    /// <returns>quantity measured in HectoWatt</returns>
	public static Quantity<double, HectoWatt> ToHectoWatt<T>(this Quantity<T, YottaWatt> val) where T:IConvertible {
        return new Quantity<double, HectoWatt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaWatt to DekaWatt
    /// </summary>
    /// <param name="val">quantity measured in YottaWatt</param>
    /// <returns>quantity measured in DekaWatt</returns>
	public static Quantity<double, DekaWatt> ToDekaWatt<T>(this Quantity<T, YottaWatt> val) where T:IConvertible {
        return new Quantity<double, DekaWatt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaWatt to DeciWatt
    /// </summary>
    /// <param name="val">quantity measured in YottaWatt</param>
    /// <returns>quantity measured in DeciWatt</returns>
	public static Quantity<double, DeciWatt> ToDeciWatt<T>(this Quantity<T, YottaWatt> val) where T:IConvertible {
        return new Quantity<double, DeciWatt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaWatt to CentiWatt
    /// </summary>
    /// <param name="val">quantity measured in YottaWatt</param>
    /// <returns>quantity measured in CentiWatt</returns>
	public static Quantity<double, CentiWatt> ToCentiWatt<T>(this Quantity<T, YottaWatt> val) where T:IConvertible {
        return new Quantity<double, CentiWatt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaWatt to MilliWatt
    /// </summary>
    /// <param name="val">quantity measured in YottaWatt</param>
    /// <returns>quantity measured in MilliWatt</returns>
	public static Quantity<double, MilliWatt> ToMilliWatt<T>(this Quantity<T, YottaWatt> val) where T:IConvertible {
        return new Quantity<double, MilliWatt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaWatt to MicroWatt
    /// </summary>
    /// <param name="val">quantity measured in YottaWatt</param>
    /// <returns>quantity measured in MicroWatt</returns>
	public static Quantity<double, MicroWatt> ToMicroWatt<T>(this Quantity<T, YottaWatt> val) where T:IConvertible {
        return new Quantity<double, MicroWatt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaWatt to NanoWatt
    /// </summary>
    /// <param name="val">quantity measured in YottaWatt</param>
    /// <returns>quantity measured in NanoWatt</returns>
	public static Quantity<double, NanoWatt> ToNanoWatt<T>(this Quantity<T, YottaWatt> val) where T:IConvertible {
        return new Quantity<double, NanoWatt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaWatt to PicoWatt
    /// </summary>
    /// <param name="val">quantity measured in YottaWatt</param>
    /// <returns>quantity measured in PicoWatt</returns>
	public static Quantity<double, PicoWatt> ToPicoWatt<T>(this Quantity<T, YottaWatt> val) where T:IConvertible {
        return new Quantity<double, PicoWatt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaWatt to FemtoWatt
    /// </summary>
    /// <param name="val">quantity measured in YottaWatt</param>
    /// <returns>quantity measured in FemtoWatt</returns>
	public static Quantity<double, FemtoWatt> ToFemtoWatt<T>(this Quantity<T, YottaWatt> val) where T:IConvertible {
        return new Quantity<double, FemtoWatt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaWatt to AttoWatt
    /// </summary>
    /// <param name="val">quantity measured in YottaWatt</param>
    /// <returns>quantity measured in AttoWatt</returns>
	public static Quantity<double, AttoWatt> ToAttoWatt<T>(this Quantity<T, YottaWatt> val) where T:IConvertible {
        return new Quantity<double, AttoWatt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaWatt to ZeptoWatt
    /// </summary>
    /// <param name="val">quantity measured in YottaWatt</param>
    /// <returns>quantity measured in ZeptoWatt</returns>
	public static Quantity<double, ZeptoWatt> ToZeptoWatt<T>(this Quantity<T, YottaWatt> val) where T:IConvertible {
        return new Quantity<double, ZeptoWatt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaWatt to YoctoWatt
    /// </summary>
    /// <param name="val">quantity measured in YottaWatt</param>
    /// <returns>quantity measured in YoctoWatt</returns>
	public static Quantity<double, YoctoWatt> ToYoctoWatt<T>(this Quantity<T, YottaWatt> val) where T:IConvertible {
        return new Quantity<double, YoctoWatt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert ZettaWatt to YottaWatt
    /// </summary>
    /// <param name="val">quantity measured in ZettaWatt</param>
    /// <returns>quantity measured in YottaWatt</returns>
	public static Quantity<double, YottaWatt> ToYottaWatt<T>(this Quantity<T, ZettaWatt> val) where T:IConvertible {
        return new Quantity<double, YottaWatt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaWatt to ExaWatt
    /// </summary>
    /// <param name="val">quantity measured in ZettaWatt</param>
    /// <returns>quantity measured in ExaWatt</returns>
	public static Quantity<double, ExaWatt> ToExaWatt<T>(this Quantity<T, ZettaWatt> val) where T:IConvertible {
        return new Quantity<double, ExaWatt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaWatt to PetaWatt
    /// </summary>
    /// <param name="val">quantity measured in ZettaWatt</param>
    /// <returns>quantity measured in PetaWatt</returns>
	public static Quantity<double, PetaWatt> ToPetaWatt<T>(this Quantity<T, ZettaWatt> val) where T:IConvertible {
        return new Quantity<double, PetaWatt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaWatt to TeraWatt
    /// </summary>
    /// <param name="val">quantity measured in ZettaWatt</param>
    /// <returns>quantity measured in TeraWatt</returns>
	public static Quantity<double, TeraWatt> ToTeraWatt<T>(this Quantity<T, ZettaWatt> val) where T:IConvertible {
        return new Quantity<double, TeraWatt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaWatt to GigaWatt
    /// </summary>
    /// <param name="val">quantity measured in ZettaWatt</param>
    /// <returns>quantity measured in GigaWatt</returns>
	public static Quantity<double, GigaWatt> ToGigaWatt<T>(this Quantity<T, ZettaWatt> val) where T:IConvertible {
        return new Quantity<double, GigaWatt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaWatt to MegaWatt
    /// </summary>
    /// <param name="val">quantity measured in ZettaWatt</param>
    /// <returns>quantity measured in MegaWatt</returns>
	public static Quantity<double, MegaWatt> ToMegaWatt<T>(this Quantity<T, ZettaWatt> val) where T:IConvertible {
        return new Quantity<double, MegaWatt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaWatt to KiloWatt
    /// </summary>
    /// <param name="val">quantity measured in ZettaWatt</param>
    /// <returns>quantity measured in KiloWatt</returns>
	public static Quantity<double, KiloWatt> ToKiloWatt<T>(this Quantity<T, ZettaWatt> val) where T:IConvertible {
        return new Quantity<double, KiloWatt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaWatt to HectoWatt
    /// </summary>
    /// <param name="val">quantity measured in ZettaWatt</param>
    /// <returns>quantity measured in HectoWatt</returns>
	public static Quantity<double, HectoWatt> ToHectoWatt<T>(this Quantity<T, ZettaWatt> val) where T:IConvertible {
        return new Quantity<double, HectoWatt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaWatt to DekaWatt
    /// </summary>
    /// <param name="val">quantity measured in ZettaWatt</param>
    /// <returns>quantity measured in DekaWatt</returns>
	public static Quantity<double, DekaWatt> ToDekaWatt<T>(this Quantity<T, ZettaWatt> val) where T:IConvertible {
        return new Quantity<double, DekaWatt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaWatt to DeciWatt
    /// </summary>
    /// <param name="val">quantity measured in ZettaWatt</param>
    /// <returns>quantity measured in DeciWatt</returns>
	public static Quantity<double, DeciWatt> ToDeciWatt<T>(this Quantity<T, ZettaWatt> val) where T:IConvertible {
        return new Quantity<double, DeciWatt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaWatt to CentiWatt
    /// </summary>
    /// <param name="val">quantity measured in ZettaWatt</param>
    /// <returns>quantity measured in CentiWatt</returns>
	public static Quantity<double, CentiWatt> ToCentiWatt<T>(this Quantity<T, ZettaWatt> val) where T:IConvertible {
        return new Quantity<double, CentiWatt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaWatt to MilliWatt
    /// </summary>
    /// <param name="val">quantity measured in ZettaWatt</param>
    /// <returns>quantity measured in MilliWatt</returns>
	public static Quantity<double, MilliWatt> ToMilliWatt<T>(this Quantity<T, ZettaWatt> val) where T:IConvertible {
        return new Quantity<double, MilliWatt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaWatt to MicroWatt
    /// </summary>
    /// <param name="val">quantity measured in ZettaWatt</param>
    /// <returns>quantity measured in MicroWatt</returns>
	public static Quantity<double, MicroWatt> ToMicroWatt<T>(this Quantity<T, ZettaWatt> val) where T:IConvertible {
        return new Quantity<double, MicroWatt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaWatt to NanoWatt
    /// </summary>
    /// <param name="val">quantity measured in ZettaWatt</param>
    /// <returns>quantity measured in NanoWatt</returns>
	public static Quantity<double, NanoWatt> ToNanoWatt<T>(this Quantity<T, ZettaWatt> val) where T:IConvertible {
        return new Quantity<double, NanoWatt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaWatt to PicoWatt
    /// </summary>
    /// <param name="val">quantity measured in ZettaWatt</param>
    /// <returns>quantity measured in PicoWatt</returns>
	public static Quantity<double, PicoWatt> ToPicoWatt<T>(this Quantity<T, ZettaWatt> val) where T:IConvertible {
        return new Quantity<double, PicoWatt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaWatt to FemtoWatt
    /// </summary>
    /// <param name="val">quantity measured in ZettaWatt</param>
    /// <returns>quantity measured in FemtoWatt</returns>
	public static Quantity<double, FemtoWatt> ToFemtoWatt<T>(this Quantity<T, ZettaWatt> val) where T:IConvertible {
        return new Quantity<double, FemtoWatt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaWatt to AttoWatt
    /// </summary>
    /// <param name="val">quantity measured in ZettaWatt</param>
    /// <returns>quantity measured in AttoWatt</returns>
	public static Quantity<double, AttoWatt> ToAttoWatt<T>(this Quantity<T, ZettaWatt> val) where T:IConvertible {
        return new Quantity<double, AttoWatt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaWatt to ZeptoWatt
    /// </summary>
    /// <param name="val">quantity measured in ZettaWatt</param>
    /// <returns>quantity measured in ZeptoWatt</returns>
	public static Quantity<double, ZeptoWatt> ToZeptoWatt<T>(this Quantity<T, ZettaWatt> val) where T:IConvertible {
        return new Quantity<double, ZeptoWatt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaWatt to YoctoWatt
    /// </summary>
    /// <param name="val">quantity measured in ZettaWatt</param>
    /// <returns>quantity measured in YoctoWatt</returns>
	public static Quantity<double, YoctoWatt> ToYoctoWatt<T>(this Quantity<T, ZettaWatt> val) where T:IConvertible {
        return new Quantity<double, YoctoWatt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ExaWatt to YottaWatt
    /// </summary>
    /// <param name="val">quantity measured in ExaWatt</param>
    /// <returns>quantity measured in YottaWatt</returns>
	public static Quantity<double, YottaWatt> ToYottaWatt<T>(this Quantity<T, ExaWatt> val) where T:IConvertible {
        return new Quantity<double, YottaWatt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaWatt to ZettaWatt
    /// </summary>
    /// <param name="val">quantity measured in ExaWatt</param>
    /// <returns>quantity measured in ZettaWatt</returns>
	public static Quantity<double, ZettaWatt> ToZettaWatt<T>(this Quantity<T, ExaWatt> val) where T:IConvertible {
        return new Quantity<double, ZettaWatt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaWatt to PetaWatt
    /// </summary>
    /// <param name="val">quantity measured in ExaWatt</param>
    /// <returns>quantity measured in PetaWatt</returns>
	public static Quantity<double, PetaWatt> ToPetaWatt<T>(this Quantity<T, ExaWatt> val) where T:IConvertible {
        return new Quantity<double, PetaWatt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaWatt to TeraWatt
    /// </summary>
    /// <param name="val">quantity measured in ExaWatt</param>
    /// <returns>quantity measured in TeraWatt</returns>
	public static Quantity<double, TeraWatt> ToTeraWatt<T>(this Quantity<T, ExaWatt> val) where T:IConvertible {
        return new Quantity<double, TeraWatt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaWatt to GigaWatt
    /// </summary>
    /// <param name="val">quantity measured in ExaWatt</param>
    /// <returns>quantity measured in GigaWatt</returns>
	public static Quantity<double, GigaWatt> ToGigaWatt<T>(this Quantity<T, ExaWatt> val) where T:IConvertible {
        return new Quantity<double, GigaWatt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaWatt to MegaWatt
    /// </summary>
    /// <param name="val">quantity measured in ExaWatt</param>
    /// <returns>quantity measured in MegaWatt</returns>
	public static Quantity<double, MegaWatt> ToMegaWatt<T>(this Quantity<T, ExaWatt> val) where T:IConvertible {
        return new Quantity<double, MegaWatt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaWatt to KiloWatt
    /// </summary>
    /// <param name="val">quantity measured in ExaWatt</param>
    /// <returns>quantity measured in KiloWatt</returns>
	public static Quantity<double, KiloWatt> ToKiloWatt<T>(this Quantity<T, ExaWatt> val) where T:IConvertible {
        return new Quantity<double, KiloWatt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaWatt to HectoWatt
    /// </summary>
    /// <param name="val">quantity measured in ExaWatt</param>
    /// <returns>quantity measured in HectoWatt</returns>
	public static Quantity<double, HectoWatt> ToHectoWatt<T>(this Quantity<T, ExaWatt> val) where T:IConvertible {
        return new Quantity<double, HectoWatt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaWatt to DekaWatt
    /// </summary>
    /// <param name="val">quantity measured in ExaWatt</param>
    /// <returns>quantity measured in DekaWatt</returns>
	public static Quantity<double, DekaWatt> ToDekaWatt<T>(this Quantity<T, ExaWatt> val) where T:IConvertible {
        return new Quantity<double, DekaWatt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaWatt to DeciWatt
    /// </summary>
    /// <param name="val">quantity measured in ExaWatt</param>
    /// <returns>quantity measured in DeciWatt</returns>
	public static Quantity<double, DeciWatt> ToDeciWatt<T>(this Quantity<T, ExaWatt> val) where T:IConvertible {
        return new Quantity<double, DeciWatt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaWatt to CentiWatt
    /// </summary>
    /// <param name="val">quantity measured in ExaWatt</param>
    /// <returns>quantity measured in CentiWatt</returns>
	public static Quantity<double, CentiWatt> ToCentiWatt<T>(this Quantity<T, ExaWatt> val) where T:IConvertible {
        return new Quantity<double, CentiWatt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaWatt to MilliWatt
    /// </summary>
    /// <param name="val">quantity measured in ExaWatt</param>
    /// <returns>quantity measured in MilliWatt</returns>
	public static Quantity<double, MilliWatt> ToMilliWatt<T>(this Quantity<T, ExaWatt> val) where T:IConvertible {
        return new Quantity<double, MilliWatt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaWatt to MicroWatt
    /// </summary>
    /// <param name="val">quantity measured in ExaWatt</param>
    /// <returns>quantity measured in MicroWatt</returns>
	public static Quantity<double, MicroWatt> ToMicroWatt<T>(this Quantity<T, ExaWatt> val) where T:IConvertible {
        return new Quantity<double, MicroWatt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaWatt to NanoWatt
    /// </summary>
    /// <param name="val">quantity measured in ExaWatt</param>
    /// <returns>quantity measured in NanoWatt</returns>
	public static Quantity<double, NanoWatt> ToNanoWatt<T>(this Quantity<T, ExaWatt> val) where T:IConvertible {
        return new Quantity<double, NanoWatt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaWatt to PicoWatt
    /// </summary>
    /// <param name="val">quantity measured in ExaWatt</param>
    /// <returns>quantity measured in PicoWatt</returns>
	public static Quantity<double, PicoWatt> ToPicoWatt<T>(this Quantity<T, ExaWatt> val) where T:IConvertible {
        return new Quantity<double, PicoWatt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaWatt to FemtoWatt
    /// </summary>
    /// <param name="val">quantity measured in ExaWatt</param>
    /// <returns>quantity measured in FemtoWatt</returns>
	public static Quantity<double, FemtoWatt> ToFemtoWatt<T>(this Quantity<T, ExaWatt> val) where T:IConvertible {
        return new Quantity<double, FemtoWatt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaWatt to AttoWatt
    /// </summary>
    /// <param name="val">quantity measured in ExaWatt</param>
    /// <returns>quantity measured in AttoWatt</returns>
	public static Quantity<double, AttoWatt> ToAttoWatt<T>(this Quantity<T, ExaWatt> val) where T:IConvertible {
        return new Quantity<double, AttoWatt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaWatt to ZeptoWatt
    /// </summary>
    /// <param name="val">quantity measured in ExaWatt</param>
    /// <returns>quantity measured in ZeptoWatt</returns>
	public static Quantity<double, ZeptoWatt> ToZeptoWatt<T>(this Quantity<T, ExaWatt> val) where T:IConvertible {
        return new Quantity<double, ZeptoWatt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaWatt to YoctoWatt
    /// </summary>
    /// <param name="val">quantity measured in ExaWatt</param>
    /// <returns>quantity measured in YoctoWatt</returns>
	public static Quantity<double, YoctoWatt> ToYoctoWatt<T>(this Quantity<T, ExaWatt> val) where T:IConvertible {
        return new Quantity<double, YoctoWatt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert PetaWatt to YottaWatt
    /// </summary>
    /// <param name="val">quantity measured in PetaWatt</param>
    /// <returns>quantity measured in YottaWatt</returns>
	public static Quantity<double, YottaWatt> ToYottaWatt<T>(this Quantity<T, PetaWatt> val) where T:IConvertible {
        return new Quantity<double, YottaWatt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaWatt to ZettaWatt
    /// </summary>
    /// <param name="val">quantity measured in PetaWatt</param>
    /// <returns>quantity measured in ZettaWatt</returns>
	public static Quantity<double, ZettaWatt> ToZettaWatt<T>(this Quantity<T, PetaWatt> val) where T:IConvertible {
        return new Quantity<double, ZettaWatt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaWatt to ExaWatt
    /// </summary>
    /// <param name="val">quantity measured in PetaWatt</param>
    /// <returns>quantity measured in ExaWatt</returns>
	public static Quantity<double, ExaWatt> ToExaWatt<T>(this Quantity<T, PetaWatt> val) where T:IConvertible {
        return new Quantity<double, ExaWatt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaWatt to TeraWatt
    /// </summary>
    /// <param name="val">quantity measured in PetaWatt</param>
    /// <returns>quantity measured in TeraWatt</returns>
	public static Quantity<double, TeraWatt> ToTeraWatt<T>(this Quantity<T, PetaWatt> val) where T:IConvertible {
        return new Quantity<double, TeraWatt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaWatt to GigaWatt
    /// </summary>
    /// <param name="val">quantity measured in PetaWatt</param>
    /// <returns>quantity measured in GigaWatt</returns>
	public static Quantity<double, GigaWatt> ToGigaWatt<T>(this Quantity<T, PetaWatt> val) where T:IConvertible {
        return new Quantity<double, GigaWatt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaWatt to MegaWatt
    /// </summary>
    /// <param name="val">quantity measured in PetaWatt</param>
    /// <returns>quantity measured in MegaWatt</returns>
	public static Quantity<double, MegaWatt> ToMegaWatt<T>(this Quantity<T, PetaWatt> val) where T:IConvertible {
        return new Quantity<double, MegaWatt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaWatt to KiloWatt
    /// </summary>
    /// <param name="val">quantity measured in PetaWatt</param>
    /// <returns>quantity measured in KiloWatt</returns>
	public static Quantity<double, KiloWatt> ToKiloWatt<T>(this Quantity<T, PetaWatt> val) where T:IConvertible {
        return new Quantity<double, KiloWatt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaWatt to HectoWatt
    /// </summary>
    /// <param name="val">quantity measured in PetaWatt</param>
    /// <returns>quantity measured in HectoWatt</returns>
	public static Quantity<double, HectoWatt> ToHectoWatt<T>(this Quantity<T, PetaWatt> val) where T:IConvertible {
        return new Quantity<double, HectoWatt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaWatt to DekaWatt
    /// </summary>
    /// <param name="val">quantity measured in PetaWatt</param>
    /// <returns>quantity measured in DekaWatt</returns>
	public static Quantity<double, DekaWatt> ToDekaWatt<T>(this Quantity<T, PetaWatt> val) where T:IConvertible {
        return new Quantity<double, DekaWatt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaWatt to DeciWatt
    /// </summary>
    /// <param name="val">quantity measured in PetaWatt</param>
    /// <returns>quantity measured in DeciWatt</returns>
	public static Quantity<double, DeciWatt> ToDeciWatt<T>(this Quantity<T, PetaWatt> val) where T:IConvertible {
        return new Quantity<double, DeciWatt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaWatt to CentiWatt
    /// </summary>
    /// <param name="val">quantity measured in PetaWatt</param>
    /// <returns>quantity measured in CentiWatt</returns>
	public static Quantity<double, CentiWatt> ToCentiWatt<T>(this Quantity<T, PetaWatt> val) where T:IConvertible {
        return new Quantity<double, CentiWatt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaWatt to MilliWatt
    /// </summary>
    /// <param name="val">quantity measured in PetaWatt</param>
    /// <returns>quantity measured in MilliWatt</returns>
	public static Quantity<double, MilliWatt> ToMilliWatt<T>(this Quantity<T, PetaWatt> val) where T:IConvertible {
        return new Quantity<double, MilliWatt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaWatt to MicroWatt
    /// </summary>
    /// <param name="val">quantity measured in PetaWatt</param>
    /// <returns>quantity measured in MicroWatt</returns>
	public static Quantity<double, MicroWatt> ToMicroWatt<T>(this Quantity<T, PetaWatt> val) where T:IConvertible {
        return new Quantity<double, MicroWatt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaWatt to NanoWatt
    /// </summary>
    /// <param name="val">quantity measured in PetaWatt</param>
    /// <returns>quantity measured in NanoWatt</returns>
	public static Quantity<double, NanoWatt> ToNanoWatt<T>(this Quantity<T, PetaWatt> val) where T:IConvertible {
        return new Quantity<double, NanoWatt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaWatt to PicoWatt
    /// </summary>
    /// <param name="val">quantity measured in PetaWatt</param>
    /// <returns>quantity measured in PicoWatt</returns>
	public static Quantity<double, PicoWatt> ToPicoWatt<T>(this Quantity<T, PetaWatt> val) where T:IConvertible {
        return new Quantity<double, PicoWatt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaWatt to FemtoWatt
    /// </summary>
    /// <param name="val">quantity measured in PetaWatt</param>
    /// <returns>quantity measured in FemtoWatt</returns>
	public static Quantity<double, FemtoWatt> ToFemtoWatt<T>(this Quantity<T, PetaWatt> val) where T:IConvertible {
        return new Quantity<double, FemtoWatt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaWatt to AttoWatt
    /// </summary>
    /// <param name="val">quantity measured in PetaWatt</param>
    /// <returns>quantity measured in AttoWatt</returns>
	public static Quantity<double, AttoWatt> ToAttoWatt<T>(this Quantity<T, PetaWatt> val) where T:IConvertible {
        return new Quantity<double, AttoWatt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaWatt to ZeptoWatt
    /// </summary>
    /// <param name="val">quantity measured in PetaWatt</param>
    /// <returns>quantity measured in ZeptoWatt</returns>
	public static Quantity<double, ZeptoWatt> ToZeptoWatt<T>(this Quantity<T, PetaWatt> val) where T:IConvertible {
        return new Quantity<double, ZeptoWatt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaWatt to YoctoWatt
    /// </summary>
    /// <param name="val">quantity measured in PetaWatt</param>
    /// <returns>quantity measured in YoctoWatt</returns>
	public static Quantity<double, YoctoWatt> ToYoctoWatt<T>(this Quantity<T, PetaWatt> val) where T:IConvertible {
        return new Quantity<double, YoctoWatt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert TeraWatt to YottaWatt
    /// </summary>
    /// <param name="val">quantity measured in TeraWatt</param>
    /// <returns>quantity measured in YottaWatt</returns>
	public static Quantity<double, YottaWatt> ToYottaWatt<T>(this Quantity<T, TeraWatt> val) where T:IConvertible {
        return new Quantity<double, YottaWatt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraWatt to ZettaWatt
    /// </summary>
    /// <param name="val">quantity measured in TeraWatt</param>
    /// <returns>quantity measured in ZettaWatt</returns>
	public static Quantity<double, ZettaWatt> ToZettaWatt<T>(this Quantity<T, TeraWatt> val) where T:IConvertible {
        return new Quantity<double, ZettaWatt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraWatt to ExaWatt
    /// </summary>
    /// <param name="val">quantity measured in TeraWatt</param>
    /// <returns>quantity measured in ExaWatt</returns>
	public static Quantity<double, ExaWatt> ToExaWatt<T>(this Quantity<T, TeraWatt> val) where T:IConvertible {
        return new Quantity<double, ExaWatt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraWatt to PetaWatt
    /// </summary>
    /// <param name="val">quantity measured in TeraWatt</param>
    /// <returns>quantity measured in PetaWatt</returns>
	public static Quantity<double, PetaWatt> ToPetaWatt<T>(this Quantity<T, TeraWatt> val) where T:IConvertible {
        return new Quantity<double, PetaWatt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraWatt to GigaWatt
    /// </summary>
    /// <param name="val">quantity measured in TeraWatt</param>
    /// <returns>quantity measured in GigaWatt</returns>
	public static Quantity<double, GigaWatt> ToGigaWatt<T>(this Quantity<T, TeraWatt> val) where T:IConvertible {
        return new Quantity<double, GigaWatt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraWatt to MegaWatt
    /// </summary>
    /// <param name="val">quantity measured in TeraWatt</param>
    /// <returns>quantity measured in MegaWatt</returns>
	public static Quantity<double, MegaWatt> ToMegaWatt<T>(this Quantity<T, TeraWatt> val) where T:IConvertible {
        return new Quantity<double, MegaWatt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraWatt to KiloWatt
    /// </summary>
    /// <param name="val">quantity measured in TeraWatt</param>
    /// <returns>quantity measured in KiloWatt</returns>
	public static Quantity<double, KiloWatt> ToKiloWatt<T>(this Quantity<T, TeraWatt> val) where T:IConvertible {
        return new Quantity<double, KiloWatt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraWatt to HectoWatt
    /// </summary>
    /// <param name="val">quantity measured in TeraWatt</param>
    /// <returns>quantity measured in HectoWatt</returns>
	public static Quantity<double, HectoWatt> ToHectoWatt<T>(this Quantity<T, TeraWatt> val) where T:IConvertible {
        return new Quantity<double, HectoWatt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraWatt to DekaWatt
    /// </summary>
    /// <param name="val">quantity measured in TeraWatt</param>
    /// <returns>quantity measured in DekaWatt</returns>
	public static Quantity<double, DekaWatt> ToDekaWatt<T>(this Quantity<T, TeraWatt> val) where T:IConvertible {
        return new Quantity<double, DekaWatt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraWatt to DeciWatt
    /// </summary>
    /// <param name="val">quantity measured in TeraWatt</param>
    /// <returns>quantity measured in DeciWatt</returns>
	public static Quantity<double, DeciWatt> ToDeciWatt<T>(this Quantity<T, TeraWatt> val) where T:IConvertible {
        return new Quantity<double, DeciWatt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraWatt to CentiWatt
    /// </summary>
    /// <param name="val">quantity measured in TeraWatt</param>
    /// <returns>quantity measured in CentiWatt</returns>
	public static Quantity<double, CentiWatt> ToCentiWatt<T>(this Quantity<T, TeraWatt> val) where T:IConvertible {
        return new Quantity<double, CentiWatt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraWatt to MilliWatt
    /// </summary>
    /// <param name="val">quantity measured in TeraWatt</param>
    /// <returns>quantity measured in MilliWatt</returns>
	public static Quantity<double, MilliWatt> ToMilliWatt<T>(this Quantity<T, TeraWatt> val) where T:IConvertible {
        return new Quantity<double, MilliWatt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraWatt to MicroWatt
    /// </summary>
    /// <param name="val">quantity measured in TeraWatt</param>
    /// <returns>quantity measured in MicroWatt</returns>
	public static Quantity<double, MicroWatt> ToMicroWatt<T>(this Quantity<T, TeraWatt> val) where T:IConvertible {
        return new Quantity<double, MicroWatt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraWatt to NanoWatt
    /// </summary>
    /// <param name="val">quantity measured in TeraWatt</param>
    /// <returns>quantity measured in NanoWatt</returns>
	public static Quantity<double, NanoWatt> ToNanoWatt<T>(this Quantity<T, TeraWatt> val) where T:IConvertible {
        return new Quantity<double, NanoWatt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraWatt to PicoWatt
    /// </summary>
    /// <param name="val">quantity measured in TeraWatt</param>
    /// <returns>quantity measured in PicoWatt</returns>
	public static Quantity<double, PicoWatt> ToPicoWatt<T>(this Quantity<T, TeraWatt> val) where T:IConvertible {
        return new Quantity<double, PicoWatt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraWatt to FemtoWatt
    /// </summary>
    /// <param name="val">quantity measured in TeraWatt</param>
    /// <returns>quantity measured in FemtoWatt</returns>
	public static Quantity<double, FemtoWatt> ToFemtoWatt<T>(this Quantity<T, TeraWatt> val) where T:IConvertible {
        return new Quantity<double, FemtoWatt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraWatt to AttoWatt
    /// </summary>
    /// <param name="val">quantity measured in TeraWatt</param>
    /// <returns>quantity measured in AttoWatt</returns>
	public static Quantity<double, AttoWatt> ToAttoWatt<T>(this Quantity<T, TeraWatt> val) where T:IConvertible {
        return new Quantity<double, AttoWatt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraWatt to ZeptoWatt
    /// </summary>
    /// <param name="val">quantity measured in TeraWatt</param>
    /// <returns>quantity measured in ZeptoWatt</returns>
	public static Quantity<double, ZeptoWatt> ToZeptoWatt<T>(this Quantity<T, TeraWatt> val) where T:IConvertible {
        return new Quantity<double, ZeptoWatt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraWatt to YoctoWatt
    /// </summary>
    /// <param name="val">quantity measured in TeraWatt</param>
    /// <returns>quantity measured in YoctoWatt</returns>
	public static Quantity<double, YoctoWatt> ToYoctoWatt<T>(this Quantity<T, TeraWatt> val) where T:IConvertible {
        return new Quantity<double, YoctoWatt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert GigaWatt to YottaWatt
    /// </summary>
    /// <param name="val">quantity measured in GigaWatt</param>
    /// <returns>quantity measured in YottaWatt</returns>
	public static Quantity<double, YottaWatt> ToYottaWatt<T>(this Quantity<T, GigaWatt> val) where T:IConvertible {
        return new Quantity<double, YottaWatt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaWatt to ZettaWatt
    /// </summary>
    /// <param name="val">quantity measured in GigaWatt</param>
    /// <returns>quantity measured in ZettaWatt</returns>
	public static Quantity<double, ZettaWatt> ToZettaWatt<T>(this Quantity<T, GigaWatt> val) where T:IConvertible {
        return new Quantity<double, ZettaWatt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaWatt to ExaWatt
    /// </summary>
    /// <param name="val">quantity measured in GigaWatt</param>
    /// <returns>quantity measured in ExaWatt</returns>
	public static Quantity<double, ExaWatt> ToExaWatt<T>(this Quantity<T, GigaWatt> val) where T:IConvertible {
        return new Quantity<double, ExaWatt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaWatt to PetaWatt
    /// </summary>
    /// <param name="val">quantity measured in GigaWatt</param>
    /// <returns>quantity measured in PetaWatt</returns>
	public static Quantity<double, PetaWatt> ToPetaWatt<T>(this Quantity<T, GigaWatt> val) where T:IConvertible {
        return new Quantity<double, PetaWatt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaWatt to TeraWatt
    /// </summary>
    /// <param name="val">quantity measured in GigaWatt</param>
    /// <returns>quantity measured in TeraWatt</returns>
	public static Quantity<double, TeraWatt> ToTeraWatt<T>(this Quantity<T, GigaWatt> val) where T:IConvertible {
        return new Quantity<double, TeraWatt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaWatt to MegaWatt
    /// </summary>
    /// <param name="val">quantity measured in GigaWatt</param>
    /// <returns>quantity measured in MegaWatt</returns>
	public static Quantity<double, MegaWatt> ToMegaWatt<T>(this Quantity<T, GigaWatt> val) where T:IConvertible {
        return new Quantity<double, MegaWatt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaWatt to KiloWatt
    /// </summary>
    /// <param name="val">quantity measured in GigaWatt</param>
    /// <returns>quantity measured in KiloWatt</returns>
	public static Quantity<double, KiloWatt> ToKiloWatt<T>(this Quantity<T, GigaWatt> val) where T:IConvertible {
        return new Quantity<double, KiloWatt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaWatt to HectoWatt
    /// </summary>
    /// <param name="val">quantity measured in GigaWatt</param>
    /// <returns>quantity measured in HectoWatt</returns>
	public static Quantity<double, HectoWatt> ToHectoWatt<T>(this Quantity<T, GigaWatt> val) where T:IConvertible {
        return new Quantity<double, HectoWatt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaWatt to DekaWatt
    /// </summary>
    /// <param name="val">quantity measured in GigaWatt</param>
    /// <returns>quantity measured in DekaWatt</returns>
	public static Quantity<double, DekaWatt> ToDekaWatt<T>(this Quantity<T, GigaWatt> val) where T:IConvertible {
        return new Quantity<double, DekaWatt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaWatt to DeciWatt
    /// </summary>
    /// <param name="val">quantity measured in GigaWatt</param>
    /// <returns>quantity measured in DeciWatt</returns>
	public static Quantity<double, DeciWatt> ToDeciWatt<T>(this Quantity<T, GigaWatt> val) where T:IConvertible {
        return new Quantity<double, DeciWatt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaWatt to CentiWatt
    /// </summary>
    /// <param name="val">quantity measured in GigaWatt</param>
    /// <returns>quantity measured in CentiWatt</returns>
	public static Quantity<double, CentiWatt> ToCentiWatt<T>(this Quantity<T, GigaWatt> val) where T:IConvertible {
        return new Quantity<double, CentiWatt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaWatt to MilliWatt
    /// </summary>
    /// <param name="val">quantity measured in GigaWatt</param>
    /// <returns>quantity measured in MilliWatt</returns>
	public static Quantity<double, MilliWatt> ToMilliWatt<T>(this Quantity<T, GigaWatt> val) where T:IConvertible {
        return new Quantity<double, MilliWatt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaWatt to MicroWatt
    /// </summary>
    /// <param name="val">quantity measured in GigaWatt</param>
    /// <returns>quantity measured in MicroWatt</returns>
	public static Quantity<double, MicroWatt> ToMicroWatt<T>(this Quantity<T, GigaWatt> val) where T:IConvertible {
        return new Quantity<double, MicroWatt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaWatt to NanoWatt
    /// </summary>
    /// <param name="val">quantity measured in GigaWatt</param>
    /// <returns>quantity measured in NanoWatt</returns>
	public static Quantity<double, NanoWatt> ToNanoWatt<T>(this Quantity<T, GigaWatt> val) where T:IConvertible {
        return new Quantity<double, NanoWatt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaWatt to PicoWatt
    /// </summary>
    /// <param name="val">quantity measured in GigaWatt</param>
    /// <returns>quantity measured in PicoWatt</returns>
	public static Quantity<double, PicoWatt> ToPicoWatt<T>(this Quantity<T, GigaWatt> val) where T:IConvertible {
        return new Quantity<double, PicoWatt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaWatt to FemtoWatt
    /// </summary>
    /// <param name="val">quantity measured in GigaWatt</param>
    /// <returns>quantity measured in FemtoWatt</returns>
	public static Quantity<double, FemtoWatt> ToFemtoWatt<T>(this Quantity<T, GigaWatt> val) where T:IConvertible {
        return new Quantity<double, FemtoWatt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaWatt to AttoWatt
    /// </summary>
    /// <param name="val">quantity measured in GigaWatt</param>
    /// <returns>quantity measured in AttoWatt</returns>
	public static Quantity<double, AttoWatt> ToAttoWatt<T>(this Quantity<T, GigaWatt> val) where T:IConvertible {
        return new Quantity<double, AttoWatt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaWatt to ZeptoWatt
    /// </summary>
    /// <param name="val">quantity measured in GigaWatt</param>
    /// <returns>quantity measured in ZeptoWatt</returns>
	public static Quantity<double, ZeptoWatt> ToZeptoWatt<T>(this Quantity<T, GigaWatt> val) where T:IConvertible {
        return new Quantity<double, ZeptoWatt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaWatt to YoctoWatt
    /// </summary>
    /// <param name="val">quantity measured in GigaWatt</param>
    /// <returns>quantity measured in YoctoWatt</returns>
	public static Quantity<double, YoctoWatt> ToYoctoWatt<T>(this Quantity<T, GigaWatt> val) where T:IConvertible {
        return new Quantity<double, YoctoWatt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert MegaWatt to YottaWatt
    /// </summary>
    /// <param name="val">quantity measured in MegaWatt</param>
    /// <returns>quantity measured in YottaWatt</returns>
	public static Quantity<double, YottaWatt> ToYottaWatt<T>(this Quantity<T, MegaWatt> val) where T:IConvertible {
        return new Quantity<double, YottaWatt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaWatt to ZettaWatt
    /// </summary>
    /// <param name="val">quantity measured in MegaWatt</param>
    /// <returns>quantity measured in ZettaWatt</returns>
	public static Quantity<double, ZettaWatt> ToZettaWatt<T>(this Quantity<T, MegaWatt> val) where T:IConvertible {
        return new Quantity<double, ZettaWatt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaWatt to ExaWatt
    /// </summary>
    /// <param name="val">quantity measured in MegaWatt</param>
    /// <returns>quantity measured in ExaWatt</returns>
	public static Quantity<double, ExaWatt> ToExaWatt<T>(this Quantity<T, MegaWatt> val) where T:IConvertible {
        return new Quantity<double, ExaWatt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaWatt to PetaWatt
    /// </summary>
    /// <param name="val">quantity measured in MegaWatt</param>
    /// <returns>quantity measured in PetaWatt</returns>
	public static Quantity<double, PetaWatt> ToPetaWatt<T>(this Quantity<T, MegaWatt> val) where T:IConvertible {
        return new Quantity<double, PetaWatt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaWatt to TeraWatt
    /// </summary>
    /// <param name="val">quantity measured in MegaWatt</param>
    /// <returns>quantity measured in TeraWatt</returns>
	public static Quantity<double, TeraWatt> ToTeraWatt<T>(this Quantity<T, MegaWatt> val) where T:IConvertible {
        return new Quantity<double, TeraWatt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaWatt to GigaWatt
    /// </summary>
    /// <param name="val">quantity measured in MegaWatt</param>
    /// <returns>quantity measured in GigaWatt</returns>
	public static Quantity<double, GigaWatt> ToGigaWatt<T>(this Quantity<T, MegaWatt> val) where T:IConvertible {
        return new Quantity<double, GigaWatt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaWatt to KiloWatt
    /// </summary>
    /// <param name="val">quantity measured in MegaWatt</param>
    /// <returns>quantity measured in KiloWatt</returns>
	public static Quantity<double, KiloWatt> ToKiloWatt<T>(this Quantity<T, MegaWatt> val) where T:IConvertible {
        return new Quantity<double, KiloWatt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaWatt to HectoWatt
    /// </summary>
    /// <param name="val">quantity measured in MegaWatt</param>
    /// <returns>quantity measured in HectoWatt</returns>
	public static Quantity<double, HectoWatt> ToHectoWatt<T>(this Quantity<T, MegaWatt> val) where T:IConvertible {
        return new Quantity<double, HectoWatt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaWatt to DekaWatt
    /// </summary>
    /// <param name="val">quantity measured in MegaWatt</param>
    /// <returns>quantity measured in DekaWatt</returns>
	public static Quantity<double, DekaWatt> ToDekaWatt<T>(this Quantity<T, MegaWatt> val) where T:IConvertible {
        return new Quantity<double, DekaWatt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaWatt to DeciWatt
    /// </summary>
    /// <param name="val">quantity measured in MegaWatt</param>
    /// <returns>quantity measured in DeciWatt</returns>
	public static Quantity<double, DeciWatt> ToDeciWatt<T>(this Quantity<T, MegaWatt> val) where T:IConvertible {
        return new Quantity<double, DeciWatt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaWatt to CentiWatt
    /// </summary>
    /// <param name="val">quantity measured in MegaWatt</param>
    /// <returns>quantity measured in CentiWatt</returns>
	public static Quantity<double, CentiWatt> ToCentiWatt<T>(this Quantity<T, MegaWatt> val) where T:IConvertible {
        return new Quantity<double, CentiWatt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaWatt to MilliWatt
    /// </summary>
    /// <param name="val">quantity measured in MegaWatt</param>
    /// <returns>quantity measured in MilliWatt</returns>
	public static Quantity<double, MilliWatt> ToMilliWatt<T>(this Quantity<T, MegaWatt> val) where T:IConvertible {
        return new Quantity<double, MilliWatt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaWatt to MicroWatt
    /// </summary>
    /// <param name="val">quantity measured in MegaWatt</param>
    /// <returns>quantity measured in MicroWatt</returns>
	public static Quantity<double, MicroWatt> ToMicroWatt<T>(this Quantity<T, MegaWatt> val) where T:IConvertible {
        return new Quantity<double, MicroWatt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaWatt to NanoWatt
    /// </summary>
    /// <param name="val">quantity measured in MegaWatt</param>
    /// <returns>quantity measured in NanoWatt</returns>
	public static Quantity<double, NanoWatt> ToNanoWatt<T>(this Quantity<T, MegaWatt> val) where T:IConvertible {
        return new Quantity<double, NanoWatt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaWatt to PicoWatt
    /// </summary>
    /// <param name="val">quantity measured in MegaWatt</param>
    /// <returns>quantity measured in PicoWatt</returns>
	public static Quantity<double, PicoWatt> ToPicoWatt<T>(this Quantity<T, MegaWatt> val) where T:IConvertible {
        return new Quantity<double, PicoWatt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaWatt to FemtoWatt
    /// </summary>
    /// <param name="val">quantity measured in MegaWatt</param>
    /// <returns>quantity measured in FemtoWatt</returns>
	public static Quantity<double, FemtoWatt> ToFemtoWatt<T>(this Quantity<T, MegaWatt> val) where T:IConvertible {
        return new Quantity<double, FemtoWatt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaWatt to AttoWatt
    /// </summary>
    /// <param name="val">quantity measured in MegaWatt</param>
    /// <returns>quantity measured in AttoWatt</returns>
	public static Quantity<double, AttoWatt> ToAttoWatt<T>(this Quantity<T, MegaWatt> val) where T:IConvertible {
        return new Quantity<double, AttoWatt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaWatt to ZeptoWatt
    /// </summary>
    /// <param name="val">quantity measured in MegaWatt</param>
    /// <returns>quantity measured in ZeptoWatt</returns>
	public static Quantity<double, ZeptoWatt> ToZeptoWatt<T>(this Quantity<T, MegaWatt> val) where T:IConvertible {
        return new Quantity<double, ZeptoWatt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaWatt to YoctoWatt
    /// </summary>
    /// <param name="val">quantity measured in MegaWatt</param>
    /// <returns>quantity measured in YoctoWatt</returns>
	public static Quantity<double, YoctoWatt> ToYoctoWatt<T>(this Quantity<T, MegaWatt> val) where T:IConvertible {
        return new Quantity<double, YoctoWatt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert KiloWatt to YottaWatt
    /// </summary>
    /// <param name="val">quantity measured in KiloWatt</param>
    /// <returns>quantity measured in YottaWatt</returns>
	public static Quantity<double, YottaWatt> ToYottaWatt<T>(this Quantity<T, KiloWatt> val) where T:IConvertible {
        return new Quantity<double, YottaWatt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloWatt to ZettaWatt
    /// </summary>
    /// <param name="val">quantity measured in KiloWatt</param>
    /// <returns>quantity measured in ZettaWatt</returns>
	public static Quantity<double, ZettaWatt> ToZettaWatt<T>(this Quantity<T, KiloWatt> val) where T:IConvertible {
        return new Quantity<double, ZettaWatt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloWatt to ExaWatt
    /// </summary>
    /// <param name="val">quantity measured in KiloWatt</param>
    /// <returns>quantity measured in ExaWatt</returns>
	public static Quantity<double, ExaWatt> ToExaWatt<T>(this Quantity<T, KiloWatt> val) where T:IConvertible {
        return new Quantity<double, ExaWatt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloWatt to PetaWatt
    /// </summary>
    /// <param name="val">quantity measured in KiloWatt</param>
    /// <returns>quantity measured in PetaWatt</returns>
	public static Quantity<double, PetaWatt> ToPetaWatt<T>(this Quantity<T, KiloWatt> val) where T:IConvertible {
        return new Quantity<double, PetaWatt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloWatt to TeraWatt
    /// </summary>
    /// <param name="val">quantity measured in KiloWatt</param>
    /// <returns>quantity measured in TeraWatt</returns>
	public static Quantity<double, TeraWatt> ToTeraWatt<T>(this Quantity<T, KiloWatt> val) where T:IConvertible {
        return new Quantity<double, TeraWatt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloWatt to GigaWatt
    /// </summary>
    /// <param name="val">quantity measured in KiloWatt</param>
    /// <returns>quantity measured in GigaWatt</returns>
	public static Quantity<double, GigaWatt> ToGigaWatt<T>(this Quantity<T, KiloWatt> val) where T:IConvertible {
        return new Quantity<double, GigaWatt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloWatt to MegaWatt
    /// </summary>
    /// <param name="val">quantity measured in KiloWatt</param>
    /// <returns>quantity measured in MegaWatt</returns>
	public static Quantity<double, MegaWatt> ToMegaWatt<T>(this Quantity<T, KiloWatt> val) where T:IConvertible {
        return new Quantity<double, MegaWatt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloWatt to HectoWatt
    /// </summary>
    /// <param name="val">quantity measured in KiloWatt</param>
    /// <returns>quantity measured in HectoWatt</returns>
	public static Quantity<double, HectoWatt> ToHectoWatt<T>(this Quantity<T, KiloWatt> val) where T:IConvertible {
        return new Quantity<double, HectoWatt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloWatt to DekaWatt
    /// </summary>
    /// <param name="val">quantity measured in KiloWatt</param>
    /// <returns>quantity measured in DekaWatt</returns>
	public static Quantity<double, DekaWatt> ToDekaWatt<T>(this Quantity<T, KiloWatt> val) where T:IConvertible {
        return new Quantity<double, DekaWatt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloWatt to DeciWatt
    /// </summary>
    /// <param name="val">quantity measured in KiloWatt</param>
    /// <returns>quantity measured in DeciWatt</returns>
	public static Quantity<double, DeciWatt> ToDeciWatt<T>(this Quantity<T, KiloWatt> val) where T:IConvertible {
        return new Quantity<double, DeciWatt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloWatt to CentiWatt
    /// </summary>
    /// <param name="val">quantity measured in KiloWatt</param>
    /// <returns>quantity measured in CentiWatt</returns>
	public static Quantity<double, CentiWatt> ToCentiWatt<T>(this Quantity<T, KiloWatt> val) where T:IConvertible {
        return new Quantity<double, CentiWatt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloWatt to MilliWatt
    /// </summary>
    /// <param name="val">quantity measured in KiloWatt</param>
    /// <returns>quantity measured in MilliWatt</returns>
	public static Quantity<double, MilliWatt> ToMilliWatt<T>(this Quantity<T, KiloWatt> val) where T:IConvertible {
        return new Quantity<double, MilliWatt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloWatt to MicroWatt
    /// </summary>
    /// <param name="val">quantity measured in KiloWatt</param>
    /// <returns>quantity measured in MicroWatt</returns>
	public static Quantity<double, MicroWatt> ToMicroWatt<T>(this Quantity<T, KiloWatt> val) where T:IConvertible {
        return new Quantity<double, MicroWatt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloWatt to NanoWatt
    /// </summary>
    /// <param name="val">quantity measured in KiloWatt</param>
    /// <returns>quantity measured in NanoWatt</returns>
	public static Quantity<double, NanoWatt> ToNanoWatt<T>(this Quantity<T, KiloWatt> val) where T:IConvertible {
        return new Quantity<double, NanoWatt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloWatt to PicoWatt
    /// </summary>
    /// <param name="val">quantity measured in KiloWatt</param>
    /// <returns>quantity measured in PicoWatt</returns>
	public static Quantity<double, PicoWatt> ToPicoWatt<T>(this Quantity<T, KiloWatt> val) where T:IConvertible {
        return new Quantity<double, PicoWatt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloWatt to FemtoWatt
    /// </summary>
    /// <param name="val">quantity measured in KiloWatt</param>
    /// <returns>quantity measured in FemtoWatt</returns>
	public static Quantity<double, FemtoWatt> ToFemtoWatt<T>(this Quantity<T, KiloWatt> val) where T:IConvertible {
        return new Quantity<double, FemtoWatt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloWatt to AttoWatt
    /// </summary>
    /// <param name="val">quantity measured in KiloWatt</param>
    /// <returns>quantity measured in AttoWatt</returns>
	public static Quantity<double, AttoWatt> ToAttoWatt<T>(this Quantity<T, KiloWatt> val) where T:IConvertible {
        return new Quantity<double, AttoWatt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloWatt to ZeptoWatt
    /// </summary>
    /// <param name="val">quantity measured in KiloWatt</param>
    /// <returns>quantity measured in ZeptoWatt</returns>
	public static Quantity<double, ZeptoWatt> ToZeptoWatt<T>(this Quantity<T, KiloWatt> val) where T:IConvertible {
        return new Quantity<double, ZeptoWatt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloWatt to YoctoWatt
    /// </summary>
    /// <param name="val">quantity measured in KiloWatt</param>
    /// <returns>quantity measured in YoctoWatt</returns>
	public static Quantity<double, YoctoWatt> ToYoctoWatt<T>(this Quantity<T, KiloWatt> val) where T:IConvertible {
        return new Quantity<double, YoctoWatt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert HectoWatt to YottaWatt
    /// </summary>
    /// <param name="val">quantity measured in HectoWatt</param>
    /// <returns>quantity measured in YottaWatt</returns>
	public static Quantity<double, YottaWatt> ToYottaWatt<T>(this Quantity<T, HectoWatt> val) where T:IConvertible {
        return new Quantity<double, YottaWatt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoWatt to ZettaWatt
    /// </summary>
    /// <param name="val">quantity measured in HectoWatt</param>
    /// <returns>quantity measured in ZettaWatt</returns>
	public static Quantity<double, ZettaWatt> ToZettaWatt<T>(this Quantity<T, HectoWatt> val) where T:IConvertible {
        return new Quantity<double, ZettaWatt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoWatt to ExaWatt
    /// </summary>
    /// <param name="val">quantity measured in HectoWatt</param>
    /// <returns>quantity measured in ExaWatt</returns>
	public static Quantity<double, ExaWatt> ToExaWatt<T>(this Quantity<T, HectoWatt> val) where T:IConvertible {
        return new Quantity<double, ExaWatt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoWatt to PetaWatt
    /// </summary>
    /// <param name="val">quantity measured in HectoWatt</param>
    /// <returns>quantity measured in PetaWatt</returns>
	public static Quantity<double, PetaWatt> ToPetaWatt<T>(this Quantity<T, HectoWatt> val) where T:IConvertible {
        return new Quantity<double, PetaWatt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoWatt to TeraWatt
    /// </summary>
    /// <param name="val">quantity measured in HectoWatt</param>
    /// <returns>quantity measured in TeraWatt</returns>
	public static Quantity<double, TeraWatt> ToTeraWatt<T>(this Quantity<T, HectoWatt> val) where T:IConvertible {
        return new Quantity<double, TeraWatt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoWatt to GigaWatt
    /// </summary>
    /// <param name="val">quantity measured in HectoWatt</param>
    /// <returns>quantity measured in GigaWatt</returns>
	public static Quantity<double, GigaWatt> ToGigaWatt<T>(this Quantity<T, HectoWatt> val) where T:IConvertible {
        return new Quantity<double, GigaWatt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoWatt to MegaWatt
    /// </summary>
    /// <param name="val">quantity measured in HectoWatt</param>
    /// <returns>quantity measured in MegaWatt</returns>
	public static Quantity<double, MegaWatt> ToMegaWatt<T>(this Quantity<T, HectoWatt> val) where T:IConvertible {
        return new Quantity<double, MegaWatt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoWatt to KiloWatt
    /// </summary>
    /// <param name="val">quantity measured in HectoWatt</param>
    /// <returns>quantity measured in KiloWatt</returns>
	public static Quantity<double, KiloWatt> ToKiloWatt<T>(this Quantity<T, HectoWatt> val) where T:IConvertible {
        return new Quantity<double, KiloWatt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoWatt to DekaWatt
    /// </summary>
    /// <param name="val">quantity measured in HectoWatt</param>
    /// <returns>quantity measured in DekaWatt</returns>
	public static Quantity<double, DekaWatt> ToDekaWatt<T>(this Quantity<T, HectoWatt> val) where T:IConvertible {
        return new Quantity<double, DekaWatt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoWatt to DeciWatt
    /// </summary>
    /// <param name="val">quantity measured in HectoWatt</param>
    /// <returns>quantity measured in DeciWatt</returns>
	public static Quantity<double, DeciWatt> ToDeciWatt<T>(this Quantity<T, HectoWatt> val) where T:IConvertible {
        return new Quantity<double, DeciWatt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoWatt to CentiWatt
    /// </summary>
    /// <param name="val">quantity measured in HectoWatt</param>
    /// <returns>quantity measured in CentiWatt</returns>
	public static Quantity<double, CentiWatt> ToCentiWatt<T>(this Quantity<T, HectoWatt> val) where T:IConvertible {
        return new Quantity<double, CentiWatt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoWatt to MilliWatt
    /// </summary>
    /// <param name="val">quantity measured in HectoWatt</param>
    /// <returns>quantity measured in MilliWatt</returns>
	public static Quantity<double, MilliWatt> ToMilliWatt<T>(this Quantity<T, HectoWatt> val) where T:IConvertible {
        return new Quantity<double, MilliWatt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoWatt to MicroWatt
    /// </summary>
    /// <param name="val">quantity measured in HectoWatt</param>
    /// <returns>quantity measured in MicroWatt</returns>
	public static Quantity<double, MicroWatt> ToMicroWatt<T>(this Quantity<T, HectoWatt> val) where T:IConvertible {
        return new Quantity<double, MicroWatt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoWatt to NanoWatt
    /// </summary>
    /// <param name="val">quantity measured in HectoWatt</param>
    /// <returns>quantity measured in NanoWatt</returns>
	public static Quantity<double, NanoWatt> ToNanoWatt<T>(this Quantity<T, HectoWatt> val) where T:IConvertible {
        return new Quantity<double, NanoWatt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoWatt to PicoWatt
    /// </summary>
    /// <param name="val">quantity measured in HectoWatt</param>
    /// <returns>quantity measured in PicoWatt</returns>
	public static Quantity<double, PicoWatt> ToPicoWatt<T>(this Quantity<T, HectoWatt> val) where T:IConvertible {
        return new Quantity<double, PicoWatt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoWatt to FemtoWatt
    /// </summary>
    /// <param name="val">quantity measured in HectoWatt</param>
    /// <returns>quantity measured in FemtoWatt</returns>
	public static Quantity<double, FemtoWatt> ToFemtoWatt<T>(this Quantity<T, HectoWatt> val) where T:IConvertible {
        return new Quantity<double, FemtoWatt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoWatt to AttoWatt
    /// </summary>
    /// <param name="val">quantity measured in HectoWatt</param>
    /// <returns>quantity measured in AttoWatt</returns>
	public static Quantity<double, AttoWatt> ToAttoWatt<T>(this Quantity<T, HectoWatt> val) where T:IConvertible {
        return new Quantity<double, AttoWatt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoWatt to ZeptoWatt
    /// </summary>
    /// <param name="val">quantity measured in HectoWatt</param>
    /// <returns>quantity measured in ZeptoWatt</returns>
	public static Quantity<double, ZeptoWatt> ToZeptoWatt<T>(this Quantity<T, HectoWatt> val) where T:IConvertible {
        return new Quantity<double, ZeptoWatt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoWatt to YoctoWatt
    /// </summary>
    /// <param name="val">quantity measured in HectoWatt</param>
    /// <returns>quantity measured in YoctoWatt</returns>
	public static Quantity<double, YoctoWatt> ToYoctoWatt<T>(this Quantity<T, HectoWatt> val) where T:IConvertible {
        return new Quantity<double, YoctoWatt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert DekaWatt to YottaWatt
    /// </summary>
    /// <param name="val">quantity measured in DekaWatt</param>
    /// <returns>quantity measured in YottaWatt</returns>
	public static Quantity<double, YottaWatt> ToYottaWatt<T>(this Quantity<T, DekaWatt> val) where T:IConvertible {
        return new Quantity<double, YottaWatt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaWatt to ZettaWatt
    /// </summary>
    /// <param name="val">quantity measured in DekaWatt</param>
    /// <returns>quantity measured in ZettaWatt</returns>
	public static Quantity<double, ZettaWatt> ToZettaWatt<T>(this Quantity<T, DekaWatt> val) where T:IConvertible {
        return new Quantity<double, ZettaWatt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaWatt to ExaWatt
    /// </summary>
    /// <param name="val">quantity measured in DekaWatt</param>
    /// <returns>quantity measured in ExaWatt</returns>
	public static Quantity<double, ExaWatt> ToExaWatt<T>(this Quantity<T, DekaWatt> val) where T:IConvertible {
        return new Quantity<double, ExaWatt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaWatt to PetaWatt
    /// </summary>
    /// <param name="val">quantity measured in DekaWatt</param>
    /// <returns>quantity measured in PetaWatt</returns>
	public static Quantity<double, PetaWatt> ToPetaWatt<T>(this Quantity<T, DekaWatt> val) where T:IConvertible {
        return new Quantity<double, PetaWatt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaWatt to TeraWatt
    /// </summary>
    /// <param name="val">quantity measured in DekaWatt</param>
    /// <returns>quantity measured in TeraWatt</returns>
	public static Quantity<double, TeraWatt> ToTeraWatt<T>(this Quantity<T, DekaWatt> val) where T:IConvertible {
        return new Quantity<double, TeraWatt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaWatt to GigaWatt
    /// </summary>
    /// <param name="val">quantity measured in DekaWatt</param>
    /// <returns>quantity measured in GigaWatt</returns>
	public static Quantity<double, GigaWatt> ToGigaWatt<T>(this Quantity<T, DekaWatt> val) where T:IConvertible {
        return new Quantity<double, GigaWatt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaWatt to MegaWatt
    /// </summary>
    /// <param name="val">quantity measured in DekaWatt</param>
    /// <returns>quantity measured in MegaWatt</returns>
	public static Quantity<double, MegaWatt> ToMegaWatt<T>(this Quantity<T, DekaWatt> val) where T:IConvertible {
        return new Quantity<double, MegaWatt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaWatt to KiloWatt
    /// </summary>
    /// <param name="val">quantity measured in DekaWatt</param>
    /// <returns>quantity measured in KiloWatt</returns>
	public static Quantity<double, KiloWatt> ToKiloWatt<T>(this Quantity<T, DekaWatt> val) where T:IConvertible {
        return new Quantity<double, KiloWatt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaWatt to HectoWatt
    /// </summary>
    /// <param name="val">quantity measured in DekaWatt</param>
    /// <returns>quantity measured in HectoWatt</returns>
	public static Quantity<double, HectoWatt> ToHectoWatt<T>(this Quantity<T, DekaWatt> val) where T:IConvertible {
        return new Quantity<double, HectoWatt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaWatt to DeciWatt
    /// </summary>
    /// <param name="val">quantity measured in DekaWatt</param>
    /// <returns>quantity measured in DeciWatt</returns>
	public static Quantity<double, DeciWatt> ToDeciWatt<T>(this Quantity<T, DekaWatt> val) where T:IConvertible {
        return new Quantity<double, DeciWatt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaWatt to CentiWatt
    /// </summary>
    /// <param name="val">quantity measured in DekaWatt</param>
    /// <returns>quantity measured in CentiWatt</returns>
	public static Quantity<double, CentiWatt> ToCentiWatt<T>(this Quantity<T, DekaWatt> val) where T:IConvertible {
        return new Quantity<double, CentiWatt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaWatt to MilliWatt
    /// </summary>
    /// <param name="val">quantity measured in DekaWatt</param>
    /// <returns>quantity measured in MilliWatt</returns>
	public static Quantity<double, MilliWatt> ToMilliWatt<T>(this Quantity<T, DekaWatt> val) where T:IConvertible {
        return new Quantity<double, MilliWatt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaWatt to MicroWatt
    /// </summary>
    /// <param name="val">quantity measured in DekaWatt</param>
    /// <returns>quantity measured in MicroWatt</returns>
	public static Quantity<double, MicroWatt> ToMicroWatt<T>(this Quantity<T, DekaWatt> val) where T:IConvertible {
        return new Quantity<double, MicroWatt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaWatt to NanoWatt
    /// </summary>
    /// <param name="val">quantity measured in DekaWatt</param>
    /// <returns>quantity measured in NanoWatt</returns>
	public static Quantity<double, NanoWatt> ToNanoWatt<T>(this Quantity<T, DekaWatt> val) where T:IConvertible {
        return new Quantity<double, NanoWatt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaWatt to PicoWatt
    /// </summary>
    /// <param name="val">quantity measured in DekaWatt</param>
    /// <returns>quantity measured in PicoWatt</returns>
	public static Quantity<double, PicoWatt> ToPicoWatt<T>(this Quantity<T, DekaWatt> val) where T:IConvertible {
        return new Quantity<double, PicoWatt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaWatt to FemtoWatt
    /// </summary>
    /// <param name="val">quantity measured in DekaWatt</param>
    /// <returns>quantity measured in FemtoWatt</returns>
	public static Quantity<double, FemtoWatt> ToFemtoWatt<T>(this Quantity<T, DekaWatt> val) where T:IConvertible {
        return new Quantity<double, FemtoWatt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaWatt to AttoWatt
    /// </summary>
    /// <param name="val">quantity measured in DekaWatt</param>
    /// <returns>quantity measured in AttoWatt</returns>
	public static Quantity<double, AttoWatt> ToAttoWatt<T>(this Quantity<T, DekaWatt> val) where T:IConvertible {
        return new Quantity<double, AttoWatt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaWatt to ZeptoWatt
    /// </summary>
    /// <param name="val">quantity measured in DekaWatt</param>
    /// <returns>quantity measured in ZeptoWatt</returns>
	public static Quantity<double, ZeptoWatt> ToZeptoWatt<T>(this Quantity<T, DekaWatt> val) where T:IConvertible {
        return new Quantity<double, ZeptoWatt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaWatt to YoctoWatt
    /// </summary>
    /// <param name="val">quantity measured in DekaWatt</param>
    /// <returns>quantity measured in YoctoWatt</returns>
	public static Quantity<double, YoctoWatt> ToYoctoWatt<T>(this Quantity<T, DekaWatt> val) where T:IConvertible {
        return new Quantity<double, YoctoWatt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DeciWatt to YottaWatt
    /// </summary>
    /// <param name="val">quantity measured in DeciWatt</param>
    /// <returns>quantity measured in YottaWatt</returns>
	public static Quantity<double, YottaWatt> ToYottaWatt<T>(this Quantity<T, DeciWatt> val) where T:IConvertible {
        return new Quantity<double, YottaWatt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciWatt to ZettaWatt
    /// </summary>
    /// <param name="val">quantity measured in DeciWatt</param>
    /// <returns>quantity measured in ZettaWatt</returns>
	public static Quantity<double, ZettaWatt> ToZettaWatt<T>(this Quantity<T, DeciWatt> val) where T:IConvertible {
        return new Quantity<double, ZettaWatt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciWatt to ExaWatt
    /// </summary>
    /// <param name="val">quantity measured in DeciWatt</param>
    /// <returns>quantity measured in ExaWatt</returns>
	public static Quantity<double, ExaWatt> ToExaWatt<T>(this Quantity<T, DeciWatt> val) where T:IConvertible {
        return new Quantity<double, ExaWatt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciWatt to PetaWatt
    /// </summary>
    /// <param name="val">quantity measured in DeciWatt</param>
    /// <returns>quantity measured in PetaWatt</returns>
	public static Quantity<double, PetaWatt> ToPetaWatt<T>(this Quantity<T, DeciWatt> val) where T:IConvertible {
        return new Quantity<double, PetaWatt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciWatt to TeraWatt
    /// </summary>
    /// <param name="val">quantity measured in DeciWatt</param>
    /// <returns>quantity measured in TeraWatt</returns>
	public static Quantity<double, TeraWatt> ToTeraWatt<T>(this Quantity<T, DeciWatt> val) where T:IConvertible {
        return new Quantity<double, TeraWatt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciWatt to GigaWatt
    /// </summary>
    /// <param name="val">quantity measured in DeciWatt</param>
    /// <returns>quantity measured in GigaWatt</returns>
	public static Quantity<double, GigaWatt> ToGigaWatt<T>(this Quantity<T, DeciWatt> val) where T:IConvertible {
        return new Quantity<double, GigaWatt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciWatt to MegaWatt
    /// </summary>
    /// <param name="val">quantity measured in DeciWatt</param>
    /// <returns>quantity measured in MegaWatt</returns>
	public static Quantity<double, MegaWatt> ToMegaWatt<T>(this Quantity<T, DeciWatt> val) where T:IConvertible {
        return new Quantity<double, MegaWatt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciWatt to KiloWatt
    /// </summary>
    /// <param name="val">quantity measured in DeciWatt</param>
    /// <returns>quantity measured in KiloWatt</returns>
	public static Quantity<double, KiloWatt> ToKiloWatt<T>(this Quantity<T, DeciWatt> val) where T:IConvertible {
        return new Quantity<double, KiloWatt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciWatt to HectoWatt
    /// </summary>
    /// <param name="val">quantity measured in DeciWatt</param>
    /// <returns>quantity measured in HectoWatt</returns>
	public static Quantity<double, HectoWatt> ToHectoWatt<T>(this Quantity<T, DeciWatt> val) where T:IConvertible {
        return new Quantity<double, HectoWatt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciWatt to DekaWatt
    /// </summary>
    /// <param name="val">quantity measured in DeciWatt</param>
    /// <returns>quantity measured in DekaWatt</returns>
	public static Quantity<double, DekaWatt> ToDekaWatt<T>(this Quantity<T, DeciWatt> val) where T:IConvertible {
        return new Quantity<double, DekaWatt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciWatt to CentiWatt
    /// </summary>
    /// <param name="val">quantity measured in DeciWatt</param>
    /// <returns>quantity measured in CentiWatt</returns>
	public static Quantity<double, CentiWatt> ToCentiWatt<T>(this Quantity<T, DeciWatt> val) where T:IConvertible {
        return new Quantity<double, CentiWatt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciWatt to MilliWatt
    /// </summary>
    /// <param name="val">quantity measured in DeciWatt</param>
    /// <returns>quantity measured in MilliWatt</returns>
	public static Quantity<double, MilliWatt> ToMilliWatt<T>(this Quantity<T, DeciWatt> val) where T:IConvertible {
        return new Quantity<double, MilliWatt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciWatt to MicroWatt
    /// </summary>
    /// <param name="val">quantity measured in DeciWatt</param>
    /// <returns>quantity measured in MicroWatt</returns>
	public static Quantity<double, MicroWatt> ToMicroWatt<T>(this Quantity<T, DeciWatt> val) where T:IConvertible {
        return new Quantity<double, MicroWatt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciWatt to NanoWatt
    /// </summary>
    /// <param name="val">quantity measured in DeciWatt</param>
    /// <returns>quantity measured in NanoWatt</returns>
	public static Quantity<double, NanoWatt> ToNanoWatt<T>(this Quantity<T, DeciWatt> val) where T:IConvertible {
        return new Quantity<double, NanoWatt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciWatt to PicoWatt
    /// </summary>
    /// <param name="val">quantity measured in DeciWatt</param>
    /// <returns>quantity measured in PicoWatt</returns>
	public static Quantity<double, PicoWatt> ToPicoWatt<T>(this Quantity<T, DeciWatt> val) where T:IConvertible {
        return new Quantity<double, PicoWatt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciWatt to FemtoWatt
    /// </summary>
    /// <param name="val">quantity measured in DeciWatt</param>
    /// <returns>quantity measured in FemtoWatt</returns>
	public static Quantity<double, FemtoWatt> ToFemtoWatt<T>(this Quantity<T, DeciWatt> val) where T:IConvertible {
        return new Quantity<double, FemtoWatt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciWatt to AttoWatt
    /// </summary>
    /// <param name="val">quantity measured in DeciWatt</param>
    /// <returns>quantity measured in AttoWatt</returns>
	public static Quantity<double, AttoWatt> ToAttoWatt<T>(this Quantity<T, DeciWatt> val) where T:IConvertible {
        return new Quantity<double, AttoWatt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciWatt to ZeptoWatt
    /// </summary>
    /// <param name="val">quantity measured in DeciWatt</param>
    /// <returns>quantity measured in ZeptoWatt</returns>
	public static Quantity<double, ZeptoWatt> ToZeptoWatt<T>(this Quantity<T, DeciWatt> val) where T:IConvertible {
        return new Quantity<double, ZeptoWatt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciWatt to YoctoWatt
    /// </summary>
    /// <param name="val">quantity measured in DeciWatt</param>
    /// <returns>quantity measured in YoctoWatt</returns>
	public static Quantity<double, YoctoWatt> ToYoctoWatt<T>(this Quantity<T, DeciWatt> val) where T:IConvertible {
        return new Quantity<double, YoctoWatt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert CentiWatt to YottaWatt
    /// </summary>
    /// <param name="val">quantity measured in CentiWatt</param>
    /// <returns>quantity measured in YottaWatt</returns>
	public static Quantity<double, YottaWatt> ToYottaWatt<T>(this Quantity<T, CentiWatt> val) where T:IConvertible {
        return new Quantity<double, YottaWatt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiWatt to ZettaWatt
    /// </summary>
    /// <param name="val">quantity measured in CentiWatt</param>
    /// <returns>quantity measured in ZettaWatt</returns>
	public static Quantity<double, ZettaWatt> ToZettaWatt<T>(this Quantity<T, CentiWatt> val) where T:IConvertible {
        return new Quantity<double, ZettaWatt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiWatt to ExaWatt
    /// </summary>
    /// <param name="val">quantity measured in CentiWatt</param>
    /// <returns>quantity measured in ExaWatt</returns>
	public static Quantity<double, ExaWatt> ToExaWatt<T>(this Quantity<T, CentiWatt> val) where T:IConvertible {
        return new Quantity<double, ExaWatt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiWatt to PetaWatt
    /// </summary>
    /// <param name="val">quantity measured in CentiWatt</param>
    /// <returns>quantity measured in PetaWatt</returns>
	public static Quantity<double, PetaWatt> ToPetaWatt<T>(this Quantity<T, CentiWatt> val) where T:IConvertible {
        return new Quantity<double, PetaWatt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiWatt to TeraWatt
    /// </summary>
    /// <param name="val">quantity measured in CentiWatt</param>
    /// <returns>quantity measured in TeraWatt</returns>
	public static Quantity<double, TeraWatt> ToTeraWatt<T>(this Quantity<T, CentiWatt> val) where T:IConvertible {
        return new Quantity<double, TeraWatt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiWatt to GigaWatt
    /// </summary>
    /// <param name="val">quantity measured in CentiWatt</param>
    /// <returns>quantity measured in GigaWatt</returns>
	public static Quantity<double, GigaWatt> ToGigaWatt<T>(this Quantity<T, CentiWatt> val) where T:IConvertible {
        return new Quantity<double, GigaWatt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiWatt to MegaWatt
    /// </summary>
    /// <param name="val">quantity measured in CentiWatt</param>
    /// <returns>quantity measured in MegaWatt</returns>
	public static Quantity<double, MegaWatt> ToMegaWatt<T>(this Quantity<T, CentiWatt> val) where T:IConvertible {
        return new Quantity<double, MegaWatt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiWatt to KiloWatt
    /// </summary>
    /// <param name="val">quantity measured in CentiWatt</param>
    /// <returns>quantity measured in KiloWatt</returns>
	public static Quantity<double, KiloWatt> ToKiloWatt<T>(this Quantity<T, CentiWatt> val) where T:IConvertible {
        return new Quantity<double, KiloWatt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiWatt to HectoWatt
    /// </summary>
    /// <param name="val">quantity measured in CentiWatt</param>
    /// <returns>quantity measured in HectoWatt</returns>
	public static Quantity<double, HectoWatt> ToHectoWatt<T>(this Quantity<T, CentiWatt> val) where T:IConvertible {
        return new Quantity<double, HectoWatt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiWatt to DekaWatt
    /// </summary>
    /// <param name="val">quantity measured in CentiWatt</param>
    /// <returns>quantity measured in DekaWatt</returns>
	public static Quantity<double, DekaWatt> ToDekaWatt<T>(this Quantity<T, CentiWatt> val) where T:IConvertible {
        return new Quantity<double, DekaWatt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiWatt to DeciWatt
    /// </summary>
    /// <param name="val">quantity measured in CentiWatt</param>
    /// <returns>quantity measured in DeciWatt</returns>
	public static Quantity<double, DeciWatt> ToDeciWatt<T>(this Quantity<T, CentiWatt> val) where T:IConvertible {
        return new Quantity<double, DeciWatt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiWatt to MilliWatt
    /// </summary>
    /// <param name="val">quantity measured in CentiWatt</param>
    /// <returns>quantity measured in MilliWatt</returns>
	public static Quantity<double, MilliWatt> ToMilliWatt<T>(this Quantity<T, CentiWatt> val) where T:IConvertible {
        return new Quantity<double, MilliWatt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiWatt to MicroWatt
    /// </summary>
    /// <param name="val">quantity measured in CentiWatt</param>
    /// <returns>quantity measured in MicroWatt</returns>
	public static Quantity<double, MicroWatt> ToMicroWatt<T>(this Quantity<T, CentiWatt> val) where T:IConvertible {
        return new Quantity<double, MicroWatt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiWatt to NanoWatt
    /// </summary>
    /// <param name="val">quantity measured in CentiWatt</param>
    /// <returns>quantity measured in NanoWatt</returns>
	public static Quantity<double, NanoWatt> ToNanoWatt<T>(this Quantity<T, CentiWatt> val) where T:IConvertible {
        return new Quantity<double, NanoWatt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiWatt to PicoWatt
    /// </summary>
    /// <param name="val">quantity measured in CentiWatt</param>
    /// <returns>quantity measured in PicoWatt</returns>
	public static Quantity<double, PicoWatt> ToPicoWatt<T>(this Quantity<T, CentiWatt> val) where T:IConvertible {
        return new Quantity<double, PicoWatt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiWatt to FemtoWatt
    /// </summary>
    /// <param name="val">quantity measured in CentiWatt</param>
    /// <returns>quantity measured in FemtoWatt</returns>
	public static Quantity<double, FemtoWatt> ToFemtoWatt<T>(this Quantity<T, CentiWatt> val) where T:IConvertible {
        return new Quantity<double, FemtoWatt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiWatt to AttoWatt
    /// </summary>
    /// <param name="val">quantity measured in CentiWatt</param>
    /// <returns>quantity measured in AttoWatt</returns>
	public static Quantity<double, AttoWatt> ToAttoWatt<T>(this Quantity<T, CentiWatt> val) where T:IConvertible {
        return new Quantity<double, AttoWatt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiWatt to ZeptoWatt
    /// </summary>
    /// <param name="val">quantity measured in CentiWatt</param>
    /// <returns>quantity measured in ZeptoWatt</returns>
	public static Quantity<double, ZeptoWatt> ToZeptoWatt<T>(this Quantity<T, CentiWatt> val) where T:IConvertible {
        return new Quantity<double, ZeptoWatt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiWatt to YoctoWatt
    /// </summary>
    /// <param name="val">quantity measured in CentiWatt</param>
    /// <returns>quantity measured in YoctoWatt</returns>
	public static Quantity<double, YoctoWatt> ToYoctoWatt<T>(this Quantity<T, CentiWatt> val) where T:IConvertible {
        return new Quantity<double, YoctoWatt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert MilliWatt to YottaWatt
    /// </summary>
    /// <param name="val">quantity measured in MilliWatt</param>
    /// <returns>quantity measured in YottaWatt</returns>
	public static Quantity<double, YottaWatt> ToYottaWatt<T>(this Quantity<T, MilliWatt> val) where T:IConvertible {
        return new Quantity<double, YottaWatt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliWatt to ZettaWatt
    /// </summary>
    /// <param name="val">quantity measured in MilliWatt</param>
    /// <returns>quantity measured in ZettaWatt</returns>
	public static Quantity<double, ZettaWatt> ToZettaWatt<T>(this Quantity<T, MilliWatt> val) where T:IConvertible {
        return new Quantity<double, ZettaWatt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliWatt to ExaWatt
    /// </summary>
    /// <param name="val">quantity measured in MilliWatt</param>
    /// <returns>quantity measured in ExaWatt</returns>
	public static Quantity<double, ExaWatt> ToExaWatt<T>(this Quantity<T, MilliWatt> val) where T:IConvertible {
        return new Quantity<double, ExaWatt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliWatt to PetaWatt
    /// </summary>
    /// <param name="val">quantity measured in MilliWatt</param>
    /// <returns>quantity measured in PetaWatt</returns>
	public static Quantity<double, PetaWatt> ToPetaWatt<T>(this Quantity<T, MilliWatt> val) where T:IConvertible {
        return new Quantity<double, PetaWatt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliWatt to TeraWatt
    /// </summary>
    /// <param name="val">quantity measured in MilliWatt</param>
    /// <returns>quantity measured in TeraWatt</returns>
	public static Quantity<double, TeraWatt> ToTeraWatt<T>(this Quantity<T, MilliWatt> val) where T:IConvertible {
        return new Quantity<double, TeraWatt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliWatt to GigaWatt
    /// </summary>
    /// <param name="val">quantity measured in MilliWatt</param>
    /// <returns>quantity measured in GigaWatt</returns>
	public static Quantity<double, GigaWatt> ToGigaWatt<T>(this Quantity<T, MilliWatt> val) where T:IConvertible {
        return new Quantity<double, GigaWatt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliWatt to MegaWatt
    /// </summary>
    /// <param name="val">quantity measured in MilliWatt</param>
    /// <returns>quantity measured in MegaWatt</returns>
	public static Quantity<double, MegaWatt> ToMegaWatt<T>(this Quantity<T, MilliWatt> val) where T:IConvertible {
        return new Quantity<double, MegaWatt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliWatt to KiloWatt
    /// </summary>
    /// <param name="val">quantity measured in MilliWatt</param>
    /// <returns>quantity measured in KiloWatt</returns>
	public static Quantity<double, KiloWatt> ToKiloWatt<T>(this Quantity<T, MilliWatt> val) where T:IConvertible {
        return new Quantity<double, KiloWatt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliWatt to HectoWatt
    /// </summary>
    /// <param name="val">quantity measured in MilliWatt</param>
    /// <returns>quantity measured in HectoWatt</returns>
	public static Quantity<double, HectoWatt> ToHectoWatt<T>(this Quantity<T, MilliWatt> val) where T:IConvertible {
        return new Quantity<double, HectoWatt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliWatt to DekaWatt
    /// </summary>
    /// <param name="val">quantity measured in MilliWatt</param>
    /// <returns>quantity measured in DekaWatt</returns>
	public static Quantity<double, DekaWatt> ToDekaWatt<T>(this Quantity<T, MilliWatt> val) where T:IConvertible {
        return new Quantity<double, DekaWatt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliWatt to DeciWatt
    /// </summary>
    /// <param name="val">quantity measured in MilliWatt</param>
    /// <returns>quantity measured in DeciWatt</returns>
	public static Quantity<double, DeciWatt> ToDeciWatt<T>(this Quantity<T, MilliWatt> val) where T:IConvertible {
        return new Quantity<double, DeciWatt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliWatt to CentiWatt
    /// </summary>
    /// <param name="val">quantity measured in MilliWatt</param>
    /// <returns>quantity measured in CentiWatt</returns>
	public static Quantity<double, CentiWatt> ToCentiWatt<T>(this Quantity<T, MilliWatt> val) where T:IConvertible {
        return new Quantity<double, CentiWatt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliWatt to MicroWatt
    /// </summary>
    /// <param name="val">quantity measured in MilliWatt</param>
    /// <returns>quantity measured in MicroWatt</returns>
	public static Quantity<double, MicroWatt> ToMicroWatt<T>(this Quantity<T, MilliWatt> val) where T:IConvertible {
        return new Quantity<double, MicroWatt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliWatt to NanoWatt
    /// </summary>
    /// <param name="val">quantity measured in MilliWatt</param>
    /// <returns>quantity measured in NanoWatt</returns>
	public static Quantity<double, NanoWatt> ToNanoWatt<T>(this Quantity<T, MilliWatt> val) where T:IConvertible {
        return new Quantity<double, NanoWatt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliWatt to PicoWatt
    /// </summary>
    /// <param name="val">quantity measured in MilliWatt</param>
    /// <returns>quantity measured in PicoWatt</returns>
	public static Quantity<double, PicoWatt> ToPicoWatt<T>(this Quantity<T, MilliWatt> val) where T:IConvertible {
        return new Quantity<double, PicoWatt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliWatt to FemtoWatt
    /// </summary>
    /// <param name="val">quantity measured in MilliWatt</param>
    /// <returns>quantity measured in FemtoWatt</returns>
	public static Quantity<double, FemtoWatt> ToFemtoWatt<T>(this Quantity<T, MilliWatt> val) where T:IConvertible {
        return new Quantity<double, FemtoWatt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliWatt to AttoWatt
    /// </summary>
    /// <param name="val">quantity measured in MilliWatt</param>
    /// <returns>quantity measured in AttoWatt</returns>
	public static Quantity<double, AttoWatt> ToAttoWatt<T>(this Quantity<T, MilliWatt> val) where T:IConvertible {
        return new Quantity<double, AttoWatt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliWatt to ZeptoWatt
    /// </summary>
    /// <param name="val">quantity measured in MilliWatt</param>
    /// <returns>quantity measured in ZeptoWatt</returns>
	public static Quantity<double, ZeptoWatt> ToZeptoWatt<T>(this Quantity<T, MilliWatt> val) where T:IConvertible {
        return new Quantity<double, ZeptoWatt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliWatt to YoctoWatt
    /// </summary>
    /// <param name="val">quantity measured in MilliWatt</param>
    /// <returns>quantity measured in YoctoWatt</returns>
	public static Quantity<double, YoctoWatt> ToYoctoWatt<T>(this Quantity<T, MilliWatt> val) where T:IConvertible {
        return new Quantity<double, YoctoWatt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MicroWatt to YottaWatt
    /// </summary>
    /// <param name="val">quantity measured in MicroWatt</param>
    /// <returns>quantity measured in YottaWatt</returns>
	public static Quantity<double, YottaWatt> ToYottaWatt<T>(this Quantity<T, MicroWatt> val) where T:IConvertible {
        return new Quantity<double, YottaWatt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroWatt to ZettaWatt
    /// </summary>
    /// <param name="val">quantity measured in MicroWatt</param>
    /// <returns>quantity measured in ZettaWatt</returns>
	public static Quantity<double, ZettaWatt> ToZettaWatt<T>(this Quantity<T, MicroWatt> val) where T:IConvertible {
        return new Quantity<double, ZettaWatt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroWatt to ExaWatt
    /// </summary>
    /// <param name="val">quantity measured in MicroWatt</param>
    /// <returns>quantity measured in ExaWatt</returns>
	public static Quantity<double, ExaWatt> ToExaWatt<T>(this Quantity<T, MicroWatt> val) where T:IConvertible {
        return new Quantity<double, ExaWatt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroWatt to PetaWatt
    /// </summary>
    /// <param name="val">quantity measured in MicroWatt</param>
    /// <returns>quantity measured in PetaWatt</returns>
	public static Quantity<double, PetaWatt> ToPetaWatt<T>(this Quantity<T, MicroWatt> val) where T:IConvertible {
        return new Quantity<double, PetaWatt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroWatt to TeraWatt
    /// </summary>
    /// <param name="val">quantity measured in MicroWatt</param>
    /// <returns>quantity measured in TeraWatt</returns>
	public static Quantity<double, TeraWatt> ToTeraWatt<T>(this Quantity<T, MicroWatt> val) where T:IConvertible {
        return new Quantity<double, TeraWatt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroWatt to GigaWatt
    /// </summary>
    /// <param name="val">quantity measured in MicroWatt</param>
    /// <returns>quantity measured in GigaWatt</returns>
	public static Quantity<double, GigaWatt> ToGigaWatt<T>(this Quantity<T, MicroWatt> val) where T:IConvertible {
        return new Quantity<double, GigaWatt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroWatt to MegaWatt
    /// </summary>
    /// <param name="val">quantity measured in MicroWatt</param>
    /// <returns>quantity measured in MegaWatt</returns>
	public static Quantity<double, MegaWatt> ToMegaWatt<T>(this Quantity<T, MicroWatt> val) where T:IConvertible {
        return new Quantity<double, MegaWatt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroWatt to KiloWatt
    /// </summary>
    /// <param name="val">quantity measured in MicroWatt</param>
    /// <returns>quantity measured in KiloWatt</returns>
	public static Quantity<double, KiloWatt> ToKiloWatt<T>(this Quantity<T, MicroWatt> val) where T:IConvertible {
        return new Quantity<double, KiloWatt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroWatt to HectoWatt
    /// </summary>
    /// <param name="val">quantity measured in MicroWatt</param>
    /// <returns>quantity measured in HectoWatt</returns>
	public static Quantity<double, HectoWatt> ToHectoWatt<T>(this Quantity<T, MicroWatt> val) where T:IConvertible {
        return new Quantity<double, HectoWatt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroWatt to DekaWatt
    /// </summary>
    /// <param name="val">quantity measured in MicroWatt</param>
    /// <returns>quantity measured in DekaWatt</returns>
	public static Quantity<double, DekaWatt> ToDekaWatt<T>(this Quantity<T, MicroWatt> val) where T:IConvertible {
        return new Quantity<double, DekaWatt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroWatt to DeciWatt
    /// </summary>
    /// <param name="val">quantity measured in MicroWatt</param>
    /// <returns>quantity measured in DeciWatt</returns>
	public static Quantity<double, DeciWatt> ToDeciWatt<T>(this Quantity<T, MicroWatt> val) where T:IConvertible {
        return new Quantity<double, DeciWatt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroWatt to CentiWatt
    /// </summary>
    /// <param name="val">quantity measured in MicroWatt</param>
    /// <returns>quantity measured in CentiWatt</returns>
	public static Quantity<double, CentiWatt> ToCentiWatt<T>(this Quantity<T, MicroWatt> val) where T:IConvertible {
        return new Quantity<double, CentiWatt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroWatt to MilliWatt
    /// </summary>
    /// <param name="val">quantity measured in MicroWatt</param>
    /// <returns>quantity measured in MilliWatt</returns>
	public static Quantity<double, MilliWatt> ToMilliWatt<T>(this Quantity<T, MicroWatt> val) where T:IConvertible {
        return new Quantity<double, MilliWatt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroWatt to NanoWatt
    /// </summary>
    /// <param name="val">quantity measured in MicroWatt</param>
    /// <returns>quantity measured in NanoWatt</returns>
	public static Quantity<double, NanoWatt> ToNanoWatt<T>(this Quantity<T, MicroWatt> val) where T:IConvertible {
        return new Quantity<double, NanoWatt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroWatt to PicoWatt
    /// </summary>
    /// <param name="val">quantity measured in MicroWatt</param>
    /// <returns>quantity measured in PicoWatt</returns>
	public static Quantity<double, PicoWatt> ToPicoWatt<T>(this Quantity<T, MicroWatt> val) where T:IConvertible {
        return new Quantity<double, PicoWatt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroWatt to FemtoWatt
    /// </summary>
    /// <param name="val">quantity measured in MicroWatt</param>
    /// <returns>quantity measured in FemtoWatt</returns>
	public static Quantity<double, FemtoWatt> ToFemtoWatt<T>(this Quantity<T, MicroWatt> val) where T:IConvertible {
        return new Quantity<double, FemtoWatt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroWatt to AttoWatt
    /// </summary>
    /// <param name="val">quantity measured in MicroWatt</param>
    /// <returns>quantity measured in AttoWatt</returns>
	public static Quantity<double, AttoWatt> ToAttoWatt<T>(this Quantity<T, MicroWatt> val) where T:IConvertible {
        return new Quantity<double, AttoWatt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroWatt to ZeptoWatt
    /// </summary>
    /// <param name="val">quantity measured in MicroWatt</param>
    /// <returns>quantity measured in ZeptoWatt</returns>
	public static Quantity<double, ZeptoWatt> ToZeptoWatt<T>(this Quantity<T, MicroWatt> val) where T:IConvertible {
        return new Quantity<double, ZeptoWatt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroWatt to YoctoWatt
    /// </summary>
    /// <param name="val">quantity measured in MicroWatt</param>
    /// <returns>quantity measured in YoctoWatt</returns>
	public static Quantity<double, YoctoWatt> ToYoctoWatt<T>(this Quantity<T, MicroWatt> val) where T:IConvertible {
        return new Quantity<double, YoctoWatt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert NanoWatt to YottaWatt
    /// </summary>
    /// <param name="val">quantity measured in NanoWatt</param>
    /// <returns>quantity measured in YottaWatt</returns>
	public static Quantity<double, YottaWatt> ToYottaWatt<T>(this Quantity<T, NanoWatt> val) where T:IConvertible {
        return new Quantity<double, YottaWatt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoWatt to ZettaWatt
    /// </summary>
    /// <param name="val">quantity measured in NanoWatt</param>
    /// <returns>quantity measured in ZettaWatt</returns>
	public static Quantity<double, ZettaWatt> ToZettaWatt<T>(this Quantity<T, NanoWatt> val) where T:IConvertible {
        return new Quantity<double, ZettaWatt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoWatt to ExaWatt
    /// </summary>
    /// <param name="val">quantity measured in NanoWatt</param>
    /// <returns>quantity measured in ExaWatt</returns>
	public static Quantity<double, ExaWatt> ToExaWatt<T>(this Quantity<T, NanoWatt> val) where T:IConvertible {
        return new Quantity<double, ExaWatt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoWatt to PetaWatt
    /// </summary>
    /// <param name="val">quantity measured in NanoWatt</param>
    /// <returns>quantity measured in PetaWatt</returns>
	public static Quantity<double, PetaWatt> ToPetaWatt<T>(this Quantity<T, NanoWatt> val) where T:IConvertible {
        return new Quantity<double, PetaWatt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoWatt to TeraWatt
    /// </summary>
    /// <param name="val">quantity measured in NanoWatt</param>
    /// <returns>quantity measured in TeraWatt</returns>
	public static Quantity<double, TeraWatt> ToTeraWatt<T>(this Quantity<T, NanoWatt> val) where T:IConvertible {
        return new Quantity<double, TeraWatt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoWatt to GigaWatt
    /// </summary>
    /// <param name="val">quantity measured in NanoWatt</param>
    /// <returns>quantity measured in GigaWatt</returns>
	public static Quantity<double, GigaWatt> ToGigaWatt<T>(this Quantity<T, NanoWatt> val) where T:IConvertible {
        return new Quantity<double, GigaWatt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoWatt to MegaWatt
    /// </summary>
    /// <param name="val">quantity measured in NanoWatt</param>
    /// <returns>quantity measured in MegaWatt</returns>
	public static Quantity<double, MegaWatt> ToMegaWatt<T>(this Quantity<T, NanoWatt> val) where T:IConvertible {
        return new Quantity<double, MegaWatt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoWatt to KiloWatt
    /// </summary>
    /// <param name="val">quantity measured in NanoWatt</param>
    /// <returns>quantity measured in KiloWatt</returns>
	public static Quantity<double, KiloWatt> ToKiloWatt<T>(this Quantity<T, NanoWatt> val) where T:IConvertible {
        return new Quantity<double, KiloWatt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoWatt to HectoWatt
    /// </summary>
    /// <param name="val">quantity measured in NanoWatt</param>
    /// <returns>quantity measured in HectoWatt</returns>
	public static Quantity<double, HectoWatt> ToHectoWatt<T>(this Quantity<T, NanoWatt> val) where T:IConvertible {
        return new Quantity<double, HectoWatt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoWatt to DekaWatt
    /// </summary>
    /// <param name="val">quantity measured in NanoWatt</param>
    /// <returns>quantity measured in DekaWatt</returns>
	public static Quantity<double, DekaWatt> ToDekaWatt<T>(this Quantity<T, NanoWatt> val) where T:IConvertible {
        return new Quantity<double, DekaWatt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoWatt to DeciWatt
    /// </summary>
    /// <param name="val">quantity measured in NanoWatt</param>
    /// <returns>quantity measured in DeciWatt</returns>
	public static Quantity<double, DeciWatt> ToDeciWatt<T>(this Quantity<T, NanoWatt> val) where T:IConvertible {
        return new Quantity<double, DeciWatt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoWatt to CentiWatt
    /// </summary>
    /// <param name="val">quantity measured in NanoWatt</param>
    /// <returns>quantity measured in CentiWatt</returns>
	public static Quantity<double, CentiWatt> ToCentiWatt<T>(this Quantity<T, NanoWatt> val) where T:IConvertible {
        return new Quantity<double, CentiWatt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoWatt to MilliWatt
    /// </summary>
    /// <param name="val">quantity measured in NanoWatt</param>
    /// <returns>quantity measured in MilliWatt</returns>
	public static Quantity<double, MilliWatt> ToMilliWatt<T>(this Quantity<T, NanoWatt> val) where T:IConvertible {
        return new Quantity<double, MilliWatt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoWatt to MicroWatt
    /// </summary>
    /// <param name="val">quantity measured in NanoWatt</param>
    /// <returns>quantity measured in MicroWatt</returns>
	public static Quantity<double, MicroWatt> ToMicroWatt<T>(this Quantity<T, NanoWatt> val) where T:IConvertible {
        return new Quantity<double, MicroWatt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoWatt to PicoWatt
    /// </summary>
    /// <param name="val">quantity measured in NanoWatt</param>
    /// <returns>quantity measured in PicoWatt</returns>
	public static Quantity<double, PicoWatt> ToPicoWatt<T>(this Quantity<T, NanoWatt> val) where T:IConvertible {
        return new Quantity<double, PicoWatt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoWatt to FemtoWatt
    /// </summary>
    /// <param name="val">quantity measured in NanoWatt</param>
    /// <returns>quantity measured in FemtoWatt</returns>
	public static Quantity<double, FemtoWatt> ToFemtoWatt<T>(this Quantity<T, NanoWatt> val) where T:IConvertible {
        return new Quantity<double, FemtoWatt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoWatt to AttoWatt
    /// </summary>
    /// <param name="val">quantity measured in NanoWatt</param>
    /// <returns>quantity measured in AttoWatt</returns>
	public static Quantity<double, AttoWatt> ToAttoWatt<T>(this Quantity<T, NanoWatt> val) where T:IConvertible {
        return new Quantity<double, AttoWatt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoWatt to ZeptoWatt
    /// </summary>
    /// <param name="val">quantity measured in NanoWatt</param>
    /// <returns>quantity measured in ZeptoWatt</returns>
	public static Quantity<double, ZeptoWatt> ToZeptoWatt<T>(this Quantity<T, NanoWatt> val) where T:IConvertible {
        return new Quantity<double, ZeptoWatt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoWatt to YoctoWatt
    /// </summary>
    /// <param name="val">quantity measured in NanoWatt</param>
    /// <returns>quantity measured in YoctoWatt</returns>
	public static Quantity<double, YoctoWatt> ToYoctoWatt<T>(this Quantity<T, NanoWatt> val) where T:IConvertible {
        return new Quantity<double, YoctoWatt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert PicoWatt to YottaWatt
    /// </summary>
    /// <param name="val">quantity measured in PicoWatt</param>
    /// <returns>quantity measured in YottaWatt</returns>
	public static Quantity<double, YottaWatt> ToYottaWatt<T>(this Quantity<T, PicoWatt> val) where T:IConvertible {
        return new Quantity<double, YottaWatt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoWatt to ZettaWatt
    /// </summary>
    /// <param name="val">quantity measured in PicoWatt</param>
    /// <returns>quantity measured in ZettaWatt</returns>
	public static Quantity<double, ZettaWatt> ToZettaWatt<T>(this Quantity<T, PicoWatt> val) where T:IConvertible {
        return new Quantity<double, ZettaWatt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoWatt to ExaWatt
    /// </summary>
    /// <param name="val">quantity measured in PicoWatt</param>
    /// <returns>quantity measured in ExaWatt</returns>
	public static Quantity<double, ExaWatt> ToExaWatt<T>(this Quantity<T, PicoWatt> val) where T:IConvertible {
        return new Quantity<double, ExaWatt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoWatt to PetaWatt
    /// </summary>
    /// <param name="val">quantity measured in PicoWatt</param>
    /// <returns>quantity measured in PetaWatt</returns>
	public static Quantity<double, PetaWatt> ToPetaWatt<T>(this Quantity<T, PicoWatt> val) where T:IConvertible {
        return new Quantity<double, PetaWatt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoWatt to TeraWatt
    /// </summary>
    /// <param name="val">quantity measured in PicoWatt</param>
    /// <returns>quantity measured in TeraWatt</returns>
	public static Quantity<double, TeraWatt> ToTeraWatt<T>(this Quantity<T, PicoWatt> val) where T:IConvertible {
        return new Quantity<double, TeraWatt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoWatt to GigaWatt
    /// </summary>
    /// <param name="val">quantity measured in PicoWatt</param>
    /// <returns>quantity measured in GigaWatt</returns>
	public static Quantity<double, GigaWatt> ToGigaWatt<T>(this Quantity<T, PicoWatt> val) where T:IConvertible {
        return new Quantity<double, GigaWatt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoWatt to MegaWatt
    /// </summary>
    /// <param name="val">quantity measured in PicoWatt</param>
    /// <returns>quantity measured in MegaWatt</returns>
	public static Quantity<double, MegaWatt> ToMegaWatt<T>(this Quantity<T, PicoWatt> val) where T:IConvertible {
        return new Quantity<double, MegaWatt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoWatt to KiloWatt
    /// </summary>
    /// <param name="val">quantity measured in PicoWatt</param>
    /// <returns>quantity measured in KiloWatt</returns>
	public static Quantity<double, KiloWatt> ToKiloWatt<T>(this Quantity<T, PicoWatt> val) where T:IConvertible {
        return new Quantity<double, KiloWatt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoWatt to HectoWatt
    /// </summary>
    /// <param name="val">quantity measured in PicoWatt</param>
    /// <returns>quantity measured in HectoWatt</returns>
	public static Quantity<double, HectoWatt> ToHectoWatt<T>(this Quantity<T, PicoWatt> val) where T:IConvertible {
        return new Quantity<double, HectoWatt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoWatt to DekaWatt
    /// </summary>
    /// <param name="val">quantity measured in PicoWatt</param>
    /// <returns>quantity measured in DekaWatt</returns>
	public static Quantity<double, DekaWatt> ToDekaWatt<T>(this Quantity<T, PicoWatt> val) where T:IConvertible {
        return new Quantity<double, DekaWatt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoWatt to DeciWatt
    /// </summary>
    /// <param name="val">quantity measured in PicoWatt</param>
    /// <returns>quantity measured in DeciWatt</returns>
	public static Quantity<double, DeciWatt> ToDeciWatt<T>(this Quantity<T, PicoWatt> val) where T:IConvertible {
        return new Quantity<double, DeciWatt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoWatt to CentiWatt
    /// </summary>
    /// <param name="val">quantity measured in PicoWatt</param>
    /// <returns>quantity measured in CentiWatt</returns>
	public static Quantity<double, CentiWatt> ToCentiWatt<T>(this Quantity<T, PicoWatt> val) where T:IConvertible {
        return new Quantity<double, CentiWatt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoWatt to MilliWatt
    /// </summary>
    /// <param name="val">quantity measured in PicoWatt</param>
    /// <returns>quantity measured in MilliWatt</returns>
	public static Quantity<double, MilliWatt> ToMilliWatt<T>(this Quantity<T, PicoWatt> val) where T:IConvertible {
        return new Quantity<double, MilliWatt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoWatt to MicroWatt
    /// </summary>
    /// <param name="val">quantity measured in PicoWatt</param>
    /// <returns>quantity measured in MicroWatt</returns>
	public static Quantity<double, MicroWatt> ToMicroWatt<T>(this Quantity<T, PicoWatt> val) where T:IConvertible {
        return new Quantity<double, MicroWatt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoWatt to NanoWatt
    /// </summary>
    /// <param name="val">quantity measured in PicoWatt</param>
    /// <returns>quantity measured in NanoWatt</returns>
	public static Quantity<double, NanoWatt> ToNanoWatt<T>(this Quantity<T, PicoWatt> val) where T:IConvertible {
        return new Quantity<double, NanoWatt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoWatt to FemtoWatt
    /// </summary>
    /// <param name="val">quantity measured in PicoWatt</param>
    /// <returns>quantity measured in FemtoWatt</returns>
	public static Quantity<double, FemtoWatt> ToFemtoWatt<T>(this Quantity<T, PicoWatt> val) where T:IConvertible {
        return new Quantity<double, FemtoWatt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoWatt to AttoWatt
    /// </summary>
    /// <param name="val">quantity measured in PicoWatt</param>
    /// <returns>quantity measured in AttoWatt</returns>
	public static Quantity<double, AttoWatt> ToAttoWatt<T>(this Quantity<T, PicoWatt> val) where T:IConvertible {
        return new Quantity<double, AttoWatt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoWatt to ZeptoWatt
    /// </summary>
    /// <param name="val">quantity measured in PicoWatt</param>
    /// <returns>quantity measured in ZeptoWatt</returns>
	public static Quantity<double, ZeptoWatt> ToZeptoWatt<T>(this Quantity<T, PicoWatt> val) where T:IConvertible {
        return new Quantity<double, ZeptoWatt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoWatt to YoctoWatt
    /// </summary>
    /// <param name="val">quantity measured in PicoWatt</param>
    /// <returns>quantity measured in YoctoWatt</returns>
	public static Quantity<double, YoctoWatt> ToYoctoWatt<T>(this Quantity<T, PicoWatt> val) where T:IConvertible {
        return new Quantity<double, YoctoWatt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert FemtoWatt to YottaWatt
    /// </summary>
    /// <param name="val">quantity measured in FemtoWatt</param>
    /// <returns>quantity measured in YottaWatt</returns>
	public static Quantity<double, YottaWatt> ToYottaWatt<T>(this Quantity<T, FemtoWatt> val) where T:IConvertible {
        return new Quantity<double, YottaWatt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoWatt to ZettaWatt
    /// </summary>
    /// <param name="val">quantity measured in FemtoWatt</param>
    /// <returns>quantity measured in ZettaWatt</returns>
	public static Quantity<double, ZettaWatt> ToZettaWatt<T>(this Quantity<T, FemtoWatt> val) where T:IConvertible {
        return new Quantity<double, ZettaWatt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoWatt to ExaWatt
    /// </summary>
    /// <param name="val">quantity measured in FemtoWatt</param>
    /// <returns>quantity measured in ExaWatt</returns>
	public static Quantity<double, ExaWatt> ToExaWatt<T>(this Quantity<T, FemtoWatt> val) where T:IConvertible {
        return new Quantity<double, ExaWatt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoWatt to PetaWatt
    /// </summary>
    /// <param name="val">quantity measured in FemtoWatt</param>
    /// <returns>quantity measured in PetaWatt</returns>
	public static Quantity<double, PetaWatt> ToPetaWatt<T>(this Quantity<T, FemtoWatt> val) where T:IConvertible {
        return new Quantity<double, PetaWatt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoWatt to TeraWatt
    /// </summary>
    /// <param name="val">quantity measured in FemtoWatt</param>
    /// <returns>quantity measured in TeraWatt</returns>
	public static Quantity<double, TeraWatt> ToTeraWatt<T>(this Quantity<T, FemtoWatt> val) where T:IConvertible {
        return new Quantity<double, TeraWatt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoWatt to GigaWatt
    /// </summary>
    /// <param name="val">quantity measured in FemtoWatt</param>
    /// <returns>quantity measured in GigaWatt</returns>
	public static Quantity<double, GigaWatt> ToGigaWatt<T>(this Quantity<T, FemtoWatt> val) where T:IConvertible {
        return new Quantity<double, GigaWatt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoWatt to MegaWatt
    /// </summary>
    /// <param name="val">quantity measured in FemtoWatt</param>
    /// <returns>quantity measured in MegaWatt</returns>
	public static Quantity<double, MegaWatt> ToMegaWatt<T>(this Quantity<T, FemtoWatt> val) where T:IConvertible {
        return new Quantity<double, MegaWatt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoWatt to KiloWatt
    /// </summary>
    /// <param name="val">quantity measured in FemtoWatt</param>
    /// <returns>quantity measured in KiloWatt</returns>
	public static Quantity<double, KiloWatt> ToKiloWatt<T>(this Quantity<T, FemtoWatt> val) where T:IConvertible {
        return new Quantity<double, KiloWatt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoWatt to HectoWatt
    /// </summary>
    /// <param name="val">quantity measured in FemtoWatt</param>
    /// <returns>quantity measured in HectoWatt</returns>
	public static Quantity<double, HectoWatt> ToHectoWatt<T>(this Quantity<T, FemtoWatt> val) where T:IConvertible {
        return new Quantity<double, HectoWatt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoWatt to DekaWatt
    /// </summary>
    /// <param name="val">quantity measured in FemtoWatt</param>
    /// <returns>quantity measured in DekaWatt</returns>
	public static Quantity<double, DekaWatt> ToDekaWatt<T>(this Quantity<T, FemtoWatt> val) where T:IConvertible {
        return new Quantity<double, DekaWatt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoWatt to DeciWatt
    /// </summary>
    /// <param name="val">quantity measured in FemtoWatt</param>
    /// <returns>quantity measured in DeciWatt</returns>
	public static Quantity<double, DeciWatt> ToDeciWatt<T>(this Quantity<T, FemtoWatt> val) where T:IConvertible {
        return new Quantity<double, DeciWatt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoWatt to CentiWatt
    /// </summary>
    /// <param name="val">quantity measured in FemtoWatt</param>
    /// <returns>quantity measured in CentiWatt</returns>
	public static Quantity<double, CentiWatt> ToCentiWatt<T>(this Quantity<T, FemtoWatt> val) where T:IConvertible {
        return new Quantity<double, CentiWatt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoWatt to MilliWatt
    /// </summary>
    /// <param name="val">quantity measured in FemtoWatt</param>
    /// <returns>quantity measured in MilliWatt</returns>
	public static Quantity<double, MilliWatt> ToMilliWatt<T>(this Quantity<T, FemtoWatt> val) where T:IConvertible {
        return new Quantity<double, MilliWatt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoWatt to MicroWatt
    /// </summary>
    /// <param name="val">quantity measured in FemtoWatt</param>
    /// <returns>quantity measured in MicroWatt</returns>
	public static Quantity<double, MicroWatt> ToMicroWatt<T>(this Quantity<T, FemtoWatt> val) where T:IConvertible {
        return new Quantity<double, MicroWatt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoWatt to NanoWatt
    /// </summary>
    /// <param name="val">quantity measured in FemtoWatt</param>
    /// <returns>quantity measured in NanoWatt</returns>
	public static Quantity<double, NanoWatt> ToNanoWatt<T>(this Quantity<T, FemtoWatt> val) where T:IConvertible {
        return new Quantity<double, NanoWatt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoWatt to PicoWatt
    /// </summary>
    /// <param name="val">quantity measured in FemtoWatt</param>
    /// <returns>quantity measured in PicoWatt</returns>
	public static Quantity<double, PicoWatt> ToPicoWatt<T>(this Quantity<T, FemtoWatt> val) where T:IConvertible {
        return new Quantity<double, PicoWatt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoWatt to AttoWatt
    /// </summary>
    /// <param name="val">quantity measured in FemtoWatt</param>
    /// <returns>quantity measured in AttoWatt</returns>
	public static Quantity<double, AttoWatt> ToAttoWatt<T>(this Quantity<T, FemtoWatt> val) where T:IConvertible {
        return new Quantity<double, AttoWatt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoWatt to ZeptoWatt
    /// </summary>
    /// <param name="val">quantity measured in FemtoWatt</param>
    /// <returns>quantity measured in ZeptoWatt</returns>
	public static Quantity<double, ZeptoWatt> ToZeptoWatt<T>(this Quantity<T, FemtoWatt> val) where T:IConvertible {
        return new Quantity<double, ZeptoWatt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoWatt to YoctoWatt
    /// </summary>
    /// <param name="val">quantity measured in FemtoWatt</param>
    /// <returns>quantity measured in YoctoWatt</returns>
	public static Quantity<double, YoctoWatt> ToYoctoWatt<T>(this Quantity<T, FemtoWatt> val) where T:IConvertible {
        return new Quantity<double, YoctoWatt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert AttoWatt to YottaWatt
    /// </summary>
    /// <param name="val">quantity measured in AttoWatt</param>
    /// <returns>quantity measured in YottaWatt</returns>
	public static Quantity<double, YottaWatt> ToYottaWatt<T>(this Quantity<T, AttoWatt> val) where T:IConvertible {
        return new Quantity<double, YottaWatt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoWatt to ZettaWatt
    /// </summary>
    /// <param name="val">quantity measured in AttoWatt</param>
    /// <returns>quantity measured in ZettaWatt</returns>
	public static Quantity<double, ZettaWatt> ToZettaWatt<T>(this Quantity<T, AttoWatt> val) where T:IConvertible {
        return new Quantity<double, ZettaWatt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoWatt to ExaWatt
    /// </summary>
    /// <param name="val">quantity measured in AttoWatt</param>
    /// <returns>quantity measured in ExaWatt</returns>
	public static Quantity<double, ExaWatt> ToExaWatt<T>(this Quantity<T, AttoWatt> val) where T:IConvertible {
        return new Quantity<double, ExaWatt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoWatt to PetaWatt
    /// </summary>
    /// <param name="val">quantity measured in AttoWatt</param>
    /// <returns>quantity measured in PetaWatt</returns>
	public static Quantity<double, PetaWatt> ToPetaWatt<T>(this Quantity<T, AttoWatt> val) where T:IConvertible {
        return new Quantity<double, PetaWatt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoWatt to TeraWatt
    /// </summary>
    /// <param name="val">quantity measured in AttoWatt</param>
    /// <returns>quantity measured in TeraWatt</returns>
	public static Quantity<double, TeraWatt> ToTeraWatt<T>(this Quantity<T, AttoWatt> val) where T:IConvertible {
        return new Quantity<double, TeraWatt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoWatt to GigaWatt
    /// </summary>
    /// <param name="val">quantity measured in AttoWatt</param>
    /// <returns>quantity measured in GigaWatt</returns>
	public static Quantity<double, GigaWatt> ToGigaWatt<T>(this Quantity<T, AttoWatt> val) where T:IConvertible {
        return new Quantity<double, GigaWatt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoWatt to MegaWatt
    /// </summary>
    /// <param name="val">quantity measured in AttoWatt</param>
    /// <returns>quantity measured in MegaWatt</returns>
	public static Quantity<double, MegaWatt> ToMegaWatt<T>(this Quantity<T, AttoWatt> val) where T:IConvertible {
        return new Quantity<double, MegaWatt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoWatt to KiloWatt
    /// </summary>
    /// <param name="val">quantity measured in AttoWatt</param>
    /// <returns>quantity measured in KiloWatt</returns>
	public static Quantity<double, KiloWatt> ToKiloWatt<T>(this Quantity<T, AttoWatt> val) where T:IConvertible {
        return new Quantity<double, KiloWatt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoWatt to HectoWatt
    /// </summary>
    /// <param name="val">quantity measured in AttoWatt</param>
    /// <returns>quantity measured in HectoWatt</returns>
	public static Quantity<double, HectoWatt> ToHectoWatt<T>(this Quantity<T, AttoWatt> val) where T:IConvertible {
        return new Quantity<double, HectoWatt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoWatt to DekaWatt
    /// </summary>
    /// <param name="val">quantity measured in AttoWatt</param>
    /// <returns>quantity measured in DekaWatt</returns>
	public static Quantity<double, DekaWatt> ToDekaWatt<T>(this Quantity<T, AttoWatt> val) where T:IConvertible {
        return new Quantity<double, DekaWatt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoWatt to DeciWatt
    /// </summary>
    /// <param name="val">quantity measured in AttoWatt</param>
    /// <returns>quantity measured in DeciWatt</returns>
	public static Quantity<double, DeciWatt> ToDeciWatt<T>(this Quantity<T, AttoWatt> val) where T:IConvertible {
        return new Quantity<double, DeciWatt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoWatt to CentiWatt
    /// </summary>
    /// <param name="val">quantity measured in AttoWatt</param>
    /// <returns>quantity measured in CentiWatt</returns>
	public static Quantity<double, CentiWatt> ToCentiWatt<T>(this Quantity<T, AttoWatt> val) where T:IConvertible {
        return new Quantity<double, CentiWatt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoWatt to MilliWatt
    /// </summary>
    /// <param name="val">quantity measured in AttoWatt</param>
    /// <returns>quantity measured in MilliWatt</returns>
	public static Quantity<double, MilliWatt> ToMilliWatt<T>(this Quantity<T, AttoWatt> val) where T:IConvertible {
        return new Quantity<double, MilliWatt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoWatt to MicroWatt
    /// </summary>
    /// <param name="val">quantity measured in AttoWatt</param>
    /// <returns>quantity measured in MicroWatt</returns>
	public static Quantity<double, MicroWatt> ToMicroWatt<T>(this Quantity<T, AttoWatt> val) where T:IConvertible {
        return new Quantity<double, MicroWatt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoWatt to NanoWatt
    /// </summary>
    /// <param name="val">quantity measured in AttoWatt</param>
    /// <returns>quantity measured in NanoWatt</returns>
	public static Quantity<double, NanoWatt> ToNanoWatt<T>(this Quantity<T, AttoWatt> val) where T:IConvertible {
        return new Quantity<double, NanoWatt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoWatt to PicoWatt
    /// </summary>
    /// <param name="val">quantity measured in AttoWatt</param>
    /// <returns>quantity measured in PicoWatt</returns>
	public static Quantity<double, PicoWatt> ToPicoWatt<T>(this Quantity<T, AttoWatt> val) where T:IConvertible {
        return new Quantity<double, PicoWatt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoWatt to FemtoWatt
    /// </summary>
    /// <param name="val">quantity measured in AttoWatt</param>
    /// <returns>quantity measured in FemtoWatt</returns>
	public static Quantity<double, FemtoWatt> ToFemtoWatt<T>(this Quantity<T, AttoWatt> val) where T:IConvertible {
        return new Quantity<double, FemtoWatt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoWatt to ZeptoWatt
    /// </summary>
    /// <param name="val">quantity measured in AttoWatt</param>
    /// <returns>quantity measured in ZeptoWatt</returns>
	public static Quantity<double, ZeptoWatt> ToZeptoWatt<T>(this Quantity<T, AttoWatt> val) where T:IConvertible {
        return new Quantity<double, ZeptoWatt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoWatt to YoctoWatt
    /// </summary>
    /// <param name="val">quantity measured in AttoWatt</param>
    /// <returns>quantity measured in YoctoWatt</returns>
	public static Quantity<double, YoctoWatt> ToYoctoWatt<T>(this Quantity<T, AttoWatt> val) where T:IConvertible {
        return new Quantity<double, YoctoWatt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoWatt to YottaWatt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoWatt</param>
    /// <returns>quantity measured in YottaWatt</returns>
	public static Quantity<double, YottaWatt> ToYottaWatt<T>(this Quantity<T, ZeptoWatt> val) where T:IConvertible {
        return new Quantity<double, YottaWatt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoWatt to ZettaWatt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoWatt</param>
    /// <returns>quantity measured in ZettaWatt</returns>
	public static Quantity<double, ZettaWatt> ToZettaWatt<T>(this Quantity<T, ZeptoWatt> val) where T:IConvertible {
        return new Quantity<double, ZettaWatt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoWatt to ExaWatt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoWatt</param>
    /// <returns>quantity measured in ExaWatt</returns>
	public static Quantity<double, ExaWatt> ToExaWatt<T>(this Quantity<T, ZeptoWatt> val) where T:IConvertible {
        return new Quantity<double, ExaWatt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoWatt to PetaWatt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoWatt</param>
    /// <returns>quantity measured in PetaWatt</returns>
	public static Quantity<double, PetaWatt> ToPetaWatt<T>(this Quantity<T, ZeptoWatt> val) where T:IConvertible {
        return new Quantity<double, PetaWatt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoWatt to TeraWatt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoWatt</param>
    /// <returns>quantity measured in TeraWatt</returns>
	public static Quantity<double, TeraWatt> ToTeraWatt<T>(this Quantity<T, ZeptoWatt> val) where T:IConvertible {
        return new Quantity<double, TeraWatt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoWatt to GigaWatt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoWatt</param>
    /// <returns>quantity measured in GigaWatt</returns>
	public static Quantity<double, GigaWatt> ToGigaWatt<T>(this Quantity<T, ZeptoWatt> val) where T:IConvertible {
        return new Quantity<double, GigaWatt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoWatt to MegaWatt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoWatt</param>
    /// <returns>quantity measured in MegaWatt</returns>
	public static Quantity<double, MegaWatt> ToMegaWatt<T>(this Quantity<T, ZeptoWatt> val) where T:IConvertible {
        return new Quantity<double, MegaWatt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoWatt to KiloWatt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoWatt</param>
    /// <returns>quantity measured in KiloWatt</returns>
	public static Quantity<double, KiloWatt> ToKiloWatt<T>(this Quantity<T, ZeptoWatt> val) where T:IConvertible {
        return new Quantity<double, KiloWatt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoWatt to HectoWatt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoWatt</param>
    /// <returns>quantity measured in HectoWatt</returns>
	public static Quantity<double, HectoWatt> ToHectoWatt<T>(this Quantity<T, ZeptoWatt> val) where T:IConvertible {
        return new Quantity<double, HectoWatt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoWatt to DekaWatt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoWatt</param>
    /// <returns>quantity measured in DekaWatt</returns>
	public static Quantity<double, DekaWatt> ToDekaWatt<T>(this Quantity<T, ZeptoWatt> val) where T:IConvertible {
        return new Quantity<double, DekaWatt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoWatt to DeciWatt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoWatt</param>
    /// <returns>quantity measured in DeciWatt</returns>
	public static Quantity<double, DeciWatt> ToDeciWatt<T>(this Quantity<T, ZeptoWatt> val) where T:IConvertible {
        return new Quantity<double, DeciWatt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoWatt to CentiWatt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoWatt</param>
    /// <returns>quantity measured in CentiWatt</returns>
	public static Quantity<double, CentiWatt> ToCentiWatt<T>(this Quantity<T, ZeptoWatt> val) where T:IConvertible {
        return new Quantity<double, CentiWatt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoWatt to MilliWatt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoWatt</param>
    /// <returns>quantity measured in MilliWatt</returns>
	public static Quantity<double, MilliWatt> ToMilliWatt<T>(this Quantity<T, ZeptoWatt> val) where T:IConvertible {
        return new Quantity<double, MilliWatt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoWatt to MicroWatt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoWatt</param>
    /// <returns>quantity measured in MicroWatt</returns>
	public static Quantity<double, MicroWatt> ToMicroWatt<T>(this Quantity<T, ZeptoWatt> val) where T:IConvertible {
        return new Quantity<double, MicroWatt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoWatt to NanoWatt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoWatt</param>
    /// <returns>quantity measured in NanoWatt</returns>
	public static Quantity<double, NanoWatt> ToNanoWatt<T>(this Quantity<T, ZeptoWatt> val) where T:IConvertible {
        return new Quantity<double, NanoWatt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoWatt to PicoWatt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoWatt</param>
    /// <returns>quantity measured in PicoWatt</returns>
	public static Quantity<double, PicoWatt> ToPicoWatt<T>(this Quantity<T, ZeptoWatt> val) where T:IConvertible {
        return new Quantity<double, PicoWatt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoWatt to FemtoWatt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoWatt</param>
    /// <returns>quantity measured in FemtoWatt</returns>
	public static Quantity<double, FemtoWatt> ToFemtoWatt<T>(this Quantity<T, ZeptoWatt> val) where T:IConvertible {
        return new Quantity<double, FemtoWatt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoWatt to AttoWatt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoWatt</param>
    /// <returns>quantity measured in AttoWatt</returns>
	public static Quantity<double, AttoWatt> ToAttoWatt<T>(this Quantity<T, ZeptoWatt> val) where T:IConvertible {
        return new Quantity<double, AttoWatt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoWatt to YoctoWatt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoWatt</param>
    /// <returns>quantity measured in YoctoWatt</returns>
	public static Quantity<double, YoctoWatt> ToYoctoWatt<T>(this Quantity<T, ZeptoWatt> val) where T:IConvertible {
        return new Quantity<double, YoctoWatt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert YoctoWatt to YottaWatt
    /// </summary>
    /// <param name="val">quantity measured in YoctoWatt</param>
    /// <returns>quantity measured in YottaWatt</returns>
	public static Quantity<double, YottaWatt> ToYottaWatt<T>(this Quantity<T, YoctoWatt> val) where T:IConvertible {
        return new Quantity<double, YottaWatt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoWatt to ZettaWatt
    /// </summary>
    /// <param name="val">quantity measured in YoctoWatt</param>
    /// <returns>quantity measured in ZettaWatt</returns>
	public static Quantity<double, ZettaWatt> ToZettaWatt<T>(this Quantity<T, YoctoWatt> val) where T:IConvertible {
        return new Quantity<double, ZettaWatt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoWatt to ExaWatt
    /// </summary>
    /// <param name="val">quantity measured in YoctoWatt</param>
    /// <returns>quantity measured in ExaWatt</returns>
	public static Quantity<double, ExaWatt> ToExaWatt<T>(this Quantity<T, YoctoWatt> val) where T:IConvertible {
        return new Quantity<double, ExaWatt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoWatt to PetaWatt
    /// </summary>
    /// <param name="val">quantity measured in YoctoWatt</param>
    /// <returns>quantity measured in PetaWatt</returns>
	public static Quantity<double, PetaWatt> ToPetaWatt<T>(this Quantity<T, YoctoWatt> val) where T:IConvertible {
        return new Quantity<double, PetaWatt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoWatt to TeraWatt
    /// </summary>
    /// <param name="val">quantity measured in YoctoWatt</param>
    /// <returns>quantity measured in TeraWatt</returns>
	public static Quantity<double, TeraWatt> ToTeraWatt<T>(this Quantity<T, YoctoWatt> val) where T:IConvertible {
        return new Quantity<double, TeraWatt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoWatt to GigaWatt
    /// </summary>
    /// <param name="val">quantity measured in YoctoWatt</param>
    /// <returns>quantity measured in GigaWatt</returns>
	public static Quantity<double, GigaWatt> ToGigaWatt<T>(this Quantity<T, YoctoWatt> val) where T:IConvertible {
        return new Quantity<double, GigaWatt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoWatt to MegaWatt
    /// </summary>
    /// <param name="val">quantity measured in YoctoWatt</param>
    /// <returns>quantity measured in MegaWatt</returns>
	public static Quantity<double, MegaWatt> ToMegaWatt<T>(this Quantity<T, YoctoWatt> val) where T:IConvertible {
        return new Quantity<double, MegaWatt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoWatt to KiloWatt
    /// </summary>
    /// <param name="val">quantity measured in YoctoWatt</param>
    /// <returns>quantity measured in KiloWatt</returns>
	public static Quantity<double, KiloWatt> ToKiloWatt<T>(this Quantity<T, YoctoWatt> val) where T:IConvertible {
        return new Quantity<double, KiloWatt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoWatt to HectoWatt
    /// </summary>
    /// <param name="val">quantity measured in YoctoWatt</param>
    /// <returns>quantity measured in HectoWatt</returns>
	public static Quantity<double, HectoWatt> ToHectoWatt<T>(this Quantity<T, YoctoWatt> val) where T:IConvertible {
        return new Quantity<double, HectoWatt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoWatt to DekaWatt
    /// </summary>
    /// <param name="val">quantity measured in YoctoWatt</param>
    /// <returns>quantity measured in DekaWatt</returns>
	public static Quantity<double, DekaWatt> ToDekaWatt<T>(this Quantity<T, YoctoWatt> val) where T:IConvertible {
        return new Quantity<double, DekaWatt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoWatt to DeciWatt
    /// </summary>
    /// <param name="val">quantity measured in YoctoWatt</param>
    /// <returns>quantity measured in DeciWatt</returns>
	public static Quantity<double, DeciWatt> ToDeciWatt<T>(this Quantity<T, YoctoWatt> val) where T:IConvertible {
        return new Quantity<double, DeciWatt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoWatt to CentiWatt
    /// </summary>
    /// <param name="val">quantity measured in YoctoWatt</param>
    /// <returns>quantity measured in CentiWatt</returns>
	public static Quantity<double, CentiWatt> ToCentiWatt<T>(this Quantity<T, YoctoWatt> val) where T:IConvertible {
        return new Quantity<double, CentiWatt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoWatt to MilliWatt
    /// </summary>
    /// <param name="val">quantity measured in YoctoWatt</param>
    /// <returns>quantity measured in MilliWatt</returns>
	public static Quantity<double, MilliWatt> ToMilliWatt<T>(this Quantity<T, YoctoWatt> val) where T:IConvertible {
        return new Quantity<double, MilliWatt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoWatt to MicroWatt
    /// </summary>
    /// <param name="val">quantity measured in YoctoWatt</param>
    /// <returns>quantity measured in MicroWatt</returns>
	public static Quantity<double, MicroWatt> ToMicroWatt<T>(this Quantity<T, YoctoWatt> val) where T:IConvertible {
        return new Quantity<double, MicroWatt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoWatt to NanoWatt
    /// </summary>
    /// <param name="val">quantity measured in YoctoWatt</param>
    /// <returns>quantity measured in NanoWatt</returns>
	public static Quantity<double, NanoWatt> ToNanoWatt<T>(this Quantity<T, YoctoWatt> val) where T:IConvertible {
        return new Quantity<double, NanoWatt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoWatt to PicoWatt
    /// </summary>
    /// <param name="val">quantity measured in YoctoWatt</param>
    /// <returns>quantity measured in PicoWatt</returns>
	public static Quantity<double, PicoWatt> ToPicoWatt<T>(this Quantity<T, YoctoWatt> val) where T:IConvertible {
        return new Quantity<double, PicoWatt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoWatt to FemtoWatt
    /// </summary>
    /// <param name="val">quantity measured in YoctoWatt</param>
    /// <returns>quantity measured in FemtoWatt</returns>
	public static Quantity<double, FemtoWatt> ToFemtoWatt<T>(this Quantity<T, YoctoWatt> val) where T:IConvertible {
        return new Quantity<double, FemtoWatt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoWatt to AttoWatt
    /// </summary>
    /// <param name="val">quantity measured in YoctoWatt</param>
    /// <returns>quantity measured in AttoWatt</returns>
	public static Quantity<double, AttoWatt> ToAttoWatt<T>(this Quantity<T, YoctoWatt> val) where T:IConvertible {
        return new Quantity<double, AttoWatt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoWatt to ZeptoWatt
    /// </summary>
    /// <param name="val">quantity measured in YoctoWatt</param>
    /// <returns>quantity measured in ZeptoWatt</returns>
	public static Quantity<double, ZeptoWatt> ToZeptoWatt<T>(this Quantity<T, YoctoWatt> val) where T:IConvertible {
        return new Quantity<double, ZeptoWatt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
}
}