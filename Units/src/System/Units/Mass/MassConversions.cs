using System;

namespace System.Units.Mass {

public static class MassConversions {
	/// <summary>
    /// Extension method to convert Gram to Yottagram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in Yottagram</returns>
	public static Quantity<double, Yottagram> ToYottagram<T>(this Quantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, Yottagram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Gram to Zettagram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in Zettagram</returns>
	public static Quantity<double, Zettagram> ToZettagram<T>(this Quantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, Zettagram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Gram to Exagram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in Exagram</returns>
	public static Quantity<double, Exagram> ToExagram<T>(this Quantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, Exagram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Gram to Petagram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in Petagram</returns>
	public static Quantity<double, Petagram> ToPetagram<T>(this Quantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, Petagram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Gram to Teragram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in Teragram</returns>
	public static Quantity<double, Teragram> ToTeragram<T>(this Quantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, Teragram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Gram to Gigagram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in Gigagram</returns>
	public static Quantity<double, Gigagram> ToGigagram<T>(this Quantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, Gigagram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gram to Megagram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in Megagram</returns>
	public static Quantity<double, Megagram> ToMegagram<T>(this Quantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, Megagram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Gram to Kilogram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in Kilogram</returns>
	public static Quantity<double, Kilogram> ToKilogram<T>(this Quantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, Kilogram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Gram to Hectogram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in Hectogram</returns>
	public static Quantity<double, Hectogram> ToHectogram<T>(this Quantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, Hectogram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Gram to Dekagram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in Dekagram</returns>
	public static Quantity<double, Dekagram> ToDekagram<T>(this Quantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, Dekagram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Gram to Decigram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in Decigram</returns>
	public static Quantity<double, Decigram> ToDecigram<T>(this Quantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, Decigram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Gram to Centigram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in Centigram</returns>
	public static Quantity<double, Centigram> ToCentigram<T>(this Quantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, Centigram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Gram to Milligram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in Milligram</returns>
	public static Quantity<double, Milligram> ToMilligram<T>(this Quantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, Milligram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Gram to Microgram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in Microgram</returns>
	public static Quantity<double, Microgram> ToMicrogram<T>(this Quantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, Microgram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Gram to Nanogram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in Nanogram</returns>
	public static Quantity<double, Nanogram> ToNanogram<T>(this Quantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, Nanogram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Gram to Picogram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in Picogram</returns>
	public static Quantity<double, Picogram> ToPicogram<T>(this Quantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, Picogram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Gram to Femtogram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in Femtogram</returns>
	public static Quantity<double, Femtogram> ToFemtogram<T>(this Quantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, Femtogram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Gram to Attogram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in Attogram</returns>
	public static Quantity<double, Attogram> ToAttogram<T>(this Quantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, Attogram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Gram to Zeptogram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in Zeptogram</returns>
	public static Quantity<double, Zeptogram> ToZeptogram<T>(this Quantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, Zeptogram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Gram to Yoctogram
    /// </summary>
    /// <param name="val">quantity measured in Gram</param>
    /// <returns>quantity measured in Yoctogram</returns>
	public static Quantity<double, Yoctogram> ToYoctogram<T>(this Quantity<T, Gram> val) where T:IConvertible {
        return new Quantity<double, Yoctogram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yottagram to Zettagram
    /// </summary>
    /// <param name="val">quantity measured in Yottagram</param>
    /// <returns>quantity measured in Zettagram</returns>
	public static Quantity<double, Zettagram> ToZettagram<T>(this Quantity<T, Yottagram> val) where T:IConvertible {
        return new Quantity<double, Zettagram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottagram to Exagram
    /// </summary>
    /// <param name="val">quantity measured in Yottagram</param>
    /// <returns>quantity measured in Exagram</returns>
	public static Quantity<double, Exagram> ToExagram<T>(this Quantity<T, Yottagram> val) where T:IConvertible {
        return new Quantity<double, Exagram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottagram to Petagram
    /// </summary>
    /// <param name="val">quantity measured in Yottagram</param>
    /// <returns>quantity measured in Petagram</returns>
	public static Quantity<double, Petagram> ToPetagram<T>(this Quantity<T, Yottagram> val) where T:IConvertible {
        return new Quantity<double, Petagram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottagram to Teragram
    /// </summary>
    /// <param name="val">quantity measured in Yottagram</param>
    /// <returns>quantity measured in Teragram</returns>
	public static Quantity<double, Teragram> ToTeragram<T>(this Quantity<T, Yottagram> val) where T:IConvertible {
        return new Quantity<double, Teragram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottagram to Gigagram
    /// </summary>
    /// <param name="val">quantity measured in Yottagram</param>
    /// <returns>quantity measured in Gigagram</returns>
	public static Quantity<double, Gigagram> ToGigagram<T>(this Quantity<T, Yottagram> val) where T:IConvertible {
        return new Quantity<double, Gigagram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottagram to Megagram
    /// </summary>
    /// <param name="val">quantity measured in Yottagram</param>
    /// <returns>quantity measured in Megagram</returns>
	public static Quantity<double, Megagram> ToMegagram<T>(this Quantity<T, Yottagram> val) where T:IConvertible {
        return new Quantity<double, Megagram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottagram to Kilogram
    /// </summary>
    /// <param name="val">quantity measured in Yottagram</param>
    /// <returns>quantity measured in Kilogram</returns>
	public static Quantity<double, Kilogram> ToKilogram<T>(this Quantity<T, Yottagram> val) where T:IConvertible {
        return new Quantity<double, Kilogram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottagram to Hectogram
    /// </summary>
    /// <param name="val">quantity measured in Yottagram</param>
    /// <returns>quantity measured in Hectogram</returns>
	public static Quantity<double, Hectogram> ToHectogram<T>(this Quantity<T, Yottagram> val) where T:IConvertible {
        return new Quantity<double, Hectogram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottagram to Dekagram
    /// </summary>
    /// <param name="val">quantity measured in Yottagram</param>
    /// <returns>quantity measured in Dekagram</returns>
	public static Quantity<double, Dekagram> ToDekagram<T>(this Quantity<T, Yottagram> val) where T:IConvertible {
        return new Quantity<double, Dekagram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottagram to Decigram
    /// </summary>
    /// <param name="val">quantity measured in Yottagram</param>
    /// <returns>quantity measured in Decigram</returns>
	public static Quantity<double, Decigram> ToDecigram<T>(this Quantity<T, Yottagram> val) where T:IConvertible {
        return new Quantity<double, Decigram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottagram to Centigram
    /// </summary>
    /// <param name="val">quantity measured in Yottagram</param>
    /// <returns>quantity measured in Centigram</returns>
	public static Quantity<double, Centigram> ToCentigram<T>(this Quantity<T, Yottagram> val) where T:IConvertible {
        return new Quantity<double, Centigram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottagram to Milligram
    /// </summary>
    /// <param name="val">quantity measured in Yottagram</param>
    /// <returns>quantity measured in Milligram</returns>
	public static Quantity<double, Milligram> ToMilligram<T>(this Quantity<T, Yottagram> val) where T:IConvertible {
        return new Quantity<double, Milligram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottagram to Microgram
    /// </summary>
    /// <param name="val">quantity measured in Yottagram</param>
    /// <returns>quantity measured in Microgram</returns>
	public static Quantity<double, Microgram> ToMicrogram<T>(this Quantity<T, Yottagram> val) where T:IConvertible {
        return new Quantity<double, Microgram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottagram to Nanogram
    /// </summary>
    /// <param name="val">quantity measured in Yottagram</param>
    /// <returns>quantity measured in Nanogram</returns>
	public static Quantity<double, Nanogram> ToNanogram<T>(this Quantity<T, Yottagram> val) where T:IConvertible {
        return new Quantity<double, Nanogram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottagram to Picogram
    /// </summary>
    /// <param name="val">quantity measured in Yottagram</param>
    /// <returns>quantity measured in Picogram</returns>
	public static Quantity<double, Picogram> ToPicogram<T>(this Quantity<T, Yottagram> val) where T:IConvertible {
        return new Quantity<double, Picogram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottagram to Femtogram
    /// </summary>
    /// <param name="val">quantity measured in Yottagram</param>
    /// <returns>quantity measured in Femtogram</returns>
	public static Quantity<double, Femtogram> ToFemtogram<T>(this Quantity<T, Yottagram> val) where T:IConvertible {
        return new Quantity<double, Femtogram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottagram to Attogram
    /// </summary>
    /// <param name="val">quantity measured in Yottagram</param>
    /// <returns>quantity measured in Attogram</returns>
	public static Quantity<double, Attogram> ToAttogram<T>(this Quantity<T, Yottagram> val) where T:IConvertible {
        return new Quantity<double, Attogram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottagram to Zeptogram
    /// </summary>
    /// <param name="val">quantity measured in Yottagram</param>
    /// <returns>quantity measured in Zeptogram</returns>
	public static Quantity<double, Zeptogram> ToZeptogram<T>(this Quantity<T, Yottagram> val) where T:IConvertible {
        return new Quantity<double, Zeptogram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottagram to Yoctogram
    /// </summary>
    /// <param name="val">quantity measured in Yottagram</param>
    /// <returns>quantity measured in Yoctogram</returns>
	public static Quantity<double, Yoctogram> ToYoctogram<T>(this Quantity<T, Yottagram> val) where T:IConvertible {
        return new Quantity<double, Yoctogram>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Zettagram to Yottagram
    /// </summary>
    /// <param name="val">quantity measured in Zettagram</param>
    /// <returns>quantity measured in Yottagram</returns>
	public static Quantity<double, Yottagram> ToYottagram<T>(this Quantity<T, Zettagram> val) where T:IConvertible {
        return new Quantity<double, Yottagram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettagram to Exagram
    /// </summary>
    /// <param name="val">quantity measured in Zettagram</param>
    /// <returns>quantity measured in Exagram</returns>
	public static Quantity<double, Exagram> ToExagram<T>(this Quantity<T, Zettagram> val) where T:IConvertible {
        return new Quantity<double, Exagram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettagram to Petagram
    /// </summary>
    /// <param name="val">quantity measured in Zettagram</param>
    /// <returns>quantity measured in Petagram</returns>
	public static Quantity<double, Petagram> ToPetagram<T>(this Quantity<T, Zettagram> val) where T:IConvertible {
        return new Quantity<double, Petagram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettagram to Teragram
    /// </summary>
    /// <param name="val">quantity measured in Zettagram</param>
    /// <returns>quantity measured in Teragram</returns>
	public static Quantity<double, Teragram> ToTeragram<T>(this Quantity<T, Zettagram> val) where T:IConvertible {
        return new Quantity<double, Teragram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettagram to Gigagram
    /// </summary>
    /// <param name="val">quantity measured in Zettagram</param>
    /// <returns>quantity measured in Gigagram</returns>
	public static Quantity<double, Gigagram> ToGigagram<T>(this Quantity<T, Zettagram> val) where T:IConvertible {
        return new Quantity<double, Gigagram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettagram to Megagram
    /// </summary>
    /// <param name="val">quantity measured in Zettagram</param>
    /// <returns>quantity measured in Megagram</returns>
	public static Quantity<double, Megagram> ToMegagram<T>(this Quantity<T, Zettagram> val) where T:IConvertible {
        return new Quantity<double, Megagram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettagram to Kilogram
    /// </summary>
    /// <param name="val">quantity measured in Zettagram</param>
    /// <returns>quantity measured in Kilogram</returns>
	public static Quantity<double, Kilogram> ToKilogram<T>(this Quantity<T, Zettagram> val) where T:IConvertible {
        return new Quantity<double, Kilogram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettagram to Hectogram
    /// </summary>
    /// <param name="val">quantity measured in Zettagram</param>
    /// <returns>quantity measured in Hectogram</returns>
	public static Quantity<double, Hectogram> ToHectogram<T>(this Quantity<T, Zettagram> val) where T:IConvertible {
        return new Quantity<double, Hectogram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettagram to Dekagram
    /// </summary>
    /// <param name="val">quantity measured in Zettagram</param>
    /// <returns>quantity measured in Dekagram</returns>
	public static Quantity<double, Dekagram> ToDekagram<T>(this Quantity<T, Zettagram> val) where T:IConvertible {
        return new Quantity<double, Dekagram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettagram to Decigram
    /// </summary>
    /// <param name="val">quantity measured in Zettagram</param>
    /// <returns>quantity measured in Decigram</returns>
	public static Quantity<double, Decigram> ToDecigram<T>(this Quantity<T, Zettagram> val) where T:IConvertible {
        return new Quantity<double, Decigram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettagram to Centigram
    /// </summary>
    /// <param name="val">quantity measured in Zettagram</param>
    /// <returns>quantity measured in Centigram</returns>
	public static Quantity<double, Centigram> ToCentigram<T>(this Quantity<T, Zettagram> val) where T:IConvertible {
        return new Quantity<double, Centigram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettagram to Milligram
    /// </summary>
    /// <param name="val">quantity measured in Zettagram</param>
    /// <returns>quantity measured in Milligram</returns>
	public static Quantity<double, Milligram> ToMilligram<T>(this Quantity<T, Zettagram> val) where T:IConvertible {
        return new Quantity<double, Milligram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettagram to Microgram
    /// </summary>
    /// <param name="val">quantity measured in Zettagram</param>
    /// <returns>quantity measured in Microgram</returns>
	public static Quantity<double, Microgram> ToMicrogram<T>(this Quantity<T, Zettagram> val) where T:IConvertible {
        return new Quantity<double, Microgram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettagram to Nanogram
    /// </summary>
    /// <param name="val">quantity measured in Zettagram</param>
    /// <returns>quantity measured in Nanogram</returns>
	public static Quantity<double, Nanogram> ToNanogram<T>(this Quantity<T, Zettagram> val) where T:IConvertible {
        return new Quantity<double, Nanogram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettagram to Picogram
    /// </summary>
    /// <param name="val">quantity measured in Zettagram</param>
    /// <returns>quantity measured in Picogram</returns>
	public static Quantity<double, Picogram> ToPicogram<T>(this Quantity<T, Zettagram> val) where T:IConvertible {
        return new Quantity<double, Picogram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettagram to Femtogram
    /// </summary>
    /// <param name="val">quantity measured in Zettagram</param>
    /// <returns>quantity measured in Femtogram</returns>
	public static Quantity<double, Femtogram> ToFemtogram<T>(this Quantity<T, Zettagram> val) where T:IConvertible {
        return new Quantity<double, Femtogram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettagram to Attogram
    /// </summary>
    /// <param name="val">quantity measured in Zettagram</param>
    /// <returns>quantity measured in Attogram</returns>
	public static Quantity<double, Attogram> ToAttogram<T>(this Quantity<T, Zettagram> val) where T:IConvertible {
        return new Quantity<double, Attogram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettagram to Zeptogram
    /// </summary>
    /// <param name="val">quantity measured in Zettagram</param>
    /// <returns>quantity measured in Zeptogram</returns>
	public static Quantity<double, Zeptogram> ToZeptogram<T>(this Quantity<T, Zettagram> val) where T:IConvertible {
        return new Quantity<double, Zeptogram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettagram to Yoctogram
    /// </summary>
    /// <param name="val">quantity measured in Zettagram</param>
    /// <returns>quantity measured in Yoctogram</returns>
	public static Quantity<double, Yoctogram> ToYoctogram<T>(this Quantity<T, Zettagram> val) where T:IConvertible {
        return new Quantity<double, Yoctogram>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Exagram to Yottagram
    /// </summary>
    /// <param name="val">quantity measured in Exagram</param>
    /// <returns>quantity measured in Yottagram</returns>
	public static Quantity<double, Yottagram> ToYottagram<T>(this Quantity<T, Exagram> val) where T:IConvertible {
        return new Quantity<double, Yottagram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exagram to Zettagram
    /// </summary>
    /// <param name="val">quantity measured in Exagram</param>
    /// <returns>quantity measured in Zettagram</returns>
	public static Quantity<double, Zettagram> ToZettagram<T>(this Quantity<T, Exagram> val) where T:IConvertible {
        return new Quantity<double, Zettagram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exagram to Petagram
    /// </summary>
    /// <param name="val">quantity measured in Exagram</param>
    /// <returns>quantity measured in Petagram</returns>
	public static Quantity<double, Petagram> ToPetagram<T>(this Quantity<T, Exagram> val) where T:IConvertible {
        return new Quantity<double, Petagram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exagram to Teragram
    /// </summary>
    /// <param name="val">quantity measured in Exagram</param>
    /// <returns>quantity measured in Teragram</returns>
	public static Quantity<double, Teragram> ToTeragram<T>(this Quantity<T, Exagram> val) where T:IConvertible {
        return new Quantity<double, Teragram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exagram to Gigagram
    /// </summary>
    /// <param name="val">quantity measured in Exagram</param>
    /// <returns>quantity measured in Gigagram</returns>
	public static Quantity<double, Gigagram> ToGigagram<T>(this Quantity<T, Exagram> val) where T:IConvertible {
        return new Quantity<double, Gigagram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exagram to Megagram
    /// </summary>
    /// <param name="val">quantity measured in Exagram</param>
    /// <returns>quantity measured in Megagram</returns>
	public static Quantity<double, Megagram> ToMegagram<T>(this Quantity<T, Exagram> val) where T:IConvertible {
        return new Quantity<double, Megagram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exagram to Kilogram
    /// </summary>
    /// <param name="val">quantity measured in Exagram</param>
    /// <returns>quantity measured in Kilogram</returns>
	public static Quantity<double, Kilogram> ToKilogram<T>(this Quantity<T, Exagram> val) where T:IConvertible {
        return new Quantity<double, Kilogram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exagram to Hectogram
    /// </summary>
    /// <param name="val">quantity measured in Exagram</param>
    /// <returns>quantity measured in Hectogram</returns>
	public static Quantity<double, Hectogram> ToHectogram<T>(this Quantity<T, Exagram> val) where T:IConvertible {
        return new Quantity<double, Hectogram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exagram to Dekagram
    /// </summary>
    /// <param name="val">quantity measured in Exagram</param>
    /// <returns>quantity measured in Dekagram</returns>
	public static Quantity<double, Dekagram> ToDekagram<T>(this Quantity<T, Exagram> val) where T:IConvertible {
        return new Quantity<double, Dekagram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exagram to Decigram
    /// </summary>
    /// <param name="val">quantity measured in Exagram</param>
    /// <returns>quantity measured in Decigram</returns>
	public static Quantity<double, Decigram> ToDecigram<T>(this Quantity<T, Exagram> val) where T:IConvertible {
        return new Quantity<double, Decigram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exagram to Centigram
    /// </summary>
    /// <param name="val">quantity measured in Exagram</param>
    /// <returns>quantity measured in Centigram</returns>
	public static Quantity<double, Centigram> ToCentigram<T>(this Quantity<T, Exagram> val) where T:IConvertible {
        return new Quantity<double, Centigram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exagram to Milligram
    /// </summary>
    /// <param name="val">quantity measured in Exagram</param>
    /// <returns>quantity measured in Milligram</returns>
	public static Quantity<double, Milligram> ToMilligram<T>(this Quantity<T, Exagram> val) where T:IConvertible {
        return new Quantity<double, Milligram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exagram to Microgram
    /// </summary>
    /// <param name="val">quantity measured in Exagram</param>
    /// <returns>quantity measured in Microgram</returns>
	public static Quantity<double, Microgram> ToMicrogram<T>(this Quantity<T, Exagram> val) where T:IConvertible {
        return new Quantity<double, Microgram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exagram to Nanogram
    /// </summary>
    /// <param name="val">quantity measured in Exagram</param>
    /// <returns>quantity measured in Nanogram</returns>
	public static Quantity<double, Nanogram> ToNanogram<T>(this Quantity<T, Exagram> val) where T:IConvertible {
        return new Quantity<double, Nanogram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exagram to Picogram
    /// </summary>
    /// <param name="val">quantity measured in Exagram</param>
    /// <returns>quantity measured in Picogram</returns>
	public static Quantity<double, Picogram> ToPicogram<T>(this Quantity<T, Exagram> val) where T:IConvertible {
        return new Quantity<double, Picogram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exagram to Femtogram
    /// </summary>
    /// <param name="val">quantity measured in Exagram</param>
    /// <returns>quantity measured in Femtogram</returns>
	public static Quantity<double, Femtogram> ToFemtogram<T>(this Quantity<T, Exagram> val) where T:IConvertible {
        return new Quantity<double, Femtogram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exagram to Attogram
    /// </summary>
    /// <param name="val">quantity measured in Exagram</param>
    /// <returns>quantity measured in Attogram</returns>
	public static Quantity<double, Attogram> ToAttogram<T>(this Quantity<T, Exagram> val) where T:IConvertible {
        return new Quantity<double, Attogram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exagram to Zeptogram
    /// </summary>
    /// <param name="val">quantity measured in Exagram</param>
    /// <returns>quantity measured in Zeptogram</returns>
	public static Quantity<double, Zeptogram> ToZeptogram<T>(this Quantity<T, Exagram> val) where T:IConvertible {
        return new Quantity<double, Zeptogram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exagram to Yoctogram
    /// </summary>
    /// <param name="val">quantity measured in Exagram</param>
    /// <returns>quantity measured in Yoctogram</returns>
	public static Quantity<double, Yoctogram> ToYoctogram<T>(this Quantity<T, Exagram> val) where T:IConvertible {
        return new Quantity<double, Yoctogram>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Petagram to Yottagram
    /// </summary>
    /// <param name="val">quantity measured in Petagram</param>
    /// <returns>quantity measured in Yottagram</returns>
	public static Quantity<double, Yottagram> ToYottagram<T>(this Quantity<T, Petagram> val) where T:IConvertible {
        return new Quantity<double, Yottagram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petagram to Zettagram
    /// </summary>
    /// <param name="val">quantity measured in Petagram</param>
    /// <returns>quantity measured in Zettagram</returns>
	public static Quantity<double, Zettagram> ToZettagram<T>(this Quantity<T, Petagram> val) where T:IConvertible {
        return new Quantity<double, Zettagram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petagram to Exagram
    /// </summary>
    /// <param name="val">quantity measured in Petagram</param>
    /// <returns>quantity measured in Exagram</returns>
	public static Quantity<double, Exagram> ToExagram<T>(this Quantity<T, Petagram> val) where T:IConvertible {
        return new Quantity<double, Exagram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petagram to Teragram
    /// </summary>
    /// <param name="val">quantity measured in Petagram</param>
    /// <returns>quantity measured in Teragram</returns>
	public static Quantity<double, Teragram> ToTeragram<T>(this Quantity<T, Petagram> val) where T:IConvertible {
        return new Quantity<double, Teragram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petagram to Gigagram
    /// </summary>
    /// <param name="val">quantity measured in Petagram</param>
    /// <returns>quantity measured in Gigagram</returns>
	public static Quantity<double, Gigagram> ToGigagram<T>(this Quantity<T, Petagram> val) where T:IConvertible {
        return new Quantity<double, Gigagram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petagram to Megagram
    /// </summary>
    /// <param name="val">quantity measured in Petagram</param>
    /// <returns>quantity measured in Megagram</returns>
	public static Quantity<double, Megagram> ToMegagram<T>(this Quantity<T, Petagram> val) where T:IConvertible {
        return new Quantity<double, Megagram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petagram to Kilogram
    /// </summary>
    /// <param name="val">quantity measured in Petagram</param>
    /// <returns>quantity measured in Kilogram</returns>
	public static Quantity<double, Kilogram> ToKilogram<T>(this Quantity<T, Petagram> val) where T:IConvertible {
        return new Quantity<double, Kilogram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petagram to Hectogram
    /// </summary>
    /// <param name="val">quantity measured in Petagram</param>
    /// <returns>quantity measured in Hectogram</returns>
	public static Quantity<double, Hectogram> ToHectogram<T>(this Quantity<T, Petagram> val) where T:IConvertible {
        return new Quantity<double, Hectogram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petagram to Dekagram
    /// </summary>
    /// <param name="val">quantity measured in Petagram</param>
    /// <returns>quantity measured in Dekagram</returns>
	public static Quantity<double, Dekagram> ToDekagram<T>(this Quantity<T, Petagram> val) where T:IConvertible {
        return new Quantity<double, Dekagram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petagram to Decigram
    /// </summary>
    /// <param name="val">quantity measured in Petagram</param>
    /// <returns>quantity measured in Decigram</returns>
	public static Quantity<double, Decigram> ToDecigram<T>(this Quantity<T, Petagram> val) where T:IConvertible {
        return new Quantity<double, Decigram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petagram to Centigram
    /// </summary>
    /// <param name="val">quantity measured in Petagram</param>
    /// <returns>quantity measured in Centigram</returns>
	public static Quantity<double, Centigram> ToCentigram<T>(this Quantity<T, Petagram> val) where T:IConvertible {
        return new Quantity<double, Centigram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petagram to Milligram
    /// </summary>
    /// <param name="val">quantity measured in Petagram</param>
    /// <returns>quantity measured in Milligram</returns>
	public static Quantity<double, Milligram> ToMilligram<T>(this Quantity<T, Petagram> val) where T:IConvertible {
        return new Quantity<double, Milligram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petagram to Microgram
    /// </summary>
    /// <param name="val">quantity measured in Petagram</param>
    /// <returns>quantity measured in Microgram</returns>
	public static Quantity<double, Microgram> ToMicrogram<T>(this Quantity<T, Petagram> val) where T:IConvertible {
        return new Quantity<double, Microgram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petagram to Nanogram
    /// </summary>
    /// <param name="val">quantity measured in Petagram</param>
    /// <returns>quantity measured in Nanogram</returns>
	public static Quantity<double, Nanogram> ToNanogram<T>(this Quantity<T, Petagram> val) where T:IConvertible {
        return new Quantity<double, Nanogram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petagram to Picogram
    /// </summary>
    /// <param name="val">quantity measured in Petagram</param>
    /// <returns>quantity measured in Picogram</returns>
	public static Quantity<double, Picogram> ToPicogram<T>(this Quantity<T, Petagram> val) where T:IConvertible {
        return new Quantity<double, Picogram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petagram to Femtogram
    /// </summary>
    /// <param name="val">quantity measured in Petagram</param>
    /// <returns>quantity measured in Femtogram</returns>
	public static Quantity<double, Femtogram> ToFemtogram<T>(this Quantity<T, Petagram> val) where T:IConvertible {
        return new Quantity<double, Femtogram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petagram to Attogram
    /// </summary>
    /// <param name="val">quantity measured in Petagram</param>
    /// <returns>quantity measured in Attogram</returns>
	public static Quantity<double, Attogram> ToAttogram<T>(this Quantity<T, Petagram> val) where T:IConvertible {
        return new Quantity<double, Attogram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petagram to Zeptogram
    /// </summary>
    /// <param name="val">quantity measured in Petagram</param>
    /// <returns>quantity measured in Zeptogram</returns>
	public static Quantity<double, Zeptogram> ToZeptogram<T>(this Quantity<T, Petagram> val) where T:IConvertible {
        return new Quantity<double, Zeptogram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petagram to Yoctogram
    /// </summary>
    /// <param name="val">quantity measured in Petagram</param>
    /// <returns>quantity measured in Yoctogram</returns>
	public static Quantity<double, Yoctogram> ToYoctogram<T>(this Quantity<T, Petagram> val) where T:IConvertible {
        return new Quantity<double, Yoctogram>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Teragram to Yottagram
    /// </summary>
    /// <param name="val">quantity measured in Teragram</param>
    /// <returns>quantity measured in Yottagram</returns>
	public static Quantity<double, Yottagram> ToYottagram<T>(this Quantity<T, Teragram> val) where T:IConvertible {
        return new Quantity<double, Yottagram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teragram to Zettagram
    /// </summary>
    /// <param name="val">quantity measured in Teragram</param>
    /// <returns>quantity measured in Zettagram</returns>
	public static Quantity<double, Zettagram> ToZettagram<T>(this Quantity<T, Teragram> val) where T:IConvertible {
        return new Quantity<double, Zettagram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teragram to Exagram
    /// </summary>
    /// <param name="val">quantity measured in Teragram</param>
    /// <returns>quantity measured in Exagram</returns>
	public static Quantity<double, Exagram> ToExagram<T>(this Quantity<T, Teragram> val) where T:IConvertible {
        return new Quantity<double, Exagram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teragram to Petagram
    /// </summary>
    /// <param name="val">quantity measured in Teragram</param>
    /// <returns>quantity measured in Petagram</returns>
	public static Quantity<double, Petagram> ToPetagram<T>(this Quantity<T, Teragram> val) where T:IConvertible {
        return new Quantity<double, Petagram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teragram to Gigagram
    /// </summary>
    /// <param name="val">quantity measured in Teragram</param>
    /// <returns>quantity measured in Gigagram</returns>
	public static Quantity<double, Gigagram> ToGigagram<T>(this Quantity<T, Teragram> val) where T:IConvertible {
        return new Quantity<double, Gigagram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teragram to Megagram
    /// </summary>
    /// <param name="val">quantity measured in Teragram</param>
    /// <returns>quantity measured in Megagram</returns>
	public static Quantity<double, Megagram> ToMegagram<T>(this Quantity<T, Teragram> val) where T:IConvertible {
        return new Quantity<double, Megagram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teragram to Kilogram
    /// </summary>
    /// <param name="val">quantity measured in Teragram</param>
    /// <returns>quantity measured in Kilogram</returns>
	public static Quantity<double, Kilogram> ToKilogram<T>(this Quantity<T, Teragram> val) where T:IConvertible {
        return new Quantity<double, Kilogram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teragram to Hectogram
    /// </summary>
    /// <param name="val">quantity measured in Teragram</param>
    /// <returns>quantity measured in Hectogram</returns>
	public static Quantity<double, Hectogram> ToHectogram<T>(this Quantity<T, Teragram> val) where T:IConvertible {
        return new Quantity<double, Hectogram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teragram to Dekagram
    /// </summary>
    /// <param name="val">quantity measured in Teragram</param>
    /// <returns>quantity measured in Dekagram</returns>
	public static Quantity<double, Dekagram> ToDekagram<T>(this Quantity<T, Teragram> val) where T:IConvertible {
        return new Quantity<double, Dekagram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teragram to Decigram
    /// </summary>
    /// <param name="val">quantity measured in Teragram</param>
    /// <returns>quantity measured in Decigram</returns>
	public static Quantity<double, Decigram> ToDecigram<T>(this Quantity<T, Teragram> val) where T:IConvertible {
        return new Quantity<double, Decigram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teragram to Centigram
    /// </summary>
    /// <param name="val">quantity measured in Teragram</param>
    /// <returns>quantity measured in Centigram</returns>
	public static Quantity<double, Centigram> ToCentigram<T>(this Quantity<T, Teragram> val) where T:IConvertible {
        return new Quantity<double, Centigram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teragram to Milligram
    /// </summary>
    /// <param name="val">quantity measured in Teragram</param>
    /// <returns>quantity measured in Milligram</returns>
	public static Quantity<double, Milligram> ToMilligram<T>(this Quantity<T, Teragram> val) where T:IConvertible {
        return new Quantity<double, Milligram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teragram to Microgram
    /// </summary>
    /// <param name="val">quantity measured in Teragram</param>
    /// <returns>quantity measured in Microgram</returns>
	public static Quantity<double, Microgram> ToMicrogram<T>(this Quantity<T, Teragram> val) where T:IConvertible {
        return new Quantity<double, Microgram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teragram to Nanogram
    /// </summary>
    /// <param name="val">quantity measured in Teragram</param>
    /// <returns>quantity measured in Nanogram</returns>
	public static Quantity<double, Nanogram> ToNanogram<T>(this Quantity<T, Teragram> val) where T:IConvertible {
        return new Quantity<double, Nanogram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teragram to Picogram
    /// </summary>
    /// <param name="val">quantity measured in Teragram</param>
    /// <returns>quantity measured in Picogram</returns>
	public static Quantity<double, Picogram> ToPicogram<T>(this Quantity<T, Teragram> val) where T:IConvertible {
        return new Quantity<double, Picogram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teragram to Femtogram
    /// </summary>
    /// <param name="val">quantity measured in Teragram</param>
    /// <returns>quantity measured in Femtogram</returns>
	public static Quantity<double, Femtogram> ToFemtogram<T>(this Quantity<T, Teragram> val) where T:IConvertible {
        return new Quantity<double, Femtogram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teragram to Attogram
    /// </summary>
    /// <param name="val">quantity measured in Teragram</param>
    /// <returns>quantity measured in Attogram</returns>
	public static Quantity<double, Attogram> ToAttogram<T>(this Quantity<T, Teragram> val) where T:IConvertible {
        return new Quantity<double, Attogram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teragram to Zeptogram
    /// </summary>
    /// <param name="val">quantity measured in Teragram</param>
    /// <returns>quantity measured in Zeptogram</returns>
	public static Quantity<double, Zeptogram> ToZeptogram<T>(this Quantity<T, Teragram> val) where T:IConvertible {
        return new Quantity<double, Zeptogram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teragram to Yoctogram
    /// </summary>
    /// <param name="val">quantity measured in Teragram</param>
    /// <returns>quantity measured in Yoctogram</returns>
	public static Quantity<double, Yoctogram> ToYoctogram<T>(this Quantity<T, Teragram> val) where T:IConvertible {
        return new Quantity<double, Yoctogram>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Gigagram to Yottagram
    /// </summary>
    /// <param name="val">quantity measured in Gigagram</param>
    /// <returns>quantity measured in Yottagram</returns>
	public static Quantity<double, Yottagram> ToYottagram<T>(this Quantity<T, Gigagram> val) where T:IConvertible {
        return new Quantity<double, Yottagram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigagram to Zettagram
    /// </summary>
    /// <param name="val">quantity measured in Gigagram</param>
    /// <returns>quantity measured in Zettagram</returns>
	public static Quantity<double, Zettagram> ToZettagram<T>(this Quantity<T, Gigagram> val) where T:IConvertible {
        return new Quantity<double, Zettagram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigagram to Exagram
    /// </summary>
    /// <param name="val">quantity measured in Gigagram</param>
    /// <returns>quantity measured in Exagram</returns>
	public static Quantity<double, Exagram> ToExagram<T>(this Quantity<T, Gigagram> val) where T:IConvertible {
        return new Quantity<double, Exagram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigagram to Petagram
    /// </summary>
    /// <param name="val">quantity measured in Gigagram</param>
    /// <returns>quantity measured in Petagram</returns>
	public static Quantity<double, Petagram> ToPetagram<T>(this Quantity<T, Gigagram> val) where T:IConvertible {
        return new Quantity<double, Petagram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigagram to Teragram
    /// </summary>
    /// <param name="val">quantity measured in Gigagram</param>
    /// <returns>quantity measured in Teragram</returns>
	public static Quantity<double, Teragram> ToTeragram<T>(this Quantity<T, Gigagram> val) where T:IConvertible {
        return new Quantity<double, Teragram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigagram to Megagram
    /// </summary>
    /// <param name="val">quantity measured in Gigagram</param>
    /// <returns>quantity measured in Megagram</returns>
	public static Quantity<double, Megagram> ToMegagram<T>(this Quantity<T, Gigagram> val) where T:IConvertible {
        return new Quantity<double, Megagram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigagram to Kilogram
    /// </summary>
    /// <param name="val">quantity measured in Gigagram</param>
    /// <returns>quantity measured in Kilogram</returns>
	public static Quantity<double, Kilogram> ToKilogram<T>(this Quantity<T, Gigagram> val) where T:IConvertible {
        return new Quantity<double, Kilogram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigagram to Hectogram
    /// </summary>
    /// <param name="val">quantity measured in Gigagram</param>
    /// <returns>quantity measured in Hectogram</returns>
	public static Quantity<double, Hectogram> ToHectogram<T>(this Quantity<T, Gigagram> val) where T:IConvertible {
        return new Quantity<double, Hectogram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigagram to Dekagram
    /// </summary>
    /// <param name="val">quantity measured in Gigagram</param>
    /// <returns>quantity measured in Dekagram</returns>
	public static Quantity<double, Dekagram> ToDekagram<T>(this Quantity<T, Gigagram> val) where T:IConvertible {
        return new Quantity<double, Dekagram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigagram to Decigram
    /// </summary>
    /// <param name="val">quantity measured in Gigagram</param>
    /// <returns>quantity measured in Decigram</returns>
	public static Quantity<double, Decigram> ToDecigram<T>(this Quantity<T, Gigagram> val) where T:IConvertible {
        return new Quantity<double, Decigram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigagram to Centigram
    /// </summary>
    /// <param name="val">quantity measured in Gigagram</param>
    /// <returns>quantity measured in Centigram</returns>
	public static Quantity<double, Centigram> ToCentigram<T>(this Quantity<T, Gigagram> val) where T:IConvertible {
        return new Quantity<double, Centigram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigagram to Milligram
    /// </summary>
    /// <param name="val">quantity measured in Gigagram</param>
    /// <returns>quantity measured in Milligram</returns>
	public static Quantity<double, Milligram> ToMilligram<T>(this Quantity<T, Gigagram> val) where T:IConvertible {
        return new Quantity<double, Milligram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigagram to Microgram
    /// </summary>
    /// <param name="val">quantity measured in Gigagram</param>
    /// <returns>quantity measured in Microgram</returns>
	public static Quantity<double, Microgram> ToMicrogram<T>(this Quantity<T, Gigagram> val) where T:IConvertible {
        return new Quantity<double, Microgram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigagram to Nanogram
    /// </summary>
    /// <param name="val">quantity measured in Gigagram</param>
    /// <returns>quantity measured in Nanogram</returns>
	public static Quantity<double, Nanogram> ToNanogram<T>(this Quantity<T, Gigagram> val) where T:IConvertible {
        return new Quantity<double, Nanogram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigagram to Picogram
    /// </summary>
    /// <param name="val">quantity measured in Gigagram</param>
    /// <returns>quantity measured in Picogram</returns>
	public static Quantity<double, Picogram> ToPicogram<T>(this Quantity<T, Gigagram> val) where T:IConvertible {
        return new Quantity<double, Picogram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigagram to Femtogram
    /// </summary>
    /// <param name="val">quantity measured in Gigagram</param>
    /// <returns>quantity measured in Femtogram</returns>
	public static Quantity<double, Femtogram> ToFemtogram<T>(this Quantity<T, Gigagram> val) where T:IConvertible {
        return new Quantity<double, Femtogram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigagram to Attogram
    /// </summary>
    /// <param name="val">quantity measured in Gigagram</param>
    /// <returns>quantity measured in Attogram</returns>
	public static Quantity<double, Attogram> ToAttogram<T>(this Quantity<T, Gigagram> val) where T:IConvertible {
        return new Quantity<double, Attogram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigagram to Zeptogram
    /// </summary>
    /// <param name="val">quantity measured in Gigagram</param>
    /// <returns>quantity measured in Zeptogram</returns>
	public static Quantity<double, Zeptogram> ToZeptogram<T>(this Quantity<T, Gigagram> val) where T:IConvertible {
        return new Quantity<double, Zeptogram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigagram to Yoctogram
    /// </summary>
    /// <param name="val">quantity measured in Gigagram</param>
    /// <returns>quantity measured in Yoctogram</returns>
	public static Quantity<double, Yoctogram> ToYoctogram<T>(this Quantity<T, Gigagram> val) where T:IConvertible {
        return new Quantity<double, Yoctogram>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Megagram to Yottagram
    /// </summary>
    /// <param name="val">quantity measured in Megagram</param>
    /// <returns>quantity measured in Yottagram</returns>
	public static Quantity<double, Yottagram> ToYottagram<T>(this Quantity<T, Megagram> val) where T:IConvertible {
        return new Quantity<double, Yottagram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megagram to Zettagram
    /// </summary>
    /// <param name="val">quantity measured in Megagram</param>
    /// <returns>quantity measured in Zettagram</returns>
	public static Quantity<double, Zettagram> ToZettagram<T>(this Quantity<T, Megagram> val) where T:IConvertible {
        return new Quantity<double, Zettagram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megagram to Exagram
    /// </summary>
    /// <param name="val">quantity measured in Megagram</param>
    /// <returns>quantity measured in Exagram</returns>
	public static Quantity<double, Exagram> ToExagram<T>(this Quantity<T, Megagram> val) where T:IConvertible {
        return new Quantity<double, Exagram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megagram to Petagram
    /// </summary>
    /// <param name="val">quantity measured in Megagram</param>
    /// <returns>quantity measured in Petagram</returns>
	public static Quantity<double, Petagram> ToPetagram<T>(this Quantity<T, Megagram> val) where T:IConvertible {
        return new Quantity<double, Petagram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megagram to Teragram
    /// </summary>
    /// <param name="val">quantity measured in Megagram</param>
    /// <returns>quantity measured in Teragram</returns>
	public static Quantity<double, Teragram> ToTeragram<T>(this Quantity<T, Megagram> val) where T:IConvertible {
        return new Quantity<double, Teragram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megagram to Gigagram
    /// </summary>
    /// <param name="val">quantity measured in Megagram</param>
    /// <returns>quantity measured in Gigagram</returns>
	public static Quantity<double, Gigagram> ToGigagram<T>(this Quantity<T, Megagram> val) where T:IConvertible {
        return new Quantity<double, Gigagram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megagram to Kilogram
    /// </summary>
    /// <param name="val">quantity measured in Megagram</param>
    /// <returns>quantity measured in Kilogram</returns>
	public static Quantity<double, Kilogram> ToKilogram<T>(this Quantity<T, Megagram> val) where T:IConvertible {
        return new Quantity<double, Kilogram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megagram to Hectogram
    /// </summary>
    /// <param name="val">quantity measured in Megagram</param>
    /// <returns>quantity measured in Hectogram</returns>
	public static Quantity<double, Hectogram> ToHectogram<T>(this Quantity<T, Megagram> val) where T:IConvertible {
        return new Quantity<double, Hectogram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megagram to Dekagram
    /// </summary>
    /// <param name="val">quantity measured in Megagram</param>
    /// <returns>quantity measured in Dekagram</returns>
	public static Quantity<double, Dekagram> ToDekagram<T>(this Quantity<T, Megagram> val) where T:IConvertible {
        return new Quantity<double, Dekagram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megagram to Decigram
    /// </summary>
    /// <param name="val">quantity measured in Megagram</param>
    /// <returns>quantity measured in Decigram</returns>
	public static Quantity<double, Decigram> ToDecigram<T>(this Quantity<T, Megagram> val) where T:IConvertible {
        return new Quantity<double, Decigram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megagram to Centigram
    /// </summary>
    /// <param name="val">quantity measured in Megagram</param>
    /// <returns>quantity measured in Centigram</returns>
	public static Quantity<double, Centigram> ToCentigram<T>(this Quantity<T, Megagram> val) where T:IConvertible {
        return new Quantity<double, Centigram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megagram to Milligram
    /// </summary>
    /// <param name="val">quantity measured in Megagram</param>
    /// <returns>quantity measured in Milligram</returns>
	public static Quantity<double, Milligram> ToMilligram<T>(this Quantity<T, Megagram> val) where T:IConvertible {
        return new Quantity<double, Milligram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megagram to Microgram
    /// </summary>
    /// <param name="val">quantity measured in Megagram</param>
    /// <returns>quantity measured in Microgram</returns>
	public static Quantity<double, Microgram> ToMicrogram<T>(this Quantity<T, Megagram> val) where T:IConvertible {
        return new Quantity<double, Microgram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megagram to Nanogram
    /// </summary>
    /// <param name="val">quantity measured in Megagram</param>
    /// <returns>quantity measured in Nanogram</returns>
	public static Quantity<double, Nanogram> ToNanogram<T>(this Quantity<T, Megagram> val) where T:IConvertible {
        return new Quantity<double, Nanogram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megagram to Picogram
    /// </summary>
    /// <param name="val">quantity measured in Megagram</param>
    /// <returns>quantity measured in Picogram</returns>
	public static Quantity<double, Picogram> ToPicogram<T>(this Quantity<T, Megagram> val) where T:IConvertible {
        return new Quantity<double, Picogram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megagram to Femtogram
    /// </summary>
    /// <param name="val">quantity measured in Megagram</param>
    /// <returns>quantity measured in Femtogram</returns>
	public static Quantity<double, Femtogram> ToFemtogram<T>(this Quantity<T, Megagram> val) where T:IConvertible {
        return new Quantity<double, Femtogram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megagram to Attogram
    /// </summary>
    /// <param name="val">quantity measured in Megagram</param>
    /// <returns>quantity measured in Attogram</returns>
	public static Quantity<double, Attogram> ToAttogram<T>(this Quantity<T, Megagram> val) where T:IConvertible {
        return new Quantity<double, Attogram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megagram to Zeptogram
    /// </summary>
    /// <param name="val">quantity measured in Megagram</param>
    /// <returns>quantity measured in Zeptogram</returns>
	public static Quantity<double, Zeptogram> ToZeptogram<T>(this Quantity<T, Megagram> val) where T:IConvertible {
        return new Quantity<double, Zeptogram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megagram to Yoctogram
    /// </summary>
    /// <param name="val">quantity measured in Megagram</param>
    /// <returns>quantity measured in Yoctogram</returns>
	public static Quantity<double, Yoctogram> ToYoctogram<T>(this Quantity<T, Megagram> val) where T:IConvertible {
        return new Quantity<double, Yoctogram>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Kilogram to Yottagram
    /// </summary>
    /// <param name="val">quantity measured in Kilogram</param>
    /// <returns>quantity measured in Yottagram</returns>
	public static Quantity<double, Yottagram> ToYottagram<T>(this Quantity<T, Kilogram> val) where T:IConvertible {
        return new Quantity<double, Yottagram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilogram to Zettagram
    /// </summary>
    /// <param name="val">quantity measured in Kilogram</param>
    /// <returns>quantity measured in Zettagram</returns>
	public static Quantity<double, Zettagram> ToZettagram<T>(this Quantity<T, Kilogram> val) where T:IConvertible {
        return new Quantity<double, Zettagram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilogram to Exagram
    /// </summary>
    /// <param name="val">quantity measured in Kilogram</param>
    /// <returns>quantity measured in Exagram</returns>
	public static Quantity<double, Exagram> ToExagram<T>(this Quantity<T, Kilogram> val) where T:IConvertible {
        return new Quantity<double, Exagram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilogram to Petagram
    /// </summary>
    /// <param name="val">quantity measured in Kilogram</param>
    /// <returns>quantity measured in Petagram</returns>
	public static Quantity<double, Petagram> ToPetagram<T>(this Quantity<T, Kilogram> val) where T:IConvertible {
        return new Quantity<double, Petagram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilogram to Teragram
    /// </summary>
    /// <param name="val">quantity measured in Kilogram</param>
    /// <returns>quantity measured in Teragram</returns>
	public static Quantity<double, Teragram> ToTeragram<T>(this Quantity<T, Kilogram> val) where T:IConvertible {
        return new Quantity<double, Teragram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilogram to Gigagram
    /// </summary>
    /// <param name="val">quantity measured in Kilogram</param>
    /// <returns>quantity measured in Gigagram</returns>
	public static Quantity<double, Gigagram> ToGigagram<T>(this Quantity<T, Kilogram> val) where T:IConvertible {
        return new Quantity<double, Gigagram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilogram to Megagram
    /// </summary>
    /// <param name="val">quantity measured in Kilogram</param>
    /// <returns>quantity measured in Megagram</returns>
	public static Quantity<double, Megagram> ToMegagram<T>(this Quantity<T, Kilogram> val) where T:IConvertible {
        return new Quantity<double, Megagram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilogram to Hectogram
    /// </summary>
    /// <param name="val">quantity measured in Kilogram</param>
    /// <returns>quantity measured in Hectogram</returns>
	public static Quantity<double, Hectogram> ToHectogram<T>(this Quantity<T, Kilogram> val) where T:IConvertible {
        return new Quantity<double, Hectogram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilogram to Dekagram
    /// </summary>
    /// <param name="val">quantity measured in Kilogram</param>
    /// <returns>quantity measured in Dekagram</returns>
	public static Quantity<double, Dekagram> ToDekagram<T>(this Quantity<T, Kilogram> val) where T:IConvertible {
        return new Quantity<double, Dekagram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilogram to Decigram
    /// </summary>
    /// <param name="val">quantity measured in Kilogram</param>
    /// <returns>quantity measured in Decigram</returns>
	public static Quantity<double, Decigram> ToDecigram<T>(this Quantity<T, Kilogram> val) where T:IConvertible {
        return new Quantity<double, Decigram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilogram to Centigram
    /// </summary>
    /// <param name="val">quantity measured in Kilogram</param>
    /// <returns>quantity measured in Centigram</returns>
	public static Quantity<double, Centigram> ToCentigram<T>(this Quantity<T, Kilogram> val) where T:IConvertible {
        return new Quantity<double, Centigram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilogram to Milligram
    /// </summary>
    /// <param name="val">quantity measured in Kilogram</param>
    /// <returns>quantity measured in Milligram</returns>
	public static Quantity<double, Milligram> ToMilligram<T>(this Quantity<T, Kilogram> val) where T:IConvertible {
        return new Quantity<double, Milligram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilogram to Microgram
    /// </summary>
    /// <param name="val">quantity measured in Kilogram</param>
    /// <returns>quantity measured in Microgram</returns>
	public static Quantity<double, Microgram> ToMicrogram<T>(this Quantity<T, Kilogram> val) where T:IConvertible {
        return new Quantity<double, Microgram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilogram to Nanogram
    /// </summary>
    /// <param name="val">quantity measured in Kilogram</param>
    /// <returns>quantity measured in Nanogram</returns>
	public static Quantity<double, Nanogram> ToNanogram<T>(this Quantity<T, Kilogram> val) where T:IConvertible {
        return new Quantity<double, Nanogram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilogram to Picogram
    /// </summary>
    /// <param name="val">quantity measured in Kilogram</param>
    /// <returns>quantity measured in Picogram</returns>
	public static Quantity<double, Picogram> ToPicogram<T>(this Quantity<T, Kilogram> val) where T:IConvertible {
        return new Quantity<double, Picogram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilogram to Femtogram
    /// </summary>
    /// <param name="val">quantity measured in Kilogram</param>
    /// <returns>quantity measured in Femtogram</returns>
	public static Quantity<double, Femtogram> ToFemtogram<T>(this Quantity<T, Kilogram> val) where T:IConvertible {
        return new Quantity<double, Femtogram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilogram to Attogram
    /// </summary>
    /// <param name="val">quantity measured in Kilogram</param>
    /// <returns>quantity measured in Attogram</returns>
	public static Quantity<double, Attogram> ToAttogram<T>(this Quantity<T, Kilogram> val) where T:IConvertible {
        return new Quantity<double, Attogram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilogram to Zeptogram
    /// </summary>
    /// <param name="val">quantity measured in Kilogram</param>
    /// <returns>quantity measured in Zeptogram</returns>
	public static Quantity<double, Zeptogram> ToZeptogram<T>(this Quantity<T, Kilogram> val) where T:IConvertible {
        return new Quantity<double, Zeptogram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilogram to Yoctogram
    /// </summary>
    /// <param name="val">quantity measured in Kilogram</param>
    /// <returns>quantity measured in Yoctogram</returns>
	public static Quantity<double, Yoctogram> ToYoctogram<T>(this Quantity<T, Kilogram> val) where T:IConvertible {
        return new Quantity<double, Yoctogram>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Hectogram to Yottagram
    /// </summary>
    /// <param name="val">quantity measured in Hectogram</param>
    /// <returns>quantity measured in Yottagram</returns>
	public static Quantity<double, Yottagram> ToYottagram<T>(this Quantity<T, Hectogram> val) where T:IConvertible {
        return new Quantity<double, Yottagram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectogram to Zettagram
    /// </summary>
    /// <param name="val">quantity measured in Hectogram</param>
    /// <returns>quantity measured in Zettagram</returns>
	public static Quantity<double, Zettagram> ToZettagram<T>(this Quantity<T, Hectogram> val) where T:IConvertible {
        return new Quantity<double, Zettagram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectogram to Exagram
    /// </summary>
    /// <param name="val">quantity measured in Hectogram</param>
    /// <returns>quantity measured in Exagram</returns>
	public static Quantity<double, Exagram> ToExagram<T>(this Quantity<T, Hectogram> val) where T:IConvertible {
        return new Quantity<double, Exagram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectogram to Petagram
    /// </summary>
    /// <param name="val">quantity measured in Hectogram</param>
    /// <returns>quantity measured in Petagram</returns>
	public static Quantity<double, Petagram> ToPetagram<T>(this Quantity<T, Hectogram> val) where T:IConvertible {
        return new Quantity<double, Petagram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectogram to Teragram
    /// </summary>
    /// <param name="val">quantity measured in Hectogram</param>
    /// <returns>quantity measured in Teragram</returns>
	public static Quantity<double, Teragram> ToTeragram<T>(this Quantity<T, Hectogram> val) where T:IConvertible {
        return new Quantity<double, Teragram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectogram to Gigagram
    /// </summary>
    /// <param name="val">quantity measured in Hectogram</param>
    /// <returns>quantity measured in Gigagram</returns>
	public static Quantity<double, Gigagram> ToGigagram<T>(this Quantity<T, Hectogram> val) where T:IConvertible {
        return new Quantity<double, Gigagram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectogram to Megagram
    /// </summary>
    /// <param name="val">quantity measured in Hectogram</param>
    /// <returns>quantity measured in Megagram</returns>
	public static Quantity<double, Megagram> ToMegagram<T>(this Quantity<T, Hectogram> val) where T:IConvertible {
        return new Quantity<double, Megagram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectogram to Kilogram
    /// </summary>
    /// <param name="val">quantity measured in Hectogram</param>
    /// <returns>quantity measured in Kilogram</returns>
	public static Quantity<double, Kilogram> ToKilogram<T>(this Quantity<T, Hectogram> val) where T:IConvertible {
        return new Quantity<double, Kilogram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectogram to Dekagram
    /// </summary>
    /// <param name="val">quantity measured in Hectogram</param>
    /// <returns>quantity measured in Dekagram</returns>
	public static Quantity<double, Dekagram> ToDekagram<T>(this Quantity<T, Hectogram> val) where T:IConvertible {
        return new Quantity<double, Dekagram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectogram to Decigram
    /// </summary>
    /// <param name="val">quantity measured in Hectogram</param>
    /// <returns>quantity measured in Decigram</returns>
	public static Quantity<double, Decigram> ToDecigram<T>(this Quantity<T, Hectogram> val) where T:IConvertible {
        return new Quantity<double, Decigram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectogram to Centigram
    /// </summary>
    /// <param name="val">quantity measured in Hectogram</param>
    /// <returns>quantity measured in Centigram</returns>
	public static Quantity<double, Centigram> ToCentigram<T>(this Quantity<T, Hectogram> val) where T:IConvertible {
        return new Quantity<double, Centigram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectogram to Milligram
    /// </summary>
    /// <param name="val">quantity measured in Hectogram</param>
    /// <returns>quantity measured in Milligram</returns>
	public static Quantity<double, Milligram> ToMilligram<T>(this Quantity<T, Hectogram> val) where T:IConvertible {
        return new Quantity<double, Milligram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectogram to Microgram
    /// </summary>
    /// <param name="val">quantity measured in Hectogram</param>
    /// <returns>quantity measured in Microgram</returns>
	public static Quantity<double, Microgram> ToMicrogram<T>(this Quantity<T, Hectogram> val) where T:IConvertible {
        return new Quantity<double, Microgram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectogram to Nanogram
    /// </summary>
    /// <param name="val">quantity measured in Hectogram</param>
    /// <returns>quantity measured in Nanogram</returns>
	public static Quantity<double, Nanogram> ToNanogram<T>(this Quantity<T, Hectogram> val) where T:IConvertible {
        return new Quantity<double, Nanogram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectogram to Picogram
    /// </summary>
    /// <param name="val">quantity measured in Hectogram</param>
    /// <returns>quantity measured in Picogram</returns>
	public static Quantity<double, Picogram> ToPicogram<T>(this Quantity<T, Hectogram> val) where T:IConvertible {
        return new Quantity<double, Picogram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectogram to Femtogram
    /// </summary>
    /// <param name="val">quantity measured in Hectogram</param>
    /// <returns>quantity measured in Femtogram</returns>
	public static Quantity<double, Femtogram> ToFemtogram<T>(this Quantity<T, Hectogram> val) where T:IConvertible {
        return new Quantity<double, Femtogram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectogram to Attogram
    /// </summary>
    /// <param name="val">quantity measured in Hectogram</param>
    /// <returns>quantity measured in Attogram</returns>
	public static Quantity<double, Attogram> ToAttogram<T>(this Quantity<T, Hectogram> val) where T:IConvertible {
        return new Quantity<double, Attogram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectogram to Zeptogram
    /// </summary>
    /// <param name="val">quantity measured in Hectogram</param>
    /// <returns>quantity measured in Zeptogram</returns>
	public static Quantity<double, Zeptogram> ToZeptogram<T>(this Quantity<T, Hectogram> val) where T:IConvertible {
        return new Quantity<double, Zeptogram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectogram to Yoctogram
    /// </summary>
    /// <param name="val">quantity measured in Hectogram</param>
    /// <returns>quantity measured in Yoctogram</returns>
	public static Quantity<double, Yoctogram> ToYoctogram<T>(this Quantity<T, Hectogram> val) where T:IConvertible {
        return new Quantity<double, Yoctogram>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Dekagram to Yottagram
    /// </summary>
    /// <param name="val">quantity measured in Dekagram</param>
    /// <returns>quantity measured in Yottagram</returns>
	public static Quantity<double, Yottagram> ToYottagram<T>(this Quantity<T, Dekagram> val) where T:IConvertible {
        return new Quantity<double, Yottagram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekagram to Zettagram
    /// </summary>
    /// <param name="val">quantity measured in Dekagram</param>
    /// <returns>quantity measured in Zettagram</returns>
	public static Quantity<double, Zettagram> ToZettagram<T>(this Quantity<T, Dekagram> val) where T:IConvertible {
        return new Quantity<double, Zettagram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekagram to Exagram
    /// </summary>
    /// <param name="val">quantity measured in Dekagram</param>
    /// <returns>quantity measured in Exagram</returns>
	public static Quantity<double, Exagram> ToExagram<T>(this Quantity<T, Dekagram> val) where T:IConvertible {
        return new Quantity<double, Exagram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekagram to Petagram
    /// </summary>
    /// <param name="val">quantity measured in Dekagram</param>
    /// <returns>quantity measured in Petagram</returns>
	public static Quantity<double, Petagram> ToPetagram<T>(this Quantity<T, Dekagram> val) where T:IConvertible {
        return new Quantity<double, Petagram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekagram to Teragram
    /// </summary>
    /// <param name="val">quantity measured in Dekagram</param>
    /// <returns>quantity measured in Teragram</returns>
	public static Quantity<double, Teragram> ToTeragram<T>(this Quantity<T, Dekagram> val) where T:IConvertible {
        return new Quantity<double, Teragram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekagram to Gigagram
    /// </summary>
    /// <param name="val">quantity measured in Dekagram</param>
    /// <returns>quantity measured in Gigagram</returns>
	public static Quantity<double, Gigagram> ToGigagram<T>(this Quantity<T, Dekagram> val) where T:IConvertible {
        return new Quantity<double, Gigagram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekagram to Megagram
    /// </summary>
    /// <param name="val">quantity measured in Dekagram</param>
    /// <returns>quantity measured in Megagram</returns>
	public static Quantity<double, Megagram> ToMegagram<T>(this Quantity<T, Dekagram> val) where T:IConvertible {
        return new Quantity<double, Megagram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekagram to Kilogram
    /// </summary>
    /// <param name="val">quantity measured in Dekagram</param>
    /// <returns>quantity measured in Kilogram</returns>
	public static Quantity<double, Kilogram> ToKilogram<T>(this Quantity<T, Dekagram> val) where T:IConvertible {
        return new Quantity<double, Kilogram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekagram to Hectogram
    /// </summary>
    /// <param name="val">quantity measured in Dekagram</param>
    /// <returns>quantity measured in Hectogram</returns>
	public static Quantity<double, Hectogram> ToHectogram<T>(this Quantity<T, Dekagram> val) where T:IConvertible {
        return new Quantity<double, Hectogram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekagram to Decigram
    /// </summary>
    /// <param name="val">quantity measured in Dekagram</param>
    /// <returns>quantity measured in Decigram</returns>
	public static Quantity<double, Decigram> ToDecigram<T>(this Quantity<T, Dekagram> val) where T:IConvertible {
        return new Quantity<double, Decigram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekagram to Centigram
    /// </summary>
    /// <param name="val">quantity measured in Dekagram</param>
    /// <returns>quantity measured in Centigram</returns>
	public static Quantity<double, Centigram> ToCentigram<T>(this Quantity<T, Dekagram> val) where T:IConvertible {
        return new Quantity<double, Centigram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekagram to Milligram
    /// </summary>
    /// <param name="val">quantity measured in Dekagram</param>
    /// <returns>quantity measured in Milligram</returns>
	public static Quantity<double, Milligram> ToMilligram<T>(this Quantity<T, Dekagram> val) where T:IConvertible {
        return new Quantity<double, Milligram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekagram to Microgram
    /// </summary>
    /// <param name="val">quantity measured in Dekagram</param>
    /// <returns>quantity measured in Microgram</returns>
	public static Quantity<double, Microgram> ToMicrogram<T>(this Quantity<T, Dekagram> val) where T:IConvertible {
        return new Quantity<double, Microgram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekagram to Nanogram
    /// </summary>
    /// <param name="val">quantity measured in Dekagram</param>
    /// <returns>quantity measured in Nanogram</returns>
	public static Quantity<double, Nanogram> ToNanogram<T>(this Quantity<T, Dekagram> val) where T:IConvertible {
        return new Quantity<double, Nanogram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekagram to Picogram
    /// </summary>
    /// <param name="val">quantity measured in Dekagram</param>
    /// <returns>quantity measured in Picogram</returns>
	public static Quantity<double, Picogram> ToPicogram<T>(this Quantity<T, Dekagram> val) where T:IConvertible {
        return new Quantity<double, Picogram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekagram to Femtogram
    /// </summary>
    /// <param name="val">quantity measured in Dekagram</param>
    /// <returns>quantity measured in Femtogram</returns>
	public static Quantity<double, Femtogram> ToFemtogram<T>(this Quantity<T, Dekagram> val) where T:IConvertible {
        return new Quantity<double, Femtogram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekagram to Attogram
    /// </summary>
    /// <param name="val">quantity measured in Dekagram</param>
    /// <returns>quantity measured in Attogram</returns>
	public static Quantity<double, Attogram> ToAttogram<T>(this Quantity<T, Dekagram> val) where T:IConvertible {
        return new Quantity<double, Attogram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekagram to Zeptogram
    /// </summary>
    /// <param name="val">quantity measured in Dekagram</param>
    /// <returns>quantity measured in Zeptogram</returns>
	public static Quantity<double, Zeptogram> ToZeptogram<T>(this Quantity<T, Dekagram> val) where T:IConvertible {
        return new Quantity<double, Zeptogram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekagram to Yoctogram
    /// </summary>
    /// <param name="val">quantity measured in Dekagram</param>
    /// <returns>quantity measured in Yoctogram</returns>
	public static Quantity<double, Yoctogram> ToYoctogram<T>(this Quantity<T, Dekagram> val) where T:IConvertible {
        return new Quantity<double, Yoctogram>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Decigram to Yottagram
    /// </summary>
    /// <param name="val">quantity measured in Decigram</param>
    /// <returns>quantity measured in Yottagram</returns>
	public static Quantity<double, Yottagram> ToYottagram<T>(this Quantity<T, Decigram> val) where T:IConvertible {
        return new Quantity<double, Yottagram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decigram to Zettagram
    /// </summary>
    /// <param name="val">quantity measured in Decigram</param>
    /// <returns>quantity measured in Zettagram</returns>
	public static Quantity<double, Zettagram> ToZettagram<T>(this Quantity<T, Decigram> val) where T:IConvertible {
        return new Quantity<double, Zettagram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decigram to Exagram
    /// </summary>
    /// <param name="val">quantity measured in Decigram</param>
    /// <returns>quantity measured in Exagram</returns>
	public static Quantity<double, Exagram> ToExagram<T>(this Quantity<T, Decigram> val) where T:IConvertible {
        return new Quantity<double, Exagram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decigram to Petagram
    /// </summary>
    /// <param name="val">quantity measured in Decigram</param>
    /// <returns>quantity measured in Petagram</returns>
	public static Quantity<double, Petagram> ToPetagram<T>(this Quantity<T, Decigram> val) where T:IConvertible {
        return new Quantity<double, Petagram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decigram to Teragram
    /// </summary>
    /// <param name="val">quantity measured in Decigram</param>
    /// <returns>quantity measured in Teragram</returns>
	public static Quantity<double, Teragram> ToTeragram<T>(this Quantity<T, Decigram> val) where T:IConvertible {
        return new Quantity<double, Teragram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decigram to Gigagram
    /// </summary>
    /// <param name="val">quantity measured in Decigram</param>
    /// <returns>quantity measured in Gigagram</returns>
	public static Quantity<double, Gigagram> ToGigagram<T>(this Quantity<T, Decigram> val) where T:IConvertible {
        return new Quantity<double, Gigagram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decigram to Megagram
    /// </summary>
    /// <param name="val">quantity measured in Decigram</param>
    /// <returns>quantity measured in Megagram</returns>
	public static Quantity<double, Megagram> ToMegagram<T>(this Quantity<T, Decigram> val) where T:IConvertible {
        return new Quantity<double, Megagram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decigram to Kilogram
    /// </summary>
    /// <param name="val">quantity measured in Decigram</param>
    /// <returns>quantity measured in Kilogram</returns>
	public static Quantity<double, Kilogram> ToKilogram<T>(this Quantity<T, Decigram> val) where T:IConvertible {
        return new Quantity<double, Kilogram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decigram to Hectogram
    /// </summary>
    /// <param name="val">quantity measured in Decigram</param>
    /// <returns>quantity measured in Hectogram</returns>
	public static Quantity<double, Hectogram> ToHectogram<T>(this Quantity<T, Decigram> val) where T:IConvertible {
        return new Quantity<double, Hectogram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decigram to Dekagram
    /// </summary>
    /// <param name="val">quantity measured in Decigram</param>
    /// <returns>quantity measured in Dekagram</returns>
	public static Quantity<double, Dekagram> ToDekagram<T>(this Quantity<T, Decigram> val) where T:IConvertible {
        return new Quantity<double, Dekagram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decigram to Centigram
    /// </summary>
    /// <param name="val">quantity measured in Decigram</param>
    /// <returns>quantity measured in Centigram</returns>
	public static Quantity<double, Centigram> ToCentigram<T>(this Quantity<T, Decigram> val) where T:IConvertible {
        return new Quantity<double, Centigram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decigram to Milligram
    /// </summary>
    /// <param name="val">quantity measured in Decigram</param>
    /// <returns>quantity measured in Milligram</returns>
	public static Quantity<double, Milligram> ToMilligram<T>(this Quantity<T, Decigram> val) where T:IConvertible {
        return new Quantity<double, Milligram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decigram to Microgram
    /// </summary>
    /// <param name="val">quantity measured in Decigram</param>
    /// <returns>quantity measured in Microgram</returns>
	public static Quantity<double, Microgram> ToMicrogram<T>(this Quantity<T, Decigram> val) where T:IConvertible {
        return new Quantity<double, Microgram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decigram to Nanogram
    /// </summary>
    /// <param name="val">quantity measured in Decigram</param>
    /// <returns>quantity measured in Nanogram</returns>
	public static Quantity<double, Nanogram> ToNanogram<T>(this Quantity<T, Decigram> val) where T:IConvertible {
        return new Quantity<double, Nanogram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decigram to Picogram
    /// </summary>
    /// <param name="val">quantity measured in Decigram</param>
    /// <returns>quantity measured in Picogram</returns>
	public static Quantity<double, Picogram> ToPicogram<T>(this Quantity<T, Decigram> val) where T:IConvertible {
        return new Quantity<double, Picogram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decigram to Femtogram
    /// </summary>
    /// <param name="val">quantity measured in Decigram</param>
    /// <returns>quantity measured in Femtogram</returns>
	public static Quantity<double, Femtogram> ToFemtogram<T>(this Quantity<T, Decigram> val) where T:IConvertible {
        return new Quantity<double, Femtogram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decigram to Attogram
    /// </summary>
    /// <param name="val">quantity measured in Decigram</param>
    /// <returns>quantity measured in Attogram</returns>
	public static Quantity<double, Attogram> ToAttogram<T>(this Quantity<T, Decigram> val) where T:IConvertible {
        return new Quantity<double, Attogram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decigram to Zeptogram
    /// </summary>
    /// <param name="val">quantity measured in Decigram</param>
    /// <returns>quantity measured in Zeptogram</returns>
	public static Quantity<double, Zeptogram> ToZeptogram<T>(this Quantity<T, Decigram> val) where T:IConvertible {
        return new Quantity<double, Zeptogram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decigram to Yoctogram
    /// </summary>
    /// <param name="val">quantity measured in Decigram</param>
    /// <returns>quantity measured in Yoctogram</returns>
	public static Quantity<double, Yoctogram> ToYoctogram<T>(this Quantity<T, Decigram> val) where T:IConvertible {
        return new Quantity<double, Yoctogram>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Centigram to Yottagram
    /// </summary>
    /// <param name="val">quantity measured in Centigram</param>
    /// <returns>quantity measured in Yottagram</returns>
	public static Quantity<double, Yottagram> ToYottagram<T>(this Quantity<T, Centigram> val) where T:IConvertible {
        return new Quantity<double, Yottagram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centigram to Zettagram
    /// </summary>
    /// <param name="val">quantity measured in Centigram</param>
    /// <returns>quantity measured in Zettagram</returns>
	public static Quantity<double, Zettagram> ToZettagram<T>(this Quantity<T, Centigram> val) where T:IConvertible {
        return new Quantity<double, Zettagram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centigram to Exagram
    /// </summary>
    /// <param name="val">quantity measured in Centigram</param>
    /// <returns>quantity measured in Exagram</returns>
	public static Quantity<double, Exagram> ToExagram<T>(this Quantity<T, Centigram> val) where T:IConvertible {
        return new Quantity<double, Exagram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centigram to Petagram
    /// </summary>
    /// <param name="val">quantity measured in Centigram</param>
    /// <returns>quantity measured in Petagram</returns>
	public static Quantity<double, Petagram> ToPetagram<T>(this Quantity<T, Centigram> val) where T:IConvertible {
        return new Quantity<double, Petagram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centigram to Teragram
    /// </summary>
    /// <param name="val">quantity measured in Centigram</param>
    /// <returns>quantity measured in Teragram</returns>
	public static Quantity<double, Teragram> ToTeragram<T>(this Quantity<T, Centigram> val) where T:IConvertible {
        return new Quantity<double, Teragram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centigram to Gigagram
    /// </summary>
    /// <param name="val">quantity measured in Centigram</param>
    /// <returns>quantity measured in Gigagram</returns>
	public static Quantity<double, Gigagram> ToGigagram<T>(this Quantity<T, Centigram> val) where T:IConvertible {
        return new Quantity<double, Gigagram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centigram to Megagram
    /// </summary>
    /// <param name="val">quantity measured in Centigram</param>
    /// <returns>quantity measured in Megagram</returns>
	public static Quantity<double, Megagram> ToMegagram<T>(this Quantity<T, Centigram> val) where T:IConvertible {
        return new Quantity<double, Megagram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centigram to Kilogram
    /// </summary>
    /// <param name="val">quantity measured in Centigram</param>
    /// <returns>quantity measured in Kilogram</returns>
	public static Quantity<double, Kilogram> ToKilogram<T>(this Quantity<T, Centigram> val) where T:IConvertible {
        return new Quantity<double, Kilogram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centigram to Hectogram
    /// </summary>
    /// <param name="val">quantity measured in Centigram</param>
    /// <returns>quantity measured in Hectogram</returns>
	public static Quantity<double, Hectogram> ToHectogram<T>(this Quantity<T, Centigram> val) where T:IConvertible {
        return new Quantity<double, Hectogram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centigram to Dekagram
    /// </summary>
    /// <param name="val">quantity measured in Centigram</param>
    /// <returns>quantity measured in Dekagram</returns>
	public static Quantity<double, Dekagram> ToDekagram<T>(this Quantity<T, Centigram> val) where T:IConvertible {
        return new Quantity<double, Dekagram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centigram to Decigram
    /// </summary>
    /// <param name="val">quantity measured in Centigram</param>
    /// <returns>quantity measured in Decigram</returns>
	public static Quantity<double, Decigram> ToDecigram<T>(this Quantity<T, Centigram> val) where T:IConvertible {
        return new Quantity<double, Decigram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centigram to Milligram
    /// </summary>
    /// <param name="val">quantity measured in Centigram</param>
    /// <returns>quantity measured in Milligram</returns>
	public static Quantity<double, Milligram> ToMilligram<T>(this Quantity<T, Centigram> val) where T:IConvertible {
        return new Quantity<double, Milligram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centigram to Microgram
    /// </summary>
    /// <param name="val">quantity measured in Centigram</param>
    /// <returns>quantity measured in Microgram</returns>
	public static Quantity<double, Microgram> ToMicrogram<T>(this Quantity<T, Centigram> val) where T:IConvertible {
        return new Quantity<double, Microgram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centigram to Nanogram
    /// </summary>
    /// <param name="val">quantity measured in Centigram</param>
    /// <returns>quantity measured in Nanogram</returns>
	public static Quantity<double, Nanogram> ToNanogram<T>(this Quantity<T, Centigram> val) where T:IConvertible {
        return new Quantity<double, Nanogram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centigram to Picogram
    /// </summary>
    /// <param name="val">quantity measured in Centigram</param>
    /// <returns>quantity measured in Picogram</returns>
	public static Quantity<double, Picogram> ToPicogram<T>(this Quantity<T, Centigram> val) where T:IConvertible {
        return new Quantity<double, Picogram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centigram to Femtogram
    /// </summary>
    /// <param name="val">quantity measured in Centigram</param>
    /// <returns>quantity measured in Femtogram</returns>
	public static Quantity<double, Femtogram> ToFemtogram<T>(this Quantity<T, Centigram> val) where T:IConvertible {
        return new Quantity<double, Femtogram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centigram to Attogram
    /// </summary>
    /// <param name="val">quantity measured in Centigram</param>
    /// <returns>quantity measured in Attogram</returns>
	public static Quantity<double, Attogram> ToAttogram<T>(this Quantity<T, Centigram> val) where T:IConvertible {
        return new Quantity<double, Attogram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centigram to Zeptogram
    /// </summary>
    /// <param name="val">quantity measured in Centigram</param>
    /// <returns>quantity measured in Zeptogram</returns>
	public static Quantity<double, Zeptogram> ToZeptogram<T>(this Quantity<T, Centigram> val) where T:IConvertible {
        return new Quantity<double, Zeptogram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centigram to Yoctogram
    /// </summary>
    /// <param name="val">quantity measured in Centigram</param>
    /// <returns>quantity measured in Yoctogram</returns>
	public static Quantity<double, Yoctogram> ToYoctogram<T>(this Quantity<T, Centigram> val) where T:IConvertible {
        return new Quantity<double, Yoctogram>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Milligram to Yottagram
    /// </summary>
    /// <param name="val">quantity measured in Milligram</param>
    /// <returns>quantity measured in Yottagram</returns>
	public static Quantity<double, Yottagram> ToYottagram<T>(this Quantity<T, Milligram> val) where T:IConvertible {
        return new Quantity<double, Yottagram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Milligram to Zettagram
    /// </summary>
    /// <param name="val">quantity measured in Milligram</param>
    /// <returns>quantity measured in Zettagram</returns>
	public static Quantity<double, Zettagram> ToZettagram<T>(this Quantity<T, Milligram> val) where T:IConvertible {
        return new Quantity<double, Zettagram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Milligram to Exagram
    /// </summary>
    /// <param name="val">quantity measured in Milligram</param>
    /// <returns>quantity measured in Exagram</returns>
	public static Quantity<double, Exagram> ToExagram<T>(this Quantity<T, Milligram> val) where T:IConvertible {
        return new Quantity<double, Exagram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Milligram to Petagram
    /// </summary>
    /// <param name="val">quantity measured in Milligram</param>
    /// <returns>quantity measured in Petagram</returns>
	public static Quantity<double, Petagram> ToPetagram<T>(this Quantity<T, Milligram> val) where T:IConvertible {
        return new Quantity<double, Petagram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Milligram to Teragram
    /// </summary>
    /// <param name="val">quantity measured in Milligram</param>
    /// <returns>quantity measured in Teragram</returns>
	public static Quantity<double, Teragram> ToTeragram<T>(this Quantity<T, Milligram> val) where T:IConvertible {
        return new Quantity<double, Teragram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Milligram to Gigagram
    /// </summary>
    /// <param name="val">quantity measured in Milligram</param>
    /// <returns>quantity measured in Gigagram</returns>
	public static Quantity<double, Gigagram> ToGigagram<T>(this Quantity<T, Milligram> val) where T:IConvertible {
        return new Quantity<double, Gigagram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Milligram to Megagram
    /// </summary>
    /// <param name="val">quantity measured in Milligram</param>
    /// <returns>quantity measured in Megagram</returns>
	public static Quantity<double, Megagram> ToMegagram<T>(this Quantity<T, Milligram> val) where T:IConvertible {
        return new Quantity<double, Megagram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Milligram to Kilogram
    /// </summary>
    /// <param name="val">quantity measured in Milligram</param>
    /// <returns>quantity measured in Kilogram</returns>
	public static Quantity<double, Kilogram> ToKilogram<T>(this Quantity<T, Milligram> val) where T:IConvertible {
        return new Quantity<double, Kilogram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Milligram to Hectogram
    /// </summary>
    /// <param name="val">quantity measured in Milligram</param>
    /// <returns>quantity measured in Hectogram</returns>
	public static Quantity<double, Hectogram> ToHectogram<T>(this Quantity<T, Milligram> val) where T:IConvertible {
        return new Quantity<double, Hectogram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Milligram to Dekagram
    /// </summary>
    /// <param name="val">quantity measured in Milligram</param>
    /// <returns>quantity measured in Dekagram</returns>
	public static Quantity<double, Dekagram> ToDekagram<T>(this Quantity<T, Milligram> val) where T:IConvertible {
        return new Quantity<double, Dekagram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Milligram to Decigram
    /// </summary>
    /// <param name="val">quantity measured in Milligram</param>
    /// <returns>quantity measured in Decigram</returns>
	public static Quantity<double, Decigram> ToDecigram<T>(this Quantity<T, Milligram> val) where T:IConvertible {
        return new Quantity<double, Decigram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Milligram to Centigram
    /// </summary>
    /// <param name="val">quantity measured in Milligram</param>
    /// <returns>quantity measured in Centigram</returns>
	public static Quantity<double, Centigram> ToCentigram<T>(this Quantity<T, Milligram> val) where T:IConvertible {
        return new Quantity<double, Centigram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Milligram to Microgram
    /// </summary>
    /// <param name="val">quantity measured in Milligram</param>
    /// <returns>quantity measured in Microgram</returns>
	public static Quantity<double, Microgram> ToMicrogram<T>(this Quantity<T, Milligram> val) where T:IConvertible {
        return new Quantity<double, Microgram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Milligram to Nanogram
    /// </summary>
    /// <param name="val">quantity measured in Milligram</param>
    /// <returns>quantity measured in Nanogram</returns>
	public static Quantity<double, Nanogram> ToNanogram<T>(this Quantity<T, Milligram> val) where T:IConvertible {
        return new Quantity<double, Nanogram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Milligram to Picogram
    /// </summary>
    /// <param name="val">quantity measured in Milligram</param>
    /// <returns>quantity measured in Picogram</returns>
	public static Quantity<double, Picogram> ToPicogram<T>(this Quantity<T, Milligram> val) where T:IConvertible {
        return new Quantity<double, Picogram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Milligram to Femtogram
    /// </summary>
    /// <param name="val">quantity measured in Milligram</param>
    /// <returns>quantity measured in Femtogram</returns>
	public static Quantity<double, Femtogram> ToFemtogram<T>(this Quantity<T, Milligram> val) where T:IConvertible {
        return new Quantity<double, Femtogram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Milligram to Attogram
    /// </summary>
    /// <param name="val">quantity measured in Milligram</param>
    /// <returns>quantity measured in Attogram</returns>
	public static Quantity<double, Attogram> ToAttogram<T>(this Quantity<T, Milligram> val) where T:IConvertible {
        return new Quantity<double, Attogram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Milligram to Zeptogram
    /// </summary>
    /// <param name="val">quantity measured in Milligram</param>
    /// <returns>quantity measured in Zeptogram</returns>
	public static Quantity<double, Zeptogram> ToZeptogram<T>(this Quantity<T, Milligram> val) where T:IConvertible {
        return new Quantity<double, Zeptogram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Milligram to Yoctogram
    /// </summary>
    /// <param name="val">quantity measured in Milligram</param>
    /// <returns>quantity measured in Yoctogram</returns>
	public static Quantity<double, Yoctogram> ToYoctogram<T>(this Quantity<T, Milligram> val) where T:IConvertible {
        return new Quantity<double, Yoctogram>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Microgram to Yottagram
    /// </summary>
    /// <param name="val">quantity measured in Microgram</param>
    /// <returns>quantity measured in Yottagram</returns>
	public static Quantity<double, Yottagram> ToYottagram<T>(this Quantity<T, Microgram> val) where T:IConvertible {
        return new Quantity<double, Yottagram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microgram to Zettagram
    /// </summary>
    /// <param name="val">quantity measured in Microgram</param>
    /// <returns>quantity measured in Zettagram</returns>
	public static Quantity<double, Zettagram> ToZettagram<T>(this Quantity<T, Microgram> val) where T:IConvertible {
        return new Quantity<double, Zettagram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microgram to Exagram
    /// </summary>
    /// <param name="val">quantity measured in Microgram</param>
    /// <returns>quantity measured in Exagram</returns>
	public static Quantity<double, Exagram> ToExagram<T>(this Quantity<T, Microgram> val) where T:IConvertible {
        return new Quantity<double, Exagram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microgram to Petagram
    /// </summary>
    /// <param name="val">quantity measured in Microgram</param>
    /// <returns>quantity measured in Petagram</returns>
	public static Quantity<double, Petagram> ToPetagram<T>(this Quantity<T, Microgram> val) where T:IConvertible {
        return new Quantity<double, Petagram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microgram to Teragram
    /// </summary>
    /// <param name="val">quantity measured in Microgram</param>
    /// <returns>quantity measured in Teragram</returns>
	public static Quantity<double, Teragram> ToTeragram<T>(this Quantity<T, Microgram> val) where T:IConvertible {
        return new Quantity<double, Teragram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microgram to Gigagram
    /// </summary>
    /// <param name="val">quantity measured in Microgram</param>
    /// <returns>quantity measured in Gigagram</returns>
	public static Quantity<double, Gigagram> ToGigagram<T>(this Quantity<T, Microgram> val) where T:IConvertible {
        return new Quantity<double, Gigagram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microgram to Megagram
    /// </summary>
    /// <param name="val">quantity measured in Microgram</param>
    /// <returns>quantity measured in Megagram</returns>
	public static Quantity<double, Megagram> ToMegagram<T>(this Quantity<T, Microgram> val) where T:IConvertible {
        return new Quantity<double, Megagram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microgram to Kilogram
    /// </summary>
    /// <param name="val">quantity measured in Microgram</param>
    /// <returns>quantity measured in Kilogram</returns>
	public static Quantity<double, Kilogram> ToKilogram<T>(this Quantity<T, Microgram> val) where T:IConvertible {
        return new Quantity<double, Kilogram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microgram to Hectogram
    /// </summary>
    /// <param name="val">quantity measured in Microgram</param>
    /// <returns>quantity measured in Hectogram</returns>
	public static Quantity<double, Hectogram> ToHectogram<T>(this Quantity<T, Microgram> val) where T:IConvertible {
        return new Quantity<double, Hectogram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microgram to Dekagram
    /// </summary>
    /// <param name="val">quantity measured in Microgram</param>
    /// <returns>quantity measured in Dekagram</returns>
	public static Quantity<double, Dekagram> ToDekagram<T>(this Quantity<T, Microgram> val) where T:IConvertible {
        return new Quantity<double, Dekagram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microgram to Decigram
    /// </summary>
    /// <param name="val">quantity measured in Microgram</param>
    /// <returns>quantity measured in Decigram</returns>
	public static Quantity<double, Decigram> ToDecigram<T>(this Quantity<T, Microgram> val) where T:IConvertible {
        return new Quantity<double, Decigram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microgram to Centigram
    /// </summary>
    /// <param name="val">quantity measured in Microgram</param>
    /// <returns>quantity measured in Centigram</returns>
	public static Quantity<double, Centigram> ToCentigram<T>(this Quantity<T, Microgram> val) where T:IConvertible {
        return new Quantity<double, Centigram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microgram to Milligram
    /// </summary>
    /// <param name="val">quantity measured in Microgram</param>
    /// <returns>quantity measured in Milligram</returns>
	public static Quantity<double, Milligram> ToMilligram<T>(this Quantity<T, Microgram> val) where T:IConvertible {
        return new Quantity<double, Milligram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microgram to Nanogram
    /// </summary>
    /// <param name="val">quantity measured in Microgram</param>
    /// <returns>quantity measured in Nanogram</returns>
	public static Quantity<double, Nanogram> ToNanogram<T>(this Quantity<T, Microgram> val) where T:IConvertible {
        return new Quantity<double, Nanogram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microgram to Picogram
    /// </summary>
    /// <param name="val">quantity measured in Microgram</param>
    /// <returns>quantity measured in Picogram</returns>
	public static Quantity<double, Picogram> ToPicogram<T>(this Quantity<T, Microgram> val) where T:IConvertible {
        return new Quantity<double, Picogram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microgram to Femtogram
    /// </summary>
    /// <param name="val">quantity measured in Microgram</param>
    /// <returns>quantity measured in Femtogram</returns>
	public static Quantity<double, Femtogram> ToFemtogram<T>(this Quantity<T, Microgram> val) where T:IConvertible {
        return new Quantity<double, Femtogram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microgram to Attogram
    /// </summary>
    /// <param name="val">quantity measured in Microgram</param>
    /// <returns>quantity measured in Attogram</returns>
	public static Quantity<double, Attogram> ToAttogram<T>(this Quantity<T, Microgram> val) where T:IConvertible {
        return new Quantity<double, Attogram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microgram to Zeptogram
    /// </summary>
    /// <param name="val">quantity measured in Microgram</param>
    /// <returns>quantity measured in Zeptogram</returns>
	public static Quantity<double, Zeptogram> ToZeptogram<T>(this Quantity<T, Microgram> val) where T:IConvertible {
        return new Quantity<double, Zeptogram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microgram to Yoctogram
    /// </summary>
    /// <param name="val">quantity measured in Microgram</param>
    /// <returns>quantity measured in Yoctogram</returns>
	public static Quantity<double, Yoctogram> ToYoctogram<T>(this Quantity<T, Microgram> val) where T:IConvertible {
        return new Quantity<double, Yoctogram>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Nanogram to Yottagram
    /// </summary>
    /// <param name="val">quantity measured in Nanogram</param>
    /// <returns>quantity measured in Yottagram</returns>
	public static Quantity<double, Yottagram> ToYottagram<T>(this Quantity<T, Nanogram> val) where T:IConvertible {
        return new Quantity<double, Yottagram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanogram to Zettagram
    /// </summary>
    /// <param name="val">quantity measured in Nanogram</param>
    /// <returns>quantity measured in Zettagram</returns>
	public static Quantity<double, Zettagram> ToZettagram<T>(this Quantity<T, Nanogram> val) where T:IConvertible {
        return new Quantity<double, Zettagram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanogram to Exagram
    /// </summary>
    /// <param name="val">quantity measured in Nanogram</param>
    /// <returns>quantity measured in Exagram</returns>
	public static Quantity<double, Exagram> ToExagram<T>(this Quantity<T, Nanogram> val) where T:IConvertible {
        return new Quantity<double, Exagram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanogram to Petagram
    /// </summary>
    /// <param name="val">quantity measured in Nanogram</param>
    /// <returns>quantity measured in Petagram</returns>
	public static Quantity<double, Petagram> ToPetagram<T>(this Quantity<T, Nanogram> val) where T:IConvertible {
        return new Quantity<double, Petagram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanogram to Teragram
    /// </summary>
    /// <param name="val">quantity measured in Nanogram</param>
    /// <returns>quantity measured in Teragram</returns>
	public static Quantity<double, Teragram> ToTeragram<T>(this Quantity<T, Nanogram> val) where T:IConvertible {
        return new Quantity<double, Teragram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanogram to Gigagram
    /// </summary>
    /// <param name="val">quantity measured in Nanogram</param>
    /// <returns>quantity measured in Gigagram</returns>
	public static Quantity<double, Gigagram> ToGigagram<T>(this Quantity<T, Nanogram> val) where T:IConvertible {
        return new Quantity<double, Gigagram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanogram to Megagram
    /// </summary>
    /// <param name="val">quantity measured in Nanogram</param>
    /// <returns>quantity measured in Megagram</returns>
	public static Quantity<double, Megagram> ToMegagram<T>(this Quantity<T, Nanogram> val) where T:IConvertible {
        return new Quantity<double, Megagram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanogram to Kilogram
    /// </summary>
    /// <param name="val">quantity measured in Nanogram</param>
    /// <returns>quantity measured in Kilogram</returns>
	public static Quantity<double, Kilogram> ToKilogram<T>(this Quantity<T, Nanogram> val) where T:IConvertible {
        return new Quantity<double, Kilogram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanogram to Hectogram
    /// </summary>
    /// <param name="val">quantity measured in Nanogram</param>
    /// <returns>quantity measured in Hectogram</returns>
	public static Quantity<double, Hectogram> ToHectogram<T>(this Quantity<T, Nanogram> val) where T:IConvertible {
        return new Quantity<double, Hectogram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanogram to Dekagram
    /// </summary>
    /// <param name="val">quantity measured in Nanogram</param>
    /// <returns>quantity measured in Dekagram</returns>
	public static Quantity<double, Dekagram> ToDekagram<T>(this Quantity<T, Nanogram> val) where T:IConvertible {
        return new Quantity<double, Dekagram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanogram to Decigram
    /// </summary>
    /// <param name="val">quantity measured in Nanogram</param>
    /// <returns>quantity measured in Decigram</returns>
	public static Quantity<double, Decigram> ToDecigram<T>(this Quantity<T, Nanogram> val) where T:IConvertible {
        return new Quantity<double, Decigram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanogram to Centigram
    /// </summary>
    /// <param name="val">quantity measured in Nanogram</param>
    /// <returns>quantity measured in Centigram</returns>
	public static Quantity<double, Centigram> ToCentigram<T>(this Quantity<T, Nanogram> val) where T:IConvertible {
        return new Quantity<double, Centigram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanogram to Milligram
    /// </summary>
    /// <param name="val">quantity measured in Nanogram</param>
    /// <returns>quantity measured in Milligram</returns>
	public static Quantity<double, Milligram> ToMilligram<T>(this Quantity<T, Nanogram> val) where T:IConvertible {
        return new Quantity<double, Milligram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanogram to Microgram
    /// </summary>
    /// <param name="val">quantity measured in Nanogram</param>
    /// <returns>quantity measured in Microgram</returns>
	public static Quantity<double, Microgram> ToMicrogram<T>(this Quantity<T, Nanogram> val) where T:IConvertible {
        return new Quantity<double, Microgram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanogram to Picogram
    /// </summary>
    /// <param name="val">quantity measured in Nanogram</param>
    /// <returns>quantity measured in Picogram</returns>
	public static Quantity<double, Picogram> ToPicogram<T>(this Quantity<T, Nanogram> val) where T:IConvertible {
        return new Quantity<double, Picogram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanogram to Femtogram
    /// </summary>
    /// <param name="val">quantity measured in Nanogram</param>
    /// <returns>quantity measured in Femtogram</returns>
	public static Quantity<double, Femtogram> ToFemtogram<T>(this Quantity<T, Nanogram> val) where T:IConvertible {
        return new Quantity<double, Femtogram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanogram to Attogram
    /// </summary>
    /// <param name="val">quantity measured in Nanogram</param>
    /// <returns>quantity measured in Attogram</returns>
	public static Quantity<double, Attogram> ToAttogram<T>(this Quantity<T, Nanogram> val) where T:IConvertible {
        return new Quantity<double, Attogram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanogram to Zeptogram
    /// </summary>
    /// <param name="val">quantity measured in Nanogram</param>
    /// <returns>quantity measured in Zeptogram</returns>
	public static Quantity<double, Zeptogram> ToZeptogram<T>(this Quantity<T, Nanogram> val) where T:IConvertible {
        return new Quantity<double, Zeptogram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanogram to Yoctogram
    /// </summary>
    /// <param name="val">quantity measured in Nanogram</param>
    /// <returns>quantity measured in Yoctogram</returns>
	public static Quantity<double, Yoctogram> ToYoctogram<T>(this Quantity<T, Nanogram> val) where T:IConvertible {
        return new Quantity<double, Yoctogram>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Picogram to Yottagram
    /// </summary>
    /// <param name="val">quantity measured in Picogram</param>
    /// <returns>quantity measured in Yottagram</returns>
	public static Quantity<double, Yottagram> ToYottagram<T>(this Quantity<T, Picogram> val) where T:IConvertible {
        return new Quantity<double, Yottagram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picogram to Zettagram
    /// </summary>
    /// <param name="val">quantity measured in Picogram</param>
    /// <returns>quantity measured in Zettagram</returns>
	public static Quantity<double, Zettagram> ToZettagram<T>(this Quantity<T, Picogram> val) where T:IConvertible {
        return new Quantity<double, Zettagram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picogram to Exagram
    /// </summary>
    /// <param name="val">quantity measured in Picogram</param>
    /// <returns>quantity measured in Exagram</returns>
	public static Quantity<double, Exagram> ToExagram<T>(this Quantity<T, Picogram> val) where T:IConvertible {
        return new Quantity<double, Exagram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picogram to Petagram
    /// </summary>
    /// <param name="val">quantity measured in Picogram</param>
    /// <returns>quantity measured in Petagram</returns>
	public static Quantity<double, Petagram> ToPetagram<T>(this Quantity<T, Picogram> val) where T:IConvertible {
        return new Quantity<double, Petagram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picogram to Teragram
    /// </summary>
    /// <param name="val">quantity measured in Picogram</param>
    /// <returns>quantity measured in Teragram</returns>
	public static Quantity<double, Teragram> ToTeragram<T>(this Quantity<T, Picogram> val) where T:IConvertible {
        return new Quantity<double, Teragram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picogram to Gigagram
    /// </summary>
    /// <param name="val">quantity measured in Picogram</param>
    /// <returns>quantity measured in Gigagram</returns>
	public static Quantity<double, Gigagram> ToGigagram<T>(this Quantity<T, Picogram> val) where T:IConvertible {
        return new Quantity<double, Gigagram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picogram to Megagram
    /// </summary>
    /// <param name="val">quantity measured in Picogram</param>
    /// <returns>quantity measured in Megagram</returns>
	public static Quantity<double, Megagram> ToMegagram<T>(this Quantity<T, Picogram> val) where T:IConvertible {
        return new Quantity<double, Megagram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picogram to Kilogram
    /// </summary>
    /// <param name="val">quantity measured in Picogram</param>
    /// <returns>quantity measured in Kilogram</returns>
	public static Quantity<double, Kilogram> ToKilogram<T>(this Quantity<T, Picogram> val) where T:IConvertible {
        return new Quantity<double, Kilogram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picogram to Hectogram
    /// </summary>
    /// <param name="val">quantity measured in Picogram</param>
    /// <returns>quantity measured in Hectogram</returns>
	public static Quantity<double, Hectogram> ToHectogram<T>(this Quantity<T, Picogram> val) where T:IConvertible {
        return new Quantity<double, Hectogram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picogram to Dekagram
    /// </summary>
    /// <param name="val">quantity measured in Picogram</param>
    /// <returns>quantity measured in Dekagram</returns>
	public static Quantity<double, Dekagram> ToDekagram<T>(this Quantity<T, Picogram> val) where T:IConvertible {
        return new Quantity<double, Dekagram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picogram to Decigram
    /// </summary>
    /// <param name="val">quantity measured in Picogram</param>
    /// <returns>quantity measured in Decigram</returns>
	public static Quantity<double, Decigram> ToDecigram<T>(this Quantity<T, Picogram> val) where T:IConvertible {
        return new Quantity<double, Decigram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picogram to Centigram
    /// </summary>
    /// <param name="val">quantity measured in Picogram</param>
    /// <returns>quantity measured in Centigram</returns>
	public static Quantity<double, Centigram> ToCentigram<T>(this Quantity<T, Picogram> val) where T:IConvertible {
        return new Quantity<double, Centigram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picogram to Milligram
    /// </summary>
    /// <param name="val">quantity measured in Picogram</param>
    /// <returns>quantity measured in Milligram</returns>
	public static Quantity<double, Milligram> ToMilligram<T>(this Quantity<T, Picogram> val) where T:IConvertible {
        return new Quantity<double, Milligram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picogram to Microgram
    /// </summary>
    /// <param name="val">quantity measured in Picogram</param>
    /// <returns>quantity measured in Microgram</returns>
	public static Quantity<double, Microgram> ToMicrogram<T>(this Quantity<T, Picogram> val) where T:IConvertible {
        return new Quantity<double, Microgram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picogram to Nanogram
    /// </summary>
    /// <param name="val">quantity measured in Picogram</param>
    /// <returns>quantity measured in Nanogram</returns>
	public static Quantity<double, Nanogram> ToNanogram<T>(this Quantity<T, Picogram> val) where T:IConvertible {
        return new Quantity<double, Nanogram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picogram to Femtogram
    /// </summary>
    /// <param name="val">quantity measured in Picogram</param>
    /// <returns>quantity measured in Femtogram</returns>
	public static Quantity<double, Femtogram> ToFemtogram<T>(this Quantity<T, Picogram> val) where T:IConvertible {
        return new Quantity<double, Femtogram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picogram to Attogram
    /// </summary>
    /// <param name="val">quantity measured in Picogram</param>
    /// <returns>quantity measured in Attogram</returns>
	public static Quantity<double, Attogram> ToAttogram<T>(this Quantity<T, Picogram> val) where T:IConvertible {
        return new Quantity<double, Attogram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picogram to Zeptogram
    /// </summary>
    /// <param name="val">quantity measured in Picogram</param>
    /// <returns>quantity measured in Zeptogram</returns>
	public static Quantity<double, Zeptogram> ToZeptogram<T>(this Quantity<T, Picogram> val) where T:IConvertible {
        return new Quantity<double, Zeptogram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picogram to Yoctogram
    /// </summary>
    /// <param name="val">quantity measured in Picogram</param>
    /// <returns>quantity measured in Yoctogram</returns>
	public static Quantity<double, Yoctogram> ToYoctogram<T>(this Quantity<T, Picogram> val) where T:IConvertible {
        return new Quantity<double, Yoctogram>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Femtogram to Yottagram
    /// </summary>
    /// <param name="val">quantity measured in Femtogram</param>
    /// <returns>quantity measured in Yottagram</returns>
	public static Quantity<double, Yottagram> ToYottagram<T>(this Quantity<T, Femtogram> val) where T:IConvertible {
        return new Quantity<double, Yottagram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtogram to Zettagram
    /// </summary>
    /// <param name="val">quantity measured in Femtogram</param>
    /// <returns>quantity measured in Zettagram</returns>
	public static Quantity<double, Zettagram> ToZettagram<T>(this Quantity<T, Femtogram> val) where T:IConvertible {
        return new Quantity<double, Zettagram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtogram to Exagram
    /// </summary>
    /// <param name="val">quantity measured in Femtogram</param>
    /// <returns>quantity measured in Exagram</returns>
	public static Quantity<double, Exagram> ToExagram<T>(this Quantity<T, Femtogram> val) where T:IConvertible {
        return new Quantity<double, Exagram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtogram to Petagram
    /// </summary>
    /// <param name="val">quantity measured in Femtogram</param>
    /// <returns>quantity measured in Petagram</returns>
	public static Quantity<double, Petagram> ToPetagram<T>(this Quantity<T, Femtogram> val) where T:IConvertible {
        return new Quantity<double, Petagram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtogram to Teragram
    /// </summary>
    /// <param name="val">quantity measured in Femtogram</param>
    /// <returns>quantity measured in Teragram</returns>
	public static Quantity<double, Teragram> ToTeragram<T>(this Quantity<T, Femtogram> val) where T:IConvertible {
        return new Quantity<double, Teragram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtogram to Gigagram
    /// </summary>
    /// <param name="val">quantity measured in Femtogram</param>
    /// <returns>quantity measured in Gigagram</returns>
	public static Quantity<double, Gigagram> ToGigagram<T>(this Quantity<T, Femtogram> val) where T:IConvertible {
        return new Quantity<double, Gigagram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtogram to Megagram
    /// </summary>
    /// <param name="val">quantity measured in Femtogram</param>
    /// <returns>quantity measured in Megagram</returns>
	public static Quantity<double, Megagram> ToMegagram<T>(this Quantity<T, Femtogram> val) where T:IConvertible {
        return new Quantity<double, Megagram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtogram to Kilogram
    /// </summary>
    /// <param name="val">quantity measured in Femtogram</param>
    /// <returns>quantity measured in Kilogram</returns>
	public static Quantity<double, Kilogram> ToKilogram<T>(this Quantity<T, Femtogram> val) where T:IConvertible {
        return new Quantity<double, Kilogram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtogram to Hectogram
    /// </summary>
    /// <param name="val">quantity measured in Femtogram</param>
    /// <returns>quantity measured in Hectogram</returns>
	public static Quantity<double, Hectogram> ToHectogram<T>(this Quantity<T, Femtogram> val) where T:IConvertible {
        return new Quantity<double, Hectogram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtogram to Dekagram
    /// </summary>
    /// <param name="val">quantity measured in Femtogram</param>
    /// <returns>quantity measured in Dekagram</returns>
	public static Quantity<double, Dekagram> ToDekagram<T>(this Quantity<T, Femtogram> val) where T:IConvertible {
        return new Quantity<double, Dekagram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtogram to Decigram
    /// </summary>
    /// <param name="val">quantity measured in Femtogram</param>
    /// <returns>quantity measured in Decigram</returns>
	public static Quantity<double, Decigram> ToDecigram<T>(this Quantity<T, Femtogram> val) where T:IConvertible {
        return new Quantity<double, Decigram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtogram to Centigram
    /// </summary>
    /// <param name="val">quantity measured in Femtogram</param>
    /// <returns>quantity measured in Centigram</returns>
	public static Quantity<double, Centigram> ToCentigram<T>(this Quantity<T, Femtogram> val) where T:IConvertible {
        return new Quantity<double, Centigram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtogram to Milligram
    /// </summary>
    /// <param name="val">quantity measured in Femtogram</param>
    /// <returns>quantity measured in Milligram</returns>
	public static Quantity<double, Milligram> ToMilligram<T>(this Quantity<T, Femtogram> val) where T:IConvertible {
        return new Quantity<double, Milligram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtogram to Microgram
    /// </summary>
    /// <param name="val">quantity measured in Femtogram</param>
    /// <returns>quantity measured in Microgram</returns>
	public static Quantity<double, Microgram> ToMicrogram<T>(this Quantity<T, Femtogram> val) where T:IConvertible {
        return new Quantity<double, Microgram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtogram to Nanogram
    /// </summary>
    /// <param name="val">quantity measured in Femtogram</param>
    /// <returns>quantity measured in Nanogram</returns>
	public static Quantity<double, Nanogram> ToNanogram<T>(this Quantity<T, Femtogram> val) where T:IConvertible {
        return new Quantity<double, Nanogram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtogram to Picogram
    /// </summary>
    /// <param name="val">quantity measured in Femtogram</param>
    /// <returns>quantity measured in Picogram</returns>
	public static Quantity<double, Picogram> ToPicogram<T>(this Quantity<T, Femtogram> val) where T:IConvertible {
        return new Quantity<double, Picogram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtogram to Attogram
    /// </summary>
    /// <param name="val">quantity measured in Femtogram</param>
    /// <returns>quantity measured in Attogram</returns>
	public static Quantity<double, Attogram> ToAttogram<T>(this Quantity<T, Femtogram> val) where T:IConvertible {
        return new Quantity<double, Attogram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtogram to Zeptogram
    /// </summary>
    /// <param name="val">quantity measured in Femtogram</param>
    /// <returns>quantity measured in Zeptogram</returns>
	public static Quantity<double, Zeptogram> ToZeptogram<T>(this Quantity<T, Femtogram> val) where T:IConvertible {
        return new Quantity<double, Zeptogram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtogram to Yoctogram
    /// </summary>
    /// <param name="val">quantity measured in Femtogram</param>
    /// <returns>quantity measured in Yoctogram</returns>
	public static Quantity<double, Yoctogram> ToYoctogram<T>(this Quantity<T, Femtogram> val) where T:IConvertible {
        return new Quantity<double, Yoctogram>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Attogram to Yottagram
    /// </summary>
    /// <param name="val">quantity measured in Attogram</param>
    /// <returns>quantity measured in Yottagram</returns>
	public static Quantity<double, Yottagram> ToYottagram<T>(this Quantity<T, Attogram> val) where T:IConvertible {
        return new Quantity<double, Yottagram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attogram to Zettagram
    /// </summary>
    /// <param name="val">quantity measured in Attogram</param>
    /// <returns>quantity measured in Zettagram</returns>
	public static Quantity<double, Zettagram> ToZettagram<T>(this Quantity<T, Attogram> val) where T:IConvertible {
        return new Quantity<double, Zettagram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attogram to Exagram
    /// </summary>
    /// <param name="val">quantity measured in Attogram</param>
    /// <returns>quantity measured in Exagram</returns>
	public static Quantity<double, Exagram> ToExagram<T>(this Quantity<T, Attogram> val) where T:IConvertible {
        return new Quantity<double, Exagram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attogram to Petagram
    /// </summary>
    /// <param name="val">quantity measured in Attogram</param>
    /// <returns>quantity measured in Petagram</returns>
	public static Quantity<double, Petagram> ToPetagram<T>(this Quantity<T, Attogram> val) where T:IConvertible {
        return new Quantity<double, Petagram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attogram to Teragram
    /// </summary>
    /// <param name="val">quantity measured in Attogram</param>
    /// <returns>quantity measured in Teragram</returns>
	public static Quantity<double, Teragram> ToTeragram<T>(this Quantity<T, Attogram> val) where T:IConvertible {
        return new Quantity<double, Teragram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attogram to Gigagram
    /// </summary>
    /// <param name="val">quantity measured in Attogram</param>
    /// <returns>quantity measured in Gigagram</returns>
	public static Quantity<double, Gigagram> ToGigagram<T>(this Quantity<T, Attogram> val) where T:IConvertible {
        return new Quantity<double, Gigagram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attogram to Megagram
    /// </summary>
    /// <param name="val">quantity measured in Attogram</param>
    /// <returns>quantity measured in Megagram</returns>
	public static Quantity<double, Megagram> ToMegagram<T>(this Quantity<T, Attogram> val) where T:IConvertible {
        return new Quantity<double, Megagram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attogram to Kilogram
    /// </summary>
    /// <param name="val">quantity measured in Attogram</param>
    /// <returns>quantity measured in Kilogram</returns>
	public static Quantity<double, Kilogram> ToKilogram<T>(this Quantity<T, Attogram> val) where T:IConvertible {
        return new Quantity<double, Kilogram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attogram to Hectogram
    /// </summary>
    /// <param name="val">quantity measured in Attogram</param>
    /// <returns>quantity measured in Hectogram</returns>
	public static Quantity<double, Hectogram> ToHectogram<T>(this Quantity<T, Attogram> val) where T:IConvertible {
        return new Quantity<double, Hectogram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attogram to Dekagram
    /// </summary>
    /// <param name="val">quantity measured in Attogram</param>
    /// <returns>quantity measured in Dekagram</returns>
	public static Quantity<double, Dekagram> ToDekagram<T>(this Quantity<T, Attogram> val) where T:IConvertible {
        return new Quantity<double, Dekagram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attogram to Decigram
    /// </summary>
    /// <param name="val">quantity measured in Attogram</param>
    /// <returns>quantity measured in Decigram</returns>
	public static Quantity<double, Decigram> ToDecigram<T>(this Quantity<T, Attogram> val) where T:IConvertible {
        return new Quantity<double, Decigram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attogram to Centigram
    /// </summary>
    /// <param name="val">quantity measured in Attogram</param>
    /// <returns>quantity measured in Centigram</returns>
	public static Quantity<double, Centigram> ToCentigram<T>(this Quantity<T, Attogram> val) where T:IConvertible {
        return new Quantity<double, Centigram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attogram to Milligram
    /// </summary>
    /// <param name="val">quantity measured in Attogram</param>
    /// <returns>quantity measured in Milligram</returns>
	public static Quantity<double, Milligram> ToMilligram<T>(this Quantity<T, Attogram> val) where T:IConvertible {
        return new Quantity<double, Milligram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attogram to Microgram
    /// </summary>
    /// <param name="val">quantity measured in Attogram</param>
    /// <returns>quantity measured in Microgram</returns>
	public static Quantity<double, Microgram> ToMicrogram<T>(this Quantity<T, Attogram> val) where T:IConvertible {
        return new Quantity<double, Microgram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attogram to Nanogram
    /// </summary>
    /// <param name="val">quantity measured in Attogram</param>
    /// <returns>quantity measured in Nanogram</returns>
	public static Quantity<double, Nanogram> ToNanogram<T>(this Quantity<T, Attogram> val) where T:IConvertible {
        return new Quantity<double, Nanogram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attogram to Picogram
    /// </summary>
    /// <param name="val">quantity measured in Attogram</param>
    /// <returns>quantity measured in Picogram</returns>
	public static Quantity<double, Picogram> ToPicogram<T>(this Quantity<T, Attogram> val) where T:IConvertible {
        return new Quantity<double, Picogram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attogram to Femtogram
    /// </summary>
    /// <param name="val">quantity measured in Attogram</param>
    /// <returns>quantity measured in Femtogram</returns>
	public static Quantity<double, Femtogram> ToFemtogram<T>(this Quantity<T, Attogram> val) where T:IConvertible {
        return new Quantity<double, Femtogram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attogram to Zeptogram
    /// </summary>
    /// <param name="val">quantity measured in Attogram</param>
    /// <returns>quantity measured in Zeptogram</returns>
	public static Quantity<double, Zeptogram> ToZeptogram<T>(this Quantity<T, Attogram> val) where T:IConvertible {
        return new Quantity<double, Zeptogram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attogram to Yoctogram
    /// </summary>
    /// <param name="val">quantity measured in Attogram</param>
    /// <returns>quantity measured in Yoctogram</returns>
	public static Quantity<double, Yoctogram> ToYoctogram<T>(this Quantity<T, Attogram> val) where T:IConvertible {
        return new Quantity<double, Yoctogram>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Zeptogram to Yottagram
    /// </summary>
    /// <param name="val">quantity measured in Zeptogram</param>
    /// <returns>quantity measured in Yottagram</returns>
	public static Quantity<double, Yottagram> ToYottagram<T>(this Quantity<T, Zeptogram> val) where T:IConvertible {
        return new Quantity<double, Yottagram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptogram to Zettagram
    /// </summary>
    /// <param name="val">quantity measured in Zeptogram</param>
    /// <returns>quantity measured in Zettagram</returns>
	public static Quantity<double, Zettagram> ToZettagram<T>(this Quantity<T, Zeptogram> val) where T:IConvertible {
        return new Quantity<double, Zettagram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptogram to Exagram
    /// </summary>
    /// <param name="val">quantity measured in Zeptogram</param>
    /// <returns>quantity measured in Exagram</returns>
	public static Quantity<double, Exagram> ToExagram<T>(this Quantity<T, Zeptogram> val) where T:IConvertible {
        return new Quantity<double, Exagram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptogram to Petagram
    /// </summary>
    /// <param name="val">quantity measured in Zeptogram</param>
    /// <returns>quantity measured in Petagram</returns>
	public static Quantity<double, Petagram> ToPetagram<T>(this Quantity<T, Zeptogram> val) where T:IConvertible {
        return new Quantity<double, Petagram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptogram to Teragram
    /// </summary>
    /// <param name="val">quantity measured in Zeptogram</param>
    /// <returns>quantity measured in Teragram</returns>
	public static Quantity<double, Teragram> ToTeragram<T>(this Quantity<T, Zeptogram> val) where T:IConvertible {
        return new Quantity<double, Teragram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptogram to Gigagram
    /// </summary>
    /// <param name="val">quantity measured in Zeptogram</param>
    /// <returns>quantity measured in Gigagram</returns>
	public static Quantity<double, Gigagram> ToGigagram<T>(this Quantity<T, Zeptogram> val) where T:IConvertible {
        return new Quantity<double, Gigagram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptogram to Megagram
    /// </summary>
    /// <param name="val">quantity measured in Zeptogram</param>
    /// <returns>quantity measured in Megagram</returns>
	public static Quantity<double, Megagram> ToMegagram<T>(this Quantity<T, Zeptogram> val) where T:IConvertible {
        return new Quantity<double, Megagram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptogram to Kilogram
    /// </summary>
    /// <param name="val">quantity measured in Zeptogram</param>
    /// <returns>quantity measured in Kilogram</returns>
	public static Quantity<double, Kilogram> ToKilogram<T>(this Quantity<T, Zeptogram> val) where T:IConvertible {
        return new Quantity<double, Kilogram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptogram to Hectogram
    /// </summary>
    /// <param name="val">quantity measured in Zeptogram</param>
    /// <returns>quantity measured in Hectogram</returns>
	public static Quantity<double, Hectogram> ToHectogram<T>(this Quantity<T, Zeptogram> val) where T:IConvertible {
        return new Quantity<double, Hectogram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptogram to Dekagram
    /// </summary>
    /// <param name="val">quantity measured in Zeptogram</param>
    /// <returns>quantity measured in Dekagram</returns>
	public static Quantity<double, Dekagram> ToDekagram<T>(this Quantity<T, Zeptogram> val) where T:IConvertible {
        return new Quantity<double, Dekagram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptogram to Decigram
    /// </summary>
    /// <param name="val">quantity measured in Zeptogram</param>
    /// <returns>quantity measured in Decigram</returns>
	public static Quantity<double, Decigram> ToDecigram<T>(this Quantity<T, Zeptogram> val) where T:IConvertible {
        return new Quantity<double, Decigram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptogram to Centigram
    /// </summary>
    /// <param name="val">quantity measured in Zeptogram</param>
    /// <returns>quantity measured in Centigram</returns>
	public static Quantity<double, Centigram> ToCentigram<T>(this Quantity<T, Zeptogram> val) where T:IConvertible {
        return new Quantity<double, Centigram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptogram to Milligram
    /// </summary>
    /// <param name="val">quantity measured in Zeptogram</param>
    /// <returns>quantity measured in Milligram</returns>
	public static Quantity<double, Milligram> ToMilligram<T>(this Quantity<T, Zeptogram> val) where T:IConvertible {
        return new Quantity<double, Milligram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptogram to Microgram
    /// </summary>
    /// <param name="val">quantity measured in Zeptogram</param>
    /// <returns>quantity measured in Microgram</returns>
	public static Quantity<double, Microgram> ToMicrogram<T>(this Quantity<T, Zeptogram> val) where T:IConvertible {
        return new Quantity<double, Microgram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptogram to Nanogram
    /// </summary>
    /// <param name="val">quantity measured in Zeptogram</param>
    /// <returns>quantity measured in Nanogram</returns>
	public static Quantity<double, Nanogram> ToNanogram<T>(this Quantity<T, Zeptogram> val) where T:IConvertible {
        return new Quantity<double, Nanogram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptogram to Picogram
    /// </summary>
    /// <param name="val">quantity measured in Zeptogram</param>
    /// <returns>quantity measured in Picogram</returns>
	public static Quantity<double, Picogram> ToPicogram<T>(this Quantity<T, Zeptogram> val) where T:IConvertible {
        return new Quantity<double, Picogram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptogram to Femtogram
    /// </summary>
    /// <param name="val">quantity measured in Zeptogram</param>
    /// <returns>quantity measured in Femtogram</returns>
	public static Quantity<double, Femtogram> ToFemtogram<T>(this Quantity<T, Zeptogram> val) where T:IConvertible {
        return new Quantity<double, Femtogram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptogram to Attogram
    /// </summary>
    /// <param name="val">quantity measured in Zeptogram</param>
    /// <returns>quantity measured in Attogram</returns>
	public static Quantity<double, Attogram> ToAttogram<T>(this Quantity<T, Zeptogram> val) where T:IConvertible {
        return new Quantity<double, Attogram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptogram to Yoctogram
    /// </summary>
    /// <param name="val">quantity measured in Zeptogram</param>
    /// <returns>quantity measured in Yoctogram</returns>
	public static Quantity<double, Yoctogram> ToYoctogram<T>(this Quantity<T, Zeptogram> val) where T:IConvertible {
        return new Quantity<double, Yoctogram>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Yoctogram to Yottagram
    /// </summary>
    /// <param name="val">quantity measured in Yoctogram</param>
    /// <returns>quantity measured in Yottagram</returns>
	public static Quantity<double, Yottagram> ToYottagram<T>(this Quantity<T, Yoctogram> val) where T:IConvertible {
        return new Quantity<double, Yottagram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctogram to Zettagram
    /// </summary>
    /// <param name="val">quantity measured in Yoctogram</param>
    /// <returns>quantity measured in Zettagram</returns>
	public static Quantity<double, Zettagram> ToZettagram<T>(this Quantity<T, Yoctogram> val) where T:IConvertible {
        return new Quantity<double, Zettagram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctogram to Exagram
    /// </summary>
    /// <param name="val">quantity measured in Yoctogram</param>
    /// <returns>quantity measured in Exagram</returns>
	public static Quantity<double, Exagram> ToExagram<T>(this Quantity<T, Yoctogram> val) where T:IConvertible {
        return new Quantity<double, Exagram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctogram to Petagram
    /// </summary>
    /// <param name="val">quantity measured in Yoctogram</param>
    /// <returns>quantity measured in Petagram</returns>
	public static Quantity<double, Petagram> ToPetagram<T>(this Quantity<T, Yoctogram> val) where T:IConvertible {
        return new Quantity<double, Petagram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctogram to Teragram
    /// </summary>
    /// <param name="val">quantity measured in Yoctogram</param>
    /// <returns>quantity measured in Teragram</returns>
	public static Quantity<double, Teragram> ToTeragram<T>(this Quantity<T, Yoctogram> val) where T:IConvertible {
        return new Quantity<double, Teragram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctogram to Gigagram
    /// </summary>
    /// <param name="val">quantity measured in Yoctogram</param>
    /// <returns>quantity measured in Gigagram</returns>
	public static Quantity<double, Gigagram> ToGigagram<T>(this Quantity<T, Yoctogram> val) where T:IConvertible {
        return new Quantity<double, Gigagram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctogram to Megagram
    /// </summary>
    /// <param name="val">quantity measured in Yoctogram</param>
    /// <returns>quantity measured in Megagram</returns>
	public static Quantity<double, Megagram> ToMegagram<T>(this Quantity<T, Yoctogram> val) where T:IConvertible {
        return new Quantity<double, Megagram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctogram to Kilogram
    /// </summary>
    /// <param name="val">quantity measured in Yoctogram</param>
    /// <returns>quantity measured in Kilogram</returns>
	public static Quantity<double, Kilogram> ToKilogram<T>(this Quantity<T, Yoctogram> val) where T:IConvertible {
        return new Quantity<double, Kilogram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctogram to Hectogram
    /// </summary>
    /// <param name="val">quantity measured in Yoctogram</param>
    /// <returns>quantity measured in Hectogram</returns>
	public static Quantity<double, Hectogram> ToHectogram<T>(this Quantity<T, Yoctogram> val) where T:IConvertible {
        return new Quantity<double, Hectogram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctogram to Dekagram
    /// </summary>
    /// <param name="val">quantity measured in Yoctogram</param>
    /// <returns>quantity measured in Dekagram</returns>
	public static Quantity<double, Dekagram> ToDekagram<T>(this Quantity<T, Yoctogram> val) where T:IConvertible {
        return new Quantity<double, Dekagram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctogram to Decigram
    /// </summary>
    /// <param name="val">quantity measured in Yoctogram</param>
    /// <returns>quantity measured in Decigram</returns>
	public static Quantity<double, Decigram> ToDecigram<T>(this Quantity<T, Yoctogram> val) where T:IConvertible {
        return new Quantity<double, Decigram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctogram to Centigram
    /// </summary>
    /// <param name="val">quantity measured in Yoctogram</param>
    /// <returns>quantity measured in Centigram</returns>
	public static Quantity<double, Centigram> ToCentigram<T>(this Quantity<T, Yoctogram> val) where T:IConvertible {
        return new Quantity<double, Centigram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctogram to Milligram
    /// </summary>
    /// <param name="val">quantity measured in Yoctogram</param>
    /// <returns>quantity measured in Milligram</returns>
	public static Quantity<double, Milligram> ToMilligram<T>(this Quantity<T, Yoctogram> val) where T:IConvertible {
        return new Quantity<double, Milligram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctogram to Microgram
    /// </summary>
    /// <param name="val">quantity measured in Yoctogram</param>
    /// <returns>quantity measured in Microgram</returns>
	public static Quantity<double, Microgram> ToMicrogram<T>(this Quantity<T, Yoctogram> val) where T:IConvertible {
        return new Quantity<double, Microgram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctogram to Nanogram
    /// </summary>
    /// <param name="val">quantity measured in Yoctogram</param>
    /// <returns>quantity measured in Nanogram</returns>
	public static Quantity<double, Nanogram> ToNanogram<T>(this Quantity<T, Yoctogram> val) where T:IConvertible {
        return new Quantity<double, Nanogram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctogram to Picogram
    /// </summary>
    /// <param name="val">quantity measured in Yoctogram</param>
    /// <returns>quantity measured in Picogram</returns>
	public static Quantity<double, Picogram> ToPicogram<T>(this Quantity<T, Yoctogram> val) where T:IConvertible {
        return new Quantity<double, Picogram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctogram to Femtogram
    /// </summary>
    /// <param name="val">quantity measured in Yoctogram</param>
    /// <returns>quantity measured in Femtogram</returns>
	public static Quantity<double, Femtogram> ToFemtogram<T>(this Quantity<T, Yoctogram> val) where T:IConvertible {
        return new Quantity<double, Femtogram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctogram to Attogram
    /// </summary>
    /// <param name="val">quantity measured in Yoctogram</param>
    /// <returns>quantity measured in Attogram</returns>
	public static Quantity<double, Attogram> ToAttogram<T>(this Quantity<T, Yoctogram> val) where T:IConvertible {
        return new Quantity<double, Attogram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctogram to Zeptogram
    /// </summary>
    /// <param name="val">quantity measured in Yoctogram</param>
    /// <returns>quantity measured in Zeptogram</returns>
	public static Quantity<double, Zeptogram> ToZeptogram<T>(this Quantity<T, Yoctogram> val) where T:IConvertible {
        return new Quantity<double, Zeptogram>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
}

}