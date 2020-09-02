using System;
namespace Qkmaxware.Units.Luminosity {
/// <summary>
/// Static class housing si-prefix conversions for the unit "CandelaLuminosity"
/// </summary>
public static class CandelaLuminosityConversions {
	/// <summary>
    /// Extension method to convert Candela to YottaCandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in YottaCandela</returns>
	public static Quantity<double, YottaCandela> ToYottaCandela<T>(this BaseQuantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, YottaCandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaCandela to Candela
    /// </summary>
    /// <param name="val">quantity measured in YottaCandela</param>
    /// <returns>quantity measured in Candela</returns>
	public static Quantity<double, Candela> ToCandela<T>(this BaseQuantity<T, YottaCandela> val) where T:IConvertible {
        return new Quantity<double, Candela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Candela to ZettaCandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in ZettaCandela</returns>
	public static Quantity<double, ZettaCandela> ToZettaCandela<T>(this BaseQuantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, ZettaCandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaCandela to Candela
    /// </summary>
    /// <param name="val">quantity measured in ZettaCandela</param>
    /// <returns>quantity measured in Candela</returns>
	public static Quantity<double, Candela> ToCandela<T>(this BaseQuantity<T, ZettaCandela> val) where T:IConvertible {
        return new Quantity<double, Candela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Candela to ExaCandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in ExaCandela</returns>
	public static Quantity<double, ExaCandela> ToExaCandela<T>(this BaseQuantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, ExaCandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaCandela to Candela
    /// </summary>
    /// <param name="val">quantity measured in ExaCandela</param>
    /// <returns>quantity measured in Candela</returns>
	public static Quantity<double, Candela> ToCandela<T>(this BaseQuantity<T, ExaCandela> val) where T:IConvertible {
        return new Quantity<double, Candela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Candela to PetaCandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in PetaCandela</returns>
	public static Quantity<double, PetaCandela> ToPetaCandela<T>(this BaseQuantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, PetaCandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaCandela to Candela
    /// </summary>
    /// <param name="val">quantity measured in PetaCandela</param>
    /// <returns>quantity measured in Candela</returns>
	public static Quantity<double, Candela> ToCandela<T>(this BaseQuantity<T, PetaCandela> val) where T:IConvertible {
        return new Quantity<double, Candela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Candela to TeraCandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in TeraCandela</returns>
	public static Quantity<double, TeraCandela> ToTeraCandela<T>(this BaseQuantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, TeraCandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraCandela to Candela
    /// </summary>
    /// <param name="val">quantity measured in TeraCandela</param>
    /// <returns>quantity measured in Candela</returns>
	public static Quantity<double, Candela> ToCandela<T>(this BaseQuantity<T, TeraCandela> val) where T:IConvertible {
        return new Quantity<double, Candela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Candela to GigaCandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in GigaCandela</returns>
	public static Quantity<double, GigaCandela> ToGigaCandela<T>(this BaseQuantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, GigaCandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaCandela to Candela
    /// </summary>
    /// <param name="val">quantity measured in GigaCandela</param>
    /// <returns>quantity measured in Candela</returns>
	public static Quantity<double, Candela> ToCandela<T>(this BaseQuantity<T, GigaCandela> val) where T:IConvertible {
        return new Quantity<double, Candela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Candela to MegaCandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in MegaCandela</returns>
	public static Quantity<double, MegaCandela> ToMegaCandela<T>(this BaseQuantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, MegaCandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaCandela to Candela
    /// </summary>
    /// <param name="val">quantity measured in MegaCandela</param>
    /// <returns>quantity measured in Candela</returns>
	public static Quantity<double, Candela> ToCandela<T>(this BaseQuantity<T, MegaCandela> val) where T:IConvertible {
        return new Quantity<double, Candela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Candela to KiloCandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in KiloCandela</returns>
	public static Quantity<double, KiloCandela> ToKiloCandela<T>(this BaseQuantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, KiloCandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloCandela to Candela
    /// </summary>
    /// <param name="val">quantity measured in KiloCandela</param>
    /// <returns>quantity measured in Candela</returns>
	public static Quantity<double, Candela> ToCandela<T>(this BaseQuantity<T, KiloCandela> val) where T:IConvertible {
        return new Quantity<double, Candela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Candela to HectoCandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in HectoCandela</returns>
	public static Quantity<double, HectoCandela> ToHectoCandela<T>(this BaseQuantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, HectoCandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoCandela to Candela
    /// </summary>
    /// <param name="val">quantity measured in HectoCandela</param>
    /// <returns>quantity measured in Candela</returns>
	public static Quantity<double, Candela> ToCandela<T>(this BaseQuantity<T, HectoCandela> val) where T:IConvertible {
        return new Quantity<double, Candela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Candela to DekaCandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in DekaCandela</returns>
	public static Quantity<double, DekaCandela> ToDekaCandela<T>(this BaseQuantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, DekaCandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaCandela to Candela
    /// </summary>
    /// <param name="val">quantity measured in DekaCandela</param>
    /// <returns>quantity measured in Candela</returns>
	public static Quantity<double, Candela> ToCandela<T>(this BaseQuantity<T, DekaCandela> val) where T:IConvertible {
        return new Quantity<double, Candela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Candela to DeciCandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in DeciCandela</returns>
	public static Quantity<double, DeciCandela> ToDeciCandela<T>(this BaseQuantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, DeciCandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciCandela to Candela
    /// </summary>
    /// <param name="val">quantity measured in DeciCandela</param>
    /// <returns>quantity measured in Candela</returns>
	public static Quantity<double, Candela> ToCandela<T>(this BaseQuantity<T, DeciCandela> val) where T:IConvertible {
        return new Quantity<double, Candela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Candela to CentiCandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in CentiCandela</returns>
	public static Quantity<double, CentiCandela> ToCentiCandela<T>(this BaseQuantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, CentiCandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiCandela to Candela
    /// </summary>
    /// <param name="val">quantity measured in CentiCandela</param>
    /// <returns>quantity measured in Candela</returns>
	public static Quantity<double, Candela> ToCandela<T>(this BaseQuantity<T, CentiCandela> val) where T:IConvertible {
        return new Quantity<double, Candela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Candela to MilliCandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in MilliCandela</returns>
	public static Quantity<double, MilliCandela> ToMilliCandela<T>(this BaseQuantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, MilliCandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliCandela to Candela
    /// </summary>
    /// <param name="val">quantity measured in MilliCandela</param>
    /// <returns>quantity measured in Candela</returns>
	public static Quantity<double, Candela> ToCandela<T>(this BaseQuantity<T, MilliCandela> val) where T:IConvertible {
        return new Quantity<double, Candela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Candela to MicroCandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in MicroCandela</returns>
	public static Quantity<double, MicroCandela> ToMicroCandela<T>(this BaseQuantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, MicroCandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroCandela to Candela
    /// </summary>
    /// <param name="val">quantity measured in MicroCandela</param>
    /// <returns>quantity measured in Candela</returns>
	public static Quantity<double, Candela> ToCandela<T>(this BaseQuantity<T, MicroCandela> val) where T:IConvertible {
        return new Quantity<double, Candela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Candela to NanoCandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in NanoCandela</returns>
	public static Quantity<double, NanoCandela> ToNanoCandela<T>(this BaseQuantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, NanoCandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoCandela to Candela
    /// </summary>
    /// <param name="val">quantity measured in NanoCandela</param>
    /// <returns>quantity measured in Candela</returns>
	public static Quantity<double, Candela> ToCandela<T>(this BaseQuantity<T, NanoCandela> val) where T:IConvertible {
        return new Quantity<double, Candela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Candela to PicoCandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in PicoCandela</returns>
	public static Quantity<double, PicoCandela> ToPicoCandela<T>(this BaseQuantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, PicoCandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoCandela to Candela
    /// </summary>
    /// <param name="val">quantity measured in PicoCandela</param>
    /// <returns>quantity measured in Candela</returns>
	public static Quantity<double, Candela> ToCandela<T>(this BaseQuantity<T, PicoCandela> val) where T:IConvertible {
        return new Quantity<double, Candela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Candela to FemtoCandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in FemtoCandela</returns>
	public static Quantity<double, FemtoCandela> ToFemtoCandela<T>(this BaseQuantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, FemtoCandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoCandela to Candela
    /// </summary>
    /// <param name="val">quantity measured in FemtoCandela</param>
    /// <returns>quantity measured in Candela</returns>
	public static Quantity<double, Candela> ToCandela<T>(this BaseQuantity<T, FemtoCandela> val) where T:IConvertible {
        return new Quantity<double, Candela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Candela to AttoCandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in AttoCandela</returns>
	public static Quantity<double, AttoCandela> ToAttoCandela<T>(this BaseQuantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, AttoCandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoCandela to Candela
    /// </summary>
    /// <param name="val">quantity measured in AttoCandela</param>
    /// <returns>quantity measured in Candela</returns>
	public static Quantity<double, Candela> ToCandela<T>(this BaseQuantity<T, AttoCandela> val) where T:IConvertible {
        return new Quantity<double, Candela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Candela to ZeptoCandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in ZeptoCandela</returns>
	public static Quantity<double, ZeptoCandela> ToZeptoCandela<T>(this BaseQuantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, ZeptoCandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoCandela to Candela
    /// </summary>
    /// <param name="val">quantity measured in ZeptoCandela</param>
    /// <returns>quantity measured in Candela</returns>
	public static Quantity<double, Candela> ToCandela<T>(this BaseQuantity<T, ZeptoCandela> val) where T:IConvertible {
        return new Quantity<double, Candela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Candela to YoctoCandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in YoctoCandela</returns>
	public static Quantity<double, YoctoCandela> ToYoctoCandela<T>(this BaseQuantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, YoctoCandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoCandela to Candela
    /// </summary>
    /// <param name="val">quantity measured in YoctoCandela</param>
    /// <returns>quantity measured in Candela</returns>
	public static Quantity<double, Candela> ToCandela<T>(this BaseQuantity<T, YoctoCandela> val) where T:IConvertible {
        return new Quantity<double, Candela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaCandela to ZettaCandela
    /// </summary>
    /// <param name="val">quantity measured in YottaCandela</param>
    /// <returns>quantity measured in ZettaCandela</returns>
	public static Quantity<double, ZettaCandela> ToZettaCandela<T>(this BaseQuantity<T, YottaCandela> val) where T:IConvertible {
        return new Quantity<double, ZettaCandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaCandela to ExaCandela
    /// </summary>
    /// <param name="val">quantity measured in YottaCandela</param>
    /// <returns>quantity measured in ExaCandela</returns>
	public static Quantity<double, ExaCandela> ToExaCandela<T>(this BaseQuantity<T, YottaCandela> val) where T:IConvertible {
        return new Quantity<double, ExaCandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaCandela to PetaCandela
    /// </summary>
    /// <param name="val">quantity measured in YottaCandela</param>
    /// <returns>quantity measured in PetaCandela</returns>
	public static Quantity<double, PetaCandela> ToPetaCandela<T>(this BaseQuantity<T, YottaCandela> val) where T:IConvertible {
        return new Quantity<double, PetaCandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaCandela to TeraCandela
    /// </summary>
    /// <param name="val">quantity measured in YottaCandela</param>
    /// <returns>quantity measured in TeraCandela</returns>
	public static Quantity<double, TeraCandela> ToTeraCandela<T>(this BaseQuantity<T, YottaCandela> val) where T:IConvertible {
        return new Quantity<double, TeraCandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaCandela to GigaCandela
    /// </summary>
    /// <param name="val">quantity measured in YottaCandela</param>
    /// <returns>quantity measured in GigaCandela</returns>
	public static Quantity<double, GigaCandela> ToGigaCandela<T>(this BaseQuantity<T, YottaCandela> val) where T:IConvertible {
        return new Quantity<double, GigaCandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaCandela to MegaCandela
    /// </summary>
    /// <param name="val">quantity measured in YottaCandela</param>
    /// <returns>quantity measured in MegaCandela</returns>
	public static Quantity<double, MegaCandela> ToMegaCandela<T>(this BaseQuantity<T, YottaCandela> val) where T:IConvertible {
        return new Quantity<double, MegaCandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaCandela to KiloCandela
    /// </summary>
    /// <param name="val">quantity measured in YottaCandela</param>
    /// <returns>quantity measured in KiloCandela</returns>
	public static Quantity<double, KiloCandela> ToKiloCandela<T>(this BaseQuantity<T, YottaCandela> val) where T:IConvertible {
        return new Quantity<double, KiloCandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaCandela to HectoCandela
    /// </summary>
    /// <param name="val">quantity measured in YottaCandela</param>
    /// <returns>quantity measured in HectoCandela</returns>
	public static Quantity<double, HectoCandela> ToHectoCandela<T>(this BaseQuantity<T, YottaCandela> val) where T:IConvertible {
        return new Quantity<double, HectoCandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaCandela to DekaCandela
    /// </summary>
    /// <param name="val">quantity measured in YottaCandela</param>
    /// <returns>quantity measured in DekaCandela</returns>
	public static Quantity<double, DekaCandela> ToDekaCandela<T>(this BaseQuantity<T, YottaCandela> val) where T:IConvertible {
        return new Quantity<double, DekaCandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaCandela to DeciCandela
    /// </summary>
    /// <param name="val">quantity measured in YottaCandela</param>
    /// <returns>quantity measured in DeciCandela</returns>
	public static Quantity<double, DeciCandela> ToDeciCandela<T>(this BaseQuantity<T, YottaCandela> val) where T:IConvertible {
        return new Quantity<double, DeciCandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaCandela to CentiCandela
    /// </summary>
    /// <param name="val">quantity measured in YottaCandela</param>
    /// <returns>quantity measured in CentiCandela</returns>
	public static Quantity<double, CentiCandela> ToCentiCandela<T>(this BaseQuantity<T, YottaCandela> val) where T:IConvertible {
        return new Quantity<double, CentiCandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaCandela to MilliCandela
    /// </summary>
    /// <param name="val">quantity measured in YottaCandela</param>
    /// <returns>quantity measured in MilliCandela</returns>
	public static Quantity<double, MilliCandela> ToMilliCandela<T>(this BaseQuantity<T, YottaCandela> val) where T:IConvertible {
        return new Quantity<double, MilliCandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaCandela to MicroCandela
    /// </summary>
    /// <param name="val">quantity measured in YottaCandela</param>
    /// <returns>quantity measured in MicroCandela</returns>
	public static Quantity<double, MicroCandela> ToMicroCandela<T>(this BaseQuantity<T, YottaCandela> val) where T:IConvertible {
        return new Quantity<double, MicroCandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaCandela to NanoCandela
    /// </summary>
    /// <param name="val">quantity measured in YottaCandela</param>
    /// <returns>quantity measured in NanoCandela</returns>
	public static Quantity<double, NanoCandela> ToNanoCandela<T>(this BaseQuantity<T, YottaCandela> val) where T:IConvertible {
        return new Quantity<double, NanoCandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaCandela to PicoCandela
    /// </summary>
    /// <param name="val">quantity measured in YottaCandela</param>
    /// <returns>quantity measured in PicoCandela</returns>
	public static Quantity<double, PicoCandela> ToPicoCandela<T>(this BaseQuantity<T, YottaCandela> val) where T:IConvertible {
        return new Quantity<double, PicoCandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaCandela to FemtoCandela
    /// </summary>
    /// <param name="val">quantity measured in YottaCandela</param>
    /// <returns>quantity measured in FemtoCandela</returns>
	public static Quantity<double, FemtoCandela> ToFemtoCandela<T>(this BaseQuantity<T, YottaCandela> val) where T:IConvertible {
        return new Quantity<double, FemtoCandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaCandela to AttoCandela
    /// </summary>
    /// <param name="val">quantity measured in YottaCandela</param>
    /// <returns>quantity measured in AttoCandela</returns>
	public static Quantity<double, AttoCandela> ToAttoCandela<T>(this BaseQuantity<T, YottaCandela> val) where T:IConvertible {
        return new Quantity<double, AttoCandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaCandela to ZeptoCandela
    /// </summary>
    /// <param name="val">quantity measured in YottaCandela</param>
    /// <returns>quantity measured in ZeptoCandela</returns>
	public static Quantity<double, ZeptoCandela> ToZeptoCandela<T>(this BaseQuantity<T, YottaCandela> val) where T:IConvertible {
        return new Quantity<double, ZeptoCandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaCandela to YoctoCandela
    /// </summary>
    /// <param name="val">quantity measured in YottaCandela</param>
    /// <returns>quantity measured in YoctoCandela</returns>
	public static Quantity<double, YoctoCandela> ToYoctoCandela<T>(this BaseQuantity<T, YottaCandela> val) where T:IConvertible {
        return new Quantity<double, YoctoCandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert ZettaCandela to YottaCandela
    /// </summary>
    /// <param name="val">quantity measured in ZettaCandela</param>
    /// <returns>quantity measured in YottaCandela</returns>
	public static Quantity<double, YottaCandela> ToYottaCandela<T>(this BaseQuantity<T, ZettaCandela> val) where T:IConvertible {
        return new Quantity<double, YottaCandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaCandela to ExaCandela
    /// </summary>
    /// <param name="val">quantity measured in ZettaCandela</param>
    /// <returns>quantity measured in ExaCandela</returns>
	public static Quantity<double, ExaCandela> ToExaCandela<T>(this BaseQuantity<T, ZettaCandela> val) where T:IConvertible {
        return new Quantity<double, ExaCandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaCandela to PetaCandela
    /// </summary>
    /// <param name="val">quantity measured in ZettaCandela</param>
    /// <returns>quantity measured in PetaCandela</returns>
	public static Quantity<double, PetaCandela> ToPetaCandela<T>(this BaseQuantity<T, ZettaCandela> val) where T:IConvertible {
        return new Quantity<double, PetaCandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaCandela to TeraCandela
    /// </summary>
    /// <param name="val">quantity measured in ZettaCandela</param>
    /// <returns>quantity measured in TeraCandela</returns>
	public static Quantity<double, TeraCandela> ToTeraCandela<T>(this BaseQuantity<T, ZettaCandela> val) where T:IConvertible {
        return new Quantity<double, TeraCandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaCandela to GigaCandela
    /// </summary>
    /// <param name="val">quantity measured in ZettaCandela</param>
    /// <returns>quantity measured in GigaCandela</returns>
	public static Quantity<double, GigaCandela> ToGigaCandela<T>(this BaseQuantity<T, ZettaCandela> val) where T:IConvertible {
        return new Quantity<double, GigaCandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaCandela to MegaCandela
    /// </summary>
    /// <param name="val">quantity measured in ZettaCandela</param>
    /// <returns>quantity measured in MegaCandela</returns>
	public static Quantity<double, MegaCandela> ToMegaCandela<T>(this BaseQuantity<T, ZettaCandela> val) where T:IConvertible {
        return new Quantity<double, MegaCandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaCandela to KiloCandela
    /// </summary>
    /// <param name="val">quantity measured in ZettaCandela</param>
    /// <returns>quantity measured in KiloCandela</returns>
	public static Quantity<double, KiloCandela> ToKiloCandela<T>(this BaseQuantity<T, ZettaCandela> val) where T:IConvertible {
        return new Quantity<double, KiloCandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaCandela to HectoCandela
    /// </summary>
    /// <param name="val">quantity measured in ZettaCandela</param>
    /// <returns>quantity measured in HectoCandela</returns>
	public static Quantity<double, HectoCandela> ToHectoCandela<T>(this BaseQuantity<T, ZettaCandela> val) where T:IConvertible {
        return new Quantity<double, HectoCandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaCandela to DekaCandela
    /// </summary>
    /// <param name="val">quantity measured in ZettaCandela</param>
    /// <returns>quantity measured in DekaCandela</returns>
	public static Quantity<double, DekaCandela> ToDekaCandela<T>(this BaseQuantity<T, ZettaCandela> val) where T:IConvertible {
        return new Quantity<double, DekaCandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaCandela to DeciCandela
    /// </summary>
    /// <param name="val">quantity measured in ZettaCandela</param>
    /// <returns>quantity measured in DeciCandela</returns>
	public static Quantity<double, DeciCandela> ToDeciCandela<T>(this BaseQuantity<T, ZettaCandela> val) where T:IConvertible {
        return new Quantity<double, DeciCandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaCandela to CentiCandela
    /// </summary>
    /// <param name="val">quantity measured in ZettaCandela</param>
    /// <returns>quantity measured in CentiCandela</returns>
	public static Quantity<double, CentiCandela> ToCentiCandela<T>(this BaseQuantity<T, ZettaCandela> val) where T:IConvertible {
        return new Quantity<double, CentiCandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaCandela to MilliCandela
    /// </summary>
    /// <param name="val">quantity measured in ZettaCandela</param>
    /// <returns>quantity measured in MilliCandela</returns>
	public static Quantity<double, MilliCandela> ToMilliCandela<T>(this BaseQuantity<T, ZettaCandela> val) where T:IConvertible {
        return new Quantity<double, MilliCandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaCandela to MicroCandela
    /// </summary>
    /// <param name="val">quantity measured in ZettaCandela</param>
    /// <returns>quantity measured in MicroCandela</returns>
	public static Quantity<double, MicroCandela> ToMicroCandela<T>(this BaseQuantity<T, ZettaCandela> val) where T:IConvertible {
        return new Quantity<double, MicroCandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaCandela to NanoCandela
    /// </summary>
    /// <param name="val">quantity measured in ZettaCandela</param>
    /// <returns>quantity measured in NanoCandela</returns>
	public static Quantity<double, NanoCandela> ToNanoCandela<T>(this BaseQuantity<T, ZettaCandela> val) where T:IConvertible {
        return new Quantity<double, NanoCandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaCandela to PicoCandela
    /// </summary>
    /// <param name="val">quantity measured in ZettaCandela</param>
    /// <returns>quantity measured in PicoCandela</returns>
	public static Quantity<double, PicoCandela> ToPicoCandela<T>(this BaseQuantity<T, ZettaCandela> val) where T:IConvertible {
        return new Quantity<double, PicoCandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaCandela to FemtoCandela
    /// </summary>
    /// <param name="val">quantity measured in ZettaCandela</param>
    /// <returns>quantity measured in FemtoCandela</returns>
	public static Quantity<double, FemtoCandela> ToFemtoCandela<T>(this BaseQuantity<T, ZettaCandela> val) where T:IConvertible {
        return new Quantity<double, FemtoCandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaCandela to AttoCandela
    /// </summary>
    /// <param name="val">quantity measured in ZettaCandela</param>
    /// <returns>quantity measured in AttoCandela</returns>
	public static Quantity<double, AttoCandela> ToAttoCandela<T>(this BaseQuantity<T, ZettaCandela> val) where T:IConvertible {
        return new Quantity<double, AttoCandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaCandela to ZeptoCandela
    /// </summary>
    /// <param name="val">quantity measured in ZettaCandela</param>
    /// <returns>quantity measured in ZeptoCandela</returns>
	public static Quantity<double, ZeptoCandela> ToZeptoCandela<T>(this BaseQuantity<T, ZettaCandela> val) where T:IConvertible {
        return new Quantity<double, ZeptoCandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaCandela to YoctoCandela
    /// </summary>
    /// <param name="val">quantity measured in ZettaCandela</param>
    /// <returns>quantity measured in YoctoCandela</returns>
	public static Quantity<double, YoctoCandela> ToYoctoCandela<T>(this BaseQuantity<T, ZettaCandela> val) where T:IConvertible {
        return new Quantity<double, YoctoCandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ExaCandela to YottaCandela
    /// </summary>
    /// <param name="val">quantity measured in ExaCandela</param>
    /// <returns>quantity measured in YottaCandela</returns>
	public static Quantity<double, YottaCandela> ToYottaCandela<T>(this BaseQuantity<T, ExaCandela> val) where T:IConvertible {
        return new Quantity<double, YottaCandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaCandela to ZettaCandela
    /// </summary>
    /// <param name="val">quantity measured in ExaCandela</param>
    /// <returns>quantity measured in ZettaCandela</returns>
	public static Quantity<double, ZettaCandela> ToZettaCandela<T>(this BaseQuantity<T, ExaCandela> val) where T:IConvertible {
        return new Quantity<double, ZettaCandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaCandela to PetaCandela
    /// </summary>
    /// <param name="val">quantity measured in ExaCandela</param>
    /// <returns>quantity measured in PetaCandela</returns>
	public static Quantity<double, PetaCandela> ToPetaCandela<T>(this BaseQuantity<T, ExaCandela> val) where T:IConvertible {
        return new Quantity<double, PetaCandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaCandela to TeraCandela
    /// </summary>
    /// <param name="val">quantity measured in ExaCandela</param>
    /// <returns>quantity measured in TeraCandela</returns>
	public static Quantity<double, TeraCandela> ToTeraCandela<T>(this BaseQuantity<T, ExaCandela> val) where T:IConvertible {
        return new Quantity<double, TeraCandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaCandela to GigaCandela
    /// </summary>
    /// <param name="val">quantity measured in ExaCandela</param>
    /// <returns>quantity measured in GigaCandela</returns>
	public static Quantity<double, GigaCandela> ToGigaCandela<T>(this BaseQuantity<T, ExaCandela> val) where T:IConvertible {
        return new Quantity<double, GigaCandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaCandela to MegaCandela
    /// </summary>
    /// <param name="val">quantity measured in ExaCandela</param>
    /// <returns>quantity measured in MegaCandela</returns>
	public static Quantity<double, MegaCandela> ToMegaCandela<T>(this BaseQuantity<T, ExaCandela> val) where T:IConvertible {
        return new Quantity<double, MegaCandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaCandela to KiloCandela
    /// </summary>
    /// <param name="val">quantity measured in ExaCandela</param>
    /// <returns>quantity measured in KiloCandela</returns>
	public static Quantity<double, KiloCandela> ToKiloCandela<T>(this BaseQuantity<T, ExaCandela> val) where T:IConvertible {
        return new Quantity<double, KiloCandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaCandela to HectoCandela
    /// </summary>
    /// <param name="val">quantity measured in ExaCandela</param>
    /// <returns>quantity measured in HectoCandela</returns>
	public static Quantity<double, HectoCandela> ToHectoCandela<T>(this BaseQuantity<T, ExaCandela> val) where T:IConvertible {
        return new Quantity<double, HectoCandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaCandela to DekaCandela
    /// </summary>
    /// <param name="val">quantity measured in ExaCandela</param>
    /// <returns>quantity measured in DekaCandela</returns>
	public static Quantity<double, DekaCandela> ToDekaCandela<T>(this BaseQuantity<T, ExaCandela> val) where T:IConvertible {
        return new Quantity<double, DekaCandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaCandela to DeciCandela
    /// </summary>
    /// <param name="val">quantity measured in ExaCandela</param>
    /// <returns>quantity measured in DeciCandela</returns>
	public static Quantity<double, DeciCandela> ToDeciCandela<T>(this BaseQuantity<T, ExaCandela> val) where T:IConvertible {
        return new Quantity<double, DeciCandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaCandela to CentiCandela
    /// </summary>
    /// <param name="val">quantity measured in ExaCandela</param>
    /// <returns>quantity measured in CentiCandela</returns>
	public static Quantity<double, CentiCandela> ToCentiCandela<T>(this BaseQuantity<T, ExaCandela> val) where T:IConvertible {
        return new Quantity<double, CentiCandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaCandela to MilliCandela
    /// </summary>
    /// <param name="val">quantity measured in ExaCandela</param>
    /// <returns>quantity measured in MilliCandela</returns>
	public static Quantity<double, MilliCandela> ToMilliCandela<T>(this BaseQuantity<T, ExaCandela> val) where T:IConvertible {
        return new Quantity<double, MilliCandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaCandela to MicroCandela
    /// </summary>
    /// <param name="val">quantity measured in ExaCandela</param>
    /// <returns>quantity measured in MicroCandela</returns>
	public static Quantity<double, MicroCandela> ToMicroCandela<T>(this BaseQuantity<T, ExaCandela> val) where T:IConvertible {
        return new Quantity<double, MicroCandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaCandela to NanoCandela
    /// </summary>
    /// <param name="val">quantity measured in ExaCandela</param>
    /// <returns>quantity measured in NanoCandela</returns>
	public static Quantity<double, NanoCandela> ToNanoCandela<T>(this BaseQuantity<T, ExaCandela> val) where T:IConvertible {
        return new Quantity<double, NanoCandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaCandela to PicoCandela
    /// </summary>
    /// <param name="val">quantity measured in ExaCandela</param>
    /// <returns>quantity measured in PicoCandela</returns>
	public static Quantity<double, PicoCandela> ToPicoCandela<T>(this BaseQuantity<T, ExaCandela> val) where T:IConvertible {
        return new Quantity<double, PicoCandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaCandela to FemtoCandela
    /// </summary>
    /// <param name="val">quantity measured in ExaCandela</param>
    /// <returns>quantity measured in FemtoCandela</returns>
	public static Quantity<double, FemtoCandela> ToFemtoCandela<T>(this BaseQuantity<T, ExaCandela> val) where T:IConvertible {
        return new Quantity<double, FemtoCandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaCandela to AttoCandela
    /// </summary>
    /// <param name="val">quantity measured in ExaCandela</param>
    /// <returns>quantity measured in AttoCandela</returns>
	public static Quantity<double, AttoCandela> ToAttoCandela<T>(this BaseQuantity<T, ExaCandela> val) where T:IConvertible {
        return new Quantity<double, AttoCandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaCandela to ZeptoCandela
    /// </summary>
    /// <param name="val">quantity measured in ExaCandela</param>
    /// <returns>quantity measured in ZeptoCandela</returns>
	public static Quantity<double, ZeptoCandela> ToZeptoCandela<T>(this BaseQuantity<T, ExaCandela> val) where T:IConvertible {
        return new Quantity<double, ZeptoCandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaCandela to YoctoCandela
    /// </summary>
    /// <param name="val">quantity measured in ExaCandela</param>
    /// <returns>quantity measured in YoctoCandela</returns>
	public static Quantity<double, YoctoCandela> ToYoctoCandela<T>(this BaseQuantity<T, ExaCandela> val) where T:IConvertible {
        return new Quantity<double, YoctoCandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert PetaCandela to YottaCandela
    /// </summary>
    /// <param name="val">quantity measured in PetaCandela</param>
    /// <returns>quantity measured in YottaCandela</returns>
	public static Quantity<double, YottaCandela> ToYottaCandela<T>(this BaseQuantity<T, PetaCandela> val) where T:IConvertible {
        return new Quantity<double, YottaCandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaCandela to ZettaCandela
    /// </summary>
    /// <param name="val">quantity measured in PetaCandela</param>
    /// <returns>quantity measured in ZettaCandela</returns>
	public static Quantity<double, ZettaCandela> ToZettaCandela<T>(this BaseQuantity<T, PetaCandela> val) where T:IConvertible {
        return new Quantity<double, ZettaCandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaCandela to ExaCandela
    /// </summary>
    /// <param name="val">quantity measured in PetaCandela</param>
    /// <returns>quantity measured in ExaCandela</returns>
	public static Quantity<double, ExaCandela> ToExaCandela<T>(this BaseQuantity<T, PetaCandela> val) where T:IConvertible {
        return new Quantity<double, ExaCandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaCandela to TeraCandela
    /// </summary>
    /// <param name="val">quantity measured in PetaCandela</param>
    /// <returns>quantity measured in TeraCandela</returns>
	public static Quantity<double, TeraCandela> ToTeraCandela<T>(this BaseQuantity<T, PetaCandela> val) where T:IConvertible {
        return new Quantity<double, TeraCandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaCandela to GigaCandela
    /// </summary>
    /// <param name="val">quantity measured in PetaCandela</param>
    /// <returns>quantity measured in GigaCandela</returns>
	public static Quantity<double, GigaCandela> ToGigaCandela<T>(this BaseQuantity<T, PetaCandela> val) where T:IConvertible {
        return new Quantity<double, GigaCandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaCandela to MegaCandela
    /// </summary>
    /// <param name="val">quantity measured in PetaCandela</param>
    /// <returns>quantity measured in MegaCandela</returns>
	public static Quantity<double, MegaCandela> ToMegaCandela<T>(this BaseQuantity<T, PetaCandela> val) where T:IConvertible {
        return new Quantity<double, MegaCandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaCandela to KiloCandela
    /// </summary>
    /// <param name="val">quantity measured in PetaCandela</param>
    /// <returns>quantity measured in KiloCandela</returns>
	public static Quantity<double, KiloCandela> ToKiloCandela<T>(this BaseQuantity<T, PetaCandela> val) where T:IConvertible {
        return new Quantity<double, KiloCandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaCandela to HectoCandela
    /// </summary>
    /// <param name="val">quantity measured in PetaCandela</param>
    /// <returns>quantity measured in HectoCandela</returns>
	public static Quantity<double, HectoCandela> ToHectoCandela<T>(this BaseQuantity<T, PetaCandela> val) where T:IConvertible {
        return new Quantity<double, HectoCandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaCandela to DekaCandela
    /// </summary>
    /// <param name="val">quantity measured in PetaCandela</param>
    /// <returns>quantity measured in DekaCandela</returns>
	public static Quantity<double, DekaCandela> ToDekaCandela<T>(this BaseQuantity<T, PetaCandela> val) where T:IConvertible {
        return new Quantity<double, DekaCandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaCandela to DeciCandela
    /// </summary>
    /// <param name="val">quantity measured in PetaCandela</param>
    /// <returns>quantity measured in DeciCandela</returns>
	public static Quantity<double, DeciCandela> ToDeciCandela<T>(this BaseQuantity<T, PetaCandela> val) where T:IConvertible {
        return new Quantity<double, DeciCandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaCandela to CentiCandela
    /// </summary>
    /// <param name="val">quantity measured in PetaCandela</param>
    /// <returns>quantity measured in CentiCandela</returns>
	public static Quantity<double, CentiCandela> ToCentiCandela<T>(this BaseQuantity<T, PetaCandela> val) where T:IConvertible {
        return new Quantity<double, CentiCandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaCandela to MilliCandela
    /// </summary>
    /// <param name="val">quantity measured in PetaCandela</param>
    /// <returns>quantity measured in MilliCandela</returns>
	public static Quantity<double, MilliCandela> ToMilliCandela<T>(this BaseQuantity<T, PetaCandela> val) where T:IConvertible {
        return new Quantity<double, MilliCandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaCandela to MicroCandela
    /// </summary>
    /// <param name="val">quantity measured in PetaCandela</param>
    /// <returns>quantity measured in MicroCandela</returns>
	public static Quantity<double, MicroCandela> ToMicroCandela<T>(this BaseQuantity<T, PetaCandela> val) where T:IConvertible {
        return new Quantity<double, MicroCandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaCandela to NanoCandela
    /// </summary>
    /// <param name="val">quantity measured in PetaCandela</param>
    /// <returns>quantity measured in NanoCandela</returns>
	public static Quantity<double, NanoCandela> ToNanoCandela<T>(this BaseQuantity<T, PetaCandela> val) where T:IConvertible {
        return new Quantity<double, NanoCandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaCandela to PicoCandela
    /// </summary>
    /// <param name="val">quantity measured in PetaCandela</param>
    /// <returns>quantity measured in PicoCandela</returns>
	public static Quantity<double, PicoCandela> ToPicoCandela<T>(this BaseQuantity<T, PetaCandela> val) where T:IConvertible {
        return new Quantity<double, PicoCandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaCandela to FemtoCandela
    /// </summary>
    /// <param name="val">quantity measured in PetaCandela</param>
    /// <returns>quantity measured in FemtoCandela</returns>
	public static Quantity<double, FemtoCandela> ToFemtoCandela<T>(this BaseQuantity<T, PetaCandela> val) where T:IConvertible {
        return new Quantity<double, FemtoCandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaCandela to AttoCandela
    /// </summary>
    /// <param name="val">quantity measured in PetaCandela</param>
    /// <returns>quantity measured in AttoCandela</returns>
	public static Quantity<double, AttoCandela> ToAttoCandela<T>(this BaseQuantity<T, PetaCandela> val) where T:IConvertible {
        return new Quantity<double, AttoCandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaCandela to ZeptoCandela
    /// </summary>
    /// <param name="val">quantity measured in PetaCandela</param>
    /// <returns>quantity measured in ZeptoCandela</returns>
	public static Quantity<double, ZeptoCandela> ToZeptoCandela<T>(this BaseQuantity<T, PetaCandela> val) where T:IConvertible {
        return new Quantity<double, ZeptoCandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaCandela to YoctoCandela
    /// </summary>
    /// <param name="val">quantity measured in PetaCandela</param>
    /// <returns>quantity measured in YoctoCandela</returns>
	public static Quantity<double, YoctoCandela> ToYoctoCandela<T>(this BaseQuantity<T, PetaCandela> val) where T:IConvertible {
        return new Quantity<double, YoctoCandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert TeraCandela to YottaCandela
    /// </summary>
    /// <param name="val">quantity measured in TeraCandela</param>
    /// <returns>quantity measured in YottaCandela</returns>
	public static Quantity<double, YottaCandela> ToYottaCandela<T>(this BaseQuantity<T, TeraCandela> val) where T:IConvertible {
        return new Quantity<double, YottaCandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraCandela to ZettaCandela
    /// </summary>
    /// <param name="val">quantity measured in TeraCandela</param>
    /// <returns>quantity measured in ZettaCandela</returns>
	public static Quantity<double, ZettaCandela> ToZettaCandela<T>(this BaseQuantity<T, TeraCandela> val) where T:IConvertible {
        return new Quantity<double, ZettaCandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraCandela to ExaCandela
    /// </summary>
    /// <param name="val">quantity measured in TeraCandela</param>
    /// <returns>quantity measured in ExaCandela</returns>
	public static Quantity<double, ExaCandela> ToExaCandela<T>(this BaseQuantity<T, TeraCandela> val) where T:IConvertible {
        return new Quantity<double, ExaCandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraCandela to PetaCandela
    /// </summary>
    /// <param name="val">quantity measured in TeraCandela</param>
    /// <returns>quantity measured in PetaCandela</returns>
	public static Quantity<double, PetaCandela> ToPetaCandela<T>(this BaseQuantity<T, TeraCandela> val) where T:IConvertible {
        return new Quantity<double, PetaCandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraCandela to GigaCandela
    /// </summary>
    /// <param name="val">quantity measured in TeraCandela</param>
    /// <returns>quantity measured in GigaCandela</returns>
	public static Quantity<double, GigaCandela> ToGigaCandela<T>(this BaseQuantity<T, TeraCandela> val) where T:IConvertible {
        return new Quantity<double, GigaCandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraCandela to MegaCandela
    /// </summary>
    /// <param name="val">quantity measured in TeraCandela</param>
    /// <returns>quantity measured in MegaCandela</returns>
	public static Quantity<double, MegaCandela> ToMegaCandela<T>(this BaseQuantity<T, TeraCandela> val) where T:IConvertible {
        return new Quantity<double, MegaCandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraCandela to KiloCandela
    /// </summary>
    /// <param name="val">quantity measured in TeraCandela</param>
    /// <returns>quantity measured in KiloCandela</returns>
	public static Quantity<double, KiloCandela> ToKiloCandela<T>(this BaseQuantity<T, TeraCandela> val) where T:IConvertible {
        return new Quantity<double, KiloCandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraCandela to HectoCandela
    /// </summary>
    /// <param name="val">quantity measured in TeraCandela</param>
    /// <returns>quantity measured in HectoCandela</returns>
	public static Quantity<double, HectoCandela> ToHectoCandela<T>(this BaseQuantity<T, TeraCandela> val) where T:IConvertible {
        return new Quantity<double, HectoCandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraCandela to DekaCandela
    /// </summary>
    /// <param name="val">quantity measured in TeraCandela</param>
    /// <returns>quantity measured in DekaCandela</returns>
	public static Quantity<double, DekaCandela> ToDekaCandela<T>(this BaseQuantity<T, TeraCandela> val) where T:IConvertible {
        return new Quantity<double, DekaCandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraCandela to DeciCandela
    /// </summary>
    /// <param name="val">quantity measured in TeraCandela</param>
    /// <returns>quantity measured in DeciCandela</returns>
	public static Quantity<double, DeciCandela> ToDeciCandela<T>(this BaseQuantity<T, TeraCandela> val) where T:IConvertible {
        return new Quantity<double, DeciCandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraCandela to CentiCandela
    /// </summary>
    /// <param name="val">quantity measured in TeraCandela</param>
    /// <returns>quantity measured in CentiCandela</returns>
	public static Quantity<double, CentiCandela> ToCentiCandela<T>(this BaseQuantity<T, TeraCandela> val) where T:IConvertible {
        return new Quantity<double, CentiCandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraCandela to MilliCandela
    /// </summary>
    /// <param name="val">quantity measured in TeraCandela</param>
    /// <returns>quantity measured in MilliCandela</returns>
	public static Quantity<double, MilliCandela> ToMilliCandela<T>(this BaseQuantity<T, TeraCandela> val) where T:IConvertible {
        return new Quantity<double, MilliCandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraCandela to MicroCandela
    /// </summary>
    /// <param name="val">quantity measured in TeraCandela</param>
    /// <returns>quantity measured in MicroCandela</returns>
	public static Quantity<double, MicroCandela> ToMicroCandela<T>(this BaseQuantity<T, TeraCandela> val) where T:IConvertible {
        return new Quantity<double, MicroCandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraCandela to NanoCandela
    /// </summary>
    /// <param name="val">quantity measured in TeraCandela</param>
    /// <returns>quantity measured in NanoCandela</returns>
	public static Quantity<double, NanoCandela> ToNanoCandela<T>(this BaseQuantity<T, TeraCandela> val) where T:IConvertible {
        return new Quantity<double, NanoCandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraCandela to PicoCandela
    /// </summary>
    /// <param name="val">quantity measured in TeraCandela</param>
    /// <returns>quantity measured in PicoCandela</returns>
	public static Quantity<double, PicoCandela> ToPicoCandela<T>(this BaseQuantity<T, TeraCandela> val) where T:IConvertible {
        return new Quantity<double, PicoCandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraCandela to FemtoCandela
    /// </summary>
    /// <param name="val">quantity measured in TeraCandela</param>
    /// <returns>quantity measured in FemtoCandela</returns>
	public static Quantity<double, FemtoCandela> ToFemtoCandela<T>(this BaseQuantity<T, TeraCandela> val) where T:IConvertible {
        return new Quantity<double, FemtoCandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraCandela to AttoCandela
    /// </summary>
    /// <param name="val">quantity measured in TeraCandela</param>
    /// <returns>quantity measured in AttoCandela</returns>
	public static Quantity<double, AttoCandela> ToAttoCandela<T>(this BaseQuantity<T, TeraCandela> val) where T:IConvertible {
        return new Quantity<double, AttoCandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraCandela to ZeptoCandela
    /// </summary>
    /// <param name="val">quantity measured in TeraCandela</param>
    /// <returns>quantity measured in ZeptoCandela</returns>
	public static Quantity<double, ZeptoCandela> ToZeptoCandela<T>(this BaseQuantity<T, TeraCandela> val) where T:IConvertible {
        return new Quantity<double, ZeptoCandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraCandela to YoctoCandela
    /// </summary>
    /// <param name="val">quantity measured in TeraCandela</param>
    /// <returns>quantity measured in YoctoCandela</returns>
	public static Quantity<double, YoctoCandela> ToYoctoCandela<T>(this BaseQuantity<T, TeraCandela> val) where T:IConvertible {
        return new Quantity<double, YoctoCandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert GigaCandela to YottaCandela
    /// </summary>
    /// <param name="val">quantity measured in GigaCandela</param>
    /// <returns>quantity measured in YottaCandela</returns>
	public static Quantity<double, YottaCandela> ToYottaCandela<T>(this BaseQuantity<T, GigaCandela> val) where T:IConvertible {
        return new Quantity<double, YottaCandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaCandela to ZettaCandela
    /// </summary>
    /// <param name="val">quantity measured in GigaCandela</param>
    /// <returns>quantity measured in ZettaCandela</returns>
	public static Quantity<double, ZettaCandela> ToZettaCandela<T>(this BaseQuantity<T, GigaCandela> val) where T:IConvertible {
        return new Quantity<double, ZettaCandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaCandela to ExaCandela
    /// </summary>
    /// <param name="val">quantity measured in GigaCandela</param>
    /// <returns>quantity measured in ExaCandela</returns>
	public static Quantity<double, ExaCandela> ToExaCandela<T>(this BaseQuantity<T, GigaCandela> val) where T:IConvertible {
        return new Quantity<double, ExaCandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaCandela to PetaCandela
    /// </summary>
    /// <param name="val">quantity measured in GigaCandela</param>
    /// <returns>quantity measured in PetaCandela</returns>
	public static Quantity<double, PetaCandela> ToPetaCandela<T>(this BaseQuantity<T, GigaCandela> val) where T:IConvertible {
        return new Quantity<double, PetaCandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaCandela to TeraCandela
    /// </summary>
    /// <param name="val">quantity measured in GigaCandela</param>
    /// <returns>quantity measured in TeraCandela</returns>
	public static Quantity<double, TeraCandela> ToTeraCandela<T>(this BaseQuantity<T, GigaCandela> val) where T:IConvertible {
        return new Quantity<double, TeraCandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaCandela to MegaCandela
    /// </summary>
    /// <param name="val">quantity measured in GigaCandela</param>
    /// <returns>quantity measured in MegaCandela</returns>
	public static Quantity<double, MegaCandela> ToMegaCandela<T>(this BaseQuantity<T, GigaCandela> val) where T:IConvertible {
        return new Quantity<double, MegaCandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaCandela to KiloCandela
    /// </summary>
    /// <param name="val">quantity measured in GigaCandela</param>
    /// <returns>quantity measured in KiloCandela</returns>
	public static Quantity<double, KiloCandela> ToKiloCandela<T>(this BaseQuantity<T, GigaCandela> val) where T:IConvertible {
        return new Quantity<double, KiloCandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaCandela to HectoCandela
    /// </summary>
    /// <param name="val">quantity measured in GigaCandela</param>
    /// <returns>quantity measured in HectoCandela</returns>
	public static Quantity<double, HectoCandela> ToHectoCandela<T>(this BaseQuantity<T, GigaCandela> val) where T:IConvertible {
        return new Quantity<double, HectoCandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaCandela to DekaCandela
    /// </summary>
    /// <param name="val">quantity measured in GigaCandela</param>
    /// <returns>quantity measured in DekaCandela</returns>
	public static Quantity<double, DekaCandela> ToDekaCandela<T>(this BaseQuantity<T, GigaCandela> val) where T:IConvertible {
        return new Quantity<double, DekaCandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaCandela to DeciCandela
    /// </summary>
    /// <param name="val">quantity measured in GigaCandela</param>
    /// <returns>quantity measured in DeciCandela</returns>
	public static Quantity<double, DeciCandela> ToDeciCandela<T>(this BaseQuantity<T, GigaCandela> val) where T:IConvertible {
        return new Quantity<double, DeciCandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaCandela to CentiCandela
    /// </summary>
    /// <param name="val">quantity measured in GigaCandela</param>
    /// <returns>quantity measured in CentiCandela</returns>
	public static Quantity<double, CentiCandela> ToCentiCandela<T>(this BaseQuantity<T, GigaCandela> val) where T:IConvertible {
        return new Quantity<double, CentiCandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaCandela to MilliCandela
    /// </summary>
    /// <param name="val">quantity measured in GigaCandela</param>
    /// <returns>quantity measured in MilliCandela</returns>
	public static Quantity<double, MilliCandela> ToMilliCandela<T>(this BaseQuantity<T, GigaCandela> val) where T:IConvertible {
        return new Quantity<double, MilliCandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaCandela to MicroCandela
    /// </summary>
    /// <param name="val">quantity measured in GigaCandela</param>
    /// <returns>quantity measured in MicroCandela</returns>
	public static Quantity<double, MicroCandela> ToMicroCandela<T>(this BaseQuantity<T, GigaCandela> val) where T:IConvertible {
        return new Quantity<double, MicroCandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaCandela to NanoCandela
    /// </summary>
    /// <param name="val">quantity measured in GigaCandela</param>
    /// <returns>quantity measured in NanoCandela</returns>
	public static Quantity<double, NanoCandela> ToNanoCandela<T>(this BaseQuantity<T, GigaCandela> val) where T:IConvertible {
        return new Quantity<double, NanoCandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaCandela to PicoCandela
    /// </summary>
    /// <param name="val">quantity measured in GigaCandela</param>
    /// <returns>quantity measured in PicoCandela</returns>
	public static Quantity<double, PicoCandela> ToPicoCandela<T>(this BaseQuantity<T, GigaCandela> val) where T:IConvertible {
        return new Quantity<double, PicoCandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaCandela to FemtoCandela
    /// </summary>
    /// <param name="val">quantity measured in GigaCandela</param>
    /// <returns>quantity measured in FemtoCandela</returns>
	public static Quantity<double, FemtoCandela> ToFemtoCandela<T>(this BaseQuantity<T, GigaCandela> val) where T:IConvertible {
        return new Quantity<double, FemtoCandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaCandela to AttoCandela
    /// </summary>
    /// <param name="val">quantity measured in GigaCandela</param>
    /// <returns>quantity measured in AttoCandela</returns>
	public static Quantity<double, AttoCandela> ToAttoCandela<T>(this BaseQuantity<T, GigaCandela> val) where T:IConvertible {
        return new Quantity<double, AttoCandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaCandela to ZeptoCandela
    /// </summary>
    /// <param name="val">quantity measured in GigaCandela</param>
    /// <returns>quantity measured in ZeptoCandela</returns>
	public static Quantity<double, ZeptoCandela> ToZeptoCandela<T>(this BaseQuantity<T, GigaCandela> val) where T:IConvertible {
        return new Quantity<double, ZeptoCandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaCandela to YoctoCandela
    /// </summary>
    /// <param name="val">quantity measured in GigaCandela</param>
    /// <returns>quantity measured in YoctoCandela</returns>
	public static Quantity<double, YoctoCandela> ToYoctoCandela<T>(this BaseQuantity<T, GigaCandela> val) where T:IConvertible {
        return new Quantity<double, YoctoCandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert MegaCandela to YottaCandela
    /// </summary>
    /// <param name="val">quantity measured in MegaCandela</param>
    /// <returns>quantity measured in YottaCandela</returns>
	public static Quantity<double, YottaCandela> ToYottaCandela<T>(this BaseQuantity<T, MegaCandela> val) where T:IConvertible {
        return new Quantity<double, YottaCandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaCandela to ZettaCandela
    /// </summary>
    /// <param name="val">quantity measured in MegaCandela</param>
    /// <returns>quantity measured in ZettaCandela</returns>
	public static Quantity<double, ZettaCandela> ToZettaCandela<T>(this BaseQuantity<T, MegaCandela> val) where T:IConvertible {
        return new Quantity<double, ZettaCandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaCandela to ExaCandela
    /// </summary>
    /// <param name="val">quantity measured in MegaCandela</param>
    /// <returns>quantity measured in ExaCandela</returns>
	public static Quantity<double, ExaCandela> ToExaCandela<T>(this BaseQuantity<T, MegaCandela> val) where T:IConvertible {
        return new Quantity<double, ExaCandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaCandela to PetaCandela
    /// </summary>
    /// <param name="val">quantity measured in MegaCandela</param>
    /// <returns>quantity measured in PetaCandela</returns>
	public static Quantity<double, PetaCandela> ToPetaCandela<T>(this BaseQuantity<T, MegaCandela> val) where T:IConvertible {
        return new Quantity<double, PetaCandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaCandela to TeraCandela
    /// </summary>
    /// <param name="val">quantity measured in MegaCandela</param>
    /// <returns>quantity measured in TeraCandela</returns>
	public static Quantity<double, TeraCandela> ToTeraCandela<T>(this BaseQuantity<T, MegaCandela> val) where T:IConvertible {
        return new Quantity<double, TeraCandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaCandela to GigaCandela
    /// </summary>
    /// <param name="val">quantity measured in MegaCandela</param>
    /// <returns>quantity measured in GigaCandela</returns>
	public static Quantity<double, GigaCandela> ToGigaCandela<T>(this BaseQuantity<T, MegaCandela> val) where T:IConvertible {
        return new Quantity<double, GigaCandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaCandela to KiloCandela
    /// </summary>
    /// <param name="val">quantity measured in MegaCandela</param>
    /// <returns>quantity measured in KiloCandela</returns>
	public static Quantity<double, KiloCandela> ToKiloCandela<T>(this BaseQuantity<T, MegaCandela> val) where T:IConvertible {
        return new Quantity<double, KiloCandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaCandela to HectoCandela
    /// </summary>
    /// <param name="val">quantity measured in MegaCandela</param>
    /// <returns>quantity measured in HectoCandela</returns>
	public static Quantity<double, HectoCandela> ToHectoCandela<T>(this BaseQuantity<T, MegaCandela> val) where T:IConvertible {
        return new Quantity<double, HectoCandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaCandela to DekaCandela
    /// </summary>
    /// <param name="val">quantity measured in MegaCandela</param>
    /// <returns>quantity measured in DekaCandela</returns>
	public static Quantity<double, DekaCandela> ToDekaCandela<T>(this BaseQuantity<T, MegaCandela> val) where T:IConvertible {
        return new Quantity<double, DekaCandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaCandela to DeciCandela
    /// </summary>
    /// <param name="val">quantity measured in MegaCandela</param>
    /// <returns>quantity measured in DeciCandela</returns>
	public static Quantity<double, DeciCandela> ToDeciCandela<T>(this BaseQuantity<T, MegaCandela> val) where T:IConvertible {
        return new Quantity<double, DeciCandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaCandela to CentiCandela
    /// </summary>
    /// <param name="val">quantity measured in MegaCandela</param>
    /// <returns>quantity measured in CentiCandela</returns>
	public static Quantity<double, CentiCandela> ToCentiCandela<T>(this BaseQuantity<T, MegaCandela> val) where T:IConvertible {
        return new Quantity<double, CentiCandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaCandela to MilliCandela
    /// </summary>
    /// <param name="val">quantity measured in MegaCandela</param>
    /// <returns>quantity measured in MilliCandela</returns>
	public static Quantity<double, MilliCandela> ToMilliCandela<T>(this BaseQuantity<T, MegaCandela> val) where T:IConvertible {
        return new Quantity<double, MilliCandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaCandela to MicroCandela
    /// </summary>
    /// <param name="val">quantity measured in MegaCandela</param>
    /// <returns>quantity measured in MicroCandela</returns>
	public static Quantity<double, MicroCandela> ToMicroCandela<T>(this BaseQuantity<T, MegaCandela> val) where T:IConvertible {
        return new Quantity<double, MicroCandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaCandela to NanoCandela
    /// </summary>
    /// <param name="val">quantity measured in MegaCandela</param>
    /// <returns>quantity measured in NanoCandela</returns>
	public static Quantity<double, NanoCandela> ToNanoCandela<T>(this BaseQuantity<T, MegaCandela> val) where T:IConvertible {
        return new Quantity<double, NanoCandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaCandela to PicoCandela
    /// </summary>
    /// <param name="val">quantity measured in MegaCandela</param>
    /// <returns>quantity measured in PicoCandela</returns>
	public static Quantity<double, PicoCandela> ToPicoCandela<T>(this BaseQuantity<T, MegaCandela> val) where T:IConvertible {
        return new Quantity<double, PicoCandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaCandela to FemtoCandela
    /// </summary>
    /// <param name="val">quantity measured in MegaCandela</param>
    /// <returns>quantity measured in FemtoCandela</returns>
	public static Quantity<double, FemtoCandela> ToFemtoCandela<T>(this BaseQuantity<T, MegaCandela> val) where T:IConvertible {
        return new Quantity<double, FemtoCandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaCandela to AttoCandela
    /// </summary>
    /// <param name="val">quantity measured in MegaCandela</param>
    /// <returns>quantity measured in AttoCandela</returns>
	public static Quantity<double, AttoCandela> ToAttoCandela<T>(this BaseQuantity<T, MegaCandela> val) where T:IConvertible {
        return new Quantity<double, AttoCandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaCandela to ZeptoCandela
    /// </summary>
    /// <param name="val">quantity measured in MegaCandela</param>
    /// <returns>quantity measured in ZeptoCandela</returns>
	public static Quantity<double, ZeptoCandela> ToZeptoCandela<T>(this BaseQuantity<T, MegaCandela> val) where T:IConvertible {
        return new Quantity<double, ZeptoCandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaCandela to YoctoCandela
    /// </summary>
    /// <param name="val">quantity measured in MegaCandela</param>
    /// <returns>quantity measured in YoctoCandela</returns>
	public static Quantity<double, YoctoCandela> ToYoctoCandela<T>(this BaseQuantity<T, MegaCandela> val) where T:IConvertible {
        return new Quantity<double, YoctoCandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert KiloCandela to YottaCandela
    /// </summary>
    /// <param name="val">quantity measured in KiloCandela</param>
    /// <returns>quantity measured in YottaCandela</returns>
	public static Quantity<double, YottaCandela> ToYottaCandela<T>(this BaseQuantity<T, KiloCandela> val) where T:IConvertible {
        return new Quantity<double, YottaCandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloCandela to ZettaCandela
    /// </summary>
    /// <param name="val">quantity measured in KiloCandela</param>
    /// <returns>quantity measured in ZettaCandela</returns>
	public static Quantity<double, ZettaCandela> ToZettaCandela<T>(this BaseQuantity<T, KiloCandela> val) where T:IConvertible {
        return new Quantity<double, ZettaCandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloCandela to ExaCandela
    /// </summary>
    /// <param name="val">quantity measured in KiloCandela</param>
    /// <returns>quantity measured in ExaCandela</returns>
	public static Quantity<double, ExaCandela> ToExaCandela<T>(this BaseQuantity<T, KiloCandela> val) where T:IConvertible {
        return new Quantity<double, ExaCandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloCandela to PetaCandela
    /// </summary>
    /// <param name="val">quantity measured in KiloCandela</param>
    /// <returns>quantity measured in PetaCandela</returns>
	public static Quantity<double, PetaCandela> ToPetaCandela<T>(this BaseQuantity<T, KiloCandela> val) where T:IConvertible {
        return new Quantity<double, PetaCandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloCandela to TeraCandela
    /// </summary>
    /// <param name="val">quantity measured in KiloCandela</param>
    /// <returns>quantity measured in TeraCandela</returns>
	public static Quantity<double, TeraCandela> ToTeraCandela<T>(this BaseQuantity<T, KiloCandela> val) where T:IConvertible {
        return new Quantity<double, TeraCandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloCandela to GigaCandela
    /// </summary>
    /// <param name="val">quantity measured in KiloCandela</param>
    /// <returns>quantity measured in GigaCandela</returns>
	public static Quantity<double, GigaCandela> ToGigaCandela<T>(this BaseQuantity<T, KiloCandela> val) where T:IConvertible {
        return new Quantity<double, GigaCandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloCandela to MegaCandela
    /// </summary>
    /// <param name="val">quantity measured in KiloCandela</param>
    /// <returns>quantity measured in MegaCandela</returns>
	public static Quantity<double, MegaCandela> ToMegaCandela<T>(this BaseQuantity<T, KiloCandela> val) where T:IConvertible {
        return new Quantity<double, MegaCandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloCandela to HectoCandela
    /// </summary>
    /// <param name="val">quantity measured in KiloCandela</param>
    /// <returns>quantity measured in HectoCandela</returns>
	public static Quantity<double, HectoCandela> ToHectoCandela<T>(this BaseQuantity<T, KiloCandela> val) where T:IConvertible {
        return new Quantity<double, HectoCandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloCandela to DekaCandela
    /// </summary>
    /// <param name="val">quantity measured in KiloCandela</param>
    /// <returns>quantity measured in DekaCandela</returns>
	public static Quantity<double, DekaCandela> ToDekaCandela<T>(this BaseQuantity<T, KiloCandela> val) where T:IConvertible {
        return new Quantity<double, DekaCandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloCandela to DeciCandela
    /// </summary>
    /// <param name="val">quantity measured in KiloCandela</param>
    /// <returns>quantity measured in DeciCandela</returns>
	public static Quantity<double, DeciCandela> ToDeciCandela<T>(this BaseQuantity<T, KiloCandela> val) where T:IConvertible {
        return new Quantity<double, DeciCandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloCandela to CentiCandela
    /// </summary>
    /// <param name="val">quantity measured in KiloCandela</param>
    /// <returns>quantity measured in CentiCandela</returns>
	public static Quantity<double, CentiCandela> ToCentiCandela<T>(this BaseQuantity<T, KiloCandela> val) where T:IConvertible {
        return new Quantity<double, CentiCandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloCandela to MilliCandela
    /// </summary>
    /// <param name="val">quantity measured in KiloCandela</param>
    /// <returns>quantity measured in MilliCandela</returns>
	public static Quantity<double, MilliCandela> ToMilliCandela<T>(this BaseQuantity<T, KiloCandela> val) where T:IConvertible {
        return new Quantity<double, MilliCandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloCandela to MicroCandela
    /// </summary>
    /// <param name="val">quantity measured in KiloCandela</param>
    /// <returns>quantity measured in MicroCandela</returns>
	public static Quantity<double, MicroCandela> ToMicroCandela<T>(this BaseQuantity<T, KiloCandela> val) where T:IConvertible {
        return new Quantity<double, MicroCandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloCandela to NanoCandela
    /// </summary>
    /// <param name="val">quantity measured in KiloCandela</param>
    /// <returns>quantity measured in NanoCandela</returns>
	public static Quantity<double, NanoCandela> ToNanoCandela<T>(this BaseQuantity<T, KiloCandela> val) where T:IConvertible {
        return new Quantity<double, NanoCandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloCandela to PicoCandela
    /// </summary>
    /// <param name="val">quantity measured in KiloCandela</param>
    /// <returns>quantity measured in PicoCandela</returns>
	public static Quantity<double, PicoCandela> ToPicoCandela<T>(this BaseQuantity<T, KiloCandela> val) where T:IConvertible {
        return new Quantity<double, PicoCandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloCandela to FemtoCandela
    /// </summary>
    /// <param name="val">quantity measured in KiloCandela</param>
    /// <returns>quantity measured in FemtoCandela</returns>
	public static Quantity<double, FemtoCandela> ToFemtoCandela<T>(this BaseQuantity<T, KiloCandela> val) where T:IConvertible {
        return new Quantity<double, FemtoCandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloCandela to AttoCandela
    /// </summary>
    /// <param name="val">quantity measured in KiloCandela</param>
    /// <returns>quantity measured in AttoCandela</returns>
	public static Quantity<double, AttoCandela> ToAttoCandela<T>(this BaseQuantity<T, KiloCandela> val) where T:IConvertible {
        return new Quantity<double, AttoCandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloCandela to ZeptoCandela
    /// </summary>
    /// <param name="val">quantity measured in KiloCandela</param>
    /// <returns>quantity measured in ZeptoCandela</returns>
	public static Quantity<double, ZeptoCandela> ToZeptoCandela<T>(this BaseQuantity<T, KiloCandela> val) where T:IConvertible {
        return new Quantity<double, ZeptoCandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloCandela to YoctoCandela
    /// </summary>
    /// <param name="val">quantity measured in KiloCandela</param>
    /// <returns>quantity measured in YoctoCandela</returns>
	public static Quantity<double, YoctoCandela> ToYoctoCandela<T>(this BaseQuantity<T, KiloCandela> val) where T:IConvertible {
        return new Quantity<double, YoctoCandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert HectoCandela to YottaCandela
    /// </summary>
    /// <param name="val">quantity measured in HectoCandela</param>
    /// <returns>quantity measured in YottaCandela</returns>
	public static Quantity<double, YottaCandela> ToYottaCandela<T>(this BaseQuantity<T, HectoCandela> val) where T:IConvertible {
        return new Quantity<double, YottaCandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoCandela to ZettaCandela
    /// </summary>
    /// <param name="val">quantity measured in HectoCandela</param>
    /// <returns>quantity measured in ZettaCandela</returns>
	public static Quantity<double, ZettaCandela> ToZettaCandela<T>(this BaseQuantity<T, HectoCandela> val) where T:IConvertible {
        return new Quantity<double, ZettaCandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoCandela to ExaCandela
    /// </summary>
    /// <param name="val">quantity measured in HectoCandela</param>
    /// <returns>quantity measured in ExaCandela</returns>
	public static Quantity<double, ExaCandela> ToExaCandela<T>(this BaseQuantity<T, HectoCandela> val) where T:IConvertible {
        return new Quantity<double, ExaCandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoCandela to PetaCandela
    /// </summary>
    /// <param name="val">quantity measured in HectoCandela</param>
    /// <returns>quantity measured in PetaCandela</returns>
	public static Quantity<double, PetaCandela> ToPetaCandela<T>(this BaseQuantity<T, HectoCandela> val) where T:IConvertible {
        return new Quantity<double, PetaCandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoCandela to TeraCandela
    /// </summary>
    /// <param name="val">quantity measured in HectoCandela</param>
    /// <returns>quantity measured in TeraCandela</returns>
	public static Quantity<double, TeraCandela> ToTeraCandela<T>(this BaseQuantity<T, HectoCandela> val) where T:IConvertible {
        return new Quantity<double, TeraCandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoCandela to GigaCandela
    /// </summary>
    /// <param name="val">quantity measured in HectoCandela</param>
    /// <returns>quantity measured in GigaCandela</returns>
	public static Quantity<double, GigaCandela> ToGigaCandela<T>(this BaseQuantity<T, HectoCandela> val) where T:IConvertible {
        return new Quantity<double, GigaCandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoCandela to MegaCandela
    /// </summary>
    /// <param name="val">quantity measured in HectoCandela</param>
    /// <returns>quantity measured in MegaCandela</returns>
	public static Quantity<double, MegaCandela> ToMegaCandela<T>(this BaseQuantity<T, HectoCandela> val) where T:IConvertible {
        return new Quantity<double, MegaCandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoCandela to KiloCandela
    /// </summary>
    /// <param name="val">quantity measured in HectoCandela</param>
    /// <returns>quantity measured in KiloCandela</returns>
	public static Quantity<double, KiloCandela> ToKiloCandela<T>(this BaseQuantity<T, HectoCandela> val) where T:IConvertible {
        return new Quantity<double, KiloCandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoCandela to DekaCandela
    /// </summary>
    /// <param name="val">quantity measured in HectoCandela</param>
    /// <returns>quantity measured in DekaCandela</returns>
	public static Quantity<double, DekaCandela> ToDekaCandela<T>(this BaseQuantity<T, HectoCandela> val) where T:IConvertible {
        return new Quantity<double, DekaCandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoCandela to DeciCandela
    /// </summary>
    /// <param name="val">quantity measured in HectoCandela</param>
    /// <returns>quantity measured in DeciCandela</returns>
	public static Quantity<double, DeciCandela> ToDeciCandela<T>(this BaseQuantity<T, HectoCandela> val) where T:IConvertible {
        return new Quantity<double, DeciCandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoCandela to CentiCandela
    /// </summary>
    /// <param name="val">quantity measured in HectoCandela</param>
    /// <returns>quantity measured in CentiCandela</returns>
	public static Quantity<double, CentiCandela> ToCentiCandela<T>(this BaseQuantity<T, HectoCandela> val) where T:IConvertible {
        return new Quantity<double, CentiCandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoCandela to MilliCandela
    /// </summary>
    /// <param name="val">quantity measured in HectoCandela</param>
    /// <returns>quantity measured in MilliCandela</returns>
	public static Quantity<double, MilliCandela> ToMilliCandela<T>(this BaseQuantity<T, HectoCandela> val) where T:IConvertible {
        return new Quantity<double, MilliCandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoCandela to MicroCandela
    /// </summary>
    /// <param name="val">quantity measured in HectoCandela</param>
    /// <returns>quantity measured in MicroCandela</returns>
	public static Quantity<double, MicroCandela> ToMicroCandela<T>(this BaseQuantity<T, HectoCandela> val) where T:IConvertible {
        return new Quantity<double, MicroCandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoCandela to NanoCandela
    /// </summary>
    /// <param name="val">quantity measured in HectoCandela</param>
    /// <returns>quantity measured in NanoCandela</returns>
	public static Quantity<double, NanoCandela> ToNanoCandela<T>(this BaseQuantity<T, HectoCandela> val) where T:IConvertible {
        return new Quantity<double, NanoCandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoCandela to PicoCandela
    /// </summary>
    /// <param name="val">quantity measured in HectoCandela</param>
    /// <returns>quantity measured in PicoCandela</returns>
	public static Quantity<double, PicoCandela> ToPicoCandela<T>(this BaseQuantity<T, HectoCandela> val) where T:IConvertible {
        return new Quantity<double, PicoCandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoCandela to FemtoCandela
    /// </summary>
    /// <param name="val">quantity measured in HectoCandela</param>
    /// <returns>quantity measured in FemtoCandela</returns>
	public static Quantity<double, FemtoCandela> ToFemtoCandela<T>(this BaseQuantity<T, HectoCandela> val) where T:IConvertible {
        return new Quantity<double, FemtoCandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoCandela to AttoCandela
    /// </summary>
    /// <param name="val">quantity measured in HectoCandela</param>
    /// <returns>quantity measured in AttoCandela</returns>
	public static Quantity<double, AttoCandela> ToAttoCandela<T>(this BaseQuantity<T, HectoCandela> val) where T:IConvertible {
        return new Quantity<double, AttoCandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoCandela to ZeptoCandela
    /// </summary>
    /// <param name="val">quantity measured in HectoCandela</param>
    /// <returns>quantity measured in ZeptoCandela</returns>
	public static Quantity<double, ZeptoCandela> ToZeptoCandela<T>(this BaseQuantity<T, HectoCandela> val) where T:IConvertible {
        return new Quantity<double, ZeptoCandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoCandela to YoctoCandela
    /// </summary>
    /// <param name="val">quantity measured in HectoCandela</param>
    /// <returns>quantity measured in YoctoCandela</returns>
	public static Quantity<double, YoctoCandela> ToYoctoCandela<T>(this BaseQuantity<T, HectoCandela> val) where T:IConvertible {
        return new Quantity<double, YoctoCandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert DekaCandela to YottaCandela
    /// </summary>
    /// <param name="val">quantity measured in DekaCandela</param>
    /// <returns>quantity measured in YottaCandela</returns>
	public static Quantity<double, YottaCandela> ToYottaCandela<T>(this BaseQuantity<T, DekaCandela> val) where T:IConvertible {
        return new Quantity<double, YottaCandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaCandela to ZettaCandela
    /// </summary>
    /// <param name="val">quantity measured in DekaCandela</param>
    /// <returns>quantity measured in ZettaCandela</returns>
	public static Quantity<double, ZettaCandela> ToZettaCandela<T>(this BaseQuantity<T, DekaCandela> val) where T:IConvertible {
        return new Quantity<double, ZettaCandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaCandela to ExaCandela
    /// </summary>
    /// <param name="val">quantity measured in DekaCandela</param>
    /// <returns>quantity measured in ExaCandela</returns>
	public static Quantity<double, ExaCandela> ToExaCandela<T>(this BaseQuantity<T, DekaCandela> val) where T:IConvertible {
        return new Quantity<double, ExaCandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaCandela to PetaCandela
    /// </summary>
    /// <param name="val">quantity measured in DekaCandela</param>
    /// <returns>quantity measured in PetaCandela</returns>
	public static Quantity<double, PetaCandela> ToPetaCandela<T>(this BaseQuantity<T, DekaCandela> val) where T:IConvertible {
        return new Quantity<double, PetaCandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaCandela to TeraCandela
    /// </summary>
    /// <param name="val">quantity measured in DekaCandela</param>
    /// <returns>quantity measured in TeraCandela</returns>
	public static Quantity<double, TeraCandela> ToTeraCandela<T>(this BaseQuantity<T, DekaCandela> val) where T:IConvertible {
        return new Quantity<double, TeraCandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaCandela to GigaCandela
    /// </summary>
    /// <param name="val">quantity measured in DekaCandela</param>
    /// <returns>quantity measured in GigaCandela</returns>
	public static Quantity<double, GigaCandela> ToGigaCandela<T>(this BaseQuantity<T, DekaCandela> val) where T:IConvertible {
        return new Quantity<double, GigaCandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaCandela to MegaCandela
    /// </summary>
    /// <param name="val">quantity measured in DekaCandela</param>
    /// <returns>quantity measured in MegaCandela</returns>
	public static Quantity<double, MegaCandela> ToMegaCandela<T>(this BaseQuantity<T, DekaCandela> val) where T:IConvertible {
        return new Quantity<double, MegaCandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaCandela to KiloCandela
    /// </summary>
    /// <param name="val">quantity measured in DekaCandela</param>
    /// <returns>quantity measured in KiloCandela</returns>
	public static Quantity<double, KiloCandela> ToKiloCandela<T>(this BaseQuantity<T, DekaCandela> val) where T:IConvertible {
        return new Quantity<double, KiloCandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaCandela to HectoCandela
    /// </summary>
    /// <param name="val">quantity measured in DekaCandela</param>
    /// <returns>quantity measured in HectoCandela</returns>
	public static Quantity<double, HectoCandela> ToHectoCandela<T>(this BaseQuantity<T, DekaCandela> val) where T:IConvertible {
        return new Quantity<double, HectoCandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaCandela to DeciCandela
    /// </summary>
    /// <param name="val">quantity measured in DekaCandela</param>
    /// <returns>quantity measured in DeciCandela</returns>
	public static Quantity<double, DeciCandela> ToDeciCandela<T>(this BaseQuantity<T, DekaCandela> val) where T:IConvertible {
        return new Quantity<double, DeciCandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaCandela to CentiCandela
    /// </summary>
    /// <param name="val">quantity measured in DekaCandela</param>
    /// <returns>quantity measured in CentiCandela</returns>
	public static Quantity<double, CentiCandela> ToCentiCandela<T>(this BaseQuantity<T, DekaCandela> val) where T:IConvertible {
        return new Quantity<double, CentiCandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaCandela to MilliCandela
    /// </summary>
    /// <param name="val">quantity measured in DekaCandela</param>
    /// <returns>quantity measured in MilliCandela</returns>
	public static Quantity<double, MilliCandela> ToMilliCandela<T>(this BaseQuantity<T, DekaCandela> val) where T:IConvertible {
        return new Quantity<double, MilliCandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaCandela to MicroCandela
    /// </summary>
    /// <param name="val">quantity measured in DekaCandela</param>
    /// <returns>quantity measured in MicroCandela</returns>
	public static Quantity<double, MicroCandela> ToMicroCandela<T>(this BaseQuantity<T, DekaCandela> val) where T:IConvertible {
        return new Quantity<double, MicroCandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaCandela to NanoCandela
    /// </summary>
    /// <param name="val">quantity measured in DekaCandela</param>
    /// <returns>quantity measured in NanoCandela</returns>
	public static Quantity<double, NanoCandela> ToNanoCandela<T>(this BaseQuantity<T, DekaCandela> val) where T:IConvertible {
        return new Quantity<double, NanoCandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaCandela to PicoCandela
    /// </summary>
    /// <param name="val">quantity measured in DekaCandela</param>
    /// <returns>quantity measured in PicoCandela</returns>
	public static Quantity<double, PicoCandela> ToPicoCandela<T>(this BaseQuantity<T, DekaCandela> val) where T:IConvertible {
        return new Quantity<double, PicoCandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaCandela to FemtoCandela
    /// </summary>
    /// <param name="val">quantity measured in DekaCandela</param>
    /// <returns>quantity measured in FemtoCandela</returns>
	public static Quantity<double, FemtoCandela> ToFemtoCandela<T>(this BaseQuantity<T, DekaCandela> val) where T:IConvertible {
        return new Quantity<double, FemtoCandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaCandela to AttoCandela
    /// </summary>
    /// <param name="val">quantity measured in DekaCandela</param>
    /// <returns>quantity measured in AttoCandela</returns>
	public static Quantity<double, AttoCandela> ToAttoCandela<T>(this BaseQuantity<T, DekaCandela> val) where T:IConvertible {
        return new Quantity<double, AttoCandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaCandela to ZeptoCandela
    /// </summary>
    /// <param name="val">quantity measured in DekaCandela</param>
    /// <returns>quantity measured in ZeptoCandela</returns>
	public static Quantity<double, ZeptoCandela> ToZeptoCandela<T>(this BaseQuantity<T, DekaCandela> val) where T:IConvertible {
        return new Quantity<double, ZeptoCandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaCandela to YoctoCandela
    /// </summary>
    /// <param name="val">quantity measured in DekaCandela</param>
    /// <returns>quantity measured in YoctoCandela</returns>
	public static Quantity<double, YoctoCandela> ToYoctoCandela<T>(this BaseQuantity<T, DekaCandela> val) where T:IConvertible {
        return new Quantity<double, YoctoCandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DeciCandela to YottaCandela
    /// </summary>
    /// <param name="val">quantity measured in DeciCandela</param>
    /// <returns>quantity measured in YottaCandela</returns>
	public static Quantity<double, YottaCandela> ToYottaCandela<T>(this BaseQuantity<T, DeciCandela> val) where T:IConvertible {
        return new Quantity<double, YottaCandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciCandela to ZettaCandela
    /// </summary>
    /// <param name="val">quantity measured in DeciCandela</param>
    /// <returns>quantity measured in ZettaCandela</returns>
	public static Quantity<double, ZettaCandela> ToZettaCandela<T>(this BaseQuantity<T, DeciCandela> val) where T:IConvertible {
        return new Quantity<double, ZettaCandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciCandela to ExaCandela
    /// </summary>
    /// <param name="val">quantity measured in DeciCandela</param>
    /// <returns>quantity measured in ExaCandela</returns>
	public static Quantity<double, ExaCandela> ToExaCandela<T>(this BaseQuantity<T, DeciCandela> val) where T:IConvertible {
        return new Quantity<double, ExaCandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciCandela to PetaCandela
    /// </summary>
    /// <param name="val">quantity measured in DeciCandela</param>
    /// <returns>quantity measured in PetaCandela</returns>
	public static Quantity<double, PetaCandela> ToPetaCandela<T>(this BaseQuantity<T, DeciCandela> val) where T:IConvertible {
        return new Quantity<double, PetaCandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciCandela to TeraCandela
    /// </summary>
    /// <param name="val">quantity measured in DeciCandela</param>
    /// <returns>quantity measured in TeraCandela</returns>
	public static Quantity<double, TeraCandela> ToTeraCandela<T>(this BaseQuantity<T, DeciCandela> val) where T:IConvertible {
        return new Quantity<double, TeraCandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciCandela to GigaCandela
    /// </summary>
    /// <param name="val">quantity measured in DeciCandela</param>
    /// <returns>quantity measured in GigaCandela</returns>
	public static Quantity<double, GigaCandela> ToGigaCandela<T>(this BaseQuantity<T, DeciCandela> val) where T:IConvertible {
        return new Quantity<double, GigaCandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciCandela to MegaCandela
    /// </summary>
    /// <param name="val">quantity measured in DeciCandela</param>
    /// <returns>quantity measured in MegaCandela</returns>
	public static Quantity<double, MegaCandela> ToMegaCandela<T>(this BaseQuantity<T, DeciCandela> val) where T:IConvertible {
        return new Quantity<double, MegaCandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciCandela to KiloCandela
    /// </summary>
    /// <param name="val">quantity measured in DeciCandela</param>
    /// <returns>quantity measured in KiloCandela</returns>
	public static Quantity<double, KiloCandela> ToKiloCandela<T>(this BaseQuantity<T, DeciCandela> val) where T:IConvertible {
        return new Quantity<double, KiloCandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciCandela to HectoCandela
    /// </summary>
    /// <param name="val">quantity measured in DeciCandela</param>
    /// <returns>quantity measured in HectoCandela</returns>
	public static Quantity<double, HectoCandela> ToHectoCandela<T>(this BaseQuantity<T, DeciCandela> val) where T:IConvertible {
        return new Quantity<double, HectoCandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciCandela to DekaCandela
    /// </summary>
    /// <param name="val">quantity measured in DeciCandela</param>
    /// <returns>quantity measured in DekaCandela</returns>
	public static Quantity<double, DekaCandela> ToDekaCandela<T>(this BaseQuantity<T, DeciCandela> val) where T:IConvertible {
        return new Quantity<double, DekaCandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciCandela to CentiCandela
    /// </summary>
    /// <param name="val">quantity measured in DeciCandela</param>
    /// <returns>quantity measured in CentiCandela</returns>
	public static Quantity<double, CentiCandela> ToCentiCandela<T>(this BaseQuantity<T, DeciCandela> val) where T:IConvertible {
        return new Quantity<double, CentiCandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciCandela to MilliCandela
    /// </summary>
    /// <param name="val">quantity measured in DeciCandela</param>
    /// <returns>quantity measured in MilliCandela</returns>
	public static Quantity<double, MilliCandela> ToMilliCandela<T>(this BaseQuantity<T, DeciCandela> val) where T:IConvertible {
        return new Quantity<double, MilliCandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciCandela to MicroCandela
    /// </summary>
    /// <param name="val">quantity measured in DeciCandela</param>
    /// <returns>quantity measured in MicroCandela</returns>
	public static Quantity<double, MicroCandela> ToMicroCandela<T>(this BaseQuantity<T, DeciCandela> val) where T:IConvertible {
        return new Quantity<double, MicroCandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciCandela to NanoCandela
    /// </summary>
    /// <param name="val">quantity measured in DeciCandela</param>
    /// <returns>quantity measured in NanoCandela</returns>
	public static Quantity<double, NanoCandela> ToNanoCandela<T>(this BaseQuantity<T, DeciCandela> val) where T:IConvertible {
        return new Quantity<double, NanoCandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciCandela to PicoCandela
    /// </summary>
    /// <param name="val">quantity measured in DeciCandela</param>
    /// <returns>quantity measured in PicoCandela</returns>
	public static Quantity<double, PicoCandela> ToPicoCandela<T>(this BaseQuantity<T, DeciCandela> val) where T:IConvertible {
        return new Quantity<double, PicoCandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciCandela to FemtoCandela
    /// </summary>
    /// <param name="val">quantity measured in DeciCandela</param>
    /// <returns>quantity measured in FemtoCandela</returns>
	public static Quantity<double, FemtoCandela> ToFemtoCandela<T>(this BaseQuantity<T, DeciCandela> val) where T:IConvertible {
        return new Quantity<double, FemtoCandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciCandela to AttoCandela
    /// </summary>
    /// <param name="val">quantity measured in DeciCandela</param>
    /// <returns>quantity measured in AttoCandela</returns>
	public static Quantity<double, AttoCandela> ToAttoCandela<T>(this BaseQuantity<T, DeciCandela> val) where T:IConvertible {
        return new Quantity<double, AttoCandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciCandela to ZeptoCandela
    /// </summary>
    /// <param name="val">quantity measured in DeciCandela</param>
    /// <returns>quantity measured in ZeptoCandela</returns>
	public static Quantity<double, ZeptoCandela> ToZeptoCandela<T>(this BaseQuantity<T, DeciCandela> val) where T:IConvertible {
        return new Quantity<double, ZeptoCandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciCandela to YoctoCandela
    /// </summary>
    /// <param name="val">quantity measured in DeciCandela</param>
    /// <returns>quantity measured in YoctoCandela</returns>
	public static Quantity<double, YoctoCandela> ToYoctoCandela<T>(this BaseQuantity<T, DeciCandela> val) where T:IConvertible {
        return new Quantity<double, YoctoCandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert CentiCandela to YottaCandela
    /// </summary>
    /// <param name="val">quantity measured in CentiCandela</param>
    /// <returns>quantity measured in YottaCandela</returns>
	public static Quantity<double, YottaCandela> ToYottaCandela<T>(this BaseQuantity<T, CentiCandela> val) where T:IConvertible {
        return new Quantity<double, YottaCandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiCandela to ZettaCandela
    /// </summary>
    /// <param name="val">quantity measured in CentiCandela</param>
    /// <returns>quantity measured in ZettaCandela</returns>
	public static Quantity<double, ZettaCandela> ToZettaCandela<T>(this BaseQuantity<T, CentiCandela> val) where T:IConvertible {
        return new Quantity<double, ZettaCandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiCandela to ExaCandela
    /// </summary>
    /// <param name="val">quantity measured in CentiCandela</param>
    /// <returns>quantity measured in ExaCandela</returns>
	public static Quantity<double, ExaCandela> ToExaCandela<T>(this BaseQuantity<T, CentiCandela> val) where T:IConvertible {
        return new Quantity<double, ExaCandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiCandela to PetaCandela
    /// </summary>
    /// <param name="val">quantity measured in CentiCandela</param>
    /// <returns>quantity measured in PetaCandela</returns>
	public static Quantity<double, PetaCandela> ToPetaCandela<T>(this BaseQuantity<T, CentiCandela> val) where T:IConvertible {
        return new Quantity<double, PetaCandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiCandela to TeraCandela
    /// </summary>
    /// <param name="val">quantity measured in CentiCandela</param>
    /// <returns>quantity measured in TeraCandela</returns>
	public static Quantity<double, TeraCandela> ToTeraCandela<T>(this BaseQuantity<T, CentiCandela> val) where T:IConvertible {
        return new Quantity<double, TeraCandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiCandela to GigaCandela
    /// </summary>
    /// <param name="val">quantity measured in CentiCandela</param>
    /// <returns>quantity measured in GigaCandela</returns>
	public static Quantity<double, GigaCandela> ToGigaCandela<T>(this BaseQuantity<T, CentiCandela> val) where T:IConvertible {
        return new Quantity<double, GigaCandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiCandela to MegaCandela
    /// </summary>
    /// <param name="val">quantity measured in CentiCandela</param>
    /// <returns>quantity measured in MegaCandela</returns>
	public static Quantity<double, MegaCandela> ToMegaCandela<T>(this BaseQuantity<T, CentiCandela> val) where T:IConvertible {
        return new Quantity<double, MegaCandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiCandela to KiloCandela
    /// </summary>
    /// <param name="val">quantity measured in CentiCandela</param>
    /// <returns>quantity measured in KiloCandela</returns>
	public static Quantity<double, KiloCandela> ToKiloCandela<T>(this BaseQuantity<T, CentiCandela> val) where T:IConvertible {
        return new Quantity<double, KiloCandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiCandela to HectoCandela
    /// </summary>
    /// <param name="val">quantity measured in CentiCandela</param>
    /// <returns>quantity measured in HectoCandela</returns>
	public static Quantity<double, HectoCandela> ToHectoCandela<T>(this BaseQuantity<T, CentiCandela> val) where T:IConvertible {
        return new Quantity<double, HectoCandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiCandela to DekaCandela
    /// </summary>
    /// <param name="val">quantity measured in CentiCandela</param>
    /// <returns>quantity measured in DekaCandela</returns>
	public static Quantity<double, DekaCandela> ToDekaCandela<T>(this BaseQuantity<T, CentiCandela> val) where T:IConvertible {
        return new Quantity<double, DekaCandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiCandela to DeciCandela
    /// </summary>
    /// <param name="val">quantity measured in CentiCandela</param>
    /// <returns>quantity measured in DeciCandela</returns>
	public static Quantity<double, DeciCandela> ToDeciCandela<T>(this BaseQuantity<T, CentiCandela> val) where T:IConvertible {
        return new Quantity<double, DeciCandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiCandela to MilliCandela
    /// </summary>
    /// <param name="val">quantity measured in CentiCandela</param>
    /// <returns>quantity measured in MilliCandela</returns>
	public static Quantity<double, MilliCandela> ToMilliCandela<T>(this BaseQuantity<T, CentiCandela> val) where T:IConvertible {
        return new Quantity<double, MilliCandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiCandela to MicroCandela
    /// </summary>
    /// <param name="val">quantity measured in CentiCandela</param>
    /// <returns>quantity measured in MicroCandela</returns>
	public static Quantity<double, MicroCandela> ToMicroCandela<T>(this BaseQuantity<T, CentiCandela> val) where T:IConvertible {
        return new Quantity<double, MicroCandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiCandela to NanoCandela
    /// </summary>
    /// <param name="val">quantity measured in CentiCandela</param>
    /// <returns>quantity measured in NanoCandela</returns>
	public static Quantity<double, NanoCandela> ToNanoCandela<T>(this BaseQuantity<T, CentiCandela> val) where T:IConvertible {
        return new Quantity<double, NanoCandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiCandela to PicoCandela
    /// </summary>
    /// <param name="val">quantity measured in CentiCandela</param>
    /// <returns>quantity measured in PicoCandela</returns>
	public static Quantity<double, PicoCandela> ToPicoCandela<T>(this BaseQuantity<T, CentiCandela> val) where T:IConvertible {
        return new Quantity<double, PicoCandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiCandela to FemtoCandela
    /// </summary>
    /// <param name="val">quantity measured in CentiCandela</param>
    /// <returns>quantity measured in FemtoCandela</returns>
	public static Quantity<double, FemtoCandela> ToFemtoCandela<T>(this BaseQuantity<T, CentiCandela> val) where T:IConvertible {
        return new Quantity<double, FemtoCandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiCandela to AttoCandela
    /// </summary>
    /// <param name="val">quantity measured in CentiCandela</param>
    /// <returns>quantity measured in AttoCandela</returns>
	public static Quantity<double, AttoCandela> ToAttoCandela<T>(this BaseQuantity<T, CentiCandela> val) where T:IConvertible {
        return new Quantity<double, AttoCandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiCandela to ZeptoCandela
    /// </summary>
    /// <param name="val">quantity measured in CentiCandela</param>
    /// <returns>quantity measured in ZeptoCandela</returns>
	public static Quantity<double, ZeptoCandela> ToZeptoCandela<T>(this BaseQuantity<T, CentiCandela> val) where T:IConvertible {
        return new Quantity<double, ZeptoCandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiCandela to YoctoCandela
    /// </summary>
    /// <param name="val">quantity measured in CentiCandela</param>
    /// <returns>quantity measured in YoctoCandela</returns>
	public static Quantity<double, YoctoCandela> ToYoctoCandela<T>(this BaseQuantity<T, CentiCandela> val) where T:IConvertible {
        return new Quantity<double, YoctoCandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert MilliCandela to YottaCandela
    /// </summary>
    /// <param name="val">quantity measured in MilliCandela</param>
    /// <returns>quantity measured in YottaCandela</returns>
	public static Quantity<double, YottaCandela> ToYottaCandela<T>(this BaseQuantity<T, MilliCandela> val) where T:IConvertible {
        return new Quantity<double, YottaCandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliCandela to ZettaCandela
    /// </summary>
    /// <param name="val">quantity measured in MilliCandela</param>
    /// <returns>quantity measured in ZettaCandela</returns>
	public static Quantity<double, ZettaCandela> ToZettaCandela<T>(this BaseQuantity<T, MilliCandela> val) where T:IConvertible {
        return new Quantity<double, ZettaCandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliCandela to ExaCandela
    /// </summary>
    /// <param name="val">quantity measured in MilliCandela</param>
    /// <returns>quantity measured in ExaCandela</returns>
	public static Quantity<double, ExaCandela> ToExaCandela<T>(this BaseQuantity<T, MilliCandela> val) where T:IConvertible {
        return new Quantity<double, ExaCandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliCandela to PetaCandela
    /// </summary>
    /// <param name="val">quantity measured in MilliCandela</param>
    /// <returns>quantity measured in PetaCandela</returns>
	public static Quantity<double, PetaCandela> ToPetaCandela<T>(this BaseQuantity<T, MilliCandela> val) where T:IConvertible {
        return new Quantity<double, PetaCandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliCandela to TeraCandela
    /// </summary>
    /// <param name="val">quantity measured in MilliCandela</param>
    /// <returns>quantity measured in TeraCandela</returns>
	public static Quantity<double, TeraCandela> ToTeraCandela<T>(this BaseQuantity<T, MilliCandela> val) where T:IConvertible {
        return new Quantity<double, TeraCandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliCandela to GigaCandela
    /// </summary>
    /// <param name="val">quantity measured in MilliCandela</param>
    /// <returns>quantity measured in GigaCandela</returns>
	public static Quantity<double, GigaCandela> ToGigaCandela<T>(this BaseQuantity<T, MilliCandela> val) where T:IConvertible {
        return new Quantity<double, GigaCandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliCandela to MegaCandela
    /// </summary>
    /// <param name="val">quantity measured in MilliCandela</param>
    /// <returns>quantity measured in MegaCandela</returns>
	public static Quantity<double, MegaCandela> ToMegaCandela<T>(this BaseQuantity<T, MilliCandela> val) where T:IConvertible {
        return new Quantity<double, MegaCandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliCandela to KiloCandela
    /// </summary>
    /// <param name="val">quantity measured in MilliCandela</param>
    /// <returns>quantity measured in KiloCandela</returns>
	public static Quantity<double, KiloCandela> ToKiloCandela<T>(this BaseQuantity<T, MilliCandela> val) where T:IConvertible {
        return new Quantity<double, KiloCandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliCandela to HectoCandela
    /// </summary>
    /// <param name="val">quantity measured in MilliCandela</param>
    /// <returns>quantity measured in HectoCandela</returns>
	public static Quantity<double, HectoCandela> ToHectoCandela<T>(this BaseQuantity<T, MilliCandela> val) where T:IConvertible {
        return new Quantity<double, HectoCandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliCandela to DekaCandela
    /// </summary>
    /// <param name="val">quantity measured in MilliCandela</param>
    /// <returns>quantity measured in DekaCandela</returns>
	public static Quantity<double, DekaCandela> ToDekaCandela<T>(this BaseQuantity<T, MilliCandela> val) where T:IConvertible {
        return new Quantity<double, DekaCandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliCandela to DeciCandela
    /// </summary>
    /// <param name="val">quantity measured in MilliCandela</param>
    /// <returns>quantity measured in DeciCandela</returns>
	public static Quantity<double, DeciCandela> ToDeciCandela<T>(this BaseQuantity<T, MilliCandela> val) where T:IConvertible {
        return new Quantity<double, DeciCandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliCandela to CentiCandela
    /// </summary>
    /// <param name="val">quantity measured in MilliCandela</param>
    /// <returns>quantity measured in CentiCandela</returns>
	public static Quantity<double, CentiCandela> ToCentiCandela<T>(this BaseQuantity<T, MilliCandela> val) where T:IConvertible {
        return new Quantity<double, CentiCandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliCandela to MicroCandela
    /// </summary>
    /// <param name="val">quantity measured in MilliCandela</param>
    /// <returns>quantity measured in MicroCandela</returns>
	public static Quantity<double, MicroCandela> ToMicroCandela<T>(this BaseQuantity<T, MilliCandela> val) where T:IConvertible {
        return new Quantity<double, MicroCandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliCandela to NanoCandela
    /// </summary>
    /// <param name="val">quantity measured in MilliCandela</param>
    /// <returns>quantity measured in NanoCandela</returns>
	public static Quantity<double, NanoCandela> ToNanoCandela<T>(this BaseQuantity<T, MilliCandela> val) where T:IConvertible {
        return new Quantity<double, NanoCandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliCandela to PicoCandela
    /// </summary>
    /// <param name="val">quantity measured in MilliCandela</param>
    /// <returns>quantity measured in PicoCandela</returns>
	public static Quantity<double, PicoCandela> ToPicoCandela<T>(this BaseQuantity<T, MilliCandela> val) where T:IConvertible {
        return new Quantity<double, PicoCandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliCandela to FemtoCandela
    /// </summary>
    /// <param name="val">quantity measured in MilliCandela</param>
    /// <returns>quantity measured in FemtoCandela</returns>
	public static Quantity<double, FemtoCandela> ToFemtoCandela<T>(this BaseQuantity<T, MilliCandela> val) where T:IConvertible {
        return new Quantity<double, FemtoCandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliCandela to AttoCandela
    /// </summary>
    /// <param name="val">quantity measured in MilliCandela</param>
    /// <returns>quantity measured in AttoCandela</returns>
	public static Quantity<double, AttoCandela> ToAttoCandela<T>(this BaseQuantity<T, MilliCandela> val) where T:IConvertible {
        return new Quantity<double, AttoCandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliCandela to ZeptoCandela
    /// </summary>
    /// <param name="val">quantity measured in MilliCandela</param>
    /// <returns>quantity measured in ZeptoCandela</returns>
	public static Quantity<double, ZeptoCandela> ToZeptoCandela<T>(this BaseQuantity<T, MilliCandela> val) where T:IConvertible {
        return new Quantity<double, ZeptoCandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliCandela to YoctoCandela
    /// </summary>
    /// <param name="val">quantity measured in MilliCandela</param>
    /// <returns>quantity measured in YoctoCandela</returns>
	public static Quantity<double, YoctoCandela> ToYoctoCandela<T>(this BaseQuantity<T, MilliCandela> val) where T:IConvertible {
        return new Quantity<double, YoctoCandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MicroCandela to YottaCandela
    /// </summary>
    /// <param name="val">quantity measured in MicroCandela</param>
    /// <returns>quantity measured in YottaCandela</returns>
	public static Quantity<double, YottaCandela> ToYottaCandela<T>(this BaseQuantity<T, MicroCandela> val) where T:IConvertible {
        return new Quantity<double, YottaCandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroCandela to ZettaCandela
    /// </summary>
    /// <param name="val">quantity measured in MicroCandela</param>
    /// <returns>quantity measured in ZettaCandela</returns>
	public static Quantity<double, ZettaCandela> ToZettaCandela<T>(this BaseQuantity<T, MicroCandela> val) where T:IConvertible {
        return new Quantity<double, ZettaCandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroCandela to ExaCandela
    /// </summary>
    /// <param name="val">quantity measured in MicroCandela</param>
    /// <returns>quantity measured in ExaCandela</returns>
	public static Quantity<double, ExaCandela> ToExaCandela<T>(this BaseQuantity<T, MicroCandela> val) where T:IConvertible {
        return new Quantity<double, ExaCandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroCandela to PetaCandela
    /// </summary>
    /// <param name="val">quantity measured in MicroCandela</param>
    /// <returns>quantity measured in PetaCandela</returns>
	public static Quantity<double, PetaCandela> ToPetaCandela<T>(this BaseQuantity<T, MicroCandela> val) where T:IConvertible {
        return new Quantity<double, PetaCandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroCandela to TeraCandela
    /// </summary>
    /// <param name="val">quantity measured in MicroCandela</param>
    /// <returns>quantity measured in TeraCandela</returns>
	public static Quantity<double, TeraCandela> ToTeraCandela<T>(this BaseQuantity<T, MicroCandela> val) where T:IConvertible {
        return new Quantity<double, TeraCandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroCandela to GigaCandela
    /// </summary>
    /// <param name="val">quantity measured in MicroCandela</param>
    /// <returns>quantity measured in GigaCandela</returns>
	public static Quantity<double, GigaCandela> ToGigaCandela<T>(this BaseQuantity<T, MicroCandela> val) where T:IConvertible {
        return new Quantity<double, GigaCandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroCandela to MegaCandela
    /// </summary>
    /// <param name="val">quantity measured in MicroCandela</param>
    /// <returns>quantity measured in MegaCandela</returns>
	public static Quantity<double, MegaCandela> ToMegaCandela<T>(this BaseQuantity<T, MicroCandela> val) where T:IConvertible {
        return new Quantity<double, MegaCandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroCandela to KiloCandela
    /// </summary>
    /// <param name="val">quantity measured in MicroCandela</param>
    /// <returns>quantity measured in KiloCandela</returns>
	public static Quantity<double, KiloCandela> ToKiloCandela<T>(this BaseQuantity<T, MicroCandela> val) where T:IConvertible {
        return new Quantity<double, KiloCandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroCandela to HectoCandela
    /// </summary>
    /// <param name="val">quantity measured in MicroCandela</param>
    /// <returns>quantity measured in HectoCandela</returns>
	public static Quantity<double, HectoCandela> ToHectoCandela<T>(this BaseQuantity<T, MicroCandela> val) where T:IConvertible {
        return new Quantity<double, HectoCandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroCandela to DekaCandela
    /// </summary>
    /// <param name="val">quantity measured in MicroCandela</param>
    /// <returns>quantity measured in DekaCandela</returns>
	public static Quantity<double, DekaCandela> ToDekaCandela<T>(this BaseQuantity<T, MicroCandela> val) where T:IConvertible {
        return new Quantity<double, DekaCandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroCandela to DeciCandela
    /// </summary>
    /// <param name="val">quantity measured in MicroCandela</param>
    /// <returns>quantity measured in DeciCandela</returns>
	public static Quantity<double, DeciCandela> ToDeciCandela<T>(this BaseQuantity<T, MicroCandela> val) where T:IConvertible {
        return new Quantity<double, DeciCandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroCandela to CentiCandela
    /// </summary>
    /// <param name="val">quantity measured in MicroCandela</param>
    /// <returns>quantity measured in CentiCandela</returns>
	public static Quantity<double, CentiCandela> ToCentiCandela<T>(this BaseQuantity<T, MicroCandela> val) where T:IConvertible {
        return new Quantity<double, CentiCandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroCandela to MilliCandela
    /// </summary>
    /// <param name="val">quantity measured in MicroCandela</param>
    /// <returns>quantity measured in MilliCandela</returns>
	public static Quantity<double, MilliCandela> ToMilliCandela<T>(this BaseQuantity<T, MicroCandela> val) where T:IConvertible {
        return new Quantity<double, MilliCandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroCandela to NanoCandela
    /// </summary>
    /// <param name="val">quantity measured in MicroCandela</param>
    /// <returns>quantity measured in NanoCandela</returns>
	public static Quantity<double, NanoCandela> ToNanoCandela<T>(this BaseQuantity<T, MicroCandela> val) where T:IConvertible {
        return new Quantity<double, NanoCandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroCandela to PicoCandela
    /// </summary>
    /// <param name="val">quantity measured in MicroCandela</param>
    /// <returns>quantity measured in PicoCandela</returns>
	public static Quantity<double, PicoCandela> ToPicoCandela<T>(this BaseQuantity<T, MicroCandela> val) where T:IConvertible {
        return new Quantity<double, PicoCandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroCandela to FemtoCandela
    /// </summary>
    /// <param name="val">quantity measured in MicroCandela</param>
    /// <returns>quantity measured in FemtoCandela</returns>
	public static Quantity<double, FemtoCandela> ToFemtoCandela<T>(this BaseQuantity<T, MicroCandela> val) where T:IConvertible {
        return new Quantity<double, FemtoCandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroCandela to AttoCandela
    /// </summary>
    /// <param name="val">quantity measured in MicroCandela</param>
    /// <returns>quantity measured in AttoCandela</returns>
	public static Quantity<double, AttoCandela> ToAttoCandela<T>(this BaseQuantity<T, MicroCandela> val) where T:IConvertible {
        return new Quantity<double, AttoCandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroCandela to ZeptoCandela
    /// </summary>
    /// <param name="val">quantity measured in MicroCandela</param>
    /// <returns>quantity measured in ZeptoCandela</returns>
	public static Quantity<double, ZeptoCandela> ToZeptoCandela<T>(this BaseQuantity<T, MicroCandela> val) where T:IConvertible {
        return new Quantity<double, ZeptoCandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroCandela to YoctoCandela
    /// </summary>
    /// <param name="val">quantity measured in MicroCandela</param>
    /// <returns>quantity measured in YoctoCandela</returns>
	public static Quantity<double, YoctoCandela> ToYoctoCandela<T>(this BaseQuantity<T, MicroCandela> val) where T:IConvertible {
        return new Quantity<double, YoctoCandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert NanoCandela to YottaCandela
    /// </summary>
    /// <param name="val">quantity measured in NanoCandela</param>
    /// <returns>quantity measured in YottaCandela</returns>
	public static Quantity<double, YottaCandela> ToYottaCandela<T>(this BaseQuantity<T, NanoCandela> val) where T:IConvertible {
        return new Quantity<double, YottaCandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoCandela to ZettaCandela
    /// </summary>
    /// <param name="val">quantity measured in NanoCandela</param>
    /// <returns>quantity measured in ZettaCandela</returns>
	public static Quantity<double, ZettaCandela> ToZettaCandela<T>(this BaseQuantity<T, NanoCandela> val) where T:IConvertible {
        return new Quantity<double, ZettaCandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoCandela to ExaCandela
    /// </summary>
    /// <param name="val">quantity measured in NanoCandela</param>
    /// <returns>quantity measured in ExaCandela</returns>
	public static Quantity<double, ExaCandela> ToExaCandela<T>(this BaseQuantity<T, NanoCandela> val) where T:IConvertible {
        return new Quantity<double, ExaCandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoCandela to PetaCandela
    /// </summary>
    /// <param name="val">quantity measured in NanoCandela</param>
    /// <returns>quantity measured in PetaCandela</returns>
	public static Quantity<double, PetaCandela> ToPetaCandela<T>(this BaseQuantity<T, NanoCandela> val) where T:IConvertible {
        return new Quantity<double, PetaCandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoCandela to TeraCandela
    /// </summary>
    /// <param name="val">quantity measured in NanoCandela</param>
    /// <returns>quantity measured in TeraCandela</returns>
	public static Quantity<double, TeraCandela> ToTeraCandela<T>(this BaseQuantity<T, NanoCandela> val) where T:IConvertible {
        return new Quantity<double, TeraCandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoCandela to GigaCandela
    /// </summary>
    /// <param name="val">quantity measured in NanoCandela</param>
    /// <returns>quantity measured in GigaCandela</returns>
	public static Quantity<double, GigaCandela> ToGigaCandela<T>(this BaseQuantity<T, NanoCandela> val) where T:IConvertible {
        return new Quantity<double, GigaCandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoCandela to MegaCandela
    /// </summary>
    /// <param name="val">quantity measured in NanoCandela</param>
    /// <returns>quantity measured in MegaCandela</returns>
	public static Quantity<double, MegaCandela> ToMegaCandela<T>(this BaseQuantity<T, NanoCandela> val) where T:IConvertible {
        return new Quantity<double, MegaCandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoCandela to KiloCandela
    /// </summary>
    /// <param name="val">quantity measured in NanoCandela</param>
    /// <returns>quantity measured in KiloCandela</returns>
	public static Quantity<double, KiloCandela> ToKiloCandela<T>(this BaseQuantity<T, NanoCandela> val) where T:IConvertible {
        return new Quantity<double, KiloCandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoCandela to HectoCandela
    /// </summary>
    /// <param name="val">quantity measured in NanoCandela</param>
    /// <returns>quantity measured in HectoCandela</returns>
	public static Quantity<double, HectoCandela> ToHectoCandela<T>(this BaseQuantity<T, NanoCandela> val) where T:IConvertible {
        return new Quantity<double, HectoCandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoCandela to DekaCandela
    /// </summary>
    /// <param name="val">quantity measured in NanoCandela</param>
    /// <returns>quantity measured in DekaCandela</returns>
	public static Quantity<double, DekaCandela> ToDekaCandela<T>(this BaseQuantity<T, NanoCandela> val) where T:IConvertible {
        return new Quantity<double, DekaCandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoCandela to DeciCandela
    /// </summary>
    /// <param name="val">quantity measured in NanoCandela</param>
    /// <returns>quantity measured in DeciCandela</returns>
	public static Quantity<double, DeciCandela> ToDeciCandela<T>(this BaseQuantity<T, NanoCandela> val) where T:IConvertible {
        return new Quantity<double, DeciCandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoCandela to CentiCandela
    /// </summary>
    /// <param name="val">quantity measured in NanoCandela</param>
    /// <returns>quantity measured in CentiCandela</returns>
	public static Quantity<double, CentiCandela> ToCentiCandela<T>(this BaseQuantity<T, NanoCandela> val) where T:IConvertible {
        return new Quantity<double, CentiCandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoCandela to MilliCandela
    /// </summary>
    /// <param name="val">quantity measured in NanoCandela</param>
    /// <returns>quantity measured in MilliCandela</returns>
	public static Quantity<double, MilliCandela> ToMilliCandela<T>(this BaseQuantity<T, NanoCandela> val) where T:IConvertible {
        return new Quantity<double, MilliCandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoCandela to MicroCandela
    /// </summary>
    /// <param name="val">quantity measured in NanoCandela</param>
    /// <returns>quantity measured in MicroCandela</returns>
	public static Quantity<double, MicroCandela> ToMicroCandela<T>(this BaseQuantity<T, NanoCandela> val) where T:IConvertible {
        return new Quantity<double, MicroCandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoCandela to PicoCandela
    /// </summary>
    /// <param name="val">quantity measured in NanoCandela</param>
    /// <returns>quantity measured in PicoCandela</returns>
	public static Quantity<double, PicoCandela> ToPicoCandela<T>(this BaseQuantity<T, NanoCandela> val) where T:IConvertible {
        return new Quantity<double, PicoCandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoCandela to FemtoCandela
    /// </summary>
    /// <param name="val">quantity measured in NanoCandela</param>
    /// <returns>quantity measured in FemtoCandela</returns>
	public static Quantity<double, FemtoCandela> ToFemtoCandela<T>(this BaseQuantity<T, NanoCandela> val) where T:IConvertible {
        return new Quantity<double, FemtoCandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoCandela to AttoCandela
    /// </summary>
    /// <param name="val">quantity measured in NanoCandela</param>
    /// <returns>quantity measured in AttoCandela</returns>
	public static Quantity<double, AttoCandela> ToAttoCandela<T>(this BaseQuantity<T, NanoCandela> val) where T:IConvertible {
        return new Quantity<double, AttoCandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoCandela to ZeptoCandela
    /// </summary>
    /// <param name="val">quantity measured in NanoCandela</param>
    /// <returns>quantity measured in ZeptoCandela</returns>
	public static Quantity<double, ZeptoCandela> ToZeptoCandela<T>(this BaseQuantity<T, NanoCandela> val) where T:IConvertible {
        return new Quantity<double, ZeptoCandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoCandela to YoctoCandela
    /// </summary>
    /// <param name="val">quantity measured in NanoCandela</param>
    /// <returns>quantity measured in YoctoCandela</returns>
	public static Quantity<double, YoctoCandela> ToYoctoCandela<T>(this BaseQuantity<T, NanoCandela> val) where T:IConvertible {
        return new Quantity<double, YoctoCandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert PicoCandela to YottaCandela
    /// </summary>
    /// <param name="val">quantity measured in PicoCandela</param>
    /// <returns>quantity measured in YottaCandela</returns>
	public static Quantity<double, YottaCandela> ToYottaCandela<T>(this BaseQuantity<T, PicoCandela> val) where T:IConvertible {
        return new Quantity<double, YottaCandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoCandela to ZettaCandela
    /// </summary>
    /// <param name="val">quantity measured in PicoCandela</param>
    /// <returns>quantity measured in ZettaCandela</returns>
	public static Quantity<double, ZettaCandela> ToZettaCandela<T>(this BaseQuantity<T, PicoCandela> val) where T:IConvertible {
        return new Quantity<double, ZettaCandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoCandela to ExaCandela
    /// </summary>
    /// <param name="val">quantity measured in PicoCandela</param>
    /// <returns>quantity measured in ExaCandela</returns>
	public static Quantity<double, ExaCandela> ToExaCandela<T>(this BaseQuantity<T, PicoCandela> val) where T:IConvertible {
        return new Quantity<double, ExaCandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoCandela to PetaCandela
    /// </summary>
    /// <param name="val">quantity measured in PicoCandela</param>
    /// <returns>quantity measured in PetaCandela</returns>
	public static Quantity<double, PetaCandela> ToPetaCandela<T>(this BaseQuantity<T, PicoCandela> val) where T:IConvertible {
        return new Quantity<double, PetaCandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoCandela to TeraCandela
    /// </summary>
    /// <param name="val">quantity measured in PicoCandela</param>
    /// <returns>quantity measured in TeraCandela</returns>
	public static Quantity<double, TeraCandela> ToTeraCandela<T>(this BaseQuantity<T, PicoCandela> val) where T:IConvertible {
        return new Quantity<double, TeraCandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoCandela to GigaCandela
    /// </summary>
    /// <param name="val">quantity measured in PicoCandela</param>
    /// <returns>quantity measured in GigaCandela</returns>
	public static Quantity<double, GigaCandela> ToGigaCandela<T>(this BaseQuantity<T, PicoCandela> val) where T:IConvertible {
        return new Quantity<double, GigaCandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoCandela to MegaCandela
    /// </summary>
    /// <param name="val">quantity measured in PicoCandela</param>
    /// <returns>quantity measured in MegaCandela</returns>
	public static Quantity<double, MegaCandela> ToMegaCandela<T>(this BaseQuantity<T, PicoCandela> val) where T:IConvertible {
        return new Quantity<double, MegaCandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoCandela to KiloCandela
    /// </summary>
    /// <param name="val">quantity measured in PicoCandela</param>
    /// <returns>quantity measured in KiloCandela</returns>
	public static Quantity<double, KiloCandela> ToKiloCandela<T>(this BaseQuantity<T, PicoCandela> val) where T:IConvertible {
        return new Quantity<double, KiloCandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoCandela to HectoCandela
    /// </summary>
    /// <param name="val">quantity measured in PicoCandela</param>
    /// <returns>quantity measured in HectoCandela</returns>
	public static Quantity<double, HectoCandela> ToHectoCandela<T>(this BaseQuantity<T, PicoCandela> val) where T:IConvertible {
        return new Quantity<double, HectoCandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoCandela to DekaCandela
    /// </summary>
    /// <param name="val">quantity measured in PicoCandela</param>
    /// <returns>quantity measured in DekaCandela</returns>
	public static Quantity<double, DekaCandela> ToDekaCandela<T>(this BaseQuantity<T, PicoCandela> val) where T:IConvertible {
        return new Quantity<double, DekaCandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoCandela to DeciCandela
    /// </summary>
    /// <param name="val">quantity measured in PicoCandela</param>
    /// <returns>quantity measured in DeciCandela</returns>
	public static Quantity<double, DeciCandela> ToDeciCandela<T>(this BaseQuantity<T, PicoCandela> val) where T:IConvertible {
        return new Quantity<double, DeciCandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoCandela to CentiCandela
    /// </summary>
    /// <param name="val">quantity measured in PicoCandela</param>
    /// <returns>quantity measured in CentiCandela</returns>
	public static Quantity<double, CentiCandela> ToCentiCandela<T>(this BaseQuantity<T, PicoCandela> val) where T:IConvertible {
        return new Quantity<double, CentiCandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoCandela to MilliCandela
    /// </summary>
    /// <param name="val">quantity measured in PicoCandela</param>
    /// <returns>quantity measured in MilliCandela</returns>
	public static Quantity<double, MilliCandela> ToMilliCandela<T>(this BaseQuantity<T, PicoCandela> val) where T:IConvertible {
        return new Quantity<double, MilliCandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoCandela to MicroCandela
    /// </summary>
    /// <param name="val">quantity measured in PicoCandela</param>
    /// <returns>quantity measured in MicroCandela</returns>
	public static Quantity<double, MicroCandela> ToMicroCandela<T>(this BaseQuantity<T, PicoCandela> val) where T:IConvertible {
        return new Quantity<double, MicroCandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoCandela to NanoCandela
    /// </summary>
    /// <param name="val">quantity measured in PicoCandela</param>
    /// <returns>quantity measured in NanoCandela</returns>
	public static Quantity<double, NanoCandela> ToNanoCandela<T>(this BaseQuantity<T, PicoCandela> val) where T:IConvertible {
        return new Quantity<double, NanoCandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoCandela to FemtoCandela
    /// </summary>
    /// <param name="val">quantity measured in PicoCandela</param>
    /// <returns>quantity measured in FemtoCandela</returns>
	public static Quantity<double, FemtoCandela> ToFemtoCandela<T>(this BaseQuantity<T, PicoCandela> val) where T:IConvertible {
        return new Quantity<double, FemtoCandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoCandela to AttoCandela
    /// </summary>
    /// <param name="val">quantity measured in PicoCandela</param>
    /// <returns>quantity measured in AttoCandela</returns>
	public static Quantity<double, AttoCandela> ToAttoCandela<T>(this BaseQuantity<T, PicoCandela> val) where T:IConvertible {
        return new Quantity<double, AttoCandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoCandela to ZeptoCandela
    /// </summary>
    /// <param name="val">quantity measured in PicoCandela</param>
    /// <returns>quantity measured in ZeptoCandela</returns>
	public static Quantity<double, ZeptoCandela> ToZeptoCandela<T>(this BaseQuantity<T, PicoCandela> val) where T:IConvertible {
        return new Quantity<double, ZeptoCandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoCandela to YoctoCandela
    /// </summary>
    /// <param name="val">quantity measured in PicoCandela</param>
    /// <returns>quantity measured in YoctoCandela</returns>
	public static Quantity<double, YoctoCandela> ToYoctoCandela<T>(this BaseQuantity<T, PicoCandela> val) where T:IConvertible {
        return new Quantity<double, YoctoCandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert FemtoCandela to YottaCandela
    /// </summary>
    /// <param name="val">quantity measured in FemtoCandela</param>
    /// <returns>quantity measured in YottaCandela</returns>
	public static Quantity<double, YottaCandela> ToYottaCandela<T>(this BaseQuantity<T, FemtoCandela> val) where T:IConvertible {
        return new Quantity<double, YottaCandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoCandela to ZettaCandela
    /// </summary>
    /// <param name="val">quantity measured in FemtoCandela</param>
    /// <returns>quantity measured in ZettaCandela</returns>
	public static Quantity<double, ZettaCandela> ToZettaCandela<T>(this BaseQuantity<T, FemtoCandela> val) where T:IConvertible {
        return new Quantity<double, ZettaCandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoCandela to ExaCandela
    /// </summary>
    /// <param name="val">quantity measured in FemtoCandela</param>
    /// <returns>quantity measured in ExaCandela</returns>
	public static Quantity<double, ExaCandela> ToExaCandela<T>(this BaseQuantity<T, FemtoCandela> val) where T:IConvertible {
        return new Quantity<double, ExaCandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoCandela to PetaCandela
    /// </summary>
    /// <param name="val">quantity measured in FemtoCandela</param>
    /// <returns>quantity measured in PetaCandela</returns>
	public static Quantity<double, PetaCandela> ToPetaCandela<T>(this BaseQuantity<T, FemtoCandela> val) where T:IConvertible {
        return new Quantity<double, PetaCandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoCandela to TeraCandela
    /// </summary>
    /// <param name="val">quantity measured in FemtoCandela</param>
    /// <returns>quantity measured in TeraCandela</returns>
	public static Quantity<double, TeraCandela> ToTeraCandela<T>(this BaseQuantity<T, FemtoCandela> val) where T:IConvertible {
        return new Quantity<double, TeraCandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoCandela to GigaCandela
    /// </summary>
    /// <param name="val">quantity measured in FemtoCandela</param>
    /// <returns>quantity measured in GigaCandela</returns>
	public static Quantity<double, GigaCandela> ToGigaCandela<T>(this BaseQuantity<T, FemtoCandela> val) where T:IConvertible {
        return new Quantity<double, GigaCandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoCandela to MegaCandela
    /// </summary>
    /// <param name="val">quantity measured in FemtoCandela</param>
    /// <returns>quantity measured in MegaCandela</returns>
	public static Quantity<double, MegaCandela> ToMegaCandela<T>(this BaseQuantity<T, FemtoCandela> val) where T:IConvertible {
        return new Quantity<double, MegaCandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoCandela to KiloCandela
    /// </summary>
    /// <param name="val">quantity measured in FemtoCandela</param>
    /// <returns>quantity measured in KiloCandela</returns>
	public static Quantity<double, KiloCandela> ToKiloCandela<T>(this BaseQuantity<T, FemtoCandela> val) where T:IConvertible {
        return new Quantity<double, KiloCandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoCandela to HectoCandela
    /// </summary>
    /// <param name="val">quantity measured in FemtoCandela</param>
    /// <returns>quantity measured in HectoCandela</returns>
	public static Quantity<double, HectoCandela> ToHectoCandela<T>(this BaseQuantity<T, FemtoCandela> val) where T:IConvertible {
        return new Quantity<double, HectoCandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoCandela to DekaCandela
    /// </summary>
    /// <param name="val">quantity measured in FemtoCandela</param>
    /// <returns>quantity measured in DekaCandela</returns>
	public static Quantity<double, DekaCandela> ToDekaCandela<T>(this BaseQuantity<T, FemtoCandela> val) where T:IConvertible {
        return new Quantity<double, DekaCandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoCandela to DeciCandela
    /// </summary>
    /// <param name="val">quantity measured in FemtoCandela</param>
    /// <returns>quantity measured in DeciCandela</returns>
	public static Quantity<double, DeciCandela> ToDeciCandela<T>(this BaseQuantity<T, FemtoCandela> val) where T:IConvertible {
        return new Quantity<double, DeciCandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoCandela to CentiCandela
    /// </summary>
    /// <param name="val">quantity measured in FemtoCandela</param>
    /// <returns>quantity measured in CentiCandela</returns>
	public static Quantity<double, CentiCandela> ToCentiCandela<T>(this BaseQuantity<T, FemtoCandela> val) where T:IConvertible {
        return new Quantity<double, CentiCandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoCandela to MilliCandela
    /// </summary>
    /// <param name="val">quantity measured in FemtoCandela</param>
    /// <returns>quantity measured in MilliCandela</returns>
	public static Quantity<double, MilliCandela> ToMilliCandela<T>(this BaseQuantity<T, FemtoCandela> val) where T:IConvertible {
        return new Quantity<double, MilliCandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoCandela to MicroCandela
    /// </summary>
    /// <param name="val">quantity measured in FemtoCandela</param>
    /// <returns>quantity measured in MicroCandela</returns>
	public static Quantity<double, MicroCandela> ToMicroCandela<T>(this BaseQuantity<T, FemtoCandela> val) where T:IConvertible {
        return new Quantity<double, MicroCandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoCandela to NanoCandela
    /// </summary>
    /// <param name="val">quantity measured in FemtoCandela</param>
    /// <returns>quantity measured in NanoCandela</returns>
	public static Quantity<double, NanoCandela> ToNanoCandela<T>(this BaseQuantity<T, FemtoCandela> val) where T:IConvertible {
        return new Quantity<double, NanoCandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoCandela to PicoCandela
    /// </summary>
    /// <param name="val">quantity measured in FemtoCandela</param>
    /// <returns>quantity measured in PicoCandela</returns>
	public static Quantity<double, PicoCandela> ToPicoCandela<T>(this BaseQuantity<T, FemtoCandela> val) where T:IConvertible {
        return new Quantity<double, PicoCandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoCandela to AttoCandela
    /// </summary>
    /// <param name="val">quantity measured in FemtoCandela</param>
    /// <returns>quantity measured in AttoCandela</returns>
	public static Quantity<double, AttoCandela> ToAttoCandela<T>(this BaseQuantity<T, FemtoCandela> val) where T:IConvertible {
        return new Quantity<double, AttoCandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoCandela to ZeptoCandela
    /// </summary>
    /// <param name="val">quantity measured in FemtoCandela</param>
    /// <returns>quantity measured in ZeptoCandela</returns>
	public static Quantity<double, ZeptoCandela> ToZeptoCandela<T>(this BaseQuantity<T, FemtoCandela> val) where T:IConvertible {
        return new Quantity<double, ZeptoCandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoCandela to YoctoCandela
    /// </summary>
    /// <param name="val">quantity measured in FemtoCandela</param>
    /// <returns>quantity measured in YoctoCandela</returns>
	public static Quantity<double, YoctoCandela> ToYoctoCandela<T>(this BaseQuantity<T, FemtoCandela> val) where T:IConvertible {
        return new Quantity<double, YoctoCandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert AttoCandela to YottaCandela
    /// </summary>
    /// <param name="val">quantity measured in AttoCandela</param>
    /// <returns>quantity measured in YottaCandela</returns>
	public static Quantity<double, YottaCandela> ToYottaCandela<T>(this BaseQuantity<T, AttoCandela> val) where T:IConvertible {
        return new Quantity<double, YottaCandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoCandela to ZettaCandela
    /// </summary>
    /// <param name="val">quantity measured in AttoCandela</param>
    /// <returns>quantity measured in ZettaCandela</returns>
	public static Quantity<double, ZettaCandela> ToZettaCandela<T>(this BaseQuantity<T, AttoCandela> val) where T:IConvertible {
        return new Quantity<double, ZettaCandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoCandela to ExaCandela
    /// </summary>
    /// <param name="val">quantity measured in AttoCandela</param>
    /// <returns>quantity measured in ExaCandela</returns>
	public static Quantity<double, ExaCandela> ToExaCandela<T>(this BaseQuantity<T, AttoCandela> val) where T:IConvertible {
        return new Quantity<double, ExaCandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoCandela to PetaCandela
    /// </summary>
    /// <param name="val">quantity measured in AttoCandela</param>
    /// <returns>quantity measured in PetaCandela</returns>
	public static Quantity<double, PetaCandela> ToPetaCandela<T>(this BaseQuantity<T, AttoCandela> val) where T:IConvertible {
        return new Quantity<double, PetaCandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoCandela to TeraCandela
    /// </summary>
    /// <param name="val">quantity measured in AttoCandela</param>
    /// <returns>quantity measured in TeraCandela</returns>
	public static Quantity<double, TeraCandela> ToTeraCandela<T>(this BaseQuantity<T, AttoCandela> val) where T:IConvertible {
        return new Quantity<double, TeraCandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoCandela to GigaCandela
    /// </summary>
    /// <param name="val">quantity measured in AttoCandela</param>
    /// <returns>quantity measured in GigaCandela</returns>
	public static Quantity<double, GigaCandela> ToGigaCandela<T>(this BaseQuantity<T, AttoCandela> val) where T:IConvertible {
        return new Quantity<double, GigaCandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoCandela to MegaCandela
    /// </summary>
    /// <param name="val">quantity measured in AttoCandela</param>
    /// <returns>quantity measured in MegaCandela</returns>
	public static Quantity<double, MegaCandela> ToMegaCandela<T>(this BaseQuantity<T, AttoCandela> val) where T:IConvertible {
        return new Quantity<double, MegaCandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoCandela to KiloCandela
    /// </summary>
    /// <param name="val">quantity measured in AttoCandela</param>
    /// <returns>quantity measured in KiloCandela</returns>
	public static Quantity<double, KiloCandela> ToKiloCandela<T>(this BaseQuantity<T, AttoCandela> val) where T:IConvertible {
        return new Quantity<double, KiloCandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoCandela to HectoCandela
    /// </summary>
    /// <param name="val">quantity measured in AttoCandela</param>
    /// <returns>quantity measured in HectoCandela</returns>
	public static Quantity<double, HectoCandela> ToHectoCandela<T>(this BaseQuantity<T, AttoCandela> val) where T:IConvertible {
        return new Quantity<double, HectoCandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoCandela to DekaCandela
    /// </summary>
    /// <param name="val">quantity measured in AttoCandela</param>
    /// <returns>quantity measured in DekaCandela</returns>
	public static Quantity<double, DekaCandela> ToDekaCandela<T>(this BaseQuantity<T, AttoCandela> val) where T:IConvertible {
        return new Quantity<double, DekaCandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoCandela to DeciCandela
    /// </summary>
    /// <param name="val">quantity measured in AttoCandela</param>
    /// <returns>quantity measured in DeciCandela</returns>
	public static Quantity<double, DeciCandela> ToDeciCandela<T>(this BaseQuantity<T, AttoCandela> val) where T:IConvertible {
        return new Quantity<double, DeciCandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoCandela to CentiCandela
    /// </summary>
    /// <param name="val">quantity measured in AttoCandela</param>
    /// <returns>quantity measured in CentiCandela</returns>
	public static Quantity<double, CentiCandela> ToCentiCandela<T>(this BaseQuantity<T, AttoCandela> val) where T:IConvertible {
        return new Quantity<double, CentiCandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoCandela to MilliCandela
    /// </summary>
    /// <param name="val">quantity measured in AttoCandela</param>
    /// <returns>quantity measured in MilliCandela</returns>
	public static Quantity<double, MilliCandela> ToMilliCandela<T>(this BaseQuantity<T, AttoCandela> val) where T:IConvertible {
        return new Quantity<double, MilliCandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoCandela to MicroCandela
    /// </summary>
    /// <param name="val">quantity measured in AttoCandela</param>
    /// <returns>quantity measured in MicroCandela</returns>
	public static Quantity<double, MicroCandela> ToMicroCandela<T>(this BaseQuantity<T, AttoCandela> val) where T:IConvertible {
        return new Quantity<double, MicroCandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoCandela to NanoCandela
    /// </summary>
    /// <param name="val">quantity measured in AttoCandela</param>
    /// <returns>quantity measured in NanoCandela</returns>
	public static Quantity<double, NanoCandela> ToNanoCandela<T>(this BaseQuantity<T, AttoCandela> val) where T:IConvertible {
        return new Quantity<double, NanoCandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoCandela to PicoCandela
    /// </summary>
    /// <param name="val">quantity measured in AttoCandela</param>
    /// <returns>quantity measured in PicoCandela</returns>
	public static Quantity<double, PicoCandela> ToPicoCandela<T>(this BaseQuantity<T, AttoCandela> val) where T:IConvertible {
        return new Quantity<double, PicoCandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoCandela to FemtoCandela
    /// </summary>
    /// <param name="val">quantity measured in AttoCandela</param>
    /// <returns>quantity measured in FemtoCandela</returns>
	public static Quantity<double, FemtoCandela> ToFemtoCandela<T>(this BaseQuantity<T, AttoCandela> val) where T:IConvertible {
        return new Quantity<double, FemtoCandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoCandela to ZeptoCandela
    /// </summary>
    /// <param name="val">quantity measured in AttoCandela</param>
    /// <returns>quantity measured in ZeptoCandela</returns>
	public static Quantity<double, ZeptoCandela> ToZeptoCandela<T>(this BaseQuantity<T, AttoCandela> val) where T:IConvertible {
        return new Quantity<double, ZeptoCandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoCandela to YoctoCandela
    /// </summary>
    /// <param name="val">quantity measured in AttoCandela</param>
    /// <returns>quantity measured in YoctoCandela</returns>
	public static Quantity<double, YoctoCandela> ToYoctoCandela<T>(this BaseQuantity<T, AttoCandela> val) where T:IConvertible {
        return new Quantity<double, YoctoCandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoCandela to YottaCandela
    /// </summary>
    /// <param name="val">quantity measured in ZeptoCandela</param>
    /// <returns>quantity measured in YottaCandela</returns>
	public static Quantity<double, YottaCandela> ToYottaCandela<T>(this BaseQuantity<T, ZeptoCandela> val) where T:IConvertible {
        return new Quantity<double, YottaCandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoCandela to ZettaCandela
    /// </summary>
    /// <param name="val">quantity measured in ZeptoCandela</param>
    /// <returns>quantity measured in ZettaCandela</returns>
	public static Quantity<double, ZettaCandela> ToZettaCandela<T>(this BaseQuantity<T, ZeptoCandela> val) where T:IConvertible {
        return new Quantity<double, ZettaCandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoCandela to ExaCandela
    /// </summary>
    /// <param name="val">quantity measured in ZeptoCandela</param>
    /// <returns>quantity measured in ExaCandela</returns>
	public static Quantity<double, ExaCandela> ToExaCandela<T>(this BaseQuantity<T, ZeptoCandela> val) where T:IConvertible {
        return new Quantity<double, ExaCandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoCandela to PetaCandela
    /// </summary>
    /// <param name="val">quantity measured in ZeptoCandela</param>
    /// <returns>quantity measured in PetaCandela</returns>
	public static Quantity<double, PetaCandela> ToPetaCandela<T>(this BaseQuantity<T, ZeptoCandela> val) where T:IConvertible {
        return new Quantity<double, PetaCandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoCandela to TeraCandela
    /// </summary>
    /// <param name="val">quantity measured in ZeptoCandela</param>
    /// <returns>quantity measured in TeraCandela</returns>
	public static Quantity<double, TeraCandela> ToTeraCandela<T>(this BaseQuantity<T, ZeptoCandela> val) where T:IConvertible {
        return new Quantity<double, TeraCandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoCandela to GigaCandela
    /// </summary>
    /// <param name="val">quantity measured in ZeptoCandela</param>
    /// <returns>quantity measured in GigaCandela</returns>
	public static Quantity<double, GigaCandela> ToGigaCandela<T>(this BaseQuantity<T, ZeptoCandela> val) where T:IConvertible {
        return new Quantity<double, GigaCandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoCandela to MegaCandela
    /// </summary>
    /// <param name="val">quantity measured in ZeptoCandela</param>
    /// <returns>quantity measured in MegaCandela</returns>
	public static Quantity<double, MegaCandela> ToMegaCandela<T>(this BaseQuantity<T, ZeptoCandela> val) where T:IConvertible {
        return new Quantity<double, MegaCandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoCandela to KiloCandela
    /// </summary>
    /// <param name="val">quantity measured in ZeptoCandela</param>
    /// <returns>quantity measured in KiloCandela</returns>
	public static Quantity<double, KiloCandela> ToKiloCandela<T>(this BaseQuantity<T, ZeptoCandela> val) where T:IConvertible {
        return new Quantity<double, KiloCandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoCandela to HectoCandela
    /// </summary>
    /// <param name="val">quantity measured in ZeptoCandela</param>
    /// <returns>quantity measured in HectoCandela</returns>
	public static Quantity<double, HectoCandela> ToHectoCandela<T>(this BaseQuantity<T, ZeptoCandela> val) where T:IConvertible {
        return new Quantity<double, HectoCandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoCandela to DekaCandela
    /// </summary>
    /// <param name="val">quantity measured in ZeptoCandela</param>
    /// <returns>quantity measured in DekaCandela</returns>
	public static Quantity<double, DekaCandela> ToDekaCandela<T>(this BaseQuantity<T, ZeptoCandela> val) where T:IConvertible {
        return new Quantity<double, DekaCandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoCandela to DeciCandela
    /// </summary>
    /// <param name="val">quantity measured in ZeptoCandela</param>
    /// <returns>quantity measured in DeciCandela</returns>
	public static Quantity<double, DeciCandela> ToDeciCandela<T>(this BaseQuantity<T, ZeptoCandela> val) where T:IConvertible {
        return new Quantity<double, DeciCandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoCandela to CentiCandela
    /// </summary>
    /// <param name="val">quantity measured in ZeptoCandela</param>
    /// <returns>quantity measured in CentiCandela</returns>
	public static Quantity<double, CentiCandela> ToCentiCandela<T>(this BaseQuantity<T, ZeptoCandela> val) where T:IConvertible {
        return new Quantity<double, CentiCandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoCandela to MilliCandela
    /// </summary>
    /// <param name="val">quantity measured in ZeptoCandela</param>
    /// <returns>quantity measured in MilliCandela</returns>
	public static Quantity<double, MilliCandela> ToMilliCandela<T>(this BaseQuantity<T, ZeptoCandela> val) where T:IConvertible {
        return new Quantity<double, MilliCandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoCandela to MicroCandela
    /// </summary>
    /// <param name="val">quantity measured in ZeptoCandela</param>
    /// <returns>quantity measured in MicroCandela</returns>
	public static Quantity<double, MicroCandela> ToMicroCandela<T>(this BaseQuantity<T, ZeptoCandela> val) where T:IConvertible {
        return new Quantity<double, MicroCandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoCandela to NanoCandela
    /// </summary>
    /// <param name="val">quantity measured in ZeptoCandela</param>
    /// <returns>quantity measured in NanoCandela</returns>
	public static Quantity<double, NanoCandela> ToNanoCandela<T>(this BaseQuantity<T, ZeptoCandela> val) where T:IConvertible {
        return new Quantity<double, NanoCandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoCandela to PicoCandela
    /// </summary>
    /// <param name="val">quantity measured in ZeptoCandela</param>
    /// <returns>quantity measured in PicoCandela</returns>
	public static Quantity<double, PicoCandela> ToPicoCandela<T>(this BaseQuantity<T, ZeptoCandela> val) where T:IConvertible {
        return new Quantity<double, PicoCandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoCandela to FemtoCandela
    /// </summary>
    /// <param name="val">quantity measured in ZeptoCandela</param>
    /// <returns>quantity measured in FemtoCandela</returns>
	public static Quantity<double, FemtoCandela> ToFemtoCandela<T>(this BaseQuantity<T, ZeptoCandela> val) where T:IConvertible {
        return new Quantity<double, FemtoCandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoCandela to AttoCandela
    /// </summary>
    /// <param name="val">quantity measured in ZeptoCandela</param>
    /// <returns>quantity measured in AttoCandela</returns>
	public static Quantity<double, AttoCandela> ToAttoCandela<T>(this BaseQuantity<T, ZeptoCandela> val) where T:IConvertible {
        return new Quantity<double, AttoCandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoCandela to YoctoCandela
    /// </summary>
    /// <param name="val">quantity measured in ZeptoCandela</param>
    /// <returns>quantity measured in YoctoCandela</returns>
	public static Quantity<double, YoctoCandela> ToYoctoCandela<T>(this BaseQuantity<T, ZeptoCandela> val) where T:IConvertible {
        return new Quantity<double, YoctoCandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert YoctoCandela to YottaCandela
    /// </summary>
    /// <param name="val">quantity measured in YoctoCandela</param>
    /// <returns>quantity measured in YottaCandela</returns>
	public static Quantity<double, YottaCandela> ToYottaCandela<T>(this BaseQuantity<T, YoctoCandela> val) where T:IConvertible {
        return new Quantity<double, YottaCandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoCandela to ZettaCandela
    /// </summary>
    /// <param name="val">quantity measured in YoctoCandela</param>
    /// <returns>quantity measured in ZettaCandela</returns>
	public static Quantity<double, ZettaCandela> ToZettaCandela<T>(this BaseQuantity<T, YoctoCandela> val) where T:IConvertible {
        return new Quantity<double, ZettaCandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoCandela to ExaCandela
    /// </summary>
    /// <param name="val">quantity measured in YoctoCandela</param>
    /// <returns>quantity measured in ExaCandela</returns>
	public static Quantity<double, ExaCandela> ToExaCandela<T>(this BaseQuantity<T, YoctoCandela> val) where T:IConvertible {
        return new Quantity<double, ExaCandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoCandela to PetaCandela
    /// </summary>
    /// <param name="val">quantity measured in YoctoCandela</param>
    /// <returns>quantity measured in PetaCandela</returns>
	public static Quantity<double, PetaCandela> ToPetaCandela<T>(this BaseQuantity<T, YoctoCandela> val) where T:IConvertible {
        return new Quantity<double, PetaCandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoCandela to TeraCandela
    /// </summary>
    /// <param name="val">quantity measured in YoctoCandela</param>
    /// <returns>quantity measured in TeraCandela</returns>
	public static Quantity<double, TeraCandela> ToTeraCandela<T>(this BaseQuantity<T, YoctoCandela> val) where T:IConvertible {
        return new Quantity<double, TeraCandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoCandela to GigaCandela
    /// </summary>
    /// <param name="val">quantity measured in YoctoCandela</param>
    /// <returns>quantity measured in GigaCandela</returns>
	public static Quantity<double, GigaCandela> ToGigaCandela<T>(this BaseQuantity<T, YoctoCandela> val) where T:IConvertible {
        return new Quantity<double, GigaCandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoCandela to MegaCandela
    /// </summary>
    /// <param name="val">quantity measured in YoctoCandela</param>
    /// <returns>quantity measured in MegaCandela</returns>
	public static Quantity<double, MegaCandela> ToMegaCandela<T>(this BaseQuantity<T, YoctoCandela> val) where T:IConvertible {
        return new Quantity<double, MegaCandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoCandela to KiloCandela
    /// </summary>
    /// <param name="val">quantity measured in YoctoCandela</param>
    /// <returns>quantity measured in KiloCandela</returns>
	public static Quantity<double, KiloCandela> ToKiloCandela<T>(this BaseQuantity<T, YoctoCandela> val) where T:IConvertible {
        return new Quantity<double, KiloCandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoCandela to HectoCandela
    /// </summary>
    /// <param name="val">quantity measured in YoctoCandela</param>
    /// <returns>quantity measured in HectoCandela</returns>
	public static Quantity<double, HectoCandela> ToHectoCandela<T>(this BaseQuantity<T, YoctoCandela> val) where T:IConvertible {
        return new Quantity<double, HectoCandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoCandela to DekaCandela
    /// </summary>
    /// <param name="val">quantity measured in YoctoCandela</param>
    /// <returns>quantity measured in DekaCandela</returns>
	public static Quantity<double, DekaCandela> ToDekaCandela<T>(this BaseQuantity<T, YoctoCandela> val) where T:IConvertible {
        return new Quantity<double, DekaCandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoCandela to DeciCandela
    /// </summary>
    /// <param name="val">quantity measured in YoctoCandela</param>
    /// <returns>quantity measured in DeciCandela</returns>
	public static Quantity<double, DeciCandela> ToDeciCandela<T>(this BaseQuantity<T, YoctoCandela> val) where T:IConvertible {
        return new Quantity<double, DeciCandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoCandela to CentiCandela
    /// </summary>
    /// <param name="val">quantity measured in YoctoCandela</param>
    /// <returns>quantity measured in CentiCandela</returns>
	public static Quantity<double, CentiCandela> ToCentiCandela<T>(this BaseQuantity<T, YoctoCandela> val) where T:IConvertible {
        return new Quantity<double, CentiCandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoCandela to MilliCandela
    /// </summary>
    /// <param name="val">quantity measured in YoctoCandela</param>
    /// <returns>quantity measured in MilliCandela</returns>
	public static Quantity<double, MilliCandela> ToMilliCandela<T>(this BaseQuantity<T, YoctoCandela> val) where T:IConvertible {
        return new Quantity<double, MilliCandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoCandela to MicroCandela
    /// </summary>
    /// <param name="val">quantity measured in YoctoCandela</param>
    /// <returns>quantity measured in MicroCandela</returns>
	public static Quantity<double, MicroCandela> ToMicroCandela<T>(this BaseQuantity<T, YoctoCandela> val) where T:IConvertible {
        return new Quantity<double, MicroCandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoCandela to NanoCandela
    /// </summary>
    /// <param name="val">quantity measured in YoctoCandela</param>
    /// <returns>quantity measured in NanoCandela</returns>
	public static Quantity<double, NanoCandela> ToNanoCandela<T>(this BaseQuantity<T, YoctoCandela> val) where T:IConvertible {
        return new Quantity<double, NanoCandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoCandela to PicoCandela
    /// </summary>
    /// <param name="val">quantity measured in YoctoCandela</param>
    /// <returns>quantity measured in PicoCandela</returns>
	public static Quantity<double, PicoCandela> ToPicoCandela<T>(this BaseQuantity<T, YoctoCandela> val) where T:IConvertible {
        return new Quantity<double, PicoCandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoCandela to FemtoCandela
    /// </summary>
    /// <param name="val">quantity measured in YoctoCandela</param>
    /// <returns>quantity measured in FemtoCandela</returns>
	public static Quantity<double, FemtoCandela> ToFemtoCandela<T>(this BaseQuantity<T, YoctoCandela> val) where T:IConvertible {
        return new Quantity<double, FemtoCandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoCandela to AttoCandela
    /// </summary>
    /// <param name="val">quantity measured in YoctoCandela</param>
    /// <returns>quantity measured in AttoCandela</returns>
	public static Quantity<double, AttoCandela> ToAttoCandela<T>(this BaseQuantity<T, YoctoCandela> val) where T:IConvertible {
        return new Quantity<double, AttoCandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoCandela to ZeptoCandela
    /// </summary>
    /// <param name="val">quantity measured in YoctoCandela</param>
    /// <returns>quantity measured in ZeptoCandela</returns>
	public static Quantity<double, ZeptoCandela> ToZeptoCandela<T>(this BaseQuantity<T, YoctoCandela> val) where T:IConvertible {
        return new Quantity<double, ZeptoCandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
}
}