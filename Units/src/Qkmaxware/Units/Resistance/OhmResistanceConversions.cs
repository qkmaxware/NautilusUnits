using System;
namespace Qkmaxware.Units.Resistance {
/// <summary>
/// Static class housing si-prefix conversions for the unit "Ohm"
/// </summary>
public static class ResistanceConversions {
	/// <summary>
    /// Extension method to convert Ohm to YottaOhm
    /// </summary>
    /// <param name="val">quantity measured in Ohm</param>
    /// <returns>quantity measured in YottaOhm</returns>
	public static Quantity<double, YottaOhm> ToYottaOhm<T>(this Quantity<T, Ohm> val) where T:IConvertible {
        return new Quantity<double, YottaOhm>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Ohm to ZettaOhm
    /// </summary>
    /// <param name="val">quantity measured in Ohm</param>
    /// <returns>quantity measured in ZettaOhm</returns>
	public static Quantity<double, ZettaOhm> ToZettaOhm<T>(this Quantity<T, Ohm> val) where T:IConvertible {
        return new Quantity<double, ZettaOhm>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Ohm to ExaOhm
    /// </summary>
    /// <param name="val">quantity measured in Ohm</param>
    /// <returns>quantity measured in ExaOhm</returns>
	public static Quantity<double, ExaOhm> ToExaOhm<T>(this Quantity<T, Ohm> val) where T:IConvertible {
        return new Quantity<double, ExaOhm>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Ohm to PetaOhm
    /// </summary>
    /// <param name="val">quantity measured in Ohm</param>
    /// <returns>quantity measured in PetaOhm</returns>
	public static Quantity<double, PetaOhm> ToPetaOhm<T>(this Quantity<T, Ohm> val) where T:IConvertible {
        return new Quantity<double, PetaOhm>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Ohm to TeraOhm
    /// </summary>
    /// <param name="val">quantity measured in Ohm</param>
    /// <returns>quantity measured in TeraOhm</returns>
	public static Quantity<double, TeraOhm> ToTeraOhm<T>(this Quantity<T, Ohm> val) where T:IConvertible {
        return new Quantity<double, TeraOhm>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Ohm to GigaOhm
    /// </summary>
    /// <param name="val">quantity measured in Ohm</param>
    /// <returns>quantity measured in GigaOhm</returns>
	public static Quantity<double, GigaOhm> ToGigaOhm<T>(this Quantity<T, Ohm> val) where T:IConvertible {
        return new Quantity<double, GigaOhm>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Ohm to MegaOhm
    /// </summary>
    /// <param name="val">quantity measured in Ohm</param>
    /// <returns>quantity measured in MegaOhm</returns>
	public static Quantity<double, MegaOhm> ToMegaOhm<T>(this Quantity<T, Ohm> val) where T:IConvertible {
        return new Quantity<double, MegaOhm>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Ohm to KiloOhm
    /// </summary>
    /// <param name="val">quantity measured in Ohm</param>
    /// <returns>quantity measured in KiloOhm</returns>
	public static Quantity<double, KiloOhm> ToKiloOhm<T>(this Quantity<T, Ohm> val) where T:IConvertible {
        return new Quantity<double, KiloOhm>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Ohm to HectoOhm
    /// </summary>
    /// <param name="val">quantity measured in Ohm</param>
    /// <returns>quantity measured in HectoOhm</returns>
	public static Quantity<double, HectoOhm> ToHectoOhm<T>(this Quantity<T, Ohm> val) where T:IConvertible {
        return new Quantity<double, HectoOhm>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Ohm to DekaOhm
    /// </summary>
    /// <param name="val">quantity measured in Ohm</param>
    /// <returns>quantity measured in DekaOhm</returns>
	public static Quantity<double, DekaOhm> ToDekaOhm<T>(this Quantity<T, Ohm> val) where T:IConvertible {
        return new Quantity<double, DekaOhm>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Ohm to DeciOhm
    /// </summary>
    /// <param name="val">quantity measured in Ohm</param>
    /// <returns>quantity measured in DeciOhm</returns>
	public static Quantity<double, DeciOhm> ToDeciOhm<T>(this Quantity<T, Ohm> val) where T:IConvertible {
        return new Quantity<double, DeciOhm>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Ohm to CentiOhm
    /// </summary>
    /// <param name="val">quantity measured in Ohm</param>
    /// <returns>quantity measured in CentiOhm</returns>
	public static Quantity<double, CentiOhm> ToCentiOhm<T>(this Quantity<T, Ohm> val) where T:IConvertible {
        return new Quantity<double, CentiOhm>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Ohm to MilliOhm
    /// </summary>
    /// <param name="val">quantity measured in Ohm</param>
    /// <returns>quantity measured in MilliOhm</returns>
	public static Quantity<double, MilliOhm> ToMilliOhm<T>(this Quantity<T, Ohm> val) where T:IConvertible {
        return new Quantity<double, MilliOhm>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Ohm to MicroOhm
    /// </summary>
    /// <param name="val">quantity measured in Ohm</param>
    /// <returns>quantity measured in MicroOhm</returns>
	public static Quantity<double, MicroOhm> ToMicroOhm<T>(this Quantity<T, Ohm> val) where T:IConvertible {
        return new Quantity<double, MicroOhm>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Ohm to NanoOhm
    /// </summary>
    /// <param name="val">quantity measured in Ohm</param>
    /// <returns>quantity measured in NanoOhm</returns>
	public static Quantity<double, NanoOhm> ToNanoOhm<T>(this Quantity<T, Ohm> val) where T:IConvertible {
        return new Quantity<double, NanoOhm>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Ohm to PicoOhm
    /// </summary>
    /// <param name="val">quantity measured in Ohm</param>
    /// <returns>quantity measured in PicoOhm</returns>
	public static Quantity<double, PicoOhm> ToPicoOhm<T>(this Quantity<T, Ohm> val) where T:IConvertible {
        return new Quantity<double, PicoOhm>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Ohm to FemtoOhm
    /// </summary>
    /// <param name="val">quantity measured in Ohm</param>
    /// <returns>quantity measured in FemtoOhm</returns>
	public static Quantity<double, FemtoOhm> ToFemtoOhm<T>(this Quantity<T, Ohm> val) where T:IConvertible {
        return new Quantity<double, FemtoOhm>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Ohm to AttoOhm
    /// </summary>
    /// <param name="val">quantity measured in Ohm</param>
    /// <returns>quantity measured in AttoOhm</returns>
	public static Quantity<double, AttoOhm> ToAttoOhm<T>(this Quantity<T, Ohm> val) where T:IConvertible {
        return new Quantity<double, AttoOhm>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Ohm to ZeptoOhm
    /// </summary>
    /// <param name="val">quantity measured in Ohm</param>
    /// <returns>quantity measured in ZeptoOhm</returns>
	public static Quantity<double, ZeptoOhm> ToZeptoOhm<T>(this Quantity<T, Ohm> val) where T:IConvertible {
        return new Quantity<double, ZeptoOhm>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Ohm to YoctoOhm
    /// </summary>
    /// <param name="val">quantity measured in Ohm</param>
    /// <returns>quantity measured in YoctoOhm</returns>
	public static Quantity<double, YoctoOhm> ToYoctoOhm<T>(this Quantity<T, Ohm> val) where T:IConvertible {
        return new Quantity<double, YoctoOhm>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YottaOhm to ZettaOhm
    /// </summary>
    /// <param name="val">quantity measured in YottaOhm</param>
    /// <returns>quantity measured in ZettaOhm</returns>
	public static Quantity<double, ZettaOhm> ToZettaOhm<T>(this Quantity<T, YottaOhm> val) where T:IConvertible {
        return new Quantity<double, ZettaOhm>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaOhm to ExaOhm
    /// </summary>
    /// <param name="val">quantity measured in YottaOhm</param>
    /// <returns>quantity measured in ExaOhm</returns>
	public static Quantity<double, ExaOhm> ToExaOhm<T>(this Quantity<T, YottaOhm> val) where T:IConvertible {
        return new Quantity<double, ExaOhm>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaOhm to PetaOhm
    /// </summary>
    /// <param name="val">quantity measured in YottaOhm</param>
    /// <returns>quantity measured in PetaOhm</returns>
	public static Quantity<double, PetaOhm> ToPetaOhm<T>(this Quantity<T, YottaOhm> val) where T:IConvertible {
        return new Quantity<double, PetaOhm>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaOhm to TeraOhm
    /// </summary>
    /// <param name="val">quantity measured in YottaOhm</param>
    /// <returns>quantity measured in TeraOhm</returns>
	public static Quantity<double, TeraOhm> ToTeraOhm<T>(this Quantity<T, YottaOhm> val) where T:IConvertible {
        return new Quantity<double, TeraOhm>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaOhm to GigaOhm
    /// </summary>
    /// <param name="val">quantity measured in YottaOhm</param>
    /// <returns>quantity measured in GigaOhm</returns>
	public static Quantity<double, GigaOhm> ToGigaOhm<T>(this Quantity<T, YottaOhm> val) where T:IConvertible {
        return new Quantity<double, GigaOhm>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaOhm to MegaOhm
    /// </summary>
    /// <param name="val">quantity measured in YottaOhm</param>
    /// <returns>quantity measured in MegaOhm</returns>
	public static Quantity<double, MegaOhm> ToMegaOhm<T>(this Quantity<T, YottaOhm> val) where T:IConvertible {
        return new Quantity<double, MegaOhm>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaOhm to KiloOhm
    /// </summary>
    /// <param name="val">quantity measured in YottaOhm</param>
    /// <returns>quantity measured in KiloOhm</returns>
	public static Quantity<double, KiloOhm> ToKiloOhm<T>(this Quantity<T, YottaOhm> val) where T:IConvertible {
        return new Quantity<double, KiloOhm>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaOhm to HectoOhm
    /// </summary>
    /// <param name="val">quantity measured in YottaOhm</param>
    /// <returns>quantity measured in HectoOhm</returns>
	public static Quantity<double, HectoOhm> ToHectoOhm<T>(this Quantity<T, YottaOhm> val) where T:IConvertible {
        return new Quantity<double, HectoOhm>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaOhm to DekaOhm
    /// </summary>
    /// <param name="val">quantity measured in YottaOhm</param>
    /// <returns>quantity measured in DekaOhm</returns>
	public static Quantity<double, DekaOhm> ToDekaOhm<T>(this Quantity<T, YottaOhm> val) where T:IConvertible {
        return new Quantity<double, DekaOhm>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaOhm to DeciOhm
    /// </summary>
    /// <param name="val">quantity measured in YottaOhm</param>
    /// <returns>quantity measured in DeciOhm</returns>
	public static Quantity<double, DeciOhm> ToDeciOhm<T>(this Quantity<T, YottaOhm> val) where T:IConvertible {
        return new Quantity<double, DeciOhm>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaOhm to CentiOhm
    /// </summary>
    /// <param name="val">quantity measured in YottaOhm</param>
    /// <returns>quantity measured in CentiOhm</returns>
	public static Quantity<double, CentiOhm> ToCentiOhm<T>(this Quantity<T, YottaOhm> val) where T:IConvertible {
        return new Quantity<double, CentiOhm>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaOhm to MilliOhm
    /// </summary>
    /// <param name="val">quantity measured in YottaOhm</param>
    /// <returns>quantity measured in MilliOhm</returns>
	public static Quantity<double, MilliOhm> ToMilliOhm<T>(this Quantity<T, YottaOhm> val) where T:IConvertible {
        return new Quantity<double, MilliOhm>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaOhm to MicroOhm
    /// </summary>
    /// <param name="val">quantity measured in YottaOhm</param>
    /// <returns>quantity measured in MicroOhm</returns>
	public static Quantity<double, MicroOhm> ToMicroOhm<T>(this Quantity<T, YottaOhm> val) where T:IConvertible {
        return new Quantity<double, MicroOhm>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaOhm to NanoOhm
    /// </summary>
    /// <param name="val">quantity measured in YottaOhm</param>
    /// <returns>quantity measured in NanoOhm</returns>
	public static Quantity<double, NanoOhm> ToNanoOhm<T>(this Quantity<T, YottaOhm> val) where T:IConvertible {
        return new Quantity<double, NanoOhm>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaOhm to PicoOhm
    /// </summary>
    /// <param name="val">quantity measured in YottaOhm</param>
    /// <returns>quantity measured in PicoOhm</returns>
	public static Quantity<double, PicoOhm> ToPicoOhm<T>(this Quantity<T, YottaOhm> val) where T:IConvertible {
        return new Quantity<double, PicoOhm>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaOhm to FemtoOhm
    /// </summary>
    /// <param name="val">quantity measured in YottaOhm</param>
    /// <returns>quantity measured in FemtoOhm</returns>
	public static Quantity<double, FemtoOhm> ToFemtoOhm<T>(this Quantity<T, YottaOhm> val) where T:IConvertible {
        return new Quantity<double, FemtoOhm>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaOhm to AttoOhm
    /// </summary>
    /// <param name="val">quantity measured in YottaOhm</param>
    /// <returns>quantity measured in AttoOhm</returns>
	public static Quantity<double, AttoOhm> ToAttoOhm<T>(this Quantity<T, YottaOhm> val) where T:IConvertible {
        return new Quantity<double, AttoOhm>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaOhm to ZeptoOhm
    /// </summary>
    /// <param name="val">quantity measured in YottaOhm</param>
    /// <returns>quantity measured in ZeptoOhm</returns>
	public static Quantity<double, ZeptoOhm> ToZeptoOhm<T>(this Quantity<T, YottaOhm> val) where T:IConvertible {
        return new Quantity<double, ZeptoOhm>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaOhm to YoctoOhm
    /// </summary>
    /// <param name="val">quantity measured in YottaOhm</param>
    /// <returns>quantity measured in YoctoOhm</returns>
	public static Quantity<double, YoctoOhm> ToYoctoOhm<T>(this Quantity<T, YottaOhm> val) where T:IConvertible {
        return new Quantity<double, YoctoOhm>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert ZettaOhm to YottaOhm
    /// </summary>
    /// <param name="val">quantity measured in ZettaOhm</param>
    /// <returns>quantity measured in YottaOhm</returns>
	public static Quantity<double, YottaOhm> ToYottaOhm<T>(this Quantity<T, ZettaOhm> val) where T:IConvertible {
        return new Quantity<double, YottaOhm>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaOhm to ExaOhm
    /// </summary>
    /// <param name="val">quantity measured in ZettaOhm</param>
    /// <returns>quantity measured in ExaOhm</returns>
	public static Quantity<double, ExaOhm> ToExaOhm<T>(this Quantity<T, ZettaOhm> val) where T:IConvertible {
        return new Quantity<double, ExaOhm>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaOhm to PetaOhm
    /// </summary>
    /// <param name="val">quantity measured in ZettaOhm</param>
    /// <returns>quantity measured in PetaOhm</returns>
	public static Quantity<double, PetaOhm> ToPetaOhm<T>(this Quantity<T, ZettaOhm> val) where T:IConvertible {
        return new Quantity<double, PetaOhm>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaOhm to TeraOhm
    /// </summary>
    /// <param name="val">quantity measured in ZettaOhm</param>
    /// <returns>quantity measured in TeraOhm</returns>
	public static Quantity<double, TeraOhm> ToTeraOhm<T>(this Quantity<T, ZettaOhm> val) where T:IConvertible {
        return new Quantity<double, TeraOhm>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaOhm to GigaOhm
    /// </summary>
    /// <param name="val">quantity measured in ZettaOhm</param>
    /// <returns>quantity measured in GigaOhm</returns>
	public static Quantity<double, GigaOhm> ToGigaOhm<T>(this Quantity<T, ZettaOhm> val) where T:IConvertible {
        return new Quantity<double, GigaOhm>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaOhm to MegaOhm
    /// </summary>
    /// <param name="val">quantity measured in ZettaOhm</param>
    /// <returns>quantity measured in MegaOhm</returns>
	public static Quantity<double, MegaOhm> ToMegaOhm<T>(this Quantity<T, ZettaOhm> val) where T:IConvertible {
        return new Quantity<double, MegaOhm>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaOhm to KiloOhm
    /// </summary>
    /// <param name="val">quantity measured in ZettaOhm</param>
    /// <returns>quantity measured in KiloOhm</returns>
	public static Quantity<double, KiloOhm> ToKiloOhm<T>(this Quantity<T, ZettaOhm> val) where T:IConvertible {
        return new Quantity<double, KiloOhm>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaOhm to HectoOhm
    /// </summary>
    /// <param name="val">quantity measured in ZettaOhm</param>
    /// <returns>quantity measured in HectoOhm</returns>
	public static Quantity<double, HectoOhm> ToHectoOhm<T>(this Quantity<T, ZettaOhm> val) where T:IConvertible {
        return new Quantity<double, HectoOhm>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaOhm to DekaOhm
    /// </summary>
    /// <param name="val">quantity measured in ZettaOhm</param>
    /// <returns>quantity measured in DekaOhm</returns>
	public static Quantity<double, DekaOhm> ToDekaOhm<T>(this Quantity<T, ZettaOhm> val) where T:IConvertible {
        return new Quantity<double, DekaOhm>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaOhm to DeciOhm
    /// </summary>
    /// <param name="val">quantity measured in ZettaOhm</param>
    /// <returns>quantity measured in DeciOhm</returns>
	public static Quantity<double, DeciOhm> ToDeciOhm<T>(this Quantity<T, ZettaOhm> val) where T:IConvertible {
        return new Quantity<double, DeciOhm>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaOhm to CentiOhm
    /// </summary>
    /// <param name="val">quantity measured in ZettaOhm</param>
    /// <returns>quantity measured in CentiOhm</returns>
	public static Quantity<double, CentiOhm> ToCentiOhm<T>(this Quantity<T, ZettaOhm> val) where T:IConvertible {
        return new Quantity<double, CentiOhm>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaOhm to MilliOhm
    /// </summary>
    /// <param name="val">quantity measured in ZettaOhm</param>
    /// <returns>quantity measured in MilliOhm</returns>
	public static Quantity<double, MilliOhm> ToMilliOhm<T>(this Quantity<T, ZettaOhm> val) where T:IConvertible {
        return new Quantity<double, MilliOhm>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaOhm to MicroOhm
    /// </summary>
    /// <param name="val">quantity measured in ZettaOhm</param>
    /// <returns>quantity measured in MicroOhm</returns>
	public static Quantity<double, MicroOhm> ToMicroOhm<T>(this Quantity<T, ZettaOhm> val) where T:IConvertible {
        return new Quantity<double, MicroOhm>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaOhm to NanoOhm
    /// </summary>
    /// <param name="val">quantity measured in ZettaOhm</param>
    /// <returns>quantity measured in NanoOhm</returns>
	public static Quantity<double, NanoOhm> ToNanoOhm<T>(this Quantity<T, ZettaOhm> val) where T:IConvertible {
        return new Quantity<double, NanoOhm>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaOhm to PicoOhm
    /// </summary>
    /// <param name="val">quantity measured in ZettaOhm</param>
    /// <returns>quantity measured in PicoOhm</returns>
	public static Quantity<double, PicoOhm> ToPicoOhm<T>(this Quantity<T, ZettaOhm> val) where T:IConvertible {
        return new Quantity<double, PicoOhm>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaOhm to FemtoOhm
    /// </summary>
    /// <param name="val">quantity measured in ZettaOhm</param>
    /// <returns>quantity measured in FemtoOhm</returns>
	public static Quantity<double, FemtoOhm> ToFemtoOhm<T>(this Quantity<T, ZettaOhm> val) where T:IConvertible {
        return new Quantity<double, FemtoOhm>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaOhm to AttoOhm
    /// </summary>
    /// <param name="val">quantity measured in ZettaOhm</param>
    /// <returns>quantity measured in AttoOhm</returns>
	public static Quantity<double, AttoOhm> ToAttoOhm<T>(this Quantity<T, ZettaOhm> val) where T:IConvertible {
        return new Quantity<double, AttoOhm>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaOhm to ZeptoOhm
    /// </summary>
    /// <param name="val">quantity measured in ZettaOhm</param>
    /// <returns>quantity measured in ZeptoOhm</returns>
	public static Quantity<double, ZeptoOhm> ToZeptoOhm<T>(this Quantity<T, ZettaOhm> val) where T:IConvertible {
        return new Quantity<double, ZeptoOhm>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaOhm to YoctoOhm
    /// </summary>
    /// <param name="val">quantity measured in ZettaOhm</param>
    /// <returns>quantity measured in YoctoOhm</returns>
	public static Quantity<double, YoctoOhm> ToYoctoOhm<T>(this Quantity<T, ZettaOhm> val) where T:IConvertible {
        return new Quantity<double, YoctoOhm>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ExaOhm to YottaOhm
    /// </summary>
    /// <param name="val">quantity measured in ExaOhm</param>
    /// <returns>quantity measured in YottaOhm</returns>
	public static Quantity<double, YottaOhm> ToYottaOhm<T>(this Quantity<T, ExaOhm> val) where T:IConvertible {
        return new Quantity<double, YottaOhm>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaOhm to ZettaOhm
    /// </summary>
    /// <param name="val">quantity measured in ExaOhm</param>
    /// <returns>quantity measured in ZettaOhm</returns>
	public static Quantity<double, ZettaOhm> ToZettaOhm<T>(this Quantity<T, ExaOhm> val) where T:IConvertible {
        return new Quantity<double, ZettaOhm>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaOhm to PetaOhm
    /// </summary>
    /// <param name="val">quantity measured in ExaOhm</param>
    /// <returns>quantity measured in PetaOhm</returns>
	public static Quantity<double, PetaOhm> ToPetaOhm<T>(this Quantity<T, ExaOhm> val) where T:IConvertible {
        return new Quantity<double, PetaOhm>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaOhm to TeraOhm
    /// </summary>
    /// <param name="val">quantity measured in ExaOhm</param>
    /// <returns>quantity measured in TeraOhm</returns>
	public static Quantity<double, TeraOhm> ToTeraOhm<T>(this Quantity<T, ExaOhm> val) where T:IConvertible {
        return new Quantity<double, TeraOhm>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaOhm to GigaOhm
    /// </summary>
    /// <param name="val">quantity measured in ExaOhm</param>
    /// <returns>quantity measured in GigaOhm</returns>
	public static Quantity<double, GigaOhm> ToGigaOhm<T>(this Quantity<T, ExaOhm> val) where T:IConvertible {
        return new Quantity<double, GigaOhm>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaOhm to MegaOhm
    /// </summary>
    /// <param name="val">quantity measured in ExaOhm</param>
    /// <returns>quantity measured in MegaOhm</returns>
	public static Quantity<double, MegaOhm> ToMegaOhm<T>(this Quantity<T, ExaOhm> val) where T:IConvertible {
        return new Quantity<double, MegaOhm>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaOhm to KiloOhm
    /// </summary>
    /// <param name="val">quantity measured in ExaOhm</param>
    /// <returns>quantity measured in KiloOhm</returns>
	public static Quantity<double, KiloOhm> ToKiloOhm<T>(this Quantity<T, ExaOhm> val) where T:IConvertible {
        return new Quantity<double, KiloOhm>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaOhm to HectoOhm
    /// </summary>
    /// <param name="val">quantity measured in ExaOhm</param>
    /// <returns>quantity measured in HectoOhm</returns>
	public static Quantity<double, HectoOhm> ToHectoOhm<T>(this Quantity<T, ExaOhm> val) where T:IConvertible {
        return new Quantity<double, HectoOhm>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaOhm to DekaOhm
    /// </summary>
    /// <param name="val">quantity measured in ExaOhm</param>
    /// <returns>quantity measured in DekaOhm</returns>
	public static Quantity<double, DekaOhm> ToDekaOhm<T>(this Quantity<T, ExaOhm> val) where T:IConvertible {
        return new Quantity<double, DekaOhm>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaOhm to DeciOhm
    /// </summary>
    /// <param name="val">quantity measured in ExaOhm</param>
    /// <returns>quantity measured in DeciOhm</returns>
	public static Quantity<double, DeciOhm> ToDeciOhm<T>(this Quantity<T, ExaOhm> val) where T:IConvertible {
        return new Quantity<double, DeciOhm>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaOhm to CentiOhm
    /// </summary>
    /// <param name="val">quantity measured in ExaOhm</param>
    /// <returns>quantity measured in CentiOhm</returns>
	public static Quantity<double, CentiOhm> ToCentiOhm<T>(this Quantity<T, ExaOhm> val) where T:IConvertible {
        return new Quantity<double, CentiOhm>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaOhm to MilliOhm
    /// </summary>
    /// <param name="val">quantity measured in ExaOhm</param>
    /// <returns>quantity measured in MilliOhm</returns>
	public static Quantity<double, MilliOhm> ToMilliOhm<T>(this Quantity<T, ExaOhm> val) where T:IConvertible {
        return new Quantity<double, MilliOhm>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaOhm to MicroOhm
    /// </summary>
    /// <param name="val">quantity measured in ExaOhm</param>
    /// <returns>quantity measured in MicroOhm</returns>
	public static Quantity<double, MicroOhm> ToMicroOhm<T>(this Quantity<T, ExaOhm> val) where T:IConvertible {
        return new Quantity<double, MicroOhm>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaOhm to NanoOhm
    /// </summary>
    /// <param name="val">quantity measured in ExaOhm</param>
    /// <returns>quantity measured in NanoOhm</returns>
	public static Quantity<double, NanoOhm> ToNanoOhm<T>(this Quantity<T, ExaOhm> val) where T:IConvertible {
        return new Quantity<double, NanoOhm>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaOhm to PicoOhm
    /// </summary>
    /// <param name="val">quantity measured in ExaOhm</param>
    /// <returns>quantity measured in PicoOhm</returns>
	public static Quantity<double, PicoOhm> ToPicoOhm<T>(this Quantity<T, ExaOhm> val) where T:IConvertible {
        return new Quantity<double, PicoOhm>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaOhm to FemtoOhm
    /// </summary>
    /// <param name="val">quantity measured in ExaOhm</param>
    /// <returns>quantity measured in FemtoOhm</returns>
	public static Quantity<double, FemtoOhm> ToFemtoOhm<T>(this Quantity<T, ExaOhm> val) where T:IConvertible {
        return new Quantity<double, FemtoOhm>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaOhm to AttoOhm
    /// </summary>
    /// <param name="val">quantity measured in ExaOhm</param>
    /// <returns>quantity measured in AttoOhm</returns>
	public static Quantity<double, AttoOhm> ToAttoOhm<T>(this Quantity<T, ExaOhm> val) where T:IConvertible {
        return new Quantity<double, AttoOhm>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaOhm to ZeptoOhm
    /// </summary>
    /// <param name="val">quantity measured in ExaOhm</param>
    /// <returns>quantity measured in ZeptoOhm</returns>
	public static Quantity<double, ZeptoOhm> ToZeptoOhm<T>(this Quantity<T, ExaOhm> val) where T:IConvertible {
        return new Quantity<double, ZeptoOhm>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaOhm to YoctoOhm
    /// </summary>
    /// <param name="val">quantity measured in ExaOhm</param>
    /// <returns>quantity measured in YoctoOhm</returns>
	public static Quantity<double, YoctoOhm> ToYoctoOhm<T>(this Quantity<T, ExaOhm> val) where T:IConvertible {
        return new Quantity<double, YoctoOhm>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert PetaOhm to YottaOhm
    /// </summary>
    /// <param name="val">quantity measured in PetaOhm</param>
    /// <returns>quantity measured in YottaOhm</returns>
	public static Quantity<double, YottaOhm> ToYottaOhm<T>(this Quantity<T, PetaOhm> val) where T:IConvertible {
        return new Quantity<double, YottaOhm>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaOhm to ZettaOhm
    /// </summary>
    /// <param name="val">quantity measured in PetaOhm</param>
    /// <returns>quantity measured in ZettaOhm</returns>
	public static Quantity<double, ZettaOhm> ToZettaOhm<T>(this Quantity<T, PetaOhm> val) where T:IConvertible {
        return new Quantity<double, ZettaOhm>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaOhm to ExaOhm
    /// </summary>
    /// <param name="val">quantity measured in PetaOhm</param>
    /// <returns>quantity measured in ExaOhm</returns>
	public static Quantity<double, ExaOhm> ToExaOhm<T>(this Quantity<T, PetaOhm> val) where T:IConvertible {
        return new Quantity<double, ExaOhm>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaOhm to TeraOhm
    /// </summary>
    /// <param name="val">quantity measured in PetaOhm</param>
    /// <returns>quantity measured in TeraOhm</returns>
	public static Quantity<double, TeraOhm> ToTeraOhm<T>(this Quantity<T, PetaOhm> val) where T:IConvertible {
        return new Quantity<double, TeraOhm>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaOhm to GigaOhm
    /// </summary>
    /// <param name="val">quantity measured in PetaOhm</param>
    /// <returns>quantity measured in GigaOhm</returns>
	public static Quantity<double, GigaOhm> ToGigaOhm<T>(this Quantity<T, PetaOhm> val) where T:IConvertible {
        return new Quantity<double, GigaOhm>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaOhm to MegaOhm
    /// </summary>
    /// <param name="val">quantity measured in PetaOhm</param>
    /// <returns>quantity measured in MegaOhm</returns>
	public static Quantity<double, MegaOhm> ToMegaOhm<T>(this Quantity<T, PetaOhm> val) where T:IConvertible {
        return new Quantity<double, MegaOhm>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaOhm to KiloOhm
    /// </summary>
    /// <param name="val">quantity measured in PetaOhm</param>
    /// <returns>quantity measured in KiloOhm</returns>
	public static Quantity<double, KiloOhm> ToKiloOhm<T>(this Quantity<T, PetaOhm> val) where T:IConvertible {
        return new Quantity<double, KiloOhm>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaOhm to HectoOhm
    /// </summary>
    /// <param name="val">quantity measured in PetaOhm</param>
    /// <returns>quantity measured in HectoOhm</returns>
	public static Quantity<double, HectoOhm> ToHectoOhm<T>(this Quantity<T, PetaOhm> val) where T:IConvertible {
        return new Quantity<double, HectoOhm>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaOhm to DekaOhm
    /// </summary>
    /// <param name="val">quantity measured in PetaOhm</param>
    /// <returns>quantity measured in DekaOhm</returns>
	public static Quantity<double, DekaOhm> ToDekaOhm<T>(this Quantity<T, PetaOhm> val) where T:IConvertible {
        return new Quantity<double, DekaOhm>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaOhm to DeciOhm
    /// </summary>
    /// <param name="val">quantity measured in PetaOhm</param>
    /// <returns>quantity measured in DeciOhm</returns>
	public static Quantity<double, DeciOhm> ToDeciOhm<T>(this Quantity<T, PetaOhm> val) where T:IConvertible {
        return new Quantity<double, DeciOhm>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaOhm to CentiOhm
    /// </summary>
    /// <param name="val">quantity measured in PetaOhm</param>
    /// <returns>quantity measured in CentiOhm</returns>
	public static Quantity<double, CentiOhm> ToCentiOhm<T>(this Quantity<T, PetaOhm> val) where T:IConvertible {
        return new Quantity<double, CentiOhm>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaOhm to MilliOhm
    /// </summary>
    /// <param name="val">quantity measured in PetaOhm</param>
    /// <returns>quantity measured in MilliOhm</returns>
	public static Quantity<double, MilliOhm> ToMilliOhm<T>(this Quantity<T, PetaOhm> val) where T:IConvertible {
        return new Quantity<double, MilliOhm>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaOhm to MicroOhm
    /// </summary>
    /// <param name="val">quantity measured in PetaOhm</param>
    /// <returns>quantity measured in MicroOhm</returns>
	public static Quantity<double, MicroOhm> ToMicroOhm<T>(this Quantity<T, PetaOhm> val) where T:IConvertible {
        return new Quantity<double, MicroOhm>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaOhm to NanoOhm
    /// </summary>
    /// <param name="val">quantity measured in PetaOhm</param>
    /// <returns>quantity measured in NanoOhm</returns>
	public static Quantity<double, NanoOhm> ToNanoOhm<T>(this Quantity<T, PetaOhm> val) where T:IConvertible {
        return new Quantity<double, NanoOhm>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaOhm to PicoOhm
    /// </summary>
    /// <param name="val">quantity measured in PetaOhm</param>
    /// <returns>quantity measured in PicoOhm</returns>
	public static Quantity<double, PicoOhm> ToPicoOhm<T>(this Quantity<T, PetaOhm> val) where T:IConvertible {
        return new Quantity<double, PicoOhm>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaOhm to FemtoOhm
    /// </summary>
    /// <param name="val">quantity measured in PetaOhm</param>
    /// <returns>quantity measured in FemtoOhm</returns>
	public static Quantity<double, FemtoOhm> ToFemtoOhm<T>(this Quantity<T, PetaOhm> val) where T:IConvertible {
        return new Quantity<double, FemtoOhm>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaOhm to AttoOhm
    /// </summary>
    /// <param name="val">quantity measured in PetaOhm</param>
    /// <returns>quantity measured in AttoOhm</returns>
	public static Quantity<double, AttoOhm> ToAttoOhm<T>(this Quantity<T, PetaOhm> val) where T:IConvertible {
        return new Quantity<double, AttoOhm>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaOhm to ZeptoOhm
    /// </summary>
    /// <param name="val">quantity measured in PetaOhm</param>
    /// <returns>quantity measured in ZeptoOhm</returns>
	public static Quantity<double, ZeptoOhm> ToZeptoOhm<T>(this Quantity<T, PetaOhm> val) where T:IConvertible {
        return new Quantity<double, ZeptoOhm>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaOhm to YoctoOhm
    /// </summary>
    /// <param name="val">quantity measured in PetaOhm</param>
    /// <returns>quantity measured in YoctoOhm</returns>
	public static Quantity<double, YoctoOhm> ToYoctoOhm<T>(this Quantity<T, PetaOhm> val) where T:IConvertible {
        return new Quantity<double, YoctoOhm>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert TeraOhm to YottaOhm
    /// </summary>
    /// <param name="val">quantity measured in TeraOhm</param>
    /// <returns>quantity measured in YottaOhm</returns>
	public static Quantity<double, YottaOhm> ToYottaOhm<T>(this Quantity<T, TeraOhm> val) where T:IConvertible {
        return new Quantity<double, YottaOhm>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraOhm to ZettaOhm
    /// </summary>
    /// <param name="val">quantity measured in TeraOhm</param>
    /// <returns>quantity measured in ZettaOhm</returns>
	public static Quantity<double, ZettaOhm> ToZettaOhm<T>(this Quantity<T, TeraOhm> val) where T:IConvertible {
        return new Quantity<double, ZettaOhm>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraOhm to ExaOhm
    /// </summary>
    /// <param name="val">quantity measured in TeraOhm</param>
    /// <returns>quantity measured in ExaOhm</returns>
	public static Quantity<double, ExaOhm> ToExaOhm<T>(this Quantity<T, TeraOhm> val) where T:IConvertible {
        return new Quantity<double, ExaOhm>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraOhm to PetaOhm
    /// </summary>
    /// <param name="val">quantity measured in TeraOhm</param>
    /// <returns>quantity measured in PetaOhm</returns>
	public static Quantity<double, PetaOhm> ToPetaOhm<T>(this Quantity<T, TeraOhm> val) where T:IConvertible {
        return new Quantity<double, PetaOhm>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraOhm to GigaOhm
    /// </summary>
    /// <param name="val">quantity measured in TeraOhm</param>
    /// <returns>quantity measured in GigaOhm</returns>
	public static Quantity<double, GigaOhm> ToGigaOhm<T>(this Quantity<T, TeraOhm> val) where T:IConvertible {
        return new Quantity<double, GigaOhm>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraOhm to MegaOhm
    /// </summary>
    /// <param name="val">quantity measured in TeraOhm</param>
    /// <returns>quantity measured in MegaOhm</returns>
	public static Quantity<double, MegaOhm> ToMegaOhm<T>(this Quantity<T, TeraOhm> val) where T:IConvertible {
        return new Quantity<double, MegaOhm>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraOhm to KiloOhm
    /// </summary>
    /// <param name="val">quantity measured in TeraOhm</param>
    /// <returns>quantity measured in KiloOhm</returns>
	public static Quantity<double, KiloOhm> ToKiloOhm<T>(this Quantity<T, TeraOhm> val) where T:IConvertible {
        return new Quantity<double, KiloOhm>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraOhm to HectoOhm
    /// </summary>
    /// <param name="val">quantity measured in TeraOhm</param>
    /// <returns>quantity measured in HectoOhm</returns>
	public static Quantity<double, HectoOhm> ToHectoOhm<T>(this Quantity<T, TeraOhm> val) where T:IConvertible {
        return new Quantity<double, HectoOhm>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraOhm to DekaOhm
    /// </summary>
    /// <param name="val">quantity measured in TeraOhm</param>
    /// <returns>quantity measured in DekaOhm</returns>
	public static Quantity<double, DekaOhm> ToDekaOhm<T>(this Quantity<T, TeraOhm> val) where T:IConvertible {
        return new Quantity<double, DekaOhm>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraOhm to DeciOhm
    /// </summary>
    /// <param name="val">quantity measured in TeraOhm</param>
    /// <returns>quantity measured in DeciOhm</returns>
	public static Quantity<double, DeciOhm> ToDeciOhm<T>(this Quantity<T, TeraOhm> val) where T:IConvertible {
        return new Quantity<double, DeciOhm>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraOhm to CentiOhm
    /// </summary>
    /// <param name="val">quantity measured in TeraOhm</param>
    /// <returns>quantity measured in CentiOhm</returns>
	public static Quantity<double, CentiOhm> ToCentiOhm<T>(this Quantity<T, TeraOhm> val) where T:IConvertible {
        return new Quantity<double, CentiOhm>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraOhm to MilliOhm
    /// </summary>
    /// <param name="val">quantity measured in TeraOhm</param>
    /// <returns>quantity measured in MilliOhm</returns>
	public static Quantity<double, MilliOhm> ToMilliOhm<T>(this Quantity<T, TeraOhm> val) where T:IConvertible {
        return new Quantity<double, MilliOhm>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraOhm to MicroOhm
    /// </summary>
    /// <param name="val">quantity measured in TeraOhm</param>
    /// <returns>quantity measured in MicroOhm</returns>
	public static Quantity<double, MicroOhm> ToMicroOhm<T>(this Quantity<T, TeraOhm> val) where T:IConvertible {
        return new Quantity<double, MicroOhm>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraOhm to NanoOhm
    /// </summary>
    /// <param name="val">quantity measured in TeraOhm</param>
    /// <returns>quantity measured in NanoOhm</returns>
	public static Quantity<double, NanoOhm> ToNanoOhm<T>(this Quantity<T, TeraOhm> val) where T:IConvertible {
        return new Quantity<double, NanoOhm>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraOhm to PicoOhm
    /// </summary>
    /// <param name="val">quantity measured in TeraOhm</param>
    /// <returns>quantity measured in PicoOhm</returns>
	public static Quantity<double, PicoOhm> ToPicoOhm<T>(this Quantity<T, TeraOhm> val) where T:IConvertible {
        return new Quantity<double, PicoOhm>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraOhm to FemtoOhm
    /// </summary>
    /// <param name="val">quantity measured in TeraOhm</param>
    /// <returns>quantity measured in FemtoOhm</returns>
	public static Quantity<double, FemtoOhm> ToFemtoOhm<T>(this Quantity<T, TeraOhm> val) where T:IConvertible {
        return new Quantity<double, FemtoOhm>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraOhm to AttoOhm
    /// </summary>
    /// <param name="val">quantity measured in TeraOhm</param>
    /// <returns>quantity measured in AttoOhm</returns>
	public static Quantity<double, AttoOhm> ToAttoOhm<T>(this Quantity<T, TeraOhm> val) where T:IConvertible {
        return new Quantity<double, AttoOhm>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraOhm to ZeptoOhm
    /// </summary>
    /// <param name="val">quantity measured in TeraOhm</param>
    /// <returns>quantity measured in ZeptoOhm</returns>
	public static Quantity<double, ZeptoOhm> ToZeptoOhm<T>(this Quantity<T, TeraOhm> val) where T:IConvertible {
        return new Quantity<double, ZeptoOhm>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraOhm to YoctoOhm
    /// </summary>
    /// <param name="val">quantity measured in TeraOhm</param>
    /// <returns>quantity measured in YoctoOhm</returns>
	public static Quantity<double, YoctoOhm> ToYoctoOhm<T>(this Quantity<T, TeraOhm> val) where T:IConvertible {
        return new Quantity<double, YoctoOhm>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert GigaOhm to YottaOhm
    /// </summary>
    /// <param name="val">quantity measured in GigaOhm</param>
    /// <returns>quantity measured in YottaOhm</returns>
	public static Quantity<double, YottaOhm> ToYottaOhm<T>(this Quantity<T, GigaOhm> val) where T:IConvertible {
        return new Quantity<double, YottaOhm>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaOhm to ZettaOhm
    /// </summary>
    /// <param name="val">quantity measured in GigaOhm</param>
    /// <returns>quantity measured in ZettaOhm</returns>
	public static Quantity<double, ZettaOhm> ToZettaOhm<T>(this Quantity<T, GigaOhm> val) where T:IConvertible {
        return new Quantity<double, ZettaOhm>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaOhm to ExaOhm
    /// </summary>
    /// <param name="val">quantity measured in GigaOhm</param>
    /// <returns>quantity measured in ExaOhm</returns>
	public static Quantity<double, ExaOhm> ToExaOhm<T>(this Quantity<T, GigaOhm> val) where T:IConvertible {
        return new Quantity<double, ExaOhm>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaOhm to PetaOhm
    /// </summary>
    /// <param name="val">quantity measured in GigaOhm</param>
    /// <returns>quantity measured in PetaOhm</returns>
	public static Quantity<double, PetaOhm> ToPetaOhm<T>(this Quantity<T, GigaOhm> val) where T:IConvertible {
        return new Quantity<double, PetaOhm>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaOhm to TeraOhm
    /// </summary>
    /// <param name="val">quantity measured in GigaOhm</param>
    /// <returns>quantity measured in TeraOhm</returns>
	public static Quantity<double, TeraOhm> ToTeraOhm<T>(this Quantity<T, GigaOhm> val) where T:IConvertible {
        return new Quantity<double, TeraOhm>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaOhm to MegaOhm
    /// </summary>
    /// <param name="val">quantity measured in GigaOhm</param>
    /// <returns>quantity measured in MegaOhm</returns>
	public static Quantity<double, MegaOhm> ToMegaOhm<T>(this Quantity<T, GigaOhm> val) where T:IConvertible {
        return new Quantity<double, MegaOhm>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaOhm to KiloOhm
    /// </summary>
    /// <param name="val">quantity measured in GigaOhm</param>
    /// <returns>quantity measured in KiloOhm</returns>
	public static Quantity<double, KiloOhm> ToKiloOhm<T>(this Quantity<T, GigaOhm> val) where T:IConvertible {
        return new Quantity<double, KiloOhm>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaOhm to HectoOhm
    /// </summary>
    /// <param name="val">quantity measured in GigaOhm</param>
    /// <returns>quantity measured in HectoOhm</returns>
	public static Quantity<double, HectoOhm> ToHectoOhm<T>(this Quantity<T, GigaOhm> val) where T:IConvertible {
        return new Quantity<double, HectoOhm>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaOhm to DekaOhm
    /// </summary>
    /// <param name="val">quantity measured in GigaOhm</param>
    /// <returns>quantity measured in DekaOhm</returns>
	public static Quantity<double, DekaOhm> ToDekaOhm<T>(this Quantity<T, GigaOhm> val) where T:IConvertible {
        return new Quantity<double, DekaOhm>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaOhm to DeciOhm
    /// </summary>
    /// <param name="val">quantity measured in GigaOhm</param>
    /// <returns>quantity measured in DeciOhm</returns>
	public static Quantity<double, DeciOhm> ToDeciOhm<T>(this Quantity<T, GigaOhm> val) where T:IConvertible {
        return new Quantity<double, DeciOhm>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaOhm to CentiOhm
    /// </summary>
    /// <param name="val">quantity measured in GigaOhm</param>
    /// <returns>quantity measured in CentiOhm</returns>
	public static Quantity<double, CentiOhm> ToCentiOhm<T>(this Quantity<T, GigaOhm> val) where T:IConvertible {
        return new Quantity<double, CentiOhm>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaOhm to MilliOhm
    /// </summary>
    /// <param name="val">quantity measured in GigaOhm</param>
    /// <returns>quantity measured in MilliOhm</returns>
	public static Quantity<double, MilliOhm> ToMilliOhm<T>(this Quantity<T, GigaOhm> val) where T:IConvertible {
        return new Quantity<double, MilliOhm>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaOhm to MicroOhm
    /// </summary>
    /// <param name="val">quantity measured in GigaOhm</param>
    /// <returns>quantity measured in MicroOhm</returns>
	public static Quantity<double, MicroOhm> ToMicroOhm<T>(this Quantity<T, GigaOhm> val) where T:IConvertible {
        return new Quantity<double, MicroOhm>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaOhm to NanoOhm
    /// </summary>
    /// <param name="val">quantity measured in GigaOhm</param>
    /// <returns>quantity measured in NanoOhm</returns>
	public static Quantity<double, NanoOhm> ToNanoOhm<T>(this Quantity<T, GigaOhm> val) where T:IConvertible {
        return new Quantity<double, NanoOhm>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaOhm to PicoOhm
    /// </summary>
    /// <param name="val">quantity measured in GigaOhm</param>
    /// <returns>quantity measured in PicoOhm</returns>
	public static Quantity<double, PicoOhm> ToPicoOhm<T>(this Quantity<T, GigaOhm> val) where T:IConvertible {
        return new Quantity<double, PicoOhm>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaOhm to FemtoOhm
    /// </summary>
    /// <param name="val">quantity measured in GigaOhm</param>
    /// <returns>quantity measured in FemtoOhm</returns>
	public static Quantity<double, FemtoOhm> ToFemtoOhm<T>(this Quantity<T, GigaOhm> val) where T:IConvertible {
        return new Quantity<double, FemtoOhm>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaOhm to AttoOhm
    /// </summary>
    /// <param name="val">quantity measured in GigaOhm</param>
    /// <returns>quantity measured in AttoOhm</returns>
	public static Quantity<double, AttoOhm> ToAttoOhm<T>(this Quantity<T, GigaOhm> val) where T:IConvertible {
        return new Quantity<double, AttoOhm>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaOhm to ZeptoOhm
    /// </summary>
    /// <param name="val">quantity measured in GigaOhm</param>
    /// <returns>quantity measured in ZeptoOhm</returns>
	public static Quantity<double, ZeptoOhm> ToZeptoOhm<T>(this Quantity<T, GigaOhm> val) where T:IConvertible {
        return new Quantity<double, ZeptoOhm>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaOhm to YoctoOhm
    /// </summary>
    /// <param name="val">quantity measured in GigaOhm</param>
    /// <returns>quantity measured in YoctoOhm</returns>
	public static Quantity<double, YoctoOhm> ToYoctoOhm<T>(this Quantity<T, GigaOhm> val) where T:IConvertible {
        return new Quantity<double, YoctoOhm>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert MegaOhm to YottaOhm
    /// </summary>
    /// <param name="val">quantity measured in MegaOhm</param>
    /// <returns>quantity measured in YottaOhm</returns>
	public static Quantity<double, YottaOhm> ToYottaOhm<T>(this Quantity<T, MegaOhm> val) where T:IConvertible {
        return new Quantity<double, YottaOhm>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaOhm to ZettaOhm
    /// </summary>
    /// <param name="val">quantity measured in MegaOhm</param>
    /// <returns>quantity measured in ZettaOhm</returns>
	public static Quantity<double, ZettaOhm> ToZettaOhm<T>(this Quantity<T, MegaOhm> val) where T:IConvertible {
        return new Quantity<double, ZettaOhm>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaOhm to ExaOhm
    /// </summary>
    /// <param name="val">quantity measured in MegaOhm</param>
    /// <returns>quantity measured in ExaOhm</returns>
	public static Quantity<double, ExaOhm> ToExaOhm<T>(this Quantity<T, MegaOhm> val) where T:IConvertible {
        return new Quantity<double, ExaOhm>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaOhm to PetaOhm
    /// </summary>
    /// <param name="val">quantity measured in MegaOhm</param>
    /// <returns>quantity measured in PetaOhm</returns>
	public static Quantity<double, PetaOhm> ToPetaOhm<T>(this Quantity<T, MegaOhm> val) where T:IConvertible {
        return new Quantity<double, PetaOhm>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaOhm to TeraOhm
    /// </summary>
    /// <param name="val">quantity measured in MegaOhm</param>
    /// <returns>quantity measured in TeraOhm</returns>
	public static Quantity<double, TeraOhm> ToTeraOhm<T>(this Quantity<T, MegaOhm> val) where T:IConvertible {
        return new Quantity<double, TeraOhm>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaOhm to GigaOhm
    /// </summary>
    /// <param name="val">quantity measured in MegaOhm</param>
    /// <returns>quantity measured in GigaOhm</returns>
	public static Quantity<double, GigaOhm> ToGigaOhm<T>(this Quantity<T, MegaOhm> val) where T:IConvertible {
        return new Quantity<double, GigaOhm>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaOhm to KiloOhm
    /// </summary>
    /// <param name="val">quantity measured in MegaOhm</param>
    /// <returns>quantity measured in KiloOhm</returns>
	public static Quantity<double, KiloOhm> ToKiloOhm<T>(this Quantity<T, MegaOhm> val) where T:IConvertible {
        return new Quantity<double, KiloOhm>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaOhm to HectoOhm
    /// </summary>
    /// <param name="val">quantity measured in MegaOhm</param>
    /// <returns>quantity measured in HectoOhm</returns>
	public static Quantity<double, HectoOhm> ToHectoOhm<T>(this Quantity<T, MegaOhm> val) where T:IConvertible {
        return new Quantity<double, HectoOhm>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaOhm to DekaOhm
    /// </summary>
    /// <param name="val">quantity measured in MegaOhm</param>
    /// <returns>quantity measured in DekaOhm</returns>
	public static Quantity<double, DekaOhm> ToDekaOhm<T>(this Quantity<T, MegaOhm> val) where T:IConvertible {
        return new Quantity<double, DekaOhm>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaOhm to DeciOhm
    /// </summary>
    /// <param name="val">quantity measured in MegaOhm</param>
    /// <returns>quantity measured in DeciOhm</returns>
	public static Quantity<double, DeciOhm> ToDeciOhm<T>(this Quantity<T, MegaOhm> val) where T:IConvertible {
        return new Quantity<double, DeciOhm>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaOhm to CentiOhm
    /// </summary>
    /// <param name="val">quantity measured in MegaOhm</param>
    /// <returns>quantity measured in CentiOhm</returns>
	public static Quantity<double, CentiOhm> ToCentiOhm<T>(this Quantity<T, MegaOhm> val) where T:IConvertible {
        return new Quantity<double, CentiOhm>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaOhm to MilliOhm
    /// </summary>
    /// <param name="val">quantity measured in MegaOhm</param>
    /// <returns>quantity measured in MilliOhm</returns>
	public static Quantity<double, MilliOhm> ToMilliOhm<T>(this Quantity<T, MegaOhm> val) where T:IConvertible {
        return new Quantity<double, MilliOhm>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaOhm to MicroOhm
    /// </summary>
    /// <param name="val">quantity measured in MegaOhm</param>
    /// <returns>quantity measured in MicroOhm</returns>
	public static Quantity<double, MicroOhm> ToMicroOhm<T>(this Quantity<T, MegaOhm> val) where T:IConvertible {
        return new Quantity<double, MicroOhm>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaOhm to NanoOhm
    /// </summary>
    /// <param name="val">quantity measured in MegaOhm</param>
    /// <returns>quantity measured in NanoOhm</returns>
	public static Quantity<double, NanoOhm> ToNanoOhm<T>(this Quantity<T, MegaOhm> val) where T:IConvertible {
        return new Quantity<double, NanoOhm>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaOhm to PicoOhm
    /// </summary>
    /// <param name="val">quantity measured in MegaOhm</param>
    /// <returns>quantity measured in PicoOhm</returns>
	public static Quantity<double, PicoOhm> ToPicoOhm<T>(this Quantity<T, MegaOhm> val) where T:IConvertible {
        return new Quantity<double, PicoOhm>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaOhm to FemtoOhm
    /// </summary>
    /// <param name="val">quantity measured in MegaOhm</param>
    /// <returns>quantity measured in FemtoOhm</returns>
	public static Quantity<double, FemtoOhm> ToFemtoOhm<T>(this Quantity<T, MegaOhm> val) where T:IConvertible {
        return new Quantity<double, FemtoOhm>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaOhm to AttoOhm
    /// </summary>
    /// <param name="val">quantity measured in MegaOhm</param>
    /// <returns>quantity measured in AttoOhm</returns>
	public static Quantity<double, AttoOhm> ToAttoOhm<T>(this Quantity<T, MegaOhm> val) where T:IConvertible {
        return new Quantity<double, AttoOhm>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaOhm to ZeptoOhm
    /// </summary>
    /// <param name="val">quantity measured in MegaOhm</param>
    /// <returns>quantity measured in ZeptoOhm</returns>
	public static Quantity<double, ZeptoOhm> ToZeptoOhm<T>(this Quantity<T, MegaOhm> val) where T:IConvertible {
        return new Quantity<double, ZeptoOhm>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaOhm to YoctoOhm
    /// </summary>
    /// <param name="val">quantity measured in MegaOhm</param>
    /// <returns>quantity measured in YoctoOhm</returns>
	public static Quantity<double, YoctoOhm> ToYoctoOhm<T>(this Quantity<T, MegaOhm> val) where T:IConvertible {
        return new Quantity<double, YoctoOhm>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert KiloOhm to YottaOhm
    /// </summary>
    /// <param name="val">quantity measured in KiloOhm</param>
    /// <returns>quantity measured in YottaOhm</returns>
	public static Quantity<double, YottaOhm> ToYottaOhm<T>(this Quantity<T, KiloOhm> val) where T:IConvertible {
        return new Quantity<double, YottaOhm>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloOhm to ZettaOhm
    /// </summary>
    /// <param name="val">quantity measured in KiloOhm</param>
    /// <returns>quantity measured in ZettaOhm</returns>
	public static Quantity<double, ZettaOhm> ToZettaOhm<T>(this Quantity<T, KiloOhm> val) where T:IConvertible {
        return new Quantity<double, ZettaOhm>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloOhm to ExaOhm
    /// </summary>
    /// <param name="val">quantity measured in KiloOhm</param>
    /// <returns>quantity measured in ExaOhm</returns>
	public static Quantity<double, ExaOhm> ToExaOhm<T>(this Quantity<T, KiloOhm> val) where T:IConvertible {
        return new Quantity<double, ExaOhm>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloOhm to PetaOhm
    /// </summary>
    /// <param name="val">quantity measured in KiloOhm</param>
    /// <returns>quantity measured in PetaOhm</returns>
	public static Quantity<double, PetaOhm> ToPetaOhm<T>(this Quantity<T, KiloOhm> val) where T:IConvertible {
        return new Quantity<double, PetaOhm>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloOhm to TeraOhm
    /// </summary>
    /// <param name="val">quantity measured in KiloOhm</param>
    /// <returns>quantity measured in TeraOhm</returns>
	public static Quantity<double, TeraOhm> ToTeraOhm<T>(this Quantity<T, KiloOhm> val) where T:IConvertible {
        return new Quantity<double, TeraOhm>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloOhm to GigaOhm
    /// </summary>
    /// <param name="val">quantity measured in KiloOhm</param>
    /// <returns>quantity measured in GigaOhm</returns>
	public static Quantity<double, GigaOhm> ToGigaOhm<T>(this Quantity<T, KiloOhm> val) where T:IConvertible {
        return new Quantity<double, GigaOhm>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloOhm to MegaOhm
    /// </summary>
    /// <param name="val">quantity measured in KiloOhm</param>
    /// <returns>quantity measured in MegaOhm</returns>
	public static Quantity<double, MegaOhm> ToMegaOhm<T>(this Quantity<T, KiloOhm> val) where T:IConvertible {
        return new Quantity<double, MegaOhm>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloOhm to HectoOhm
    /// </summary>
    /// <param name="val">quantity measured in KiloOhm</param>
    /// <returns>quantity measured in HectoOhm</returns>
	public static Quantity<double, HectoOhm> ToHectoOhm<T>(this Quantity<T, KiloOhm> val) where T:IConvertible {
        return new Quantity<double, HectoOhm>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloOhm to DekaOhm
    /// </summary>
    /// <param name="val">quantity measured in KiloOhm</param>
    /// <returns>quantity measured in DekaOhm</returns>
	public static Quantity<double, DekaOhm> ToDekaOhm<T>(this Quantity<T, KiloOhm> val) where T:IConvertible {
        return new Quantity<double, DekaOhm>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloOhm to DeciOhm
    /// </summary>
    /// <param name="val">quantity measured in KiloOhm</param>
    /// <returns>quantity measured in DeciOhm</returns>
	public static Quantity<double, DeciOhm> ToDeciOhm<T>(this Quantity<T, KiloOhm> val) where T:IConvertible {
        return new Quantity<double, DeciOhm>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloOhm to CentiOhm
    /// </summary>
    /// <param name="val">quantity measured in KiloOhm</param>
    /// <returns>quantity measured in CentiOhm</returns>
	public static Quantity<double, CentiOhm> ToCentiOhm<T>(this Quantity<T, KiloOhm> val) where T:IConvertible {
        return new Quantity<double, CentiOhm>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloOhm to MilliOhm
    /// </summary>
    /// <param name="val">quantity measured in KiloOhm</param>
    /// <returns>quantity measured in MilliOhm</returns>
	public static Quantity<double, MilliOhm> ToMilliOhm<T>(this Quantity<T, KiloOhm> val) where T:IConvertible {
        return new Quantity<double, MilliOhm>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloOhm to MicroOhm
    /// </summary>
    /// <param name="val">quantity measured in KiloOhm</param>
    /// <returns>quantity measured in MicroOhm</returns>
	public static Quantity<double, MicroOhm> ToMicroOhm<T>(this Quantity<T, KiloOhm> val) where T:IConvertible {
        return new Quantity<double, MicroOhm>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloOhm to NanoOhm
    /// </summary>
    /// <param name="val">quantity measured in KiloOhm</param>
    /// <returns>quantity measured in NanoOhm</returns>
	public static Quantity<double, NanoOhm> ToNanoOhm<T>(this Quantity<T, KiloOhm> val) where T:IConvertible {
        return new Quantity<double, NanoOhm>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloOhm to PicoOhm
    /// </summary>
    /// <param name="val">quantity measured in KiloOhm</param>
    /// <returns>quantity measured in PicoOhm</returns>
	public static Quantity<double, PicoOhm> ToPicoOhm<T>(this Quantity<T, KiloOhm> val) where T:IConvertible {
        return new Quantity<double, PicoOhm>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloOhm to FemtoOhm
    /// </summary>
    /// <param name="val">quantity measured in KiloOhm</param>
    /// <returns>quantity measured in FemtoOhm</returns>
	public static Quantity<double, FemtoOhm> ToFemtoOhm<T>(this Quantity<T, KiloOhm> val) where T:IConvertible {
        return new Quantity<double, FemtoOhm>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloOhm to AttoOhm
    /// </summary>
    /// <param name="val">quantity measured in KiloOhm</param>
    /// <returns>quantity measured in AttoOhm</returns>
	public static Quantity<double, AttoOhm> ToAttoOhm<T>(this Quantity<T, KiloOhm> val) where T:IConvertible {
        return new Quantity<double, AttoOhm>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloOhm to ZeptoOhm
    /// </summary>
    /// <param name="val">quantity measured in KiloOhm</param>
    /// <returns>quantity measured in ZeptoOhm</returns>
	public static Quantity<double, ZeptoOhm> ToZeptoOhm<T>(this Quantity<T, KiloOhm> val) where T:IConvertible {
        return new Quantity<double, ZeptoOhm>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloOhm to YoctoOhm
    /// </summary>
    /// <param name="val">quantity measured in KiloOhm</param>
    /// <returns>quantity measured in YoctoOhm</returns>
	public static Quantity<double, YoctoOhm> ToYoctoOhm<T>(this Quantity<T, KiloOhm> val) where T:IConvertible {
        return new Quantity<double, YoctoOhm>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert HectoOhm to YottaOhm
    /// </summary>
    /// <param name="val">quantity measured in HectoOhm</param>
    /// <returns>quantity measured in YottaOhm</returns>
	public static Quantity<double, YottaOhm> ToYottaOhm<T>(this Quantity<T, HectoOhm> val) where T:IConvertible {
        return new Quantity<double, YottaOhm>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoOhm to ZettaOhm
    /// </summary>
    /// <param name="val">quantity measured in HectoOhm</param>
    /// <returns>quantity measured in ZettaOhm</returns>
	public static Quantity<double, ZettaOhm> ToZettaOhm<T>(this Quantity<T, HectoOhm> val) where T:IConvertible {
        return new Quantity<double, ZettaOhm>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoOhm to ExaOhm
    /// </summary>
    /// <param name="val">quantity measured in HectoOhm</param>
    /// <returns>quantity measured in ExaOhm</returns>
	public static Quantity<double, ExaOhm> ToExaOhm<T>(this Quantity<T, HectoOhm> val) where T:IConvertible {
        return new Quantity<double, ExaOhm>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoOhm to PetaOhm
    /// </summary>
    /// <param name="val">quantity measured in HectoOhm</param>
    /// <returns>quantity measured in PetaOhm</returns>
	public static Quantity<double, PetaOhm> ToPetaOhm<T>(this Quantity<T, HectoOhm> val) where T:IConvertible {
        return new Quantity<double, PetaOhm>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoOhm to TeraOhm
    /// </summary>
    /// <param name="val">quantity measured in HectoOhm</param>
    /// <returns>quantity measured in TeraOhm</returns>
	public static Quantity<double, TeraOhm> ToTeraOhm<T>(this Quantity<T, HectoOhm> val) where T:IConvertible {
        return new Quantity<double, TeraOhm>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoOhm to GigaOhm
    /// </summary>
    /// <param name="val">quantity measured in HectoOhm</param>
    /// <returns>quantity measured in GigaOhm</returns>
	public static Quantity<double, GigaOhm> ToGigaOhm<T>(this Quantity<T, HectoOhm> val) where T:IConvertible {
        return new Quantity<double, GigaOhm>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoOhm to MegaOhm
    /// </summary>
    /// <param name="val">quantity measured in HectoOhm</param>
    /// <returns>quantity measured in MegaOhm</returns>
	public static Quantity<double, MegaOhm> ToMegaOhm<T>(this Quantity<T, HectoOhm> val) where T:IConvertible {
        return new Quantity<double, MegaOhm>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoOhm to KiloOhm
    /// </summary>
    /// <param name="val">quantity measured in HectoOhm</param>
    /// <returns>quantity measured in KiloOhm</returns>
	public static Quantity<double, KiloOhm> ToKiloOhm<T>(this Quantity<T, HectoOhm> val) where T:IConvertible {
        return new Quantity<double, KiloOhm>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoOhm to DekaOhm
    /// </summary>
    /// <param name="val">quantity measured in HectoOhm</param>
    /// <returns>quantity measured in DekaOhm</returns>
	public static Quantity<double, DekaOhm> ToDekaOhm<T>(this Quantity<T, HectoOhm> val) where T:IConvertible {
        return new Quantity<double, DekaOhm>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoOhm to DeciOhm
    /// </summary>
    /// <param name="val">quantity measured in HectoOhm</param>
    /// <returns>quantity measured in DeciOhm</returns>
	public static Quantity<double, DeciOhm> ToDeciOhm<T>(this Quantity<T, HectoOhm> val) where T:IConvertible {
        return new Quantity<double, DeciOhm>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoOhm to CentiOhm
    /// </summary>
    /// <param name="val">quantity measured in HectoOhm</param>
    /// <returns>quantity measured in CentiOhm</returns>
	public static Quantity<double, CentiOhm> ToCentiOhm<T>(this Quantity<T, HectoOhm> val) where T:IConvertible {
        return new Quantity<double, CentiOhm>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoOhm to MilliOhm
    /// </summary>
    /// <param name="val">quantity measured in HectoOhm</param>
    /// <returns>quantity measured in MilliOhm</returns>
	public static Quantity<double, MilliOhm> ToMilliOhm<T>(this Quantity<T, HectoOhm> val) where T:IConvertible {
        return new Quantity<double, MilliOhm>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoOhm to MicroOhm
    /// </summary>
    /// <param name="val">quantity measured in HectoOhm</param>
    /// <returns>quantity measured in MicroOhm</returns>
	public static Quantity<double, MicroOhm> ToMicroOhm<T>(this Quantity<T, HectoOhm> val) where T:IConvertible {
        return new Quantity<double, MicroOhm>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoOhm to NanoOhm
    /// </summary>
    /// <param name="val">quantity measured in HectoOhm</param>
    /// <returns>quantity measured in NanoOhm</returns>
	public static Quantity<double, NanoOhm> ToNanoOhm<T>(this Quantity<T, HectoOhm> val) where T:IConvertible {
        return new Quantity<double, NanoOhm>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoOhm to PicoOhm
    /// </summary>
    /// <param name="val">quantity measured in HectoOhm</param>
    /// <returns>quantity measured in PicoOhm</returns>
	public static Quantity<double, PicoOhm> ToPicoOhm<T>(this Quantity<T, HectoOhm> val) where T:IConvertible {
        return new Quantity<double, PicoOhm>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoOhm to FemtoOhm
    /// </summary>
    /// <param name="val">quantity measured in HectoOhm</param>
    /// <returns>quantity measured in FemtoOhm</returns>
	public static Quantity<double, FemtoOhm> ToFemtoOhm<T>(this Quantity<T, HectoOhm> val) where T:IConvertible {
        return new Quantity<double, FemtoOhm>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoOhm to AttoOhm
    /// </summary>
    /// <param name="val">quantity measured in HectoOhm</param>
    /// <returns>quantity measured in AttoOhm</returns>
	public static Quantity<double, AttoOhm> ToAttoOhm<T>(this Quantity<T, HectoOhm> val) where T:IConvertible {
        return new Quantity<double, AttoOhm>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoOhm to ZeptoOhm
    /// </summary>
    /// <param name="val">quantity measured in HectoOhm</param>
    /// <returns>quantity measured in ZeptoOhm</returns>
	public static Quantity<double, ZeptoOhm> ToZeptoOhm<T>(this Quantity<T, HectoOhm> val) where T:IConvertible {
        return new Quantity<double, ZeptoOhm>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoOhm to YoctoOhm
    /// </summary>
    /// <param name="val">quantity measured in HectoOhm</param>
    /// <returns>quantity measured in YoctoOhm</returns>
	public static Quantity<double, YoctoOhm> ToYoctoOhm<T>(this Quantity<T, HectoOhm> val) where T:IConvertible {
        return new Quantity<double, YoctoOhm>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert DekaOhm to YottaOhm
    /// </summary>
    /// <param name="val">quantity measured in DekaOhm</param>
    /// <returns>quantity measured in YottaOhm</returns>
	public static Quantity<double, YottaOhm> ToYottaOhm<T>(this Quantity<T, DekaOhm> val) where T:IConvertible {
        return new Quantity<double, YottaOhm>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaOhm to ZettaOhm
    /// </summary>
    /// <param name="val">quantity measured in DekaOhm</param>
    /// <returns>quantity measured in ZettaOhm</returns>
	public static Quantity<double, ZettaOhm> ToZettaOhm<T>(this Quantity<T, DekaOhm> val) where T:IConvertible {
        return new Quantity<double, ZettaOhm>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaOhm to ExaOhm
    /// </summary>
    /// <param name="val">quantity measured in DekaOhm</param>
    /// <returns>quantity measured in ExaOhm</returns>
	public static Quantity<double, ExaOhm> ToExaOhm<T>(this Quantity<T, DekaOhm> val) where T:IConvertible {
        return new Quantity<double, ExaOhm>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaOhm to PetaOhm
    /// </summary>
    /// <param name="val">quantity measured in DekaOhm</param>
    /// <returns>quantity measured in PetaOhm</returns>
	public static Quantity<double, PetaOhm> ToPetaOhm<T>(this Quantity<T, DekaOhm> val) where T:IConvertible {
        return new Quantity<double, PetaOhm>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaOhm to TeraOhm
    /// </summary>
    /// <param name="val">quantity measured in DekaOhm</param>
    /// <returns>quantity measured in TeraOhm</returns>
	public static Quantity<double, TeraOhm> ToTeraOhm<T>(this Quantity<T, DekaOhm> val) where T:IConvertible {
        return new Quantity<double, TeraOhm>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaOhm to GigaOhm
    /// </summary>
    /// <param name="val">quantity measured in DekaOhm</param>
    /// <returns>quantity measured in GigaOhm</returns>
	public static Quantity<double, GigaOhm> ToGigaOhm<T>(this Quantity<T, DekaOhm> val) where T:IConvertible {
        return new Quantity<double, GigaOhm>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaOhm to MegaOhm
    /// </summary>
    /// <param name="val">quantity measured in DekaOhm</param>
    /// <returns>quantity measured in MegaOhm</returns>
	public static Quantity<double, MegaOhm> ToMegaOhm<T>(this Quantity<T, DekaOhm> val) where T:IConvertible {
        return new Quantity<double, MegaOhm>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaOhm to KiloOhm
    /// </summary>
    /// <param name="val">quantity measured in DekaOhm</param>
    /// <returns>quantity measured in KiloOhm</returns>
	public static Quantity<double, KiloOhm> ToKiloOhm<T>(this Quantity<T, DekaOhm> val) where T:IConvertible {
        return new Quantity<double, KiloOhm>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaOhm to HectoOhm
    /// </summary>
    /// <param name="val">quantity measured in DekaOhm</param>
    /// <returns>quantity measured in HectoOhm</returns>
	public static Quantity<double, HectoOhm> ToHectoOhm<T>(this Quantity<T, DekaOhm> val) where T:IConvertible {
        return new Quantity<double, HectoOhm>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaOhm to DeciOhm
    /// </summary>
    /// <param name="val">quantity measured in DekaOhm</param>
    /// <returns>quantity measured in DeciOhm</returns>
	public static Quantity<double, DeciOhm> ToDeciOhm<T>(this Quantity<T, DekaOhm> val) where T:IConvertible {
        return new Quantity<double, DeciOhm>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaOhm to CentiOhm
    /// </summary>
    /// <param name="val">quantity measured in DekaOhm</param>
    /// <returns>quantity measured in CentiOhm</returns>
	public static Quantity<double, CentiOhm> ToCentiOhm<T>(this Quantity<T, DekaOhm> val) where T:IConvertible {
        return new Quantity<double, CentiOhm>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaOhm to MilliOhm
    /// </summary>
    /// <param name="val">quantity measured in DekaOhm</param>
    /// <returns>quantity measured in MilliOhm</returns>
	public static Quantity<double, MilliOhm> ToMilliOhm<T>(this Quantity<T, DekaOhm> val) where T:IConvertible {
        return new Quantity<double, MilliOhm>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaOhm to MicroOhm
    /// </summary>
    /// <param name="val">quantity measured in DekaOhm</param>
    /// <returns>quantity measured in MicroOhm</returns>
	public static Quantity<double, MicroOhm> ToMicroOhm<T>(this Quantity<T, DekaOhm> val) where T:IConvertible {
        return new Quantity<double, MicroOhm>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaOhm to NanoOhm
    /// </summary>
    /// <param name="val">quantity measured in DekaOhm</param>
    /// <returns>quantity measured in NanoOhm</returns>
	public static Quantity<double, NanoOhm> ToNanoOhm<T>(this Quantity<T, DekaOhm> val) where T:IConvertible {
        return new Quantity<double, NanoOhm>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaOhm to PicoOhm
    /// </summary>
    /// <param name="val">quantity measured in DekaOhm</param>
    /// <returns>quantity measured in PicoOhm</returns>
	public static Quantity<double, PicoOhm> ToPicoOhm<T>(this Quantity<T, DekaOhm> val) where T:IConvertible {
        return new Quantity<double, PicoOhm>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaOhm to FemtoOhm
    /// </summary>
    /// <param name="val">quantity measured in DekaOhm</param>
    /// <returns>quantity measured in FemtoOhm</returns>
	public static Quantity<double, FemtoOhm> ToFemtoOhm<T>(this Quantity<T, DekaOhm> val) where T:IConvertible {
        return new Quantity<double, FemtoOhm>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaOhm to AttoOhm
    /// </summary>
    /// <param name="val">quantity measured in DekaOhm</param>
    /// <returns>quantity measured in AttoOhm</returns>
	public static Quantity<double, AttoOhm> ToAttoOhm<T>(this Quantity<T, DekaOhm> val) where T:IConvertible {
        return new Quantity<double, AttoOhm>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaOhm to ZeptoOhm
    /// </summary>
    /// <param name="val">quantity measured in DekaOhm</param>
    /// <returns>quantity measured in ZeptoOhm</returns>
	public static Quantity<double, ZeptoOhm> ToZeptoOhm<T>(this Quantity<T, DekaOhm> val) where T:IConvertible {
        return new Quantity<double, ZeptoOhm>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaOhm to YoctoOhm
    /// </summary>
    /// <param name="val">quantity measured in DekaOhm</param>
    /// <returns>quantity measured in YoctoOhm</returns>
	public static Quantity<double, YoctoOhm> ToYoctoOhm<T>(this Quantity<T, DekaOhm> val) where T:IConvertible {
        return new Quantity<double, YoctoOhm>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DeciOhm to YottaOhm
    /// </summary>
    /// <param name="val">quantity measured in DeciOhm</param>
    /// <returns>quantity measured in YottaOhm</returns>
	public static Quantity<double, YottaOhm> ToYottaOhm<T>(this Quantity<T, DeciOhm> val) where T:IConvertible {
        return new Quantity<double, YottaOhm>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciOhm to ZettaOhm
    /// </summary>
    /// <param name="val">quantity measured in DeciOhm</param>
    /// <returns>quantity measured in ZettaOhm</returns>
	public static Quantity<double, ZettaOhm> ToZettaOhm<T>(this Quantity<T, DeciOhm> val) where T:IConvertible {
        return new Quantity<double, ZettaOhm>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciOhm to ExaOhm
    /// </summary>
    /// <param name="val">quantity measured in DeciOhm</param>
    /// <returns>quantity measured in ExaOhm</returns>
	public static Quantity<double, ExaOhm> ToExaOhm<T>(this Quantity<T, DeciOhm> val) where T:IConvertible {
        return new Quantity<double, ExaOhm>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciOhm to PetaOhm
    /// </summary>
    /// <param name="val">quantity measured in DeciOhm</param>
    /// <returns>quantity measured in PetaOhm</returns>
	public static Quantity<double, PetaOhm> ToPetaOhm<T>(this Quantity<T, DeciOhm> val) where T:IConvertible {
        return new Quantity<double, PetaOhm>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciOhm to TeraOhm
    /// </summary>
    /// <param name="val">quantity measured in DeciOhm</param>
    /// <returns>quantity measured in TeraOhm</returns>
	public static Quantity<double, TeraOhm> ToTeraOhm<T>(this Quantity<T, DeciOhm> val) where T:IConvertible {
        return new Quantity<double, TeraOhm>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciOhm to GigaOhm
    /// </summary>
    /// <param name="val">quantity measured in DeciOhm</param>
    /// <returns>quantity measured in GigaOhm</returns>
	public static Quantity<double, GigaOhm> ToGigaOhm<T>(this Quantity<T, DeciOhm> val) where T:IConvertible {
        return new Quantity<double, GigaOhm>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciOhm to MegaOhm
    /// </summary>
    /// <param name="val">quantity measured in DeciOhm</param>
    /// <returns>quantity measured in MegaOhm</returns>
	public static Quantity<double, MegaOhm> ToMegaOhm<T>(this Quantity<T, DeciOhm> val) where T:IConvertible {
        return new Quantity<double, MegaOhm>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciOhm to KiloOhm
    /// </summary>
    /// <param name="val">quantity measured in DeciOhm</param>
    /// <returns>quantity measured in KiloOhm</returns>
	public static Quantity<double, KiloOhm> ToKiloOhm<T>(this Quantity<T, DeciOhm> val) where T:IConvertible {
        return new Quantity<double, KiloOhm>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciOhm to HectoOhm
    /// </summary>
    /// <param name="val">quantity measured in DeciOhm</param>
    /// <returns>quantity measured in HectoOhm</returns>
	public static Quantity<double, HectoOhm> ToHectoOhm<T>(this Quantity<T, DeciOhm> val) where T:IConvertible {
        return new Quantity<double, HectoOhm>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciOhm to DekaOhm
    /// </summary>
    /// <param name="val">quantity measured in DeciOhm</param>
    /// <returns>quantity measured in DekaOhm</returns>
	public static Quantity<double, DekaOhm> ToDekaOhm<T>(this Quantity<T, DeciOhm> val) where T:IConvertible {
        return new Quantity<double, DekaOhm>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciOhm to CentiOhm
    /// </summary>
    /// <param name="val">quantity measured in DeciOhm</param>
    /// <returns>quantity measured in CentiOhm</returns>
	public static Quantity<double, CentiOhm> ToCentiOhm<T>(this Quantity<T, DeciOhm> val) where T:IConvertible {
        return new Quantity<double, CentiOhm>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciOhm to MilliOhm
    /// </summary>
    /// <param name="val">quantity measured in DeciOhm</param>
    /// <returns>quantity measured in MilliOhm</returns>
	public static Quantity<double, MilliOhm> ToMilliOhm<T>(this Quantity<T, DeciOhm> val) where T:IConvertible {
        return new Quantity<double, MilliOhm>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciOhm to MicroOhm
    /// </summary>
    /// <param name="val">quantity measured in DeciOhm</param>
    /// <returns>quantity measured in MicroOhm</returns>
	public static Quantity<double, MicroOhm> ToMicroOhm<T>(this Quantity<T, DeciOhm> val) where T:IConvertible {
        return new Quantity<double, MicroOhm>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciOhm to NanoOhm
    /// </summary>
    /// <param name="val">quantity measured in DeciOhm</param>
    /// <returns>quantity measured in NanoOhm</returns>
	public static Quantity<double, NanoOhm> ToNanoOhm<T>(this Quantity<T, DeciOhm> val) where T:IConvertible {
        return new Quantity<double, NanoOhm>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciOhm to PicoOhm
    /// </summary>
    /// <param name="val">quantity measured in DeciOhm</param>
    /// <returns>quantity measured in PicoOhm</returns>
	public static Quantity<double, PicoOhm> ToPicoOhm<T>(this Quantity<T, DeciOhm> val) where T:IConvertible {
        return new Quantity<double, PicoOhm>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciOhm to FemtoOhm
    /// </summary>
    /// <param name="val">quantity measured in DeciOhm</param>
    /// <returns>quantity measured in FemtoOhm</returns>
	public static Quantity<double, FemtoOhm> ToFemtoOhm<T>(this Quantity<T, DeciOhm> val) where T:IConvertible {
        return new Quantity<double, FemtoOhm>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciOhm to AttoOhm
    /// </summary>
    /// <param name="val">quantity measured in DeciOhm</param>
    /// <returns>quantity measured in AttoOhm</returns>
	public static Quantity<double, AttoOhm> ToAttoOhm<T>(this Quantity<T, DeciOhm> val) where T:IConvertible {
        return new Quantity<double, AttoOhm>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciOhm to ZeptoOhm
    /// </summary>
    /// <param name="val">quantity measured in DeciOhm</param>
    /// <returns>quantity measured in ZeptoOhm</returns>
	public static Quantity<double, ZeptoOhm> ToZeptoOhm<T>(this Quantity<T, DeciOhm> val) where T:IConvertible {
        return new Quantity<double, ZeptoOhm>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciOhm to YoctoOhm
    /// </summary>
    /// <param name="val">quantity measured in DeciOhm</param>
    /// <returns>quantity measured in YoctoOhm</returns>
	public static Quantity<double, YoctoOhm> ToYoctoOhm<T>(this Quantity<T, DeciOhm> val) where T:IConvertible {
        return new Quantity<double, YoctoOhm>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert CentiOhm to YottaOhm
    /// </summary>
    /// <param name="val">quantity measured in CentiOhm</param>
    /// <returns>quantity measured in YottaOhm</returns>
	public static Quantity<double, YottaOhm> ToYottaOhm<T>(this Quantity<T, CentiOhm> val) where T:IConvertible {
        return new Quantity<double, YottaOhm>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiOhm to ZettaOhm
    /// </summary>
    /// <param name="val">quantity measured in CentiOhm</param>
    /// <returns>quantity measured in ZettaOhm</returns>
	public static Quantity<double, ZettaOhm> ToZettaOhm<T>(this Quantity<T, CentiOhm> val) where T:IConvertible {
        return new Quantity<double, ZettaOhm>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiOhm to ExaOhm
    /// </summary>
    /// <param name="val">quantity measured in CentiOhm</param>
    /// <returns>quantity measured in ExaOhm</returns>
	public static Quantity<double, ExaOhm> ToExaOhm<T>(this Quantity<T, CentiOhm> val) where T:IConvertible {
        return new Quantity<double, ExaOhm>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiOhm to PetaOhm
    /// </summary>
    /// <param name="val">quantity measured in CentiOhm</param>
    /// <returns>quantity measured in PetaOhm</returns>
	public static Quantity<double, PetaOhm> ToPetaOhm<T>(this Quantity<T, CentiOhm> val) where T:IConvertible {
        return new Quantity<double, PetaOhm>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiOhm to TeraOhm
    /// </summary>
    /// <param name="val">quantity measured in CentiOhm</param>
    /// <returns>quantity measured in TeraOhm</returns>
	public static Quantity<double, TeraOhm> ToTeraOhm<T>(this Quantity<T, CentiOhm> val) where T:IConvertible {
        return new Quantity<double, TeraOhm>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiOhm to GigaOhm
    /// </summary>
    /// <param name="val">quantity measured in CentiOhm</param>
    /// <returns>quantity measured in GigaOhm</returns>
	public static Quantity<double, GigaOhm> ToGigaOhm<T>(this Quantity<T, CentiOhm> val) where T:IConvertible {
        return new Quantity<double, GigaOhm>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiOhm to MegaOhm
    /// </summary>
    /// <param name="val">quantity measured in CentiOhm</param>
    /// <returns>quantity measured in MegaOhm</returns>
	public static Quantity<double, MegaOhm> ToMegaOhm<T>(this Quantity<T, CentiOhm> val) where T:IConvertible {
        return new Quantity<double, MegaOhm>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiOhm to KiloOhm
    /// </summary>
    /// <param name="val">quantity measured in CentiOhm</param>
    /// <returns>quantity measured in KiloOhm</returns>
	public static Quantity<double, KiloOhm> ToKiloOhm<T>(this Quantity<T, CentiOhm> val) where T:IConvertible {
        return new Quantity<double, KiloOhm>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiOhm to HectoOhm
    /// </summary>
    /// <param name="val">quantity measured in CentiOhm</param>
    /// <returns>quantity measured in HectoOhm</returns>
	public static Quantity<double, HectoOhm> ToHectoOhm<T>(this Quantity<T, CentiOhm> val) where T:IConvertible {
        return new Quantity<double, HectoOhm>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiOhm to DekaOhm
    /// </summary>
    /// <param name="val">quantity measured in CentiOhm</param>
    /// <returns>quantity measured in DekaOhm</returns>
	public static Quantity<double, DekaOhm> ToDekaOhm<T>(this Quantity<T, CentiOhm> val) where T:IConvertible {
        return new Quantity<double, DekaOhm>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiOhm to DeciOhm
    /// </summary>
    /// <param name="val">quantity measured in CentiOhm</param>
    /// <returns>quantity measured in DeciOhm</returns>
	public static Quantity<double, DeciOhm> ToDeciOhm<T>(this Quantity<T, CentiOhm> val) where T:IConvertible {
        return new Quantity<double, DeciOhm>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiOhm to MilliOhm
    /// </summary>
    /// <param name="val">quantity measured in CentiOhm</param>
    /// <returns>quantity measured in MilliOhm</returns>
	public static Quantity<double, MilliOhm> ToMilliOhm<T>(this Quantity<T, CentiOhm> val) where T:IConvertible {
        return new Quantity<double, MilliOhm>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiOhm to MicroOhm
    /// </summary>
    /// <param name="val">quantity measured in CentiOhm</param>
    /// <returns>quantity measured in MicroOhm</returns>
	public static Quantity<double, MicroOhm> ToMicroOhm<T>(this Quantity<T, CentiOhm> val) where T:IConvertible {
        return new Quantity<double, MicroOhm>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiOhm to NanoOhm
    /// </summary>
    /// <param name="val">quantity measured in CentiOhm</param>
    /// <returns>quantity measured in NanoOhm</returns>
	public static Quantity<double, NanoOhm> ToNanoOhm<T>(this Quantity<T, CentiOhm> val) where T:IConvertible {
        return new Quantity<double, NanoOhm>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiOhm to PicoOhm
    /// </summary>
    /// <param name="val">quantity measured in CentiOhm</param>
    /// <returns>quantity measured in PicoOhm</returns>
	public static Quantity<double, PicoOhm> ToPicoOhm<T>(this Quantity<T, CentiOhm> val) where T:IConvertible {
        return new Quantity<double, PicoOhm>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiOhm to FemtoOhm
    /// </summary>
    /// <param name="val">quantity measured in CentiOhm</param>
    /// <returns>quantity measured in FemtoOhm</returns>
	public static Quantity<double, FemtoOhm> ToFemtoOhm<T>(this Quantity<T, CentiOhm> val) where T:IConvertible {
        return new Quantity<double, FemtoOhm>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiOhm to AttoOhm
    /// </summary>
    /// <param name="val">quantity measured in CentiOhm</param>
    /// <returns>quantity measured in AttoOhm</returns>
	public static Quantity<double, AttoOhm> ToAttoOhm<T>(this Quantity<T, CentiOhm> val) where T:IConvertible {
        return new Quantity<double, AttoOhm>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiOhm to ZeptoOhm
    /// </summary>
    /// <param name="val">quantity measured in CentiOhm</param>
    /// <returns>quantity measured in ZeptoOhm</returns>
	public static Quantity<double, ZeptoOhm> ToZeptoOhm<T>(this Quantity<T, CentiOhm> val) where T:IConvertible {
        return new Quantity<double, ZeptoOhm>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiOhm to YoctoOhm
    /// </summary>
    /// <param name="val">quantity measured in CentiOhm</param>
    /// <returns>quantity measured in YoctoOhm</returns>
	public static Quantity<double, YoctoOhm> ToYoctoOhm<T>(this Quantity<T, CentiOhm> val) where T:IConvertible {
        return new Quantity<double, YoctoOhm>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert MilliOhm to YottaOhm
    /// </summary>
    /// <param name="val">quantity measured in MilliOhm</param>
    /// <returns>quantity measured in YottaOhm</returns>
	public static Quantity<double, YottaOhm> ToYottaOhm<T>(this Quantity<T, MilliOhm> val) where T:IConvertible {
        return new Quantity<double, YottaOhm>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliOhm to ZettaOhm
    /// </summary>
    /// <param name="val">quantity measured in MilliOhm</param>
    /// <returns>quantity measured in ZettaOhm</returns>
	public static Quantity<double, ZettaOhm> ToZettaOhm<T>(this Quantity<T, MilliOhm> val) where T:IConvertible {
        return new Quantity<double, ZettaOhm>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliOhm to ExaOhm
    /// </summary>
    /// <param name="val">quantity measured in MilliOhm</param>
    /// <returns>quantity measured in ExaOhm</returns>
	public static Quantity<double, ExaOhm> ToExaOhm<T>(this Quantity<T, MilliOhm> val) where T:IConvertible {
        return new Quantity<double, ExaOhm>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliOhm to PetaOhm
    /// </summary>
    /// <param name="val">quantity measured in MilliOhm</param>
    /// <returns>quantity measured in PetaOhm</returns>
	public static Quantity<double, PetaOhm> ToPetaOhm<T>(this Quantity<T, MilliOhm> val) where T:IConvertible {
        return new Quantity<double, PetaOhm>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliOhm to TeraOhm
    /// </summary>
    /// <param name="val">quantity measured in MilliOhm</param>
    /// <returns>quantity measured in TeraOhm</returns>
	public static Quantity<double, TeraOhm> ToTeraOhm<T>(this Quantity<T, MilliOhm> val) where T:IConvertible {
        return new Quantity<double, TeraOhm>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliOhm to GigaOhm
    /// </summary>
    /// <param name="val">quantity measured in MilliOhm</param>
    /// <returns>quantity measured in GigaOhm</returns>
	public static Quantity<double, GigaOhm> ToGigaOhm<T>(this Quantity<T, MilliOhm> val) where T:IConvertible {
        return new Quantity<double, GigaOhm>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliOhm to MegaOhm
    /// </summary>
    /// <param name="val">quantity measured in MilliOhm</param>
    /// <returns>quantity measured in MegaOhm</returns>
	public static Quantity<double, MegaOhm> ToMegaOhm<T>(this Quantity<T, MilliOhm> val) where T:IConvertible {
        return new Quantity<double, MegaOhm>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliOhm to KiloOhm
    /// </summary>
    /// <param name="val">quantity measured in MilliOhm</param>
    /// <returns>quantity measured in KiloOhm</returns>
	public static Quantity<double, KiloOhm> ToKiloOhm<T>(this Quantity<T, MilliOhm> val) where T:IConvertible {
        return new Quantity<double, KiloOhm>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliOhm to HectoOhm
    /// </summary>
    /// <param name="val">quantity measured in MilliOhm</param>
    /// <returns>quantity measured in HectoOhm</returns>
	public static Quantity<double, HectoOhm> ToHectoOhm<T>(this Quantity<T, MilliOhm> val) where T:IConvertible {
        return new Quantity<double, HectoOhm>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliOhm to DekaOhm
    /// </summary>
    /// <param name="val">quantity measured in MilliOhm</param>
    /// <returns>quantity measured in DekaOhm</returns>
	public static Quantity<double, DekaOhm> ToDekaOhm<T>(this Quantity<T, MilliOhm> val) where T:IConvertible {
        return new Quantity<double, DekaOhm>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliOhm to DeciOhm
    /// </summary>
    /// <param name="val">quantity measured in MilliOhm</param>
    /// <returns>quantity measured in DeciOhm</returns>
	public static Quantity<double, DeciOhm> ToDeciOhm<T>(this Quantity<T, MilliOhm> val) where T:IConvertible {
        return new Quantity<double, DeciOhm>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliOhm to CentiOhm
    /// </summary>
    /// <param name="val">quantity measured in MilliOhm</param>
    /// <returns>quantity measured in CentiOhm</returns>
	public static Quantity<double, CentiOhm> ToCentiOhm<T>(this Quantity<T, MilliOhm> val) where T:IConvertible {
        return new Quantity<double, CentiOhm>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliOhm to MicroOhm
    /// </summary>
    /// <param name="val">quantity measured in MilliOhm</param>
    /// <returns>quantity measured in MicroOhm</returns>
	public static Quantity<double, MicroOhm> ToMicroOhm<T>(this Quantity<T, MilliOhm> val) where T:IConvertible {
        return new Quantity<double, MicroOhm>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliOhm to NanoOhm
    /// </summary>
    /// <param name="val">quantity measured in MilliOhm</param>
    /// <returns>quantity measured in NanoOhm</returns>
	public static Quantity<double, NanoOhm> ToNanoOhm<T>(this Quantity<T, MilliOhm> val) where T:IConvertible {
        return new Quantity<double, NanoOhm>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliOhm to PicoOhm
    /// </summary>
    /// <param name="val">quantity measured in MilliOhm</param>
    /// <returns>quantity measured in PicoOhm</returns>
	public static Quantity<double, PicoOhm> ToPicoOhm<T>(this Quantity<T, MilliOhm> val) where T:IConvertible {
        return new Quantity<double, PicoOhm>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliOhm to FemtoOhm
    /// </summary>
    /// <param name="val">quantity measured in MilliOhm</param>
    /// <returns>quantity measured in FemtoOhm</returns>
	public static Quantity<double, FemtoOhm> ToFemtoOhm<T>(this Quantity<T, MilliOhm> val) where T:IConvertible {
        return new Quantity<double, FemtoOhm>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliOhm to AttoOhm
    /// </summary>
    /// <param name="val">quantity measured in MilliOhm</param>
    /// <returns>quantity measured in AttoOhm</returns>
	public static Quantity<double, AttoOhm> ToAttoOhm<T>(this Quantity<T, MilliOhm> val) where T:IConvertible {
        return new Quantity<double, AttoOhm>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliOhm to ZeptoOhm
    /// </summary>
    /// <param name="val">quantity measured in MilliOhm</param>
    /// <returns>quantity measured in ZeptoOhm</returns>
	public static Quantity<double, ZeptoOhm> ToZeptoOhm<T>(this Quantity<T, MilliOhm> val) where T:IConvertible {
        return new Quantity<double, ZeptoOhm>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliOhm to YoctoOhm
    /// </summary>
    /// <param name="val">quantity measured in MilliOhm</param>
    /// <returns>quantity measured in YoctoOhm</returns>
	public static Quantity<double, YoctoOhm> ToYoctoOhm<T>(this Quantity<T, MilliOhm> val) where T:IConvertible {
        return new Quantity<double, YoctoOhm>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MicroOhm to YottaOhm
    /// </summary>
    /// <param name="val">quantity measured in MicroOhm</param>
    /// <returns>quantity measured in YottaOhm</returns>
	public static Quantity<double, YottaOhm> ToYottaOhm<T>(this Quantity<T, MicroOhm> val) where T:IConvertible {
        return new Quantity<double, YottaOhm>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroOhm to ZettaOhm
    /// </summary>
    /// <param name="val">quantity measured in MicroOhm</param>
    /// <returns>quantity measured in ZettaOhm</returns>
	public static Quantity<double, ZettaOhm> ToZettaOhm<T>(this Quantity<T, MicroOhm> val) where T:IConvertible {
        return new Quantity<double, ZettaOhm>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroOhm to ExaOhm
    /// </summary>
    /// <param name="val">quantity measured in MicroOhm</param>
    /// <returns>quantity measured in ExaOhm</returns>
	public static Quantity<double, ExaOhm> ToExaOhm<T>(this Quantity<T, MicroOhm> val) where T:IConvertible {
        return new Quantity<double, ExaOhm>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroOhm to PetaOhm
    /// </summary>
    /// <param name="val">quantity measured in MicroOhm</param>
    /// <returns>quantity measured in PetaOhm</returns>
	public static Quantity<double, PetaOhm> ToPetaOhm<T>(this Quantity<T, MicroOhm> val) where T:IConvertible {
        return new Quantity<double, PetaOhm>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroOhm to TeraOhm
    /// </summary>
    /// <param name="val">quantity measured in MicroOhm</param>
    /// <returns>quantity measured in TeraOhm</returns>
	public static Quantity<double, TeraOhm> ToTeraOhm<T>(this Quantity<T, MicroOhm> val) where T:IConvertible {
        return new Quantity<double, TeraOhm>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroOhm to GigaOhm
    /// </summary>
    /// <param name="val">quantity measured in MicroOhm</param>
    /// <returns>quantity measured in GigaOhm</returns>
	public static Quantity<double, GigaOhm> ToGigaOhm<T>(this Quantity<T, MicroOhm> val) where T:IConvertible {
        return new Quantity<double, GigaOhm>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroOhm to MegaOhm
    /// </summary>
    /// <param name="val">quantity measured in MicroOhm</param>
    /// <returns>quantity measured in MegaOhm</returns>
	public static Quantity<double, MegaOhm> ToMegaOhm<T>(this Quantity<T, MicroOhm> val) where T:IConvertible {
        return new Quantity<double, MegaOhm>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroOhm to KiloOhm
    /// </summary>
    /// <param name="val">quantity measured in MicroOhm</param>
    /// <returns>quantity measured in KiloOhm</returns>
	public static Quantity<double, KiloOhm> ToKiloOhm<T>(this Quantity<T, MicroOhm> val) where T:IConvertible {
        return new Quantity<double, KiloOhm>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroOhm to HectoOhm
    /// </summary>
    /// <param name="val">quantity measured in MicroOhm</param>
    /// <returns>quantity measured in HectoOhm</returns>
	public static Quantity<double, HectoOhm> ToHectoOhm<T>(this Quantity<T, MicroOhm> val) where T:IConvertible {
        return new Quantity<double, HectoOhm>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroOhm to DekaOhm
    /// </summary>
    /// <param name="val">quantity measured in MicroOhm</param>
    /// <returns>quantity measured in DekaOhm</returns>
	public static Quantity<double, DekaOhm> ToDekaOhm<T>(this Quantity<T, MicroOhm> val) where T:IConvertible {
        return new Quantity<double, DekaOhm>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroOhm to DeciOhm
    /// </summary>
    /// <param name="val">quantity measured in MicroOhm</param>
    /// <returns>quantity measured in DeciOhm</returns>
	public static Quantity<double, DeciOhm> ToDeciOhm<T>(this Quantity<T, MicroOhm> val) where T:IConvertible {
        return new Quantity<double, DeciOhm>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroOhm to CentiOhm
    /// </summary>
    /// <param name="val">quantity measured in MicroOhm</param>
    /// <returns>quantity measured in CentiOhm</returns>
	public static Quantity<double, CentiOhm> ToCentiOhm<T>(this Quantity<T, MicroOhm> val) where T:IConvertible {
        return new Quantity<double, CentiOhm>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroOhm to MilliOhm
    /// </summary>
    /// <param name="val">quantity measured in MicroOhm</param>
    /// <returns>quantity measured in MilliOhm</returns>
	public static Quantity<double, MilliOhm> ToMilliOhm<T>(this Quantity<T, MicroOhm> val) where T:IConvertible {
        return new Quantity<double, MilliOhm>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroOhm to NanoOhm
    /// </summary>
    /// <param name="val">quantity measured in MicroOhm</param>
    /// <returns>quantity measured in NanoOhm</returns>
	public static Quantity<double, NanoOhm> ToNanoOhm<T>(this Quantity<T, MicroOhm> val) where T:IConvertible {
        return new Quantity<double, NanoOhm>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroOhm to PicoOhm
    /// </summary>
    /// <param name="val">quantity measured in MicroOhm</param>
    /// <returns>quantity measured in PicoOhm</returns>
	public static Quantity<double, PicoOhm> ToPicoOhm<T>(this Quantity<T, MicroOhm> val) where T:IConvertible {
        return new Quantity<double, PicoOhm>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroOhm to FemtoOhm
    /// </summary>
    /// <param name="val">quantity measured in MicroOhm</param>
    /// <returns>quantity measured in FemtoOhm</returns>
	public static Quantity<double, FemtoOhm> ToFemtoOhm<T>(this Quantity<T, MicroOhm> val) where T:IConvertible {
        return new Quantity<double, FemtoOhm>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroOhm to AttoOhm
    /// </summary>
    /// <param name="val">quantity measured in MicroOhm</param>
    /// <returns>quantity measured in AttoOhm</returns>
	public static Quantity<double, AttoOhm> ToAttoOhm<T>(this Quantity<T, MicroOhm> val) where T:IConvertible {
        return new Quantity<double, AttoOhm>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroOhm to ZeptoOhm
    /// </summary>
    /// <param name="val">quantity measured in MicroOhm</param>
    /// <returns>quantity measured in ZeptoOhm</returns>
	public static Quantity<double, ZeptoOhm> ToZeptoOhm<T>(this Quantity<T, MicroOhm> val) where T:IConvertible {
        return new Quantity<double, ZeptoOhm>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroOhm to YoctoOhm
    /// </summary>
    /// <param name="val">quantity measured in MicroOhm</param>
    /// <returns>quantity measured in YoctoOhm</returns>
	public static Quantity<double, YoctoOhm> ToYoctoOhm<T>(this Quantity<T, MicroOhm> val) where T:IConvertible {
        return new Quantity<double, YoctoOhm>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert NanoOhm to YottaOhm
    /// </summary>
    /// <param name="val">quantity measured in NanoOhm</param>
    /// <returns>quantity measured in YottaOhm</returns>
	public static Quantity<double, YottaOhm> ToYottaOhm<T>(this Quantity<T, NanoOhm> val) where T:IConvertible {
        return new Quantity<double, YottaOhm>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoOhm to ZettaOhm
    /// </summary>
    /// <param name="val">quantity measured in NanoOhm</param>
    /// <returns>quantity measured in ZettaOhm</returns>
	public static Quantity<double, ZettaOhm> ToZettaOhm<T>(this Quantity<T, NanoOhm> val) where T:IConvertible {
        return new Quantity<double, ZettaOhm>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoOhm to ExaOhm
    /// </summary>
    /// <param name="val">quantity measured in NanoOhm</param>
    /// <returns>quantity measured in ExaOhm</returns>
	public static Quantity<double, ExaOhm> ToExaOhm<T>(this Quantity<T, NanoOhm> val) where T:IConvertible {
        return new Quantity<double, ExaOhm>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoOhm to PetaOhm
    /// </summary>
    /// <param name="val">quantity measured in NanoOhm</param>
    /// <returns>quantity measured in PetaOhm</returns>
	public static Quantity<double, PetaOhm> ToPetaOhm<T>(this Quantity<T, NanoOhm> val) where T:IConvertible {
        return new Quantity<double, PetaOhm>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoOhm to TeraOhm
    /// </summary>
    /// <param name="val">quantity measured in NanoOhm</param>
    /// <returns>quantity measured in TeraOhm</returns>
	public static Quantity<double, TeraOhm> ToTeraOhm<T>(this Quantity<T, NanoOhm> val) where T:IConvertible {
        return new Quantity<double, TeraOhm>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoOhm to GigaOhm
    /// </summary>
    /// <param name="val">quantity measured in NanoOhm</param>
    /// <returns>quantity measured in GigaOhm</returns>
	public static Quantity<double, GigaOhm> ToGigaOhm<T>(this Quantity<T, NanoOhm> val) where T:IConvertible {
        return new Quantity<double, GigaOhm>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoOhm to MegaOhm
    /// </summary>
    /// <param name="val">quantity measured in NanoOhm</param>
    /// <returns>quantity measured in MegaOhm</returns>
	public static Quantity<double, MegaOhm> ToMegaOhm<T>(this Quantity<T, NanoOhm> val) where T:IConvertible {
        return new Quantity<double, MegaOhm>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoOhm to KiloOhm
    /// </summary>
    /// <param name="val">quantity measured in NanoOhm</param>
    /// <returns>quantity measured in KiloOhm</returns>
	public static Quantity<double, KiloOhm> ToKiloOhm<T>(this Quantity<T, NanoOhm> val) where T:IConvertible {
        return new Quantity<double, KiloOhm>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoOhm to HectoOhm
    /// </summary>
    /// <param name="val">quantity measured in NanoOhm</param>
    /// <returns>quantity measured in HectoOhm</returns>
	public static Quantity<double, HectoOhm> ToHectoOhm<T>(this Quantity<T, NanoOhm> val) where T:IConvertible {
        return new Quantity<double, HectoOhm>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoOhm to DekaOhm
    /// </summary>
    /// <param name="val">quantity measured in NanoOhm</param>
    /// <returns>quantity measured in DekaOhm</returns>
	public static Quantity<double, DekaOhm> ToDekaOhm<T>(this Quantity<T, NanoOhm> val) where T:IConvertible {
        return new Quantity<double, DekaOhm>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoOhm to DeciOhm
    /// </summary>
    /// <param name="val">quantity measured in NanoOhm</param>
    /// <returns>quantity measured in DeciOhm</returns>
	public static Quantity<double, DeciOhm> ToDeciOhm<T>(this Quantity<T, NanoOhm> val) where T:IConvertible {
        return new Quantity<double, DeciOhm>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoOhm to CentiOhm
    /// </summary>
    /// <param name="val">quantity measured in NanoOhm</param>
    /// <returns>quantity measured in CentiOhm</returns>
	public static Quantity<double, CentiOhm> ToCentiOhm<T>(this Quantity<T, NanoOhm> val) where T:IConvertible {
        return new Quantity<double, CentiOhm>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoOhm to MilliOhm
    /// </summary>
    /// <param name="val">quantity measured in NanoOhm</param>
    /// <returns>quantity measured in MilliOhm</returns>
	public static Quantity<double, MilliOhm> ToMilliOhm<T>(this Quantity<T, NanoOhm> val) where T:IConvertible {
        return new Quantity<double, MilliOhm>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoOhm to MicroOhm
    /// </summary>
    /// <param name="val">quantity measured in NanoOhm</param>
    /// <returns>quantity measured in MicroOhm</returns>
	public static Quantity<double, MicroOhm> ToMicroOhm<T>(this Quantity<T, NanoOhm> val) where T:IConvertible {
        return new Quantity<double, MicroOhm>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoOhm to PicoOhm
    /// </summary>
    /// <param name="val">quantity measured in NanoOhm</param>
    /// <returns>quantity measured in PicoOhm</returns>
	public static Quantity<double, PicoOhm> ToPicoOhm<T>(this Quantity<T, NanoOhm> val) where T:IConvertible {
        return new Quantity<double, PicoOhm>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoOhm to FemtoOhm
    /// </summary>
    /// <param name="val">quantity measured in NanoOhm</param>
    /// <returns>quantity measured in FemtoOhm</returns>
	public static Quantity<double, FemtoOhm> ToFemtoOhm<T>(this Quantity<T, NanoOhm> val) where T:IConvertible {
        return new Quantity<double, FemtoOhm>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoOhm to AttoOhm
    /// </summary>
    /// <param name="val">quantity measured in NanoOhm</param>
    /// <returns>quantity measured in AttoOhm</returns>
	public static Quantity<double, AttoOhm> ToAttoOhm<T>(this Quantity<T, NanoOhm> val) where T:IConvertible {
        return new Quantity<double, AttoOhm>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoOhm to ZeptoOhm
    /// </summary>
    /// <param name="val">quantity measured in NanoOhm</param>
    /// <returns>quantity measured in ZeptoOhm</returns>
	public static Quantity<double, ZeptoOhm> ToZeptoOhm<T>(this Quantity<T, NanoOhm> val) where T:IConvertible {
        return new Quantity<double, ZeptoOhm>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoOhm to YoctoOhm
    /// </summary>
    /// <param name="val">quantity measured in NanoOhm</param>
    /// <returns>quantity measured in YoctoOhm</returns>
	public static Quantity<double, YoctoOhm> ToYoctoOhm<T>(this Quantity<T, NanoOhm> val) where T:IConvertible {
        return new Quantity<double, YoctoOhm>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert PicoOhm to YottaOhm
    /// </summary>
    /// <param name="val">quantity measured in PicoOhm</param>
    /// <returns>quantity measured in YottaOhm</returns>
	public static Quantity<double, YottaOhm> ToYottaOhm<T>(this Quantity<T, PicoOhm> val) where T:IConvertible {
        return new Quantity<double, YottaOhm>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoOhm to ZettaOhm
    /// </summary>
    /// <param name="val">quantity measured in PicoOhm</param>
    /// <returns>quantity measured in ZettaOhm</returns>
	public static Quantity<double, ZettaOhm> ToZettaOhm<T>(this Quantity<T, PicoOhm> val) where T:IConvertible {
        return new Quantity<double, ZettaOhm>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoOhm to ExaOhm
    /// </summary>
    /// <param name="val">quantity measured in PicoOhm</param>
    /// <returns>quantity measured in ExaOhm</returns>
	public static Quantity<double, ExaOhm> ToExaOhm<T>(this Quantity<T, PicoOhm> val) where T:IConvertible {
        return new Quantity<double, ExaOhm>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoOhm to PetaOhm
    /// </summary>
    /// <param name="val">quantity measured in PicoOhm</param>
    /// <returns>quantity measured in PetaOhm</returns>
	public static Quantity<double, PetaOhm> ToPetaOhm<T>(this Quantity<T, PicoOhm> val) where T:IConvertible {
        return new Quantity<double, PetaOhm>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoOhm to TeraOhm
    /// </summary>
    /// <param name="val">quantity measured in PicoOhm</param>
    /// <returns>quantity measured in TeraOhm</returns>
	public static Quantity<double, TeraOhm> ToTeraOhm<T>(this Quantity<T, PicoOhm> val) where T:IConvertible {
        return new Quantity<double, TeraOhm>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoOhm to GigaOhm
    /// </summary>
    /// <param name="val">quantity measured in PicoOhm</param>
    /// <returns>quantity measured in GigaOhm</returns>
	public static Quantity<double, GigaOhm> ToGigaOhm<T>(this Quantity<T, PicoOhm> val) where T:IConvertible {
        return new Quantity<double, GigaOhm>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoOhm to MegaOhm
    /// </summary>
    /// <param name="val">quantity measured in PicoOhm</param>
    /// <returns>quantity measured in MegaOhm</returns>
	public static Quantity<double, MegaOhm> ToMegaOhm<T>(this Quantity<T, PicoOhm> val) where T:IConvertible {
        return new Quantity<double, MegaOhm>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoOhm to KiloOhm
    /// </summary>
    /// <param name="val">quantity measured in PicoOhm</param>
    /// <returns>quantity measured in KiloOhm</returns>
	public static Quantity<double, KiloOhm> ToKiloOhm<T>(this Quantity<T, PicoOhm> val) where T:IConvertible {
        return new Quantity<double, KiloOhm>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoOhm to HectoOhm
    /// </summary>
    /// <param name="val">quantity measured in PicoOhm</param>
    /// <returns>quantity measured in HectoOhm</returns>
	public static Quantity<double, HectoOhm> ToHectoOhm<T>(this Quantity<T, PicoOhm> val) where T:IConvertible {
        return new Quantity<double, HectoOhm>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoOhm to DekaOhm
    /// </summary>
    /// <param name="val">quantity measured in PicoOhm</param>
    /// <returns>quantity measured in DekaOhm</returns>
	public static Quantity<double, DekaOhm> ToDekaOhm<T>(this Quantity<T, PicoOhm> val) where T:IConvertible {
        return new Quantity<double, DekaOhm>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoOhm to DeciOhm
    /// </summary>
    /// <param name="val">quantity measured in PicoOhm</param>
    /// <returns>quantity measured in DeciOhm</returns>
	public static Quantity<double, DeciOhm> ToDeciOhm<T>(this Quantity<T, PicoOhm> val) where T:IConvertible {
        return new Quantity<double, DeciOhm>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoOhm to CentiOhm
    /// </summary>
    /// <param name="val">quantity measured in PicoOhm</param>
    /// <returns>quantity measured in CentiOhm</returns>
	public static Quantity<double, CentiOhm> ToCentiOhm<T>(this Quantity<T, PicoOhm> val) where T:IConvertible {
        return new Quantity<double, CentiOhm>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoOhm to MilliOhm
    /// </summary>
    /// <param name="val">quantity measured in PicoOhm</param>
    /// <returns>quantity measured in MilliOhm</returns>
	public static Quantity<double, MilliOhm> ToMilliOhm<T>(this Quantity<T, PicoOhm> val) where T:IConvertible {
        return new Quantity<double, MilliOhm>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoOhm to MicroOhm
    /// </summary>
    /// <param name="val">quantity measured in PicoOhm</param>
    /// <returns>quantity measured in MicroOhm</returns>
	public static Quantity<double, MicroOhm> ToMicroOhm<T>(this Quantity<T, PicoOhm> val) where T:IConvertible {
        return new Quantity<double, MicroOhm>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoOhm to NanoOhm
    /// </summary>
    /// <param name="val">quantity measured in PicoOhm</param>
    /// <returns>quantity measured in NanoOhm</returns>
	public static Quantity<double, NanoOhm> ToNanoOhm<T>(this Quantity<T, PicoOhm> val) where T:IConvertible {
        return new Quantity<double, NanoOhm>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoOhm to FemtoOhm
    /// </summary>
    /// <param name="val">quantity measured in PicoOhm</param>
    /// <returns>quantity measured in FemtoOhm</returns>
	public static Quantity<double, FemtoOhm> ToFemtoOhm<T>(this Quantity<T, PicoOhm> val) where T:IConvertible {
        return new Quantity<double, FemtoOhm>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoOhm to AttoOhm
    /// </summary>
    /// <param name="val">quantity measured in PicoOhm</param>
    /// <returns>quantity measured in AttoOhm</returns>
	public static Quantity<double, AttoOhm> ToAttoOhm<T>(this Quantity<T, PicoOhm> val) where T:IConvertible {
        return new Quantity<double, AttoOhm>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoOhm to ZeptoOhm
    /// </summary>
    /// <param name="val">quantity measured in PicoOhm</param>
    /// <returns>quantity measured in ZeptoOhm</returns>
	public static Quantity<double, ZeptoOhm> ToZeptoOhm<T>(this Quantity<T, PicoOhm> val) where T:IConvertible {
        return new Quantity<double, ZeptoOhm>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoOhm to YoctoOhm
    /// </summary>
    /// <param name="val">quantity measured in PicoOhm</param>
    /// <returns>quantity measured in YoctoOhm</returns>
	public static Quantity<double, YoctoOhm> ToYoctoOhm<T>(this Quantity<T, PicoOhm> val) where T:IConvertible {
        return new Quantity<double, YoctoOhm>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert FemtoOhm to YottaOhm
    /// </summary>
    /// <param name="val">quantity measured in FemtoOhm</param>
    /// <returns>quantity measured in YottaOhm</returns>
	public static Quantity<double, YottaOhm> ToYottaOhm<T>(this Quantity<T, FemtoOhm> val) where T:IConvertible {
        return new Quantity<double, YottaOhm>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoOhm to ZettaOhm
    /// </summary>
    /// <param name="val">quantity measured in FemtoOhm</param>
    /// <returns>quantity measured in ZettaOhm</returns>
	public static Quantity<double, ZettaOhm> ToZettaOhm<T>(this Quantity<T, FemtoOhm> val) where T:IConvertible {
        return new Quantity<double, ZettaOhm>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoOhm to ExaOhm
    /// </summary>
    /// <param name="val">quantity measured in FemtoOhm</param>
    /// <returns>quantity measured in ExaOhm</returns>
	public static Quantity<double, ExaOhm> ToExaOhm<T>(this Quantity<T, FemtoOhm> val) where T:IConvertible {
        return new Quantity<double, ExaOhm>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoOhm to PetaOhm
    /// </summary>
    /// <param name="val">quantity measured in FemtoOhm</param>
    /// <returns>quantity measured in PetaOhm</returns>
	public static Quantity<double, PetaOhm> ToPetaOhm<T>(this Quantity<T, FemtoOhm> val) where T:IConvertible {
        return new Quantity<double, PetaOhm>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoOhm to TeraOhm
    /// </summary>
    /// <param name="val">quantity measured in FemtoOhm</param>
    /// <returns>quantity measured in TeraOhm</returns>
	public static Quantity<double, TeraOhm> ToTeraOhm<T>(this Quantity<T, FemtoOhm> val) where T:IConvertible {
        return new Quantity<double, TeraOhm>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoOhm to GigaOhm
    /// </summary>
    /// <param name="val">quantity measured in FemtoOhm</param>
    /// <returns>quantity measured in GigaOhm</returns>
	public static Quantity<double, GigaOhm> ToGigaOhm<T>(this Quantity<T, FemtoOhm> val) where T:IConvertible {
        return new Quantity<double, GigaOhm>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoOhm to MegaOhm
    /// </summary>
    /// <param name="val">quantity measured in FemtoOhm</param>
    /// <returns>quantity measured in MegaOhm</returns>
	public static Quantity<double, MegaOhm> ToMegaOhm<T>(this Quantity<T, FemtoOhm> val) where T:IConvertible {
        return new Quantity<double, MegaOhm>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoOhm to KiloOhm
    /// </summary>
    /// <param name="val">quantity measured in FemtoOhm</param>
    /// <returns>quantity measured in KiloOhm</returns>
	public static Quantity<double, KiloOhm> ToKiloOhm<T>(this Quantity<T, FemtoOhm> val) where T:IConvertible {
        return new Quantity<double, KiloOhm>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoOhm to HectoOhm
    /// </summary>
    /// <param name="val">quantity measured in FemtoOhm</param>
    /// <returns>quantity measured in HectoOhm</returns>
	public static Quantity<double, HectoOhm> ToHectoOhm<T>(this Quantity<T, FemtoOhm> val) where T:IConvertible {
        return new Quantity<double, HectoOhm>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoOhm to DekaOhm
    /// </summary>
    /// <param name="val">quantity measured in FemtoOhm</param>
    /// <returns>quantity measured in DekaOhm</returns>
	public static Quantity<double, DekaOhm> ToDekaOhm<T>(this Quantity<T, FemtoOhm> val) where T:IConvertible {
        return new Quantity<double, DekaOhm>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoOhm to DeciOhm
    /// </summary>
    /// <param name="val">quantity measured in FemtoOhm</param>
    /// <returns>quantity measured in DeciOhm</returns>
	public static Quantity<double, DeciOhm> ToDeciOhm<T>(this Quantity<T, FemtoOhm> val) where T:IConvertible {
        return new Quantity<double, DeciOhm>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoOhm to CentiOhm
    /// </summary>
    /// <param name="val">quantity measured in FemtoOhm</param>
    /// <returns>quantity measured in CentiOhm</returns>
	public static Quantity<double, CentiOhm> ToCentiOhm<T>(this Quantity<T, FemtoOhm> val) where T:IConvertible {
        return new Quantity<double, CentiOhm>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoOhm to MilliOhm
    /// </summary>
    /// <param name="val">quantity measured in FemtoOhm</param>
    /// <returns>quantity measured in MilliOhm</returns>
	public static Quantity<double, MilliOhm> ToMilliOhm<T>(this Quantity<T, FemtoOhm> val) where T:IConvertible {
        return new Quantity<double, MilliOhm>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoOhm to MicroOhm
    /// </summary>
    /// <param name="val">quantity measured in FemtoOhm</param>
    /// <returns>quantity measured in MicroOhm</returns>
	public static Quantity<double, MicroOhm> ToMicroOhm<T>(this Quantity<T, FemtoOhm> val) where T:IConvertible {
        return new Quantity<double, MicroOhm>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoOhm to NanoOhm
    /// </summary>
    /// <param name="val">quantity measured in FemtoOhm</param>
    /// <returns>quantity measured in NanoOhm</returns>
	public static Quantity<double, NanoOhm> ToNanoOhm<T>(this Quantity<T, FemtoOhm> val) where T:IConvertible {
        return new Quantity<double, NanoOhm>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoOhm to PicoOhm
    /// </summary>
    /// <param name="val">quantity measured in FemtoOhm</param>
    /// <returns>quantity measured in PicoOhm</returns>
	public static Quantity<double, PicoOhm> ToPicoOhm<T>(this Quantity<T, FemtoOhm> val) where T:IConvertible {
        return new Quantity<double, PicoOhm>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoOhm to AttoOhm
    /// </summary>
    /// <param name="val">quantity measured in FemtoOhm</param>
    /// <returns>quantity measured in AttoOhm</returns>
	public static Quantity<double, AttoOhm> ToAttoOhm<T>(this Quantity<T, FemtoOhm> val) where T:IConvertible {
        return new Quantity<double, AttoOhm>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoOhm to ZeptoOhm
    /// </summary>
    /// <param name="val">quantity measured in FemtoOhm</param>
    /// <returns>quantity measured in ZeptoOhm</returns>
	public static Quantity<double, ZeptoOhm> ToZeptoOhm<T>(this Quantity<T, FemtoOhm> val) where T:IConvertible {
        return new Quantity<double, ZeptoOhm>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoOhm to YoctoOhm
    /// </summary>
    /// <param name="val">quantity measured in FemtoOhm</param>
    /// <returns>quantity measured in YoctoOhm</returns>
	public static Quantity<double, YoctoOhm> ToYoctoOhm<T>(this Quantity<T, FemtoOhm> val) where T:IConvertible {
        return new Quantity<double, YoctoOhm>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert AttoOhm to YottaOhm
    /// </summary>
    /// <param name="val">quantity measured in AttoOhm</param>
    /// <returns>quantity measured in YottaOhm</returns>
	public static Quantity<double, YottaOhm> ToYottaOhm<T>(this Quantity<T, AttoOhm> val) where T:IConvertible {
        return new Quantity<double, YottaOhm>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoOhm to ZettaOhm
    /// </summary>
    /// <param name="val">quantity measured in AttoOhm</param>
    /// <returns>quantity measured in ZettaOhm</returns>
	public static Quantity<double, ZettaOhm> ToZettaOhm<T>(this Quantity<T, AttoOhm> val) where T:IConvertible {
        return new Quantity<double, ZettaOhm>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoOhm to ExaOhm
    /// </summary>
    /// <param name="val">quantity measured in AttoOhm</param>
    /// <returns>quantity measured in ExaOhm</returns>
	public static Quantity<double, ExaOhm> ToExaOhm<T>(this Quantity<T, AttoOhm> val) where T:IConvertible {
        return new Quantity<double, ExaOhm>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoOhm to PetaOhm
    /// </summary>
    /// <param name="val">quantity measured in AttoOhm</param>
    /// <returns>quantity measured in PetaOhm</returns>
	public static Quantity<double, PetaOhm> ToPetaOhm<T>(this Quantity<T, AttoOhm> val) where T:IConvertible {
        return new Quantity<double, PetaOhm>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoOhm to TeraOhm
    /// </summary>
    /// <param name="val">quantity measured in AttoOhm</param>
    /// <returns>quantity measured in TeraOhm</returns>
	public static Quantity<double, TeraOhm> ToTeraOhm<T>(this Quantity<T, AttoOhm> val) where T:IConvertible {
        return new Quantity<double, TeraOhm>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoOhm to GigaOhm
    /// </summary>
    /// <param name="val">quantity measured in AttoOhm</param>
    /// <returns>quantity measured in GigaOhm</returns>
	public static Quantity<double, GigaOhm> ToGigaOhm<T>(this Quantity<T, AttoOhm> val) where T:IConvertible {
        return new Quantity<double, GigaOhm>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoOhm to MegaOhm
    /// </summary>
    /// <param name="val">quantity measured in AttoOhm</param>
    /// <returns>quantity measured in MegaOhm</returns>
	public static Quantity<double, MegaOhm> ToMegaOhm<T>(this Quantity<T, AttoOhm> val) where T:IConvertible {
        return new Quantity<double, MegaOhm>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoOhm to KiloOhm
    /// </summary>
    /// <param name="val">quantity measured in AttoOhm</param>
    /// <returns>quantity measured in KiloOhm</returns>
	public static Quantity<double, KiloOhm> ToKiloOhm<T>(this Quantity<T, AttoOhm> val) where T:IConvertible {
        return new Quantity<double, KiloOhm>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoOhm to HectoOhm
    /// </summary>
    /// <param name="val">quantity measured in AttoOhm</param>
    /// <returns>quantity measured in HectoOhm</returns>
	public static Quantity<double, HectoOhm> ToHectoOhm<T>(this Quantity<T, AttoOhm> val) where T:IConvertible {
        return new Quantity<double, HectoOhm>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoOhm to DekaOhm
    /// </summary>
    /// <param name="val">quantity measured in AttoOhm</param>
    /// <returns>quantity measured in DekaOhm</returns>
	public static Quantity<double, DekaOhm> ToDekaOhm<T>(this Quantity<T, AttoOhm> val) where T:IConvertible {
        return new Quantity<double, DekaOhm>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoOhm to DeciOhm
    /// </summary>
    /// <param name="val">quantity measured in AttoOhm</param>
    /// <returns>quantity measured in DeciOhm</returns>
	public static Quantity<double, DeciOhm> ToDeciOhm<T>(this Quantity<T, AttoOhm> val) where T:IConvertible {
        return new Quantity<double, DeciOhm>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoOhm to CentiOhm
    /// </summary>
    /// <param name="val">quantity measured in AttoOhm</param>
    /// <returns>quantity measured in CentiOhm</returns>
	public static Quantity<double, CentiOhm> ToCentiOhm<T>(this Quantity<T, AttoOhm> val) where T:IConvertible {
        return new Quantity<double, CentiOhm>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoOhm to MilliOhm
    /// </summary>
    /// <param name="val">quantity measured in AttoOhm</param>
    /// <returns>quantity measured in MilliOhm</returns>
	public static Quantity<double, MilliOhm> ToMilliOhm<T>(this Quantity<T, AttoOhm> val) where T:IConvertible {
        return new Quantity<double, MilliOhm>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoOhm to MicroOhm
    /// </summary>
    /// <param name="val">quantity measured in AttoOhm</param>
    /// <returns>quantity measured in MicroOhm</returns>
	public static Quantity<double, MicroOhm> ToMicroOhm<T>(this Quantity<T, AttoOhm> val) where T:IConvertible {
        return new Quantity<double, MicroOhm>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoOhm to NanoOhm
    /// </summary>
    /// <param name="val">quantity measured in AttoOhm</param>
    /// <returns>quantity measured in NanoOhm</returns>
	public static Quantity<double, NanoOhm> ToNanoOhm<T>(this Quantity<T, AttoOhm> val) where T:IConvertible {
        return new Quantity<double, NanoOhm>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoOhm to PicoOhm
    /// </summary>
    /// <param name="val">quantity measured in AttoOhm</param>
    /// <returns>quantity measured in PicoOhm</returns>
	public static Quantity<double, PicoOhm> ToPicoOhm<T>(this Quantity<T, AttoOhm> val) where T:IConvertible {
        return new Quantity<double, PicoOhm>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoOhm to FemtoOhm
    /// </summary>
    /// <param name="val">quantity measured in AttoOhm</param>
    /// <returns>quantity measured in FemtoOhm</returns>
	public static Quantity<double, FemtoOhm> ToFemtoOhm<T>(this Quantity<T, AttoOhm> val) where T:IConvertible {
        return new Quantity<double, FemtoOhm>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoOhm to ZeptoOhm
    /// </summary>
    /// <param name="val">quantity measured in AttoOhm</param>
    /// <returns>quantity measured in ZeptoOhm</returns>
	public static Quantity<double, ZeptoOhm> ToZeptoOhm<T>(this Quantity<T, AttoOhm> val) where T:IConvertible {
        return new Quantity<double, ZeptoOhm>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoOhm to YoctoOhm
    /// </summary>
    /// <param name="val">quantity measured in AttoOhm</param>
    /// <returns>quantity measured in YoctoOhm</returns>
	public static Quantity<double, YoctoOhm> ToYoctoOhm<T>(this Quantity<T, AttoOhm> val) where T:IConvertible {
        return new Quantity<double, YoctoOhm>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoOhm to YottaOhm
    /// </summary>
    /// <param name="val">quantity measured in ZeptoOhm</param>
    /// <returns>quantity measured in YottaOhm</returns>
	public static Quantity<double, YottaOhm> ToYottaOhm<T>(this Quantity<T, ZeptoOhm> val) where T:IConvertible {
        return new Quantity<double, YottaOhm>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoOhm to ZettaOhm
    /// </summary>
    /// <param name="val">quantity measured in ZeptoOhm</param>
    /// <returns>quantity measured in ZettaOhm</returns>
	public static Quantity<double, ZettaOhm> ToZettaOhm<T>(this Quantity<T, ZeptoOhm> val) where T:IConvertible {
        return new Quantity<double, ZettaOhm>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoOhm to ExaOhm
    /// </summary>
    /// <param name="val">quantity measured in ZeptoOhm</param>
    /// <returns>quantity measured in ExaOhm</returns>
	public static Quantity<double, ExaOhm> ToExaOhm<T>(this Quantity<T, ZeptoOhm> val) where T:IConvertible {
        return new Quantity<double, ExaOhm>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoOhm to PetaOhm
    /// </summary>
    /// <param name="val">quantity measured in ZeptoOhm</param>
    /// <returns>quantity measured in PetaOhm</returns>
	public static Quantity<double, PetaOhm> ToPetaOhm<T>(this Quantity<T, ZeptoOhm> val) where T:IConvertible {
        return new Quantity<double, PetaOhm>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoOhm to TeraOhm
    /// </summary>
    /// <param name="val">quantity measured in ZeptoOhm</param>
    /// <returns>quantity measured in TeraOhm</returns>
	public static Quantity<double, TeraOhm> ToTeraOhm<T>(this Quantity<T, ZeptoOhm> val) where T:IConvertible {
        return new Quantity<double, TeraOhm>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoOhm to GigaOhm
    /// </summary>
    /// <param name="val">quantity measured in ZeptoOhm</param>
    /// <returns>quantity measured in GigaOhm</returns>
	public static Quantity<double, GigaOhm> ToGigaOhm<T>(this Quantity<T, ZeptoOhm> val) where T:IConvertible {
        return new Quantity<double, GigaOhm>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoOhm to MegaOhm
    /// </summary>
    /// <param name="val">quantity measured in ZeptoOhm</param>
    /// <returns>quantity measured in MegaOhm</returns>
	public static Quantity<double, MegaOhm> ToMegaOhm<T>(this Quantity<T, ZeptoOhm> val) where T:IConvertible {
        return new Quantity<double, MegaOhm>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoOhm to KiloOhm
    /// </summary>
    /// <param name="val">quantity measured in ZeptoOhm</param>
    /// <returns>quantity measured in KiloOhm</returns>
	public static Quantity<double, KiloOhm> ToKiloOhm<T>(this Quantity<T, ZeptoOhm> val) where T:IConvertible {
        return new Quantity<double, KiloOhm>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoOhm to HectoOhm
    /// </summary>
    /// <param name="val">quantity measured in ZeptoOhm</param>
    /// <returns>quantity measured in HectoOhm</returns>
	public static Quantity<double, HectoOhm> ToHectoOhm<T>(this Quantity<T, ZeptoOhm> val) where T:IConvertible {
        return new Quantity<double, HectoOhm>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoOhm to DekaOhm
    /// </summary>
    /// <param name="val">quantity measured in ZeptoOhm</param>
    /// <returns>quantity measured in DekaOhm</returns>
	public static Quantity<double, DekaOhm> ToDekaOhm<T>(this Quantity<T, ZeptoOhm> val) where T:IConvertible {
        return new Quantity<double, DekaOhm>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoOhm to DeciOhm
    /// </summary>
    /// <param name="val">quantity measured in ZeptoOhm</param>
    /// <returns>quantity measured in DeciOhm</returns>
	public static Quantity<double, DeciOhm> ToDeciOhm<T>(this Quantity<T, ZeptoOhm> val) where T:IConvertible {
        return new Quantity<double, DeciOhm>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoOhm to CentiOhm
    /// </summary>
    /// <param name="val">quantity measured in ZeptoOhm</param>
    /// <returns>quantity measured in CentiOhm</returns>
	public static Quantity<double, CentiOhm> ToCentiOhm<T>(this Quantity<T, ZeptoOhm> val) where T:IConvertible {
        return new Quantity<double, CentiOhm>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoOhm to MilliOhm
    /// </summary>
    /// <param name="val">quantity measured in ZeptoOhm</param>
    /// <returns>quantity measured in MilliOhm</returns>
	public static Quantity<double, MilliOhm> ToMilliOhm<T>(this Quantity<T, ZeptoOhm> val) where T:IConvertible {
        return new Quantity<double, MilliOhm>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoOhm to MicroOhm
    /// </summary>
    /// <param name="val">quantity measured in ZeptoOhm</param>
    /// <returns>quantity measured in MicroOhm</returns>
	public static Quantity<double, MicroOhm> ToMicroOhm<T>(this Quantity<T, ZeptoOhm> val) where T:IConvertible {
        return new Quantity<double, MicroOhm>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoOhm to NanoOhm
    /// </summary>
    /// <param name="val">quantity measured in ZeptoOhm</param>
    /// <returns>quantity measured in NanoOhm</returns>
	public static Quantity<double, NanoOhm> ToNanoOhm<T>(this Quantity<T, ZeptoOhm> val) where T:IConvertible {
        return new Quantity<double, NanoOhm>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoOhm to PicoOhm
    /// </summary>
    /// <param name="val">quantity measured in ZeptoOhm</param>
    /// <returns>quantity measured in PicoOhm</returns>
	public static Quantity<double, PicoOhm> ToPicoOhm<T>(this Quantity<T, ZeptoOhm> val) where T:IConvertible {
        return new Quantity<double, PicoOhm>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoOhm to FemtoOhm
    /// </summary>
    /// <param name="val">quantity measured in ZeptoOhm</param>
    /// <returns>quantity measured in FemtoOhm</returns>
	public static Quantity<double, FemtoOhm> ToFemtoOhm<T>(this Quantity<T, ZeptoOhm> val) where T:IConvertible {
        return new Quantity<double, FemtoOhm>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoOhm to AttoOhm
    /// </summary>
    /// <param name="val">quantity measured in ZeptoOhm</param>
    /// <returns>quantity measured in AttoOhm</returns>
	public static Quantity<double, AttoOhm> ToAttoOhm<T>(this Quantity<T, ZeptoOhm> val) where T:IConvertible {
        return new Quantity<double, AttoOhm>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoOhm to YoctoOhm
    /// </summary>
    /// <param name="val">quantity measured in ZeptoOhm</param>
    /// <returns>quantity measured in YoctoOhm</returns>
	public static Quantity<double, YoctoOhm> ToYoctoOhm<T>(this Quantity<T, ZeptoOhm> val) where T:IConvertible {
        return new Quantity<double, YoctoOhm>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert YoctoOhm to YottaOhm
    /// </summary>
    /// <param name="val">quantity measured in YoctoOhm</param>
    /// <returns>quantity measured in YottaOhm</returns>
	public static Quantity<double, YottaOhm> ToYottaOhm<T>(this Quantity<T, YoctoOhm> val) where T:IConvertible {
        return new Quantity<double, YottaOhm>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoOhm to ZettaOhm
    /// </summary>
    /// <param name="val">quantity measured in YoctoOhm</param>
    /// <returns>quantity measured in ZettaOhm</returns>
	public static Quantity<double, ZettaOhm> ToZettaOhm<T>(this Quantity<T, YoctoOhm> val) where T:IConvertible {
        return new Quantity<double, ZettaOhm>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoOhm to ExaOhm
    /// </summary>
    /// <param name="val">quantity measured in YoctoOhm</param>
    /// <returns>quantity measured in ExaOhm</returns>
	public static Quantity<double, ExaOhm> ToExaOhm<T>(this Quantity<T, YoctoOhm> val) where T:IConvertible {
        return new Quantity<double, ExaOhm>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoOhm to PetaOhm
    /// </summary>
    /// <param name="val">quantity measured in YoctoOhm</param>
    /// <returns>quantity measured in PetaOhm</returns>
	public static Quantity<double, PetaOhm> ToPetaOhm<T>(this Quantity<T, YoctoOhm> val) where T:IConvertible {
        return new Quantity<double, PetaOhm>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoOhm to TeraOhm
    /// </summary>
    /// <param name="val">quantity measured in YoctoOhm</param>
    /// <returns>quantity measured in TeraOhm</returns>
	public static Quantity<double, TeraOhm> ToTeraOhm<T>(this Quantity<T, YoctoOhm> val) where T:IConvertible {
        return new Quantity<double, TeraOhm>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoOhm to GigaOhm
    /// </summary>
    /// <param name="val">quantity measured in YoctoOhm</param>
    /// <returns>quantity measured in GigaOhm</returns>
	public static Quantity<double, GigaOhm> ToGigaOhm<T>(this Quantity<T, YoctoOhm> val) where T:IConvertible {
        return new Quantity<double, GigaOhm>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoOhm to MegaOhm
    /// </summary>
    /// <param name="val">quantity measured in YoctoOhm</param>
    /// <returns>quantity measured in MegaOhm</returns>
	public static Quantity<double, MegaOhm> ToMegaOhm<T>(this Quantity<T, YoctoOhm> val) where T:IConvertible {
        return new Quantity<double, MegaOhm>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoOhm to KiloOhm
    /// </summary>
    /// <param name="val">quantity measured in YoctoOhm</param>
    /// <returns>quantity measured in KiloOhm</returns>
	public static Quantity<double, KiloOhm> ToKiloOhm<T>(this Quantity<T, YoctoOhm> val) where T:IConvertible {
        return new Quantity<double, KiloOhm>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoOhm to HectoOhm
    /// </summary>
    /// <param name="val">quantity measured in YoctoOhm</param>
    /// <returns>quantity measured in HectoOhm</returns>
	public static Quantity<double, HectoOhm> ToHectoOhm<T>(this Quantity<T, YoctoOhm> val) where T:IConvertible {
        return new Quantity<double, HectoOhm>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoOhm to DekaOhm
    /// </summary>
    /// <param name="val">quantity measured in YoctoOhm</param>
    /// <returns>quantity measured in DekaOhm</returns>
	public static Quantity<double, DekaOhm> ToDekaOhm<T>(this Quantity<T, YoctoOhm> val) where T:IConvertible {
        return new Quantity<double, DekaOhm>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoOhm to DeciOhm
    /// </summary>
    /// <param name="val">quantity measured in YoctoOhm</param>
    /// <returns>quantity measured in DeciOhm</returns>
	public static Quantity<double, DeciOhm> ToDeciOhm<T>(this Quantity<T, YoctoOhm> val) where T:IConvertible {
        return new Quantity<double, DeciOhm>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoOhm to CentiOhm
    /// </summary>
    /// <param name="val">quantity measured in YoctoOhm</param>
    /// <returns>quantity measured in CentiOhm</returns>
	public static Quantity<double, CentiOhm> ToCentiOhm<T>(this Quantity<T, YoctoOhm> val) where T:IConvertible {
        return new Quantity<double, CentiOhm>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoOhm to MilliOhm
    /// </summary>
    /// <param name="val">quantity measured in YoctoOhm</param>
    /// <returns>quantity measured in MilliOhm</returns>
	public static Quantity<double, MilliOhm> ToMilliOhm<T>(this Quantity<T, YoctoOhm> val) where T:IConvertible {
        return new Quantity<double, MilliOhm>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoOhm to MicroOhm
    /// </summary>
    /// <param name="val">quantity measured in YoctoOhm</param>
    /// <returns>quantity measured in MicroOhm</returns>
	public static Quantity<double, MicroOhm> ToMicroOhm<T>(this Quantity<T, YoctoOhm> val) where T:IConvertible {
        return new Quantity<double, MicroOhm>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoOhm to NanoOhm
    /// </summary>
    /// <param name="val">quantity measured in YoctoOhm</param>
    /// <returns>quantity measured in NanoOhm</returns>
	public static Quantity<double, NanoOhm> ToNanoOhm<T>(this Quantity<T, YoctoOhm> val) where T:IConvertible {
        return new Quantity<double, NanoOhm>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoOhm to PicoOhm
    /// </summary>
    /// <param name="val">quantity measured in YoctoOhm</param>
    /// <returns>quantity measured in PicoOhm</returns>
	public static Quantity<double, PicoOhm> ToPicoOhm<T>(this Quantity<T, YoctoOhm> val) where T:IConvertible {
        return new Quantity<double, PicoOhm>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoOhm to FemtoOhm
    /// </summary>
    /// <param name="val">quantity measured in YoctoOhm</param>
    /// <returns>quantity measured in FemtoOhm</returns>
	public static Quantity<double, FemtoOhm> ToFemtoOhm<T>(this Quantity<T, YoctoOhm> val) where T:IConvertible {
        return new Quantity<double, FemtoOhm>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoOhm to AttoOhm
    /// </summary>
    /// <param name="val">quantity measured in YoctoOhm</param>
    /// <returns>quantity measured in AttoOhm</returns>
	public static Quantity<double, AttoOhm> ToAttoOhm<T>(this Quantity<T, YoctoOhm> val) where T:IConvertible {
        return new Quantity<double, AttoOhm>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoOhm to ZeptoOhm
    /// </summary>
    /// <param name="val">quantity measured in YoctoOhm</param>
    /// <returns>quantity measured in ZeptoOhm</returns>
	public static Quantity<double, ZeptoOhm> ToZeptoOhm<T>(this Quantity<T, YoctoOhm> val) where T:IConvertible {
        return new Quantity<double, ZeptoOhm>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
}
}