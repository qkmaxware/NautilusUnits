using System;
namespace Qkmaxware.Units.Luminosity {
/// <summary>
/// Static class housing si-prefix conversions for the unit "Lumen"
/// </summary>
public static class LuminosityConversions {
	/// <summary>
    /// Extension method to convert Lumen to YottaLumen
    /// </summary>
    /// <param name="val">quantity measured in Lumen</param>
    /// <returns>quantity measured in YottaLumen</returns>
	public static Quantity<double, YottaLumen> ToYottaLumen<T>(this Quantity<T, Lumen> val) where T:IConvertible {
        return new Quantity<double, YottaLumen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Lumen to ZettaLumen
    /// </summary>
    /// <param name="val">quantity measured in Lumen</param>
    /// <returns>quantity measured in ZettaLumen</returns>
	public static Quantity<double, ZettaLumen> ToZettaLumen<T>(this Quantity<T, Lumen> val) where T:IConvertible {
        return new Quantity<double, ZettaLumen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Lumen to ExaLumen
    /// </summary>
    /// <param name="val">quantity measured in Lumen</param>
    /// <returns>quantity measured in ExaLumen</returns>
	public static Quantity<double, ExaLumen> ToExaLumen<T>(this Quantity<T, Lumen> val) where T:IConvertible {
        return new Quantity<double, ExaLumen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Lumen to PetaLumen
    /// </summary>
    /// <param name="val">quantity measured in Lumen</param>
    /// <returns>quantity measured in PetaLumen</returns>
	public static Quantity<double, PetaLumen> ToPetaLumen<T>(this Quantity<T, Lumen> val) where T:IConvertible {
        return new Quantity<double, PetaLumen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Lumen to TeraLumen
    /// </summary>
    /// <param name="val">quantity measured in Lumen</param>
    /// <returns>quantity measured in TeraLumen</returns>
	public static Quantity<double, TeraLumen> ToTeraLumen<T>(this Quantity<T, Lumen> val) where T:IConvertible {
        return new Quantity<double, TeraLumen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Lumen to GigaLumen
    /// </summary>
    /// <param name="val">quantity measured in Lumen</param>
    /// <returns>quantity measured in GigaLumen</returns>
	public static Quantity<double, GigaLumen> ToGigaLumen<T>(this Quantity<T, Lumen> val) where T:IConvertible {
        return new Quantity<double, GigaLumen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Lumen to MegaLumen
    /// </summary>
    /// <param name="val">quantity measured in Lumen</param>
    /// <returns>quantity measured in MegaLumen</returns>
	public static Quantity<double, MegaLumen> ToMegaLumen<T>(this Quantity<T, Lumen> val) where T:IConvertible {
        return new Quantity<double, MegaLumen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Lumen to KiloLumen
    /// </summary>
    /// <param name="val">quantity measured in Lumen</param>
    /// <returns>quantity measured in KiloLumen</returns>
	public static Quantity<double, KiloLumen> ToKiloLumen<T>(this Quantity<T, Lumen> val) where T:IConvertible {
        return new Quantity<double, KiloLumen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Lumen to HectoLumen
    /// </summary>
    /// <param name="val">quantity measured in Lumen</param>
    /// <returns>quantity measured in HectoLumen</returns>
	public static Quantity<double, HectoLumen> ToHectoLumen<T>(this Quantity<T, Lumen> val) where T:IConvertible {
        return new Quantity<double, HectoLumen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Lumen to DekaLumen
    /// </summary>
    /// <param name="val">quantity measured in Lumen</param>
    /// <returns>quantity measured in DekaLumen</returns>
	public static Quantity<double, DekaLumen> ToDekaLumen<T>(this Quantity<T, Lumen> val) where T:IConvertible {
        return new Quantity<double, DekaLumen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Lumen to DeciLumen
    /// </summary>
    /// <param name="val">quantity measured in Lumen</param>
    /// <returns>quantity measured in DeciLumen</returns>
	public static Quantity<double, DeciLumen> ToDeciLumen<T>(this Quantity<T, Lumen> val) where T:IConvertible {
        return new Quantity<double, DeciLumen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Lumen to CentiLumen
    /// </summary>
    /// <param name="val">quantity measured in Lumen</param>
    /// <returns>quantity measured in CentiLumen</returns>
	public static Quantity<double, CentiLumen> ToCentiLumen<T>(this Quantity<T, Lumen> val) where T:IConvertible {
        return new Quantity<double, CentiLumen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Lumen to MilliLumen
    /// </summary>
    /// <param name="val">quantity measured in Lumen</param>
    /// <returns>quantity measured in MilliLumen</returns>
	public static Quantity<double, MilliLumen> ToMilliLumen<T>(this Quantity<T, Lumen> val) where T:IConvertible {
        return new Quantity<double, MilliLumen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Lumen to MicroLumen
    /// </summary>
    /// <param name="val">quantity measured in Lumen</param>
    /// <returns>quantity measured in MicroLumen</returns>
	public static Quantity<double, MicroLumen> ToMicroLumen<T>(this Quantity<T, Lumen> val) where T:IConvertible {
        return new Quantity<double, MicroLumen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Lumen to NanoLumen
    /// </summary>
    /// <param name="val">quantity measured in Lumen</param>
    /// <returns>quantity measured in NanoLumen</returns>
	public static Quantity<double, NanoLumen> ToNanoLumen<T>(this Quantity<T, Lumen> val) where T:IConvertible {
        return new Quantity<double, NanoLumen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Lumen to PicoLumen
    /// </summary>
    /// <param name="val">quantity measured in Lumen</param>
    /// <returns>quantity measured in PicoLumen</returns>
	public static Quantity<double, PicoLumen> ToPicoLumen<T>(this Quantity<T, Lumen> val) where T:IConvertible {
        return new Quantity<double, PicoLumen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Lumen to FemtoLumen
    /// </summary>
    /// <param name="val">quantity measured in Lumen</param>
    /// <returns>quantity measured in FemtoLumen</returns>
	public static Quantity<double, FemtoLumen> ToFemtoLumen<T>(this Quantity<T, Lumen> val) where T:IConvertible {
        return new Quantity<double, FemtoLumen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Lumen to AttoLumen
    /// </summary>
    /// <param name="val">quantity measured in Lumen</param>
    /// <returns>quantity measured in AttoLumen</returns>
	public static Quantity<double, AttoLumen> ToAttoLumen<T>(this Quantity<T, Lumen> val) where T:IConvertible {
        return new Quantity<double, AttoLumen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Lumen to ZeptoLumen
    /// </summary>
    /// <param name="val">quantity measured in Lumen</param>
    /// <returns>quantity measured in ZeptoLumen</returns>
	public static Quantity<double, ZeptoLumen> ToZeptoLumen<T>(this Quantity<T, Lumen> val) where T:IConvertible {
        return new Quantity<double, ZeptoLumen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Lumen to YoctoLumen
    /// </summary>
    /// <param name="val">quantity measured in Lumen</param>
    /// <returns>quantity measured in YoctoLumen</returns>
	public static Quantity<double, YoctoLumen> ToYoctoLumen<T>(this Quantity<T, Lumen> val) where T:IConvertible {
        return new Quantity<double, YoctoLumen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YottaLumen to ZettaLumen
    /// </summary>
    /// <param name="val">quantity measured in YottaLumen</param>
    /// <returns>quantity measured in ZettaLumen</returns>
	public static Quantity<double, ZettaLumen> ToZettaLumen<T>(this Quantity<T, YottaLumen> val) where T:IConvertible {
        return new Quantity<double, ZettaLumen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaLumen to ExaLumen
    /// </summary>
    /// <param name="val">quantity measured in YottaLumen</param>
    /// <returns>quantity measured in ExaLumen</returns>
	public static Quantity<double, ExaLumen> ToExaLumen<T>(this Quantity<T, YottaLumen> val) where T:IConvertible {
        return new Quantity<double, ExaLumen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaLumen to PetaLumen
    /// </summary>
    /// <param name="val">quantity measured in YottaLumen</param>
    /// <returns>quantity measured in PetaLumen</returns>
	public static Quantity<double, PetaLumen> ToPetaLumen<T>(this Quantity<T, YottaLumen> val) where T:IConvertible {
        return new Quantity<double, PetaLumen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaLumen to TeraLumen
    /// </summary>
    /// <param name="val">quantity measured in YottaLumen</param>
    /// <returns>quantity measured in TeraLumen</returns>
	public static Quantity<double, TeraLumen> ToTeraLumen<T>(this Quantity<T, YottaLumen> val) where T:IConvertible {
        return new Quantity<double, TeraLumen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaLumen to GigaLumen
    /// </summary>
    /// <param name="val">quantity measured in YottaLumen</param>
    /// <returns>quantity measured in GigaLumen</returns>
	public static Quantity<double, GigaLumen> ToGigaLumen<T>(this Quantity<T, YottaLumen> val) where T:IConvertible {
        return new Quantity<double, GigaLumen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaLumen to MegaLumen
    /// </summary>
    /// <param name="val">quantity measured in YottaLumen</param>
    /// <returns>quantity measured in MegaLumen</returns>
	public static Quantity<double, MegaLumen> ToMegaLumen<T>(this Quantity<T, YottaLumen> val) where T:IConvertible {
        return new Quantity<double, MegaLumen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaLumen to KiloLumen
    /// </summary>
    /// <param name="val">quantity measured in YottaLumen</param>
    /// <returns>quantity measured in KiloLumen</returns>
	public static Quantity<double, KiloLumen> ToKiloLumen<T>(this Quantity<T, YottaLumen> val) where T:IConvertible {
        return new Quantity<double, KiloLumen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaLumen to HectoLumen
    /// </summary>
    /// <param name="val">quantity measured in YottaLumen</param>
    /// <returns>quantity measured in HectoLumen</returns>
	public static Quantity<double, HectoLumen> ToHectoLumen<T>(this Quantity<T, YottaLumen> val) where T:IConvertible {
        return new Quantity<double, HectoLumen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaLumen to DekaLumen
    /// </summary>
    /// <param name="val">quantity measured in YottaLumen</param>
    /// <returns>quantity measured in DekaLumen</returns>
	public static Quantity<double, DekaLumen> ToDekaLumen<T>(this Quantity<T, YottaLumen> val) where T:IConvertible {
        return new Quantity<double, DekaLumen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaLumen to DeciLumen
    /// </summary>
    /// <param name="val">quantity measured in YottaLumen</param>
    /// <returns>quantity measured in DeciLumen</returns>
	public static Quantity<double, DeciLumen> ToDeciLumen<T>(this Quantity<T, YottaLumen> val) where T:IConvertible {
        return new Quantity<double, DeciLumen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaLumen to CentiLumen
    /// </summary>
    /// <param name="val">quantity measured in YottaLumen</param>
    /// <returns>quantity measured in CentiLumen</returns>
	public static Quantity<double, CentiLumen> ToCentiLumen<T>(this Quantity<T, YottaLumen> val) where T:IConvertible {
        return new Quantity<double, CentiLumen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaLumen to MilliLumen
    /// </summary>
    /// <param name="val">quantity measured in YottaLumen</param>
    /// <returns>quantity measured in MilliLumen</returns>
	public static Quantity<double, MilliLumen> ToMilliLumen<T>(this Quantity<T, YottaLumen> val) where T:IConvertible {
        return new Quantity<double, MilliLumen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaLumen to MicroLumen
    /// </summary>
    /// <param name="val">quantity measured in YottaLumen</param>
    /// <returns>quantity measured in MicroLumen</returns>
	public static Quantity<double, MicroLumen> ToMicroLumen<T>(this Quantity<T, YottaLumen> val) where T:IConvertible {
        return new Quantity<double, MicroLumen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaLumen to NanoLumen
    /// </summary>
    /// <param name="val">quantity measured in YottaLumen</param>
    /// <returns>quantity measured in NanoLumen</returns>
	public static Quantity<double, NanoLumen> ToNanoLumen<T>(this Quantity<T, YottaLumen> val) where T:IConvertible {
        return new Quantity<double, NanoLumen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaLumen to PicoLumen
    /// </summary>
    /// <param name="val">quantity measured in YottaLumen</param>
    /// <returns>quantity measured in PicoLumen</returns>
	public static Quantity<double, PicoLumen> ToPicoLumen<T>(this Quantity<T, YottaLumen> val) where T:IConvertible {
        return new Quantity<double, PicoLumen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaLumen to FemtoLumen
    /// </summary>
    /// <param name="val">quantity measured in YottaLumen</param>
    /// <returns>quantity measured in FemtoLumen</returns>
	public static Quantity<double, FemtoLumen> ToFemtoLumen<T>(this Quantity<T, YottaLumen> val) where T:IConvertible {
        return new Quantity<double, FemtoLumen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaLumen to AttoLumen
    /// </summary>
    /// <param name="val">quantity measured in YottaLumen</param>
    /// <returns>quantity measured in AttoLumen</returns>
	public static Quantity<double, AttoLumen> ToAttoLumen<T>(this Quantity<T, YottaLumen> val) where T:IConvertible {
        return new Quantity<double, AttoLumen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaLumen to ZeptoLumen
    /// </summary>
    /// <param name="val">quantity measured in YottaLumen</param>
    /// <returns>quantity measured in ZeptoLumen</returns>
	public static Quantity<double, ZeptoLumen> ToZeptoLumen<T>(this Quantity<T, YottaLumen> val) where T:IConvertible {
        return new Quantity<double, ZeptoLumen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaLumen to YoctoLumen
    /// </summary>
    /// <param name="val">quantity measured in YottaLumen</param>
    /// <returns>quantity measured in YoctoLumen</returns>
	public static Quantity<double, YoctoLumen> ToYoctoLumen<T>(this Quantity<T, YottaLumen> val) where T:IConvertible {
        return new Quantity<double, YoctoLumen>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert ZettaLumen to YottaLumen
    /// </summary>
    /// <param name="val">quantity measured in ZettaLumen</param>
    /// <returns>quantity measured in YottaLumen</returns>
	public static Quantity<double, YottaLumen> ToYottaLumen<T>(this Quantity<T, ZettaLumen> val) where T:IConvertible {
        return new Quantity<double, YottaLumen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaLumen to ExaLumen
    /// </summary>
    /// <param name="val">quantity measured in ZettaLumen</param>
    /// <returns>quantity measured in ExaLumen</returns>
	public static Quantity<double, ExaLumen> ToExaLumen<T>(this Quantity<T, ZettaLumen> val) where T:IConvertible {
        return new Quantity<double, ExaLumen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaLumen to PetaLumen
    /// </summary>
    /// <param name="val">quantity measured in ZettaLumen</param>
    /// <returns>quantity measured in PetaLumen</returns>
	public static Quantity<double, PetaLumen> ToPetaLumen<T>(this Quantity<T, ZettaLumen> val) where T:IConvertible {
        return new Quantity<double, PetaLumen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaLumen to TeraLumen
    /// </summary>
    /// <param name="val">quantity measured in ZettaLumen</param>
    /// <returns>quantity measured in TeraLumen</returns>
	public static Quantity<double, TeraLumen> ToTeraLumen<T>(this Quantity<T, ZettaLumen> val) where T:IConvertible {
        return new Quantity<double, TeraLumen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaLumen to GigaLumen
    /// </summary>
    /// <param name="val">quantity measured in ZettaLumen</param>
    /// <returns>quantity measured in GigaLumen</returns>
	public static Quantity<double, GigaLumen> ToGigaLumen<T>(this Quantity<T, ZettaLumen> val) where T:IConvertible {
        return new Quantity<double, GigaLumen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaLumen to MegaLumen
    /// </summary>
    /// <param name="val">quantity measured in ZettaLumen</param>
    /// <returns>quantity measured in MegaLumen</returns>
	public static Quantity<double, MegaLumen> ToMegaLumen<T>(this Quantity<T, ZettaLumen> val) where T:IConvertible {
        return new Quantity<double, MegaLumen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaLumen to KiloLumen
    /// </summary>
    /// <param name="val">quantity measured in ZettaLumen</param>
    /// <returns>quantity measured in KiloLumen</returns>
	public static Quantity<double, KiloLumen> ToKiloLumen<T>(this Quantity<T, ZettaLumen> val) where T:IConvertible {
        return new Quantity<double, KiloLumen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaLumen to HectoLumen
    /// </summary>
    /// <param name="val">quantity measured in ZettaLumen</param>
    /// <returns>quantity measured in HectoLumen</returns>
	public static Quantity<double, HectoLumen> ToHectoLumen<T>(this Quantity<T, ZettaLumen> val) where T:IConvertible {
        return new Quantity<double, HectoLumen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaLumen to DekaLumen
    /// </summary>
    /// <param name="val">quantity measured in ZettaLumen</param>
    /// <returns>quantity measured in DekaLumen</returns>
	public static Quantity<double, DekaLumen> ToDekaLumen<T>(this Quantity<T, ZettaLumen> val) where T:IConvertible {
        return new Quantity<double, DekaLumen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaLumen to DeciLumen
    /// </summary>
    /// <param name="val">quantity measured in ZettaLumen</param>
    /// <returns>quantity measured in DeciLumen</returns>
	public static Quantity<double, DeciLumen> ToDeciLumen<T>(this Quantity<T, ZettaLumen> val) where T:IConvertible {
        return new Quantity<double, DeciLumen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaLumen to CentiLumen
    /// </summary>
    /// <param name="val">quantity measured in ZettaLumen</param>
    /// <returns>quantity measured in CentiLumen</returns>
	public static Quantity<double, CentiLumen> ToCentiLumen<T>(this Quantity<T, ZettaLumen> val) where T:IConvertible {
        return new Quantity<double, CentiLumen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaLumen to MilliLumen
    /// </summary>
    /// <param name="val">quantity measured in ZettaLumen</param>
    /// <returns>quantity measured in MilliLumen</returns>
	public static Quantity<double, MilliLumen> ToMilliLumen<T>(this Quantity<T, ZettaLumen> val) where T:IConvertible {
        return new Quantity<double, MilliLumen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaLumen to MicroLumen
    /// </summary>
    /// <param name="val">quantity measured in ZettaLumen</param>
    /// <returns>quantity measured in MicroLumen</returns>
	public static Quantity<double, MicroLumen> ToMicroLumen<T>(this Quantity<T, ZettaLumen> val) where T:IConvertible {
        return new Quantity<double, MicroLumen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaLumen to NanoLumen
    /// </summary>
    /// <param name="val">quantity measured in ZettaLumen</param>
    /// <returns>quantity measured in NanoLumen</returns>
	public static Quantity<double, NanoLumen> ToNanoLumen<T>(this Quantity<T, ZettaLumen> val) where T:IConvertible {
        return new Quantity<double, NanoLumen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaLumen to PicoLumen
    /// </summary>
    /// <param name="val">quantity measured in ZettaLumen</param>
    /// <returns>quantity measured in PicoLumen</returns>
	public static Quantity<double, PicoLumen> ToPicoLumen<T>(this Quantity<T, ZettaLumen> val) where T:IConvertible {
        return new Quantity<double, PicoLumen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaLumen to FemtoLumen
    /// </summary>
    /// <param name="val">quantity measured in ZettaLumen</param>
    /// <returns>quantity measured in FemtoLumen</returns>
	public static Quantity<double, FemtoLumen> ToFemtoLumen<T>(this Quantity<T, ZettaLumen> val) where T:IConvertible {
        return new Quantity<double, FemtoLumen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaLumen to AttoLumen
    /// </summary>
    /// <param name="val">quantity measured in ZettaLumen</param>
    /// <returns>quantity measured in AttoLumen</returns>
	public static Quantity<double, AttoLumen> ToAttoLumen<T>(this Quantity<T, ZettaLumen> val) where T:IConvertible {
        return new Quantity<double, AttoLumen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaLumen to ZeptoLumen
    /// </summary>
    /// <param name="val">quantity measured in ZettaLumen</param>
    /// <returns>quantity measured in ZeptoLumen</returns>
	public static Quantity<double, ZeptoLumen> ToZeptoLumen<T>(this Quantity<T, ZettaLumen> val) where T:IConvertible {
        return new Quantity<double, ZeptoLumen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaLumen to YoctoLumen
    /// </summary>
    /// <param name="val">quantity measured in ZettaLumen</param>
    /// <returns>quantity measured in YoctoLumen</returns>
	public static Quantity<double, YoctoLumen> ToYoctoLumen<T>(this Quantity<T, ZettaLumen> val) where T:IConvertible {
        return new Quantity<double, YoctoLumen>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ExaLumen to YottaLumen
    /// </summary>
    /// <param name="val">quantity measured in ExaLumen</param>
    /// <returns>quantity measured in YottaLumen</returns>
	public static Quantity<double, YottaLumen> ToYottaLumen<T>(this Quantity<T, ExaLumen> val) where T:IConvertible {
        return new Quantity<double, YottaLumen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaLumen to ZettaLumen
    /// </summary>
    /// <param name="val">quantity measured in ExaLumen</param>
    /// <returns>quantity measured in ZettaLumen</returns>
	public static Quantity<double, ZettaLumen> ToZettaLumen<T>(this Quantity<T, ExaLumen> val) where T:IConvertible {
        return new Quantity<double, ZettaLumen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaLumen to PetaLumen
    /// </summary>
    /// <param name="val">quantity measured in ExaLumen</param>
    /// <returns>quantity measured in PetaLumen</returns>
	public static Quantity<double, PetaLumen> ToPetaLumen<T>(this Quantity<T, ExaLumen> val) where T:IConvertible {
        return new Quantity<double, PetaLumen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaLumen to TeraLumen
    /// </summary>
    /// <param name="val">quantity measured in ExaLumen</param>
    /// <returns>quantity measured in TeraLumen</returns>
	public static Quantity<double, TeraLumen> ToTeraLumen<T>(this Quantity<T, ExaLumen> val) where T:IConvertible {
        return new Quantity<double, TeraLumen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaLumen to GigaLumen
    /// </summary>
    /// <param name="val">quantity measured in ExaLumen</param>
    /// <returns>quantity measured in GigaLumen</returns>
	public static Quantity<double, GigaLumen> ToGigaLumen<T>(this Quantity<T, ExaLumen> val) where T:IConvertible {
        return new Quantity<double, GigaLumen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaLumen to MegaLumen
    /// </summary>
    /// <param name="val">quantity measured in ExaLumen</param>
    /// <returns>quantity measured in MegaLumen</returns>
	public static Quantity<double, MegaLumen> ToMegaLumen<T>(this Quantity<T, ExaLumen> val) where T:IConvertible {
        return new Quantity<double, MegaLumen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaLumen to KiloLumen
    /// </summary>
    /// <param name="val">quantity measured in ExaLumen</param>
    /// <returns>quantity measured in KiloLumen</returns>
	public static Quantity<double, KiloLumen> ToKiloLumen<T>(this Quantity<T, ExaLumen> val) where T:IConvertible {
        return new Quantity<double, KiloLumen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaLumen to HectoLumen
    /// </summary>
    /// <param name="val">quantity measured in ExaLumen</param>
    /// <returns>quantity measured in HectoLumen</returns>
	public static Quantity<double, HectoLumen> ToHectoLumen<T>(this Quantity<T, ExaLumen> val) where T:IConvertible {
        return new Quantity<double, HectoLumen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaLumen to DekaLumen
    /// </summary>
    /// <param name="val">quantity measured in ExaLumen</param>
    /// <returns>quantity measured in DekaLumen</returns>
	public static Quantity<double, DekaLumen> ToDekaLumen<T>(this Quantity<T, ExaLumen> val) where T:IConvertible {
        return new Quantity<double, DekaLumen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaLumen to DeciLumen
    /// </summary>
    /// <param name="val">quantity measured in ExaLumen</param>
    /// <returns>quantity measured in DeciLumen</returns>
	public static Quantity<double, DeciLumen> ToDeciLumen<T>(this Quantity<T, ExaLumen> val) where T:IConvertible {
        return new Quantity<double, DeciLumen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaLumen to CentiLumen
    /// </summary>
    /// <param name="val">quantity measured in ExaLumen</param>
    /// <returns>quantity measured in CentiLumen</returns>
	public static Quantity<double, CentiLumen> ToCentiLumen<T>(this Quantity<T, ExaLumen> val) where T:IConvertible {
        return new Quantity<double, CentiLumen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaLumen to MilliLumen
    /// </summary>
    /// <param name="val">quantity measured in ExaLumen</param>
    /// <returns>quantity measured in MilliLumen</returns>
	public static Quantity<double, MilliLumen> ToMilliLumen<T>(this Quantity<T, ExaLumen> val) where T:IConvertible {
        return new Quantity<double, MilliLumen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaLumen to MicroLumen
    /// </summary>
    /// <param name="val">quantity measured in ExaLumen</param>
    /// <returns>quantity measured in MicroLumen</returns>
	public static Quantity<double, MicroLumen> ToMicroLumen<T>(this Quantity<T, ExaLumen> val) where T:IConvertible {
        return new Quantity<double, MicroLumen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaLumen to NanoLumen
    /// </summary>
    /// <param name="val">quantity measured in ExaLumen</param>
    /// <returns>quantity measured in NanoLumen</returns>
	public static Quantity<double, NanoLumen> ToNanoLumen<T>(this Quantity<T, ExaLumen> val) where T:IConvertible {
        return new Quantity<double, NanoLumen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaLumen to PicoLumen
    /// </summary>
    /// <param name="val">quantity measured in ExaLumen</param>
    /// <returns>quantity measured in PicoLumen</returns>
	public static Quantity<double, PicoLumen> ToPicoLumen<T>(this Quantity<T, ExaLumen> val) where T:IConvertible {
        return new Quantity<double, PicoLumen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaLumen to FemtoLumen
    /// </summary>
    /// <param name="val">quantity measured in ExaLumen</param>
    /// <returns>quantity measured in FemtoLumen</returns>
	public static Quantity<double, FemtoLumen> ToFemtoLumen<T>(this Quantity<T, ExaLumen> val) where T:IConvertible {
        return new Quantity<double, FemtoLumen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaLumen to AttoLumen
    /// </summary>
    /// <param name="val">quantity measured in ExaLumen</param>
    /// <returns>quantity measured in AttoLumen</returns>
	public static Quantity<double, AttoLumen> ToAttoLumen<T>(this Quantity<T, ExaLumen> val) where T:IConvertible {
        return new Quantity<double, AttoLumen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaLumen to ZeptoLumen
    /// </summary>
    /// <param name="val">quantity measured in ExaLumen</param>
    /// <returns>quantity measured in ZeptoLumen</returns>
	public static Quantity<double, ZeptoLumen> ToZeptoLumen<T>(this Quantity<T, ExaLumen> val) where T:IConvertible {
        return new Quantity<double, ZeptoLumen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaLumen to YoctoLumen
    /// </summary>
    /// <param name="val">quantity measured in ExaLumen</param>
    /// <returns>quantity measured in YoctoLumen</returns>
	public static Quantity<double, YoctoLumen> ToYoctoLumen<T>(this Quantity<T, ExaLumen> val) where T:IConvertible {
        return new Quantity<double, YoctoLumen>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert PetaLumen to YottaLumen
    /// </summary>
    /// <param name="val">quantity measured in PetaLumen</param>
    /// <returns>quantity measured in YottaLumen</returns>
	public static Quantity<double, YottaLumen> ToYottaLumen<T>(this Quantity<T, PetaLumen> val) where T:IConvertible {
        return new Quantity<double, YottaLumen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaLumen to ZettaLumen
    /// </summary>
    /// <param name="val">quantity measured in PetaLumen</param>
    /// <returns>quantity measured in ZettaLumen</returns>
	public static Quantity<double, ZettaLumen> ToZettaLumen<T>(this Quantity<T, PetaLumen> val) where T:IConvertible {
        return new Quantity<double, ZettaLumen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaLumen to ExaLumen
    /// </summary>
    /// <param name="val">quantity measured in PetaLumen</param>
    /// <returns>quantity measured in ExaLumen</returns>
	public static Quantity<double, ExaLumen> ToExaLumen<T>(this Quantity<T, PetaLumen> val) where T:IConvertible {
        return new Quantity<double, ExaLumen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaLumen to TeraLumen
    /// </summary>
    /// <param name="val">quantity measured in PetaLumen</param>
    /// <returns>quantity measured in TeraLumen</returns>
	public static Quantity<double, TeraLumen> ToTeraLumen<T>(this Quantity<T, PetaLumen> val) where T:IConvertible {
        return new Quantity<double, TeraLumen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaLumen to GigaLumen
    /// </summary>
    /// <param name="val">quantity measured in PetaLumen</param>
    /// <returns>quantity measured in GigaLumen</returns>
	public static Quantity<double, GigaLumen> ToGigaLumen<T>(this Quantity<T, PetaLumen> val) where T:IConvertible {
        return new Quantity<double, GigaLumen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaLumen to MegaLumen
    /// </summary>
    /// <param name="val">quantity measured in PetaLumen</param>
    /// <returns>quantity measured in MegaLumen</returns>
	public static Quantity<double, MegaLumen> ToMegaLumen<T>(this Quantity<T, PetaLumen> val) where T:IConvertible {
        return new Quantity<double, MegaLumen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaLumen to KiloLumen
    /// </summary>
    /// <param name="val">quantity measured in PetaLumen</param>
    /// <returns>quantity measured in KiloLumen</returns>
	public static Quantity<double, KiloLumen> ToKiloLumen<T>(this Quantity<T, PetaLumen> val) where T:IConvertible {
        return new Quantity<double, KiloLumen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaLumen to HectoLumen
    /// </summary>
    /// <param name="val">quantity measured in PetaLumen</param>
    /// <returns>quantity measured in HectoLumen</returns>
	public static Quantity<double, HectoLumen> ToHectoLumen<T>(this Quantity<T, PetaLumen> val) where T:IConvertible {
        return new Quantity<double, HectoLumen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaLumen to DekaLumen
    /// </summary>
    /// <param name="val">quantity measured in PetaLumen</param>
    /// <returns>quantity measured in DekaLumen</returns>
	public static Quantity<double, DekaLumen> ToDekaLumen<T>(this Quantity<T, PetaLumen> val) where T:IConvertible {
        return new Quantity<double, DekaLumen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaLumen to DeciLumen
    /// </summary>
    /// <param name="val">quantity measured in PetaLumen</param>
    /// <returns>quantity measured in DeciLumen</returns>
	public static Quantity<double, DeciLumen> ToDeciLumen<T>(this Quantity<T, PetaLumen> val) where T:IConvertible {
        return new Quantity<double, DeciLumen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaLumen to CentiLumen
    /// </summary>
    /// <param name="val">quantity measured in PetaLumen</param>
    /// <returns>quantity measured in CentiLumen</returns>
	public static Quantity<double, CentiLumen> ToCentiLumen<T>(this Quantity<T, PetaLumen> val) where T:IConvertible {
        return new Quantity<double, CentiLumen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaLumen to MilliLumen
    /// </summary>
    /// <param name="val">quantity measured in PetaLumen</param>
    /// <returns>quantity measured in MilliLumen</returns>
	public static Quantity<double, MilliLumen> ToMilliLumen<T>(this Quantity<T, PetaLumen> val) where T:IConvertible {
        return new Quantity<double, MilliLumen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaLumen to MicroLumen
    /// </summary>
    /// <param name="val">quantity measured in PetaLumen</param>
    /// <returns>quantity measured in MicroLumen</returns>
	public static Quantity<double, MicroLumen> ToMicroLumen<T>(this Quantity<T, PetaLumen> val) where T:IConvertible {
        return new Quantity<double, MicroLumen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaLumen to NanoLumen
    /// </summary>
    /// <param name="val">quantity measured in PetaLumen</param>
    /// <returns>quantity measured in NanoLumen</returns>
	public static Quantity<double, NanoLumen> ToNanoLumen<T>(this Quantity<T, PetaLumen> val) where T:IConvertible {
        return new Quantity<double, NanoLumen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaLumen to PicoLumen
    /// </summary>
    /// <param name="val">quantity measured in PetaLumen</param>
    /// <returns>quantity measured in PicoLumen</returns>
	public static Quantity<double, PicoLumen> ToPicoLumen<T>(this Quantity<T, PetaLumen> val) where T:IConvertible {
        return new Quantity<double, PicoLumen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaLumen to FemtoLumen
    /// </summary>
    /// <param name="val">quantity measured in PetaLumen</param>
    /// <returns>quantity measured in FemtoLumen</returns>
	public static Quantity<double, FemtoLumen> ToFemtoLumen<T>(this Quantity<T, PetaLumen> val) where T:IConvertible {
        return new Quantity<double, FemtoLumen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaLumen to AttoLumen
    /// </summary>
    /// <param name="val">quantity measured in PetaLumen</param>
    /// <returns>quantity measured in AttoLumen</returns>
	public static Quantity<double, AttoLumen> ToAttoLumen<T>(this Quantity<T, PetaLumen> val) where T:IConvertible {
        return new Quantity<double, AttoLumen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaLumen to ZeptoLumen
    /// </summary>
    /// <param name="val">quantity measured in PetaLumen</param>
    /// <returns>quantity measured in ZeptoLumen</returns>
	public static Quantity<double, ZeptoLumen> ToZeptoLumen<T>(this Quantity<T, PetaLumen> val) where T:IConvertible {
        return new Quantity<double, ZeptoLumen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaLumen to YoctoLumen
    /// </summary>
    /// <param name="val">quantity measured in PetaLumen</param>
    /// <returns>quantity measured in YoctoLumen</returns>
	public static Quantity<double, YoctoLumen> ToYoctoLumen<T>(this Quantity<T, PetaLumen> val) where T:IConvertible {
        return new Quantity<double, YoctoLumen>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert TeraLumen to YottaLumen
    /// </summary>
    /// <param name="val">quantity measured in TeraLumen</param>
    /// <returns>quantity measured in YottaLumen</returns>
	public static Quantity<double, YottaLumen> ToYottaLumen<T>(this Quantity<T, TeraLumen> val) where T:IConvertible {
        return new Quantity<double, YottaLumen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraLumen to ZettaLumen
    /// </summary>
    /// <param name="val">quantity measured in TeraLumen</param>
    /// <returns>quantity measured in ZettaLumen</returns>
	public static Quantity<double, ZettaLumen> ToZettaLumen<T>(this Quantity<T, TeraLumen> val) where T:IConvertible {
        return new Quantity<double, ZettaLumen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraLumen to ExaLumen
    /// </summary>
    /// <param name="val">quantity measured in TeraLumen</param>
    /// <returns>quantity measured in ExaLumen</returns>
	public static Quantity<double, ExaLumen> ToExaLumen<T>(this Quantity<T, TeraLumen> val) where T:IConvertible {
        return new Quantity<double, ExaLumen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraLumen to PetaLumen
    /// </summary>
    /// <param name="val">quantity measured in TeraLumen</param>
    /// <returns>quantity measured in PetaLumen</returns>
	public static Quantity<double, PetaLumen> ToPetaLumen<T>(this Quantity<T, TeraLumen> val) where T:IConvertible {
        return new Quantity<double, PetaLumen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraLumen to GigaLumen
    /// </summary>
    /// <param name="val">quantity measured in TeraLumen</param>
    /// <returns>quantity measured in GigaLumen</returns>
	public static Quantity<double, GigaLumen> ToGigaLumen<T>(this Quantity<T, TeraLumen> val) where T:IConvertible {
        return new Quantity<double, GigaLumen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraLumen to MegaLumen
    /// </summary>
    /// <param name="val">quantity measured in TeraLumen</param>
    /// <returns>quantity measured in MegaLumen</returns>
	public static Quantity<double, MegaLumen> ToMegaLumen<T>(this Quantity<T, TeraLumen> val) where T:IConvertible {
        return new Quantity<double, MegaLumen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraLumen to KiloLumen
    /// </summary>
    /// <param name="val">quantity measured in TeraLumen</param>
    /// <returns>quantity measured in KiloLumen</returns>
	public static Quantity<double, KiloLumen> ToKiloLumen<T>(this Quantity<T, TeraLumen> val) where T:IConvertible {
        return new Quantity<double, KiloLumen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraLumen to HectoLumen
    /// </summary>
    /// <param name="val">quantity measured in TeraLumen</param>
    /// <returns>quantity measured in HectoLumen</returns>
	public static Quantity<double, HectoLumen> ToHectoLumen<T>(this Quantity<T, TeraLumen> val) where T:IConvertible {
        return new Quantity<double, HectoLumen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraLumen to DekaLumen
    /// </summary>
    /// <param name="val">quantity measured in TeraLumen</param>
    /// <returns>quantity measured in DekaLumen</returns>
	public static Quantity<double, DekaLumen> ToDekaLumen<T>(this Quantity<T, TeraLumen> val) where T:IConvertible {
        return new Quantity<double, DekaLumen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraLumen to DeciLumen
    /// </summary>
    /// <param name="val">quantity measured in TeraLumen</param>
    /// <returns>quantity measured in DeciLumen</returns>
	public static Quantity<double, DeciLumen> ToDeciLumen<T>(this Quantity<T, TeraLumen> val) where T:IConvertible {
        return new Quantity<double, DeciLumen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraLumen to CentiLumen
    /// </summary>
    /// <param name="val">quantity measured in TeraLumen</param>
    /// <returns>quantity measured in CentiLumen</returns>
	public static Quantity<double, CentiLumen> ToCentiLumen<T>(this Quantity<T, TeraLumen> val) where T:IConvertible {
        return new Quantity<double, CentiLumen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraLumen to MilliLumen
    /// </summary>
    /// <param name="val">quantity measured in TeraLumen</param>
    /// <returns>quantity measured in MilliLumen</returns>
	public static Quantity<double, MilliLumen> ToMilliLumen<T>(this Quantity<T, TeraLumen> val) where T:IConvertible {
        return new Quantity<double, MilliLumen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraLumen to MicroLumen
    /// </summary>
    /// <param name="val">quantity measured in TeraLumen</param>
    /// <returns>quantity measured in MicroLumen</returns>
	public static Quantity<double, MicroLumen> ToMicroLumen<T>(this Quantity<T, TeraLumen> val) where T:IConvertible {
        return new Quantity<double, MicroLumen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraLumen to NanoLumen
    /// </summary>
    /// <param name="val">quantity measured in TeraLumen</param>
    /// <returns>quantity measured in NanoLumen</returns>
	public static Quantity<double, NanoLumen> ToNanoLumen<T>(this Quantity<T, TeraLumen> val) where T:IConvertible {
        return new Quantity<double, NanoLumen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraLumen to PicoLumen
    /// </summary>
    /// <param name="val">quantity measured in TeraLumen</param>
    /// <returns>quantity measured in PicoLumen</returns>
	public static Quantity<double, PicoLumen> ToPicoLumen<T>(this Quantity<T, TeraLumen> val) where T:IConvertible {
        return new Quantity<double, PicoLumen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraLumen to FemtoLumen
    /// </summary>
    /// <param name="val">quantity measured in TeraLumen</param>
    /// <returns>quantity measured in FemtoLumen</returns>
	public static Quantity<double, FemtoLumen> ToFemtoLumen<T>(this Quantity<T, TeraLumen> val) where T:IConvertible {
        return new Quantity<double, FemtoLumen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraLumen to AttoLumen
    /// </summary>
    /// <param name="val">quantity measured in TeraLumen</param>
    /// <returns>quantity measured in AttoLumen</returns>
	public static Quantity<double, AttoLumen> ToAttoLumen<T>(this Quantity<T, TeraLumen> val) where T:IConvertible {
        return new Quantity<double, AttoLumen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraLumen to ZeptoLumen
    /// </summary>
    /// <param name="val">quantity measured in TeraLumen</param>
    /// <returns>quantity measured in ZeptoLumen</returns>
	public static Quantity<double, ZeptoLumen> ToZeptoLumen<T>(this Quantity<T, TeraLumen> val) where T:IConvertible {
        return new Quantity<double, ZeptoLumen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraLumen to YoctoLumen
    /// </summary>
    /// <param name="val">quantity measured in TeraLumen</param>
    /// <returns>quantity measured in YoctoLumen</returns>
	public static Quantity<double, YoctoLumen> ToYoctoLumen<T>(this Quantity<T, TeraLumen> val) where T:IConvertible {
        return new Quantity<double, YoctoLumen>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert GigaLumen to YottaLumen
    /// </summary>
    /// <param name="val">quantity measured in GigaLumen</param>
    /// <returns>quantity measured in YottaLumen</returns>
	public static Quantity<double, YottaLumen> ToYottaLumen<T>(this Quantity<T, GigaLumen> val) where T:IConvertible {
        return new Quantity<double, YottaLumen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaLumen to ZettaLumen
    /// </summary>
    /// <param name="val">quantity measured in GigaLumen</param>
    /// <returns>quantity measured in ZettaLumen</returns>
	public static Quantity<double, ZettaLumen> ToZettaLumen<T>(this Quantity<T, GigaLumen> val) where T:IConvertible {
        return new Quantity<double, ZettaLumen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaLumen to ExaLumen
    /// </summary>
    /// <param name="val">quantity measured in GigaLumen</param>
    /// <returns>quantity measured in ExaLumen</returns>
	public static Quantity<double, ExaLumen> ToExaLumen<T>(this Quantity<T, GigaLumen> val) where T:IConvertible {
        return new Quantity<double, ExaLumen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaLumen to PetaLumen
    /// </summary>
    /// <param name="val">quantity measured in GigaLumen</param>
    /// <returns>quantity measured in PetaLumen</returns>
	public static Quantity<double, PetaLumen> ToPetaLumen<T>(this Quantity<T, GigaLumen> val) where T:IConvertible {
        return new Quantity<double, PetaLumen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaLumen to TeraLumen
    /// </summary>
    /// <param name="val">quantity measured in GigaLumen</param>
    /// <returns>quantity measured in TeraLumen</returns>
	public static Quantity<double, TeraLumen> ToTeraLumen<T>(this Quantity<T, GigaLumen> val) where T:IConvertible {
        return new Quantity<double, TeraLumen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaLumen to MegaLumen
    /// </summary>
    /// <param name="val">quantity measured in GigaLumen</param>
    /// <returns>quantity measured in MegaLumen</returns>
	public static Quantity<double, MegaLumen> ToMegaLumen<T>(this Quantity<T, GigaLumen> val) where T:IConvertible {
        return new Quantity<double, MegaLumen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaLumen to KiloLumen
    /// </summary>
    /// <param name="val">quantity measured in GigaLumen</param>
    /// <returns>quantity measured in KiloLumen</returns>
	public static Quantity<double, KiloLumen> ToKiloLumen<T>(this Quantity<T, GigaLumen> val) where T:IConvertible {
        return new Quantity<double, KiloLumen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaLumen to HectoLumen
    /// </summary>
    /// <param name="val">quantity measured in GigaLumen</param>
    /// <returns>quantity measured in HectoLumen</returns>
	public static Quantity<double, HectoLumen> ToHectoLumen<T>(this Quantity<T, GigaLumen> val) where T:IConvertible {
        return new Quantity<double, HectoLumen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaLumen to DekaLumen
    /// </summary>
    /// <param name="val">quantity measured in GigaLumen</param>
    /// <returns>quantity measured in DekaLumen</returns>
	public static Quantity<double, DekaLumen> ToDekaLumen<T>(this Quantity<T, GigaLumen> val) where T:IConvertible {
        return new Quantity<double, DekaLumen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaLumen to DeciLumen
    /// </summary>
    /// <param name="val">quantity measured in GigaLumen</param>
    /// <returns>quantity measured in DeciLumen</returns>
	public static Quantity<double, DeciLumen> ToDeciLumen<T>(this Quantity<T, GigaLumen> val) where T:IConvertible {
        return new Quantity<double, DeciLumen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaLumen to CentiLumen
    /// </summary>
    /// <param name="val">quantity measured in GigaLumen</param>
    /// <returns>quantity measured in CentiLumen</returns>
	public static Quantity<double, CentiLumen> ToCentiLumen<T>(this Quantity<T, GigaLumen> val) where T:IConvertible {
        return new Quantity<double, CentiLumen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaLumen to MilliLumen
    /// </summary>
    /// <param name="val">quantity measured in GigaLumen</param>
    /// <returns>quantity measured in MilliLumen</returns>
	public static Quantity<double, MilliLumen> ToMilliLumen<T>(this Quantity<T, GigaLumen> val) where T:IConvertible {
        return new Quantity<double, MilliLumen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaLumen to MicroLumen
    /// </summary>
    /// <param name="val">quantity measured in GigaLumen</param>
    /// <returns>quantity measured in MicroLumen</returns>
	public static Quantity<double, MicroLumen> ToMicroLumen<T>(this Quantity<T, GigaLumen> val) where T:IConvertible {
        return new Quantity<double, MicroLumen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaLumen to NanoLumen
    /// </summary>
    /// <param name="val">quantity measured in GigaLumen</param>
    /// <returns>quantity measured in NanoLumen</returns>
	public static Quantity<double, NanoLumen> ToNanoLumen<T>(this Quantity<T, GigaLumen> val) where T:IConvertible {
        return new Quantity<double, NanoLumen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaLumen to PicoLumen
    /// </summary>
    /// <param name="val">quantity measured in GigaLumen</param>
    /// <returns>quantity measured in PicoLumen</returns>
	public static Quantity<double, PicoLumen> ToPicoLumen<T>(this Quantity<T, GigaLumen> val) where T:IConvertible {
        return new Quantity<double, PicoLumen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaLumen to FemtoLumen
    /// </summary>
    /// <param name="val">quantity measured in GigaLumen</param>
    /// <returns>quantity measured in FemtoLumen</returns>
	public static Quantity<double, FemtoLumen> ToFemtoLumen<T>(this Quantity<T, GigaLumen> val) where T:IConvertible {
        return new Quantity<double, FemtoLumen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaLumen to AttoLumen
    /// </summary>
    /// <param name="val">quantity measured in GigaLumen</param>
    /// <returns>quantity measured in AttoLumen</returns>
	public static Quantity<double, AttoLumen> ToAttoLumen<T>(this Quantity<T, GigaLumen> val) where T:IConvertible {
        return new Quantity<double, AttoLumen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaLumen to ZeptoLumen
    /// </summary>
    /// <param name="val">quantity measured in GigaLumen</param>
    /// <returns>quantity measured in ZeptoLumen</returns>
	public static Quantity<double, ZeptoLumen> ToZeptoLumen<T>(this Quantity<T, GigaLumen> val) where T:IConvertible {
        return new Quantity<double, ZeptoLumen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaLumen to YoctoLumen
    /// </summary>
    /// <param name="val">quantity measured in GigaLumen</param>
    /// <returns>quantity measured in YoctoLumen</returns>
	public static Quantity<double, YoctoLumen> ToYoctoLumen<T>(this Quantity<T, GigaLumen> val) where T:IConvertible {
        return new Quantity<double, YoctoLumen>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert MegaLumen to YottaLumen
    /// </summary>
    /// <param name="val">quantity measured in MegaLumen</param>
    /// <returns>quantity measured in YottaLumen</returns>
	public static Quantity<double, YottaLumen> ToYottaLumen<T>(this Quantity<T, MegaLumen> val) where T:IConvertible {
        return new Quantity<double, YottaLumen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaLumen to ZettaLumen
    /// </summary>
    /// <param name="val">quantity measured in MegaLumen</param>
    /// <returns>quantity measured in ZettaLumen</returns>
	public static Quantity<double, ZettaLumen> ToZettaLumen<T>(this Quantity<T, MegaLumen> val) where T:IConvertible {
        return new Quantity<double, ZettaLumen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaLumen to ExaLumen
    /// </summary>
    /// <param name="val">quantity measured in MegaLumen</param>
    /// <returns>quantity measured in ExaLumen</returns>
	public static Quantity<double, ExaLumen> ToExaLumen<T>(this Quantity<T, MegaLumen> val) where T:IConvertible {
        return new Quantity<double, ExaLumen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaLumen to PetaLumen
    /// </summary>
    /// <param name="val">quantity measured in MegaLumen</param>
    /// <returns>quantity measured in PetaLumen</returns>
	public static Quantity<double, PetaLumen> ToPetaLumen<T>(this Quantity<T, MegaLumen> val) where T:IConvertible {
        return new Quantity<double, PetaLumen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaLumen to TeraLumen
    /// </summary>
    /// <param name="val">quantity measured in MegaLumen</param>
    /// <returns>quantity measured in TeraLumen</returns>
	public static Quantity<double, TeraLumen> ToTeraLumen<T>(this Quantity<T, MegaLumen> val) where T:IConvertible {
        return new Quantity<double, TeraLumen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaLumen to GigaLumen
    /// </summary>
    /// <param name="val">quantity measured in MegaLumen</param>
    /// <returns>quantity measured in GigaLumen</returns>
	public static Quantity<double, GigaLumen> ToGigaLumen<T>(this Quantity<T, MegaLumen> val) where T:IConvertible {
        return new Quantity<double, GigaLumen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaLumen to KiloLumen
    /// </summary>
    /// <param name="val">quantity measured in MegaLumen</param>
    /// <returns>quantity measured in KiloLumen</returns>
	public static Quantity<double, KiloLumen> ToKiloLumen<T>(this Quantity<T, MegaLumen> val) where T:IConvertible {
        return new Quantity<double, KiloLumen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaLumen to HectoLumen
    /// </summary>
    /// <param name="val">quantity measured in MegaLumen</param>
    /// <returns>quantity measured in HectoLumen</returns>
	public static Quantity<double, HectoLumen> ToHectoLumen<T>(this Quantity<T, MegaLumen> val) where T:IConvertible {
        return new Quantity<double, HectoLumen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaLumen to DekaLumen
    /// </summary>
    /// <param name="val">quantity measured in MegaLumen</param>
    /// <returns>quantity measured in DekaLumen</returns>
	public static Quantity<double, DekaLumen> ToDekaLumen<T>(this Quantity<T, MegaLumen> val) where T:IConvertible {
        return new Quantity<double, DekaLumen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaLumen to DeciLumen
    /// </summary>
    /// <param name="val">quantity measured in MegaLumen</param>
    /// <returns>quantity measured in DeciLumen</returns>
	public static Quantity<double, DeciLumen> ToDeciLumen<T>(this Quantity<T, MegaLumen> val) where T:IConvertible {
        return new Quantity<double, DeciLumen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaLumen to CentiLumen
    /// </summary>
    /// <param name="val">quantity measured in MegaLumen</param>
    /// <returns>quantity measured in CentiLumen</returns>
	public static Quantity<double, CentiLumen> ToCentiLumen<T>(this Quantity<T, MegaLumen> val) where T:IConvertible {
        return new Quantity<double, CentiLumen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaLumen to MilliLumen
    /// </summary>
    /// <param name="val">quantity measured in MegaLumen</param>
    /// <returns>quantity measured in MilliLumen</returns>
	public static Quantity<double, MilliLumen> ToMilliLumen<T>(this Quantity<T, MegaLumen> val) where T:IConvertible {
        return new Quantity<double, MilliLumen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaLumen to MicroLumen
    /// </summary>
    /// <param name="val">quantity measured in MegaLumen</param>
    /// <returns>quantity measured in MicroLumen</returns>
	public static Quantity<double, MicroLumen> ToMicroLumen<T>(this Quantity<T, MegaLumen> val) where T:IConvertible {
        return new Quantity<double, MicroLumen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaLumen to NanoLumen
    /// </summary>
    /// <param name="val">quantity measured in MegaLumen</param>
    /// <returns>quantity measured in NanoLumen</returns>
	public static Quantity<double, NanoLumen> ToNanoLumen<T>(this Quantity<T, MegaLumen> val) where T:IConvertible {
        return new Quantity<double, NanoLumen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaLumen to PicoLumen
    /// </summary>
    /// <param name="val">quantity measured in MegaLumen</param>
    /// <returns>quantity measured in PicoLumen</returns>
	public static Quantity<double, PicoLumen> ToPicoLumen<T>(this Quantity<T, MegaLumen> val) where T:IConvertible {
        return new Quantity<double, PicoLumen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaLumen to FemtoLumen
    /// </summary>
    /// <param name="val">quantity measured in MegaLumen</param>
    /// <returns>quantity measured in FemtoLumen</returns>
	public static Quantity<double, FemtoLumen> ToFemtoLumen<T>(this Quantity<T, MegaLumen> val) where T:IConvertible {
        return new Quantity<double, FemtoLumen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaLumen to AttoLumen
    /// </summary>
    /// <param name="val">quantity measured in MegaLumen</param>
    /// <returns>quantity measured in AttoLumen</returns>
	public static Quantity<double, AttoLumen> ToAttoLumen<T>(this Quantity<T, MegaLumen> val) where T:IConvertible {
        return new Quantity<double, AttoLumen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaLumen to ZeptoLumen
    /// </summary>
    /// <param name="val">quantity measured in MegaLumen</param>
    /// <returns>quantity measured in ZeptoLumen</returns>
	public static Quantity<double, ZeptoLumen> ToZeptoLumen<T>(this Quantity<T, MegaLumen> val) where T:IConvertible {
        return new Quantity<double, ZeptoLumen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaLumen to YoctoLumen
    /// </summary>
    /// <param name="val">quantity measured in MegaLumen</param>
    /// <returns>quantity measured in YoctoLumen</returns>
	public static Quantity<double, YoctoLumen> ToYoctoLumen<T>(this Quantity<T, MegaLumen> val) where T:IConvertible {
        return new Quantity<double, YoctoLumen>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert KiloLumen to YottaLumen
    /// </summary>
    /// <param name="val">quantity measured in KiloLumen</param>
    /// <returns>quantity measured in YottaLumen</returns>
	public static Quantity<double, YottaLumen> ToYottaLumen<T>(this Quantity<T, KiloLumen> val) where T:IConvertible {
        return new Quantity<double, YottaLumen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloLumen to ZettaLumen
    /// </summary>
    /// <param name="val">quantity measured in KiloLumen</param>
    /// <returns>quantity measured in ZettaLumen</returns>
	public static Quantity<double, ZettaLumen> ToZettaLumen<T>(this Quantity<T, KiloLumen> val) where T:IConvertible {
        return new Quantity<double, ZettaLumen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloLumen to ExaLumen
    /// </summary>
    /// <param name="val">quantity measured in KiloLumen</param>
    /// <returns>quantity measured in ExaLumen</returns>
	public static Quantity<double, ExaLumen> ToExaLumen<T>(this Quantity<T, KiloLumen> val) where T:IConvertible {
        return new Quantity<double, ExaLumen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloLumen to PetaLumen
    /// </summary>
    /// <param name="val">quantity measured in KiloLumen</param>
    /// <returns>quantity measured in PetaLumen</returns>
	public static Quantity<double, PetaLumen> ToPetaLumen<T>(this Quantity<T, KiloLumen> val) where T:IConvertible {
        return new Quantity<double, PetaLumen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloLumen to TeraLumen
    /// </summary>
    /// <param name="val">quantity measured in KiloLumen</param>
    /// <returns>quantity measured in TeraLumen</returns>
	public static Quantity<double, TeraLumen> ToTeraLumen<T>(this Quantity<T, KiloLumen> val) where T:IConvertible {
        return new Quantity<double, TeraLumen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloLumen to GigaLumen
    /// </summary>
    /// <param name="val">quantity measured in KiloLumen</param>
    /// <returns>quantity measured in GigaLumen</returns>
	public static Quantity<double, GigaLumen> ToGigaLumen<T>(this Quantity<T, KiloLumen> val) where T:IConvertible {
        return new Quantity<double, GigaLumen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloLumen to MegaLumen
    /// </summary>
    /// <param name="val">quantity measured in KiloLumen</param>
    /// <returns>quantity measured in MegaLumen</returns>
	public static Quantity<double, MegaLumen> ToMegaLumen<T>(this Quantity<T, KiloLumen> val) where T:IConvertible {
        return new Quantity<double, MegaLumen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloLumen to HectoLumen
    /// </summary>
    /// <param name="val">quantity measured in KiloLumen</param>
    /// <returns>quantity measured in HectoLumen</returns>
	public static Quantity<double, HectoLumen> ToHectoLumen<T>(this Quantity<T, KiloLumen> val) where T:IConvertible {
        return new Quantity<double, HectoLumen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloLumen to DekaLumen
    /// </summary>
    /// <param name="val">quantity measured in KiloLumen</param>
    /// <returns>quantity measured in DekaLumen</returns>
	public static Quantity<double, DekaLumen> ToDekaLumen<T>(this Quantity<T, KiloLumen> val) where T:IConvertible {
        return new Quantity<double, DekaLumen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloLumen to DeciLumen
    /// </summary>
    /// <param name="val">quantity measured in KiloLumen</param>
    /// <returns>quantity measured in DeciLumen</returns>
	public static Quantity<double, DeciLumen> ToDeciLumen<T>(this Quantity<T, KiloLumen> val) where T:IConvertible {
        return new Quantity<double, DeciLumen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloLumen to CentiLumen
    /// </summary>
    /// <param name="val">quantity measured in KiloLumen</param>
    /// <returns>quantity measured in CentiLumen</returns>
	public static Quantity<double, CentiLumen> ToCentiLumen<T>(this Quantity<T, KiloLumen> val) where T:IConvertible {
        return new Quantity<double, CentiLumen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloLumen to MilliLumen
    /// </summary>
    /// <param name="val">quantity measured in KiloLumen</param>
    /// <returns>quantity measured in MilliLumen</returns>
	public static Quantity<double, MilliLumen> ToMilliLumen<T>(this Quantity<T, KiloLumen> val) where T:IConvertible {
        return new Quantity<double, MilliLumen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloLumen to MicroLumen
    /// </summary>
    /// <param name="val">quantity measured in KiloLumen</param>
    /// <returns>quantity measured in MicroLumen</returns>
	public static Quantity<double, MicroLumen> ToMicroLumen<T>(this Quantity<T, KiloLumen> val) where T:IConvertible {
        return new Quantity<double, MicroLumen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloLumen to NanoLumen
    /// </summary>
    /// <param name="val">quantity measured in KiloLumen</param>
    /// <returns>quantity measured in NanoLumen</returns>
	public static Quantity<double, NanoLumen> ToNanoLumen<T>(this Quantity<T, KiloLumen> val) where T:IConvertible {
        return new Quantity<double, NanoLumen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloLumen to PicoLumen
    /// </summary>
    /// <param name="val">quantity measured in KiloLumen</param>
    /// <returns>quantity measured in PicoLumen</returns>
	public static Quantity<double, PicoLumen> ToPicoLumen<T>(this Quantity<T, KiloLumen> val) where T:IConvertible {
        return new Quantity<double, PicoLumen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloLumen to FemtoLumen
    /// </summary>
    /// <param name="val">quantity measured in KiloLumen</param>
    /// <returns>quantity measured in FemtoLumen</returns>
	public static Quantity<double, FemtoLumen> ToFemtoLumen<T>(this Quantity<T, KiloLumen> val) where T:IConvertible {
        return new Quantity<double, FemtoLumen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloLumen to AttoLumen
    /// </summary>
    /// <param name="val">quantity measured in KiloLumen</param>
    /// <returns>quantity measured in AttoLumen</returns>
	public static Quantity<double, AttoLumen> ToAttoLumen<T>(this Quantity<T, KiloLumen> val) where T:IConvertible {
        return new Quantity<double, AttoLumen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloLumen to ZeptoLumen
    /// </summary>
    /// <param name="val">quantity measured in KiloLumen</param>
    /// <returns>quantity measured in ZeptoLumen</returns>
	public static Quantity<double, ZeptoLumen> ToZeptoLumen<T>(this Quantity<T, KiloLumen> val) where T:IConvertible {
        return new Quantity<double, ZeptoLumen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloLumen to YoctoLumen
    /// </summary>
    /// <param name="val">quantity measured in KiloLumen</param>
    /// <returns>quantity measured in YoctoLumen</returns>
	public static Quantity<double, YoctoLumen> ToYoctoLumen<T>(this Quantity<T, KiloLumen> val) where T:IConvertible {
        return new Quantity<double, YoctoLumen>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert HectoLumen to YottaLumen
    /// </summary>
    /// <param name="val">quantity measured in HectoLumen</param>
    /// <returns>quantity measured in YottaLumen</returns>
	public static Quantity<double, YottaLumen> ToYottaLumen<T>(this Quantity<T, HectoLumen> val) where T:IConvertible {
        return new Quantity<double, YottaLumen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoLumen to ZettaLumen
    /// </summary>
    /// <param name="val">quantity measured in HectoLumen</param>
    /// <returns>quantity measured in ZettaLumen</returns>
	public static Quantity<double, ZettaLumen> ToZettaLumen<T>(this Quantity<T, HectoLumen> val) where T:IConvertible {
        return new Quantity<double, ZettaLumen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoLumen to ExaLumen
    /// </summary>
    /// <param name="val">quantity measured in HectoLumen</param>
    /// <returns>quantity measured in ExaLumen</returns>
	public static Quantity<double, ExaLumen> ToExaLumen<T>(this Quantity<T, HectoLumen> val) where T:IConvertible {
        return new Quantity<double, ExaLumen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoLumen to PetaLumen
    /// </summary>
    /// <param name="val">quantity measured in HectoLumen</param>
    /// <returns>quantity measured in PetaLumen</returns>
	public static Quantity<double, PetaLumen> ToPetaLumen<T>(this Quantity<T, HectoLumen> val) where T:IConvertible {
        return new Quantity<double, PetaLumen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoLumen to TeraLumen
    /// </summary>
    /// <param name="val">quantity measured in HectoLumen</param>
    /// <returns>quantity measured in TeraLumen</returns>
	public static Quantity<double, TeraLumen> ToTeraLumen<T>(this Quantity<T, HectoLumen> val) where T:IConvertible {
        return new Quantity<double, TeraLumen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoLumen to GigaLumen
    /// </summary>
    /// <param name="val">quantity measured in HectoLumen</param>
    /// <returns>quantity measured in GigaLumen</returns>
	public static Quantity<double, GigaLumen> ToGigaLumen<T>(this Quantity<T, HectoLumen> val) where T:IConvertible {
        return new Quantity<double, GigaLumen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoLumen to MegaLumen
    /// </summary>
    /// <param name="val">quantity measured in HectoLumen</param>
    /// <returns>quantity measured in MegaLumen</returns>
	public static Quantity<double, MegaLumen> ToMegaLumen<T>(this Quantity<T, HectoLumen> val) where T:IConvertible {
        return new Quantity<double, MegaLumen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoLumen to KiloLumen
    /// </summary>
    /// <param name="val">quantity measured in HectoLumen</param>
    /// <returns>quantity measured in KiloLumen</returns>
	public static Quantity<double, KiloLumen> ToKiloLumen<T>(this Quantity<T, HectoLumen> val) where T:IConvertible {
        return new Quantity<double, KiloLumen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoLumen to DekaLumen
    /// </summary>
    /// <param name="val">quantity measured in HectoLumen</param>
    /// <returns>quantity measured in DekaLumen</returns>
	public static Quantity<double, DekaLumen> ToDekaLumen<T>(this Quantity<T, HectoLumen> val) where T:IConvertible {
        return new Quantity<double, DekaLumen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoLumen to DeciLumen
    /// </summary>
    /// <param name="val">quantity measured in HectoLumen</param>
    /// <returns>quantity measured in DeciLumen</returns>
	public static Quantity<double, DeciLumen> ToDeciLumen<T>(this Quantity<T, HectoLumen> val) where T:IConvertible {
        return new Quantity<double, DeciLumen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoLumen to CentiLumen
    /// </summary>
    /// <param name="val">quantity measured in HectoLumen</param>
    /// <returns>quantity measured in CentiLumen</returns>
	public static Quantity<double, CentiLumen> ToCentiLumen<T>(this Quantity<T, HectoLumen> val) where T:IConvertible {
        return new Quantity<double, CentiLumen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoLumen to MilliLumen
    /// </summary>
    /// <param name="val">quantity measured in HectoLumen</param>
    /// <returns>quantity measured in MilliLumen</returns>
	public static Quantity<double, MilliLumen> ToMilliLumen<T>(this Quantity<T, HectoLumen> val) where T:IConvertible {
        return new Quantity<double, MilliLumen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoLumen to MicroLumen
    /// </summary>
    /// <param name="val">quantity measured in HectoLumen</param>
    /// <returns>quantity measured in MicroLumen</returns>
	public static Quantity<double, MicroLumen> ToMicroLumen<T>(this Quantity<T, HectoLumen> val) where T:IConvertible {
        return new Quantity<double, MicroLumen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoLumen to NanoLumen
    /// </summary>
    /// <param name="val">quantity measured in HectoLumen</param>
    /// <returns>quantity measured in NanoLumen</returns>
	public static Quantity<double, NanoLumen> ToNanoLumen<T>(this Quantity<T, HectoLumen> val) where T:IConvertible {
        return new Quantity<double, NanoLumen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoLumen to PicoLumen
    /// </summary>
    /// <param name="val">quantity measured in HectoLumen</param>
    /// <returns>quantity measured in PicoLumen</returns>
	public static Quantity<double, PicoLumen> ToPicoLumen<T>(this Quantity<T, HectoLumen> val) where T:IConvertible {
        return new Quantity<double, PicoLumen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoLumen to FemtoLumen
    /// </summary>
    /// <param name="val">quantity measured in HectoLumen</param>
    /// <returns>quantity measured in FemtoLumen</returns>
	public static Quantity<double, FemtoLumen> ToFemtoLumen<T>(this Quantity<T, HectoLumen> val) where T:IConvertible {
        return new Quantity<double, FemtoLumen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoLumen to AttoLumen
    /// </summary>
    /// <param name="val">quantity measured in HectoLumen</param>
    /// <returns>quantity measured in AttoLumen</returns>
	public static Quantity<double, AttoLumen> ToAttoLumen<T>(this Quantity<T, HectoLumen> val) where T:IConvertible {
        return new Quantity<double, AttoLumen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoLumen to ZeptoLumen
    /// </summary>
    /// <param name="val">quantity measured in HectoLumen</param>
    /// <returns>quantity measured in ZeptoLumen</returns>
	public static Quantity<double, ZeptoLumen> ToZeptoLumen<T>(this Quantity<T, HectoLumen> val) where T:IConvertible {
        return new Quantity<double, ZeptoLumen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoLumen to YoctoLumen
    /// </summary>
    /// <param name="val">quantity measured in HectoLumen</param>
    /// <returns>quantity measured in YoctoLumen</returns>
	public static Quantity<double, YoctoLumen> ToYoctoLumen<T>(this Quantity<T, HectoLumen> val) where T:IConvertible {
        return new Quantity<double, YoctoLumen>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert DekaLumen to YottaLumen
    /// </summary>
    /// <param name="val">quantity measured in DekaLumen</param>
    /// <returns>quantity measured in YottaLumen</returns>
	public static Quantity<double, YottaLumen> ToYottaLumen<T>(this Quantity<T, DekaLumen> val) where T:IConvertible {
        return new Quantity<double, YottaLumen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaLumen to ZettaLumen
    /// </summary>
    /// <param name="val">quantity measured in DekaLumen</param>
    /// <returns>quantity measured in ZettaLumen</returns>
	public static Quantity<double, ZettaLumen> ToZettaLumen<T>(this Quantity<T, DekaLumen> val) where T:IConvertible {
        return new Quantity<double, ZettaLumen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaLumen to ExaLumen
    /// </summary>
    /// <param name="val">quantity measured in DekaLumen</param>
    /// <returns>quantity measured in ExaLumen</returns>
	public static Quantity<double, ExaLumen> ToExaLumen<T>(this Quantity<T, DekaLumen> val) where T:IConvertible {
        return new Quantity<double, ExaLumen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaLumen to PetaLumen
    /// </summary>
    /// <param name="val">quantity measured in DekaLumen</param>
    /// <returns>quantity measured in PetaLumen</returns>
	public static Quantity<double, PetaLumen> ToPetaLumen<T>(this Quantity<T, DekaLumen> val) where T:IConvertible {
        return new Quantity<double, PetaLumen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaLumen to TeraLumen
    /// </summary>
    /// <param name="val">quantity measured in DekaLumen</param>
    /// <returns>quantity measured in TeraLumen</returns>
	public static Quantity<double, TeraLumen> ToTeraLumen<T>(this Quantity<T, DekaLumen> val) where T:IConvertible {
        return new Quantity<double, TeraLumen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaLumen to GigaLumen
    /// </summary>
    /// <param name="val">quantity measured in DekaLumen</param>
    /// <returns>quantity measured in GigaLumen</returns>
	public static Quantity<double, GigaLumen> ToGigaLumen<T>(this Quantity<T, DekaLumen> val) where T:IConvertible {
        return new Quantity<double, GigaLumen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaLumen to MegaLumen
    /// </summary>
    /// <param name="val">quantity measured in DekaLumen</param>
    /// <returns>quantity measured in MegaLumen</returns>
	public static Quantity<double, MegaLumen> ToMegaLumen<T>(this Quantity<T, DekaLumen> val) where T:IConvertible {
        return new Quantity<double, MegaLumen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaLumen to KiloLumen
    /// </summary>
    /// <param name="val">quantity measured in DekaLumen</param>
    /// <returns>quantity measured in KiloLumen</returns>
	public static Quantity<double, KiloLumen> ToKiloLumen<T>(this Quantity<T, DekaLumen> val) where T:IConvertible {
        return new Quantity<double, KiloLumen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaLumen to HectoLumen
    /// </summary>
    /// <param name="val">quantity measured in DekaLumen</param>
    /// <returns>quantity measured in HectoLumen</returns>
	public static Quantity<double, HectoLumen> ToHectoLumen<T>(this Quantity<T, DekaLumen> val) where T:IConvertible {
        return new Quantity<double, HectoLumen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaLumen to DeciLumen
    /// </summary>
    /// <param name="val">quantity measured in DekaLumen</param>
    /// <returns>quantity measured in DeciLumen</returns>
	public static Quantity<double, DeciLumen> ToDeciLumen<T>(this Quantity<T, DekaLumen> val) where T:IConvertible {
        return new Quantity<double, DeciLumen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaLumen to CentiLumen
    /// </summary>
    /// <param name="val">quantity measured in DekaLumen</param>
    /// <returns>quantity measured in CentiLumen</returns>
	public static Quantity<double, CentiLumen> ToCentiLumen<T>(this Quantity<T, DekaLumen> val) where T:IConvertible {
        return new Quantity<double, CentiLumen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaLumen to MilliLumen
    /// </summary>
    /// <param name="val">quantity measured in DekaLumen</param>
    /// <returns>quantity measured in MilliLumen</returns>
	public static Quantity<double, MilliLumen> ToMilliLumen<T>(this Quantity<T, DekaLumen> val) where T:IConvertible {
        return new Quantity<double, MilliLumen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaLumen to MicroLumen
    /// </summary>
    /// <param name="val">quantity measured in DekaLumen</param>
    /// <returns>quantity measured in MicroLumen</returns>
	public static Quantity<double, MicroLumen> ToMicroLumen<T>(this Quantity<T, DekaLumen> val) where T:IConvertible {
        return new Quantity<double, MicroLumen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaLumen to NanoLumen
    /// </summary>
    /// <param name="val">quantity measured in DekaLumen</param>
    /// <returns>quantity measured in NanoLumen</returns>
	public static Quantity<double, NanoLumen> ToNanoLumen<T>(this Quantity<T, DekaLumen> val) where T:IConvertible {
        return new Quantity<double, NanoLumen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaLumen to PicoLumen
    /// </summary>
    /// <param name="val">quantity measured in DekaLumen</param>
    /// <returns>quantity measured in PicoLumen</returns>
	public static Quantity<double, PicoLumen> ToPicoLumen<T>(this Quantity<T, DekaLumen> val) where T:IConvertible {
        return new Quantity<double, PicoLumen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaLumen to FemtoLumen
    /// </summary>
    /// <param name="val">quantity measured in DekaLumen</param>
    /// <returns>quantity measured in FemtoLumen</returns>
	public static Quantity<double, FemtoLumen> ToFemtoLumen<T>(this Quantity<T, DekaLumen> val) where T:IConvertible {
        return new Quantity<double, FemtoLumen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaLumen to AttoLumen
    /// </summary>
    /// <param name="val">quantity measured in DekaLumen</param>
    /// <returns>quantity measured in AttoLumen</returns>
	public static Quantity<double, AttoLumen> ToAttoLumen<T>(this Quantity<T, DekaLumen> val) where T:IConvertible {
        return new Quantity<double, AttoLumen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaLumen to ZeptoLumen
    /// </summary>
    /// <param name="val">quantity measured in DekaLumen</param>
    /// <returns>quantity measured in ZeptoLumen</returns>
	public static Quantity<double, ZeptoLumen> ToZeptoLumen<T>(this Quantity<T, DekaLumen> val) where T:IConvertible {
        return new Quantity<double, ZeptoLumen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaLumen to YoctoLumen
    /// </summary>
    /// <param name="val">quantity measured in DekaLumen</param>
    /// <returns>quantity measured in YoctoLumen</returns>
	public static Quantity<double, YoctoLumen> ToYoctoLumen<T>(this Quantity<T, DekaLumen> val) where T:IConvertible {
        return new Quantity<double, YoctoLumen>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DeciLumen to YottaLumen
    /// </summary>
    /// <param name="val">quantity measured in DeciLumen</param>
    /// <returns>quantity measured in YottaLumen</returns>
	public static Quantity<double, YottaLumen> ToYottaLumen<T>(this Quantity<T, DeciLumen> val) where T:IConvertible {
        return new Quantity<double, YottaLumen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciLumen to ZettaLumen
    /// </summary>
    /// <param name="val">quantity measured in DeciLumen</param>
    /// <returns>quantity measured in ZettaLumen</returns>
	public static Quantity<double, ZettaLumen> ToZettaLumen<T>(this Quantity<T, DeciLumen> val) where T:IConvertible {
        return new Quantity<double, ZettaLumen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciLumen to ExaLumen
    /// </summary>
    /// <param name="val">quantity measured in DeciLumen</param>
    /// <returns>quantity measured in ExaLumen</returns>
	public static Quantity<double, ExaLumen> ToExaLumen<T>(this Quantity<T, DeciLumen> val) where T:IConvertible {
        return new Quantity<double, ExaLumen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciLumen to PetaLumen
    /// </summary>
    /// <param name="val">quantity measured in DeciLumen</param>
    /// <returns>quantity measured in PetaLumen</returns>
	public static Quantity<double, PetaLumen> ToPetaLumen<T>(this Quantity<T, DeciLumen> val) where T:IConvertible {
        return new Quantity<double, PetaLumen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciLumen to TeraLumen
    /// </summary>
    /// <param name="val">quantity measured in DeciLumen</param>
    /// <returns>quantity measured in TeraLumen</returns>
	public static Quantity<double, TeraLumen> ToTeraLumen<T>(this Quantity<T, DeciLumen> val) where T:IConvertible {
        return new Quantity<double, TeraLumen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciLumen to GigaLumen
    /// </summary>
    /// <param name="val">quantity measured in DeciLumen</param>
    /// <returns>quantity measured in GigaLumen</returns>
	public static Quantity<double, GigaLumen> ToGigaLumen<T>(this Quantity<T, DeciLumen> val) where T:IConvertible {
        return new Quantity<double, GigaLumen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciLumen to MegaLumen
    /// </summary>
    /// <param name="val">quantity measured in DeciLumen</param>
    /// <returns>quantity measured in MegaLumen</returns>
	public static Quantity<double, MegaLumen> ToMegaLumen<T>(this Quantity<T, DeciLumen> val) where T:IConvertible {
        return new Quantity<double, MegaLumen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciLumen to KiloLumen
    /// </summary>
    /// <param name="val">quantity measured in DeciLumen</param>
    /// <returns>quantity measured in KiloLumen</returns>
	public static Quantity<double, KiloLumen> ToKiloLumen<T>(this Quantity<T, DeciLumen> val) where T:IConvertible {
        return new Quantity<double, KiloLumen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciLumen to HectoLumen
    /// </summary>
    /// <param name="val">quantity measured in DeciLumen</param>
    /// <returns>quantity measured in HectoLumen</returns>
	public static Quantity<double, HectoLumen> ToHectoLumen<T>(this Quantity<T, DeciLumen> val) where T:IConvertible {
        return new Quantity<double, HectoLumen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciLumen to DekaLumen
    /// </summary>
    /// <param name="val">quantity measured in DeciLumen</param>
    /// <returns>quantity measured in DekaLumen</returns>
	public static Quantity<double, DekaLumen> ToDekaLumen<T>(this Quantity<T, DeciLumen> val) where T:IConvertible {
        return new Quantity<double, DekaLumen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciLumen to CentiLumen
    /// </summary>
    /// <param name="val">quantity measured in DeciLumen</param>
    /// <returns>quantity measured in CentiLumen</returns>
	public static Quantity<double, CentiLumen> ToCentiLumen<T>(this Quantity<T, DeciLumen> val) where T:IConvertible {
        return new Quantity<double, CentiLumen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciLumen to MilliLumen
    /// </summary>
    /// <param name="val">quantity measured in DeciLumen</param>
    /// <returns>quantity measured in MilliLumen</returns>
	public static Quantity<double, MilliLumen> ToMilliLumen<T>(this Quantity<T, DeciLumen> val) where T:IConvertible {
        return new Quantity<double, MilliLumen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciLumen to MicroLumen
    /// </summary>
    /// <param name="val">quantity measured in DeciLumen</param>
    /// <returns>quantity measured in MicroLumen</returns>
	public static Quantity<double, MicroLumen> ToMicroLumen<T>(this Quantity<T, DeciLumen> val) where T:IConvertible {
        return new Quantity<double, MicroLumen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciLumen to NanoLumen
    /// </summary>
    /// <param name="val">quantity measured in DeciLumen</param>
    /// <returns>quantity measured in NanoLumen</returns>
	public static Quantity<double, NanoLumen> ToNanoLumen<T>(this Quantity<T, DeciLumen> val) where T:IConvertible {
        return new Quantity<double, NanoLumen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciLumen to PicoLumen
    /// </summary>
    /// <param name="val">quantity measured in DeciLumen</param>
    /// <returns>quantity measured in PicoLumen</returns>
	public static Quantity<double, PicoLumen> ToPicoLumen<T>(this Quantity<T, DeciLumen> val) where T:IConvertible {
        return new Quantity<double, PicoLumen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciLumen to FemtoLumen
    /// </summary>
    /// <param name="val">quantity measured in DeciLumen</param>
    /// <returns>quantity measured in FemtoLumen</returns>
	public static Quantity<double, FemtoLumen> ToFemtoLumen<T>(this Quantity<T, DeciLumen> val) where T:IConvertible {
        return new Quantity<double, FemtoLumen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciLumen to AttoLumen
    /// </summary>
    /// <param name="val">quantity measured in DeciLumen</param>
    /// <returns>quantity measured in AttoLumen</returns>
	public static Quantity<double, AttoLumen> ToAttoLumen<T>(this Quantity<T, DeciLumen> val) where T:IConvertible {
        return new Quantity<double, AttoLumen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciLumen to ZeptoLumen
    /// </summary>
    /// <param name="val">quantity measured in DeciLumen</param>
    /// <returns>quantity measured in ZeptoLumen</returns>
	public static Quantity<double, ZeptoLumen> ToZeptoLumen<T>(this Quantity<T, DeciLumen> val) where T:IConvertible {
        return new Quantity<double, ZeptoLumen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciLumen to YoctoLumen
    /// </summary>
    /// <param name="val">quantity measured in DeciLumen</param>
    /// <returns>quantity measured in YoctoLumen</returns>
	public static Quantity<double, YoctoLumen> ToYoctoLumen<T>(this Quantity<T, DeciLumen> val) where T:IConvertible {
        return new Quantity<double, YoctoLumen>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert CentiLumen to YottaLumen
    /// </summary>
    /// <param name="val">quantity measured in CentiLumen</param>
    /// <returns>quantity measured in YottaLumen</returns>
	public static Quantity<double, YottaLumen> ToYottaLumen<T>(this Quantity<T, CentiLumen> val) where T:IConvertible {
        return new Quantity<double, YottaLumen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiLumen to ZettaLumen
    /// </summary>
    /// <param name="val">quantity measured in CentiLumen</param>
    /// <returns>quantity measured in ZettaLumen</returns>
	public static Quantity<double, ZettaLumen> ToZettaLumen<T>(this Quantity<T, CentiLumen> val) where T:IConvertible {
        return new Quantity<double, ZettaLumen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiLumen to ExaLumen
    /// </summary>
    /// <param name="val">quantity measured in CentiLumen</param>
    /// <returns>quantity measured in ExaLumen</returns>
	public static Quantity<double, ExaLumen> ToExaLumen<T>(this Quantity<T, CentiLumen> val) where T:IConvertible {
        return new Quantity<double, ExaLumen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiLumen to PetaLumen
    /// </summary>
    /// <param name="val">quantity measured in CentiLumen</param>
    /// <returns>quantity measured in PetaLumen</returns>
	public static Quantity<double, PetaLumen> ToPetaLumen<T>(this Quantity<T, CentiLumen> val) where T:IConvertible {
        return new Quantity<double, PetaLumen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiLumen to TeraLumen
    /// </summary>
    /// <param name="val">quantity measured in CentiLumen</param>
    /// <returns>quantity measured in TeraLumen</returns>
	public static Quantity<double, TeraLumen> ToTeraLumen<T>(this Quantity<T, CentiLumen> val) where T:IConvertible {
        return new Quantity<double, TeraLumen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiLumen to GigaLumen
    /// </summary>
    /// <param name="val">quantity measured in CentiLumen</param>
    /// <returns>quantity measured in GigaLumen</returns>
	public static Quantity<double, GigaLumen> ToGigaLumen<T>(this Quantity<T, CentiLumen> val) where T:IConvertible {
        return new Quantity<double, GigaLumen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiLumen to MegaLumen
    /// </summary>
    /// <param name="val">quantity measured in CentiLumen</param>
    /// <returns>quantity measured in MegaLumen</returns>
	public static Quantity<double, MegaLumen> ToMegaLumen<T>(this Quantity<T, CentiLumen> val) where T:IConvertible {
        return new Quantity<double, MegaLumen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiLumen to KiloLumen
    /// </summary>
    /// <param name="val">quantity measured in CentiLumen</param>
    /// <returns>quantity measured in KiloLumen</returns>
	public static Quantity<double, KiloLumen> ToKiloLumen<T>(this Quantity<T, CentiLumen> val) where T:IConvertible {
        return new Quantity<double, KiloLumen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiLumen to HectoLumen
    /// </summary>
    /// <param name="val">quantity measured in CentiLumen</param>
    /// <returns>quantity measured in HectoLumen</returns>
	public static Quantity<double, HectoLumen> ToHectoLumen<T>(this Quantity<T, CentiLumen> val) where T:IConvertible {
        return new Quantity<double, HectoLumen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiLumen to DekaLumen
    /// </summary>
    /// <param name="val">quantity measured in CentiLumen</param>
    /// <returns>quantity measured in DekaLumen</returns>
	public static Quantity<double, DekaLumen> ToDekaLumen<T>(this Quantity<T, CentiLumen> val) where T:IConvertible {
        return new Quantity<double, DekaLumen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiLumen to DeciLumen
    /// </summary>
    /// <param name="val">quantity measured in CentiLumen</param>
    /// <returns>quantity measured in DeciLumen</returns>
	public static Quantity<double, DeciLumen> ToDeciLumen<T>(this Quantity<T, CentiLumen> val) where T:IConvertible {
        return new Quantity<double, DeciLumen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiLumen to MilliLumen
    /// </summary>
    /// <param name="val">quantity measured in CentiLumen</param>
    /// <returns>quantity measured in MilliLumen</returns>
	public static Quantity<double, MilliLumen> ToMilliLumen<T>(this Quantity<T, CentiLumen> val) where T:IConvertible {
        return new Quantity<double, MilliLumen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiLumen to MicroLumen
    /// </summary>
    /// <param name="val">quantity measured in CentiLumen</param>
    /// <returns>quantity measured in MicroLumen</returns>
	public static Quantity<double, MicroLumen> ToMicroLumen<T>(this Quantity<T, CentiLumen> val) where T:IConvertible {
        return new Quantity<double, MicroLumen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiLumen to NanoLumen
    /// </summary>
    /// <param name="val">quantity measured in CentiLumen</param>
    /// <returns>quantity measured in NanoLumen</returns>
	public static Quantity<double, NanoLumen> ToNanoLumen<T>(this Quantity<T, CentiLumen> val) where T:IConvertible {
        return new Quantity<double, NanoLumen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiLumen to PicoLumen
    /// </summary>
    /// <param name="val">quantity measured in CentiLumen</param>
    /// <returns>quantity measured in PicoLumen</returns>
	public static Quantity<double, PicoLumen> ToPicoLumen<T>(this Quantity<T, CentiLumen> val) where T:IConvertible {
        return new Quantity<double, PicoLumen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiLumen to FemtoLumen
    /// </summary>
    /// <param name="val">quantity measured in CentiLumen</param>
    /// <returns>quantity measured in FemtoLumen</returns>
	public static Quantity<double, FemtoLumen> ToFemtoLumen<T>(this Quantity<T, CentiLumen> val) where T:IConvertible {
        return new Quantity<double, FemtoLumen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiLumen to AttoLumen
    /// </summary>
    /// <param name="val">quantity measured in CentiLumen</param>
    /// <returns>quantity measured in AttoLumen</returns>
	public static Quantity<double, AttoLumen> ToAttoLumen<T>(this Quantity<T, CentiLumen> val) where T:IConvertible {
        return new Quantity<double, AttoLumen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiLumen to ZeptoLumen
    /// </summary>
    /// <param name="val">quantity measured in CentiLumen</param>
    /// <returns>quantity measured in ZeptoLumen</returns>
	public static Quantity<double, ZeptoLumen> ToZeptoLumen<T>(this Quantity<T, CentiLumen> val) where T:IConvertible {
        return new Quantity<double, ZeptoLumen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiLumen to YoctoLumen
    /// </summary>
    /// <param name="val">quantity measured in CentiLumen</param>
    /// <returns>quantity measured in YoctoLumen</returns>
	public static Quantity<double, YoctoLumen> ToYoctoLumen<T>(this Quantity<T, CentiLumen> val) where T:IConvertible {
        return new Quantity<double, YoctoLumen>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert MilliLumen to YottaLumen
    /// </summary>
    /// <param name="val">quantity measured in MilliLumen</param>
    /// <returns>quantity measured in YottaLumen</returns>
	public static Quantity<double, YottaLumen> ToYottaLumen<T>(this Quantity<T, MilliLumen> val) where T:IConvertible {
        return new Quantity<double, YottaLumen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliLumen to ZettaLumen
    /// </summary>
    /// <param name="val">quantity measured in MilliLumen</param>
    /// <returns>quantity measured in ZettaLumen</returns>
	public static Quantity<double, ZettaLumen> ToZettaLumen<T>(this Quantity<T, MilliLumen> val) where T:IConvertible {
        return new Quantity<double, ZettaLumen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliLumen to ExaLumen
    /// </summary>
    /// <param name="val">quantity measured in MilliLumen</param>
    /// <returns>quantity measured in ExaLumen</returns>
	public static Quantity<double, ExaLumen> ToExaLumen<T>(this Quantity<T, MilliLumen> val) where T:IConvertible {
        return new Quantity<double, ExaLumen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliLumen to PetaLumen
    /// </summary>
    /// <param name="val">quantity measured in MilliLumen</param>
    /// <returns>quantity measured in PetaLumen</returns>
	public static Quantity<double, PetaLumen> ToPetaLumen<T>(this Quantity<T, MilliLumen> val) where T:IConvertible {
        return new Quantity<double, PetaLumen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliLumen to TeraLumen
    /// </summary>
    /// <param name="val">quantity measured in MilliLumen</param>
    /// <returns>quantity measured in TeraLumen</returns>
	public static Quantity<double, TeraLumen> ToTeraLumen<T>(this Quantity<T, MilliLumen> val) where T:IConvertible {
        return new Quantity<double, TeraLumen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliLumen to GigaLumen
    /// </summary>
    /// <param name="val">quantity measured in MilliLumen</param>
    /// <returns>quantity measured in GigaLumen</returns>
	public static Quantity<double, GigaLumen> ToGigaLumen<T>(this Quantity<T, MilliLumen> val) where T:IConvertible {
        return new Quantity<double, GigaLumen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliLumen to MegaLumen
    /// </summary>
    /// <param name="val">quantity measured in MilliLumen</param>
    /// <returns>quantity measured in MegaLumen</returns>
	public static Quantity<double, MegaLumen> ToMegaLumen<T>(this Quantity<T, MilliLumen> val) where T:IConvertible {
        return new Quantity<double, MegaLumen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliLumen to KiloLumen
    /// </summary>
    /// <param name="val">quantity measured in MilliLumen</param>
    /// <returns>quantity measured in KiloLumen</returns>
	public static Quantity<double, KiloLumen> ToKiloLumen<T>(this Quantity<T, MilliLumen> val) where T:IConvertible {
        return new Quantity<double, KiloLumen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliLumen to HectoLumen
    /// </summary>
    /// <param name="val">quantity measured in MilliLumen</param>
    /// <returns>quantity measured in HectoLumen</returns>
	public static Quantity<double, HectoLumen> ToHectoLumen<T>(this Quantity<T, MilliLumen> val) where T:IConvertible {
        return new Quantity<double, HectoLumen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliLumen to DekaLumen
    /// </summary>
    /// <param name="val">quantity measured in MilliLumen</param>
    /// <returns>quantity measured in DekaLumen</returns>
	public static Quantity<double, DekaLumen> ToDekaLumen<T>(this Quantity<T, MilliLumen> val) where T:IConvertible {
        return new Quantity<double, DekaLumen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliLumen to DeciLumen
    /// </summary>
    /// <param name="val">quantity measured in MilliLumen</param>
    /// <returns>quantity measured in DeciLumen</returns>
	public static Quantity<double, DeciLumen> ToDeciLumen<T>(this Quantity<T, MilliLumen> val) where T:IConvertible {
        return new Quantity<double, DeciLumen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliLumen to CentiLumen
    /// </summary>
    /// <param name="val">quantity measured in MilliLumen</param>
    /// <returns>quantity measured in CentiLumen</returns>
	public static Quantity<double, CentiLumen> ToCentiLumen<T>(this Quantity<T, MilliLumen> val) where T:IConvertible {
        return new Quantity<double, CentiLumen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliLumen to MicroLumen
    /// </summary>
    /// <param name="val">quantity measured in MilliLumen</param>
    /// <returns>quantity measured in MicroLumen</returns>
	public static Quantity<double, MicroLumen> ToMicroLumen<T>(this Quantity<T, MilliLumen> val) where T:IConvertible {
        return new Quantity<double, MicroLumen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliLumen to NanoLumen
    /// </summary>
    /// <param name="val">quantity measured in MilliLumen</param>
    /// <returns>quantity measured in NanoLumen</returns>
	public static Quantity<double, NanoLumen> ToNanoLumen<T>(this Quantity<T, MilliLumen> val) where T:IConvertible {
        return new Quantity<double, NanoLumen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliLumen to PicoLumen
    /// </summary>
    /// <param name="val">quantity measured in MilliLumen</param>
    /// <returns>quantity measured in PicoLumen</returns>
	public static Quantity<double, PicoLumen> ToPicoLumen<T>(this Quantity<T, MilliLumen> val) where T:IConvertible {
        return new Quantity<double, PicoLumen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliLumen to FemtoLumen
    /// </summary>
    /// <param name="val">quantity measured in MilliLumen</param>
    /// <returns>quantity measured in FemtoLumen</returns>
	public static Quantity<double, FemtoLumen> ToFemtoLumen<T>(this Quantity<T, MilliLumen> val) where T:IConvertible {
        return new Quantity<double, FemtoLumen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliLumen to AttoLumen
    /// </summary>
    /// <param name="val">quantity measured in MilliLumen</param>
    /// <returns>quantity measured in AttoLumen</returns>
	public static Quantity<double, AttoLumen> ToAttoLumen<T>(this Quantity<T, MilliLumen> val) where T:IConvertible {
        return new Quantity<double, AttoLumen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliLumen to ZeptoLumen
    /// </summary>
    /// <param name="val">quantity measured in MilliLumen</param>
    /// <returns>quantity measured in ZeptoLumen</returns>
	public static Quantity<double, ZeptoLumen> ToZeptoLumen<T>(this Quantity<T, MilliLumen> val) where T:IConvertible {
        return new Quantity<double, ZeptoLumen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliLumen to YoctoLumen
    /// </summary>
    /// <param name="val">quantity measured in MilliLumen</param>
    /// <returns>quantity measured in YoctoLumen</returns>
	public static Quantity<double, YoctoLumen> ToYoctoLumen<T>(this Quantity<T, MilliLumen> val) where T:IConvertible {
        return new Quantity<double, YoctoLumen>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MicroLumen to YottaLumen
    /// </summary>
    /// <param name="val">quantity measured in MicroLumen</param>
    /// <returns>quantity measured in YottaLumen</returns>
	public static Quantity<double, YottaLumen> ToYottaLumen<T>(this Quantity<T, MicroLumen> val) where T:IConvertible {
        return new Quantity<double, YottaLumen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroLumen to ZettaLumen
    /// </summary>
    /// <param name="val">quantity measured in MicroLumen</param>
    /// <returns>quantity measured in ZettaLumen</returns>
	public static Quantity<double, ZettaLumen> ToZettaLumen<T>(this Quantity<T, MicroLumen> val) where T:IConvertible {
        return new Quantity<double, ZettaLumen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroLumen to ExaLumen
    /// </summary>
    /// <param name="val">quantity measured in MicroLumen</param>
    /// <returns>quantity measured in ExaLumen</returns>
	public static Quantity<double, ExaLumen> ToExaLumen<T>(this Quantity<T, MicroLumen> val) where T:IConvertible {
        return new Quantity<double, ExaLumen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroLumen to PetaLumen
    /// </summary>
    /// <param name="val">quantity measured in MicroLumen</param>
    /// <returns>quantity measured in PetaLumen</returns>
	public static Quantity<double, PetaLumen> ToPetaLumen<T>(this Quantity<T, MicroLumen> val) where T:IConvertible {
        return new Quantity<double, PetaLumen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroLumen to TeraLumen
    /// </summary>
    /// <param name="val">quantity measured in MicroLumen</param>
    /// <returns>quantity measured in TeraLumen</returns>
	public static Quantity<double, TeraLumen> ToTeraLumen<T>(this Quantity<T, MicroLumen> val) where T:IConvertible {
        return new Quantity<double, TeraLumen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroLumen to GigaLumen
    /// </summary>
    /// <param name="val">quantity measured in MicroLumen</param>
    /// <returns>quantity measured in GigaLumen</returns>
	public static Quantity<double, GigaLumen> ToGigaLumen<T>(this Quantity<T, MicroLumen> val) where T:IConvertible {
        return new Quantity<double, GigaLumen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroLumen to MegaLumen
    /// </summary>
    /// <param name="val">quantity measured in MicroLumen</param>
    /// <returns>quantity measured in MegaLumen</returns>
	public static Quantity<double, MegaLumen> ToMegaLumen<T>(this Quantity<T, MicroLumen> val) where T:IConvertible {
        return new Quantity<double, MegaLumen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroLumen to KiloLumen
    /// </summary>
    /// <param name="val">quantity measured in MicroLumen</param>
    /// <returns>quantity measured in KiloLumen</returns>
	public static Quantity<double, KiloLumen> ToKiloLumen<T>(this Quantity<T, MicroLumen> val) where T:IConvertible {
        return new Quantity<double, KiloLumen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroLumen to HectoLumen
    /// </summary>
    /// <param name="val">quantity measured in MicroLumen</param>
    /// <returns>quantity measured in HectoLumen</returns>
	public static Quantity<double, HectoLumen> ToHectoLumen<T>(this Quantity<T, MicroLumen> val) where T:IConvertible {
        return new Quantity<double, HectoLumen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroLumen to DekaLumen
    /// </summary>
    /// <param name="val">quantity measured in MicroLumen</param>
    /// <returns>quantity measured in DekaLumen</returns>
	public static Quantity<double, DekaLumen> ToDekaLumen<T>(this Quantity<T, MicroLumen> val) where T:IConvertible {
        return new Quantity<double, DekaLumen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroLumen to DeciLumen
    /// </summary>
    /// <param name="val">quantity measured in MicroLumen</param>
    /// <returns>quantity measured in DeciLumen</returns>
	public static Quantity<double, DeciLumen> ToDeciLumen<T>(this Quantity<T, MicroLumen> val) where T:IConvertible {
        return new Quantity<double, DeciLumen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroLumen to CentiLumen
    /// </summary>
    /// <param name="val">quantity measured in MicroLumen</param>
    /// <returns>quantity measured in CentiLumen</returns>
	public static Quantity<double, CentiLumen> ToCentiLumen<T>(this Quantity<T, MicroLumen> val) where T:IConvertible {
        return new Quantity<double, CentiLumen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroLumen to MilliLumen
    /// </summary>
    /// <param name="val">quantity measured in MicroLumen</param>
    /// <returns>quantity measured in MilliLumen</returns>
	public static Quantity<double, MilliLumen> ToMilliLumen<T>(this Quantity<T, MicroLumen> val) where T:IConvertible {
        return new Quantity<double, MilliLumen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroLumen to NanoLumen
    /// </summary>
    /// <param name="val">quantity measured in MicroLumen</param>
    /// <returns>quantity measured in NanoLumen</returns>
	public static Quantity<double, NanoLumen> ToNanoLumen<T>(this Quantity<T, MicroLumen> val) where T:IConvertible {
        return new Quantity<double, NanoLumen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroLumen to PicoLumen
    /// </summary>
    /// <param name="val">quantity measured in MicroLumen</param>
    /// <returns>quantity measured in PicoLumen</returns>
	public static Quantity<double, PicoLumen> ToPicoLumen<T>(this Quantity<T, MicroLumen> val) where T:IConvertible {
        return new Quantity<double, PicoLumen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroLumen to FemtoLumen
    /// </summary>
    /// <param name="val">quantity measured in MicroLumen</param>
    /// <returns>quantity measured in FemtoLumen</returns>
	public static Quantity<double, FemtoLumen> ToFemtoLumen<T>(this Quantity<T, MicroLumen> val) where T:IConvertible {
        return new Quantity<double, FemtoLumen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroLumen to AttoLumen
    /// </summary>
    /// <param name="val">quantity measured in MicroLumen</param>
    /// <returns>quantity measured in AttoLumen</returns>
	public static Quantity<double, AttoLumen> ToAttoLumen<T>(this Quantity<T, MicroLumen> val) where T:IConvertible {
        return new Quantity<double, AttoLumen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroLumen to ZeptoLumen
    /// </summary>
    /// <param name="val">quantity measured in MicroLumen</param>
    /// <returns>quantity measured in ZeptoLumen</returns>
	public static Quantity<double, ZeptoLumen> ToZeptoLumen<T>(this Quantity<T, MicroLumen> val) where T:IConvertible {
        return new Quantity<double, ZeptoLumen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroLumen to YoctoLumen
    /// </summary>
    /// <param name="val">quantity measured in MicroLumen</param>
    /// <returns>quantity measured in YoctoLumen</returns>
	public static Quantity<double, YoctoLumen> ToYoctoLumen<T>(this Quantity<T, MicroLumen> val) where T:IConvertible {
        return new Quantity<double, YoctoLumen>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert NanoLumen to YottaLumen
    /// </summary>
    /// <param name="val">quantity measured in NanoLumen</param>
    /// <returns>quantity measured in YottaLumen</returns>
	public static Quantity<double, YottaLumen> ToYottaLumen<T>(this Quantity<T, NanoLumen> val) where T:IConvertible {
        return new Quantity<double, YottaLumen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoLumen to ZettaLumen
    /// </summary>
    /// <param name="val">quantity measured in NanoLumen</param>
    /// <returns>quantity measured in ZettaLumen</returns>
	public static Quantity<double, ZettaLumen> ToZettaLumen<T>(this Quantity<T, NanoLumen> val) where T:IConvertible {
        return new Quantity<double, ZettaLumen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoLumen to ExaLumen
    /// </summary>
    /// <param name="val">quantity measured in NanoLumen</param>
    /// <returns>quantity measured in ExaLumen</returns>
	public static Quantity<double, ExaLumen> ToExaLumen<T>(this Quantity<T, NanoLumen> val) where T:IConvertible {
        return new Quantity<double, ExaLumen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoLumen to PetaLumen
    /// </summary>
    /// <param name="val">quantity measured in NanoLumen</param>
    /// <returns>quantity measured in PetaLumen</returns>
	public static Quantity<double, PetaLumen> ToPetaLumen<T>(this Quantity<T, NanoLumen> val) where T:IConvertible {
        return new Quantity<double, PetaLumen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoLumen to TeraLumen
    /// </summary>
    /// <param name="val">quantity measured in NanoLumen</param>
    /// <returns>quantity measured in TeraLumen</returns>
	public static Quantity<double, TeraLumen> ToTeraLumen<T>(this Quantity<T, NanoLumen> val) where T:IConvertible {
        return new Quantity<double, TeraLumen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoLumen to GigaLumen
    /// </summary>
    /// <param name="val">quantity measured in NanoLumen</param>
    /// <returns>quantity measured in GigaLumen</returns>
	public static Quantity<double, GigaLumen> ToGigaLumen<T>(this Quantity<T, NanoLumen> val) where T:IConvertible {
        return new Quantity<double, GigaLumen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoLumen to MegaLumen
    /// </summary>
    /// <param name="val">quantity measured in NanoLumen</param>
    /// <returns>quantity measured in MegaLumen</returns>
	public static Quantity<double, MegaLumen> ToMegaLumen<T>(this Quantity<T, NanoLumen> val) where T:IConvertible {
        return new Quantity<double, MegaLumen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoLumen to KiloLumen
    /// </summary>
    /// <param name="val">quantity measured in NanoLumen</param>
    /// <returns>quantity measured in KiloLumen</returns>
	public static Quantity<double, KiloLumen> ToKiloLumen<T>(this Quantity<T, NanoLumen> val) where T:IConvertible {
        return new Quantity<double, KiloLumen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoLumen to HectoLumen
    /// </summary>
    /// <param name="val">quantity measured in NanoLumen</param>
    /// <returns>quantity measured in HectoLumen</returns>
	public static Quantity<double, HectoLumen> ToHectoLumen<T>(this Quantity<T, NanoLumen> val) where T:IConvertible {
        return new Quantity<double, HectoLumen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoLumen to DekaLumen
    /// </summary>
    /// <param name="val">quantity measured in NanoLumen</param>
    /// <returns>quantity measured in DekaLumen</returns>
	public static Quantity<double, DekaLumen> ToDekaLumen<T>(this Quantity<T, NanoLumen> val) where T:IConvertible {
        return new Quantity<double, DekaLumen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoLumen to DeciLumen
    /// </summary>
    /// <param name="val">quantity measured in NanoLumen</param>
    /// <returns>quantity measured in DeciLumen</returns>
	public static Quantity<double, DeciLumen> ToDeciLumen<T>(this Quantity<T, NanoLumen> val) where T:IConvertible {
        return new Quantity<double, DeciLumen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoLumen to CentiLumen
    /// </summary>
    /// <param name="val">quantity measured in NanoLumen</param>
    /// <returns>quantity measured in CentiLumen</returns>
	public static Quantity<double, CentiLumen> ToCentiLumen<T>(this Quantity<T, NanoLumen> val) where T:IConvertible {
        return new Quantity<double, CentiLumen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoLumen to MilliLumen
    /// </summary>
    /// <param name="val">quantity measured in NanoLumen</param>
    /// <returns>quantity measured in MilliLumen</returns>
	public static Quantity<double, MilliLumen> ToMilliLumen<T>(this Quantity<T, NanoLumen> val) where T:IConvertible {
        return new Quantity<double, MilliLumen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoLumen to MicroLumen
    /// </summary>
    /// <param name="val">quantity measured in NanoLumen</param>
    /// <returns>quantity measured in MicroLumen</returns>
	public static Quantity<double, MicroLumen> ToMicroLumen<T>(this Quantity<T, NanoLumen> val) where T:IConvertible {
        return new Quantity<double, MicroLumen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoLumen to PicoLumen
    /// </summary>
    /// <param name="val">quantity measured in NanoLumen</param>
    /// <returns>quantity measured in PicoLumen</returns>
	public static Quantity<double, PicoLumen> ToPicoLumen<T>(this Quantity<T, NanoLumen> val) where T:IConvertible {
        return new Quantity<double, PicoLumen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoLumen to FemtoLumen
    /// </summary>
    /// <param name="val">quantity measured in NanoLumen</param>
    /// <returns>quantity measured in FemtoLumen</returns>
	public static Quantity<double, FemtoLumen> ToFemtoLumen<T>(this Quantity<T, NanoLumen> val) where T:IConvertible {
        return new Quantity<double, FemtoLumen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoLumen to AttoLumen
    /// </summary>
    /// <param name="val">quantity measured in NanoLumen</param>
    /// <returns>quantity measured in AttoLumen</returns>
	public static Quantity<double, AttoLumen> ToAttoLumen<T>(this Quantity<T, NanoLumen> val) where T:IConvertible {
        return new Quantity<double, AttoLumen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoLumen to ZeptoLumen
    /// </summary>
    /// <param name="val">quantity measured in NanoLumen</param>
    /// <returns>quantity measured in ZeptoLumen</returns>
	public static Quantity<double, ZeptoLumen> ToZeptoLumen<T>(this Quantity<T, NanoLumen> val) where T:IConvertible {
        return new Quantity<double, ZeptoLumen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoLumen to YoctoLumen
    /// </summary>
    /// <param name="val">quantity measured in NanoLumen</param>
    /// <returns>quantity measured in YoctoLumen</returns>
	public static Quantity<double, YoctoLumen> ToYoctoLumen<T>(this Quantity<T, NanoLumen> val) where T:IConvertible {
        return new Quantity<double, YoctoLumen>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert PicoLumen to YottaLumen
    /// </summary>
    /// <param name="val">quantity measured in PicoLumen</param>
    /// <returns>quantity measured in YottaLumen</returns>
	public static Quantity<double, YottaLumen> ToYottaLumen<T>(this Quantity<T, PicoLumen> val) where T:IConvertible {
        return new Quantity<double, YottaLumen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoLumen to ZettaLumen
    /// </summary>
    /// <param name="val">quantity measured in PicoLumen</param>
    /// <returns>quantity measured in ZettaLumen</returns>
	public static Quantity<double, ZettaLumen> ToZettaLumen<T>(this Quantity<T, PicoLumen> val) where T:IConvertible {
        return new Quantity<double, ZettaLumen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoLumen to ExaLumen
    /// </summary>
    /// <param name="val">quantity measured in PicoLumen</param>
    /// <returns>quantity measured in ExaLumen</returns>
	public static Quantity<double, ExaLumen> ToExaLumen<T>(this Quantity<T, PicoLumen> val) where T:IConvertible {
        return new Quantity<double, ExaLumen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoLumen to PetaLumen
    /// </summary>
    /// <param name="val">quantity measured in PicoLumen</param>
    /// <returns>quantity measured in PetaLumen</returns>
	public static Quantity<double, PetaLumen> ToPetaLumen<T>(this Quantity<T, PicoLumen> val) where T:IConvertible {
        return new Quantity<double, PetaLumen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoLumen to TeraLumen
    /// </summary>
    /// <param name="val">quantity measured in PicoLumen</param>
    /// <returns>quantity measured in TeraLumen</returns>
	public static Quantity<double, TeraLumen> ToTeraLumen<T>(this Quantity<T, PicoLumen> val) where T:IConvertible {
        return new Quantity<double, TeraLumen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoLumen to GigaLumen
    /// </summary>
    /// <param name="val">quantity measured in PicoLumen</param>
    /// <returns>quantity measured in GigaLumen</returns>
	public static Quantity<double, GigaLumen> ToGigaLumen<T>(this Quantity<T, PicoLumen> val) where T:IConvertible {
        return new Quantity<double, GigaLumen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoLumen to MegaLumen
    /// </summary>
    /// <param name="val">quantity measured in PicoLumen</param>
    /// <returns>quantity measured in MegaLumen</returns>
	public static Quantity<double, MegaLumen> ToMegaLumen<T>(this Quantity<T, PicoLumen> val) where T:IConvertible {
        return new Quantity<double, MegaLumen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoLumen to KiloLumen
    /// </summary>
    /// <param name="val">quantity measured in PicoLumen</param>
    /// <returns>quantity measured in KiloLumen</returns>
	public static Quantity<double, KiloLumen> ToKiloLumen<T>(this Quantity<T, PicoLumen> val) where T:IConvertible {
        return new Quantity<double, KiloLumen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoLumen to HectoLumen
    /// </summary>
    /// <param name="val">quantity measured in PicoLumen</param>
    /// <returns>quantity measured in HectoLumen</returns>
	public static Quantity<double, HectoLumen> ToHectoLumen<T>(this Quantity<T, PicoLumen> val) where T:IConvertible {
        return new Quantity<double, HectoLumen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoLumen to DekaLumen
    /// </summary>
    /// <param name="val">quantity measured in PicoLumen</param>
    /// <returns>quantity measured in DekaLumen</returns>
	public static Quantity<double, DekaLumen> ToDekaLumen<T>(this Quantity<T, PicoLumen> val) where T:IConvertible {
        return new Quantity<double, DekaLumen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoLumen to DeciLumen
    /// </summary>
    /// <param name="val">quantity measured in PicoLumen</param>
    /// <returns>quantity measured in DeciLumen</returns>
	public static Quantity<double, DeciLumen> ToDeciLumen<T>(this Quantity<T, PicoLumen> val) where T:IConvertible {
        return new Quantity<double, DeciLumen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoLumen to CentiLumen
    /// </summary>
    /// <param name="val">quantity measured in PicoLumen</param>
    /// <returns>quantity measured in CentiLumen</returns>
	public static Quantity<double, CentiLumen> ToCentiLumen<T>(this Quantity<T, PicoLumen> val) where T:IConvertible {
        return new Quantity<double, CentiLumen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoLumen to MilliLumen
    /// </summary>
    /// <param name="val">quantity measured in PicoLumen</param>
    /// <returns>quantity measured in MilliLumen</returns>
	public static Quantity<double, MilliLumen> ToMilliLumen<T>(this Quantity<T, PicoLumen> val) where T:IConvertible {
        return new Quantity<double, MilliLumen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoLumen to MicroLumen
    /// </summary>
    /// <param name="val">quantity measured in PicoLumen</param>
    /// <returns>quantity measured in MicroLumen</returns>
	public static Quantity<double, MicroLumen> ToMicroLumen<T>(this Quantity<T, PicoLumen> val) where T:IConvertible {
        return new Quantity<double, MicroLumen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoLumen to NanoLumen
    /// </summary>
    /// <param name="val">quantity measured in PicoLumen</param>
    /// <returns>quantity measured in NanoLumen</returns>
	public static Quantity<double, NanoLumen> ToNanoLumen<T>(this Quantity<T, PicoLumen> val) where T:IConvertible {
        return new Quantity<double, NanoLumen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoLumen to FemtoLumen
    /// </summary>
    /// <param name="val">quantity measured in PicoLumen</param>
    /// <returns>quantity measured in FemtoLumen</returns>
	public static Quantity<double, FemtoLumen> ToFemtoLumen<T>(this Quantity<T, PicoLumen> val) where T:IConvertible {
        return new Quantity<double, FemtoLumen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoLumen to AttoLumen
    /// </summary>
    /// <param name="val">quantity measured in PicoLumen</param>
    /// <returns>quantity measured in AttoLumen</returns>
	public static Quantity<double, AttoLumen> ToAttoLumen<T>(this Quantity<T, PicoLumen> val) where T:IConvertible {
        return new Quantity<double, AttoLumen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoLumen to ZeptoLumen
    /// </summary>
    /// <param name="val">quantity measured in PicoLumen</param>
    /// <returns>quantity measured in ZeptoLumen</returns>
	public static Quantity<double, ZeptoLumen> ToZeptoLumen<T>(this Quantity<T, PicoLumen> val) where T:IConvertible {
        return new Quantity<double, ZeptoLumen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoLumen to YoctoLumen
    /// </summary>
    /// <param name="val">quantity measured in PicoLumen</param>
    /// <returns>quantity measured in YoctoLumen</returns>
	public static Quantity<double, YoctoLumen> ToYoctoLumen<T>(this Quantity<T, PicoLumen> val) where T:IConvertible {
        return new Quantity<double, YoctoLumen>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert FemtoLumen to YottaLumen
    /// </summary>
    /// <param name="val">quantity measured in FemtoLumen</param>
    /// <returns>quantity measured in YottaLumen</returns>
	public static Quantity<double, YottaLumen> ToYottaLumen<T>(this Quantity<T, FemtoLumen> val) where T:IConvertible {
        return new Quantity<double, YottaLumen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoLumen to ZettaLumen
    /// </summary>
    /// <param name="val">quantity measured in FemtoLumen</param>
    /// <returns>quantity measured in ZettaLumen</returns>
	public static Quantity<double, ZettaLumen> ToZettaLumen<T>(this Quantity<T, FemtoLumen> val) where T:IConvertible {
        return new Quantity<double, ZettaLumen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoLumen to ExaLumen
    /// </summary>
    /// <param name="val">quantity measured in FemtoLumen</param>
    /// <returns>quantity measured in ExaLumen</returns>
	public static Quantity<double, ExaLumen> ToExaLumen<T>(this Quantity<T, FemtoLumen> val) where T:IConvertible {
        return new Quantity<double, ExaLumen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoLumen to PetaLumen
    /// </summary>
    /// <param name="val">quantity measured in FemtoLumen</param>
    /// <returns>quantity measured in PetaLumen</returns>
	public static Quantity<double, PetaLumen> ToPetaLumen<T>(this Quantity<T, FemtoLumen> val) where T:IConvertible {
        return new Quantity<double, PetaLumen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoLumen to TeraLumen
    /// </summary>
    /// <param name="val">quantity measured in FemtoLumen</param>
    /// <returns>quantity measured in TeraLumen</returns>
	public static Quantity<double, TeraLumen> ToTeraLumen<T>(this Quantity<T, FemtoLumen> val) where T:IConvertible {
        return new Quantity<double, TeraLumen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoLumen to GigaLumen
    /// </summary>
    /// <param name="val">quantity measured in FemtoLumen</param>
    /// <returns>quantity measured in GigaLumen</returns>
	public static Quantity<double, GigaLumen> ToGigaLumen<T>(this Quantity<T, FemtoLumen> val) where T:IConvertible {
        return new Quantity<double, GigaLumen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoLumen to MegaLumen
    /// </summary>
    /// <param name="val">quantity measured in FemtoLumen</param>
    /// <returns>quantity measured in MegaLumen</returns>
	public static Quantity<double, MegaLumen> ToMegaLumen<T>(this Quantity<T, FemtoLumen> val) where T:IConvertible {
        return new Quantity<double, MegaLumen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoLumen to KiloLumen
    /// </summary>
    /// <param name="val">quantity measured in FemtoLumen</param>
    /// <returns>quantity measured in KiloLumen</returns>
	public static Quantity<double, KiloLumen> ToKiloLumen<T>(this Quantity<T, FemtoLumen> val) where T:IConvertible {
        return new Quantity<double, KiloLumen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoLumen to HectoLumen
    /// </summary>
    /// <param name="val">quantity measured in FemtoLumen</param>
    /// <returns>quantity measured in HectoLumen</returns>
	public static Quantity<double, HectoLumen> ToHectoLumen<T>(this Quantity<T, FemtoLumen> val) where T:IConvertible {
        return new Quantity<double, HectoLumen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoLumen to DekaLumen
    /// </summary>
    /// <param name="val">quantity measured in FemtoLumen</param>
    /// <returns>quantity measured in DekaLumen</returns>
	public static Quantity<double, DekaLumen> ToDekaLumen<T>(this Quantity<T, FemtoLumen> val) where T:IConvertible {
        return new Quantity<double, DekaLumen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoLumen to DeciLumen
    /// </summary>
    /// <param name="val">quantity measured in FemtoLumen</param>
    /// <returns>quantity measured in DeciLumen</returns>
	public static Quantity<double, DeciLumen> ToDeciLumen<T>(this Quantity<T, FemtoLumen> val) where T:IConvertible {
        return new Quantity<double, DeciLumen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoLumen to CentiLumen
    /// </summary>
    /// <param name="val">quantity measured in FemtoLumen</param>
    /// <returns>quantity measured in CentiLumen</returns>
	public static Quantity<double, CentiLumen> ToCentiLumen<T>(this Quantity<T, FemtoLumen> val) where T:IConvertible {
        return new Quantity<double, CentiLumen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoLumen to MilliLumen
    /// </summary>
    /// <param name="val">quantity measured in FemtoLumen</param>
    /// <returns>quantity measured in MilliLumen</returns>
	public static Quantity<double, MilliLumen> ToMilliLumen<T>(this Quantity<T, FemtoLumen> val) where T:IConvertible {
        return new Quantity<double, MilliLumen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoLumen to MicroLumen
    /// </summary>
    /// <param name="val">quantity measured in FemtoLumen</param>
    /// <returns>quantity measured in MicroLumen</returns>
	public static Quantity<double, MicroLumen> ToMicroLumen<T>(this Quantity<T, FemtoLumen> val) where T:IConvertible {
        return new Quantity<double, MicroLumen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoLumen to NanoLumen
    /// </summary>
    /// <param name="val">quantity measured in FemtoLumen</param>
    /// <returns>quantity measured in NanoLumen</returns>
	public static Quantity<double, NanoLumen> ToNanoLumen<T>(this Quantity<T, FemtoLumen> val) where T:IConvertible {
        return new Quantity<double, NanoLumen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoLumen to PicoLumen
    /// </summary>
    /// <param name="val">quantity measured in FemtoLumen</param>
    /// <returns>quantity measured in PicoLumen</returns>
	public static Quantity<double, PicoLumen> ToPicoLumen<T>(this Quantity<T, FemtoLumen> val) where T:IConvertible {
        return new Quantity<double, PicoLumen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoLumen to AttoLumen
    /// </summary>
    /// <param name="val">quantity measured in FemtoLumen</param>
    /// <returns>quantity measured in AttoLumen</returns>
	public static Quantity<double, AttoLumen> ToAttoLumen<T>(this Quantity<T, FemtoLumen> val) where T:IConvertible {
        return new Quantity<double, AttoLumen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoLumen to ZeptoLumen
    /// </summary>
    /// <param name="val">quantity measured in FemtoLumen</param>
    /// <returns>quantity measured in ZeptoLumen</returns>
	public static Quantity<double, ZeptoLumen> ToZeptoLumen<T>(this Quantity<T, FemtoLumen> val) where T:IConvertible {
        return new Quantity<double, ZeptoLumen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoLumen to YoctoLumen
    /// </summary>
    /// <param name="val">quantity measured in FemtoLumen</param>
    /// <returns>quantity measured in YoctoLumen</returns>
	public static Quantity<double, YoctoLumen> ToYoctoLumen<T>(this Quantity<T, FemtoLumen> val) where T:IConvertible {
        return new Quantity<double, YoctoLumen>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert AttoLumen to YottaLumen
    /// </summary>
    /// <param name="val">quantity measured in AttoLumen</param>
    /// <returns>quantity measured in YottaLumen</returns>
	public static Quantity<double, YottaLumen> ToYottaLumen<T>(this Quantity<T, AttoLumen> val) where T:IConvertible {
        return new Quantity<double, YottaLumen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoLumen to ZettaLumen
    /// </summary>
    /// <param name="val">quantity measured in AttoLumen</param>
    /// <returns>quantity measured in ZettaLumen</returns>
	public static Quantity<double, ZettaLumen> ToZettaLumen<T>(this Quantity<T, AttoLumen> val) where T:IConvertible {
        return new Quantity<double, ZettaLumen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoLumen to ExaLumen
    /// </summary>
    /// <param name="val">quantity measured in AttoLumen</param>
    /// <returns>quantity measured in ExaLumen</returns>
	public static Quantity<double, ExaLumen> ToExaLumen<T>(this Quantity<T, AttoLumen> val) where T:IConvertible {
        return new Quantity<double, ExaLumen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoLumen to PetaLumen
    /// </summary>
    /// <param name="val">quantity measured in AttoLumen</param>
    /// <returns>quantity measured in PetaLumen</returns>
	public static Quantity<double, PetaLumen> ToPetaLumen<T>(this Quantity<T, AttoLumen> val) where T:IConvertible {
        return new Quantity<double, PetaLumen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoLumen to TeraLumen
    /// </summary>
    /// <param name="val">quantity measured in AttoLumen</param>
    /// <returns>quantity measured in TeraLumen</returns>
	public static Quantity<double, TeraLumen> ToTeraLumen<T>(this Quantity<T, AttoLumen> val) where T:IConvertible {
        return new Quantity<double, TeraLumen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoLumen to GigaLumen
    /// </summary>
    /// <param name="val">quantity measured in AttoLumen</param>
    /// <returns>quantity measured in GigaLumen</returns>
	public static Quantity<double, GigaLumen> ToGigaLumen<T>(this Quantity<T, AttoLumen> val) where T:IConvertible {
        return new Quantity<double, GigaLumen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoLumen to MegaLumen
    /// </summary>
    /// <param name="val">quantity measured in AttoLumen</param>
    /// <returns>quantity measured in MegaLumen</returns>
	public static Quantity<double, MegaLumen> ToMegaLumen<T>(this Quantity<T, AttoLumen> val) where T:IConvertible {
        return new Quantity<double, MegaLumen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoLumen to KiloLumen
    /// </summary>
    /// <param name="val">quantity measured in AttoLumen</param>
    /// <returns>quantity measured in KiloLumen</returns>
	public static Quantity<double, KiloLumen> ToKiloLumen<T>(this Quantity<T, AttoLumen> val) where T:IConvertible {
        return new Quantity<double, KiloLumen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoLumen to HectoLumen
    /// </summary>
    /// <param name="val">quantity measured in AttoLumen</param>
    /// <returns>quantity measured in HectoLumen</returns>
	public static Quantity<double, HectoLumen> ToHectoLumen<T>(this Quantity<T, AttoLumen> val) where T:IConvertible {
        return new Quantity<double, HectoLumen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoLumen to DekaLumen
    /// </summary>
    /// <param name="val">quantity measured in AttoLumen</param>
    /// <returns>quantity measured in DekaLumen</returns>
	public static Quantity<double, DekaLumen> ToDekaLumen<T>(this Quantity<T, AttoLumen> val) where T:IConvertible {
        return new Quantity<double, DekaLumen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoLumen to DeciLumen
    /// </summary>
    /// <param name="val">quantity measured in AttoLumen</param>
    /// <returns>quantity measured in DeciLumen</returns>
	public static Quantity<double, DeciLumen> ToDeciLumen<T>(this Quantity<T, AttoLumen> val) where T:IConvertible {
        return new Quantity<double, DeciLumen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoLumen to CentiLumen
    /// </summary>
    /// <param name="val">quantity measured in AttoLumen</param>
    /// <returns>quantity measured in CentiLumen</returns>
	public static Quantity<double, CentiLumen> ToCentiLumen<T>(this Quantity<T, AttoLumen> val) where T:IConvertible {
        return new Quantity<double, CentiLumen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoLumen to MilliLumen
    /// </summary>
    /// <param name="val">quantity measured in AttoLumen</param>
    /// <returns>quantity measured in MilliLumen</returns>
	public static Quantity<double, MilliLumen> ToMilliLumen<T>(this Quantity<T, AttoLumen> val) where T:IConvertible {
        return new Quantity<double, MilliLumen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoLumen to MicroLumen
    /// </summary>
    /// <param name="val">quantity measured in AttoLumen</param>
    /// <returns>quantity measured in MicroLumen</returns>
	public static Quantity<double, MicroLumen> ToMicroLumen<T>(this Quantity<T, AttoLumen> val) where T:IConvertible {
        return new Quantity<double, MicroLumen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoLumen to NanoLumen
    /// </summary>
    /// <param name="val">quantity measured in AttoLumen</param>
    /// <returns>quantity measured in NanoLumen</returns>
	public static Quantity<double, NanoLumen> ToNanoLumen<T>(this Quantity<T, AttoLumen> val) where T:IConvertible {
        return new Quantity<double, NanoLumen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoLumen to PicoLumen
    /// </summary>
    /// <param name="val">quantity measured in AttoLumen</param>
    /// <returns>quantity measured in PicoLumen</returns>
	public static Quantity<double, PicoLumen> ToPicoLumen<T>(this Quantity<T, AttoLumen> val) where T:IConvertible {
        return new Quantity<double, PicoLumen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoLumen to FemtoLumen
    /// </summary>
    /// <param name="val">quantity measured in AttoLumen</param>
    /// <returns>quantity measured in FemtoLumen</returns>
	public static Quantity<double, FemtoLumen> ToFemtoLumen<T>(this Quantity<T, AttoLumen> val) where T:IConvertible {
        return new Quantity<double, FemtoLumen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoLumen to ZeptoLumen
    /// </summary>
    /// <param name="val">quantity measured in AttoLumen</param>
    /// <returns>quantity measured in ZeptoLumen</returns>
	public static Quantity<double, ZeptoLumen> ToZeptoLumen<T>(this Quantity<T, AttoLumen> val) where T:IConvertible {
        return new Quantity<double, ZeptoLumen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoLumen to YoctoLumen
    /// </summary>
    /// <param name="val">quantity measured in AttoLumen</param>
    /// <returns>quantity measured in YoctoLumen</returns>
	public static Quantity<double, YoctoLumen> ToYoctoLumen<T>(this Quantity<T, AttoLumen> val) where T:IConvertible {
        return new Quantity<double, YoctoLumen>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoLumen to YottaLumen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoLumen</param>
    /// <returns>quantity measured in YottaLumen</returns>
	public static Quantity<double, YottaLumen> ToYottaLumen<T>(this Quantity<T, ZeptoLumen> val) where T:IConvertible {
        return new Quantity<double, YottaLumen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoLumen to ZettaLumen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoLumen</param>
    /// <returns>quantity measured in ZettaLumen</returns>
	public static Quantity<double, ZettaLumen> ToZettaLumen<T>(this Quantity<T, ZeptoLumen> val) where T:IConvertible {
        return new Quantity<double, ZettaLumen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoLumen to ExaLumen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoLumen</param>
    /// <returns>quantity measured in ExaLumen</returns>
	public static Quantity<double, ExaLumen> ToExaLumen<T>(this Quantity<T, ZeptoLumen> val) where T:IConvertible {
        return new Quantity<double, ExaLumen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoLumen to PetaLumen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoLumen</param>
    /// <returns>quantity measured in PetaLumen</returns>
	public static Quantity<double, PetaLumen> ToPetaLumen<T>(this Quantity<T, ZeptoLumen> val) where T:IConvertible {
        return new Quantity<double, PetaLumen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoLumen to TeraLumen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoLumen</param>
    /// <returns>quantity measured in TeraLumen</returns>
	public static Quantity<double, TeraLumen> ToTeraLumen<T>(this Quantity<T, ZeptoLumen> val) where T:IConvertible {
        return new Quantity<double, TeraLumen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoLumen to GigaLumen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoLumen</param>
    /// <returns>quantity measured in GigaLumen</returns>
	public static Quantity<double, GigaLumen> ToGigaLumen<T>(this Quantity<T, ZeptoLumen> val) where T:IConvertible {
        return new Quantity<double, GigaLumen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoLumen to MegaLumen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoLumen</param>
    /// <returns>quantity measured in MegaLumen</returns>
	public static Quantity<double, MegaLumen> ToMegaLumen<T>(this Quantity<T, ZeptoLumen> val) where T:IConvertible {
        return new Quantity<double, MegaLumen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoLumen to KiloLumen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoLumen</param>
    /// <returns>quantity measured in KiloLumen</returns>
	public static Quantity<double, KiloLumen> ToKiloLumen<T>(this Quantity<T, ZeptoLumen> val) where T:IConvertible {
        return new Quantity<double, KiloLumen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoLumen to HectoLumen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoLumen</param>
    /// <returns>quantity measured in HectoLumen</returns>
	public static Quantity<double, HectoLumen> ToHectoLumen<T>(this Quantity<T, ZeptoLumen> val) where T:IConvertible {
        return new Quantity<double, HectoLumen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoLumen to DekaLumen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoLumen</param>
    /// <returns>quantity measured in DekaLumen</returns>
	public static Quantity<double, DekaLumen> ToDekaLumen<T>(this Quantity<T, ZeptoLumen> val) where T:IConvertible {
        return new Quantity<double, DekaLumen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoLumen to DeciLumen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoLumen</param>
    /// <returns>quantity measured in DeciLumen</returns>
	public static Quantity<double, DeciLumen> ToDeciLumen<T>(this Quantity<T, ZeptoLumen> val) where T:IConvertible {
        return new Quantity<double, DeciLumen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoLumen to CentiLumen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoLumen</param>
    /// <returns>quantity measured in CentiLumen</returns>
	public static Quantity<double, CentiLumen> ToCentiLumen<T>(this Quantity<T, ZeptoLumen> val) where T:IConvertible {
        return new Quantity<double, CentiLumen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoLumen to MilliLumen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoLumen</param>
    /// <returns>quantity measured in MilliLumen</returns>
	public static Quantity<double, MilliLumen> ToMilliLumen<T>(this Quantity<T, ZeptoLumen> val) where T:IConvertible {
        return new Quantity<double, MilliLumen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoLumen to MicroLumen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoLumen</param>
    /// <returns>quantity measured in MicroLumen</returns>
	public static Quantity<double, MicroLumen> ToMicroLumen<T>(this Quantity<T, ZeptoLumen> val) where T:IConvertible {
        return new Quantity<double, MicroLumen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoLumen to NanoLumen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoLumen</param>
    /// <returns>quantity measured in NanoLumen</returns>
	public static Quantity<double, NanoLumen> ToNanoLumen<T>(this Quantity<T, ZeptoLumen> val) where T:IConvertible {
        return new Quantity<double, NanoLumen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoLumen to PicoLumen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoLumen</param>
    /// <returns>quantity measured in PicoLumen</returns>
	public static Quantity<double, PicoLumen> ToPicoLumen<T>(this Quantity<T, ZeptoLumen> val) where T:IConvertible {
        return new Quantity<double, PicoLumen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoLumen to FemtoLumen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoLumen</param>
    /// <returns>quantity measured in FemtoLumen</returns>
	public static Quantity<double, FemtoLumen> ToFemtoLumen<T>(this Quantity<T, ZeptoLumen> val) where T:IConvertible {
        return new Quantity<double, FemtoLumen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoLumen to AttoLumen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoLumen</param>
    /// <returns>quantity measured in AttoLumen</returns>
	public static Quantity<double, AttoLumen> ToAttoLumen<T>(this Quantity<T, ZeptoLumen> val) where T:IConvertible {
        return new Quantity<double, AttoLumen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoLumen to YoctoLumen
    /// </summary>
    /// <param name="val">quantity measured in ZeptoLumen</param>
    /// <returns>quantity measured in YoctoLumen</returns>
	public static Quantity<double, YoctoLumen> ToYoctoLumen<T>(this Quantity<T, ZeptoLumen> val) where T:IConvertible {
        return new Quantity<double, YoctoLumen>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert YoctoLumen to YottaLumen
    /// </summary>
    /// <param name="val">quantity measured in YoctoLumen</param>
    /// <returns>quantity measured in YottaLumen</returns>
	public static Quantity<double, YottaLumen> ToYottaLumen<T>(this Quantity<T, YoctoLumen> val) where T:IConvertible {
        return new Quantity<double, YottaLumen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoLumen to ZettaLumen
    /// </summary>
    /// <param name="val">quantity measured in YoctoLumen</param>
    /// <returns>quantity measured in ZettaLumen</returns>
	public static Quantity<double, ZettaLumen> ToZettaLumen<T>(this Quantity<T, YoctoLumen> val) where T:IConvertible {
        return new Quantity<double, ZettaLumen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoLumen to ExaLumen
    /// </summary>
    /// <param name="val">quantity measured in YoctoLumen</param>
    /// <returns>quantity measured in ExaLumen</returns>
	public static Quantity<double, ExaLumen> ToExaLumen<T>(this Quantity<T, YoctoLumen> val) where T:IConvertible {
        return new Quantity<double, ExaLumen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoLumen to PetaLumen
    /// </summary>
    /// <param name="val">quantity measured in YoctoLumen</param>
    /// <returns>quantity measured in PetaLumen</returns>
	public static Quantity<double, PetaLumen> ToPetaLumen<T>(this Quantity<T, YoctoLumen> val) where T:IConvertible {
        return new Quantity<double, PetaLumen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoLumen to TeraLumen
    /// </summary>
    /// <param name="val">quantity measured in YoctoLumen</param>
    /// <returns>quantity measured in TeraLumen</returns>
	public static Quantity<double, TeraLumen> ToTeraLumen<T>(this Quantity<T, YoctoLumen> val) where T:IConvertible {
        return new Quantity<double, TeraLumen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoLumen to GigaLumen
    /// </summary>
    /// <param name="val">quantity measured in YoctoLumen</param>
    /// <returns>quantity measured in GigaLumen</returns>
	public static Quantity<double, GigaLumen> ToGigaLumen<T>(this Quantity<T, YoctoLumen> val) where T:IConvertible {
        return new Quantity<double, GigaLumen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoLumen to MegaLumen
    /// </summary>
    /// <param name="val">quantity measured in YoctoLumen</param>
    /// <returns>quantity measured in MegaLumen</returns>
	public static Quantity<double, MegaLumen> ToMegaLumen<T>(this Quantity<T, YoctoLumen> val) where T:IConvertible {
        return new Quantity<double, MegaLumen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoLumen to KiloLumen
    /// </summary>
    /// <param name="val">quantity measured in YoctoLumen</param>
    /// <returns>quantity measured in KiloLumen</returns>
	public static Quantity<double, KiloLumen> ToKiloLumen<T>(this Quantity<T, YoctoLumen> val) where T:IConvertible {
        return new Quantity<double, KiloLumen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoLumen to HectoLumen
    /// </summary>
    /// <param name="val">quantity measured in YoctoLumen</param>
    /// <returns>quantity measured in HectoLumen</returns>
	public static Quantity<double, HectoLumen> ToHectoLumen<T>(this Quantity<T, YoctoLumen> val) where T:IConvertible {
        return new Quantity<double, HectoLumen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoLumen to DekaLumen
    /// </summary>
    /// <param name="val">quantity measured in YoctoLumen</param>
    /// <returns>quantity measured in DekaLumen</returns>
	public static Quantity<double, DekaLumen> ToDekaLumen<T>(this Quantity<T, YoctoLumen> val) where T:IConvertible {
        return new Quantity<double, DekaLumen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoLumen to DeciLumen
    /// </summary>
    /// <param name="val">quantity measured in YoctoLumen</param>
    /// <returns>quantity measured in DeciLumen</returns>
	public static Quantity<double, DeciLumen> ToDeciLumen<T>(this Quantity<T, YoctoLumen> val) where T:IConvertible {
        return new Quantity<double, DeciLumen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoLumen to CentiLumen
    /// </summary>
    /// <param name="val">quantity measured in YoctoLumen</param>
    /// <returns>quantity measured in CentiLumen</returns>
	public static Quantity<double, CentiLumen> ToCentiLumen<T>(this Quantity<T, YoctoLumen> val) where T:IConvertible {
        return new Quantity<double, CentiLumen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoLumen to MilliLumen
    /// </summary>
    /// <param name="val">quantity measured in YoctoLumen</param>
    /// <returns>quantity measured in MilliLumen</returns>
	public static Quantity<double, MilliLumen> ToMilliLumen<T>(this Quantity<T, YoctoLumen> val) where T:IConvertible {
        return new Quantity<double, MilliLumen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoLumen to MicroLumen
    /// </summary>
    /// <param name="val">quantity measured in YoctoLumen</param>
    /// <returns>quantity measured in MicroLumen</returns>
	public static Quantity<double, MicroLumen> ToMicroLumen<T>(this Quantity<T, YoctoLumen> val) where T:IConvertible {
        return new Quantity<double, MicroLumen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoLumen to NanoLumen
    /// </summary>
    /// <param name="val">quantity measured in YoctoLumen</param>
    /// <returns>quantity measured in NanoLumen</returns>
	public static Quantity<double, NanoLumen> ToNanoLumen<T>(this Quantity<T, YoctoLumen> val) where T:IConvertible {
        return new Quantity<double, NanoLumen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoLumen to PicoLumen
    /// </summary>
    /// <param name="val">quantity measured in YoctoLumen</param>
    /// <returns>quantity measured in PicoLumen</returns>
	public static Quantity<double, PicoLumen> ToPicoLumen<T>(this Quantity<T, YoctoLumen> val) where T:IConvertible {
        return new Quantity<double, PicoLumen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoLumen to FemtoLumen
    /// </summary>
    /// <param name="val">quantity measured in YoctoLumen</param>
    /// <returns>quantity measured in FemtoLumen</returns>
	public static Quantity<double, FemtoLumen> ToFemtoLumen<T>(this Quantity<T, YoctoLumen> val) where T:IConvertible {
        return new Quantity<double, FemtoLumen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoLumen to AttoLumen
    /// </summary>
    /// <param name="val">quantity measured in YoctoLumen</param>
    /// <returns>quantity measured in AttoLumen</returns>
	public static Quantity<double, AttoLumen> ToAttoLumen<T>(this Quantity<T, YoctoLumen> val) where T:IConvertible {
        return new Quantity<double, AttoLumen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoLumen to ZeptoLumen
    /// </summary>
    /// <param name="val">quantity measured in YoctoLumen</param>
    /// <returns>quantity measured in ZeptoLumen</returns>
	public static Quantity<double, ZeptoLumen> ToZeptoLumen<T>(this Quantity<T, YoctoLumen> val) where T:IConvertible {
        return new Quantity<double, ZeptoLumen>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
}
}