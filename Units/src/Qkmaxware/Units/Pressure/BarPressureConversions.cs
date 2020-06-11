using System;
namespace Qkmaxware.Units.Pressure {
/// <summary>
/// Static class housing si-prefix conversions for the unit "Bar"
/// </summary>
public static class BarPressureConversions {
	/// <summary>
    /// Extension method to convert Bar to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Bar to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Bar to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Bar to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Bar to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Bar to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Bar to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Bar to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Bar to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Bar to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Bar to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Bar to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Bar to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Bar to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Bar to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Bar to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Bar to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Bar to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Bar to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Bar to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in Bar</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, Bar> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaBar to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in YottaBar</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, YottaBar> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaBar to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in ZettaBar</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, ZettaBar> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaBar to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in ExaBar</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, ExaBar> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaBar to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in PetaBar</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, PetaBar> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraBar to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in TeraBar</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, TeraBar> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaBar to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in GigaBar</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, GigaBar> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaBar to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in MegaBar</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, MegaBar> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloBar to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in KiloBar</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, KiloBar> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoBar to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in HectoBar</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, HectoBar> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaBar to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in DekaBar</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, DekaBar> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciBar to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in DeciBar</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, DeciBar> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiBar to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in CentiBar</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, CentiBar> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliBar to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in MilliBar</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, MilliBar> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroBar to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in MicroBar</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, MicroBar> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoBar to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in NanoBar</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, NanoBar> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoBar to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in PicoBar</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, PicoBar> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoBar to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in FemtoBar</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, FemtoBar> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoBar to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in AttoBar</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, AttoBar> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoBar to YoctoBar
    /// </summary>
    /// <param name="val">quantity measured in ZeptoBar</param>
    /// <returns>quantity measured in YoctoBar</returns>
	public static Quantity<double, YoctoBar> ToYoctoBar<T>(this Quantity<T, ZeptoBar> val) where T:IConvertible {
        return new Quantity<double, YoctoBar>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to YottaBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in YottaBar</returns>
	public static Quantity<double, YottaBar> ToYottaBar<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, YottaBar>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to ZettaBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in ZettaBar</returns>
	public static Quantity<double, ZettaBar> ToZettaBar<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, ZettaBar>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to ExaBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in ExaBar</returns>
	public static Quantity<double, ExaBar> ToExaBar<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, ExaBar>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to PetaBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in PetaBar</returns>
	public static Quantity<double, PetaBar> ToPetaBar<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, PetaBar>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to TeraBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in TeraBar</returns>
	public static Quantity<double, TeraBar> ToTeraBar<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, TeraBar>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to GigaBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in GigaBar</returns>
	public static Quantity<double, GigaBar> ToGigaBar<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, GigaBar>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to MegaBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in MegaBar</returns>
	public static Quantity<double, MegaBar> ToMegaBar<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, MegaBar>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to KiloBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in KiloBar</returns>
	public static Quantity<double, KiloBar> ToKiloBar<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, KiloBar>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to HectoBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in HectoBar</returns>
	public static Quantity<double, HectoBar> ToHectoBar<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, HectoBar>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to DekaBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in DekaBar</returns>
	public static Quantity<double, DekaBar> ToDekaBar<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, DekaBar>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to DeciBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in DeciBar</returns>
	public static Quantity<double, DeciBar> ToDeciBar<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, DeciBar>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to CentiBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in CentiBar</returns>
	public static Quantity<double, CentiBar> ToCentiBar<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, CentiBar>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to MilliBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in MilliBar</returns>
	public static Quantity<double, MilliBar> ToMilliBar<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, MilliBar>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to MicroBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in MicroBar</returns>
	public static Quantity<double, MicroBar> ToMicroBar<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, MicroBar>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to NanoBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in NanoBar</returns>
	public static Quantity<double, NanoBar> ToNanoBar<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, NanoBar>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to PicoBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in PicoBar</returns>
	public static Quantity<double, PicoBar> ToPicoBar<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, PicoBar>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to FemtoBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in FemtoBar</returns>
	public static Quantity<double, FemtoBar> ToFemtoBar<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, FemtoBar>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to AttoBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in AttoBar</returns>
	public static Quantity<double, AttoBar> ToAttoBar<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, AttoBar>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoBar to ZeptoBar
    /// </summary>
    /// <param name="val">quantity measured in YoctoBar</param>
    /// <returns>quantity measured in ZeptoBar</returns>
	public static Quantity<double, ZeptoBar> ToZeptoBar<T>(this Quantity<T, YoctoBar> val) where T:IConvertible {
        return new Quantity<double, ZeptoBar>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
}
}