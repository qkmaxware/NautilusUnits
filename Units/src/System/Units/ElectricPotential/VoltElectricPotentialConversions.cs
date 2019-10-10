using System;
namespace System.Units.ElectricPotential {
public static class ElectricPotentialConversions {
	/// <summary>
    /// Extension method to convert Volt to YottaVolt
    /// </summary>
    /// <param name="val">quantity measured in Volt</param>
    /// <returns>quantity measured in YottaVolt</returns>
	public static Quantity<double, YottaVolt> ToYottaVolt<T>(this Quantity<T, Volt> val) where T:IConvertible {
        return new Quantity<double, YottaVolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Volt to ZettaVolt
    /// </summary>
    /// <param name="val">quantity measured in Volt</param>
    /// <returns>quantity measured in ZettaVolt</returns>
	public static Quantity<double, ZettaVolt> ToZettaVolt<T>(this Quantity<T, Volt> val) where T:IConvertible {
        return new Quantity<double, ZettaVolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Volt to ExaVolt
    /// </summary>
    /// <param name="val">quantity measured in Volt</param>
    /// <returns>quantity measured in ExaVolt</returns>
	public static Quantity<double, ExaVolt> ToExaVolt<T>(this Quantity<T, Volt> val) where T:IConvertible {
        return new Quantity<double, ExaVolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Volt to PetaVolt
    /// </summary>
    /// <param name="val">quantity measured in Volt</param>
    /// <returns>quantity measured in PetaVolt</returns>
	public static Quantity<double, PetaVolt> ToPetaVolt<T>(this Quantity<T, Volt> val) where T:IConvertible {
        return new Quantity<double, PetaVolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Volt to TeraVolt
    /// </summary>
    /// <param name="val">quantity measured in Volt</param>
    /// <returns>quantity measured in TeraVolt</returns>
	public static Quantity<double, TeraVolt> ToTeraVolt<T>(this Quantity<T, Volt> val) where T:IConvertible {
        return new Quantity<double, TeraVolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Volt to GigaVolt
    /// </summary>
    /// <param name="val">quantity measured in Volt</param>
    /// <returns>quantity measured in GigaVolt</returns>
	public static Quantity<double, GigaVolt> ToGigaVolt<T>(this Quantity<T, Volt> val) where T:IConvertible {
        return new Quantity<double, GigaVolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Volt to MegaVolt
    /// </summary>
    /// <param name="val">quantity measured in Volt</param>
    /// <returns>quantity measured in MegaVolt</returns>
	public static Quantity<double, MegaVolt> ToMegaVolt<T>(this Quantity<T, Volt> val) where T:IConvertible {
        return new Quantity<double, MegaVolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Volt to KiloVolt
    /// </summary>
    /// <param name="val">quantity measured in Volt</param>
    /// <returns>quantity measured in KiloVolt</returns>
	public static Quantity<double, KiloVolt> ToKiloVolt<T>(this Quantity<T, Volt> val) where T:IConvertible {
        return new Quantity<double, KiloVolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Volt to HectoVolt
    /// </summary>
    /// <param name="val">quantity measured in Volt</param>
    /// <returns>quantity measured in HectoVolt</returns>
	public static Quantity<double, HectoVolt> ToHectoVolt<T>(this Quantity<T, Volt> val) where T:IConvertible {
        return new Quantity<double, HectoVolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Volt to DekaVolt
    /// </summary>
    /// <param name="val">quantity measured in Volt</param>
    /// <returns>quantity measured in DekaVolt</returns>
	public static Quantity<double, DekaVolt> ToDekaVolt<T>(this Quantity<T, Volt> val) where T:IConvertible {
        return new Quantity<double, DekaVolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Volt to DeciVolt
    /// </summary>
    /// <param name="val">quantity measured in Volt</param>
    /// <returns>quantity measured in DeciVolt</returns>
	public static Quantity<double, DeciVolt> ToDeciVolt<T>(this Quantity<T, Volt> val) where T:IConvertible {
        return new Quantity<double, DeciVolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Volt to CentiVolt
    /// </summary>
    /// <param name="val">quantity measured in Volt</param>
    /// <returns>quantity measured in CentiVolt</returns>
	public static Quantity<double, CentiVolt> ToCentiVolt<T>(this Quantity<T, Volt> val) where T:IConvertible {
        return new Quantity<double, CentiVolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Volt to MilliVolt
    /// </summary>
    /// <param name="val">quantity measured in Volt</param>
    /// <returns>quantity measured in MilliVolt</returns>
	public static Quantity<double, MilliVolt> ToMilliVolt<T>(this Quantity<T, Volt> val) where T:IConvertible {
        return new Quantity<double, MilliVolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Volt to MicroVolt
    /// </summary>
    /// <param name="val">quantity measured in Volt</param>
    /// <returns>quantity measured in MicroVolt</returns>
	public static Quantity<double, MicroVolt> ToMicroVolt<T>(this Quantity<T, Volt> val) where T:IConvertible {
        return new Quantity<double, MicroVolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Volt to NanoVolt
    /// </summary>
    /// <param name="val">quantity measured in Volt</param>
    /// <returns>quantity measured in NanoVolt</returns>
	public static Quantity<double, NanoVolt> ToNanoVolt<T>(this Quantity<T, Volt> val) where T:IConvertible {
        return new Quantity<double, NanoVolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Volt to PicoVolt
    /// </summary>
    /// <param name="val">quantity measured in Volt</param>
    /// <returns>quantity measured in PicoVolt</returns>
	public static Quantity<double, PicoVolt> ToPicoVolt<T>(this Quantity<T, Volt> val) where T:IConvertible {
        return new Quantity<double, PicoVolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Volt to FemtoVolt
    /// </summary>
    /// <param name="val">quantity measured in Volt</param>
    /// <returns>quantity measured in FemtoVolt</returns>
	public static Quantity<double, FemtoVolt> ToFemtoVolt<T>(this Quantity<T, Volt> val) where T:IConvertible {
        return new Quantity<double, FemtoVolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Volt to AttoVolt
    /// </summary>
    /// <param name="val">quantity measured in Volt</param>
    /// <returns>quantity measured in AttoVolt</returns>
	public static Quantity<double, AttoVolt> ToAttoVolt<T>(this Quantity<T, Volt> val) where T:IConvertible {
        return new Quantity<double, AttoVolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Volt to ZeptoVolt
    /// </summary>
    /// <param name="val">quantity measured in Volt</param>
    /// <returns>quantity measured in ZeptoVolt</returns>
	public static Quantity<double, ZeptoVolt> ToZeptoVolt<T>(this Quantity<T, Volt> val) where T:IConvertible {
        return new Quantity<double, ZeptoVolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Volt to YoctoVolt
    /// </summary>
    /// <param name="val">quantity measured in Volt</param>
    /// <returns>quantity measured in YoctoVolt</returns>
	public static Quantity<double, YoctoVolt> ToYoctoVolt<T>(this Quantity<T, Volt> val) where T:IConvertible {
        return new Quantity<double, YoctoVolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YottaVolt to ZettaVolt
    /// </summary>
    /// <param name="val">quantity measured in YottaVolt</param>
    /// <returns>quantity measured in ZettaVolt</returns>
	public static Quantity<double, ZettaVolt> ToZettaVolt<T>(this Quantity<T, YottaVolt> val) where T:IConvertible {
        return new Quantity<double, ZettaVolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaVolt to ExaVolt
    /// </summary>
    /// <param name="val">quantity measured in YottaVolt</param>
    /// <returns>quantity measured in ExaVolt</returns>
	public static Quantity<double, ExaVolt> ToExaVolt<T>(this Quantity<T, YottaVolt> val) where T:IConvertible {
        return new Quantity<double, ExaVolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaVolt to PetaVolt
    /// </summary>
    /// <param name="val">quantity measured in YottaVolt</param>
    /// <returns>quantity measured in PetaVolt</returns>
	public static Quantity<double, PetaVolt> ToPetaVolt<T>(this Quantity<T, YottaVolt> val) where T:IConvertible {
        return new Quantity<double, PetaVolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaVolt to TeraVolt
    /// </summary>
    /// <param name="val">quantity measured in YottaVolt</param>
    /// <returns>quantity measured in TeraVolt</returns>
	public static Quantity<double, TeraVolt> ToTeraVolt<T>(this Quantity<T, YottaVolt> val) where T:IConvertible {
        return new Quantity<double, TeraVolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaVolt to GigaVolt
    /// </summary>
    /// <param name="val">quantity measured in YottaVolt</param>
    /// <returns>quantity measured in GigaVolt</returns>
	public static Quantity<double, GigaVolt> ToGigaVolt<T>(this Quantity<T, YottaVolt> val) where T:IConvertible {
        return new Quantity<double, GigaVolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaVolt to MegaVolt
    /// </summary>
    /// <param name="val">quantity measured in YottaVolt</param>
    /// <returns>quantity measured in MegaVolt</returns>
	public static Quantity<double, MegaVolt> ToMegaVolt<T>(this Quantity<T, YottaVolt> val) where T:IConvertible {
        return new Quantity<double, MegaVolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaVolt to KiloVolt
    /// </summary>
    /// <param name="val">quantity measured in YottaVolt</param>
    /// <returns>quantity measured in KiloVolt</returns>
	public static Quantity<double, KiloVolt> ToKiloVolt<T>(this Quantity<T, YottaVolt> val) where T:IConvertible {
        return new Quantity<double, KiloVolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaVolt to HectoVolt
    /// </summary>
    /// <param name="val">quantity measured in YottaVolt</param>
    /// <returns>quantity measured in HectoVolt</returns>
	public static Quantity<double, HectoVolt> ToHectoVolt<T>(this Quantity<T, YottaVolt> val) where T:IConvertible {
        return new Quantity<double, HectoVolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaVolt to DekaVolt
    /// </summary>
    /// <param name="val">quantity measured in YottaVolt</param>
    /// <returns>quantity measured in DekaVolt</returns>
	public static Quantity<double, DekaVolt> ToDekaVolt<T>(this Quantity<T, YottaVolt> val) where T:IConvertible {
        return new Quantity<double, DekaVolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaVolt to DeciVolt
    /// </summary>
    /// <param name="val">quantity measured in YottaVolt</param>
    /// <returns>quantity measured in DeciVolt</returns>
	public static Quantity<double, DeciVolt> ToDeciVolt<T>(this Quantity<T, YottaVolt> val) where T:IConvertible {
        return new Quantity<double, DeciVolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaVolt to CentiVolt
    /// </summary>
    /// <param name="val">quantity measured in YottaVolt</param>
    /// <returns>quantity measured in CentiVolt</returns>
	public static Quantity<double, CentiVolt> ToCentiVolt<T>(this Quantity<T, YottaVolt> val) where T:IConvertible {
        return new Quantity<double, CentiVolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaVolt to MilliVolt
    /// </summary>
    /// <param name="val">quantity measured in YottaVolt</param>
    /// <returns>quantity measured in MilliVolt</returns>
	public static Quantity<double, MilliVolt> ToMilliVolt<T>(this Quantity<T, YottaVolt> val) where T:IConvertible {
        return new Quantity<double, MilliVolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaVolt to MicroVolt
    /// </summary>
    /// <param name="val">quantity measured in YottaVolt</param>
    /// <returns>quantity measured in MicroVolt</returns>
	public static Quantity<double, MicroVolt> ToMicroVolt<T>(this Quantity<T, YottaVolt> val) where T:IConvertible {
        return new Quantity<double, MicroVolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaVolt to NanoVolt
    /// </summary>
    /// <param name="val">quantity measured in YottaVolt</param>
    /// <returns>quantity measured in NanoVolt</returns>
	public static Quantity<double, NanoVolt> ToNanoVolt<T>(this Quantity<T, YottaVolt> val) where T:IConvertible {
        return new Quantity<double, NanoVolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaVolt to PicoVolt
    /// </summary>
    /// <param name="val">quantity measured in YottaVolt</param>
    /// <returns>quantity measured in PicoVolt</returns>
	public static Quantity<double, PicoVolt> ToPicoVolt<T>(this Quantity<T, YottaVolt> val) where T:IConvertible {
        return new Quantity<double, PicoVolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaVolt to FemtoVolt
    /// </summary>
    /// <param name="val">quantity measured in YottaVolt</param>
    /// <returns>quantity measured in FemtoVolt</returns>
	public static Quantity<double, FemtoVolt> ToFemtoVolt<T>(this Quantity<T, YottaVolt> val) where T:IConvertible {
        return new Quantity<double, FemtoVolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaVolt to AttoVolt
    /// </summary>
    /// <param name="val">quantity measured in YottaVolt</param>
    /// <returns>quantity measured in AttoVolt</returns>
	public static Quantity<double, AttoVolt> ToAttoVolt<T>(this Quantity<T, YottaVolt> val) where T:IConvertible {
        return new Quantity<double, AttoVolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaVolt to ZeptoVolt
    /// </summary>
    /// <param name="val">quantity measured in YottaVolt</param>
    /// <returns>quantity measured in ZeptoVolt</returns>
	public static Quantity<double, ZeptoVolt> ToZeptoVolt<T>(this Quantity<T, YottaVolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoVolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaVolt to YoctoVolt
    /// </summary>
    /// <param name="val">quantity measured in YottaVolt</param>
    /// <returns>quantity measured in YoctoVolt</returns>
	public static Quantity<double, YoctoVolt> ToYoctoVolt<T>(this Quantity<T, YottaVolt> val) where T:IConvertible {
        return new Quantity<double, YoctoVolt>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert ZettaVolt to YottaVolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaVolt</param>
    /// <returns>quantity measured in YottaVolt</returns>
	public static Quantity<double, YottaVolt> ToYottaVolt<T>(this Quantity<T, ZettaVolt> val) where T:IConvertible {
        return new Quantity<double, YottaVolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaVolt to ExaVolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaVolt</param>
    /// <returns>quantity measured in ExaVolt</returns>
	public static Quantity<double, ExaVolt> ToExaVolt<T>(this Quantity<T, ZettaVolt> val) where T:IConvertible {
        return new Quantity<double, ExaVolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaVolt to PetaVolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaVolt</param>
    /// <returns>quantity measured in PetaVolt</returns>
	public static Quantity<double, PetaVolt> ToPetaVolt<T>(this Quantity<T, ZettaVolt> val) where T:IConvertible {
        return new Quantity<double, PetaVolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaVolt to TeraVolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaVolt</param>
    /// <returns>quantity measured in TeraVolt</returns>
	public static Quantity<double, TeraVolt> ToTeraVolt<T>(this Quantity<T, ZettaVolt> val) where T:IConvertible {
        return new Quantity<double, TeraVolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaVolt to GigaVolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaVolt</param>
    /// <returns>quantity measured in GigaVolt</returns>
	public static Quantity<double, GigaVolt> ToGigaVolt<T>(this Quantity<T, ZettaVolt> val) where T:IConvertible {
        return new Quantity<double, GigaVolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaVolt to MegaVolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaVolt</param>
    /// <returns>quantity measured in MegaVolt</returns>
	public static Quantity<double, MegaVolt> ToMegaVolt<T>(this Quantity<T, ZettaVolt> val) where T:IConvertible {
        return new Quantity<double, MegaVolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaVolt to KiloVolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaVolt</param>
    /// <returns>quantity measured in KiloVolt</returns>
	public static Quantity<double, KiloVolt> ToKiloVolt<T>(this Quantity<T, ZettaVolt> val) where T:IConvertible {
        return new Quantity<double, KiloVolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaVolt to HectoVolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaVolt</param>
    /// <returns>quantity measured in HectoVolt</returns>
	public static Quantity<double, HectoVolt> ToHectoVolt<T>(this Quantity<T, ZettaVolt> val) where T:IConvertible {
        return new Quantity<double, HectoVolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaVolt to DekaVolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaVolt</param>
    /// <returns>quantity measured in DekaVolt</returns>
	public static Quantity<double, DekaVolt> ToDekaVolt<T>(this Quantity<T, ZettaVolt> val) where T:IConvertible {
        return new Quantity<double, DekaVolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaVolt to DeciVolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaVolt</param>
    /// <returns>quantity measured in DeciVolt</returns>
	public static Quantity<double, DeciVolt> ToDeciVolt<T>(this Quantity<T, ZettaVolt> val) where T:IConvertible {
        return new Quantity<double, DeciVolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaVolt to CentiVolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaVolt</param>
    /// <returns>quantity measured in CentiVolt</returns>
	public static Quantity<double, CentiVolt> ToCentiVolt<T>(this Quantity<T, ZettaVolt> val) where T:IConvertible {
        return new Quantity<double, CentiVolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaVolt to MilliVolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaVolt</param>
    /// <returns>quantity measured in MilliVolt</returns>
	public static Quantity<double, MilliVolt> ToMilliVolt<T>(this Quantity<T, ZettaVolt> val) where T:IConvertible {
        return new Quantity<double, MilliVolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaVolt to MicroVolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaVolt</param>
    /// <returns>quantity measured in MicroVolt</returns>
	public static Quantity<double, MicroVolt> ToMicroVolt<T>(this Quantity<T, ZettaVolt> val) where T:IConvertible {
        return new Quantity<double, MicroVolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaVolt to NanoVolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaVolt</param>
    /// <returns>quantity measured in NanoVolt</returns>
	public static Quantity<double, NanoVolt> ToNanoVolt<T>(this Quantity<T, ZettaVolt> val) where T:IConvertible {
        return new Quantity<double, NanoVolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaVolt to PicoVolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaVolt</param>
    /// <returns>quantity measured in PicoVolt</returns>
	public static Quantity<double, PicoVolt> ToPicoVolt<T>(this Quantity<T, ZettaVolt> val) where T:IConvertible {
        return new Quantity<double, PicoVolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaVolt to FemtoVolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaVolt</param>
    /// <returns>quantity measured in FemtoVolt</returns>
	public static Quantity<double, FemtoVolt> ToFemtoVolt<T>(this Quantity<T, ZettaVolt> val) where T:IConvertible {
        return new Quantity<double, FemtoVolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaVolt to AttoVolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaVolt</param>
    /// <returns>quantity measured in AttoVolt</returns>
	public static Quantity<double, AttoVolt> ToAttoVolt<T>(this Quantity<T, ZettaVolt> val) where T:IConvertible {
        return new Quantity<double, AttoVolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaVolt to ZeptoVolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaVolt</param>
    /// <returns>quantity measured in ZeptoVolt</returns>
	public static Quantity<double, ZeptoVolt> ToZeptoVolt<T>(this Quantity<T, ZettaVolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoVolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaVolt to YoctoVolt
    /// </summary>
    /// <param name="val">quantity measured in ZettaVolt</param>
    /// <returns>quantity measured in YoctoVolt</returns>
	public static Quantity<double, YoctoVolt> ToYoctoVolt<T>(this Quantity<T, ZettaVolt> val) where T:IConvertible {
        return new Quantity<double, YoctoVolt>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ExaVolt to YottaVolt
    /// </summary>
    /// <param name="val">quantity measured in ExaVolt</param>
    /// <returns>quantity measured in YottaVolt</returns>
	public static Quantity<double, YottaVolt> ToYottaVolt<T>(this Quantity<T, ExaVolt> val) where T:IConvertible {
        return new Quantity<double, YottaVolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaVolt to ZettaVolt
    /// </summary>
    /// <param name="val">quantity measured in ExaVolt</param>
    /// <returns>quantity measured in ZettaVolt</returns>
	public static Quantity<double, ZettaVolt> ToZettaVolt<T>(this Quantity<T, ExaVolt> val) where T:IConvertible {
        return new Quantity<double, ZettaVolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaVolt to PetaVolt
    /// </summary>
    /// <param name="val">quantity measured in ExaVolt</param>
    /// <returns>quantity measured in PetaVolt</returns>
	public static Quantity<double, PetaVolt> ToPetaVolt<T>(this Quantity<T, ExaVolt> val) where T:IConvertible {
        return new Quantity<double, PetaVolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaVolt to TeraVolt
    /// </summary>
    /// <param name="val">quantity measured in ExaVolt</param>
    /// <returns>quantity measured in TeraVolt</returns>
	public static Quantity<double, TeraVolt> ToTeraVolt<T>(this Quantity<T, ExaVolt> val) where T:IConvertible {
        return new Quantity<double, TeraVolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaVolt to GigaVolt
    /// </summary>
    /// <param name="val">quantity measured in ExaVolt</param>
    /// <returns>quantity measured in GigaVolt</returns>
	public static Quantity<double, GigaVolt> ToGigaVolt<T>(this Quantity<T, ExaVolt> val) where T:IConvertible {
        return new Quantity<double, GigaVolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaVolt to MegaVolt
    /// </summary>
    /// <param name="val">quantity measured in ExaVolt</param>
    /// <returns>quantity measured in MegaVolt</returns>
	public static Quantity<double, MegaVolt> ToMegaVolt<T>(this Quantity<T, ExaVolt> val) where T:IConvertible {
        return new Quantity<double, MegaVolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaVolt to KiloVolt
    /// </summary>
    /// <param name="val">quantity measured in ExaVolt</param>
    /// <returns>quantity measured in KiloVolt</returns>
	public static Quantity<double, KiloVolt> ToKiloVolt<T>(this Quantity<T, ExaVolt> val) where T:IConvertible {
        return new Quantity<double, KiloVolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaVolt to HectoVolt
    /// </summary>
    /// <param name="val">quantity measured in ExaVolt</param>
    /// <returns>quantity measured in HectoVolt</returns>
	public static Quantity<double, HectoVolt> ToHectoVolt<T>(this Quantity<T, ExaVolt> val) where T:IConvertible {
        return new Quantity<double, HectoVolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaVolt to DekaVolt
    /// </summary>
    /// <param name="val">quantity measured in ExaVolt</param>
    /// <returns>quantity measured in DekaVolt</returns>
	public static Quantity<double, DekaVolt> ToDekaVolt<T>(this Quantity<T, ExaVolt> val) where T:IConvertible {
        return new Quantity<double, DekaVolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaVolt to DeciVolt
    /// </summary>
    /// <param name="val">quantity measured in ExaVolt</param>
    /// <returns>quantity measured in DeciVolt</returns>
	public static Quantity<double, DeciVolt> ToDeciVolt<T>(this Quantity<T, ExaVolt> val) where T:IConvertible {
        return new Quantity<double, DeciVolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaVolt to CentiVolt
    /// </summary>
    /// <param name="val">quantity measured in ExaVolt</param>
    /// <returns>quantity measured in CentiVolt</returns>
	public static Quantity<double, CentiVolt> ToCentiVolt<T>(this Quantity<T, ExaVolt> val) where T:IConvertible {
        return new Quantity<double, CentiVolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaVolt to MilliVolt
    /// </summary>
    /// <param name="val">quantity measured in ExaVolt</param>
    /// <returns>quantity measured in MilliVolt</returns>
	public static Quantity<double, MilliVolt> ToMilliVolt<T>(this Quantity<T, ExaVolt> val) where T:IConvertible {
        return new Quantity<double, MilliVolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaVolt to MicroVolt
    /// </summary>
    /// <param name="val">quantity measured in ExaVolt</param>
    /// <returns>quantity measured in MicroVolt</returns>
	public static Quantity<double, MicroVolt> ToMicroVolt<T>(this Quantity<T, ExaVolt> val) where T:IConvertible {
        return new Quantity<double, MicroVolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaVolt to NanoVolt
    /// </summary>
    /// <param name="val">quantity measured in ExaVolt</param>
    /// <returns>quantity measured in NanoVolt</returns>
	public static Quantity<double, NanoVolt> ToNanoVolt<T>(this Quantity<T, ExaVolt> val) where T:IConvertible {
        return new Quantity<double, NanoVolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaVolt to PicoVolt
    /// </summary>
    /// <param name="val">quantity measured in ExaVolt</param>
    /// <returns>quantity measured in PicoVolt</returns>
	public static Quantity<double, PicoVolt> ToPicoVolt<T>(this Quantity<T, ExaVolt> val) where T:IConvertible {
        return new Quantity<double, PicoVolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaVolt to FemtoVolt
    /// </summary>
    /// <param name="val">quantity measured in ExaVolt</param>
    /// <returns>quantity measured in FemtoVolt</returns>
	public static Quantity<double, FemtoVolt> ToFemtoVolt<T>(this Quantity<T, ExaVolt> val) where T:IConvertible {
        return new Quantity<double, FemtoVolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaVolt to AttoVolt
    /// </summary>
    /// <param name="val">quantity measured in ExaVolt</param>
    /// <returns>quantity measured in AttoVolt</returns>
	public static Quantity<double, AttoVolt> ToAttoVolt<T>(this Quantity<T, ExaVolt> val) where T:IConvertible {
        return new Quantity<double, AttoVolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaVolt to ZeptoVolt
    /// </summary>
    /// <param name="val">quantity measured in ExaVolt</param>
    /// <returns>quantity measured in ZeptoVolt</returns>
	public static Quantity<double, ZeptoVolt> ToZeptoVolt<T>(this Quantity<T, ExaVolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoVolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaVolt to YoctoVolt
    /// </summary>
    /// <param name="val">quantity measured in ExaVolt</param>
    /// <returns>quantity measured in YoctoVolt</returns>
	public static Quantity<double, YoctoVolt> ToYoctoVolt<T>(this Quantity<T, ExaVolt> val) where T:IConvertible {
        return new Quantity<double, YoctoVolt>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert PetaVolt to YottaVolt
    /// </summary>
    /// <param name="val">quantity measured in PetaVolt</param>
    /// <returns>quantity measured in YottaVolt</returns>
	public static Quantity<double, YottaVolt> ToYottaVolt<T>(this Quantity<T, PetaVolt> val) where T:IConvertible {
        return new Quantity<double, YottaVolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaVolt to ZettaVolt
    /// </summary>
    /// <param name="val">quantity measured in PetaVolt</param>
    /// <returns>quantity measured in ZettaVolt</returns>
	public static Quantity<double, ZettaVolt> ToZettaVolt<T>(this Quantity<T, PetaVolt> val) where T:IConvertible {
        return new Quantity<double, ZettaVolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaVolt to ExaVolt
    /// </summary>
    /// <param name="val">quantity measured in PetaVolt</param>
    /// <returns>quantity measured in ExaVolt</returns>
	public static Quantity<double, ExaVolt> ToExaVolt<T>(this Quantity<T, PetaVolt> val) where T:IConvertible {
        return new Quantity<double, ExaVolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaVolt to TeraVolt
    /// </summary>
    /// <param name="val">quantity measured in PetaVolt</param>
    /// <returns>quantity measured in TeraVolt</returns>
	public static Quantity<double, TeraVolt> ToTeraVolt<T>(this Quantity<T, PetaVolt> val) where T:IConvertible {
        return new Quantity<double, TeraVolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaVolt to GigaVolt
    /// </summary>
    /// <param name="val">quantity measured in PetaVolt</param>
    /// <returns>quantity measured in GigaVolt</returns>
	public static Quantity<double, GigaVolt> ToGigaVolt<T>(this Quantity<T, PetaVolt> val) where T:IConvertible {
        return new Quantity<double, GigaVolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaVolt to MegaVolt
    /// </summary>
    /// <param name="val">quantity measured in PetaVolt</param>
    /// <returns>quantity measured in MegaVolt</returns>
	public static Quantity<double, MegaVolt> ToMegaVolt<T>(this Quantity<T, PetaVolt> val) where T:IConvertible {
        return new Quantity<double, MegaVolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaVolt to KiloVolt
    /// </summary>
    /// <param name="val">quantity measured in PetaVolt</param>
    /// <returns>quantity measured in KiloVolt</returns>
	public static Quantity<double, KiloVolt> ToKiloVolt<T>(this Quantity<T, PetaVolt> val) where T:IConvertible {
        return new Quantity<double, KiloVolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaVolt to HectoVolt
    /// </summary>
    /// <param name="val">quantity measured in PetaVolt</param>
    /// <returns>quantity measured in HectoVolt</returns>
	public static Quantity<double, HectoVolt> ToHectoVolt<T>(this Quantity<T, PetaVolt> val) where T:IConvertible {
        return new Quantity<double, HectoVolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaVolt to DekaVolt
    /// </summary>
    /// <param name="val">quantity measured in PetaVolt</param>
    /// <returns>quantity measured in DekaVolt</returns>
	public static Quantity<double, DekaVolt> ToDekaVolt<T>(this Quantity<T, PetaVolt> val) where T:IConvertible {
        return new Quantity<double, DekaVolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaVolt to DeciVolt
    /// </summary>
    /// <param name="val">quantity measured in PetaVolt</param>
    /// <returns>quantity measured in DeciVolt</returns>
	public static Quantity<double, DeciVolt> ToDeciVolt<T>(this Quantity<T, PetaVolt> val) where T:IConvertible {
        return new Quantity<double, DeciVolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaVolt to CentiVolt
    /// </summary>
    /// <param name="val">quantity measured in PetaVolt</param>
    /// <returns>quantity measured in CentiVolt</returns>
	public static Quantity<double, CentiVolt> ToCentiVolt<T>(this Quantity<T, PetaVolt> val) where T:IConvertible {
        return new Quantity<double, CentiVolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaVolt to MilliVolt
    /// </summary>
    /// <param name="val">quantity measured in PetaVolt</param>
    /// <returns>quantity measured in MilliVolt</returns>
	public static Quantity<double, MilliVolt> ToMilliVolt<T>(this Quantity<T, PetaVolt> val) where T:IConvertible {
        return new Quantity<double, MilliVolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaVolt to MicroVolt
    /// </summary>
    /// <param name="val">quantity measured in PetaVolt</param>
    /// <returns>quantity measured in MicroVolt</returns>
	public static Quantity<double, MicroVolt> ToMicroVolt<T>(this Quantity<T, PetaVolt> val) where T:IConvertible {
        return new Quantity<double, MicroVolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaVolt to NanoVolt
    /// </summary>
    /// <param name="val">quantity measured in PetaVolt</param>
    /// <returns>quantity measured in NanoVolt</returns>
	public static Quantity<double, NanoVolt> ToNanoVolt<T>(this Quantity<T, PetaVolt> val) where T:IConvertible {
        return new Quantity<double, NanoVolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaVolt to PicoVolt
    /// </summary>
    /// <param name="val">quantity measured in PetaVolt</param>
    /// <returns>quantity measured in PicoVolt</returns>
	public static Quantity<double, PicoVolt> ToPicoVolt<T>(this Quantity<T, PetaVolt> val) where T:IConvertible {
        return new Quantity<double, PicoVolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaVolt to FemtoVolt
    /// </summary>
    /// <param name="val">quantity measured in PetaVolt</param>
    /// <returns>quantity measured in FemtoVolt</returns>
	public static Quantity<double, FemtoVolt> ToFemtoVolt<T>(this Quantity<T, PetaVolt> val) where T:IConvertible {
        return new Quantity<double, FemtoVolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaVolt to AttoVolt
    /// </summary>
    /// <param name="val">quantity measured in PetaVolt</param>
    /// <returns>quantity measured in AttoVolt</returns>
	public static Quantity<double, AttoVolt> ToAttoVolt<T>(this Quantity<T, PetaVolt> val) where T:IConvertible {
        return new Quantity<double, AttoVolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaVolt to ZeptoVolt
    /// </summary>
    /// <param name="val">quantity measured in PetaVolt</param>
    /// <returns>quantity measured in ZeptoVolt</returns>
	public static Quantity<double, ZeptoVolt> ToZeptoVolt<T>(this Quantity<T, PetaVolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoVolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaVolt to YoctoVolt
    /// </summary>
    /// <param name="val">quantity measured in PetaVolt</param>
    /// <returns>quantity measured in YoctoVolt</returns>
	public static Quantity<double, YoctoVolt> ToYoctoVolt<T>(this Quantity<T, PetaVolt> val) where T:IConvertible {
        return new Quantity<double, YoctoVolt>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert TeraVolt to YottaVolt
    /// </summary>
    /// <param name="val">quantity measured in TeraVolt</param>
    /// <returns>quantity measured in YottaVolt</returns>
	public static Quantity<double, YottaVolt> ToYottaVolt<T>(this Quantity<T, TeraVolt> val) where T:IConvertible {
        return new Quantity<double, YottaVolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraVolt to ZettaVolt
    /// </summary>
    /// <param name="val">quantity measured in TeraVolt</param>
    /// <returns>quantity measured in ZettaVolt</returns>
	public static Quantity<double, ZettaVolt> ToZettaVolt<T>(this Quantity<T, TeraVolt> val) where T:IConvertible {
        return new Quantity<double, ZettaVolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraVolt to ExaVolt
    /// </summary>
    /// <param name="val">quantity measured in TeraVolt</param>
    /// <returns>quantity measured in ExaVolt</returns>
	public static Quantity<double, ExaVolt> ToExaVolt<T>(this Quantity<T, TeraVolt> val) where T:IConvertible {
        return new Quantity<double, ExaVolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraVolt to PetaVolt
    /// </summary>
    /// <param name="val">quantity measured in TeraVolt</param>
    /// <returns>quantity measured in PetaVolt</returns>
	public static Quantity<double, PetaVolt> ToPetaVolt<T>(this Quantity<T, TeraVolt> val) where T:IConvertible {
        return new Quantity<double, PetaVolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraVolt to GigaVolt
    /// </summary>
    /// <param name="val">quantity measured in TeraVolt</param>
    /// <returns>quantity measured in GigaVolt</returns>
	public static Quantity<double, GigaVolt> ToGigaVolt<T>(this Quantity<T, TeraVolt> val) where T:IConvertible {
        return new Quantity<double, GigaVolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraVolt to MegaVolt
    /// </summary>
    /// <param name="val">quantity measured in TeraVolt</param>
    /// <returns>quantity measured in MegaVolt</returns>
	public static Quantity<double, MegaVolt> ToMegaVolt<T>(this Quantity<T, TeraVolt> val) where T:IConvertible {
        return new Quantity<double, MegaVolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraVolt to KiloVolt
    /// </summary>
    /// <param name="val">quantity measured in TeraVolt</param>
    /// <returns>quantity measured in KiloVolt</returns>
	public static Quantity<double, KiloVolt> ToKiloVolt<T>(this Quantity<T, TeraVolt> val) where T:IConvertible {
        return new Quantity<double, KiloVolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraVolt to HectoVolt
    /// </summary>
    /// <param name="val">quantity measured in TeraVolt</param>
    /// <returns>quantity measured in HectoVolt</returns>
	public static Quantity<double, HectoVolt> ToHectoVolt<T>(this Quantity<T, TeraVolt> val) where T:IConvertible {
        return new Quantity<double, HectoVolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraVolt to DekaVolt
    /// </summary>
    /// <param name="val">quantity measured in TeraVolt</param>
    /// <returns>quantity measured in DekaVolt</returns>
	public static Quantity<double, DekaVolt> ToDekaVolt<T>(this Quantity<T, TeraVolt> val) where T:IConvertible {
        return new Quantity<double, DekaVolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraVolt to DeciVolt
    /// </summary>
    /// <param name="val">quantity measured in TeraVolt</param>
    /// <returns>quantity measured in DeciVolt</returns>
	public static Quantity<double, DeciVolt> ToDeciVolt<T>(this Quantity<T, TeraVolt> val) where T:IConvertible {
        return new Quantity<double, DeciVolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraVolt to CentiVolt
    /// </summary>
    /// <param name="val">quantity measured in TeraVolt</param>
    /// <returns>quantity measured in CentiVolt</returns>
	public static Quantity<double, CentiVolt> ToCentiVolt<T>(this Quantity<T, TeraVolt> val) where T:IConvertible {
        return new Quantity<double, CentiVolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraVolt to MilliVolt
    /// </summary>
    /// <param name="val">quantity measured in TeraVolt</param>
    /// <returns>quantity measured in MilliVolt</returns>
	public static Quantity<double, MilliVolt> ToMilliVolt<T>(this Quantity<T, TeraVolt> val) where T:IConvertible {
        return new Quantity<double, MilliVolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraVolt to MicroVolt
    /// </summary>
    /// <param name="val">quantity measured in TeraVolt</param>
    /// <returns>quantity measured in MicroVolt</returns>
	public static Quantity<double, MicroVolt> ToMicroVolt<T>(this Quantity<T, TeraVolt> val) where T:IConvertible {
        return new Quantity<double, MicroVolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraVolt to NanoVolt
    /// </summary>
    /// <param name="val">quantity measured in TeraVolt</param>
    /// <returns>quantity measured in NanoVolt</returns>
	public static Quantity<double, NanoVolt> ToNanoVolt<T>(this Quantity<T, TeraVolt> val) where T:IConvertible {
        return new Quantity<double, NanoVolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraVolt to PicoVolt
    /// </summary>
    /// <param name="val">quantity measured in TeraVolt</param>
    /// <returns>quantity measured in PicoVolt</returns>
	public static Quantity<double, PicoVolt> ToPicoVolt<T>(this Quantity<T, TeraVolt> val) where T:IConvertible {
        return new Quantity<double, PicoVolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraVolt to FemtoVolt
    /// </summary>
    /// <param name="val">quantity measured in TeraVolt</param>
    /// <returns>quantity measured in FemtoVolt</returns>
	public static Quantity<double, FemtoVolt> ToFemtoVolt<T>(this Quantity<T, TeraVolt> val) where T:IConvertible {
        return new Quantity<double, FemtoVolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraVolt to AttoVolt
    /// </summary>
    /// <param name="val">quantity measured in TeraVolt</param>
    /// <returns>quantity measured in AttoVolt</returns>
	public static Quantity<double, AttoVolt> ToAttoVolt<T>(this Quantity<T, TeraVolt> val) where T:IConvertible {
        return new Quantity<double, AttoVolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraVolt to ZeptoVolt
    /// </summary>
    /// <param name="val">quantity measured in TeraVolt</param>
    /// <returns>quantity measured in ZeptoVolt</returns>
	public static Quantity<double, ZeptoVolt> ToZeptoVolt<T>(this Quantity<T, TeraVolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoVolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraVolt to YoctoVolt
    /// </summary>
    /// <param name="val">quantity measured in TeraVolt</param>
    /// <returns>quantity measured in YoctoVolt</returns>
	public static Quantity<double, YoctoVolt> ToYoctoVolt<T>(this Quantity<T, TeraVolt> val) where T:IConvertible {
        return new Quantity<double, YoctoVolt>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert GigaVolt to YottaVolt
    /// </summary>
    /// <param name="val">quantity measured in GigaVolt</param>
    /// <returns>quantity measured in YottaVolt</returns>
	public static Quantity<double, YottaVolt> ToYottaVolt<T>(this Quantity<T, GigaVolt> val) where T:IConvertible {
        return new Quantity<double, YottaVolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaVolt to ZettaVolt
    /// </summary>
    /// <param name="val">quantity measured in GigaVolt</param>
    /// <returns>quantity measured in ZettaVolt</returns>
	public static Quantity<double, ZettaVolt> ToZettaVolt<T>(this Quantity<T, GigaVolt> val) where T:IConvertible {
        return new Quantity<double, ZettaVolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaVolt to ExaVolt
    /// </summary>
    /// <param name="val">quantity measured in GigaVolt</param>
    /// <returns>quantity measured in ExaVolt</returns>
	public static Quantity<double, ExaVolt> ToExaVolt<T>(this Quantity<T, GigaVolt> val) where T:IConvertible {
        return new Quantity<double, ExaVolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaVolt to PetaVolt
    /// </summary>
    /// <param name="val">quantity measured in GigaVolt</param>
    /// <returns>quantity measured in PetaVolt</returns>
	public static Quantity<double, PetaVolt> ToPetaVolt<T>(this Quantity<T, GigaVolt> val) where T:IConvertible {
        return new Quantity<double, PetaVolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaVolt to TeraVolt
    /// </summary>
    /// <param name="val">quantity measured in GigaVolt</param>
    /// <returns>quantity measured in TeraVolt</returns>
	public static Quantity<double, TeraVolt> ToTeraVolt<T>(this Quantity<T, GigaVolt> val) where T:IConvertible {
        return new Quantity<double, TeraVolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaVolt to MegaVolt
    /// </summary>
    /// <param name="val">quantity measured in GigaVolt</param>
    /// <returns>quantity measured in MegaVolt</returns>
	public static Quantity<double, MegaVolt> ToMegaVolt<T>(this Quantity<T, GigaVolt> val) where T:IConvertible {
        return new Quantity<double, MegaVolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaVolt to KiloVolt
    /// </summary>
    /// <param name="val">quantity measured in GigaVolt</param>
    /// <returns>quantity measured in KiloVolt</returns>
	public static Quantity<double, KiloVolt> ToKiloVolt<T>(this Quantity<T, GigaVolt> val) where T:IConvertible {
        return new Quantity<double, KiloVolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaVolt to HectoVolt
    /// </summary>
    /// <param name="val">quantity measured in GigaVolt</param>
    /// <returns>quantity measured in HectoVolt</returns>
	public static Quantity<double, HectoVolt> ToHectoVolt<T>(this Quantity<T, GigaVolt> val) where T:IConvertible {
        return new Quantity<double, HectoVolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaVolt to DekaVolt
    /// </summary>
    /// <param name="val">quantity measured in GigaVolt</param>
    /// <returns>quantity measured in DekaVolt</returns>
	public static Quantity<double, DekaVolt> ToDekaVolt<T>(this Quantity<T, GigaVolt> val) where T:IConvertible {
        return new Quantity<double, DekaVolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaVolt to DeciVolt
    /// </summary>
    /// <param name="val">quantity measured in GigaVolt</param>
    /// <returns>quantity measured in DeciVolt</returns>
	public static Quantity<double, DeciVolt> ToDeciVolt<T>(this Quantity<T, GigaVolt> val) where T:IConvertible {
        return new Quantity<double, DeciVolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaVolt to CentiVolt
    /// </summary>
    /// <param name="val">quantity measured in GigaVolt</param>
    /// <returns>quantity measured in CentiVolt</returns>
	public static Quantity<double, CentiVolt> ToCentiVolt<T>(this Quantity<T, GigaVolt> val) where T:IConvertible {
        return new Quantity<double, CentiVolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaVolt to MilliVolt
    /// </summary>
    /// <param name="val">quantity measured in GigaVolt</param>
    /// <returns>quantity measured in MilliVolt</returns>
	public static Quantity<double, MilliVolt> ToMilliVolt<T>(this Quantity<T, GigaVolt> val) where T:IConvertible {
        return new Quantity<double, MilliVolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaVolt to MicroVolt
    /// </summary>
    /// <param name="val">quantity measured in GigaVolt</param>
    /// <returns>quantity measured in MicroVolt</returns>
	public static Quantity<double, MicroVolt> ToMicroVolt<T>(this Quantity<T, GigaVolt> val) where T:IConvertible {
        return new Quantity<double, MicroVolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaVolt to NanoVolt
    /// </summary>
    /// <param name="val">quantity measured in GigaVolt</param>
    /// <returns>quantity measured in NanoVolt</returns>
	public static Quantity<double, NanoVolt> ToNanoVolt<T>(this Quantity<T, GigaVolt> val) where T:IConvertible {
        return new Quantity<double, NanoVolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaVolt to PicoVolt
    /// </summary>
    /// <param name="val">quantity measured in GigaVolt</param>
    /// <returns>quantity measured in PicoVolt</returns>
	public static Quantity<double, PicoVolt> ToPicoVolt<T>(this Quantity<T, GigaVolt> val) where T:IConvertible {
        return new Quantity<double, PicoVolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaVolt to FemtoVolt
    /// </summary>
    /// <param name="val">quantity measured in GigaVolt</param>
    /// <returns>quantity measured in FemtoVolt</returns>
	public static Quantity<double, FemtoVolt> ToFemtoVolt<T>(this Quantity<T, GigaVolt> val) where T:IConvertible {
        return new Quantity<double, FemtoVolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaVolt to AttoVolt
    /// </summary>
    /// <param name="val">quantity measured in GigaVolt</param>
    /// <returns>quantity measured in AttoVolt</returns>
	public static Quantity<double, AttoVolt> ToAttoVolt<T>(this Quantity<T, GigaVolt> val) where T:IConvertible {
        return new Quantity<double, AttoVolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaVolt to ZeptoVolt
    /// </summary>
    /// <param name="val">quantity measured in GigaVolt</param>
    /// <returns>quantity measured in ZeptoVolt</returns>
	public static Quantity<double, ZeptoVolt> ToZeptoVolt<T>(this Quantity<T, GigaVolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoVolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaVolt to YoctoVolt
    /// </summary>
    /// <param name="val">quantity measured in GigaVolt</param>
    /// <returns>quantity measured in YoctoVolt</returns>
	public static Quantity<double, YoctoVolt> ToYoctoVolt<T>(this Quantity<T, GigaVolt> val) where T:IConvertible {
        return new Quantity<double, YoctoVolt>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert MegaVolt to YottaVolt
    /// </summary>
    /// <param name="val">quantity measured in MegaVolt</param>
    /// <returns>quantity measured in YottaVolt</returns>
	public static Quantity<double, YottaVolt> ToYottaVolt<T>(this Quantity<T, MegaVolt> val) where T:IConvertible {
        return new Quantity<double, YottaVolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaVolt to ZettaVolt
    /// </summary>
    /// <param name="val">quantity measured in MegaVolt</param>
    /// <returns>quantity measured in ZettaVolt</returns>
	public static Quantity<double, ZettaVolt> ToZettaVolt<T>(this Quantity<T, MegaVolt> val) where T:IConvertible {
        return new Quantity<double, ZettaVolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaVolt to ExaVolt
    /// </summary>
    /// <param name="val">quantity measured in MegaVolt</param>
    /// <returns>quantity measured in ExaVolt</returns>
	public static Quantity<double, ExaVolt> ToExaVolt<T>(this Quantity<T, MegaVolt> val) where T:IConvertible {
        return new Quantity<double, ExaVolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaVolt to PetaVolt
    /// </summary>
    /// <param name="val">quantity measured in MegaVolt</param>
    /// <returns>quantity measured in PetaVolt</returns>
	public static Quantity<double, PetaVolt> ToPetaVolt<T>(this Quantity<T, MegaVolt> val) where T:IConvertible {
        return new Quantity<double, PetaVolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaVolt to TeraVolt
    /// </summary>
    /// <param name="val">quantity measured in MegaVolt</param>
    /// <returns>quantity measured in TeraVolt</returns>
	public static Quantity<double, TeraVolt> ToTeraVolt<T>(this Quantity<T, MegaVolt> val) where T:IConvertible {
        return new Quantity<double, TeraVolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaVolt to GigaVolt
    /// </summary>
    /// <param name="val">quantity measured in MegaVolt</param>
    /// <returns>quantity measured in GigaVolt</returns>
	public static Quantity<double, GigaVolt> ToGigaVolt<T>(this Quantity<T, MegaVolt> val) where T:IConvertible {
        return new Quantity<double, GigaVolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaVolt to KiloVolt
    /// </summary>
    /// <param name="val">quantity measured in MegaVolt</param>
    /// <returns>quantity measured in KiloVolt</returns>
	public static Quantity<double, KiloVolt> ToKiloVolt<T>(this Quantity<T, MegaVolt> val) where T:IConvertible {
        return new Quantity<double, KiloVolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaVolt to HectoVolt
    /// </summary>
    /// <param name="val">quantity measured in MegaVolt</param>
    /// <returns>quantity measured in HectoVolt</returns>
	public static Quantity<double, HectoVolt> ToHectoVolt<T>(this Quantity<T, MegaVolt> val) where T:IConvertible {
        return new Quantity<double, HectoVolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaVolt to DekaVolt
    /// </summary>
    /// <param name="val">quantity measured in MegaVolt</param>
    /// <returns>quantity measured in DekaVolt</returns>
	public static Quantity<double, DekaVolt> ToDekaVolt<T>(this Quantity<T, MegaVolt> val) where T:IConvertible {
        return new Quantity<double, DekaVolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaVolt to DeciVolt
    /// </summary>
    /// <param name="val">quantity measured in MegaVolt</param>
    /// <returns>quantity measured in DeciVolt</returns>
	public static Quantity<double, DeciVolt> ToDeciVolt<T>(this Quantity<T, MegaVolt> val) where T:IConvertible {
        return new Quantity<double, DeciVolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaVolt to CentiVolt
    /// </summary>
    /// <param name="val">quantity measured in MegaVolt</param>
    /// <returns>quantity measured in CentiVolt</returns>
	public static Quantity<double, CentiVolt> ToCentiVolt<T>(this Quantity<T, MegaVolt> val) where T:IConvertible {
        return new Quantity<double, CentiVolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaVolt to MilliVolt
    /// </summary>
    /// <param name="val">quantity measured in MegaVolt</param>
    /// <returns>quantity measured in MilliVolt</returns>
	public static Quantity<double, MilliVolt> ToMilliVolt<T>(this Quantity<T, MegaVolt> val) where T:IConvertible {
        return new Quantity<double, MilliVolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaVolt to MicroVolt
    /// </summary>
    /// <param name="val">quantity measured in MegaVolt</param>
    /// <returns>quantity measured in MicroVolt</returns>
	public static Quantity<double, MicroVolt> ToMicroVolt<T>(this Quantity<T, MegaVolt> val) where T:IConvertible {
        return new Quantity<double, MicroVolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaVolt to NanoVolt
    /// </summary>
    /// <param name="val">quantity measured in MegaVolt</param>
    /// <returns>quantity measured in NanoVolt</returns>
	public static Quantity<double, NanoVolt> ToNanoVolt<T>(this Quantity<T, MegaVolt> val) where T:IConvertible {
        return new Quantity<double, NanoVolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaVolt to PicoVolt
    /// </summary>
    /// <param name="val">quantity measured in MegaVolt</param>
    /// <returns>quantity measured in PicoVolt</returns>
	public static Quantity<double, PicoVolt> ToPicoVolt<T>(this Quantity<T, MegaVolt> val) where T:IConvertible {
        return new Quantity<double, PicoVolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaVolt to FemtoVolt
    /// </summary>
    /// <param name="val">quantity measured in MegaVolt</param>
    /// <returns>quantity measured in FemtoVolt</returns>
	public static Quantity<double, FemtoVolt> ToFemtoVolt<T>(this Quantity<T, MegaVolt> val) where T:IConvertible {
        return new Quantity<double, FemtoVolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaVolt to AttoVolt
    /// </summary>
    /// <param name="val">quantity measured in MegaVolt</param>
    /// <returns>quantity measured in AttoVolt</returns>
	public static Quantity<double, AttoVolt> ToAttoVolt<T>(this Quantity<T, MegaVolt> val) where T:IConvertible {
        return new Quantity<double, AttoVolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaVolt to ZeptoVolt
    /// </summary>
    /// <param name="val">quantity measured in MegaVolt</param>
    /// <returns>quantity measured in ZeptoVolt</returns>
	public static Quantity<double, ZeptoVolt> ToZeptoVolt<T>(this Quantity<T, MegaVolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoVolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaVolt to YoctoVolt
    /// </summary>
    /// <param name="val">quantity measured in MegaVolt</param>
    /// <returns>quantity measured in YoctoVolt</returns>
	public static Quantity<double, YoctoVolt> ToYoctoVolt<T>(this Quantity<T, MegaVolt> val) where T:IConvertible {
        return new Quantity<double, YoctoVolt>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert KiloVolt to YottaVolt
    /// </summary>
    /// <param name="val">quantity measured in KiloVolt</param>
    /// <returns>quantity measured in YottaVolt</returns>
	public static Quantity<double, YottaVolt> ToYottaVolt<T>(this Quantity<T, KiloVolt> val) where T:IConvertible {
        return new Quantity<double, YottaVolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloVolt to ZettaVolt
    /// </summary>
    /// <param name="val">quantity measured in KiloVolt</param>
    /// <returns>quantity measured in ZettaVolt</returns>
	public static Quantity<double, ZettaVolt> ToZettaVolt<T>(this Quantity<T, KiloVolt> val) where T:IConvertible {
        return new Quantity<double, ZettaVolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloVolt to ExaVolt
    /// </summary>
    /// <param name="val">quantity measured in KiloVolt</param>
    /// <returns>quantity measured in ExaVolt</returns>
	public static Quantity<double, ExaVolt> ToExaVolt<T>(this Quantity<T, KiloVolt> val) where T:IConvertible {
        return new Quantity<double, ExaVolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloVolt to PetaVolt
    /// </summary>
    /// <param name="val">quantity measured in KiloVolt</param>
    /// <returns>quantity measured in PetaVolt</returns>
	public static Quantity<double, PetaVolt> ToPetaVolt<T>(this Quantity<T, KiloVolt> val) where T:IConvertible {
        return new Quantity<double, PetaVolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloVolt to TeraVolt
    /// </summary>
    /// <param name="val">quantity measured in KiloVolt</param>
    /// <returns>quantity measured in TeraVolt</returns>
	public static Quantity<double, TeraVolt> ToTeraVolt<T>(this Quantity<T, KiloVolt> val) where T:IConvertible {
        return new Quantity<double, TeraVolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloVolt to GigaVolt
    /// </summary>
    /// <param name="val">quantity measured in KiloVolt</param>
    /// <returns>quantity measured in GigaVolt</returns>
	public static Quantity<double, GigaVolt> ToGigaVolt<T>(this Quantity<T, KiloVolt> val) where T:IConvertible {
        return new Quantity<double, GigaVolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloVolt to MegaVolt
    /// </summary>
    /// <param name="val">quantity measured in KiloVolt</param>
    /// <returns>quantity measured in MegaVolt</returns>
	public static Quantity<double, MegaVolt> ToMegaVolt<T>(this Quantity<T, KiloVolt> val) where T:IConvertible {
        return new Quantity<double, MegaVolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloVolt to HectoVolt
    /// </summary>
    /// <param name="val">quantity measured in KiloVolt</param>
    /// <returns>quantity measured in HectoVolt</returns>
	public static Quantity<double, HectoVolt> ToHectoVolt<T>(this Quantity<T, KiloVolt> val) where T:IConvertible {
        return new Quantity<double, HectoVolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloVolt to DekaVolt
    /// </summary>
    /// <param name="val">quantity measured in KiloVolt</param>
    /// <returns>quantity measured in DekaVolt</returns>
	public static Quantity<double, DekaVolt> ToDekaVolt<T>(this Quantity<T, KiloVolt> val) where T:IConvertible {
        return new Quantity<double, DekaVolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloVolt to DeciVolt
    /// </summary>
    /// <param name="val">quantity measured in KiloVolt</param>
    /// <returns>quantity measured in DeciVolt</returns>
	public static Quantity<double, DeciVolt> ToDeciVolt<T>(this Quantity<T, KiloVolt> val) where T:IConvertible {
        return new Quantity<double, DeciVolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloVolt to CentiVolt
    /// </summary>
    /// <param name="val">quantity measured in KiloVolt</param>
    /// <returns>quantity measured in CentiVolt</returns>
	public static Quantity<double, CentiVolt> ToCentiVolt<T>(this Quantity<T, KiloVolt> val) where T:IConvertible {
        return new Quantity<double, CentiVolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloVolt to MilliVolt
    /// </summary>
    /// <param name="val">quantity measured in KiloVolt</param>
    /// <returns>quantity measured in MilliVolt</returns>
	public static Quantity<double, MilliVolt> ToMilliVolt<T>(this Quantity<T, KiloVolt> val) where T:IConvertible {
        return new Quantity<double, MilliVolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloVolt to MicroVolt
    /// </summary>
    /// <param name="val">quantity measured in KiloVolt</param>
    /// <returns>quantity measured in MicroVolt</returns>
	public static Quantity<double, MicroVolt> ToMicroVolt<T>(this Quantity<T, KiloVolt> val) where T:IConvertible {
        return new Quantity<double, MicroVolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloVolt to NanoVolt
    /// </summary>
    /// <param name="val">quantity measured in KiloVolt</param>
    /// <returns>quantity measured in NanoVolt</returns>
	public static Quantity<double, NanoVolt> ToNanoVolt<T>(this Quantity<T, KiloVolt> val) where T:IConvertible {
        return new Quantity<double, NanoVolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloVolt to PicoVolt
    /// </summary>
    /// <param name="val">quantity measured in KiloVolt</param>
    /// <returns>quantity measured in PicoVolt</returns>
	public static Quantity<double, PicoVolt> ToPicoVolt<T>(this Quantity<T, KiloVolt> val) where T:IConvertible {
        return new Quantity<double, PicoVolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloVolt to FemtoVolt
    /// </summary>
    /// <param name="val">quantity measured in KiloVolt</param>
    /// <returns>quantity measured in FemtoVolt</returns>
	public static Quantity<double, FemtoVolt> ToFemtoVolt<T>(this Quantity<T, KiloVolt> val) where T:IConvertible {
        return new Quantity<double, FemtoVolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloVolt to AttoVolt
    /// </summary>
    /// <param name="val">quantity measured in KiloVolt</param>
    /// <returns>quantity measured in AttoVolt</returns>
	public static Quantity<double, AttoVolt> ToAttoVolt<T>(this Quantity<T, KiloVolt> val) where T:IConvertible {
        return new Quantity<double, AttoVolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloVolt to ZeptoVolt
    /// </summary>
    /// <param name="val">quantity measured in KiloVolt</param>
    /// <returns>quantity measured in ZeptoVolt</returns>
	public static Quantity<double, ZeptoVolt> ToZeptoVolt<T>(this Quantity<T, KiloVolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoVolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloVolt to YoctoVolt
    /// </summary>
    /// <param name="val">quantity measured in KiloVolt</param>
    /// <returns>quantity measured in YoctoVolt</returns>
	public static Quantity<double, YoctoVolt> ToYoctoVolt<T>(this Quantity<T, KiloVolt> val) where T:IConvertible {
        return new Quantity<double, YoctoVolt>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert HectoVolt to YottaVolt
    /// </summary>
    /// <param name="val">quantity measured in HectoVolt</param>
    /// <returns>quantity measured in YottaVolt</returns>
	public static Quantity<double, YottaVolt> ToYottaVolt<T>(this Quantity<T, HectoVolt> val) where T:IConvertible {
        return new Quantity<double, YottaVolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoVolt to ZettaVolt
    /// </summary>
    /// <param name="val">quantity measured in HectoVolt</param>
    /// <returns>quantity measured in ZettaVolt</returns>
	public static Quantity<double, ZettaVolt> ToZettaVolt<T>(this Quantity<T, HectoVolt> val) where T:IConvertible {
        return new Quantity<double, ZettaVolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoVolt to ExaVolt
    /// </summary>
    /// <param name="val">quantity measured in HectoVolt</param>
    /// <returns>quantity measured in ExaVolt</returns>
	public static Quantity<double, ExaVolt> ToExaVolt<T>(this Quantity<T, HectoVolt> val) where T:IConvertible {
        return new Quantity<double, ExaVolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoVolt to PetaVolt
    /// </summary>
    /// <param name="val">quantity measured in HectoVolt</param>
    /// <returns>quantity measured in PetaVolt</returns>
	public static Quantity<double, PetaVolt> ToPetaVolt<T>(this Quantity<T, HectoVolt> val) where T:IConvertible {
        return new Quantity<double, PetaVolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoVolt to TeraVolt
    /// </summary>
    /// <param name="val">quantity measured in HectoVolt</param>
    /// <returns>quantity measured in TeraVolt</returns>
	public static Quantity<double, TeraVolt> ToTeraVolt<T>(this Quantity<T, HectoVolt> val) where T:IConvertible {
        return new Quantity<double, TeraVolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoVolt to GigaVolt
    /// </summary>
    /// <param name="val">quantity measured in HectoVolt</param>
    /// <returns>quantity measured in GigaVolt</returns>
	public static Quantity<double, GigaVolt> ToGigaVolt<T>(this Quantity<T, HectoVolt> val) where T:IConvertible {
        return new Quantity<double, GigaVolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoVolt to MegaVolt
    /// </summary>
    /// <param name="val">quantity measured in HectoVolt</param>
    /// <returns>quantity measured in MegaVolt</returns>
	public static Quantity<double, MegaVolt> ToMegaVolt<T>(this Quantity<T, HectoVolt> val) where T:IConvertible {
        return new Quantity<double, MegaVolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoVolt to KiloVolt
    /// </summary>
    /// <param name="val">quantity measured in HectoVolt</param>
    /// <returns>quantity measured in KiloVolt</returns>
	public static Quantity<double, KiloVolt> ToKiloVolt<T>(this Quantity<T, HectoVolt> val) where T:IConvertible {
        return new Quantity<double, KiloVolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoVolt to DekaVolt
    /// </summary>
    /// <param name="val">quantity measured in HectoVolt</param>
    /// <returns>quantity measured in DekaVolt</returns>
	public static Quantity<double, DekaVolt> ToDekaVolt<T>(this Quantity<T, HectoVolt> val) where T:IConvertible {
        return new Quantity<double, DekaVolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoVolt to DeciVolt
    /// </summary>
    /// <param name="val">quantity measured in HectoVolt</param>
    /// <returns>quantity measured in DeciVolt</returns>
	public static Quantity<double, DeciVolt> ToDeciVolt<T>(this Quantity<T, HectoVolt> val) where T:IConvertible {
        return new Quantity<double, DeciVolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoVolt to CentiVolt
    /// </summary>
    /// <param name="val">quantity measured in HectoVolt</param>
    /// <returns>quantity measured in CentiVolt</returns>
	public static Quantity<double, CentiVolt> ToCentiVolt<T>(this Quantity<T, HectoVolt> val) where T:IConvertible {
        return new Quantity<double, CentiVolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoVolt to MilliVolt
    /// </summary>
    /// <param name="val">quantity measured in HectoVolt</param>
    /// <returns>quantity measured in MilliVolt</returns>
	public static Quantity<double, MilliVolt> ToMilliVolt<T>(this Quantity<T, HectoVolt> val) where T:IConvertible {
        return new Quantity<double, MilliVolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoVolt to MicroVolt
    /// </summary>
    /// <param name="val">quantity measured in HectoVolt</param>
    /// <returns>quantity measured in MicroVolt</returns>
	public static Quantity<double, MicroVolt> ToMicroVolt<T>(this Quantity<T, HectoVolt> val) where T:IConvertible {
        return new Quantity<double, MicroVolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoVolt to NanoVolt
    /// </summary>
    /// <param name="val">quantity measured in HectoVolt</param>
    /// <returns>quantity measured in NanoVolt</returns>
	public static Quantity<double, NanoVolt> ToNanoVolt<T>(this Quantity<T, HectoVolt> val) where T:IConvertible {
        return new Quantity<double, NanoVolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoVolt to PicoVolt
    /// </summary>
    /// <param name="val">quantity measured in HectoVolt</param>
    /// <returns>quantity measured in PicoVolt</returns>
	public static Quantity<double, PicoVolt> ToPicoVolt<T>(this Quantity<T, HectoVolt> val) where T:IConvertible {
        return new Quantity<double, PicoVolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoVolt to FemtoVolt
    /// </summary>
    /// <param name="val">quantity measured in HectoVolt</param>
    /// <returns>quantity measured in FemtoVolt</returns>
	public static Quantity<double, FemtoVolt> ToFemtoVolt<T>(this Quantity<T, HectoVolt> val) where T:IConvertible {
        return new Quantity<double, FemtoVolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoVolt to AttoVolt
    /// </summary>
    /// <param name="val">quantity measured in HectoVolt</param>
    /// <returns>quantity measured in AttoVolt</returns>
	public static Quantity<double, AttoVolt> ToAttoVolt<T>(this Quantity<T, HectoVolt> val) where T:IConvertible {
        return new Quantity<double, AttoVolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoVolt to ZeptoVolt
    /// </summary>
    /// <param name="val">quantity measured in HectoVolt</param>
    /// <returns>quantity measured in ZeptoVolt</returns>
	public static Quantity<double, ZeptoVolt> ToZeptoVolt<T>(this Quantity<T, HectoVolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoVolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoVolt to YoctoVolt
    /// </summary>
    /// <param name="val">quantity measured in HectoVolt</param>
    /// <returns>quantity measured in YoctoVolt</returns>
	public static Quantity<double, YoctoVolt> ToYoctoVolt<T>(this Quantity<T, HectoVolt> val) where T:IConvertible {
        return new Quantity<double, YoctoVolt>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert DekaVolt to YottaVolt
    /// </summary>
    /// <param name="val">quantity measured in DekaVolt</param>
    /// <returns>quantity measured in YottaVolt</returns>
	public static Quantity<double, YottaVolt> ToYottaVolt<T>(this Quantity<T, DekaVolt> val) where T:IConvertible {
        return new Quantity<double, YottaVolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaVolt to ZettaVolt
    /// </summary>
    /// <param name="val">quantity measured in DekaVolt</param>
    /// <returns>quantity measured in ZettaVolt</returns>
	public static Quantity<double, ZettaVolt> ToZettaVolt<T>(this Quantity<T, DekaVolt> val) where T:IConvertible {
        return new Quantity<double, ZettaVolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaVolt to ExaVolt
    /// </summary>
    /// <param name="val">quantity measured in DekaVolt</param>
    /// <returns>quantity measured in ExaVolt</returns>
	public static Quantity<double, ExaVolt> ToExaVolt<T>(this Quantity<T, DekaVolt> val) where T:IConvertible {
        return new Quantity<double, ExaVolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaVolt to PetaVolt
    /// </summary>
    /// <param name="val">quantity measured in DekaVolt</param>
    /// <returns>quantity measured in PetaVolt</returns>
	public static Quantity<double, PetaVolt> ToPetaVolt<T>(this Quantity<T, DekaVolt> val) where T:IConvertible {
        return new Quantity<double, PetaVolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaVolt to TeraVolt
    /// </summary>
    /// <param name="val">quantity measured in DekaVolt</param>
    /// <returns>quantity measured in TeraVolt</returns>
	public static Quantity<double, TeraVolt> ToTeraVolt<T>(this Quantity<T, DekaVolt> val) where T:IConvertible {
        return new Quantity<double, TeraVolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaVolt to GigaVolt
    /// </summary>
    /// <param name="val">quantity measured in DekaVolt</param>
    /// <returns>quantity measured in GigaVolt</returns>
	public static Quantity<double, GigaVolt> ToGigaVolt<T>(this Quantity<T, DekaVolt> val) where T:IConvertible {
        return new Quantity<double, GigaVolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaVolt to MegaVolt
    /// </summary>
    /// <param name="val">quantity measured in DekaVolt</param>
    /// <returns>quantity measured in MegaVolt</returns>
	public static Quantity<double, MegaVolt> ToMegaVolt<T>(this Quantity<T, DekaVolt> val) where T:IConvertible {
        return new Quantity<double, MegaVolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaVolt to KiloVolt
    /// </summary>
    /// <param name="val">quantity measured in DekaVolt</param>
    /// <returns>quantity measured in KiloVolt</returns>
	public static Quantity<double, KiloVolt> ToKiloVolt<T>(this Quantity<T, DekaVolt> val) where T:IConvertible {
        return new Quantity<double, KiloVolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaVolt to HectoVolt
    /// </summary>
    /// <param name="val">quantity measured in DekaVolt</param>
    /// <returns>quantity measured in HectoVolt</returns>
	public static Quantity<double, HectoVolt> ToHectoVolt<T>(this Quantity<T, DekaVolt> val) where T:IConvertible {
        return new Quantity<double, HectoVolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaVolt to DeciVolt
    /// </summary>
    /// <param name="val">quantity measured in DekaVolt</param>
    /// <returns>quantity measured in DeciVolt</returns>
	public static Quantity<double, DeciVolt> ToDeciVolt<T>(this Quantity<T, DekaVolt> val) where T:IConvertible {
        return new Quantity<double, DeciVolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaVolt to CentiVolt
    /// </summary>
    /// <param name="val">quantity measured in DekaVolt</param>
    /// <returns>quantity measured in CentiVolt</returns>
	public static Quantity<double, CentiVolt> ToCentiVolt<T>(this Quantity<T, DekaVolt> val) where T:IConvertible {
        return new Quantity<double, CentiVolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaVolt to MilliVolt
    /// </summary>
    /// <param name="val">quantity measured in DekaVolt</param>
    /// <returns>quantity measured in MilliVolt</returns>
	public static Quantity<double, MilliVolt> ToMilliVolt<T>(this Quantity<T, DekaVolt> val) where T:IConvertible {
        return new Quantity<double, MilliVolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaVolt to MicroVolt
    /// </summary>
    /// <param name="val">quantity measured in DekaVolt</param>
    /// <returns>quantity measured in MicroVolt</returns>
	public static Quantity<double, MicroVolt> ToMicroVolt<T>(this Quantity<T, DekaVolt> val) where T:IConvertible {
        return new Quantity<double, MicroVolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaVolt to NanoVolt
    /// </summary>
    /// <param name="val">quantity measured in DekaVolt</param>
    /// <returns>quantity measured in NanoVolt</returns>
	public static Quantity<double, NanoVolt> ToNanoVolt<T>(this Quantity<T, DekaVolt> val) where T:IConvertible {
        return new Quantity<double, NanoVolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaVolt to PicoVolt
    /// </summary>
    /// <param name="val">quantity measured in DekaVolt</param>
    /// <returns>quantity measured in PicoVolt</returns>
	public static Quantity<double, PicoVolt> ToPicoVolt<T>(this Quantity<T, DekaVolt> val) where T:IConvertible {
        return new Quantity<double, PicoVolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaVolt to FemtoVolt
    /// </summary>
    /// <param name="val">quantity measured in DekaVolt</param>
    /// <returns>quantity measured in FemtoVolt</returns>
	public static Quantity<double, FemtoVolt> ToFemtoVolt<T>(this Quantity<T, DekaVolt> val) where T:IConvertible {
        return new Quantity<double, FemtoVolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaVolt to AttoVolt
    /// </summary>
    /// <param name="val">quantity measured in DekaVolt</param>
    /// <returns>quantity measured in AttoVolt</returns>
	public static Quantity<double, AttoVolt> ToAttoVolt<T>(this Quantity<T, DekaVolt> val) where T:IConvertible {
        return new Quantity<double, AttoVolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaVolt to ZeptoVolt
    /// </summary>
    /// <param name="val">quantity measured in DekaVolt</param>
    /// <returns>quantity measured in ZeptoVolt</returns>
	public static Quantity<double, ZeptoVolt> ToZeptoVolt<T>(this Quantity<T, DekaVolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoVolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaVolt to YoctoVolt
    /// </summary>
    /// <param name="val">quantity measured in DekaVolt</param>
    /// <returns>quantity measured in YoctoVolt</returns>
	public static Quantity<double, YoctoVolt> ToYoctoVolt<T>(this Quantity<T, DekaVolt> val) where T:IConvertible {
        return new Quantity<double, YoctoVolt>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DeciVolt to YottaVolt
    /// </summary>
    /// <param name="val">quantity measured in DeciVolt</param>
    /// <returns>quantity measured in YottaVolt</returns>
	public static Quantity<double, YottaVolt> ToYottaVolt<T>(this Quantity<T, DeciVolt> val) where T:IConvertible {
        return new Quantity<double, YottaVolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciVolt to ZettaVolt
    /// </summary>
    /// <param name="val">quantity measured in DeciVolt</param>
    /// <returns>quantity measured in ZettaVolt</returns>
	public static Quantity<double, ZettaVolt> ToZettaVolt<T>(this Quantity<T, DeciVolt> val) where T:IConvertible {
        return new Quantity<double, ZettaVolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciVolt to ExaVolt
    /// </summary>
    /// <param name="val">quantity measured in DeciVolt</param>
    /// <returns>quantity measured in ExaVolt</returns>
	public static Quantity<double, ExaVolt> ToExaVolt<T>(this Quantity<T, DeciVolt> val) where T:IConvertible {
        return new Quantity<double, ExaVolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciVolt to PetaVolt
    /// </summary>
    /// <param name="val">quantity measured in DeciVolt</param>
    /// <returns>quantity measured in PetaVolt</returns>
	public static Quantity<double, PetaVolt> ToPetaVolt<T>(this Quantity<T, DeciVolt> val) where T:IConvertible {
        return new Quantity<double, PetaVolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciVolt to TeraVolt
    /// </summary>
    /// <param name="val">quantity measured in DeciVolt</param>
    /// <returns>quantity measured in TeraVolt</returns>
	public static Quantity<double, TeraVolt> ToTeraVolt<T>(this Quantity<T, DeciVolt> val) where T:IConvertible {
        return new Quantity<double, TeraVolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciVolt to GigaVolt
    /// </summary>
    /// <param name="val">quantity measured in DeciVolt</param>
    /// <returns>quantity measured in GigaVolt</returns>
	public static Quantity<double, GigaVolt> ToGigaVolt<T>(this Quantity<T, DeciVolt> val) where T:IConvertible {
        return new Quantity<double, GigaVolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciVolt to MegaVolt
    /// </summary>
    /// <param name="val">quantity measured in DeciVolt</param>
    /// <returns>quantity measured in MegaVolt</returns>
	public static Quantity<double, MegaVolt> ToMegaVolt<T>(this Quantity<T, DeciVolt> val) where T:IConvertible {
        return new Quantity<double, MegaVolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciVolt to KiloVolt
    /// </summary>
    /// <param name="val">quantity measured in DeciVolt</param>
    /// <returns>quantity measured in KiloVolt</returns>
	public static Quantity<double, KiloVolt> ToKiloVolt<T>(this Quantity<T, DeciVolt> val) where T:IConvertible {
        return new Quantity<double, KiloVolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciVolt to HectoVolt
    /// </summary>
    /// <param name="val">quantity measured in DeciVolt</param>
    /// <returns>quantity measured in HectoVolt</returns>
	public static Quantity<double, HectoVolt> ToHectoVolt<T>(this Quantity<T, DeciVolt> val) where T:IConvertible {
        return new Quantity<double, HectoVolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciVolt to DekaVolt
    /// </summary>
    /// <param name="val">quantity measured in DeciVolt</param>
    /// <returns>quantity measured in DekaVolt</returns>
	public static Quantity<double, DekaVolt> ToDekaVolt<T>(this Quantity<T, DeciVolt> val) where T:IConvertible {
        return new Quantity<double, DekaVolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciVolt to CentiVolt
    /// </summary>
    /// <param name="val">quantity measured in DeciVolt</param>
    /// <returns>quantity measured in CentiVolt</returns>
	public static Quantity<double, CentiVolt> ToCentiVolt<T>(this Quantity<T, DeciVolt> val) where T:IConvertible {
        return new Quantity<double, CentiVolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciVolt to MilliVolt
    /// </summary>
    /// <param name="val">quantity measured in DeciVolt</param>
    /// <returns>quantity measured in MilliVolt</returns>
	public static Quantity<double, MilliVolt> ToMilliVolt<T>(this Quantity<T, DeciVolt> val) where T:IConvertible {
        return new Quantity<double, MilliVolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciVolt to MicroVolt
    /// </summary>
    /// <param name="val">quantity measured in DeciVolt</param>
    /// <returns>quantity measured in MicroVolt</returns>
	public static Quantity<double, MicroVolt> ToMicroVolt<T>(this Quantity<T, DeciVolt> val) where T:IConvertible {
        return new Quantity<double, MicroVolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciVolt to NanoVolt
    /// </summary>
    /// <param name="val">quantity measured in DeciVolt</param>
    /// <returns>quantity measured in NanoVolt</returns>
	public static Quantity<double, NanoVolt> ToNanoVolt<T>(this Quantity<T, DeciVolt> val) where T:IConvertible {
        return new Quantity<double, NanoVolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciVolt to PicoVolt
    /// </summary>
    /// <param name="val">quantity measured in DeciVolt</param>
    /// <returns>quantity measured in PicoVolt</returns>
	public static Quantity<double, PicoVolt> ToPicoVolt<T>(this Quantity<T, DeciVolt> val) where T:IConvertible {
        return new Quantity<double, PicoVolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciVolt to FemtoVolt
    /// </summary>
    /// <param name="val">quantity measured in DeciVolt</param>
    /// <returns>quantity measured in FemtoVolt</returns>
	public static Quantity<double, FemtoVolt> ToFemtoVolt<T>(this Quantity<T, DeciVolt> val) where T:IConvertible {
        return new Quantity<double, FemtoVolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciVolt to AttoVolt
    /// </summary>
    /// <param name="val">quantity measured in DeciVolt</param>
    /// <returns>quantity measured in AttoVolt</returns>
	public static Quantity<double, AttoVolt> ToAttoVolt<T>(this Quantity<T, DeciVolt> val) where T:IConvertible {
        return new Quantity<double, AttoVolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciVolt to ZeptoVolt
    /// </summary>
    /// <param name="val">quantity measured in DeciVolt</param>
    /// <returns>quantity measured in ZeptoVolt</returns>
	public static Quantity<double, ZeptoVolt> ToZeptoVolt<T>(this Quantity<T, DeciVolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoVolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciVolt to YoctoVolt
    /// </summary>
    /// <param name="val">quantity measured in DeciVolt</param>
    /// <returns>quantity measured in YoctoVolt</returns>
	public static Quantity<double, YoctoVolt> ToYoctoVolt<T>(this Quantity<T, DeciVolt> val) where T:IConvertible {
        return new Quantity<double, YoctoVolt>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert CentiVolt to YottaVolt
    /// </summary>
    /// <param name="val">quantity measured in CentiVolt</param>
    /// <returns>quantity measured in YottaVolt</returns>
	public static Quantity<double, YottaVolt> ToYottaVolt<T>(this Quantity<T, CentiVolt> val) where T:IConvertible {
        return new Quantity<double, YottaVolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiVolt to ZettaVolt
    /// </summary>
    /// <param name="val">quantity measured in CentiVolt</param>
    /// <returns>quantity measured in ZettaVolt</returns>
	public static Quantity<double, ZettaVolt> ToZettaVolt<T>(this Quantity<T, CentiVolt> val) where T:IConvertible {
        return new Quantity<double, ZettaVolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiVolt to ExaVolt
    /// </summary>
    /// <param name="val">quantity measured in CentiVolt</param>
    /// <returns>quantity measured in ExaVolt</returns>
	public static Quantity<double, ExaVolt> ToExaVolt<T>(this Quantity<T, CentiVolt> val) where T:IConvertible {
        return new Quantity<double, ExaVolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiVolt to PetaVolt
    /// </summary>
    /// <param name="val">quantity measured in CentiVolt</param>
    /// <returns>quantity measured in PetaVolt</returns>
	public static Quantity<double, PetaVolt> ToPetaVolt<T>(this Quantity<T, CentiVolt> val) where T:IConvertible {
        return new Quantity<double, PetaVolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiVolt to TeraVolt
    /// </summary>
    /// <param name="val">quantity measured in CentiVolt</param>
    /// <returns>quantity measured in TeraVolt</returns>
	public static Quantity<double, TeraVolt> ToTeraVolt<T>(this Quantity<T, CentiVolt> val) where T:IConvertible {
        return new Quantity<double, TeraVolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiVolt to GigaVolt
    /// </summary>
    /// <param name="val">quantity measured in CentiVolt</param>
    /// <returns>quantity measured in GigaVolt</returns>
	public static Quantity<double, GigaVolt> ToGigaVolt<T>(this Quantity<T, CentiVolt> val) where T:IConvertible {
        return new Quantity<double, GigaVolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiVolt to MegaVolt
    /// </summary>
    /// <param name="val">quantity measured in CentiVolt</param>
    /// <returns>quantity measured in MegaVolt</returns>
	public static Quantity<double, MegaVolt> ToMegaVolt<T>(this Quantity<T, CentiVolt> val) where T:IConvertible {
        return new Quantity<double, MegaVolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiVolt to KiloVolt
    /// </summary>
    /// <param name="val">quantity measured in CentiVolt</param>
    /// <returns>quantity measured in KiloVolt</returns>
	public static Quantity<double, KiloVolt> ToKiloVolt<T>(this Quantity<T, CentiVolt> val) where T:IConvertible {
        return new Quantity<double, KiloVolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiVolt to HectoVolt
    /// </summary>
    /// <param name="val">quantity measured in CentiVolt</param>
    /// <returns>quantity measured in HectoVolt</returns>
	public static Quantity<double, HectoVolt> ToHectoVolt<T>(this Quantity<T, CentiVolt> val) where T:IConvertible {
        return new Quantity<double, HectoVolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiVolt to DekaVolt
    /// </summary>
    /// <param name="val">quantity measured in CentiVolt</param>
    /// <returns>quantity measured in DekaVolt</returns>
	public static Quantity<double, DekaVolt> ToDekaVolt<T>(this Quantity<T, CentiVolt> val) where T:IConvertible {
        return new Quantity<double, DekaVolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiVolt to DeciVolt
    /// </summary>
    /// <param name="val">quantity measured in CentiVolt</param>
    /// <returns>quantity measured in DeciVolt</returns>
	public static Quantity<double, DeciVolt> ToDeciVolt<T>(this Quantity<T, CentiVolt> val) where T:IConvertible {
        return new Quantity<double, DeciVolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiVolt to MilliVolt
    /// </summary>
    /// <param name="val">quantity measured in CentiVolt</param>
    /// <returns>quantity measured in MilliVolt</returns>
	public static Quantity<double, MilliVolt> ToMilliVolt<T>(this Quantity<T, CentiVolt> val) where T:IConvertible {
        return new Quantity<double, MilliVolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiVolt to MicroVolt
    /// </summary>
    /// <param name="val">quantity measured in CentiVolt</param>
    /// <returns>quantity measured in MicroVolt</returns>
	public static Quantity<double, MicroVolt> ToMicroVolt<T>(this Quantity<T, CentiVolt> val) where T:IConvertible {
        return new Quantity<double, MicroVolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiVolt to NanoVolt
    /// </summary>
    /// <param name="val">quantity measured in CentiVolt</param>
    /// <returns>quantity measured in NanoVolt</returns>
	public static Quantity<double, NanoVolt> ToNanoVolt<T>(this Quantity<T, CentiVolt> val) where T:IConvertible {
        return new Quantity<double, NanoVolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiVolt to PicoVolt
    /// </summary>
    /// <param name="val">quantity measured in CentiVolt</param>
    /// <returns>quantity measured in PicoVolt</returns>
	public static Quantity<double, PicoVolt> ToPicoVolt<T>(this Quantity<T, CentiVolt> val) where T:IConvertible {
        return new Quantity<double, PicoVolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiVolt to FemtoVolt
    /// </summary>
    /// <param name="val">quantity measured in CentiVolt</param>
    /// <returns>quantity measured in FemtoVolt</returns>
	public static Quantity<double, FemtoVolt> ToFemtoVolt<T>(this Quantity<T, CentiVolt> val) where T:IConvertible {
        return new Quantity<double, FemtoVolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiVolt to AttoVolt
    /// </summary>
    /// <param name="val">quantity measured in CentiVolt</param>
    /// <returns>quantity measured in AttoVolt</returns>
	public static Quantity<double, AttoVolt> ToAttoVolt<T>(this Quantity<T, CentiVolt> val) where T:IConvertible {
        return new Quantity<double, AttoVolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiVolt to ZeptoVolt
    /// </summary>
    /// <param name="val">quantity measured in CentiVolt</param>
    /// <returns>quantity measured in ZeptoVolt</returns>
	public static Quantity<double, ZeptoVolt> ToZeptoVolt<T>(this Quantity<T, CentiVolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoVolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiVolt to YoctoVolt
    /// </summary>
    /// <param name="val">quantity measured in CentiVolt</param>
    /// <returns>quantity measured in YoctoVolt</returns>
	public static Quantity<double, YoctoVolt> ToYoctoVolt<T>(this Quantity<T, CentiVolt> val) where T:IConvertible {
        return new Quantity<double, YoctoVolt>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert MilliVolt to YottaVolt
    /// </summary>
    /// <param name="val">quantity measured in MilliVolt</param>
    /// <returns>quantity measured in YottaVolt</returns>
	public static Quantity<double, YottaVolt> ToYottaVolt<T>(this Quantity<T, MilliVolt> val) where T:IConvertible {
        return new Quantity<double, YottaVolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliVolt to ZettaVolt
    /// </summary>
    /// <param name="val">quantity measured in MilliVolt</param>
    /// <returns>quantity measured in ZettaVolt</returns>
	public static Quantity<double, ZettaVolt> ToZettaVolt<T>(this Quantity<T, MilliVolt> val) where T:IConvertible {
        return new Quantity<double, ZettaVolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliVolt to ExaVolt
    /// </summary>
    /// <param name="val">quantity measured in MilliVolt</param>
    /// <returns>quantity measured in ExaVolt</returns>
	public static Quantity<double, ExaVolt> ToExaVolt<T>(this Quantity<T, MilliVolt> val) where T:IConvertible {
        return new Quantity<double, ExaVolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliVolt to PetaVolt
    /// </summary>
    /// <param name="val">quantity measured in MilliVolt</param>
    /// <returns>quantity measured in PetaVolt</returns>
	public static Quantity<double, PetaVolt> ToPetaVolt<T>(this Quantity<T, MilliVolt> val) where T:IConvertible {
        return new Quantity<double, PetaVolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliVolt to TeraVolt
    /// </summary>
    /// <param name="val">quantity measured in MilliVolt</param>
    /// <returns>quantity measured in TeraVolt</returns>
	public static Quantity<double, TeraVolt> ToTeraVolt<T>(this Quantity<T, MilliVolt> val) where T:IConvertible {
        return new Quantity<double, TeraVolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliVolt to GigaVolt
    /// </summary>
    /// <param name="val">quantity measured in MilliVolt</param>
    /// <returns>quantity measured in GigaVolt</returns>
	public static Quantity<double, GigaVolt> ToGigaVolt<T>(this Quantity<T, MilliVolt> val) where T:IConvertible {
        return new Quantity<double, GigaVolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliVolt to MegaVolt
    /// </summary>
    /// <param name="val">quantity measured in MilliVolt</param>
    /// <returns>quantity measured in MegaVolt</returns>
	public static Quantity<double, MegaVolt> ToMegaVolt<T>(this Quantity<T, MilliVolt> val) where T:IConvertible {
        return new Quantity<double, MegaVolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliVolt to KiloVolt
    /// </summary>
    /// <param name="val">quantity measured in MilliVolt</param>
    /// <returns>quantity measured in KiloVolt</returns>
	public static Quantity<double, KiloVolt> ToKiloVolt<T>(this Quantity<T, MilliVolt> val) where T:IConvertible {
        return new Quantity<double, KiloVolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliVolt to HectoVolt
    /// </summary>
    /// <param name="val">quantity measured in MilliVolt</param>
    /// <returns>quantity measured in HectoVolt</returns>
	public static Quantity<double, HectoVolt> ToHectoVolt<T>(this Quantity<T, MilliVolt> val) where T:IConvertible {
        return new Quantity<double, HectoVolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliVolt to DekaVolt
    /// </summary>
    /// <param name="val">quantity measured in MilliVolt</param>
    /// <returns>quantity measured in DekaVolt</returns>
	public static Quantity<double, DekaVolt> ToDekaVolt<T>(this Quantity<T, MilliVolt> val) where T:IConvertible {
        return new Quantity<double, DekaVolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliVolt to DeciVolt
    /// </summary>
    /// <param name="val">quantity measured in MilliVolt</param>
    /// <returns>quantity measured in DeciVolt</returns>
	public static Quantity<double, DeciVolt> ToDeciVolt<T>(this Quantity<T, MilliVolt> val) where T:IConvertible {
        return new Quantity<double, DeciVolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliVolt to CentiVolt
    /// </summary>
    /// <param name="val">quantity measured in MilliVolt</param>
    /// <returns>quantity measured in CentiVolt</returns>
	public static Quantity<double, CentiVolt> ToCentiVolt<T>(this Quantity<T, MilliVolt> val) where T:IConvertible {
        return new Quantity<double, CentiVolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliVolt to MicroVolt
    /// </summary>
    /// <param name="val">quantity measured in MilliVolt</param>
    /// <returns>quantity measured in MicroVolt</returns>
	public static Quantity<double, MicroVolt> ToMicroVolt<T>(this Quantity<T, MilliVolt> val) where T:IConvertible {
        return new Quantity<double, MicroVolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliVolt to NanoVolt
    /// </summary>
    /// <param name="val">quantity measured in MilliVolt</param>
    /// <returns>quantity measured in NanoVolt</returns>
	public static Quantity<double, NanoVolt> ToNanoVolt<T>(this Quantity<T, MilliVolt> val) where T:IConvertible {
        return new Quantity<double, NanoVolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliVolt to PicoVolt
    /// </summary>
    /// <param name="val">quantity measured in MilliVolt</param>
    /// <returns>quantity measured in PicoVolt</returns>
	public static Quantity<double, PicoVolt> ToPicoVolt<T>(this Quantity<T, MilliVolt> val) where T:IConvertible {
        return new Quantity<double, PicoVolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliVolt to FemtoVolt
    /// </summary>
    /// <param name="val">quantity measured in MilliVolt</param>
    /// <returns>quantity measured in FemtoVolt</returns>
	public static Quantity<double, FemtoVolt> ToFemtoVolt<T>(this Quantity<T, MilliVolt> val) where T:IConvertible {
        return new Quantity<double, FemtoVolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliVolt to AttoVolt
    /// </summary>
    /// <param name="val">quantity measured in MilliVolt</param>
    /// <returns>quantity measured in AttoVolt</returns>
	public static Quantity<double, AttoVolt> ToAttoVolt<T>(this Quantity<T, MilliVolt> val) where T:IConvertible {
        return new Quantity<double, AttoVolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliVolt to ZeptoVolt
    /// </summary>
    /// <param name="val">quantity measured in MilliVolt</param>
    /// <returns>quantity measured in ZeptoVolt</returns>
	public static Quantity<double, ZeptoVolt> ToZeptoVolt<T>(this Quantity<T, MilliVolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoVolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliVolt to YoctoVolt
    /// </summary>
    /// <param name="val">quantity measured in MilliVolt</param>
    /// <returns>quantity measured in YoctoVolt</returns>
	public static Quantity<double, YoctoVolt> ToYoctoVolt<T>(this Quantity<T, MilliVolt> val) where T:IConvertible {
        return new Quantity<double, YoctoVolt>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MicroVolt to YottaVolt
    /// </summary>
    /// <param name="val">quantity measured in MicroVolt</param>
    /// <returns>quantity measured in YottaVolt</returns>
	public static Quantity<double, YottaVolt> ToYottaVolt<T>(this Quantity<T, MicroVolt> val) where T:IConvertible {
        return new Quantity<double, YottaVolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroVolt to ZettaVolt
    /// </summary>
    /// <param name="val">quantity measured in MicroVolt</param>
    /// <returns>quantity measured in ZettaVolt</returns>
	public static Quantity<double, ZettaVolt> ToZettaVolt<T>(this Quantity<T, MicroVolt> val) where T:IConvertible {
        return new Quantity<double, ZettaVolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroVolt to ExaVolt
    /// </summary>
    /// <param name="val">quantity measured in MicroVolt</param>
    /// <returns>quantity measured in ExaVolt</returns>
	public static Quantity<double, ExaVolt> ToExaVolt<T>(this Quantity<T, MicroVolt> val) where T:IConvertible {
        return new Quantity<double, ExaVolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroVolt to PetaVolt
    /// </summary>
    /// <param name="val">quantity measured in MicroVolt</param>
    /// <returns>quantity measured in PetaVolt</returns>
	public static Quantity<double, PetaVolt> ToPetaVolt<T>(this Quantity<T, MicroVolt> val) where T:IConvertible {
        return new Quantity<double, PetaVolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroVolt to TeraVolt
    /// </summary>
    /// <param name="val">quantity measured in MicroVolt</param>
    /// <returns>quantity measured in TeraVolt</returns>
	public static Quantity<double, TeraVolt> ToTeraVolt<T>(this Quantity<T, MicroVolt> val) where T:IConvertible {
        return new Quantity<double, TeraVolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroVolt to GigaVolt
    /// </summary>
    /// <param name="val">quantity measured in MicroVolt</param>
    /// <returns>quantity measured in GigaVolt</returns>
	public static Quantity<double, GigaVolt> ToGigaVolt<T>(this Quantity<T, MicroVolt> val) where T:IConvertible {
        return new Quantity<double, GigaVolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroVolt to MegaVolt
    /// </summary>
    /// <param name="val">quantity measured in MicroVolt</param>
    /// <returns>quantity measured in MegaVolt</returns>
	public static Quantity<double, MegaVolt> ToMegaVolt<T>(this Quantity<T, MicroVolt> val) where T:IConvertible {
        return new Quantity<double, MegaVolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroVolt to KiloVolt
    /// </summary>
    /// <param name="val">quantity measured in MicroVolt</param>
    /// <returns>quantity measured in KiloVolt</returns>
	public static Quantity<double, KiloVolt> ToKiloVolt<T>(this Quantity<T, MicroVolt> val) where T:IConvertible {
        return new Quantity<double, KiloVolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroVolt to HectoVolt
    /// </summary>
    /// <param name="val">quantity measured in MicroVolt</param>
    /// <returns>quantity measured in HectoVolt</returns>
	public static Quantity<double, HectoVolt> ToHectoVolt<T>(this Quantity<T, MicroVolt> val) where T:IConvertible {
        return new Quantity<double, HectoVolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroVolt to DekaVolt
    /// </summary>
    /// <param name="val">quantity measured in MicroVolt</param>
    /// <returns>quantity measured in DekaVolt</returns>
	public static Quantity<double, DekaVolt> ToDekaVolt<T>(this Quantity<T, MicroVolt> val) where T:IConvertible {
        return new Quantity<double, DekaVolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroVolt to DeciVolt
    /// </summary>
    /// <param name="val">quantity measured in MicroVolt</param>
    /// <returns>quantity measured in DeciVolt</returns>
	public static Quantity<double, DeciVolt> ToDeciVolt<T>(this Quantity<T, MicroVolt> val) where T:IConvertible {
        return new Quantity<double, DeciVolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroVolt to CentiVolt
    /// </summary>
    /// <param name="val">quantity measured in MicroVolt</param>
    /// <returns>quantity measured in CentiVolt</returns>
	public static Quantity<double, CentiVolt> ToCentiVolt<T>(this Quantity<T, MicroVolt> val) where T:IConvertible {
        return new Quantity<double, CentiVolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroVolt to MilliVolt
    /// </summary>
    /// <param name="val">quantity measured in MicroVolt</param>
    /// <returns>quantity measured in MilliVolt</returns>
	public static Quantity<double, MilliVolt> ToMilliVolt<T>(this Quantity<T, MicroVolt> val) where T:IConvertible {
        return new Quantity<double, MilliVolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroVolt to NanoVolt
    /// </summary>
    /// <param name="val">quantity measured in MicroVolt</param>
    /// <returns>quantity measured in NanoVolt</returns>
	public static Quantity<double, NanoVolt> ToNanoVolt<T>(this Quantity<T, MicroVolt> val) where T:IConvertible {
        return new Quantity<double, NanoVolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroVolt to PicoVolt
    /// </summary>
    /// <param name="val">quantity measured in MicroVolt</param>
    /// <returns>quantity measured in PicoVolt</returns>
	public static Quantity<double, PicoVolt> ToPicoVolt<T>(this Quantity<T, MicroVolt> val) where T:IConvertible {
        return new Quantity<double, PicoVolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroVolt to FemtoVolt
    /// </summary>
    /// <param name="val">quantity measured in MicroVolt</param>
    /// <returns>quantity measured in FemtoVolt</returns>
	public static Quantity<double, FemtoVolt> ToFemtoVolt<T>(this Quantity<T, MicroVolt> val) where T:IConvertible {
        return new Quantity<double, FemtoVolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroVolt to AttoVolt
    /// </summary>
    /// <param name="val">quantity measured in MicroVolt</param>
    /// <returns>quantity measured in AttoVolt</returns>
	public static Quantity<double, AttoVolt> ToAttoVolt<T>(this Quantity<T, MicroVolt> val) where T:IConvertible {
        return new Quantity<double, AttoVolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroVolt to ZeptoVolt
    /// </summary>
    /// <param name="val">quantity measured in MicroVolt</param>
    /// <returns>quantity measured in ZeptoVolt</returns>
	public static Quantity<double, ZeptoVolt> ToZeptoVolt<T>(this Quantity<T, MicroVolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoVolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroVolt to YoctoVolt
    /// </summary>
    /// <param name="val">quantity measured in MicroVolt</param>
    /// <returns>quantity measured in YoctoVolt</returns>
	public static Quantity<double, YoctoVolt> ToYoctoVolt<T>(this Quantity<T, MicroVolt> val) where T:IConvertible {
        return new Quantity<double, YoctoVolt>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert NanoVolt to YottaVolt
    /// </summary>
    /// <param name="val">quantity measured in NanoVolt</param>
    /// <returns>quantity measured in YottaVolt</returns>
	public static Quantity<double, YottaVolt> ToYottaVolt<T>(this Quantity<T, NanoVolt> val) where T:IConvertible {
        return new Quantity<double, YottaVolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoVolt to ZettaVolt
    /// </summary>
    /// <param name="val">quantity measured in NanoVolt</param>
    /// <returns>quantity measured in ZettaVolt</returns>
	public static Quantity<double, ZettaVolt> ToZettaVolt<T>(this Quantity<T, NanoVolt> val) where T:IConvertible {
        return new Quantity<double, ZettaVolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoVolt to ExaVolt
    /// </summary>
    /// <param name="val">quantity measured in NanoVolt</param>
    /// <returns>quantity measured in ExaVolt</returns>
	public static Quantity<double, ExaVolt> ToExaVolt<T>(this Quantity<T, NanoVolt> val) where T:IConvertible {
        return new Quantity<double, ExaVolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoVolt to PetaVolt
    /// </summary>
    /// <param name="val">quantity measured in NanoVolt</param>
    /// <returns>quantity measured in PetaVolt</returns>
	public static Quantity<double, PetaVolt> ToPetaVolt<T>(this Quantity<T, NanoVolt> val) where T:IConvertible {
        return new Quantity<double, PetaVolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoVolt to TeraVolt
    /// </summary>
    /// <param name="val">quantity measured in NanoVolt</param>
    /// <returns>quantity measured in TeraVolt</returns>
	public static Quantity<double, TeraVolt> ToTeraVolt<T>(this Quantity<T, NanoVolt> val) where T:IConvertible {
        return new Quantity<double, TeraVolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoVolt to GigaVolt
    /// </summary>
    /// <param name="val">quantity measured in NanoVolt</param>
    /// <returns>quantity measured in GigaVolt</returns>
	public static Quantity<double, GigaVolt> ToGigaVolt<T>(this Quantity<T, NanoVolt> val) where T:IConvertible {
        return new Quantity<double, GigaVolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoVolt to MegaVolt
    /// </summary>
    /// <param name="val">quantity measured in NanoVolt</param>
    /// <returns>quantity measured in MegaVolt</returns>
	public static Quantity<double, MegaVolt> ToMegaVolt<T>(this Quantity<T, NanoVolt> val) where T:IConvertible {
        return new Quantity<double, MegaVolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoVolt to KiloVolt
    /// </summary>
    /// <param name="val">quantity measured in NanoVolt</param>
    /// <returns>quantity measured in KiloVolt</returns>
	public static Quantity<double, KiloVolt> ToKiloVolt<T>(this Quantity<T, NanoVolt> val) where T:IConvertible {
        return new Quantity<double, KiloVolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoVolt to HectoVolt
    /// </summary>
    /// <param name="val">quantity measured in NanoVolt</param>
    /// <returns>quantity measured in HectoVolt</returns>
	public static Quantity<double, HectoVolt> ToHectoVolt<T>(this Quantity<T, NanoVolt> val) where T:IConvertible {
        return new Quantity<double, HectoVolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoVolt to DekaVolt
    /// </summary>
    /// <param name="val">quantity measured in NanoVolt</param>
    /// <returns>quantity measured in DekaVolt</returns>
	public static Quantity<double, DekaVolt> ToDekaVolt<T>(this Quantity<T, NanoVolt> val) where T:IConvertible {
        return new Quantity<double, DekaVolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoVolt to DeciVolt
    /// </summary>
    /// <param name="val">quantity measured in NanoVolt</param>
    /// <returns>quantity measured in DeciVolt</returns>
	public static Quantity<double, DeciVolt> ToDeciVolt<T>(this Quantity<T, NanoVolt> val) where T:IConvertible {
        return new Quantity<double, DeciVolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoVolt to CentiVolt
    /// </summary>
    /// <param name="val">quantity measured in NanoVolt</param>
    /// <returns>quantity measured in CentiVolt</returns>
	public static Quantity<double, CentiVolt> ToCentiVolt<T>(this Quantity<T, NanoVolt> val) where T:IConvertible {
        return new Quantity<double, CentiVolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoVolt to MilliVolt
    /// </summary>
    /// <param name="val">quantity measured in NanoVolt</param>
    /// <returns>quantity measured in MilliVolt</returns>
	public static Quantity<double, MilliVolt> ToMilliVolt<T>(this Quantity<T, NanoVolt> val) where T:IConvertible {
        return new Quantity<double, MilliVolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoVolt to MicroVolt
    /// </summary>
    /// <param name="val">quantity measured in NanoVolt</param>
    /// <returns>quantity measured in MicroVolt</returns>
	public static Quantity<double, MicroVolt> ToMicroVolt<T>(this Quantity<T, NanoVolt> val) where T:IConvertible {
        return new Quantity<double, MicroVolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoVolt to PicoVolt
    /// </summary>
    /// <param name="val">quantity measured in NanoVolt</param>
    /// <returns>quantity measured in PicoVolt</returns>
	public static Quantity<double, PicoVolt> ToPicoVolt<T>(this Quantity<T, NanoVolt> val) where T:IConvertible {
        return new Quantity<double, PicoVolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoVolt to FemtoVolt
    /// </summary>
    /// <param name="val">quantity measured in NanoVolt</param>
    /// <returns>quantity measured in FemtoVolt</returns>
	public static Quantity<double, FemtoVolt> ToFemtoVolt<T>(this Quantity<T, NanoVolt> val) where T:IConvertible {
        return new Quantity<double, FemtoVolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoVolt to AttoVolt
    /// </summary>
    /// <param name="val">quantity measured in NanoVolt</param>
    /// <returns>quantity measured in AttoVolt</returns>
	public static Quantity<double, AttoVolt> ToAttoVolt<T>(this Quantity<T, NanoVolt> val) where T:IConvertible {
        return new Quantity<double, AttoVolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoVolt to ZeptoVolt
    /// </summary>
    /// <param name="val">quantity measured in NanoVolt</param>
    /// <returns>quantity measured in ZeptoVolt</returns>
	public static Quantity<double, ZeptoVolt> ToZeptoVolt<T>(this Quantity<T, NanoVolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoVolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoVolt to YoctoVolt
    /// </summary>
    /// <param name="val">quantity measured in NanoVolt</param>
    /// <returns>quantity measured in YoctoVolt</returns>
	public static Quantity<double, YoctoVolt> ToYoctoVolt<T>(this Quantity<T, NanoVolt> val) where T:IConvertible {
        return new Quantity<double, YoctoVolt>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert PicoVolt to YottaVolt
    /// </summary>
    /// <param name="val">quantity measured in PicoVolt</param>
    /// <returns>quantity measured in YottaVolt</returns>
	public static Quantity<double, YottaVolt> ToYottaVolt<T>(this Quantity<T, PicoVolt> val) where T:IConvertible {
        return new Quantity<double, YottaVolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoVolt to ZettaVolt
    /// </summary>
    /// <param name="val">quantity measured in PicoVolt</param>
    /// <returns>quantity measured in ZettaVolt</returns>
	public static Quantity<double, ZettaVolt> ToZettaVolt<T>(this Quantity<T, PicoVolt> val) where T:IConvertible {
        return new Quantity<double, ZettaVolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoVolt to ExaVolt
    /// </summary>
    /// <param name="val">quantity measured in PicoVolt</param>
    /// <returns>quantity measured in ExaVolt</returns>
	public static Quantity<double, ExaVolt> ToExaVolt<T>(this Quantity<T, PicoVolt> val) where T:IConvertible {
        return new Quantity<double, ExaVolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoVolt to PetaVolt
    /// </summary>
    /// <param name="val">quantity measured in PicoVolt</param>
    /// <returns>quantity measured in PetaVolt</returns>
	public static Quantity<double, PetaVolt> ToPetaVolt<T>(this Quantity<T, PicoVolt> val) where T:IConvertible {
        return new Quantity<double, PetaVolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoVolt to TeraVolt
    /// </summary>
    /// <param name="val">quantity measured in PicoVolt</param>
    /// <returns>quantity measured in TeraVolt</returns>
	public static Quantity<double, TeraVolt> ToTeraVolt<T>(this Quantity<T, PicoVolt> val) where T:IConvertible {
        return new Quantity<double, TeraVolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoVolt to GigaVolt
    /// </summary>
    /// <param name="val">quantity measured in PicoVolt</param>
    /// <returns>quantity measured in GigaVolt</returns>
	public static Quantity<double, GigaVolt> ToGigaVolt<T>(this Quantity<T, PicoVolt> val) where T:IConvertible {
        return new Quantity<double, GigaVolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoVolt to MegaVolt
    /// </summary>
    /// <param name="val">quantity measured in PicoVolt</param>
    /// <returns>quantity measured in MegaVolt</returns>
	public static Quantity<double, MegaVolt> ToMegaVolt<T>(this Quantity<T, PicoVolt> val) where T:IConvertible {
        return new Quantity<double, MegaVolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoVolt to KiloVolt
    /// </summary>
    /// <param name="val">quantity measured in PicoVolt</param>
    /// <returns>quantity measured in KiloVolt</returns>
	public static Quantity<double, KiloVolt> ToKiloVolt<T>(this Quantity<T, PicoVolt> val) where T:IConvertible {
        return new Quantity<double, KiloVolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoVolt to HectoVolt
    /// </summary>
    /// <param name="val">quantity measured in PicoVolt</param>
    /// <returns>quantity measured in HectoVolt</returns>
	public static Quantity<double, HectoVolt> ToHectoVolt<T>(this Quantity<T, PicoVolt> val) where T:IConvertible {
        return new Quantity<double, HectoVolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoVolt to DekaVolt
    /// </summary>
    /// <param name="val">quantity measured in PicoVolt</param>
    /// <returns>quantity measured in DekaVolt</returns>
	public static Quantity<double, DekaVolt> ToDekaVolt<T>(this Quantity<T, PicoVolt> val) where T:IConvertible {
        return new Quantity<double, DekaVolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoVolt to DeciVolt
    /// </summary>
    /// <param name="val">quantity measured in PicoVolt</param>
    /// <returns>quantity measured in DeciVolt</returns>
	public static Quantity<double, DeciVolt> ToDeciVolt<T>(this Quantity<T, PicoVolt> val) where T:IConvertible {
        return new Quantity<double, DeciVolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoVolt to CentiVolt
    /// </summary>
    /// <param name="val">quantity measured in PicoVolt</param>
    /// <returns>quantity measured in CentiVolt</returns>
	public static Quantity<double, CentiVolt> ToCentiVolt<T>(this Quantity<T, PicoVolt> val) where T:IConvertible {
        return new Quantity<double, CentiVolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoVolt to MilliVolt
    /// </summary>
    /// <param name="val">quantity measured in PicoVolt</param>
    /// <returns>quantity measured in MilliVolt</returns>
	public static Quantity<double, MilliVolt> ToMilliVolt<T>(this Quantity<T, PicoVolt> val) where T:IConvertible {
        return new Quantity<double, MilliVolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoVolt to MicroVolt
    /// </summary>
    /// <param name="val">quantity measured in PicoVolt</param>
    /// <returns>quantity measured in MicroVolt</returns>
	public static Quantity<double, MicroVolt> ToMicroVolt<T>(this Quantity<T, PicoVolt> val) where T:IConvertible {
        return new Quantity<double, MicroVolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoVolt to NanoVolt
    /// </summary>
    /// <param name="val">quantity measured in PicoVolt</param>
    /// <returns>quantity measured in NanoVolt</returns>
	public static Quantity<double, NanoVolt> ToNanoVolt<T>(this Quantity<T, PicoVolt> val) where T:IConvertible {
        return new Quantity<double, NanoVolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoVolt to FemtoVolt
    /// </summary>
    /// <param name="val">quantity measured in PicoVolt</param>
    /// <returns>quantity measured in FemtoVolt</returns>
	public static Quantity<double, FemtoVolt> ToFemtoVolt<T>(this Quantity<T, PicoVolt> val) where T:IConvertible {
        return new Quantity<double, FemtoVolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoVolt to AttoVolt
    /// </summary>
    /// <param name="val">quantity measured in PicoVolt</param>
    /// <returns>quantity measured in AttoVolt</returns>
	public static Quantity<double, AttoVolt> ToAttoVolt<T>(this Quantity<T, PicoVolt> val) where T:IConvertible {
        return new Quantity<double, AttoVolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoVolt to ZeptoVolt
    /// </summary>
    /// <param name="val">quantity measured in PicoVolt</param>
    /// <returns>quantity measured in ZeptoVolt</returns>
	public static Quantity<double, ZeptoVolt> ToZeptoVolt<T>(this Quantity<T, PicoVolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoVolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoVolt to YoctoVolt
    /// </summary>
    /// <param name="val">quantity measured in PicoVolt</param>
    /// <returns>quantity measured in YoctoVolt</returns>
	public static Quantity<double, YoctoVolt> ToYoctoVolt<T>(this Quantity<T, PicoVolt> val) where T:IConvertible {
        return new Quantity<double, YoctoVolt>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert FemtoVolt to YottaVolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoVolt</param>
    /// <returns>quantity measured in YottaVolt</returns>
	public static Quantity<double, YottaVolt> ToYottaVolt<T>(this Quantity<T, FemtoVolt> val) where T:IConvertible {
        return new Quantity<double, YottaVolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoVolt to ZettaVolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoVolt</param>
    /// <returns>quantity measured in ZettaVolt</returns>
	public static Quantity<double, ZettaVolt> ToZettaVolt<T>(this Quantity<T, FemtoVolt> val) where T:IConvertible {
        return new Quantity<double, ZettaVolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoVolt to ExaVolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoVolt</param>
    /// <returns>quantity measured in ExaVolt</returns>
	public static Quantity<double, ExaVolt> ToExaVolt<T>(this Quantity<T, FemtoVolt> val) where T:IConvertible {
        return new Quantity<double, ExaVolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoVolt to PetaVolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoVolt</param>
    /// <returns>quantity measured in PetaVolt</returns>
	public static Quantity<double, PetaVolt> ToPetaVolt<T>(this Quantity<T, FemtoVolt> val) where T:IConvertible {
        return new Quantity<double, PetaVolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoVolt to TeraVolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoVolt</param>
    /// <returns>quantity measured in TeraVolt</returns>
	public static Quantity<double, TeraVolt> ToTeraVolt<T>(this Quantity<T, FemtoVolt> val) where T:IConvertible {
        return new Quantity<double, TeraVolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoVolt to GigaVolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoVolt</param>
    /// <returns>quantity measured in GigaVolt</returns>
	public static Quantity<double, GigaVolt> ToGigaVolt<T>(this Quantity<T, FemtoVolt> val) where T:IConvertible {
        return new Quantity<double, GigaVolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoVolt to MegaVolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoVolt</param>
    /// <returns>quantity measured in MegaVolt</returns>
	public static Quantity<double, MegaVolt> ToMegaVolt<T>(this Quantity<T, FemtoVolt> val) where T:IConvertible {
        return new Quantity<double, MegaVolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoVolt to KiloVolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoVolt</param>
    /// <returns>quantity measured in KiloVolt</returns>
	public static Quantity<double, KiloVolt> ToKiloVolt<T>(this Quantity<T, FemtoVolt> val) where T:IConvertible {
        return new Quantity<double, KiloVolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoVolt to HectoVolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoVolt</param>
    /// <returns>quantity measured in HectoVolt</returns>
	public static Quantity<double, HectoVolt> ToHectoVolt<T>(this Quantity<T, FemtoVolt> val) where T:IConvertible {
        return new Quantity<double, HectoVolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoVolt to DekaVolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoVolt</param>
    /// <returns>quantity measured in DekaVolt</returns>
	public static Quantity<double, DekaVolt> ToDekaVolt<T>(this Quantity<T, FemtoVolt> val) where T:IConvertible {
        return new Quantity<double, DekaVolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoVolt to DeciVolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoVolt</param>
    /// <returns>quantity measured in DeciVolt</returns>
	public static Quantity<double, DeciVolt> ToDeciVolt<T>(this Quantity<T, FemtoVolt> val) where T:IConvertible {
        return new Quantity<double, DeciVolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoVolt to CentiVolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoVolt</param>
    /// <returns>quantity measured in CentiVolt</returns>
	public static Quantity<double, CentiVolt> ToCentiVolt<T>(this Quantity<T, FemtoVolt> val) where T:IConvertible {
        return new Quantity<double, CentiVolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoVolt to MilliVolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoVolt</param>
    /// <returns>quantity measured in MilliVolt</returns>
	public static Quantity<double, MilliVolt> ToMilliVolt<T>(this Quantity<T, FemtoVolt> val) where T:IConvertible {
        return new Quantity<double, MilliVolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoVolt to MicroVolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoVolt</param>
    /// <returns>quantity measured in MicroVolt</returns>
	public static Quantity<double, MicroVolt> ToMicroVolt<T>(this Quantity<T, FemtoVolt> val) where T:IConvertible {
        return new Quantity<double, MicroVolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoVolt to NanoVolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoVolt</param>
    /// <returns>quantity measured in NanoVolt</returns>
	public static Quantity<double, NanoVolt> ToNanoVolt<T>(this Quantity<T, FemtoVolt> val) where T:IConvertible {
        return new Quantity<double, NanoVolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoVolt to PicoVolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoVolt</param>
    /// <returns>quantity measured in PicoVolt</returns>
	public static Quantity<double, PicoVolt> ToPicoVolt<T>(this Quantity<T, FemtoVolt> val) where T:IConvertible {
        return new Quantity<double, PicoVolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoVolt to AttoVolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoVolt</param>
    /// <returns>quantity measured in AttoVolt</returns>
	public static Quantity<double, AttoVolt> ToAttoVolt<T>(this Quantity<T, FemtoVolt> val) where T:IConvertible {
        return new Quantity<double, AttoVolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoVolt to ZeptoVolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoVolt</param>
    /// <returns>quantity measured in ZeptoVolt</returns>
	public static Quantity<double, ZeptoVolt> ToZeptoVolt<T>(this Quantity<T, FemtoVolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoVolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoVolt to YoctoVolt
    /// </summary>
    /// <param name="val">quantity measured in FemtoVolt</param>
    /// <returns>quantity measured in YoctoVolt</returns>
	public static Quantity<double, YoctoVolt> ToYoctoVolt<T>(this Quantity<T, FemtoVolt> val) where T:IConvertible {
        return new Quantity<double, YoctoVolt>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert AttoVolt to YottaVolt
    /// </summary>
    /// <param name="val">quantity measured in AttoVolt</param>
    /// <returns>quantity measured in YottaVolt</returns>
	public static Quantity<double, YottaVolt> ToYottaVolt<T>(this Quantity<T, AttoVolt> val) where T:IConvertible {
        return new Quantity<double, YottaVolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoVolt to ZettaVolt
    /// </summary>
    /// <param name="val">quantity measured in AttoVolt</param>
    /// <returns>quantity measured in ZettaVolt</returns>
	public static Quantity<double, ZettaVolt> ToZettaVolt<T>(this Quantity<T, AttoVolt> val) where T:IConvertible {
        return new Quantity<double, ZettaVolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoVolt to ExaVolt
    /// </summary>
    /// <param name="val">quantity measured in AttoVolt</param>
    /// <returns>quantity measured in ExaVolt</returns>
	public static Quantity<double, ExaVolt> ToExaVolt<T>(this Quantity<T, AttoVolt> val) where T:IConvertible {
        return new Quantity<double, ExaVolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoVolt to PetaVolt
    /// </summary>
    /// <param name="val">quantity measured in AttoVolt</param>
    /// <returns>quantity measured in PetaVolt</returns>
	public static Quantity<double, PetaVolt> ToPetaVolt<T>(this Quantity<T, AttoVolt> val) where T:IConvertible {
        return new Quantity<double, PetaVolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoVolt to TeraVolt
    /// </summary>
    /// <param name="val">quantity measured in AttoVolt</param>
    /// <returns>quantity measured in TeraVolt</returns>
	public static Quantity<double, TeraVolt> ToTeraVolt<T>(this Quantity<T, AttoVolt> val) where T:IConvertible {
        return new Quantity<double, TeraVolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoVolt to GigaVolt
    /// </summary>
    /// <param name="val">quantity measured in AttoVolt</param>
    /// <returns>quantity measured in GigaVolt</returns>
	public static Quantity<double, GigaVolt> ToGigaVolt<T>(this Quantity<T, AttoVolt> val) where T:IConvertible {
        return new Quantity<double, GigaVolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoVolt to MegaVolt
    /// </summary>
    /// <param name="val">quantity measured in AttoVolt</param>
    /// <returns>quantity measured in MegaVolt</returns>
	public static Quantity<double, MegaVolt> ToMegaVolt<T>(this Quantity<T, AttoVolt> val) where T:IConvertible {
        return new Quantity<double, MegaVolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoVolt to KiloVolt
    /// </summary>
    /// <param name="val">quantity measured in AttoVolt</param>
    /// <returns>quantity measured in KiloVolt</returns>
	public static Quantity<double, KiloVolt> ToKiloVolt<T>(this Quantity<T, AttoVolt> val) where T:IConvertible {
        return new Quantity<double, KiloVolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoVolt to HectoVolt
    /// </summary>
    /// <param name="val">quantity measured in AttoVolt</param>
    /// <returns>quantity measured in HectoVolt</returns>
	public static Quantity<double, HectoVolt> ToHectoVolt<T>(this Quantity<T, AttoVolt> val) where T:IConvertible {
        return new Quantity<double, HectoVolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoVolt to DekaVolt
    /// </summary>
    /// <param name="val">quantity measured in AttoVolt</param>
    /// <returns>quantity measured in DekaVolt</returns>
	public static Quantity<double, DekaVolt> ToDekaVolt<T>(this Quantity<T, AttoVolt> val) where T:IConvertible {
        return new Quantity<double, DekaVolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoVolt to DeciVolt
    /// </summary>
    /// <param name="val">quantity measured in AttoVolt</param>
    /// <returns>quantity measured in DeciVolt</returns>
	public static Quantity<double, DeciVolt> ToDeciVolt<T>(this Quantity<T, AttoVolt> val) where T:IConvertible {
        return new Quantity<double, DeciVolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoVolt to CentiVolt
    /// </summary>
    /// <param name="val">quantity measured in AttoVolt</param>
    /// <returns>quantity measured in CentiVolt</returns>
	public static Quantity<double, CentiVolt> ToCentiVolt<T>(this Quantity<T, AttoVolt> val) where T:IConvertible {
        return new Quantity<double, CentiVolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoVolt to MilliVolt
    /// </summary>
    /// <param name="val">quantity measured in AttoVolt</param>
    /// <returns>quantity measured in MilliVolt</returns>
	public static Quantity<double, MilliVolt> ToMilliVolt<T>(this Quantity<T, AttoVolt> val) where T:IConvertible {
        return new Quantity<double, MilliVolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoVolt to MicroVolt
    /// </summary>
    /// <param name="val">quantity measured in AttoVolt</param>
    /// <returns>quantity measured in MicroVolt</returns>
	public static Quantity<double, MicroVolt> ToMicroVolt<T>(this Quantity<T, AttoVolt> val) where T:IConvertible {
        return new Quantity<double, MicroVolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoVolt to NanoVolt
    /// </summary>
    /// <param name="val">quantity measured in AttoVolt</param>
    /// <returns>quantity measured in NanoVolt</returns>
	public static Quantity<double, NanoVolt> ToNanoVolt<T>(this Quantity<T, AttoVolt> val) where T:IConvertible {
        return new Quantity<double, NanoVolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoVolt to PicoVolt
    /// </summary>
    /// <param name="val">quantity measured in AttoVolt</param>
    /// <returns>quantity measured in PicoVolt</returns>
	public static Quantity<double, PicoVolt> ToPicoVolt<T>(this Quantity<T, AttoVolt> val) where T:IConvertible {
        return new Quantity<double, PicoVolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoVolt to FemtoVolt
    /// </summary>
    /// <param name="val">quantity measured in AttoVolt</param>
    /// <returns>quantity measured in FemtoVolt</returns>
	public static Quantity<double, FemtoVolt> ToFemtoVolt<T>(this Quantity<T, AttoVolt> val) where T:IConvertible {
        return new Quantity<double, FemtoVolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoVolt to ZeptoVolt
    /// </summary>
    /// <param name="val">quantity measured in AttoVolt</param>
    /// <returns>quantity measured in ZeptoVolt</returns>
	public static Quantity<double, ZeptoVolt> ToZeptoVolt<T>(this Quantity<T, AttoVolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoVolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoVolt to YoctoVolt
    /// </summary>
    /// <param name="val">quantity measured in AttoVolt</param>
    /// <returns>quantity measured in YoctoVolt</returns>
	public static Quantity<double, YoctoVolt> ToYoctoVolt<T>(this Quantity<T, AttoVolt> val) where T:IConvertible {
        return new Quantity<double, YoctoVolt>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoVolt to YottaVolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoVolt</param>
    /// <returns>quantity measured in YottaVolt</returns>
	public static Quantity<double, YottaVolt> ToYottaVolt<T>(this Quantity<T, ZeptoVolt> val) where T:IConvertible {
        return new Quantity<double, YottaVolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoVolt to ZettaVolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoVolt</param>
    /// <returns>quantity measured in ZettaVolt</returns>
	public static Quantity<double, ZettaVolt> ToZettaVolt<T>(this Quantity<T, ZeptoVolt> val) where T:IConvertible {
        return new Quantity<double, ZettaVolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoVolt to ExaVolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoVolt</param>
    /// <returns>quantity measured in ExaVolt</returns>
	public static Quantity<double, ExaVolt> ToExaVolt<T>(this Quantity<T, ZeptoVolt> val) where T:IConvertible {
        return new Quantity<double, ExaVolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoVolt to PetaVolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoVolt</param>
    /// <returns>quantity measured in PetaVolt</returns>
	public static Quantity<double, PetaVolt> ToPetaVolt<T>(this Quantity<T, ZeptoVolt> val) where T:IConvertible {
        return new Quantity<double, PetaVolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoVolt to TeraVolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoVolt</param>
    /// <returns>quantity measured in TeraVolt</returns>
	public static Quantity<double, TeraVolt> ToTeraVolt<T>(this Quantity<T, ZeptoVolt> val) where T:IConvertible {
        return new Quantity<double, TeraVolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoVolt to GigaVolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoVolt</param>
    /// <returns>quantity measured in GigaVolt</returns>
	public static Quantity<double, GigaVolt> ToGigaVolt<T>(this Quantity<T, ZeptoVolt> val) where T:IConvertible {
        return new Quantity<double, GigaVolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoVolt to MegaVolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoVolt</param>
    /// <returns>quantity measured in MegaVolt</returns>
	public static Quantity<double, MegaVolt> ToMegaVolt<T>(this Quantity<T, ZeptoVolt> val) where T:IConvertible {
        return new Quantity<double, MegaVolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoVolt to KiloVolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoVolt</param>
    /// <returns>quantity measured in KiloVolt</returns>
	public static Quantity<double, KiloVolt> ToKiloVolt<T>(this Quantity<T, ZeptoVolt> val) where T:IConvertible {
        return new Quantity<double, KiloVolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoVolt to HectoVolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoVolt</param>
    /// <returns>quantity measured in HectoVolt</returns>
	public static Quantity<double, HectoVolt> ToHectoVolt<T>(this Quantity<T, ZeptoVolt> val) where T:IConvertible {
        return new Quantity<double, HectoVolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoVolt to DekaVolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoVolt</param>
    /// <returns>quantity measured in DekaVolt</returns>
	public static Quantity<double, DekaVolt> ToDekaVolt<T>(this Quantity<T, ZeptoVolt> val) where T:IConvertible {
        return new Quantity<double, DekaVolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoVolt to DeciVolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoVolt</param>
    /// <returns>quantity measured in DeciVolt</returns>
	public static Quantity<double, DeciVolt> ToDeciVolt<T>(this Quantity<T, ZeptoVolt> val) where T:IConvertible {
        return new Quantity<double, DeciVolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoVolt to CentiVolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoVolt</param>
    /// <returns>quantity measured in CentiVolt</returns>
	public static Quantity<double, CentiVolt> ToCentiVolt<T>(this Quantity<T, ZeptoVolt> val) where T:IConvertible {
        return new Quantity<double, CentiVolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoVolt to MilliVolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoVolt</param>
    /// <returns>quantity measured in MilliVolt</returns>
	public static Quantity<double, MilliVolt> ToMilliVolt<T>(this Quantity<T, ZeptoVolt> val) where T:IConvertible {
        return new Quantity<double, MilliVolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoVolt to MicroVolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoVolt</param>
    /// <returns>quantity measured in MicroVolt</returns>
	public static Quantity<double, MicroVolt> ToMicroVolt<T>(this Quantity<T, ZeptoVolt> val) where T:IConvertible {
        return new Quantity<double, MicroVolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoVolt to NanoVolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoVolt</param>
    /// <returns>quantity measured in NanoVolt</returns>
	public static Quantity<double, NanoVolt> ToNanoVolt<T>(this Quantity<T, ZeptoVolt> val) where T:IConvertible {
        return new Quantity<double, NanoVolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoVolt to PicoVolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoVolt</param>
    /// <returns>quantity measured in PicoVolt</returns>
	public static Quantity<double, PicoVolt> ToPicoVolt<T>(this Quantity<T, ZeptoVolt> val) where T:IConvertible {
        return new Quantity<double, PicoVolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoVolt to FemtoVolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoVolt</param>
    /// <returns>quantity measured in FemtoVolt</returns>
	public static Quantity<double, FemtoVolt> ToFemtoVolt<T>(this Quantity<T, ZeptoVolt> val) where T:IConvertible {
        return new Quantity<double, FemtoVolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoVolt to AttoVolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoVolt</param>
    /// <returns>quantity measured in AttoVolt</returns>
	public static Quantity<double, AttoVolt> ToAttoVolt<T>(this Quantity<T, ZeptoVolt> val) where T:IConvertible {
        return new Quantity<double, AttoVolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoVolt to YoctoVolt
    /// </summary>
    /// <param name="val">quantity measured in ZeptoVolt</param>
    /// <returns>quantity measured in YoctoVolt</returns>
	public static Quantity<double, YoctoVolt> ToYoctoVolt<T>(this Quantity<T, ZeptoVolt> val) where T:IConvertible {
        return new Quantity<double, YoctoVolt>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert YoctoVolt to YottaVolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoVolt</param>
    /// <returns>quantity measured in YottaVolt</returns>
	public static Quantity<double, YottaVolt> ToYottaVolt<T>(this Quantity<T, YoctoVolt> val) where T:IConvertible {
        return new Quantity<double, YottaVolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoVolt to ZettaVolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoVolt</param>
    /// <returns>quantity measured in ZettaVolt</returns>
	public static Quantity<double, ZettaVolt> ToZettaVolt<T>(this Quantity<T, YoctoVolt> val) where T:IConvertible {
        return new Quantity<double, ZettaVolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoVolt to ExaVolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoVolt</param>
    /// <returns>quantity measured in ExaVolt</returns>
	public static Quantity<double, ExaVolt> ToExaVolt<T>(this Quantity<T, YoctoVolt> val) where T:IConvertible {
        return new Quantity<double, ExaVolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoVolt to PetaVolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoVolt</param>
    /// <returns>quantity measured in PetaVolt</returns>
	public static Quantity<double, PetaVolt> ToPetaVolt<T>(this Quantity<T, YoctoVolt> val) where T:IConvertible {
        return new Quantity<double, PetaVolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoVolt to TeraVolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoVolt</param>
    /// <returns>quantity measured in TeraVolt</returns>
	public static Quantity<double, TeraVolt> ToTeraVolt<T>(this Quantity<T, YoctoVolt> val) where T:IConvertible {
        return new Quantity<double, TeraVolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoVolt to GigaVolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoVolt</param>
    /// <returns>quantity measured in GigaVolt</returns>
	public static Quantity<double, GigaVolt> ToGigaVolt<T>(this Quantity<T, YoctoVolt> val) where T:IConvertible {
        return new Quantity<double, GigaVolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoVolt to MegaVolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoVolt</param>
    /// <returns>quantity measured in MegaVolt</returns>
	public static Quantity<double, MegaVolt> ToMegaVolt<T>(this Quantity<T, YoctoVolt> val) where T:IConvertible {
        return new Quantity<double, MegaVolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoVolt to KiloVolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoVolt</param>
    /// <returns>quantity measured in KiloVolt</returns>
	public static Quantity<double, KiloVolt> ToKiloVolt<T>(this Quantity<T, YoctoVolt> val) where T:IConvertible {
        return new Quantity<double, KiloVolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoVolt to HectoVolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoVolt</param>
    /// <returns>quantity measured in HectoVolt</returns>
	public static Quantity<double, HectoVolt> ToHectoVolt<T>(this Quantity<T, YoctoVolt> val) where T:IConvertible {
        return new Quantity<double, HectoVolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoVolt to DekaVolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoVolt</param>
    /// <returns>quantity measured in DekaVolt</returns>
	public static Quantity<double, DekaVolt> ToDekaVolt<T>(this Quantity<T, YoctoVolt> val) where T:IConvertible {
        return new Quantity<double, DekaVolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoVolt to DeciVolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoVolt</param>
    /// <returns>quantity measured in DeciVolt</returns>
	public static Quantity<double, DeciVolt> ToDeciVolt<T>(this Quantity<T, YoctoVolt> val) where T:IConvertible {
        return new Quantity<double, DeciVolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoVolt to CentiVolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoVolt</param>
    /// <returns>quantity measured in CentiVolt</returns>
	public static Quantity<double, CentiVolt> ToCentiVolt<T>(this Quantity<T, YoctoVolt> val) where T:IConvertible {
        return new Quantity<double, CentiVolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoVolt to MilliVolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoVolt</param>
    /// <returns>quantity measured in MilliVolt</returns>
	public static Quantity<double, MilliVolt> ToMilliVolt<T>(this Quantity<T, YoctoVolt> val) where T:IConvertible {
        return new Quantity<double, MilliVolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoVolt to MicroVolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoVolt</param>
    /// <returns>quantity measured in MicroVolt</returns>
	public static Quantity<double, MicroVolt> ToMicroVolt<T>(this Quantity<T, YoctoVolt> val) where T:IConvertible {
        return new Quantity<double, MicroVolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoVolt to NanoVolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoVolt</param>
    /// <returns>quantity measured in NanoVolt</returns>
	public static Quantity<double, NanoVolt> ToNanoVolt<T>(this Quantity<T, YoctoVolt> val) where T:IConvertible {
        return new Quantity<double, NanoVolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoVolt to PicoVolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoVolt</param>
    /// <returns>quantity measured in PicoVolt</returns>
	public static Quantity<double, PicoVolt> ToPicoVolt<T>(this Quantity<T, YoctoVolt> val) where T:IConvertible {
        return new Quantity<double, PicoVolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoVolt to FemtoVolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoVolt</param>
    /// <returns>quantity measured in FemtoVolt</returns>
	public static Quantity<double, FemtoVolt> ToFemtoVolt<T>(this Quantity<T, YoctoVolt> val) where T:IConvertible {
        return new Quantity<double, FemtoVolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoVolt to AttoVolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoVolt</param>
    /// <returns>quantity measured in AttoVolt</returns>
	public static Quantity<double, AttoVolt> ToAttoVolt<T>(this Quantity<T, YoctoVolt> val) where T:IConvertible {
        return new Quantity<double, AttoVolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoVolt to ZeptoVolt
    /// </summary>
    /// <param name="val">quantity measured in YoctoVolt</param>
    /// <returns>quantity measured in ZeptoVolt</returns>
	public static Quantity<double, ZeptoVolt> ToZeptoVolt<T>(this Quantity<T, YoctoVolt> val) where T:IConvertible {
        return new Quantity<double, ZeptoVolt>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
}
}