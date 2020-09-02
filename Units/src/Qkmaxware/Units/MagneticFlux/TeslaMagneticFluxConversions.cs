using System;
namespace Qkmaxware.Units.MagneticFlux {
/// <summary>
/// Static class housing si-prefix conversions for the unit "TeslaMagneticFlux"
/// </summary>
public static class TeslaMagneticFluxConversions {
	/// <summary>
    /// Extension method to convert Tesla to YottaTesla
    /// </summary>
    /// <param name="val">quantity measured in Tesla</param>
    /// <returns>quantity measured in YottaTesla</returns>
	public static Quantity<double, YottaTesla> ToYottaTesla<T>(this BaseQuantity<T, Tesla> val) where T:IConvertible {
        return new Quantity<double, YottaTesla>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaTesla to Tesla
    /// </summary>
    /// <param name="val">quantity measured in YottaTesla</param>
    /// <returns>quantity measured in Tesla</returns>
	public static Quantity<double, Tesla> ToTesla<T>(this BaseQuantity<T, YottaTesla> val) where T:IConvertible {
        return new Quantity<double, Tesla>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Tesla to ZettaTesla
    /// </summary>
    /// <param name="val">quantity measured in Tesla</param>
    /// <returns>quantity measured in ZettaTesla</returns>
	public static Quantity<double, ZettaTesla> ToZettaTesla<T>(this BaseQuantity<T, Tesla> val) where T:IConvertible {
        return new Quantity<double, ZettaTesla>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaTesla to Tesla
    /// </summary>
    /// <param name="val">quantity measured in ZettaTesla</param>
    /// <returns>quantity measured in Tesla</returns>
	public static Quantity<double, Tesla> ToTesla<T>(this BaseQuantity<T, ZettaTesla> val) where T:IConvertible {
        return new Quantity<double, Tesla>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Tesla to ExaTesla
    /// </summary>
    /// <param name="val">quantity measured in Tesla</param>
    /// <returns>quantity measured in ExaTesla</returns>
	public static Quantity<double, ExaTesla> ToExaTesla<T>(this BaseQuantity<T, Tesla> val) where T:IConvertible {
        return new Quantity<double, ExaTesla>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaTesla to Tesla
    /// </summary>
    /// <param name="val">quantity measured in ExaTesla</param>
    /// <returns>quantity measured in Tesla</returns>
	public static Quantity<double, Tesla> ToTesla<T>(this BaseQuantity<T, ExaTesla> val) where T:IConvertible {
        return new Quantity<double, Tesla>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Tesla to PetaTesla
    /// </summary>
    /// <param name="val">quantity measured in Tesla</param>
    /// <returns>quantity measured in PetaTesla</returns>
	public static Quantity<double, PetaTesla> ToPetaTesla<T>(this BaseQuantity<T, Tesla> val) where T:IConvertible {
        return new Quantity<double, PetaTesla>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaTesla to Tesla
    /// </summary>
    /// <param name="val">quantity measured in PetaTesla</param>
    /// <returns>quantity measured in Tesla</returns>
	public static Quantity<double, Tesla> ToTesla<T>(this BaseQuantity<T, PetaTesla> val) where T:IConvertible {
        return new Quantity<double, Tesla>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Tesla to TeraTesla
    /// </summary>
    /// <param name="val">quantity measured in Tesla</param>
    /// <returns>quantity measured in TeraTesla</returns>
	public static Quantity<double, TeraTesla> ToTeraTesla<T>(this BaseQuantity<T, Tesla> val) where T:IConvertible {
        return new Quantity<double, TeraTesla>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraTesla to Tesla
    /// </summary>
    /// <param name="val">quantity measured in TeraTesla</param>
    /// <returns>quantity measured in Tesla</returns>
	public static Quantity<double, Tesla> ToTesla<T>(this BaseQuantity<T, TeraTesla> val) where T:IConvertible {
        return new Quantity<double, Tesla>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Tesla to GigaTesla
    /// </summary>
    /// <param name="val">quantity measured in Tesla</param>
    /// <returns>quantity measured in GigaTesla</returns>
	public static Quantity<double, GigaTesla> ToGigaTesla<T>(this BaseQuantity<T, Tesla> val) where T:IConvertible {
        return new Quantity<double, GigaTesla>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaTesla to Tesla
    /// </summary>
    /// <param name="val">quantity measured in GigaTesla</param>
    /// <returns>quantity measured in Tesla</returns>
	public static Quantity<double, Tesla> ToTesla<T>(this BaseQuantity<T, GigaTesla> val) where T:IConvertible {
        return new Quantity<double, Tesla>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Tesla to MegaTesla
    /// </summary>
    /// <param name="val">quantity measured in Tesla</param>
    /// <returns>quantity measured in MegaTesla</returns>
	public static Quantity<double, MegaTesla> ToMegaTesla<T>(this BaseQuantity<T, Tesla> val) where T:IConvertible {
        return new Quantity<double, MegaTesla>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaTesla to Tesla
    /// </summary>
    /// <param name="val">quantity measured in MegaTesla</param>
    /// <returns>quantity measured in Tesla</returns>
	public static Quantity<double, Tesla> ToTesla<T>(this BaseQuantity<T, MegaTesla> val) where T:IConvertible {
        return new Quantity<double, Tesla>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Tesla to KiloTesla
    /// </summary>
    /// <param name="val">quantity measured in Tesla</param>
    /// <returns>quantity measured in KiloTesla</returns>
	public static Quantity<double, KiloTesla> ToKiloTesla<T>(this BaseQuantity<T, Tesla> val) where T:IConvertible {
        return new Quantity<double, KiloTesla>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloTesla to Tesla
    /// </summary>
    /// <param name="val">quantity measured in KiloTesla</param>
    /// <returns>quantity measured in Tesla</returns>
	public static Quantity<double, Tesla> ToTesla<T>(this BaseQuantity<T, KiloTesla> val) where T:IConvertible {
        return new Quantity<double, Tesla>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Tesla to HectoTesla
    /// </summary>
    /// <param name="val">quantity measured in Tesla</param>
    /// <returns>quantity measured in HectoTesla</returns>
	public static Quantity<double, HectoTesla> ToHectoTesla<T>(this BaseQuantity<T, Tesla> val) where T:IConvertible {
        return new Quantity<double, HectoTesla>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoTesla to Tesla
    /// </summary>
    /// <param name="val">quantity measured in HectoTesla</param>
    /// <returns>quantity measured in Tesla</returns>
	public static Quantity<double, Tesla> ToTesla<T>(this BaseQuantity<T, HectoTesla> val) where T:IConvertible {
        return new Quantity<double, Tesla>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Tesla to DekaTesla
    /// </summary>
    /// <param name="val">quantity measured in Tesla</param>
    /// <returns>quantity measured in DekaTesla</returns>
	public static Quantity<double, DekaTesla> ToDekaTesla<T>(this BaseQuantity<T, Tesla> val) where T:IConvertible {
        return new Quantity<double, DekaTesla>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaTesla to Tesla
    /// </summary>
    /// <param name="val">quantity measured in DekaTesla</param>
    /// <returns>quantity measured in Tesla</returns>
	public static Quantity<double, Tesla> ToTesla<T>(this BaseQuantity<T, DekaTesla> val) where T:IConvertible {
        return new Quantity<double, Tesla>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Tesla to DeciTesla
    /// </summary>
    /// <param name="val">quantity measured in Tesla</param>
    /// <returns>quantity measured in DeciTesla</returns>
	public static Quantity<double, DeciTesla> ToDeciTesla<T>(this BaseQuantity<T, Tesla> val) where T:IConvertible {
        return new Quantity<double, DeciTesla>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciTesla to Tesla
    /// </summary>
    /// <param name="val">quantity measured in DeciTesla</param>
    /// <returns>quantity measured in Tesla</returns>
	public static Quantity<double, Tesla> ToTesla<T>(this BaseQuantity<T, DeciTesla> val) where T:IConvertible {
        return new Quantity<double, Tesla>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Tesla to CentiTesla
    /// </summary>
    /// <param name="val">quantity measured in Tesla</param>
    /// <returns>quantity measured in CentiTesla</returns>
	public static Quantity<double, CentiTesla> ToCentiTesla<T>(this BaseQuantity<T, Tesla> val) where T:IConvertible {
        return new Quantity<double, CentiTesla>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiTesla to Tesla
    /// </summary>
    /// <param name="val">quantity measured in CentiTesla</param>
    /// <returns>quantity measured in Tesla</returns>
	public static Quantity<double, Tesla> ToTesla<T>(this BaseQuantity<T, CentiTesla> val) where T:IConvertible {
        return new Quantity<double, Tesla>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Tesla to MilliTesla
    /// </summary>
    /// <param name="val">quantity measured in Tesla</param>
    /// <returns>quantity measured in MilliTesla</returns>
	public static Quantity<double, MilliTesla> ToMilliTesla<T>(this BaseQuantity<T, Tesla> val) where T:IConvertible {
        return new Quantity<double, MilliTesla>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliTesla to Tesla
    /// </summary>
    /// <param name="val">quantity measured in MilliTesla</param>
    /// <returns>quantity measured in Tesla</returns>
	public static Quantity<double, Tesla> ToTesla<T>(this BaseQuantity<T, MilliTesla> val) where T:IConvertible {
        return new Quantity<double, Tesla>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Tesla to MicroTesla
    /// </summary>
    /// <param name="val">quantity measured in Tesla</param>
    /// <returns>quantity measured in MicroTesla</returns>
	public static Quantity<double, MicroTesla> ToMicroTesla<T>(this BaseQuantity<T, Tesla> val) where T:IConvertible {
        return new Quantity<double, MicroTesla>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroTesla to Tesla
    /// </summary>
    /// <param name="val">quantity measured in MicroTesla</param>
    /// <returns>quantity measured in Tesla</returns>
	public static Quantity<double, Tesla> ToTesla<T>(this BaseQuantity<T, MicroTesla> val) where T:IConvertible {
        return new Quantity<double, Tesla>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Tesla to NanoTesla
    /// </summary>
    /// <param name="val">quantity measured in Tesla</param>
    /// <returns>quantity measured in NanoTesla</returns>
	public static Quantity<double, NanoTesla> ToNanoTesla<T>(this BaseQuantity<T, Tesla> val) where T:IConvertible {
        return new Quantity<double, NanoTesla>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoTesla to Tesla
    /// </summary>
    /// <param name="val">quantity measured in NanoTesla</param>
    /// <returns>quantity measured in Tesla</returns>
	public static Quantity<double, Tesla> ToTesla<T>(this BaseQuantity<T, NanoTesla> val) where T:IConvertible {
        return new Quantity<double, Tesla>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Tesla to PicoTesla
    /// </summary>
    /// <param name="val">quantity measured in Tesla</param>
    /// <returns>quantity measured in PicoTesla</returns>
	public static Quantity<double, PicoTesla> ToPicoTesla<T>(this BaseQuantity<T, Tesla> val) where T:IConvertible {
        return new Quantity<double, PicoTesla>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoTesla to Tesla
    /// </summary>
    /// <param name="val">quantity measured in PicoTesla</param>
    /// <returns>quantity measured in Tesla</returns>
	public static Quantity<double, Tesla> ToTesla<T>(this BaseQuantity<T, PicoTesla> val) where T:IConvertible {
        return new Quantity<double, Tesla>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Tesla to FemtoTesla
    /// </summary>
    /// <param name="val">quantity measured in Tesla</param>
    /// <returns>quantity measured in FemtoTesla</returns>
	public static Quantity<double, FemtoTesla> ToFemtoTesla<T>(this BaseQuantity<T, Tesla> val) where T:IConvertible {
        return new Quantity<double, FemtoTesla>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoTesla to Tesla
    /// </summary>
    /// <param name="val">quantity measured in FemtoTesla</param>
    /// <returns>quantity measured in Tesla</returns>
	public static Quantity<double, Tesla> ToTesla<T>(this BaseQuantity<T, FemtoTesla> val) where T:IConvertible {
        return new Quantity<double, Tesla>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Tesla to AttoTesla
    /// </summary>
    /// <param name="val">quantity measured in Tesla</param>
    /// <returns>quantity measured in AttoTesla</returns>
	public static Quantity<double, AttoTesla> ToAttoTesla<T>(this BaseQuantity<T, Tesla> val) where T:IConvertible {
        return new Quantity<double, AttoTesla>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoTesla to Tesla
    /// </summary>
    /// <param name="val">quantity measured in AttoTesla</param>
    /// <returns>quantity measured in Tesla</returns>
	public static Quantity<double, Tesla> ToTesla<T>(this BaseQuantity<T, AttoTesla> val) where T:IConvertible {
        return new Quantity<double, Tesla>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Tesla to ZeptoTesla
    /// </summary>
    /// <param name="val">quantity measured in Tesla</param>
    /// <returns>quantity measured in ZeptoTesla</returns>
	public static Quantity<double, ZeptoTesla> ToZeptoTesla<T>(this BaseQuantity<T, Tesla> val) where T:IConvertible {
        return new Quantity<double, ZeptoTesla>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoTesla to Tesla
    /// </summary>
    /// <param name="val">quantity measured in ZeptoTesla</param>
    /// <returns>quantity measured in Tesla</returns>
	public static Quantity<double, Tesla> ToTesla<T>(this BaseQuantity<T, ZeptoTesla> val) where T:IConvertible {
        return new Quantity<double, Tesla>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Tesla to YoctoTesla
    /// </summary>
    /// <param name="val">quantity measured in Tesla</param>
    /// <returns>quantity measured in YoctoTesla</returns>
	public static Quantity<double, YoctoTesla> ToYoctoTesla<T>(this BaseQuantity<T, Tesla> val) where T:IConvertible {
        return new Quantity<double, YoctoTesla>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoTesla to Tesla
    /// </summary>
    /// <param name="val">quantity measured in YoctoTesla</param>
    /// <returns>quantity measured in Tesla</returns>
	public static Quantity<double, Tesla> ToTesla<T>(this BaseQuantity<T, YoctoTesla> val) where T:IConvertible {
        return new Quantity<double, Tesla>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaTesla to ZettaTesla
    /// </summary>
    /// <param name="val">quantity measured in YottaTesla</param>
    /// <returns>quantity measured in ZettaTesla</returns>
	public static Quantity<double, ZettaTesla> ToZettaTesla<T>(this BaseQuantity<T, YottaTesla> val) where T:IConvertible {
        return new Quantity<double, ZettaTesla>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaTesla to ExaTesla
    /// </summary>
    /// <param name="val">quantity measured in YottaTesla</param>
    /// <returns>quantity measured in ExaTesla</returns>
	public static Quantity<double, ExaTesla> ToExaTesla<T>(this BaseQuantity<T, YottaTesla> val) where T:IConvertible {
        return new Quantity<double, ExaTesla>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaTesla to PetaTesla
    /// </summary>
    /// <param name="val">quantity measured in YottaTesla</param>
    /// <returns>quantity measured in PetaTesla</returns>
	public static Quantity<double, PetaTesla> ToPetaTesla<T>(this BaseQuantity<T, YottaTesla> val) where T:IConvertible {
        return new Quantity<double, PetaTesla>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaTesla to TeraTesla
    /// </summary>
    /// <param name="val">quantity measured in YottaTesla</param>
    /// <returns>quantity measured in TeraTesla</returns>
	public static Quantity<double, TeraTesla> ToTeraTesla<T>(this BaseQuantity<T, YottaTesla> val) where T:IConvertible {
        return new Quantity<double, TeraTesla>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaTesla to GigaTesla
    /// </summary>
    /// <param name="val">quantity measured in YottaTesla</param>
    /// <returns>quantity measured in GigaTesla</returns>
	public static Quantity<double, GigaTesla> ToGigaTesla<T>(this BaseQuantity<T, YottaTesla> val) where T:IConvertible {
        return new Quantity<double, GigaTesla>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaTesla to MegaTesla
    /// </summary>
    /// <param name="val">quantity measured in YottaTesla</param>
    /// <returns>quantity measured in MegaTesla</returns>
	public static Quantity<double, MegaTesla> ToMegaTesla<T>(this BaseQuantity<T, YottaTesla> val) where T:IConvertible {
        return new Quantity<double, MegaTesla>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaTesla to KiloTesla
    /// </summary>
    /// <param name="val">quantity measured in YottaTesla</param>
    /// <returns>quantity measured in KiloTesla</returns>
	public static Quantity<double, KiloTesla> ToKiloTesla<T>(this BaseQuantity<T, YottaTesla> val) where T:IConvertible {
        return new Quantity<double, KiloTesla>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaTesla to HectoTesla
    /// </summary>
    /// <param name="val">quantity measured in YottaTesla</param>
    /// <returns>quantity measured in HectoTesla</returns>
	public static Quantity<double, HectoTesla> ToHectoTesla<T>(this BaseQuantity<T, YottaTesla> val) where T:IConvertible {
        return new Quantity<double, HectoTesla>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaTesla to DekaTesla
    /// </summary>
    /// <param name="val">quantity measured in YottaTesla</param>
    /// <returns>quantity measured in DekaTesla</returns>
	public static Quantity<double, DekaTesla> ToDekaTesla<T>(this BaseQuantity<T, YottaTesla> val) where T:IConvertible {
        return new Quantity<double, DekaTesla>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaTesla to DeciTesla
    /// </summary>
    /// <param name="val">quantity measured in YottaTesla</param>
    /// <returns>quantity measured in DeciTesla</returns>
	public static Quantity<double, DeciTesla> ToDeciTesla<T>(this BaseQuantity<T, YottaTesla> val) where T:IConvertible {
        return new Quantity<double, DeciTesla>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaTesla to CentiTesla
    /// </summary>
    /// <param name="val">quantity measured in YottaTesla</param>
    /// <returns>quantity measured in CentiTesla</returns>
	public static Quantity<double, CentiTesla> ToCentiTesla<T>(this BaseQuantity<T, YottaTesla> val) where T:IConvertible {
        return new Quantity<double, CentiTesla>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaTesla to MilliTesla
    /// </summary>
    /// <param name="val">quantity measured in YottaTesla</param>
    /// <returns>quantity measured in MilliTesla</returns>
	public static Quantity<double, MilliTesla> ToMilliTesla<T>(this BaseQuantity<T, YottaTesla> val) where T:IConvertible {
        return new Quantity<double, MilliTesla>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaTesla to MicroTesla
    /// </summary>
    /// <param name="val">quantity measured in YottaTesla</param>
    /// <returns>quantity measured in MicroTesla</returns>
	public static Quantity<double, MicroTesla> ToMicroTesla<T>(this BaseQuantity<T, YottaTesla> val) where T:IConvertible {
        return new Quantity<double, MicroTesla>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaTesla to NanoTesla
    /// </summary>
    /// <param name="val">quantity measured in YottaTesla</param>
    /// <returns>quantity measured in NanoTesla</returns>
	public static Quantity<double, NanoTesla> ToNanoTesla<T>(this BaseQuantity<T, YottaTesla> val) where T:IConvertible {
        return new Quantity<double, NanoTesla>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaTesla to PicoTesla
    /// </summary>
    /// <param name="val">quantity measured in YottaTesla</param>
    /// <returns>quantity measured in PicoTesla</returns>
	public static Quantity<double, PicoTesla> ToPicoTesla<T>(this BaseQuantity<T, YottaTesla> val) where T:IConvertible {
        return new Quantity<double, PicoTesla>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaTesla to FemtoTesla
    /// </summary>
    /// <param name="val">quantity measured in YottaTesla</param>
    /// <returns>quantity measured in FemtoTesla</returns>
	public static Quantity<double, FemtoTesla> ToFemtoTesla<T>(this BaseQuantity<T, YottaTesla> val) where T:IConvertible {
        return new Quantity<double, FemtoTesla>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaTesla to AttoTesla
    /// </summary>
    /// <param name="val">quantity measured in YottaTesla</param>
    /// <returns>quantity measured in AttoTesla</returns>
	public static Quantity<double, AttoTesla> ToAttoTesla<T>(this BaseQuantity<T, YottaTesla> val) where T:IConvertible {
        return new Quantity<double, AttoTesla>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaTesla to ZeptoTesla
    /// </summary>
    /// <param name="val">quantity measured in YottaTesla</param>
    /// <returns>quantity measured in ZeptoTesla</returns>
	public static Quantity<double, ZeptoTesla> ToZeptoTesla<T>(this BaseQuantity<T, YottaTesla> val) where T:IConvertible {
        return new Quantity<double, ZeptoTesla>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert YottaTesla to YoctoTesla
    /// </summary>
    /// <param name="val">quantity measured in YottaTesla</param>
    /// <returns>quantity measured in YoctoTesla</returns>
	public static Quantity<double, YoctoTesla> ToYoctoTesla<T>(this BaseQuantity<T, YottaTesla> val) where T:IConvertible {
        return new Quantity<double, YoctoTesla>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert ZettaTesla to YottaTesla
    /// </summary>
    /// <param name="val">quantity measured in ZettaTesla</param>
    /// <returns>quantity measured in YottaTesla</returns>
	public static Quantity<double, YottaTesla> ToYottaTesla<T>(this BaseQuantity<T, ZettaTesla> val) where T:IConvertible {
        return new Quantity<double, YottaTesla>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaTesla to ExaTesla
    /// </summary>
    /// <param name="val">quantity measured in ZettaTesla</param>
    /// <returns>quantity measured in ExaTesla</returns>
	public static Quantity<double, ExaTesla> ToExaTesla<T>(this BaseQuantity<T, ZettaTesla> val) where T:IConvertible {
        return new Quantity<double, ExaTesla>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaTesla to PetaTesla
    /// </summary>
    /// <param name="val">quantity measured in ZettaTesla</param>
    /// <returns>quantity measured in PetaTesla</returns>
	public static Quantity<double, PetaTesla> ToPetaTesla<T>(this BaseQuantity<T, ZettaTesla> val) where T:IConvertible {
        return new Quantity<double, PetaTesla>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaTesla to TeraTesla
    /// </summary>
    /// <param name="val">quantity measured in ZettaTesla</param>
    /// <returns>quantity measured in TeraTesla</returns>
	public static Quantity<double, TeraTesla> ToTeraTesla<T>(this BaseQuantity<T, ZettaTesla> val) where T:IConvertible {
        return new Quantity<double, TeraTesla>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaTesla to GigaTesla
    /// </summary>
    /// <param name="val">quantity measured in ZettaTesla</param>
    /// <returns>quantity measured in GigaTesla</returns>
	public static Quantity<double, GigaTesla> ToGigaTesla<T>(this BaseQuantity<T, ZettaTesla> val) where T:IConvertible {
        return new Quantity<double, GigaTesla>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaTesla to MegaTesla
    /// </summary>
    /// <param name="val">quantity measured in ZettaTesla</param>
    /// <returns>quantity measured in MegaTesla</returns>
	public static Quantity<double, MegaTesla> ToMegaTesla<T>(this BaseQuantity<T, ZettaTesla> val) where T:IConvertible {
        return new Quantity<double, MegaTesla>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaTesla to KiloTesla
    /// </summary>
    /// <param name="val">quantity measured in ZettaTesla</param>
    /// <returns>quantity measured in KiloTesla</returns>
	public static Quantity<double, KiloTesla> ToKiloTesla<T>(this BaseQuantity<T, ZettaTesla> val) where T:IConvertible {
        return new Quantity<double, KiloTesla>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaTesla to HectoTesla
    /// </summary>
    /// <param name="val">quantity measured in ZettaTesla</param>
    /// <returns>quantity measured in HectoTesla</returns>
	public static Quantity<double, HectoTesla> ToHectoTesla<T>(this BaseQuantity<T, ZettaTesla> val) where T:IConvertible {
        return new Quantity<double, HectoTesla>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaTesla to DekaTesla
    /// </summary>
    /// <param name="val">quantity measured in ZettaTesla</param>
    /// <returns>quantity measured in DekaTesla</returns>
	public static Quantity<double, DekaTesla> ToDekaTesla<T>(this BaseQuantity<T, ZettaTesla> val) where T:IConvertible {
        return new Quantity<double, DekaTesla>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaTesla to DeciTesla
    /// </summary>
    /// <param name="val">quantity measured in ZettaTesla</param>
    /// <returns>quantity measured in DeciTesla</returns>
	public static Quantity<double, DeciTesla> ToDeciTesla<T>(this BaseQuantity<T, ZettaTesla> val) where T:IConvertible {
        return new Quantity<double, DeciTesla>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaTesla to CentiTesla
    /// </summary>
    /// <param name="val">quantity measured in ZettaTesla</param>
    /// <returns>quantity measured in CentiTesla</returns>
	public static Quantity<double, CentiTesla> ToCentiTesla<T>(this BaseQuantity<T, ZettaTesla> val) where T:IConvertible {
        return new Quantity<double, CentiTesla>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaTesla to MilliTesla
    /// </summary>
    /// <param name="val">quantity measured in ZettaTesla</param>
    /// <returns>quantity measured in MilliTesla</returns>
	public static Quantity<double, MilliTesla> ToMilliTesla<T>(this BaseQuantity<T, ZettaTesla> val) where T:IConvertible {
        return new Quantity<double, MilliTesla>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaTesla to MicroTesla
    /// </summary>
    /// <param name="val">quantity measured in ZettaTesla</param>
    /// <returns>quantity measured in MicroTesla</returns>
	public static Quantity<double, MicroTesla> ToMicroTesla<T>(this BaseQuantity<T, ZettaTesla> val) where T:IConvertible {
        return new Quantity<double, MicroTesla>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaTesla to NanoTesla
    /// </summary>
    /// <param name="val">quantity measured in ZettaTesla</param>
    /// <returns>quantity measured in NanoTesla</returns>
	public static Quantity<double, NanoTesla> ToNanoTesla<T>(this BaseQuantity<T, ZettaTesla> val) where T:IConvertible {
        return new Quantity<double, NanoTesla>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaTesla to PicoTesla
    /// </summary>
    /// <param name="val">quantity measured in ZettaTesla</param>
    /// <returns>quantity measured in PicoTesla</returns>
	public static Quantity<double, PicoTesla> ToPicoTesla<T>(this BaseQuantity<T, ZettaTesla> val) where T:IConvertible {
        return new Quantity<double, PicoTesla>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaTesla to FemtoTesla
    /// </summary>
    /// <param name="val">quantity measured in ZettaTesla</param>
    /// <returns>quantity measured in FemtoTesla</returns>
	public static Quantity<double, FemtoTesla> ToFemtoTesla<T>(this BaseQuantity<T, ZettaTesla> val) where T:IConvertible {
        return new Quantity<double, FemtoTesla>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaTesla to AttoTesla
    /// </summary>
    /// <param name="val">quantity measured in ZettaTesla</param>
    /// <returns>quantity measured in AttoTesla</returns>
	public static Quantity<double, AttoTesla> ToAttoTesla<T>(this BaseQuantity<T, ZettaTesla> val) where T:IConvertible {
        return new Quantity<double, AttoTesla>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaTesla to ZeptoTesla
    /// </summary>
    /// <param name="val">quantity measured in ZettaTesla</param>
    /// <returns>quantity measured in ZeptoTesla</returns>
	public static Quantity<double, ZeptoTesla> ToZeptoTesla<T>(this BaseQuantity<T, ZettaTesla> val) where T:IConvertible {
        return new Quantity<double, ZeptoTesla>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ZettaTesla to YoctoTesla
    /// </summary>
    /// <param name="val">quantity measured in ZettaTesla</param>
    /// <returns>quantity measured in YoctoTesla</returns>
	public static Quantity<double, YoctoTesla> ToYoctoTesla<T>(this BaseQuantity<T, ZettaTesla> val) where T:IConvertible {
        return new Quantity<double, YoctoTesla>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert ExaTesla to YottaTesla
    /// </summary>
    /// <param name="val">quantity measured in ExaTesla</param>
    /// <returns>quantity measured in YottaTesla</returns>
	public static Quantity<double, YottaTesla> ToYottaTesla<T>(this BaseQuantity<T, ExaTesla> val) where T:IConvertible {
        return new Quantity<double, YottaTesla>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaTesla to ZettaTesla
    /// </summary>
    /// <param name="val">quantity measured in ExaTesla</param>
    /// <returns>quantity measured in ZettaTesla</returns>
	public static Quantity<double, ZettaTesla> ToZettaTesla<T>(this BaseQuantity<T, ExaTesla> val) where T:IConvertible {
        return new Quantity<double, ZettaTesla>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaTesla to PetaTesla
    /// </summary>
    /// <param name="val">quantity measured in ExaTesla</param>
    /// <returns>quantity measured in PetaTesla</returns>
	public static Quantity<double, PetaTesla> ToPetaTesla<T>(this BaseQuantity<T, ExaTesla> val) where T:IConvertible {
        return new Quantity<double, PetaTesla>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaTesla to TeraTesla
    /// </summary>
    /// <param name="val">quantity measured in ExaTesla</param>
    /// <returns>quantity measured in TeraTesla</returns>
	public static Quantity<double, TeraTesla> ToTeraTesla<T>(this BaseQuantity<T, ExaTesla> val) where T:IConvertible {
        return new Quantity<double, TeraTesla>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaTesla to GigaTesla
    /// </summary>
    /// <param name="val">quantity measured in ExaTesla</param>
    /// <returns>quantity measured in GigaTesla</returns>
	public static Quantity<double, GigaTesla> ToGigaTesla<T>(this BaseQuantity<T, ExaTesla> val) where T:IConvertible {
        return new Quantity<double, GigaTesla>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaTesla to MegaTesla
    /// </summary>
    /// <param name="val">quantity measured in ExaTesla</param>
    /// <returns>quantity measured in MegaTesla</returns>
	public static Quantity<double, MegaTesla> ToMegaTesla<T>(this BaseQuantity<T, ExaTesla> val) where T:IConvertible {
        return new Quantity<double, MegaTesla>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaTesla to KiloTesla
    /// </summary>
    /// <param name="val">quantity measured in ExaTesla</param>
    /// <returns>quantity measured in KiloTesla</returns>
	public static Quantity<double, KiloTesla> ToKiloTesla<T>(this BaseQuantity<T, ExaTesla> val) where T:IConvertible {
        return new Quantity<double, KiloTesla>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaTesla to HectoTesla
    /// </summary>
    /// <param name="val">quantity measured in ExaTesla</param>
    /// <returns>quantity measured in HectoTesla</returns>
	public static Quantity<double, HectoTesla> ToHectoTesla<T>(this BaseQuantity<T, ExaTesla> val) where T:IConvertible {
        return new Quantity<double, HectoTesla>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaTesla to DekaTesla
    /// </summary>
    /// <param name="val">quantity measured in ExaTesla</param>
    /// <returns>quantity measured in DekaTesla</returns>
	public static Quantity<double, DekaTesla> ToDekaTesla<T>(this BaseQuantity<T, ExaTesla> val) where T:IConvertible {
        return new Quantity<double, DekaTesla>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaTesla to DeciTesla
    /// </summary>
    /// <param name="val">quantity measured in ExaTesla</param>
    /// <returns>quantity measured in DeciTesla</returns>
	public static Quantity<double, DeciTesla> ToDeciTesla<T>(this BaseQuantity<T, ExaTesla> val) where T:IConvertible {
        return new Quantity<double, DeciTesla>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaTesla to CentiTesla
    /// </summary>
    /// <param name="val">quantity measured in ExaTesla</param>
    /// <returns>quantity measured in CentiTesla</returns>
	public static Quantity<double, CentiTesla> ToCentiTesla<T>(this BaseQuantity<T, ExaTesla> val) where T:IConvertible {
        return new Quantity<double, CentiTesla>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaTesla to MilliTesla
    /// </summary>
    /// <param name="val">quantity measured in ExaTesla</param>
    /// <returns>quantity measured in MilliTesla</returns>
	public static Quantity<double, MilliTesla> ToMilliTesla<T>(this BaseQuantity<T, ExaTesla> val) where T:IConvertible {
        return new Quantity<double, MilliTesla>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaTesla to MicroTesla
    /// </summary>
    /// <param name="val">quantity measured in ExaTesla</param>
    /// <returns>quantity measured in MicroTesla</returns>
	public static Quantity<double, MicroTesla> ToMicroTesla<T>(this BaseQuantity<T, ExaTesla> val) where T:IConvertible {
        return new Quantity<double, MicroTesla>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaTesla to NanoTesla
    /// </summary>
    /// <param name="val">quantity measured in ExaTesla</param>
    /// <returns>quantity measured in NanoTesla</returns>
	public static Quantity<double, NanoTesla> ToNanoTesla<T>(this BaseQuantity<T, ExaTesla> val) where T:IConvertible {
        return new Quantity<double, NanoTesla>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaTesla to PicoTesla
    /// </summary>
    /// <param name="val">quantity measured in ExaTesla</param>
    /// <returns>quantity measured in PicoTesla</returns>
	public static Quantity<double, PicoTesla> ToPicoTesla<T>(this BaseQuantity<T, ExaTesla> val) where T:IConvertible {
        return new Quantity<double, PicoTesla>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaTesla to FemtoTesla
    /// </summary>
    /// <param name="val">quantity measured in ExaTesla</param>
    /// <returns>quantity measured in FemtoTesla</returns>
	public static Quantity<double, FemtoTesla> ToFemtoTesla<T>(this BaseQuantity<T, ExaTesla> val) where T:IConvertible {
        return new Quantity<double, FemtoTesla>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaTesla to AttoTesla
    /// </summary>
    /// <param name="val">quantity measured in ExaTesla</param>
    /// <returns>quantity measured in AttoTesla</returns>
	public static Quantity<double, AttoTesla> ToAttoTesla<T>(this BaseQuantity<T, ExaTesla> val) where T:IConvertible {
        return new Quantity<double, AttoTesla>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaTesla to ZeptoTesla
    /// </summary>
    /// <param name="val">quantity measured in ExaTesla</param>
    /// <returns>quantity measured in ZeptoTesla</returns>
	public static Quantity<double, ZeptoTesla> ToZeptoTesla<T>(this BaseQuantity<T, ExaTesla> val) where T:IConvertible {
        return new Quantity<double, ZeptoTesla>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert ExaTesla to YoctoTesla
    /// </summary>
    /// <param name="val">quantity measured in ExaTesla</param>
    /// <returns>quantity measured in YoctoTesla</returns>
	public static Quantity<double, YoctoTesla> ToYoctoTesla<T>(this BaseQuantity<T, ExaTesla> val) where T:IConvertible {
        return new Quantity<double, YoctoTesla>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert PetaTesla to YottaTesla
    /// </summary>
    /// <param name="val">quantity measured in PetaTesla</param>
    /// <returns>quantity measured in YottaTesla</returns>
	public static Quantity<double, YottaTesla> ToYottaTesla<T>(this BaseQuantity<T, PetaTesla> val) where T:IConvertible {
        return new Quantity<double, YottaTesla>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaTesla to ZettaTesla
    /// </summary>
    /// <param name="val">quantity measured in PetaTesla</param>
    /// <returns>quantity measured in ZettaTesla</returns>
	public static Quantity<double, ZettaTesla> ToZettaTesla<T>(this BaseQuantity<T, PetaTesla> val) where T:IConvertible {
        return new Quantity<double, ZettaTesla>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaTesla to ExaTesla
    /// </summary>
    /// <param name="val">quantity measured in PetaTesla</param>
    /// <returns>quantity measured in ExaTesla</returns>
	public static Quantity<double, ExaTesla> ToExaTesla<T>(this BaseQuantity<T, PetaTesla> val) where T:IConvertible {
        return new Quantity<double, ExaTesla>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaTesla to TeraTesla
    /// </summary>
    /// <param name="val">quantity measured in PetaTesla</param>
    /// <returns>quantity measured in TeraTesla</returns>
	public static Quantity<double, TeraTesla> ToTeraTesla<T>(this BaseQuantity<T, PetaTesla> val) where T:IConvertible {
        return new Quantity<double, TeraTesla>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaTesla to GigaTesla
    /// </summary>
    /// <param name="val">quantity measured in PetaTesla</param>
    /// <returns>quantity measured in GigaTesla</returns>
	public static Quantity<double, GigaTesla> ToGigaTesla<T>(this BaseQuantity<T, PetaTesla> val) where T:IConvertible {
        return new Quantity<double, GigaTesla>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaTesla to MegaTesla
    /// </summary>
    /// <param name="val">quantity measured in PetaTesla</param>
    /// <returns>quantity measured in MegaTesla</returns>
	public static Quantity<double, MegaTesla> ToMegaTesla<T>(this BaseQuantity<T, PetaTesla> val) where T:IConvertible {
        return new Quantity<double, MegaTesla>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaTesla to KiloTesla
    /// </summary>
    /// <param name="val">quantity measured in PetaTesla</param>
    /// <returns>quantity measured in KiloTesla</returns>
	public static Quantity<double, KiloTesla> ToKiloTesla<T>(this BaseQuantity<T, PetaTesla> val) where T:IConvertible {
        return new Quantity<double, KiloTesla>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaTesla to HectoTesla
    /// </summary>
    /// <param name="val">quantity measured in PetaTesla</param>
    /// <returns>quantity measured in HectoTesla</returns>
	public static Quantity<double, HectoTesla> ToHectoTesla<T>(this BaseQuantity<T, PetaTesla> val) where T:IConvertible {
        return new Quantity<double, HectoTesla>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaTesla to DekaTesla
    /// </summary>
    /// <param name="val">quantity measured in PetaTesla</param>
    /// <returns>quantity measured in DekaTesla</returns>
	public static Quantity<double, DekaTesla> ToDekaTesla<T>(this BaseQuantity<T, PetaTesla> val) where T:IConvertible {
        return new Quantity<double, DekaTesla>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaTesla to DeciTesla
    /// </summary>
    /// <param name="val">quantity measured in PetaTesla</param>
    /// <returns>quantity measured in DeciTesla</returns>
	public static Quantity<double, DeciTesla> ToDeciTesla<T>(this BaseQuantity<T, PetaTesla> val) where T:IConvertible {
        return new Quantity<double, DeciTesla>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaTesla to CentiTesla
    /// </summary>
    /// <param name="val">quantity measured in PetaTesla</param>
    /// <returns>quantity measured in CentiTesla</returns>
	public static Quantity<double, CentiTesla> ToCentiTesla<T>(this BaseQuantity<T, PetaTesla> val) where T:IConvertible {
        return new Quantity<double, CentiTesla>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaTesla to MilliTesla
    /// </summary>
    /// <param name="val">quantity measured in PetaTesla</param>
    /// <returns>quantity measured in MilliTesla</returns>
	public static Quantity<double, MilliTesla> ToMilliTesla<T>(this BaseQuantity<T, PetaTesla> val) where T:IConvertible {
        return new Quantity<double, MilliTesla>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaTesla to MicroTesla
    /// </summary>
    /// <param name="val">quantity measured in PetaTesla</param>
    /// <returns>quantity measured in MicroTesla</returns>
	public static Quantity<double, MicroTesla> ToMicroTesla<T>(this BaseQuantity<T, PetaTesla> val) where T:IConvertible {
        return new Quantity<double, MicroTesla>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaTesla to NanoTesla
    /// </summary>
    /// <param name="val">quantity measured in PetaTesla</param>
    /// <returns>quantity measured in NanoTesla</returns>
	public static Quantity<double, NanoTesla> ToNanoTesla<T>(this BaseQuantity<T, PetaTesla> val) where T:IConvertible {
        return new Quantity<double, NanoTesla>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaTesla to PicoTesla
    /// </summary>
    /// <param name="val">quantity measured in PetaTesla</param>
    /// <returns>quantity measured in PicoTesla</returns>
	public static Quantity<double, PicoTesla> ToPicoTesla<T>(this BaseQuantity<T, PetaTesla> val) where T:IConvertible {
        return new Quantity<double, PicoTesla>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaTesla to FemtoTesla
    /// </summary>
    /// <param name="val">quantity measured in PetaTesla</param>
    /// <returns>quantity measured in FemtoTesla</returns>
	public static Quantity<double, FemtoTesla> ToFemtoTesla<T>(this BaseQuantity<T, PetaTesla> val) where T:IConvertible {
        return new Quantity<double, FemtoTesla>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaTesla to AttoTesla
    /// </summary>
    /// <param name="val">quantity measured in PetaTesla</param>
    /// <returns>quantity measured in AttoTesla</returns>
	public static Quantity<double, AttoTesla> ToAttoTesla<T>(this BaseQuantity<T, PetaTesla> val) where T:IConvertible {
        return new Quantity<double, AttoTesla>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaTesla to ZeptoTesla
    /// </summary>
    /// <param name="val">quantity measured in PetaTesla</param>
    /// <returns>quantity measured in ZeptoTesla</returns>
	public static Quantity<double, ZeptoTesla> ToZeptoTesla<T>(this BaseQuantity<T, PetaTesla> val) where T:IConvertible {
        return new Quantity<double, ZeptoTesla>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert PetaTesla to YoctoTesla
    /// </summary>
    /// <param name="val">quantity measured in PetaTesla</param>
    /// <returns>quantity measured in YoctoTesla</returns>
	public static Quantity<double, YoctoTesla> ToYoctoTesla<T>(this BaseQuantity<T, PetaTesla> val) where T:IConvertible {
        return new Quantity<double, YoctoTesla>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert TeraTesla to YottaTesla
    /// </summary>
    /// <param name="val">quantity measured in TeraTesla</param>
    /// <returns>quantity measured in YottaTesla</returns>
	public static Quantity<double, YottaTesla> ToYottaTesla<T>(this BaseQuantity<T, TeraTesla> val) where T:IConvertible {
        return new Quantity<double, YottaTesla>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraTesla to ZettaTesla
    /// </summary>
    /// <param name="val">quantity measured in TeraTesla</param>
    /// <returns>quantity measured in ZettaTesla</returns>
	public static Quantity<double, ZettaTesla> ToZettaTesla<T>(this BaseQuantity<T, TeraTesla> val) where T:IConvertible {
        return new Quantity<double, ZettaTesla>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraTesla to ExaTesla
    /// </summary>
    /// <param name="val">quantity measured in TeraTesla</param>
    /// <returns>quantity measured in ExaTesla</returns>
	public static Quantity<double, ExaTesla> ToExaTesla<T>(this BaseQuantity<T, TeraTesla> val) where T:IConvertible {
        return new Quantity<double, ExaTesla>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraTesla to PetaTesla
    /// </summary>
    /// <param name="val">quantity measured in TeraTesla</param>
    /// <returns>quantity measured in PetaTesla</returns>
	public static Quantity<double, PetaTesla> ToPetaTesla<T>(this BaseQuantity<T, TeraTesla> val) where T:IConvertible {
        return new Quantity<double, PetaTesla>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraTesla to GigaTesla
    /// </summary>
    /// <param name="val">quantity measured in TeraTesla</param>
    /// <returns>quantity measured in GigaTesla</returns>
	public static Quantity<double, GigaTesla> ToGigaTesla<T>(this BaseQuantity<T, TeraTesla> val) where T:IConvertible {
        return new Quantity<double, GigaTesla>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraTesla to MegaTesla
    /// </summary>
    /// <param name="val">quantity measured in TeraTesla</param>
    /// <returns>quantity measured in MegaTesla</returns>
	public static Quantity<double, MegaTesla> ToMegaTesla<T>(this BaseQuantity<T, TeraTesla> val) where T:IConvertible {
        return new Quantity<double, MegaTesla>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraTesla to KiloTesla
    /// </summary>
    /// <param name="val">quantity measured in TeraTesla</param>
    /// <returns>quantity measured in KiloTesla</returns>
	public static Quantity<double, KiloTesla> ToKiloTesla<T>(this BaseQuantity<T, TeraTesla> val) where T:IConvertible {
        return new Quantity<double, KiloTesla>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraTesla to HectoTesla
    /// </summary>
    /// <param name="val">quantity measured in TeraTesla</param>
    /// <returns>quantity measured in HectoTesla</returns>
	public static Quantity<double, HectoTesla> ToHectoTesla<T>(this BaseQuantity<T, TeraTesla> val) where T:IConvertible {
        return new Quantity<double, HectoTesla>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraTesla to DekaTesla
    /// </summary>
    /// <param name="val">quantity measured in TeraTesla</param>
    /// <returns>quantity measured in DekaTesla</returns>
	public static Quantity<double, DekaTesla> ToDekaTesla<T>(this BaseQuantity<T, TeraTesla> val) where T:IConvertible {
        return new Quantity<double, DekaTesla>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraTesla to DeciTesla
    /// </summary>
    /// <param name="val">quantity measured in TeraTesla</param>
    /// <returns>quantity measured in DeciTesla</returns>
	public static Quantity<double, DeciTesla> ToDeciTesla<T>(this BaseQuantity<T, TeraTesla> val) where T:IConvertible {
        return new Quantity<double, DeciTesla>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraTesla to CentiTesla
    /// </summary>
    /// <param name="val">quantity measured in TeraTesla</param>
    /// <returns>quantity measured in CentiTesla</returns>
	public static Quantity<double, CentiTesla> ToCentiTesla<T>(this BaseQuantity<T, TeraTesla> val) where T:IConvertible {
        return new Quantity<double, CentiTesla>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraTesla to MilliTesla
    /// </summary>
    /// <param name="val">quantity measured in TeraTesla</param>
    /// <returns>quantity measured in MilliTesla</returns>
	public static Quantity<double, MilliTesla> ToMilliTesla<T>(this BaseQuantity<T, TeraTesla> val) where T:IConvertible {
        return new Quantity<double, MilliTesla>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraTesla to MicroTesla
    /// </summary>
    /// <param name="val">quantity measured in TeraTesla</param>
    /// <returns>quantity measured in MicroTesla</returns>
	public static Quantity<double, MicroTesla> ToMicroTesla<T>(this BaseQuantity<T, TeraTesla> val) where T:IConvertible {
        return new Quantity<double, MicroTesla>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraTesla to NanoTesla
    /// </summary>
    /// <param name="val">quantity measured in TeraTesla</param>
    /// <returns>quantity measured in NanoTesla</returns>
	public static Quantity<double, NanoTesla> ToNanoTesla<T>(this BaseQuantity<T, TeraTesla> val) where T:IConvertible {
        return new Quantity<double, NanoTesla>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraTesla to PicoTesla
    /// </summary>
    /// <param name="val">quantity measured in TeraTesla</param>
    /// <returns>quantity measured in PicoTesla</returns>
	public static Quantity<double, PicoTesla> ToPicoTesla<T>(this BaseQuantity<T, TeraTesla> val) where T:IConvertible {
        return new Quantity<double, PicoTesla>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraTesla to FemtoTesla
    /// </summary>
    /// <param name="val">quantity measured in TeraTesla</param>
    /// <returns>quantity measured in FemtoTesla</returns>
	public static Quantity<double, FemtoTesla> ToFemtoTesla<T>(this BaseQuantity<T, TeraTesla> val) where T:IConvertible {
        return new Quantity<double, FemtoTesla>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraTesla to AttoTesla
    /// </summary>
    /// <param name="val">quantity measured in TeraTesla</param>
    /// <returns>quantity measured in AttoTesla</returns>
	public static Quantity<double, AttoTesla> ToAttoTesla<T>(this BaseQuantity<T, TeraTesla> val) where T:IConvertible {
        return new Quantity<double, AttoTesla>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraTesla to ZeptoTesla
    /// </summary>
    /// <param name="val">quantity measured in TeraTesla</param>
    /// <returns>quantity measured in ZeptoTesla</returns>
	public static Quantity<double, ZeptoTesla> ToZeptoTesla<T>(this BaseQuantity<T, TeraTesla> val) where T:IConvertible {
        return new Quantity<double, ZeptoTesla>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert TeraTesla to YoctoTesla
    /// </summary>
    /// <param name="val">quantity measured in TeraTesla</param>
    /// <returns>quantity measured in YoctoTesla</returns>
	public static Quantity<double, YoctoTesla> ToYoctoTesla<T>(this BaseQuantity<T, TeraTesla> val) where T:IConvertible {
        return new Quantity<double, YoctoTesla>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert GigaTesla to YottaTesla
    /// </summary>
    /// <param name="val">quantity measured in GigaTesla</param>
    /// <returns>quantity measured in YottaTesla</returns>
	public static Quantity<double, YottaTesla> ToYottaTesla<T>(this BaseQuantity<T, GigaTesla> val) where T:IConvertible {
        return new Quantity<double, YottaTesla>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaTesla to ZettaTesla
    /// </summary>
    /// <param name="val">quantity measured in GigaTesla</param>
    /// <returns>quantity measured in ZettaTesla</returns>
	public static Quantity<double, ZettaTesla> ToZettaTesla<T>(this BaseQuantity<T, GigaTesla> val) where T:IConvertible {
        return new Quantity<double, ZettaTesla>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaTesla to ExaTesla
    /// </summary>
    /// <param name="val">quantity measured in GigaTesla</param>
    /// <returns>quantity measured in ExaTesla</returns>
	public static Quantity<double, ExaTesla> ToExaTesla<T>(this BaseQuantity<T, GigaTesla> val) where T:IConvertible {
        return new Quantity<double, ExaTesla>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaTesla to PetaTesla
    /// </summary>
    /// <param name="val">quantity measured in GigaTesla</param>
    /// <returns>quantity measured in PetaTesla</returns>
	public static Quantity<double, PetaTesla> ToPetaTesla<T>(this BaseQuantity<T, GigaTesla> val) where T:IConvertible {
        return new Quantity<double, PetaTesla>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaTesla to TeraTesla
    /// </summary>
    /// <param name="val">quantity measured in GigaTesla</param>
    /// <returns>quantity measured in TeraTesla</returns>
	public static Quantity<double, TeraTesla> ToTeraTesla<T>(this BaseQuantity<T, GigaTesla> val) where T:IConvertible {
        return new Quantity<double, TeraTesla>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaTesla to MegaTesla
    /// </summary>
    /// <param name="val">quantity measured in GigaTesla</param>
    /// <returns>quantity measured in MegaTesla</returns>
	public static Quantity<double, MegaTesla> ToMegaTesla<T>(this BaseQuantity<T, GigaTesla> val) where T:IConvertible {
        return new Quantity<double, MegaTesla>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaTesla to KiloTesla
    /// </summary>
    /// <param name="val">quantity measured in GigaTesla</param>
    /// <returns>quantity measured in KiloTesla</returns>
	public static Quantity<double, KiloTesla> ToKiloTesla<T>(this BaseQuantity<T, GigaTesla> val) where T:IConvertible {
        return new Quantity<double, KiloTesla>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaTesla to HectoTesla
    /// </summary>
    /// <param name="val">quantity measured in GigaTesla</param>
    /// <returns>quantity measured in HectoTesla</returns>
	public static Quantity<double, HectoTesla> ToHectoTesla<T>(this BaseQuantity<T, GigaTesla> val) where T:IConvertible {
        return new Quantity<double, HectoTesla>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaTesla to DekaTesla
    /// </summary>
    /// <param name="val">quantity measured in GigaTesla</param>
    /// <returns>quantity measured in DekaTesla</returns>
	public static Quantity<double, DekaTesla> ToDekaTesla<T>(this BaseQuantity<T, GigaTesla> val) where T:IConvertible {
        return new Quantity<double, DekaTesla>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaTesla to DeciTesla
    /// </summary>
    /// <param name="val">quantity measured in GigaTesla</param>
    /// <returns>quantity measured in DeciTesla</returns>
	public static Quantity<double, DeciTesla> ToDeciTesla<T>(this BaseQuantity<T, GigaTesla> val) where T:IConvertible {
        return new Quantity<double, DeciTesla>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaTesla to CentiTesla
    /// </summary>
    /// <param name="val">quantity measured in GigaTesla</param>
    /// <returns>quantity measured in CentiTesla</returns>
	public static Quantity<double, CentiTesla> ToCentiTesla<T>(this BaseQuantity<T, GigaTesla> val) where T:IConvertible {
        return new Quantity<double, CentiTesla>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaTesla to MilliTesla
    /// </summary>
    /// <param name="val">quantity measured in GigaTesla</param>
    /// <returns>quantity measured in MilliTesla</returns>
	public static Quantity<double, MilliTesla> ToMilliTesla<T>(this BaseQuantity<T, GigaTesla> val) where T:IConvertible {
        return new Quantity<double, MilliTesla>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaTesla to MicroTesla
    /// </summary>
    /// <param name="val">quantity measured in GigaTesla</param>
    /// <returns>quantity measured in MicroTesla</returns>
	public static Quantity<double, MicroTesla> ToMicroTesla<T>(this BaseQuantity<T, GigaTesla> val) where T:IConvertible {
        return new Quantity<double, MicroTesla>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaTesla to NanoTesla
    /// </summary>
    /// <param name="val">quantity measured in GigaTesla</param>
    /// <returns>quantity measured in NanoTesla</returns>
	public static Quantity<double, NanoTesla> ToNanoTesla<T>(this BaseQuantity<T, GigaTesla> val) where T:IConvertible {
        return new Quantity<double, NanoTesla>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaTesla to PicoTesla
    /// </summary>
    /// <param name="val">quantity measured in GigaTesla</param>
    /// <returns>quantity measured in PicoTesla</returns>
	public static Quantity<double, PicoTesla> ToPicoTesla<T>(this BaseQuantity<T, GigaTesla> val) where T:IConvertible {
        return new Quantity<double, PicoTesla>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaTesla to FemtoTesla
    /// </summary>
    /// <param name="val">quantity measured in GigaTesla</param>
    /// <returns>quantity measured in FemtoTesla</returns>
	public static Quantity<double, FemtoTesla> ToFemtoTesla<T>(this BaseQuantity<T, GigaTesla> val) where T:IConvertible {
        return new Quantity<double, FemtoTesla>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaTesla to AttoTesla
    /// </summary>
    /// <param name="val">quantity measured in GigaTesla</param>
    /// <returns>quantity measured in AttoTesla</returns>
	public static Quantity<double, AttoTesla> ToAttoTesla<T>(this BaseQuantity<T, GigaTesla> val) where T:IConvertible {
        return new Quantity<double, AttoTesla>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaTesla to ZeptoTesla
    /// </summary>
    /// <param name="val">quantity measured in GigaTesla</param>
    /// <returns>quantity measured in ZeptoTesla</returns>
	public static Quantity<double, ZeptoTesla> ToZeptoTesla<T>(this BaseQuantity<T, GigaTesla> val) where T:IConvertible {
        return new Quantity<double, ZeptoTesla>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert GigaTesla to YoctoTesla
    /// </summary>
    /// <param name="val">quantity measured in GigaTesla</param>
    /// <returns>quantity measured in YoctoTesla</returns>
	public static Quantity<double, YoctoTesla> ToYoctoTesla<T>(this BaseQuantity<T, GigaTesla> val) where T:IConvertible {
        return new Quantity<double, YoctoTesla>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert MegaTesla to YottaTesla
    /// </summary>
    /// <param name="val">quantity measured in MegaTesla</param>
    /// <returns>quantity measured in YottaTesla</returns>
	public static Quantity<double, YottaTesla> ToYottaTesla<T>(this BaseQuantity<T, MegaTesla> val) where T:IConvertible {
        return new Quantity<double, YottaTesla>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaTesla to ZettaTesla
    /// </summary>
    /// <param name="val">quantity measured in MegaTesla</param>
    /// <returns>quantity measured in ZettaTesla</returns>
	public static Quantity<double, ZettaTesla> ToZettaTesla<T>(this BaseQuantity<T, MegaTesla> val) where T:IConvertible {
        return new Quantity<double, ZettaTesla>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaTesla to ExaTesla
    /// </summary>
    /// <param name="val">quantity measured in MegaTesla</param>
    /// <returns>quantity measured in ExaTesla</returns>
	public static Quantity<double, ExaTesla> ToExaTesla<T>(this BaseQuantity<T, MegaTesla> val) where T:IConvertible {
        return new Quantity<double, ExaTesla>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaTesla to PetaTesla
    /// </summary>
    /// <param name="val">quantity measured in MegaTesla</param>
    /// <returns>quantity measured in PetaTesla</returns>
	public static Quantity<double, PetaTesla> ToPetaTesla<T>(this BaseQuantity<T, MegaTesla> val) where T:IConvertible {
        return new Quantity<double, PetaTesla>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaTesla to TeraTesla
    /// </summary>
    /// <param name="val">quantity measured in MegaTesla</param>
    /// <returns>quantity measured in TeraTesla</returns>
	public static Quantity<double, TeraTesla> ToTeraTesla<T>(this BaseQuantity<T, MegaTesla> val) where T:IConvertible {
        return new Quantity<double, TeraTesla>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaTesla to GigaTesla
    /// </summary>
    /// <param name="val">quantity measured in MegaTesla</param>
    /// <returns>quantity measured in GigaTesla</returns>
	public static Quantity<double, GigaTesla> ToGigaTesla<T>(this BaseQuantity<T, MegaTesla> val) where T:IConvertible {
        return new Quantity<double, GigaTesla>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaTesla to KiloTesla
    /// </summary>
    /// <param name="val">quantity measured in MegaTesla</param>
    /// <returns>quantity measured in KiloTesla</returns>
	public static Quantity<double, KiloTesla> ToKiloTesla<T>(this BaseQuantity<T, MegaTesla> val) where T:IConvertible {
        return new Quantity<double, KiloTesla>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaTesla to HectoTesla
    /// </summary>
    /// <param name="val">quantity measured in MegaTesla</param>
    /// <returns>quantity measured in HectoTesla</returns>
	public static Quantity<double, HectoTesla> ToHectoTesla<T>(this BaseQuantity<T, MegaTesla> val) where T:IConvertible {
        return new Quantity<double, HectoTesla>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaTesla to DekaTesla
    /// </summary>
    /// <param name="val">quantity measured in MegaTesla</param>
    /// <returns>quantity measured in DekaTesla</returns>
	public static Quantity<double, DekaTesla> ToDekaTesla<T>(this BaseQuantity<T, MegaTesla> val) where T:IConvertible {
        return new Quantity<double, DekaTesla>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaTesla to DeciTesla
    /// </summary>
    /// <param name="val">quantity measured in MegaTesla</param>
    /// <returns>quantity measured in DeciTesla</returns>
	public static Quantity<double, DeciTesla> ToDeciTesla<T>(this BaseQuantity<T, MegaTesla> val) where T:IConvertible {
        return new Quantity<double, DeciTesla>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaTesla to CentiTesla
    /// </summary>
    /// <param name="val">quantity measured in MegaTesla</param>
    /// <returns>quantity measured in CentiTesla</returns>
	public static Quantity<double, CentiTesla> ToCentiTesla<T>(this BaseQuantity<T, MegaTesla> val) where T:IConvertible {
        return new Quantity<double, CentiTesla>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaTesla to MilliTesla
    /// </summary>
    /// <param name="val">quantity measured in MegaTesla</param>
    /// <returns>quantity measured in MilliTesla</returns>
	public static Quantity<double, MilliTesla> ToMilliTesla<T>(this BaseQuantity<T, MegaTesla> val) where T:IConvertible {
        return new Quantity<double, MilliTesla>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaTesla to MicroTesla
    /// </summary>
    /// <param name="val">quantity measured in MegaTesla</param>
    /// <returns>quantity measured in MicroTesla</returns>
	public static Quantity<double, MicroTesla> ToMicroTesla<T>(this BaseQuantity<T, MegaTesla> val) where T:IConvertible {
        return new Quantity<double, MicroTesla>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaTesla to NanoTesla
    /// </summary>
    /// <param name="val">quantity measured in MegaTesla</param>
    /// <returns>quantity measured in NanoTesla</returns>
	public static Quantity<double, NanoTesla> ToNanoTesla<T>(this BaseQuantity<T, MegaTesla> val) where T:IConvertible {
        return new Quantity<double, NanoTesla>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaTesla to PicoTesla
    /// </summary>
    /// <param name="val">quantity measured in MegaTesla</param>
    /// <returns>quantity measured in PicoTesla</returns>
	public static Quantity<double, PicoTesla> ToPicoTesla<T>(this BaseQuantity<T, MegaTesla> val) where T:IConvertible {
        return new Quantity<double, PicoTesla>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaTesla to FemtoTesla
    /// </summary>
    /// <param name="val">quantity measured in MegaTesla</param>
    /// <returns>quantity measured in FemtoTesla</returns>
	public static Quantity<double, FemtoTesla> ToFemtoTesla<T>(this BaseQuantity<T, MegaTesla> val) where T:IConvertible {
        return new Quantity<double, FemtoTesla>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaTesla to AttoTesla
    /// </summary>
    /// <param name="val">quantity measured in MegaTesla</param>
    /// <returns>quantity measured in AttoTesla</returns>
	public static Quantity<double, AttoTesla> ToAttoTesla<T>(this BaseQuantity<T, MegaTesla> val) where T:IConvertible {
        return new Quantity<double, AttoTesla>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaTesla to ZeptoTesla
    /// </summary>
    /// <param name="val">quantity measured in MegaTesla</param>
    /// <returns>quantity measured in ZeptoTesla</returns>
	public static Quantity<double, ZeptoTesla> ToZeptoTesla<T>(this BaseQuantity<T, MegaTesla> val) where T:IConvertible {
        return new Quantity<double, ZeptoTesla>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert MegaTesla to YoctoTesla
    /// </summary>
    /// <param name="val">quantity measured in MegaTesla</param>
    /// <returns>quantity measured in YoctoTesla</returns>
	public static Quantity<double, YoctoTesla> ToYoctoTesla<T>(this BaseQuantity<T, MegaTesla> val) where T:IConvertible {
        return new Quantity<double, YoctoTesla>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert KiloTesla to YottaTesla
    /// </summary>
    /// <param name="val">quantity measured in KiloTesla</param>
    /// <returns>quantity measured in YottaTesla</returns>
	public static Quantity<double, YottaTesla> ToYottaTesla<T>(this BaseQuantity<T, KiloTesla> val) where T:IConvertible {
        return new Quantity<double, YottaTesla>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloTesla to ZettaTesla
    /// </summary>
    /// <param name="val">quantity measured in KiloTesla</param>
    /// <returns>quantity measured in ZettaTesla</returns>
	public static Quantity<double, ZettaTesla> ToZettaTesla<T>(this BaseQuantity<T, KiloTesla> val) where T:IConvertible {
        return new Quantity<double, ZettaTesla>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloTesla to ExaTesla
    /// </summary>
    /// <param name="val">quantity measured in KiloTesla</param>
    /// <returns>quantity measured in ExaTesla</returns>
	public static Quantity<double, ExaTesla> ToExaTesla<T>(this BaseQuantity<T, KiloTesla> val) where T:IConvertible {
        return new Quantity<double, ExaTesla>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloTesla to PetaTesla
    /// </summary>
    /// <param name="val">quantity measured in KiloTesla</param>
    /// <returns>quantity measured in PetaTesla</returns>
	public static Quantity<double, PetaTesla> ToPetaTesla<T>(this BaseQuantity<T, KiloTesla> val) where T:IConvertible {
        return new Quantity<double, PetaTesla>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloTesla to TeraTesla
    /// </summary>
    /// <param name="val">quantity measured in KiloTesla</param>
    /// <returns>quantity measured in TeraTesla</returns>
	public static Quantity<double, TeraTesla> ToTeraTesla<T>(this BaseQuantity<T, KiloTesla> val) where T:IConvertible {
        return new Quantity<double, TeraTesla>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloTesla to GigaTesla
    /// </summary>
    /// <param name="val">quantity measured in KiloTesla</param>
    /// <returns>quantity measured in GigaTesla</returns>
	public static Quantity<double, GigaTesla> ToGigaTesla<T>(this BaseQuantity<T, KiloTesla> val) where T:IConvertible {
        return new Quantity<double, GigaTesla>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloTesla to MegaTesla
    /// </summary>
    /// <param name="val">quantity measured in KiloTesla</param>
    /// <returns>quantity measured in MegaTesla</returns>
	public static Quantity<double, MegaTesla> ToMegaTesla<T>(this BaseQuantity<T, KiloTesla> val) where T:IConvertible {
        return new Quantity<double, MegaTesla>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloTesla to HectoTesla
    /// </summary>
    /// <param name="val">quantity measured in KiloTesla</param>
    /// <returns>quantity measured in HectoTesla</returns>
	public static Quantity<double, HectoTesla> ToHectoTesla<T>(this BaseQuantity<T, KiloTesla> val) where T:IConvertible {
        return new Quantity<double, HectoTesla>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloTesla to DekaTesla
    /// </summary>
    /// <param name="val">quantity measured in KiloTesla</param>
    /// <returns>quantity measured in DekaTesla</returns>
	public static Quantity<double, DekaTesla> ToDekaTesla<T>(this BaseQuantity<T, KiloTesla> val) where T:IConvertible {
        return new Quantity<double, DekaTesla>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloTesla to DeciTesla
    /// </summary>
    /// <param name="val">quantity measured in KiloTesla</param>
    /// <returns>quantity measured in DeciTesla</returns>
	public static Quantity<double, DeciTesla> ToDeciTesla<T>(this BaseQuantity<T, KiloTesla> val) where T:IConvertible {
        return new Quantity<double, DeciTesla>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloTesla to CentiTesla
    /// </summary>
    /// <param name="val">quantity measured in KiloTesla</param>
    /// <returns>quantity measured in CentiTesla</returns>
	public static Quantity<double, CentiTesla> ToCentiTesla<T>(this BaseQuantity<T, KiloTesla> val) where T:IConvertible {
        return new Quantity<double, CentiTesla>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloTesla to MilliTesla
    /// </summary>
    /// <param name="val">quantity measured in KiloTesla</param>
    /// <returns>quantity measured in MilliTesla</returns>
	public static Quantity<double, MilliTesla> ToMilliTesla<T>(this BaseQuantity<T, KiloTesla> val) where T:IConvertible {
        return new Quantity<double, MilliTesla>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloTesla to MicroTesla
    /// </summary>
    /// <param name="val">quantity measured in KiloTesla</param>
    /// <returns>quantity measured in MicroTesla</returns>
	public static Quantity<double, MicroTesla> ToMicroTesla<T>(this BaseQuantity<T, KiloTesla> val) where T:IConvertible {
        return new Quantity<double, MicroTesla>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloTesla to NanoTesla
    /// </summary>
    /// <param name="val">quantity measured in KiloTesla</param>
    /// <returns>quantity measured in NanoTesla</returns>
	public static Quantity<double, NanoTesla> ToNanoTesla<T>(this BaseQuantity<T, KiloTesla> val) where T:IConvertible {
        return new Quantity<double, NanoTesla>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloTesla to PicoTesla
    /// </summary>
    /// <param name="val">quantity measured in KiloTesla</param>
    /// <returns>quantity measured in PicoTesla</returns>
	public static Quantity<double, PicoTesla> ToPicoTesla<T>(this BaseQuantity<T, KiloTesla> val) where T:IConvertible {
        return new Quantity<double, PicoTesla>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloTesla to FemtoTesla
    /// </summary>
    /// <param name="val">quantity measured in KiloTesla</param>
    /// <returns>quantity measured in FemtoTesla</returns>
	public static Quantity<double, FemtoTesla> ToFemtoTesla<T>(this BaseQuantity<T, KiloTesla> val) where T:IConvertible {
        return new Quantity<double, FemtoTesla>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloTesla to AttoTesla
    /// </summary>
    /// <param name="val">quantity measured in KiloTesla</param>
    /// <returns>quantity measured in AttoTesla</returns>
	public static Quantity<double, AttoTesla> ToAttoTesla<T>(this BaseQuantity<T, KiloTesla> val) where T:IConvertible {
        return new Quantity<double, AttoTesla>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloTesla to ZeptoTesla
    /// </summary>
    /// <param name="val">quantity measured in KiloTesla</param>
    /// <returns>quantity measured in ZeptoTesla</returns>
	public static Quantity<double, ZeptoTesla> ToZeptoTesla<T>(this BaseQuantity<T, KiloTesla> val) where T:IConvertible {
        return new Quantity<double, ZeptoTesla>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert KiloTesla to YoctoTesla
    /// </summary>
    /// <param name="val">quantity measured in KiloTesla</param>
    /// <returns>quantity measured in YoctoTesla</returns>
	public static Quantity<double, YoctoTesla> ToYoctoTesla<T>(this BaseQuantity<T, KiloTesla> val) where T:IConvertible {
        return new Quantity<double, YoctoTesla>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert HectoTesla to YottaTesla
    /// </summary>
    /// <param name="val">quantity measured in HectoTesla</param>
    /// <returns>quantity measured in YottaTesla</returns>
	public static Quantity<double, YottaTesla> ToYottaTesla<T>(this BaseQuantity<T, HectoTesla> val) where T:IConvertible {
        return new Quantity<double, YottaTesla>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoTesla to ZettaTesla
    /// </summary>
    /// <param name="val">quantity measured in HectoTesla</param>
    /// <returns>quantity measured in ZettaTesla</returns>
	public static Quantity<double, ZettaTesla> ToZettaTesla<T>(this BaseQuantity<T, HectoTesla> val) where T:IConvertible {
        return new Quantity<double, ZettaTesla>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoTesla to ExaTesla
    /// </summary>
    /// <param name="val">quantity measured in HectoTesla</param>
    /// <returns>quantity measured in ExaTesla</returns>
	public static Quantity<double, ExaTesla> ToExaTesla<T>(this BaseQuantity<T, HectoTesla> val) where T:IConvertible {
        return new Quantity<double, ExaTesla>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoTesla to PetaTesla
    /// </summary>
    /// <param name="val">quantity measured in HectoTesla</param>
    /// <returns>quantity measured in PetaTesla</returns>
	public static Quantity<double, PetaTesla> ToPetaTesla<T>(this BaseQuantity<T, HectoTesla> val) where T:IConvertible {
        return new Quantity<double, PetaTesla>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoTesla to TeraTesla
    /// </summary>
    /// <param name="val">quantity measured in HectoTesla</param>
    /// <returns>quantity measured in TeraTesla</returns>
	public static Quantity<double, TeraTesla> ToTeraTesla<T>(this BaseQuantity<T, HectoTesla> val) where T:IConvertible {
        return new Quantity<double, TeraTesla>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoTesla to GigaTesla
    /// </summary>
    /// <param name="val">quantity measured in HectoTesla</param>
    /// <returns>quantity measured in GigaTesla</returns>
	public static Quantity<double, GigaTesla> ToGigaTesla<T>(this BaseQuantity<T, HectoTesla> val) where T:IConvertible {
        return new Quantity<double, GigaTesla>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoTesla to MegaTesla
    /// </summary>
    /// <param name="val">quantity measured in HectoTesla</param>
    /// <returns>quantity measured in MegaTesla</returns>
	public static Quantity<double, MegaTesla> ToMegaTesla<T>(this BaseQuantity<T, HectoTesla> val) where T:IConvertible {
        return new Quantity<double, MegaTesla>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoTesla to KiloTesla
    /// </summary>
    /// <param name="val">quantity measured in HectoTesla</param>
    /// <returns>quantity measured in KiloTesla</returns>
	public static Quantity<double, KiloTesla> ToKiloTesla<T>(this BaseQuantity<T, HectoTesla> val) where T:IConvertible {
        return new Quantity<double, KiloTesla>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoTesla to DekaTesla
    /// </summary>
    /// <param name="val">quantity measured in HectoTesla</param>
    /// <returns>quantity measured in DekaTesla</returns>
	public static Quantity<double, DekaTesla> ToDekaTesla<T>(this BaseQuantity<T, HectoTesla> val) where T:IConvertible {
        return new Quantity<double, DekaTesla>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoTesla to DeciTesla
    /// </summary>
    /// <param name="val">quantity measured in HectoTesla</param>
    /// <returns>quantity measured in DeciTesla</returns>
	public static Quantity<double, DeciTesla> ToDeciTesla<T>(this BaseQuantity<T, HectoTesla> val) where T:IConvertible {
        return new Quantity<double, DeciTesla>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoTesla to CentiTesla
    /// </summary>
    /// <param name="val">quantity measured in HectoTesla</param>
    /// <returns>quantity measured in CentiTesla</returns>
	public static Quantity<double, CentiTesla> ToCentiTesla<T>(this BaseQuantity<T, HectoTesla> val) where T:IConvertible {
        return new Quantity<double, CentiTesla>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoTesla to MilliTesla
    /// </summary>
    /// <param name="val">quantity measured in HectoTesla</param>
    /// <returns>quantity measured in MilliTesla</returns>
	public static Quantity<double, MilliTesla> ToMilliTesla<T>(this BaseQuantity<T, HectoTesla> val) where T:IConvertible {
        return new Quantity<double, MilliTesla>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoTesla to MicroTesla
    /// </summary>
    /// <param name="val">quantity measured in HectoTesla</param>
    /// <returns>quantity measured in MicroTesla</returns>
	public static Quantity<double, MicroTesla> ToMicroTesla<T>(this BaseQuantity<T, HectoTesla> val) where T:IConvertible {
        return new Quantity<double, MicroTesla>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoTesla to NanoTesla
    /// </summary>
    /// <param name="val">quantity measured in HectoTesla</param>
    /// <returns>quantity measured in NanoTesla</returns>
	public static Quantity<double, NanoTesla> ToNanoTesla<T>(this BaseQuantity<T, HectoTesla> val) where T:IConvertible {
        return new Quantity<double, NanoTesla>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoTesla to PicoTesla
    /// </summary>
    /// <param name="val">quantity measured in HectoTesla</param>
    /// <returns>quantity measured in PicoTesla</returns>
	public static Quantity<double, PicoTesla> ToPicoTesla<T>(this BaseQuantity<T, HectoTesla> val) where T:IConvertible {
        return new Quantity<double, PicoTesla>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoTesla to FemtoTesla
    /// </summary>
    /// <param name="val">quantity measured in HectoTesla</param>
    /// <returns>quantity measured in FemtoTesla</returns>
	public static Quantity<double, FemtoTesla> ToFemtoTesla<T>(this BaseQuantity<T, HectoTesla> val) where T:IConvertible {
        return new Quantity<double, FemtoTesla>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoTesla to AttoTesla
    /// </summary>
    /// <param name="val">quantity measured in HectoTesla</param>
    /// <returns>quantity measured in AttoTesla</returns>
	public static Quantity<double, AttoTesla> ToAttoTesla<T>(this BaseQuantity<T, HectoTesla> val) where T:IConvertible {
        return new Quantity<double, AttoTesla>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoTesla to ZeptoTesla
    /// </summary>
    /// <param name="val">quantity measured in HectoTesla</param>
    /// <returns>quantity measured in ZeptoTesla</returns>
	public static Quantity<double, ZeptoTesla> ToZeptoTesla<T>(this BaseQuantity<T, HectoTesla> val) where T:IConvertible {
        return new Quantity<double, ZeptoTesla>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert HectoTesla to YoctoTesla
    /// </summary>
    /// <param name="val">quantity measured in HectoTesla</param>
    /// <returns>quantity measured in YoctoTesla</returns>
	public static Quantity<double, YoctoTesla> ToYoctoTesla<T>(this BaseQuantity<T, HectoTesla> val) where T:IConvertible {
        return new Quantity<double, YoctoTesla>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert DekaTesla to YottaTesla
    /// </summary>
    /// <param name="val">quantity measured in DekaTesla</param>
    /// <returns>quantity measured in YottaTesla</returns>
	public static Quantity<double, YottaTesla> ToYottaTesla<T>(this BaseQuantity<T, DekaTesla> val) where T:IConvertible {
        return new Quantity<double, YottaTesla>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaTesla to ZettaTesla
    /// </summary>
    /// <param name="val">quantity measured in DekaTesla</param>
    /// <returns>quantity measured in ZettaTesla</returns>
	public static Quantity<double, ZettaTesla> ToZettaTesla<T>(this BaseQuantity<T, DekaTesla> val) where T:IConvertible {
        return new Quantity<double, ZettaTesla>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaTesla to ExaTesla
    /// </summary>
    /// <param name="val">quantity measured in DekaTesla</param>
    /// <returns>quantity measured in ExaTesla</returns>
	public static Quantity<double, ExaTesla> ToExaTesla<T>(this BaseQuantity<T, DekaTesla> val) where T:IConvertible {
        return new Quantity<double, ExaTesla>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaTesla to PetaTesla
    /// </summary>
    /// <param name="val">quantity measured in DekaTesla</param>
    /// <returns>quantity measured in PetaTesla</returns>
	public static Quantity<double, PetaTesla> ToPetaTesla<T>(this BaseQuantity<T, DekaTesla> val) where T:IConvertible {
        return new Quantity<double, PetaTesla>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaTesla to TeraTesla
    /// </summary>
    /// <param name="val">quantity measured in DekaTesla</param>
    /// <returns>quantity measured in TeraTesla</returns>
	public static Quantity<double, TeraTesla> ToTeraTesla<T>(this BaseQuantity<T, DekaTesla> val) where T:IConvertible {
        return new Quantity<double, TeraTesla>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaTesla to GigaTesla
    /// </summary>
    /// <param name="val">quantity measured in DekaTesla</param>
    /// <returns>quantity measured in GigaTesla</returns>
	public static Quantity<double, GigaTesla> ToGigaTesla<T>(this BaseQuantity<T, DekaTesla> val) where T:IConvertible {
        return new Quantity<double, GigaTesla>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaTesla to MegaTesla
    /// </summary>
    /// <param name="val">quantity measured in DekaTesla</param>
    /// <returns>quantity measured in MegaTesla</returns>
	public static Quantity<double, MegaTesla> ToMegaTesla<T>(this BaseQuantity<T, DekaTesla> val) where T:IConvertible {
        return new Quantity<double, MegaTesla>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaTesla to KiloTesla
    /// </summary>
    /// <param name="val">quantity measured in DekaTesla</param>
    /// <returns>quantity measured in KiloTesla</returns>
	public static Quantity<double, KiloTesla> ToKiloTesla<T>(this BaseQuantity<T, DekaTesla> val) where T:IConvertible {
        return new Quantity<double, KiloTesla>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaTesla to HectoTesla
    /// </summary>
    /// <param name="val">quantity measured in DekaTesla</param>
    /// <returns>quantity measured in HectoTesla</returns>
	public static Quantity<double, HectoTesla> ToHectoTesla<T>(this BaseQuantity<T, DekaTesla> val) where T:IConvertible {
        return new Quantity<double, HectoTesla>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaTesla to DeciTesla
    /// </summary>
    /// <param name="val">quantity measured in DekaTesla</param>
    /// <returns>quantity measured in DeciTesla</returns>
	public static Quantity<double, DeciTesla> ToDeciTesla<T>(this BaseQuantity<T, DekaTesla> val) where T:IConvertible {
        return new Quantity<double, DeciTesla>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaTesla to CentiTesla
    /// </summary>
    /// <param name="val">quantity measured in DekaTesla</param>
    /// <returns>quantity measured in CentiTesla</returns>
	public static Quantity<double, CentiTesla> ToCentiTesla<T>(this BaseQuantity<T, DekaTesla> val) where T:IConvertible {
        return new Quantity<double, CentiTesla>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaTesla to MilliTesla
    /// </summary>
    /// <param name="val">quantity measured in DekaTesla</param>
    /// <returns>quantity measured in MilliTesla</returns>
	public static Quantity<double, MilliTesla> ToMilliTesla<T>(this BaseQuantity<T, DekaTesla> val) where T:IConvertible {
        return new Quantity<double, MilliTesla>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaTesla to MicroTesla
    /// </summary>
    /// <param name="val">quantity measured in DekaTesla</param>
    /// <returns>quantity measured in MicroTesla</returns>
	public static Quantity<double, MicroTesla> ToMicroTesla<T>(this BaseQuantity<T, DekaTesla> val) where T:IConvertible {
        return new Quantity<double, MicroTesla>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaTesla to NanoTesla
    /// </summary>
    /// <param name="val">quantity measured in DekaTesla</param>
    /// <returns>quantity measured in NanoTesla</returns>
	public static Quantity<double, NanoTesla> ToNanoTesla<T>(this BaseQuantity<T, DekaTesla> val) where T:IConvertible {
        return new Quantity<double, NanoTesla>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaTesla to PicoTesla
    /// </summary>
    /// <param name="val">quantity measured in DekaTesla</param>
    /// <returns>quantity measured in PicoTesla</returns>
	public static Quantity<double, PicoTesla> ToPicoTesla<T>(this BaseQuantity<T, DekaTesla> val) where T:IConvertible {
        return new Quantity<double, PicoTesla>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaTesla to FemtoTesla
    /// </summary>
    /// <param name="val">quantity measured in DekaTesla</param>
    /// <returns>quantity measured in FemtoTesla</returns>
	public static Quantity<double, FemtoTesla> ToFemtoTesla<T>(this BaseQuantity<T, DekaTesla> val) where T:IConvertible {
        return new Quantity<double, FemtoTesla>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaTesla to AttoTesla
    /// </summary>
    /// <param name="val">quantity measured in DekaTesla</param>
    /// <returns>quantity measured in AttoTesla</returns>
	public static Quantity<double, AttoTesla> ToAttoTesla<T>(this BaseQuantity<T, DekaTesla> val) where T:IConvertible {
        return new Quantity<double, AttoTesla>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaTesla to ZeptoTesla
    /// </summary>
    /// <param name="val">quantity measured in DekaTesla</param>
    /// <returns>quantity measured in ZeptoTesla</returns>
	public static Quantity<double, ZeptoTesla> ToZeptoTesla<T>(this BaseQuantity<T, DekaTesla> val) where T:IConvertible {
        return new Quantity<double, ZeptoTesla>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DekaTesla to YoctoTesla
    /// </summary>
    /// <param name="val">quantity measured in DekaTesla</param>
    /// <returns>quantity measured in YoctoTesla</returns>
	public static Quantity<double, YoctoTesla> ToYoctoTesla<T>(this BaseQuantity<T, DekaTesla> val) where T:IConvertible {
        return new Quantity<double, YoctoTesla>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert DeciTesla to YottaTesla
    /// </summary>
    /// <param name="val">quantity measured in DeciTesla</param>
    /// <returns>quantity measured in YottaTesla</returns>
	public static Quantity<double, YottaTesla> ToYottaTesla<T>(this BaseQuantity<T, DeciTesla> val) where T:IConvertible {
        return new Quantity<double, YottaTesla>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciTesla to ZettaTesla
    /// </summary>
    /// <param name="val">quantity measured in DeciTesla</param>
    /// <returns>quantity measured in ZettaTesla</returns>
	public static Quantity<double, ZettaTesla> ToZettaTesla<T>(this BaseQuantity<T, DeciTesla> val) where T:IConvertible {
        return new Quantity<double, ZettaTesla>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciTesla to ExaTesla
    /// </summary>
    /// <param name="val">quantity measured in DeciTesla</param>
    /// <returns>quantity measured in ExaTesla</returns>
	public static Quantity<double, ExaTesla> ToExaTesla<T>(this BaseQuantity<T, DeciTesla> val) where T:IConvertible {
        return new Quantity<double, ExaTesla>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciTesla to PetaTesla
    /// </summary>
    /// <param name="val">quantity measured in DeciTesla</param>
    /// <returns>quantity measured in PetaTesla</returns>
	public static Quantity<double, PetaTesla> ToPetaTesla<T>(this BaseQuantity<T, DeciTesla> val) where T:IConvertible {
        return new Quantity<double, PetaTesla>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciTesla to TeraTesla
    /// </summary>
    /// <param name="val">quantity measured in DeciTesla</param>
    /// <returns>quantity measured in TeraTesla</returns>
	public static Quantity<double, TeraTesla> ToTeraTesla<T>(this BaseQuantity<T, DeciTesla> val) where T:IConvertible {
        return new Quantity<double, TeraTesla>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciTesla to GigaTesla
    /// </summary>
    /// <param name="val">quantity measured in DeciTesla</param>
    /// <returns>quantity measured in GigaTesla</returns>
	public static Quantity<double, GigaTesla> ToGigaTesla<T>(this BaseQuantity<T, DeciTesla> val) where T:IConvertible {
        return new Quantity<double, GigaTesla>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciTesla to MegaTesla
    /// </summary>
    /// <param name="val">quantity measured in DeciTesla</param>
    /// <returns>quantity measured in MegaTesla</returns>
	public static Quantity<double, MegaTesla> ToMegaTesla<T>(this BaseQuantity<T, DeciTesla> val) where T:IConvertible {
        return new Quantity<double, MegaTesla>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciTesla to KiloTesla
    /// </summary>
    /// <param name="val">quantity measured in DeciTesla</param>
    /// <returns>quantity measured in KiloTesla</returns>
	public static Quantity<double, KiloTesla> ToKiloTesla<T>(this BaseQuantity<T, DeciTesla> val) where T:IConvertible {
        return new Quantity<double, KiloTesla>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciTesla to HectoTesla
    /// </summary>
    /// <param name="val">quantity measured in DeciTesla</param>
    /// <returns>quantity measured in HectoTesla</returns>
	public static Quantity<double, HectoTesla> ToHectoTesla<T>(this BaseQuantity<T, DeciTesla> val) where T:IConvertible {
        return new Quantity<double, HectoTesla>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciTesla to DekaTesla
    /// </summary>
    /// <param name="val">quantity measured in DeciTesla</param>
    /// <returns>quantity measured in DekaTesla</returns>
	public static Quantity<double, DekaTesla> ToDekaTesla<T>(this BaseQuantity<T, DeciTesla> val) where T:IConvertible {
        return new Quantity<double, DekaTesla>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciTesla to CentiTesla
    /// </summary>
    /// <param name="val">quantity measured in DeciTesla</param>
    /// <returns>quantity measured in CentiTesla</returns>
	public static Quantity<double, CentiTesla> ToCentiTesla<T>(this BaseQuantity<T, DeciTesla> val) where T:IConvertible {
        return new Quantity<double, CentiTesla>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciTesla to MilliTesla
    /// </summary>
    /// <param name="val">quantity measured in DeciTesla</param>
    /// <returns>quantity measured in MilliTesla</returns>
	public static Quantity<double, MilliTesla> ToMilliTesla<T>(this BaseQuantity<T, DeciTesla> val) where T:IConvertible {
        return new Quantity<double, MilliTesla>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciTesla to MicroTesla
    /// </summary>
    /// <param name="val">quantity measured in DeciTesla</param>
    /// <returns>quantity measured in MicroTesla</returns>
	public static Quantity<double, MicroTesla> ToMicroTesla<T>(this BaseQuantity<T, DeciTesla> val) where T:IConvertible {
        return new Quantity<double, MicroTesla>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciTesla to NanoTesla
    /// </summary>
    /// <param name="val">quantity measured in DeciTesla</param>
    /// <returns>quantity measured in NanoTesla</returns>
	public static Quantity<double, NanoTesla> ToNanoTesla<T>(this BaseQuantity<T, DeciTesla> val) where T:IConvertible {
        return new Quantity<double, NanoTesla>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciTesla to PicoTesla
    /// </summary>
    /// <param name="val">quantity measured in DeciTesla</param>
    /// <returns>quantity measured in PicoTesla</returns>
	public static Quantity<double, PicoTesla> ToPicoTesla<T>(this BaseQuantity<T, DeciTesla> val) where T:IConvertible {
        return new Quantity<double, PicoTesla>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciTesla to FemtoTesla
    /// </summary>
    /// <param name="val">quantity measured in DeciTesla</param>
    /// <returns>quantity measured in FemtoTesla</returns>
	public static Quantity<double, FemtoTesla> ToFemtoTesla<T>(this BaseQuantity<T, DeciTesla> val) where T:IConvertible {
        return new Quantity<double, FemtoTesla>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciTesla to AttoTesla
    /// </summary>
    /// <param name="val">quantity measured in DeciTesla</param>
    /// <returns>quantity measured in AttoTesla</returns>
	public static Quantity<double, AttoTesla> ToAttoTesla<T>(this BaseQuantity<T, DeciTesla> val) where T:IConvertible {
        return new Quantity<double, AttoTesla>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciTesla to ZeptoTesla
    /// </summary>
    /// <param name="val">quantity measured in DeciTesla</param>
    /// <returns>quantity measured in ZeptoTesla</returns>
	public static Quantity<double, ZeptoTesla> ToZeptoTesla<T>(this BaseQuantity<T, DeciTesla> val) where T:IConvertible {
        return new Quantity<double, ZeptoTesla>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert DeciTesla to YoctoTesla
    /// </summary>
    /// <param name="val">quantity measured in DeciTesla</param>
    /// <returns>quantity measured in YoctoTesla</returns>
	public static Quantity<double, YoctoTesla> ToYoctoTesla<T>(this BaseQuantity<T, DeciTesla> val) where T:IConvertible {
        return new Quantity<double, YoctoTesla>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert CentiTesla to YottaTesla
    /// </summary>
    /// <param name="val">quantity measured in CentiTesla</param>
    /// <returns>quantity measured in YottaTesla</returns>
	public static Quantity<double, YottaTesla> ToYottaTesla<T>(this BaseQuantity<T, CentiTesla> val) where T:IConvertible {
        return new Quantity<double, YottaTesla>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiTesla to ZettaTesla
    /// </summary>
    /// <param name="val">quantity measured in CentiTesla</param>
    /// <returns>quantity measured in ZettaTesla</returns>
	public static Quantity<double, ZettaTesla> ToZettaTesla<T>(this BaseQuantity<T, CentiTesla> val) where T:IConvertible {
        return new Quantity<double, ZettaTesla>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiTesla to ExaTesla
    /// </summary>
    /// <param name="val">quantity measured in CentiTesla</param>
    /// <returns>quantity measured in ExaTesla</returns>
	public static Quantity<double, ExaTesla> ToExaTesla<T>(this BaseQuantity<T, CentiTesla> val) where T:IConvertible {
        return new Quantity<double, ExaTesla>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiTesla to PetaTesla
    /// </summary>
    /// <param name="val">quantity measured in CentiTesla</param>
    /// <returns>quantity measured in PetaTesla</returns>
	public static Quantity<double, PetaTesla> ToPetaTesla<T>(this BaseQuantity<T, CentiTesla> val) where T:IConvertible {
        return new Quantity<double, PetaTesla>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiTesla to TeraTesla
    /// </summary>
    /// <param name="val">quantity measured in CentiTesla</param>
    /// <returns>quantity measured in TeraTesla</returns>
	public static Quantity<double, TeraTesla> ToTeraTesla<T>(this BaseQuantity<T, CentiTesla> val) where T:IConvertible {
        return new Quantity<double, TeraTesla>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiTesla to GigaTesla
    /// </summary>
    /// <param name="val">quantity measured in CentiTesla</param>
    /// <returns>quantity measured in GigaTesla</returns>
	public static Quantity<double, GigaTesla> ToGigaTesla<T>(this BaseQuantity<T, CentiTesla> val) where T:IConvertible {
        return new Quantity<double, GigaTesla>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiTesla to MegaTesla
    /// </summary>
    /// <param name="val">quantity measured in CentiTesla</param>
    /// <returns>quantity measured in MegaTesla</returns>
	public static Quantity<double, MegaTesla> ToMegaTesla<T>(this BaseQuantity<T, CentiTesla> val) where T:IConvertible {
        return new Quantity<double, MegaTesla>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiTesla to KiloTesla
    /// </summary>
    /// <param name="val">quantity measured in CentiTesla</param>
    /// <returns>quantity measured in KiloTesla</returns>
	public static Quantity<double, KiloTesla> ToKiloTesla<T>(this BaseQuantity<T, CentiTesla> val) where T:IConvertible {
        return new Quantity<double, KiloTesla>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiTesla to HectoTesla
    /// </summary>
    /// <param name="val">quantity measured in CentiTesla</param>
    /// <returns>quantity measured in HectoTesla</returns>
	public static Quantity<double, HectoTesla> ToHectoTesla<T>(this BaseQuantity<T, CentiTesla> val) where T:IConvertible {
        return new Quantity<double, HectoTesla>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiTesla to DekaTesla
    /// </summary>
    /// <param name="val">quantity measured in CentiTesla</param>
    /// <returns>quantity measured in DekaTesla</returns>
	public static Quantity<double, DekaTesla> ToDekaTesla<T>(this BaseQuantity<T, CentiTesla> val) where T:IConvertible {
        return new Quantity<double, DekaTesla>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiTesla to DeciTesla
    /// </summary>
    /// <param name="val">quantity measured in CentiTesla</param>
    /// <returns>quantity measured in DeciTesla</returns>
	public static Quantity<double, DeciTesla> ToDeciTesla<T>(this BaseQuantity<T, CentiTesla> val) where T:IConvertible {
        return new Quantity<double, DeciTesla>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiTesla to MilliTesla
    /// </summary>
    /// <param name="val">quantity measured in CentiTesla</param>
    /// <returns>quantity measured in MilliTesla</returns>
	public static Quantity<double, MilliTesla> ToMilliTesla<T>(this BaseQuantity<T, CentiTesla> val) where T:IConvertible {
        return new Quantity<double, MilliTesla>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiTesla to MicroTesla
    /// </summary>
    /// <param name="val">quantity measured in CentiTesla</param>
    /// <returns>quantity measured in MicroTesla</returns>
	public static Quantity<double, MicroTesla> ToMicroTesla<T>(this BaseQuantity<T, CentiTesla> val) where T:IConvertible {
        return new Quantity<double, MicroTesla>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiTesla to NanoTesla
    /// </summary>
    /// <param name="val">quantity measured in CentiTesla</param>
    /// <returns>quantity measured in NanoTesla</returns>
	public static Quantity<double, NanoTesla> ToNanoTesla<T>(this BaseQuantity<T, CentiTesla> val) where T:IConvertible {
        return new Quantity<double, NanoTesla>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiTesla to PicoTesla
    /// </summary>
    /// <param name="val">quantity measured in CentiTesla</param>
    /// <returns>quantity measured in PicoTesla</returns>
	public static Quantity<double, PicoTesla> ToPicoTesla<T>(this BaseQuantity<T, CentiTesla> val) where T:IConvertible {
        return new Quantity<double, PicoTesla>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiTesla to FemtoTesla
    /// </summary>
    /// <param name="val">quantity measured in CentiTesla</param>
    /// <returns>quantity measured in FemtoTesla</returns>
	public static Quantity<double, FemtoTesla> ToFemtoTesla<T>(this BaseQuantity<T, CentiTesla> val) where T:IConvertible {
        return new Quantity<double, FemtoTesla>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiTesla to AttoTesla
    /// </summary>
    /// <param name="val">quantity measured in CentiTesla</param>
    /// <returns>quantity measured in AttoTesla</returns>
	public static Quantity<double, AttoTesla> ToAttoTesla<T>(this BaseQuantity<T, CentiTesla> val) where T:IConvertible {
        return new Quantity<double, AttoTesla>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiTesla to ZeptoTesla
    /// </summary>
    /// <param name="val">quantity measured in CentiTesla</param>
    /// <returns>quantity measured in ZeptoTesla</returns>
	public static Quantity<double, ZeptoTesla> ToZeptoTesla<T>(this BaseQuantity<T, CentiTesla> val) where T:IConvertible {
        return new Quantity<double, ZeptoTesla>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert CentiTesla to YoctoTesla
    /// </summary>
    /// <param name="val">quantity measured in CentiTesla</param>
    /// <returns>quantity measured in YoctoTesla</returns>
	public static Quantity<double, YoctoTesla> ToYoctoTesla<T>(this BaseQuantity<T, CentiTesla> val) where T:IConvertible {
        return new Quantity<double, YoctoTesla>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert MilliTesla to YottaTesla
    /// </summary>
    /// <param name="val">quantity measured in MilliTesla</param>
    /// <returns>quantity measured in YottaTesla</returns>
	public static Quantity<double, YottaTesla> ToYottaTesla<T>(this BaseQuantity<T, MilliTesla> val) where T:IConvertible {
        return new Quantity<double, YottaTesla>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliTesla to ZettaTesla
    /// </summary>
    /// <param name="val">quantity measured in MilliTesla</param>
    /// <returns>quantity measured in ZettaTesla</returns>
	public static Quantity<double, ZettaTesla> ToZettaTesla<T>(this BaseQuantity<T, MilliTesla> val) where T:IConvertible {
        return new Quantity<double, ZettaTesla>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliTesla to ExaTesla
    /// </summary>
    /// <param name="val">quantity measured in MilliTesla</param>
    /// <returns>quantity measured in ExaTesla</returns>
	public static Quantity<double, ExaTesla> ToExaTesla<T>(this BaseQuantity<T, MilliTesla> val) where T:IConvertible {
        return new Quantity<double, ExaTesla>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliTesla to PetaTesla
    /// </summary>
    /// <param name="val">quantity measured in MilliTesla</param>
    /// <returns>quantity measured in PetaTesla</returns>
	public static Quantity<double, PetaTesla> ToPetaTesla<T>(this BaseQuantity<T, MilliTesla> val) where T:IConvertible {
        return new Quantity<double, PetaTesla>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliTesla to TeraTesla
    /// </summary>
    /// <param name="val">quantity measured in MilliTesla</param>
    /// <returns>quantity measured in TeraTesla</returns>
	public static Quantity<double, TeraTesla> ToTeraTesla<T>(this BaseQuantity<T, MilliTesla> val) where T:IConvertible {
        return new Quantity<double, TeraTesla>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliTesla to GigaTesla
    /// </summary>
    /// <param name="val">quantity measured in MilliTesla</param>
    /// <returns>quantity measured in GigaTesla</returns>
	public static Quantity<double, GigaTesla> ToGigaTesla<T>(this BaseQuantity<T, MilliTesla> val) where T:IConvertible {
        return new Quantity<double, GigaTesla>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliTesla to MegaTesla
    /// </summary>
    /// <param name="val">quantity measured in MilliTesla</param>
    /// <returns>quantity measured in MegaTesla</returns>
	public static Quantity<double, MegaTesla> ToMegaTesla<T>(this BaseQuantity<T, MilliTesla> val) where T:IConvertible {
        return new Quantity<double, MegaTesla>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliTesla to KiloTesla
    /// </summary>
    /// <param name="val">quantity measured in MilliTesla</param>
    /// <returns>quantity measured in KiloTesla</returns>
	public static Quantity<double, KiloTesla> ToKiloTesla<T>(this BaseQuantity<T, MilliTesla> val) where T:IConvertible {
        return new Quantity<double, KiloTesla>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliTesla to HectoTesla
    /// </summary>
    /// <param name="val">quantity measured in MilliTesla</param>
    /// <returns>quantity measured in HectoTesla</returns>
	public static Quantity<double, HectoTesla> ToHectoTesla<T>(this BaseQuantity<T, MilliTesla> val) where T:IConvertible {
        return new Quantity<double, HectoTesla>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliTesla to DekaTesla
    /// </summary>
    /// <param name="val">quantity measured in MilliTesla</param>
    /// <returns>quantity measured in DekaTesla</returns>
	public static Quantity<double, DekaTesla> ToDekaTesla<T>(this BaseQuantity<T, MilliTesla> val) where T:IConvertible {
        return new Quantity<double, DekaTesla>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliTesla to DeciTesla
    /// </summary>
    /// <param name="val">quantity measured in MilliTesla</param>
    /// <returns>quantity measured in DeciTesla</returns>
	public static Quantity<double, DeciTesla> ToDeciTesla<T>(this BaseQuantity<T, MilliTesla> val) where T:IConvertible {
        return new Quantity<double, DeciTesla>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliTesla to CentiTesla
    /// </summary>
    /// <param name="val">quantity measured in MilliTesla</param>
    /// <returns>quantity measured in CentiTesla</returns>
	public static Quantity<double, CentiTesla> ToCentiTesla<T>(this BaseQuantity<T, MilliTesla> val) where T:IConvertible {
        return new Quantity<double, CentiTesla>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliTesla to MicroTesla
    /// </summary>
    /// <param name="val">quantity measured in MilliTesla</param>
    /// <returns>quantity measured in MicroTesla</returns>
	public static Quantity<double, MicroTesla> ToMicroTesla<T>(this BaseQuantity<T, MilliTesla> val) where T:IConvertible {
        return new Quantity<double, MicroTesla>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliTesla to NanoTesla
    /// </summary>
    /// <param name="val">quantity measured in MilliTesla</param>
    /// <returns>quantity measured in NanoTesla</returns>
	public static Quantity<double, NanoTesla> ToNanoTesla<T>(this BaseQuantity<T, MilliTesla> val) where T:IConvertible {
        return new Quantity<double, NanoTesla>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliTesla to PicoTesla
    /// </summary>
    /// <param name="val">quantity measured in MilliTesla</param>
    /// <returns>quantity measured in PicoTesla</returns>
	public static Quantity<double, PicoTesla> ToPicoTesla<T>(this BaseQuantity<T, MilliTesla> val) where T:IConvertible {
        return new Quantity<double, PicoTesla>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliTesla to FemtoTesla
    /// </summary>
    /// <param name="val">quantity measured in MilliTesla</param>
    /// <returns>quantity measured in FemtoTesla</returns>
	public static Quantity<double, FemtoTesla> ToFemtoTesla<T>(this BaseQuantity<T, MilliTesla> val) where T:IConvertible {
        return new Quantity<double, FemtoTesla>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliTesla to AttoTesla
    /// </summary>
    /// <param name="val">quantity measured in MilliTesla</param>
    /// <returns>quantity measured in AttoTesla</returns>
	public static Quantity<double, AttoTesla> ToAttoTesla<T>(this BaseQuantity<T, MilliTesla> val) where T:IConvertible {
        return new Quantity<double, AttoTesla>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliTesla to ZeptoTesla
    /// </summary>
    /// <param name="val">quantity measured in MilliTesla</param>
    /// <returns>quantity measured in ZeptoTesla</returns>
	public static Quantity<double, ZeptoTesla> ToZeptoTesla<T>(this BaseQuantity<T, MilliTesla> val) where T:IConvertible {
        return new Quantity<double, ZeptoTesla>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MilliTesla to YoctoTesla
    /// </summary>
    /// <param name="val">quantity measured in MilliTesla</param>
    /// <returns>quantity measured in YoctoTesla</returns>
	public static Quantity<double, YoctoTesla> ToYoctoTesla<T>(this BaseQuantity<T, MilliTesla> val) where T:IConvertible {
        return new Quantity<double, YoctoTesla>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert MicroTesla to YottaTesla
    /// </summary>
    /// <param name="val">quantity measured in MicroTesla</param>
    /// <returns>quantity measured in YottaTesla</returns>
	public static Quantity<double, YottaTesla> ToYottaTesla<T>(this BaseQuantity<T, MicroTesla> val) where T:IConvertible {
        return new Quantity<double, YottaTesla>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroTesla to ZettaTesla
    /// </summary>
    /// <param name="val">quantity measured in MicroTesla</param>
    /// <returns>quantity measured in ZettaTesla</returns>
	public static Quantity<double, ZettaTesla> ToZettaTesla<T>(this BaseQuantity<T, MicroTesla> val) where T:IConvertible {
        return new Quantity<double, ZettaTesla>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroTesla to ExaTesla
    /// </summary>
    /// <param name="val">quantity measured in MicroTesla</param>
    /// <returns>quantity measured in ExaTesla</returns>
	public static Quantity<double, ExaTesla> ToExaTesla<T>(this BaseQuantity<T, MicroTesla> val) where T:IConvertible {
        return new Quantity<double, ExaTesla>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroTesla to PetaTesla
    /// </summary>
    /// <param name="val">quantity measured in MicroTesla</param>
    /// <returns>quantity measured in PetaTesla</returns>
	public static Quantity<double, PetaTesla> ToPetaTesla<T>(this BaseQuantity<T, MicroTesla> val) where T:IConvertible {
        return new Quantity<double, PetaTesla>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroTesla to TeraTesla
    /// </summary>
    /// <param name="val">quantity measured in MicroTesla</param>
    /// <returns>quantity measured in TeraTesla</returns>
	public static Quantity<double, TeraTesla> ToTeraTesla<T>(this BaseQuantity<T, MicroTesla> val) where T:IConvertible {
        return new Quantity<double, TeraTesla>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroTesla to GigaTesla
    /// </summary>
    /// <param name="val">quantity measured in MicroTesla</param>
    /// <returns>quantity measured in GigaTesla</returns>
	public static Quantity<double, GigaTesla> ToGigaTesla<T>(this BaseQuantity<T, MicroTesla> val) where T:IConvertible {
        return new Quantity<double, GigaTesla>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroTesla to MegaTesla
    /// </summary>
    /// <param name="val">quantity measured in MicroTesla</param>
    /// <returns>quantity measured in MegaTesla</returns>
	public static Quantity<double, MegaTesla> ToMegaTesla<T>(this BaseQuantity<T, MicroTesla> val) where T:IConvertible {
        return new Quantity<double, MegaTesla>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroTesla to KiloTesla
    /// </summary>
    /// <param name="val">quantity measured in MicroTesla</param>
    /// <returns>quantity measured in KiloTesla</returns>
	public static Quantity<double, KiloTesla> ToKiloTesla<T>(this BaseQuantity<T, MicroTesla> val) where T:IConvertible {
        return new Quantity<double, KiloTesla>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroTesla to HectoTesla
    /// </summary>
    /// <param name="val">quantity measured in MicroTesla</param>
    /// <returns>quantity measured in HectoTesla</returns>
	public static Quantity<double, HectoTesla> ToHectoTesla<T>(this BaseQuantity<T, MicroTesla> val) where T:IConvertible {
        return new Quantity<double, HectoTesla>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroTesla to DekaTesla
    /// </summary>
    /// <param name="val">quantity measured in MicroTesla</param>
    /// <returns>quantity measured in DekaTesla</returns>
	public static Quantity<double, DekaTesla> ToDekaTesla<T>(this BaseQuantity<T, MicroTesla> val) where T:IConvertible {
        return new Quantity<double, DekaTesla>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroTesla to DeciTesla
    /// </summary>
    /// <param name="val">quantity measured in MicroTesla</param>
    /// <returns>quantity measured in DeciTesla</returns>
	public static Quantity<double, DeciTesla> ToDeciTesla<T>(this BaseQuantity<T, MicroTesla> val) where T:IConvertible {
        return new Quantity<double, DeciTesla>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroTesla to CentiTesla
    /// </summary>
    /// <param name="val">quantity measured in MicroTesla</param>
    /// <returns>quantity measured in CentiTesla</returns>
	public static Quantity<double, CentiTesla> ToCentiTesla<T>(this BaseQuantity<T, MicroTesla> val) where T:IConvertible {
        return new Quantity<double, CentiTesla>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroTesla to MilliTesla
    /// </summary>
    /// <param name="val">quantity measured in MicroTesla</param>
    /// <returns>quantity measured in MilliTesla</returns>
	public static Quantity<double, MilliTesla> ToMilliTesla<T>(this BaseQuantity<T, MicroTesla> val) where T:IConvertible {
        return new Quantity<double, MilliTesla>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroTesla to NanoTesla
    /// </summary>
    /// <param name="val">quantity measured in MicroTesla</param>
    /// <returns>quantity measured in NanoTesla</returns>
	public static Quantity<double, NanoTesla> ToNanoTesla<T>(this BaseQuantity<T, MicroTesla> val) where T:IConvertible {
        return new Quantity<double, NanoTesla>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroTesla to PicoTesla
    /// </summary>
    /// <param name="val">quantity measured in MicroTesla</param>
    /// <returns>quantity measured in PicoTesla</returns>
	public static Quantity<double, PicoTesla> ToPicoTesla<T>(this BaseQuantity<T, MicroTesla> val) where T:IConvertible {
        return new Quantity<double, PicoTesla>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroTesla to FemtoTesla
    /// </summary>
    /// <param name="val">quantity measured in MicroTesla</param>
    /// <returns>quantity measured in FemtoTesla</returns>
	public static Quantity<double, FemtoTesla> ToFemtoTesla<T>(this BaseQuantity<T, MicroTesla> val) where T:IConvertible {
        return new Quantity<double, FemtoTesla>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroTesla to AttoTesla
    /// </summary>
    /// <param name="val">quantity measured in MicroTesla</param>
    /// <returns>quantity measured in AttoTesla</returns>
	public static Quantity<double, AttoTesla> ToAttoTesla<T>(this BaseQuantity<T, MicroTesla> val) where T:IConvertible {
        return new Quantity<double, AttoTesla>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroTesla to ZeptoTesla
    /// </summary>
    /// <param name="val">quantity measured in MicroTesla</param>
    /// <returns>quantity measured in ZeptoTesla</returns>
	public static Quantity<double, ZeptoTesla> ToZeptoTesla<T>(this BaseQuantity<T, MicroTesla> val) where T:IConvertible {
        return new Quantity<double, ZeptoTesla>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert MicroTesla to YoctoTesla
    /// </summary>
    /// <param name="val">quantity measured in MicroTesla</param>
    /// <returns>quantity measured in YoctoTesla</returns>
	public static Quantity<double, YoctoTesla> ToYoctoTesla<T>(this BaseQuantity<T, MicroTesla> val) where T:IConvertible {
        return new Quantity<double, YoctoTesla>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert NanoTesla to YottaTesla
    /// </summary>
    /// <param name="val">quantity measured in NanoTesla</param>
    /// <returns>quantity measured in YottaTesla</returns>
	public static Quantity<double, YottaTesla> ToYottaTesla<T>(this BaseQuantity<T, NanoTesla> val) where T:IConvertible {
        return new Quantity<double, YottaTesla>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoTesla to ZettaTesla
    /// </summary>
    /// <param name="val">quantity measured in NanoTesla</param>
    /// <returns>quantity measured in ZettaTesla</returns>
	public static Quantity<double, ZettaTesla> ToZettaTesla<T>(this BaseQuantity<T, NanoTesla> val) where T:IConvertible {
        return new Quantity<double, ZettaTesla>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoTesla to ExaTesla
    /// </summary>
    /// <param name="val">quantity measured in NanoTesla</param>
    /// <returns>quantity measured in ExaTesla</returns>
	public static Quantity<double, ExaTesla> ToExaTesla<T>(this BaseQuantity<T, NanoTesla> val) where T:IConvertible {
        return new Quantity<double, ExaTesla>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoTesla to PetaTesla
    /// </summary>
    /// <param name="val">quantity measured in NanoTesla</param>
    /// <returns>quantity measured in PetaTesla</returns>
	public static Quantity<double, PetaTesla> ToPetaTesla<T>(this BaseQuantity<T, NanoTesla> val) where T:IConvertible {
        return new Quantity<double, PetaTesla>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoTesla to TeraTesla
    /// </summary>
    /// <param name="val">quantity measured in NanoTesla</param>
    /// <returns>quantity measured in TeraTesla</returns>
	public static Quantity<double, TeraTesla> ToTeraTesla<T>(this BaseQuantity<T, NanoTesla> val) where T:IConvertible {
        return new Quantity<double, TeraTesla>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoTesla to GigaTesla
    /// </summary>
    /// <param name="val">quantity measured in NanoTesla</param>
    /// <returns>quantity measured in GigaTesla</returns>
	public static Quantity<double, GigaTesla> ToGigaTesla<T>(this BaseQuantity<T, NanoTesla> val) where T:IConvertible {
        return new Quantity<double, GigaTesla>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoTesla to MegaTesla
    /// </summary>
    /// <param name="val">quantity measured in NanoTesla</param>
    /// <returns>quantity measured in MegaTesla</returns>
	public static Quantity<double, MegaTesla> ToMegaTesla<T>(this BaseQuantity<T, NanoTesla> val) where T:IConvertible {
        return new Quantity<double, MegaTesla>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoTesla to KiloTesla
    /// </summary>
    /// <param name="val">quantity measured in NanoTesla</param>
    /// <returns>quantity measured in KiloTesla</returns>
	public static Quantity<double, KiloTesla> ToKiloTesla<T>(this BaseQuantity<T, NanoTesla> val) where T:IConvertible {
        return new Quantity<double, KiloTesla>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoTesla to HectoTesla
    /// </summary>
    /// <param name="val">quantity measured in NanoTesla</param>
    /// <returns>quantity measured in HectoTesla</returns>
	public static Quantity<double, HectoTesla> ToHectoTesla<T>(this BaseQuantity<T, NanoTesla> val) where T:IConvertible {
        return new Quantity<double, HectoTesla>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoTesla to DekaTesla
    /// </summary>
    /// <param name="val">quantity measured in NanoTesla</param>
    /// <returns>quantity measured in DekaTesla</returns>
	public static Quantity<double, DekaTesla> ToDekaTesla<T>(this BaseQuantity<T, NanoTesla> val) where T:IConvertible {
        return new Quantity<double, DekaTesla>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoTesla to DeciTesla
    /// </summary>
    /// <param name="val">quantity measured in NanoTesla</param>
    /// <returns>quantity measured in DeciTesla</returns>
	public static Quantity<double, DeciTesla> ToDeciTesla<T>(this BaseQuantity<T, NanoTesla> val) where T:IConvertible {
        return new Quantity<double, DeciTesla>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoTesla to CentiTesla
    /// </summary>
    /// <param name="val">quantity measured in NanoTesla</param>
    /// <returns>quantity measured in CentiTesla</returns>
	public static Quantity<double, CentiTesla> ToCentiTesla<T>(this BaseQuantity<T, NanoTesla> val) where T:IConvertible {
        return new Quantity<double, CentiTesla>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoTesla to MilliTesla
    /// </summary>
    /// <param name="val">quantity measured in NanoTesla</param>
    /// <returns>quantity measured in MilliTesla</returns>
	public static Quantity<double, MilliTesla> ToMilliTesla<T>(this BaseQuantity<T, NanoTesla> val) where T:IConvertible {
        return new Quantity<double, MilliTesla>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoTesla to MicroTesla
    /// </summary>
    /// <param name="val">quantity measured in NanoTesla</param>
    /// <returns>quantity measured in MicroTesla</returns>
	public static Quantity<double, MicroTesla> ToMicroTesla<T>(this BaseQuantity<T, NanoTesla> val) where T:IConvertible {
        return new Quantity<double, MicroTesla>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoTesla to PicoTesla
    /// </summary>
    /// <param name="val">quantity measured in NanoTesla</param>
    /// <returns>quantity measured in PicoTesla</returns>
	public static Quantity<double, PicoTesla> ToPicoTesla<T>(this BaseQuantity<T, NanoTesla> val) where T:IConvertible {
        return new Quantity<double, PicoTesla>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoTesla to FemtoTesla
    /// </summary>
    /// <param name="val">quantity measured in NanoTesla</param>
    /// <returns>quantity measured in FemtoTesla</returns>
	public static Quantity<double, FemtoTesla> ToFemtoTesla<T>(this BaseQuantity<T, NanoTesla> val) where T:IConvertible {
        return new Quantity<double, FemtoTesla>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoTesla to AttoTesla
    /// </summary>
    /// <param name="val">quantity measured in NanoTesla</param>
    /// <returns>quantity measured in AttoTesla</returns>
	public static Quantity<double, AttoTesla> ToAttoTesla<T>(this BaseQuantity<T, NanoTesla> val) where T:IConvertible {
        return new Quantity<double, AttoTesla>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoTesla to ZeptoTesla
    /// </summary>
    /// <param name="val">quantity measured in NanoTesla</param>
    /// <returns>quantity measured in ZeptoTesla</returns>
	public static Quantity<double, ZeptoTesla> ToZeptoTesla<T>(this BaseQuantity<T, NanoTesla> val) where T:IConvertible {
        return new Quantity<double, ZeptoTesla>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert NanoTesla to YoctoTesla
    /// </summary>
    /// <param name="val">quantity measured in NanoTesla</param>
    /// <returns>quantity measured in YoctoTesla</returns>
	public static Quantity<double, YoctoTesla> ToYoctoTesla<T>(this BaseQuantity<T, NanoTesla> val) where T:IConvertible {
        return new Quantity<double, YoctoTesla>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert PicoTesla to YottaTesla
    /// </summary>
    /// <param name="val">quantity measured in PicoTesla</param>
    /// <returns>quantity measured in YottaTesla</returns>
	public static Quantity<double, YottaTesla> ToYottaTesla<T>(this BaseQuantity<T, PicoTesla> val) where T:IConvertible {
        return new Quantity<double, YottaTesla>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoTesla to ZettaTesla
    /// </summary>
    /// <param name="val">quantity measured in PicoTesla</param>
    /// <returns>quantity measured in ZettaTesla</returns>
	public static Quantity<double, ZettaTesla> ToZettaTesla<T>(this BaseQuantity<T, PicoTesla> val) where T:IConvertible {
        return new Quantity<double, ZettaTesla>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoTesla to ExaTesla
    /// </summary>
    /// <param name="val">quantity measured in PicoTesla</param>
    /// <returns>quantity measured in ExaTesla</returns>
	public static Quantity<double, ExaTesla> ToExaTesla<T>(this BaseQuantity<T, PicoTesla> val) where T:IConvertible {
        return new Quantity<double, ExaTesla>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoTesla to PetaTesla
    /// </summary>
    /// <param name="val">quantity measured in PicoTesla</param>
    /// <returns>quantity measured in PetaTesla</returns>
	public static Quantity<double, PetaTesla> ToPetaTesla<T>(this BaseQuantity<T, PicoTesla> val) where T:IConvertible {
        return new Quantity<double, PetaTesla>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoTesla to TeraTesla
    /// </summary>
    /// <param name="val">quantity measured in PicoTesla</param>
    /// <returns>quantity measured in TeraTesla</returns>
	public static Quantity<double, TeraTesla> ToTeraTesla<T>(this BaseQuantity<T, PicoTesla> val) where T:IConvertible {
        return new Quantity<double, TeraTesla>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoTesla to GigaTesla
    /// </summary>
    /// <param name="val">quantity measured in PicoTesla</param>
    /// <returns>quantity measured in GigaTesla</returns>
	public static Quantity<double, GigaTesla> ToGigaTesla<T>(this BaseQuantity<T, PicoTesla> val) where T:IConvertible {
        return new Quantity<double, GigaTesla>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoTesla to MegaTesla
    /// </summary>
    /// <param name="val">quantity measured in PicoTesla</param>
    /// <returns>quantity measured in MegaTesla</returns>
	public static Quantity<double, MegaTesla> ToMegaTesla<T>(this BaseQuantity<T, PicoTesla> val) where T:IConvertible {
        return new Quantity<double, MegaTesla>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoTesla to KiloTesla
    /// </summary>
    /// <param name="val">quantity measured in PicoTesla</param>
    /// <returns>quantity measured in KiloTesla</returns>
	public static Quantity<double, KiloTesla> ToKiloTesla<T>(this BaseQuantity<T, PicoTesla> val) where T:IConvertible {
        return new Quantity<double, KiloTesla>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoTesla to HectoTesla
    /// </summary>
    /// <param name="val">quantity measured in PicoTesla</param>
    /// <returns>quantity measured in HectoTesla</returns>
	public static Quantity<double, HectoTesla> ToHectoTesla<T>(this BaseQuantity<T, PicoTesla> val) where T:IConvertible {
        return new Quantity<double, HectoTesla>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoTesla to DekaTesla
    /// </summary>
    /// <param name="val">quantity measured in PicoTesla</param>
    /// <returns>quantity measured in DekaTesla</returns>
	public static Quantity<double, DekaTesla> ToDekaTesla<T>(this BaseQuantity<T, PicoTesla> val) where T:IConvertible {
        return new Quantity<double, DekaTesla>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoTesla to DeciTesla
    /// </summary>
    /// <param name="val">quantity measured in PicoTesla</param>
    /// <returns>quantity measured in DeciTesla</returns>
	public static Quantity<double, DeciTesla> ToDeciTesla<T>(this BaseQuantity<T, PicoTesla> val) where T:IConvertible {
        return new Quantity<double, DeciTesla>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoTesla to CentiTesla
    /// </summary>
    /// <param name="val">quantity measured in PicoTesla</param>
    /// <returns>quantity measured in CentiTesla</returns>
	public static Quantity<double, CentiTesla> ToCentiTesla<T>(this BaseQuantity<T, PicoTesla> val) where T:IConvertible {
        return new Quantity<double, CentiTesla>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoTesla to MilliTesla
    /// </summary>
    /// <param name="val">quantity measured in PicoTesla</param>
    /// <returns>quantity measured in MilliTesla</returns>
	public static Quantity<double, MilliTesla> ToMilliTesla<T>(this BaseQuantity<T, PicoTesla> val) where T:IConvertible {
        return new Quantity<double, MilliTesla>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoTesla to MicroTesla
    /// </summary>
    /// <param name="val">quantity measured in PicoTesla</param>
    /// <returns>quantity measured in MicroTesla</returns>
	public static Quantity<double, MicroTesla> ToMicroTesla<T>(this BaseQuantity<T, PicoTesla> val) where T:IConvertible {
        return new Quantity<double, MicroTesla>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoTesla to NanoTesla
    /// </summary>
    /// <param name="val">quantity measured in PicoTesla</param>
    /// <returns>quantity measured in NanoTesla</returns>
	public static Quantity<double, NanoTesla> ToNanoTesla<T>(this BaseQuantity<T, PicoTesla> val) where T:IConvertible {
        return new Quantity<double, NanoTesla>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoTesla to FemtoTesla
    /// </summary>
    /// <param name="val">quantity measured in PicoTesla</param>
    /// <returns>quantity measured in FemtoTesla</returns>
	public static Quantity<double, FemtoTesla> ToFemtoTesla<T>(this BaseQuantity<T, PicoTesla> val) where T:IConvertible {
        return new Quantity<double, FemtoTesla>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoTesla to AttoTesla
    /// </summary>
    /// <param name="val">quantity measured in PicoTesla</param>
    /// <returns>quantity measured in AttoTesla</returns>
	public static Quantity<double, AttoTesla> ToAttoTesla<T>(this BaseQuantity<T, PicoTesla> val) where T:IConvertible {
        return new Quantity<double, AttoTesla>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoTesla to ZeptoTesla
    /// </summary>
    /// <param name="val">quantity measured in PicoTesla</param>
    /// <returns>quantity measured in ZeptoTesla</returns>
	public static Quantity<double, ZeptoTesla> ToZeptoTesla<T>(this BaseQuantity<T, PicoTesla> val) where T:IConvertible {
        return new Quantity<double, ZeptoTesla>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert PicoTesla to YoctoTesla
    /// </summary>
    /// <param name="val">quantity measured in PicoTesla</param>
    /// <returns>quantity measured in YoctoTesla</returns>
	public static Quantity<double, YoctoTesla> ToYoctoTesla<T>(this BaseQuantity<T, PicoTesla> val) where T:IConvertible {
        return new Quantity<double, YoctoTesla>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert FemtoTesla to YottaTesla
    /// </summary>
    /// <param name="val">quantity measured in FemtoTesla</param>
    /// <returns>quantity measured in YottaTesla</returns>
	public static Quantity<double, YottaTesla> ToYottaTesla<T>(this BaseQuantity<T, FemtoTesla> val) where T:IConvertible {
        return new Quantity<double, YottaTesla>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoTesla to ZettaTesla
    /// </summary>
    /// <param name="val">quantity measured in FemtoTesla</param>
    /// <returns>quantity measured in ZettaTesla</returns>
	public static Quantity<double, ZettaTesla> ToZettaTesla<T>(this BaseQuantity<T, FemtoTesla> val) where T:IConvertible {
        return new Quantity<double, ZettaTesla>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoTesla to ExaTesla
    /// </summary>
    /// <param name="val">quantity measured in FemtoTesla</param>
    /// <returns>quantity measured in ExaTesla</returns>
	public static Quantity<double, ExaTesla> ToExaTesla<T>(this BaseQuantity<T, FemtoTesla> val) where T:IConvertible {
        return new Quantity<double, ExaTesla>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoTesla to PetaTesla
    /// </summary>
    /// <param name="val">quantity measured in FemtoTesla</param>
    /// <returns>quantity measured in PetaTesla</returns>
	public static Quantity<double, PetaTesla> ToPetaTesla<T>(this BaseQuantity<T, FemtoTesla> val) where T:IConvertible {
        return new Quantity<double, PetaTesla>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoTesla to TeraTesla
    /// </summary>
    /// <param name="val">quantity measured in FemtoTesla</param>
    /// <returns>quantity measured in TeraTesla</returns>
	public static Quantity<double, TeraTesla> ToTeraTesla<T>(this BaseQuantity<T, FemtoTesla> val) where T:IConvertible {
        return new Quantity<double, TeraTesla>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoTesla to GigaTesla
    /// </summary>
    /// <param name="val">quantity measured in FemtoTesla</param>
    /// <returns>quantity measured in GigaTesla</returns>
	public static Quantity<double, GigaTesla> ToGigaTesla<T>(this BaseQuantity<T, FemtoTesla> val) where T:IConvertible {
        return new Quantity<double, GigaTesla>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoTesla to MegaTesla
    /// </summary>
    /// <param name="val">quantity measured in FemtoTesla</param>
    /// <returns>quantity measured in MegaTesla</returns>
	public static Quantity<double, MegaTesla> ToMegaTesla<T>(this BaseQuantity<T, FemtoTesla> val) where T:IConvertible {
        return new Quantity<double, MegaTesla>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoTesla to KiloTesla
    /// </summary>
    /// <param name="val">quantity measured in FemtoTesla</param>
    /// <returns>quantity measured in KiloTesla</returns>
	public static Quantity<double, KiloTesla> ToKiloTesla<T>(this BaseQuantity<T, FemtoTesla> val) where T:IConvertible {
        return new Quantity<double, KiloTesla>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoTesla to HectoTesla
    /// </summary>
    /// <param name="val">quantity measured in FemtoTesla</param>
    /// <returns>quantity measured in HectoTesla</returns>
	public static Quantity<double, HectoTesla> ToHectoTesla<T>(this BaseQuantity<T, FemtoTesla> val) where T:IConvertible {
        return new Quantity<double, HectoTesla>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoTesla to DekaTesla
    /// </summary>
    /// <param name="val">quantity measured in FemtoTesla</param>
    /// <returns>quantity measured in DekaTesla</returns>
	public static Quantity<double, DekaTesla> ToDekaTesla<T>(this BaseQuantity<T, FemtoTesla> val) where T:IConvertible {
        return new Quantity<double, DekaTesla>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoTesla to DeciTesla
    /// </summary>
    /// <param name="val">quantity measured in FemtoTesla</param>
    /// <returns>quantity measured in DeciTesla</returns>
	public static Quantity<double, DeciTesla> ToDeciTesla<T>(this BaseQuantity<T, FemtoTesla> val) where T:IConvertible {
        return new Quantity<double, DeciTesla>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoTesla to CentiTesla
    /// </summary>
    /// <param name="val">quantity measured in FemtoTesla</param>
    /// <returns>quantity measured in CentiTesla</returns>
	public static Quantity<double, CentiTesla> ToCentiTesla<T>(this BaseQuantity<T, FemtoTesla> val) where T:IConvertible {
        return new Quantity<double, CentiTesla>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoTesla to MilliTesla
    /// </summary>
    /// <param name="val">quantity measured in FemtoTesla</param>
    /// <returns>quantity measured in MilliTesla</returns>
	public static Quantity<double, MilliTesla> ToMilliTesla<T>(this BaseQuantity<T, FemtoTesla> val) where T:IConvertible {
        return new Quantity<double, MilliTesla>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoTesla to MicroTesla
    /// </summary>
    /// <param name="val">quantity measured in FemtoTesla</param>
    /// <returns>quantity measured in MicroTesla</returns>
	public static Quantity<double, MicroTesla> ToMicroTesla<T>(this BaseQuantity<T, FemtoTesla> val) where T:IConvertible {
        return new Quantity<double, MicroTesla>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoTesla to NanoTesla
    /// </summary>
    /// <param name="val">quantity measured in FemtoTesla</param>
    /// <returns>quantity measured in NanoTesla</returns>
	public static Quantity<double, NanoTesla> ToNanoTesla<T>(this BaseQuantity<T, FemtoTesla> val) where T:IConvertible {
        return new Quantity<double, NanoTesla>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoTesla to PicoTesla
    /// </summary>
    /// <param name="val">quantity measured in FemtoTesla</param>
    /// <returns>quantity measured in PicoTesla</returns>
	public static Quantity<double, PicoTesla> ToPicoTesla<T>(this BaseQuantity<T, FemtoTesla> val) where T:IConvertible {
        return new Quantity<double, PicoTesla>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoTesla to AttoTesla
    /// </summary>
    /// <param name="val">quantity measured in FemtoTesla</param>
    /// <returns>quantity measured in AttoTesla</returns>
	public static Quantity<double, AttoTesla> ToAttoTesla<T>(this BaseQuantity<T, FemtoTesla> val) where T:IConvertible {
        return new Quantity<double, AttoTesla>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoTesla to ZeptoTesla
    /// </summary>
    /// <param name="val">quantity measured in FemtoTesla</param>
    /// <returns>quantity measured in ZeptoTesla</returns>
	public static Quantity<double, ZeptoTesla> ToZeptoTesla<T>(this BaseQuantity<T, FemtoTesla> val) where T:IConvertible {
        return new Quantity<double, ZeptoTesla>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert FemtoTesla to YoctoTesla
    /// </summary>
    /// <param name="val">quantity measured in FemtoTesla</param>
    /// <returns>quantity measured in YoctoTesla</returns>
	public static Quantity<double, YoctoTesla> ToYoctoTesla<T>(this BaseQuantity<T, FemtoTesla> val) where T:IConvertible {
        return new Quantity<double, YoctoTesla>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert AttoTesla to YottaTesla
    /// </summary>
    /// <param name="val">quantity measured in AttoTesla</param>
    /// <returns>quantity measured in YottaTesla</returns>
	public static Quantity<double, YottaTesla> ToYottaTesla<T>(this BaseQuantity<T, AttoTesla> val) where T:IConvertible {
        return new Quantity<double, YottaTesla>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoTesla to ZettaTesla
    /// </summary>
    /// <param name="val">quantity measured in AttoTesla</param>
    /// <returns>quantity measured in ZettaTesla</returns>
	public static Quantity<double, ZettaTesla> ToZettaTesla<T>(this BaseQuantity<T, AttoTesla> val) where T:IConvertible {
        return new Quantity<double, ZettaTesla>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoTesla to ExaTesla
    /// </summary>
    /// <param name="val">quantity measured in AttoTesla</param>
    /// <returns>quantity measured in ExaTesla</returns>
	public static Quantity<double, ExaTesla> ToExaTesla<T>(this BaseQuantity<T, AttoTesla> val) where T:IConvertible {
        return new Quantity<double, ExaTesla>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoTesla to PetaTesla
    /// </summary>
    /// <param name="val">quantity measured in AttoTesla</param>
    /// <returns>quantity measured in PetaTesla</returns>
	public static Quantity<double, PetaTesla> ToPetaTesla<T>(this BaseQuantity<T, AttoTesla> val) where T:IConvertible {
        return new Quantity<double, PetaTesla>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoTesla to TeraTesla
    /// </summary>
    /// <param name="val">quantity measured in AttoTesla</param>
    /// <returns>quantity measured in TeraTesla</returns>
	public static Quantity<double, TeraTesla> ToTeraTesla<T>(this BaseQuantity<T, AttoTesla> val) where T:IConvertible {
        return new Quantity<double, TeraTesla>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoTesla to GigaTesla
    /// </summary>
    /// <param name="val">quantity measured in AttoTesla</param>
    /// <returns>quantity measured in GigaTesla</returns>
	public static Quantity<double, GigaTesla> ToGigaTesla<T>(this BaseQuantity<T, AttoTesla> val) where T:IConvertible {
        return new Quantity<double, GigaTesla>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoTesla to MegaTesla
    /// </summary>
    /// <param name="val">quantity measured in AttoTesla</param>
    /// <returns>quantity measured in MegaTesla</returns>
	public static Quantity<double, MegaTesla> ToMegaTesla<T>(this BaseQuantity<T, AttoTesla> val) where T:IConvertible {
        return new Quantity<double, MegaTesla>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoTesla to KiloTesla
    /// </summary>
    /// <param name="val">quantity measured in AttoTesla</param>
    /// <returns>quantity measured in KiloTesla</returns>
	public static Quantity<double, KiloTesla> ToKiloTesla<T>(this BaseQuantity<T, AttoTesla> val) where T:IConvertible {
        return new Quantity<double, KiloTesla>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoTesla to HectoTesla
    /// </summary>
    /// <param name="val">quantity measured in AttoTesla</param>
    /// <returns>quantity measured in HectoTesla</returns>
	public static Quantity<double, HectoTesla> ToHectoTesla<T>(this BaseQuantity<T, AttoTesla> val) where T:IConvertible {
        return new Quantity<double, HectoTesla>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoTesla to DekaTesla
    /// </summary>
    /// <param name="val">quantity measured in AttoTesla</param>
    /// <returns>quantity measured in DekaTesla</returns>
	public static Quantity<double, DekaTesla> ToDekaTesla<T>(this BaseQuantity<T, AttoTesla> val) where T:IConvertible {
        return new Quantity<double, DekaTesla>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoTesla to DeciTesla
    /// </summary>
    /// <param name="val">quantity measured in AttoTesla</param>
    /// <returns>quantity measured in DeciTesla</returns>
	public static Quantity<double, DeciTesla> ToDeciTesla<T>(this BaseQuantity<T, AttoTesla> val) where T:IConvertible {
        return new Quantity<double, DeciTesla>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoTesla to CentiTesla
    /// </summary>
    /// <param name="val">quantity measured in AttoTesla</param>
    /// <returns>quantity measured in CentiTesla</returns>
	public static Quantity<double, CentiTesla> ToCentiTesla<T>(this BaseQuantity<T, AttoTesla> val) where T:IConvertible {
        return new Quantity<double, CentiTesla>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoTesla to MilliTesla
    /// </summary>
    /// <param name="val">quantity measured in AttoTesla</param>
    /// <returns>quantity measured in MilliTesla</returns>
	public static Quantity<double, MilliTesla> ToMilliTesla<T>(this BaseQuantity<T, AttoTesla> val) where T:IConvertible {
        return new Quantity<double, MilliTesla>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoTesla to MicroTesla
    /// </summary>
    /// <param name="val">quantity measured in AttoTesla</param>
    /// <returns>quantity measured in MicroTesla</returns>
	public static Quantity<double, MicroTesla> ToMicroTesla<T>(this BaseQuantity<T, AttoTesla> val) where T:IConvertible {
        return new Quantity<double, MicroTesla>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoTesla to NanoTesla
    /// </summary>
    /// <param name="val">quantity measured in AttoTesla</param>
    /// <returns>quantity measured in NanoTesla</returns>
	public static Quantity<double, NanoTesla> ToNanoTesla<T>(this BaseQuantity<T, AttoTesla> val) where T:IConvertible {
        return new Quantity<double, NanoTesla>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoTesla to PicoTesla
    /// </summary>
    /// <param name="val">quantity measured in AttoTesla</param>
    /// <returns>quantity measured in PicoTesla</returns>
	public static Quantity<double, PicoTesla> ToPicoTesla<T>(this BaseQuantity<T, AttoTesla> val) where T:IConvertible {
        return new Quantity<double, PicoTesla>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoTesla to FemtoTesla
    /// </summary>
    /// <param name="val">quantity measured in AttoTesla</param>
    /// <returns>quantity measured in FemtoTesla</returns>
	public static Quantity<double, FemtoTesla> ToFemtoTesla<T>(this BaseQuantity<T, AttoTesla> val) where T:IConvertible {
        return new Quantity<double, FemtoTesla>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoTesla to ZeptoTesla
    /// </summary>
    /// <param name="val">quantity measured in AttoTesla</param>
    /// <returns>quantity measured in ZeptoTesla</returns>
	public static Quantity<double, ZeptoTesla> ToZeptoTesla<T>(this BaseQuantity<T, AttoTesla> val) where T:IConvertible {
        return new Quantity<double, ZeptoTesla>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert AttoTesla to YoctoTesla
    /// </summary>
    /// <param name="val">quantity measured in AttoTesla</param>
    /// <returns>quantity measured in YoctoTesla</returns>
	public static Quantity<double, YoctoTesla> ToYoctoTesla<T>(this BaseQuantity<T, AttoTesla> val) where T:IConvertible {
        return new Quantity<double, YoctoTesla>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoTesla to YottaTesla
    /// </summary>
    /// <param name="val">quantity measured in ZeptoTesla</param>
    /// <returns>quantity measured in YottaTesla</returns>
	public static Quantity<double, YottaTesla> ToYottaTesla<T>(this BaseQuantity<T, ZeptoTesla> val) where T:IConvertible {
        return new Quantity<double, YottaTesla>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoTesla to ZettaTesla
    /// </summary>
    /// <param name="val">quantity measured in ZeptoTesla</param>
    /// <returns>quantity measured in ZettaTesla</returns>
	public static Quantity<double, ZettaTesla> ToZettaTesla<T>(this BaseQuantity<T, ZeptoTesla> val) where T:IConvertible {
        return new Quantity<double, ZettaTesla>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoTesla to ExaTesla
    /// </summary>
    /// <param name="val">quantity measured in ZeptoTesla</param>
    /// <returns>quantity measured in ExaTesla</returns>
	public static Quantity<double, ExaTesla> ToExaTesla<T>(this BaseQuantity<T, ZeptoTesla> val) where T:IConvertible {
        return new Quantity<double, ExaTesla>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoTesla to PetaTesla
    /// </summary>
    /// <param name="val">quantity measured in ZeptoTesla</param>
    /// <returns>quantity measured in PetaTesla</returns>
	public static Quantity<double, PetaTesla> ToPetaTesla<T>(this BaseQuantity<T, ZeptoTesla> val) where T:IConvertible {
        return new Quantity<double, PetaTesla>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoTesla to TeraTesla
    /// </summary>
    /// <param name="val">quantity measured in ZeptoTesla</param>
    /// <returns>quantity measured in TeraTesla</returns>
	public static Quantity<double, TeraTesla> ToTeraTesla<T>(this BaseQuantity<T, ZeptoTesla> val) where T:IConvertible {
        return new Quantity<double, TeraTesla>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoTesla to GigaTesla
    /// </summary>
    /// <param name="val">quantity measured in ZeptoTesla</param>
    /// <returns>quantity measured in GigaTesla</returns>
	public static Quantity<double, GigaTesla> ToGigaTesla<T>(this BaseQuantity<T, ZeptoTesla> val) where T:IConvertible {
        return new Quantity<double, GigaTesla>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoTesla to MegaTesla
    /// </summary>
    /// <param name="val">quantity measured in ZeptoTesla</param>
    /// <returns>quantity measured in MegaTesla</returns>
	public static Quantity<double, MegaTesla> ToMegaTesla<T>(this BaseQuantity<T, ZeptoTesla> val) where T:IConvertible {
        return new Quantity<double, MegaTesla>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoTesla to KiloTesla
    /// </summary>
    /// <param name="val">quantity measured in ZeptoTesla</param>
    /// <returns>quantity measured in KiloTesla</returns>
	public static Quantity<double, KiloTesla> ToKiloTesla<T>(this BaseQuantity<T, ZeptoTesla> val) where T:IConvertible {
        return new Quantity<double, KiloTesla>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoTesla to HectoTesla
    /// </summary>
    /// <param name="val">quantity measured in ZeptoTesla</param>
    /// <returns>quantity measured in HectoTesla</returns>
	public static Quantity<double, HectoTesla> ToHectoTesla<T>(this BaseQuantity<T, ZeptoTesla> val) where T:IConvertible {
        return new Quantity<double, HectoTesla>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoTesla to DekaTesla
    /// </summary>
    /// <param name="val">quantity measured in ZeptoTesla</param>
    /// <returns>quantity measured in DekaTesla</returns>
	public static Quantity<double, DekaTesla> ToDekaTesla<T>(this BaseQuantity<T, ZeptoTesla> val) where T:IConvertible {
        return new Quantity<double, DekaTesla>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoTesla to DeciTesla
    /// </summary>
    /// <param name="val">quantity measured in ZeptoTesla</param>
    /// <returns>quantity measured in DeciTesla</returns>
	public static Quantity<double, DeciTesla> ToDeciTesla<T>(this BaseQuantity<T, ZeptoTesla> val) where T:IConvertible {
        return new Quantity<double, DeciTesla>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoTesla to CentiTesla
    /// </summary>
    /// <param name="val">quantity measured in ZeptoTesla</param>
    /// <returns>quantity measured in CentiTesla</returns>
	public static Quantity<double, CentiTesla> ToCentiTesla<T>(this BaseQuantity<T, ZeptoTesla> val) where T:IConvertible {
        return new Quantity<double, CentiTesla>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoTesla to MilliTesla
    /// </summary>
    /// <param name="val">quantity measured in ZeptoTesla</param>
    /// <returns>quantity measured in MilliTesla</returns>
	public static Quantity<double, MilliTesla> ToMilliTesla<T>(this BaseQuantity<T, ZeptoTesla> val) where T:IConvertible {
        return new Quantity<double, MilliTesla>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoTesla to MicroTesla
    /// </summary>
    /// <param name="val">quantity measured in ZeptoTesla</param>
    /// <returns>quantity measured in MicroTesla</returns>
	public static Quantity<double, MicroTesla> ToMicroTesla<T>(this BaseQuantity<T, ZeptoTesla> val) where T:IConvertible {
        return new Quantity<double, MicroTesla>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoTesla to NanoTesla
    /// </summary>
    /// <param name="val">quantity measured in ZeptoTesla</param>
    /// <returns>quantity measured in NanoTesla</returns>
	public static Quantity<double, NanoTesla> ToNanoTesla<T>(this BaseQuantity<T, ZeptoTesla> val) where T:IConvertible {
        return new Quantity<double, NanoTesla>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoTesla to PicoTesla
    /// </summary>
    /// <param name="val">quantity measured in ZeptoTesla</param>
    /// <returns>quantity measured in PicoTesla</returns>
	public static Quantity<double, PicoTesla> ToPicoTesla<T>(this BaseQuantity<T, ZeptoTesla> val) where T:IConvertible {
        return new Quantity<double, PicoTesla>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoTesla to FemtoTesla
    /// </summary>
    /// <param name="val">quantity measured in ZeptoTesla</param>
    /// <returns>quantity measured in FemtoTesla</returns>
	public static Quantity<double, FemtoTesla> ToFemtoTesla<T>(this BaseQuantity<T, ZeptoTesla> val) where T:IConvertible {
        return new Quantity<double, FemtoTesla>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoTesla to AttoTesla
    /// </summary>
    /// <param name="val">quantity measured in ZeptoTesla</param>
    /// <returns>quantity measured in AttoTesla</returns>
	public static Quantity<double, AttoTesla> ToAttoTesla<T>(this BaseQuantity<T, ZeptoTesla> val) where T:IConvertible {
        return new Quantity<double, AttoTesla>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert ZeptoTesla to YoctoTesla
    /// </summary>
    /// <param name="val">quantity measured in ZeptoTesla</param>
    /// <returns>quantity measured in YoctoTesla</returns>
	public static Quantity<double, YoctoTesla> ToYoctoTesla<T>(this BaseQuantity<T, ZeptoTesla> val) where T:IConvertible {
        return new Quantity<double, YoctoTesla>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert YoctoTesla to YottaTesla
    /// </summary>
    /// <param name="val">quantity measured in YoctoTesla</param>
    /// <returns>quantity measured in YottaTesla</returns>
	public static Quantity<double, YottaTesla> ToYottaTesla<T>(this BaseQuantity<T, YoctoTesla> val) where T:IConvertible {
        return new Quantity<double, YottaTesla>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoTesla to ZettaTesla
    /// </summary>
    /// <param name="val">quantity measured in YoctoTesla</param>
    /// <returns>quantity measured in ZettaTesla</returns>
	public static Quantity<double, ZettaTesla> ToZettaTesla<T>(this BaseQuantity<T, YoctoTesla> val) where T:IConvertible {
        return new Quantity<double, ZettaTesla>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoTesla to ExaTesla
    /// </summary>
    /// <param name="val">quantity measured in YoctoTesla</param>
    /// <returns>quantity measured in ExaTesla</returns>
	public static Quantity<double, ExaTesla> ToExaTesla<T>(this BaseQuantity<T, YoctoTesla> val) where T:IConvertible {
        return new Quantity<double, ExaTesla>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoTesla to PetaTesla
    /// </summary>
    /// <param name="val">quantity measured in YoctoTesla</param>
    /// <returns>quantity measured in PetaTesla</returns>
	public static Quantity<double, PetaTesla> ToPetaTesla<T>(this BaseQuantity<T, YoctoTesla> val) where T:IConvertible {
        return new Quantity<double, PetaTesla>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoTesla to TeraTesla
    /// </summary>
    /// <param name="val">quantity measured in YoctoTesla</param>
    /// <returns>quantity measured in TeraTesla</returns>
	public static Quantity<double, TeraTesla> ToTeraTesla<T>(this BaseQuantity<T, YoctoTesla> val) where T:IConvertible {
        return new Quantity<double, TeraTesla>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoTesla to GigaTesla
    /// </summary>
    /// <param name="val">quantity measured in YoctoTesla</param>
    /// <returns>quantity measured in GigaTesla</returns>
	public static Quantity<double, GigaTesla> ToGigaTesla<T>(this BaseQuantity<T, YoctoTesla> val) where T:IConvertible {
        return new Quantity<double, GigaTesla>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoTesla to MegaTesla
    /// </summary>
    /// <param name="val">quantity measured in YoctoTesla</param>
    /// <returns>quantity measured in MegaTesla</returns>
	public static Quantity<double, MegaTesla> ToMegaTesla<T>(this BaseQuantity<T, YoctoTesla> val) where T:IConvertible {
        return new Quantity<double, MegaTesla>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoTesla to KiloTesla
    /// </summary>
    /// <param name="val">quantity measured in YoctoTesla</param>
    /// <returns>quantity measured in KiloTesla</returns>
	public static Quantity<double, KiloTesla> ToKiloTesla<T>(this BaseQuantity<T, YoctoTesla> val) where T:IConvertible {
        return new Quantity<double, KiloTesla>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoTesla to HectoTesla
    /// </summary>
    /// <param name="val">quantity measured in YoctoTesla</param>
    /// <returns>quantity measured in HectoTesla</returns>
	public static Quantity<double, HectoTesla> ToHectoTesla<T>(this BaseQuantity<T, YoctoTesla> val) where T:IConvertible {
        return new Quantity<double, HectoTesla>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoTesla to DekaTesla
    /// </summary>
    /// <param name="val">quantity measured in YoctoTesla</param>
    /// <returns>quantity measured in DekaTesla</returns>
	public static Quantity<double, DekaTesla> ToDekaTesla<T>(this BaseQuantity<T, YoctoTesla> val) where T:IConvertible {
        return new Quantity<double, DekaTesla>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoTesla to DeciTesla
    /// </summary>
    /// <param name="val">quantity measured in YoctoTesla</param>
    /// <returns>quantity measured in DeciTesla</returns>
	public static Quantity<double, DeciTesla> ToDeciTesla<T>(this BaseQuantity<T, YoctoTesla> val) where T:IConvertible {
        return new Quantity<double, DeciTesla>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoTesla to CentiTesla
    /// </summary>
    /// <param name="val">quantity measured in YoctoTesla</param>
    /// <returns>quantity measured in CentiTesla</returns>
	public static Quantity<double, CentiTesla> ToCentiTesla<T>(this BaseQuantity<T, YoctoTesla> val) where T:IConvertible {
        return new Quantity<double, CentiTesla>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoTesla to MilliTesla
    /// </summary>
    /// <param name="val">quantity measured in YoctoTesla</param>
    /// <returns>quantity measured in MilliTesla</returns>
	public static Quantity<double, MilliTesla> ToMilliTesla<T>(this BaseQuantity<T, YoctoTesla> val) where T:IConvertible {
        return new Quantity<double, MilliTesla>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoTesla to MicroTesla
    /// </summary>
    /// <param name="val">quantity measured in YoctoTesla</param>
    /// <returns>quantity measured in MicroTesla</returns>
	public static Quantity<double, MicroTesla> ToMicroTesla<T>(this BaseQuantity<T, YoctoTesla> val) where T:IConvertible {
        return new Quantity<double, MicroTesla>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoTesla to NanoTesla
    /// </summary>
    /// <param name="val">quantity measured in YoctoTesla</param>
    /// <returns>quantity measured in NanoTesla</returns>
	public static Quantity<double, NanoTesla> ToNanoTesla<T>(this BaseQuantity<T, YoctoTesla> val) where T:IConvertible {
        return new Quantity<double, NanoTesla>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoTesla to PicoTesla
    /// </summary>
    /// <param name="val">quantity measured in YoctoTesla</param>
    /// <returns>quantity measured in PicoTesla</returns>
	public static Quantity<double, PicoTesla> ToPicoTesla<T>(this BaseQuantity<T, YoctoTesla> val) where T:IConvertible {
        return new Quantity<double, PicoTesla>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoTesla to FemtoTesla
    /// </summary>
    /// <param name="val">quantity measured in YoctoTesla</param>
    /// <returns>quantity measured in FemtoTesla</returns>
	public static Quantity<double, FemtoTesla> ToFemtoTesla<T>(this BaseQuantity<T, YoctoTesla> val) where T:IConvertible {
        return new Quantity<double, FemtoTesla>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoTesla to AttoTesla
    /// </summary>
    /// <param name="val">quantity measured in YoctoTesla</param>
    /// <returns>quantity measured in AttoTesla</returns>
	public static Quantity<double, AttoTesla> ToAttoTesla<T>(this BaseQuantity<T, YoctoTesla> val) where T:IConvertible {
        return new Quantity<double, AttoTesla>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert YoctoTesla to ZeptoTesla
    /// </summary>
    /// <param name="val">quantity measured in YoctoTesla</param>
    /// <returns>quantity measured in ZeptoTesla</returns>
	public static Quantity<double, ZeptoTesla> ToZeptoTesla<T>(this BaseQuantity<T, YoctoTesla> val) where T:IConvertible {
        return new Quantity<double, ZeptoTesla>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
}
}