using System;
namespace System.Units.Conductance {
public static class SiemenConductanceConversions {
	/// <summary>
    /// Extension method to convert Siemen to YottaSiemen
    /// </summary>
    /// <param name="val">quantity measured in Siemen</param>
    /// <returns>quantity measured in YottaSiemen</returns>
	public static Quantity<double, YottaSiemen> ToYottaSiemen<T>(this Quantity<T, Siemen> val) where T:IConvertible {
        return new Quantity<double, YottaSiemen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Siemen to ZettaSiemen
    /// </summary>
    /// <param name="val">quantity measured in Siemen</param>
    /// <returns>quantity measured in ZettaSiemen</returns>
	public static Quantity<double, ZettaSiemen> ToZettaSiemen<T>(this Quantity<T, Siemen> val) where T:IConvertible {
        return new Quantity<double, ZettaSiemen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Siemen to ExaSiemen
    /// </summary>
    /// <param name="val">quantity measured in Siemen</param>
    /// <returns>quantity measured in ExaSiemen</returns>
	public static Quantity<double, ExaSiemen> ToExaSiemen<T>(this Quantity<T, Siemen> val) where T:IConvertible {
        return new Quantity<double, ExaSiemen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Siemen to PetaSiemen
    /// </summary>
    /// <param name="val">quantity measured in Siemen</param>
    /// <returns>quantity measured in PetaSiemen</returns>
	public static Quantity<double, PetaSiemen> ToPetaSiemen<T>(this Quantity<T, Siemen> val) where T:IConvertible {
        return new Quantity<double, PetaSiemen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Siemen to TeraSiemen
    /// </summary>
    /// <param name="val">quantity measured in Siemen</param>
    /// <returns>quantity measured in TeraSiemen</returns>
	public static Quantity<double, TeraSiemen> ToTeraSiemen<T>(this Quantity<T, Siemen> val) where T:IConvertible {
        return new Quantity<double, TeraSiemen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Siemen to GigaSiemen
    /// </summary>
    /// <param name="val">quantity measured in Siemen</param>
    /// <returns>quantity measured in GigaSiemen</returns>
	public static Quantity<double, GigaSiemen> ToGigaSiemen<T>(this Quantity<T, Siemen> val) where T:IConvertible {
        return new Quantity<double, GigaSiemen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Siemen to MegaSiemen
    /// </summary>
    /// <param name="val">quantity measured in Siemen</param>
    /// <returns>quantity measured in MegaSiemen</returns>
	public static Quantity<double, MegaSiemen> ToMegaSiemen<T>(this Quantity<T, Siemen> val) where T:IConvertible {
        return new Quantity<double, MegaSiemen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Siemen to KiloSiemen
    /// </summary>
    /// <param name="val">quantity measured in Siemen</param>
    /// <returns>quantity measured in KiloSiemen</returns>
	public static Quantity<double, KiloSiemen> ToKiloSiemen<T>(this Quantity<T, Siemen> val) where T:IConvertible {
        return new Quantity<double, KiloSiemen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Siemen to HectoSiemen
    /// </summary>
    /// <param name="val">quantity measured in Siemen</param>
    /// <returns>quantity measured in HectoSiemen</returns>
	public static Quantity<double, HectoSiemen> ToHectoSiemen<T>(this Quantity<T, Siemen> val) where T:IConvertible {
        return new Quantity<double, HectoSiemen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Siemen to DekaSiemen
    /// </summary>
    /// <param name="val">quantity measured in Siemen</param>
    /// <returns>quantity measured in DekaSiemen</returns>
	public static Quantity<double, DekaSiemen> ToDekaSiemen<T>(this Quantity<T, Siemen> val) where T:IConvertible {
        return new Quantity<double, DekaSiemen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Siemen to DeciSiemen
    /// </summary>
    /// <param name="val">quantity measured in Siemen</param>
    /// <returns>quantity measured in DeciSiemen</returns>
	public static Quantity<double, DeciSiemen> ToDeciSiemen<T>(this Quantity<T, Siemen> val) where T:IConvertible {
        return new Quantity<double, DeciSiemen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Siemen to CentiSiemen
    /// </summary>
    /// <param name="val">quantity measured in Siemen</param>
    /// <returns>quantity measured in CentiSiemen</returns>
	public static Quantity<double, CentiSiemen> ToCentiSiemen<T>(this Quantity<T, Siemen> val) where T:IConvertible {
        return new Quantity<double, CentiSiemen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Siemen to MilliSiemen
    /// </summary>
    /// <param name="val">quantity measured in Siemen</param>
    /// <returns>quantity measured in MilliSiemen</returns>
	public static Quantity<double, MilliSiemen> ToMilliSiemen<T>(this Quantity<T, Siemen> val) where T:IConvertible {
        return new Quantity<double, MilliSiemen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Siemen to MicroSiemen
    /// </summary>
    /// <param name="val">quantity measured in Siemen</param>
    /// <returns>quantity measured in MicroSiemen</returns>
	public static Quantity<double, MicroSiemen> ToMicroSiemen<T>(this Quantity<T, Siemen> val) where T:IConvertible {
        return new Quantity<double, MicroSiemen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Siemen to NanoSiemen
    /// </summary>
    /// <param name="val">quantity measured in Siemen</param>
    /// <returns>quantity measured in NanoSiemen</returns>
	public static Quantity<double, NanoSiemen> ToNanoSiemen<T>(this Quantity<T, Siemen> val) where T:IConvertible {
        return new Quantity<double, NanoSiemen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Siemen to PicoSiemen
    /// </summary>
    /// <param name="val">quantity measured in Siemen</param>
    /// <returns>quantity measured in PicoSiemen</returns>
	public static Quantity<double, PicoSiemen> ToPicoSiemen<T>(this Quantity<T, Siemen> val) where T:IConvertible {
        return new Quantity<double, PicoSiemen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Siemen to FemtoSiemen
    /// </summary>
    /// <param name="val">quantity measured in Siemen</param>
    /// <returns>quantity measured in FemtoSiemen</returns>
	public static Quantity<double, FemtoSiemen> ToFemtoSiemen<T>(this Quantity<T, Siemen> val) where T:IConvertible {
        return new Quantity<double, FemtoSiemen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Siemen to AttoSiemen
    /// </summary>
    /// <param name="val">quantity measured in Siemen</param>
    /// <returns>quantity measured in AttoSiemen</returns>
	public static Quantity<double, AttoSiemen> ToAttoSiemen<T>(this Quantity<T, Siemen> val) where T:IConvertible {
        return new Quantity<double, AttoSiemen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Siemen to ZeptoSiemen
    /// </summary>
    /// <param name="val">quantity measured in Siemen</param>
    /// <returns>quantity measured in ZeptoSiemen</returns>
	public static Quantity<double, ZeptoSiemen> ToZeptoSiemen<T>(this Quantity<T, Siemen> val) where T:IConvertible {
        return new Quantity<double, ZeptoSiemen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Siemen to YoctoSiemen
    /// </summary>
    /// <param name="val">quantity measured in Siemen</param>
    /// <returns>quantity measured in YoctoSiemen</returns>
	public static Quantity<double, YoctoSiemen> ToYoctoSiemen<T>(this Quantity<T, Siemen> val) where T:IConvertible {
        return new Quantity<double, YoctoSiemen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YottaSiemen to ZettaSiemen
    /// </summary>
    /// <param name="val">quantity measured in YottaSiemen</param>
    /// <returns>quantity measured in ZettaSiemen</returns>
	public static Quantity<double, ZettaSiemen> ToZettaSiemen<T>(this Quantity<T, YottaSiemen> val) where T:IConvertible {
        return new Quantity<double, ZettaSiemen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaSiemen to ExaSiemen
    /// </summary>
    /// <param name="val">quantity measured in YottaSiemen</param>
    /// <returns>quantity measured in ExaSiemen</returns>
	public static Quantity<double, ExaSiemen> ToExaSiemen<T>(this Quantity<T, YottaSiemen> val) where T:IConvertible {
        return new Quantity<double, ExaSiemen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaSiemen to PetaSiemen
    /// </summary>
    /// <param name="val">quantity measured in YottaSiemen</param>
    /// <returns>quantity measured in PetaSiemen</returns>
	public static Quantity<double, PetaSiemen> ToPetaSiemen<T>(this Quantity<T, YottaSiemen> val) where T:IConvertible {
        return new Quantity<double, PetaSiemen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaSiemen to TeraSiemen
    /// </summary>
    /// <param name="val">quantity measured in YottaSiemen</param>
    /// <returns>quantity measured in TeraSiemen</returns>
	public static Quantity<double, TeraSiemen> ToTeraSiemen<T>(this Quantity<T, YottaSiemen> val) where T:IConvertible {
        return new Quantity<double, TeraSiemen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaSiemen to GigaSiemen
    /// </summary>
    /// <param name="val">quantity measured in YottaSiemen</param>
    /// <returns>quantity measured in GigaSiemen</returns>
	public static Quantity<double, GigaSiemen> ToGigaSiemen<T>(this Quantity<T, YottaSiemen> val) where T:IConvertible {
        return new Quantity<double, GigaSiemen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaSiemen to MegaSiemen
    /// </summary>
    /// <param name="val">quantity measured in YottaSiemen</param>
    /// <returns>quantity measured in MegaSiemen</returns>
	public static Quantity<double, MegaSiemen> ToMegaSiemen<T>(this Quantity<T, YottaSiemen> val) where T:IConvertible {
        return new Quantity<double, MegaSiemen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaSiemen to KiloSiemen
    /// </summary>
    /// <param name="val">quantity measured in YottaSiemen</param>
    /// <returns>quantity measured in KiloSiemen</returns>
	public static Quantity<double, KiloSiemen> ToKiloSiemen<T>(this Quantity<T, YottaSiemen> val) where T:IConvertible {
        return new Quantity<double, KiloSiemen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaSiemen to HectoSiemen
    /// </summary>
    /// <param name="val">quantity measured in YottaSiemen</param>
    /// <returns>quantity measured in HectoSiemen</returns>
	public static Quantity<double, HectoSiemen> ToHectoSiemen<T>(this Quantity<T, YottaSiemen> val) where T:IConvertible {
        return new Quantity<double, HectoSiemen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaSiemen to DekaSiemen
    /// </summary>
    /// <param name="val">quantity measured in YottaSiemen</param>
    /// <returns>quantity measured in DekaSiemen</returns>
	public static Quantity<double, DekaSiemen> ToDekaSiemen<T>(this Quantity<T, YottaSiemen> val) where T:IConvertible {
        return new Quantity<double, DekaSiemen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaSiemen to DeciSiemen
    /// </summary>
    /// <param name="val">quantity measured in YottaSiemen</param>
    /// <returns>quantity measured in DeciSiemen</returns>
	public static Quantity<double, DeciSiemen> ToDeciSiemen<T>(this Quantity<T, YottaSiemen> val) where T:IConvertible {
        return new Quantity<double, DeciSiemen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaSiemen to CentiSiemen
    /// </summary>
    /// <param name="val">quantity measured in YottaSiemen</param>
    /// <returns>quantity measured in CentiSiemen</returns>
	public static Quantity<double, CentiSiemen> ToCentiSiemen<T>(this Quantity<T, YottaSiemen> val) where T:IConvertible {
        return new Quantity<double, CentiSiemen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaSiemen to MilliSiemen
    /// </summary>
    /// <param name="val">quantity measured in YottaSiemen</param>
    /// <returns>quantity measured in MilliSiemen</returns>
	public static Quantity<double, MilliSiemen> ToMilliSiemen<T>(this Quantity<T, YottaSiemen> val) where T:IConvertible {
        return new Quantity<double, MilliSiemen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaSiemen to MicroSiemen
    /// </summary>
    /// <param name="val">quantity measured in YottaSiemen</param>
    /// <returns>quantity measured in MicroSiemen</returns>
	public static Quantity<double, MicroSiemen> ToMicroSiemen<T>(this Quantity<T, YottaSiemen> val) where T:IConvertible {
        return new Quantity<double, MicroSiemen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaSiemen to NanoSiemen
    /// </summary>
    /// <param name="val">quantity measured in YottaSiemen</param>
    /// <returns>quantity measured in NanoSiemen</returns>
	public static Quantity<double, NanoSiemen> ToNanoSiemen<T>(this Quantity<T, YottaSiemen> val) where T:IConvertible {
        return new Quantity<double, NanoSiemen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaSiemen to PicoSiemen
    /// </summary>
    /// <param name="val">quantity measured in YottaSiemen</param>
    /// <returns>quantity measured in PicoSiemen</returns>
	public static Quantity<double, PicoSiemen> ToPicoSiemen<T>(this Quantity<T, YottaSiemen> val) where T:IConvertible {
        return new Quantity<double, PicoSiemen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaSiemen to FemtoSiemen
    /// </summary>
    /// <param name="val">quantity measured in YottaSiemen</param>
    /// <returns>quantity measured in FemtoSiemen</returns>
	public static Quantity<double, FemtoSiemen> ToFemtoSiemen<T>(this Quantity<T, YottaSiemen> val) where T:IConvertible {
        return new Quantity<double, FemtoSiemen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaSiemen to AttoSiemen
    /// </summary>
    /// <param name="val">quantity measured in YottaSiemen</param>
    /// <returns>quantity measured in AttoSiemen</returns>
	public static Quantity<double, AttoSiemen> ToAttoSiemen<T>(this Quantity<T, YottaSiemen> val) where T:IConvertible {
        return new Quantity<double, AttoSiemen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaSiemen to ZeptoSiemen
    /// </summary>
    /// <param name="val">quantity measured in YottaSiemen</param>
    /// <returns>quantity measured in ZeptoSiemen</returns>
	public static Quantity<double, ZeptoSiemen> ToZeptoSiemen<T>(this Quantity<T, YottaSiemen> val) where T:IConvertible {
        return new Quantity<double, ZeptoSiemen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaSiemen to YoctoSiemen
    /// </summary>
    /// <param name="val">quantity measured in YottaSiemen</param>
    /// <returns>quantity measured in YoctoSiemen</returns>
	public static Quantity<double, YoctoSiemen> ToYoctoSiemen<T>(this Quantity<T, YottaSiemen> val) where T:IConvertible {
        return new Quantity<double, YoctoSiemen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert ZettaSiemen to YottaSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZettaSiemen</param>
    /// <returns>quantity measured in YottaSiemen</returns>
	public static Quantity<double, YottaSiemen> ToYottaSiemen<T>(this Quantity<T, ZettaSiemen> val) where T:IConvertible {
        return new Quantity<double, YottaSiemen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaSiemen to ExaSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZettaSiemen</param>
    /// <returns>quantity measured in ExaSiemen</returns>
	public static Quantity<double, ExaSiemen> ToExaSiemen<T>(this Quantity<T, ZettaSiemen> val) where T:IConvertible {
        return new Quantity<double, ExaSiemen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaSiemen to PetaSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZettaSiemen</param>
    /// <returns>quantity measured in PetaSiemen</returns>
	public static Quantity<double, PetaSiemen> ToPetaSiemen<T>(this Quantity<T, ZettaSiemen> val) where T:IConvertible {
        return new Quantity<double, PetaSiemen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaSiemen to TeraSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZettaSiemen</param>
    /// <returns>quantity measured in TeraSiemen</returns>
	public static Quantity<double, TeraSiemen> ToTeraSiemen<T>(this Quantity<T, ZettaSiemen> val) where T:IConvertible {
        return new Quantity<double, TeraSiemen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaSiemen to GigaSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZettaSiemen</param>
    /// <returns>quantity measured in GigaSiemen</returns>
	public static Quantity<double, GigaSiemen> ToGigaSiemen<T>(this Quantity<T, ZettaSiemen> val) where T:IConvertible {
        return new Quantity<double, GigaSiemen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaSiemen to MegaSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZettaSiemen</param>
    /// <returns>quantity measured in MegaSiemen</returns>
	public static Quantity<double, MegaSiemen> ToMegaSiemen<T>(this Quantity<T, ZettaSiemen> val) where T:IConvertible {
        return new Quantity<double, MegaSiemen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaSiemen to KiloSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZettaSiemen</param>
    /// <returns>quantity measured in KiloSiemen</returns>
	public static Quantity<double, KiloSiemen> ToKiloSiemen<T>(this Quantity<T, ZettaSiemen> val) where T:IConvertible {
        return new Quantity<double, KiloSiemen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaSiemen to HectoSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZettaSiemen</param>
    /// <returns>quantity measured in HectoSiemen</returns>
	public static Quantity<double, HectoSiemen> ToHectoSiemen<T>(this Quantity<T, ZettaSiemen> val) where T:IConvertible {
        return new Quantity<double, HectoSiemen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaSiemen to DekaSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZettaSiemen</param>
    /// <returns>quantity measured in DekaSiemen</returns>
	public static Quantity<double, DekaSiemen> ToDekaSiemen<T>(this Quantity<T, ZettaSiemen> val) where T:IConvertible {
        return new Quantity<double, DekaSiemen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaSiemen to DeciSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZettaSiemen</param>
    /// <returns>quantity measured in DeciSiemen</returns>
	public static Quantity<double, DeciSiemen> ToDeciSiemen<T>(this Quantity<T, ZettaSiemen> val) where T:IConvertible {
        return new Quantity<double, DeciSiemen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaSiemen to CentiSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZettaSiemen</param>
    /// <returns>quantity measured in CentiSiemen</returns>
	public static Quantity<double, CentiSiemen> ToCentiSiemen<T>(this Quantity<T, ZettaSiemen> val) where T:IConvertible {
        return new Quantity<double, CentiSiemen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaSiemen to MilliSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZettaSiemen</param>
    /// <returns>quantity measured in MilliSiemen</returns>
	public static Quantity<double, MilliSiemen> ToMilliSiemen<T>(this Quantity<T, ZettaSiemen> val) where T:IConvertible {
        return new Quantity<double, MilliSiemen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaSiemen to MicroSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZettaSiemen</param>
    /// <returns>quantity measured in MicroSiemen</returns>
	public static Quantity<double, MicroSiemen> ToMicroSiemen<T>(this Quantity<T, ZettaSiemen> val) where T:IConvertible {
        return new Quantity<double, MicroSiemen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaSiemen to NanoSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZettaSiemen</param>
    /// <returns>quantity measured in NanoSiemen</returns>
	public static Quantity<double, NanoSiemen> ToNanoSiemen<T>(this Quantity<T, ZettaSiemen> val) where T:IConvertible {
        return new Quantity<double, NanoSiemen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaSiemen to PicoSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZettaSiemen</param>
    /// <returns>quantity measured in PicoSiemen</returns>
	public static Quantity<double, PicoSiemen> ToPicoSiemen<T>(this Quantity<T, ZettaSiemen> val) where T:IConvertible {
        return new Quantity<double, PicoSiemen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaSiemen to FemtoSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZettaSiemen</param>
    /// <returns>quantity measured in FemtoSiemen</returns>
	public static Quantity<double, FemtoSiemen> ToFemtoSiemen<T>(this Quantity<T, ZettaSiemen> val) where T:IConvertible {
        return new Quantity<double, FemtoSiemen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaSiemen to AttoSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZettaSiemen</param>
    /// <returns>quantity measured in AttoSiemen</returns>
	public static Quantity<double, AttoSiemen> ToAttoSiemen<T>(this Quantity<T, ZettaSiemen> val) where T:IConvertible {
        return new Quantity<double, AttoSiemen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaSiemen to ZeptoSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZettaSiemen</param>
    /// <returns>quantity measured in ZeptoSiemen</returns>
	public static Quantity<double, ZeptoSiemen> ToZeptoSiemen<T>(this Quantity<T, ZettaSiemen> val) where T:IConvertible {
        return new Quantity<double, ZeptoSiemen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaSiemen to YoctoSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZettaSiemen</param>
    /// <returns>quantity measured in YoctoSiemen</returns>
	public static Quantity<double, YoctoSiemen> ToYoctoSiemen<T>(this Quantity<T, ZettaSiemen> val) where T:IConvertible {
        return new Quantity<double, YoctoSiemen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ExaSiemen to YottaSiemen
    /// </summary>
    /// <param name="val">quantity measured in ExaSiemen</param>
    /// <returns>quantity measured in YottaSiemen</returns>
	public static Quantity<double, YottaSiemen> ToYottaSiemen<T>(this Quantity<T, ExaSiemen> val) where T:IConvertible {
        return new Quantity<double, YottaSiemen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaSiemen to ZettaSiemen
    /// </summary>
    /// <param name="val">quantity measured in ExaSiemen</param>
    /// <returns>quantity measured in ZettaSiemen</returns>
	public static Quantity<double, ZettaSiemen> ToZettaSiemen<T>(this Quantity<T, ExaSiemen> val) where T:IConvertible {
        return new Quantity<double, ZettaSiemen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaSiemen to PetaSiemen
    /// </summary>
    /// <param name="val">quantity measured in ExaSiemen</param>
    /// <returns>quantity measured in PetaSiemen</returns>
	public static Quantity<double, PetaSiemen> ToPetaSiemen<T>(this Quantity<T, ExaSiemen> val) where T:IConvertible {
        return new Quantity<double, PetaSiemen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaSiemen to TeraSiemen
    /// </summary>
    /// <param name="val">quantity measured in ExaSiemen</param>
    /// <returns>quantity measured in TeraSiemen</returns>
	public static Quantity<double, TeraSiemen> ToTeraSiemen<T>(this Quantity<T, ExaSiemen> val) where T:IConvertible {
        return new Quantity<double, TeraSiemen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaSiemen to GigaSiemen
    /// </summary>
    /// <param name="val">quantity measured in ExaSiemen</param>
    /// <returns>quantity measured in GigaSiemen</returns>
	public static Quantity<double, GigaSiemen> ToGigaSiemen<T>(this Quantity<T, ExaSiemen> val) where T:IConvertible {
        return new Quantity<double, GigaSiemen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaSiemen to MegaSiemen
    /// </summary>
    /// <param name="val">quantity measured in ExaSiemen</param>
    /// <returns>quantity measured in MegaSiemen</returns>
	public static Quantity<double, MegaSiemen> ToMegaSiemen<T>(this Quantity<T, ExaSiemen> val) where T:IConvertible {
        return new Quantity<double, MegaSiemen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaSiemen to KiloSiemen
    /// </summary>
    /// <param name="val">quantity measured in ExaSiemen</param>
    /// <returns>quantity measured in KiloSiemen</returns>
	public static Quantity<double, KiloSiemen> ToKiloSiemen<T>(this Quantity<T, ExaSiemen> val) where T:IConvertible {
        return new Quantity<double, KiloSiemen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaSiemen to HectoSiemen
    /// </summary>
    /// <param name="val">quantity measured in ExaSiemen</param>
    /// <returns>quantity measured in HectoSiemen</returns>
	public static Quantity<double, HectoSiemen> ToHectoSiemen<T>(this Quantity<T, ExaSiemen> val) where T:IConvertible {
        return new Quantity<double, HectoSiemen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaSiemen to DekaSiemen
    /// </summary>
    /// <param name="val">quantity measured in ExaSiemen</param>
    /// <returns>quantity measured in DekaSiemen</returns>
	public static Quantity<double, DekaSiemen> ToDekaSiemen<T>(this Quantity<T, ExaSiemen> val) where T:IConvertible {
        return new Quantity<double, DekaSiemen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaSiemen to DeciSiemen
    /// </summary>
    /// <param name="val">quantity measured in ExaSiemen</param>
    /// <returns>quantity measured in DeciSiemen</returns>
	public static Quantity<double, DeciSiemen> ToDeciSiemen<T>(this Quantity<T, ExaSiemen> val) where T:IConvertible {
        return new Quantity<double, DeciSiemen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaSiemen to CentiSiemen
    /// </summary>
    /// <param name="val">quantity measured in ExaSiemen</param>
    /// <returns>quantity measured in CentiSiemen</returns>
	public static Quantity<double, CentiSiemen> ToCentiSiemen<T>(this Quantity<T, ExaSiemen> val) where T:IConvertible {
        return new Quantity<double, CentiSiemen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaSiemen to MilliSiemen
    /// </summary>
    /// <param name="val">quantity measured in ExaSiemen</param>
    /// <returns>quantity measured in MilliSiemen</returns>
	public static Quantity<double, MilliSiemen> ToMilliSiemen<T>(this Quantity<T, ExaSiemen> val) where T:IConvertible {
        return new Quantity<double, MilliSiemen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaSiemen to MicroSiemen
    /// </summary>
    /// <param name="val">quantity measured in ExaSiemen</param>
    /// <returns>quantity measured in MicroSiemen</returns>
	public static Quantity<double, MicroSiemen> ToMicroSiemen<T>(this Quantity<T, ExaSiemen> val) where T:IConvertible {
        return new Quantity<double, MicroSiemen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaSiemen to NanoSiemen
    /// </summary>
    /// <param name="val">quantity measured in ExaSiemen</param>
    /// <returns>quantity measured in NanoSiemen</returns>
	public static Quantity<double, NanoSiemen> ToNanoSiemen<T>(this Quantity<T, ExaSiemen> val) where T:IConvertible {
        return new Quantity<double, NanoSiemen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaSiemen to PicoSiemen
    /// </summary>
    /// <param name="val">quantity measured in ExaSiemen</param>
    /// <returns>quantity measured in PicoSiemen</returns>
	public static Quantity<double, PicoSiemen> ToPicoSiemen<T>(this Quantity<T, ExaSiemen> val) where T:IConvertible {
        return new Quantity<double, PicoSiemen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaSiemen to FemtoSiemen
    /// </summary>
    /// <param name="val">quantity measured in ExaSiemen</param>
    /// <returns>quantity measured in FemtoSiemen</returns>
	public static Quantity<double, FemtoSiemen> ToFemtoSiemen<T>(this Quantity<T, ExaSiemen> val) where T:IConvertible {
        return new Quantity<double, FemtoSiemen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaSiemen to AttoSiemen
    /// </summary>
    /// <param name="val">quantity measured in ExaSiemen</param>
    /// <returns>quantity measured in AttoSiemen</returns>
	public static Quantity<double, AttoSiemen> ToAttoSiemen<T>(this Quantity<T, ExaSiemen> val) where T:IConvertible {
        return new Quantity<double, AttoSiemen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaSiemen to ZeptoSiemen
    /// </summary>
    /// <param name="val">quantity measured in ExaSiemen</param>
    /// <returns>quantity measured in ZeptoSiemen</returns>
	public static Quantity<double, ZeptoSiemen> ToZeptoSiemen<T>(this Quantity<T, ExaSiemen> val) where T:IConvertible {
        return new Quantity<double, ZeptoSiemen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaSiemen to YoctoSiemen
    /// </summary>
    /// <param name="val">quantity measured in ExaSiemen</param>
    /// <returns>quantity measured in YoctoSiemen</returns>
	public static Quantity<double, YoctoSiemen> ToYoctoSiemen<T>(this Quantity<T, ExaSiemen> val) where T:IConvertible {
        return new Quantity<double, YoctoSiemen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert PetaSiemen to YottaSiemen
    /// </summary>
    /// <param name="val">quantity measured in PetaSiemen</param>
    /// <returns>quantity measured in YottaSiemen</returns>
	public static Quantity<double, YottaSiemen> ToYottaSiemen<T>(this Quantity<T, PetaSiemen> val) where T:IConvertible {
        return new Quantity<double, YottaSiemen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaSiemen to ZettaSiemen
    /// </summary>
    /// <param name="val">quantity measured in PetaSiemen</param>
    /// <returns>quantity measured in ZettaSiemen</returns>
	public static Quantity<double, ZettaSiemen> ToZettaSiemen<T>(this Quantity<T, PetaSiemen> val) where T:IConvertible {
        return new Quantity<double, ZettaSiemen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaSiemen to ExaSiemen
    /// </summary>
    /// <param name="val">quantity measured in PetaSiemen</param>
    /// <returns>quantity measured in ExaSiemen</returns>
	public static Quantity<double, ExaSiemen> ToExaSiemen<T>(this Quantity<T, PetaSiemen> val) where T:IConvertible {
        return new Quantity<double, ExaSiemen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaSiemen to TeraSiemen
    /// </summary>
    /// <param name="val">quantity measured in PetaSiemen</param>
    /// <returns>quantity measured in TeraSiemen</returns>
	public static Quantity<double, TeraSiemen> ToTeraSiemen<T>(this Quantity<T, PetaSiemen> val) where T:IConvertible {
        return new Quantity<double, TeraSiemen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaSiemen to GigaSiemen
    /// </summary>
    /// <param name="val">quantity measured in PetaSiemen</param>
    /// <returns>quantity measured in GigaSiemen</returns>
	public static Quantity<double, GigaSiemen> ToGigaSiemen<T>(this Quantity<T, PetaSiemen> val) where T:IConvertible {
        return new Quantity<double, GigaSiemen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaSiemen to MegaSiemen
    /// </summary>
    /// <param name="val">quantity measured in PetaSiemen</param>
    /// <returns>quantity measured in MegaSiemen</returns>
	public static Quantity<double, MegaSiemen> ToMegaSiemen<T>(this Quantity<T, PetaSiemen> val) where T:IConvertible {
        return new Quantity<double, MegaSiemen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaSiemen to KiloSiemen
    /// </summary>
    /// <param name="val">quantity measured in PetaSiemen</param>
    /// <returns>quantity measured in KiloSiemen</returns>
	public static Quantity<double, KiloSiemen> ToKiloSiemen<T>(this Quantity<T, PetaSiemen> val) where T:IConvertible {
        return new Quantity<double, KiloSiemen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaSiemen to HectoSiemen
    /// </summary>
    /// <param name="val">quantity measured in PetaSiemen</param>
    /// <returns>quantity measured in HectoSiemen</returns>
	public static Quantity<double, HectoSiemen> ToHectoSiemen<T>(this Quantity<T, PetaSiemen> val) where T:IConvertible {
        return new Quantity<double, HectoSiemen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaSiemen to DekaSiemen
    /// </summary>
    /// <param name="val">quantity measured in PetaSiemen</param>
    /// <returns>quantity measured in DekaSiemen</returns>
	public static Quantity<double, DekaSiemen> ToDekaSiemen<T>(this Quantity<T, PetaSiemen> val) where T:IConvertible {
        return new Quantity<double, DekaSiemen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaSiemen to DeciSiemen
    /// </summary>
    /// <param name="val">quantity measured in PetaSiemen</param>
    /// <returns>quantity measured in DeciSiemen</returns>
	public static Quantity<double, DeciSiemen> ToDeciSiemen<T>(this Quantity<T, PetaSiemen> val) where T:IConvertible {
        return new Quantity<double, DeciSiemen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaSiemen to CentiSiemen
    /// </summary>
    /// <param name="val">quantity measured in PetaSiemen</param>
    /// <returns>quantity measured in CentiSiemen</returns>
	public static Quantity<double, CentiSiemen> ToCentiSiemen<T>(this Quantity<T, PetaSiemen> val) where T:IConvertible {
        return new Quantity<double, CentiSiemen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaSiemen to MilliSiemen
    /// </summary>
    /// <param name="val">quantity measured in PetaSiemen</param>
    /// <returns>quantity measured in MilliSiemen</returns>
	public static Quantity<double, MilliSiemen> ToMilliSiemen<T>(this Quantity<T, PetaSiemen> val) where T:IConvertible {
        return new Quantity<double, MilliSiemen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaSiemen to MicroSiemen
    /// </summary>
    /// <param name="val">quantity measured in PetaSiemen</param>
    /// <returns>quantity measured in MicroSiemen</returns>
	public static Quantity<double, MicroSiemen> ToMicroSiemen<T>(this Quantity<T, PetaSiemen> val) where T:IConvertible {
        return new Quantity<double, MicroSiemen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaSiemen to NanoSiemen
    /// </summary>
    /// <param name="val">quantity measured in PetaSiemen</param>
    /// <returns>quantity measured in NanoSiemen</returns>
	public static Quantity<double, NanoSiemen> ToNanoSiemen<T>(this Quantity<T, PetaSiemen> val) where T:IConvertible {
        return new Quantity<double, NanoSiemen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaSiemen to PicoSiemen
    /// </summary>
    /// <param name="val">quantity measured in PetaSiemen</param>
    /// <returns>quantity measured in PicoSiemen</returns>
	public static Quantity<double, PicoSiemen> ToPicoSiemen<T>(this Quantity<T, PetaSiemen> val) where T:IConvertible {
        return new Quantity<double, PicoSiemen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaSiemen to FemtoSiemen
    /// </summary>
    /// <param name="val">quantity measured in PetaSiemen</param>
    /// <returns>quantity measured in FemtoSiemen</returns>
	public static Quantity<double, FemtoSiemen> ToFemtoSiemen<T>(this Quantity<T, PetaSiemen> val) where T:IConvertible {
        return new Quantity<double, FemtoSiemen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaSiemen to AttoSiemen
    /// </summary>
    /// <param name="val">quantity measured in PetaSiemen</param>
    /// <returns>quantity measured in AttoSiemen</returns>
	public static Quantity<double, AttoSiemen> ToAttoSiemen<T>(this Quantity<T, PetaSiemen> val) where T:IConvertible {
        return new Quantity<double, AttoSiemen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaSiemen to ZeptoSiemen
    /// </summary>
    /// <param name="val">quantity measured in PetaSiemen</param>
    /// <returns>quantity measured in ZeptoSiemen</returns>
	public static Quantity<double, ZeptoSiemen> ToZeptoSiemen<T>(this Quantity<T, PetaSiemen> val) where T:IConvertible {
        return new Quantity<double, ZeptoSiemen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaSiemen to YoctoSiemen
    /// </summary>
    /// <param name="val">quantity measured in PetaSiemen</param>
    /// <returns>quantity measured in YoctoSiemen</returns>
	public static Quantity<double, YoctoSiemen> ToYoctoSiemen<T>(this Quantity<T, PetaSiemen> val) where T:IConvertible {
        return new Quantity<double, YoctoSiemen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert TeraSiemen to YottaSiemen
    /// </summary>
    /// <param name="val">quantity measured in TeraSiemen</param>
    /// <returns>quantity measured in YottaSiemen</returns>
	public static Quantity<double, YottaSiemen> ToYottaSiemen<T>(this Quantity<T, TeraSiemen> val) where T:IConvertible {
        return new Quantity<double, YottaSiemen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraSiemen to ZettaSiemen
    /// </summary>
    /// <param name="val">quantity measured in TeraSiemen</param>
    /// <returns>quantity measured in ZettaSiemen</returns>
	public static Quantity<double, ZettaSiemen> ToZettaSiemen<T>(this Quantity<T, TeraSiemen> val) where T:IConvertible {
        return new Quantity<double, ZettaSiemen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraSiemen to ExaSiemen
    /// </summary>
    /// <param name="val">quantity measured in TeraSiemen</param>
    /// <returns>quantity measured in ExaSiemen</returns>
	public static Quantity<double, ExaSiemen> ToExaSiemen<T>(this Quantity<T, TeraSiemen> val) where T:IConvertible {
        return new Quantity<double, ExaSiemen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraSiemen to PetaSiemen
    /// </summary>
    /// <param name="val">quantity measured in TeraSiemen</param>
    /// <returns>quantity measured in PetaSiemen</returns>
	public static Quantity<double, PetaSiemen> ToPetaSiemen<T>(this Quantity<T, TeraSiemen> val) where T:IConvertible {
        return new Quantity<double, PetaSiemen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraSiemen to GigaSiemen
    /// </summary>
    /// <param name="val">quantity measured in TeraSiemen</param>
    /// <returns>quantity measured in GigaSiemen</returns>
	public static Quantity<double, GigaSiemen> ToGigaSiemen<T>(this Quantity<T, TeraSiemen> val) where T:IConvertible {
        return new Quantity<double, GigaSiemen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraSiemen to MegaSiemen
    /// </summary>
    /// <param name="val">quantity measured in TeraSiemen</param>
    /// <returns>quantity measured in MegaSiemen</returns>
	public static Quantity<double, MegaSiemen> ToMegaSiemen<T>(this Quantity<T, TeraSiemen> val) where T:IConvertible {
        return new Quantity<double, MegaSiemen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraSiemen to KiloSiemen
    /// </summary>
    /// <param name="val">quantity measured in TeraSiemen</param>
    /// <returns>quantity measured in KiloSiemen</returns>
	public static Quantity<double, KiloSiemen> ToKiloSiemen<T>(this Quantity<T, TeraSiemen> val) where T:IConvertible {
        return new Quantity<double, KiloSiemen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraSiemen to HectoSiemen
    /// </summary>
    /// <param name="val">quantity measured in TeraSiemen</param>
    /// <returns>quantity measured in HectoSiemen</returns>
	public static Quantity<double, HectoSiemen> ToHectoSiemen<T>(this Quantity<T, TeraSiemen> val) where T:IConvertible {
        return new Quantity<double, HectoSiemen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraSiemen to DekaSiemen
    /// </summary>
    /// <param name="val">quantity measured in TeraSiemen</param>
    /// <returns>quantity measured in DekaSiemen</returns>
	public static Quantity<double, DekaSiemen> ToDekaSiemen<T>(this Quantity<T, TeraSiemen> val) where T:IConvertible {
        return new Quantity<double, DekaSiemen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraSiemen to DeciSiemen
    /// </summary>
    /// <param name="val">quantity measured in TeraSiemen</param>
    /// <returns>quantity measured in DeciSiemen</returns>
	public static Quantity<double, DeciSiemen> ToDeciSiemen<T>(this Quantity<T, TeraSiemen> val) where T:IConvertible {
        return new Quantity<double, DeciSiemen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraSiemen to CentiSiemen
    /// </summary>
    /// <param name="val">quantity measured in TeraSiemen</param>
    /// <returns>quantity measured in CentiSiemen</returns>
	public static Quantity<double, CentiSiemen> ToCentiSiemen<T>(this Quantity<T, TeraSiemen> val) where T:IConvertible {
        return new Quantity<double, CentiSiemen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraSiemen to MilliSiemen
    /// </summary>
    /// <param name="val">quantity measured in TeraSiemen</param>
    /// <returns>quantity measured in MilliSiemen</returns>
	public static Quantity<double, MilliSiemen> ToMilliSiemen<T>(this Quantity<T, TeraSiemen> val) where T:IConvertible {
        return new Quantity<double, MilliSiemen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraSiemen to MicroSiemen
    /// </summary>
    /// <param name="val">quantity measured in TeraSiemen</param>
    /// <returns>quantity measured in MicroSiemen</returns>
	public static Quantity<double, MicroSiemen> ToMicroSiemen<T>(this Quantity<T, TeraSiemen> val) where T:IConvertible {
        return new Quantity<double, MicroSiemen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraSiemen to NanoSiemen
    /// </summary>
    /// <param name="val">quantity measured in TeraSiemen</param>
    /// <returns>quantity measured in NanoSiemen</returns>
	public static Quantity<double, NanoSiemen> ToNanoSiemen<T>(this Quantity<T, TeraSiemen> val) where T:IConvertible {
        return new Quantity<double, NanoSiemen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraSiemen to PicoSiemen
    /// </summary>
    /// <param name="val">quantity measured in TeraSiemen</param>
    /// <returns>quantity measured in PicoSiemen</returns>
	public static Quantity<double, PicoSiemen> ToPicoSiemen<T>(this Quantity<T, TeraSiemen> val) where T:IConvertible {
        return new Quantity<double, PicoSiemen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraSiemen to FemtoSiemen
    /// </summary>
    /// <param name="val">quantity measured in TeraSiemen</param>
    /// <returns>quantity measured in FemtoSiemen</returns>
	public static Quantity<double, FemtoSiemen> ToFemtoSiemen<T>(this Quantity<T, TeraSiemen> val) where T:IConvertible {
        return new Quantity<double, FemtoSiemen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraSiemen to AttoSiemen
    /// </summary>
    /// <param name="val">quantity measured in TeraSiemen</param>
    /// <returns>quantity measured in AttoSiemen</returns>
	public static Quantity<double, AttoSiemen> ToAttoSiemen<T>(this Quantity<T, TeraSiemen> val) where T:IConvertible {
        return new Quantity<double, AttoSiemen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraSiemen to ZeptoSiemen
    /// </summary>
    /// <param name="val">quantity measured in TeraSiemen</param>
    /// <returns>quantity measured in ZeptoSiemen</returns>
	public static Quantity<double, ZeptoSiemen> ToZeptoSiemen<T>(this Quantity<T, TeraSiemen> val) where T:IConvertible {
        return new Quantity<double, ZeptoSiemen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraSiemen to YoctoSiemen
    /// </summary>
    /// <param name="val">quantity measured in TeraSiemen</param>
    /// <returns>quantity measured in YoctoSiemen</returns>
	public static Quantity<double, YoctoSiemen> ToYoctoSiemen<T>(this Quantity<T, TeraSiemen> val) where T:IConvertible {
        return new Quantity<double, YoctoSiemen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert GigaSiemen to YottaSiemen
    /// </summary>
    /// <param name="val">quantity measured in GigaSiemen</param>
    /// <returns>quantity measured in YottaSiemen</returns>
	public static Quantity<double, YottaSiemen> ToYottaSiemen<T>(this Quantity<T, GigaSiemen> val) where T:IConvertible {
        return new Quantity<double, YottaSiemen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaSiemen to ZettaSiemen
    /// </summary>
    /// <param name="val">quantity measured in GigaSiemen</param>
    /// <returns>quantity measured in ZettaSiemen</returns>
	public static Quantity<double, ZettaSiemen> ToZettaSiemen<T>(this Quantity<T, GigaSiemen> val) where T:IConvertible {
        return new Quantity<double, ZettaSiemen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaSiemen to ExaSiemen
    /// </summary>
    /// <param name="val">quantity measured in GigaSiemen</param>
    /// <returns>quantity measured in ExaSiemen</returns>
	public static Quantity<double, ExaSiemen> ToExaSiemen<T>(this Quantity<T, GigaSiemen> val) where T:IConvertible {
        return new Quantity<double, ExaSiemen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaSiemen to PetaSiemen
    /// </summary>
    /// <param name="val">quantity measured in GigaSiemen</param>
    /// <returns>quantity measured in PetaSiemen</returns>
	public static Quantity<double, PetaSiemen> ToPetaSiemen<T>(this Quantity<T, GigaSiemen> val) where T:IConvertible {
        return new Quantity<double, PetaSiemen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaSiemen to TeraSiemen
    /// </summary>
    /// <param name="val">quantity measured in GigaSiemen</param>
    /// <returns>quantity measured in TeraSiemen</returns>
	public static Quantity<double, TeraSiemen> ToTeraSiemen<T>(this Quantity<T, GigaSiemen> val) where T:IConvertible {
        return new Quantity<double, TeraSiemen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaSiemen to MegaSiemen
    /// </summary>
    /// <param name="val">quantity measured in GigaSiemen</param>
    /// <returns>quantity measured in MegaSiemen</returns>
	public static Quantity<double, MegaSiemen> ToMegaSiemen<T>(this Quantity<T, GigaSiemen> val) where T:IConvertible {
        return new Quantity<double, MegaSiemen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaSiemen to KiloSiemen
    /// </summary>
    /// <param name="val">quantity measured in GigaSiemen</param>
    /// <returns>quantity measured in KiloSiemen</returns>
	public static Quantity<double, KiloSiemen> ToKiloSiemen<T>(this Quantity<T, GigaSiemen> val) where T:IConvertible {
        return new Quantity<double, KiloSiemen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaSiemen to HectoSiemen
    /// </summary>
    /// <param name="val">quantity measured in GigaSiemen</param>
    /// <returns>quantity measured in HectoSiemen</returns>
	public static Quantity<double, HectoSiemen> ToHectoSiemen<T>(this Quantity<T, GigaSiemen> val) where T:IConvertible {
        return new Quantity<double, HectoSiemen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaSiemen to DekaSiemen
    /// </summary>
    /// <param name="val">quantity measured in GigaSiemen</param>
    /// <returns>quantity measured in DekaSiemen</returns>
	public static Quantity<double, DekaSiemen> ToDekaSiemen<T>(this Quantity<T, GigaSiemen> val) where T:IConvertible {
        return new Quantity<double, DekaSiemen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaSiemen to DeciSiemen
    /// </summary>
    /// <param name="val">quantity measured in GigaSiemen</param>
    /// <returns>quantity measured in DeciSiemen</returns>
	public static Quantity<double, DeciSiemen> ToDeciSiemen<T>(this Quantity<T, GigaSiemen> val) where T:IConvertible {
        return new Quantity<double, DeciSiemen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaSiemen to CentiSiemen
    /// </summary>
    /// <param name="val">quantity measured in GigaSiemen</param>
    /// <returns>quantity measured in CentiSiemen</returns>
	public static Quantity<double, CentiSiemen> ToCentiSiemen<T>(this Quantity<T, GigaSiemen> val) where T:IConvertible {
        return new Quantity<double, CentiSiemen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaSiemen to MilliSiemen
    /// </summary>
    /// <param name="val">quantity measured in GigaSiemen</param>
    /// <returns>quantity measured in MilliSiemen</returns>
	public static Quantity<double, MilliSiemen> ToMilliSiemen<T>(this Quantity<T, GigaSiemen> val) where T:IConvertible {
        return new Quantity<double, MilliSiemen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaSiemen to MicroSiemen
    /// </summary>
    /// <param name="val">quantity measured in GigaSiemen</param>
    /// <returns>quantity measured in MicroSiemen</returns>
	public static Quantity<double, MicroSiemen> ToMicroSiemen<T>(this Quantity<T, GigaSiemen> val) where T:IConvertible {
        return new Quantity<double, MicroSiemen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaSiemen to NanoSiemen
    /// </summary>
    /// <param name="val">quantity measured in GigaSiemen</param>
    /// <returns>quantity measured in NanoSiemen</returns>
	public static Quantity<double, NanoSiemen> ToNanoSiemen<T>(this Quantity<T, GigaSiemen> val) where T:IConvertible {
        return new Quantity<double, NanoSiemen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaSiemen to PicoSiemen
    /// </summary>
    /// <param name="val">quantity measured in GigaSiemen</param>
    /// <returns>quantity measured in PicoSiemen</returns>
	public static Quantity<double, PicoSiemen> ToPicoSiemen<T>(this Quantity<T, GigaSiemen> val) where T:IConvertible {
        return new Quantity<double, PicoSiemen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaSiemen to FemtoSiemen
    /// </summary>
    /// <param name="val">quantity measured in GigaSiemen</param>
    /// <returns>quantity measured in FemtoSiemen</returns>
	public static Quantity<double, FemtoSiemen> ToFemtoSiemen<T>(this Quantity<T, GigaSiemen> val) where T:IConvertible {
        return new Quantity<double, FemtoSiemen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaSiemen to AttoSiemen
    /// </summary>
    /// <param name="val">quantity measured in GigaSiemen</param>
    /// <returns>quantity measured in AttoSiemen</returns>
	public static Quantity<double, AttoSiemen> ToAttoSiemen<T>(this Quantity<T, GigaSiemen> val) where T:IConvertible {
        return new Quantity<double, AttoSiemen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaSiemen to ZeptoSiemen
    /// </summary>
    /// <param name="val">quantity measured in GigaSiemen</param>
    /// <returns>quantity measured in ZeptoSiemen</returns>
	public static Quantity<double, ZeptoSiemen> ToZeptoSiemen<T>(this Quantity<T, GigaSiemen> val) where T:IConvertible {
        return new Quantity<double, ZeptoSiemen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaSiemen to YoctoSiemen
    /// </summary>
    /// <param name="val">quantity measured in GigaSiemen</param>
    /// <returns>quantity measured in YoctoSiemen</returns>
	public static Quantity<double, YoctoSiemen> ToYoctoSiemen<T>(this Quantity<T, GigaSiemen> val) where T:IConvertible {
        return new Quantity<double, YoctoSiemen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert MegaSiemen to YottaSiemen
    /// </summary>
    /// <param name="val">quantity measured in MegaSiemen</param>
    /// <returns>quantity measured in YottaSiemen</returns>
	public static Quantity<double, YottaSiemen> ToYottaSiemen<T>(this Quantity<T, MegaSiemen> val) where T:IConvertible {
        return new Quantity<double, YottaSiemen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaSiemen to ZettaSiemen
    /// </summary>
    /// <param name="val">quantity measured in MegaSiemen</param>
    /// <returns>quantity measured in ZettaSiemen</returns>
	public static Quantity<double, ZettaSiemen> ToZettaSiemen<T>(this Quantity<T, MegaSiemen> val) where T:IConvertible {
        return new Quantity<double, ZettaSiemen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaSiemen to ExaSiemen
    /// </summary>
    /// <param name="val">quantity measured in MegaSiemen</param>
    /// <returns>quantity measured in ExaSiemen</returns>
	public static Quantity<double, ExaSiemen> ToExaSiemen<T>(this Quantity<T, MegaSiemen> val) where T:IConvertible {
        return new Quantity<double, ExaSiemen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaSiemen to PetaSiemen
    /// </summary>
    /// <param name="val">quantity measured in MegaSiemen</param>
    /// <returns>quantity measured in PetaSiemen</returns>
	public static Quantity<double, PetaSiemen> ToPetaSiemen<T>(this Quantity<T, MegaSiemen> val) where T:IConvertible {
        return new Quantity<double, PetaSiemen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaSiemen to TeraSiemen
    /// </summary>
    /// <param name="val">quantity measured in MegaSiemen</param>
    /// <returns>quantity measured in TeraSiemen</returns>
	public static Quantity<double, TeraSiemen> ToTeraSiemen<T>(this Quantity<T, MegaSiemen> val) where T:IConvertible {
        return new Quantity<double, TeraSiemen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaSiemen to GigaSiemen
    /// </summary>
    /// <param name="val">quantity measured in MegaSiemen</param>
    /// <returns>quantity measured in GigaSiemen</returns>
	public static Quantity<double, GigaSiemen> ToGigaSiemen<T>(this Quantity<T, MegaSiemen> val) where T:IConvertible {
        return new Quantity<double, GigaSiemen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaSiemen to KiloSiemen
    /// </summary>
    /// <param name="val">quantity measured in MegaSiemen</param>
    /// <returns>quantity measured in KiloSiemen</returns>
	public static Quantity<double, KiloSiemen> ToKiloSiemen<T>(this Quantity<T, MegaSiemen> val) where T:IConvertible {
        return new Quantity<double, KiloSiemen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaSiemen to HectoSiemen
    /// </summary>
    /// <param name="val">quantity measured in MegaSiemen</param>
    /// <returns>quantity measured in HectoSiemen</returns>
	public static Quantity<double, HectoSiemen> ToHectoSiemen<T>(this Quantity<T, MegaSiemen> val) where T:IConvertible {
        return new Quantity<double, HectoSiemen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaSiemen to DekaSiemen
    /// </summary>
    /// <param name="val">quantity measured in MegaSiemen</param>
    /// <returns>quantity measured in DekaSiemen</returns>
	public static Quantity<double, DekaSiemen> ToDekaSiemen<T>(this Quantity<T, MegaSiemen> val) where T:IConvertible {
        return new Quantity<double, DekaSiemen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaSiemen to DeciSiemen
    /// </summary>
    /// <param name="val">quantity measured in MegaSiemen</param>
    /// <returns>quantity measured in DeciSiemen</returns>
	public static Quantity<double, DeciSiemen> ToDeciSiemen<T>(this Quantity<T, MegaSiemen> val) where T:IConvertible {
        return new Quantity<double, DeciSiemen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaSiemen to CentiSiemen
    /// </summary>
    /// <param name="val">quantity measured in MegaSiemen</param>
    /// <returns>quantity measured in CentiSiemen</returns>
	public static Quantity<double, CentiSiemen> ToCentiSiemen<T>(this Quantity<T, MegaSiemen> val) where T:IConvertible {
        return new Quantity<double, CentiSiemen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaSiemen to MilliSiemen
    /// </summary>
    /// <param name="val">quantity measured in MegaSiemen</param>
    /// <returns>quantity measured in MilliSiemen</returns>
	public static Quantity<double, MilliSiemen> ToMilliSiemen<T>(this Quantity<T, MegaSiemen> val) where T:IConvertible {
        return new Quantity<double, MilliSiemen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaSiemen to MicroSiemen
    /// </summary>
    /// <param name="val">quantity measured in MegaSiemen</param>
    /// <returns>quantity measured in MicroSiemen</returns>
	public static Quantity<double, MicroSiemen> ToMicroSiemen<T>(this Quantity<T, MegaSiemen> val) where T:IConvertible {
        return new Quantity<double, MicroSiemen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaSiemen to NanoSiemen
    /// </summary>
    /// <param name="val">quantity measured in MegaSiemen</param>
    /// <returns>quantity measured in NanoSiemen</returns>
	public static Quantity<double, NanoSiemen> ToNanoSiemen<T>(this Quantity<T, MegaSiemen> val) where T:IConvertible {
        return new Quantity<double, NanoSiemen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaSiemen to PicoSiemen
    /// </summary>
    /// <param name="val">quantity measured in MegaSiemen</param>
    /// <returns>quantity measured in PicoSiemen</returns>
	public static Quantity<double, PicoSiemen> ToPicoSiemen<T>(this Quantity<T, MegaSiemen> val) where T:IConvertible {
        return new Quantity<double, PicoSiemen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaSiemen to FemtoSiemen
    /// </summary>
    /// <param name="val">quantity measured in MegaSiemen</param>
    /// <returns>quantity measured in FemtoSiemen</returns>
	public static Quantity<double, FemtoSiemen> ToFemtoSiemen<T>(this Quantity<T, MegaSiemen> val) where T:IConvertible {
        return new Quantity<double, FemtoSiemen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaSiemen to AttoSiemen
    /// </summary>
    /// <param name="val">quantity measured in MegaSiemen</param>
    /// <returns>quantity measured in AttoSiemen</returns>
	public static Quantity<double, AttoSiemen> ToAttoSiemen<T>(this Quantity<T, MegaSiemen> val) where T:IConvertible {
        return new Quantity<double, AttoSiemen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaSiemen to ZeptoSiemen
    /// </summary>
    /// <param name="val">quantity measured in MegaSiemen</param>
    /// <returns>quantity measured in ZeptoSiemen</returns>
	public static Quantity<double, ZeptoSiemen> ToZeptoSiemen<T>(this Quantity<T, MegaSiemen> val) where T:IConvertible {
        return new Quantity<double, ZeptoSiemen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaSiemen to YoctoSiemen
    /// </summary>
    /// <param name="val">quantity measured in MegaSiemen</param>
    /// <returns>quantity measured in YoctoSiemen</returns>
	public static Quantity<double, YoctoSiemen> ToYoctoSiemen<T>(this Quantity<T, MegaSiemen> val) where T:IConvertible {
        return new Quantity<double, YoctoSiemen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert KiloSiemen to YottaSiemen
    /// </summary>
    /// <param name="val">quantity measured in KiloSiemen</param>
    /// <returns>quantity measured in YottaSiemen</returns>
	public static Quantity<double, YottaSiemen> ToYottaSiemen<T>(this Quantity<T, KiloSiemen> val) where T:IConvertible {
        return new Quantity<double, YottaSiemen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloSiemen to ZettaSiemen
    /// </summary>
    /// <param name="val">quantity measured in KiloSiemen</param>
    /// <returns>quantity measured in ZettaSiemen</returns>
	public static Quantity<double, ZettaSiemen> ToZettaSiemen<T>(this Quantity<T, KiloSiemen> val) where T:IConvertible {
        return new Quantity<double, ZettaSiemen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloSiemen to ExaSiemen
    /// </summary>
    /// <param name="val">quantity measured in KiloSiemen</param>
    /// <returns>quantity measured in ExaSiemen</returns>
	public static Quantity<double, ExaSiemen> ToExaSiemen<T>(this Quantity<T, KiloSiemen> val) where T:IConvertible {
        return new Quantity<double, ExaSiemen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloSiemen to PetaSiemen
    /// </summary>
    /// <param name="val">quantity measured in KiloSiemen</param>
    /// <returns>quantity measured in PetaSiemen</returns>
	public static Quantity<double, PetaSiemen> ToPetaSiemen<T>(this Quantity<T, KiloSiemen> val) where T:IConvertible {
        return new Quantity<double, PetaSiemen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloSiemen to TeraSiemen
    /// </summary>
    /// <param name="val">quantity measured in KiloSiemen</param>
    /// <returns>quantity measured in TeraSiemen</returns>
	public static Quantity<double, TeraSiemen> ToTeraSiemen<T>(this Quantity<T, KiloSiemen> val) where T:IConvertible {
        return new Quantity<double, TeraSiemen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloSiemen to GigaSiemen
    /// </summary>
    /// <param name="val">quantity measured in KiloSiemen</param>
    /// <returns>quantity measured in GigaSiemen</returns>
	public static Quantity<double, GigaSiemen> ToGigaSiemen<T>(this Quantity<T, KiloSiemen> val) where T:IConvertible {
        return new Quantity<double, GigaSiemen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloSiemen to MegaSiemen
    /// </summary>
    /// <param name="val">quantity measured in KiloSiemen</param>
    /// <returns>quantity measured in MegaSiemen</returns>
	public static Quantity<double, MegaSiemen> ToMegaSiemen<T>(this Quantity<T, KiloSiemen> val) where T:IConvertible {
        return new Quantity<double, MegaSiemen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloSiemen to HectoSiemen
    /// </summary>
    /// <param name="val">quantity measured in KiloSiemen</param>
    /// <returns>quantity measured in HectoSiemen</returns>
	public static Quantity<double, HectoSiemen> ToHectoSiemen<T>(this Quantity<T, KiloSiemen> val) where T:IConvertible {
        return new Quantity<double, HectoSiemen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloSiemen to DekaSiemen
    /// </summary>
    /// <param name="val">quantity measured in KiloSiemen</param>
    /// <returns>quantity measured in DekaSiemen</returns>
	public static Quantity<double, DekaSiemen> ToDekaSiemen<T>(this Quantity<T, KiloSiemen> val) where T:IConvertible {
        return new Quantity<double, DekaSiemen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloSiemen to DeciSiemen
    /// </summary>
    /// <param name="val">quantity measured in KiloSiemen</param>
    /// <returns>quantity measured in DeciSiemen</returns>
	public static Quantity<double, DeciSiemen> ToDeciSiemen<T>(this Quantity<T, KiloSiemen> val) where T:IConvertible {
        return new Quantity<double, DeciSiemen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloSiemen to CentiSiemen
    /// </summary>
    /// <param name="val">quantity measured in KiloSiemen</param>
    /// <returns>quantity measured in CentiSiemen</returns>
	public static Quantity<double, CentiSiemen> ToCentiSiemen<T>(this Quantity<T, KiloSiemen> val) where T:IConvertible {
        return new Quantity<double, CentiSiemen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloSiemen to MilliSiemen
    /// </summary>
    /// <param name="val">quantity measured in KiloSiemen</param>
    /// <returns>quantity measured in MilliSiemen</returns>
	public static Quantity<double, MilliSiemen> ToMilliSiemen<T>(this Quantity<T, KiloSiemen> val) where T:IConvertible {
        return new Quantity<double, MilliSiemen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloSiemen to MicroSiemen
    /// </summary>
    /// <param name="val">quantity measured in KiloSiemen</param>
    /// <returns>quantity measured in MicroSiemen</returns>
	public static Quantity<double, MicroSiemen> ToMicroSiemen<T>(this Quantity<T, KiloSiemen> val) where T:IConvertible {
        return new Quantity<double, MicroSiemen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloSiemen to NanoSiemen
    /// </summary>
    /// <param name="val">quantity measured in KiloSiemen</param>
    /// <returns>quantity measured in NanoSiemen</returns>
	public static Quantity<double, NanoSiemen> ToNanoSiemen<T>(this Quantity<T, KiloSiemen> val) where T:IConvertible {
        return new Quantity<double, NanoSiemen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloSiemen to PicoSiemen
    /// </summary>
    /// <param name="val">quantity measured in KiloSiemen</param>
    /// <returns>quantity measured in PicoSiemen</returns>
	public static Quantity<double, PicoSiemen> ToPicoSiemen<T>(this Quantity<T, KiloSiemen> val) where T:IConvertible {
        return new Quantity<double, PicoSiemen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloSiemen to FemtoSiemen
    /// </summary>
    /// <param name="val">quantity measured in KiloSiemen</param>
    /// <returns>quantity measured in FemtoSiemen</returns>
	public static Quantity<double, FemtoSiemen> ToFemtoSiemen<T>(this Quantity<T, KiloSiemen> val) where T:IConvertible {
        return new Quantity<double, FemtoSiemen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloSiemen to AttoSiemen
    /// </summary>
    /// <param name="val">quantity measured in KiloSiemen</param>
    /// <returns>quantity measured in AttoSiemen</returns>
	public static Quantity<double, AttoSiemen> ToAttoSiemen<T>(this Quantity<T, KiloSiemen> val) where T:IConvertible {
        return new Quantity<double, AttoSiemen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloSiemen to ZeptoSiemen
    /// </summary>
    /// <param name="val">quantity measured in KiloSiemen</param>
    /// <returns>quantity measured in ZeptoSiemen</returns>
	public static Quantity<double, ZeptoSiemen> ToZeptoSiemen<T>(this Quantity<T, KiloSiemen> val) where T:IConvertible {
        return new Quantity<double, ZeptoSiemen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloSiemen to YoctoSiemen
    /// </summary>
    /// <param name="val">quantity measured in KiloSiemen</param>
    /// <returns>quantity measured in YoctoSiemen</returns>
	public static Quantity<double, YoctoSiemen> ToYoctoSiemen<T>(this Quantity<T, KiloSiemen> val) where T:IConvertible {
        return new Quantity<double, YoctoSiemen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert HectoSiemen to YottaSiemen
    /// </summary>
    /// <param name="val">quantity measured in HectoSiemen</param>
    /// <returns>quantity measured in YottaSiemen</returns>
	public static Quantity<double, YottaSiemen> ToYottaSiemen<T>(this Quantity<T, HectoSiemen> val) where T:IConvertible {
        return new Quantity<double, YottaSiemen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoSiemen to ZettaSiemen
    /// </summary>
    /// <param name="val">quantity measured in HectoSiemen</param>
    /// <returns>quantity measured in ZettaSiemen</returns>
	public static Quantity<double, ZettaSiemen> ToZettaSiemen<T>(this Quantity<T, HectoSiemen> val) where T:IConvertible {
        return new Quantity<double, ZettaSiemen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoSiemen to ExaSiemen
    /// </summary>
    /// <param name="val">quantity measured in HectoSiemen</param>
    /// <returns>quantity measured in ExaSiemen</returns>
	public static Quantity<double, ExaSiemen> ToExaSiemen<T>(this Quantity<T, HectoSiemen> val) where T:IConvertible {
        return new Quantity<double, ExaSiemen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoSiemen to PetaSiemen
    /// </summary>
    /// <param name="val">quantity measured in HectoSiemen</param>
    /// <returns>quantity measured in PetaSiemen</returns>
	public static Quantity<double, PetaSiemen> ToPetaSiemen<T>(this Quantity<T, HectoSiemen> val) where T:IConvertible {
        return new Quantity<double, PetaSiemen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoSiemen to TeraSiemen
    /// </summary>
    /// <param name="val">quantity measured in HectoSiemen</param>
    /// <returns>quantity measured in TeraSiemen</returns>
	public static Quantity<double, TeraSiemen> ToTeraSiemen<T>(this Quantity<T, HectoSiemen> val) where T:IConvertible {
        return new Quantity<double, TeraSiemen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoSiemen to GigaSiemen
    /// </summary>
    /// <param name="val">quantity measured in HectoSiemen</param>
    /// <returns>quantity measured in GigaSiemen</returns>
	public static Quantity<double, GigaSiemen> ToGigaSiemen<T>(this Quantity<T, HectoSiemen> val) where T:IConvertible {
        return new Quantity<double, GigaSiemen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoSiemen to MegaSiemen
    /// </summary>
    /// <param name="val">quantity measured in HectoSiemen</param>
    /// <returns>quantity measured in MegaSiemen</returns>
	public static Quantity<double, MegaSiemen> ToMegaSiemen<T>(this Quantity<T, HectoSiemen> val) where T:IConvertible {
        return new Quantity<double, MegaSiemen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoSiemen to KiloSiemen
    /// </summary>
    /// <param name="val">quantity measured in HectoSiemen</param>
    /// <returns>quantity measured in KiloSiemen</returns>
	public static Quantity<double, KiloSiemen> ToKiloSiemen<T>(this Quantity<T, HectoSiemen> val) where T:IConvertible {
        return new Quantity<double, KiloSiemen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoSiemen to DekaSiemen
    /// </summary>
    /// <param name="val">quantity measured in HectoSiemen</param>
    /// <returns>quantity measured in DekaSiemen</returns>
	public static Quantity<double, DekaSiemen> ToDekaSiemen<T>(this Quantity<T, HectoSiemen> val) where T:IConvertible {
        return new Quantity<double, DekaSiemen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoSiemen to DeciSiemen
    /// </summary>
    /// <param name="val">quantity measured in HectoSiemen</param>
    /// <returns>quantity measured in DeciSiemen</returns>
	public static Quantity<double, DeciSiemen> ToDeciSiemen<T>(this Quantity<T, HectoSiemen> val) where T:IConvertible {
        return new Quantity<double, DeciSiemen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoSiemen to CentiSiemen
    /// </summary>
    /// <param name="val">quantity measured in HectoSiemen</param>
    /// <returns>quantity measured in CentiSiemen</returns>
	public static Quantity<double, CentiSiemen> ToCentiSiemen<T>(this Quantity<T, HectoSiemen> val) where T:IConvertible {
        return new Quantity<double, CentiSiemen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoSiemen to MilliSiemen
    /// </summary>
    /// <param name="val">quantity measured in HectoSiemen</param>
    /// <returns>quantity measured in MilliSiemen</returns>
	public static Quantity<double, MilliSiemen> ToMilliSiemen<T>(this Quantity<T, HectoSiemen> val) where T:IConvertible {
        return new Quantity<double, MilliSiemen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoSiemen to MicroSiemen
    /// </summary>
    /// <param name="val">quantity measured in HectoSiemen</param>
    /// <returns>quantity measured in MicroSiemen</returns>
	public static Quantity<double, MicroSiemen> ToMicroSiemen<T>(this Quantity<T, HectoSiemen> val) where T:IConvertible {
        return new Quantity<double, MicroSiemen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoSiemen to NanoSiemen
    /// </summary>
    /// <param name="val">quantity measured in HectoSiemen</param>
    /// <returns>quantity measured in NanoSiemen</returns>
	public static Quantity<double, NanoSiemen> ToNanoSiemen<T>(this Quantity<T, HectoSiemen> val) where T:IConvertible {
        return new Quantity<double, NanoSiemen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoSiemen to PicoSiemen
    /// </summary>
    /// <param name="val">quantity measured in HectoSiemen</param>
    /// <returns>quantity measured in PicoSiemen</returns>
	public static Quantity<double, PicoSiemen> ToPicoSiemen<T>(this Quantity<T, HectoSiemen> val) where T:IConvertible {
        return new Quantity<double, PicoSiemen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoSiemen to FemtoSiemen
    /// </summary>
    /// <param name="val">quantity measured in HectoSiemen</param>
    /// <returns>quantity measured in FemtoSiemen</returns>
	public static Quantity<double, FemtoSiemen> ToFemtoSiemen<T>(this Quantity<T, HectoSiemen> val) where T:IConvertible {
        return new Quantity<double, FemtoSiemen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoSiemen to AttoSiemen
    /// </summary>
    /// <param name="val">quantity measured in HectoSiemen</param>
    /// <returns>quantity measured in AttoSiemen</returns>
	public static Quantity<double, AttoSiemen> ToAttoSiemen<T>(this Quantity<T, HectoSiemen> val) where T:IConvertible {
        return new Quantity<double, AttoSiemen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoSiemen to ZeptoSiemen
    /// </summary>
    /// <param name="val">quantity measured in HectoSiemen</param>
    /// <returns>quantity measured in ZeptoSiemen</returns>
	public static Quantity<double, ZeptoSiemen> ToZeptoSiemen<T>(this Quantity<T, HectoSiemen> val) where T:IConvertible {
        return new Quantity<double, ZeptoSiemen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoSiemen to YoctoSiemen
    /// </summary>
    /// <param name="val">quantity measured in HectoSiemen</param>
    /// <returns>quantity measured in YoctoSiemen</returns>
	public static Quantity<double, YoctoSiemen> ToYoctoSiemen<T>(this Quantity<T, HectoSiemen> val) where T:IConvertible {
        return new Quantity<double, YoctoSiemen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert DekaSiemen to YottaSiemen
    /// </summary>
    /// <param name="val">quantity measured in DekaSiemen</param>
    /// <returns>quantity measured in YottaSiemen</returns>
	public static Quantity<double, YottaSiemen> ToYottaSiemen<T>(this Quantity<T, DekaSiemen> val) where T:IConvertible {
        return new Quantity<double, YottaSiemen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaSiemen to ZettaSiemen
    /// </summary>
    /// <param name="val">quantity measured in DekaSiemen</param>
    /// <returns>quantity measured in ZettaSiemen</returns>
	public static Quantity<double, ZettaSiemen> ToZettaSiemen<T>(this Quantity<T, DekaSiemen> val) where T:IConvertible {
        return new Quantity<double, ZettaSiemen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaSiemen to ExaSiemen
    /// </summary>
    /// <param name="val">quantity measured in DekaSiemen</param>
    /// <returns>quantity measured in ExaSiemen</returns>
	public static Quantity<double, ExaSiemen> ToExaSiemen<T>(this Quantity<T, DekaSiemen> val) where T:IConvertible {
        return new Quantity<double, ExaSiemen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaSiemen to PetaSiemen
    /// </summary>
    /// <param name="val">quantity measured in DekaSiemen</param>
    /// <returns>quantity measured in PetaSiemen</returns>
	public static Quantity<double, PetaSiemen> ToPetaSiemen<T>(this Quantity<T, DekaSiemen> val) where T:IConvertible {
        return new Quantity<double, PetaSiemen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaSiemen to TeraSiemen
    /// </summary>
    /// <param name="val">quantity measured in DekaSiemen</param>
    /// <returns>quantity measured in TeraSiemen</returns>
	public static Quantity<double, TeraSiemen> ToTeraSiemen<T>(this Quantity<T, DekaSiemen> val) where T:IConvertible {
        return new Quantity<double, TeraSiemen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaSiemen to GigaSiemen
    /// </summary>
    /// <param name="val">quantity measured in DekaSiemen</param>
    /// <returns>quantity measured in GigaSiemen</returns>
	public static Quantity<double, GigaSiemen> ToGigaSiemen<T>(this Quantity<T, DekaSiemen> val) where T:IConvertible {
        return new Quantity<double, GigaSiemen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaSiemen to MegaSiemen
    /// </summary>
    /// <param name="val">quantity measured in DekaSiemen</param>
    /// <returns>quantity measured in MegaSiemen</returns>
	public static Quantity<double, MegaSiemen> ToMegaSiemen<T>(this Quantity<T, DekaSiemen> val) where T:IConvertible {
        return new Quantity<double, MegaSiemen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaSiemen to KiloSiemen
    /// </summary>
    /// <param name="val">quantity measured in DekaSiemen</param>
    /// <returns>quantity measured in KiloSiemen</returns>
	public static Quantity<double, KiloSiemen> ToKiloSiemen<T>(this Quantity<T, DekaSiemen> val) where T:IConvertible {
        return new Quantity<double, KiloSiemen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaSiemen to HectoSiemen
    /// </summary>
    /// <param name="val">quantity measured in DekaSiemen</param>
    /// <returns>quantity measured in HectoSiemen</returns>
	public static Quantity<double, HectoSiemen> ToHectoSiemen<T>(this Quantity<T, DekaSiemen> val) where T:IConvertible {
        return new Quantity<double, HectoSiemen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaSiemen to DeciSiemen
    /// </summary>
    /// <param name="val">quantity measured in DekaSiemen</param>
    /// <returns>quantity measured in DeciSiemen</returns>
	public static Quantity<double, DeciSiemen> ToDeciSiemen<T>(this Quantity<T, DekaSiemen> val) where T:IConvertible {
        return new Quantity<double, DeciSiemen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaSiemen to CentiSiemen
    /// </summary>
    /// <param name="val">quantity measured in DekaSiemen</param>
    /// <returns>quantity measured in CentiSiemen</returns>
	public static Quantity<double, CentiSiemen> ToCentiSiemen<T>(this Quantity<T, DekaSiemen> val) where T:IConvertible {
        return new Quantity<double, CentiSiemen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaSiemen to MilliSiemen
    /// </summary>
    /// <param name="val">quantity measured in DekaSiemen</param>
    /// <returns>quantity measured in MilliSiemen</returns>
	public static Quantity<double, MilliSiemen> ToMilliSiemen<T>(this Quantity<T, DekaSiemen> val) where T:IConvertible {
        return new Quantity<double, MilliSiemen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaSiemen to MicroSiemen
    /// </summary>
    /// <param name="val">quantity measured in DekaSiemen</param>
    /// <returns>quantity measured in MicroSiemen</returns>
	public static Quantity<double, MicroSiemen> ToMicroSiemen<T>(this Quantity<T, DekaSiemen> val) where T:IConvertible {
        return new Quantity<double, MicroSiemen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaSiemen to NanoSiemen
    /// </summary>
    /// <param name="val">quantity measured in DekaSiemen</param>
    /// <returns>quantity measured in NanoSiemen</returns>
	public static Quantity<double, NanoSiemen> ToNanoSiemen<T>(this Quantity<T, DekaSiemen> val) where T:IConvertible {
        return new Quantity<double, NanoSiemen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaSiemen to PicoSiemen
    /// </summary>
    /// <param name="val">quantity measured in DekaSiemen</param>
    /// <returns>quantity measured in PicoSiemen</returns>
	public static Quantity<double, PicoSiemen> ToPicoSiemen<T>(this Quantity<T, DekaSiemen> val) where T:IConvertible {
        return new Quantity<double, PicoSiemen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaSiemen to FemtoSiemen
    /// </summary>
    /// <param name="val">quantity measured in DekaSiemen</param>
    /// <returns>quantity measured in FemtoSiemen</returns>
	public static Quantity<double, FemtoSiemen> ToFemtoSiemen<T>(this Quantity<T, DekaSiemen> val) where T:IConvertible {
        return new Quantity<double, FemtoSiemen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaSiemen to AttoSiemen
    /// </summary>
    /// <param name="val">quantity measured in DekaSiemen</param>
    /// <returns>quantity measured in AttoSiemen</returns>
	public static Quantity<double, AttoSiemen> ToAttoSiemen<T>(this Quantity<T, DekaSiemen> val) where T:IConvertible {
        return new Quantity<double, AttoSiemen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaSiemen to ZeptoSiemen
    /// </summary>
    /// <param name="val">quantity measured in DekaSiemen</param>
    /// <returns>quantity measured in ZeptoSiemen</returns>
	public static Quantity<double, ZeptoSiemen> ToZeptoSiemen<T>(this Quantity<T, DekaSiemen> val) where T:IConvertible {
        return new Quantity<double, ZeptoSiemen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaSiemen to YoctoSiemen
    /// </summary>
    /// <param name="val">quantity measured in DekaSiemen</param>
    /// <returns>quantity measured in YoctoSiemen</returns>
	public static Quantity<double, YoctoSiemen> ToYoctoSiemen<T>(this Quantity<T, DekaSiemen> val) where T:IConvertible {
        return new Quantity<double, YoctoSiemen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DeciSiemen to YottaSiemen
    /// </summary>
    /// <param name="val">quantity measured in DeciSiemen</param>
    /// <returns>quantity measured in YottaSiemen</returns>
	public static Quantity<double, YottaSiemen> ToYottaSiemen<T>(this Quantity<T, DeciSiemen> val) where T:IConvertible {
        return new Quantity<double, YottaSiemen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciSiemen to ZettaSiemen
    /// </summary>
    /// <param name="val">quantity measured in DeciSiemen</param>
    /// <returns>quantity measured in ZettaSiemen</returns>
	public static Quantity<double, ZettaSiemen> ToZettaSiemen<T>(this Quantity<T, DeciSiemen> val) where T:IConvertible {
        return new Quantity<double, ZettaSiemen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciSiemen to ExaSiemen
    /// </summary>
    /// <param name="val">quantity measured in DeciSiemen</param>
    /// <returns>quantity measured in ExaSiemen</returns>
	public static Quantity<double, ExaSiemen> ToExaSiemen<T>(this Quantity<T, DeciSiemen> val) where T:IConvertible {
        return new Quantity<double, ExaSiemen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciSiemen to PetaSiemen
    /// </summary>
    /// <param name="val">quantity measured in DeciSiemen</param>
    /// <returns>quantity measured in PetaSiemen</returns>
	public static Quantity<double, PetaSiemen> ToPetaSiemen<T>(this Quantity<T, DeciSiemen> val) where T:IConvertible {
        return new Quantity<double, PetaSiemen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciSiemen to TeraSiemen
    /// </summary>
    /// <param name="val">quantity measured in DeciSiemen</param>
    /// <returns>quantity measured in TeraSiemen</returns>
	public static Quantity<double, TeraSiemen> ToTeraSiemen<T>(this Quantity<T, DeciSiemen> val) where T:IConvertible {
        return new Quantity<double, TeraSiemen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciSiemen to GigaSiemen
    /// </summary>
    /// <param name="val">quantity measured in DeciSiemen</param>
    /// <returns>quantity measured in GigaSiemen</returns>
	public static Quantity<double, GigaSiemen> ToGigaSiemen<T>(this Quantity<T, DeciSiemen> val) where T:IConvertible {
        return new Quantity<double, GigaSiemen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciSiemen to MegaSiemen
    /// </summary>
    /// <param name="val">quantity measured in DeciSiemen</param>
    /// <returns>quantity measured in MegaSiemen</returns>
	public static Quantity<double, MegaSiemen> ToMegaSiemen<T>(this Quantity<T, DeciSiemen> val) where T:IConvertible {
        return new Quantity<double, MegaSiemen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciSiemen to KiloSiemen
    /// </summary>
    /// <param name="val">quantity measured in DeciSiemen</param>
    /// <returns>quantity measured in KiloSiemen</returns>
	public static Quantity<double, KiloSiemen> ToKiloSiemen<T>(this Quantity<T, DeciSiemen> val) where T:IConvertible {
        return new Quantity<double, KiloSiemen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciSiemen to HectoSiemen
    /// </summary>
    /// <param name="val">quantity measured in DeciSiemen</param>
    /// <returns>quantity measured in HectoSiemen</returns>
	public static Quantity<double, HectoSiemen> ToHectoSiemen<T>(this Quantity<T, DeciSiemen> val) where T:IConvertible {
        return new Quantity<double, HectoSiemen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciSiemen to DekaSiemen
    /// </summary>
    /// <param name="val">quantity measured in DeciSiemen</param>
    /// <returns>quantity measured in DekaSiemen</returns>
	public static Quantity<double, DekaSiemen> ToDekaSiemen<T>(this Quantity<T, DeciSiemen> val) where T:IConvertible {
        return new Quantity<double, DekaSiemen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciSiemen to CentiSiemen
    /// </summary>
    /// <param name="val">quantity measured in DeciSiemen</param>
    /// <returns>quantity measured in CentiSiemen</returns>
	public static Quantity<double, CentiSiemen> ToCentiSiemen<T>(this Quantity<T, DeciSiemen> val) where T:IConvertible {
        return new Quantity<double, CentiSiemen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciSiemen to MilliSiemen
    /// </summary>
    /// <param name="val">quantity measured in DeciSiemen</param>
    /// <returns>quantity measured in MilliSiemen</returns>
	public static Quantity<double, MilliSiemen> ToMilliSiemen<T>(this Quantity<T, DeciSiemen> val) where T:IConvertible {
        return new Quantity<double, MilliSiemen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciSiemen to MicroSiemen
    /// </summary>
    /// <param name="val">quantity measured in DeciSiemen</param>
    /// <returns>quantity measured in MicroSiemen</returns>
	public static Quantity<double, MicroSiemen> ToMicroSiemen<T>(this Quantity<T, DeciSiemen> val) where T:IConvertible {
        return new Quantity<double, MicroSiemen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciSiemen to NanoSiemen
    /// </summary>
    /// <param name="val">quantity measured in DeciSiemen</param>
    /// <returns>quantity measured in NanoSiemen</returns>
	public static Quantity<double, NanoSiemen> ToNanoSiemen<T>(this Quantity<T, DeciSiemen> val) where T:IConvertible {
        return new Quantity<double, NanoSiemen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciSiemen to PicoSiemen
    /// </summary>
    /// <param name="val">quantity measured in DeciSiemen</param>
    /// <returns>quantity measured in PicoSiemen</returns>
	public static Quantity<double, PicoSiemen> ToPicoSiemen<T>(this Quantity<T, DeciSiemen> val) where T:IConvertible {
        return new Quantity<double, PicoSiemen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciSiemen to FemtoSiemen
    /// </summary>
    /// <param name="val">quantity measured in DeciSiemen</param>
    /// <returns>quantity measured in FemtoSiemen</returns>
	public static Quantity<double, FemtoSiemen> ToFemtoSiemen<T>(this Quantity<T, DeciSiemen> val) where T:IConvertible {
        return new Quantity<double, FemtoSiemen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciSiemen to AttoSiemen
    /// </summary>
    /// <param name="val">quantity measured in DeciSiemen</param>
    /// <returns>quantity measured in AttoSiemen</returns>
	public static Quantity<double, AttoSiemen> ToAttoSiemen<T>(this Quantity<T, DeciSiemen> val) where T:IConvertible {
        return new Quantity<double, AttoSiemen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciSiemen to ZeptoSiemen
    /// </summary>
    /// <param name="val">quantity measured in DeciSiemen</param>
    /// <returns>quantity measured in ZeptoSiemen</returns>
	public static Quantity<double, ZeptoSiemen> ToZeptoSiemen<T>(this Quantity<T, DeciSiemen> val) where T:IConvertible {
        return new Quantity<double, ZeptoSiemen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciSiemen to YoctoSiemen
    /// </summary>
    /// <param name="val">quantity measured in DeciSiemen</param>
    /// <returns>quantity measured in YoctoSiemen</returns>
	public static Quantity<double, YoctoSiemen> ToYoctoSiemen<T>(this Quantity<T, DeciSiemen> val) where T:IConvertible {
        return new Quantity<double, YoctoSiemen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert CentiSiemen to YottaSiemen
    /// </summary>
    /// <param name="val">quantity measured in CentiSiemen</param>
    /// <returns>quantity measured in YottaSiemen</returns>
	public static Quantity<double, YottaSiemen> ToYottaSiemen<T>(this Quantity<T, CentiSiemen> val) where T:IConvertible {
        return new Quantity<double, YottaSiemen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiSiemen to ZettaSiemen
    /// </summary>
    /// <param name="val">quantity measured in CentiSiemen</param>
    /// <returns>quantity measured in ZettaSiemen</returns>
	public static Quantity<double, ZettaSiemen> ToZettaSiemen<T>(this Quantity<T, CentiSiemen> val) where T:IConvertible {
        return new Quantity<double, ZettaSiemen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiSiemen to ExaSiemen
    /// </summary>
    /// <param name="val">quantity measured in CentiSiemen</param>
    /// <returns>quantity measured in ExaSiemen</returns>
	public static Quantity<double, ExaSiemen> ToExaSiemen<T>(this Quantity<T, CentiSiemen> val) where T:IConvertible {
        return new Quantity<double, ExaSiemen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiSiemen to PetaSiemen
    /// </summary>
    /// <param name="val">quantity measured in CentiSiemen</param>
    /// <returns>quantity measured in PetaSiemen</returns>
	public static Quantity<double, PetaSiemen> ToPetaSiemen<T>(this Quantity<T, CentiSiemen> val) where T:IConvertible {
        return new Quantity<double, PetaSiemen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiSiemen to TeraSiemen
    /// </summary>
    /// <param name="val">quantity measured in CentiSiemen</param>
    /// <returns>quantity measured in TeraSiemen</returns>
	public static Quantity<double, TeraSiemen> ToTeraSiemen<T>(this Quantity<T, CentiSiemen> val) where T:IConvertible {
        return new Quantity<double, TeraSiemen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiSiemen to GigaSiemen
    /// </summary>
    /// <param name="val">quantity measured in CentiSiemen</param>
    /// <returns>quantity measured in GigaSiemen</returns>
	public static Quantity<double, GigaSiemen> ToGigaSiemen<T>(this Quantity<T, CentiSiemen> val) where T:IConvertible {
        return new Quantity<double, GigaSiemen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiSiemen to MegaSiemen
    /// </summary>
    /// <param name="val">quantity measured in CentiSiemen</param>
    /// <returns>quantity measured in MegaSiemen</returns>
	public static Quantity<double, MegaSiemen> ToMegaSiemen<T>(this Quantity<T, CentiSiemen> val) where T:IConvertible {
        return new Quantity<double, MegaSiemen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiSiemen to KiloSiemen
    /// </summary>
    /// <param name="val">quantity measured in CentiSiemen</param>
    /// <returns>quantity measured in KiloSiemen</returns>
	public static Quantity<double, KiloSiemen> ToKiloSiemen<T>(this Quantity<T, CentiSiemen> val) where T:IConvertible {
        return new Quantity<double, KiloSiemen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiSiemen to HectoSiemen
    /// </summary>
    /// <param name="val">quantity measured in CentiSiemen</param>
    /// <returns>quantity measured in HectoSiemen</returns>
	public static Quantity<double, HectoSiemen> ToHectoSiemen<T>(this Quantity<T, CentiSiemen> val) where T:IConvertible {
        return new Quantity<double, HectoSiemen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiSiemen to DekaSiemen
    /// </summary>
    /// <param name="val">quantity measured in CentiSiemen</param>
    /// <returns>quantity measured in DekaSiemen</returns>
	public static Quantity<double, DekaSiemen> ToDekaSiemen<T>(this Quantity<T, CentiSiemen> val) where T:IConvertible {
        return new Quantity<double, DekaSiemen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiSiemen to DeciSiemen
    /// </summary>
    /// <param name="val">quantity measured in CentiSiemen</param>
    /// <returns>quantity measured in DeciSiemen</returns>
	public static Quantity<double, DeciSiemen> ToDeciSiemen<T>(this Quantity<T, CentiSiemen> val) where T:IConvertible {
        return new Quantity<double, DeciSiemen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiSiemen to MilliSiemen
    /// </summary>
    /// <param name="val">quantity measured in CentiSiemen</param>
    /// <returns>quantity measured in MilliSiemen</returns>
	public static Quantity<double, MilliSiemen> ToMilliSiemen<T>(this Quantity<T, CentiSiemen> val) where T:IConvertible {
        return new Quantity<double, MilliSiemen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiSiemen to MicroSiemen
    /// </summary>
    /// <param name="val">quantity measured in CentiSiemen</param>
    /// <returns>quantity measured in MicroSiemen</returns>
	public static Quantity<double, MicroSiemen> ToMicroSiemen<T>(this Quantity<T, CentiSiemen> val) where T:IConvertible {
        return new Quantity<double, MicroSiemen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiSiemen to NanoSiemen
    /// </summary>
    /// <param name="val">quantity measured in CentiSiemen</param>
    /// <returns>quantity measured in NanoSiemen</returns>
	public static Quantity<double, NanoSiemen> ToNanoSiemen<T>(this Quantity<T, CentiSiemen> val) where T:IConvertible {
        return new Quantity<double, NanoSiemen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiSiemen to PicoSiemen
    /// </summary>
    /// <param name="val">quantity measured in CentiSiemen</param>
    /// <returns>quantity measured in PicoSiemen</returns>
	public static Quantity<double, PicoSiemen> ToPicoSiemen<T>(this Quantity<T, CentiSiemen> val) where T:IConvertible {
        return new Quantity<double, PicoSiemen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiSiemen to FemtoSiemen
    /// </summary>
    /// <param name="val">quantity measured in CentiSiemen</param>
    /// <returns>quantity measured in FemtoSiemen</returns>
	public static Quantity<double, FemtoSiemen> ToFemtoSiemen<T>(this Quantity<T, CentiSiemen> val) where T:IConvertible {
        return new Quantity<double, FemtoSiemen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiSiemen to AttoSiemen
    /// </summary>
    /// <param name="val">quantity measured in CentiSiemen</param>
    /// <returns>quantity measured in AttoSiemen</returns>
	public static Quantity<double, AttoSiemen> ToAttoSiemen<T>(this Quantity<T, CentiSiemen> val) where T:IConvertible {
        return new Quantity<double, AttoSiemen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiSiemen to ZeptoSiemen
    /// </summary>
    /// <param name="val">quantity measured in CentiSiemen</param>
    /// <returns>quantity measured in ZeptoSiemen</returns>
	public static Quantity<double, ZeptoSiemen> ToZeptoSiemen<T>(this Quantity<T, CentiSiemen> val) where T:IConvertible {
        return new Quantity<double, ZeptoSiemen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiSiemen to YoctoSiemen
    /// </summary>
    /// <param name="val">quantity measured in CentiSiemen</param>
    /// <returns>quantity measured in YoctoSiemen</returns>
	public static Quantity<double, YoctoSiemen> ToYoctoSiemen<T>(this Quantity<T, CentiSiemen> val) where T:IConvertible {
        return new Quantity<double, YoctoSiemen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert MilliSiemen to YottaSiemen
    /// </summary>
    /// <param name="val">quantity measured in MilliSiemen</param>
    /// <returns>quantity measured in YottaSiemen</returns>
	public static Quantity<double, YottaSiemen> ToYottaSiemen<T>(this Quantity<T, MilliSiemen> val) where T:IConvertible {
        return new Quantity<double, YottaSiemen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliSiemen to ZettaSiemen
    /// </summary>
    /// <param name="val">quantity measured in MilliSiemen</param>
    /// <returns>quantity measured in ZettaSiemen</returns>
	public static Quantity<double, ZettaSiemen> ToZettaSiemen<T>(this Quantity<T, MilliSiemen> val) where T:IConvertible {
        return new Quantity<double, ZettaSiemen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliSiemen to ExaSiemen
    /// </summary>
    /// <param name="val">quantity measured in MilliSiemen</param>
    /// <returns>quantity measured in ExaSiemen</returns>
	public static Quantity<double, ExaSiemen> ToExaSiemen<T>(this Quantity<T, MilliSiemen> val) where T:IConvertible {
        return new Quantity<double, ExaSiemen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliSiemen to PetaSiemen
    /// </summary>
    /// <param name="val">quantity measured in MilliSiemen</param>
    /// <returns>quantity measured in PetaSiemen</returns>
	public static Quantity<double, PetaSiemen> ToPetaSiemen<T>(this Quantity<T, MilliSiemen> val) where T:IConvertible {
        return new Quantity<double, PetaSiemen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliSiemen to TeraSiemen
    /// </summary>
    /// <param name="val">quantity measured in MilliSiemen</param>
    /// <returns>quantity measured in TeraSiemen</returns>
	public static Quantity<double, TeraSiemen> ToTeraSiemen<T>(this Quantity<T, MilliSiemen> val) where T:IConvertible {
        return new Quantity<double, TeraSiemen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliSiemen to GigaSiemen
    /// </summary>
    /// <param name="val">quantity measured in MilliSiemen</param>
    /// <returns>quantity measured in GigaSiemen</returns>
	public static Quantity<double, GigaSiemen> ToGigaSiemen<T>(this Quantity<T, MilliSiemen> val) where T:IConvertible {
        return new Quantity<double, GigaSiemen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliSiemen to MegaSiemen
    /// </summary>
    /// <param name="val">quantity measured in MilliSiemen</param>
    /// <returns>quantity measured in MegaSiemen</returns>
	public static Quantity<double, MegaSiemen> ToMegaSiemen<T>(this Quantity<T, MilliSiemen> val) where T:IConvertible {
        return new Quantity<double, MegaSiemen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliSiemen to KiloSiemen
    /// </summary>
    /// <param name="val">quantity measured in MilliSiemen</param>
    /// <returns>quantity measured in KiloSiemen</returns>
	public static Quantity<double, KiloSiemen> ToKiloSiemen<T>(this Quantity<T, MilliSiemen> val) where T:IConvertible {
        return new Quantity<double, KiloSiemen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliSiemen to HectoSiemen
    /// </summary>
    /// <param name="val">quantity measured in MilliSiemen</param>
    /// <returns>quantity measured in HectoSiemen</returns>
	public static Quantity<double, HectoSiemen> ToHectoSiemen<T>(this Quantity<T, MilliSiemen> val) where T:IConvertible {
        return new Quantity<double, HectoSiemen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliSiemen to DekaSiemen
    /// </summary>
    /// <param name="val">quantity measured in MilliSiemen</param>
    /// <returns>quantity measured in DekaSiemen</returns>
	public static Quantity<double, DekaSiemen> ToDekaSiemen<T>(this Quantity<T, MilliSiemen> val) where T:IConvertible {
        return new Quantity<double, DekaSiemen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliSiemen to DeciSiemen
    /// </summary>
    /// <param name="val">quantity measured in MilliSiemen</param>
    /// <returns>quantity measured in DeciSiemen</returns>
	public static Quantity<double, DeciSiemen> ToDeciSiemen<T>(this Quantity<T, MilliSiemen> val) where T:IConvertible {
        return new Quantity<double, DeciSiemen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliSiemen to CentiSiemen
    /// </summary>
    /// <param name="val">quantity measured in MilliSiemen</param>
    /// <returns>quantity measured in CentiSiemen</returns>
	public static Quantity<double, CentiSiemen> ToCentiSiemen<T>(this Quantity<T, MilliSiemen> val) where T:IConvertible {
        return new Quantity<double, CentiSiemen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliSiemen to MicroSiemen
    /// </summary>
    /// <param name="val">quantity measured in MilliSiemen</param>
    /// <returns>quantity measured in MicroSiemen</returns>
	public static Quantity<double, MicroSiemen> ToMicroSiemen<T>(this Quantity<T, MilliSiemen> val) where T:IConvertible {
        return new Quantity<double, MicroSiemen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliSiemen to NanoSiemen
    /// </summary>
    /// <param name="val">quantity measured in MilliSiemen</param>
    /// <returns>quantity measured in NanoSiemen</returns>
	public static Quantity<double, NanoSiemen> ToNanoSiemen<T>(this Quantity<T, MilliSiemen> val) where T:IConvertible {
        return new Quantity<double, NanoSiemen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliSiemen to PicoSiemen
    /// </summary>
    /// <param name="val">quantity measured in MilliSiemen</param>
    /// <returns>quantity measured in PicoSiemen</returns>
	public static Quantity<double, PicoSiemen> ToPicoSiemen<T>(this Quantity<T, MilliSiemen> val) where T:IConvertible {
        return new Quantity<double, PicoSiemen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliSiemen to FemtoSiemen
    /// </summary>
    /// <param name="val">quantity measured in MilliSiemen</param>
    /// <returns>quantity measured in FemtoSiemen</returns>
	public static Quantity<double, FemtoSiemen> ToFemtoSiemen<T>(this Quantity<T, MilliSiemen> val) where T:IConvertible {
        return new Quantity<double, FemtoSiemen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliSiemen to AttoSiemen
    /// </summary>
    /// <param name="val">quantity measured in MilliSiemen</param>
    /// <returns>quantity measured in AttoSiemen</returns>
	public static Quantity<double, AttoSiemen> ToAttoSiemen<T>(this Quantity<T, MilliSiemen> val) where T:IConvertible {
        return new Quantity<double, AttoSiemen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliSiemen to ZeptoSiemen
    /// </summary>
    /// <param name="val">quantity measured in MilliSiemen</param>
    /// <returns>quantity measured in ZeptoSiemen</returns>
	public static Quantity<double, ZeptoSiemen> ToZeptoSiemen<T>(this Quantity<T, MilliSiemen> val) where T:IConvertible {
        return new Quantity<double, ZeptoSiemen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliSiemen to YoctoSiemen
    /// </summary>
    /// <param name="val">quantity measured in MilliSiemen</param>
    /// <returns>quantity measured in YoctoSiemen</returns>
	public static Quantity<double, YoctoSiemen> ToYoctoSiemen<T>(this Quantity<T, MilliSiemen> val) where T:IConvertible {
        return new Quantity<double, YoctoSiemen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MicroSiemen to YottaSiemen
    /// </summary>
    /// <param name="val">quantity measured in MicroSiemen</param>
    /// <returns>quantity measured in YottaSiemen</returns>
	public static Quantity<double, YottaSiemen> ToYottaSiemen<T>(this Quantity<T, MicroSiemen> val) where T:IConvertible {
        return new Quantity<double, YottaSiemen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroSiemen to ZettaSiemen
    /// </summary>
    /// <param name="val">quantity measured in MicroSiemen</param>
    /// <returns>quantity measured in ZettaSiemen</returns>
	public static Quantity<double, ZettaSiemen> ToZettaSiemen<T>(this Quantity<T, MicroSiemen> val) where T:IConvertible {
        return new Quantity<double, ZettaSiemen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroSiemen to ExaSiemen
    /// </summary>
    /// <param name="val">quantity measured in MicroSiemen</param>
    /// <returns>quantity measured in ExaSiemen</returns>
	public static Quantity<double, ExaSiemen> ToExaSiemen<T>(this Quantity<T, MicroSiemen> val) where T:IConvertible {
        return new Quantity<double, ExaSiemen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroSiemen to PetaSiemen
    /// </summary>
    /// <param name="val">quantity measured in MicroSiemen</param>
    /// <returns>quantity measured in PetaSiemen</returns>
	public static Quantity<double, PetaSiemen> ToPetaSiemen<T>(this Quantity<T, MicroSiemen> val) where T:IConvertible {
        return new Quantity<double, PetaSiemen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroSiemen to TeraSiemen
    /// </summary>
    /// <param name="val">quantity measured in MicroSiemen</param>
    /// <returns>quantity measured in TeraSiemen</returns>
	public static Quantity<double, TeraSiemen> ToTeraSiemen<T>(this Quantity<T, MicroSiemen> val) where T:IConvertible {
        return new Quantity<double, TeraSiemen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroSiemen to GigaSiemen
    /// </summary>
    /// <param name="val">quantity measured in MicroSiemen</param>
    /// <returns>quantity measured in GigaSiemen</returns>
	public static Quantity<double, GigaSiemen> ToGigaSiemen<T>(this Quantity<T, MicroSiemen> val) where T:IConvertible {
        return new Quantity<double, GigaSiemen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroSiemen to MegaSiemen
    /// </summary>
    /// <param name="val">quantity measured in MicroSiemen</param>
    /// <returns>quantity measured in MegaSiemen</returns>
	public static Quantity<double, MegaSiemen> ToMegaSiemen<T>(this Quantity<T, MicroSiemen> val) where T:IConvertible {
        return new Quantity<double, MegaSiemen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroSiemen to KiloSiemen
    /// </summary>
    /// <param name="val">quantity measured in MicroSiemen</param>
    /// <returns>quantity measured in KiloSiemen</returns>
	public static Quantity<double, KiloSiemen> ToKiloSiemen<T>(this Quantity<T, MicroSiemen> val) where T:IConvertible {
        return new Quantity<double, KiloSiemen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroSiemen to HectoSiemen
    /// </summary>
    /// <param name="val">quantity measured in MicroSiemen</param>
    /// <returns>quantity measured in HectoSiemen</returns>
	public static Quantity<double, HectoSiemen> ToHectoSiemen<T>(this Quantity<T, MicroSiemen> val) where T:IConvertible {
        return new Quantity<double, HectoSiemen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroSiemen to DekaSiemen
    /// </summary>
    /// <param name="val">quantity measured in MicroSiemen</param>
    /// <returns>quantity measured in DekaSiemen</returns>
	public static Quantity<double, DekaSiemen> ToDekaSiemen<T>(this Quantity<T, MicroSiemen> val) where T:IConvertible {
        return new Quantity<double, DekaSiemen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroSiemen to DeciSiemen
    /// </summary>
    /// <param name="val">quantity measured in MicroSiemen</param>
    /// <returns>quantity measured in DeciSiemen</returns>
	public static Quantity<double, DeciSiemen> ToDeciSiemen<T>(this Quantity<T, MicroSiemen> val) where T:IConvertible {
        return new Quantity<double, DeciSiemen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroSiemen to CentiSiemen
    /// </summary>
    /// <param name="val">quantity measured in MicroSiemen</param>
    /// <returns>quantity measured in CentiSiemen</returns>
	public static Quantity<double, CentiSiemen> ToCentiSiemen<T>(this Quantity<T, MicroSiemen> val) where T:IConvertible {
        return new Quantity<double, CentiSiemen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroSiemen to MilliSiemen
    /// </summary>
    /// <param name="val">quantity measured in MicroSiemen</param>
    /// <returns>quantity measured in MilliSiemen</returns>
	public static Quantity<double, MilliSiemen> ToMilliSiemen<T>(this Quantity<T, MicroSiemen> val) where T:IConvertible {
        return new Quantity<double, MilliSiemen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroSiemen to NanoSiemen
    /// </summary>
    /// <param name="val">quantity measured in MicroSiemen</param>
    /// <returns>quantity measured in NanoSiemen</returns>
	public static Quantity<double, NanoSiemen> ToNanoSiemen<T>(this Quantity<T, MicroSiemen> val) where T:IConvertible {
        return new Quantity<double, NanoSiemen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroSiemen to PicoSiemen
    /// </summary>
    /// <param name="val">quantity measured in MicroSiemen</param>
    /// <returns>quantity measured in PicoSiemen</returns>
	public static Quantity<double, PicoSiemen> ToPicoSiemen<T>(this Quantity<T, MicroSiemen> val) where T:IConvertible {
        return new Quantity<double, PicoSiemen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroSiemen to FemtoSiemen
    /// </summary>
    /// <param name="val">quantity measured in MicroSiemen</param>
    /// <returns>quantity measured in FemtoSiemen</returns>
	public static Quantity<double, FemtoSiemen> ToFemtoSiemen<T>(this Quantity<T, MicroSiemen> val) where T:IConvertible {
        return new Quantity<double, FemtoSiemen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroSiemen to AttoSiemen
    /// </summary>
    /// <param name="val">quantity measured in MicroSiemen</param>
    /// <returns>quantity measured in AttoSiemen</returns>
	public static Quantity<double, AttoSiemen> ToAttoSiemen<T>(this Quantity<T, MicroSiemen> val) where T:IConvertible {
        return new Quantity<double, AttoSiemen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroSiemen to ZeptoSiemen
    /// </summary>
    /// <param name="val">quantity measured in MicroSiemen</param>
    /// <returns>quantity measured in ZeptoSiemen</returns>
	public static Quantity<double, ZeptoSiemen> ToZeptoSiemen<T>(this Quantity<T, MicroSiemen> val) where T:IConvertible {
        return new Quantity<double, ZeptoSiemen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroSiemen to YoctoSiemen
    /// </summary>
    /// <param name="val">quantity measured in MicroSiemen</param>
    /// <returns>quantity measured in YoctoSiemen</returns>
	public static Quantity<double, YoctoSiemen> ToYoctoSiemen<T>(this Quantity<T, MicroSiemen> val) where T:IConvertible {
        return new Quantity<double, YoctoSiemen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert NanoSiemen to YottaSiemen
    /// </summary>
    /// <param name="val">quantity measured in NanoSiemen</param>
    /// <returns>quantity measured in YottaSiemen</returns>
	public static Quantity<double, YottaSiemen> ToYottaSiemen<T>(this Quantity<T, NanoSiemen> val) where T:IConvertible {
        return new Quantity<double, YottaSiemen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoSiemen to ZettaSiemen
    /// </summary>
    /// <param name="val">quantity measured in NanoSiemen</param>
    /// <returns>quantity measured in ZettaSiemen</returns>
	public static Quantity<double, ZettaSiemen> ToZettaSiemen<T>(this Quantity<T, NanoSiemen> val) where T:IConvertible {
        return new Quantity<double, ZettaSiemen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoSiemen to ExaSiemen
    /// </summary>
    /// <param name="val">quantity measured in NanoSiemen</param>
    /// <returns>quantity measured in ExaSiemen</returns>
	public static Quantity<double, ExaSiemen> ToExaSiemen<T>(this Quantity<T, NanoSiemen> val) where T:IConvertible {
        return new Quantity<double, ExaSiemen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoSiemen to PetaSiemen
    /// </summary>
    /// <param name="val">quantity measured in NanoSiemen</param>
    /// <returns>quantity measured in PetaSiemen</returns>
	public static Quantity<double, PetaSiemen> ToPetaSiemen<T>(this Quantity<T, NanoSiemen> val) where T:IConvertible {
        return new Quantity<double, PetaSiemen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoSiemen to TeraSiemen
    /// </summary>
    /// <param name="val">quantity measured in NanoSiemen</param>
    /// <returns>quantity measured in TeraSiemen</returns>
	public static Quantity<double, TeraSiemen> ToTeraSiemen<T>(this Quantity<T, NanoSiemen> val) where T:IConvertible {
        return new Quantity<double, TeraSiemen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoSiemen to GigaSiemen
    /// </summary>
    /// <param name="val">quantity measured in NanoSiemen</param>
    /// <returns>quantity measured in GigaSiemen</returns>
	public static Quantity<double, GigaSiemen> ToGigaSiemen<T>(this Quantity<T, NanoSiemen> val) where T:IConvertible {
        return new Quantity<double, GigaSiemen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoSiemen to MegaSiemen
    /// </summary>
    /// <param name="val">quantity measured in NanoSiemen</param>
    /// <returns>quantity measured in MegaSiemen</returns>
	public static Quantity<double, MegaSiemen> ToMegaSiemen<T>(this Quantity<T, NanoSiemen> val) where T:IConvertible {
        return new Quantity<double, MegaSiemen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoSiemen to KiloSiemen
    /// </summary>
    /// <param name="val">quantity measured in NanoSiemen</param>
    /// <returns>quantity measured in KiloSiemen</returns>
	public static Quantity<double, KiloSiemen> ToKiloSiemen<T>(this Quantity<T, NanoSiemen> val) where T:IConvertible {
        return new Quantity<double, KiloSiemen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoSiemen to HectoSiemen
    /// </summary>
    /// <param name="val">quantity measured in NanoSiemen</param>
    /// <returns>quantity measured in HectoSiemen</returns>
	public static Quantity<double, HectoSiemen> ToHectoSiemen<T>(this Quantity<T, NanoSiemen> val) where T:IConvertible {
        return new Quantity<double, HectoSiemen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoSiemen to DekaSiemen
    /// </summary>
    /// <param name="val">quantity measured in NanoSiemen</param>
    /// <returns>quantity measured in DekaSiemen</returns>
	public static Quantity<double, DekaSiemen> ToDekaSiemen<T>(this Quantity<T, NanoSiemen> val) where T:IConvertible {
        return new Quantity<double, DekaSiemen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoSiemen to DeciSiemen
    /// </summary>
    /// <param name="val">quantity measured in NanoSiemen</param>
    /// <returns>quantity measured in DeciSiemen</returns>
	public static Quantity<double, DeciSiemen> ToDeciSiemen<T>(this Quantity<T, NanoSiemen> val) where T:IConvertible {
        return new Quantity<double, DeciSiemen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoSiemen to CentiSiemen
    /// </summary>
    /// <param name="val">quantity measured in NanoSiemen</param>
    /// <returns>quantity measured in CentiSiemen</returns>
	public static Quantity<double, CentiSiemen> ToCentiSiemen<T>(this Quantity<T, NanoSiemen> val) where T:IConvertible {
        return new Quantity<double, CentiSiemen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoSiemen to MilliSiemen
    /// </summary>
    /// <param name="val">quantity measured in NanoSiemen</param>
    /// <returns>quantity measured in MilliSiemen</returns>
	public static Quantity<double, MilliSiemen> ToMilliSiemen<T>(this Quantity<T, NanoSiemen> val) where T:IConvertible {
        return new Quantity<double, MilliSiemen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoSiemen to MicroSiemen
    /// </summary>
    /// <param name="val">quantity measured in NanoSiemen</param>
    /// <returns>quantity measured in MicroSiemen</returns>
	public static Quantity<double, MicroSiemen> ToMicroSiemen<T>(this Quantity<T, NanoSiemen> val) where T:IConvertible {
        return new Quantity<double, MicroSiemen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoSiemen to PicoSiemen
    /// </summary>
    /// <param name="val">quantity measured in NanoSiemen</param>
    /// <returns>quantity measured in PicoSiemen</returns>
	public static Quantity<double, PicoSiemen> ToPicoSiemen<T>(this Quantity<T, NanoSiemen> val) where T:IConvertible {
        return new Quantity<double, PicoSiemen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoSiemen to FemtoSiemen
    /// </summary>
    /// <param name="val">quantity measured in NanoSiemen</param>
    /// <returns>quantity measured in FemtoSiemen</returns>
	public static Quantity<double, FemtoSiemen> ToFemtoSiemen<T>(this Quantity<T, NanoSiemen> val) where T:IConvertible {
        return new Quantity<double, FemtoSiemen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoSiemen to AttoSiemen
    /// </summary>
    /// <param name="val">quantity measured in NanoSiemen</param>
    /// <returns>quantity measured in AttoSiemen</returns>
	public static Quantity<double, AttoSiemen> ToAttoSiemen<T>(this Quantity<T, NanoSiemen> val) where T:IConvertible {
        return new Quantity<double, AttoSiemen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoSiemen to ZeptoSiemen
    /// </summary>
    /// <param name="val">quantity measured in NanoSiemen</param>
    /// <returns>quantity measured in ZeptoSiemen</returns>
	public static Quantity<double, ZeptoSiemen> ToZeptoSiemen<T>(this Quantity<T, NanoSiemen> val) where T:IConvertible {
        return new Quantity<double, ZeptoSiemen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoSiemen to YoctoSiemen
    /// </summary>
    /// <param name="val">quantity measured in NanoSiemen</param>
    /// <returns>quantity measured in YoctoSiemen</returns>
	public static Quantity<double, YoctoSiemen> ToYoctoSiemen<T>(this Quantity<T, NanoSiemen> val) where T:IConvertible {
        return new Quantity<double, YoctoSiemen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert PicoSiemen to YottaSiemen
    /// </summary>
    /// <param name="val">quantity measured in PicoSiemen</param>
    /// <returns>quantity measured in YottaSiemen</returns>
	public static Quantity<double, YottaSiemen> ToYottaSiemen<T>(this Quantity<T, PicoSiemen> val) where T:IConvertible {
        return new Quantity<double, YottaSiemen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoSiemen to ZettaSiemen
    /// </summary>
    /// <param name="val">quantity measured in PicoSiemen</param>
    /// <returns>quantity measured in ZettaSiemen</returns>
	public static Quantity<double, ZettaSiemen> ToZettaSiemen<T>(this Quantity<T, PicoSiemen> val) where T:IConvertible {
        return new Quantity<double, ZettaSiemen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoSiemen to ExaSiemen
    /// </summary>
    /// <param name="val">quantity measured in PicoSiemen</param>
    /// <returns>quantity measured in ExaSiemen</returns>
	public static Quantity<double, ExaSiemen> ToExaSiemen<T>(this Quantity<T, PicoSiemen> val) where T:IConvertible {
        return new Quantity<double, ExaSiemen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoSiemen to PetaSiemen
    /// </summary>
    /// <param name="val">quantity measured in PicoSiemen</param>
    /// <returns>quantity measured in PetaSiemen</returns>
	public static Quantity<double, PetaSiemen> ToPetaSiemen<T>(this Quantity<T, PicoSiemen> val) where T:IConvertible {
        return new Quantity<double, PetaSiemen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoSiemen to TeraSiemen
    /// </summary>
    /// <param name="val">quantity measured in PicoSiemen</param>
    /// <returns>quantity measured in TeraSiemen</returns>
	public static Quantity<double, TeraSiemen> ToTeraSiemen<T>(this Quantity<T, PicoSiemen> val) where T:IConvertible {
        return new Quantity<double, TeraSiemen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoSiemen to GigaSiemen
    /// </summary>
    /// <param name="val">quantity measured in PicoSiemen</param>
    /// <returns>quantity measured in GigaSiemen</returns>
	public static Quantity<double, GigaSiemen> ToGigaSiemen<T>(this Quantity<T, PicoSiemen> val) where T:IConvertible {
        return new Quantity<double, GigaSiemen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoSiemen to MegaSiemen
    /// </summary>
    /// <param name="val">quantity measured in PicoSiemen</param>
    /// <returns>quantity measured in MegaSiemen</returns>
	public static Quantity<double, MegaSiemen> ToMegaSiemen<T>(this Quantity<T, PicoSiemen> val) where T:IConvertible {
        return new Quantity<double, MegaSiemen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoSiemen to KiloSiemen
    /// </summary>
    /// <param name="val">quantity measured in PicoSiemen</param>
    /// <returns>quantity measured in KiloSiemen</returns>
	public static Quantity<double, KiloSiemen> ToKiloSiemen<T>(this Quantity<T, PicoSiemen> val) where T:IConvertible {
        return new Quantity<double, KiloSiemen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoSiemen to HectoSiemen
    /// </summary>
    /// <param name="val">quantity measured in PicoSiemen</param>
    /// <returns>quantity measured in HectoSiemen</returns>
	public static Quantity<double, HectoSiemen> ToHectoSiemen<T>(this Quantity<T, PicoSiemen> val) where T:IConvertible {
        return new Quantity<double, HectoSiemen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoSiemen to DekaSiemen
    /// </summary>
    /// <param name="val">quantity measured in PicoSiemen</param>
    /// <returns>quantity measured in DekaSiemen</returns>
	public static Quantity<double, DekaSiemen> ToDekaSiemen<T>(this Quantity<T, PicoSiemen> val) where T:IConvertible {
        return new Quantity<double, DekaSiemen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoSiemen to DeciSiemen
    /// </summary>
    /// <param name="val">quantity measured in PicoSiemen</param>
    /// <returns>quantity measured in DeciSiemen</returns>
	public static Quantity<double, DeciSiemen> ToDeciSiemen<T>(this Quantity<T, PicoSiemen> val) where T:IConvertible {
        return new Quantity<double, DeciSiemen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoSiemen to CentiSiemen
    /// </summary>
    /// <param name="val">quantity measured in PicoSiemen</param>
    /// <returns>quantity measured in CentiSiemen</returns>
	public static Quantity<double, CentiSiemen> ToCentiSiemen<T>(this Quantity<T, PicoSiemen> val) where T:IConvertible {
        return new Quantity<double, CentiSiemen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoSiemen to MilliSiemen
    /// </summary>
    /// <param name="val">quantity measured in PicoSiemen</param>
    /// <returns>quantity measured in MilliSiemen</returns>
	public static Quantity<double, MilliSiemen> ToMilliSiemen<T>(this Quantity<T, PicoSiemen> val) where T:IConvertible {
        return new Quantity<double, MilliSiemen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoSiemen to MicroSiemen
    /// </summary>
    /// <param name="val">quantity measured in PicoSiemen</param>
    /// <returns>quantity measured in MicroSiemen</returns>
	public static Quantity<double, MicroSiemen> ToMicroSiemen<T>(this Quantity<T, PicoSiemen> val) where T:IConvertible {
        return new Quantity<double, MicroSiemen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoSiemen to NanoSiemen
    /// </summary>
    /// <param name="val">quantity measured in PicoSiemen</param>
    /// <returns>quantity measured in NanoSiemen</returns>
	public static Quantity<double, NanoSiemen> ToNanoSiemen<T>(this Quantity<T, PicoSiemen> val) where T:IConvertible {
        return new Quantity<double, NanoSiemen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoSiemen to FemtoSiemen
    /// </summary>
    /// <param name="val">quantity measured in PicoSiemen</param>
    /// <returns>quantity measured in FemtoSiemen</returns>
	public static Quantity<double, FemtoSiemen> ToFemtoSiemen<T>(this Quantity<T, PicoSiemen> val) where T:IConvertible {
        return new Quantity<double, FemtoSiemen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoSiemen to AttoSiemen
    /// </summary>
    /// <param name="val">quantity measured in PicoSiemen</param>
    /// <returns>quantity measured in AttoSiemen</returns>
	public static Quantity<double, AttoSiemen> ToAttoSiemen<T>(this Quantity<T, PicoSiemen> val) where T:IConvertible {
        return new Quantity<double, AttoSiemen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoSiemen to ZeptoSiemen
    /// </summary>
    /// <param name="val">quantity measured in PicoSiemen</param>
    /// <returns>quantity measured in ZeptoSiemen</returns>
	public static Quantity<double, ZeptoSiemen> ToZeptoSiemen<T>(this Quantity<T, PicoSiemen> val) where T:IConvertible {
        return new Quantity<double, ZeptoSiemen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoSiemen to YoctoSiemen
    /// </summary>
    /// <param name="val">quantity measured in PicoSiemen</param>
    /// <returns>quantity measured in YoctoSiemen</returns>
	public static Quantity<double, YoctoSiemen> ToYoctoSiemen<T>(this Quantity<T, PicoSiemen> val) where T:IConvertible {
        return new Quantity<double, YoctoSiemen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert FemtoSiemen to YottaSiemen
    /// </summary>
    /// <param name="val">quantity measured in FemtoSiemen</param>
    /// <returns>quantity measured in YottaSiemen</returns>
	public static Quantity<double, YottaSiemen> ToYottaSiemen<T>(this Quantity<T, FemtoSiemen> val) where T:IConvertible {
        return new Quantity<double, YottaSiemen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoSiemen to ZettaSiemen
    /// </summary>
    /// <param name="val">quantity measured in FemtoSiemen</param>
    /// <returns>quantity measured in ZettaSiemen</returns>
	public static Quantity<double, ZettaSiemen> ToZettaSiemen<T>(this Quantity<T, FemtoSiemen> val) where T:IConvertible {
        return new Quantity<double, ZettaSiemen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoSiemen to ExaSiemen
    /// </summary>
    /// <param name="val">quantity measured in FemtoSiemen</param>
    /// <returns>quantity measured in ExaSiemen</returns>
	public static Quantity<double, ExaSiemen> ToExaSiemen<T>(this Quantity<T, FemtoSiemen> val) where T:IConvertible {
        return new Quantity<double, ExaSiemen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoSiemen to PetaSiemen
    /// </summary>
    /// <param name="val">quantity measured in FemtoSiemen</param>
    /// <returns>quantity measured in PetaSiemen</returns>
	public static Quantity<double, PetaSiemen> ToPetaSiemen<T>(this Quantity<T, FemtoSiemen> val) where T:IConvertible {
        return new Quantity<double, PetaSiemen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoSiemen to TeraSiemen
    /// </summary>
    /// <param name="val">quantity measured in FemtoSiemen</param>
    /// <returns>quantity measured in TeraSiemen</returns>
	public static Quantity<double, TeraSiemen> ToTeraSiemen<T>(this Quantity<T, FemtoSiemen> val) where T:IConvertible {
        return new Quantity<double, TeraSiemen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoSiemen to GigaSiemen
    /// </summary>
    /// <param name="val">quantity measured in FemtoSiemen</param>
    /// <returns>quantity measured in GigaSiemen</returns>
	public static Quantity<double, GigaSiemen> ToGigaSiemen<T>(this Quantity<T, FemtoSiemen> val) where T:IConvertible {
        return new Quantity<double, GigaSiemen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoSiemen to MegaSiemen
    /// </summary>
    /// <param name="val">quantity measured in FemtoSiemen</param>
    /// <returns>quantity measured in MegaSiemen</returns>
	public static Quantity<double, MegaSiemen> ToMegaSiemen<T>(this Quantity<T, FemtoSiemen> val) where T:IConvertible {
        return new Quantity<double, MegaSiemen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoSiemen to KiloSiemen
    /// </summary>
    /// <param name="val">quantity measured in FemtoSiemen</param>
    /// <returns>quantity measured in KiloSiemen</returns>
	public static Quantity<double, KiloSiemen> ToKiloSiemen<T>(this Quantity<T, FemtoSiemen> val) where T:IConvertible {
        return new Quantity<double, KiloSiemen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoSiemen to HectoSiemen
    /// </summary>
    /// <param name="val">quantity measured in FemtoSiemen</param>
    /// <returns>quantity measured in HectoSiemen</returns>
	public static Quantity<double, HectoSiemen> ToHectoSiemen<T>(this Quantity<T, FemtoSiemen> val) where T:IConvertible {
        return new Quantity<double, HectoSiemen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoSiemen to DekaSiemen
    /// </summary>
    /// <param name="val">quantity measured in FemtoSiemen</param>
    /// <returns>quantity measured in DekaSiemen</returns>
	public static Quantity<double, DekaSiemen> ToDekaSiemen<T>(this Quantity<T, FemtoSiemen> val) where T:IConvertible {
        return new Quantity<double, DekaSiemen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoSiemen to DeciSiemen
    /// </summary>
    /// <param name="val">quantity measured in FemtoSiemen</param>
    /// <returns>quantity measured in DeciSiemen</returns>
	public static Quantity<double, DeciSiemen> ToDeciSiemen<T>(this Quantity<T, FemtoSiemen> val) where T:IConvertible {
        return new Quantity<double, DeciSiemen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoSiemen to CentiSiemen
    /// </summary>
    /// <param name="val">quantity measured in FemtoSiemen</param>
    /// <returns>quantity measured in CentiSiemen</returns>
	public static Quantity<double, CentiSiemen> ToCentiSiemen<T>(this Quantity<T, FemtoSiemen> val) where T:IConvertible {
        return new Quantity<double, CentiSiemen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoSiemen to MilliSiemen
    /// </summary>
    /// <param name="val">quantity measured in FemtoSiemen</param>
    /// <returns>quantity measured in MilliSiemen</returns>
	public static Quantity<double, MilliSiemen> ToMilliSiemen<T>(this Quantity<T, FemtoSiemen> val) where T:IConvertible {
        return new Quantity<double, MilliSiemen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoSiemen to MicroSiemen
    /// </summary>
    /// <param name="val">quantity measured in FemtoSiemen</param>
    /// <returns>quantity measured in MicroSiemen</returns>
	public static Quantity<double, MicroSiemen> ToMicroSiemen<T>(this Quantity<T, FemtoSiemen> val) where T:IConvertible {
        return new Quantity<double, MicroSiemen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoSiemen to NanoSiemen
    /// </summary>
    /// <param name="val">quantity measured in FemtoSiemen</param>
    /// <returns>quantity measured in NanoSiemen</returns>
	public static Quantity<double, NanoSiemen> ToNanoSiemen<T>(this Quantity<T, FemtoSiemen> val) where T:IConvertible {
        return new Quantity<double, NanoSiemen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoSiemen to PicoSiemen
    /// </summary>
    /// <param name="val">quantity measured in FemtoSiemen</param>
    /// <returns>quantity measured in PicoSiemen</returns>
	public static Quantity<double, PicoSiemen> ToPicoSiemen<T>(this Quantity<T, FemtoSiemen> val) where T:IConvertible {
        return new Quantity<double, PicoSiemen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoSiemen to AttoSiemen
    /// </summary>
    /// <param name="val">quantity measured in FemtoSiemen</param>
    /// <returns>quantity measured in AttoSiemen</returns>
	public static Quantity<double, AttoSiemen> ToAttoSiemen<T>(this Quantity<T, FemtoSiemen> val) where T:IConvertible {
        return new Quantity<double, AttoSiemen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoSiemen to ZeptoSiemen
    /// </summary>
    /// <param name="val">quantity measured in FemtoSiemen</param>
    /// <returns>quantity measured in ZeptoSiemen</returns>
	public static Quantity<double, ZeptoSiemen> ToZeptoSiemen<T>(this Quantity<T, FemtoSiemen> val) where T:IConvertible {
        return new Quantity<double, ZeptoSiemen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoSiemen to YoctoSiemen
    /// </summary>
    /// <param name="val">quantity measured in FemtoSiemen</param>
    /// <returns>quantity measured in YoctoSiemen</returns>
	public static Quantity<double, YoctoSiemen> ToYoctoSiemen<T>(this Quantity<T, FemtoSiemen> val) where T:IConvertible {
        return new Quantity<double, YoctoSiemen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert AttoSiemen to YottaSiemen
    /// </summary>
    /// <param name="val">quantity measured in AttoSiemen</param>
    /// <returns>quantity measured in YottaSiemen</returns>
	public static Quantity<double, YottaSiemen> ToYottaSiemen<T>(this Quantity<T, AttoSiemen> val) where T:IConvertible {
        return new Quantity<double, YottaSiemen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoSiemen to ZettaSiemen
    /// </summary>
    /// <param name="val">quantity measured in AttoSiemen</param>
    /// <returns>quantity measured in ZettaSiemen</returns>
	public static Quantity<double, ZettaSiemen> ToZettaSiemen<T>(this Quantity<T, AttoSiemen> val) where T:IConvertible {
        return new Quantity<double, ZettaSiemen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoSiemen to ExaSiemen
    /// </summary>
    /// <param name="val">quantity measured in AttoSiemen</param>
    /// <returns>quantity measured in ExaSiemen</returns>
	public static Quantity<double, ExaSiemen> ToExaSiemen<T>(this Quantity<T, AttoSiemen> val) where T:IConvertible {
        return new Quantity<double, ExaSiemen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoSiemen to PetaSiemen
    /// </summary>
    /// <param name="val">quantity measured in AttoSiemen</param>
    /// <returns>quantity measured in PetaSiemen</returns>
	public static Quantity<double, PetaSiemen> ToPetaSiemen<T>(this Quantity<T, AttoSiemen> val) where T:IConvertible {
        return new Quantity<double, PetaSiemen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoSiemen to TeraSiemen
    /// </summary>
    /// <param name="val">quantity measured in AttoSiemen</param>
    /// <returns>quantity measured in TeraSiemen</returns>
	public static Quantity<double, TeraSiemen> ToTeraSiemen<T>(this Quantity<T, AttoSiemen> val) where T:IConvertible {
        return new Quantity<double, TeraSiemen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoSiemen to GigaSiemen
    /// </summary>
    /// <param name="val">quantity measured in AttoSiemen</param>
    /// <returns>quantity measured in GigaSiemen</returns>
	public static Quantity<double, GigaSiemen> ToGigaSiemen<T>(this Quantity<T, AttoSiemen> val) where T:IConvertible {
        return new Quantity<double, GigaSiemen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoSiemen to MegaSiemen
    /// </summary>
    /// <param name="val">quantity measured in AttoSiemen</param>
    /// <returns>quantity measured in MegaSiemen</returns>
	public static Quantity<double, MegaSiemen> ToMegaSiemen<T>(this Quantity<T, AttoSiemen> val) where T:IConvertible {
        return new Quantity<double, MegaSiemen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoSiemen to KiloSiemen
    /// </summary>
    /// <param name="val">quantity measured in AttoSiemen</param>
    /// <returns>quantity measured in KiloSiemen</returns>
	public static Quantity<double, KiloSiemen> ToKiloSiemen<T>(this Quantity<T, AttoSiemen> val) where T:IConvertible {
        return new Quantity<double, KiloSiemen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoSiemen to HectoSiemen
    /// </summary>
    /// <param name="val">quantity measured in AttoSiemen</param>
    /// <returns>quantity measured in HectoSiemen</returns>
	public static Quantity<double, HectoSiemen> ToHectoSiemen<T>(this Quantity<T, AttoSiemen> val) where T:IConvertible {
        return new Quantity<double, HectoSiemen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoSiemen to DekaSiemen
    /// </summary>
    /// <param name="val">quantity measured in AttoSiemen</param>
    /// <returns>quantity measured in DekaSiemen</returns>
	public static Quantity<double, DekaSiemen> ToDekaSiemen<T>(this Quantity<T, AttoSiemen> val) where T:IConvertible {
        return new Quantity<double, DekaSiemen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoSiemen to DeciSiemen
    /// </summary>
    /// <param name="val">quantity measured in AttoSiemen</param>
    /// <returns>quantity measured in DeciSiemen</returns>
	public static Quantity<double, DeciSiemen> ToDeciSiemen<T>(this Quantity<T, AttoSiemen> val) where T:IConvertible {
        return new Quantity<double, DeciSiemen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoSiemen to CentiSiemen
    /// </summary>
    /// <param name="val">quantity measured in AttoSiemen</param>
    /// <returns>quantity measured in CentiSiemen</returns>
	public static Quantity<double, CentiSiemen> ToCentiSiemen<T>(this Quantity<T, AttoSiemen> val) where T:IConvertible {
        return new Quantity<double, CentiSiemen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoSiemen to MilliSiemen
    /// </summary>
    /// <param name="val">quantity measured in AttoSiemen</param>
    /// <returns>quantity measured in MilliSiemen</returns>
	public static Quantity<double, MilliSiemen> ToMilliSiemen<T>(this Quantity<T, AttoSiemen> val) where T:IConvertible {
        return new Quantity<double, MilliSiemen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoSiemen to MicroSiemen
    /// </summary>
    /// <param name="val">quantity measured in AttoSiemen</param>
    /// <returns>quantity measured in MicroSiemen</returns>
	public static Quantity<double, MicroSiemen> ToMicroSiemen<T>(this Quantity<T, AttoSiemen> val) where T:IConvertible {
        return new Quantity<double, MicroSiemen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoSiemen to NanoSiemen
    /// </summary>
    /// <param name="val">quantity measured in AttoSiemen</param>
    /// <returns>quantity measured in NanoSiemen</returns>
	public static Quantity<double, NanoSiemen> ToNanoSiemen<T>(this Quantity<T, AttoSiemen> val) where T:IConvertible {
        return new Quantity<double, NanoSiemen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoSiemen to PicoSiemen
    /// </summary>
    /// <param name="val">quantity measured in AttoSiemen</param>
    /// <returns>quantity measured in PicoSiemen</returns>
	public static Quantity<double, PicoSiemen> ToPicoSiemen<T>(this Quantity<T, AttoSiemen> val) where T:IConvertible {
        return new Quantity<double, PicoSiemen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoSiemen to FemtoSiemen
    /// </summary>
    /// <param name="val">quantity measured in AttoSiemen</param>
    /// <returns>quantity measured in FemtoSiemen</returns>
	public static Quantity<double, FemtoSiemen> ToFemtoSiemen<T>(this Quantity<T, AttoSiemen> val) where T:IConvertible {
        return new Quantity<double, FemtoSiemen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoSiemen to ZeptoSiemen
    /// </summary>
    /// <param name="val">quantity measured in AttoSiemen</param>
    /// <returns>quantity measured in ZeptoSiemen</returns>
	public static Quantity<double, ZeptoSiemen> ToZeptoSiemen<T>(this Quantity<T, AttoSiemen> val) where T:IConvertible {
        return new Quantity<double, ZeptoSiemen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoSiemen to YoctoSiemen
    /// </summary>
    /// <param name="val">quantity measured in AttoSiemen</param>
    /// <returns>quantity measured in YoctoSiemen</returns>
	public static Quantity<double, YoctoSiemen> ToYoctoSiemen<T>(this Quantity<T, AttoSiemen> val) where T:IConvertible {
        return new Quantity<double, YoctoSiemen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoSiemen to YottaSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoSiemen</param>
    /// <returns>quantity measured in YottaSiemen</returns>
	public static Quantity<double, YottaSiemen> ToYottaSiemen<T>(this Quantity<T, ZeptoSiemen> val) where T:IConvertible {
        return new Quantity<double, YottaSiemen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoSiemen to ZettaSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoSiemen</param>
    /// <returns>quantity measured in ZettaSiemen</returns>
	public static Quantity<double, ZettaSiemen> ToZettaSiemen<T>(this Quantity<T, ZeptoSiemen> val) where T:IConvertible {
        return new Quantity<double, ZettaSiemen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoSiemen to ExaSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoSiemen</param>
    /// <returns>quantity measured in ExaSiemen</returns>
	public static Quantity<double, ExaSiemen> ToExaSiemen<T>(this Quantity<T, ZeptoSiemen> val) where T:IConvertible {
        return new Quantity<double, ExaSiemen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoSiemen to PetaSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoSiemen</param>
    /// <returns>quantity measured in PetaSiemen</returns>
	public static Quantity<double, PetaSiemen> ToPetaSiemen<T>(this Quantity<T, ZeptoSiemen> val) where T:IConvertible {
        return new Quantity<double, PetaSiemen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoSiemen to TeraSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoSiemen</param>
    /// <returns>quantity measured in TeraSiemen</returns>
	public static Quantity<double, TeraSiemen> ToTeraSiemen<T>(this Quantity<T, ZeptoSiemen> val) where T:IConvertible {
        return new Quantity<double, TeraSiemen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoSiemen to GigaSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoSiemen</param>
    /// <returns>quantity measured in GigaSiemen</returns>
	public static Quantity<double, GigaSiemen> ToGigaSiemen<T>(this Quantity<T, ZeptoSiemen> val) where T:IConvertible {
        return new Quantity<double, GigaSiemen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoSiemen to MegaSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoSiemen</param>
    /// <returns>quantity measured in MegaSiemen</returns>
	public static Quantity<double, MegaSiemen> ToMegaSiemen<T>(this Quantity<T, ZeptoSiemen> val) where T:IConvertible {
        return new Quantity<double, MegaSiemen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoSiemen to KiloSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoSiemen</param>
    /// <returns>quantity measured in KiloSiemen</returns>
	public static Quantity<double, KiloSiemen> ToKiloSiemen<T>(this Quantity<T, ZeptoSiemen> val) where T:IConvertible {
        return new Quantity<double, KiloSiemen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoSiemen to HectoSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoSiemen</param>
    /// <returns>quantity measured in HectoSiemen</returns>
	public static Quantity<double, HectoSiemen> ToHectoSiemen<T>(this Quantity<T, ZeptoSiemen> val) where T:IConvertible {
        return new Quantity<double, HectoSiemen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoSiemen to DekaSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoSiemen</param>
    /// <returns>quantity measured in DekaSiemen</returns>
	public static Quantity<double, DekaSiemen> ToDekaSiemen<T>(this Quantity<T, ZeptoSiemen> val) where T:IConvertible {
        return new Quantity<double, DekaSiemen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoSiemen to DeciSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoSiemen</param>
    /// <returns>quantity measured in DeciSiemen</returns>
	public static Quantity<double, DeciSiemen> ToDeciSiemen<T>(this Quantity<T, ZeptoSiemen> val) where T:IConvertible {
        return new Quantity<double, DeciSiemen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoSiemen to CentiSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoSiemen</param>
    /// <returns>quantity measured in CentiSiemen</returns>
	public static Quantity<double, CentiSiemen> ToCentiSiemen<T>(this Quantity<T, ZeptoSiemen> val) where T:IConvertible {
        return new Quantity<double, CentiSiemen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoSiemen to MilliSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoSiemen</param>
    /// <returns>quantity measured in MilliSiemen</returns>
	public static Quantity<double, MilliSiemen> ToMilliSiemen<T>(this Quantity<T, ZeptoSiemen> val) where T:IConvertible {
        return new Quantity<double, MilliSiemen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoSiemen to MicroSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoSiemen</param>
    /// <returns>quantity measured in MicroSiemen</returns>
	public static Quantity<double, MicroSiemen> ToMicroSiemen<T>(this Quantity<T, ZeptoSiemen> val) where T:IConvertible {
        return new Quantity<double, MicroSiemen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoSiemen to NanoSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoSiemen</param>
    /// <returns>quantity measured in NanoSiemen</returns>
	public static Quantity<double, NanoSiemen> ToNanoSiemen<T>(this Quantity<T, ZeptoSiemen> val) where T:IConvertible {
        return new Quantity<double, NanoSiemen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoSiemen to PicoSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoSiemen</param>
    /// <returns>quantity measured in PicoSiemen</returns>
	public static Quantity<double, PicoSiemen> ToPicoSiemen<T>(this Quantity<T, ZeptoSiemen> val) where T:IConvertible {
        return new Quantity<double, PicoSiemen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoSiemen to FemtoSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoSiemen</param>
    /// <returns>quantity measured in FemtoSiemen</returns>
	public static Quantity<double, FemtoSiemen> ToFemtoSiemen<T>(this Quantity<T, ZeptoSiemen> val) where T:IConvertible {
        return new Quantity<double, FemtoSiemen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoSiemen to AttoSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoSiemen</param>
    /// <returns>quantity measured in AttoSiemen</returns>
	public static Quantity<double, AttoSiemen> ToAttoSiemen<T>(this Quantity<T, ZeptoSiemen> val) where T:IConvertible {
        return new Quantity<double, AttoSiemen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoSiemen to YoctoSiemen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoSiemen</param>
    /// <returns>quantity measured in YoctoSiemen</returns>
	public static Quantity<double, YoctoSiemen> ToYoctoSiemen<T>(this Quantity<T, ZeptoSiemen> val) where T:IConvertible {
        return new Quantity<double, YoctoSiemen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert YoctoSiemen to YottaSiemen
    /// </summary>
    /// <param name="val">quantity measured in YoctoSiemen</param>
    /// <returns>quantity measured in YottaSiemen</returns>
	public static Quantity<double, YottaSiemen> ToYottaSiemen<T>(this Quantity<T, YoctoSiemen> val) where T:IConvertible {
        return new Quantity<double, YottaSiemen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoSiemen to ZettaSiemen
    /// </summary>
    /// <param name="val">quantity measured in YoctoSiemen</param>
    /// <returns>quantity measured in ZettaSiemen</returns>
	public static Quantity<double, ZettaSiemen> ToZettaSiemen<T>(this Quantity<T, YoctoSiemen> val) where T:IConvertible {
        return new Quantity<double, ZettaSiemen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoSiemen to ExaSiemen
    /// </summary>
    /// <param name="val">quantity measured in YoctoSiemen</param>
    /// <returns>quantity measured in ExaSiemen</returns>
	public static Quantity<double, ExaSiemen> ToExaSiemen<T>(this Quantity<T, YoctoSiemen> val) where T:IConvertible {
        return new Quantity<double, ExaSiemen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoSiemen to PetaSiemen
    /// </summary>
    /// <param name="val">quantity measured in YoctoSiemen</param>
    /// <returns>quantity measured in PetaSiemen</returns>
	public static Quantity<double, PetaSiemen> ToPetaSiemen<T>(this Quantity<T, YoctoSiemen> val) where T:IConvertible {
        return new Quantity<double, PetaSiemen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoSiemen to TeraSiemen
    /// </summary>
    /// <param name="val">quantity measured in YoctoSiemen</param>
    /// <returns>quantity measured in TeraSiemen</returns>
	public static Quantity<double, TeraSiemen> ToTeraSiemen<T>(this Quantity<T, YoctoSiemen> val) where T:IConvertible {
        return new Quantity<double, TeraSiemen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoSiemen to GigaSiemen
    /// </summary>
    /// <param name="val">quantity measured in YoctoSiemen</param>
    /// <returns>quantity measured in GigaSiemen</returns>
	public static Quantity<double, GigaSiemen> ToGigaSiemen<T>(this Quantity<T, YoctoSiemen> val) where T:IConvertible {
        return new Quantity<double, GigaSiemen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoSiemen to MegaSiemen
    /// </summary>
    /// <param name="val">quantity measured in YoctoSiemen</param>
    /// <returns>quantity measured in MegaSiemen</returns>
	public static Quantity<double, MegaSiemen> ToMegaSiemen<T>(this Quantity<T, YoctoSiemen> val) where T:IConvertible {
        return new Quantity<double, MegaSiemen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoSiemen to KiloSiemen
    /// </summary>
    /// <param name="val">quantity measured in YoctoSiemen</param>
    /// <returns>quantity measured in KiloSiemen</returns>
	public static Quantity<double, KiloSiemen> ToKiloSiemen<T>(this Quantity<T, YoctoSiemen> val) where T:IConvertible {
        return new Quantity<double, KiloSiemen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoSiemen to HectoSiemen
    /// </summary>
    /// <param name="val">quantity measured in YoctoSiemen</param>
    /// <returns>quantity measured in HectoSiemen</returns>
	public static Quantity<double, HectoSiemen> ToHectoSiemen<T>(this Quantity<T, YoctoSiemen> val) where T:IConvertible {
        return new Quantity<double, HectoSiemen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoSiemen to DekaSiemen
    /// </summary>
    /// <param name="val">quantity measured in YoctoSiemen</param>
    /// <returns>quantity measured in DekaSiemen</returns>
	public static Quantity<double, DekaSiemen> ToDekaSiemen<T>(this Quantity<T, YoctoSiemen> val) where T:IConvertible {
        return new Quantity<double, DekaSiemen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoSiemen to DeciSiemen
    /// </summary>
    /// <param name="val">quantity measured in YoctoSiemen</param>
    /// <returns>quantity measured in DeciSiemen</returns>
	public static Quantity<double, DeciSiemen> ToDeciSiemen<T>(this Quantity<T, YoctoSiemen> val) where T:IConvertible {
        return new Quantity<double, DeciSiemen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoSiemen to CentiSiemen
    /// </summary>
    /// <param name="val">quantity measured in YoctoSiemen</param>
    /// <returns>quantity measured in CentiSiemen</returns>
	public static Quantity<double, CentiSiemen> ToCentiSiemen<T>(this Quantity<T, YoctoSiemen> val) where T:IConvertible {
        return new Quantity<double, CentiSiemen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoSiemen to MilliSiemen
    /// </summary>
    /// <param name="val">quantity measured in YoctoSiemen</param>
    /// <returns>quantity measured in MilliSiemen</returns>
	public static Quantity<double, MilliSiemen> ToMilliSiemen<T>(this Quantity<T, YoctoSiemen> val) where T:IConvertible {
        return new Quantity<double, MilliSiemen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoSiemen to MicroSiemen
    /// </summary>
    /// <param name="val">quantity measured in YoctoSiemen</param>
    /// <returns>quantity measured in MicroSiemen</returns>
	public static Quantity<double, MicroSiemen> ToMicroSiemen<T>(this Quantity<T, YoctoSiemen> val) where T:IConvertible {
        return new Quantity<double, MicroSiemen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoSiemen to NanoSiemen
    /// </summary>
    /// <param name="val">quantity measured in YoctoSiemen</param>
    /// <returns>quantity measured in NanoSiemen</returns>
	public static Quantity<double, NanoSiemen> ToNanoSiemen<T>(this Quantity<T, YoctoSiemen> val) where T:IConvertible {
        return new Quantity<double, NanoSiemen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoSiemen to PicoSiemen
    /// </summary>
    /// <param name="val">quantity measured in YoctoSiemen</param>
    /// <returns>quantity measured in PicoSiemen</returns>
	public static Quantity<double, PicoSiemen> ToPicoSiemen<T>(this Quantity<T, YoctoSiemen> val) where T:IConvertible {
        return new Quantity<double, PicoSiemen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoSiemen to FemtoSiemen
    /// </summary>
    /// <param name="val">quantity measured in YoctoSiemen</param>
    /// <returns>quantity measured in FemtoSiemen</returns>
	public static Quantity<double, FemtoSiemen> ToFemtoSiemen<T>(this Quantity<T, YoctoSiemen> val) where T:IConvertible {
        return new Quantity<double, FemtoSiemen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoSiemen to AttoSiemen
    /// </summary>
    /// <param name="val">quantity measured in YoctoSiemen</param>
    /// <returns>quantity measured in AttoSiemen</returns>
	public static Quantity<double, AttoSiemen> ToAttoSiemen<T>(this Quantity<T, YoctoSiemen> val) where T:IConvertible {
        return new Quantity<double, AttoSiemen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoSiemen to ZeptoSiemen
    /// </summary>
    /// <param name="val">quantity measured in YoctoSiemen</param>
    /// <returns>quantity measured in ZeptoSiemen</returns>
	public static Quantity<double, ZeptoSiemen> ToZeptoSiemen<T>(this Quantity<T, YoctoSiemen> val) where T:IConvertible {
        return new Quantity<double, ZeptoSiemen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
}
}