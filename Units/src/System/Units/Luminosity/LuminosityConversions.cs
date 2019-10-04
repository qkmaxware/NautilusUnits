using System;

namespace System.Units.Luminosity {

public static class LuminosityConversions {
	/// <summary>
    /// Extension method to convert Candela to Yottacandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in Yottacandela</returns>
	public static Quantity<double, Yottacandela> ToYottacandela<T>(this Quantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, Yottacandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Candela to Zettacandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in Zettacandela</returns>
	public static Quantity<double, Zettacandela> ToZettacandela<T>(this Quantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, Zettacandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Candela to Exacandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in Exacandela</returns>
	public static Quantity<double, Exacandela> ToExacandela<T>(this Quantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, Exacandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Candela to Petacandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in Petacandela</returns>
	public static Quantity<double, Petacandela> ToPetacandela<T>(this Quantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, Petacandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Candela to Teracandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in Teracandela</returns>
	public static Quantity<double, Teracandela> ToTeracandela<T>(this Quantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, Teracandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Candela to Gigacandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in Gigacandela</returns>
	public static Quantity<double, Gigacandela> ToGigacandela<T>(this Quantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, Gigacandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Candela to Megacandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in Megacandela</returns>
	public static Quantity<double, Megacandela> ToMegacandela<T>(this Quantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, Megacandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Candela to Kilocandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in Kilocandela</returns>
	public static Quantity<double, Kilocandela> ToKilocandela<T>(this Quantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, Kilocandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Candela to Hectocandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in Hectocandela</returns>
	public static Quantity<double, Hectocandela> ToHectocandela<T>(this Quantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, Hectocandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Candela to Dekacandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in Dekacandela</returns>
	public static Quantity<double, Dekacandela> ToDekacandela<T>(this Quantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, Dekacandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Candela to Decicandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in Decicandela</returns>
	public static Quantity<double, Decicandela> ToDecicandela<T>(this Quantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, Decicandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Candela to Centicandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in Centicandela</returns>
	public static Quantity<double, Centicandela> ToCenticandela<T>(this Quantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, Centicandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Candela to Millicandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in Millicandela</returns>
	public static Quantity<double, Millicandela> ToMillicandela<T>(this Quantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, Millicandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Candela to Microcandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in Microcandela</returns>
	public static Quantity<double, Microcandela> ToMicrocandela<T>(this Quantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, Microcandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Candela to Nanocandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in Nanocandela</returns>
	public static Quantity<double, Nanocandela> ToNanocandela<T>(this Quantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, Nanocandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Candela to Picocandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in Picocandela</returns>
	public static Quantity<double, Picocandela> ToPicocandela<T>(this Quantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, Picocandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Candela to Femtocandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in Femtocandela</returns>
	public static Quantity<double, Femtocandela> ToFemtocandela<T>(this Quantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, Femtocandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Candela to Attocandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in Attocandela</returns>
	public static Quantity<double, Attocandela> ToAttocandela<T>(this Quantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, Attocandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Candela to Zeptocandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in Zeptocandela</returns>
	public static Quantity<double, Zeptocandela> ToZeptocandela<T>(this Quantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, Zeptocandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Candela to Yoctocandela
    /// </summary>
    /// <param name="val">quantity measured in Candela</param>
    /// <returns>quantity measured in Yoctocandela</returns>
	public static Quantity<double, Yoctocandela> ToYoctocandela<T>(this Quantity<T, Candela> val) where T:IConvertible {
        return new Quantity<double, Yoctocandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yottacandela to Zettacandela
    /// </summary>
    /// <param name="val">quantity measured in Yottacandela</param>
    /// <returns>quantity measured in Zettacandela</returns>
	public static Quantity<double, Zettacandela> ToZettacandela<T>(this Quantity<T, Yottacandela> val) where T:IConvertible {
        return new Quantity<double, Zettacandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottacandela to Exacandela
    /// </summary>
    /// <param name="val">quantity measured in Yottacandela</param>
    /// <returns>quantity measured in Exacandela</returns>
	public static Quantity<double, Exacandela> ToExacandela<T>(this Quantity<T, Yottacandela> val) where T:IConvertible {
        return new Quantity<double, Exacandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottacandela to Petacandela
    /// </summary>
    /// <param name="val">quantity measured in Yottacandela</param>
    /// <returns>quantity measured in Petacandela</returns>
	public static Quantity<double, Petacandela> ToPetacandela<T>(this Quantity<T, Yottacandela> val) where T:IConvertible {
        return new Quantity<double, Petacandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottacandela to Teracandela
    /// </summary>
    /// <param name="val">quantity measured in Yottacandela</param>
    /// <returns>quantity measured in Teracandela</returns>
	public static Quantity<double, Teracandela> ToTeracandela<T>(this Quantity<T, Yottacandela> val) where T:IConvertible {
        return new Quantity<double, Teracandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottacandela to Gigacandela
    /// </summary>
    /// <param name="val">quantity measured in Yottacandela</param>
    /// <returns>quantity measured in Gigacandela</returns>
	public static Quantity<double, Gigacandela> ToGigacandela<T>(this Quantity<T, Yottacandela> val) where T:IConvertible {
        return new Quantity<double, Gigacandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottacandela to Megacandela
    /// </summary>
    /// <param name="val">quantity measured in Yottacandela</param>
    /// <returns>quantity measured in Megacandela</returns>
	public static Quantity<double, Megacandela> ToMegacandela<T>(this Quantity<T, Yottacandela> val) where T:IConvertible {
        return new Quantity<double, Megacandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottacandela to Kilocandela
    /// </summary>
    /// <param name="val">quantity measured in Yottacandela</param>
    /// <returns>quantity measured in Kilocandela</returns>
	public static Quantity<double, Kilocandela> ToKilocandela<T>(this Quantity<T, Yottacandela> val) where T:IConvertible {
        return new Quantity<double, Kilocandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottacandela to Hectocandela
    /// </summary>
    /// <param name="val">quantity measured in Yottacandela</param>
    /// <returns>quantity measured in Hectocandela</returns>
	public static Quantity<double, Hectocandela> ToHectocandela<T>(this Quantity<T, Yottacandela> val) where T:IConvertible {
        return new Quantity<double, Hectocandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottacandela to Dekacandela
    /// </summary>
    /// <param name="val">quantity measured in Yottacandela</param>
    /// <returns>quantity measured in Dekacandela</returns>
	public static Quantity<double, Dekacandela> ToDekacandela<T>(this Quantity<T, Yottacandela> val) where T:IConvertible {
        return new Quantity<double, Dekacandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottacandela to Decicandela
    /// </summary>
    /// <param name="val">quantity measured in Yottacandela</param>
    /// <returns>quantity measured in Decicandela</returns>
	public static Quantity<double, Decicandela> ToDecicandela<T>(this Quantity<T, Yottacandela> val) where T:IConvertible {
        return new Quantity<double, Decicandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottacandela to Centicandela
    /// </summary>
    /// <param name="val">quantity measured in Yottacandela</param>
    /// <returns>quantity measured in Centicandela</returns>
	public static Quantity<double, Centicandela> ToCenticandela<T>(this Quantity<T, Yottacandela> val) where T:IConvertible {
        return new Quantity<double, Centicandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottacandela to Millicandela
    /// </summary>
    /// <param name="val">quantity measured in Yottacandela</param>
    /// <returns>quantity measured in Millicandela</returns>
	public static Quantity<double, Millicandela> ToMillicandela<T>(this Quantity<T, Yottacandela> val) where T:IConvertible {
        return new Quantity<double, Millicandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottacandela to Microcandela
    /// </summary>
    /// <param name="val">quantity measured in Yottacandela</param>
    /// <returns>quantity measured in Microcandela</returns>
	public static Quantity<double, Microcandela> ToMicrocandela<T>(this Quantity<T, Yottacandela> val) where T:IConvertible {
        return new Quantity<double, Microcandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottacandela to Nanocandela
    /// </summary>
    /// <param name="val">quantity measured in Yottacandela</param>
    /// <returns>quantity measured in Nanocandela</returns>
	public static Quantity<double, Nanocandela> ToNanocandela<T>(this Quantity<T, Yottacandela> val) where T:IConvertible {
        return new Quantity<double, Nanocandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottacandela to Picocandela
    /// </summary>
    /// <param name="val">quantity measured in Yottacandela</param>
    /// <returns>quantity measured in Picocandela</returns>
	public static Quantity<double, Picocandela> ToPicocandela<T>(this Quantity<T, Yottacandela> val) where T:IConvertible {
        return new Quantity<double, Picocandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottacandela to Femtocandela
    /// </summary>
    /// <param name="val">quantity measured in Yottacandela</param>
    /// <returns>quantity measured in Femtocandela</returns>
	public static Quantity<double, Femtocandela> ToFemtocandela<T>(this Quantity<T, Yottacandela> val) where T:IConvertible {
        return new Quantity<double, Femtocandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottacandela to Attocandela
    /// </summary>
    /// <param name="val">quantity measured in Yottacandela</param>
    /// <returns>quantity measured in Attocandela</returns>
	public static Quantity<double, Attocandela> ToAttocandela<T>(this Quantity<T, Yottacandela> val) where T:IConvertible {
        return new Quantity<double, Attocandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottacandela to Zeptocandela
    /// </summary>
    /// <param name="val">quantity measured in Yottacandela</param>
    /// <returns>quantity measured in Zeptocandela</returns>
	public static Quantity<double, Zeptocandela> ToZeptocandela<T>(this Quantity<T, Yottacandela> val) where T:IConvertible {
        return new Quantity<double, Zeptocandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottacandela to Yoctocandela
    /// </summary>
    /// <param name="val">quantity measured in Yottacandela</param>
    /// <returns>quantity measured in Yoctocandela</returns>
	public static Quantity<double, Yoctocandela> ToYoctocandela<T>(this Quantity<T, Yottacandela> val) where T:IConvertible {
        return new Quantity<double, Yoctocandela>(
            Convert.ToDouble(val.Value) * 1E-24
        );
    }
	/// <summary>
    /// Extension method to convert Zettacandela to Yottacandela
    /// </summary>
    /// <param name="val">quantity measured in Zettacandela</param>
    /// <returns>quantity measured in Yottacandela</returns>
	public static Quantity<double, Yottacandela> ToYottacandela<T>(this Quantity<T, Zettacandela> val) where T:IConvertible {
        return new Quantity<double, Yottacandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettacandela to Exacandela
    /// </summary>
    /// <param name="val">quantity measured in Zettacandela</param>
    /// <returns>quantity measured in Exacandela</returns>
	public static Quantity<double, Exacandela> ToExacandela<T>(this Quantity<T, Zettacandela> val) where T:IConvertible {
        return new Quantity<double, Exacandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettacandela to Petacandela
    /// </summary>
    /// <param name="val">quantity measured in Zettacandela</param>
    /// <returns>quantity measured in Petacandela</returns>
	public static Quantity<double, Petacandela> ToPetacandela<T>(this Quantity<T, Zettacandela> val) where T:IConvertible {
        return new Quantity<double, Petacandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettacandela to Teracandela
    /// </summary>
    /// <param name="val">quantity measured in Zettacandela</param>
    /// <returns>quantity measured in Teracandela</returns>
	public static Quantity<double, Teracandela> ToTeracandela<T>(this Quantity<T, Zettacandela> val) where T:IConvertible {
        return new Quantity<double, Teracandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettacandela to Gigacandela
    /// </summary>
    /// <param name="val">quantity measured in Zettacandela</param>
    /// <returns>quantity measured in Gigacandela</returns>
	public static Quantity<double, Gigacandela> ToGigacandela<T>(this Quantity<T, Zettacandela> val) where T:IConvertible {
        return new Quantity<double, Gigacandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettacandela to Megacandela
    /// </summary>
    /// <param name="val">quantity measured in Zettacandela</param>
    /// <returns>quantity measured in Megacandela</returns>
	public static Quantity<double, Megacandela> ToMegacandela<T>(this Quantity<T, Zettacandela> val) where T:IConvertible {
        return new Quantity<double, Megacandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettacandela to Kilocandela
    /// </summary>
    /// <param name="val">quantity measured in Zettacandela</param>
    /// <returns>quantity measured in Kilocandela</returns>
	public static Quantity<double, Kilocandela> ToKilocandela<T>(this Quantity<T, Zettacandela> val) where T:IConvertible {
        return new Quantity<double, Kilocandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettacandela to Hectocandela
    /// </summary>
    /// <param name="val">quantity measured in Zettacandela</param>
    /// <returns>quantity measured in Hectocandela</returns>
	public static Quantity<double, Hectocandela> ToHectocandela<T>(this Quantity<T, Zettacandela> val) where T:IConvertible {
        return new Quantity<double, Hectocandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettacandela to Dekacandela
    /// </summary>
    /// <param name="val">quantity measured in Zettacandela</param>
    /// <returns>quantity measured in Dekacandela</returns>
	public static Quantity<double, Dekacandela> ToDekacandela<T>(this Quantity<T, Zettacandela> val) where T:IConvertible {
        return new Quantity<double, Dekacandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettacandela to Decicandela
    /// </summary>
    /// <param name="val">quantity measured in Zettacandela</param>
    /// <returns>quantity measured in Decicandela</returns>
	public static Quantity<double, Decicandela> ToDecicandela<T>(this Quantity<T, Zettacandela> val) where T:IConvertible {
        return new Quantity<double, Decicandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettacandela to Centicandela
    /// </summary>
    /// <param name="val">quantity measured in Zettacandela</param>
    /// <returns>quantity measured in Centicandela</returns>
	public static Quantity<double, Centicandela> ToCenticandela<T>(this Quantity<T, Zettacandela> val) where T:IConvertible {
        return new Quantity<double, Centicandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettacandela to Millicandela
    /// </summary>
    /// <param name="val">quantity measured in Zettacandela</param>
    /// <returns>quantity measured in Millicandela</returns>
	public static Quantity<double, Millicandela> ToMillicandela<T>(this Quantity<T, Zettacandela> val) where T:IConvertible {
        return new Quantity<double, Millicandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettacandela to Microcandela
    /// </summary>
    /// <param name="val">quantity measured in Zettacandela</param>
    /// <returns>quantity measured in Microcandela</returns>
	public static Quantity<double, Microcandela> ToMicrocandela<T>(this Quantity<T, Zettacandela> val) where T:IConvertible {
        return new Quantity<double, Microcandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettacandela to Nanocandela
    /// </summary>
    /// <param name="val">quantity measured in Zettacandela</param>
    /// <returns>quantity measured in Nanocandela</returns>
	public static Quantity<double, Nanocandela> ToNanocandela<T>(this Quantity<T, Zettacandela> val) where T:IConvertible {
        return new Quantity<double, Nanocandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettacandela to Picocandela
    /// </summary>
    /// <param name="val">quantity measured in Zettacandela</param>
    /// <returns>quantity measured in Picocandela</returns>
	public static Quantity<double, Picocandela> ToPicocandela<T>(this Quantity<T, Zettacandela> val) where T:IConvertible {
        return new Quantity<double, Picocandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettacandela to Femtocandela
    /// </summary>
    /// <param name="val">quantity measured in Zettacandela</param>
    /// <returns>quantity measured in Femtocandela</returns>
	public static Quantity<double, Femtocandela> ToFemtocandela<T>(this Quantity<T, Zettacandela> val) where T:IConvertible {
        return new Quantity<double, Femtocandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettacandela to Attocandela
    /// </summary>
    /// <param name="val">quantity measured in Zettacandela</param>
    /// <returns>quantity measured in Attocandela</returns>
	public static Quantity<double, Attocandela> ToAttocandela<T>(this Quantity<T, Zettacandela> val) where T:IConvertible {
        return new Quantity<double, Attocandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettacandela to Zeptocandela
    /// </summary>
    /// <param name="val">quantity measured in Zettacandela</param>
    /// <returns>quantity measured in Zeptocandela</returns>
	public static Quantity<double, Zeptocandela> ToZeptocandela<T>(this Quantity<T, Zettacandela> val) where T:IConvertible {
        return new Quantity<double, Zeptocandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Zettacandela to Yoctocandela
    /// </summary>
    /// <param name="val">quantity measured in Zettacandela</param>
    /// <returns>quantity measured in Yoctocandela</returns>
	public static Quantity<double, Yoctocandela> ToYoctocandela<T>(this Quantity<T, Zettacandela> val) where T:IConvertible {
        return new Quantity<double, Yoctocandela>(
            Convert.ToDouble(val.Value) * 1E-21
        );
    }
	/// <summary>
    /// Extension method to convert Exacandela to Yottacandela
    /// </summary>
    /// <param name="val">quantity measured in Exacandela</param>
    /// <returns>quantity measured in Yottacandela</returns>
	public static Quantity<double, Yottacandela> ToYottacandela<T>(this Quantity<T, Exacandela> val) where T:IConvertible {
        return new Quantity<double, Yottacandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exacandela to Zettacandela
    /// </summary>
    /// <param name="val">quantity measured in Exacandela</param>
    /// <returns>quantity measured in Zettacandela</returns>
	public static Quantity<double, Zettacandela> ToZettacandela<T>(this Quantity<T, Exacandela> val) where T:IConvertible {
        return new Quantity<double, Zettacandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exacandela to Petacandela
    /// </summary>
    /// <param name="val">quantity measured in Exacandela</param>
    /// <returns>quantity measured in Petacandela</returns>
	public static Quantity<double, Petacandela> ToPetacandela<T>(this Quantity<T, Exacandela> val) where T:IConvertible {
        return new Quantity<double, Petacandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exacandela to Teracandela
    /// </summary>
    /// <param name="val">quantity measured in Exacandela</param>
    /// <returns>quantity measured in Teracandela</returns>
	public static Quantity<double, Teracandela> ToTeracandela<T>(this Quantity<T, Exacandela> val) where T:IConvertible {
        return new Quantity<double, Teracandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exacandela to Gigacandela
    /// </summary>
    /// <param name="val">quantity measured in Exacandela</param>
    /// <returns>quantity measured in Gigacandela</returns>
	public static Quantity<double, Gigacandela> ToGigacandela<T>(this Quantity<T, Exacandela> val) where T:IConvertible {
        return new Quantity<double, Gigacandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exacandela to Megacandela
    /// </summary>
    /// <param name="val">quantity measured in Exacandela</param>
    /// <returns>quantity measured in Megacandela</returns>
	public static Quantity<double, Megacandela> ToMegacandela<T>(this Quantity<T, Exacandela> val) where T:IConvertible {
        return new Quantity<double, Megacandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exacandela to Kilocandela
    /// </summary>
    /// <param name="val">quantity measured in Exacandela</param>
    /// <returns>quantity measured in Kilocandela</returns>
	public static Quantity<double, Kilocandela> ToKilocandela<T>(this Quantity<T, Exacandela> val) where T:IConvertible {
        return new Quantity<double, Kilocandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exacandela to Hectocandela
    /// </summary>
    /// <param name="val">quantity measured in Exacandela</param>
    /// <returns>quantity measured in Hectocandela</returns>
	public static Quantity<double, Hectocandela> ToHectocandela<T>(this Quantity<T, Exacandela> val) where T:IConvertible {
        return new Quantity<double, Hectocandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exacandela to Dekacandela
    /// </summary>
    /// <param name="val">quantity measured in Exacandela</param>
    /// <returns>quantity measured in Dekacandela</returns>
	public static Quantity<double, Dekacandela> ToDekacandela<T>(this Quantity<T, Exacandela> val) where T:IConvertible {
        return new Quantity<double, Dekacandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exacandela to Decicandela
    /// </summary>
    /// <param name="val">quantity measured in Exacandela</param>
    /// <returns>quantity measured in Decicandela</returns>
	public static Quantity<double, Decicandela> ToDecicandela<T>(this Quantity<T, Exacandela> val) where T:IConvertible {
        return new Quantity<double, Decicandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exacandela to Centicandela
    /// </summary>
    /// <param name="val">quantity measured in Exacandela</param>
    /// <returns>quantity measured in Centicandela</returns>
	public static Quantity<double, Centicandela> ToCenticandela<T>(this Quantity<T, Exacandela> val) where T:IConvertible {
        return new Quantity<double, Centicandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exacandela to Millicandela
    /// </summary>
    /// <param name="val">quantity measured in Exacandela</param>
    /// <returns>quantity measured in Millicandela</returns>
	public static Quantity<double, Millicandela> ToMillicandela<T>(this Quantity<T, Exacandela> val) where T:IConvertible {
        return new Quantity<double, Millicandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exacandela to Microcandela
    /// </summary>
    /// <param name="val">quantity measured in Exacandela</param>
    /// <returns>quantity measured in Microcandela</returns>
	public static Quantity<double, Microcandela> ToMicrocandela<T>(this Quantity<T, Exacandela> val) where T:IConvertible {
        return new Quantity<double, Microcandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exacandela to Nanocandela
    /// </summary>
    /// <param name="val">quantity measured in Exacandela</param>
    /// <returns>quantity measured in Nanocandela</returns>
	public static Quantity<double, Nanocandela> ToNanocandela<T>(this Quantity<T, Exacandela> val) where T:IConvertible {
        return new Quantity<double, Nanocandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exacandela to Picocandela
    /// </summary>
    /// <param name="val">quantity measured in Exacandela</param>
    /// <returns>quantity measured in Picocandela</returns>
	public static Quantity<double, Picocandela> ToPicocandela<T>(this Quantity<T, Exacandela> val) where T:IConvertible {
        return new Quantity<double, Picocandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exacandela to Femtocandela
    /// </summary>
    /// <param name="val">quantity measured in Exacandela</param>
    /// <returns>quantity measured in Femtocandela</returns>
	public static Quantity<double, Femtocandela> ToFemtocandela<T>(this Quantity<T, Exacandela> val) where T:IConvertible {
        return new Quantity<double, Femtocandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exacandela to Attocandela
    /// </summary>
    /// <param name="val">quantity measured in Exacandela</param>
    /// <returns>quantity measured in Attocandela</returns>
	public static Quantity<double, Attocandela> ToAttocandela<T>(this Quantity<T, Exacandela> val) where T:IConvertible {
        return new Quantity<double, Attocandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exacandela to Zeptocandela
    /// </summary>
    /// <param name="val">quantity measured in Exacandela</param>
    /// <returns>quantity measured in Zeptocandela</returns>
	public static Quantity<double, Zeptocandela> ToZeptocandela<T>(this Quantity<T, Exacandela> val) where T:IConvertible {
        return new Quantity<double, Zeptocandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Exacandela to Yoctocandela
    /// </summary>
    /// <param name="val">quantity measured in Exacandela</param>
    /// <returns>quantity measured in Yoctocandela</returns>
	public static Quantity<double, Yoctocandela> ToYoctocandela<T>(this Quantity<T, Exacandela> val) where T:IConvertible {
        return new Quantity<double, Yoctocandela>(
            Convert.ToDouble(val.Value) * 1E-18
        );
    }
	/// <summary>
    /// Extension method to convert Petacandela to Yottacandela
    /// </summary>
    /// <param name="val">quantity measured in Petacandela</param>
    /// <returns>quantity measured in Yottacandela</returns>
	public static Quantity<double, Yottacandela> ToYottacandela<T>(this Quantity<T, Petacandela> val) where T:IConvertible {
        return new Quantity<double, Yottacandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petacandela to Zettacandela
    /// </summary>
    /// <param name="val">quantity measured in Petacandela</param>
    /// <returns>quantity measured in Zettacandela</returns>
	public static Quantity<double, Zettacandela> ToZettacandela<T>(this Quantity<T, Petacandela> val) where T:IConvertible {
        return new Quantity<double, Zettacandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petacandela to Exacandela
    /// </summary>
    /// <param name="val">quantity measured in Petacandela</param>
    /// <returns>quantity measured in Exacandela</returns>
	public static Quantity<double, Exacandela> ToExacandela<T>(this Quantity<T, Petacandela> val) where T:IConvertible {
        return new Quantity<double, Exacandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petacandela to Teracandela
    /// </summary>
    /// <param name="val">quantity measured in Petacandela</param>
    /// <returns>quantity measured in Teracandela</returns>
	public static Quantity<double, Teracandela> ToTeracandela<T>(this Quantity<T, Petacandela> val) where T:IConvertible {
        return new Quantity<double, Teracandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petacandela to Gigacandela
    /// </summary>
    /// <param name="val">quantity measured in Petacandela</param>
    /// <returns>quantity measured in Gigacandela</returns>
	public static Quantity<double, Gigacandela> ToGigacandela<T>(this Quantity<T, Petacandela> val) where T:IConvertible {
        return new Quantity<double, Gigacandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petacandela to Megacandela
    /// </summary>
    /// <param name="val">quantity measured in Petacandela</param>
    /// <returns>quantity measured in Megacandela</returns>
	public static Quantity<double, Megacandela> ToMegacandela<T>(this Quantity<T, Petacandela> val) where T:IConvertible {
        return new Quantity<double, Megacandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petacandela to Kilocandela
    /// </summary>
    /// <param name="val">quantity measured in Petacandela</param>
    /// <returns>quantity measured in Kilocandela</returns>
	public static Quantity<double, Kilocandela> ToKilocandela<T>(this Quantity<T, Petacandela> val) where T:IConvertible {
        return new Quantity<double, Kilocandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petacandela to Hectocandela
    /// </summary>
    /// <param name="val">quantity measured in Petacandela</param>
    /// <returns>quantity measured in Hectocandela</returns>
	public static Quantity<double, Hectocandela> ToHectocandela<T>(this Quantity<T, Petacandela> val) where T:IConvertible {
        return new Quantity<double, Hectocandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petacandela to Dekacandela
    /// </summary>
    /// <param name="val">quantity measured in Petacandela</param>
    /// <returns>quantity measured in Dekacandela</returns>
	public static Quantity<double, Dekacandela> ToDekacandela<T>(this Quantity<T, Petacandela> val) where T:IConvertible {
        return new Quantity<double, Dekacandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petacandela to Decicandela
    /// </summary>
    /// <param name="val">quantity measured in Petacandela</param>
    /// <returns>quantity measured in Decicandela</returns>
	public static Quantity<double, Decicandela> ToDecicandela<T>(this Quantity<T, Petacandela> val) where T:IConvertible {
        return new Quantity<double, Decicandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petacandela to Centicandela
    /// </summary>
    /// <param name="val">quantity measured in Petacandela</param>
    /// <returns>quantity measured in Centicandela</returns>
	public static Quantity<double, Centicandela> ToCenticandela<T>(this Quantity<T, Petacandela> val) where T:IConvertible {
        return new Quantity<double, Centicandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petacandela to Millicandela
    /// </summary>
    /// <param name="val">quantity measured in Petacandela</param>
    /// <returns>quantity measured in Millicandela</returns>
	public static Quantity<double, Millicandela> ToMillicandela<T>(this Quantity<T, Petacandela> val) where T:IConvertible {
        return new Quantity<double, Millicandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petacandela to Microcandela
    /// </summary>
    /// <param name="val">quantity measured in Petacandela</param>
    /// <returns>quantity measured in Microcandela</returns>
	public static Quantity<double, Microcandela> ToMicrocandela<T>(this Quantity<T, Petacandela> val) where T:IConvertible {
        return new Quantity<double, Microcandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petacandela to Nanocandela
    /// </summary>
    /// <param name="val">quantity measured in Petacandela</param>
    /// <returns>quantity measured in Nanocandela</returns>
	public static Quantity<double, Nanocandela> ToNanocandela<T>(this Quantity<T, Petacandela> val) where T:IConvertible {
        return new Quantity<double, Nanocandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petacandela to Picocandela
    /// </summary>
    /// <param name="val">quantity measured in Petacandela</param>
    /// <returns>quantity measured in Picocandela</returns>
	public static Quantity<double, Picocandela> ToPicocandela<T>(this Quantity<T, Petacandela> val) where T:IConvertible {
        return new Quantity<double, Picocandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petacandela to Femtocandela
    /// </summary>
    /// <param name="val">quantity measured in Petacandela</param>
    /// <returns>quantity measured in Femtocandela</returns>
	public static Quantity<double, Femtocandela> ToFemtocandela<T>(this Quantity<T, Petacandela> val) where T:IConvertible {
        return new Quantity<double, Femtocandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petacandela to Attocandela
    /// </summary>
    /// <param name="val">quantity measured in Petacandela</param>
    /// <returns>quantity measured in Attocandela</returns>
	public static Quantity<double, Attocandela> ToAttocandela<T>(this Quantity<T, Petacandela> val) where T:IConvertible {
        return new Quantity<double, Attocandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petacandela to Zeptocandela
    /// </summary>
    /// <param name="val">quantity measured in Petacandela</param>
    /// <returns>quantity measured in Zeptocandela</returns>
	public static Quantity<double, Zeptocandela> ToZeptocandela<T>(this Quantity<T, Petacandela> val) where T:IConvertible {
        return new Quantity<double, Zeptocandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Petacandela to Yoctocandela
    /// </summary>
    /// <param name="val">quantity measured in Petacandela</param>
    /// <returns>quantity measured in Yoctocandela</returns>
	public static Quantity<double, Yoctocandela> ToYoctocandela<T>(this Quantity<T, Petacandela> val) where T:IConvertible {
        return new Quantity<double, Yoctocandela>(
            Convert.ToDouble(val.Value) * 1E-15
        );
    }
	/// <summary>
    /// Extension method to convert Teracandela to Yottacandela
    /// </summary>
    /// <param name="val">quantity measured in Teracandela</param>
    /// <returns>quantity measured in Yottacandela</returns>
	public static Quantity<double, Yottacandela> ToYottacandela<T>(this Quantity<T, Teracandela> val) where T:IConvertible {
        return new Quantity<double, Yottacandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teracandela to Zettacandela
    /// </summary>
    /// <param name="val">quantity measured in Teracandela</param>
    /// <returns>quantity measured in Zettacandela</returns>
	public static Quantity<double, Zettacandela> ToZettacandela<T>(this Quantity<T, Teracandela> val) where T:IConvertible {
        return new Quantity<double, Zettacandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teracandela to Exacandela
    /// </summary>
    /// <param name="val">quantity measured in Teracandela</param>
    /// <returns>quantity measured in Exacandela</returns>
	public static Quantity<double, Exacandela> ToExacandela<T>(this Quantity<T, Teracandela> val) where T:IConvertible {
        return new Quantity<double, Exacandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teracandela to Petacandela
    /// </summary>
    /// <param name="val">quantity measured in Teracandela</param>
    /// <returns>quantity measured in Petacandela</returns>
	public static Quantity<double, Petacandela> ToPetacandela<T>(this Quantity<T, Teracandela> val) where T:IConvertible {
        return new Quantity<double, Petacandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teracandela to Gigacandela
    /// </summary>
    /// <param name="val">quantity measured in Teracandela</param>
    /// <returns>quantity measured in Gigacandela</returns>
	public static Quantity<double, Gigacandela> ToGigacandela<T>(this Quantity<T, Teracandela> val) where T:IConvertible {
        return new Quantity<double, Gigacandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teracandela to Megacandela
    /// </summary>
    /// <param name="val">quantity measured in Teracandela</param>
    /// <returns>quantity measured in Megacandela</returns>
	public static Quantity<double, Megacandela> ToMegacandela<T>(this Quantity<T, Teracandela> val) where T:IConvertible {
        return new Quantity<double, Megacandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teracandela to Kilocandela
    /// </summary>
    /// <param name="val">quantity measured in Teracandela</param>
    /// <returns>quantity measured in Kilocandela</returns>
	public static Quantity<double, Kilocandela> ToKilocandela<T>(this Quantity<T, Teracandela> val) where T:IConvertible {
        return new Quantity<double, Kilocandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teracandela to Hectocandela
    /// </summary>
    /// <param name="val">quantity measured in Teracandela</param>
    /// <returns>quantity measured in Hectocandela</returns>
	public static Quantity<double, Hectocandela> ToHectocandela<T>(this Quantity<T, Teracandela> val) where T:IConvertible {
        return new Quantity<double, Hectocandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teracandela to Dekacandela
    /// </summary>
    /// <param name="val">quantity measured in Teracandela</param>
    /// <returns>quantity measured in Dekacandela</returns>
	public static Quantity<double, Dekacandela> ToDekacandela<T>(this Quantity<T, Teracandela> val) where T:IConvertible {
        return new Quantity<double, Dekacandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teracandela to Decicandela
    /// </summary>
    /// <param name="val">quantity measured in Teracandela</param>
    /// <returns>quantity measured in Decicandela</returns>
	public static Quantity<double, Decicandela> ToDecicandela<T>(this Quantity<T, Teracandela> val) where T:IConvertible {
        return new Quantity<double, Decicandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teracandela to Centicandela
    /// </summary>
    /// <param name="val">quantity measured in Teracandela</param>
    /// <returns>quantity measured in Centicandela</returns>
	public static Quantity<double, Centicandela> ToCenticandela<T>(this Quantity<T, Teracandela> val) where T:IConvertible {
        return new Quantity<double, Centicandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teracandela to Millicandela
    /// </summary>
    /// <param name="val">quantity measured in Teracandela</param>
    /// <returns>quantity measured in Millicandela</returns>
	public static Quantity<double, Millicandela> ToMillicandela<T>(this Quantity<T, Teracandela> val) where T:IConvertible {
        return new Quantity<double, Millicandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teracandela to Microcandela
    /// </summary>
    /// <param name="val">quantity measured in Teracandela</param>
    /// <returns>quantity measured in Microcandela</returns>
	public static Quantity<double, Microcandela> ToMicrocandela<T>(this Quantity<T, Teracandela> val) where T:IConvertible {
        return new Quantity<double, Microcandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teracandela to Nanocandela
    /// </summary>
    /// <param name="val">quantity measured in Teracandela</param>
    /// <returns>quantity measured in Nanocandela</returns>
	public static Quantity<double, Nanocandela> ToNanocandela<T>(this Quantity<T, Teracandela> val) where T:IConvertible {
        return new Quantity<double, Nanocandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teracandela to Picocandela
    /// </summary>
    /// <param name="val">quantity measured in Teracandela</param>
    /// <returns>quantity measured in Picocandela</returns>
	public static Quantity<double, Picocandela> ToPicocandela<T>(this Quantity<T, Teracandela> val) where T:IConvertible {
        return new Quantity<double, Picocandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teracandela to Femtocandela
    /// </summary>
    /// <param name="val">quantity measured in Teracandela</param>
    /// <returns>quantity measured in Femtocandela</returns>
	public static Quantity<double, Femtocandela> ToFemtocandela<T>(this Quantity<T, Teracandela> val) where T:IConvertible {
        return new Quantity<double, Femtocandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teracandela to Attocandela
    /// </summary>
    /// <param name="val">quantity measured in Teracandela</param>
    /// <returns>quantity measured in Attocandela</returns>
	public static Quantity<double, Attocandela> ToAttocandela<T>(this Quantity<T, Teracandela> val) where T:IConvertible {
        return new Quantity<double, Attocandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teracandela to Zeptocandela
    /// </summary>
    /// <param name="val">quantity measured in Teracandela</param>
    /// <returns>quantity measured in Zeptocandela</returns>
	public static Quantity<double, Zeptocandela> ToZeptocandela<T>(this Quantity<T, Teracandela> val) where T:IConvertible {
        return new Quantity<double, Zeptocandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Teracandela to Yoctocandela
    /// </summary>
    /// <param name="val">quantity measured in Teracandela</param>
    /// <returns>quantity measured in Yoctocandela</returns>
	public static Quantity<double, Yoctocandela> ToYoctocandela<T>(this Quantity<T, Teracandela> val) where T:IConvertible {
        return new Quantity<double, Yoctocandela>(
            Convert.ToDouble(val.Value) * 1E-12
        );
    }
	/// <summary>
    /// Extension method to convert Gigacandela to Yottacandela
    /// </summary>
    /// <param name="val">quantity measured in Gigacandela</param>
    /// <returns>quantity measured in Yottacandela</returns>
	public static Quantity<double, Yottacandela> ToYottacandela<T>(this Quantity<T, Gigacandela> val) where T:IConvertible {
        return new Quantity<double, Yottacandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigacandela to Zettacandela
    /// </summary>
    /// <param name="val">quantity measured in Gigacandela</param>
    /// <returns>quantity measured in Zettacandela</returns>
	public static Quantity<double, Zettacandela> ToZettacandela<T>(this Quantity<T, Gigacandela> val) where T:IConvertible {
        return new Quantity<double, Zettacandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigacandela to Exacandela
    /// </summary>
    /// <param name="val">quantity measured in Gigacandela</param>
    /// <returns>quantity measured in Exacandela</returns>
	public static Quantity<double, Exacandela> ToExacandela<T>(this Quantity<T, Gigacandela> val) where T:IConvertible {
        return new Quantity<double, Exacandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigacandela to Petacandela
    /// </summary>
    /// <param name="val">quantity measured in Gigacandela</param>
    /// <returns>quantity measured in Petacandela</returns>
	public static Quantity<double, Petacandela> ToPetacandela<T>(this Quantity<T, Gigacandela> val) where T:IConvertible {
        return new Quantity<double, Petacandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigacandela to Teracandela
    /// </summary>
    /// <param name="val">quantity measured in Gigacandela</param>
    /// <returns>quantity measured in Teracandela</returns>
	public static Quantity<double, Teracandela> ToTeracandela<T>(this Quantity<T, Gigacandela> val) where T:IConvertible {
        return new Quantity<double, Teracandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigacandela to Megacandela
    /// </summary>
    /// <param name="val">quantity measured in Gigacandela</param>
    /// <returns>quantity measured in Megacandela</returns>
	public static Quantity<double, Megacandela> ToMegacandela<T>(this Quantity<T, Gigacandela> val) where T:IConvertible {
        return new Quantity<double, Megacandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigacandela to Kilocandela
    /// </summary>
    /// <param name="val">quantity measured in Gigacandela</param>
    /// <returns>quantity measured in Kilocandela</returns>
	public static Quantity<double, Kilocandela> ToKilocandela<T>(this Quantity<T, Gigacandela> val) where T:IConvertible {
        return new Quantity<double, Kilocandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigacandela to Hectocandela
    /// </summary>
    /// <param name="val">quantity measured in Gigacandela</param>
    /// <returns>quantity measured in Hectocandela</returns>
	public static Quantity<double, Hectocandela> ToHectocandela<T>(this Quantity<T, Gigacandela> val) where T:IConvertible {
        return new Quantity<double, Hectocandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigacandela to Dekacandela
    /// </summary>
    /// <param name="val">quantity measured in Gigacandela</param>
    /// <returns>quantity measured in Dekacandela</returns>
	public static Quantity<double, Dekacandela> ToDekacandela<T>(this Quantity<T, Gigacandela> val) where T:IConvertible {
        return new Quantity<double, Dekacandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigacandela to Decicandela
    /// </summary>
    /// <param name="val">quantity measured in Gigacandela</param>
    /// <returns>quantity measured in Decicandela</returns>
	public static Quantity<double, Decicandela> ToDecicandela<T>(this Quantity<T, Gigacandela> val) where T:IConvertible {
        return new Quantity<double, Decicandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigacandela to Centicandela
    /// </summary>
    /// <param name="val">quantity measured in Gigacandela</param>
    /// <returns>quantity measured in Centicandela</returns>
	public static Quantity<double, Centicandela> ToCenticandela<T>(this Quantity<T, Gigacandela> val) where T:IConvertible {
        return new Quantity<double, Centicandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigacandela to Millicandela
    /// </summary>
    /// <param name="val">quantity measured in Gigacandela</param>
    /// <returns>quantity measured in Millicandela</returns>
	public static Quantity<double, Millicandela> ToMillicandela<T>(this Quantity<T, Gigacandela> val) where T:IConvertible {
        return new Quantity<double, Millicandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigacandela to Microcandela
    /// </summary>
    /// <param name="val">quantity measured in Gigacandela</param>
    /// <returns>quantity measured in Microcandela</returns>
	public static Quantity<double, Microcandela> ToMicrocandela<T>(this Quantity<T, Gigacandela> val) where T:IConvertible {
        return new Quantity<double, Microcandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigacandela to Nanocandela
    /// </summary>
    /// <param name="val">quantity measured in Gigacandela</param>
    /// <returns>quantity measured in Nanocandela</returns>
	public static Quantity<double, Nanocandela> ToNanocandela<T>(this Quantity<T, Gigacandela> val) where T:IConvertible {
        return new Quantity<double, Nanocandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigacandela to Picocandela
    /// </summary>
    /// <param name="val">quantity measured in Gigacandela</param>
    /// <returns>quantity measured in Picocandela</returns>
	public static Quantity<double, Picocandela> ToPicocandela<T>(this Quantity<T, Gigacandela> val) where T:IConvertible {
        return new Quantity<double, Picocandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigacandela to Femtocandela
    /// </summary>
    /// <param name="val">quantity measured in Gigacandela</param>
    /// <returns>quantity measured in Femtocandela</returns>
	public static Quantity<double, Femtocandela> ToFemtocandela<T>(this Quantity<T, Gigacandela> val) where T:IConvertible {
        return new Quantity<double, Femtocandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigacandela to Attocandela
    /// </summary>
    /// <param name="val">quantity measured in Gigacandela</param>
    /// <returns>quantity measured in Attocandela</returns>
	public static Quantity<double, Attocandela> ToAttocandela<T>(this Quantity<T, Gigacandela> val) where T:IConvertible {
        return new Quantity<double, Attocandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigacandela to Zeptocandela
    /// </summary>
    /// <param name="val">quantity measured in Gigacandela</param>
    /// <returns>quantity measured in Zeptocandela</returns>
	public static Quantity<double, Zeptocandela> ToZeptocandela<T>(this Quantity<T, Gigacandela> val) where T:IConvertible {
        return new Quantity<double, Zeptocandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Gigacandela to Yoctocandela
    /// </summary>
    /// <param name="val">quantity measured in Gigacandela</param>
    /// <returns>quantity measured in Yoctocandela</returns>
	public static Quantity<double, Yoctocandela> ToYoctocandela<T>(this Quantity<T, Gigacandela> val) where T:IConvertible {
        return new Quantity<double, Yoctocandela>(
            Convert.ToDouble(val.Value) * 1E-9
        );
    }
	/// <summary>
    /// Extension method to convert Megacandela to Yottacandela
    /// </summary>
    /// <param name="val">quantity measured in Megacandela</param>
    /// <returns>quantity measured in Yottacandela</returns>
	public static Quantity<double, Yottacandela> ToYottacandela<T>(this Quantity<T, Megacandela> val) where T:IConvertible {
        return new Quantity<double, Yottacandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megacandela to Zettacandela
    /// </summary>
    /// <param name="val">quantity measured in Megacandela</param>
    /// <returns>quantity measured in Zettacandela</returns>
	public static Quantity<double, Zettacandela> ToZettacandela<T>(this Quantity<T, Megacandela> val) where T:IConvertible {
        return new Quantity<double, Zettacandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megacandela to Exacandela
    /// </summary>
    /// <param name="val">quantity measured in Megacandela</param>
    /// <returns>quantity measured in Exacandela</returns>
	public static Quantity<double, Exacandela> ToExacandela<T>(this Quantity<T, Megacandela> val) where T:IConvertible {
        return new Quantity<double, Exacandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megacandela to Petacandela
    /// </summary>
    /// <param name="val">quantity measured in Megacandela</param>
    /// <returns>quantity measured in Petacandela</returns>
	public static Quantity<double, Petacandela> ToPetacandela<T>(this Quantity<T, Megacandela> val) where T:IConvertible {
        return new Quantity<double, Petacandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megacandela to Teracandela
    /// </summary>
    /// <param name="val">quantity measured in Megacandela</param>
    /// <returns>quantity measured in Teracandela</returns>
	public static Quantity<double, Teracandela> ToTeracandela<T>(this Quantity<T, Megacandela> val) where T:IConvertible {
        return new Quantity<double, Teracandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megacandela to Gigacandela
    /// </summary>
    /// <param name="val">quantity measured in Megacandela</param>
    /// <returns>quantity measured in Gigacandela</returns>
	public static Quantity<double, Gigacandela> ToGigacandela<T>(this Quantity<T, Megacandela> val) where T:IConvertible {
        return new Quantity<double, Gigacandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megacandela to Kilocandela
    /// </summary>
    /// <param name="val">quantity measured in Megacandela</param>
    /// <returns>quantity measured in Kilocandela</returns>
	public static Quantity<double, Kilocandela> ToKilocandela<T>(this Quantity<T, Megacandela> val) where T:IConvertible {
        return new Quantity<double, Kilocandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megacandela to Hectocandela
    /// </summary>
    /// <param name="val">quantity measured in Megacandela</param>
    /// <returns>quantity measured in Hectocandela</returns>
	public static Quantity<double, Hectocandela> ToHectocandela<T>(this Quantity<T, Megacandela> val) where T:IConvertible {
        return new Quantity<double, Hectocandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megacandela to Dekacandela
    /// </summary>
    /// <param name="val">quantity measured in Megacandela</param>
    /// <returns>quantity measured in Dekacandela</returns>
	public static Quantity<double, Dekacandela> ToDekacandela<T>(this Quantity<T, Megacandela> val) where T:IConvertible {
        return new Quantity<double, Dekacandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megacandela to Decicandela
    /// </summary>
    /// <param name="val">quantity measured in Megacandela</param>
    /// <returns>quantity measured in Decicandela</returns>
	public static Quantity<double, Decicandela> ToDecicandela<T>(this Quantity<T, Megacandela> val) where T:IConvertible {
        return new Quantity<double, Decicandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megacandela to Centicandela
    /// </summary>
    /// <param name="val">quantity measured in Megacandela</param>
    /// <returns>quantity measured in Centicandela</returns>
	public static Quantity<double, Centicandela> ToCenticandela<T>(this Quantity<T, Megacandela> val) where T:IConvertible {
        return new Quantity<double, Centicandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megacandela to Millicandela
    /// </summary>
    /// <param name="val">quantity measured in Megacandela</param>
    /// <returns>quantity measured in Millicandela</returns>
	public static Quantity<double, Millicandela> ToMillicandela<T>(this Quantity<T, Megacandela> val) where T:IConvertible {
        return new Quantity<double, Millicandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megacandela to Microcandela
    /// </summary>
    /// <param name="val">quantity measured in Megacandela</param>
    /// <returns>quantity measured in Microcandela</returns>
	public static Quantity<double, Microcandela> ToMicrocandela<T>(this Quantity<T, Megacandela> val) where T:IConvertible {
        return new Quantity<double, Microcandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megacandela to Nanocandela
    /// </summary>
    /// <param name="val">quantity measured in Megacandela</param>
    /// <returns>quantity measured in Nanocandela</returns>
	public static Quantity<double, Nanocandela> ToNanocandela<T>(this Quantity<T, Megacandela> val) where T:IConvertible {
        return new Quantity<double, Nanocandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megacandela to Picocandela
    /// </summary>
    /// <param name="val">quantity measured in Megacandela</param>
    /// <returns>quantity measured in Picocandela</returns>
	public static Quantity<double, Picocandela> ToPicocandela<T>(this Quantity<T, Megacandela> val) where T:IConvertible {
        return new Quantity<double, Picocandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megacandela to Femtocandela
    /// </summary>
    /// <param name="val">quantity measured in Megacandela</param>
    /// <returns>quantity measured in Femtocandela</returns>
	public static Quantity<double, Femtocandela> ToFemtocandela<T>(this Quantity<T, Megacandela> val) where T:IConvertible {
        return new Quantity<double, Femtocandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megacandela to Attocandela
    /// </summary>
    /// <param name="val">quantity measured in Megacandela</param>
    /// <returns>quantity measured in Attocandela</returns>
	public static Quantity<double, Attocandela> ToAttocandela<T>(this Quantity<T, Megacandela> val) where T:IConvertible {
        return new Quantity<double, Attocandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megacandela to Zeptocandela
    /// </summary>
    /// <param name="val">quantity measured in Megacandela</param>
    /// <returns>quantity measured in Zeptocandela</returns>
	public static Quantity<double, Zeptocandela> ToZeptocandela<T>(this Quantity<T, Megacandela> val) where T:IConvertible {
        return new Quantity<double, Zeptocandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Megacandela to Yoctocandela
    /// </summary>
    /// <param name="val">quantity measured in Megacandela</param>
    /// <returns>quantity measured in Yoctocandela</returns>
	public static Quantity<double, Yoctocandela> ToYoctocandela<T>(this Quantity<T, Megacandela> val) where T:IConvertible {
        return new Quantity<double, Yoctocandela>(
            Convert.ToDouble(val.Value) * 1E-6
        );
    }
	/// <summary>
    /// Extension method to convert Kilocandela to Yottacandela
    /// </summary>
    /// <param name="val">quantity measured in Kilocandela</param>
    /// <returns>quantity measured in Yottacandela</returns>
	public static Quantity<double, Yottacandela> ToYottacandela<T>(this Quantity<T, Kilocandela> val) where T:IConvertible {
        return new Quantity<double, Yottacandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilocandela to Zettacandela
    /// </summary>
    /// <param name="val">quantity measured in Kilocandela</param>
    /// <returns>quantity measured in Zettacandela</returns>
	public static Quantity<double, Zettacandela> ToZettacandela<T>(this Quantity<T, Kilocandela> val) where T:IConvertible {
        return new Quantity<double, Zettacandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilocandela to Exacandela
    /// </summary>
    /// <param name="val">quantity measured in Kilocandela</param>
    /// <returns>quantity measured in Exacandela</returns>
	public static Quantity<double, Exacandela> ToExacandela<T>(this Quantity<T, Kilocandela> val) where T:IConvertible {
        return new Quantity<double, Exacandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilocandela to Petacandela
    /// </summary>
    /// <param name="val">quantity measured in Kilocandela</param>
    /// <returns>quantity measured in Petacandela</returns>
	public static Quantity<double, Petacandela> ToPetacandela<T>(this Quantity<T, Kilocandela> val) where T:IConvertible {
        return new Quantity<double, Petacandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilocandela to Teracandela
    /// </summary>
    /// <param name="val">quantity measured in Kilocandela</param>
    /// <returns>quantity measured in Teracandela</returns>
	public static Quantity<double, Teracandela> ToTeracandela<T>(this Quantity<T, Kilocandela> val) where T:IConvertible {
        return new Quantity<double, Teracandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilocandela to Gigacandela
    /// </summary>
    /// <param name="val">quantity measured in Kilocandela</param>
    /// <returns>quantity measured in Gigacandela</returns>
	public static Quantity<double, Gigacandela> ToGigacandela<T>(this Quantity<T, Kilocandela> val) where T:IConvertible {
        return new Quantity<double, Gigacandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilocandela to Megacandela
    /// </summary>
    /// <param name="val">quantity measured in Kilocandela</param>
    /// <returns>quantity measured in Megacandela</returns>
	public static Quantity<double, Megacandela> ToMegacandela<T>(this Quantity<T, Kilocandela> val) where T:IConvertible {
        return new Quantity<double, Megacandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilocandela to Hectocandela
    /// </summary>
    /// <param name="val">quantity measured in Kilocandela</param>
    /// <returns>quantity measured in Hectocandela</returns>
	public static Quantity<double, Hectocandela> ToHectocandela<T>(this Quantity<T, Kilocandela> val) where T:IConvertible {
        return new Quantity<double, Hectocandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilocandela to Dekacandela
    /// </summary>
    /// <param name="val">quantity measured in Kilocandela</param>
    /// <returns>quantity measured in Dekacandela</returns>
	public static Quantity<double, Dekacandela> ToDekacandela<T>(this Quantity<T, Kilocandela> val) where T:IConvertible {
        return new Quantity<double, Dekacandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilocandela to Decicandela
    /// </summary>
    /// <param name="val">quantity measured in Kilocandela</param>
    /// <returns>quantity measured in Decicandela</returns>
	public static Quantity<double, Decicandela> ToDecicandela<T>(this Quantity<T, Kilocandela> val) where T:IConvertible {
        return new Quantity<double, Decicandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilocandela to Centicandela
    /// </summary>
    /// <param name="val">quantity measured in Kilocandela</param>
    /// <returns>quantity measured in Centicandela</returns>
	public static Quantity<double, Centicandela> ToCenticandela<T>(this Quantity<T, Kilocandela> val) where T:IConvertible {
        return new Quantity<double, Centicandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilocandela to Millicandela
    /// </summary>
    /// <param name="val">quantity measured in Kilocandela</param>
    /// <returns>quantity measured in Millicandela</returns>
	public static Quantity<double, Millicandela> ToMillicandela<T>(this Quantity<T, Kilocandela> val) where T:IConvertible {
        return new Quantity<double, Millicandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilocandela to Microcandela
    /// </summary>
    /// <param name="val">quantity measured in Kilocandela</param>
    /// <returns>quantity measured in Microcandela</returns>
	public static Quantity<double, Microcandela> ToMicrocandela<T>(this Quantity<T, Kilocandela> val) where T:IConvertible {
        return new Quantity<double, Microcandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilocandela to Nanocandela
    /// </summary>
    /// <param name="val">quantity measured in Kilocandela</param>
    /// <returns>quantity measured in Nanocandela</returns>
	public static Quantity<double, Nanocandela> ToNanocandela<T>(this Quantity<T, Kilocandela> val) where T:IConvertible {
        return new Quantity<double, Nanocandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilocandela to Picocandela
    /// </summary>
    /// <param name="val">quantity measured in Kilocandela</param>
    /// <returns>quantity measured in Picocandela</returns>
	public static Quantity<double, Picocandela> ToPicocandela<T>(this Quantity<T, Kilocandela> val) where T:IConvertible {
        return new Quantity<double, Picocandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilocandela to Femtocandela
    /// </summary>
    /// <param name="val">quantity measured in Kilocandela</param>
    /// <returns>quantity measured in Femtocandela</returns>
	public static Quantity<double, Femtocandela> ToFemtocandela<T>(this Quantity<T, Kilocandela> val) where T:IConvertible {
        return new Quantity<double, Femtocandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilocandela to Attocandela
    /// </summary>
    /// <param name="val">quantity measured in Kilocandela</param>
    /// <returns>quantity measured in Attocandela</returns>
	public static Quantity<double, Attocandela> ToAttocandela<T>(this Quantity<T, Kilocandela> val) where T:IConvertible {
        return new Quantity<double, Attocandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilocandela to Zeptocandela
    /// </summary>
    /// <param name="val">quantity measured in Kilocandela</param>
    /// <returns>quantity measured in Zeptocandela</returns>
	public static Quantity<double, Zeptocandela> ToZeptocandela<T>(this Quantity<T, Kilocandela> val) where T:IConvertible {
        return new Quantity<double, Zeptocandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Kilocandela to Yoctocandela
    /// </summary>
    /// <param name="val">quantity measured in Kilocandela</param>
    /// <returns>quantity measured in Yoctocandela</returns>
	public static Quantity<double, Yoctocandela> ToYoctocandela<T>(this Quantity<T, Kilocandela> val) where T:IConvertible {
        return new Quantity<double, Yoctocandela>(
            Convert.ToDouble(val.Value) * 1E-3
        );
    }
	/// <summary>
    /// Extension method to convert Hectocandela to Yottacandela
    /// </summary>
    /// <param name="val">quantity measured in Hectocandela</param>
    /// <returns>quantity measured in Yottacandela</returns>
	public static Quantity<double, Yottacandela> ToYottacandela<T>(this Quantity<T, Hectocandela> val) where T:IConvertible {
        return new Quantity<double, Yottacandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectocandela to Zettacandela
    /// </summary>
    /// <param name="val">quantity measured in Hectocandela</param>
    /// <returns>quantity measured in Zettacandela</returns>
	public static Quantity<double, Zettacandela> ToZettacandela<T>(this Quantity<T, Hectocandela> val) where T:IConvertible {
        return new Quantity<double, Zettacandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectocandela to Exacandela
    /// </summary>
    /// <param name="val">quantity measured in Hectocandela</param>
    /// <returns>quantity measured in Exacandela</returns>
	public static Quantity<double, Exacandela> ToExacandela<T>(this Quantity<T, Hectocandela> val) where T:IConvertible {
        return new Quantity<double, Exacandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectocandela to Petacandela
    /// </summary>
    /// <param name="val">quantity measured in Hectocandela</param>
    /// <returns>quantity measured in Petacandela</returns>
	public static Quantity<double, Petacandela> ToPetacandela<T>(this Quantity<T, Hectocandela> val) where T:IConvertible {
        return new Quantity<double, Petacandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectocandela to Teracandela
    /// </summary>
    /// <param name="val">quantity measured in Hectocandela</param>
    /// <returns>quantity measured in Teracandela</returns>
	public static Quantity<double, Teracandela> ToTeracandela<T>(this Quantity<T, Hectocandela> val) where T:IConvertible {
        return new Quantity<double, Teracandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectocandela to Gigacandela
    /// </summary>
    /// <param name="val">quantity measured in Hectocandela</param>
    /// <returns>quantity measured in Gigacandela</returns>
	public static Quantity<double, Gigacandela> ToGigacandela<T>(this Quantity<T, Hectocandela> val) where T:IConvertible {
        return new Quantity<double, Gigacandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectocandela to Megacandela
    /// </summary>
    /// <param name="val">quantity measured in Hectocandela</param>
    /// <returns>quantity measured in Megacandela</returns>
	public static Quantity<double, Megacandela> ToMegacandela<T>(this Quantity<T, Hectocandela> val) where T:IConvertible {
        return new Quantity<double, Megacandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectocandela to Kilocandela
    /// </summary>
    /// <param name="val">quantity measured in Hectocandela</param>
    /// <returns>quantity measured in Kilocandela</returns>
	public static Quantity<double, Kilocandela> ToKilocandela<T>(this Quantity<T, Hectocandela> val) where T:IConvertible {
        return new Quantity<double, Kilocandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectocandela to Dekacandela
    /// </summary>
    /// <param name="val">quantity measured in Hectocandela</param>
    /// <returns>quantity measured in Dekacandela</returns>
	public static Quantity<double, Dekacandela> ToDekacandela<T>(this Quantity<T, Hectocandela> val) where T:IConvertible {
        return new Quantity<double, Dekacandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectocandela to Decicandela
    /// </summary>
    /// <param name="val">quantity measured in Hectocandela</param>
    /// <returns>quantity measured in Decicandela</returns>
	public static Quantity<double, Decicandela> ToDecicandela<T>(this Quantity<T, Hectocandela> val) where T:IConvertible {
        return new Quantity<double, Decicandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectocandela to Centicandela
    /// </summary>
    /// <param name="val">quantity measured in Hectocandela</param>
    /// <returns>quantity measured in Centicandela</returns>
	public static Quantity<double, Centicandela> ToCenticandela<T>(this Quantity<T, Hectocandela> val) where T:IConvertible {
        return new Quantity<double, Centicandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectocandela to Millicandela
    /// </summary>
    /// <param name="val">quantity measured in Hectocandela</param>
    /// <returns>quantity measured in Millicandela</returns>
	public static Quantity<double, Millicandela> ToMillicandela<T>(this Quantity<T, Hectocandela> val) where T:IConvertible {
        return new Quantity<double, Millicandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectocandela to Microcandela
    /// </summary>
    /// <param name="val">quantity measured in Hectocandela</param>
    /// <returns>quantity measured in Microcandela</returns>
	public static Quantity<double, Microcandela> ToMicrocandela<T>(this Quantity<T, Hectocandela> val) where T:IConvertible {
        return new Quantity<double, Microcandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectocandela to Nanocandela
    /// </summary>
    /// <param name="val">quantity measured in Hectocandela</param>
    /// <returns>quantity measured in Nanocandela</returns>
	public static Quantity<double, Nanocandela> ToNanocandela<T>(this Quantity<T, Hectocandela> val) where T:IConvertible {
        return new Quantity<double, Nanocandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectocandela to Picocandela
    /// </summary>
    /// <param name="val">quantity measured in Hectocandela</param>
    /// <returns>quantity measured in Picocandela</returns>
	public static Quantity<double, Picocandela> ToPicocandela<T>(this Quantity<T, Hectocandela> val) where T:IConvertible {
        return new Quantity<double, Picocandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectocandela to Femtocandela
    /// </summary>
    /// <param name="val">quantity measured in Hectocandela</param>
    /// <returns>quantity measured in Femtocandela</returns>
	public static Quantity<double, Femtocandela> ToFemtocandela<T>(this Quantity<T, Hectocandela> val) where T:IConvertible {
        return new Quantity<double, Femtocandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectocandela to Attocandela
    /// </summary>
    /// <param name="val">quantity measured in Hectocandela</param>
    /// <returns>quantity measured in Attocandela</returns>
	public static Quantity<double, Attocandela> ToAttocandela<T>(this Quantity<T, Hectocandela> val) where T:IConvertible {
        return new Quantity<double, Attocandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectocandela to Zeptocandela
    /// </summary>
    /// <param name="val">quantity measured in Hectocandela</param>
    /// <returns>quantity measured in Zeptocandela</returns>
	public static Quantity<double, Zeptocandela> ToZeptocandela<T>(this Quantity<T, Hectocandela> val) where T:IConvertible {
        return new Quantity<double, Zeptocandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Hectocandela to Yoctocandela
    /// </summary>
    /// <param name="val">quantity measured in Hectocandela</param>
    /// <returns>quantity measured in Yoctocandela</returns>
	public static Quantity<double, Yoctocandela> ToYoctocandela<T>(this Quantity<T, Hectocandela> val) where T:IConvertible {
        return new Quantity<double, Yoctocandela>(
            Convert.ToDouble(val.Value) * 1E-2
        );
    }
	/// <summary>
    /// Extension method to convert Dekacandela to Yottacandela
    /// </summary>
    /// <param name="val">quantity measured in Dekacandela</param>
    /// <returns>quantity measured in Yottacandela</returns>
	public static Quantity<double, Yottacandela> ToYottacandela<T>(this Quantity<T, Dekacandela> val) where T:IConvertible {
        return new Quantity<double, Yottacandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekacandela to Zettacandela
    /// </summary>
    /// <param name="val">quantity measured in Dekacandela</param>
    /// <returns>quantity measured in Zettacandela</returns>
	public static Quantity<double, Zettacandela> ToZettacandela<T>(this Quantity<T, Dekacandela> val) where T:IConvertible {
        return new Quantity<double, Zettacandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekacandela to Exacandela
    /// </summary>
    /// <param name="val">quantity measured in Dekacandela</param>
    /// <returns>quantity measured in Exacandela</returns>
	public static Quantity<double, Exacandela> ToExacandela<T>(this Quantity<T, Dekacandela> val) where T:IConvertible {
        return new Quantity<double, Exacandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekacandela to Petacandela
    /// </summary>
    /// <param name="val">quantity measured in Dekacandela</param>
    /// <returns>quantity measured in Petacandela</returns>
	public static Quantity<double, Petacandela> ToPetacandela<T>(this Quantity<T, Dekacandela> val) where T:IConvertible {
        return new Quantity<double, Petacandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekacandela to Teracandela
    /// </summary>
    /// <param name="val">quantity measured in Dekacandela</param>
    /// <returns>quantity measured in Teracandela</returns>
	public static Quantity<double, Teracandela> ToTeracandela<T>(this Quantity<T, Dekacandela> val) where T:IConvertible {
        return new Quantity<double, Teracandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekacandela to Gigacandela
    /// </summary>
    /// <param name="val">quantity measured in Dekacandela</param>
    /// <returns>quantity measured in Gigacandela</returns>
	public static Quantity<double, Gigacandela> ToGigacandela<T>(this Quantity<T, Dekacandela> val) where T:IConvertible {
        return new Quantity<double, Gigacandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekacandela to Megacandela
    /// </summary>
    /// <param name="val">quantity measured in Dekacandela</param>
    /// <returns>quantity measured in Megacandela</returns>
	public static Quantity<double, Megacandela> ToMegacandela<T>(this Quantity<T, Dekacandela> val) where T:IConvertible {
        return new Quantity<double, Megacandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekacandela to Kilocandela
    /// </summary>
    /// <param name="val">quantity measured in Dekacandela</param>
    /// <returns>quantity measured in Kilocandela</returns>
	public static Quantity<double, Kilocandela> ToKilocandela<T>(this Quantity<T, Dekacandela> val) where T:IConvertible {
        return new Quantity<double, Kilocandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekacandela to Hectocandela
    /// </summary>
    /// <param name="val">quantity measured in Dekacandela</param>
    /// <returns>quantity measured in Hectocandela</returns>
	public static Quantity<double, Hectocandela> ToHectocandela<T>(this Quantity<T, Dekacandela> val) where T:IConvertible {
        return new Quantity<double, Hectocandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekacandela to Decicandela
    /// </summary>
    /// <param name="val">quantity measured in Dekacandela</param>
    /// <returns>quantity measured in Decicandela</returns>
	public static Quantity<double, Decicandela> ToDecicandela<T>(this Quantity<T, Dekacandela> val) where T:IConvertible {
        return new Quantity<double, Decicandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekacandela to Centicandela
    /// </summary>
    /// <param name="val">quantity measured in Dekacandela</param>
    /// <returns>quantity measured in Centicandela</returns>
	public static Quantity<double, Centicandela> ToCenticandela<T>(this Quantity<T, Dekacandela> val) where T:IConvertible {
        return new Quantity<double, Centicandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekacandela to Millicandela
    /// </summary>
    /// <param name="val">quantity measured in Dekacandela</param>
    /// <returns>quantity measured in Millicandela</returns>
	public static Quantity<double, Millicandela> ToMillicandela<T>(this Quantity<T, Dekacandela> val) where T:IConvertible {
        return new Quantity<double, Millicandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekacandela to Microcandela
    /// </summary>
    /// <param name="val">quantity measured in Dekacandela</param>
    /// <returns>quantity measured in Microcandela</returns>
	public static Quantity<double, Microcandela> ToMicrocandela<T>(this Quantity<T, Dekacandela> val) where T:IConvertible {
        return new Quantity<double, Microcandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekacandela to Nanocandela
    /// </summary>
    /// <param name="val">quantity measured in Dekacandela</param>
    /// <returns>quantity measured in Nanocandela</returns>
	public static Quantity<double, Nanocandela> ToNanocandela<T>(this Quantity<T, Dekacandela> val) where T:IConvertible {
        return new Quantity<double, Nanocandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekacandela to Picocandela
    /// </summary>
    /// <param name="val">quantity measured in Dekacandela</param>
    /// <returns>quantity measured in Picocandela</returns>
	public static Quantity<double, Picocandela> ToPicocandela<T>(this Quantity<T, Dekacandela> val) where T:IConvertible {
        return new Quantity<double, Picocandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekacandela to Femtocandela
    /// </summary>
    /// <param name="val">quantity measured in Dekacandela</param>
    /// <returns>quantity measured in Femtocandela</returns>
	public static Quantity<double, Femtocandela> ToFemtocandela<T>(this Quantity<T, Dekacandela> val) where T:IConvertible {
        return new Quantity<double, Femtocandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekacandela to Attocandela
    /// </summary>
    /// <param name="val">quantity measured in Dekacandela</param>
    /// <returns>quantity measured in Attocandela</returns>
	public static Quantity<double, Attocandela> ToAttocandela<T>(this Quantity<T, Dekacandela> val) where T:IConvertible {
        return new Quantity<double, Attocandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekacandela to Zeptocandela
    /// </summary>
    /// <param name="val">quantity measured in Dekacandela</param>
    /// <returns>quantity measured in Zeptocandela</returns>
	public static Quantity<double, Zeptocandela> ToZeptocandela<T>(this Quantity<T, Dekacandela> val) where T:IConvertible {
        return new Quantity<double, Zeptocandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Dekacandela to Yoctocandela
    /// </summary>
    /// <param name="val">quantity measured in Dekacandela</param>
    /// <returns>quantity measured in Yoctocandela</returns>
	public static Quantity<double, Yoctocandela> ToYoctocandela<T>(this Quantity<T, Dekacandela> val) where T:IConvertible {
        return new Quantity<double, Yoctocandela>(
            Convert.ToDouble(val.Value) * 1E-1
        );
    }
	/// <summary>
    /// Extension method to convert Decicandela to Yottacandela
    /// </summary>
    /// <param name="val">quantity measured in Decicandela</param>
    /// <returns>quantity measured in Yottacandela</returns>
	public static Quantity<double, Yottacandela> ToYottacandela<T>(this Quantity<T, Decicandela> val) where T:IConvertible {
        return new Quantity<double, Yottacandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decicandela to Zettacandela
    /// </summary>
    /// <param name="val">quantity measured in Decicandela</param>
    /// <returns>quantity measured in Zettacandela</returns>
	public static Quantity<double, Zettacandela> ToZettacandela<T>(this Quantity<T, Decicandela> val) where T:IConvertible {
        return new Quantity<double, Zettacandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decicandela to Exacandela
    /// </summary>
    /// <param name="val">quantity measured in Decicandela</param>
    /// <returns>quantity measured in Exacandela</returns>
	public static Quantity<double, Exacandela> ToExacandela<T>(this Quantity<T, Decicandela> val) where T:IConvertible {
        return new Quantity<double, Exacandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decicandela to Petacandela
    /// </summary>
    /// <param name="val">quantity measured in Decicandela</param>
    /// <returns>quantity measured in Petacandela</returns>
	public static Quantity<double, Petacandela> ToPetacandela<T>(this Quantity<T, Decicandela> val) where T:IConvertible {
        return new Quantity<double, Petacandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decicandela to Teracandela
    /// </summary>
    /// <param name="val">quantity measured in Decicandela</param>
    /// <returns>quantity measured in Teracandela</returns>
	public static Quantity<double, Teracandela> ToTeracandela<T>(this Quantity<T, Decicandela> val) where T:IConvertible {
        return new Quantity<double, Teracandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decicandela to Gigacandela
    /// </summary>
    /// <param name="val">quantity measured in Decicandela</param>
    /// <returns>quantity measured in Gigacandela</returns>
	public static Quantity<double, Gigacandela> ToGigacandela<T>(this Quantity<T, Decicandela> val) where T:IConvertible {
        return new Quantity<double, Gigacandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decicandela to Megacandela
    /// </summary>
    /// <param name="val">quantity measured in Decicandela</param>
    /// <returns>quantity measured in Megacandela</returns>
	public static Quantity<double, Megacandela> ToMegacandela<T>(this Quantity<T, Decicandela> val) where T:IConvertible {
        return new Quantity<double, Megacandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decicandela to Kilocandela
    /// </summary>
    /// <param name="val">quantity measured in Decicandela</param>
    /// <returns>quantity measured in Kilocandela</returns>
	public static Quantity<double, Kilocandela> ToKilocandela<T>(this Quantity<T, Decicandela> val) where T:IConvertible {
        return new Quantity<double, Kilocandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decicandela to Hectocandela
    /// </summary>
    /// <param name="val">quantity measured in Decicandela</param>
    /// <returns>quantity measured in Hectocandela</returns>
	public static Quantity<double, Hectocandela> ToHectocandela<T>(this Quantity<T, Decicandela> val) where T:IConvertible {
        return new Quantity<double, Hectocandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decicandela to Dekacandela
    /// </summary>
    /// <param name="val">quantity measured in Decicandela</param>
    /// <returns>quantity measured in Dekacandela</returns>
	public static Quantity<double, Dekacandela> ToDekacandela<T>(this Quantity<T, Decicandela> val) where T:IConvertible {
        return new Quantity<double, Dekacandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decicandela to Centicandela
    /// </summary>
    /// <param name="val">quantity measured in Decicandela</param>
    /// <returns>quantity measured in Centicandela</returns>
	public static Quantity<double, Centicandela> ToCenticandela<T>(this Quantity<T, Decicandela> val) where T:IConvertible {
        return new Quantity<double, Centicandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decicandela to Millicandela
    /// </summary>
    /// <param name="val">quantity measured in Decicandela</param>
    /// <returns>quantity measured in Millicandela</returns>
	public static Quantity<double, Millicandela> ToMillicandela<T>(this Quantity<T, Decicandela> val) where T:IConvertible {
        return new Quantity<double, Millicandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decicandela to Microcandela
    /// </summary>
    /// <param name="val">quantity measured in Decicandela</param>
    /// <returns>quantity measured in Microcandela</returns>
	public static Quantity<double, Microcandela> ToMicrocandela<T>(this Quantity<T, Decicandela> val) where T:IConvertible {
        return new Quantity<double, Microcandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decicandela to Nanocandela
    /// </summary>
    /// <param name="val">quantity measured in Decicandela</param>
    /// <returns>quantity measured in Nanocandela</returns>
	public static Quantity<double, Nanocandela> ToNanocandela<T>(this Quantity<T, Decicandela> val) where T:IConvertible {
        return new Quantity<double, Nanocandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decicandela to Picocandela
    /// </summary>
    /// <param name="val">quantity measured in Decicandela</param>
    /// <returns>quantity measured in Picocandela</returns>
	public static Quantity<double, Picocandela> ToPicocandela<T>(this Quantity<T, Decicandela> val) where T:IConvertible {
        return new Quantity<double, Picocandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decicandela to Femtocandela
    /// </summary>
    /// <param name="val">quantity measured in Decicandela</param>
    /// <returns>quantity measured in Femtocandela</returns>
	public static Quantity<double, Femtocandela> ToFemtocandela<T>(this Quantity<T, Decicandela> val) where T:IConvertible {
        return new Quantity<double, Femtocandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decicandela to Attocandela
    /// </summary>
    /// <param name="val">quantity measured in Decicandela</param>
    /// <returns>quantity measured in Attocandela</returns>
	public static Quantity<double, Attocandela> ToAttocandela<T>(this Quantity<T, Decicandela> val) where T:IConvertible {
        return new Quantity<double, Attocandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decicandela to Zeptocandela
    /// </summary>
    /// <param name="val">quantity measured in Decicandela</param>
    /// <returns>quantity measured in Zeptocandela</returns>
	public static Quantity<double, Zeptocandela> ToZeptocandela<T>(this Quantity<T, Decicandela> val) where T:IConvertible {
        return new Quantity<double, Zeptocandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Decicandela to Yoctocandela
    /// </summary>
    /// <param name="val">quantity measured in Decicandela</param>
    /// <returns>quantity measured in Yoctocandela</returns>
	public static Quantity<double, Yoctocandela> ToYoctocandela<T>(this Quantity<T, Decicandela> val) where T:IConvertible {
        return new Quantity<double, Yoctocandela>(
            Convert.ToDouble(val.Value) * 1E1
        );
    }
	/// <summary>
    /// Extension method to convert Centicandela to Yottacandela
    /// </summary>
    /// <param name="val">quantity measured in Centicandela</param>
    /// <returns>quantity measured in Yottacandela</returns>
	public static Quantity<double, Yottacandela> ToYottacandela<T>(this Quantity<T, Centicandela> val) where T:IConvertible {
        return new Quantity<double, Yottacandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centicandela to Zettacandela
    /// </summary>
    /// <param name="val">quantity measured in Centicandela</param>
    /// <returns>quantity measured in Zettacandela</returns>
	public static Quantity<double, Zettacandela> ToZettacandela<T>(this Quantity<T, Centicandela> val) where T:IConvertible {
        return new Quantity<double, Zettacandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centicandela to Exacandela
    /// </summary>
    /// <param name="val">quantity measured in Centicandela</param>
    /// <returns>quantity measured in Exacandela</returns>
	public static Quantity<double, Exacandela> ToExacandela<T>(this Quantity<T, Centicandela> val) where T:IConvertible {
        return new Quantity<double, Exacandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centicandela to Petacandela
    /// </summary>
    /// <param name="val">quantity measured in Centicandela</param>
    /// <returns>quantity measured in Petacandela</returns>
	public static Quantity<double, Petacandela> ToPetacandela<T>(this Quantity<T, Centicandela> val) where T:IConvertible {
        return new Quantity<double, Petacandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centicandela to Teracandela
    /// </summary>
    /// <param name="val">quantity measured in Centicandela</param>
    /// <returns>quantity measured in Teracandela</returns>
	public static Quantity<double, Teracandela> ToTeracandela<T>(this Quantity<T, Centicandela> val) where T:IConvertible {
        return new Quantity<double, Teracandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centicandela to Gigacandela
    /// </summary>
    /// <param name="val">quantity measured in Centicandela</param>
    /// <returns>quantity measured in Gigacandela</returns>
	public static Quantity<double, Gigacandela> ToGigacandela<T>(this Quantity<T, Centicandela> val) where T:IConvertible {
        return new Quantity<double, Gigacandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centicandela to Megacandela
    /// </summary>
    /// <param name="val">quantity measured in Centicandela</param>
    /// <returns>quantity measured in Megacandela</returns>
	public static Quantity<double, Megacandela> ToMegacandela<T>(this Quantity<T, Centicandela> val) where T:IConvertible {
        return new Quantity<double, Megacandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centicandela to Kilocandela
    /// </summary>
    /// <param name="val">quantity measured in Centicandela</param>
    /// <returns>quantity measured in Kilocandela</returns>
	public static Quantity<double, Kilocandela> ToKilocandela<T>(this Quantity<T, Centicandela> val) where T:IConvertible {
        return new Quantity<double, Kilocandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centicandela to Hectocandela
    /// </summary>
    /// <param name="val">quantity measured in Centicandela</param>
    /// <returns>quantity measured in Hectocandela</returns>
	public static Quantity<double, Hectocandela> ToHectocandela<T>(this Quantity<T, Centicandela> val) where T:IConvertible {
        return new Quantity<double, Hectocandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centicandela to Dekacandela
    /// </summary>
    /// <param name="val">quantity measured in Centicandela</param>
    /// <returns>quantity measured in Dekacandela</returns>
	public static Quantity<double, Dekacandela> ToDekacandela<T>(this Quantity<T, Centicandela> val) where T:IConvertible {
        return new Quantity<double, Dekacandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centicandela to Decicandela
    /// </summary>
    /// <param name="val">quantity measured in Centicandela</param>
    /// <returns>quantity measured in Decicandela</returns>
	public static Quantity<double, Decicandela> ToDecicandela<T>(this Quantity<T, Centicandela> val) where T:IConvertible {
        return new Quantity<double, Decicandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centicandela to Millicandela
    /// </summary>
    /// <param name="val">quantity measured in Centicandela</param>
    /// <returns>quantity measured in Millicandela</returns>
	public static Quantity<double, Millicandela> ToMillicandela<T>(this Quantity<T, Centicandela> val) where T:IConvertible {
        return new Quantity<double, Millicandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centicandela to Microcandela
    /// </summary>
    /// <param name="val">quantity measured in Centicandela</param>
    /// <returns>quantity measured in Microcandela</returns>
	public static Quantity<double, Microcandela> ToMicrocandela<T>(this Quantity<T, Centicandela> val) where T:IConvertible {
        return new Quantity<double, Microcandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centicandela to Nanocandela
    /// </summary>
    /// <param name="val">quantity measured in Centicandela</param>
    /// <returns>quantity measured in Nanocandela</returns>
	public static Quantity<double, Nanocandela> ToNanocandela<T>(this Quantity<T, Centicandela> val) where T:IConvertible {
        return new Quantity<double, Nanocandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centicandela to Picocandela
    /// </summary>
    /// <param name="val">quantity measured in Centicandela</param>
    /// <returns>quantity measured in Picocandela</returns>
	public static Quantity<double, Picocandela> ToPicocandela<T>(this Quantity<T, Centicandela> val) where T:IConvertible {
        return new Quantity<double, Picocandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centicandela to Femtocandela
    /// </summary>
    /// <param name="val">quantity measured in Centicandela</param>
    /// <returns>quantity measured in Femtocandela</returns>
	public static Quantity<double, Femtocandela> ToFemtocandela<T>(this Quantity<T, Centicandela> val) where T:IConvertible {
        return new Quantity<double, Femtocandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centicandela to Attocandela
    /// </summary>
    /// <param name="val">quantity measured in Centicandela</param>
    /// <returns>quantity measured in Attocandela</returns>
	public static Quantity<double, Attocandela> ToAttocandela<T>(this Quantity<T, Centicandela> val) where T:IConvertible {
        return new Quantity<double, Attocandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centicandela to Zeptocandela
    /// </summary>
    /// <param name="val">quantity measured in Centicandela</param>
    /// <returns>quantity measured in Zeptocandela</returns>
	public static Quantity<double, Zeptocandela> ToZeptocandela<T>(this Quantity<T, Centicandela> val) where T:IConvertible {
        return new Quantity<double, Zeptocandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Centicandela to Yoctocandela
    /// </summary>
    /// <param name="val">quantity measured in Centicandela</param>
    /// <returns>quantity measured in Yoctocandela</returns>
	public static Quantity<double, Yoctocandela> ToYoctocandela<T>(this Quantity<T, Centicandela> val) where T:IConvertible {
        return new Quantity<double, Yoctocandela>(
            Convert.ToDouble(val.Value) * 1E2
        );
    }
	/// <summary>
    /// Extension method to convert Millicandela to Yottacandela
    /// </summary>
    /// <param name="val">quantity measured in Millicandela</param>
    /// <returns>quantity measured in Yottacandela</returns>
	public static Quantity<double, Yottacandela> ToYottacandela<T>(this Quantity<T, Millicandela> val) where T:IConvertible {
        return new Quantity<double, Yottacandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Millicandela to Zettacandela
    /// </summary>
    /// <param name="val">quantity measured in Millicandela</param>
    /// <returns>quantity measured in Zettacandela</returns>
	public static Quantity<double, Zettacandela> ToZettacandela<T>(this Quantity<T, Millicandela> val) where T:IConvertible {
        return new Quantity<double, Zettacandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Millicandela to Exacandela
    /// </summary>
    /// <param name="val">quantity measured in Millicandela</param>
    /// <returns>quantity measured in Exacandela</returns>
	public static Quantity<double, Exacandela> ToExacandela<T>(this Quantity<T, Millicandela> val) where T:IConvertible {
        return new Quantity<double, Exacandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Millicandela to Petacandela
    /// </summary>
    /// <param name="val">quantity measured in Millicandela</param>
    /// <returns>quantity measured in Petacandela</returns>
	public static Quantity<double, Petacandela> ToPetacandela<T>(this Quantity<T, Millicandela> val) where T:IConvertible {
        return new Quantity<double, Petacandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Millicandela to Teracandela
    /// </summary>
    /// <param name="val">quantity measured in Millicandela</param>
    /// <returns>quantity measured in Teracandela</returns>
	public static Quantity<double, Teracandela> ToTeracandela<T>(this Quantity<T, Millicandela> val) where T:IConvertible {
        return new Quantity<double, Teracandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Millicandela to Gigacandela
    /// </summary>
    /// <param name="val">quantity measured in Millicandela</param>
    /// <returns>quantity measured in Gigacandela</returns>
	public static Quantity<double, Gigacandela> ToGigacandela<T>(this Quantity<T, Millicandela> val) where T:IConvertible {
        return new Quantity<double, Gigacandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Millicandela to Megacandela
    /// </summary>
    /// <param name="val">quantity measured in Millicandela</param>
    /// <returns>quantity measured in Megacandela</returns>
	public static Quantity<double, Megacandela> ToMegacandela<T>(this Quantity<T, Millicandela> val) where T:IConvertible {
        return new Quantity<double, Megacandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Millicandela to Kilocandela
    /// </summary>
    /// <param name="val">quantity measured in Millicandela</param>
    /// <returns>quantity measured in Kilocandela</returns>
	public static Quantity<double, Kilocandela> ToKilocandela<T>(this Quantity<T, Millicandela> val) where T:IConvertible {
        return new Quantity<double, Kilocandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Millicandela to Hectocandela
    /// </summary>
    /// <param name="val">quantity measured in Millicandela</param>
    /// <returns>quantity measured in Hectocandela</returns>
	public static Quantity<double, Hectocandela> ToHectocandela<T>(this Quantity<T, Millicandela> val) where T:IConvertible {
        return new Quantity<double, Hectocandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Millicandela to Dekacandela
    /// </summary>
    /// <param name="val">quantity measured in Millicandela</param>
    /// <returns>quantity measured in Dekacandela</returns>
	public static Quantity<double, Dekacandela> ToDekacandela<T>(this Quantity<T, Millicandela> val) where T:IConvertible {
        return new Quantity<double, Dekacandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Millicandela to Decicandela
    /// </summary>
    /// <param name="val">quantity measured in Millicandela</param>
    /// <returns>quantity measured in Decicandela</returns>
	public static Quantity<double, Decicandela> ToDecicandela<T>(this Quantity<T, Millicandela> val) where T:IConvertible {
        return new Quantity<double, Decicandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Millicandela to Centicandela
    /// </summary>
    /// <param name="val">quantity measured in Millicandela</param>
    /// <returns>quantity measured in Centicandela</returns>
	public static Quantity<double, Centicandela> ToCenticandela<T>(this Quantity<T, Millicandela> val) where T:IConvertible {
        return new Quantity<double, Centicandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Millicandela to Microcandela
    /// </summary>
    /// <param name="val">quantity measured in Millicandela</param>
    /// <returns>quantity measured in Microcandela</returns>
	public static Quantity<double, Microcandela> ToMicrocandela<T>(this Quantity<T, Millicandela> val) where T:IConvertible {
        return new Quantity<double, Microcandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Millicandela to Nanocandela
    /// </summary>
    /// <param name="val">quantity measured in Millicandela</param>
    /// <returns>quantity measured in Nanocandela</returns>
	public static Quantity<double, Nanocandela> ToNanocandela<T>(this Quantity<T, Millicandela> val) where T:IConvertible {
        return new Quantity<double, Nanocandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Millicandela to Picocandela
    /// </summary>
    /// <param name="val">quantity measured in Millicandela</param>
    /// <returns>quantity measured in Picocandela</returns>
	public static Quantity<double, Picocandela> ToPicocandela<T>(this Quantity<T, Millicandela> val) where T:IConvertible {
        return new Quantity<double, Picocandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Millicandela to Femtocandela
    /// </summary>
    /// <param name="val">quantity measured in Millicandela</param>
    /// <returns>quantity measured in Femtocandela</returns>
	public static Quantity<double, Femtocandela> ToFemtocandela<T>(this Quantity<T, Millicandela> val) where T:IConvertible {
        return new Quantity<double, Femtocandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Millicandela to Attocandela
    /// </summary>
    /// <param name="val">quantity measured in Millicandela</param>
    /// <returns>quantity measured in Attocandela</returns>
	public static Quantity<double, Attocandela> ToAttocandela<T>(this Quantity<T, Millicandela> val) where T:IConvertible {
        return new Quantity<double, Attocandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Millicandela to Zeptocandela
    /// </summary>
    /// <param name="val">quantity measured in Millicandela</param>
    /// <returns>quantity measured in Zeptocandela</returns>
	public static Quantity<double, Zeptocandela> ToZeptocandela<T>(this Quantity<T, Millicandela> val) where T:IConvertible {
        return new Quantity<double, Zeptocandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Millicandela to Yoctocandela
    /// </summary>
    /// <param name="val">quantity measured in Millicandela</param>
    /// <returns>quantity measured in Yoctocandela</returns>
	public static Quantity<double, Yoctocandela> ToYoctocandela<T>(this Quantity<T, Millicandela> val) where T:IConvertible {
        return new Quantity<double, Yoctocandela>(
            Convert.ToDouble(val.Value) * 1E3
        );
    }
	/// <summary>
    /// Extension method to convert Microcandela to Yottacandela
    /// </summary>
    /// <param name="val">quantity measured in Microcandela</param>
    /// <returns>quantity measured in Yottacandela</returns>
	public static Quantity<double, Yottacandela> ToYottacandela<T>(this Quantity<T, Microcandela> val) where T:IConvertible {
        return new Quantity<double, Yottacandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microcandela to Zettacandela
    /// </summary>
    /// <param name="val">quantity measured in Microcandela</param>
    /// <returns>quantity measured in Zettacandela</returns>
	public static Quantity<double, Zettacandela> ToZettacandela<T>(this Quantity<T, Microcandela> val) where T:IConvertible {
        return new Quantity<double, Zettacandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microcandela to Exacandela
    /// </summary>
    /// <param name="val">quantity measured in Microcandela</param>
    /// <returns>quantity measured in Exacandela</returns>
	public static Quantity<double, Exacandela> ToExacandela<T>(this Quantity<T, Microcandela> val) where T:IConvertible {
        return new Quantity<double, Exacandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microcandela to Petacandela
    /// </summary>
    /// <param name="val">quantity measured in Microcandela</param>
    /// <returns>quantity measured in Petacandela</returns>
	public static Quantity<double, Petacandela> ToPetacandela<T>(this Quantity<T, Microcandela> val) where T:IConvertible {
        return new Quantity<double, Petacandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microcandela to Teracandela
    /// </summary>
    /// <param name="val">quantity measured in Microcandela</param>
    /// <returns>quantity measured in Teracandela</returns>
	public static Quantity<double, Teracandela> ToTeracandela<T>(this Quantity<T, Microcandela> val) where T:IConvertible {
        return new Quantity<double, Teracandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microcandela to Gigacandela
    /// </summary>
    /// <param name="val">quantity measured in Microcandela</param>
    /// <returns>quantity measured in Gigacandela</returns>
	public static Quantity<double, Gigacandela> ToGigacandela<T>(this Quantity<T, Microcandela> val) where T:IConvertible {
        return new Quantity<double, Gigacandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microcandela to Megacandela
    /// </summary>
    /// <param name="val">quantity measured in Microcandela</param>
    /// <returns>quantity measured in Megacandela</returns>
	public static Quantity<double, Megacandela> ToMegacandela<T>(this Quantity<T, Microcandela> val) where T:IConvertible {
        return new Quantity<double, Megacandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microcandela to Kilocandela
    /// </summary>
    /// <param name="val">quantity measured in Microcandela</param>
    /// <returns>quantity measured in Kilocandela</returns>
	public static Quantity<double, Kilocandela> ToKilocandela<T>(this Quantity<T, Microcandela> val) where T:IConvertible {
        return new Quantity<double, Kilocandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microcandela to Hectocandela
    /// </summary>
    /// <param name="val">quantity measured in Microcandela</param>
    /// <returns>quantity measured in Hectocandela</returns>
	public static Quantity<double, Hectocandela> ToHectocandela<T>(this Quantity<T, Microcandela> val) where T:IConvertible {
        return new Quantity<double, Hectocandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microcandela to Dekacandela
    /// </summary>
    /// <param name="val">quantity measured in Microcandela</param>
    /// <returns>quantity measured in Dekacandela</returns>
	public static Quantity<double, Dekacandela> ToDekacandela<T>(this Quantity<T, Microcandela> val) where T:IConvertible {
        return new Quantity<double, Dekacandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microcandela to Decicandela
    /// </summary>
    /// <param name="val">quantity measured in Microcandela</param>
    /// <returns>quantity measured in Decicandela</returns>
	public static Quantity<double, Decicandela> ToDecicandela<T>(this Quantity<T, Microcandela> val) where T:IConvertible {
        return new Quantity<double, Decicandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microcandela to Centicandela
    /// </summary>
    /// <param name="val">quantity measured in Microcandela</param>
    /// <returns>quantity measured in Centicandela</returns>
	public static Quantity<double, Centicandela> ToCenticandela<T>(this Quantity<T, Microcandela> val) where T:IConvertible {
        return new Quantity<double, Centicandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microcandela to Millicandela
    /// </summary>
    /// <param name="val">quantity measured in Microcandela</param>
    /// <returns>quantity measured in Millicandela</returns>
	public static Quantity<double, Millicandela> ToMillicandela<T>(this Quantity<T, Microcandela> val) where T:IConvertible {
        return new Quantity<double, Millicandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microcandela to Nanocandela
    /// </summary>
    /// <param name="val">quantity measured in Microcandela</param>
    /// <returns>quantity measured in Nanocandela</returns>
	public static Quantity<double, Nanocandela> ToNanocandela<T>(this Quantity<T, Microcandela> val) where T:IConvertible {
        return new Quantity<double, Nanocandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microcandela to Picocandela
    /// </summary>
    /// <param name="val">quantity measured in Microcandela</param>
    /// <returns>quantity measured in Picocandela</returns>
	public static Quantity<double, Picocandela> ToPicocandela<T>(this Quantity<T, Microcandela> val) where T:IConvertible {
        return new Quantity<double, Picocandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microcandela to Femtocandela
    /// </summary>
    /// <param name="val">quantity measured in Microcandela</param>
    /// <returns>quantity measured in Femtocandela</returns>
	public static Quantity<double, Femtocandela> ToFemtocandela<T>(this Quantity<T, Microcandela> val) where T:IConvertible {
        return new Quantity<double, Femtocandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microcandela to Attocandela
    /// </summary>
    /// <param name="val">quantity measured in Microcandela</param>
    /// <returns>quantity measured in Attocandela</returns>
	public static Quantity<double, Attocandela> ToAttocandela<T>(this Quantity<T, Microcandela> val) where T:IConvertible {
        return new Quantity<double, Attocandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microcandela to Zeptocandela
    /// </summary>
    /// <param name="val">quantity measured in Microcandela</param>
    /// <returns>quantity measured in Zeptocandela</returns>
	public static Quantity<double, Zeptocandela> ToZeptocandela<T>(this Quantity<T, Microcandela> val) where T:IConvertible {
        return new Quantity<double, Zeptocandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Microcandela to Yoctocandela
    /// </summary>
    /// <param name="val">quantity measured in Microcandela</param>
    /// <returns>quantity measured in Yoctocandela</returns>
	public static Quantity<double, Yoctocandela> ToYoctocandela<T>(this Quantity<T, Microcandela> val) where T:IConvertible {
        return new Quantity<double, Yoctocandela>(
            Convert.ToDouble(val.Value) * 1E6
        );
    }
	/// <summary>
    /// Extension method to convert Nanocandela to Yottacandela
    /// </summary>
    /// <param name="val">quantity measured in Nanocandela</param>
    /// <returns>quantity measured in Yottacandela</returns>
	public static Quantity<double, Yottacandela> ToYottacandela<T>(this Quantity<T, Nanocandela> val) where T:IConvertible {
        return new Quantity<double, Yottacandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanocandela to Zettacandela
    /// </summary>
    /// <param name="val">quantity measured in Nanocandela</param>
    /// <returns>quantity measured in Zettacandela</returns>
	public static Quantity<double, Zettacandela> ToZettacandela<T>(this Quantity<T, Nanocandela> val) where T:IConvertible {
        return new Quantity<double, Zettacandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanocandela to Exacandela
    /// </summary>
    /// <param name="val">quantity measured in Nanocandela</param>
    /// <returns>quantity measured in Exacandela</returns>
	public static Quantity<double, Exacandela> ToExacandela<T>(this Quantity<T, Nanocandela> val) where T:IConvertible {
        return new Quantity<double, Exacandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanocandela to Petacandela
    /// </summary>
    /// <param name="val">quantity measured in Nanocandela</param>
    /// <returns>quantity measured in Petacandela</returns>
	public static Quantity<double, Petacandela> ToPetacandela<T>(this Quantity<T, Nanocandela> val) where T:IConvertible {
        return new Quantity<double, Petacandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanocandela to Teracandela
    /// </summary>
    /// <param name="val">quantity measured in Nanocandela</param>
    /// <returns>quantity measured in Teracandela</returns>
	public static Quantity<double, Teracandela> ToTeracandela<T>(this Quantity<T, Nanocandela> val) where T:IConvertible {
        return new Quantity<double, Teracandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanocandela to Gigacandela
    /// </summary>
    /// <param name="val">quantity measured in Nanocandela</param>
    /// <returns>quantity measured in Gigacandela</returns>
	public static Quantity<double, Gigacandela> ToGigacandela<T>(this Quantity<T, Nanocandela> val) where T:IConvertible {
        return new Quantity<double, Gigacandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanocandela to Megacandela
    /// </summary>
    /// <param name="val">quantity measured in Nanocandela</param>
    /// <returns>quantity measured in Megacandela</returns>
	public static Quantity<double, Megacandela> ToMegacandela<T>(this Quantity<T, Nanocandela> val) where T:IConvertible {
        return new Quantity<double, Megacandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanocandela to Kilocandela
    /// </summary>
    /// <param name="val">quantity measured in Nanocandela</param>
    /// <returns>quantity measured in Kilocandela</returns>
	public static Quantity<double, Kilocandela> ToKilocandela<T>(this Quantity<T, Nanocandela> val) where T:IConvertible {
        return new Quantity<double, Kilocandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanocandela to Hectocandela
    /// </summary>
    /// <param name="val">quantity measured in Nanocandela</param>
    /// <returns>quantity measured in Hectocandela</returns>
	public static Quantity<double, Hectocandela> ToHectocandela<T>(this Quantity<T, Nanocandela> val) where T:IConvertible {
        return new Quantity<double, Hectocandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanocandela to Dekacandela
    /// </summary>
    /// <param name="val">quantity measured in Nanocandela</param>
    /// <returns>quantity measured in Dekacandela</returns>
	public static Quantity<double, Dekacandela> ToDekacandela<T>(this Quantity<T, Nanocandela> val) where T:IConvertible {
        return new Quantity<double, Dekacandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanocandela to Decicandela
    /// </summary>
    /// <param name="val">quantity measured in Nanocandela</param>
    /// <returns>quantity measured in Decicandela</returns>
	public static Quantity<double, Decicandela> ToDecicandela<T>(this Quantity<T, Nanocandela> val) where T:IConvertible {
        return new Quantity<double, Decicandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanocandela to Centicandela
    /// </summary>
    /// <param name="val">quantity measured in Nanocandela</param>
    /// <returns>quantity measured in Centicandela</returns>
	public static Quantity<double, Centicandela> ToCenticandela<T>(this Quantity<T, Nanocandela> val) where T:IConvertible {
        return new Quantity<double, Centicandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanocandela to Millicandela
    /// </summary>
    /// <param name="val">quantity measured in Nanocandela</param>
    /// <returns>quantity measured in Millicandela</returns>
	public static Quantity<double, Millicandela> ToMillicandela<T>(this Quantity<T, Nanocandela> val) where T:IConvertible {
        return new Quantity<double, Millicandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanocandela to Microcandela
    /// </summary>
    /// <param name="val">quantity measured in Nanocandela</param>
    /// <returns>quantity measured in Microcandela</returns>
	public static Quantity<double, Microcandela> ToMicrocandela<T>(this Quantity<T, Nanocandela> val) where T:IConvertible {
        return new Quantity<double, Microcandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanocandela to Picocandela
    /// </summary>
    /// <param name="val">quantity measured in Nanocandela</param>
    /// <returns>quantity measured in Picocandela</returns>
	public static Quantity<double, Picocandela> ToPicocandela<T>(this Quantity<T, Nanocandela> val) where T:IConvertible {
        return new Quantity<double, Picocandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanocandela to Femtocandela
    /// </summary>
    /// <param name="val">quantity measured in Nanocandela</param>
    /// <returns>quantity measured in Femtocandela</returns>
	public static Quantity<double, Femtocandela> ToFemtocandela<T>(this Quantity<T, Nanocandela> val) where T:IConvertible {
        return new Quantity<double, Femtocandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanocandela to Attocandela
    /// </summary>
    /// <param name="val">quantity measured in Nanocandela</param>
    /// <returns>quantity measured in Attocandela</returns>
	public static Quantity<double, Attocandela> ToAttocandela<T>(this Quantity<T, Nanocandela> val) where T:IConvertible {
        return new Quantity<double, Attocandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanocandela to Zeptocandela
    /// </summary>
    /// <param name="val">quantity measured in Nanocandela</param>
    /// <returns>quantity measured in Zeptocandela</returns>
	public static Quantity<double, Zeptocandela> ToZeptocandela<T>(this Quantity<T, Nanocandela> val) where T:IConvertible {
        return new Quantity<double, Zeptocandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Nanocandela to Yoctocandela
    /// </summary>
    /// <param name="val">quantity measured in Nanocandela</param>
    /// <returns>quantity measured in Yoctocandela</returns>
	public static Quantity<double, Yoctocandela> ToYoctocandela<T>(this Quantity<T, Nanocandela> val) where T:IConvertible {
        return new Quantity<double, Yoctocandela>(
            Convert.ToDouble(val.Value) * 1E9
        );
    }
	/// <summary>
    /// Extension method to convert Picocandela to Yottacandela
    /// </summary>
    /// <param name="val">quantity measured in Picocandela</param>
    /// <returns>quantity measured in Yottacandela</returns>
	public static Quantity<double, Yottacandela> ToYottacandela<T>(this Quantity<T, Picocandela> val) where T:IConvertible {
        return new Quantity<double, Yottacandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picocandela to Zettacandela
    /// </summary>
    /// <param name="val">quantity measured in Picocandela</param>
    /// <returns>quantity measured in Zettacandela</returns>
	public static Quantity<double, Zettacandela> ToZettacandela<T>(this Quantity<T, Picocandela> val) where T:IConvertible {
        return new Quantity<double, Zettacandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picocandela to Exacandela
    /// </summary>
    /// <param name="val">quantity measured in Picocandela</param>
    /// <returns>quantity measured in Exacandela</returns>
	public static Quantity<double, Exacandela> ToExacandela<T>(this Quantity<T, Picocandela> val) where T:IConvertible {
        return new Quantity<double, Exacandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picocandela to Petacandela
    /// </summary>
    /// <param name="val">quantity measured in Picocandela</param>
    /// <returns>quantity measured in Petacandela</returns>
	public static Quantity<double, Petacandela> ToPetacandela<T>(this Quantity<T, Picocandela> val) where T:IConvertible {
        return new Quantity<double, Petacandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picocandela to Teracandela
    /// </summary>
    /// <param name="val">quantity measured in Picocandela</param>
    /// <returns>quantity measured in Teracandela</returns>
	public static Quantity<double, Teracandela> ToTeracandela<T>(this Quantity<T, Picocandela> val) where T:IConvertible {
        return new Quantity<double, Teracandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picocandela to Gigacandela
    /// </summary>
    /// <param name="val">quantity measured in Picocandela</param>
    /// <returns>quantity measured in Gigacandela</returns>
	public static Quantity<double, Gigacandela> ToGigacandela<T>(this Quantity<T, Picocandela> val) where T:IConvertible {
        return new Quantity<double, Gigacandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picocandela to Megacandela
    /// </summary>
    /// <param name="val">quantity measured in Picocandela</param>
    /// <returns>quantity measured in Megacandela</returns>
	public static Quantity<double, Megacandela> ToMegacandela<T>(this Quantity<T, Picocandela> val) where T:IConvertible {
        return new Quantity<double, Megacandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picocandela to Kilocandela
    /// </summary>
    /// <param name="val">quantity measured in Picocandela</param>
    /// <returns>quantity measured in Kilocandela</returns>
	public static Quantity<double, Kilocandela> ToKilocandela<T>(this Quantity<T, Picocandela> val) where T:IConvertible {
        return new Quantity<double, Kilocandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picocandela to Hectocandela
    /// </summary>
    /// <param name="val">quantity measured in Picocandela</param>
    /// <returns>quantity measured in Hectocandela</returns>
	public static Quantity<double, Hectocandela> ToHectocandela<T>(this Quantity<T, Picocandela> val) where T:IConvertible {
        return new Quantity<double, Hectocandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picocandela to Dekacandela
    /// </summary>
    /// <param name="val">quantity measured in Picocandela</param>
    /// <returns>quantity measured in Dekacandela</returns>
	public static Quantity<double, Dekacandela> ToDekacandela<T>(this Quantity<T, Picocandela> val) where T:IConvertible {
        return new Quantity<double, Dekacandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picocandela to Decicandela
    /// </summary>
    /// <param name="val">quantity measured in Picocandela</param>
    /// <returns>quantity measured in Decicandela</returns>
	public static Quantity<double, Decicandela> ToDecicandela<T>(this Quantity<T, Picocandela> val) where T:IConvertible {
        return new Quantity<double, Decicandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picocandela to Centicandela
    /// </summary>
    /// <param name="val">quantity measured in Picocandela</param>
    /// <returns>quantity measured in Centicandela</returns>
	public static Quantity<double, Centicandela> ToCenticandela<T>(this Quantity<T, Picocandela> val) where T:IConvertible {
        return new Quantity<double, Centicandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picocandela to Millicandela
    /// </summary>
    /// <param name="val">quantity measured in Picocandela</param>
    /// <returns>quantity measured in Millicandela</returns>
	public static Quantity<double, Millicandela> ToMillicandela<T>(this Quantity<T, Picocandela> val) where T:IConvertible {
        return new Quantity<double, Millicandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picocandela to Microcandela
    /// </summary>
    /// <param name="val">quantity measured in Picocandela</param>
    /// <returns>quantity measured in Microcandela</returns>
	public static Quantity<double, Microcandela> ToMicrocandela<T>(this Quantity<T, Picocandela> val) where T:IConvertible {
        return new Quantity<double, Microcandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picocandela to Nanocandela
    /// </summary>
    /// <param name="val">quantity measured in Picocandela</param>
    /// <returns>quantity measured in Nanocandela</returns>
	public static Quantity<double, Nanocandela> ToNanocandela<T>(this Quantity<T, Picocandela> val) where T:IConvertible {
        return new Quantity<double, Nanocandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picocandela to Femtocandela
    /// </summary>
    /// <param name="val">quantity measured in Picocandela</param>
    /// <returns>quantity measured in Femtocandela</returns>
	public static Quantity<double, Femtocandela> ToFemtocandela<T>(this Quantity<T, Picocandela> val) where T:IConvertible {
        return new Quantity<double, Femtocandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picocandela to Attocandela
    /// </summary>
    /// <param name="val">quantity measured in Picocandela</param>
    /// <returns>quantity measured in Attocandela</returns>
	public static Quantity<double, Attocandela> ToAttocandela<T>(this Quantity<T, Picocandela> val) where T:IConvertible {
        return new Quantity<double, Attocandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picocandela to Zeptocandela
    /// </summary>
    /// <param name="val">quantity measured in Picocandela</param>
    /// <returns>quantity measured in Zeptocandela</returns>
	public static Quantity<double, Zeptocandela> ToZeptocandela<T>(this Quantity<T, Picocandela> val) where T:IConvertible {
        return new Quantity<double, Zeptocandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Picocandela to Yoctocandela
    /// </summary>
    /// <param name="val">quantity measured in Picocandela</param>
    /// <returns>quantity measured in Yoctocandela</returns>
	public static Quantity<double, Yoctocandela> ToYoctocandela<T>(this Quantity<T, Picocandela> val) where T:IConvertible {
        return new Quantity<double, Yoctocandela>(
            Convert.ToDouble(val.Value) * 1E12
        );
    }
	/// <summary>
    /// Extension method to convert Femtocandela to Yottacandela
    /// </summary>
    /// <param name="val">quantity measured in Femtocandela</param>
    /// <returns>quantity measured in Yottacandela</returns>
	public static Quantity<double, Yottacandela> ToYottacandela<T>(this Quantity<T, Femtocandela> val) where T:IConvertible {
        return new Quantity<double, Yottacandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtocandela to Zettacandela
    /// </summary>
    /// <param name="val">quantity measured in Femtocandela</param>
    /// <returns>quantity measured in Zettacandela</returns>
	public static Quantity<double, Zettacandela> ToZettacandela<T>(this Quantity<T, Femtocandela> val) where T:IConvertible {
        return new Quantity<double, Zettacandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtocandela to Exacandela
    /// </summary>
    /// <param name="val">quantity measured in Femtocandela</param>
    /// <returns>quantity measured in Exacandela</returns>
	public static Quantity<double, Exacandela> ToExacandela<T>(this Quantity<T, Femtocandela> val) where T:IConvertible {
        return new Quantity<double, Exacandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtocandela to Petacandela
    /// </summary>
    /// <param name="val">quantity measured in Femtocandela</param>
    /// <returns>quantity measured in Petacandela</returns>
	public static Quantity<double, Petacandela> ToPetacandela<T>(this Quantity<T, Femtocandela> val) where T:IConvertible {
        return new Quantity<double, Petacandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtocandela to Teracandela
    /// </summary>
    /// <param name="val">quantity measured in Femtocandela</param>
    /// <returns>quantity measured in Teracandela</returns>
	public static Quantity<double, Teracandela> ToTeracandela<T>(this Quantity<T, Femtocandela> val) where T:IConvertible {
        return new Quantity<double, Teracandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtocandela to Gigacandela
    /// </summary>
    /// <param name="val">quantity measured in Femtocandela</param>
    /// <returns>quantity measured in Gigacandela</returns>
	public static Quantity<double, Gigacandela> ToGigacandela<T>(this Quantity<T, Femtocandela> val) where T:IConvertible {
        return new Quantity<double, Gigacandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtocandela to Megacandela
    /// </summary>
    /// <param name="val">quantity measured in Femtocandela</param>
    /// <returns>quantity measured in Megacandela</returns>
	public static Quantity<double, Megacandela> ToMegacandela<T>(this Quantity<T, Femtocandela> val) where T:IConvertible {
        return new Quantity<double, Megacandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtocandela to Kilocandela
    /// </summary>
    /// <param name="val">quantity measured in Femtocandela</param>
    /// <returns>quantity measured in Kilocandela</returns>
	public static Quantity<double, Kilocandela> ToKilocandela<T>(this Quantity<T, Femtocandela> val) where T:IConvertible {
        return new Quantity<double, Kilocandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtocandela to Hectocandela
    /// </summary>
    /// <param name="val">quantity measured in Femtocandela</param>
    /// <returns>quantity measured in Hectocandela</returns>
	public static Quantity<double, Hectocandela> ToHectocandela<T>(this Quantity<T, Femtocandela> val) where T:IConvertible {
        return new Quantity<double, Hectocandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtocandela to Dekacandela
    /// </summary>
    /// <param name="val">quantity measured in Femtocandela</param>
    /// <returns>quantity measured in Dekacandela</returns>
	public static Quantity<double, Dekacandela> ToDekacandela<T>(this Quantity<T, Femtocandela> val) where T:IConvertible {
        return new Quantity<double, Dekacandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtocandela to Decicandela
    /// </summary>
    /// <param name="val">quantity measured in Femtocandela</param>
    /// <returns>quantity measured in Decicandela</returns>
	public static Quantity<double, Decicandela> ToDecicandela<T>(this Quantity<T, Femtocandela> val) where T:IConvertible {
        return new Quantity<double, Decicandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtocandela to Centicandela
    /// </summary>
    /// <param name="val">quantity measured in Femtocandela</param>
    /// <returns>quantity measured in Centicandela</returns>
	public static Quantity<double, Centicandela> ToCenticandela<T>(this Quantity<T, Femtocandela> val) where T:IConvertible {
        return new Quantity<double, Centicandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtocandela to Millicandela
    /// </summary>
    /// <param name="val">quantity measured in Femtocandela</param>
    /// <returns>quantity measured in Millicandela</returns>
	public static Quantity<double, Millicandela> ToMillicandela<T>(this Quantity<T, Femtocandela> val) where T:IConvertible {
        return new Quantity<double, Millicandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtocandela to Microcandela
    /// </summary>
    /// <param name="val">quantity measured in Femtocandela</param>
    /// <returns>quantity measured in Microcandela</returns>
	public static Quantity<double, Microcandela> ToMicrocandela<T>(this Quantity<T, Femtocandela> val) where T:IConvertible {
        return new Quantity<double, Microcandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtocandela to Nanocandela
    /// </summary>
    /// <param name="val">quantity measured in Femtocandela</param>
    /// <returns>quantity measured in Nanocandela</returns>
	public static Quantity<double, Nanocandela> ToNanocandela<T>(this Quantity<T, Femtocandela> val) where T:IConvertible {
        return new Quantity<double, Nanocandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtocandela to Picocandela
    /// </summary>
    /// <param name="val">quantity measured in Femtocandela</param>
    /// <returns>quantity measured in Picocandela</returns>
	public static Quantity<double, Picocandela> ToPicocandela<T>(this Quantity<T, Femtocandela> val) where T:IConvertible {
        return new Quantity<double, Picocandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtocandela to Attocandela
    /// </summary>
    /// <param name="val">quantity measured in Femtocandela</param>
    /// <returns>quantity measured in Attocandela</returns>
	public static Quantity<double, Attocandela> ToAttocandela<T>(this Quantity<T, Femtocandela> val) where T:IConvertible {
        return new Quantity<double, Attocandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtocandela to Zeptocandela
    /// </summary>
    /// <param name="val">quantity measured in Femtocandela</param>
    /// <returns>quantity measured in Zeptocandela</returns>
	public static Quantity<double, Zeptocandela> ToZeptocandela<T>(this Quantity<T, Femtocandela> val) where T:IConvertible {
        return new Quantity<double, Zeptocandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Femtocandela to Yoctocandela
    /// </summary>
    /// <param name="val">quantity measured in Femtocandela</param>
    /// <returns>quantity measured in Yoctocandela</returns>
	public static Quantity<double, Yoctocandela> ToYoctocandela<T>(this Quantity<T, Femtocandela> val) where T:IConvertible {
        return new Quantity<double, Yoctocandela>(
            Convert.ToDouble(val.Value) * 1E15
        );
    }
	/// <summary>
    /// Extension method to convert Attocandela to Yottacandela
    /// </summary>
    /// <param name="val">quantity measured in Attocandela</param>
    /// <returns>quantity measured in Yottacandela</returns>
	public static Quantity<double, Yottacandela> ToYottacandela<T>(this Quantity<T, Attocandela> val) where T:IConvertible {
        return new Quantity<double, Yottacandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attocandela to Zettacandela
    /// </summary>
    /// <param name="val">quantity measured in Attocandela</param>
    /// <returns>quantity measured in Zettacandela</returns>
	public static Quantity<double, Zettacandela> ToZettacandela<T>(this Quantity<T, Attocandela> val) where T:IConvertible {
        return new Quantity<double, Zettacandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attocandela to Exacandela
    /// </summary>
    /// <param name="val">quantity measured in Attocandela</param>
    /// <returns>quantity measured in Exacandela</returns>
	public static Quantity<double, Exacandela> ToExacandela<T>(this Quantity<T, Attocandela> val) where T:IConvertible {
        return new Quantity<double, Exacandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attocandela to Petacandela
    /// </summary>
    /// <param name="val">quantity measured in Attocandela</param>
    /// <returns>quantity measured in Petacandela</returns>
	public static Quantity<double, Petacandela> ToPetacandela<T>(this Quantity<T, Attocandela> val) where T:IConvertible {
        return new Quantity<double, Petacandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attocandela to Teracandela
    /// </summary>
    /// <param name="val">quantity measured in Attocandela</param>
    /// <returns>quantity measured in Teracandela</returns>
	public static Quantity<double, Teracandela> ToTeracandela<T>(this Quantity<T, Attocandela> val) where T:IConvertible {
        return new Quantity<double, Teracandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attocandela to Gigacandela
    /// </summary>
    /// <param name="val">quantity measured in Attocandela</param>
    /// <returns>quantity measured in Gigacandela</returns>
	public static Quantity<double, Gigacandela> ToGigacandela<T>(this Quantity<T, Attocandela> val) where T:IConvertible {
        return new Quantity<double, Gigacandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attocandela to Megacandela
    /// </summary>
    /// <param name="val">quantity measured in Attocandela</param>
    /// <returns>quantity measured in Megacandela</returns>
	public static Quantity<double, Megacandela> ToMegacandela<T>(this Quantity<T, Attocandela> val) where T:IConvertible {
        return new Quantity<double, Megacandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attocandela to Kilocandela
    /// </summary>
    /// <param name="val">quantity measured in Attocandela</param>
    /// <returns>quantity measured in Kilocandela</returns>
	public static Quantity<double, Kilocandela> ToKilocandela<T>(this Quantity<T, Attocandela> val) where T:IConvertible {
        return new Quantity<double, Kilocandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attocandela to Hectocandela
    /// </summary>
    /// <param name="val">quantity measured in Attocandela</param>
    /// <returns>quantity measured in Hectocandela</returns>
	public static Quantity<double, Hectocandela> ToHectocandela<T>(this Quantity<T, Attocandela> val) where T:IConvertible {
        return new Quantity<double, Hectocandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attocandela to Dekacandela
    /// </summary>
    /// <param name="val">quantity measured in Attocandela</param>
    /// <returns>quantity measured in Dekacandela</returns>
	public static Quantity<double, Dekacandela> ToDekacandela<T>(this Quantity<T, Attocandela> val) where T:IConvertible {
        return new Quantity<double, Dekacandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attocandela to Decicandela
    /// </summary>
    /// <param name="val">quantity measured in Attocandela</param>
    /// <returns>quantity measured in Decicandela</returns>
	public static Quantity<double, Decicandela> ToDecicandela<T>(this Quantity<T, Attocandela> val) where T:IConvertible {
        return new Quantity<double, Decicandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attocandela to Centicandela
    /// </summary>
    /// <param name="val">quantity measured in Attocandela</param>
    /// <returns>quantity measured in Centicandela</returns>
	public static Quantity<double, Centicandela> ToCenticandela<T>(this Quantity<T, Attocandela> val) where T:IConvertible {
        return new Quantity<double, Centicandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attocandela to Millicandela
    /// </summary>
    /// <param name="val">quantity measured in Attocandela</param>
    /// <returns>quantity measured in Millicandela</returns>
	public static Quantity<double, Millicandela> ToMillicandela<T>(this Quantity<T, Attocandela> val) where T:IConvertible {
        return new Quantity<double, Millicandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attocandela to Microcandela
    /// </summary>
    /// <param name="val">quantity measured in Attocandela</param>
    /// <returns>quantity measured in Microcandela</returns>
	public static Quantity<double, Microcandela> ToMicrocandela<T>(this Quantity<T, Attocandela> val) where T:IConvertible {
        return new Quantity<double, Microcandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attocandela to Nanocandela
    /// </summary>
    /// <param name="val">quantity measured in Attocandela</param>
    /// <returns>quantity measured in Nanocandela</returns>
	public static Quantity<double, Nanocandela> ToNanocandela<T>(this Quantity<T, Attocandela> val) where T:IConvertible {
        return new Quantity<double, Nanocandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attocandela to Picocandela
    /// </summary>
    /// <param name="val">quantity measured in Attocandela</param>
    /// <returns>quantity measured in Picocandela</returns>
	public static Quantity<double, Picocandela> ToPicocandela<T>(this Quantity<T, Attocandela> val) where T:IConvertible {
        return new Quantity<double, Picocandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attocandela to Femtocandela
    /// </summary>
    /// <param name="val">quantity measured in Attocandela</param>
    /// <returns>quantity measured in Femtocandela</returns>
	public static Quantity<double, Femtocandela> ToFemtocandela<T>(this Quantity<T, Attocandela> val) where T:IConvertible {
        return new Quantity<double, Femtocandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attocandela to Zeptocandela
    /// </summary>
    /// <param name="val">quantity measured in Attocandela</param>
    /// <returns>quantity measured in Zeptocandela</returns>
	public static Quantity<double, Zeptocandela> ToZeptocandela<T>(this Quantity<T, Attocandela> val) where T:IConvertible {
        return new Quantity<double, Zeptocandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Attocandela to Yoctocandela
    /// </summary>
    /// <param name="val">quantity measured in Attocandela</param>
    /// <returns>quantity measured in Yoctocandela</returns>
	public static Quantity<double, Yoctocandela> ToYoctocandela<T>(this Quantity<T, Attocandela> val) where T:IConvertible {
        return new Quantity<double, Yoctocandela>(
            Convert.ToDouble(val.Value) * 1E18
        );
    }
	/// <summary>
    /// Extension method to convert Zeptocandela to Yottacandela
    /// </summary>
    /// <param name="val">quantity measured in Zeptocandela</param>
    /// <returns>quantity measured in Yottacandela</returns>
	public static Quantity<double, Yottacandela> ToYottacandela<T>(this Quantity<T, Zeptocandela> val) where T:IConvertible {
        return new Quantity<double, Yottacandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptocandela to Zettacandela
    /// </summary>
    /// <param name="val">quantity measured in Zeptocandela</param>
    /// <returns>quantity measured in Zettacandela</returns>
	public static Quantity<double, Zettacandela> ToZettacandela<T>(this Quantity<T, Zeptocandela> val) where T:IConvertible {
        return new Quantity<double, Zettacandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptocandela to Exacandela
    /// </summary>
    /// <param name="val">quantity measured in Zeptocandela</param>
    /// <returns>quantity measured in Exacandela</returns>
	public static Quantity<double, Exacandela> ToExacandela<T>(this Quantity<T, Zeptocandela> val) where T:IConvertible {
        return new Quantity<double, Exacandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptocandela to Petacandela
    /// </summary>
    /// <param name="val">quantity measured in Zeptocandela</param>
    /// <returns>quantity measured in Petacandela</returns>
	public static Quantity<double, Petacandela> ToPetacandela<T>(this Quantity<T, Zeptocandela> val) where T:IConvertible {
        return new Quantity<double, Petacandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptocandela to Teracandela
    /// </summary>
    /// <param name="val">quantity measured in Zeptocandela</param>
    /// <returns>quantity measured in Teracandela</returns>
	public static Quantity<double, Teracandela> ToTeracandela<T>(this Quantity<T, Zeptocandela> val) where T:IConvertible {
        return new Quantity<double, Teracandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptocandela to Gigacandela
    /// </summary>
    /// <param name="val">quantity measured in Zeptocandela</param>
    /// <returns>quantity measured in Gigacandela</returns>
	public static Quantity<double, Gigacandela> ToGigacandela<T>(this Quantity<T, Zeptocandela> val) where T:IConvertible {
        return new Quantity<double, Gigacandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptocandela to Megacandela
    /// </summary>
    /// <param name="val">quantity measured in Zeptocandela</param>
    /// <returns>quantity measured in Megacandela</returns>
	public static Quantity<double, Megacandela> ToMegacandela<T>(this Quantity<T, Zeptocandela> val) where T:IConvertible {
        return new Quantity<double, Megacandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptocandela to Kilocandela
    /// </summary>
    /// <param name="val">quantity measured in Zeptocandela</param>
    /// <returns>quantity measured in Kilocandela</returns>
	public static Quantity<double, Kilocandela> ToKilocandela<T>(this Quantity<T, Zeptocandela> val) where T:IConvertible {
        return new Quantity<double, Kilocandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptocandela to Hectocandela
    /// </summary>
    /// <param name="val">quantity measured in Zeptocandela</param>
    /// <returns>quantity measured in Hectocandela</returns>
	public static Quantity<double, Hectocandela> ToHectocandela<T>(this Quantity<T, Zeptocandela> val) where T:IConvertible {
        return new Quantity<double, Hectocandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptocandela to Dekacandela
    /// </summary>
    /// <param name="val">quantity measured in Zeptocandela</param>
    /// <returns>quantity measured in Dekacandela</returns>
	public static Quantity<double, Dekacandela> ToDekacandela<T>(this Quantity<T, Zeptocandela> val) where T:IConvertible {
        return new Quantity<double, Dekacandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptocandela to Decicandela
    /// </summary>
    /// <param name="val">quantity measured in Zeptocandela</param>
    /// <returns>quantity measured in Decicandela</returns>
	public static Quantity<double, Decicandela> ToDecicandela<T>(this Quantity<T, Zeptocandela> val) where T:IConvertible {
        return new Quantity<double, Decicandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptocandela to Centicandela
    /// </summary>
    /// <param name="val">quantity measured in Zeptocandela</param>
    /// <returns>quantity measured in Centicandela</returns>
	public static Quantity<double, Centicandela> ToCenticandela<T>(this Quantity<T, Zeptocandela> val) where T:IConvertible {
        return new Quantity<double, Centicandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptocandela to Millicandela
    /// </summary>
    /// <param name="val">quantity measured in Zeptocandela</param>
    /// <returns>quantity measured in Millicandela</returns>
	public static Quantity<double, Millicandela> ToMillicandela<T>(this Quantity<T, Zeptocandela> val) where T:IConvertible {
        return new Quantity<double, Millicandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptocandela to Microcandela
    /// </summary>
    /// <param name="val">quantity measured in Zeptocandela</param>
    /// <returns>quantity measured in Microcandela</returns>
	public static Quantity<double, Microcandela> ToMicrocandela<T>(this Quantity<T, Zeptocandela> val) where T:IConvertible {
        return new Quantity<double, Microcandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptocandela to Nanocandela
    /// </summary>
    /// <param name="val">quantity measured in Zeptocandela</param>
    /// <returns>quantity measured in Nanocandela</returns>
	public static Quantity<double, Nanocandela> ToNanocandela<T>(this Quantity<T, Zeptocandela> val) where T:IConvertible {
        return new Quantity<double, Nanocandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptocandela to Picocandela
    /// </summary>
    /// <param name="val">quantity measured in Zeptocandela</param>
    /// <returns>quantity measured in Picocandela</returns>
	public static Quantity<double, Picocandela> ToPicocandela<T>(this Quantity<T, Zeptocandela> val) where T:IConvertible {
        return new Quantity<double, Picocandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptocandela to Femtocandela
    /// </summary>
    /// <param name="val">quantity measured in Zeptocandela</param>
    /// <returns>quantity measured in Femtocandela</returns>
	public static Quantity<double, Femtocandela> ToFemtocandela<T>(this Quantity<T, Zeptocandela> val) where T:IConvertible {
        return new Quantity<double, Femtocandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptocandela to Attocandela
    /// </summary>
    /// <param name="val">quantity measured in Zeptocandela</param>
    /// <returns>quantity measured in Attocandela</returns>
	public static Quantity<double, Attocandela> ToAttocandela<T>(this Quantity<T, Zeptocandela> val) where T:IConvertible {
        return new Quantity<double, Attocandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptocandela to Yoctocandela
    /// </summary>
    /// <param name="val">quantity measured in Zeptocandela</param>
    /// <returns>quantity measured in Yoctocandela</returns>
	public static Quantity<double, Yoctocandela> ToYoctocandela<T>(this Quantity<T, Zeptocandela> val) where T:IConvertible {
        return new Quantity<double, Yoctocandela>(
            Convert.ToDouble(val.Value) * 1E21
        );
    }
	/// <summary>
    /// Extension method to convert Yoctocandela to Yottacandela
    /// </summary>
    /// <param name="val">quantity measured in Yoctocandela</param>
    /// <returns>quantity measured in Yottacandela</returns>
	public static Quantity<double, Yottacandela> ToYottacandela<T>(this Quantity<T, Yoctocandela> val) where T:IConvertible {
        return new Quantity<double, Yottacandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctocandela to Zettacandela
    /// </summary>
    /// <param name="val">quantity measured in Yoctocandela</param>
    /// <returns>quantity measured in Zettacandela</returns>
	public static Quantity<double, Zettacandela> ToZettacandela<T>(this Quantity<T, Yoctocandela> val) where T:IConvertible {
        return new Quantity<double, Zettacandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctocandela to Exacandela
    /// </summary>
    /// <param name="val">quantity measured in Yoctocandela</param>
    /// <returns>quantity measured in Exacandela</returns>
	public static Quantity<double, Exacandela> ToExacandela<T>(this Quantity<T, Yoctocandela> val) where T:IConvertible {
        return new Quantity<double, Exacandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctocandela to Petacandela
    /// </summary>
    /// <param name="val">quantity measured in Yoctocandela</param>
    /// <returns>quantity measured in Petacandela</returns>
	public static Quantity<double, Petacandela> ToPetacandela<T>(this Quantity<T, Yoctocandela> val) where T:IConvertible {
        return new Quantity<double, Petacandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctocandela to Teracandela
    /// </summary>
    /// <param name="val">quantity measured in Yoctocandela</param>
    /// <returns>quantity measured in Teracandela</returns>
	public static Quantity<double, Teracandela> ToTeracandela<T>(this Quantity<T, Yoctocandela> val) where T:IConvertible {
        return new Quantity<double, Teracandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctocandela to Gigacandela
    /// </summary>
    /// <param name="val">quantity measured in Yoctocandela</param>
    /// <returns>quantity measured in Gigacandela</returns>
	public static Quantity<double, Gigacandela> ToGigacandela<T>(this Quantity<T, Yoctocandela> val) where T:IConvertible {
        return new Quantity<double, Gigacandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctocandela to Megacandela
    /// </summary>
    /// <param name="val">quantity measured in Yoctocandela</param>
    /// <returns>quantity measured in Megacandela</returns>
	public static Quantity<double, Megacandela> ToMegacandela<T>(this Quantity<T, Yoctocandela> val) where T:IConvertible {
        return new Quantity<double, Megacandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctocandela to Kilocandela
    /// </summary>
    /// <param name="val">quantity measured in Yoctocandela</param>
    /// <returns>quantity measured in Kilocandela</returns>
	public static Quantity<double, Kilocandela> ToKilocandela<T>(this Quantity<T, Yoctocandela> val) where T:IConvertible {
        return new Quantity<double, Kilocandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctocandela to Hectocandela
    /// </summary>
    /// <param name="val">quantity measured in Yoctocandela</param>
    /// <returns>quantity measured in Hectocandela</returns>
	public static Quantity<double, Hectocandela> ToHectocandela<T>(this Quantity<T, Yoctocandela> val) where T:IConvertible {
        return new Quantity<double, Hectocandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctocandela to Dekacandela
    /// </summary>
    /// <param name="val">quantity measured in Yoctocandela</param>
    /// <returns>quantity measured in Dekacandela</returns>
	public static Quantity<double, Dekacandela> ToDekacandela<T>(this Quantity<T, Yoctocandela> val) where T:IConvertible {
        return new Quantity<double, Dekacandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctocandela to Decicandela
    /// </summary>
    /// <param name="val">quantity measured in Yoctocandela</param>
    /// <returns>quantity measured in Decicandela</returns>
	public static Quantity<double, Decicandela> ToDecicandela<T>(this Quantity<T, Yoctocandela> val) where T:IConvertible {
        return new Quantity<double, Decicandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctocandela to Centicandela
    /// </summary>
    /// <param name="val">quantity measured in Yoctocandela</param>
    /// <returns>quantity measured in Centicandela</returns>
	public static Quantity<double, Centicandela> ToCenticandela<T>(this Quantity<T, Yoctocandela> val) where T:IConvertible {
        return new Quantity<double, Centicandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctocandela to Millicandela
    /// </summary>
    /// <param name="val">quantity measured in Yoctocandela</param>
    /// <returns>quantity measured in Millicandela</returns>
	public static Quantity<double, Millicandela> ToMillicandela<T>(this Quantity<T, Yoctocandela> val) where T:IConvertible {
        return new Quantity<double, Millicandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctocandela to Microcandela
    /// </summary>
    /// <param name="val">quantity measured in Yoctocandela</param>
    /// <returns>quantity measured in Microcandela</returns>
	public static Quantity<double, Microcandela> ToMicrocandela<T>(this Quantity<T, Yoctocandela> val) where T:IConvertible {
        return new Quantity<double, Microcandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctocandela to Nanocandela
    /// </summary>
    /// <param name="val">quantity measured in Yoctocandela</param>
    /// <returns>quantity measured in Nanocandela</returns>
	public static Quantity<double, Nanocandela> ToNanocandela<T>(this Quantity<T, Yoctocandela> val) where T:IConvertible {
        return new Quantity<double, Nanocandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctocandela to Picocandela
    /// </summary>
    /// <param name="val">quantity measured in Yoctocandela</param>
    /// <returns>quantity measured in Picocandela</returns>
	public static Quantity<double, Picocandela> ToPicocandela<T>(this Quantity<T, Yoctocandela> val) where T:IConvertible {
        return new Quantity<double, Picocandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctocandela to Femtocandela
    /// </summary>
    /// <param name="val">quantity measured in Yoctocandela</param>
    /// <returns>quantity measured in Femtocandela</returns>
	public static Quantity<double, Femtocandela> ToFemtocandela<T>(this Quantity<T, Yoctocandela> val) where T:IConvertible {
        return new Quantity<double, Femtocandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctocandela to Attocandela
    /// </summary>
    /// <param name="val">quantity measured in Yoctocandela</param>
    /// <returns>quantity measured in Attocandela</returns>
	public static Quantity<double, Attocandela> ToAttocandela<T>(this Quantity<T, Yoctocandela> val) where T:IConvertible {
        return new Quantity<double, Attocandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctocandela to Zeptocandela
    /// </summary>
    /// <param name="val">quantity measured in Yoctocandela</param>
    /// <returns>quantity measured in Zeptocandela</returns>
	public static Quantity<double, Zeptocandela> ToZeptocandela<T>(this Quantity<T, Yoctocandela> val) where T:IConvertible {
        return new Quantity<double, Zeptocandela>(
            Convert.ToDouble(val.Value) * 1E24
        );
    }
}

}