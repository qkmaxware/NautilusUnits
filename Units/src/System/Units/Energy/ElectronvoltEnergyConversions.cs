using System;
namespace System.Units.Energy {
public static class ElectronvoltEnergyConversions {
	/// <summary>
    /// Extension method to convert Electronvolt to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Electronvolt to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaElectronvolt to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YottaElectronvolt</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, YottaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaElectronvolt to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaElectronvolt</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, ZettaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaElectronvolt to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ExaElectronvolt</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, ExaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaElectronvolt to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PetaElectronvolt</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, PetaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraElectronvolt to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in TeraElectronvolt</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, TeraElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaElectronvolt to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in GigaElectronvolt</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, GigaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaElectronvolt to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MegaElectronvolt</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, MegaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloElectronvolt to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in KiloElectronvolt</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, KiloElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoElectronvolt to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in HectoElectronvolt</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, HectoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaElectronvolt to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DekaElectronvolt</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, DekaElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciElectronvolt to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in DeciElectronvolt</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, DeciElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiElectronvolt to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in CentiElectronvolt</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, CentiElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliElectronvolt to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MilliElectronvolt</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, MilliElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroElectronvolt to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in MicroElectronvolt</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, MicroElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoElectronvolt to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in NanoElectronvolt</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, NanoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoElectronvolt to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in PicoElectronvolt</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, PicoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoElectronvolt to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoElectronvolt</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, FemtoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoElectronvolt to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in AttoElectronvolt</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, AttoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoElectronvolt to YoctoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoElectronvolt</param>
    /// <returns>quantity measured in YoctoElectronvolt</returns>
	public static Quantity<double, YoctoElectronvolt> ToYoctoElectronvolt<T>(this Quantity<T, ZeptoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YoctoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to YottaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in YottaElectronvolt</returns>
	public static Quantity<double, YottaElectronvolt> ToYottaElectronvolt<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, YottaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to ZettaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in ZettaElectronvolt</returns>
	public static Quantity<double, ZettaElectronvolt> ToZettaElectronvolt<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZettaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to ExaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in ExaElectronvolt</returns>
	public static Quantity<double, ExaElectronvolt> ToExaElectronvolt<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ExaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to PetaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in PetaElectronvolt</returns>
	public static Quantity<double, PetaElectronvolt> ToPetaElectronvolt<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PetaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to TeraElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in TeraElectronvolt</returns>
	public static Quantity<double, TeraElectronvolt> ToTeraElectronvolt<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, TeraElectronvolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to GigaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in GigaElectronvolt</returns>
	public static Quantity<double, GigaElectronvolt> ToGigaElectronvolt<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, GigaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to MegaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in MegaElectronvolt</returns>
	public static Quantity<double, MegaElectronvolt> ToMegaElectronvolt<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MegaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to KiloElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in KiloElectronvolt</returns>
	public static Quantity<double, KiloElectronvolt> ToKiloElectronvolt<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, KiloElectronvolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to HectoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in HectoElectronvolt</returns>
	public static Quantity<double, HectoElectronvolt> ToHectoElectronvolt<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, HectoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to DekaElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in DekaElectronvolt</returns>
	public static Quantity<double, DekaElectronvolt> ToDekaElectronvolt<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DekaElectronvolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to DeciElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in DeciElectronvolt</returns>
	public static Quantity<double, DeciElectronvolt> ToDeciElectronvolt<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, DeciElectronvolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to CentiElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in CentiElectronvolt</returns>
	public static Quantity<double, CentiElectronvolt> ToCentiElectronvolt<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, CentiElectronvolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to MilliElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in MilliElectronvolt</returns>
	public static Quantity<double, MilliElectronvolt> ToMilliElectronvolt<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MilliElectronvolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to MicroElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in MicroElectronvolt</returns>
	public static Quantity<double, MicroElectronvolt> ToMicroElectronvolt<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, MicroElectronvolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to NanoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in NanoElectronvolt</returns>
	public static Quantity<double, NanoElectronvolt> ToNanoElectronvolt<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, NanoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to PicoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in PicoElectronvolt</returns>
	public static Quantity<double, PicoElectronvolt> ToPicoElectronvolt<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, PicoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to FemtoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in FemtoElectronvolt</returns>
	public static Quantity<double, FemtoElectronvolt> ToFemtoElectronvolt<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, FemtoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to AttoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in AttoElectronvolt</returns>
	public static Quantity<double, AttoElectronvolt> ToAttoElectronvolt<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, AttoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoElectronvolt to ZeptoElectronvolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoElectronvolt</param>
    /// <returns>quantity measured in ZeptoElectronvolt</returns>
	public static Quantity<double, ZeptoElectronvolt> ToZeptoElectronvolt<T>(this Quantity<T, YoctoElectronvolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoElectronvolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
}
}