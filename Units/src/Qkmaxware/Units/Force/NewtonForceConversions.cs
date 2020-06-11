using System;
namespace Qkmaxware.Units.Force {
/// <summary>
/// Static class housing si-prefix conversions for the unit "Newton"
/// </summary>
public static class ForceConversions {
	/// <summary>
    /// Extension method to convert Newton to YottaNewton
    /// </summary>
    /// <param name="val">quantity measured in Newton</param>
    /// <returns>quantity measured in YottaNewton</returns>
	public static Quantity<double, YottaNewton> ToYottaNewton<T>(this BaseQuantity<T, Newton> val) where T:IConvertible {
        return new Quantity<double, YottaNewton>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Newton to ZettaNewton
    /// </summary>
    /// <param name="val">quantity measured in Newton</param>
    /// <returns>quantity measured in ZettaNewton</returns>
	public static Quantity<double, ZettaNewton> ToZettaNewton<T>(this BaseQuantity<T, Newton> val) where T:IConvertible {
        return new Quantity<double, ZettaNewton>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Newton to ExaNewton
    /// </summary>
    /// <param name="val">quantity measured in Newton</param>
    /// <returns>quantity measured in ExaNewton</returns>
	public static Quantity<double, ExaNewton> ToExaNewton<T>(this BaseQuantity<T, Newton> val) where T:IConvertible {
        return new Quantity<double, ExaNewton>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Newton to PetaNewton
    /// </summary>
    /// <param name="val">quantity measured in Newton</param>
    /// <returns>quantity measured in PetaNewton</returns>
	public static Quantity<double, PetaNewton> ToPetaNewton<T>(this BaseQuantity<T, Newton> val) where T:IConvertible {
        return new Quantity<double, PetaNewton>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Newton to TeraNewton
    /// </summary>
    /// <param name="val">quantity measured in Newton</param>
    /// <returns>quantity measured in TeraNewton</returns>
	public static Quantity<double, TeraNewton> ToTeraNewton<T>(this BaseQuantity<T, Newton> val) where T:IConvertible {
        return new Quantity<double, TeraNewton>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Newton to GigaNewton
    /// </summary>
    /// <param name="val">quantity measured in Newton</param>
    /// <returns>quantity measured in GigaNewton</returns>
	public static Quantity<double, GigaNewton> ToGigaNewton<T>(this BaseQuantity<T, Newton> val) where T:IConvertible {
        return new Quantity<double, GigaNewton>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Newton to MegaNewton
    /// </summary>
    /// <param name="val">quantity measured in Newton</param>
    /// <returns>quantity measured in MegaNewton</returns>
	public static Quantity<double, MegaNewton> ToMegaNewton<T>(this BaseQuantity<T, Newton> val) where T:IConvertible {
        return new Quantity<double, MegaNewton>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Newton to KiloNewton
    /// </summary>
    /// <param name="val">quantity measured in Newton</param>
    /// <returns>quantity measured in KiloNewton</returns>
	public static Quantity<double, KiloNewton> ToKiloNewton<T>(this BaseQuantity<T, Newton> val) where T:IConvertible {
        return new Quantity<double, KiloNewton>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Newton to HectoNewton
    /// </summary>
    /// <param name="val">quantity measured in Newton</param>
    /// <returns>quantity measured in HectoNewton</returns>
	public static Quantity<double, HectoNewton> ToHectoNewton<T>(this BaseQuantity<T, Newton> val) where T:IConvertible {
        return new Quantity<double, HectoNewton>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Newton to DekaNewton
    /// </summary>
    /// <param name="val">quantity measured in Newton</param>
    /// <returns>quantity measured in DekaNewton</returns>
	public static Quantity<double, DekaNewton> ToDekaNewton<T>(this BaseQuantity<T, Newton> val) where T:IConvertible {
        return new Quantity<double, DekaNewton>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Newton to DeciNewton
    /// </summary>
    /// <param name="val">quantity measured in Newton</param>
    /// <returns>quantity measured in DeciNewton</returns>
	public static Quantity<double, DeciNewton> ToDeciNewton<T>(this BaseQuantity<T, Newton> val) where T:IConvertible {
        return new Quantity<double, DeciNewton>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Newton to CentiNewton
    /// </summary>
    /// <param name="val">quantity measured in Newton</param>
    /// <returns>quantity measured in CentiNewton</returns>
	public static Quantity<double, CentiNewton> ToCentiNewton<T>(this BaseQuantity<T, Newton> val) where T:IConvertible {
        return new Quantity<double, CentiNewton>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Newton to MilliNewton
    /// </summary>
    /// <param name="val">quantity measured in Newton</param>
    /// <returns>quantity measured in MilliNewton</returns>
	public static Quantity<double, MilliNewton> ToMilliNewton<T>(this BaseQuantity<T, Newton> val) where T:IConvertible {
        return new Quantity<double, MilliNewton>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Newton to MicroNewton
    /// </summary>
    /// <param name="val">quantity measured in Newton</param>
    /// <returns>quantity measured in MicroNewton</returns>
	public static Quantity<double, MicroNewton> ToMicroNewton<T>(this BaseQuantity<T, Newton> val) where T:IConvertible {
        return new Quantity<double, MicroNewton>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Newton to NanoNewton
    /// </summary>
    /// <param name="val">quantity measured in Newton</param>
    /// <returns>quantity measured in NanoNewton</returns>
	public static Quantity<double, NanoNewton> ToNanoNewton<T>(this BaseQuantity<T, Newton> val) where T:IConvertible {
        return new Quantity<double, NanoNewton>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Newton to PicoNewton
    /// </summary>
    /// <param name="val">quantity measured in Newton</param>
    /// <returns>quantity measured in PicoNewton</returns>
	public static Quantity<double, PicoNewton> ToPicoNewton<T>(this BaseQuantity<T, Newton> val) where T:IConvertible {
        return new Quantity<double, PicoNewton>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Newton to FemtoNewton
    /// </summary>
    /// <param name="val">quantity measured in Newton</param>
    /// <returns>quantity measured in FemtoNewton</returns>
	public static Quantity<double, FemtoNewton> ToFemtoNewton<T>(this BaseQuantity<T, Newton> val) where T:IConvertible {
        return new Quantity<double, FemtoNewton>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Newton to AttoNewton
    /// </summary>
    /// <param name="val">quantity measured in Newton</param>
    /// <returns>quantity measured in AttoNewton</returns>
	public static Quantity<double, AttoNewton> ToAttoNewton<T>(this BaseQuantity<T, Newton> val) where T:IConvertible {
        return new Quantity<double, AttoNewton>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Newton to ZeptoNewton
    /// </summary>
    /// <param name="val">quantity measured in Newton</param>
    /// <returns>quantity measured in ZeptoNewton</returns>
	public static Quantity<double, ZeptoNewton> ToZeptoNewton<T>(this BaseQuantity<T, Newton> val) where T:IConvertible {
        return new Quantity<double, ZeptoNewton>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Newton to YoctoNewton
    /// </summary>
    /// <param name="val">quantity measured in Newton</param>
    /// <returns>quantity measured in YoctoNewton</returns>
	public static Quantity<double, YoctoNewton> ToYoctoNewton<T>(this BaseQuantity<T, Newton> val) where T:IConvertible {
        return new Quantity<double, YoctoNewton>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YottaNewton to ZettaNewton
    /// </summary>
    /// <param name="val">quantity measured in YottaNewton</param>
    /// <returns>quantity measured in ZettaNewton</returns>
	public static Quantity<double, ZettaNewton> ToZettaNewton<T>(this BaseQuantity<T, YottaNewton> val) where T:IConvertible {
        return new Quantity<double, ZettaNewton>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaNewton to ExaNewton
    /// </summary>
    /// <param name="val">quantity measured in YottaNewton</param>
    /// <returns>quantity measured in ExaNewton</returns>
	public static Quantity<double, ExaNewton> ToExaNewton<T>(this BaseQuantity<T, YottaNewton> val) where T:IConvertible {
        return new Quantity<double, ExaNewton>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaNewton to PetaNewton
    /// </summary>
    /// <param name="val">quantity measured in YottaNewton</param>
    /// <returns>quantity measured in PetaNewton</returns>
	public static Quantity<double, PetaNewton> ToPetaNewton<T>(this BaseQuantity<T, YottaNewton> val) where T:IConvertible {
        return new Quantity<double, PetaNewton>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaNewton to TeraNewton
    /// </summary>
    /// <param name="val">quantity measured in YottaNewton</param>
    /// <returns>quantity measured in TeraNewton</returns>
	public static Quantity<double, TeraNewton> ToTeraNewton<T>(this BaseQuantity<T, YottaNewton> val) where T:IConvertible {
        return new Quantity<double, TeraNewton>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaNewton to GigaNewton
    /// </summary>
    /// <param name="val">quantity measured in YottaNewton</param>
    /// <returns>quantity measured in GigaNewton</returns>
	public static Quantity<double, GigaNewton> ToGigaNewton<T>(this BaseQuantity<T, YottaNewton> val) where T:IConvertible {
        return new Quantity<double, GigaNewton>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaNewton to MegaNewton
    /// </summary>
    /// <param name="val">quantity measured in YottaNewton</param>
    /// <returns>quantity measured in MegaNewton</returns>
	public static Quantity<double, MegaNewton> ToMegaNewton<T>(this BaseQuantity<T, YottaNewton> val) where T:IConvertible {
        return new Quantity<double, MegaNewton>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaNewton to KiloNewton
    /// </summary>
    /// <param name="val">quantity measured in YottaNewton</param>
    /// <returns>quantity measured in KiloNewton</returns>
	public static Quantity<double, KiloNewton> ToKiloNewton<T>(this BaseQuantity<T, YottaNewton> val) where T:IConvertible {
        return new Quantity<double, KiloNewton>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaNewton to HectoNewton
    /// </summary>
    /// <param name="val">quantity measured in YottaNewton</param>
    /// <returns>quantity measured in HectoNewton</returns>
	public static Quantity<double, HectoNewton> ToHectoNewton<T>(this BaseQuantity<T, YottaNewton> val) where T:IConvertible {
        return new Quantity<double, HectoNewton>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaNewton to DekaNewton
    /// </summary>
    /// <param name="val">quantity measured in YottaNewton</param>
    /// <returns>quantity measured in DekaNewton</returns>
	public static Quantity<double, DekaNewton> ToDekaNewton<T>(this BaseQuantity<T, YottaNewton> val) where T:IConvertible {
        return new Quantity<double, DekaNewton>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaNewton to DeciNewton
    /// </summary>
    /// <param name="val">quantity measured in YottaNewton</param>
    /// <returns>quantity measured in DeciNewton</returns>
	public static Quantity<double, DeciNewton> ToDeciNewton<T>(this BaseQuantity<T, YottaNewton> val) where T:IConvertible {
        return new Quantity<double, DeciNewton>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaNewton to CentiNewton
    /// </summary>
    /// <param name="val">quantity measured in YottaNewton</param>
    /// <returns>quantity measured in CentiNewton</returns>
	public static Quantity<double, CentiNewton> ToCentiNewton<T>(this BaseQuantity<T, YottaNewton> val) where T:IConvertible {
        return new Quantity<double, CentiNewton>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaNewton to MilliNewton
    /// </summary>
    /// <param name="val">quantity measured in YottaNewton</param>
    /// <returns>quantity measured in MilliNewton</returns>
	public static Quantity<double, MilliNewton> ToMilliNewton<T>(this BaseQuantity<T, YottaNewton> val) where T:IConvertible {
        return new Quantity<double, MilliNewton>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaNewton to MicroNewton
    /// </summary>
    /// <param name="val">quantity measured in YottaNewton</param>
    /// <returns>quantity measured in MicroNewton</returns>
	public static Quantity<double, MicroNewton> ToMicroNewton<T>(this BaseQuantity<T, YottaNewton> val) where T:IConvertible {
        return new Quantity<double, MicroNewton>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaNewton to NanoNewton
    /// </summary>
    /// <param name="val">quantity measured in YottaNewton</param>
    /// <returns>quantity measured in NanoNewton</returns>
	public static Quantity<double, NanoNewton> ToNanoNewton<T>(this BaseQuantity<T, YottaNewton> val) where T:IConvertible {
        return new Quantity<double, NanoNewton>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaNewton to PicoNewton
    /// </summary>
    /// <param name="val">quantity measured in YottaNewton</param>
    /// <returns>quantity measured in PicoNewton</returns>
	public static Quantity<double, PicoNewton> ToPicoNewton<T>(this BaseQuantity<T, YottaNewton> val) where T:IConvertible {
        return new Quantity<double, PicoNewton>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaNewton to FemtoNewton
    /// </summary>
    /// <param name="val">quantity measured in YottaNewton</param>
    /// <returns>quantity measured in FemtoNewton</returns>
	public static Quantity<double, FemtoNewton> ToFemtoNewton<T>(this BaseQuantity<T, YottaNewton> val) where T:IConvertible {
        return new Quantity<double, FemtoNewton>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaNewton to AttoNewton
    /// </summary>
    /// <param name="val">quantity measured in YottaNewton</param>
    /// <returns>quantity measured in AttoNewton</returns>
	public static Quantity<double, AttoNewton> ToAttoNewton<T>(this BaseQuantity<T, YottaNewton> val) where T:IConvertible {
        return new Quantity<double, AttoNewton>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaNewton to ZeptoNewton
    /// </summary>
    /// <param name="val">quantity measured in YottaNewton</param>
    /// <returns>quantity measured in ZeptoNewton</returns>
	public static Quantity<double, ZeptoNewton> ToZeptoNewton<T>(this BaseQuantity<T, YottaNewton> val) where T:IConvertible {
        return new Quantity<double, ZeptoNewton>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaNewton to YoctoNewton
    /// </summary>
    /// <param name="val">quantity measured in YottaNewton</param>
    /// <returns>quantity measured in YoctoNewton</returns>
	public static Quantity<double, YoctoNewton> ToYoctoNewton<T>(this BaseQuantity<T, YottaNewton> val) where T:IConvertible {
        return new Quantity<double, YoctoNewton>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert ZettaNewton to YottaNewton
    /// </summary>
    /// <param name="val">quantity measured in ZettaNewton</param>
    /// <returns>quantity measured in YottaNewton</returns>
	public static Quantity<double, YottaNewton> ToYottaNewton<T>(this BaseQuantity<T, ZettaNewton> val) where T:IConvertible {
        return new Quantity<double, YottaNewton>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaNewton to ExaNewton
    /// </summary>
    /// <param name="val">quantity measured in ZettaNewton</param>
    /// <returns>quantity measured in ExaNewton</returns>
	public static Quantity<double, ExaNewton> ToExaNewton<T>(this BaseQuantity<T, ZettaNewton> val) where T:IConvertible {
        return new Quantity<double, ExaNewton>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaNewton to PetaNewton
    /// </summary>
    /// <param name="val">quantity measured in ZettaNewton</param>
    /// <returns>quantity measured in PetaNewton</returns>
	public static Quantity<double, PetaNewton> ToPetaNewton<T>(this BaseQuantity<T, ZettaNewton> val) where T:IConvertible {
        return new Quantity<double, PetaNewton>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaNewton to TeraNewton
    /// </summary>
    /// <param name="val">quantity measured in ZettaNewton</param>
    /// <returns>quantity measured in TeraNewton</returns>
	public static Quantity<double, TeraNewton> ToTeraNewton<T>(this BaseQuantity<T, ZettaNewton> val) where T:IConvertible {
        return new Quantity<double, TeraNewton>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaNewton to GigaNewton
    /// </summary>
    /// <param name="val">quantity measured in ZettaNewton</param>
    /// <returns>quantity measured in GigaNewton</returns>
	public static Quantity<double, GigaNewton> ToGigaNewton<T>(this BaseQuantity<T, ZettaNewton> val) where T:IConvertible {
        return new Quantity<double, GigaNewton>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaNewton to MegaNewton
    /// </summary>
    /// <param name="val">quantity measured in ZettaNewton</param>
    /// <returns>quantity measured in MegaNewton</returns>
	public static Quantity<double, MegaNewton> ToMegaNewton<T>(this BaseQuantity<T, ZettaNewton> val) where T:IConvertible {
        return new Quantity<double, MegaNewton>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaNewton to KiloNewton
    /// </summary>
    /// <param name="val">quantity measured in ZettaNewton</param>
    /// <returns>quantity measured in KiloNewton</returns>
	public static Quantity<double, KiloNewton> ToKiloNewton<T>(this BaseQuantity<T, ZettaNewton> val) where T:IConvertible {
        return new Quantity<double, KiloNewton>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaNewton to HectoNewton
    /// </summary>
    /// <param name="val">quantity measured in ZettaNewton</param>
    /// <returns>quantity measured in HectoNewton</returns>
	public static Quantity<double, HectoNewton> ToHectoNewton<T>(this BaseQuantity<T, ZettaNewton> val) where T:IConvertible {
        return new Quantity<double, HectoNewton>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaNewton to DekaNewton
    /// </summary>
    /// <param name="val">quantity measured in ZettaNewton</param>
    /// <returns>quantity measured in DekaNewton</returns>
	public static Quantity<double, DekaNewton> ToDekaNewton<T>(this BaseQuantity<T, ZettaNewton> val) where T:IConvertible {
        return new Quantity<double, DekaNewton>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaNewton to DeciNewton
    /// </summary>
    /// <param name="val">quantity measured in ZettaNewton</param>
    /// <returns>quantity measured in DeciNewton</returns>
	public static Quantity<double, DeciNewton> ToDeciNewton<T>(this BaseQuantity<T, ZettaNewton> val) where T:IConvertible {
        return new Quantity<double, DeciNewton>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaNewton to CentiNewton
    /// </summary>
    /// <param name="val">quantity measured in ZettaNewton</param>
    /// <returns>quantity measured in CentiNewton</returns>
	public static Quantity<double, CentiNewton> ToCentiNewton<T>(this BaseQuantity<T, ZettaNewton> val) where T:IConvertible {
        return new Quantity<double, CentiNewton>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaNewton to MilliNewton
    /// </summary>
    /// <param name="val">quantity measured in ZettaNewton</param>
    /// <returns>quantity measured in MilliNewton</returns>
	public static Quantity<double, MilliNewton> ToMilliNewton<T>(this BaseQuantity<T, ZettaNewton> val) where T:IConvertible {
        return new Quantity<double, MilliNewton>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaNewton to MicroNewton
    /// </summary>
    /// <param name="val">quantity measured in ZettaNewton</param>
    /// <returns>quantity measured in MicroNewton</returns>
	public static Quantity<double, MicroNewton> ToMicroNewton<T>(this BaseQuantity<T, ZettaNewton> val) where T:IConvertible {
        return new Quantity<double, MicroNewton>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaNewton to NanoNewton
    /// </summary>
    /// <param name="val">quantity measured in ZettaNewton</param>
    /// <returns>quantity measured in NanoNewton</returns>
	public static Quantity<double, NanoNewton> ToNanoNewton<T>(this BaseQuantity<T, ZettaNewton> val) where T:IConvertible {
        return new Quantity<double, NanoNewton>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaNewton to PicoNewton
    /// </summary>
    /// <param name="val">quantity measured in ZettaNewton</param>
    /// <returns>quantity measured in PicoNewton</returns>
	public static Quantity<double, PicoNewton> ToPicoNewton<T>(this BaseQuantity<T, ZettaNewton> val) where T:IConvertible {
        return new Quantity<double, PicoNewton>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaNewton to FemtoNewton
    /// </summary>
    /// <param name="val">quantity measured in ZettaNewton</param>
    /// <returns>quantity measured in FemtoNewton</returns>
	public static Quantity<double, FemtoNewton> ToFemtoNewton<T>(this BaseQuantity<T, ZettaNewton> val) where T:IConvertible {
        return new Quantity<double, FemtoNewton>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaNewton to AttoNewton
    /// </summary>
    /// <param name="val">quantity measured in ZettaNewton</param>
    /// <returns>quantity measured in AttoNewton</returns>
	public static Quantity<double, AttoNewton> ToAttoNewton<T>(this BaseQuantity<T, ZettaNewton> val) where T:IConvertible {
        return new Quantity<double, AttoNewton>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaNewton to ZeptoNewton
    /// </summary>
    /// <param name="val">quantity measured in ZettaNewton</param>
    /// <returns>quantity measured in ZeptoNewton</returns>
	public static Quantity<double, ZeptoNewton> ToZeptoNewton<T>(this BaseQuantity<T, ZettaNewton> val) where T:IConvertible {
        return new Quantity<double, ZeptoNewton>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaNewton to YoctoNewton
    /// </summary>
    /// <param name="val">quantity measured in ZettaNewton</param>
    /// <returns>quantity measured in YoctoNewton</returns>
	public static Quantity<double, YoctoNewton> ToYoctoNewton<T>(this BaseQuantity<T, ZettaNewton> val) where T:IConvertible {
        return new Quantity<double, YoctoNewton>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ExaNewton to YottaNewton
    /// </summary>
    /// <param name="val">quantity measured in ExaNewton</param>
    /// <returns>quantity measured in YottaNewton</returns>
	public static Quantity<double, YottaNewton> ToYottaNewton<T>(this BaseQuantity<T, ExaNewton> val) where T:IConvertible {
        return new Quantity<double, YottaNewton>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaNewton to ZettaNewton
    /// </summary>
    /// <param name="val">quantity measured in ExaNewton</param>
    /// <returns>quantity measured in ZettaNewton</returns>
	public static Quantity<double, ZettaNewton> ToZettaNewton<T>(this BaseQuantity<T, ExaNewton> val) where T:IConvertible {
        return new Quantity<double, ZettaNewton>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaNewton to PetaNewton
    /// </summary>
    /// <param name="val">quantity measured in ExaNewton</param>
    /// <returns>quantity measured in PetaNewton</returns>
	public static Quantity<double, PetaNewton> ToPetaNewton<T>(this BaseQuantity<T, ExaNewton> val) where T:IConvertible {
        return new Quantity<double, PetaNewton>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaNewton to TeraNewton
    /// </summary>
    /// <param name="val">quantity measured in ExaNewton</param>
    /// <returns>quantity measured in TeraNewton</returns>
	public static Quantity<double, TeraNewton> ToTeraNewton<T>(this BaseQuantity<T, ExaNewton> val) where T:IConvertible {
        return new Quantity<double, TeraNewton>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaNewton to GigaNewton
    /// </summary>
    /// <param name="val">quantity measured in ExaNewton</param>
    /// <returns>quantity measured in GigaNewton</returns>
	public static Quantity<double, GigaNewton> ToGigaNewton<T>(this BaseQuantity<T, ExaNewton> val) where T:IConvertible {
        return new Quantity<double, GigaNewton>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaNewton to MegaNewton
    /// </summary>
    /// <param name="val">quantity measured in ExaNewton</param>
    /// <returns>quantity measured in MegaNewton</returns>
	public static Quantity<double, MegaNewton> ToMegaNewton<T>(this BaseQuantity<T, ExaNewton> val) where T:IConvertible {
        return new Quantity<double, MegaNewton>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaNewton to KiloNewton
    /// </summary>
    /// <param name="val">quantity measured in ExaNewton</param>
    /// <returns>quantity measured in KiloNewton</returns>
	public static Quantity<double, KiloNewton> ToKiloNewton<T>(this BaseQuantity<T, ExaNewton> val) where T:IConvertible {
        return new Quantity<double, KiloNewton>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaNewton to HectoNewton
    /// </summary>
    /// <param name="val">quantity measured in ExaNewton</param>
    /// <returns>quantity measured in HectoNewton</returns>
	public static Quantity<double, HectoNewton> ToHectoNewton<T>(this BaseQuantity<T, ExaNewton> val) where T:IConvertible {
        return new Quantity<double, HectoNewton>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaNewton to DekaNewton
    /// </summary>
    /// <param name="val">quantity measured in ExaNewton</param>
    /// <returns>quantity measured in DekaNewton</returns>
	public static Quantity<double, DekaNewton> ToDekaNewton<T>(this BaseQuantity<T, ExaNewton> val) where T:IConvertible {
        return new Quantity<double, DekaNewton>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaNewton to DeciNewton
    /// </summary>
    /// <param name="val">quantity measured in ExaNewton</param>
    /// <returns>quantity measured in DeciNewton</returns>
	public static Quantity<double, DeciNewton> ToDeciNewton<T>(this BaseQuantity<T, ExaNewton> val) where T:IConvertible {
        return new Quantity<double, DeciNewton>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaNewton to CentiNewton
    /// </summary>
    /// <param name="val">quantity measured in ExaNewton</param>
    /// <returns>quantity measured in CentiNewton</returns>
	public static Quantity<double, CentiNewton> ToCentiNewton<T>(this BaseQuantity<T, ExaNewton> val) where T:IConvertible {
        return new Quantity<double, CentiNewton>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaNewton to MilliNewton
    /// </summary>
    /// <param name="val">quantity measured in ExaNewton</param>
    /// <returns>quantity measured in MilliNewton</returns>
	public static Quantity<double, MilliNewton> ToMilliNewton<T>(this BaseQuantity<T, ExaNewton> val) where T:IConvertible {
        return new Quantity<double, MilliNewton>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaNewton to MicroNewton
    /// </summary>
    /// <param name="val">quantity measured in ExaNewton</param>
    /// <returns>quantity measured in MicroNewton</returns>
	public static Quantity<double, MicroNewton> ToMicroNewton<T>(this BaseQuantity<T, ExaNewton> val) where T:IConvertible {
        return new Quantity<double, MicroNewton>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaNewton to NanoNewton
    /// </summary>
    /// <param name="val">quantity measured in ExaNewton</param>
    /// <returns>quantity measured in NanoNewton</returns>
	public static Quantity<double, NanoNewton> ToNanoNewton<T>(this BaseQuantity<T, ExaNewton> val) where T:IConvertible {
        return new Quantity<double, NanoNewton>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaNewton to PicoNewton
    /// </summary>
    /// <param name="val">quantity measured in ExaNewton</param>
    /// <returns>quantity measured in PicoNewton</returns>
	public static Quantity<double, PicoNewton> ToPicoNewton<T>(this BaseQuantity<T, ExaNewton> val) where T:IConvertible {
        return new Quantity<double, PicoNewton>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaNewton to FemtoNewton
    /// </summary>
    /// <param name="val">quantity measured in ExaNewton</param>
    /// <returns>quantity measured in FemtoNewton</returns>
	public static Quantity<double, FemtoNewton> ToFemtoNewton<T>(this BaseQuantity<T, ExaNewton> val) where T:IConvertible {
        return new Quantity<double, FemtoNewton>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaNewton to AttoNewton
    /// </summary>
    /// <param name="val">quantity measured in ExaNewton</param>
    /// <returns>quantity measured in AttoNewton</returns>
	public static Quantity<double, AttoNewton> ToAttoNewton<T>(this BaseQuantity<T, ExaNewton> val) where T:IConvertible {
        return new Quantity<double, AttoNewton>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaNewton to ZeptoNewton
    /// </summary>
    /// <param name="val">quantity measured in ExaNewton</param>
    /// <returns>quantity measured in ZeptoNewton</returns>
	public static Quantity<double, ZeptoNewton> ToZeptoNewton<T>(this BaseQuantity<T, ExaNewton> val) where T:IConvertible {
        return new Quantity<double, ZeptoNewton>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaNewton to YoctoNewton
    /// </summary>
    /// <param name="val">quantity measured in ExaNewton</param>
    /// <returns>quantity measured in YoctoNewton</returns>
	public static Quantity<double, YoctoNewton> ToYoctoNewton<T>(this BaseQuantity<T, ExaNewton> val) where T:IConvertible {
        return new Quantity<double, YoctoNewton>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert PetaNewton to YottaNewton
    /// </summary>
    /// <param name="val">quantity measured in PetaNewton</param>
    /// <returns>quantity measured in YottaNewton</returns>
	public static Quantity<double, YottaNewton> ToYottaNewton<T>(this BaseQuantity<T, PetaNewton> val) where T:IConvertible {
        return new Quantity<double, YottaNewton>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaNewton to ZettaNewton
    /// </summary>
    /// <param name="val">quantity measured in PetaNewton</param>
    /// <returns>quantity measured in ZettaNewton</returns>
	public static Quantity<double, ZettaNewton> ToZettaNewton<T>(this BaseQuantity<T, PetaNewton> val) where T:IConvertible {
        return new Quantity<double, ZettaNewton>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaNewton to ExaNewton
    /// </summary>
    /// <param name="val">quantity measured in PetaNewton</param>
    /// <returns>quantity measured in ExaNewton</returns>
	public static Quantity<double, ExaNewton> ToExaNewton<T>(this BaseQuantity<T, PetaNewton> val) where T:IConvertible {
        return new Quantity<double, ExaNewton>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaNewton to TeraNewton
    /// </summary>
    /// <param name="val">quantity measured in PetaNewton</param>
    /// <returns>quantity measured in TeraNewton</returns>
	public static Quantity<double, TeraNewton> ToTeraNewton<T>(this BaseQuantity<T, PetaNewton> val) where T:IConvertible {
        return new Quantity<double, TeraNewton>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaNewton to GigaNewton
    /// </summary>
    /// <param name="val">quantity measured in PetaNewton</param>
    /// <returns>quantity measured in GigaNewton</returns>
	public static Quantity<double, GigaNewton> ToGigaNewton<T>(this BaseQuantity<T, PetaNewton> val) where T:IConvertible {
        return new Quantity<double, GigaNewton>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaNewton to MegaNewton
    /// </summary>
    /// <param name="val">quantity measured in PetaNewton</param>
    /// <returns>quantity measured in MegaNewton</returns>
	public static Quantity<double, MegaNewton> ToMegaNewton<T>(this BaseQuantity<T, PetaNewton> val) where T:IConvertible {
        return new Quantity<double, MegaNewton>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaNewton to KiloNewton
    /// </summary>
    /// <param name="val">quantity measured in PetaNewton</param>
    /// <returns>quantity measured in KiloNewton</returns>
	public static Quantity<double, KiloNewton> ToKiloNewton<T>(this BaseQuantity<T, PetaNewton> val) where T:IConvertible {
        return new Quantity<double, KiloNewton>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaNewton to HectoNewton
    /// </summary>
    /// <param name="val">quantity measured in PetaNewton</param>
    /// <returns>quantity measured in HectoNewton</returns>
	public static Quantity<double, HectoNewton> ToHectoNewton<T>(this BaseQuantity<T, PetaNewton> val) where T:IConvertible {
        return new Quantity<double, HectoNewton>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaNewton to DekaNewton
    /// </summary>
    /// <param name="val">quantity measured in PetaNewton</param>
    /// <returns>quantity measured in DekaNewton</returns>
	public static Quantity<double, DekaNewton> ToDekaNewton<T>(this BaseQuantity<T, PetaNewton> val) where T:IConvertible {
        return new Quantity<double, DekaNewton>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaNewton to DeciNewton
    /// </summary>
    /// <param name="val">quantity measured in PetaNewton</param>
    /// <returns>quantity measured in DeciNewton</returns>
	public static Quantity<double, DeciNewton> ToDeciNewton<T>(this BaseQuantity<T, PetaNewton> val) where T:IConvertible {
        return new Quantity<double, DeciNewton>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaNewton to CentiNewton
    /// </summary>
    /// <param name="val">quantity measured in PetaNewton</param>
    /// <returns>quantity measured in CentiNewton</returns>
	public static Quantity<double, CentiNewton> ToCentiNewton<T>(this BaseQuantity<T, PetaNewton> val) where T:IConvertible {
        return new Quantity<double, CentiNewton>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaNewton to MilliNewton
    /// </summary>
    /// <param name="val">quantity measured in PetaNewton</param>
    /// <returns>quantity measured in MilliNewton</returns>
	public static Quantity<double, MilliNewton> ToMilliNewton<T>(this BaseQuantity<T, PetaNewton> val) where T:IConvertible {
        return new Quantity<double, MilliNewton>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaNewton to MicroNewton
    /// </summary>
    /// <param name="val">quantity measured in PetaNewton</param>
    /// <returns>quantity measured in MicroNewton</returns>
	public static Quantity<double, MicroNewton> ToMicroNewton<T>(this BaseQuantity<T, PetaNewton> val) where T:IConvertible {
        return new Quantity<double, MicroNewton>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaNewton to NanoNewton
    /// </summary>
    /// <param name="val">quantity measured in PetaNewton</param>
    /// <returns>quantity measured in NanoNewton</returns>
	public static Quantity<double, NanoNewton> ToNanoNewton<T>(this BaseQuantity<T, PetaNewton> val) where T:IConvertible {
        return new Quantity<double, NanoNewton>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaNewton to PicoNewton
    /// </summary>
    /// <param name="val">quantity measured in PetaNewton</param>
    /// <returns>quantity measured in PicoNewton</returns>
	public static Quantity<double, PicoNewton> ToPicoNewton<T>(this BaseQuantity<T, PetaNewton> val) where T:IConvertible {
        return new Quantity<double, PicoNewton>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaNewton to FemtoNewton
    /// </summary>
    /// <param name="val">quantity measured in PetaNewton</param>
    /// <returns>quantity measured in FemtoNewton</returns>
	public static Quantity<double, FemtoNewton> ToFemtoNewton<T>(this BaseQuantity<T, PetaNewton> val) where T:IConvertible {
        return new Quantity<double, FemtoNewton>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaNewton to AttoNewton
    /// </summary>
    /// <param name="val">quantity measured in PetaNewton</param>
    /// <returns>quantity measured in AttoNewton</returns>
	public static Quantity<double, AttoNewton> ToAttoNewton<T>(this BaseQuantity<T, PetaNewton> val) where T:IConvertible {
        return new Quantity<double, AttoNewton>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaNewton to ZeptoNewton
    /// </summary>
    /// <param name="val">quantity measured in PetaNewton</param>
    /// <returns>quantity measured in ZeptoNewton</returns>
	public static Quantity<double, ZeptoNewton> ToZeptoNewton<T>(this BaseQuantity<T, PetaNewton> val) where T:IConvertible {
        return new Quantity<double, ZeptoNewton>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaNewton to YoctoNewton
    /// </summary>
    /// <param name="val">quantity measured in PetaNewton</param>
    /// <returns>quantity measured in YoctoNewton</returns>
	public static Quantity<double, YoctoNewton> ToYoctoNewton<T>(this BaseQuantity<T, PetaNewton> val) where T:IConvertible {
        return new Quantity<double, YoctoNewton>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert TeraNewton to YottaNewton
    /// </summary>
    /// <param name="val">quantity measured in TeraNewton</param>
    /// <returns>quantity measured in YottaNewton</returns>
	public static Quantity<double, YottaNewton> ToYottaNewton<T>(this BaseQuantity<T, TeraNewton> val) where T:IConvertible {
        return new Quantity<double, YottaNewton>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraNewton to ZettaNewton
    /// </summary>
    /// <param name="val">quantity measured in TeraNewton</param>
    /// <returns>quantity measured in ZettaNewton</returns>
	public static Quantity<double, ZettaNewton> ToZettaNewton<T>(this BaseQuantity<T, TeraNewton> val) where T:IConvertible {
        return new Quantity<double, ZettaNewton>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraNewton to ExaNewton
    /// </summary>
    /// <param name="val">quantity measured in TeraNewton</param>
    /// <returns>quantity measured in ExaNewton</returns>
	public static Quantity<double, ExaNewton> ToExaNewton<T>(this BaseQuantity<T, TeraNewton> val) where T:IConvertible {
        return new Quantity<double, ExaNewton>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraNewton to PetaNewton
    /// </summary>
    /// <param name="val">quantity measured in TeraNewton</param>
    /// <returns>quantity measured in PetaNewton</returns>
	public static Quantity<double, PetaNewton> ToPetaNewton<T>(this BaseQuantity<T, TeraNewton> val) where T:IConvertible {
        return new Quantity<double, PetaNewton>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraNewton to GigaNewton
    /// </summary>
    /// <param name="val">quantity measured in TeraNewton</param>
    /// <returns>quantity measured in GigaNewton</returns>
	public static Quantity<double, GigaNewton> ToGigaNewton<T>(this BaseQuantity<T, TeraNewton> val) where T:IConvertible {
        return new Quantity<double, GigaNewton>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraNewton to MegaNewton
    /// </summary>
    /// <param name="val">quantity measured in TeraNewton</param>
    /// <returns>quantity measured in MegaNewton</returns>
	public static Quantity<double, MegaNewton> ToMegaNewton<T>(this BaseQuantity<T, TeraNewton> val) where T:IConvertible {
        return new Quantity<double, MegaNewton>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraNewton to KiloNewton
    /// </summary>
    /// <param name="val">quantity measured in TeraNewton</param>
    /// <returns>quantity measured in KiloNewton</returns>
	public static Quantity<double, KiloNewton> ToKiloNewton<T>(this BaseQuantity<T, TeraNewton> val) where T:IConvertible {
        return new Quantity<double, KiloNewton>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraNewton to HectoNewton
    /// </summary>
    /// <param name="val">quantity measured in TeraNewton</param>
    /// <returns>quantity measured in HectoNewton</returns>
	public static Quantity<double, HectoNewton> ToHectoNewton<T>(this BaseQuantity<T, TeraNewton> val) where T:IConvertible {
        return new Quantity<double, HectoNewton>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraNewton to DekaNewton
    /// </summary>
    /// <param name="val">quantity measured in TeraNewton</param>
    /// <returns>quantity measured in DekaNewton</returns>
	public static Quantity<double, DekaNewton> ToDekaNewton<T>(this BaseQuantity<T, TeraNewton> val) where T:IConvertible {
        return new Quantity<double, DekaNewton>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraNewton to DeciNewton
    /// </summary>
    /// <param name="val">quantity measured in TeraNewton</param>
    /// <returns>quantity measured in DeciNewton</returns>
	public static Quantity<double, DeciNewton> ToDeciNewton<T>(this BaseQuantity<T, TeraNewton> val) where T:IConvertible {
        return new Quantity<double, DeciNewton>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraNewton to CentiNewton
    /// </summary>
    /// <param name="val">quantity measured in TeraNewton</param>
    /// <returns>quantity measured in CentiNewton</returns>
	public static Quantity<double, CentiNewton> ToCentiNewton<T>(this BaseQuantity<T, TeraNewton> val) where T:IConvertible {
        return new Quantity<double, CentiNewton>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraNewton to MilliNewton
    /// </summary>
    /// <param name="val">quantity measured in TeraNewton</param>
    /// <returns>quantity measured in MilliNewton</returns>
	public static Quantity<double, MilliNewton> ToMilliNewton<T>(this BaseQuantity<T, TeraNewton> val) where T:IConvertible {
        return new Quantity<double, MilliNewton>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraNewton to MicroNewton
    /// </summary>
    /// <param name="val">quantity measured in TeraNewton</param>
    /// <returns>quantity measured in MicroNewton</returns>
	public static Quantity<double, MicroNewton> ToMicroNewton<T>(this BaseQuantity<T, TeraNewton> val) where T:IConvertible {
        return new Quantity<double, MicroNewton>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraNewton to NanoNewton
    /// </summary>
    /// <param name="val">quantity measured in TeraNewton</param>
    /// <returns>quantity measured in NanoNewton</returns>
	public static Quantity<double, NanoNewton> ToNanoNewton<T>(this BaseQuantity<T, TeraNewton> val) where T:IConvertible {
        return new Quantity<double, NanoNewton>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraNewton to PicoNewton
    /// </summary>
    /// <param name="val">quantity measured in TeraNewton</param>
    /// <returns>quantity measured in PicoNewton</returns>
	public static Quantity<double, PicoNewton> ToPicoNewton<T>(this BaseQuantity<T, TeraNewton> val) where T:IConvertible {
        return new Quantity<double, PicoNewton>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraNewton to FemtoNewton
    /// </summary>
    /// <param name="val">quantity measured in TeraNewton</param>
    /// <returns>quantity measured in FemtoNewton</returns>
	public static Quantity<double, FemtoNewton> ToFemtoNewton<T>(this BaseQuantity<T, TeraNewton> val) where T:IConvertible {
        return new Quantity<double, FemtoNewton>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraNewton to AttoNewton
    /// </summary>
    /// <param name="val">quantity measured in TeraNewton</param>
    /// <returns>quantity measured in AttoNewton</returns>
	public static Quantity<double, AttoNewton> ToAttoNewton<T>(this BaseQuantity<T, TeraNewton> val) where T:IConvertible {
        return new Quantity<double, AttoNewton>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraNewton to ZeptoNewton
    /// </summary>
    /// <param name="val">quantity measured in TeraNewton</param>
    /// <returns>quantity measured in ZeptoNewton</returns>
	public static Quantity<double, ZeptoNewton> ToZeptoNewton<T>(this BaseQuantity<T, TeraNewton> val) where T:IConvertible {
        return new Quantity<double, ZeptoNewton>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraNewton to YoctoNewton
    /// </summary>
    /// <param name="val">quantity measured in TeraNewton</param>
    /// <returns>quantity measured in YoctoNewton</returns>
	public static Quantity<double, YoctoNewton> ToYoctoNewton<T>(this BaseQuantity<T, TeraNewton> val) where T:IConvertible {
        return new Quantity<double, YoctoNewton>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert GigaNewton to YottaNewton
    /// </summary>
    /// <param name="val">quantity measured in GigaNewton</param>
    /// <returns>quantity measured in YottaNewton</returns>
	public static Quantity<double, YottaNewton> ToYottaNewton<T>(this BaseQuantity<T, GigaNewton> val) where T:IConvertible {
        return new Quantity<double, YottaNewton>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaNewton to ZettaNewton
    /// </summary>
    /// <param name="val">quantity measured in GigaNewton</param>
    /// <returns>quantity measured in ZettaNewton</returns>
	public static Quantity<double, ZettaNewton> ToZettaNewton<T>(this BaseQuantity<T, GigaNewton> val) where T:IConvertible {
        return new Quantity<double, ZettaNewton>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaNewton to ExaNewton
    /// </summary>
    /// <param name="val">quantity measured in GigaNewton</param>
    /// <returns>quantity measured in ExaNewton</returns>
	public static Quantity<double, ExaNewton> ToExaNewton<T>(this BaseQuantity<T, GigaNewton> val) where T:IConvertible {
        return new Quantity<double, ExaNewton>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaNewton to PetaNewton
    /// </summary>
    /// <param name="val">quantity measured in GigaNewton</param>
    /// <returns>quantity measured in PetaNewton</returns>
	public static Quantity<double, PetaNewton> ToPetaNewton<T>(this BaseQuantity<T, GigaNewton> val) where T:IConvertible {
        return new Quantity<double, PetaNewton>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaNewton to TeraNewton
    /// </summary>
    /// <param name="val">quantity measured in GigaNewton</param>
    /// <returns>quantity measured in TeraNewton</returns>
	public static Quantity<double, TeraNewton> ToTeraNewton<T>(this BaseQuantity<T, GigaNewton> val) where T:IConvertible {
        return new Quantity<double, TeraNewton>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaNewton to MegaNewton
    /// </summary>
    /// <param name="val">quantity measured in GigaNewton</param>
    /// <returns>quantity measured in MegaNewton</returns>
	public static Quantity<double, MegaNewton> ToMegaNewton<T>(this BaseQuantity<T, GigaNewton> val) where T:IConvertible {
        return new Quantity<double, MegaNewton>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaNewton to KiloNewton
    /// </summary>
    /// <param name="val">quantity measured in GigaNewton</param>
    /// <returns>quantity measured in KiloNewton</returns>
	public static Quantity<double, KiloNewton> ToKiloNewton<T>(this BaseQuantity<T, GigaNewton> val) where T:IConvertible {
        return new Quantity<double, KiloNewton>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaNewton to HectoNewton
    /// </summary>
    /// <param name="val">quantity measured in GigaNewton</param>
    /// <returns>quantity measured in HectoNewton</returns>
	public static Quantity<double, HectoNewton> ToHectoNewton<T>(this BaseQuantity<T, GigaNewton> val) where T:IConvertible {
        return new Quantity<double, HectoNewton>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaNewton to DekaNewton
    /// </summary>
    /// <param name="val">quantity measured in GigaNewton</param>
    /// <returns>quantity measured in DekaNewton</returns>
	public static Quantity<double, DekaNewton> ToDekaNewton<T>(this BaseQuantity<T, GigaNewton> val) where T:IConvertible {
        return new Quantity<double, DekaNewton>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaNewton to DeciNewton
    /// </summary>
    /// <param name="val">quantity measured in GigaNewton</param>
    /// <returns>quantity measured in DeciNewton</returns>
	public static Quantity<double, DeciNewton> ToDeciNewton<T>(this BaseQuantity<T, GigaNewton> val) where T:IConvertible {
        return new Quantity<double, DeciNewton>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaNewton to CentiNewton
    /// </summary>
    /// <param name="val">quantity measured in GigaNewton</param>
    /// <returns>quantity measured in CentiNewton</returns>
	public static Quantity<double, CentiNewton> ToCentiNewton<T>(this BaseQuantity<T, GigaNewton> val) where T:IConvertible {
        return new Quantity<double, CentiNewton>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaNewton to MilliNewton
    /// </summary>
    /// <param name="val">quantity measured in GigaNewton</param>
    /// <returns>quantity measured in MilliNewton</returns>
	public static Quantity<double, MilliNewton> ToMilliNewton<T>(this BaseQuantity<T, GigaNewton> val) where T:IConvertible {
        return new Quantity<double, MilliNewton>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaNewton to MicroNewton
    /// </summary>
    /// <param name="val">quantity measured in GigaNewton</param>
    /// <returns>quantity measured in MicroNewton</returns>
	public static Quantity<double, MicroNewton> ToMicroNewton<T>(this BaseQuantity<T, GigaNewton> val) where T:IConvertible {
        return new Quantity<double, MicroNewton>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaNewton to NanoNewton
    /// </summary>
    /// <param name="val">quantity measured in GigaNewton</param>
    /// <returns>quantity measured in NanoNewton</returns>
	public static Quantity<double, NanoNewton> ToNanoNewton<T>(this BaseQuantity<T, GigaNewton> val) where T:IConvertible {
        return new Quantity<double, NanoNewton>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaNewton to PicoNewton
    /// </summary>
    /// <param name="val">quantity measured in GigaNewton</param>
    /// <returns>quantity measured in PicoNewton</returns>
	public static Quantity<double, PicoNewton> ToPicoNewton<T>(this BaseQuantity<T, GigaNewton> val) where T:IConvertible {
        return new Quantity<double, PicoNewton>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaNewton to FemtoNewton
    /// </summary>
    /// <param name="val">quantity measured in GigaNewton</param>
    /// <returns>quantity measured in FemtoNewton</returns>
	public static Quantity<double, FemtoNewton> ToFemtoNewton<T>(this BaseQuantity<T, GigaNewton> val) where T:IConvertible {
        return new Quantity<double, FemtoNewton>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaNewton to AttoNewton
    /// </summary>
    /// <param name="val">quantity measured in GigaNewton</param>
    /// <returns>quantity measured in AttoNewton</returns>
	public static Quantity<double, AttoNewton> ToAttoNewton<T>(this BaseQuantity<T, GigaNewton> val) where T:IConvertible {
        return new Quantity<double, AttoNewton>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaNewton to ZeptoNewton
    /// </summary>
    /// <param name="val">quantity measured in GigaNewton</param>
    /// <returns>quantity measured in ZeptoNewton</returns>
	public static Quantity<double, ZeptoNewton> ToZeptoNewton<T>(this BaseQuantity<T, GigaNewton> val) where T:IConvertible {
        return new Quantity<double, ZeptoNewton>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaNewton to YoctoNewton
    /// </summary>
    /// <param name="val">quantity measured in GigaNewton</param>
    /// <returns>quantity measured in YoctoNewton</returns>
	public static Quantity<double, YoctoNewton> ToYoctoNewton<T>(this BaseQuantity<T, GigaNewton> val) where T:IConvertible {
        return new Quantity<double, YoctoNewton>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert MegaNewton to YottaNewton
    /// </summary>
    /// <param name="val">quantity measured in MegaNewton</param>
    /// <returns>quantity measured in YottaNewton</returns>
	public static Quantity<double, YottaNewton> ToYottaNewton<T>(this BaseQuantity<T, MegaNewton> val) where T:IConvertible {
        return new Quantity<double, YottaNewton>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaNewton to ZettaNewton
    /// </summary>
    /// <param name="val">quantity measured in MegaNewton</param>
    /// <returns>quantity measured in ZettaNewton</returns>
	public static Quantity<double, ZettaNewton> ToZettaNewton<T>(this BaseQuantity<T, MegaNewton> val) where T:IConvertible {
        return new Quantity<double, ZettaNewton>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaNewton to ExaNewton
    /// </summary>
    /// <param name="val">quantity measured in MegaNewton</param>
    /// <returns>quantity measured in ExaNewton</returns>
	public static Quantity<double, ExaNewton> ToExaNewton<T>(this BaseQuantity<T, MegaNewton> val) where T:IConvertible {
        return new Quantity<double, ExaNewton>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaNewton to PetaNewton
    /// </summary>
    /// <param name="val">quantity measured in MegaNewton</param>
    /// <returns>quantity measured in PetaNewton</returns>
	public static Quantity<double, PetaNewton> ToPetaNewton<T>(this BaseQuantity<T, MegaNewton> val) where T:IConvertible {
        return new Quantity<double, PetaNewton>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaNewton to TeraNewton
    /// </summary>
    /// <param name="val">quantity measured in MegaNewton</param>
    /// <returns>quantity measured in TeraNewton</returns>
	public static Quantity<double, TeraNewton> ToTeraNewton<T>(this BaseQuantity<T, MegaNewton> val) where T:IConvertible {
        return new Quantity<double, TeraNewton>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaNewton to GigaNewton
    /// </summary>
    /// <param name="val">quantity measured in MegaNewton</param>
    /// <returns>quantity measured in GigaNewton</returns>
	public static Quantity<double, GigaNewton> ToGigaNewton<T>(this BaseQuantity<T, MegaNewton> val) where T:IConvertible {
        return new Quantity<double, GigaNewton>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaNewton to KiloNewton
    /// </summary>
    /// <param name="val">quantity measured in MegaNewton</param>
    /// <returns>quantity measured in KiloNewton</returns>
	public static Quantity<double, KiloNewton> ToKiloNewton<T>(this BaseQuantity<T, MegaNewton> val) where T:IConvertible {
        return new Quantity<double, KiloNewton>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaNewton to HectoNewton
    /// </summary>
    /// <param name="val">quantity measured in MegaNewton</param>
    /// <returns>quantity measured in HectoNewton</returns>
	public static Quantity<double, HectoNewton> ToHectoNewton<T>(this BaseQuantity<T, MegaNewton> val) where T:IConvertible {
        return new Quantity<double, HectoNewton>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaNewton to DekaNewton
    /// </summary>
    /// <param name="val">quantity measured in MegaNewton</param>
    /// <returns>quantity measured in DekaNewton</returns>
	public static Quantity<double, DekaNewton> ToDekaNewton<T>(this BaseQuantity<T, MegaNewton> val) where T:IConvertible {
        return new Quantity<double, DekaNewton>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaNewton to DeciNewton
    /// </summary>
    /// <param name="val">quantity measured in MegaNewton</param>
    /// <returns>quantity measured in DeciNewton</returns>
	public static Quantity<double, DeciNewton> ToDeciNewton<T>(this BaseQuantity<T, MegaNewton> val) where T:IConvertible {
        return new Quantity<double, DeciNewton>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaNewton to CentiNewton
    /// </summary>
    /// <param name="val">quantity measured in MegaNewton</param>
    /// <returns>quantity measured in CentiNewton</returns>
	public static Quantity<double, CentiNewton> ToCentiNewton<T>(this BaseQuantity<T, MegaNewton> val) where T:IConvertible {
        return new Quantity<double, CentiNewton>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaNewton to MilliNewton
    /// </summary>
    /// <param name="val">quantity measured in MegaNewton</param>
    /// <returns>quantity measured in MilliNewton</returns>
	public static Quantity<double, MilliNewton> ToMilliNewton<T>(this BaseQuantity<T, MegaNewton> val) where T:IConvertible {
        return new Quantity<double, MilliNewton>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaNewton to MicroNewton
    /// </summary>
    /// <param name="val">quantity measured in MegaNewton</param>
    /// <returns>quantity measured in MicroNewton</returns>
	public static Quantity<double, MicroNewton> ToMicroNewton<T>(this BaseQuantity<T, MegaNewton> val) where T:IConvertible {
        return new Quantity<double, MicroNewton>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaNewton to NanoNewton
    /// </summary>
    /// <param name="val">quantity measured in MegaNewton</param>
    /// <returns>quantity measured in NanoNewton</returns>
	public static Quantity<double, NanoNewton> ToNanoNewton<T>(this BaseQuantity<T, MegaNewton> val) where T:IConvertible {
        return new Quantity<double, NanoNewton>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaNewton to PicoNewton
    /// </summary>
    /// <param name="val">quantity measured in MegaNewton</param>
    /// <returns>quantity measured in PicoNewton</returns>
	public static Quantity<double, PicoNewton> ToPicoNewton<T>(this BaseQuantity<T, MegaNewton> val) where T:IConvertible {
        return new Quantity<double, PicoNewton>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaNewton to FemtoNewton
    /// </summary>
    /// <param name="val">quantity measured in MegaNewton</param>
    /// <returns>quantity measured in FemtoNewton</returns>
	public static Quantity<double, FemtoNewton> ToFemtoNewton<T>(this BaseQuantity<T, MegaNewton> val) where T:IConvertible {
        return new Quantity<double, FemtoNewton>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaNewton to AttoNewton
    /// </summary>
    /// <param name="val">quantity measured in MegaNewton</param>
    /// <returns>quantity measured in AttoNewton</returns>
	public static Quantity<double, AttoNewton> ToAttoNewton<T>(this BaseQuantity<T, MegaNewton> val) where T:IConvertible {
        return new Quantity<double, AttoNewton>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaNewton to ZeptoNewton
    /// </summary>
    /// <param name="val">quantity measured in MegaNewton</param>
    /// <returns>quantity measured in ZeptoNewton</returns>
	public static Quantity<double, ZeptoNewton> ToZeptoNewton<T>(this BaseQuantity<T, MegaNewton> val) where T:IConvertible {
        return new Quantity<double, ZeptoNewton>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaNewton to YoctoNewton
    /// </summary>
    /// <param name="val">quantity measured in MegaNewton</param>
    /// <returns>quantity measured in YoctoNewton</returns>
	public static Quantity<double, YoctoNewton> ToYoctoNewton<T>(this BaseQuantity<T, MegaNewton> val) where T:IConvertible {
        return new Quantity<double, YoctoNewton>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert KiloNewton to YottaNewton
    /// </summary>
    /// <param name="val">quantity measured in KiloNewton</param>
    /// <returns>quantity measured in YottaNewton</returns>
	public static Quantity<double, YottaNewton> ToYottaNewton<T>(this BaseQuantity<T, KiloNewton> val) where T:IConvertible {
        return new Quantity<double, YottaNewton>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloNewton to ZettaNewton
    /// </summary>
    /// <param name="val">quantity measured in KiloNewton</param>
    /// <returns>quantity measured in ZettaNewton</returns>
	public static Quantity<double, ZettaNewton> ToZettaNewton<T>(this BaseQuantity<T, KiloNewton> val) where T:IConvertible {
        return new Quantity<double, ZettaNewton>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloNewton to ExaNewton
    /// </summary>
    /// <param name="val">quantity measured in KiloNewton</param>
    /// <returns>quantity measured in ExaNewton</returns>
	public static Quantity<double, ExaNewton> ToExaNewton<T>(this BaseQuantity<T, KiloNewton> val) where T:IConvertible {
        return new Quantity<double, ExaNewton>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloNewton to PetaNewton
    /// </summary>
    /// <param name="val">quantity measured in KiloNewton</param>
    /// <returns>quantity measured in PetaNewton</returns>
	public static Quantity<double, PetaNewton> ToPetaNewton<T>(this BaseQuantity<T, KiloNewton> val) where T:IConvertible {
        return new Quantity<double, PetaNewton>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloNewton to TeraNewton
    /// </summary>
    /// <param name="val">quantity measured in KiloNewton</param>
    /// <returns>quantity measured in TeraNewton</returns>
	public static Quantity<double, TeraNewton> ToTeraNewton<T>(this BaseQuantity<T, KiloNewton> val) where T:IConvertible {
        return new Quantity<double, TeraNewton>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloNewton to GigaNewton
    /// </summary>
    /// <param name="val">quantity measured in KiloNewton</param>
    /// <returns>quantity measured in GigaNewton</returns>
	public static Quantity<double, GigaNewton> ToGigaNewton<T>(this BaseQuantity<T, KiloNewton> val) where T:IConvertible {
        return new Quantity<double, GigaNewton>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloNewton to MegaNewton
    /// </summary>
    /// <param name="val">quantity measured in KiloNewton</param>
    /// <returns>quantity measured in MegaNewton</returns>
	public static Quantity<double, MegaNewton> ToMegaNewton<T>(this BaseQuantity<T, KiloNewton> val) where T:IConvertible {
        return new Quantity<double, MegaNewton>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloNewton to HectoNewton
    /// </summary>
    /// <param name="val">quantity measured in KiloNewton</param>
    /// <returns>quantity measured in HectoNewton</returns>
	public static Quantity<double, HectoNewton> ToHectoNewton<T>(this BaseQuantity<T, KiloNewton> val) where T:IConvertible {
        return new Quantity<double, HectoNewton>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloNewton to DekaNewton
    /// </summary>
    /// <param name="val">quantity measured in KiloNewton</param>
    /// <returns>quantity measured in DekaNewton</returns>
	public static Quantity<double, DekaNewton> ToDekaNewton<T>(this BaseQuantity<T, KiloNewton> val) where T:IConvertible {
        return new Quantity<double, DekaNewton>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloNewton to DeciNewton
    /// </summary>
    /// <param name="val">quantity measured in KiloNewton</param>
    /// <returns>quantity measured in DeciNewton</returns>
	public static Quantity<double, DeciNewton> ToDeciNewton<T>(this BaseQuantity<T, KiloNewton> val) where T:IConvertible {
        return new Quantity<double, DeciNewton>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloNewton to CentiNewton
    /// </summary>
    /// <param name="val">quantity measured in KiloNewton</param>
    /// <returns>quantity measured in CentiNewton</returns>
	public static Quantity<double, CentiNewton> ToCentiNewton<T>(this BaseQuantity<T, KiloNewton> val) where T:IConvertible {
        return new Quantity<double, CentiNewton>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloNewton to MilliNewton
    /// </summary>
    /// <param name="val">quantity measured in KiloNewton</param>
    /// <returns>quantity measured in MilliNewton</returns>
	public static Quantity<double, MilliNewton> ToMilliNewton<T>(this BaseQuantity<T, KiloNewton> val) where T:IConvertible {
        return new Quantity<double, MilliNewton>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloNewton to MicroNewton
    /// </summary>
    /// <param name="val">quantity measured in KiloNewton</param>
    /// <returns>quantity measured in MicroNewton</returns>
	public static Quantity<double, MicroNewton> ToMicroNewton<T>(this BaseQuantity<T, KiloNewton> val) where T:IConvertible {
        return new Quantity<double, MicroNewton>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloNewton to NanoNewton
    /// </summary>
    /// <param name="val">quantity measured in KiloNewton</param>
    /// <returns>quantity measured in NanoNewton</returns>
	public static Quantity<double, NanoNewton> ToNanoNewton<T>(this BaseQuantity<T, KiloNewton> val) where T:IConvertible {
        return new Quantity<double, NanoNewton>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloNewton to PicoNewton
    /// </summary>
    /// <param name="val">quantity measured in KiloNewton</param>
    /// <returns>quantity measured in PicoNewton</returns>
	public static Quantity<double, PicoNewton> ToPicoNewton<T>(this BaseQuantity<T, KiloNewton> val) where T:IConvertible {
        return new Quantity<double, PicoNewton>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloNewton to FemtoNewton
    /// </summary>
    /// <param name="val">quantity measured in KiloNewton</param>
    /// <returns>quantity measured in FemtoNewton</returns>
	public static Quantity<double, FemtoNewton> ToFemtoNewton<T>(this BaseQuantity<T, KiloNewton> val) where T:IConvertible {
        return new Quantity<double, FemtoNewton>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloNewton to AttoNewton
    /// </summary>
    /// <param name="val">quantity measured in KiloNewton</param>
    /// <returns>quantity measured in AttoNewton</returns>
	public static Quantity<double, AttoNewton> ToAttoNewton<T>(this BaseQuantity<T, KiloNewton> val) where T:IConvertible {
        return new Quantity<double, AttoNewton>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloNewton to ZeptoNewton
    /// </summary>
    /// <param name="val">quantity measured in KiloNewton</param>
    /// <returns>quantity measured in ZeptoNewton</returns>
	public static Quantity<double, ZeptoNewton> ToZeptoNewton<T>(this BaseQuantity<T, KiloNewton> val) where T:IConvertible {
        return new Quantity<double, ZeptoNewton>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloNewton to YoctoNewton
    /// </summary>
    /// <param name="val">quantity measured in KiloNewton</param>
    /// <returns>quantity measured in YoctoNewton</returns>
	public static Quantity<double, YoctoNewton> ToYoctoNewton<T>(this BaseQuantity<T, KiloNewton> val) where T:IConvertible {
        return new Quantity<double, YoctoNewton>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert HectoNewton to YottaNewton
    /// </summary>
    /// <param name="val">quantity measured in HectoNewton</param>
    /// <returns>quantity measured in YottaNewton</returns>
	public static Quantity<double, YottaNewton> ToYottaNewton<T>(this BaseQuantity<T, HectoNewton> val) where T:IConvertible {
        return new Quantity<double, YottaNewton>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoNewton to ZettaNewton
    /// </summary>
    /// <param name="val">quantity measured in HectoNewton</param>
    /// <returns>quantity measured in ZettaNewton</returns>
	public static Quantity<double, ZettaNewton> ToZettaNewton<T>(this BaseQuantity<T, HectoNewton> val) where T:IConvertible {
        return new Quantity<double, ZettaNewton>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoNewton to ExaNewton
    /// </summary>
    /// <param name="val">quantity measured in HectoNewton</param>
    /// <returns>quantity measured in ExaNewton</returns>
	public static Quantity<double, ExaNewton> ToExaNewton<T>(this BaseQuantity<T, HectoNewton> val) where T:IConvertible {
        return new Quantity<double, ExaNewton>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoNewton to PetaNewton
    /// </summary>
    /// <param name="val">quantity measured in HectoNewton</param>
    /// <returns>quantity measured in PetaNewton</returns>
	public static Quantity<double, PetaNewton> ToPetaNewton<T>(this BaseQuantity<T, HectoNewton> val) where T:IConvertible {
        return new Quantity<double, PetaNewton>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoNewton to TeraNewton
    /// </summary>
    /// <param name="val">quantity measured in HectoNewton</param>
    /// <returns>quantity measured in TeraNewton</returns>
	public static Quantity<double, TeraNewton> ToTeraNewton<T>(this BaseQuantity<T, HectoNewton> val) where T:IConvertible {
        return new Quantity<double, TeraNewton>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoNewton to GigaNewton
    /// </summary>
    /// <param name="val">quantity measured in HectoNewton</param>
    /// <returns>quantity measured in GigaNewton</returns>
	public static Quantity<double, GigaNewton> ToGigaNewton<T>(this BaseQuantity<T, HectoNewton> val) where T:IConvertible {
        return new Quantity<double, GigaNewton>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoNewton to MegaNewton
    /// </summary>
    /// <param name="val">quantity measured in HectoNewton</param>
    /// <returns>quantity measured in MegaNewton</returns>
	public static Quantity<double, MegaNewton> ToMegaNewton<T>(this BaseQuantity<T, HectoNewton> val) where T:IConvertible {
        return new Quantity<double, MegaNewton>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoNewton to KiloNewton
    /// </summary>
    /// <param name="val">quantity measured in HectoNewton</param>
    /// <returns>quantity measured in KiloNewton</returns>
	public static Quantity<double, KiloNewton> ToKiloNewton<T>(this BaseQuantity<T, HectoNewton> val) where T:IConvertible {
        return new Quantity<double, KiloNewton>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoNewton to DekaNewton
    /// </summary>
    /// <param name="val">quantity measured in HectoNewton</param>
    /// <returns>quantity measured in DekaNewton</returns>
	public static Quantity<double, DekaNewton> ToDekaNewton<T>(this BaseQuantity<T, HectoNewton> val) where T:IConvertible {
        return new Quantity<double, DekaNewton>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoNewton to DeciNewton
    /// </summary>
    /// <param name="val">quantity measured in HectoNewton</param>
    /// <returns>quantity measured in DeciNewton</returns>
	public static Quantity<double, DeciNewton> ToDeciNewton<T>(this BaseQuantity<T, HectoNewton> val) where T:IConvertible {
        return new Quantity<double, DeciNewton>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoNewton to CentiNewton
    /// </summary>
    /// <param name="val">quantity measured in HectoNewton</param>
    /// <returns>quantity measured in CentiNewton</returns>
	public static Quantity<double, CentiNewton> ToCentiNewton<T>(this BaseQuantity<T, HectoNewton> val) where T:IConvertible {
        return new Quantity<double, CentiNewton>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoNewton to MilliNewton
    /// </summary>
    /// <param name="val">quantity measured in HectoNewton</param>
    /// <returns>quantity measured in MilliNewton</returns>
	public static Quantity<double, MilliNewton> ToMilliNewton<T>(this BaseQuantity<T, HectoNewton> val) where T:IConvertible {
        return new Quantity<double, MilliNewton>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoNewton to MicroNewton
    /// </summary>
    /// <param name="val">quantity measured in HectoNewton</param>
    /// <returns>quantity measured in MicroNewton</returns>
	public static Quantity<double, MicroNewton> ToMicroNewton<T>(this BaseQuantity<T, HectoNewton> val) where T:IConvertible {
        return new Quantity<double, MicroNewton>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoNewton to NanoNewton
    /// </summary>
    /// <param name="val">quantity measured in HectoNewton</param>
    /// <returns>quantity measured in NanoNewton</returns>
	public static Quantity<double, NanoNewton> ToNanoNewton<T>(this BaseQuantity<T, HectoNewton> val) where T:IConvertible {
        return new Quantity<double, NanoNewton>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoNewton to PicoNewton
    /// </summary>
    /// <param name="val">quantity measured in HectoNewton</param>
    /// <returns>quantity measured in PicoNewton</returns>
	public static Quantity<double, PicoNewton> ToPicoNewton<T>(this BaseQuantity<T, HectoNewton> val) where T:IConvertible {
        return new Quantity<double, PicoNewton>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoNewton to FemtoNewton
    /// </summary>
    /// <param name="val">quantity measured in HectoNewton</param>
    /// <returns>quantity measured in FemtoNewton</returns>
	public static Quantity<double, FemtoNewton> ToFemtoNewton<T>(this BaseQuantity<T, HectoNewton> val) where T:IConvertible {
        return new Quantity<double, FemtoNewton>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoNewton to AttoNewton
    /// </summary>
    /// <param name="val">quantity measured in HectoNewton</param>
    /// <returns>quantity measured in AttoNewton</returns>
	public static Quantity<double, AttoNewton> ToAttoNewton<T>(this BaseQuantity<T, HectoNewton> val) where T:IConvertible {
        return new Quantity<double, AttoNewton>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoNewton to ZeptoNewton
    /// </summary>
    /// <param name="val">quantity measured in HectoNewton</param>
    /// <returns>quantity measured in ZeptoNewton</returns>
	public static Quantity<double, ZeptoNewton> ToZeptoNewton<T>(this BaseQuantity<T, HectoNewton> val) where T:IConvertible {
        return new Quantity<double, ZeptoNewton>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoNewton to YoctoNewton
    /// </summary>
    /// <param name="val">quantity measured in HectoNewton</param>
    /// <returns>quantity measured in YoctoNewton</returns>
	public static Quantity<double, YoctoNewton> ToYoctoNewton<T>(this BaseQuantity<T, HectoNewton> val) where T:IConvertible {
        return new Quantity<double, YoctoNewton>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert DekaNewton to YottaNewton
    /// </summary>
    /// <param name="val">quantity measured in DekaNewton</param>
    /// <returns>quantity measured in YottaNewton</returns>
	public static Quantity<double, YottaNewton> ToYottaNewton<T>(this BaseQuantity<T, DekaNewton> val) where T:IConvertible {
        return new Quantity<double, YottaNewton>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaNewton to ZettaNewton
    /// </summary>
    /// <param name="val">quantity measured in DekaNewton</param>
    /// <returns>quantity measured in ZettaNewton</returns>
	public static Quantity<double, ZettaNewton> ToZettaNewton<T>(this BaseQuantity<T, DekaNewton> val) where T:IConvertible {
        return new Quantity<double, ZettaNewton>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaNewton to ExaNewton
    /// </summary>
    /// <param name="val">quantity measured in DekaNewton</param>
    /// <returns>quantity measured in ExaNewton</returns>
	public static Quantity<double, ExaNewton> ToExaNewton<T>(this BaseQuantity<T, DekaNewton> val) where T:IConvertible {
        return new Quantity<double, ExaNewton>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaNewton to PetaNewton
    /// </summary>
    /// <param name="val">quantity measured in DekaNewton</param>
    /// <returns>quantity measured in PetaNewton</returns>
	public static Quantity<double, PetaNewton> ToPetaNewton<T>(this BaseQuantity<T, DekaNewton> val) where T:IConvertible {
        return new Quantity<double, PetaNewton>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaNewton to TeraNewton
    /// </summary>
    /// <param name="val">quantity measured in DekaNewton</param>
    /// <returns>quantity measured in TeraNewton</returns>
	public static Quantity<double, TeraNewton> ToTeraNewton<T>(this BaseQuantity<T, DekaNewton> val) where T:IConvertible {
        return new Quantity<double, TeraNewton>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaNewton to GigaNewton
    /// </summary>
    /// <param name="val">quantity measured in DekaNewton</param>
    /// <returns>quantity measured in GigaNewton</returns>
	public static Quantity<double, GigaNewton> ToGigaNewton<T>(this BaseQuantity<T, DekaNewton> val) where T:IConvertible {
        return new Quantity<double, GigaNewton>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaNewton to MegaNewton
    /// </summary>
    /// <param name="val">quantity measured in DekaNewton</param>
    /// <returns>quantity measured in MegaNewton</returns>
	public static Quantity<double, MegaNewton> ToMegaNewton<T>(this BaseQuantity<T, DekaNewton> val) where T:IConvertible {
        return new Quantity<double, MegaNewton>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaNewton to KiloNewton
    /// </summary>
    /// <param name="val">quantity measured in DekaNewton</param>
    /// <returns>quantity measured in KiloNewton</returns>
	public static Quantity<double, KiloNewton> ToKiloNewton<T>(this BaseQuantity<T, DekaNewton> val) where T:IConvertible {
        return new Quantity<double, KiloNewton>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaNewton to HectoNewton
    /// </summary>
    /// <param name="val">quantity measured in DekaNewton</param>
    /// <returns>quantity measured in HectoNewton</returns>
	public static Quantity<double, HectoNewton> ToHectoNewton<T>(this BaseQuantity<T, DekaNewton> val) where T:IConvertible {
        return new Quantity<double, HectoNewton>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaNewton to DeciNewton
    /// </summary>
    /// <param name="val">quantity measured in DekaNewton</param>
    /// <returns>quantity measured in DeciNewton</returns>
	public static Quantity<double, DeciNewton> ToDeciNewton<T>(this BaseQuantity<T, DekaNewton> val) where T:IConvertible {
        return new Quantity<double, DeciNewton>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaNewton to CentiNewton
    /// </summary>
    /// <param name="val">quantity measured in DekaNewton</param>
    /// <returns>quantity measured in CentiNewton</returns>
	public static Quantity<double, CentiNewton> ToCentiNewton<T>(this BaseQuantity<T, DekaNewton> val) where T:IConvertible {
        return new Quantity<double, CentiNewton>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaNewton to MilliNewton
    /// </summary>
    /// <param name="val">quantity measured in DekaNewton</param>
    /// <returns>quantity measured in MilliNewton</returns>
	public static Quantity<double, MilliNewton> ToMilliNewton<T>(this BaseQuantity<T, DekaNewton> val) where T:IConvertible {
        return new Quantity<double, MilliNewton>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaNewton to MicroNewton
    /// </summary>
    /// <param name="val">quantity measured in DekaNewton</param>
    /// <returns>quantity measured in MicroNewton</returns>
	public static Quantity<double, MicroNewton> ToMicroNewton<T>(this BaseQuantity<T, DekaNewton> val) where T:IConvertible {
        return new Quantity<double, MicroNewton>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaNewton to NanoNewton
    /// </summary>
    /// <param name="val">quantity measured in DekaNewton</param>
    /// <returns>quantity measured in NanoNewton</returns>
	public static Quantity<double, NanoNewton> ToNanoNewton<T>(this BaseQuantity<T, DekaNewton> val) where T:IConvertible {
        return new Quantity<double, NanoNewton>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaNewton to PicoNewton
    /// </summary>
    /// <param name="val">quantity measured in DekaNewton</param>
    /// <returns>quantity measured in PicoNewton</returns>
	public static Quantity<double, PicoNewton> ToPicoNewton<T>(this BaseQuantity<T, DekaNewton> val) where T:IConvertible {
        return new Quantity<double, PicoNewton>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaNewton to FemtoNewton
    /// </summary>
    /// <param name="val">quantity measured in DekaNewton</param>
    /// <returns>quantity measured in FemtoNewton</returns>
	public static Quantity<double, FemtoNewton> ToFemtoNewton<T>(this BaseQuantity<T, DekaNewton> val) where T:IConvertible {
        return new Quantity<double, FemtoNewton>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaNewton to AttoNewton
    /// </summary>
    /// <param name="val">quantity measured in DekaNewton</param>
    /// <returns>quantity measured in AttoNewton</returns>
	public static Quantity<double, AttoNewton> ToAttoNewton<T>(this BaseQuantity<T, DekaNewton> val) where T:IConvertible {
        return new Quantity<double, AttoNewton>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaNewton to ZeptoNewton
    /// </summary>
    /// <param name="val">quantity measured in DekaNewton</param>
    /// <returns>quantity measured in ZeptoNewton</returns>
	public static Quantity<double, ZeptoNewton> ToZeptoNewton<T>(this BaseQuantity<T, DekaNewton> val) where T:IConvertible {
        return new Quantity<double, ZeptoNewton>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaNewton to YoctoNewton
    /// </summary>
    /// <param name="val">quantity measured in DekaNewton</param>
    /// <returns>quantity measured in YoctoNewton</returns>
	public static Quantity<double, YoctoNewton> ToYoctoNewton<T>(this BaseQuantity<T, DekaNewton> val) where T:IConvertible {
        return new Quantity<double, YoctoNewton>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DeciNewton to YottaNewton
    /// </summary>
    /// <param name="val">quantity measured in DeciNewton</param>
    /// <returns>quantity measured in YottaNewton</returns>
	public static Quantity<double, YottaNewton> ToYottaNewton<T>(this BaseQuantity<T, DeciNewton> val) where T:IConvertible {
        return new Quantity<double, YottaNewton>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciNewton to ZettaNewton
    /// </summary>
    /// <param name="val">quantity measured in DeciNewton</param>
    /// <returns>quantity measured in ZettaNewton</returns>
	public static Quantity<double, ZettaNewton> ToZettaNewton<T>(this BaseQuantity<T, DeciNewton> val) where T:IConvertible {
        return new Quantity<double, ZettaNewton>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciNewton to ExaNewton
    /// </summary>
    /// <param name="val">quantity measured in DeciNewton</param>
    /// <returns>quantity measured in ExaNewton</returns>
	public static Quantity<double, ExaNewton> ToExaNewton<T>(this BaseQuantity<T, DeciNewton> val) where T:IConvertible {
        return new Quantity<double, ExaNewton>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciNewton to PetaNewton
    /// </summary>
    /// <param name="val">quantity measured in DeciNewton</param>
    /// <returns>quantity measured in PetaNewton</returns>
	public static Quantity<double, PetaNewton> ToPetaNewton<T>(this BaseQuantity<T, DeciNewton> val) where T:IConvertible {
        return new Quantity<double, PetaNewton>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciNewton to TeraNewton
    /// </summary>
    /// <param name="val">quantity measured in DeciNewton</param>
    /// <returns>quantity measured in TeraNewton</returns>
	public static Quantity<double, TeraNewton> ToTeraNewton<T>(this BaseQuantity<T, DeciNewton> val) where T:IConvertible {
        return new Quantity<double, TeraNewton>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciNewton to GigaNewton
    /// </summary>
    /// <param name="val">quantity measured in DeciNewton</param>
    /// <returns>quantity measured in GigaNewton</returns>
	public static Quantity<double, GigaNewton> ToGigaNewton<T>(this BaseQuantity<T, DeciNewton> val) where T:IConvertible {
        return new Quantity<double, GigaNewton>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciNewton to MegaNewton
    /// </summary>
    /// <param name="val">quantity measured in DeciNewton</param>
    /// <returns>quantity measured in MegaNewton</returns>
	public static Quantity<double, MegaNewton> ToMegaNewton<T>(this BaseQuantity<T, DeciNewton> val) where T:IConvertible {
        return new Quantity<double, MegaNewton>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciNewton to KiloNewton
    /// </summary>
    /// <param name="val">quantity measured in DeciNewton</param>
    /// <returns>quantity measured in KiloNewton</returns>
	public static Quantity<double, KiloNewton> ToKiloNewton<T>(this BaseQuantity<T, DeciNewton> val) where T:IConvertible {
        return new Quantity<double, KiloNewton>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciNewton to HectoNewton
    /// </summary>
    /// <param name="val">quantity measured in DeciNewton</param>
    /// <returns>quantity measured in HectoNewton</returns>
	public static Quantity<double, HectoNewton> ToHectoNewton<T>(this BaseQuantity<T, DeciNewton> val) where T:IConvertible {
        return new Quantity<double, HectoNewton>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciNewton to DekaNewton
    /// </summary>
    /// <param name="val">quantity measured in DeciNewton</param>
    /// <returns>quantity measured in DekaNewton</returns>
	public static Quantity<double, DekaNewton> ToDekaNewton<T>(this BaseQuantity<T, DeciNewton> val) where T:IConvertible {
        return new Quantity<double, DekaNewton>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciNewton to CentiNewton
    /// </summary>
    /// <param name="val">quantity measured in DeciNewton</param>
    /// <returns>quantity measured in CentiNewton</returns>
	public static Quantity<double, CentiNewton> ToCentiNewton<T>(this BaseQuantity<T, DeciNewton> val) where T:IConvertible {
        return new Quantity<double, CentiNewton>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciNewton to MilliNewton
    /// </summary>
    /// <param name="val">quantity measured in DeciNewton</param>
    /// <returns>quantity measured in MilliNewton</returns>
	public static Quantity<double, MilliNewton> ToMilliNewton<T>(this BaseQuantity<T, DeciNewton> val) where T:IConvertible {
        return new Quantity<double, MilliNewton>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciNewton to MicroNewton
    /// </summary>
    /// <param name="val">quantity measured in DeciNewton</param>
    /// <returns>quantity measured in MicroNewton</returns>
	public static Quantity<double, MicroNewton> ToMicroNewton<T>(this BaseQuantity<T, DeciNewton> val) where T:IConvertible {
        return new Quantity<double, MicroNewton>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciNewton to NanoNewton
    /// </summary>
    /// <param name="val">quantity measured in DeciNewton</param>
    /// <returns>quantity measured in NanoNewton</returns>
	public static Quantity<double, NanoNewton> ToNanoNewton<T>(this BaseQuantity<T, DeciNewton> val) where T:IConvertible {
        return new Quantity<double, NanoNewton>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciNewton to PicoNewton
    /// </summary>
    /// <param name="val">quantity measured in DeciNewton</param>
    /// <returns>quantity measured in PicoNewton</returns>
	public static Quantity<double, PicoNewton> ToPicoNewton<T>(this BaseQuantity<T, DeciNewton> val) where T:IConvertible {
        return new Quantity<double, PicoNewton>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciNewton to FemtoNewton
    /// </summary>
    /// <param name="val">quantity measured in DeciNewton</param>
    /// <returns>quantity measured in FemtoNewton</returns>
	public static Quantity<double, FemtoNewton> ToFemtoNewton<T>(this BaseQuantity<T, DeciNewton> val) where T:IConvertible {
        return new Quantity<double, FemtoNewton>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciNewton to AttoNewton
    /// </summary>
    /// <param name="val">quantity measured in DeciNewton</param>
    /// <returns>quantity measured in AttoNewton</returns>
	public static Quantity<double, AttoNewton> ToAttoNewton<T>(this BaseQuantity<T, DeciNewton> val) where T:IConvertible {
        return new Quantity<double, AttoNewton>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciNewton to ZeptoNewton
    /// </summary>
    /// <param name="val">quantity measured in DeciNewton</param>
    /// <returns>quantity measured in ZeptoNewton</returns>
	public static Quantity<double, ZeptoNewton> ToZeptoNewton<T>(this BaseQuantity<T, DeciNewton> val) where T:IConvertible {
        return new Quantity<double, ZeptoNewton>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciNewton to YoctoNewton
    /// </summary>
    /// <param name="val">quantity measured in DeciNewton</param>
    /// <returns>quantity measured in YoctoNewton</returns>
	public static Quantity<double, YoctoNewton> ToYoctoNewton<T>(this BaseQuantity<T, DeciNewton> val) where T:IConvertible {
        return new Quantity<double, YoctoNewton>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert CentiNewton to YottaNewton
    /// </summary>
    /// <param name="val">quantity measured in CentiNewton</param>
    /// <returns>quantity measured in YottaNewton</returns>
	public static Quantity<double, YottaNewton> ToYottaNewton<T>(this BaseQuantity<T, CentiNewton> val) where T:IConvertible {
        return new Quantity<double, YottaNewton>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiNewton to ZettaNewton
    /// </summary>
    /// <param name="val">quantity measured in CentiNewton</param>
    /// <returns>quantity measured in ZettaNewton</returns>
	public static Quantity<double, ZettaNewton> ToZettaNewton<T>(this BaseQuantity<T, CentiNewton> val) where T:IConvertible {
        return new Quantity<double, ZettaNewton>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiNewton to ExaNewton
    /// </summary>
    /// <param name="val">quantity measured in CentiNewton</param>
    /// <returns>quantity measured in ExaNewton</returns>
	public static Quantity<double, ExaNewton> ToExaNewton<T>(this BaseQuantity<T, CentiNewton> val) where T:IConvertible {
        return new Quantity<double, ExaNewton>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiNewton to PetaNewton
    /// </summary>
    /// <param name="val">quantity measured in CentiNewton</param>
    /// <returns>quantity measured in PetaNewton</returns>
	public static Quantity<double, PetaNewton> ToPetaNewton<T>(this BaseQuantity<T, CentiNewton> val) where T:IConvertible {
        return new Quantity<double, PetaNewton>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiNewton to TeraNewton
    /// </summary>
    /// <param name="val">quantity measured in CentiNewton</param>
    /// <returns>quantity measured in TeraNewton</returns>
	public static Quantity<double, TeraNewton> ToTeraNewton<T>(this BaseQuantity<T, CentiNewton> val) where T:IConvertible {
        return new Quantity<double, TeraNewton>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiNewton to GigaNewton
    /// </summary>
    /// <param name="val">quantity measured in CentiNewton</param>
    /// <returns>quantity measured in GigaNewton</returns>
	public static Quantity<double, GigaNewton> ToGigaNewton<T>(this BaseQuantity<T, CentiNewton> val) where T:IConvertible {
        return new Quantity<double, GigaNewton>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiNewton to MegaNewton
    /// </summary>
    /// <param name="val">quantity measured in CentiNewton</param>
    /// <returns>quantity measured in MegaNewton</returns>
	public static Quantity<double, MegaNewton> ToMegaNewton<T>(this BaseQuantity<T, CentiNewton> val) where T:IConvertible {
        return new Quantity<double, MegaNewton>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiNewton to KiloNewton
    /// </summary>
    /// <param name="val">quantity measured in CentiNewton</param>
    /// <returns>quantity measured in KiloNewton</returns>
	public static Quantity<double, KiloNewton> ToKiloNewton<T>(this BaseQuantity<T, CentiNewton> val) where T:IConvertible {
        return new Quantity<double, KiloNewton>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiNewton to HectoNewton
    /// </summary>
    /// <param name="val">quantity measured in CentiNewton</param>
    /// <returns>quantity measured in HectoNewton</returns>
	public static Quantity<double, HectoNewton> ToHectoNewton<T>(this BaseQuantity<T, CentiNewton> val) where T:IConvertible {
        return new Quantity<double, HectoNewton>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiNewton to DekaNewton
    /// </summary>
    /// <param name="val">quantity measured in CentiNewton</param>
    /// <returns>quantity measured in DekaNewton</returns>
	public static Quantity<double, DekaNewton> ToDekaNewton<T>(this BaseQuantity<T, CentiNewton> val) where T:IConvertible {
        return new Quantity<double, DekaNewton>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiNewton to DeciNewton
    /// </summary>
    /// <param name="val">quantity measured in CentiNewton</param>
    /// <returns>quantity measured in DeciNewton</returns>
	public static Quantity<double, DeciNewton> ToDeciNewton<T>(this BaseQuantity<T, CentiNewton> val) where T:IConvertible {
        return new Quantity<double, DeciNewton>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiNewton to MilliNewton
    /// </summary>
    /// <param name="val">quantity measured in CentiNewton</param>
    /// <returns>quantity measured in MilliNewton</returns>
	public static Quantity<double, MilliNewton> ToMilliNewton<T>(this BaseQuantity<T, CentiNewton> val) where T:IConvertible {
        return new Quantity<double, MilliNewton>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiNewton to MicroNewton
    /// </summary>
    /// <param name="val">quantity measured in CentiNewton</param>
    /// <returns>quantity measured in MicroNewton</returns>
	public static Quantity<double, MicroNewton> ToMicroNewton<T>(this BaseQuantity<T, CentiNewton> val) where T:IConvertible {
        return new Quantity<double, MicroNewton>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiNewton to NanoNewton
    /// </summary>
    /// <param name="val">quantity measured in CentiNewton</param>
    /// <returns>quantity measured in NanoNewton</returns>
	public static Quantity<double, NanoNewton> ToNanoNewton<T>(this BaseQuantity<T, CentiNewton> val) where T:IConvertible {
        return new Quantity<double, NanoNewton>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiNewton to PicoNewton
    /// </summary>
    /// <param name="val">quantity measured in CentiNewton</param>
    /// <returns>quantity measured in PicoNewton</returns>
	public static Quantity<double, PicoNewton> ToPicoNewton<T>(this BaseQuantity<T, CentiNewton> val) where T:IConvertible {
        return new Quantity<double, PicoNewton>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiNewton to FemtoNewton
    /// </summary>
    /// <param name="val">quantity measured in CentiNewton</param>
    /// <returns>quantity measured in FemtoNewton</returns>
	public static Quantity<double, FemtoNewton> ToFemtoNewton<T>(this BaseQuantity<T, CentiNewton> val) where T:IConvertible {
        return new Quantity<double, FemtoNewton>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiNewton to AttoNewton
    /// </summary>
    /// <param name="val">quantity measured in CentiNewton</param>
    /// <returns>quantity measured in AttoNewton</returns>
	public static Quantity<double, AttoNewton> ToAttoNewton<T>(this BaseQuantity<T, CentiNewton> val) where T:IConvertible {
        return new Quantity<double, AttoNewton>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiNewton to ZeptoNewton
    /// </summary>
    /// <param name="val">quantity measured in CentiNewton</param>
    /// <returns>quantity measured in ZeptoNewton</returns>
	public static Quantity<double, ZeptoNewton> ToZeptoNewton<T>(this BaseQuantity<T, CentiNewton> val) where T:IConvertible {
        return new Quantity<double, ZeptoNewton>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiNewton to YoctoNewton
    /// </summary>
    /// <param name="val">quantity measured in CentiNewton</param>
    /// <returns>quantity measured in YoctoNewton</returns>
	public static Quantity<double, YoctoNewton> ToYoctoNewton<T>(this BaseQuantity<T, CentiNewton> val) where T:IConvertible {
        return new Quantity<double, YoctoNewton>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert MilliNewton to YottaNewton
    /// </summary>
    /// <param name="val">quantity measured in MilliNewton</param>
    /// <returns>quantity measured in YottaNewton</returns>
	public static Quantity<double, YottaNewton> ToYottaNewton<T>(this BaseQuantity<T, MilliNewton> val) where T:IConvertible {
        return new Quantity<double, YottaNewton>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliNewton to ZettaNewton
    /// </summary>
    /// <param name="val">quantity measured in MilliNewton</param>
    /// <returns>quantity measured in ZettaNewton</returns>
	public static Quantity<double, ZettaNewton> ToZettaNewton<T>(this BaseQuantity<T, MilliNewton> val) where T:IConvertible {
        return new Quantity<double, ZettaNewton>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliNewton to ExaNewton
    /// </summary>
    /// <param name="val">quantity measured in MilliNewton</param>
    /// <returns>quantity measured in ExaNewton</returns>
	public static Quantity<double, ExaNewton> ToExaNewton<T>(this BaseQuantity<T, MilliNewton> val) where T:IConvertible {
        return new Quantity<double, ExaNewton>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliNewton to PetaNewton
    /// </summary>
    /// <param name="val">quantity measured in MilliNewton</param>
    /// <returns>quantity measured in PetaNewton</returns>
	public static Quantity<double, PetaNewton> ToPetaNewton<T>(this BaseQuantity<T, MilliNewton> val) where T:IConvertible {
        return new Quantity<double, PetaNewton>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliNewton to TeraNewton
    /// </summary>
    /// <param name="val">quantity measured in MilliNewton</param>
    /// <returns>quantity measured in TeraNewton</returns>
	public static Quantity<double, TeraNewton> ToTeraNewton<T>(this BaseQuantity<T, MilliNewton> val) where T:IConvertible {
        return new Quantity<double, TeraNewton>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliNewton to GigaNewton
    /// </summary>
    /// <param name="val">quantity measured in MilliNewton</param>
    /// <returns>quantity measured in GigaNewton</returns>
	public static Quantity<double, GigaNewton> ToGigaNewton<T>(this BaseQuantity<T, MilliNewton> val) where T:IConvertible {
        return new Quantity<double, GigaNewton>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliNewton to MegaNewton
    /// </summary>
    /// <param name="val">quantity measured in MilliNewton</param>
    /// <returns>quantity measured in MegaNewton</returns>
	public static Quantity<double, MegaNewton> ToMegaNewton<T>(this BaseQuantity<T, MilliNewton> val) where T:IConvertible {
        return new Quantity<double, MegaNewton>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliNewton to KiloNewton
    /// </summary>
    /// <param name="val">quantity measured in MilliNewton</param>
    /// <returns>quantity measured in KiloNewton</returns>
	public static Quantity<double, KiloNewton> ToKiloNewton<T>(this BaseQuantity<T, MilliNewton> val) where T:IConvertible {
        return new Quantity<double, KiloNewton>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliNewton to HectoNewton
    /// </summary>
    /// <param name="val">quantity measured in MilliNewton</param>
    /// <returns>quantity measured in HectoNewton</returns>
	public static Quantity<double, HectoNewton> ToHectoNewton<T>(this BaseQuantity<T, MilliNewton> val) where T:IConvertible {
        return new Quantity<double, HectoNewton>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliNewton to DekaNewton
    /// </summary>
    /// <param name="val">quantity measured in MilliNewton</param>
    /// <returns>quantity measured in DekaNewton</returns>
	public static Quantity<double, DekaNewton> ToDekaNewton<T>(this BaseQuantity<T, MilliNewton> val) where T:IConvertible {
        return new Quantity<double, DekaNewton>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliNewton to DeciNewton
    /// </summary>
    /// <param name="val">quantity measured in MilliNewton</param>
    /// <returns>quantity measured in DeciNewton</returns>
	public static Quantity<double, DeciNewton> ToDeciNewton<T>(this BaseQuantity<T, MilliNewton> val) where T:IConvertible {
        return new Quantity<double, DeciNewton>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliNewton to CentiNewton
    /// </summary>
    /// <param name="val">quantity measured in MilliNewton</param>
    /// <returns>quantity measured in CentiNewton</returns>
	public static Quantity<double, CentiNewton> ToCentiNewton<T>(this BaseQuantity<T, MilliNewton> val) where T:IConvertible {
        return new Quantity<double, CentiNewton>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliNewton to MicroNewton
    /// </summary>
    /// <param name="val">quantity measured in MilliNewton</param>
    /// <returns>quantity measured in MicroNewton</returns>
	public static Quantity<double, MicroNewton> ToMicroNewton<T>(this BaseQuantity<T, MilliNewton> val) where T:IConvertible {
        return new Quantity<double, MicroNewton>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliNewton to NanoNewton
    /// </summary>
    /// <param name="val">quantity measured in MilliNewton</param>
    /// <returns>quantity measured in NanoNewton</returns>
	public static Quantity<double, NanoNewton> ToNanoNewton<T>(this BaseQuantity<T, MilliNewton> val) where T:IConvertible {
        return new Quantity<double, NanoNewton>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliNewton to PicoNewton
    /// </summary>
    /// <param name="val">quantity measured in MilliNewton</param>
    /// <returns>quantity measured in PicoNewton</returns>
	public static Quantity<double, PicoNewton> ToPicoNewton<T>(this BaseQuantity<T, MilliNewton> val) where T:IConvertible {
        return new Quantity<double, PicoNewton>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliNewton to FemtoNewton
    /// </summary>
    /// <param name="val">quantity measured in MilliNewton</param>
    /// <returns>quantity measured in FemtoNewton</returns>
	public static Quantity<double, FemtoNewton> ToFemtoNewton<T>(this BaseQuantity<T, MilliNewton> val) where T:IConvertible {
        return new Quantity<double, FemtoNewton>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliNewton to AttoNewton
    /// </summary>
    /// <param name="val">quantity measured in MilliNewton</param>
    /// <returns>quantity measured in AttoNewton</returns>
	public static Quantity<double, AttoNewton> ToAttoNewton<T>(this BaseQuantity<T, MilliNewton> val) where T:IConvertible {
        return new Quantity<double, AttoNewton>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliNewton to ZeptoNewton
    /// </summary>
    /// <param name="val">quantity measured in MilliNewton</param>
    /// <returns>quantity measured in ZeptoNewton</returns>
	public static Quantity<double, ZeptoNewton> ToZeptoNewton<T>(this BaseQuantity<T, MilliNewton> val) where T:IConvertible {
        return new Quantity<double, ZeptoNewton>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliNewton to YoctoNewton
    /// </summary>
    /// <param name="val">quantity measured in MilliNewton</param>
    /// <returns>quantity measured in YoctoNewton</returns>
	public static Quantity<double, YoctoNewton> ToYoctoNewton<T>(this BaseQuantity<T, MilliNewton> val) where T:IConvertible {
        return new Quantity<double, YoctoNewton>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MicroNewton to YottaNewton
    /// </summary>
    /// <param name="val">quantity measured in MicroNewton</param>
    /// <returns>quantity measured in YottaNewton</returns>
	public static Quantity<double, YottaNewton> ToYottaNewton<T>(this BaseQuantity<T, MicroNewton> val) where T:IConvertible {
        return new Quantity<double, YottaNewton>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroNewton to ZettaNewton
    /// </summary>
    /// <param name="val">quantity measured in MicroNewton</param>
    /// <returns>quantity measured in ZettaNewton</returns>
	public static Quantity<double, ZettaNewton> ToZettaNewton<T>(this BaseQuantity<T, MicroNewton> val) where T:IConvertible {
        return new Quantity<double, ZettaNewton>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroNewton to ExaNewton
    /// </summary>
    /// <param name="val">quantity measured in MicroNewton</param>
    /// <returns>quantity measured in ExaNewton</returns>
	public static Quantity<double, ExaNewton> ToExaNewton<T>(this BaseQuantity<T, MicroNewton> val) where T:IConvertible {
        return new Quantity<double, ExaNewton>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroNewton to PetaNewton
    /// </summary>
    /// <param name="val">quantity measured in MicroNewton</param>
    /// <returns>quantity measured in PetaNewton</returns>
	public static Quantity<double, PetaNewton> ToPetaNewton<T>(this BaseQuantity<T, MicroNewton> val) where T:IConvertible {
        return new Quantity<double, PetaNewton>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroNewton to TeraNewton
    /// </summary>
    /// <param name="val">quantity measured in MicroNewton</param>
    /// <returns>quantity measured in TeraNewton</returns>
	public static Quantity<double, TeraNewton> ToTeraNewton<T>(this BaseQuantity<T, MicroNewton> val) where T:IConvertible {
        return new Quantity<double, TeraNewton>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroNewton to GigaNewton
    /// </summary>
    /// <param name="val">quantity measured in MicroNewton</param>
    /// <returns>quantity measured in GigaNewton</returns>
	public static Quantity<double, GigaNewton> ToGigaNewton<T>(this BaseQuantity<T, MicroNewton> val) where T:IConvertible {
        return new Quantity<double, GigaNewton>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroNewton to MegaNewton
    /// </summary>
    /// <param name="val">quantity measured in MicroNewton</param>
    /// <returns>quantity measured in MegaNewton</returns>
	public static Quantity<double, MegaNewton> ToMegaNewton<T>(this BaseQuantity<T, MicroNewton> val) where T:IConvertible {
        return new Quantity<double, MegaNewton>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroNewton to KiloNewton
    /// </summary>
    /// <param name="val">quantity measured in MicroNewton</param>
    /// <returns>quantity measured in KiloNewton</returns>
	public static Quantity<double, KiloNewton> ToKiloNewton<T>(this BaseQuantity<T, MicroNewton> val) where T:IConvertible {
        return new Quantity<double, KiloNewton>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroNewton to HectoNewton
    /// </summary>
    /// <param name="val">quantity measured in MicroNewton</param>
    /// <returns>quantity measured in HectoNewton</returns>
	public static Quantity<double, HectoNewton> ToHectoNewton<T>(this BaseQuantity<T, MicroNewton> val) where T:IConvertible {
        return new Quantity<double, HectoNewton>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroNewton to DekaNewton
    /// </summary>
    /// <param name="val">quantity measured in MicroNewton</param>
    /// <returns>quantity measured in DekaNewton</returns>
	public static Quantity<double, DekaNewton> ToDekaNewton<T>(this BaseQuantity<T, MicroNewton> val) where T:IConvertible {
        return new Quantity<double, DekaNewton>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroNewton to DeciNewton
    /// </summary>
    /// <param name="val">quantity measured in MicroNewton</param>
    /// <returns>quantity measured in DeciNewton</returns>
	public static Quantity<double, DeciNewton> ToDeciNewton<T>(this BaseQuantity<T, MicroNewton> val) where T:IConvertible {
        return new Quantity<double, DeciNewton>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroNewton to CentiNewton
    /// </summary>
    /// <param name="val">quantity measured in MicroNewton</param>
    /// <returns>quantity measured in CentiNewton</returns>
	public static Quantity<double, CentiNewton> ToCentiNewton<T>(this BaseQuantity<T, MicroNewton> val) where T:IConvertible {
        return new Quantity<double, CentiNewton>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroNewton to MilliNewton
    /// </summary>
    /// <param name="val">quantity measured in MicroNewton</param>
    /// <returns>quantity measured in MilliNewton</returns>
	public static Quantity<double, MilliNewton> ToMilliNewton<T>(this BaseQuantity<T, MicroNewton> val) where T:IConvertible {
        return new Quantity<double, MilliNewton>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroNewton to NanoNewton
    /// </summary>
    /// <param name="val">quantity measured in MicroNewton</param>
    /// <returns>quantity measured in NanoNewton</returns>
	public static Quantity<double, NanoNewton> ToNanoNewton<T>(this BaseQuantity<T, MicroNewton> val) where T:IConvertible {
        return new Quantity<double, NanoNewton>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroNewton to PicoNewton
    /// </summary>
    /// <param name="val">quantity measured in MicroNewton</param>
    /// <returns>quantity measured in PicoNewton</returns>
	public static Quantity<double, PicoNewton> ToPicoNewton<T>(this BaseQuantity<T, MicroNewton> val) where T:IConvertible {
        return new Quantity<double, PicoNewton>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroNewton to FemtoNewton
    /// </summary>
    /// <param name="val">quantity measured in MicroNewton</param>
    /// <returns>quantity measured in FemtoNewton</returns>
	public static Quantity<double, FemtoNewton> ToFemtoNewton<T>(this BaseQuantity<T, MicroNewton> val) where T:IConvertible {
        return new Quantity<double, FemtoNewton>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroNewton to AttoNewton
    /// </summary>
    /// <param name="val">quantity measured in MicroNewton</param>
    /// <returns>quantity measured in AttoNewton</returns>
	public static Quantity<double, AttoNewton> ToAttoNewton<T>(this BaseQuantity<T, MicroNewton> val) where T:IConvertible {
        return new Quantity<double, AttoNewton>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroNewton to ZeptoNewton
    /// </summary>
    /// <param name="val">quantity measured in MicroNewton</param>
    /// <returns>quantity measured in ZeptoNewton</returns>
	public static Quantity<double, ZeptoNewton> ToZeptoNewton<T>(this BaseQuantity<T, MicroNewton> val) where T:IConvertible {
        return new Quantity<double, ZeptoNewton>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroNewton to YoctoNewton
    /// </summary>
    /// <param name="val">quantity measured in MicroNewton</param>
    /// <returns>quantity measured in YoctoNewton</returns>
	public static Quantity<double, YoctoNewton> ToYoctoNewton<T>(this BaseQuantity<T, MicroNewton> val) where T:IConvertible {
        return new Quantity<double, YoctoNewton>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert NanoNewton to YottaNewton
    /// </summary>
    /// <param name="val">quantity measured in NanoNewton</param>
    /// <returns>quantity measured in YottaNewton</returns>
	public static Quantity<double, YottaNewton> ToYottaNewton<T>(this BaseQuantity<T, NanoNewton> val) where T:IConvertible {
        return new Quantity<double, YottaNewton>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoNewton to ZettaNewton
    /// </summary>
    /// <param name="val">quantity measured in NanoNewton</param>
    /// <returns>quantity measured in ZettaNewton</returns>
	public static Quantity<double, ZettaNewton> ToZettaNewton<T>(this BaseQuantity<T, NanoNewton> val) where T:IConvertible {
        return new Quantity<double, ZettaNewton>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoNewton to ExaNewton
    /// </summary>
    /// <param name="val">quantity measured in NanoNewton</param>
    /// <returns>quantity measured in ExaNewton</returns>
	public static Quantity<double, ExaNewton> ToExaNewton<T>(this BaseQuantity<T, NanoNewton> val) where T:IConvertible {
        return new Quantity<double, ExaNewton>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoNewton to PetaNewton
    /// </summary>
    /// <param name="val">quantity measured in NanoNewton</param>
    /// <returns>quantity measured in PetaNewton</returns>
	public static Quantity<double, PetaNewton> ToPetaNewton<T>(this BaseQuantity<T, NanoNewton> val) where T:IConvertible {
        return new Quantity<double, PetaNewton>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoNewton to TeraNewton
    /// </summary>
    /// <param name="val">quantity measured in NanoNewton</param>
    /// <returns>quantity measured in TeraNewton</returns>
	public static Quantity<double, TeraNewton> ToTeraNewton<T>(this BaseQuantity<T, NanoNewton> val) where T:IConvertible {
        return new Quantity<double, TeraNewton>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoNewton to GigaNewton
    /// </summary>
    /// <param name="val">quantity measured in NanoNewton</param>
    /// <returns>quantity measured in GigaNewton</returns>
	public static Quantity<double, GigaNewton> ToGigaNewton<T>(this BaseQuantity<T, NanoNewton> val) where T:IConvertible {
        return new Quantity<double, GigaNewton>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoNewton to MegaNewton
    /// </summary>
    /// <param name="val">quantity measured in NanoNewton</param>
    /// <returns>quantity measured in MegaNewton</returns>
	public static Quantity<double, MegaNewton> ToMegaNewton<T>(this BaseQuantity<T, NanoNewton> val) where T:IConvertible {
        return new Quantity<double, MegaNewton>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoNewton to KiloNewton
    /// </summary>
    /// <param name="val">quantity measured in NanoNewton</param>
    /// <returns>quantity measured in KiloNewton</returns>
	public static Quantity<double, KiloNewton> ToKiloNewton<T>(this BaseQuantity<T, NanoNewton> val) where T:IConvertible {
        return new Quantity<double, KiloNewton>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoNewton to HectoNewton
    /// </summary>
    /// <param name="val">quantity measured in NanoNewton</param>
    /// <returns>quantity measured in HectoNewton</returns>
	public static Quantity<double, HectoNewton> ToHectoNewton<T>(this BaseQuantity<T, NanoNewton> val) where T:IConvertible {
        return new Quantity<double, HectoNewton>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoNewton to DekaNewton
    /// </summary>
    /// <param name="val">quantity measured in NanoNewton</param>
    /// <returns>quantity measured in DekaNewton</returns>
	public static Quantity<double, DekaNewton> ToDekaNewton<T>(this BaseQuantity<T, NanoNewton> val) where T:IConvertible {
        return new Quantity<double, DekaNewton>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoNewton to DeciNewton
    /// </summary>
    /// <param name="val">quantity measured in NanoNewton</param>
    /// <returns>quantity measured in DeciNewton</returns>
	public static Quantity<double, DeciNewton> ToDeciNewton<T>(this BaseQuantity<T, NanoNewton> val) where T:IConvertible {
        return new Quantity<double, DeciNewton>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoNewton to CentiNewton
    /// </summary>
    /// <param name="val">quantity measured in NanoNewton</param>
    /// <returns>quantity measured in CentiNewton</returns>
	public static Quantity<double, CentiNewton> ToCentiNewton<T>(this BaseQuantity<T, NanoNewton> val) where T:IConvertible {
        return new Quantity<double, CentiNewton>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoNewton to MilliNewton
    /// </summary>
    /// <param name="val">quantity measured in NanoNewton</param>
    /// <returns>quantity measured in MilliNewton</returns>
	public static Quantity<double, MilliNewton> ToMilliNewton<T>(this BaseQuantity<T, NanoNewton> val) where T:IConvertible {
        return new Quantity<double, MilliNewton>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoNewton to MicroNewton
    /// </summary>
    /// <param name="val">quantity measured in NanoNewton</param>
    /// <returns>quantity measured in MicroNewton</returns>
	public static Quantity<double, MicroNewton> ToMicroNewton<T>(this BaseQuantity<T, NanoNewton> val) where T:IConvertible {
        return new Quantity<double, MicroNewton>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoNewton to PicoNewton
    /// </summary>
    /// <param name="val">quantity measured in NanoNewton</param>
    /// <returns>quantity measured in PicoNewton</returns>
	public static Quantity<double, PicoNewton> ToPicoNewton<T>(this BaseQuantity<T, NanoNewton> val) where T:IConvertible {
        return new Quantity<double, PicoNewton>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoNewton to FemtoNewton
    /// </summary>
    /// <param name="val">quantity measured in NanoNewton</param>
    /// <returns>quantity measured in FemtoNewton</returns>
	public static Quantity<double, FemtoNewton> ToFemtoNewton<T>(this BaseQuantity<T, NanoNewton> val) where T:IConvertible {
        return new Quantity<double, FemtoNewton>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoNewton to AttoNewton
    /// </summary>
    /// <param name="val">quantity measured in NanoNewton</param>
    /// <returns>quantity measured in AttoNewton</returns>
	public static Quantity<double, AttoNewton> ToAttoNewton<T>(this BaseQuantity<T, NanoNewton> val) where T:IConvertible {
        return new Quantity<double, AttoNewton>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoNewton to ZeptoNewton
    /// </summary>
    /// <param name="val">quantity measured in NanoNewton</param>
    /// <returns>quantity measured in ZeptoNewton</returns>
	public static Quantity<double, ZeptoNewton> ToZeptoNewton<T>(this BaseQuantity<T, NanoNewton> val) where T:IConvertible {
        return new Quantity<double, ZeptoNewton>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoNewton to YoctoNewton
    /// </summary>
    /// <param name="val">quantity measured in NanoNewton</param>
    /// <returns>quantity measured in YoctoNewton</returns>
	public static Quantity<double, YoctoNewton> ToYoctoNewton<T>(this BaseQuantity<T, NanoNewton> val) where T:IConvertible {
        return new Quantity<double, YoctoNewton>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert PicoNewton to YottaNewton
    /// </summary>
    /// <param name="val">quantity measured in PicoNewton</param>
    /// <returns>quantity measured in YottaNewton</returns>
	public static Quantity<double, YottaNewton> ToYottaNewton<T>(this BaseQuantity<T, PicoNewton> val) where T:IConvertible {
        return new Quantity<double, YottaNewton>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoNewton to ZettaNewton
    /// </summary>
    /// <param name="val">quantity measured in PicoNewton</param>
    /// <returns>quantity measured in ZettaNewton</returns>
	public static Quantity<double, ZettaNewton> ToZettaNewton<T>(this BaseQuantity<T, PicoNewton> val) where T:IConvertible {
        return new Quantity<double, ZettaNewton>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoNewton to ExaNewton
    /// </summary>
    /// <param name="val">quantity measured in PicoNewton</param>
    /// <returns>quantity measured in ExaNewton</returns>
	public static Quantity<double, ExaNewton> ToExaNewton<T>(this BaseQuantity<T, PicoNewton> val) where T:IConvertible {
        return new Quantity<double, ExaNewton>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoNewton to PetaNewton
    /// </summary>
    /// <param name="val">quantity measured in PicoNewton</param>
    /// <returns>quantity measured in PetaNewton</returns>
	public static Quantity<double, PetaNewton> ToPetaNewton<T>(this BaseQuantity<T, PicoNewton> val) where T:IConvertible {
        return new Quantity<double, PetaNewton>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoNewton to TeraNewton
    /// </summary>
    /// <param name="val">quantity measured in PicoNewton</param>
    /// <returns>quantity measured in TeraNewton</returns>
	public static Quantity<double, TeraNewton> ToTeraNewton<T>(this BaseQuantity<T, PicoNewton> val) where T:IConvertible {
        return new Quantity<double, TeraNewton>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoNewton to GigaNewton
    /// </summary>
    /// <param name="val">quantity measured in PicoNewton</param>
    /// <returns>quantity measured in GigaNewton</returns>
	public static Quantity<double, GigaNewton> ToGigaNewton<T>(this BaseQuantity<T, PicoNewton> val) where T:IConvertible {
        return new Quantity<double, GigaNewton>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoNewton to MegaNewton
    /// </summary>
    /// <param name="val">quantity measured in PicoNewton</param>
    /// <returns>quantity measured in MegaNewton</returns>
	public static Quantity<double, MegaNewton> ToMegaNewton<T>(this BaseQuantity<T, PicoNewton> val) where T:IConvertible {
        return new Quantity<double, MegaNewton>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoNewton to KiloNewton
    /// </summary>
    /// <param name="val">quantity measured in PicoNewton</param>
    /// <returns>quantity measured in KiloNewton</returns>
	public static Quantity<double, KiloNewton> ToKiloNewton<T>(this BaseQuantity<T, PicoNewton> val) where T:IConvertible {
        return new Quantity<double, KiloNewton>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoNewton to HectoNewton
    /// </summary>
    /// <param name="val">quantity measured in PicoNewton</param>
    /// <returns>quantity measured in HectoNewton</returns>
	public static Quantity<double, HectoNewton> ToHectoNewton<T>(this BaseQuantity<T, PicoNewton> val) where T:IConvertible {
        return new Quantity<double, HectoNewton>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoNewton to DekaNewton
    /// </summary>
    /// <param name="val">quantity measured in PicoNewton</param>
    /// <returns>quantity measured in DekaNewton</returns>
	public static Quantity<double, DekaNewton> ToDekaNewton<T>(this BaseQuantity<T, PicoNewton> val) where T:IConvertible {
        return new Quantity<double, DekaNewton>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoNewton to DeciNewton
    /// </summary>
    /// <param name="val">quantity measured in PicoNewton</param>
    /// <returns>quantity measured in DeciNewton</returns>
	public static Quantity<double, DeciNewton> ToDeciNewton<T>(this BaseQuantity<T, PicoNewton> val) where T:IConvertible {
        return new Quantity<double, DeciNewton>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoNewton to CentiNewton
    /// </summary>
    /// <param name="val">quantity measured in PicoNewton</param>
    /// <returns>quantity measured in CentiNewton</returns>
	public static Quantity<double, CentiNewton> ToCentiNewton<T>(this BaseQuantity<T, PicoNewton> val) where T:IConvertible {
        return new Quantity<double, CentiNewton>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoNewton to MilliNewton
    /// </summary>
    /// <param name="val">quantity measured in PicoNewton</param>
    /// <returns>quantity measured in MilliNewton</returns>
	public static Quantity<double, MilliNewton> ToMilliNewton<T>(this BaseQuantity<T, PicoNewton> val) where T:IConvertible {
        return new Quantity<double, MilliNewton>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoNewton to MicroNewton
    /// </summary>
    /// <param name="val">quantity measured in PicoNewton</param>
    /// <returns>quantity measured in MicroNewton</returns>
	public static Quantity<double, MicroNewton> ToMicroNewton<T>(this BaseQuantity<T, PicoNewton> val) where T:IConvertible {
        return new Quantity<double, MicroNewton>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoNewton to NanoNewton
    /// </summary>
    /// <param name="val">quantity measured in PicoNewton</param>
    /// <returns>quantity measured in NanoNewton</returns>
	public static Quantity<double, NanoNewton> ToNanoNewton<T>(this BaseQuantity<T, PicoNewton> val) where T:IConvertible {
        return new Quantity<double, NanoNewton>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoNewton to FemtoNewton
    /// </summary>
    /// <param name="val">quantity measured in PicoNewton</param>
    /// <returns>quantity measured in FemtoNewton</returns>
	public static Quantity<double, FemtoNewton> ToFemtoNewton<T>(this BaseQuantity<T, PicoNewton> val) where T:IConvertible {
        return new Quantity<double, FemtoNewton>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoNewton to AttoNewton
    /// </summary>
    /// <param name="val">quantity measured in PicoNewton</param>
    /// <returns>quantity measured in AttoNewton</returns>
	public static Quantity<double, AttoNewton> ToAttoNewton<T>(this BaseQuantity<T, PicoNewton> val) where T:IConvertible {
        return new Quantity<double, AttoNewton>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoNewton to ZeptoNewton
    /// </summary>
    /// <param name="val">quantity measured in PicoNewton</param>
    /// <returns>quantity measured in ZeptoNewton</returns>
	public static Quantity<double, ZeptoNewton> ToZeptoNewton<T>(this BaseQuantity<T, PicoNewton> val) where T:IConvertible {
        return new Quantity<double, ZeptoNewton>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoNewton to YoctoNewton
    /// </summary>
    /// <param name="val">quantity measured in PicoNewton</param>
    /// <returns>quantity measured in YoctoNewton</returns>
	public static Quantity<double, YoctoNewton> ToYoctoNewton<T>(this BaseQuantity<T, PicoNewton> val) where T:IConvertible {
        return new Quantity<double, YoctoNewton>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert FemtoNewton to YottaNewton
    /// </summary>
    /// <param name="val">quantity measured in FemtoNewton</param>
    /// <returns>quantity measured in YottaNewton</returns>
	public static Quantity<double, YottaNewton> ToYottaNewton<T>(this BaseQuantity<T, FemtoNewton> val) where T:IConvertible {
        return new Quantity<double, YottaNewton>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoNewton to ZettaNewton
    /// </summary>
    /// <param name="val">quantity measured in FemtoNewton</param>
    /// <returns>quantity measured in ZettaNewton</returns>
	public static Quantity<double, ZettaNewton> ToZettaNewton<T>(this BaseQuantity<T, FemtoNewton> val) where T:IConvertible {
        return new Quantity<double, ZettaNewton>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoNewton to ExaNewton
    /// </summary>
    /// <param name="val">quantity measured in FemtoNewton</param>
    /// <returns>quantity measured in ExaNewton</returns>
	public static Quantity<double, ExaNewton> ToExaNewton<T>(this BaseQuantity<T, FemtoNewton> val) where T:IConvertible {
        return new Quantity<double, ExaNewton>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoNewton to PetaNewton
    /// </summary>
    /// <param name="val">quantity measured in FemtoNewton</param>
    /// <returns>quantity measured in PetaNewton</returns>
	public static Quantity<double, PetaNewton> ToPetaNewton<T>(this BaseQuantity<T, FemtoNewton> val) where T:IConvertible {
        return new Quantity<double, PetaNewton>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoNewton to TeraNewton
    /// </summary>
    /// <param name="val">quantity measured in FemtoNewton</param>
    /// <returns>quantity measured in TeraNewton</returns>
	public static Quantity<double, TeraNewton> ToTeraNewton<T>(this BaseQuantity<T, FemtoNewton> val) where T:IConvertible {
        return new Quantity<double, TeraNewton>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoNewton to GigaNewton
    /// </summary>
    /// <param name="val">quantity measured in FemtoNewton</param>
    /// <returns>quantity measured in GigaNewton</returns>
	public static Quantity<double, GigaNewton> ToGigaNewton<T>(this BaseQuantity<T, FemtoNewton> val) where T:IConvertible {
        return new Quantity<double, GigaNewton>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoNewton to MegaNewton
    /// </summary>
    /// <param name="val">quantity measured in FemtoNewton</param>
    /// <returns>quantity measured in MegaNewton</returns>
	public static Quantity<double, MegaNewton> ToMegaNewton<T>(this BaseQuantity<T, FemtoNewton> val) where T:IConvertible {
        return new Quantity<double, MegaNewton>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoNewton to KiloNewton
    /// </summary>
    /// <param name="val">quantity measured in FemtoNewton</param>
    /// <returns>quantity measured in KiloNewton</returns>
	public static Quantity<double, KiloNewton> ToKiloNewton<T>(this BaseQuantity<T, FemtoNewton> val) where T:IConvertible {
        return new Quantity<double, KiloNewton>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoNewton to HectoNewton
    /// </summary>
    /// <param name="val">quantity measured in FemtoNewton</param>
    /// <returns>quantity measured in HectoNewton</returns>
	public static Quantity<double, HectoNewton> ToHectoNewton<T>(this BaseQuantity<T, FemtoNewton> val) where T:IConvertible {
        return new Quantity<double, HectoNewton>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoNewton to DekaNewton
    /// </summary>
    /// <param name="val">quantity measured in FemtoNewton</param>
    /// <returns>quantity measured in DekaNewton</returns>
	public static Quantity<double, DekaNewton> ToDekaNewton<T>(this BaseQuantity<T, FemtoNewton> val) where T:IConvertible {
        return new Quantity<double, DekaNewton>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoNewton to DeciNewton
    /// </summary>
    /// <param name="val">quantity measured in FemtoNewton</param>
    /// <returns>quantity measured in DeciNewton</returns>
	public static Quantity<double, DeciNewton> ToDeciNewton<T>(this BaseQuantity<T, FemtoNewton> val) where T:IConvertible {
        return new Quantity<double, DeciNewton>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoNewton to CentiNewton
    /// </summary>
    /// <param name="val">quantity measured in FemtoNewton</param>
    /// <returns>quantity measured in CentiNewton</returns>
	public static Quantity<double, CentiNewton> ToCentiNewton<T>(this BaseQuantity<T, FemtoNewton> val) where T:IConvertible {
        return new Quantity<double, CentiNewton>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoNewton to MilliNewton
    /// </summary>
    /// <param name="val">quantity measured in FemtoNewton</param>
    /// <returns>quantity measured in MilliNewton</returns>
	public static Quantity<double, MilliNewton> ToMilliNewton<T>(this BaseQuantity<T, FemtoNewton> val) where T:IConvertible {
        return new Quantity<double, MilliNewton>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoNewton to MicroNewton
    /// </summary>
    /// <param name="val">quantity measured in FemtoNewton</param>
    /// <returns>quantity measured in MicroNewton</returns>
	public static Quantity<double, MicroNewton> ToMicroNewton<T>(this BaseQuantity<T, FemtoNewton> val) where T:IConvertible {
        return new Quantity<double, MicroNewton>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoNewton to NanoNewton
    /// </summary>
    /// <param name="val">quantity measured in FemtoNewton</param>
    /// <returns>quantity measured in NanoNewton</returns>
	public static Quantity<double, NanoNewton> ToNanoNewton<T>(this BaseQuantity<T, FemtoNewton> val) where T:IConvertible {
        return new Quantity<double, NanoNewton>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoNewton to PicoNewton
    /// </summary>
    /// <param name="val">quantity measured in FemtoNewton</param>
    /// <returns>quantity measured in PicoNewton</returns>
	public static Quantity<double, PicoNewton> ToPicoNewton<T>(this BaseQuantity<T, FemtoNewton> val) where T:IConvertible {
        return new Quantity<double, PicoNewton>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoNewton to AttoNewton
    /// </summary>
    /// <param name="val">quantity measured in FemtoNewton</param>
    /// <returns>quantity measured in AttoNewton</returns>
	public static Quantity<double, AttoNewton> ToAttoNewton<T>(this BaseQuantity<T, FemtoNewton> val) where T:IConvertible {
        return new Quantity<double, AttoNewton>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoNewton to ZeptoNewton
    /// </summary>
    /// <param name="val">quantity measured in FemtoNewton</param>
    /// <returns>quantity measured in ZeptoNewton</returns>
	public static Quantity<double, ZeptoNewton> ToZeptoNewton<T>(this BaseQuantity<T, FemtoNewton> val) where T:IConvertible {
        return new Quantity<double, ZeptoNewton>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoNewton to YoctoNewton
    /// </summary>
    /// <param name="val">quantity measured in FemtoNewton</param>
    /// <returns>quantity measured in YoctoNewton</returns>
	public static Quantity<double, YoctoNewton> ToYoctoNewton<T>(this BaseQuantity<T, FemtoNewton> val) where T:IConvertible {
        return new Quantity<double, YoctoNewton>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert AttoNewton to YottaNewton
    /// </summary>
    /// <param name="val">quantity measured in AttoNewton</param>
    /// <returns>quantity measured in YottaNewton</returns>
	public static Quantity<double, YottaNewton> ToYottaNewton<T>(this BaseQuantity<T, AttoNewton> val) where T:IConvertible {
        return new Quantity<double, YottaNewton>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoNewton to ZettaNewton
    /// </summary>
    /// <param name="val">quantity measured in AttoNewton</param>
    /// <returns>quantity measured in ZettaNewton</returns>
	public static Quantity<double, ZettaNewton> ToZettaNewton<T>(this BaseQuantity<T, AttoNewton> val) where T:IConvertible {
        return new Quantity<double, ZettaNewton>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoNewton to ExaNewton
    /// </summary>
    /// <param name="val">quantity measured in AttoNewton</param>
    /// <returns>quantity measured in ExaNewton</returns>
	public static Quantity<double, ExaNewton> ToExaNewton<T>(this BaseQuantity<T, AttoNewton> val) where T:IConvertible {
        return new Quantity<double, ExaNewton>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoNewton to PetaNewton
    /// </summary>
    /// <param name="val">quantity measured in AttoNewton</param>
    /// <returns>quantity measured in PetaNewton</returns>
	public static Quantity<double, PetaNewton> ToPetaNewton<T>(this BaseQuantity<T, AttoNewton> val) where T:IConvertible {
        return new Quantity<double, PetaNewton>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoNewton to TeraNewton
    /// </summary>
    /// <param name="val">quantity measured in AttoNewton</param>
    /// <returns>quantity measured in TeraNewton</returns>
	public static Quantity<double, TeraNewton> ToTeraNewton<T>(this BaseQuantity<T, AttoNewton> val) where T:IConvertible {
        return new Quantity<double, TeraNewton>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoNewton to GigaNewton
    /// </summary>
    /// <param name="val">quantity measured in AttoNewton</param>
    /// <returns>quantity measured in GigaNewton</returns>
	public static Quantity<double, GigaNewton> ToGigaNewton<T>(this BaseQuantity<T, AttoNewton> val) where T:IConvertible {
        return new Quantity<double, GigaNewton>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoNewton to MegaNewton
    /// </summary>
    /// <param name="val">quantity measured in AttoNewton</param>
    /// <returns>quantity measured in MegaNewton</returns>
	public static Quantity<double, MegaNewton> ToMegaNewton<T>(this BaseQuantity<T, AttoNewton> val) where T:IConvertible {
        return new Quantity<double, MegaNewton>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoNewton to KiloNewton
    /// </summary>
    /// <param name="val">quantity measured in AttoNewton</param>
    /// <returns>quantity measured in KiloNewton</returns>
	public static Quantity<double, KiloNewton> ToKiloNewton<T>(this BaseQuantity<T, AttoNewton> val) where T:IConvertible {
        return new Quantity<double, KiloNewton>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoNewton to HectoNewton
    /// </summary>
    /// <param name="val">quantity measured in AttoNewton</param>
    /// <returns>quantity measured in HectoNewton</returns>
	public static Quantity<double, HectoNewton> ToHectoNewton<T>(this BaseQuantity<T, AttoNewton> val) where T:IConvertible {
        return new Quantity<double, HectoNewton>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoNewton to DekaNewton
    /// </summary>
    /// <param name="val">quantity measured in AttoNewton</param>
    /// <returns>quantity measured in DekaNewton</returns>
	public static Quantity<double, DekaNewton> ToDekaNewton<T>(this BaseQuantity<T, AttoNewton> val) where T:IConvertible {
        return new Quantity<double, DekaNewton>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoNewton to DeciNewton
    /// </summary>
    /// <param name="val">quantity measured in AttoNewton</param>
    /// <returns>quantity measured in DeciNewton</returns>
	public static Quantity<double, DeciNewton> ToDeciNewton<T>(this BaseQuantity<T, AttoNewton> val) where T:IConvertible {
        return new Quantity<double, DeciNewton>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoNewton to CentiNewton
    /// </summary>
    /// <param name="val">quantity measured in AttoNewton</param>
    /// <returns>quantity measured in CentiNewton</returns>
	public static Quantity<double, CentiNewton> ToCentiNewton<T>(this BaseQuantity<T, AttoNewton> val) where T:IConvertible {
        return new Quantity<double, CentiNewton>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoNewton to MilliNewton
    /// </summary>
    /// <param name="val">quantity measured in AttoNewton</param>
    /// <returns>quantity measured in MilliNewton</returns>
	public static Quantity<double, MilliNewton> ToMilliNewton<T>(this BaseQuantity<T, AttoNewton> val) where T:IConvertible {
        return new Quantity<double, MilliNewton>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoNewton to MicroNewton
    /// </summary>
    /// <param name="val">quantity measured in AttoNewton</param>
    /// <returns>quantity measured in MicroNewton</returns>
	public static Quantity<double, MicroNewton> ToMicroNewton<T>(this BaseQuantity<T, AttoNewton> val) where T:IConvertible {
        return new Quantity<double, MicroNewton>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoNewton to NanoNewton
    /// </summary>
    /// <param name="val">quantity measured in AttoNewton</param>
    /// <returns>quantity measured in NanoNewton</returns>
	public static Quantity<double, NanoNewton> ToNanoNewton<T>(this BaseQuantity<T, AttoNewton> val) where T:IConvertible {
        return new Quantity<double, NanoNewton>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoNewton to PicoNewton
    /// </summary>
    /// <param name="val">quantity measured in AttoNewton</param>
    /// <returns>quantity measured in PicoNewton</returns>
	public static Quantity<double, PicoNewton> ToPicoNewton<T>(this BaseQuantity<T, AttoNewton> val) where T:IConvertible {
        return new Quantity<double, PicoNewton>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoNewton to FemtoNewton
    /// </summary>
    /// <param name="val">quantity measured in AttoNewton</param>
    /// <returns>quantity measured in FemtoNewton</returns>
	public static Quantity<double, FemtoNewton> ToFemtoNewton<T>(this BaseQuantity<T, AttoNewton> val) where T:IConvertible {
        return new Quantity<double, FemtoNewton>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoNewton to ZeptoNewton
    /// </summary>
    /// <param name="val">quantity measured in AttoNewton</param>
    /// <returns>quantity measured in ZeptoNewton</returns>
	public static Quantity<double, ZeptoNewton> ToZeptoNewton<T>(this BaseQuantity<T, AttoNewton> val) where T:IConvertible {
        return new Quantity<double, ZeptoNewton>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoNewton to YoctoNewton
    /// </summary>
    /// <param name="val">quantity measured in AttoNewton</param>
    /// <returns>quantity measured in YoctoNewton</returns>
	public static Quantity<double, YoctoNewton> ToYoctoNewton<T>(this BaseQuantity<T, AttoNewton> val) where T:IConvertible {
        return new Quantity<double, YoctoNewton>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoNewton to YottaNewton
    /// </summary>
    /// <param name="val">quantity measured in ZeptoNewton</param>
    /// <returns>quantity measured in YottaNewton</returns>
	public static Quantity<double, YottaNewton> ToYottaNewton<T>(this BaseQuantity<T, ZeptoNewton> val) where T:IConvertible {
        return new Quantity<double, YottaNewton>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoNewton to ZettaNewton
    /// </summary>
    /// <param name="val">quantity measured in ZeptoNewton</param>
    /// <returns>quantity measured in ZettaNewton</returns>
	public static Quantity<double, ZettaNewton> ToZettaNewton<T>(this BaseQuantity<T, ZeptoNewton> val) where T:IConvertible {
        return new Quantity<double, ZettaNewton>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoNewton to ExaNewton
    /// </summary>
    /// <param name="val">quantity measured in ZeptoNewton</param>
    /// <returns>quantity measured in ExaNewton</returns>
	public static Quantity<double, ExaNewton> ToExaNewton<T>(this BaseQuantity<T, ZeptoNewton> val) where T:IConvertible {
        return new Quantity<double, ExaNewton>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoNewton to PetaNewton
    /// </summary>
    /// <param name="val">quantity measured in ZeptoNewton</param>
    /// <returns>quantity measured in PetaNewton</returns>
	public static Quantity<double, PetaNewton> ToPetaNewton<T>(this BaseQuantity<T, ZeptoNewton> val) where T:IConvertible {
        return new Quantity<double, PetaNewton>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoNewton to TeraNewton
    /// </summary>
    /// <param name="val">quantity measured in ZeptoNewton</param>
    /// <returns>quantity measured in TeraNewton</returns>
	public static Quantity<double, TeraNewton> ToTeraNewton<T>(this BaseQuantity<T, ZeptoNewton> val) where T:IConvertible {
        return new Quantity<double, TeraNewton>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoNewton to GigaNewton
    /// </summary>
    /// <param name="val">quantity measured in ZeptoNewton</param>
    /// <returns>quantity measured in GigaNewton</returns>
	public static Quantity<double, GigaNewton> ToGigaNewton<T>(this BaseQuantity<T, ZeptoNewton> val) where T:IConvertible {
        return new Quantity<double, GigaNewton>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoNewton to MegaNewton
    /// </summary>
    /// <param name="val">quantity measured in ZeptoNewton</param>
    /// <returns>quantity measured in MegaNewton</returns>
	public static Quantity<double, MegaNewton> ToMegaNewton<T>(this BaseQuantity<T, ZeptoNewton> val) where T:IConvertible {
        return new Quantity<double, MegaNewton>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoNewton to KiloNewton
    /// </summary>
    /// <param name="val">quantity measured in ZeptoNewton</param>
    /// <returns>quantity measured in KiloNewton</returns>
	public static Quantity<double, KiloNewton> ToKiloNewton<T>(this BaseQuantity<T, ZeptoNewton> val) where T:IConvertible {
        return new Quantity<double, KiloNewton>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoNewton to HectoNewton
    /// </summary>
    /// <param name="val">quantity measured in ZeptoNewton</param>
    /// <returns>quantity measured in HectoNewton</returns>
	public static Quantity<double, HectoNewton> ToHectoNewton<T>(this BaseQuantity<T, ZeptoNewton> val) where T:IConvertible {
        return new Quantity<double, HectoNewton>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoNewton to DekaNewton
    /// </summary>
    /// <param name="val">quantity measured in ZeptoNewton</param>
    /// <returns>quantity measured in DekaNewton</returns>
	public static Quantity<double, DekaNewton> ToDekaNewton<T>(this BaseQuantity<T, ZeptoNewton> val) where T:IConvertible {
        return new Quantity<double, DekaNewton>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoNewton to DeciNewton
    /// </summary>
    /// <param name="val">quantity measured in ZeptoNewton</param>
    /// <returns>quantity measured in DeciNewton</returns>
	public static Quantity<double, DeciNewton> ToDeciNewton<T>(this BaseQuantity<T, ZeptoNewton> val) where T:IConvertible {
        return new Quantity<double, DeciNewton>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoNewton to CentiNewton
    /// </summary>
    /// <param name="val">quantity measured in ZeptoNewton</param>
    /// <returns>quantity measured in CentiNewton</returns>
	public static Quantity<double, CentiNewton> ToCentiNewton<T>(this BaseQuantity<T, ZeptoNewton> val) where T:IConvertible {
        return new Quantity<double, CentiNewton>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoNewton to MilliNewton
    /// </summary>
    /// <param name="val">quantity measured in ZeptoNewton</param>
    /// <returns>quantity measured in MilliNewton</returns>
	public static Quantity<double, MilliNewton> ToMilliNewton<T>(this BaseQuantity<T, ZeptoNewton> val) where T:IConvertible {
        return new Quantity<double, MilliNewton>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoNewton to MicroNewton
    /// </summary>
    /// <param name="val">quantity measured in ZeptoNewton</param>
    /// <returns>quantity measured in MicroNewton</returns>
	public static Quantity<double, MicroNewton> ToMicroNewton<T>(this BaseQuantity<T, ZeptoNewton> val) where T:IConvertible {
        return new Quantity<double, MicroNewton>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoNewton to NanoNewton
    /// </summary>
    /// <param name="val">quantity measured in ZeptoNewton</param>
    /// <returns>quantity measured in NanoNewton</returns>
	public static Quantity<double, NanoNewton> ToNanoNewton<T>(this BaseQuantity<T, ZeptoNewton> val) where T:IConvertible {
        return new Quantity<double, NanoNewton>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoNewton to PicoNewton
    /// </summary>
    /// <param name="val">quantity measured in ZeptoNewton</param>
    /// <returns>quantity measured in PicoNewton</returns>
	public static Quantity<double, PicoNewton> ToPicoNewton<T>(this BaseQuantity<T, ZeptoNewton> val) where T:IConvertible {
        return new Quantity<double, PicoNewton>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoNewton to FemtoNewton
    /// </summary>
    /// <param name="val">quantity measured in ZeptoNewton</param>
    /// <returns>quantity measured in FemtoNewton</returns>
	public static Quantity<double, FemtoNewton> ToFemtoNewton<T>(this BaseQuantity<T, ZeptoNewton> val) where T:IConvertible {
        return new Quantity<double, FemtoNewton>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoNewton to AttoNewton
    /// </summary>
    /// <param name="val">quantity measured in ZeptoNewton</param>
    /// <returns>quantity measured in AttoNewton</returns>
	public static Quantity<double, AttoNewton> ToAttoNewton<T>(this BaseQuantity<T, ZeptoNewton> val) where T:IConvertible {
        return new Quantity<double, AttoNewton>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoNewton to YoctoNewton
    /// </summary>
    /// <param name="val">quantity measured in ZeptoNewton</param>
    /// <returns>quantity measured in YoctoNewton</returns>
	public static Quantity<double, YoctoNewton> ToYoctoNewton<T>(this BaseQuantity<T, ZeptoNewton> val) where T:IConvertible {
        return new Quantity<double, YoctoNewton>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert YoctoNewton to YottaNewton
    /// </summary>
    /// <param name="val">quantity measured in YoctoNewton</param>
    /// <returns>quantity measured in YottaNewton</returns>
	public static Quantity<double, YottaNewton> ToYottaNewton<T>(this BaseQuantity<T, YoctoNewton> val) where T:IConvertible {
        return new Quantity<double, YottaNewton>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoNewton to ZettaNewton
    /// </summary>
    /// <param name="val">quantity measured in YoctoNewton</param>
    /// <returns>quantity measured in ZettaNewton</returns>
	public static Quantity<double, ZettaNewton> ToZettaNewton<T>(this BaseQuantity<T, YoctoNewton> val) where T:IConvertible {
        return new Quantity<double, ZettaNewton>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoNewton to ExaNewton
    /// </summary>
    /// <param name="val">quantity measured in YoctoNewton</param>
    /// <returns>quantity measured in ExaNewton</returns>
	public static Quantity<double, ExaNewton> ToExaNewton<T>(this BaseQuantity<T, YoctoNewton> val) where T:IConvertible {
        return new Quantity<double, ExaNewton>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoNewton to PetaNewton
    /// </summary>
    /// <param name="val">quantity measured in YoctoNewton</param>
    /// <returns>quantity measured in PetaNewton</returns>
	public static Quantity<double, PetaNewton> ToPetaNewton<T>(this BaseQuantity<T, YoctoNewton> val) where T:IConvertible {
        return new Quantity<double, PetaNewton>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoNewton to TeraNewton
    /// </summary>
    /// <param name="val">quantity measured in YoctoNewton</param>
    /// <returns>quantity measured in TeraNewton</returns>
	public static Quantity<double, TeraNewton> ToTeraNewton<T>(this BaseQuantity<T, YoctoNewton> val) where T:IConvertible {
        return new Quantity<double, TeraNewton>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoNewton to GigaNewton
    /// </summary>
    /// <param name="val">quantity measured in YoctoNewton</param>
    /// <returns>quantity measured in GigaNewton</returns>
	public static Quantity<double, GigaNewton> ToGigaNewton<T>(this BaseQuantity<T, YoctoNewton> val) where T:IConvertible {
        return new Quantity<double, GigaNewton>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoNewton to MegaNewton
    /// </summary>
    /// <param name="val">quantity measured in YoctoNewton</param>
    /// <returns>quantity measured in MegaNewton</returns>
	public static Quantity<double, MegaNewton> ToMegaNewton<T>(this BaseQuantity<T, YoctoNewton> val) where T:IConvertible {
        return new Quantity<double, MegaNewton>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoNewton to KiloNewton
    /// </summary>
    /// <param name="val">quantity measured in YoctoNewton</param>
    /// <returns>quantity measured in KiloNewton</returns>
	public static Quantity<double, KiloNewton> ToKiloNewton<T>(this BaseQuantity<T, YoctoNewton> val) where T:IConvertible {
        return new Quantity<double, KiloNewton>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoNewton to HectoNewton
    /// </summary>
    /// <param name="val">quantity measured in YoctoNewton</param>
    /// <returns>quantity measured in HectoNewton</returns>
	public static Quantity<double, HectoNewton> ToHectoNewton<T>(this BaseQuantity<T, YoctoNewton> val) where T:IConvertible {
        return new Quantity<double, HectoNewton>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoNewton to DekaNewton
    /// </summary>
    /// <param name="val">quantity measured in YoctoNewton</param>
    /// <returns>quantity measured in DekaNewton</returns>
	public static Quantity<double, DekaNewton> ToDekaNewton<T>(this BaseQuantity<T, YoctoNewton> val) where T:IConvertible {
        return new Quantity<double, DekaNewton>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoNewton to DeciNewton
    /// </summary>
    /// <param name="val">quantity measured in YoctoNewton</param>
    /// <returns>quantity measured in DeciNewton</returns>
	public static Quantity<double, DeciNewton> ToDeciNewton<T>(this BaseQuantity<T, YoctoNewton> val) where T:IConvertible {
        return new Quantity<double, DeciNewton>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoNewton to CentiNewton
    /// </summary>
    /// <param name="val">quantity measured in YoctoNewton</param>
    /// <returns>quantity measured in CentiNewton</returns>
	public static Quantity<double, CentiNewton> ToCentiNewton<T>(this BaseQuantity<T, YoctoNewton> val) where T:IConvertible {
        return new Quantity<double, CentiNewton>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoNewton to MilliNewton
    /// </summary>
    /// <param name="val">quantity measured in YoctoNewton</param>
    /// <returns>quantity measured in MilliNewton</returns>
	public static Quantity<double, MilliNewton> ToMilliNewton<T>(this BaseQuantity<T, YoctoNewton> val) where T:IConvertible {
        return new Quantity<double, MilliNewton>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoNewton to MicroNewton
    /// </summary>
    /// <param name="val">quantity measured in YoctoNewton</param>
    /// <returns>quantity measured in MicroNewton</returns>
	public static Quantity<double, MicroNewton> ToMicroNewton<T>(this BaseQuantity<T, YoctoNewton> val) where T:IConvertible {
        return new Quantity<double, MicroNewton>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoNewton to NanoNewton
    /// </summary>
    /// <param name="val">quantity measured in YoctoNewton</param>
    /// <returns>quantity measured in NanoNewton</returns>
	public static Quantity<double, NanoNewton> ToNanoNewton<T>(this BaseQuantity<T, YoctoNewton> val) where T:IConvertible {
        return new Quantity<double, NanoNewton>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoNewton to PicoNewton
    /// </summary>
    /// <param name="val">quantity measured in YoctoNewton</param>
    /// <returns>quantity measured in PicoNewton</returns>
	public static Quantity<double, PicoNewton> ToPicoNewton<T>(this BaseQuantity<T, YoctoNewton> val) where T:IConvertible {
        return new Quantity<double, PicoNewton>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoNewton to FemtoNewton
    /// </summary>
    /// <param name="val">quantity measured in YoctoNewton</param>
    /// <returns>quantity measured in FemtoNewton</returns>
	public static Quantity<double, FemtoNewton> ToFemtoNewton<T>(this BaseQuantity<T, YoctoNewton> val) where T:IConvertible {
        return new Quantity<double, FemtoNewton>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoNewton to AttoNewton
    /// </summary>
    /// <param name="val">quantity measured in YoctoNewton</param>
    /// <returns>quantity measured in AttoNewton</returns>
	public static Quantity<double, AttoNewton> ToAttoNewton<T>(this BaseQuantity<T, YoctoNewton> val) where T:IConvertible {
        return new Quantity<double, AttoNewton>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoNewton to ZeptoNewton
    /// </summary>
    /// <param name="val">quantity measured in YoctoNewton</param>
    /// <returns>quantity measured in ZeptoNewton</returns>
	public static Quantity<double, ZeptoNewton> ToZeptoNewton<T>(this BaseQuantity<T, YoctoNewton> val) where T:IConvertible {
        return new Quantity<double, ZeptoNewton>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
}
}