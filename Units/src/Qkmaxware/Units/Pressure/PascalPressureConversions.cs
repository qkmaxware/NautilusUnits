using System;
namespace Qkmaxware.Units.Pressure {
/// <summary>
/// Static class housing si-prefix conversions for the unit "Pascal"
/// </summary>
public static class PascalPressureConversions {
	/// <summary>
    /// Extension method to convert Pascal to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
}
}