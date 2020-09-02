using System;
namespace Qkmaxware.Units.Mass {
/// <summary>
/// Static class housing si-prefix conversions for the unit "GramMass"
/// </summary>
public static class GramMassConversions {
	/// <summary>
    /// Extension method to convert Gram to YottaGram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in YottaGram</returns>
	public static Quantity<double, YottaGram> ToYottaGram<T>(this BaseQuantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, YottaGram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaGram to Gram
    /// </summary>
    /// <param name="val">quantity measured in YottaGram</param>
    /// <returns>quantity measured in Gram</returns>
	public static Quantity<double, Gram> ToGram<T>(this BaseQuantity<T, YottaGram> val) where T:IConvertible {
        return new Quantity<double, Gram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Gram to ZettaGram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in ZettaGram</returns>
	public static Quantity<double, ZettaGram> ToZettaGram<T>(this BaseQuantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, ZettaGram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaGram to Gram
    /// </summary>
    /// <param name="val">quantity measured in ZettaGram</param>
    /// <returns>quantity measured in Gram</returns>
	public static Quantity<double, Gram> ToGram<T>(this BaseQuantity<T, ZettaGram> val) where T:IConvertible {
        return new Quantity<double, Gram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Gram to ExaGram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in ExaGram</returns>
	public static Quantity<double, ExaGram> ToExaGram<T>(this BaseQuantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, ExaGram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaGram to Gram
    /// </summary>
    /// <param name="val">quantity measured in ExaGram</param>
    /// <returns>quantity measured in Gram</returns>
	public static Quantity<double, Gram> ToGram<T>(this BaseQuantity<T, ExaGram> val) where T:IConvertible {
        return new Quantity<double, Gram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Gram to PetaGram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in PetaGram</returns>
	public static Quantity<double, PetaGram> ToPetaGram<T>(this BaseQuantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, PetaGram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaGram to Gram
    /// </summary>
    /// <param name="val">quantity measured in PetaGram</param>
    /// <returns>quantity measured in Gram</returns>
	public static Quantity<double, Gram> ToGram<T>(this BaseQuantity<T, PetaGram> val) where T:IConvertible {
        return new Quantity<double, Gram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Gram to TeraGram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in TeraGram</returns>
	public static Quantity<double, TeraGram> ToTeraGram<T>(this BaseQuantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, TeraGram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraGram to Gram
    /// </summary>
    /// <param name="val">quantity measured in TeraGram</param>
    /// <returns>quantity measured in Gram</returns>
	public static Quantity<double, Gram> ToGram<T>(this BaseQuantity<T, TeraGram> val) where T:IConvertible {
        return new Quantity<double, Gram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Gram to GigaGram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in GigaGram</returns>
	public static Quantity<double, GigaGram> ToGigaGram<T>(this BaseQuantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, GigaGram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaGram to Gram
    /// </summary>
    /// <param name="val">quantity measured in GigaGram</param>
    /// <returns>quantity measured in Gram</returns>
	public static Quantity<double, Gram> ToGram<T>(this BaseQuantity<T, GigaGram> val) where T:IConvertible {
        return new Quantity<double, Gram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Gram to MegaGram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in MegaGram</returns>
	public static Quantity<double, MegaGram> ToMegaGram<T>(this BaseQuantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, MegaGram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaGram to Gram
    /// </summary>
    /// <param name="val">quantity measured in MegaGram</param>
    /// <returns>quantity measured in Gram</returns>
	public static Quantity<double, Gram> ToGram<T>(this BaseQuantity<T, MegaGram> val) where T:IConvertible {
        return new Quantity<double, Gram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Gram to KiloGram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in KiloGram</returns>
	public static Quantity<double, KiloGram> ToKiloGram<T>(this BaseQuantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, KiloGram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloGram to Gram
    /// </summary>
    /// <param name="val">quantity measured in KiloGram</param>
    /// <returns>quantity measured in Gram</returns>
	public static Quantity<double, Gram> ToGram<T>(this BaseQuantity<T, KiloGram> val) where T:IConvertible {
        return new Quantity<double, Gram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Gram to HectoGram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in HectoGram</returns>
	public static Quantity<double, HectoGram> ToHectoGram<T>(this BaseQuantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, HectoGram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoGram to Gram
    /// </summary>
    /// <param name="val">quantity measured in HectoGram</param>
    /// <returns>quantity measured in Gram</returns>
	public static Quantity<double, Gram> ToGram<T>(this BaseQuantity<T, HectoGram> val) where T:IConvertible {
        return new Quantity<double, Gram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Gram to DekaGram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in DekaGram</returns>
	public static Quantity<double, DekaGram> ToDekaGram<T>(this BaseQuantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, DekaGram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaGram to Gram
    /// </summary>
    /// <param name="val">quantity measured in DekaGram</param>
    /// <returns>quantity measured in Gram</returns>
	public static Quantity<double, Gram> ToGram<T>(this BaseQuantity<T, DekaGram> val) where T:IConvertible {
        return new Quantity<double, Gram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Gram to DeciGram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in DeciGram</returns>
	public static Quantity<double, DeciGram> ToDeciGram<T>(this BaseQuantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, DeciGram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciGram to Gram
    /// </summary>
    /// <param name="val">quantity measured in DeciGram</param>
    /// <returns>quantity measured in Gram</returns>
	public static Quantity<double, Gram> ToGram<T>(this BaseQuantity<T, DeciGram> val) where T:IConvertible {
        return new Quantity<double, Gram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Gram to CentiGram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in CentiGram</returns>
	public static Quantity<double, CentiGram> ToCentiGram<T>(this BaseQuantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, CentiGram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiGram to Gram
    /// </summary>
    /// <param name="val">quantity measured in CentiGram</param>
    /// <returns>quantity measured in Gram</returns>
	public static Quantity<double, Gram> ToGram<T>(this BaseQuantity<T, CentiGram> val) where T:IConvertible {
        return new Quantity<double, Gram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Gram to MilliGram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in MilliGram</returns>
	public static Quantity<double, MilliGram> ToMilliGram<T>(this BaseQuantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, MilliGram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliGram to Gram
    /// </summary>
    /// <param name="val">quantity measured in MilliGram</param>
    /// <returns>quantity measured in Gram</returns>
	public static Quantity<double, Gram> ToGram<T>(this BaseQuantity<T, MilliGram> val) where T:IConvertible {
        return new Quantity<double, Gram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Gram to MicroGram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in MicroGram</returns>
	public static Quantity<double, MicroGram> ToMicroGram<T>(this BaseQuantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, MicroGram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroGram to Gram
    /// </summary>
    /// <param name="val">quantity measured in MicroGram</param>
    /// <returns>quantity measured in Gram</returns>
	public static Quantity<double, Gram> ToGram<T>(this BaseQuantity<T, MicroGram> val) where T:IConvertible {
        return new Quantity<double, Gram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Gram to NanoGram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in NanoGram</returns>
	public static Quantity<double, NanoGram> ToNanoGram<T>(this BaseQuantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, NanoGram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoGram to Gram
    /// </summary>
    /// <param name="val">quantity measured in NanoGram</param>
    /// <returns>quantity measured in Gram</returns>
	public static Quantity<double, Gram> ToGram<T>(this BaseQuantity<T, NanoGram> val) where T:IConvertible {
        return new Quantity<double, Gram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gram to PicoGram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in PicoGram</returns>
	public static Quantity<double, PicoGram> ToPicoGram<T>(this BaseQuantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, PicoGram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoGram to Gram
    /// </summary>
    /// <param name="val">quantity measured in PicoGram</param>
    /// <returns>quantity measured in Gram</returns>
	public static Quantity<double, Gram> ToGram<T>(this BaseQuantity<T, PicoGram> val) where T:IConvertible {
        return new Quantity<double, Gram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Gram to FemtoGram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in FemtoGram</returns>
	public static Quantity<double, FemtoGram> ToFemtoGram<T>(this BaseQuantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, FemtoGram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoGram to Gram
    /// </summary>
    /// <param name="val">quantity measured in FemtoGram</param>
    /// <returns>quantity measured in Gram</returns>
	public static Quantity<double, Gram> ToGram<T>(this BaseQuantity<T, FemtoGram> val) where T:IConvertible {
        return new Quantity<double, Gram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Gram to AttoGram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in AttoGram</returns>
	public static Quantity<double, AttoGram> ToAttoGram<T>(this BaseQuantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, AttoGram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoGram to Gram
    /// </summary>
    /// <param name="val">quantity measured in AttoGram</param>
    /// <returns>quantity measured in Gram</returns>
	public static Quantity<double, Gram> ToGram<T>(this BaseQuantity<T, AttoGram> val) where T:IConvertible {
        return new Quantity<double, Gram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Gram to ZeptoGram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in ZeptoGram</returns>
	public static Quantity<double, ZeptoGram> ToZeptoGram<T>(this BaseQuantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, ZeptoGram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoGram to Gram
    /// </summary>
    /// <param name="val">quantity measured in ZeptoGram</param>
    /// <returns>quantity measured in Gram</returns>
	public static Quantity<double, Gram> ToGram<T>(this BaseQuantity<T, ZeptoGram> val) where T:IConvertible {
        return new Quantity<double, Gram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Gram to YoctoGram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in YoctoGram</returns>
	public static Quantity<double, YoctoGram> ToYoctoGram<T>(this BaseQuantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, YoctoGram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoGram to Gram
    /// </summary>
    /// <param name="val">quantity measured in YoctoGram</param>
    /// <returns>quantity measured in Gram</returns>
	public static Quantity<double, Gram> ToGram<T>(this BaseQuantity<T, YoctoGram> val) where T:IConvertible {
        return new Quantity<double, Gram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaGram to ZettaGram
    /// </summary>
    /// <param name="val">quantity measured in YottaGram</param>
    /// <returns>quantity measured in ZettaGram</returns>
	public static Quantity<double, ZettaGram> ToZettaGram<T>(this BaseQuantity<T, YottaGram> val) where T:IConvertible {
        return new Quantity<double, ZettaGram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaGram to ExaGram
    /// </summary>
    /// <param name="val">quantity measured in YottaGram</param>
    /// <returns>quantity measured in ExaGram</returns>
	public static Quantity<double, ExaGram> ToExaGram<T>(this BaseQuantity<T, YottaGram> val) where T:IConvertible {
        return new Quantity<double, ExaGram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaGram to PetaGram
    /// </summary>
    /// <param name="val">quantity measured in YottaGram</param>
    /// <returns>quantity measured in PetaGram</returns>
	public static Quantity<double, PetaGram> ToPetaGram<T>(this BaseQuantity<T, YottaGram> val) where T:IConvertible {
        return new Quantity<double, PetaGram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaGram to TeraGram
    /// </summary>
    /// <param name="val">quantity measured in YottaGram</param>
    /// <returns>quantity measured in TeraGram</returns>
	public static Quantity<double, TeraGram> ToTeraGram<T>(this BaseQuantity<T, YottaGram> val) where T:IConvertible {
        return new Quantity<double, TeraGram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaGram to GigaGram
    /// </summary>
    /// <param name="val">quantity measured in YottaGram</param>
    /// <returns>quantity measured in GigaGram</returns>
	public static Quantity<double, GigaGram> ToGigaGram<T>(this BaseQuantity<T, YottaGram> val) where T:IConvertible {
        return new Quantity<double, GigaGram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaGram to MegaGram
    /// </summary>
    /// <param name="val">quantity measured in YottaGram</param>
    /// <returns>quantity measured in MegaGram</returns>
	public static Quantity<double, MegaGram> ToMegaGram<T>(this BaseQuantity<T, YottaGram> val) where T:IConvertible {
        return new Quantity<double, MegaGram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaGram to KiloGram
    /// </summary>
    /// <param name="val">quantity measured in YottaGram</param>
    /// <returns>quantity measured in KiloGram</returns>
	public static Quantity<double, KiloGram> ToKiloGram<T>(this BaseQuantity<T, YottaGram> val) where T:IConvertible {
        return new Quantity<double, KiloGram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaGram to HectoGram
    /// </summary>
    /// <param name="val">quantity measured in YottaGram</param>
    /// <returns>quantity measured in HectoGram</returns>
	public static Quantity<double, HectoGram> ToHectoGram<T>(this BaseQuantity<T, YottaGram> val) where T:IConvertible {
        return new Quantity<double, HectoGram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaGram to DekaGram
    /// </summary>
    /// <param name="val">quantity measured in YottaGram</param>
    /// <returns>quantity measured in DekaGram</returns>
	public static Quantity<double, DekaGram> ToDekaGram<T>(this BaseQuantity<T, YottaGram> val) where T:IConvertible {
        return new Quantity<double, DekaGram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaGram to DeciGram
    /// </summary>
    /// <param name="val">quantity measured in YottaGram</param>
    /// <returns>quantity measured in DeciGram</returns>
	public static Quantity<double, DeciGram> ToDeciGram<T>(this BaseQuantity<T, YottaGram> val) where T:IConvertible {
        return new Quantity<double, DeciGram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaGram to CentiGram
    /// </summary>
    /// <param name="val">quantity measured in YottaGram</param>
    /// <returns>quantity measured in CentiGram</returns>
	public static Quantity<double, CentiGram> ToCentiGram<T>(this BaseQuantity<T, YottaGram> val) where T:IConvertible {
        return new Quantity<double, CentiGram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaGram to MilliGram
    /// </summary>
    /// <param name="val">quantity measured in YottaGram</param>
    /// <returns>quantity measured in MilliGram</returns>
	public static Quantity<double, MilliGram> ToMilliGram<T>(this BaseQuantity<T, YottaGram> val) where T:IConvertible {
        return new Quantity<double, MilliGram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaGram to MicroGram
    /// </summary>
    /// <param name="val">quantity measured in YottaGram</param>
    /// <returns>quantity measured in MicroGram</returns>
	public static Quantity<double, MicroGram> ToMicroGram<T>(this BaseQuantity<T, YottaGram> val) where T:IConvertible {
        return new Quantity<double, MicroGram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaGram to NanoGram
    /// </summary>
    /// <param name="val">quantity measured in YottaGram</param>
    /// <returns>quantity measured in NanoGram</returns>
	public static Quantity<double, NanoGram> ToNanoGram<T>(this BaseQuantity<T, YottaGram> val) where T:IConvertible {
        return new Quantity<double, NanoGram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaGram to PicoGram
    /// </summary>
    /// <param name="val">quantity measured in YottaGram</param>
    /// <returns>quantity measured in PicoGram</returns>
	public static Quantity<double, PicoGram> ToPicoGram<T>(this BaseQuantity<T, YottaGram> val) where T:IConvertible {
        return new Quantity<double, PicoGram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaGram to FemtoGram
    /// </summary>
    /// <param name="val">quantity measured in YottaGram</param>
    /// <returns>quantity measured in FemtoGram</returns>
	public static Quantity<double, FemtoGram> ToFemtoGram<T>(this BaseQuantity<T, YottaGram> val) where T:IConvertible {
        return new Quantity<double, FemtoGram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaGram to AttoGram
    /// </summary>
    /// <param name="val">quantity measured in YottaGram</param>
    /// <returns>quantity measured in AttoGram</returns>
	public static Quantity<double, AttoGram> ToAttoGram<T>(this BaseQuantity<T, YottaGram> val) where T:IConvertible {
        return new Quantity<double, AttoGram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaGram to ZeptoGram
    /// </summary>
    /// <param name="val">quantity measured in YottaGram</param>
    /// <returns>quantity measured in ZeptoGram</returns>
	public static Quantity<double, ZeptoGram> ToZeptoGram<T>(this BaseQuantity<T, YottaGram> val) where T:IConvertible {
        return new Quantity<double, ZeptoGram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaGram to YoctoGram
    /// </summary>
    /// <param name="val">quantity measured in YottaGram</param>
    /// <returns>quantity measured in YoctoGram</returns>
	public static Quantity<double, YoctoGram> ToYoctoGram<T>(this BaseQuantity<T, YottaGram> val) where T:IConvertible {
        return new Quantity<double, YoctoGram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert ZettaGram to YottaGram
    /// </summary>
    /// <param name="val">quantity measured in ZettaGram</param>
    /// <returns>quantity measured in YottaGram</returns>
	public static Quantity<double, YottaGram> ToYottaGram<T>(this BaseQuantity<T, ZettaGram> val) where T:IConvertible {
        return new Quantity<double, YottaGram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaGram to ExaGram
    /// </summary>
    /// <param name="val">quantity measured in ZettaGram</param>
    /// <returns>quantity measured in ExaGram</returns>
	public static Quantity<double, ExaGram> ToExaGram<T>(this BaseQuantity<T, ZettaGram> val) where T:IConvertible {
        return new Quantity<double, ExaGram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaGram to PetaGram
    /// </summary>
    /// <param name="val">quantity measured in ZettaGram</param>
    /// <returns>quantity measured in PetaGram</returns>
	public static Quantity<double, PetaGram> ToPetaGram<T>(this BaseQuantity<T, ZettaGram> val) where T:IConvertible {
        return new Quantity<double, PetaGram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaGram to TeraGram
    /// </summary>
    /// <param name="val">quantity measured in ZettaGram</param>
    /// <returns>quantity measured in TeraGram</returns>
	public static Quantity<double, TeraGram> ToTeraGram<T>(this BaseQuantity<T, ZettaGram> val) where T:IConvertible {
        return new Quantity<double, TeraGram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaGram to GigaGram
    /// </summary>
    /// <param name="val">quantity measured in ZettaGram</param>
    /// <returns>quantity measured in GigaGram</returns>
	public static Quantity<double, GigaGram> ToGigaGram<T>(this BaseQuantity<T, ZettaGram> val) where T:IConvertible {
        return new Quantity<double, GigaGram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaGram to MegaGram
    /// </summary>
    /// <param name="val">quantity measured in ZettaGram</param>
    /// <returns>quantity measured in MegaGram</returns>
	public static Quantity<double, MegaGram> ToMegaGram<T>(this BaseQuantity<T, ZettaGram> val) where T:IConvertible {
        return new Quantity<double, MegaGram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaGram to KiloGram
    /// </summary>
    /// <param name="val">quantity measured in ZettaGram</param>
    /// <returns>quantity measured in KiloGram</returns>
	public static Quantity<double, KiloGram> ToKiloGram<T>(this BaseQuantity<T, ZettaGram> val) where T:IConvertible {
        return new Quantity<double, KiloGram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaGram to HectoGram
    /// </summary>
    /// <param name="val">quantity measured in ZettaGram</param>
    /// <returns>quantity measured in HectoGram</returns>
	public static Quantity<double, HectoGram> ToHectoGram<T>(this BaseQuantity<T, ZettaGram> val) where T:IConvertible {
        return new Quantity<double, HectoGram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaGram to DekaGram
    /// </summary>
    /// <param name="val">quantity measured in ZettaGram</param>
    /// <returns>quantity measured in DekaGram</returns>
	public static Quantity<double, DekaGram> ToDekaGram<T>(this BaseQuantity<T, ZettaGram> val) where T:IConvertible {
        return new Quantity<double, DekaGram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaGram to DeciGram
    /// </summary>
    /// <param name="val">quantity measured in ZettaGram</param>
    /// <returns>quantity measured in DeciGram</returns>
	public static Quantity<double, DeciGram> ToDeciGram<T>(this BaseQuantity<T, ZettaGram> val) where T:IConvertible {
        return new Quantity<double, DeciGram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaGram to CentiGram
    /// </summary>
    /// <param name="val">quantity measured in ZettaGram</param>
    /// <returns>quantity measured in CentiGram</returns>
	public static Quantity<double, CentiGram> ToCentiGram<T>(this BaseQuantity<T, ZettaGram> val) where T:IConvertible {
        return new Quantity<double, CentiGram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaGram to MilliGram
    /// </summary>
    /// <param name="val">quantity measured in ZettaGram</param>
    /// <returns>quantity measured in MilliGram</returns>
	public static Quantity<double, MilliGram> ToMilliGram<T>(this BaseQuantity<T, ZettaGram> val) where T:IConvertible {
        return new Quantity<double, MilliGram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaGram to MicroGram
    /// </summary>
    /// <param name="val">quantity measured in ZettaGram</param>
    /// <returns>quantity measured in MicroGram</returns>
	public static Quantity<double, MicroGram> ToMicroGram<T>(this BaseQuantity<T, ZettaGram> val) where T:IConvertible {
        return new Quantity<double, MicroGram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaGram to NanoGram
    /// </summary>
    /// <param name="val">quantity measured in ZettaGram</param>
    /// <returns>quantity measured in NanoGram</returns>
	public static Quantity<double, NanoGram> ToNanoGram<T>(this BaseQuantity<T, ZettaGram> val) where T:IConvertible {
        return new Quantity<double, NanoGram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaGram to PicoGram
    /// </summary>
    /// <param name="val">quantity measured in ZettaGram</param>
    /// <returns>quantity measured in PicoGram</returns>
	public static Quantity<double, PicoGram> ToPicoGram<T>(this BaseQuantity<T, ZettaGram> val) where T:IConvertible {
        return new Quantity<double, PicoGram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaGram to FemtoGram
    /// </summary>
    /// <param name="val">quantity measured in ZettaGram</param>
    /// <returns>quantity measured in FemtoGram</returns>
	public static Quantity<double, FemtoGram> ToFemtoGram<T>(this BaseQuantity<T, ZettaGram> val) where T:IConvertible {
        return new Quantity<double, FemtoGram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaGram to AttoGram
    /// </summary>
    /// <param name="val">quantity measured in ZettaGram</param>
    /// <returns>quantity measured in AttoGram</returns>
	public static Quantity<double, AttoGram> ToAttoGram<T>(this BaseQuantity<T, ZettaGram> val) where T:IConvertible {
        return new Quantity<double, AttoGram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaGram to ZeptoGram
    /// </summary>
    /// <param name="val">quantity measured in ZettaGram</param>
    /// <returns>quantity measured in ZeptoGram</returns>
	public static Quantity<double, ZeptoGram> ToZeptoGram<T>(this BaseQuantity<T, ZettaGram> val) where T:IConvertible {
        return new Quantity<double, ZeptoGram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaGram to YoctoGram
    /// </summary>
    /// <param name="val">quantity measured in ZettaGram</param>
    /// <returns>quantity measured in YoctoGram</returns>
	public static Quantity<double, YoctoGram> ToYoctoGram<T>(this BaseQuantity<T, ZettaGram> val) where T:IConvertible {
        return new Quantity<double, YoctoGram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ExaGram to YottaGram
    /// </summary>
    /// <param name="val">quantity measured in ExaGram</param>
    /// <returns>quantity measured in YottaGram</returns>
	public static Quantity<double, YottaGram> ToYottaGram<T>(this BaseQuantity<T, ExaGram> val) where T:IConvertible {
        return new Quantity<double, YottaGram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaGram to ZettaGram
    /// </summary>
    /// <param name="val">quantity measured in ExaGram</param>
    /// <returns>quantity measured in ZettaGram</returns>
	public static Quantity<double, ZettaGram> ToZettaGram<T>(this BaseQuantity<T, ExaGram> val) where T:IConvertible {
        return new Quantity<double, ZettaGram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaGram to PetaGram
    /// </summary>
    /// <param name="val">quantity measured in ExaGram</param>
    /// <returns>quantity measured in PetaGram</returns>
	public static Quantity<double, PetaGram> ToPetaGram<T>(this BaseQuantity<T, ExaGram> val) where T:IConvertible {
        return new Quantity<double, PetaGram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaGram to TeraGram
    /// </summary>
    /// <param name="val">quantity measured in ExaGram</param>
    /// <returns>quantity measured in TeraGram</returns>
	public static Quantity<double, TeraGram> ToTeraGram<T>(this BaseQuantity<T, ExaGram> val) where T:IConvertible {
        return new Quantity<double, TeraGram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaGram to GigaGram
    /// </summary>
    /// <param name="val">quantity measured in ExaGram</param>
    /// <returns>quantity measured in GigaGram</returns>
	public static Quantity<double, GigaGram> ToGigaGram<T>(this BaseQuantity<T, ExaGram> val) where T:IConvertible {
        return new Quantity<double, GigaGram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaGram to MegaGram
    /// </summary>
    /// <param name="val">quantity measured in ExaGram</param>
    /// <returns>quantity measured in MegaGram</returns>
	public static Quantity<double, MegaGram> ToMegaGram<T>(this BaseQuantity<T, ExaGram> val) where T:IConvertible {
        return new Quantity<double, MegaGram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaGram to KiloGram
    /// </summary>
    /// <param name="val">quantity measured in ExaGram</param>
    /// <returns>quantity measured in KiloGram</returns>
	public static Quantity<double, KiloGram> ToKiloGram<T>(this BaseQuantity<T, ExaGram> val) where T:IConvertible {
        return new Quantity<double, KiloGram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaGram to HectoGram
    /// </summary>
    /// <param name="val">quantity measured in ExaGram</param>
    /// <returns>quantity measured in HectoGram</returns>
	public static Quantity<double, HectoGram> ToHectoGram<T>(this BaseQuantity<T, ExaGram> val) where T:IConvertible {
        return new Quantity<double, HectoGram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaGram to DekaGram
    /// </summary>
    /// <param name="val">quantity measured in ExaGram</param>
    /// <returns>quantity measured in DekaGram</returns>
	public static Quantity<double, DekaGram> ToDekaGram<T>(this BaseQuantity<T, ExaGram> val) where T:IConvertible {
        return new Quantity<double, DekaGram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaGram to DeciGram
    /// </summary>
    /// <param name="val">quantity measured in ExaGram</param>
    /// <returns>quantity measured in DeciGram</returns>
	public static Quantity<double, DeciGram> ToDeciGram<T>(this BaseQuantity<T, ExaGram> val) where T:IConvertible {
        return new Quantity<double, DeciGram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaGram to CentiGram
    /// </summary>
    /// <param name="val">quantity measured in ExaGram</param>
    /// <returns>quantity measured in CentiGram</returns>
	public static Quantity<double, CentiGram> ToCentiGram<T>(this BaseQuantity<T, ExaGram> val) where T:IConvertible {
        return new Quantity<double, CentiGram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaGram to MilliGram
    /// </summary>
    /// <param name="val">quantity measured in ExaGram</param>
    /// <returns>quantity measured in MilliGram</returns>
	public static Quantity<double, MilliGram> ToMilliGram<T>(this BaseQuantity<T, ExaGram> val) where T:IConvertible {
        return new Quantity<double, MilliGram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaGram to MicroGram
    /// </summary>
    /// <param name="val">quantity measured in ExaGram</param>
    /// <returns>quantity measured in MicroGram</returns>
	public static Quantity<double, MicroGram> ToMicroGram<T>(this BaseQuantity<T, ExaGram> val) where T:IConvertible {
        return new Quantity<double, MicroGram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaGram to NanoGram
    /// </summary>
    /// <param name="val">quantity measured in ExaGram</param>
    /// <returns>quantity measured in NanoGram</returns>
	public static Quantity<double, NanoGram> ToNanoGram<T>(this BaseQuantity<T, ExaGram> val) where T:IConvertible {
        return new Quantity<double, NanoGram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaGram to PicoGram
    /// </summary>
    /// <param name="val">quantity measured in ExaGram</param>
    /// <returns>quantity measured in PicoGram</returns>
	public static Quantity<double, PicoGram> ToPicoGram<T>(this BaseQuantity<T, ExaGram> val) where T:IConvertible {
        return new Quantity<double, PicoGram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaGram to FemtoGram
    /// </summary>
    /// <param name="val">quantity measured in ExaGram</param>
    /// <returns>quantity measured in FemtoGram</returns>
	public static Quantity<double, FemtoGram> ToFemtoGram<T>(this BaseQuantity<T, ExaGram> val) where T:IConvertible {
        return new Quantity<double, FemtoGram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaGram to AttoGram
    /// </summary>
    /// <param name="val">quantity measured in ExaGram</param>
    /// <returns>quantity measured in AttoGram</returns>
	public static Quantity<double, AttoGram> ToAttoGram<T>(this BaseQuantity<T, ExaGram> val) where T:IConvertible {
        return new Quantity<double, AttoGram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaGram to ZeptoGram
    /// </summary>
    /// <param name="val">quantity measured in ExaGram</param>
    /// <returns>quantity measured in ZeptoGram</returns>
	public static Quantity<double, ZeptoGram> ToZeptoGram<T>(this BaseQuantity<T, ExaGram> val) where T:IConvertible {
        return new Quantity<double, ZeptoGram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaGram to YoctoGram
    /// </summary>
    /// <param name="val">quantity measured in ExaGram</param>
    /// <returns>quantity measured in YoctoGram</returns>
	public static Quantity<double, YoctoGram> ToYoctoGram<T>(this BaseQuantity<T, ExaGram> val) where T:IConvertible {
        return new Quantity<double, YoctoGram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert PetaGram to YottaGram
    /// </summary>
    /// <param name="val">quantity measured in PetaGram</param>
    /// <returns>quantity measured in YottaGram</returns>
	public static Quantity<double, YottaGram> ToYottaGram<T>(this BaseQuantity<T, PetaGram> val) where T:IConvertible {
        return new Quantity<double, YottaGram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaGram to ZettaGram
    /// </summary>
    /// <param name="val">quantity measured in PetaGram</param>
    /// <returns>quantity measured in ZettaGram</returns>
	public static Quantity<double, ZettaGram> ToZettaGram<T>(this BaseQuantity<T, PetaGram> val) where T:IConvertible {
        return new Quantity<double, ZettaGram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaGram to ExaGram
    /// </summary>
    /// <param name="val">quantity measured in PetaGram</param>
    /// <returns>quantity measured in ExaGram</returns>
	public static Quantity<double, ExaGram> ToExaGram<T>(this BaseQuantity<T, PetaGram> val) where T:IConvertible {
        return new Quantity<double, ExaGram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaGram to TeraGram
    /// </summary>
    /// <param name="val">quantity measured in PetaGram</param>
    /// <returns>quantity measured in TeraGram</returns>
	public static Quantity<double, TeraGram> ToTeraGram<T>(this BaseQuantity<T, PetaGram> val) where T:IConvertible {
        return new Quantity<double, TeraGram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaGram to GigaGram
    /// </summary>
    /// <param name="val">quantity measured in PetaGram</param>
    /// <returns>quantity measured in GigaGram</returns>
	public static Quantity<double, GigaGram> ToGigaGram<T>(this BaseQuantity<T, PetaGram> val) where T:IConvertible {
        return new Quantity<double, GigaGram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaGram to MegaGram
    /// </summary>
    /// <param name="val">quantity measured in PetaGram</param>
    /// <returns>quantity measured in MegaGram</returns>
	public static Quantity<double, MegaGram> ToMegaGram<T>(this BaseQuantity<T, PetaGram> val) where T:IConvertible {
        return new Quantity<double, MegaGram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaGram to KiloGram
    /// </summary>
    /// <param name="val">quantity measured in PetaGram</param>
    /// <returns>quantity measured in KiloGram</returns>
	public static Quantity<double, KiloGram> ToKiloGram<T>(this BaseQuantity<T, PetaGram> val) where T:IConvertible {
        return new Quantity<double, KiloGram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaGram to HectoGram
    /// </summary>
    /// <param name="val">quantity measured in PetaGram</param>
    /// <returns>quantity measured in HectoGram</returns>
	public static Quantity<double, HectoGram> ToHectoGram<T>(this BaseQuantity<T, PetaGram> val) where T:IConvertible {
        return new Quantity<double, HectoGram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaGram to DekaGram
    /// </summary>
    /// <param name="val">quantity measured in PetaGram</param>
    /// <returns>quantity measured in DekaGram</returns>
	public static Quantity<double, DekaGram> ToDekaGram<T>(this BaseQuantity<T, PetaGram> val) where T:IConvertible {
        return new Quantity<double, DekaGram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaGram to DeciGram
    /// </summary>
    /// <param name="val">quantity measured in PetaGram</param>
    /// <returns>quantity measured in DeciGram</returns>
	public static Quantity<double, DeciGram> ToDeciGram<T>(this BaseQuantity<T, PetaGram> val) where T:IConvertible {
        return new Quantity<double, DeciGram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaGram to CentiGram
    /// </summary>
    /// <param name="val">quantity measured in PetaGram</param>
    /// <returns>quantity measured in CentiGram</returns>
	public static Quantity<double, CentiGram> ToCentiGram<T>(this BaseQuantity<T, PetaGram> val) where T:IConvertible {
        return new Quantity<double, CentiGram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaGram to MilliGram
    /// </summary>
    /// <param name="val">quantity measured in PetaGram</param>
    /// <returns>quantity measured in MilliGram</returns>
	public static Quantity<double, MilliGram> ToMilliGram<T>(this BaseQuantity<T, PetaGram> val) where T:IConvertible {
        return new Quantity<double, MilliGram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaGram to MicroGram
    /// </summary>
    /// <param name="val">quantity measured in PetaGram</param>
    /// <returns>quantity measured in MicroGram</returns>
	public static Quantity<double, MicroGram> ToMicroGram<T>(this BaseQuantity<T, PetaGram> val) where T:IConvertible {
        return new Quantity<double, MicroGram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaGram to NanoGram
    /// </summary>
    /// <param name="val">quantity measured in PetaGram</param>
    /// <returns>quantity measured in NanoGram</returns>
	public static Quantity<double, NanoGram> ToNanoGram<T>(this BaseQuantity<T, PetaGram> val) where T:IConvertible {
        return new Quantity<double, NanoGram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaGram to PicoGram
    /// </summary>
    /// <param name="val">quantity measured in PetaGram</param>
    /// <returns>quantity measured in PicoGram</returns>
	public static Quantity<double, PicoGram> ToPicoGram<T>(this BaseQuantity<T, PetaGram> val) where T:IConvertible {
        return new Quantity<double, PicoGram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaGram to FemtoGram
    /// </summary>
    /// <param name="val">quantity measured in PetaGram</param>
    /// <returns>quantity measured in FemtoGram</returns>
	public static Quantity<double, FemtoGram> ToFemtoGram<T>(this BaseQuantity<T, PetaGram> val) where T:IConvertible {
        return new Quantity<double, FemtoGram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaGram to AttoGram
    /// </summary>
    /// <param name="val">quantity measured in PetaGram</param>
    /// <returns>quantity measured in AttoGram</returns>
	public static Quantity<double, AttoGram> ToAttoGram<T>(this BaseQuantity<T, PetaGram> val) where T:IConvertible {
        return new Quantity<double, AttoGram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaGram to ZeptoGram
    /// </summary>
    /// <param name="val">quantity measured in PetaGram</param>
    /// <returns>quantity measured in ZeptoGram</returns>
	public static Quantity<double, ZeptoGram> ToZeptoGram<T>(this BaseQuantity<T, PetaGram> val) where T:IConvertible {
        return new Quantity<double, ZeptoGram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaGram to YoctoGram
    /// </summary>
    /// <param name="val">quantity measured in PetaGram</param>
    /// <returns>quantity measured in YoctoGram</returns>
	public static Quantity<double, YoctoGram> ToYoctoGram<T>(this BaseQuantity<T, PetaGram> val) where T:IConvertible {
        return new Quantity<double, YoctoGram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert TeraGram to YottaGram
    /// </summary>
    /// <param name="val">quantity measured in TeraGram</param>
    /// <returns>quantity measured in YottaGram</returns>
	public static Quantity<double, YottaGram> ToYottaGram<T>(this BaseQuantity<T, TeraGram> val) where T:IConvertible {
        return new Quantity<double, YottaGram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraGram to ZettaGram
    /// </summary>
    /// <param name="val">quantity measured in TeraGram</param>
    /// <returns>quantity measured in ZettaGram</returns>
	public static Quantity<double, ZettaGram> ToZettaGram<T>(this BaseQuantity<T, TeraGram> val) where T:IConvertible {
        return new Quantity<double, ZettaGram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraGram to ExaGram
    /// </summary>
    /// <param name="val">quantity measured in TeraGram</param>
    /// <returns>quantity measured in ExaGram</returns>
	public static Quantity<double, ExaGram> ToExaGram<T>(this BaseQuantity<T, TeraGram> val) where T:IConvertible {
        return new Quantity<double, ExaGram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraGram to PetaGram
    /// </summary>
    /// <param name="val">quantity measured in TeraGram</param>
    /// <returns>quantity measured in PetaGram</returns>
	public static Quantity<double, PetaGram> ToPetaGram<T>(this BaseQuantity<T, TeraGram> val) where T:IConvertible {
        return new Quantity<double, PetaGram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraGram to GigaGram
    /// </summary>
    /// <param name="val">quantity measured in TeraGram</param>
    /// <returns>quantity measured in GigaGram</returns>
	public static Quantity<double, GigaGram> ToGigaGram<T>(this BaseQuantity<T, TeraGram> val) where T:IConvertible {
        return new Quantity<double, GigaGram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraGram to MegaGram
    /// </summary>
    /// <param name="val">quantity measured in TeraGram</param>
    /// <returns>quantity measured in MegaGram</returns>
	public static Quantity<double, MegaGram> ToMegaGram<T>(this BaseQuantity<T, TeraGram> val) where T:IConvertible {
        return new Quantity<double, MegaGram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraGram to KiloGram
    /// </summary>
    /// <param name="val">quantity measured in TeraGram</param>
    /// <returns>quantity measured in KiloGram</returns>
	public static Quantity<double, KiloGram> ToKiloGram<T>(this BaseQuantity<T, TeraGram> val) where T:IConvertible {
        return new Quantity<double, KiloGram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraGram to HectoGram
    /// </summary>
    /// <param name="val">quantity measured in TeraGram</param>
    /// <returns>quantity measured in HectoGram</returns>
	public static Quantity<double, HectoGram> ToHectoGram<T>(this BaseQuantity<T, TeraGram> val) where T:IConvertible {
        return new Quantity<double, HectoGram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraGram to DekaGram
    /// </summary>
    /// <param name="val">quantity measured in TeraGram</param>
    /// <returns>quantity measured in DekaGram</returns>
	public static Quantity<double, DekaGram> ToDekaGram<T>(this BaseQuantity<T, TeraGram> val) where T:IConvertible {
        return new Quantity<double, DekaGram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraGram to DeciGram
    /// </summary>
    /// <param name="val">quantity measured in TeraGram</param>
    /// <returns>quantity measured in DeciGram</returns>
	public static Quantity<double, DeciGram> ToDeciGram<T>(this BaseQuantity<T, TeraGram> val) where T:IConvertible {
        return new Quantity<double, DeciGram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraGram to CentiGram
    /// </summary>
    /// <param name="val">quantity measured in TeraGram</param>
    /// <returns>quantity measured in CentiGram</returns>
	public static Quantity<double, CentiGram> ToCentiGram<T>(this BaseQuantity<T, TeraGram> val) where T:IConvertible {
        return new Quantity<double, CentiGram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraGram to MilliGram
    /// </summary>
    /// <param name="val">quantity measured in TeraGram</param>
    /// <returns>quantity measured in MilliGram</returns>
	public static Quantity<double, MilliGram> ToMilliGram<T>(this BaseQuantity<T, TeraGram> val) where T:IConvertible {
        return new Quantity<double, MilliGram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraGram to MicroGram
    /// </summary>
    /// <param name="val">quantity measured in TeraGram</param>
    /// <returns>quantity measured in MicroGram</returns>
	public static Quantity<double, MicroGram> ToMicroGram<T>(this BaseQuantity<T, TeraGram> val) where T:IConvertible {
        return new Quantity<double, MicroGram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraGram to NanoGram
    /// </summary>
    /// <param name="val">quantity measured in TeraGram</param>
    /// <returns>quantity measured in NanoGram</returns>
	public static Quantity<double, NanoGram> ToNanoGram<T>(this BaseQuantity<T, TeraGram> val) where T:IConvertible {
        return new Quantity<double, NanoGram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraGram to PicoGram
    /// </summary>
    /// <param name="val">quantity measured in TeraGram</param>
    /// <returns>quantity measured in PicoGram</returns>
	public static Quantity<double, PicoGram> ToPicoGram<T>(this BaseQuantity<T, TeraGram> val) where T:IConvertible {
        return new Quantity<double, PicoGram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraGram to FemtoGram
    /// </summary>
    /// <param name="val">quantity measured in TeraGram</param>
    /// <returns>quantity measured in FemtoGram</returns>
	public static Quantity<double, FemtoGram> ToFemtoGram<T>(this BaseQuantity<T, TeraGram> val) where T:IConvertible {
        return new Quantity<double, FemtoGram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraGram to AttoGram
    /// </summary>
    /// <param name="val">quantity measured in TeraGram</param>
    /// <returns>quantity measured in AttoGram</returns>
	public static Quantity<double, AttoGram> ToAttoGram<T>(this BaseQuantity<T, TeraGram> val) where T:IConvertible {
        return new Quantity<double, AttoGram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraGram to ZeptoGram
    /// </summary>
    /// <param name="val">quantity measured in TeraGram</param>
    /// <returns>quantity measured in ZeptoGram</returns>
	public static Quantity<double, ZeptoGram> ToZeptoGram<T>(this BaseQuantity<T, TeraGram> val) where T:IConvertible {
        return new Quantity<double, ZeptoGram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraGram to YoctoGram
    /// </summary>
    /// <param name="val">quantity measured in TeraGram</param>
    /// <returns>quantity measured in YoctoGram</returns>
	public static Quantity<double, YoctoGram> ToYoctoGram<T>(this BaseQuantity<T, TeraGram> val) where T:IConvertible {
        return new Quantity<double, YoctoGram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert GigaGram to YottaGram
    /// </summary>
    /// <param name="val">quantity measured in GigaGram</param>
    /// <returns>quantity measured in YottaGram</returns>
	public static Quantity<double, YottaGram> ToYottaGram<T>(this BaseQuantity<T, GigaGram> val) where T:IConvertible {
        return new Quantity<double, YottaGram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaGram to ZettaGram
    /// </summary>
    /// <param name="val">quantity measured in GigaGram</param>
    /// <returns>quantity measured in ZettaGram</returns>
	public static Quantity<double, ZettaGram> ToZettaGram<T>(this BaseQuantity<T, GigaGram> val) where T:IConvertible {
        return new Quantity<double, ZettaGram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaGram to ExaGram
    /// </summary>
    /// <param name="val">quantity measured in GigaGram</param>
    /// <returns>quantity measured in ExaGram</returns>
	public static Quantity<double, ExaGram> ToExaGram<T>(this BaseQuantity<T, GigaGram> val) where T:IConvertible {
        return new Quantity<double, ExaGram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaGram to PetaGram
    /// </summary>
    /// <param name="val">quantity measured in GigaGram</param>
    /// <returns>quantity measured in PetaGram</returns>
	public static Quantity<double, PetaGram> ToPetaGram<T>(this BaseQuantity<T, GigaGram> val) where T:IConvertible {
        return new Quantity<double, PetaGram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaGram to TeraGram
    /// </summary>
    /// <param name="val">quantity measured in GigaGram</param>
    /// <returns>quantity measured in TeraGram</returns>
	public static Quantity<double, TeraGram> ToTeraGram<T>(this BaseQuantity<T, GigaGram> val) where T:IConvertible {
        return new Quantity<double, TeraGram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaGram to MegaGram
    /// </summary>
    /// <param name="val">quantity measured in GigaGram</param>
    /// <returns>quantity measured in MegaGram</returns>
	public static Quantity<double, MegaGram> ToMegaGram<T>(this BaseQuantity<T, GigaGram> val) where T:IConvertible {
        return new Quantity<double, MegaGram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaGram to KiloGram
    /// </summary>
    /// <param name="val">quantity measured in GigaGram</param>
    /// <returns>quantity measured in KiloGram</returns>
	public static Quantity<double, KiloGram> ToKiloGram<T>(this BaseQuantity<T, GigaGram> val) where T:IConvertible {
        return new Quantity<double, KiloGram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaGram to HectoGram
    /// </summary>
    /// <param name="val">quantity measured in GigaGram</param>
    /// <returns>quantity measured in HectoGram</returns>
	public static Quantity<double, HectoGram> ToHectoGram<T>(this BaseQuantity<T, GigaGram> val) where T:IConvertible {
        return new Quantity<double, HectoGram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaGram to DekaGram
    /// </summary>
    /// <param name="val">quantity measured in GigaGram</param>
    /// <returns>quantity measured in DekaGram</returns>
	public static Quantity<double, DekaGram> ToDekaGram<T>(this BaseQuantity<T, GigaGram> val) where T:IConvertible {
        return new Quantity<double, DekaGram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaGram to DeciGram
    /// </summary>
    /// <param name="val">quantity measured in GigaGram</param>
    /// <returns>quantity measured in DeciGram</returns>
	public static Quantity<double, DeciGram> ToDeciGram<T>(this BaseQuantity<T, GigaGram> val) where T:IConvertible {
        return new Quantity<double, DeciGram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaGram to CentiGram
    /// </summary>
    /// <param name="val">quantity measured in GigaGram</param>
    /// <returns>quantity measured in CentiGram</returns>
	public static Quantity<double, CentiGram> ToCentiGram<T>(this BaseQuantity<T, GigaGram> val) where T:IConvertible {
        return new Quantity<double, CentiGram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaGram to MilliGram
    /// </summary>
    /// <param name="val">quantity measured in GigaGram</param>
    /// <returns>quantity measured in MilliGram</returns>
	public static Quantity<double, MilliGram> ToMilliGram<T>(this BaseQuantity<T, GigaGram> val) where T:IConvertible {
        return new Quantity<double, MilliGram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaGram to MicroGram
    /// </summary>
    /// <param name="val">quantity measured in GigaGram</param>
    /// <returns>quantity measured in MicroGram</returns>
	public static Quantity<double, MicroGram> ToMicroGram<T>(this BaseQuantity<T, GigaGram> val) where T:IConvertible {
        return new Quantity<double, MicroGram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaGram to NanoGram
    /// </summary>
    /// <param name="val">quantity measured in GigaGram</param>
    /// <returns>quantity measured in NanoGram</returns>
	public static Quantity<double, NanoGram> ToNanoGram<T>(this BaseQuantity<T, GigaGram> val) where T:IConvertible {
        return new Quantity<double, NanoGram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaGram to PicoGram
    /// </summary>
    /// <param name="val">quantity measured in GigaGram</param>
    /// <returns>quantity measured in PicoGram</returns>
	public static Quantity<double, PicoGram> ToPicoGram<T>(this BaseQuantity<T, GigaGram> val) where T:IConvertible {
        return new Quantity<double, PicoGram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaGram to FemtoGram
    /// </summary>
    /// <param name="val">quantity measured in GigaGram</param>
    /// <returns>quantity measured in FemtoGram</returns>
	public static Quantity<double, FemtoGram> ToFemtoGram<T>(this BaseQuantity<T, GigaGram> val) where T:IConvertible {
        return new Quantity<double, FemtoGram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaGram to AttoGram
    /// </summary>
    /// <param name="val">quantity measured in GigaGram</param>
    /// <returns>quantity measured in AttoGram</returns>
	public static Quantity<double, AttoGram> ToAttoGram<T>(this BaseQuantity<T, GigaGram> val) where T:IConvertible {
        return new Quantity<double, AttoGram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaGram to ZeptoGram
    /// </summary>
    /// <param name="val">quantity measured in GigaGram</param>
    /// <returns>quantity measured in ZeptoGram</returns>
	public static Quantity<double, ZeptoGram> ToZeptoGram<T>(this BaseQuantity<T, GigaGram> val) where T:IConvertible {
        return new Quantity<double, ZeptoGram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaGram to YoctoGram
    /// </summary>
    /// <param name="val">quantity measured in GigaGram</param>
    /// <returns>quantity measured in YoctoGram</returns>
	public static Quantity<double, YoctoGram> ToYoctoGram<T>(this BaseQuantity<T, GigaGram> val) where T:IConvertible {
        return new Quantity<double, YoctoGram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert MegaGram to YottaGram
    /// </summary>
    /// <param name="val">quantity measured in MegaGram</param>
    /// <returns>quantity measured in YottaGram</returns>
	public static Quantity<double, YottaGram> ToYottaGram<T>(this BaseQuantity<T, MegaGram> val) where T:IConvertible {
        return new Quantity<double, YottaGram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaGram to ZettaGram
    /// </summary>
    /// <param name="val">quantity measured in MegaGram</param>
    /// <returns>quantity measured in ZettaGram</returns>
	public static Quantity<double, ZettaGram> ToZettaGram<T>(this BaseQuantity<T, MegaGram> val) where T:IConvertible {
        return new Quantity<double, ZettaGram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaGram to ExaGram
    /// </summary>
    /// <param name="val">quantity measured in MegaGram</param>
    /// <returns>quantity measured in ExaGram</returns>
	public static Quantity<double, ExaGram> ToExaGram<T>(this BaseQuantity<T, MegaGram> val) where T:IConvertible {
        return new Quantity<double, ExaGram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaGram to PetaGram
    /// </summary>
    /// <param name="val">quantity measured in MegaGram</param>
    /// <returns>quantity measured in PetaGram</returns>
	public static Quantity<double, PetaGram> ToPetaGram<T>(this BaseQuantity<T, MegaGram> val) where T:IConvertible {
        return new Quantity<double, PetaGram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaGram to TeraGram
    /// </summary>
    /// <param name="val">quantity measured in MegaGram</param>
    /// <returns>quantity measured in TeraGram</returns>
	public static Quantity<double, TeraGram> ToTeraGram<T>(this BaseQuantity<T, MegaGram> val) where T:IConvertible {
        return new Quantity<double, TeraGram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaGram to GigaGram
    /// </summary>
    /// <param name="val">quantity measured in MegaGram</param>
    /// <returns>quantity measured in GigaGram</returns>
	public static Quantity<double, GigaGram> ToGigaGram<T>(this BaseQuantity<T, MegaGram> val) where T:IConvertible {
        return new Quantity<double, GigaGram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaGram to KiloGram
    /// </summary>
    /// <param name="val">quantity measured in MegaGram</param>
    /// <returns>quantity measured in KiloGram</returns>
	public static Quantity<double, KiloGram> ToKiloGram<T>(this BaseQuantity<T, MegaGram> val) where T:IConvertible {
        return new Quantity<double, KiloGram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaGram to HectoGram
    /// </summary>
    /// <param name="val">quantity measured in MegaGram</param>
    /// <returns>quantity measured in HectoGram</returns>
	public static Quantity<double, HectoGram> ToHectoGram<T>(this BaseQuantity<T, MegaGram> val) where T:IConvertible {
        return new Quantity<double, HectoGram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaGram to DekaGram
    /// </summary>
    /// <param name="val">quantity measured in MegaGram</param>
    /// <returns>quantity measured in DekaGram</returns>
	public static Quantity<double, DekaGram> ToDekaGram<T>(this BaseQuantity<T, MegaGram> val) where T:IConvertible {
        return new Quantity<double, DekaGram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaGram to DeciGram
    /// </summary>
    /// <param name="val">quantity measured in MegaGram</param>
    /// <returns>quantity measured in DeciGram</returns>
	public static Quantity<double, DeciGram> ToDeciGram<T>(this BaseQuantity<T, MegaGram> val) where T:IConvertible {
        return new Quantity<double, DeciGram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaGram to CentiGram
    /// </summary>
    /// <param name="val">quantity measured in MegaGram</param>
    /// <returns>quantity measured in CentiGram</returns>
	public static Quantity<double, CentiGram> ToCentiGram<T>(this BaseQuantity<T, MegaGram> val) where T:IConvertible {
        return new Quantity<double, CentiGram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaGram to MilliGram
    /// </summary>
    /// <param name="val">quantity measured in MegaGram</param>
    /// <returns>quantity measured in MilliGram</returns>
	public static Quantity<double, MilliGram> ToMilliGram<T>(this BaseQuantity<T, MegaGram> val) where T:IConvertible {
        return new Quantity<double, MilliGram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaGram to MicroGram
    /// </summary>
    /// <param name="val">quantity measured in MegaGram</param>
    /// <returns>quantity measured in MicroGram</returns>
	public static Quantity<double, MicroGram> ToMicroGram<T>(this BaseQuantity<T, MegaGram> val) where T:IConvertible {
        return new Quantity<double, MicroGram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaGram to NanoGram
    /// </summary>
    /// <param name="val">quantity measured in MegaGram</param>
    /// <returns>quantity measured in NanoGram</returns>
	public static Quantity<double, NanoGram> ToNanoGram<T>(this BaseQuantity<T, MegaGram> val) where T:IConvertible {
        return new Quantity<double, NanoGram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaGram to PicoGram
    /// </summary>
    /// <param name="val">quantity measured in MegaGram</param>
    /// <returns>quantity measured in PicoGram</returns>
	public static Quantity<double, PicoGram> ToPicoGram<T>(this BaseQuantity<T, MegaGram> val) where T:IConvertible {
        return new Quantity<double, PicoGram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaGram to FemtoGram
    /// </summary>
    /// <param name="val">quantity measured in MegaGram</param>
    /// <returns>quantity measured in FemtoGram</returns>
	public static Quantity<double, FemtoGram> ToFemtoGram<T>(this BaseQuantity<T, MegaGram> val) where T:IConvertible {
        return new Quantity<double, FemtoGram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaGram to AttoGram
    /// </summary>
    /// <param name="val">quantity measured in MegaGram</param>
    /// <returns>quantity measured in AttoGram</returns>
	public static Quantity<double, AttoGram> ToAttoGram<T>(this BaseQuantity<T, MegaGram> val) where T:IConvertible {
        return new Quantity<double, AttoGram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaGram to ZeptoGram
    /// </summary>
    /// <param name="val">quantity measured in MegaGram</param>
    /// <returns>quantity measured in ZeptoGram</returns>
	public static Quantity<double, ZeptoGram> ToZeptoGram<T>(this BaseQuantity<T, MegaGram> val) where T:IConvertible {
        return new Quantity<double, ZeptoGram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaGram to YoctoGram
    /// </summary>
    /// <param name="val">quantity measured in MegaGram</param>
    /// <returns>quantity measured in YoctoGram</returns>
	public static Quantity<double, YoctoGram> ToYoctoGram<T>(this BaseQuantity<T, MegaGram> val) where T:IConvertible {
        return new Quantity<double, YoctoGram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert KiloGram to YottaGram
    /// </summary>
    /// <param name="val">quantity measured in KiloGram</param>
    /// <returns>quantity measured in YottaGram</returns>
	public static Quantity<double, YottaGram> ToYottaGram<T>(this BaseQuantity<T, KiloGram> val) where T:IConvertible {
        return new Quantity<double, YottaGram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloGram to ZettaGram
    /// </summary>
    /// <param name="val">quantity measured in KiloGram</param>
    /// <returns>quantity measured in ZettaGram</returns>
	public static Quantity<double, ZettaGram> ToZettaGram<T>(this BaseQuantity<T, KiloGram> val) where T:IConvertible {
        return new Quantity<double, ZettaGram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloGram to ExaGram
    /// </summary>
    /// <param name="val">quantity measured in KiloGram</param>
    /// <returns>quantity measured in ExaGram</returns>
	public static Quantity<double, ExaGram> ToExaGram<T>(this BaseQuantity<T, KiloGram> val) where T:IConvertible {
        return new Quantity<double, ExaGram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloGram to PetaGram
    /// </summary>
    /// <param name="val">quantity measured in KiloGram</param>
    /// <returns>quantity measured in PetaGram</returns>
	public static Quantity<double, PetaGram> ToPetaGram<T>(this BaseQuantity<T, KiloGram> val) where T:IConvertible {
        return new Quantity<double, PetaGram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloGram to TeraGram
    /// </summary>
    /// <param name="val">quantity measured in KiloGram</param>
    /// <returns>quantity measured in TeraGram</returns>
	public static Quantity<double, TeraGram> ToTeraGram<T>(this BaseQuantity<T, KiloGram> val) where T:IConvertible {
        return new Quantity<double, TeraGram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloGram to GigaGram
    /// </summary>
    /// <param name="val">quantity measured in KiloGram</param>
    /// <returns>quantity measured in GigaGram</returns>
	public static Quantity<double, GigaGram> ToGigaGram<T>(this BaseQuantity<T, KiloGram> val) where T:IConvertible {
        return new Quantity<double, GigaGram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloGram to MegaGram
    /// </summary>
    /// <param name="val">quantity measured in KiloGram</param>
    /// <returns>quantity measured in MegaGram</returns>
	public static Quantity<double, MegaGram> ToMegaGram<T>(this BaseQuantity<T, KiloGram> val) where T:IConvertible {
        return new Quantity<double, MegaGram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloGram to HectoGram
    /// </summary>
    /// <param name="val">quantity measured in KiloGram</param>
    /// <returns>quantity measured in HectoGram</returns>
	public static Quantity<double, HectoGram> ToHectoGram<T>(this BaseQuantity<T, KiloGram> val) where T:IConvertible {
        return new Quantity<double, HectoGram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloGram to DekaGram
    /// </summary>
    /// <param name="val">quantity measured in KiloGram</param>
    /// <returns>quantity measured in DekaGram</returns>
	public static Quantity<double, DekaGram> ToDekaGram<T>(this BaseQuantity<T, KiloGram> val) where T:IConvertible {
        return new Quantity<double, DekaGram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloGram to DeciGram
    /// </summary>
    /// <param name="val">quantity measured in KiloGram</param>
    /// <returns>quantity measured in DeciGram</returns>
	public static Quantity<double, DeciGram> ToDeciGram<T>(this BaseQuantity<T, KiloGram> val) where T:IConvertible {
        return new Quantity<double, DeciGram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloGram to CentiGram
    /// </summary>
    /// <param name="val">quantity measured in KiloGram</param>
    /// <returns>quantity measured in CentiGram</returns>
	public static Quantity<double, CentiGram> ToCentiGram<T>(this BaseQuantity<T, KiloGram> val) where T:IConvertible {
        return new Quantity<double, CentiGram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloGram to MilliGram
    /// </summary>
    /// <param name="val">quantity measured in KiloGram</param>
    /// <returns>quantity measured in MilliGram</returns>
	public static Quantity<double, MilliGram> ToMilliGram<T>(this BaseQuantity<T, KiloGram> val) where T:IConvertible {
        return new Quantity<double, MilliGram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloGram to MicroGram
    /// </summary>
    /// <param name="val">quantity measured in KiloGram</param>
    /// <returns>quantity measured in MicroGram</returns>
	public static Quantity<double, MicroGram> ToMicroGram<T>(this BaseQuantity<T, KiloGram> val) where T:IConvertible {
        return new Quantity<double, MicroGram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloGram to NanoGram
    /// </summary>
    /// <param name="val">quantity measured in KiloGram</param>
    /// <returns>quantity measured in NanoGram</returns>
	public static Quantity<double, NanoGram> ToNanoGram<T>(this BaseQuantity<T, KiloGram> val) where T:IConvertible {
        return new Quantity<double, NanoGram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloGram to PicoGram
    /// </summary>
    /// <param name="val">quantity measured in KiloGram</param>
    /// <returns>quantity measured in PicoGram</returns>
	public static Quantity<double, PicoGram> ToPicoGram<T>(this BaseQuantity<T, KiloGram> val) where T:IConvertible {
        return new Quantity<double, PicoGram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloGram to FemtoGram
    /// </summary>
    /// <param name="val">quantity measured in KiloGram</param>
    /// <returns>quantity measured in FemtoGram</returns>
	public static Quantity<double, FemtoGram> ToFemtoGram<T>(this BaseQuantity<T, KiloGram> val) where T:IConvertible {
        return new Quantity<double, FemtoGram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloGram to AttoGram
    /// </summary>
    /// <param name="val">quantity measured in KiloGram</param>
    /// <returns>quantity measured in AttoGram</returns>
	public static Quantity<double, AttoGram> ToAttoGram<T>(this BaseQuantity<T, KiloGram> val) where T:IConvertible {
        return new Quantity<double, AttoGram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloGram to ZeptoGram
    /// </summary>
    /// <param name="val">quantity measured in KiloGram</param>
    /// <returns>quantity measured in ZeptoGram</returns>
	public static Quantity<double, ZeptoGram> ToZeptoGram<T>(this BaseQuantity<T, KiloGram> val) where T:IConvertible {
        return new Quantity<double, ZeptoGram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloGram to YoctoGram
    /// </summary>
    /// <param name="val">quantity measured in KiloGram</param>
    /// <returns>quantity measured in YoctoGram</returns>
	public static Quantity<double, YoctoGram> ToYoctoGram<T>(this BaseQuantity<T, KiloGram> val) where T:IConvertible {
        return new Quantity<double, YoctoGram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert HectoGram to YottaGram
    /// </summary>
    /// <param name="val">quantity measured in HectoGram</param>
    /// <returns>quantity measured in YottaGram</returns>
	public static Quantity<double, YottaGram> ToYottaGram<T>(this BaseQuantity<T, HectoGram> val) where T:IConvertible {
        return new Quantity<double, YottaGram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoGram to ZettaGram
    /// </summary>
    /// <param name="val">quantity measured in HectoGram</param>
    /// <returns>quantity measured in ZettaGram</returns>
	public static Quantity<double, ZettaGram> ToZettaGram<T>(this BaseQuantity<T, HectoGram> val) where T:IConvertible {
        return new Quantity<double, ZettaGram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoGram to ExaGram
    /// </summary>
    /// <param name="val">quantity measured in HectoGram</param>
    /// <returns>quantity measured in ExaGram</returns>
	public static Quantity<double, ExaGram> ToExaGram<T>(this BaseQuantity<T, HectoGram> val) where T:IConvertible {
        return new Quantity<double, ExaGram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoGram to PetaGram
    /// </summary>
    /// <param name="val">quantity measured in HectoGram</param>
    /// <returns>quantity measured in PetaGram</returns>
	public static Quantity<double, PetaGram> ToPetaGram<T>(this BaseQuantity<T, HectoGram> val) where T:IConvertible {
        return new Quantity<double, PetaGram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoGram to TeraGram
    /// </summary>
    /// <param name="val">quantity measured in HectoGram</param>
    /// <returns>quantity measured in TeraGram</returns>
	public static Quantity<double, TeraGram> ToTeraGram<T>(this BaseQuantity<T, HectoGram> val) where T:IConvertible {
        return new Quantity<double, TeraGram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoGram to GigaGram
    /// </summary>
    /// <param name="val">quantity measured in HectoGram</param>
    /// <returns>quantity measured in GigaGram</returns>
	public static Quantity<double, GigaGram> ToGigaGram<T>(this BaseQuantity<T, HectoGram> val) where T:IConvertible {
        return new Quantity<double, GigaGram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoGram to MegaGram
    /// </summary>
    /// <param name="val">quantity measured in HectoGram</param>
    /// <returns>quantity measured in MegaGram</returns>
	public static Quantity<double, MegaGram> ToMegaGram<T>(this BaseQuantity<T, HectoGram> val) where T:IConvertible {
        return new Quantity<double, MegaGram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoGram to KiloGram
    /// </summary>
    /// <param name="val">quantity measured in HectoGram</param>
    /// <returns>quantity measured in KiloGram</returns>
	public static Quantity<double, KiloGram> ToKiloGram<T>(this BaseQuantity<T, HectoGram> val) where T:IConvertible {
        return new Quantity<double, KiloGram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoGram to DekaGram
    /// </summary>
    /// <param name="val">quantity measured in HectoGram</param>
    /// <returns>quantity measured in DekaGram</returns>
	public static Quantity<double, DekaGram> ToDekaGram<T>(this BaseQuantity<T, HectoGram> val) where T:IConvertible {
        return new Quantity<double, DekaGram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoGram to DeciGram
    /// </summary>
    /// <param name="val">quantity measured in HectoGram</param>
    /// <returns>quantity measured in DeciGram</returns>
	public static Quantity<double, DeciGram> ToDeciGram<T>(this BaseQuantity<T, HectoGram> val) where T:IConvertible {
        return new Quantity<double, DeciGram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoGram to CentiGram
    /// </summary>
    /// <param name="val">quantity measured in HectoGram</param>
    /// <returns>quantity measured in CentiGram</returns>
	public static Quantity<double, CentiGram> ToCentiGram<T>(this BaseQuantity<T, HectoGram> val) where T:IConvertible {
        return new Quantity<double, CentiGram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoGram to MilliGram
    /// </summary>
    /// <param name="val">quantity measured in HectoGram</param>
    /// <returns>quantity measured in MilliGram</returns>
	public static Quantity<double, MilliGram> ToMilliGram<T>(this BaseQuantity<T, HectoGram> val) where T:IConvertible {
        return new Quantity<double, MilliGram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoGram to MicroGram
    /// </summary>
    /// <param name="val">quantity measured in HectoGram</param>
    /// <returns>quantity measured in MicroGram</returns>
	public static Quantity<double, MicroGram> ToMicroGram<T>(this BaseQuantity<T, HectoGram> val) where T:IConvertible {
        return new Quantity<double, MicroGram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoGram to NanoGram
    /// </summary>
    /// <param name="val">quantity measured in HectoGram</param>
    /// <returns>quantity measured in NanoGram</returns>
	public static Quantity<double, NanoGram> ToNanoGram<T>(this BaseQuantity<T, HectoGram> val) where T:IConvertible {
        return new Quantity<double, NanoGram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoGram to PicoGram
    /// </summary>
    /// <param name="val">quantity measured in HectoGram</param>
    /// <returns>quantity measured in PicoGram</returns>
	public static Quantity<double, PicoGram> ToPicoGram<T>(this BaseQuantity<T, HectoGram> val) where T:IConvertible {
        return new Quantity<double, PicoGram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoGram to FemtoGram
    /// </summary>
    /// <param name="val">quantity measured in HectoGram</param>
    /// <returns>quantity measured in FemtoGram</returns>
	public static Quantity<double, FemtoGram> ToFemtoGram<T>(this BaseQuantity<T, HectoGram> val) where T:IConvertible {
        return new Quantity<double, FemtoGram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoGram to AttoGram
    /// </summary>
    /// <param name="val">quantity measured in HectoGram</param>
    /// <returns>quantity measured in AttoGram</returns>
	public static Quantity<double, AttoGram> ToAttoGram<T>(this BaseQuantity<T, HectoGram> val) where T:IConvertible {
        return new Quantity<double, AttoGram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoGram to ZeptoGram
    /// </summary>
    /// <param name="val">quantity measured in HectoGram</param>
    /// <returns>quantity measured in ZeptoGram</returns>
	public static Quantity<double, ZeptoGram> ToZeptoGram<T>(this BaseQuantity<T, HectoGram> val) where T:IConvertible {
        return new Quantity<double, ZeptoGram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoGram to YoctoGram
    /// </summary>
    /// <param name="val">quantity measured in HectoGram</param>
    /// <returns>quantity measured in YoctoGram</returns>
	public static Quantity<double, YoctoGram> ToYoctoGram<T>(this BaseQuantity<T, HectoGram> val) where T:IConvertible {
        return new Quantity<double, YoctoGram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert DekaGram to YottaGram
    /// </summary>
    /// <param name="val">quantity measured in DekaGram</param>
    /// <returns>quantity measured in YottaGram</returns>
	public static Quantity<double, YottaGram> ToYottaGram<T>(this BaseQuantity<T, DekaGram> val) where T:IConvertible {
        return new Quantity<double, YottaGram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaGram to ZettaGram
    /// </summary>
    /// <param name="val">quantity measured in DekaGram</param>
    /// <returns>quantity measured in ZettaGram</returns>
	public static Quantity<double, ZettaGram> ToZettaGram<T>(this BaseQuantity<T, DekaGram> val) where T:IConvertible {
        return new Quantity<double, ZettaGram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaGram to ExaGram
    /// </summary>
    /// <param name="val">quantity measured in DekaGram</param>
    /// <returns>quantity measured in ExaGram</returns>
	public static Quantity<double, ExaGram> ToExaGram<T>(this BaseQuantity<T, DekaGram> val) where T:IConvertible {
        return new Quantity<double, ExaGram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaGram to PetaGram
    /// </summary>
    /// <param name="val">quantity measured in DekaGram</param>
    /// <returns>quantity measured in PetaGram</returns>
	public static Quantity<double, PetaGram> ToPetaGram<T>(this BaseQuantity<T, DekaGram> val) where T:IConvertible {
        return new Quantity<double, PetaGram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaGram to TeraGram
    /// </summary>
    /// <param name="val">quantity measured in DekaGram</param>
    /// <returns>quantity measured in TeraGram</returns>
	public static Quantity<double, TeraGram> ToTeraGram<T>(this BaseQuantity<T, DekaGram> val) where T:IConvertible {
        return new Quantity<double, TeraGram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaGram to GigaGram
    /// </summary>
    /// <param name="val">quantity measured in DekaGram</param>
    /// <returns>quantity measured in GigaGram</returns>
	public static Quantity<double, GigaGram> ToGigaGram<T>(this BaseQuantity<T, DekaGram> val) where T:IConvertible {
        return new Quantity<double, GigaGram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaGram to MegaGram
    /// </summary>
    /// <param name="val">quantity measured in DekaGram</param>
    /// <returns>quantity measured in MegaGram</returns>
	public static Quantity<double, MegaGram> ToMegaGram<T>(this BaseQuantity<T, DekaGram> val) where T:IConvertible {
        return new Quantity<double, MegaGram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaGram to KiloGram
    /// </summary>
    /// <param name="val">quantity measured in DekaGram</param>
    /// <returns>quantity measured in KiloGram</returns>
	public static Quantity<double, KiloGram> ToKiloGram<T>(this BaseQuantity<T, DekaGram> val) where T:IConvertible {
        return new Quantity<double, KiloGram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaGram to HectoGram
    /// </summary>
    /// <param name="val">quantity measured in DekaGram</param>
    /// <returns>quantity measured in HectoGram</returns>
	public static Quantity<double, HectoGram> ToHectoGram<T>(this BaseQuantity<T, DekaGram> val) where T:IConvertible {
        return new Quantity<double, HectoGram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaGram to DeciGram
    /// </summary>
    /// <param name="val">quantity measured in DekaGram</param>
    /// <returns>quantity measured in DeciGram</returns>
	public static Quantity<double, DeciGram> ToDeciGram<T>(this BaseQuantity<T, DekaGram> val) where T:IConvertible {
        return new Quantity<double, DeciGram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaGram to CentiGram
    /// </summary>
    /// <param name="val">quantity measured in DekaGram</param>
    /// <returns>quantity measured in CentiGram</returns>
	public static Quantity<double, CentiGram> ToCentiGram<T>(this BaseQuantity<T, DekaGram> val) where T:IConvertible {
        return new Quantity<double, CentiGram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaGram to MilliGram
    /// </summary>
    /// <param name="val">quantity measured in DekaGram</param>
    /// <returns>quantity measured in MilliGram</returns>
	public static Quantity<double, MilliGram> ToMilliGram<T>(this BaseQuantity<T, DekaGram> val) where T:IConvertible {
        return new Quantity<double, MilliGram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaGram to MicroGram
    /// </summary>
    /// <param name="val">quantity measured in DekaGram</param>
    /// <returns>quantity measured in MicroGram</returns>
	public static Quantity<double, MicroGram> ToMicroGram<T>(this BaseQuantity<T, DekaGram> val) where T:IConvertible {
        return new Quantity<double, MicroGram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaGram to NanoGram
    /// </summary>
    /// <param name="val">quantity measured in DekaGram</param>
    /// <returns>quantity measured in NanoGram</returns>
	public static Quantity<double, NanoGram> ToNanoGram<T>(this BaseQuantity<T, DekaGram> val) where T:IConvertible {
        return new Quantity<double, NanoGram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaGram to PicoGram
    /// </summary>
    /// <param name="val">quantity measured in DekaGram</param>
    /// <returns>quantity measured in PicoGram</returns>
	public static Quantity<double, PicoGram> ToPicoGram<T>(this BaseQuantity<T, DekaGram> val) where T:IConvertible {
        return new Quantity<double, PicoGram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaGram to FemtoGram
    /// </summary>
    /// <param name="val">quantity measured in DekaGram</param>
    /// <returns>quantity measured in FemtoGram</returns>
	public static Quantity<double, FemtoGram> ToFemtoGram<T>(this BaseQuantity<T, DekaGram> val) where T:IConvertible {
        return new Quantity<double, FemtoGram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaGram to AttoGram
    /// </summary>
    /// <param name="val">quantity measured in DekaGram</param>
    /// <returns>quantity measured in AttoGram</returns>
	public static Quantity<double, AttoGram> ToAttoGram<T>(this BaseQuantity<T, DekaGram> val) where T:IConvertible {
        return new Quantity<double, AttoGram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaGram to ZeptoGram
    /// </summary>
    /// <param name="val">quantity measured in DekaGram</param>
    /// <returns>quantity measured in ZeptoGram</returns>
	public static Quantity<double, ZeptoGram> ToZeptoGram<T>(this BaseQuantity<T, DekaGram> val) where T:IConvertible {
        return new Quantity<double, ZeptoGram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaGram to YoctoGram
    /// </summary>
    /// <param name="val">quantity measured in DekaGram</param>
    /// <returns>quantity measured in YoctoGram</returns>
	public static Quantity<double, YoctoGram> ToYoctoGram<T>(this BaseQuantity<T, DekaGram> val) where T:IConvertible {
        return new Quantity<double, YoctoGram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DeciGram to YottaGram
    /// </summary>
    /// <param name="val">quantity measured in DeciGram</param>
    /// <returns>quantity measured in YottaGram</returns>
	public static Quantity<double, YottaGram> ToYottaGram<T>(this BaseQuantity<T, DeciGram> val) where T:IConvertible {
        return new Quantity<double, YottaGram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciGram to ZettaGram
    /// </summary>
    /// <param name="val">quantity measured in DeciGram</param>
    /// <returns>quantity measured in ZettaGram</returns>
	public static Quantity<double, ZettaGram> ToZettaGram<T>(this BaseQuantity<T, DeciGram> val) where T:IConvertible {
        return new Quantity<double, ZettaGram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciGram to ExaGram
    /// </summary>
    /// <param name="val">quantity measured in DeciGram</param>
    /// <returns>quantity measured in ExaGram</returns>
	public static Quantity<double, ExaGram> ToExaGram<T>(this BaseQuantity<T, DeciGram> val) where T:IConvertible {
        return new Quantity<double, ExaGram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciGram to PetaGram
    /// </summary>
    /// <param name="val">quantity measured in DeciGram</param>
    /// <returns>quantity measured in PetaGram</returns>
	public static Quantity<double, PetaGram> ToPetaGram<T>(this BaseQuantity<T, DeciGram> val) where T:IConvertible {
        return new Quantity<double, PetaGram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciGram to TeraGram
    /// </summary>
    /// <param name="val">quantity measured in DeciGram</param>
    /// <returns>quantity measured in TeraGram</returns>
	public static Quantity<double, TeraGram> ToTeraGram<T>(this BaseQuantity<T, DeciGram> val) where T:IConvertible {
        return new Quantity<double, TeraGram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciGram to GigaGram
    /// </summary>
    /// <param name="val">quantity measured in DeciGram</param>
    /// <returns>quantity measured in GigaGram</returns>
	public static Quantity<double, GigaGram> ToGigaGram<T>(this BaseQuantity<T, DeciGram> val) where T:IConvertible {
        return new Quantity<double, GigaGram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciGram to MegaGram
    /// </summary>
    /// <param name="val">quantity measured in DeciGram</param>
    /// <returns>quantity measured in MegaGram</returns>
	public static Quantity<double, MegaGram> ToMegaGram<T>(this BaseQuantity<T, DeciGram> val) where T:IConvertible {
        return new Quantity<double, MegaGram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciGram to KiloGram
    /// </summary>
    /// <param name="val">quantity measured in DeciGram</param>
    /// <returns>quantity measured in KiloGram</returns>
	public static Quantity<double, KiloGram> ToKiloGram<T>(this BaseQuantity<T, DeciGram> val) where T:IConvertible {
        return new Quantity<double, KiloGram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciGram to HectoGram
    /// </summary>
    /// <param name="val">quantity measured in DeciGram</param>
    /// <returns>quantity measured in HectoGram</returns>
	public static Quantity<double, HectoGram> ToHectoGram<T>(this BaseQuantity<T, DeciGram> val) where T:IConvertible {
        return new Quantity<double, HectoGram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciGram to DekaGram
    /// </summary>
    /// <param name="val">quantity measured in DeciGram</param>
    /// <returns>quantity measured in DekaGram</returns>
	public static Quantity<double, DekaGram> ToDekaGram<T>(this BaseQuantity<T, DeciGram> val) where T:IConvertible {
        return new Quantity<double, DekaGram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciGram to CentiGram
    /// </summary>
    /// <param name="val">quantity measured in DeciGram</param>
    /// <returns>quantity measured in CentiGram</returns>
	public static Quantity<double, CentiGram> ToCentiGram<T>(this BaseQuantity<T, DeciGram> val) where T:IConvertible {
        return new Quantity<double, CentiGram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciGram to MilliGram
    /// </summary>
    /// <param name="val">quantity measured in DeciGram</param>
    /// <returns>quantity measured in MilliGram</returns>
	public static Quantity<double, MilliGram> ToMilliGram<T>(this BaseQuantity<T, DeciGram> val) where T:IConvertible {
        return new Quantity<double, MilliGram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciGram to MicroGram
    /// </summary>
    /// <param name="val">quantity measured in DeciGram</param>
    /// <returns>quantity measured in MicroGram</returns>
	public static Quantity<double, MicroGram> ToMicroGram<T>(this BaseQuantity<T, DeciGram> val) where T:IConvertible {
        return new Quantity<double, MicroGram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciGram to NanoGram
    /// </summary>
    /// <param name="val">quantity measured in DeciGram</param>
    /// <returns>quantity measured in NanoGram</returns>
	public static Quantity<double, NanoGram> ToNanoGram<T>(this BaseQuantity<T, DeciGram> val) where T:IConvertible {
        return new Quantity<double, NanoGram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciGram to PicoGram
    /// </summary>
    /// <param name="val">quantity measured in DeciGram</param>
    /// <returns>quantity measured in PicoGram</returns>
	public static Quantity<double, PicoGram> ToPicoGram<T>(this BaseQuantity<T, DeciGram> val) where T:IConvertible {
        return new Quantity<double, PicoGram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciGram to FemtoGram
    /// </summary>
    /// <param name="val">quantity measured in DeciGram</param>
    /// <returns>quantity measured in FemtoGram</returns>
	public static Quantity<double, FemtoGram> ToFemtoGram<T>(this BaseQuantity<T, DeciGram> val) where T:IConvertible {
        return new Quantity<double, FemtoGram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciGram to AttoGram
    /// </summary>
    /// <param name="val">quantity measured in DeciGram</param>
    /// <returns>quantity measured in AttoGram</returns>
	public static Quantity<double, AttoGram> ToAttoGram<T>(this BaseQuantity<T, DeciGram> val) where T:IConvertible {
        return new Quantity<double, AttoGram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciGram to ZeptoGram
    /// </summary>
    /// <param name="val">quantity measured in DeciGram</param>
    /// <returns>quantity measured in ZeptoGram</returns>
	public static Quantity<double, ZeptoGram> ToZeptoGram<T>(this BaseQuantity<T, DeciGram> val) where T:IConvertible {
        return new Quantity<double, ZeptoGram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciGram to YoctoGram
    /// </summary>
    /// <param name="val">quantity measured in DeciGram</param>
    /// <returns>quantity measured in YoctoGram</returns>
	public static Quantity<double, YoctoGram> ToYoctoGram<T>(this BaseQuantity<T, DeciGram> val) where T:IConvertible {
        return new Quantity<double, YoctoGram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert CentiGram to YottaGram
    /// </summary>
    /// <param name="val">quantity measured in CentiGram</param>
    /// <returns>quantity measured in YottaGram</returns>
	public static Quantity<double, YottaGram> ToYottaGram<T>(this BaseQuantity<T, CentiGram> val) where T:IConvertible {
        return new Quantity<double, YottaGram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiGram to ZettaGram
    /// </summary>
    /// <param name="val">quantity measured in CentiGram</param>
    /// <returns>quantity measured in ZettaGram</returns>
	public static Quantity<double, ZettaGram> ToZettaGram<T>(this BaseQuantity<T, CentiGram> val) where T:IConvertible {
        return new Quantity<double, ZettaGram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiGram to ExaGram
    /// </summary>
    /// <param name="val">quantity measured in CentiGram</param>
    /// <returns>quantity measured in ExaGram</returns>
	public static Quantity<double, ExaGram> ToExaGram<T>(this BaseQuantity<T, CentiGram> val) where T:IConvertible {
        return new Quantity<double, ExaGram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiGram to PetaGram
    /// </summary>
    /// <param name="val">quantity measured in CentiGram</param>
    /// <returns>quantity measured in PetaGram</returns>
	public static Quantity<double, PetaGram> ToPetaGram<T>(this BaseQuantity<T, CentiGram> val) where T:IConvertible {
        return new Quantity<double, PetaGram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiGram to TeraGram
    /// </summary>
    /// <param name="val">quantity measured in CentiGram</param>
    /// <returns>quantity measured in TeraGram</returns>
	public static Quantity<double, TeraGram> ToTeraGram<T>(this BaseQuantity<T, CentiGram> val) where T:IConvertible {
        return new Quantity<double, TeraGram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiGram to GigaGram
    /// </summary>
    /// <param name="val">quantity measured in CentiGram</param>
    /// <returns>quantity measured in GigaGram</returns>
	public static Quantity<double, GigaGram> ToGigaGram<T>(this BaseQuantity<T, CentiGram> val) where T:IConvertible {
        return new Quantity<double, GigaGram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiGram to MegaGram
    /// </summary>
    /// <param name="val">quantity measured in CentiGram</param>
    /// <returns>quantity measured in MegaGram</returns>
	public static Quantity<double, MegaGram> ToMegaGram<T>(this BaseQuantity<T, CentiGram> val) where T:IConvertible {
        return new Quantity<double, MegaGram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiGram to KiloGram
    /// </summary>
    /// <param name="val">quantity measured in CentiGram</param>
    /// <returns>quantity measured in KiloGram</returns>
	public static Quantity<double, KiloGram> ToKiloGram<T>(this BaseQuantity<T, CentiGram> val) where T:IConvertible {
        return new Quantity<double, KiloGram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiGram to HectoGram
    /// </summary>
    /// <param name="val">quantity measured in CentiGram</param>
    /// <returns>quantity measured in HectoGram</returns>
	public static Quantity<double, HectoGram> ToHectoGram<T>(this BaseQuantity<T, CentiGram> val) where T:IConvertible {
        return new Quantity<double, HectoGram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiGram to DekaGram
    /// </summary>
    /// <param name="val">quantity measured in CentiGram</param>
    /// <returns>quantity measured in DekaGram</returns>
	public static Quantity<double, DekaGram> ToDekaGram<T>(this BaseQuantity<T, CentiGram> val) where T:IConvertible {
        return new Quantity<double, DekaGram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiGram to DeciGram
    /// </summary>
    /// <param name="val">quantity measured in CentiGram</param>
    /// <returns>quantity measured in DeciGram</returns>
	public static Quantity<double, DeciGram> ToDeciGram<T>(this BaseQuantity<T, CentiGram> val) where T:IConvertible {
        return new Quantity<double, DeciGram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiGram to MilliGram
    /// </summary>
    /// <param name="val">quantity measured in CentiGram</param>
    /// <returns>quantity measured in MilliGram</returns>
	public static Quantity<double, MilliGram> ToMilliGram<T>(this BaseQuantity<T, CentiGram> val) where T:IConvertible {
        return new Quantity<double, MilliGram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiGram to MicroGram
    /// </summary>
    /// <param name="val">quantity measured in CentiGram</param>
    /// <returns>quantity measured in MicroGram</returns>
	public static Quantity<double, MicroGram> ToMicroGram<T>(this BaseQuantity<T, CentiGram> val) where T:IConvertible {
        return new Quantity<double, MicroGram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiGram to NanoGram
    /// </summary>
    /// <param name="val">quantity measured in CentiGram</param>
    /// <returns>quantity measured in NanoGram</returns>
	public static Quantity<double, NanoGram> ToNanoGram<T>(this BaseQuantity<T, CentiGram> val) where T:IConvertible {
        return new Quantity<double, NanoGram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiGram to PicoGram
    /// </summary>
    /// <param name="val">quantity measured in CentiGram</param>
    /// <returns>quantity measured in PicoGram</returns>
	public static Quantity<double, PicoGram> ToPicoGram<T>(this BaseQuantity<T, CentiGram> val) where T:IConvertible {
        return new Quantity<double, PicoGram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiGram to FemtoGram
    /// </summary>
    /// <param name="val">quantity measured in CentiGram</param>
    /// <returns>quantity measured in FemtoGram</returns>
	public static Quantity<double, FemtoGram> ToFemtoGram<T>(this BaseQuantity<T, CentiGram> val) where T:IConvertible {
        return new Quantity<double, FemtoGram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiGram to AttoGram
    /// </summary>
    /// <param name="val">quantity measured in CentiGram</param>
    /// <returns>quantity measured in AttoGram</returns>
	public static Quantity<double, AttoGram> ToAttoGram<T>(this BaseQuantity<T, CentiGram> val) where T:IConvertible {
        return new Quantity<double, AttoGram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiGram to ZeptoGram
    /// </summary>
    /// <param name="val">quantity measured in CentiGram</param>
    /// <returns>quantity measured in ZeptoGram</returns>
	public static Quantity<double, ZeptoGram> ToZeptoGram<T>(this BaseQuantity<T, CentiGram> val) where T:IConvertible {
        return new Quantity<double, ZeptoGram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiGram to YoctoGram
    /// </summary>
    /// <param name="val">quantity measured in CentiGram</param>
    /// <returns>quantity measured in YoctoGram</returns>
	public static Quantity<double, YoctoGram> ToYoctoGram<T>(this BaseQuantity<T, CentiGram> val) where T:IConvertible {
        return new Quantity<double, YoctoGram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert MilliGram to YottaGram
    /// </summary>
    /// <param name="val">quantity measured in MilliGram</param>
    /// <returns>quantity measured in YottaGram</returns>
	public static Quantity<double, YottaGram> ToYottaGram<T>(this BaseQuantity<T, MilliGram> val) where T:IConvertible {
        return new Quantity<double, YottaGram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliGram to ZettaGram
    /// </summary>
    /// <param name="val">quantity measured in MilliGram</param>
    /// <returns>quantity measured in ZettaGram</returns>
	public static Quantity<double, ZettaGram> ToZettaGram<T>(this BaseQuantity<T, MilliGram> val) where T:IConvertible {
        return new Quantity<double, ZettaGram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliGram to ExaGram
    /// </summary>
    /// <param name="val">quantity measured in MilliGram</param>
    /// <returns>quantity measured in ExaGram</returns>
	public static Quantity<double, ExaGram> ToExaGram<T>(this BaseQuantity<T, MilliGram> val) where T:IConvertible {
        return new Quantity<double, ExaGram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliGram to PetaGram
    /// </summary>
    /// <param name="val">quantity measured in MilliGram</param>
    /// <returns>quantity measured in PetaGram</returns>
	public static Quantity<double, PetaGram> ToPetaGram<T>(this BaseQuantity<T, MilliGram> val) where T:IConvertible {
        return new Quantity<double, PetaGram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliGram to TeraGram
    /// </summary>
    /// <param name="val">quantity measured in MilliGram</param>
    /// <returns>quantity measured in TeraGram</returns>
	public static Quantity<double, TeraGram> ToTeraGram<T>(this BaseQuantity<T, MilliGram> val) where T:IConvertible {
        return new Quantity<double, TeraGram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliGram to GigaGram
    /// </summary>
    /// <param name="val">quantity measured in MilliGram</param>
    /// <returns>quantity measured in GigaGram</returns>
	public static Quantity<double, GigaGram> ToGigaGram<T>(this BaseQuantity<T, MilliGram> val) where T:IConvertible {
        return new Quantity<double, GigaGram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliGram to MegaGram
    /// </summary>
    /// <param name="val">quantity measured in MilliGram</param>
    /// <returns>quantity measured in MegaGram</returns>
	public static Quantity<double, MegaGram> ToMegaGram<T>(this BaseQuantity<T, MilliGram> val) where T:IConvertible {
        return new Quantity<double, MegaGram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliGram to KiloGram
    /// </summary>
    /// <param name="val">quantity measured in MilliGram</param>
    /// <returns>quantity measured in KiloGram</returns>
	public static Quantity<double, KiloGram> ToKiloGram<T>(this BaseQuantity<T, MilliGram> val) where T:IConvertible {
        return new Quantity<double, KiloGram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliGram to HectoGram
    /// </summary>
    /// <param name="val">quantity measured in MilliGram</param>
    /// <returns>quantity measured in HectoGram</returns>
	public static Quantity<double, HectoGram> ToHectoGram<T>(this BaseQuantity<T, MilliGram> val) where T:IConvertible {
        return new Quantity<double, HectoGram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliGram to DekaGram
    /// </summary>
    /// <param name="val">quantity measured in MilliGram</param>
    /// <returns>quantity measured in DekaGram</returns>
	public static Quantity<double, DekaGram> ToDekaGram<T>(this BaseQuantity<T, MilliGram> val) where T:IConvertible {
        return new Quantity<double, DekaGram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliGram to DeciGram
    /// </summary>
    /// <param name="val">quantity measured in MilliGram</param>
    /// <returns>quantity measured in DeciGram</returns>
	public static Quantity<double, DeciGram> ToDeciGram<T>(this BaseQuantity<T, MilliGram> val) where T:IConvertible {
        return new Quantity<double, DeciGram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliGram to CentiGram
    /// </summary>
    /// <param name="val">quantity measured in MilliGram</param>
    /// <returns>quantity measured in CentiGram</returns>
	public static Quantity<double, CentiGram> ToCentiGram<T>(this BaseQuantity<T, MilliGram> val) where T:IConvertible {
        return new Quantity<double, CentiGram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliGram to MicroGram
    /// </summary>
    /// <param name="val">quantity measured in MilliGram</param>
    /// <returns>quantity measured in MicroGram</returns>
	public static Quantity<double, MicroGram> ToMicroGram<T>(this BaseQuantity<T, MilliGram> val) where T:IConvertible {
        return new Quantity<double, MicroGram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliGram to NanoGram
    /// </summary>
    /// <param name="val">quantity measured in MilliGram</param>
    /// <returns>quantity measured in NanoGram</returns>
	public static Quantity<double, NanoGram> ToNanoGram<T>(this BaseQuantity<T, MilliGram> val) where T:IConvertible {
        return new Quantity<double, NanoGram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliGram to PicoGram
    /// </summary>
    /// <param name="val">quantity measured in MilliGram</param>
    /// <returns>quantity measured in PicoGram</returns>
	public static Quantity<double, PicoGram> ToPicoGram<T>(this BaseQuantity<T, MilliGram> val) where T:IConvertible {
        return new Quantity<double, PicoGram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliGram to FemtoGram
    /// </summary>
    /// <param name="val">quantity measured in MilliGram</param>
    /// <returns>quantity measured in FemtoGram</returns>
	public static Quantity<double, FemtoGram> ToFemtoGram<T>(this BaseQuantity<T, MilliGram> val) where T:IConvertible {
        return new Quantity<double, FemtoGram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliGram to AttoGram
    /// </summary>
    /// <param name="val">quantity measured in MilliGram</param>
    /// <returns>quantity measured in AttoGram</returns>
	public static Quantity<double, AttoGram> ToAttoGram<T>(this BaseQuantity<T, MilliGram> val) where T:IConvertible {
        return new Quantity<double, AttoGram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliGram to ZeptoGram
    /// </summary>
    /// <param name="val">quantity measured in MilliGram</param>
    /// <returns>quantity measured in ZeptoGram</returns>
	public static Quantity<double, ZeptoGram> ToZeptoGram<T>(this BaseQuantity<T, MilliGram> val) where T:IConvertible {
        return new Quantity<double, ZeptoGram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliGram to YoctoGram
    /// </summary>
    /// <param name="val">quantity measured in MilliGram</param>
    /// <returns>quantity measured in YoctoGram</returns>
	public static Quantity<double, YoctoGram> ToYoctoGram<T>(this BaseQuantity<T, MilliGram> val) where T:IConvertible {
        return new Quantity<double, YoctoGram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MicroGram to YottaGram
    /// </summary>
    /// <param name="val">quantity measured in MicroGram</param>
    /// <returns>quantity measured in YottaGram</returns>
	public static Quantity<double, YottaGram> ToYottaGram<T>(this BaseQuantity<T, MicroGram> val) where T:IConvertible {
        return new Quantity<double, YottaGram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroGram to ZettaGram
    /// </summary>
    /// <param name="val">quantity measured in MicroGram</param>
    /// <returns>quantity measured in ZettaGram</returns>
	public static Quantity<double, ZettaGram> ToZettaGram<T>(this BaseQuantity<T, MicroGram> val) where T:IConvertible {
        return new Quantity<double, ZettaGram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroGram to ExaGram
    /// </summary>
    /// <param name="val">quantity measured in MicroGram</param>
    /// <returns>quantity measured in ExaGram</returns>
	public static Quantity<double, ExaGram> ToExaGram<T>(this BaseQuantity<T, MicroGram> val) where T:IConvertible {
        return new Quantity<double, ExaGram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroGram to PetaGram
    /// </summary>
    /// <param name="val">quantity measured in MicroGram</param>
    /// <returns>quantity measured in PetaGram</returns>
	public static Quantity<double, PetaGram> ToPetaGram<T>(this BaseQuantity<T, MicroGram> val) where T:IConvertible {
        return new Quantity<double, PetaGram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroGram to TeraGram
    /// </summary>
    /// <param name="val">quantity measured in MicroGram</param>
    /// <returns>quantity measured in TeraGram</returns>
	public static Quantity<double, TeraGram> ToTeraGram<T>(this BaseQuantity<T, MicroGram> val) where T:IConvertible {
        return new Quantity<double, TeraGram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroGram to GigaGram
    /// </summary>
    /// <param name="val">quantity measured in MicroGram</param>
    /// <returns>quantity measured in GigaGram</returns>
	public static Quantity<double, GigaGram> ToGigaGram<T>(this BaseQuantity<T, MicroGram> val) where T:IConvertible {
        return new Quantity<double, GigaGram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroGram to MegaGram
    /// </summary>
    /// <param name="val">quantity measured in MicroGram</param>
    /// <returns>quantity measured in MegaGram</returns>
	public static Quantity<double, MegaGram> ToMegaGram<T>(this BaseQuantity<T, MicroGram> val) where T:IConvertible {
        return new Quantity<double, MegaGram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroGram to KiloGram
    /// </summary>
    /// <param name="val">quantity measured in MicroGram</param>
    /// <returns>quantity measured in KiloGram</returns>
	public static Quantity<double, KiloGram> ToKiloGram<T>(this BaseQuantity<T, MicroGram> val) where T:IConvertible {
        return new Quantity<double, KiloGram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroGram to HectoGram
    /// </summary>
    /// <param name="val">quantity measured in MicroGram</param>
    /// <returns>quantity measured in HectoGram</returns>
	public static Quantity<double, HectoGram> ToHectoGram<T>(this BaseQuantity<T, MicroGram> val) where T:IConvertible {
        return new Quantity<double, HectoGram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroGram to DekaGram
    /// </summary>
    /// <param name="val">quantity measured in MicroGram</param>
    /// <returns>quantity measured in DekaGram</returns>
	public static Quantity<double, DekaGram> ToDekaGram<T>(this BaseQuantity<T, MicroGram> val) where T:IConvertible {
        return new Quantity<double, DekaGram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroGram to DeciGram
    /// </summary>
    /// <param name="val">quantity measured in MicroGram</param>
    /// <returns>quantity measured in DeciGram</returns>
	public static Quantity<double, DeciGram> ToDeciGram<T>(this BaseQuantity<T, MicroGram> val) where T:IConvertible {
        return new Quantity<double, DeciGram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroGram to CentiGram
    /// </summary>
    /// <param name="val">quantity measured in MicroGram</param>
    /// <returns>quantity measured in CentiGram</returns>
	public static Quantity<double, CentiGram> ToCentiGram<T>(this BaseQuantity<T, MicroGram> val) where T:IConvertible {
        return new Quantity<double, CentiGram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroGram to MilliGram
    /// </summary>
    /// <param name="val">quantity measured in MicroGram</param>
    /// <returns>quantity measured in MilliGram</returns>
	public static Quantity<double, MilliGram> ToMilliGram<T>(this BaseQuantity<T, MicroGram> val) where T:IConvertible {
        return new Quantity<double, MilliGram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroGram to NanoGram
    /// </summary>
    /// <param name="val">quantity measured in MicroGram</param>
    /// <returns>quantity measured in NanoGram</returns>
	public static Quantity<double, NanoGram> ToNanoGram<T>(this BaseQuantity<T, MicroGram> val) where T:IConvertible {
        return new Quantity<double, NanoGram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroGram to PicoGram
    /// </summary>
    /// <param name="val">quantity measured in MicroGram</param>
    /// <returns>quantity measured in PicoGram</returns>
	public static Quantity<double, PicoGram> ToPicoGram<T>(this BaseQuantity<T, MicroGram> val) where T:IConvertible {
        return new Quantity<double, PicoGram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroGram to FemtoGram
    /// </summary>
    /// <param name="val">quantity measured in MicroGram</param>
    /// <returns>quantity measured in FemtoGram</returns>
	public static Quantity<double, FemtoGram> ToFemtoGram<T>(this BaseQuantity<T, MicroGram> val) where T:IConvertible {
        return new Quantity<double, FemtoGram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroGram to AttoGram
    /// </summary>
    /// <param name="val">quantity measured in MicroGram</param>
    /// <returns>quantity measured in AttoGram</returns>
	public static Quantity<double, AttoGram> ToAttoGram<T>(this BaseQuantity<T, MicroGram> val) where T:IConvertible {
        return new Quantity<double, AttoGram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroGram to ZeptoGram
    /// </summary>
    /// <param name="val">quantity measured in MicroGram</param>
    /// <returns>quantity measured in ZeptoGram</returns>
	public static Quantity<double, ZeptoGram> ToZeptoGram<T>(this BaseQuantity<T, MicroGram> val) where T:IConvertible {
        return new Quantity<double, ZeptoGram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroGram to YoctoGram
    /// </summary>
    /// <param name="val">quantity measured in MicroGram</param>
    /// <returns>quantity measured in YoctoGram</returns>
	public static Quantity<double, YoctoGram> ToYoctoGram<T>(this BaseQuantity<T, MicroGram> val) where T:IConvertible {
        return new Quantity<double, YoctoGram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert NanoGram to YottaGram
    /// </summary>
    /// <param name="val">quantity measured in NanoGram</param>
    /// <returns>quantity measured in YottaGram</returns>
	public static Quantity<double, YottaGram> ToYottaGram<T>(this BaseQuantity<T, NanoGram> val) where T:IConvertible {
        return new Quantity<double, YottaGram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoGram to ZettaGram
    /// </summary>
    /// <param name="val">quantity measured in NanoGram</param>
    /// <returns>quantity measured in ZettaGram</returns>
	public static Quantity<double, ZettaGram> ToZettaGram<T>(this BaseQuantity<T, NanoGram> val) where T:IConvertible {
        return new Quantity<double, ZettaGram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoGram to ExaGram
    /// </summary>
    /// <param name="val">quantity measured in NanoGram</param>
    /// <returns>quantity measured in ExaGram</returns>
	public static Quantity<double, ExaGram> ToExaGram<T>(this BaseQuantity<T, NanoGram> val) where T:IConvertible {
        return new Quantity<double, ExaGram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoGram to PetaGram
    /// </summary>
    /// <param name="val">quantity measured in NanoGram</param>
    /// <returns>quantity measured in PetaGram</returns>
	public static Quantity<double, PetaGram> ToPetaGram<T>(this BaseQuantity<T, NanoGram> val) where T:IConvertible {
        return new Quantity<double, PetaGram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoGram to TeraGram
    /// </summary>
    /// <param name="val">quantity measured in NanoGram</param>
    /// <returns>quantity measured in TeraGram</returns>
	public static Quantity<double, TeraGram> ToTeraGram<T>(this BaseQuantity<T, NanoGram> val) where T:IConvertible {
        return new Quantity<double, TeraGram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoGram to GigaGram
    /// </summary>
    /// <param name="val">quantity measured in NanoGram</param>
    /// <returns>quantity measured in GigaGram</returns>
	public static Quantity<double, GigaGram> ToGigaGram<T>(this BaseQuantity<T, NanoGram> val) where T:IConvertible {
        return new Quantity<double, GigaGram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoGram to MegaGram
    /// </summary>
    /// <param name="val">quantity measured in NanoGram</param>
    /// <returns>quantity measured in MegaGram</returns>
	public static Quantity<double, MegaGram> ToMegaGram<T>(this BaseQuantity<T, NanoGram> val) where T:IConvertible {
        return new Quantity<double, MegaGram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoGram to KiloGram
    /// </summary>
    /// <param name="val">quantity measured in NanoGram</param>
    /// <returns>quantity measured in KiloGram</returns>
	public static Quantity<double, KiloGram> ToKiloGram<T>(this BaseQuantity<T, NanoGram> val) where T:IConvertible {
        return new Quantity<double, KiloGram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoGram to HectoGram
    /// </summary>
    /// <param name="val">quantity measured in NanoGram</param>
    /// <returns>quantity measured in HectoGram</returns>
	public static Quantity<double, HectoGram> ToHectoGram<T>(this BaseQuantity<T, NanoGram> val) where T:IConvertible {
        return new Quantity<double, HectoGram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoGram to DekaGram
    /// </summary>
    /// <param name="val">quantity measured in NanoGram</param>
    /// <returns>quantity measured in DekaGram</returns>
	public static Quantity<double, DekaGram> ToDekaGram<T>(this BaseQuantity<T, NanoGram> val) where T:IConvertible {
        return new Quantity<double, DekaGram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoGram to DeciGram
    /// </summary>
    /// <param name="val">quantity measured in NanoGram</param>
    /// <returns>quantity measured in DeciGram</returns>
	public static Quantity<double, DeciGram> ToDeciGram<T>(this BaseQuantity<T, NanoGram> val) where T:IConvertible {
        return new Quantity<double, DeciGram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoGram to CentiGram
    /// </summary>
    /// <param name="val">quantity measured in NanoGram</param>
    /// <returns>quantity measured in CentiGram</returns>
	public static Quantity<double, CentiGram> ToCentiGram<T>(this BaseQuantity<T, NanoGram> val) where T:IConvertible {
        return new Quantity<double, CentiGram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoGram to MilliGram
    /// </summary>
    /// <param name="val">quantity measured in NanoGram</param>
    /// <returns>quantity measured in MilliGram</returns>
	public static Quantity<double, MilliGram> ToMilliGram<T>(this BaseQuantity<T, NanoGram> val) where T:IConvertible {
        return new Quantity<double, MilliGram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoGram to MicroGram
    /// </summary>
    /// <param name="val">quantity measured in NanoGram</param>
    /// <returns>quantity measured in MicroGram</returns>
	public static Quantity<double, MicroGram> ToMicroGram<T>(this BaseQuantity<T, NanoGram> val) where T:IConvertible {
        return new Quantity<double, MicroGram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoGram to PicoGram
    /// </summary>
    /// <param name="val">quantity measured in NanoGram</param>
    /// <returns>quantity measured in PicoGram</returns>
	public static Quantity<double, PicoGram> ToPicoGram<T>(this BaseQuantity<T, NanoGram> val) where T:IConvertible {
        return new Quantity<double, PicoGram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoGram to FemtoGram
    /// </summary>
    /// <param name="val">quantity measured in NanoGram</param>
    /// <returns>quantity measured in FemtoGram</returns>
	public static Quantity<double, FemtoGram> ToFemtoGram<T>(this BaseQuantity<T, NanoGram> val) where T:IConvertible {
        return new Quantity<double, FemtoGram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoGram to AttoGram
    /// </summary>
    /// <param name="val">quantity measured in NanoGram</param>
    /// <returns>quantity measured in AttoGram</returns>
	public static Quantity<double, AttoGram> ToAttoGram<T>(this BaseQuantity<T, NanoGram> val) where T:IConvertible {
        return new Quantity<double, AttoGram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoGram to ZeptoGram
    /// </summary>
    /// <param name="val">quantity measured in NanoGram</param>
    /// <returns>quantity measured in ZeptoGram</returns>
	public static Quantity<double, ZeptoGram> ToZeptoGram<T>(this BaseQuantity<T, NanoGram> val) where T:IConvertible {
        return new Quantity<double, ZeptoGram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoGram to YoctoGram
    /// </summary>
    /// <param name="val">quantity measured in NanoGram</param>
    /// <returns>quantity measured in YoctoGram</returns>
	public static Quantity<double, YoctoGram> ToYoctoGram<T>(this BaseQuantity<T, NanoGram> val) where T:IConvertible {
        return new Quantity<double, YoctoGram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert PicoGram to YottaGram
    /// </summary>
    /// <param name="val">quantity measured in PicoGram</param>
    /// <returns>quantity measured in YottaGram</returns>
	public static Quantity<double, YottaGram> ToYottaGram<T>(this BaseQuantity<T, PicoGram> val) where T:IConvertible {
        return new Quantity<double, YottaGram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoGram to ZettaGram
    /// </summary>
    /// <param name="val">quantity measured in PicoGram</param>
    /// <returns>quantity measured in ZettaGram</returns>
	public static Quantity<double, ZettaGram> ToZettaGram<T>(this BaseQuantity<T, PicoGram> val) where T:IConvertible {
        return new Quantity<double, ZettaGram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoGram to ExaGram
    /// </summary>
    /// <param name="val">quantity measured in PicoGram</param>
    /// <returns>quantity measured in ExaGram</returns>
	public static Quantity<double, ExaGram> ToExaGram<T>(this BaseQuantity<T, PicoGram> val) where T:IConvertible {
        return new Quantity<double, ExaGram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoGram to PetaGram
    /// </summary>
    /// <param name="val">quantity measured in PicoGram</param>
    /// <returns>quantity measured in PetaGram</returns>
	public static Quantity<double, PetaGram> ToPetaGram<T>(this BaseQuantity<T, PicoGram> val) where T:IConvertible {
        return new Quantity<double, PetaGram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoGram to TeraGram
    /// </summary>
    /// <param name="val">quantity measured in PicoGram</param>
    /// <returns>quantity measured in TeraGram</returns>
	public static Quantity<double, TeraGram> ToTeraGram<T>(this BaseQuantity<T, PicoGram> val) where T:IConvertible {
        return new Quantity<double, TeraGram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoGram to GigaGram
    /// </summary>
    /// <param name="val">quantity measured in PicoGram</param>
    /// <returns>quantity measured in GigaGram</returns>
	public static Quantity<double, GigaGram> ToGigaGram<T>(this BaseQuantity<T, PicoGram> val) where T:IConvertible {
        return new Quantity<double, GigaGram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoGram to MegaGram
    /// </summary>
    /// <param name="val">quantity measured in PicoGram</param>
    /// <returns>quantity measured in MegaGram</returns>
	public static Quantity<double, MegaGram> ToMegaGram<T>(this BaseQuantity<T, PicoGram> val) where T:IConvertible {
        return new Quantity<double, MegaGram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoGram to KiloGram
    /// </summary>
    /// <param name="val">quantity measured in PicoGram</param>
    /// <returns>quantity measured in KiloGram</returns>
	public static Quantity<double, KiloGram> ToKiloGram<T>(this BaseQuantity<T, PicoGram> val) where T:IConvertible {
        return new Quantity<double, KiloGram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoGram to HectoGram
    /// </summary>
    /// <param name="val">quantity measured in PicoGram</param>
    /// <returns>quantity measured in HectoGram</returns>
	public static Quantity<double, HectoGram> ToHectoGram<T>(this BaseQuantity<T, PicoGram> val) where T:IConvertible {
        return new Quantity<double, HectoGram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoGram to DekaGram
    /// </summary>
    /// <param name="val">quantity measured in PicoGram</param>
    /// <returns>quantity measured in DekaGram</returns>
	public static Quantity<double, DekaGram> ToDekaGram<T>(this BaseQuantity<T, PicoGram> val) where T:IConvertible {
        return new Quantity<double, DekaGram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoGram to DeciGram
    /// </summary>
    /// <param name="val">quantity measured in PicoGram</param>
    /// <returns>quantity measured in DeciGram</returns>
	public static Quantity<double, DeciGram> ToDeciGram<T>(this BaseQuantity<T, PicoGram> val) where T:IConvertible {
        return new Quantity<double, DeciGram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoGram to CentiGram
    /// </summary>
    /// <param name="val">quantity measured in PicoGram</param>
    /// <returns>quantity measured in CentiGram</returns>
	public static Quantity<double, CentiGram> ToCentiGram<T>(this BaseQuantity<T, PicoGram> val) where T:IConvertible {
        return new Quantity<double, CentiGram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoGram to MilliGram
    /// </summary>
    /// <param name="val">quantity measured in PicoGram</param>
    /// <returns>quantity measured in MilliGram</returns>
	public static Quantity<double, MilliGram> ToMilliGram<T>(this BaseQuantity<T, PicoGram> val) where T:IConvertible {
        return new Quantity<double, MilliGram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoGram to MicroGram
    /// </summary>
    /// <param name="val">quantity measured in PicoGram</param>
    /// <returns>quantity measured in MicroGram</returns>
	public static Quantity<double, MicroGram> ToMicroGram<T>(this BaseQuantity<T, PicoGram> val) where T:IConvertible {
        return new Quantity<double, MicroGram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoGram to NanoGram
    /// </summary>
    /// <param name="val">quantity measured in PicoGram</param>
    /// <returns>quantity measured in NanoGram</returns>
	public static Quantity<double, NanoGram> ToNanoGram<T>(this BaseQuantity<T, PicoGram> val) where T:IConvertible {
        return new Quantity<double, NanoGram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoGram to FemtoGram
    /// </summary>
    /// <param name="val">quantity measured in PicoGram</param>
    /// <returns>quantity measured in FemtoGram</returns>
	public static Quantity<double, FemtoGram> ToFemtoGram<T>(this BaseQuantity<T, PicoGram> val) where T:IConvertible {
        return new Quantity<double, FemtoGram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoGram to AttoGram
    /// </summary>
    /// <param name="val">quantity measured in PicoGram</param>
    /// <returns>quantity measured in AttoGram</returns>
	public static Quantity<double, AttoGram> ToAttoGram<T>(this BaseQuantity<T, PicoGram> val) where T:IConvertible {
        return new Quantity<double, AttoGram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoGram to ZeptoGram
    /// </summary>
    /// <param name="val">quantity measured in PicoGram</param>
    /// <returns>quantity measured in ZeptoGram</returns>
	public static Quantity<double, ZeptoGram> ToZeptoGram<T>(this BaseQuantity<T, PicoGram> val) where T:IConvertible {
        return new Quantity<double, ZeptoGram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoGram to YoctoGram
    /// </summary>
    /// <param name="val">quantity measured in PicoGram</param>
    /// <returns>quantity measured in YoctoGram</returns>
	public static Quantity<double, YoctoGram> ToYoctoGram<T>(this BaseQuantity<T, PicoGram> val) where T:IConvertible {
        return new Quantity<double, YoctoGram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert FemtoGram to YottaGram
    /// </summary>
    /// <param name="val">quantity measured in FemtoGram</param>
    /// <returns>quantity measured in YottaGram</returns>
	public static Quantity<double, YottaGram> ToYottaGram<T>(this BaseQuantity<T, FemtoGram> val) where T:IConvertible {
        return new Quantity<double, YottaGram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoGram to ZettaGram
    /// </summary>
    /// <param name="val">quantity measured in FemtoGram</param>
    /// <returns>quantity measured in ZettaGram</returns>
	public static Quantity<double, ZettaGram> ToZettaGram<T>(this BaseQuantity<T, FemtoGram> val) where T:IConvertible {
        return new Quantity<double, ZettaGram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoGram to ExaGram
    /// </summary>
    /// <param name="val">quantity measured in FemtoGram</param>
    /// <returns>quantity measured in ExaGram</returns>
	public static Quantity<double, ExaGram> ToExaGram<T>(this BaseQuantity<T, FemtoGram> val) where T:IConvertible {
        return new Quantity<double, ExaGram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoGram to PetaGram
    /// </summary>
    /// <param name="val">quantity measured in FemtoGram</param>
    /// <returns>quantity measured in PetaGram</returns>
	public static Quantity<double, PetaGram> ToPetaGram<T>(this BaseQuantity<T, FemtoGram> val) where T:IConvertible {
        return new Quantity<double, PetaGram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoGram to TeraGram
    /// </summary>
    /// <param name="val">quantity measured in FemtoGram</param>
    /// <returns>quantity measured in TeraGram</returns>
	public static Quantity<double, TeraGram> ToTeraGram<T>(this BaseQuantity<T, FemtoGram> val) where T:IConvertible {
        return new Quantity<double, TeraGram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoGram to GigaGram
    /// </summary>
    /// <param name="val">quantity measured in FemtoGram</param>
    /// <returns>quantity measured in GigaGram</returns>
	public static Quantity<double, GigaGram> ToGigaGram<T>(this BaseQuantity<T, FemtoGram> val) where T:IConvertible {
        return new Quantity<double, GigaGram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoGram to MegaGram
    /// </summary>
    /// <param name="val">quantity measured in FemtoGram</param>
    /// <returns>quantity measured in MegaGram</returns>
	public static Quantity<double, MegaGram> ToMegaGram<T>(this BaseQuantity<T, FemtoGram> val) where T:IConvertible {
        return new Quantity<double, MegaGram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoGram to KiloGram
    /// </summary>
    /// <param name="val">quantity measured in FemtoGram</param>
    /// <returns>quantity measured in KiloGram</returns>
	public static Quantity<double, KiloGram> ToKiloGram<T>(this BaseQuantity<T, FemtoGram> val) where T:IConvertible {
        return new Quantity<double, KiloGram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoGram to HectoGram
    /// </summary>
    /// <param name="val">quantity measured in FemtoGram</param>
    /// <returns>quantity measured in HectoGram</returns>
	public static Quantity<double, HectoGram> ToHectoGram<T>(this BaseQuantity<T, FemtoGram> val) where T:IConvertible {
        return new Quantity<double, HectoGram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoGram to DekaGram
    /// </summary>
    /// <param name="val">quantity measured in FemtoGram</param>
    /// <returns>quantity measured in DekaGram</returns>
	public static Quantity<double, DekaGram> ToDekaGram<T>(this BaseQuantity<T, FemtoGram> val) where T:IConvertible {
        return new Quantity<double, DekaGram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoGram to DeciGram
    /// </summary>
    /// <param name="val">quantity measured in FemtoGram</param>
    /// <returns>quantity measured in DeciGram</returns>
	public static Quantity<double, DeciGram> ToDeciGram<T>(this BaseQuantity<T, FemtoGram> val) where T:IConvertible {
        return new Quantity<double, DeciGram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoGram to CentiGram
    /// </summary>
    /// <param name="val">quantity measured in FemtoGram</param>
    /// <returns>quantity measured in CentiGram</returns>
	public static Quantity<double, CentiGram> ToCentiGram<T>(this BaseQuantity<T, FemtoGram> val) where T:IConvertible {
        return new Quantity<double, CentiGram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoGram to MilliGram
    /// </summary>
    /// <param name="val">quantity measured in FemtoGram</param>
    /// <returns>quantity measured in MilliGram</returns>
	public static Quantity<double, MilliGram> ToMilliGram<T>(this BaseQuantity<T, FemtoGram> val) where T:IConvertible {
        return new Quantity<double, MilliGram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoGram to MicroGram
    /// </summary>
    /// <param name="val">quantity measured in FemtoGram</param>
    /// <returns>quantity measured in MicroGram</returns>
	public static Quantity<double, MicroGram> ToMicroGram<T>(this BaseQuantity<T, FemtoGram> val) where T:IConvertible {
        return new Quantity<double, MicroGram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoGram to NanoGram
    /// </summary>
    /// <param name="val">quantity measured in FemtoGram</param>
    /// <returns>quantity measured in NanoGram</returns>
	public static Quantity<double, NanoGram> ToNanoGram<T>(this BaseQuantity<T, FemtoGram> val) where T:IConvertible {
        return new Quantity<double, NanoGram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoGram to PicoGram
    /// </summary>
    /// <param name="val">quantity measured in FemtoGram</param>
    /// <returns>quantity measured in PicoGram</returns>
	public static Quantity<double, PicoGram> ToPicoGram<T>(this BaseQuantity<T, FemtoGram> val) where T:IConvertible {
        return new Quantity<double, PicoGram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoGram to AttoGram
    /// </summary>
    /// <param name="val">quantity measured in FemtoGram</param>
    /// <returns>quantity measured in AttoGram</returns>
	public static Quantity<double, AttoGram> ToAttoGram<T>(this BaseQuantity<T, FemtoGram> val) where T:IConvertible {
        return new Quantity<double, AttoGram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoGram to ZeptoGram
    /// </summary>
    /// <param name="val">quantity measured in FemtoGram</param>
    /// <returns>quantity measured in ZeptoGram</returns>
	public static Quantity<double, ZeptoGram> ToZeptoGram<T>(this BaseQuantity<T, FemtoGram> val) where T:IConvertible {
        return new Quantity<double, ZeptoGram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoGram to YoctoGram
    /// </summary>
    /// <param name="val">quantity measured in FemtoGram</param>
    /// <returns>quantity measured in YoctoGram</returns>
	public static Quantity<double, YoctoGram> ToYoctoGram<T>(this BaseQuantity<T, FemtoGram> val) where T:IConvertible {
        return new Quantity<double, YoctoGram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert AttoGram to YottaGram
    /// </summary>
    /// <param name="val">quantity measured in AttoGram</param>
    /// <returns>quantity measured in YottaGram</returns>
	public static Quantity<double, YottaGram> ToYottaGram<T>(this BaseQuantity<T, AttoGram> val) where T:IConvertible {
        return new Quantity<double, YottaGram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoGram to ZettaGram
    /// </summary>
    /// <param name="val">quantity measured in AttoGram</param>
    /// <returns>quantity measured in ZettaGram</returns>
	public static Quantity<double, ZettaGram> ToZettaGram<T>(this BaseQuantity<T, AttoGram> val) where T:IConvertible {
        return new Quantity<double, ZettaGram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoGram to ExaGram
    /// </summary>
    /// <param name="val">quantity measured in AttoGram</param>
    /// <returns>quantity measured in ExaGram</returns>
	public static Quantity<double, ExaGram> ToExaGram<T>(this BaseQuantity<T, AttoGram> val) where T:IConvertible {
        return new Quantity<double, ExaGram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoGram to PetaGram
    /// </summary>
    /// <param name="val">quantity measured in AttoGram</param>
    /// <returns>quantity measured in PetaGram</returns>
	public static Quantity<double, PetaGram> ToPetaGram<T>(this BaseQuantity<T, AttoGram> val) where T:IConvertible {
        return new Quantity<double, PetaGram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoGram to TeraGram
    /// </summary>
    /// <param name="val">quantity measured in AttoGram</param>
    /// <returns>quantity measured in TeraGram</returns>
	public static Quantity<double, TeraGram> ToTeraGram<T>(this BaseQuantity<T, AttoGram> val) where T:IConvertible {
        return new Quantity<double, TeraGram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoGram to GigaGram
    /// </summary>
    /// <param name="val">quantity measured in AttoGram</param>
    /// <returns>quantity measured in GigaGram</returns>
	public static Quantity<double, GigaGram> ToGigaGram<T>(this BaseQuantity<T, AttoGram> val) where T:IConvertible {
        return new Quantity<double, GigaGram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoGram to MegaGram
    /// </summary>
    /// <param name="val">quantity measured in AttoGram</param>
    /// <returns>quantity measured in MegaGram</returns>
	public static Quantity<double, MegaGram> ToMegaGram<T>(this BaseQuantity<T, AttoGram> val) where T:IConvertible {
        return new Quantity<double, MegaGram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoGram to KiloGram
    /// </summary>
    /// <param name="val">quantity measured in AttoGram</param>
    /// <returns>quantity measured in KiloGram</returns>
	public static Quantity<double, KiloGram> ToKiloGram<T>(this BaseQuantity<T, AttoGram> val) where T:IConvertible {
        return new Quantity<double, KiloGram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoGram to HectoGram
    /// </summary>
    /// <param name="val">quantity measured in AttoGram</param>
    /// <returns>quantity measured in HectoGram</returns>
	public static Quantity<double, HectoGram> ToHectoGram<T>(this BaseQuantity<T, AttoGram> val) where T:IConvertible {
        return new Quantity<double, HectoGram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoGram to DekaGram
    /// </summary>
    /// <param name="val">quantity measured in AttoGram</param>
    /// <returns>quantity measured in DekaGram</returns>
	public static Quantity<double, DekaGram> ToDekaGram<T>(this BaseQuantity<T, AttoGram> val) where T:IConvertible {
        return new Quantity<double, DekaGram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoGram to DeciGram
    /// </summary>
    /// <param name="val">quantity measured in AttoGram</param>
    /// <returns>quantity measured in DeciGram</returns>
	public static Quantity<double, DeciGram> ToDeciGram<T>(this BaseQuantity<T, AttoGram> val) where T:IConvertible {
        return new Quantity<double, DeciGram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoGram to CentiGram
    /// </summary>
    /// <param name="val">quantity measured in AttoGram</param>
    /// <returns>quantity measured in CentiGram</returns>
	public static Quantity<double, CentiGram> ToCentiGram<T>(this BaseQuantity<T, AttoGram> val) where T:IConvertible {
        return new Quantity<double, CentiGram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoGram to MilliGram
    /// </summary>
    /// <param name="val">quantity measured in AttoGram</param>
    /// <returns>quantity measured in MilliGram</returns>
	public static Quantity<double, MilliGram> ToMilliGram<T>(this BaseQuantity<T, AttoGram> val) where T:IConvertible {
        return new Quantity<double, MilliGram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoGram to MicroGram
    /// </summary>
    /// <param name="val">quantity measured in AttoGram</param>
    /// <returns>quantity measured in MicroGram</returns>
	public static Quantity<double, MicroGram> ToMicroGram<T>(this BaseQuantity<T, AttoGram> val) where T:IConvertible {
        return new Quantity<double, MicroGram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoGram to NanoGram
    /// </summary>
    /// <param name="val">quantity measured in AttoGram</param>
    /// <returns>quantity measured in NanoGram</returns>
	public static Quantity<double, NanoGram> ToNanoGram<T>(this BaseQuantity<T, AttoGram> val) where T:IConvertible {
        return new Quantity<double, NanoGram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoGram to PicoGram
    /// </summary>
    /// <param name="val">quantity measured in AttoGram</param>
    /// <returns>quantity measured in PicoGram</returns>
	public static Quantity<double, PicoGram> ToPicoGram<T>(this BaseQuantity<T, AttoGram> val) where T:IConvertible {
        return new Quantity<double, PicoGram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoGram to FemtoGram
    /// </summary>
    /// <param name="val">quantity measured in AttoGram</param>
    /// <returns>quantity measured in FemtoGram</returns>
	public static Quantity<double, FemtoGram> ToFemtoGram<T>(this BaseQuantity<T, AttoGram> val) where T:IConvertible {
        return new Quantity<double, FemtoGram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoGram to ZeptoGram
    /// </summary>
    /// <param name="val">quantity measured in AttoGram</param>
    /// <returns>quantity measured in ZeptoGram</returns>
	public static Quantity<double, ZeptoGram> ToZeptoGram<T>(this BaseQuantity<T, AttoGram> val) where T:IConvertible {
        return new Quantity<double, ZeptoGram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoGram to YoctoGram
    /// </summary>
    /// <param name="val">quantity measured in AttoGram</param>
    /// <returns>quantity measured in YoctoGram</returns>
	public static Quantity<double, YoctoGram> ToYoctoGram<T>(this BaseQuantity<T, AttoGram> val) where T:IConvertible {
        return new Quantity<double, YoctoGram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoGram to YottaGram
    /// </summary>
    /// <param name="val">quantity measured in ZeptoGram</param>
    /// <returns>quantity measured in YottaGram</returns>
	public static Quantity<double, YottaGram> ToYottaGram<T>(this BaseQuantity<T, ZeptoGram> val) where T:IConvertible {
        return new Quantity<double, YottaGram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoGram to ZettaGram
    /// </summary>
    /// <param name="val">quantity measured in ZeptoGram</param>
    /// <returns>quantity measured in ZettaGram</returns>
	public static Quantity<double, ZettaGram> ToZettaGram<T>(this BaseQuantity<T, ZeptoGram> val) where T:IConvertible {
        return new Quantity<double, ZettaGram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoGram to ExaGram
    /// </summary>
    /// <param name="val">quantity measured in ZeptoGram</param>
    /// <returns>quantity measured in ExaGram</returns>
	public static Quantity<double, ExaGram> ToExaGram<T>(this BaseQuantity<T, ZeptoGram> val) where T:IConvertible {
        return new Quantity<double, ExaGram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoGram to PetaGram
    /// </summary>
    /// <param name="val">quantity measured in ZeptoGram</param>
    /// <returns>quantity measured in PetaGram</returns>
	public static Quantity<double, PetaGram> ToPetaGram<T>(this BaseQuantity<T, ZeptoGram> val) where T:IConvertible {
        return new Quantity<double, PetaGram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoGram to TeraGram
    /// </summary>
    /// <param name="val">quantity measured in ZeptoGram</param>
    /// <returns>quantity measured in TeraGram</returns>
	public static Quantity<double, TeraGram> ToTeraGram<T>(this BaseQuantity<T, ZeptoGram> val) where T:IConvertible {
        return new Quantity<double, TeraGram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoGram to GigaGram
    /// </summary>
    /// <param name="val">quantity measured in ZeptoGram</param>
    /// <returns>quantity measured in GigaGram</returns>
	public static Quantity<double, GigaGram> ToGigaGram<T>(this BaseQuantity<T, ZeptoGram> val) where T:IConvertible {
        return new Quantity<double, GigaGram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoGram to MegaGram
    /// </summary>
    /// <param name="val">quantity measured in ZeptoGram</param>
    /// <returns>quantity measured in MegaGram</returns>
	public static Quantity<double, MegaGram> ToMegaGram<T>(this BaseQuantity<T, ZeptoGram> val) where T:IConvertible {
        return new Quantity<double, MegaGram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoGram to KiloGram
    /// </summary>
    /// <param name="val">quantity measured in ZeptoGram</param>
    /// <returns>quantity measured in KiloGram</returns>
	public static Quantity<double, KiloGram> ToKiloGram<T>(this BaseQuantity<T, ZeptoGram> val) where T:IConvertible {
        return new Quantity<double, KiloGram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoGram to HectoGram
    /// </summary>
    /// <param name="val">quantity measured in ZeptoGram</param>
    /// <returns>quantity measured in HectoGram</returns>
	public static Quantity<double, HectoGram> ToHectoGram<T>(this BaseQuantity<T, ZeptoGram> val) where T:IConvertible {
        return new Quantity<double, HectoGram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoGram to DekaGram
    /// </summary>
    /// <param name="val">quantity measured in ZeptoGram</param>
    /// <returns>quantity measured in DekaGram</returns>
	public static Quantity<double, DekaGram> ToDekaGram<T>(this BaseQuantity<T, ZeptoGram> val) where T:IConvertible {
        return new Quantity<double, DekaGram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoGram to DeciGram
    /// </summary>
    /// <param name="val">quantity measured in ZeptoGram</param>
    /// <returns>quantity measured in DeciGram</returns>
	public static Quantity<double, DeciGram> ToDeciGram<T>(this BaseQuantity<T, ZeptoGram> val) where T:IConvertible {
        return new Quantity<double, DeciGram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoGram to CentiGram
    /// </summary>
    /// <param name="val">quantity measured in ZeptoGram</param>
    /// <returns>quantity measured in CentiGram</returns>
	public static Quantity<double, CentiGram> ToCentiGram<T>(this BaseQuantity<T, ZeptoGram> val) where T:IConvertible {
        return new Quantity<double, CentiGram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoGram to MilliGram
    /// </summary>
    /// <param name="val">quantity measured in ZeptoGram</param>
    /// <returns>quantity measured in MilliGram</returns>
	public static Quantity<double, MilliGram> ToMilliGram<T>(this BaseQuantity<T, ZeptoGram> val) where T:IConvertible {
        return new Quantity<double, MilliGram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoGram to MicroGram
    /// </summary>
    /// <param name="val">quantity measured in ZeptoGram</param>
    /// <returns>quantity measured in MicroGram</returns>
	public static Quantity<double, MicroGram> ToMicroGram<T>(this BaseQuantity<T, ZeptoGram> val) where T:IConvertible {
        return new Quantity<double, MicroGram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoGram to NanoGram
    /// </summary>
    /// <param name="val">quantity measured in ZeptoGram</param>
    /// <returns>quantity measured in NanoGram</returns>
	public static Quantity<double, NanoGram> ToNanoGram<T>(this BaseQuantity<T, ZeptoGram> val) where T:IConvertible {
        return new Quantity<double, NanoGram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoGram to PicoGram
    /// </summary>
    /// <param name="val">quantity measured in ZeptoGram</param>
    /// <returns>quantity measured in PicoGram</returns>
	public static Quantity<double, PicoGram> ToPicoGram<T>(this BaseQuantity<T, ZeptoGram> val) where T:IConvertible {
        return new Quantity<double, PicoGram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoGram to FemtoGram
    /// </summary>
    /// <param name="val">quantity measured in ZeptoGram</param>
    /// <returns>quantity measured in FemtoGram</returns>
	public static Quantity<double, FemtoGram> ToFemtoGram<T>(this BaseQuantity<T, ZeptoGram> val) where T:IConvertible {
        return new Quantity<double, FemtoGram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoGram to AttoGram
    /// </summary>
    /// <param name="val">quantity measured in ZeptoGram</param>
    /// <returns>quantity measured in AttoGram</returns>
	public static Quantity<double, AttoGram> ToAttoGram<T>(this BaseQuantity<T, ZeptoGram> val) where T:IConvertible {
        return new Quantity<double, AttoGram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoGram to YoctoGram
    /// </summary>
    /// <param name="val">quantity measured in ZeptoGram</param>
    /// <returns>quantity measured in YoctoGram</returns>
	public static Quantity<double, YoctoGram> ToYoctoGram<T>(this BaseQuantity<T, ZeptoGram> val) where T:IConvertible {
        return new Quantity<double, YoctoGram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert YoctoGram to YottaGram
    /// </summary>
    /// <param name="val">quantity measured in YoctoGram</param>
    /// <returns>quantity measured in YottaGram</returns>
	public static Quantity<double, YottaGram> ToYottaGram<T>(this BaseQuantity<T, YoctoGram> val) where T:IConvertible {
        return new Quantity<double, YottaGram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoGram to ZettaGram
    /// </summary>
    /// <param name="val">quantity measured in YoctoGram</param>
    /// <returns>quantity measured in ZettaGram</returns>
	public static Quantity<double, ZettaGram> ToZettaGram<T>(this BaseQuantity<T, YoctoGram> val) where T:IConvertible {
        return new Quantity<double, ZettaGram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoGram to ExaGram
    /// </summary>
    /// <param name="val">quantity measured in YoctoGram</param>
    /// <returns>quantity measured in ExaGram</returns>
	public static Quantity<double, ExaGram> ToExaGram<T>(this BaseQuantity<T, YoctoGram> val) where T:IConvertible {
        return new Quantity<double, ExaGram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoGram to PetaGram
    /// </summary>
    /// <param name="val">quantity measured in YoctoGram</param>
    /// <returns>quantity measured in PetaGram</returns>
	public static Quantity<double, PetaGram> ToPetaGram<T>(this BaseQuantity<T, YoctoGram> val) where T:IConvertible {
        return new Quantity<double, PetaGram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoGram to TeraGram
    /// </summary>
    /// <param name="val">quantity measured in YoctoGram</param>
    /// <returns>quantity measured in TeraGram</returns>
	public static Quantity<double, TeraGram> ToTeraGram<T>(this BaseQuantity<T, YoctoGram> val) where T:IConvertible {
        return new Quantity<double, TeraGram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoGram to GigaGram
    /// </summary>
    /// <param name="val">quantity measured in YoctoGram</param>
    /// <returns>quantity measured in GigaGram</returns>
	public static Quantity<double, GigaGram> ToGigaGram<T>(this BaseQuantity<T, YoctoGram> val) where T:IConvertible {
        return new Quantity<double, GigaGram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoGram to MegaGram
    /// </summary>
    /// <param name="val">quantity measured in YoctoGram</param>
    /// <returns>quantity measured in MegaGram</returns>
	public static Quantity<double, MegaGram> ToMegaGram<T>(this BaseQuantity<T, YoctoGram> val) where T:IConvertible {
        return new Quantity<double, MegaGram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoGram to KiloGram
    /// </summary>
    /// <param name="val">quantity measured in YoctoGram</param>
    /// <returns>quantity measured in KiloGram</returns>
	public static Quantity<double, KiloGram> ToKiloGram<T>(this BaseQuantity<T, YoctoGram> val) where T:IConvertible {
        return new Quantity<double, KiloGram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoGram to HectoGram
    /// </summary>
    /// <param name="val">quantity measured in YoctoGram</param>
    /// <returns>quantity measured in HectoGram</returns>
	public static Quantity<double, HectoGram> ToHectoGram<T>(this BaseQuantity<T, YoctoGram> val) where T:IConvertible {
        return new Quantity<double, HectoGram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoGram to DekaGram
    /// </summary>
    /// <param name="val">quantity measured in YoctoGram</param>
    /// <returns>quantity measured in DekaGram</returns>
	public static Quantity<double, DekaGram> ToDekaGram<T>(this BaseQuantity<T, YoctoGram> val) where T:IConvertible {
        return new Quantity<double, DekaGram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoGram to DeciGram
    /// </summary>
    /// <param name="val">quantity measured in YoctoGram</param>
    /// <returns>quantity measured in DeciGram</returns>
	public static Quantity<double, DeciGram> ToDeciGram<T>(this BaseQuantity<T, YoctoGram> val) where T:IConvertible {
        return new Quantity<double, DeciGram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoGram to CentiGram
    /// </summary>
    /// <param name="val">quantity measured in YoctoGram</param>
    /// <returns>quantity measured in CentiGram</returns>
	public static Quantity<double, CentiGram> ToCentiGram<T>(this BaseQuantity<T, YoctoGram> val) where T:IConvertible {
        return new Quantity<double, CentiGram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoGram to MilliGram
    /// </summary>
    /// <param name="val">quantity measured in YoctoGram</param>
    /// <returns>quantity measured in MilliGram</returns>
	public static Quantity<double, MilliGram> ToMilliGram<T>(this BaseQuantity<T, YoctoGram> val) where T:IConvertible {
        return new Quantity<double, MilliGram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoGram to MicroGram
    /// </summary>
    /// <param name="val">quantity measured in YoctoGram</param>
    /// <returns>quantity measured in MicroGram</returns>
	public static Quantity<double, MicroGram> ToMicroGram<T>(this BaseQuantity<T, YoctoGram> val) where T:IConvertible {
        return new Quantity<double, MicroGram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoGram to NanoGram
    /// </summary>
    /// <param name="val">quantity measured in YoctoGram</param>
    /// <returns>quantity measured in NanoGram</returns>
	public static Quantity<double, NanoGram> ToNanoGram<T>(this BaseQuantity<T, YoctoGram> val) where T:IConvertible {
        return new Quantity<double, NanoGram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoGram to PicoGram
    /// </summary>
    /// <param name="val">quantity measured in YoctoGram</param>
    /// <returns>quantity measured in PicoGram</returns>
	public static Quantity<double, PicoGram> ToPicoGram<T>(this BaseQuantity<T, YoctoGram> val) where T:IConvertible {
        return new Quantity<double, PicoGram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoGram to FemtoGram
    /// </summary>
    /// <param name="val">quantity measured in YoctoGram</param>
    /// <returns>quantity measured in FemtoGram</returns>
	public static Quantity<double, FemtoGram> ToFemtoGram<T>(this BaseQuantity<T, YoctoGram> val) where T:IConvertible {
        return new Quantity<double, FemtoGram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoGram to AttoGram
    /// </summary>
    /// <param name="val">quantity measured in YoctoGram</param>
    /// <returns>quantity measured in AttoGram</returns>
	public static Quantity<double, AttoGram> ToAttoGram<T>(this BaseQuantity<T, YoctoGram> val) where T:IConvertible {
        return new Quantity<double, AttoGram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoGram to ZeptoGram
    /// </summary>
    /// <param name="val">quantity measured in YoctoGram</param>
    /// <returns>quantity measured in ZeptoGram</returns>
	public static Quantity<double, ZeptoGram> ToZeptoGram<T>(this BaseQuantity<T, YoctoGram> val) where T:IConvertible {
        return new Quantity<double, ZeptoGram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
}
}