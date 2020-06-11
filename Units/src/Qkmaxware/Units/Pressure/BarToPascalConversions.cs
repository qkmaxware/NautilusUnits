using System;

namespace Qkmaxware.Units.Pressure {
/// <summary>
/// Static class housing conversions to and from Pascal and Bar
/// </summary>
public static class BarToPascalConversionsConversions {
	/// <summary>
    /// Extension method to convert Bar to Pascal
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in Pascal</returns>
	public static Quantity<double, Pascal> ToPascal<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, Pascal>(
            Convert.ToDouble(val.Value) * (100000)
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to Bar
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in Bar</returns>
	public static Quantity<double, Bar> ToBar<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, Bar>(
            Convert.ToDouble(val.Value) * (1.0/(100000))
        );
    }
	/// <summary>
    /// Extension method to convert Bar to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * 1E-24)
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * 1E-24)
        );
    }
	/// <summary>
    /// Extension method to convert Bar to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * 1E-21)
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * 1E-21)
        );
    }
	/// <summary>
    /// Extension method to convert Bar to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * 1E-18)
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * 1E-18)
        );
    }
	/// <summary>
    /// Extension method to convert Bar to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * 1E-15)
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * 1E-15)
        );
    }
	/// <summary>
    /// Extension method to convert Bar to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * ((100000) * 1E-12)
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * 1E-12)
        );
    }
	/// <summary>
    /// Extension method to convert Bar to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * 1E-9)
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * 1E-9)
        );
    }
	/// <summary>
    /// Extension method to convert Bar to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * 1E-6)
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * 1E-6)
        );
    }
	/// <summary>
    /// Extension method to convert Bar to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * ((100000) * 1E-3)
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * 1E-3)
        );
    }
	/// <summary>
    /// Extension method to convert Bar to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * 1E-2)
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * 1E-2)
        );
    }
	/// <summary>
    /// Extension method to convert Bar to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * 1E-1)
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * 1E-1)
        );
    }
	/// <summary>
    /// Extension method to convert Bar to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * ((100000) * 1E1)
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * 1E1)
        );
    }
	/// <summary>
    /// Extension method to convert Bar to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * ((100000) * 1E2)
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * 1E2)
        );
    }
	/// <summary>
    /// Extension method to convert Bar to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * ((100000) * 1E3)
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * 1E3)
        );
    }
	/// <summary>
    /// Extension method to convert Bar to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * ((100000) * 1E6)
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * 1E6)
        );
    }
	/// <summary>
    /// Extension method to convert Bar to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * 1E9)
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * 1E9)
        );
    }
	/// <summary>
    /// Extension method to convert Bar to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * 1E12)
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * 1E12)
        );
    }
	/// <summary>
    /// Extension method to convert Bar to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * 1E15)
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * 1E15)
        );
    }
	/// <summary>
    /// Extension method to convert Bar to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * 1E18)
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * 1E18)
        );
    }
	/// <summary>
    /// Extension method to convert Bar to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * 1E21)
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * 1E21)
        );
    }
	/// <summary>
    /// Extension method to convert Bar to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * 1E24)
        );
    }
	/// <summary>
    /// Extension method to convert Pascal to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in Pascal</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, Pascal> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * 1E24)
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-24))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-21))
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-18))
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-15))
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-12))
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-9))
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-6))
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-3))
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-2))
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E-1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E1))
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E2))
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E3))
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E6))
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E9))
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E12))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E15))
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E18))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E21))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to YottaPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in YottaPascal</returns>
	public static Quantity<double, YottaPascal> ToYottaPascal<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, YottaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YottaPascal to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in YottaPascal</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, YottaPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to ZettaPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in ZettaPascal</returns>
	public static Quantity<double, ZettaPascal> ToZettaPascal<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, ZettaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert ZettaPascal to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaPascal</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, ZettaPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to ExaPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in ExaPascal</returns>
	public static Quantity<double, ExaPascal> ToExaPascal<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, ExaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert ExaPascal to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in ExaPascal</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, ExaPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to PetaPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in PetaPascal</returns>
	public static Quantity<double, PetaPascal> ToPetaPascal<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, PetaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert PetaPascal to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in PetaPascal</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, PetaPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to TeraPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in TeraPascal</returns>
	public static Quantity<double, TeraPascal> ToTeraPascal<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, TeraPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert TeraPascal to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in TeraPascal</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, TeraPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to GigaPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in GigaPascal</returns>
	public static Quantity<double, GigaPascal> ToGigaPascal<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, GigaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert GigaPascal to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in GigaPascal</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, GigaPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to MegaPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in MegaPascal</returns>
	public static Quantity<double, MegaPascal> ToMegaPascal<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, MegaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert MegaPascal to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in MegaPascal</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, MegaPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to KiloPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in KiloPascal</returns>
	public static Quantity<double, KiloPascal> ToKiloPascal<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, KiloPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert KiloPascal to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in KiloPascal</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, KiloPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to HectoPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in HectoPascal</returns>
	public static Quantity<double, HectoPascal> ToHectoPascal<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, HectoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert HectoPascal to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in HectoPascal</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, HectoPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to DekaPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in DekaPascal</returns>
	public static Quantity<double, DekaPascal> ToDekaPascal<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, DekaPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert DekaPascal to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in DekaPascal</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, DekaPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to DeciPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in DeciPascal</returns>
	public static Quantity<double, DeciPascal> ToDeciPascal<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, DeciPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert DeciPascal to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in DeciPascal</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, DeciPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to CentiPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in CentiPascal</returns>
	public static Quantity<double, CentiPascal> ToCentiPascal<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, CentiPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert CentiPascal to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in CentiPascal</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, CentiPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to MilliPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in MilliPascal</returns>
	public static Quantity<double, MilliPascal> ToMilliPascal<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, MilliPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert MilliPascal to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in MilliPascal</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, MilliPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to MicroPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in MicroPascal</returns>
	public static Quantity<double, MicroPascal> ToMicroPascal<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, MicroPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert MicroPascal to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in MicroPascal</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, MicroPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to NanoPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in NanoPascal</returns>
	public static Quantity<double, NanoPascal> ToNanoPascal<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, NanoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert NanoPascal to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in NanoPascal</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, NanoPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to PicoPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in PicoPascal</returns>
	public static Quantity<double, PicoPascal> ToPicoPascal<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, PicoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert PicoPascal to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in PicoPascal</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, PicoPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to FemtoPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in FemtoPascal</returns>
	public static Quantity<double, FemtoPascal> ToFemtoPascal<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, FemtoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert FemtoPascal to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoPascal</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, FemtoPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to AttoPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in AttoPascal</returns>
	public static Quantity<double, AttoPascal> ToAttoPascal<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, AttoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert AttoPascal to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in AttoPascal</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, AttoPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to ZeptoPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in ZeptoPascal</returns>
	public static Quantity<double, ZeptoPascal> ToZeptoPascal<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoPascal to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoPascal</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, ZeptoPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to YoctoPascal
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in YoctoPascal</returns>
	public static Quantity<double, YoctoPascal> ToYoctoPascal<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, YoctoPascal>(
            Convert.ToDouble(val.Value) * ((100000) * (1E24))
        );
    }
	/// <summary>
    /// Extension method to convert YoctoPascal to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoPascal</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, YoctoPascal> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * ((1.0/(100000)) * (1E24))
        );
    }
}
}