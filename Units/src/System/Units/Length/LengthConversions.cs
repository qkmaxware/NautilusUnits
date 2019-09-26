using System;

namespace System.Units.Length {

public static class LengthConversions {
	/// <summary>
    /// Extension method to convert Metre to Yottametre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in Yottametre</returns>
	public static Quantity<double, Yottametre> ToYottametre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, Yottametre>(
            Convert.ToDouble(val.Value) * 10e24
        );
    }
	/// <summary>
    /// Extension method to convert Metre to Zettametre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in Zettametre</returns>
	public static Quantity<double, Zettametre> ToZettametre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, Zettametre>(
            Convert.ToDouble(val.Value) * 10e21
        );
    }
	/// <summary>
    /// Extension method to convert Metre to Exametre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in Exametre</returns>
	public static Quantity<double, Exametre> ToExametre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, Exametre>(
            Convert.ToDouble(val.Value) * 10e18
        );
    }
	/// <summary>
    /// Extension method to convert Metre to Petametre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in Petametre</returns>
	public static Quantity<double, Petametre> ToPetametre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, Petametre>(
            Convert.ToDouble(val.Value) * 10e15
        );
    }
	/// <summary>
    /// Extension method to convert Metre to Terametre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in Terametre</returns>
	public static Quantity<double, Terametre> ToTerametre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, Terametre>(
            Convert.ToDouble(val.Value) * 10e12
        );
    }
	/// <summary>
    /// Extension method to convert Metre to Gigametre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in Gigametre</returns>
	public static Quantity<double, Gigametre> ToGigametre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, Gigametre>(
            Convert.ToDouble(val.Value) * 10e9
        );
    }
	/// <summary>
    /// Extension method to convert Metre to Megametre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in Megametre</returns>
	public static Quantity<double, Megametre> ToMegametre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, Megametre>(
            Convert.ToDouble(val.Value) * 10e6
        );
    }
	/// <summary>
    /// Extension method to convert Metre to Kilometre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in Kilometre</returns>
	public static Quantity<double, Kilometre> ToKilometre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, Kilometre>(
            Convert.ToDouble(val.Value) * 10e3
        );
    }
	/// <summary>
    /// Extension method to convert Metre to Hectometre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in Hectometre</returns>
	public static Quantity<double, Hectometre> ToHectometre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, Hectometre>(
            Convert.ToDouble(val.Value) * 10e2
        );
    }
	/// <summary>
    /// Extension method to convert Metre to Dekametre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in Dekametre</returns>
	public static Quantity<double, Dekametre> ToDekametre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, Dekametre>(
            Convert.ToDouble(val.Value) * 10e1
        );
    }
	/// <summary>
    /// Extension method to convert Metre to Decimetre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in Decimetre</returns>
	public static Quantity<double, Decimetre> ToDecimetre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, Decimetre>(
            Convert.ToDouble(val.Value) * 10e-1
        );
    }
	/// <summary>
    /// Extension method to convert Metre to Centimetre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in Centimetre</returns>
	public static Quantity<double, Centimetre> ToCentimetre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, Centimetre>(
            Convert.ToDouble(val.Value) * 10e-2
        );
    }
	/// <summary>
    /// Extension method to convert Metre to Millimetre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in Millimetre</returns>
	public static Quantity<double, Millimetre> ToMillimetre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, Millimetre>(
            Convert.ToDouble(val.Value) * 10e-3
        );
    }
	/// <summary>
    /// Extension method to convert Metre to Micrometre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in Micrometre</returns>
	public static Quantity<double, Micrometre> ToMicrometre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, Micrometre>(
            Convert.ToDouble(val.Value) * 10e-6
        );
    }
	/// <summary>
    /// Extension method to convert Metre to Nanometre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in Nanometre</returns>
	public static Quantity<double, Nanometre> ToNanometre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, Nanometre>(
            Convert.ToDouble(val.Value) * 10e-9
        );
    }
	/// <summary>
    /// Extension method to convert Metre to Picometre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in Picometre</returns>
	public static Quantity<double, Picometre> ToPicometre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, Picometre>(
            Convert.ToDouble(val.Value) * 10e-12
        );
    }
	/// <summary>
    /// Extension method to convert Metre to Femtometre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in Femtometre</returns>
	public static Quantity<double, Femtometre> ToFemtometre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, Femtometre>(
            Convert.ToDouble(val.Value) * 10e-15
        );
    }
	/// <summary>
    /// Extension method to convert Metre to Attometre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in Attometre</returns>
	public static Quantity<double, Attometre> ToAttometre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, Attometre>(
            Convert.ToDouble(val.Value) * 10e-18
        );
    }
	/// <summary>
    /// Extension method to convert Metre to Zeptometre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in Zeptometre</returns>
	public static Quantity<double, Zeptometre> ToZeptometre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, Zeptometre>(
            Convert.ToDouble(val.Value) * 10e-21
        );
    }
	/// <summary>
    /// Extension method to convert Metre to Yoctometre
    /// </summary>
    /// <param name="val">quantity measured in Metre</param>
    /// <returns>quantity measured in Yoctometre</returns>
	public static Quantity<double, Yoctometre> ToYoctometre<T>(this Quantity<T, Metre> val) where T:IConvertible {
        return new Quantity<double, Yoctometre>(
            Convert.ToDouble(val.Value) * 10e-24
        );
    }
	/// <summary>
    /// Extension method to convert Yottametre to Zettametre
    /// </summary>
    /// <param name="val">quantity measured in Yottametre</param>
    /// <returns>quantity measured in Zettametre</returns>
	public static Quantity<double, Zettametre> ToZettametre<T>(this Quantity<T, Yottametre> val) where T:IConvertible {
        return new Quantity<double, Zettametre>(
            Convert.ToDouble(val.Value) * 10e24
        );
    }
	/// <summary>
    /// Extension method to convert Yottametre to Exametre
    /// </summary>
    /// <param name="val">quantity measured in Yottametre</param>
    /// <returns>quantity measured in Exametre</returns>
	public static Quantity<double, Exametre> ToExametre<T>(this Quantity<T, Yottametre> val) where T:IConvertible {
        return new Quantity<double, Exametre>(
            Convert.ToDouble(val.Value) * 10e24
        );
    }
	/// <summary>
    /// Extension method to convert Yottametre to Petametre
    /// </summary>
    /// <param name="val">quantity measured in Yottametre</param>
    /// <returns>quantity measured in Petametre</returns>
	public static Quantity<double, Petametre> ToPetametre<T>(this Quantity<T, Yottametre> val) where T:IConvertible {
        return new Quantity<double, Petametre>(
            Convert.ToDouble(val.Value) * 10e24
        );
    }
	/// <summary>
    /// Extension method to convert Yottametre to Terametre
    /// </summary>
    /// <param name="val">quantity measured in Yottametre</param>
    /// <returns>quantity measured in Terametre</returns>
	public static Quantity<double, Terametre> ToTerametre<T>(this Quantity<T, Yottametre> val) where T:IConvertible {
        return new Quantity<double, Terametre>(
            Convert.ToDouble(val.Value) * 10e24
        );
    }
	/// <summary>
    /// Extension method to convert Yottametre to Gigametre
    /// </summary>
    /// <param name="val">quantity measured in Yottametre</param>
    /// <returns>quantity measured in Gigametre</returns>
	public static Quantity<double, Gigametre> ToGigametre<T>(this Quantity<T, Yottametre> val) where T:IConvertible {
        return new Quantity<double, Gigametre>(
            Convert.ToDouble(val.Value) * 10e24
        );
    }
	/// <summary>
    /// Extension method to convert Yottametre to Megametre
    /// </summary>
    /// <param name="val">quantity measured in Yottametre</param>
    /// <returns>quantity measured in Megametre</returns>
	public static Quantity<double, Megametre> ToMegametre<T>(this Quantity<T, Yottametre> val) where T:IConvertible {
        return new Quantity<double, Megametre>(
            Convert.ToDouble(val.Value) * 10e24
        );
    }
	/// <summary>
    /// Extension method to convert Yottametre to Kilometre
    /// </summary>
    /// <param name="val">quantity measured in Yottametre</param>
    /// <returns>quantity measured in Kilometre</returns>
	public static Quantity<double, Kilometre> ToKilometre<T>(this Quantity<T, Yottametre> val) where T:IConvertible {
        return new Quantity<double, Kilometre>(
            Convert.ToDouble(val.Value) * 10e24
        );
    }
	/// <summary>
    /// Extension method to convert Yottametre to Hectometre
    /// </summary>
    /// <param name="val">quantity measured in Yottametre</param>
    /// <returns>quantity measured in Hectometre</returns>
	public static Quantity<double, Hectometre> ToHectometre<T>(this Quantity<T, Yottametre> val) where T:IConvertible {
        return new Quantity<double, Hectometre>(
            Convert.ToDouble(val.Value) * 10e24
        );
    }
	/// <summary>
    /// Extension method to convert Yottametre to Dekametre
    /// </summary>
    /// <param name="val">quantity measured in Yottametre</param>
    /// <returns>quantity measured in Dekametre</returns>
	public static Quantity<double, Dekametre> ToDekametre<T>(this Quantity<T, Yottametre> val) where T:IConvertible {
        return new Quantity<double, Dekametre>(
            Convert.ToDouble(val.Value) * 10e24
        );
    }
	/// <summary>
    /// Extension method to convert Yottametre to Decimetre
    /// </summary>
    /// <param name="val">quantity measured in Yottametre</param>
    /// <returns>quantity measured in Decimetre</returns>
	public static Quantity<double, Decimetre> ToDecimetre<T>(this Quantity<T, Yottametre> val) where T:IConvertible {
        return new Quantity<double, Decimetre>(
            Convert.ToDouble(val.Value) * 10e24
        );
    }
	/// <summary>
    /// Extension method to convert Yottametre to Centimetre
    /// </summary>
    /// <param name="val">quantity measured in Yottametre</param>
    /// <returns>quantity measured in Centimetre</returns>
	public static Quantity<double, Centimetre> ToCentimetre<T>(this Quantity<T, Yottametre> val) where T:IConvertible {
        return new Quantity<double, Centimetre>(
            Convert.ToDouble(val.Value) * 10e24
        );
    }
	/// <summary>
    /// Extension method to convert Yottametre to Millimetre
    /// </summary>
    /// <param name="val">quantity measured in Yottametre</param>
    /// <returns>quantity measured in Millimetre</returns>
	public static Quantity<double, Millimetre> ToMillimetre<T>(this Quantity<T, Yottametre> val) where T:IConvertible {
        return new Quantity<double, Millimetre>(
            Convert.ToDouble(val.Value) * 10e24
        );
    }
	/// <summary>
    /// Extension method to convert Yottametre to Micrometre
    /// </summary>
    /// <param name="val">quantity measured in Yottametre</param>
    /// <returns>quantity measured in Micrometre</returns>
	public static Quantity<double, Micrometre> ToMicrometre<T>(this Quantity<T, Yottametre> val) where T:IConvertible {
        return new Quantity<double, Micrometre>(
            Convert.ToDouble(val.Value) * 10e24
        );
    }
	/// <summary>
    /// Extension method to convert Yottametre to Nanometre
    /// </summary>
    /// <param name="val">quantity measured in Yottametre</param>
    /// <returns>quantity measured in Nanometre</returns>
	public static Quantity<double, Nanometre> ToNanometre<T>(this Quantity<T, Yottametre> val) where T:IConvertible {
        return new Quantity<double, Nanometre>(
            Convert.ToDouble(val.Value) * 10e24
        );
    }
	/// <summary>
    /// Extension method to convert Yottametre to Picometre
    /// </summary>
    /// <param name="val">quantity measured in Yottametre</param>
    /// <returns>quantity measured in Picometre</returns>
	public static Quantity<double, Picometre> ToPicometre<T>(this Quantity<T, Yottametre> val) where T:IConvertible {
        return new Quantity<double, Picometre>(
            Convert.ToDouble(val.Value) * 10e24
        );
    }
	/// <summary>
    /// Extension method to convert Yottametre to Femtometre
    /// </summary>
    /// <param name="val">quantity measured in Yottametre</param>
    /// <returns>quantity measured in Femtometre</returns>
	public static Quantity<double, Femtometre> ToFemtometre<T>(this Quantity<T, Yottametre> val) where T:IConvertible {
        return new Quantity<double, Femtometre>(
            Convert.ToDouble(val.Value) * 10e24
        );
    }
	/// <summary>
    /// Extension method to convert Yottametre to Attometre
    /// </summary>
    /// <param name="val">quantity measured in Yottametre</param>
    /// <returns>quantity measured in Attometre</returns>
	public static Quantity<double, Attometre> ToAttometre<T>(this Quantity<T, Yottametre> val) where T:IConvertible {
        return new Quantity<double, Attometre>(
            Convert.ToDouble(val.Value) * 10e24
        );
    }
	/// <summary>
    /// Extension method to convert Yottametre to Zeptometre
    /// </summary>
    /// <param name="val">quantity measured in Yottametre</param>
    /// <returns>quantity measured in Zeptometre</returns>
	public static Quantity<double, Zeptometre> ToZeptometre<T>(this Quantity<T, Yottametre> val) where T:IConvertible {
        return new Quantity<double, Zeptometre>(
            Convert.ToDouble(val.Value) * 10e24
        );
    }
	/// <summary>
    /// Extension method to convert Yottametre to Yoctometre
    /// </summary>
    /// <param name="val">quantity measured in Yottametre</param>
    /// <returns>quantity measured in Yoctometre</returns>
	public static Quantity<double, Yoctometre> ToYoctometre<T>(this Quantity<T, Yottametre> val) where T:IConvertible {
        return new Quantity<double, Yoctometre>(
            Convert.ToDouble(val.Value) * 10e24
        );
    }
	/// <summary>
    /// Extension method to convert Zettametre to Yottametre
    /// </summary>
    /// <param name="val">quantity measured in Zettametre</param>
    /// <returns>quantity measured in Yottametre</returns>
	public static Quantity<double, Yottametre> ToYottametre<T>(this Quantity<T, Zettametre> val) where T:IConvertible {
        return new Quantity<double, Yottametre>(
            Convert.ToDouble(val.Value) * 10e21
        );
    }
	/// <summary>
    /// Extension method to convert Zettametre to Exametre
    /// </summary>
    /// <param name="val">quantity measured in Zettametre</param>
    /// <returns>quantity measured in Exametre</returns>
	public static Quantity<double, Exametre> ToExametre<T>(this Quantity<T, Zettametre> val) where T:IConvertible {
        return new Quantity<double, Exametre>(
            Convert.ToDouble(val.Value) * 10e21
        );
    }
	/// <summary>
    /// Extension method to convert Zettametre to Petametre
    /// </summary>
    /// <param name="val">quantity measured in Zettametre</param>
    /// <returns>quantity measured in Petametre</returns>
	public static Quantity<double, Petametre> ToPetametre<T>(this Quantity<T, Zettametre> val) where T:IConvertible {
        return new Quantity<double, Petametre>(
            Convert.ToDouble(val.Value) * 10e21
        );
    }
	/// <summary>
    /// Extension method to convert Zettametre to Terametre
    /// </summary>
    /// <param name="val">quantity measured in Zettametre</param>
    /// <returns>quantity measured in Terametre</returns>
	public static Quantity<double, Terametre> ToTerametre<T>(this Quantity<T, Zettametre> val) where T:IConvertible {
        return new Quantity<double, Terametre>(
            Convert.ToDouble(val.Value) * 10e21
        );
    }
	/// <summary>
    /// Extension method to convert Zettametre to Gigametre
    /// </summary>
    /// <param name="val">quantity measured in Zettametre</param>
    /// <returns>quantity measured in Gigametre</returns>
	public static Quantity<double, Gigametre> ToGigametre<T>(this Quantity<T, Zettametre> val) where T:IConvertible {
        return new Quantity<double, Gigametre>(
            Convert.ToDouble(val.Value) * 10e21
        );
    }
	/// <summary>
    /// Extension method to convert Zettametre to Megametre
    /// </summary>
    /// <param name="val">quantity measured in Zettametre</param>
    /// <returns>quantity measured in Megametre</returns>
	public static Quantity<double, Megametre> ToMegametre<T>(this Quantity<T, Zettametre> val) where T:IConvertible {
        return new Quantity<double, Megametre>(
            Convert.ToDouble(val.Value) * 10e21
        );
    }
	/// <summary>
    /// Extension method to convert Zettametre to Kilometre
    /// </summary>
    /// <param name="val">quantity measured in Zettametre</param>
    /// <returns>quantity measured in Kilometre</returns>
	public static Quantity<double, Kilometre> ToKilometre<T>(this Quantity<T, Zettametre> val) where T:IConvertible {
        return new Quantity<double, Kilometre>(
            Convert.ToDouble(val.Value) * 10e21
        );
    }
	/// <summary>
    /// Extension method to convert Zettametre to Hectometre
    /// </summary>
    /// <param name="val">quantity measured in Zettametre</param>
    /// <returns>quantity measured in Hectometre</returns>
	public static Quantity<double, Hectometre> ToHectometre<T>(this Quantity<T, Zettametre> val) where T:IConvertible {
        return new Quantity<double, Hectometre>(
            Convert.ToDouble(val.Value) * 10e21
        );
    }
	/// <summary>
    /// Extension method to convert Zettametre to Dekametre
    /// </summary>
    /// <param name="val">quantity measured in Zettametre</param>
    /// <returns>quantity measured in Dekametre</returns>
	public static Quantity<double, Dekametre> ToDekametre<T>(this Quantity<T, Zettametre> val) where T:IConvertible {
        return new Quantity<double, Dekametre>(
            Convert.ToDouble(val.Value) * 10e21
        );
    }
	/// <summary>
    /// Extension method to convert Zettametre to Decimetre
    /// </summary>
    /// <param name="val">quantity measured in Zettametre</param>
    /// <returns>quantity measured in Decimetre</returns>
	public static Quantity<double, Decimetre> ToDecimetre<T>(this Quantity<T, Zettametre> val) where T:IConvertible {
        return new Quantity<double, Decimetre>(
            Convert.ToDouble(val.Value) * 10e21
        );
    }
	/// <summary>
    /// Extension method to convert Zettametre to Centimetre
    /// </summary>
    /// <param name="val">quantity measured in Zettametre</param>
    /// <returns>quantity measured in Centimetre</returns>
	public static Quantity<double, Centimetre> ToCentimetre<T>(this Quantity<T, Zettametre> val) where T:IConvertible {
        return new Quantity<double, Centimetre>(
            Convert.ToDouble(val.Value) * 10e21
        );
    }
	/// <summary>
    /// Extension method to convert Zettametre to Millimetre
    /// </summary>
    /// <param name="val">quantity measured in Zettametre</param>
    /// <returns>quantity measured in Millimetre</returns>
	public static Quantity<double, Millimetre> ToMillimetre<T>(this Quantity<T, Zettametre> val) where T:IConvertible {
        return new Quantity<double, Millimetre>(
            Convert.ToDouble(val.Value) * 10e21
        );
    }
	/// <summary>
    /// Extension method to convert Zettametre to Micrometre
    /// </summary>
    /// <param name="val">quantity measured in Zettametre</param>
    /// <returns>quantity measured in Micrometre</returns>
	public static Quantity<double, Micrometre> ToMicrometre<T>(this Quantity<T, Zettametre> val) where T:IConvertible {
        return new Quantity<double, Micrometre>(
            Convert.ToDouble(val.Value) * 10e21
        );
    }
	/// <summary>
    /// Extension method to convert Zettametre to Nanometre
    /// </summary>
    /// <param name="val">quantity measured in Zettametre</param>
    /// <returns>quantity measured in Nanometre</returns>
	public static Quantity<double, Nanometre> ToNanometre<T>(this Quantity<T, Zettametre> val) where T:IConvertible {
        return new Quantity<double, Nanometre>(
            Convert.ToDouble(val.Value) * 10e21
        );
    }
	/// <summary>
    /// Extension method to convert Zettametre to Picometre
    /// </summary>
    /// <param name="val">quantity measured in Zettametre</param>
    /// <returns>quantity measured in Picometre</returns>
	public static Quantity<double, Picometre> ToPicometre<T>(this Quantity<T, Zettametre> val) where T:IConvertible {
        return new Quantity<double, Picometre>(
            Convert.ToDouble(val.Value) * 10e21
        );
    }
	/// <summary>
    /// Extension method to convert Zettametre to Femtometre
    /// </summary>
    /// <param name="val">quantity measured in Zettametre</param>
    /// <returns>quantity measured in Femtometre</returns>
	public static Quantity<double, Femtometre> ToFemtometre<T>(this Quantity<T, Zettametre> val) where T:IConvertible {
        return new Quantity<double, Femtometre>(
            Convert.ToDouble(val.Value) * 10e21
        );
    }
	/// <summary>
    /// Extension method to convert Zettametre to Attometre
    /// </summary>
    /// <param name="val">quantity measured in Zettametre</param>
    /// <returns>quantity measured in Attometre</returns>
	public static Quantity<double, Attometre> ToAttometre<T>(this Quantity<T, Zettametre> val) where T:IConvertible {
        return new Quantity<double, Attometre>(
            Convert.ToDouble(val.Value) * 10e21
        );
    }
	/// <summary>
    /// Extension method to convert Zettametre to Zeptometre
    /// </summary>
    /// <param name="val">quantity measured in Zettametre</param>
    /// <returns>quantity measured in Zeptometre</returns>
	public static Quantity<double, Zeptometre> ToZeptometre<T>(this Quantity<T, Zettametre> val) where T:IConvertible {
        return new Quantity<double, Zeptometre>(
            Convert.ToDouble(val.Value) * 10e21
        );
    }
	/// <summary>
    /// Extension method to convert Zettametre to Yoctometre
    /// </summary>
    /// <param name="val">quantity measured in Zettametre</param>
    /// <returns>quantity measured in Yoctometre</returns>
	public static Quantity<double, Yoctometre> ToYoctometre<T>(this Quantity<T, Zettametre> val) where T:IConvertible {
        return new Quantity<double, Yoctometre>(
            Convert.ToDouble(val.Value) * 10e21
        );
    }
	/// <summary>
    /// Extension method to convert Exametre to Yottametre
    /// </summary>
    /// <param name="val">quantity measured in Exametre</param>
    /// <returns>quantity measured in Yottametre</returns>
	public static Quantity<double, Yottametre> ToYottametre<T>(this Quantity<T, Exametre> val) where T:IConvertible {
        return new Quantity<double, Yottametre>(
            Convert.ToDouble(val.Value) * 10e18
        );
    }
	/// <summary>
    /// Extension method to convert Exametre to Zettametre
    /// </summary>
    /// <param name="val">quantity measured in Exametre</param>
    /// <returns>quantity measured in Zettametre</returns>
	public static Quantity<double, Zettametre> ToZettametre<T>(this Quantity<T, Exametre> val) where T:IConvertible {
        return new Quantity<double, Zettametre>(
            Convert.ToDouble(val.Value) * 10e18
        );
    }
	/// <summary>
    /// Extension method to convert Exametre to Petametre
    /// </summary>
    /// <param name="val">quantity measured in Exametre</param>
    /// <returns>quantity measured in Petametre</returns>
	public static Quantity<double, Petametre> ToPetametre<T>(this Quantity<T, Exametre> val) where T:IConvertible {
        return new Quantity<double, Petametre>(
            Convert.ToDouble(val.Value) * 10e18
        );
    }
	/// <summary>
    /// Extension method to convert Exametre to Terametre
    /// </summary>
    /// <param name="val">quantity measured in Exametre</param>
    /// <returns>quantity measured in Terametre</returns>
	public static Quantity<double, Terametre> ToTerametre<T>(this Quantity<T, Exametre> val) where T:IConvertible {
        return new Quantity<double, Terametre>(
            Convert.ToDouble(val.Value) * 10e18
        );
    }
	/// <summary>
    /// Extension method to convert Exametre to Gigametre
    /// </summary>
    /// <param name="val">quantity measured in Exametre</param>
    /// <returns>quantity measured in Gigametre</returns>
	public static Quantity<double, Gigametre> ToGigametre<T>(this Quantity<T, Exametre> val) where T:IConvertible {
        return new Quantity<double, Gigametre>(
            Convert.ToDouble(val.Value) * 10e18
        );
    }
	/// <summary>
    /// Extension method to convert Exametre to Megametre
    /// </summary>
    /// <param name="val">quantity measured in Exametre</param>
    /// <returns>quantity measured in Megametre</returns>
	public static Quantity<double, Megametre> ToMegametre<T>(this Quantity<T, Exametre> val) where T:IConvertible {
        return new Quantity<double, Megametre>(
            Convert.ToDouble(val.Value) * 10e18
        );
    }
	/// <summary>
    /// Extension method to convert Exametre to Kilometre
    /// </summary>
    /// <param name="val">quantity measured in Exametre</param>
    /// <returns>quantity measured in Kilometre</returns>
	public static Quantity<double, Kilometre> ToKilometre<T>(this Quantity<T, Exametre> val) where T:IConvertible {
        return new Quantity<double, Kilometre>(
            Convert.ToDouble(val.Value) * 10e18
        );
    }
	/// <summary>
    /// Extension method to convert Exametre to Hectometre
    /// </summary>
    /// <param name="val">quantity measured in Exametre</param>
    /// <returns>quantity measured in Hectometre</returns>
	public static Quantity<double, Hectometre> ToHectometre<T>(this Quantity<T, Exametre> val) where T:IConvertible {
        return new Quantity<double, Hectometre>(
            Convert.ToDouble(val.Value) * 10e18
        );
    }
	/// <summary>
    /// Extension method to convert Exametre to Dekametre
    /// </summary>
    /// <param name="val">quantity measured in Exametre</param>
    /// <returns>quantity measured in Dekametre</returns>
	public static Quantity<double, Dekametre> ToDekametre<T>(this Quantity<T, Exametre> val) where T:IConvertible {
        return new Quantity<double, Dekametre>(
            Convert.ToDouble(val.Value) * 10e18
        );
    }
	/// <summary>
    /// Extension method to convert Exametre to Decimetre
    /// </summary>
    /// <param name="val">quantity measured in Exametre</param>
    /// <returns>quantity measured in Decimetre</returns>
	public static Quantity<double, Decimetre> ToDecimetre<T>(this Quantity<T, Exametre> val) where T:IConvertible {
        return new Quantity<double, Decimetre>(
            Convert.ToDouble(val.Value) * 10e18
        );
    }
	/// <summary>
    /// Extension method to convert Exametre to Centimetre
    /// </summary>
    /// <param name="val">quantity measured in Exametre</param>
    /// <returns>quantity measured in Centimetre</returns>
	public static Quantity<double, Centimetre> ToCentimetre<T>(this Quantity<T, Exametre> val) where T:IConvertible {
        return new Quantity<double, Centimetre>(
            Convert.ToDouble(val.Value) * 10e18
        );
    }
	/// <summary>
    /// Extension method to convert Exametre to Millimetre
    /// </summary>
    /// <param name="val">quantity measured in Exametre</param>
    /// <returns>quantity measured in Millimetre</returns>
	public static Quantity<double, Millimetre> ToMillimetre<T>(this Quantity<T, Exametre> val) where T:IConvertible {
        return new Quantity<double, Millimetre>(
            Convert.ToDouble(val.Value) * 10e18
        );
    }
	/// <summary>
    /// Extension method to convert Exametre to Micrometre
    /// </summary>
    /// <param name="val">quantity measured in Exametre</param>
    /// <returns>quantity measured in Micrometre</returns>
	public static Quantity<double, Micrometre> ToMicrometre<T>(this Quantity<T, Exametre> val) where T:IConvertible {
        return new Quantity<double, Micrometre>(
            Convert.ToDouble(val.Value) * 10e18
        );
    }
	/// <summary>
    /// Extension method to convert Exametre to Nanometre
    /// </summary>
    /// <param name="val">quantity measured in Exametre</param>
    /// <returns>quantity measured in Nanometre</returns>
	public static Quantity<double, Nanometre> ToNanometre<T>(this Quantity<T, Exametre> val) where T:IConvertible {
        return new Quantity<double, Nanometre>(
            Convert.ToDouble(val.Value) * 10e18
        );
    }
	/// <summary>
    /// Extension method to convert Exametre to Picometre
    /// </summary>
    /// <param name="val">quantity measured in Exametre</param>
    /// <returns>quantity measured in Picometre</returns>
	public static Quantity<double, Picometre> ToPicometre<T>(this Quantity<T, Exametre> val) where T:IConvertible {
        return new Quantity<double, Picometre>(
            Convert.ToDouble(val.Value) * 10e18
        );
    }
	/// <summary>
    /// Extension method to convert Exametre to Femtometre
    /// </summary>
    /// <param name="val">quantity measured in Exametre</param>
    /// <returns>quantity measured in Femtometre</returns>
	public static Quantity<double, Femtometre> ToFemtometre<T>(this Quantity<T, Exametre> val) where T:IConvertible {
        return new Quantity<double, Femtometre>(
            Convert.ToDouble(val.Value) * 10e18
        );
    }
	/// <summary>
    /// Extension method to convert Exametre to Attometre
    /// </summary>
    /// <param name="val">quantity measured in Exametre</param>
    /// <returns>quantity measured in Attometre</returns>
	public static Quantity<double, Attometre> ToAttometre<T>(this Quantity<T, Exametre> val) where T:IConvertible {
        return new Quantity<double, Attometre>(
            Convert.ToDouble(val.Value) * 10e18
        );
    }
	/// <summary>
    /// Extension method to convert Exametre to Zeptometre
    /// </summary>
    /// <param name="val">quantity measured in Exametre</param>
    /// <returns>quantity measured in Zeptometre</returns>
	public static Quantity<double, Zeptometre> ToZeptometre<T>(this Quantity<T, Exametre> val) where T:IConvertible {
        return new Quantity<double, Zeptometre>(
            Convert.ToDouble(val.Value) * 10e18
        );
    }
	/// <summary>
    /// Extension method to convert Exametre to Yoctometre
    /// </summary>
    /// <param name="val">quantity measured in Exametre</param>
    /// <returns>quantity measured in Yoctometre</returns>
	public static Quantity<double, Yoctometre> ToYoctometre<T>(this Quantity<T, Exametre> val) where T:IConvertible {
        return new Quantity<double, Yoctometre>(
            Convert.ToDouble(val.Value) * 10e18
        );
    }
	/// <summary>
    /// Extension method to convert Petametre to Yottametre
    /// </summary>
    /// <param name="val">quantity measured in Petametre</param>
    /// <returns>quantity measured in Yottametre</returns>
	public static Quantity<double, Yottametre> ToYottametre<T>(this Quantity<T, Petametre> val) where T:IConvertible {
        return new Quantity<double, Yottametre>(
            Convert.ToDouble(val.Value) * 10e15
        );
    }
	/// <summary>
    /// Extension method to convert Petametre to Zettametre
    /// </summary>
    /// <param name="val">quantity measured in Petametre</param>
    /// <returns>quantity measured in Zettametre</returns>
	public static Quantity<double, Zettametre> ToZettametre<T>(this Quantity<T, Petametre> val) where T:IConvertible {
        return new Quantity<double, Zettametre>(
            Convert.ToDouble(val.Value) * 10e15
        );
    }
	/// <summary>
    /// Extension method to convert Petametre to Exametre
    /// </summary>
    /// <param name="val">quantity measured in Petametre</param>
    /// <returns>quantity measured in Exametre</returns>
	public static Quantity<double, Exametre> ToExametre<T>(this Quantity<T, Petametre> val) where T:IConvertible {
        return new Quantity<double, Exametre>(
            Convert.ToDouble(val.Value) * 10e15
        );
    }
	/// <summary>
    /// Extension method to convert Petametre to Terametre
    /// </summary>
    /// <param name="val">quantity measured in Petametre</param>
    /// <returns>quantity measured in Terametre</returns>
	public static Quantity<double, Terametre> ToTerametre<T>(this Quantity<T, Petametre> val) where T:IConvertible {
        return new Quantity<double, Terametre>(
            Convert.ToDouble(val.Value) * 10e15
        );
    }
	/// <summary>
    /// Extension method to convert Petametre to Gigametre
    /// </summary>
    /// <param name="val">quantity measured in Petametre</param>
    /// <returns>quantity measured in Gigametre</returns>
	public static Quantity<double, Gigametre> ToGigametre<T>(this Quantity<T, Petametre> val) where T:IConvertible {
        return new Quantity<double, Gigametre>(
            Convert.ToDouble(val.Value) * 10e15
        );
    }
	/// <summary>
    /// Extension method to convert Petametre to Megametre
    /// </summary>
    /// <param name="val">quantity measured in Petametre</param>
    /// <returns>quantity measured in Megametre</returns>
	public static Quantity<double, Megametre> ToMegametre<T>(this Quantity<T, Petametre> val) where T:IConvertible {
        return new Quantity<double, Megametre>(
            Convert.ToDouble(val.Value) * 10e15
        );
    }
	/// <summary>
    /// Extension method to convert Petametre to Kilometre
    /// </summary>
    /// <param name="val">quantity measured in Petametre</param>
    /// <returns>quantity measured in Kilometre</returns>
	public static Quantity<double, Kilometre> ToKilometre<T>(this Quantity<T, Petametre> val) where T:IConvertible {
        return new Quantity<double, Kilometre>(
            Convert.ToDouble(val.Value) * 10e15
        );
    }
	/// <summary>
    /// Extension method to convert Petametre to Hectometre
    /// </summary>
    /// <param name="val">quantity measured in Petametre</param>
    /// <returns>quantity measured in Hectometre</returns>
	public static Quantity<double, Hectometre> ToHectometre<T>(this Quantity<T, Petametre> val) where T:IConvertible {
        return new Quantity<double, Hectometre>(
            Convert.ToDouble(val.Value) * 10e15
        );
    }
	/// <summary>
    /// Extension method to convert Petametre to Dekametre
    /// </summary>
    /// <param name="val">quantity measured in Petametre</param>
    /// <returns>quantity measured in Dekametre</returns>
	public static Quantity<double, Dekametre> ToDekametre<T>(this Quantity<T, Petametre> val) where T:IConvertible {
        return new Quantity<double, Dekametre>(
            Convert.ToDouble(val.Value) * 10e15
        );
    }
	/// <summary>
    /// Extension method to convert Petametre to Decimetre
    /// </summary>
    /// <param name="val">quantity measured in Petametre</param>
    /// <returns>quantity measured in Decimetre</returns>
	public static Quantity<double, Decimetre> ToDecimetre<T>(this Quantity<T, Petametre> val) where T:IConvertible {
        return new Quantity<double, Decimetre>(
            Convert.ToDouble(val.Value) * 10e15
        );
    }
	/// <summary>
    /// Extension method to convert Petametre to Centimetre
    /// </summary>
    /// <param name="val">quantity measured in Petametre</param>
    /// <returns>quantity measured in Centimetre</returns>
	public static Quantity<double, Centimetre> ToCentimetre<T>(this Quantity<T, Petametre> val) where T:IConvertible {
        return new Quantity<double, Centimetre>(
            Convert.ToDouble(val.Value) * 10e15
        );
    }
	/// <summary>
    /// Extension method to convert Petametre to Millimetre
    /// </summary>
    /// <param name="val">quantity measured in Petametre</param>
    /// <returns>quantity measured in Millimetre</returns>
	public static Quantity<double, Millimetre> ToMillimetre<T>(this Quantity<T, Petametre> val) where T:IConvertible {
        return new Quantity<double, Millimetre>(
            Convert.ToDouble(val.Value) * 10e15
        );
    }
	/// <summary>
    /// Extension method to convert Petametre to Micrometre
    /// </summary>
    /// <param name="val">quantity measured in Petametre</param>
    /// <returns>quantity measured in Micrometre</returns>
	public static Quantity<double, Micrometre> ToMicrometre<T>(this Quantity<T, Petametre> val) where T:IConvertible {
        return new Quantity<double, Micrometre>(
            Convert.ToDouble(val.Value) * 10e15
        );
    }
	/// <summary>
    /// Extension method to convert Petametre to Nanometre
    /// </summary>
    /// <param name="val">quantity measured in Petametre</param>
    /// <returns>quantity measured in Nanometre</returns>
	public static Quantity<double, Nanometre> ToNanometre<T>(this Quantity<T, Petametre> val) where T:IConvertible {
        return new Quantity<double, Nanometre>(
            Convert.ToDouble(val.Value) * 10e15
        );
    }
	/// <summary>
    /// Extension method to convert Petametre to Picometre
    /// </summary>
    /// <param name="val">quantity measured in Petametre</param>
    /// <returns>quantity measured in Picometre</returns>
	public static Quantity<double, Picometre> ToPicometre<T>(this Quantity<T, Petametre> val) where T:IConvertible {
        return new Quantity<double, Picometre>(
            Convert.ToDouble(val.Value) * 10e15
        );
    }
	/// <summary>
    /// Extension method to convert Petametre to Femtometre
    /// </summary>
    /// <param name="val">quantity measured in Petametre</param>
    /// <returns>quantity measured in Femtometre</returns>
	public static Quantity<double, Femtometre> ToFemtometre<T>(this Quantity<T, Petametre> val) where T:IConvertible {
        return new Quantity<double, Femtometre>(
            Convert.ToDouble(val.Value) * 10e15
        );
    }
	/// <summary>
    /// Extension method to convert Petametre to Attometre
    /// </summary>
    /// <param name="val">quantity measured in Petametre</param>
    /// <returns>quantity measured in Attometre</returns>
	public static Quantity<double, Attometre> ToAttometre<T>(this Quantity<T, Petametre> val) where T:IConvertible {
        return new Quantity<double, Attometre>(
            Convert.ToDouble(val.Value) * 10e15
        );
    }
	/// <summary>
    /// Extension method to convert Petametre to Zeptometre
    /// </summary>
    /// <param name="val">quantity measured in Petametre</param>
    /// <returns>quantity measured in Zeptometre</returns>
	public static Quantity<double, Zeptometre> ToZeptometre<T>(this Quantity<T, Petametre> val) where T:IConvertible {
        return new Quantity<double, Zeptometre>(
            Convert.ToDouble(val.Value) * 10e15
        );
    }
	/// <summary>
    /// Extension method to convert Petametre to Yoctometre
    /// </summary>
    /// <param name="val">quantity measured in Petametre</param>
    /// <returns>quantity measured in Yoctometre</returns>
	public static Quantity<double, Yoctometre> ToYoctometre<T>(this Quantity<T, Petametre> val) where T:IConvertible {
        return new Quantity<double, Yoctometre>(
            Convert.ToDouble(val.Value) * 10e15
        );
    }
	/// <summary>
    /// Extension method to convert Terametre to Yottametre
    /// </summary>
    /// <param name="val">quantity measured in Terametre</param>
    /// <returns>quantity measured in Yottametre</returns>
	public static Quantity<double, Yottametre> ToYottametre<T>(this Quantity<T, Terametre> val) where T:IConvertible {
        return new Quantity<double, Yottametre>(
            Convert.ToDouble(val.Value) * 10e12
        );
    }
	/// <summary>
    /// Extension method to convert Terametre to Zettametre
    /// </summary>
    /// <param name="val">quantity measured in Terametre</param>
    /// <returns>quantity measured in Zettametre</returns>
	public static Quantity<double, Zettametre> ToZettametre<T>(this Quantity<T, Terametre> val) where T:IConvertible {
        return new Quantity<double, Zettametre>(
            Convert.ToDouble(val.Value) * 10e12
        );
    }
	/// <summary>
    /// Extension method to convert Terametre to Exametre
    /// </summary>
    /// <param name="val">quantity measured in Terametre</param>
    /// <returns>quantity measured in Exametre</returns>
	public static Quantity<double, Exametre> ToExametre<T>(this Quantity<T, Terametre> val) where T:IConvertible {
        return new Quantity<double, Exametre>(
            Convert.ToDouble(val.Value) * 10e12
        );
    }
	/// <summary>
    /// Extension method to convert Terametre to Petametre
    /// </summary>
    /// <param name="val">quantity measured in Terametre</param>
    /// <returns>quantity measured in Petametre</returns>
	public static Quantity<double, Petametre> ToPetametre<T>(this Quantity<T, Terametre> val) where T:IConvertible {
        return new Quantity<double, Petametre>(
            Convert.ToDouble(val.Value) * 10e12
        );
    }
	/// <summary>
    /// Extension method to convert Terametre to Gigametre
    /// </summary>
    /// <param name="val">quantity measured in Terametre</param>
    /// <returns>quantity measured in Gigametre</returns>
	public static Quantity<double, Gigametre> ToGigametre<T>(this Quantity<T, Terametre> val) where T:IConvertible {
        return new Quantity<double, Gigametre>(
            Convert.ToDouble(val.Value) * 10e12
        );
    }
	/// <summary>
    /// Extension method to convert Terametre to Megametre
    /// </summary>
    /// <param name="val">quantity measured in Terametre</param>
    /// <returns>quantity measured in Megametre</returns>
	public static Quantity<double, Megametre> ToMegametre<T>(this Quantity<T, Terametre> val) where T:IConvertible {
        return new Quantity<double, Megametre>(
            Convert.ToDouble(val.Value) * 10e12
        );
    }
	/// <summary>
    /// Extension method to convert Terametre to Kilometre
    /// </summary>
    /// <param name="val">quantity measured in Terametre</param>
    /// <returns>quantity measured in Kilometre</returns>
	public static Quantity<double, Kilometre> ToKilometre<T>(this Quantity<T, Terametre> val) where T:IConvertible {
        return new Quantity<double, Kilometre>(
            Convert.ToDouble(val.Value) * 10e12
        );
    }
	/// <summary>
    /// Extension method to convert Terametre to Hectometre
    /// </summary>
    /// <param name="val">quantity measured in Terametre</param>
    /// <returns>quantity measured in Hectometre</returns>
	public static Quantity<double, Hectometre> ToHectometre<T>(this Quantity<T, Terametre> val) where T:IConvertible {
        return new Quantity<double, Hectometre>(
            Convert.ToDouble(val.Value) * 10e12
        );
    }
	/// <summary>
    /// Extension method to convert Terametre to Dekametre
    /// </summary>
    /// <param name="val">quantity measured in Terametre</param>
    /// <returns>quantity measured in Dekametre</returns>
	public static Quantity<double, Dekametre> ToDekametre<T>(this Quantity<T, Terametre> val) where T:IConvertible {
        return new Quantity<double, Dekametre>(
            Convert.ToDouble(val.Value) * 10e12
        );
    }
	/// <summary>
    /// Extension method to convert Terametre to Decimetre
    /// </summary>
    /// <param name="val">quantity measured in Terametre</param>
    /// <returns>quantity measured in Decimetre</returns>
	public static Quantity<double, Decimetre> ToDecimetre<T>(this Quantity<T, Terametre> val) where T:IConvertible {
        return new Quantity<double, Decimetre>(
            Convert.ToDouble(val.Value) * 10e12
        );
    }
	/// <summary>
    /// Extension method to convert Terametre to Centimetre
    /// </summary>
    /// <param name="val">quantity measured in Terametre</param>
    /// <returns>quantity measured in Centimetre</returns>
	public static Quantity<double, Centimetre> ToCentimetre<T>(this Quantity<T, Terametre> val) where T:IConvertible {
        return new Quantity<double, Centimetre>(
            Convert.ToDouble(val.Value) * 10e12
        );
    }
	/// <summary>
    /// Extension method to convert Terametre to Millimetre
    /// </summary>
    /// <param name="val">quantity measured in Terametre</param>
    /// <returns>quantity measured in Millimetre</returns>
	public static Quantity<double, Millimetre> ToMillimetre<T>(this Quantity<T, Terametre> val) where T:IConvertible {
        return new Quantity<double, Millimetre>(
            Convert.ToDouble(val.Value) * 10e12
        );
    }
	/// <summary>
    /// Extension method to convert Terametre to Micrometre
    /// </summary>
    /// <param name="val">quantity measured in Terametre</param>
    /// <returns>quantity measured in Micrometre</returns>
	public static Quantity<double, Micrometre> ToMicrometre<T>(this Quantity<T, Terametre> val) where T:IConvertible {
        return new Quantity<double, Micrometre>(
            Convert.ToDouble(val.Value) * 10e12
        );
    }
	/// <summary>
    /// Extension method to convert Terametre to Nanometre
    /// </summary>
    /// <param name="val">quantity measured in Terametre</param>
    /// <returns>quantity measured in Nanometre</returns>
	public static Quantity<double, Nanometre> ToNanometre<T>(this Quantity<T, Terametre> val) where T:IConvertible {
        return new Quantity<double, Nanometre>(
            Convert.ToDouble(val.Value) * 10e12
        );
    }
	/// <summary>
    /// Extension method to convert Terametre to Picometre
    /// </summary>
    /// <param name="val">quantity measured in Terametre</param>
    /// <returns>quantity measured in Picometre</returns>
	public static Quantity<double, Picometre> ToPicometre<T>(this Quantity<T, Terametre> val) where T:IConvertible {
        return new Quantity<double, Picometre>(
            Convert.ToDouble(val.Value) * 10e12
        );
    }
	/// <summary>
    /// Extension method to convert Terametre to Femtometre
    /// </summary>
    /// <param name="val">quantity measured in Terametre</param>
    /// <returns>quantity measured in Femtometre</returns>
	public static Quantity<double, Femtometre> ToFemtometre<T>(this Quantity<T, Terametre> val) where T:IConvertible {
        return new Quantity<double, Femtometre>(
            Convert.ToDouble(val.Value) * 10e12
        );
    }
	/// <summary>
    /// Extension method to convert Terametre to Attometre
    /// </summary>
    /// <param name="val">quantity measured in Terametre</param>
    /// <returns>quantity measured in Attometre</returns>
	public static Quantity<double, Attometre> ToAttometre<T>(this Quantity<T, Terametre> val) where T:IConvertible {
        return new Quantity<double, Attometre>(
            Convert.ToDouble(val.Value) * 10e12
        );
    }
	/// <summary>
    /// Extension method to convert Terametre to Zeptometre
    /// </summary>
    /// <param name="val">quantity measured in Terametre</param>
    /// <returns>quantity measured in Zeptometre</returns>
	public static Quantity<double, Zeptometre> ToZeptometre<T>(this Quantity<T, Terametre> val) where T:IConvertible {
        return new Quantity<double, Zeptometre>(
            Convert.ToDouble(val.Value) * 10e12
        );
    }
	/// <summary>
    /// Extension method to convert Terametre to Yoctometre
    /// </summary>
    /// <param name="val">quantity measured in Terametre</param>
    /// <returns>quantity measured in Yoctometre</returns>
	public static Quantity<double, Yoctometre> ToYoctometre<T>(this Quantity<T, Terametre> val) where T:IConvertible {
        return new Quantity<double, Yoctometre>(
            Convert.ToDouble(val.Value) * 10e12
        );
    }
	/// <summary>
    /// Extension method to convert Gigametre to Yottametre
    /// </summary>
    /// <param name="val">quantity measured in Gigametre</param>
    /// <returns>quantity measured in Yottametre</returns>
	public static Quantity<double, Yottametre> ToYottametre<T>(this Quantity<T, Gigametre> val) where T:IConvertible {
        return new Quantity<double, Yottametre>(
            Convert.ToDouble(val.Value) * 10e9
        );
    }
	/// <summary>
    /// Extension method to convert Gigametre to Zettametre
    /// </summary>
    /// <param name="val">quantity measured in Gigametre</param>
    /// <returns>quantity measured in Zettametre</returns>
	public static Quantity<double, Zettametre> ToZettametre<T>(this Quantity<T, Gigametre> val) where T:IConvertible {
        return new Quantity<double, Zettametre>(
            Convert.ToDouble(val.Value) * 10e9
        );
    }
	/// <summary>
    /// Extension method to convert Gigametre to Exametre
    /// </summary>
    /// <param name="val">quantity measured in Gigametre</param>
    /// <returns>quantity measured in Exametre</returns>
	public static Quantity<double, Exametre> ToExametre<T>(this Quantity<T, Gigametre> val) where T:IConvertible {
        return new Quantity<double, Exametre>(
            Convert.ToDouble(val.Value) * 10e9
        );
    }
	/// <summary>
    /// Extension method to convert Gigametre to Petametre
    /// </summary>
    /// <param name="val">quantity measured in Gigametre</param>
    /// <returns>quantity measured in Petametre</returns>
	public static Quantity<double, Petametre> ToPetametre<T>(this Quantity<T, Gigametre> val) where T:IConvertible {
        return new Quantity<double, Petametre>(
            Convert.ToDouble(val.Value) * 10e9
        );
    }
	/// <summary>
    /// Extension method to convert Gigametre to Terametre
    /// </summary>
    /// <param name="val">quantity measured in Gigametre</param>
    /// <returns>quantity measured in Terametre</returns>
	public static Quantity<double, Terametre> ToTerametre<T>(this Quantity<T, Gigametre> val) where T:IConvertible {
        return new Quantity<double, Terametre>(
            Convert.ToDouble(val.Value) * 10e9
        );
    }
	/// <summary>
    /// Extension method to convert Gigametre to Megametre
    /// </summary>
    /// <param name="val">quantity measured in Gigametre</param>
    /// <returns>quantity measured in Megametre</returns>
	public static Quantity<double, Megametre> ToMegametre<T>(this Quantity<T, Gigametre> val) where T:IConvertible {
        return new Quantity<double, Megametre>(
            Convert.ToDouble(val.Value) * 10e9
        );
    }
	/// <summary>
    /// Extension method to convert Gigametre to Kilometre
    /// </summary>
    /// <param name="val">quantity measured in Gigametre</param>
    /// <returns>quantity measured in Kilometre</returns>
	public static Quantity<double, Kilometre> ToKilometre<T>(this Quantity<T, Gigametre> val) where T:IConvertible {
        return new Quantity<double, Kilometre>(
            Convert.ToDouble(val.Value) * 10e9
        );
    }
	/// <summary>
    /// Extension method to convert Gigametre to Hectometre
    /// </summary>
    /// <param name="val">quantity measured in Gigametre</param>
    /// <returns>quantity measured in Hectometre</returns>
	public static Quantity<double, Hectometre> ToHectometre<T>(this Quantity<T, Gigametre> val) where T:IConvertible {
        return new Quantity<double, Hectometre>(
            Convert.ToDouble(val.Value) * 10e9
        );
    }
	/// <summary>
    /// Extension method to convert Gigametre to Dekametre
    /// </summary>
    /// <param name="val">quantity measured in Gigametre</param>
    /// <returns>quantity measured in Dekametre</returns>
	public static Quantity<double, Dekametre> ToDekametre<T>(this Quantity<T, Gigametre> val) where T:IConvertible {
        return new Quantity<double, Dekametre>(
            Convert.ToDouble(val.Value) * 10e9
        );
    }
	/// <summary>
    /// Extension method to convert Gigametre to Decimetre
    /// </summary>
    /// <param name="val">quantity measured in Gigametre</param>
    /// <returns>quantity measured in Decimetre</returns>
	public static Quantity<double, Decimetre> ToDecimetre<T>(this Quantity<T, Gigametre> val) where T:IConvertible {
        return new Quantity<double, Decimetre>(
            Convert.ToDouble(val.Value) * 10e9
        );
    }
	/// <summary>
    /// Extension method to convert Gigametre to Centimetre
    /// </summary>
    /// <param name="val">quantity measured in Gigametre</param>
    /// <returns>quantity measured in Centimetre</returns>
	public static Quantity<double, Centimetre> ToCentimetre<T>(this Quantity<T, Gigametre> val) where T:IConvertible {
        return new Quantity<double, Centimetre>(
            Convert.ToDouble(val.Value) * 10e9
        );
    }
	/// <summary>
    /// Extension method to convert Gigametre to Millimetre
    /// </summary>
    /// <param name="val">quantity measured in Gigametre</param>
    /// <returns>quantity measured in Millimetre</returns>
	public static Quantity<double, Millimetre> ToMillimetre<T>(this Quantity<T, Gigametre> val) where T:IConvertible {
        return new Quantity<double, Millimetre>(
            Convert.ToDouble(val.Value) * 10e9
        );
    }
	/// <summary>
    /// Extension method to convert Gigametre to Micrometre
    /// </summary>
    /// <param name="val">quantity measured in Gigametre</param>
    /// <returns>quantity measured in Micrometre</returns>
	public static Quantity<double, Micrometre> ToMicrometre<T>(this Quantity<T, Gigametre> val) where T:IConvertible {
        return new Quantity<double, Micrometre>(
            Convert.ToDouble(val.Value) * 10e9
        );
    }
	/// <summary>
    /// Extension method to convert Gigametre to Nanometre
    /// </summary>
    /// <param name="val">quantity measured in Gigametre</param>
    /// <returns>quantity measured in Nanometre</returns>
	public static Quantity<double, Nanometre> ToNanometre<T>(this Quantity<T, Gigametre> val) where T:IConvertible {
        return new Quantity<double, Nanometre>(
            Convert.ToDouble(val.Value) * 10e9
        );
    }
	/// <summary>
    /// Extension method to convert Gigametre to Picometre
    /// </summary>
    /// <param name="val">quantity measured in Gigametre</param>
    /// <returns>quantity measured in Picometre</returns>
	public static Quantity<double, Picometre> ToPicometre<T>(this Quantity<T, Gigametre> val) where T:IConvertible {
        return new Quantity<double, Picometre>(
            Convert.ToDouble(val.Value) * 10e9
        );
    }
	/// <summary>
    /// Extension method to convert Gigametre to Femtometre
    /// </summary>
    /// <param name="val">quantity measured in Gigametre</param>
    /// <returns>quantity measured in Femtometre</returns>
	public static Quantity<double, Femtometre> ToFemtometre<T>(this Quantity<T, Gigametre> val) where T:IConvertible {
        return new Quantity<double, Femtometre>(
            Convert.ToDouble(val.Value) * 10e9
        );
    }
	/// <summary>
    /// Extension method to convert Gigametre to Attometre
    /// </summary>
    /// <param name="val">quantity measured in Gigametre</param>
    /// <returns>quantity measured in Attometre</returns>
	public static Quantity<double, Attometre> ToAttometre<T>(this Quantity<T, Gigametre> val) where T:IConvertible {
        return new Quantity<double, Attometre>(
            Convert.ToDouble(val.Value) * 10e9
        );
    }
	/// <summary>
    /// Extension method to convert Gigametre to Zeptometre
    /// </summary>
    /// <param name="val">quantity measured in Gigametre</param>
    /// <returns>quantity measured in Zeptometre</returns>
	public static Quantity<double, Zeptometre> ToZeptometre<T>(this Quantity<T, Gigametre> val) where T:IConvertible {
        return new Quantity<double, Zeptometre>(
            Convert.ToDouble(val.Value) * 10e9
        );
    }
	/// <summary>
    /// Extension method to convert Gigametre to Yoctometre
    /// </summary>
    /// <param name="val">quantity measured in Gigametre</param>
    /// <returns>quantity measured in Yoctometre</returns>
	public static Quantity<double, Yoctometre> ToYoctometre<T>(this Quantity<T, Gigametre> val) where T:IConvertible {
        return new Quantity<double, Yoctometre>(
            Convert.ToDouble(val.Value) * 10e9
        );
    }
	/// <summary>
    /// Extension method to convert Megametre to Yottametre
    /// </summary>
    /// <param name="val">quantity measured in Megametre</param>
    /// <returns>quantity measured in Yottametre</returns>
	public static Quantity<double, Yottametre> ToYottametre<T>(this Quantity<T, Megametre> val) where T:IConvertible {
        return new Quantity<double, Yottametre>(
            Convert.ToDouble(val.Value) * 10e6
        );
    }
	/// <summary>
    /// Extension method to convert Megametre to Zettametre
    /// </summary>
    /// <param name="val">quantity measured in Megametre</param>
    /// <returns>quantity measured in Zettametre</returns>
	public static Quantity<double, Zettametre> ToZettametre<T>(this Quantity<T, Megametre> val) where T:IConvertible {
        return new Quantity<double, Zettametre>(
            Convert.ToDouble(val.Value) * 10e6
        );
    }
	/// <summary>
    /// Extension method to convert Megametre to Exametre
    /// </summary>
    /// <param name="val">quantity measured in Megametre</param>
    /// <returns>quantity measured in Exametre</returns>
	public static Quantity<double, Exametre> ToExametre<T>(this Quantity<T, Megametre> val) where T:IConvertible {
        return new Quantity<double, Exametre>(
            Convert.ToDouble(val.Value) * 10e6
        );
    }
	/// <summary>
    /// Extension method to convert Megametre to Petametre
    /// </summary>
    /// <param name="val">quantity measured in Megametre</param>
    /// <returns>quantity measured in Petametre</returns>
	public static Quantity<double, Petametre> ToPetametre<T>(this Quantity<T, Megametre> val) where T:IConvertible {
        return new Quantity<double, Petametre>(
            Convert.ToDouble(val.Value) * 10e6
        );
    }
	/// <summary>
    /// Extension method to convert Megametre to Terametre
    /// </summary>
    /// <param name="val">quantity measured in Megametre</param>
    /// <returns>quantity measured in Terametre</returns>
	public static Quantity<double, Terametre> ToTerametre<T>(this Quantity<T, Megametre> val) where T:IConvertible {
        return new Quantity<double, Terametre>(
            Convert.ToDouble(val.Value) * 10e6
        );
    }
	/// <summary>
    /// Extension method to convert Megametre to Gigametre
    /// </summary>
    /// <param name="val">quantity measured in Megametre</param>
    /// <returns>quantity measured in Gigametre</returns>
	public static Quantity<double, Gigametre> ToGigametre<T>(this Quantity<T, Megametre> val) where T:IConvertible {
        return new Quantity<double, Gigametre>(
            Convert.ToDouble(val.Value) * 10e6
        );
    }
	/// <summary>
    /// Extension method to convert Megametre to Kilometre
    /// </summary>
    /// <param name="val">quantity measured in Megametre</param>
    /// <returns>quantity measured in Kilometre</returns>
	public static Quantity<double, Kilometre> ToKilometre<T>(this Quantity<T, Megametre> val) where T:IConvertible {
        return new Quantity<double, Kilometre>(
            Convert.ToDouble(val.Value) * 10e6
        );
    }
	/// <summary>
    /// Extension method to convert Megametre to Hectometre
    /// </summary>
    /// <param name="val">quantity measured in Megametre</param>
    /// <returns>quantity measured in Hectometre</returns>
	public static Quantity<double, Hectometre> ToHectometre<T>(this Quantity<T, Megametre> val) where T:IConvertible {
        return new Quantity<double, Hectometre>(
            Convert.ToDouble(val.Value) * 10e6
        );
    }
	/// <summary>
    /// Extension method to convert Megametre to Dekametre
    /// </summary>
    /// <param name="val">quantity measured in Megametre</param>
    /// <returns>quantity measured in Dekametre</returns>
	public static Quantity<double, Dekametre> ToDekametre<T>(this Quantity<T, Megametre> val) where T:IConvertible {
        return new Quantity<double, Dekametre>(
            Convert.ToDouble(val.Value) * 10e6
        );
    }
	/// <summary>
    /// Extension method to convert Megametre to Decimetre
    /// </summary>
    /// <param name="val">quantity measured in Megametre</param>
    /// <returns>quantity measured in Decimetre</returns>
	public static Quantity<double, Decimetre> ToDecimetre<T>(this Quantity<T, Megametre> val) where T:IConvertible {
        return new Quantity<double, Decimetre>(
            Convert.ToDouble(val.Value) * 10e6
        );
    }
	/// <summary>
    /// Extension method to convert Megametre to Centimetre
    /// </summary>
    /// <param name="val">quantity measured in Megametre</param>
    /// <returns>quantity measured in Centimetre</returns>
	public static Quantity<double, Centimetre> ToCentimetre<T>(this Quantity<T, Megametre> val) where T:IConvertible {
        return new Quantity<double, Centimetre>(
            Convert.ToDouble(val.Value) * 10e6
        );
    }
	/// <summary>
    /// Extension method to convert Megametre to Millimetre
    /// </summary>
    /// <param name="val">quantity measured in Megametre</param>
    /// <returns>quantity measured in Millimetre</returns>
	public static Quantity<double, Millimetre> ToMillimetre<T>(this Quantity<T, Megametre> val) where T:IConvertible {
        return new Quantity<double, Millimetre>(
            Convert.ToDouble(val.Value) * 10e6
        );
    }
	/// <summary>
    /// Extension method to convert Megametre to Micrometre
    /// </summary>
    /// <param name="val">quantity measured in Megametre</param>
    /// <returns>quantity measured in Micrometre</returns>
	public static Quantity<double, Micrometre> ToMicrometre<T>(this Quantity<T, Megametre> val) where T:IConvertible {
        return new Quantity<double, Micrometre>(
            Convert.ToDouble(val.Value) * 10e6
        );
    }
	/// <summary>
    /// Extension method to convert Megametre to Nanometre
    /// </summary>
    /// <param name="val">quantity measured in Megametre</param>
    /// <returns>quantity measured in Nanometre</returns>
	public static Quantity<double, Nanometre> ToNanometre<T>(this Quantity<T, Megametre> val) where T:IConvertible {
        return new Quantity<double, Nanometre>(
            Convert.ToDouble(val.Value) * 10e6
        );
    }
	/// <summary>
    /// Extension method to convert Megametre to Picometre
    /// </summary>
    /// <param name="val">quantity measured in Megametre</param>
    /// <returns>quantity measured in Picometre</returns>
	public static Quantity<double, Picometre> ToPicometre<T>(this Quantity<T, Megametre> val) where T:IConvertible {
        return new Quantity<double, Picometre>(
            Convert.ToDouble(val.Value) * 10e6
        );
    }
	/// <summary>
    /// Extension method to convert Megametre to Femtometre
    /// </summary>
    /// <param name="val">quantity measured in Megametre</param>
    /// <returns>quantity measured in Femtometre</returns>
	public static Quantity<double, Femtometre> ToFemtometre<T>(this Quantity<T, Megametre> val) where T:IConvertible {
        return new Quantity<double, Femtometre>(
            Convert.ToDouble(val.Value) * 10e6
        );
    }
	/// <summary>
    /// Extension method to convert Megametre to Attometre
    /// </summary>
    /// <param name="val">quantity measured in Megametre</param>
    /// <returns>quantity measured in Attometre</returns>
	public static Quantity<double, Attometre> ToAttometre<T>(this Quantity<T, Megametre> val) where T:IConvertible {
        return new Quantity<double, Attometre>(
            Convert.ToDouble(val.Value) * 10e6
        );
    }
	/// <summary>
    /// Extension method to convert Megametre to Zeptometre
    /// </summary>
    /// <param name="val">quantity measured in Megametre</param>
    /// <returns>quantity measured in Zeptometre</returns>
	public static Quantity<double, Zeptometre> ToZeptometre<T>(this Quantity<T, Megametre> val) where T:IConvertible {
        return new Quantity<double, Zeptometre>(
            Convert.ToDouble(val.Value) * 10e6
        );
    }
	/// <summary>
    /// Extension method to convert Megametre to Yoctometre
    /// </summary>
    /// <param name="val">quantity measured in Megametre</param>
    /// <returns>quantity measured in Yoctometre</returns>
	public static Quantity<double, Yoctometre> ToYoctometre<T>(this Quantity<T, Megametre> val) where T:IConvertible {
        return new Quantity<double, Yoctometre>(
            Convert.ToDouble(val.Value) * 10e6
        );
    }
	/// <summary>
    /// Extension method to convert Kilometre to Yottametre
    /// </summary>
    /// <param name="val">quantity measured in Kilometre</param>
    /// <returns>quantity measured in Yottametre</returns>
	public static Quantity<double, Yottametre> ToYottametre<T>(this Quantity<T, Kilometre> val) where T:IConvertible {
        return new Quantity<double, Yottametre>(
            Convert.ToDouble(val.Value) * 10e3
        );
    }
	/// <summary>
    /// Extension method to convert Kilometre to Zettametre
    /// </summary>
    /// <param name="val">quantity measured in Kilometre</param>
    /// <returns>quantity measured in Zettametre</returns>
	public static Quantity<double, Zettametre> ToZettametre<T>(this Quantity<T, Kilometre> val) where T:IConvertible {
        return new Quantity<double, Zettametre>(
            Convert.ToDouble(val.Value) * 10e3
        );
    }
	/// <summary>
    /// Extension method to convert Kilometre to Exametre
    /// </summary>
    /// <param name="val">quantity measured in Kilometre</param>
    /// <returns>quantity measured in Exametre</returns>
	public static Quantity<double, Exametre> ToExametre<T>(this Quantity<T, Kilometre> val) where T:IConvertible {
        return new Quantity<double, Exametre>(
            Convert.ToDouble(val.Value) * 10e3
        );
    }
	/// <summary>
    /// Extension method to convert Kilometre to Petametre
    /// </summary>
    /// <param name="val">quantity measured in Kilometre</param>
    /// <returns>quantity measured in Petametre</returns>
	public static Quantity<double, Petametre> ToPetametre<T>(this Quantity<T, Kilometre> val) where T:IConvertible {
        return new Quantity<double, Petametre>(
            Convert.ToDouble(val.Value) * 10e3
        );
    }
	/// <summary>
    /// Extension method to convert Kilometre to Terametre
    /// </summary>
    /// <param name="val">quantity measured in Kilometre</param>
    /// <returns>quantity measured in Terametre</returns>
	public static Quantity<double, Terametre> ToTerametre<T>(this Quantity<T, Kilometre> val) where T:IConvertible {
        return new Quantity<double, Terametre>(
            Convert.ToDouble(val.Value) * 10e3
        );
    }
	/// <summary>
    /// Extension method to convert Kilometre to Gigametre
    /// </summary>
    /// <param name="val">quantity measured in Kilometre</param>
    /// <returns>quantity measured in Gigametre</returns>
	public static Quantity<double, Gigametre> ToGigametre<T>(this Quantity<T, Kilometre> val) where T:IConvertible {
        return new Quantity<double, Gigametre>(
            Convert.ToDouble(val.Value) * 10e3
        );
    }
	/// <summary>
    /// Extension method to convert Kilometre to Megametre
    /// </summary>
    /// <param name="val">quantity measured in Kilometre</param>
    /// <returns>quantity measured in Megametre</returns>
	public static Quantity<double, Megametre> ToMegametre<T>(this Quantity<T, Kilometre> val) where T:IConvertible {
        return new Quantity<double, Megametre>(
            Convert.ToDouble(val.Value) * 10e3
        );
    }
	/// <summary>
    /// Extension method to convert Kilometre to Hectometre
    /// </summary>
    /// <param name="val">quantity measured in Kilometre</param>
    /// <returns>quantity measured in Hectometre</returns>
	public static Quantity<double, Hectometre> ToHectometre<T>(this Quantity<T, Kilometre> val) where T:IConvertible {
        return new Quantity<double, Hectometre>(
            Convert.ToDouble(val.Value) * 10e3
        );
    }
	/// <summary>
    /// Extension method to convert Kilometre to Dekametre
    /// </summary>
    /// <param name="val">quantity measured in Kilometre</param>
    /// <returns>quantity measured in Dekametre</returns>
	public static Quantity<double, Dekametre> ToDekametre<T>(this Quantity<T, Kilometre> val) where T:IConvertible {
        return new Quantity<double, Dekametre>(
            Convert.ToDouble(val.Value) * 10e3
        );
    }
	/// <summary>
    /// Extension method to convert Kilometre to Decimetre
    /// </summary>
    /// <param name="val">quantity measured in Kilometre</param>
    /// <returns>quantity measured in Decimetre</returns>
	public static Quantity<double, Decimetre> ToDecimetre<T>(this Quantity<T, Kilometre> val) where T:IConvertible {
        return new Quantity<double, Decimetre>(
            Convert.ToDouble(val.Value) * 10e3
        );
    }
	/// <summary>
    /// Extension method to convert Kilometre to Centimetre
    /// </summary>
    /// <param name="val">quantity measured in Kilometre</param>
    /// <returns>quantity measured in Centimetre</returns>
	public static Quantity<double, Centimetre> ToCentimetre<T>(this Quantity<T, Kilometre> val) where T:IConvertible {
        return new Quantity<double, Centimetre>(
            Convert.ToDouble(val.Value) * 10e3
        );
    }
	/// <summary>
    /// Extension method to convert Kilometre to Millimetre
    /// </summary>
    /// <param name="val">quantity measured in Kilometre</param>
    /// <returns>quantity measured in Millimetre</returns>
	public static Quantity<double, Millimetre> ToMillimetre<T>(this Quantity<T, Kilometre> val) where T:IConvertible {
        return new Quantity<double, Millimetre>(
            Convert.ToDouble(val.Value) * 10e3
        );
    }
	/// <summary>
    /// Extension method to convert Kilometre to Micrometre
    /// </summary>
    /// <param name="val">quantity measured in Kilometre</param>
    /// <returns>quantity measured in Micrometre</returns>
	public static Quantity<double, Micrometre> ToMicrometre<T>(this Quantity<T, Kilometre> val) where T:IConvertible {
        return new Quantity<double, Micrometre>(
            Convert.ToDouble(val.Value) * 10e3
        );
    }
	/// <summary>
    /// Extension method to convert Kilometre to Nanometre
    /// </summary>
    /// <param name="val">quantity measured in Kilometre</param>
    /// <returns>quantity measured in Nanometre</returns>
	public static Quantity<double, Nanometre> ToNanometre<T>(this Quantity<T, Kilometre> val) where T:IConvertible {
        return new Quantity<double, Nanometre>(
            Convert.ToDouble(val.Value) * 10e3
        );
    }
	/// <summary>
    /// Extension method to convert Kilometre to Picometre
    /// </summary>
    /// <param name="val">quantity measured in Kilometre</param>
    /// <returns>quantity measured in Picometre</returns>
	public static Quantity<double, Picometre> ToPicometre<T>(this Quantity<T, Kilometre> val) where T:IConvertible {
        return new Quantity<double, Picometre>(
            Convert.ToDouble(val.Value) * 10e3
        );
    }
	/// <summary>
    /// Extension method to convert Kilometre to Femtometre
    /// </summary>
    /// <param name="val">quantity measured in Kilometre</param>
    /// <returns>quantity measured in Femtometre</returns>
	public static Quantity<double, Femtometre> ToFemtometre<T>(this Quantity<T, Kilometre> val) where T:IConvertible {
        return new Quantity<double, Femtometre>(
            Convert.ToDouble(val.Value) * 10e3
        );
    }
	/// <summary>
    /// Extension method to convert Kilometre to Attometre
    /// </summary>
    /// <param name="val">quantity measured in Kilometre</param>
    /// <returns>quantity measured in Attometre</returns>
	public static Quantity<double, Attometre> ToAttometre<T>(this Quantity<T, Kilometre> val) where T:IConvertible {
        return new Quantity<double, Attometre>(
            Convert.ToDouble(val.Value) * 10e3
        );
    }
	/// <summary>
    /// Extension method to convert Kilometre to Zeptometre
    /// </summary>
    /// <param name="val">quantity measured in Kilometre</param>
    /// <returns>quantity measured in Zeptometre</returns>
	public static Quantity<double, Zeptometre> ToZeptometre<T>(this Quantity<T, Kilometre> val) where T:IConvertible {
        return new Quantity<double, Zeptometre>(
            Convert.ToDouble(val.Value) * 10e3
        );
    }
	/// <summary>
    /// Extension method to convert Kilometre to Yoctometre
    /// </summary>
    /// <param name="val">quantity measured in Kilometre</param>
    /// <returns>quantity measured in Yoctometre</returns>
	public static Quantity<double, Yoctometre> ToYoctometre<T>(this Quantity<T, Kilometre> val) where T:IConvertible {
        return new Quantity<double, Yoctometre>(
            Convert.ToDouble(val.Value) * 10e3
        );
    }
	/// <summary>
    /// Extension method to convert Hectometre to Yottametre
    /// </summary>
    /// <param name="val">quantity measured in Hectometre</param>
    /// <returns>quantity measured in Yottametre</returns>
	public static Quantity<double, Yottametre> ToYottametre<T>(this Quantity<T, Hectometre> val) where T:IConvertible {
        return new Quantity<double, Yottametre>(
            Convert.ToDouble(val.Value) * 10e2
        );
    }
	/// <summary>
    /// Extension method to convert Hectometre to Zettametre
    /// </summary>
    /// <param name="val">quantity measured in Hectometre</param>
    /// <returns>quantity measured in Zettametre</returns>
	public static Quantity<double, Zettametre> ToZettametre<T>(this Quantity<T, Hectometre> val) where T:IConvertible {
        return new Quantity<double, Zettametre>(
            Convert.ToDouble(val.Value) * 10e2
        );
    }
	/// <summary>
    /// Extension method to convert Hectometre to Exametre
    /// </summary>
    /// <param name="val">quantity measured in Hectometre</param>
    /// <returns>quantity measured in Exametre</returns>
	public static Quantity<double, Exametre> ToExametre<T>(this Quantity<T, Hectometre> val) where T:IConvertible {
        return new Quantity<double, Exametre>(
            Convert.ToDouble(val.Value) * 10e2
        );
    }
	/// <summary>
    /// Extension method to convert Hectometre to Petametre
    /// </summary>
    /// <param name="val">quantity measured in Hectometre</param>
    /// <returns>quantity measured in Petametre</returns>
	public static Quantity<double, Petametre> ToPetametre<T>(this Quantity<T, Hectometre> val) where T:IConvertible {
        return new Quantity<double, Petametre>(
            Convert.ToDouble(val.Value) * 10e2
        );
    }
	/// <summary>
    /// Extension method to convert Hectometre to Terametre
    /// </summary>
    /// <param name="val">quantity measured in Hectometre</param>
    /// <returns>quantity measured in Terametre</returns>
	public static Quantity<double, Terametre> ToTerametre<T>(this Quantity<T, Hectometre> val) where T:IConvertible {
        return new Quantity<double, Terametre>(
            Convert.ToDouble(val.Value) * 10e2
        );
    }
	/// <summary>
    /// Extension method to convert Hectometre to Gigametre
    /// </summary>
    /// <param name="val">quantity measured in Hectometre</param>
    /// <returns>quantity measured in Gigametre</returns>
	public static Quantity<double, Gigametre> ToGigametre<T>(this Quantity<T, Hectometre> val) where T:IConvertible {
        return new Quantity<double, Gigametre>(
            Convert.ToDouble(val.Value) * 10e2
        );
    }
	/// <summary>
    /// Extension method to convert Hectometre to Megametre
    /// </summary>
    /// <param name="val">quantity measured in Hectometre</param>
    /// <returns>quantity measured in Megametre</returns>
	public static Quantity<double, Megametre> ToMegametre<T>(this Quantity<T, Hectometre> val) where T:IConvertible {
        return new Quantity<double, Megametre>(
            Convert.ToDouble(val.Value) * 10e2
        );
    }
	/// <summary>
    /// Extension method to convert Hectometre to Kilometre
    /// </summary>
    /// <param name="val">quantity measured in Hectometre</param>
    /// <returns>quantity measured in Kilometre</returns>
	public static Quantity<double, Kilometre> ToKilometre<T>(this Quantity<T, Hectometre> val) where T:IConvertible {
        return new Quantity<double, Kilometre>(
            Convert.ToDouble(val.Value) * 10e2
        );
    }
	/// <summary>
    /// Extension method to convert Hectometre to Dekametre
    /// </summary>
    /// <param name="val">quantity measured in Hectometre</param>
    /// <returns>quantity measured in Dekametre</returns>
	public static Quantity<double, Dekametre> ToDekametre<T>(this Quantity<T, Hectometre> val) where T:IConvertible {
        return new Quantity<double, Dekametre>(
            Convert.ToDouble(val.Value) * 10e2
        );
    }
	/// <summary>
    /// Extension method to convert Hectometre to Decimetre
    /// </summary>
    /// <param name="val">quantity measured in Hectometre</param>
    /// <returns>quantity measured in Decimetre</returns>
	public static Quantity<double, Decimetre> ToDecimetre<T>(this Quantity<T, Hectometre> val) where T:IConvertible {
        return new Quantity<double, Decimetre>(
            Convert.ToDouble(val.Value) * 10e2
        );
    }
	/// <summary>
    /// Extension method to convert Hectometre to Centimetre
    /// </summary>
    /// <param name="val">quantity measured in Hectometre</param>
    /// <returns>quantity measured in Centimetre</returns>
	public static Quantity<double, Centimetre> ToCentimetre<T>(this Quantity<T, Hectometre> val) where T:IConvertible {
        return new Quantity<double, Centimetre>(
            Convert.ToDouble(val.Value) * 10e2
        );
    }
	/// <summary>
    /// Extension method to convert Hectometre to Millimetre
    /// </summary>
    /// <param name="val">quantity measured in Hectometre</param>
    /// <returns>quantity measured in Millimetre</returns>
	public static Quantity<double, Millimetre> ToMillimetre<T>(this Quantity<T, Hectometre> val) where T:IConvertible {
        return new Quantity<double, Millimetre>(
            Convert.ToDouble(val.Value) * 10e2
        );
    }
	/// <summary>
    /// Extension method to convert Hectometre to Micrometre
    /// </summary>
    /// <param name="val">quantity measured in Hectometre</param>
    /// <returns>quantity measured in Micrometre</returns>
	public static Quantity<double, Micrometre> ToMicrometre<T>(this Quantity<T, Hectometre> val) where T:IConvertible {
        return new Quantity<double, Micrometre>(
            Convert.ToDouble(val.Value) * 10e2
        );
    }
	/// <summary>
    /// Extension method to convert Hectometre to Nanometre
    /// </summary>
    /// <param name="val">quantity measured in Hectometre</param>
    /// <returns>quantity measured in Nanometre</returns>
	public static Quantity<double, Nanometre> ToNanometre<T>(this Quantity<T, Hectometre> val) where T:IConvertible {
        return new Quantity<double, Nanometre>(
            Convert.ToDouble(val.Value) * 10e2
        );
    }
	/// <summary>
    /// Extension method to convert Hectometre to Picometre
    /// </summary>
    /// <param name="val">quantity measured in Hectometre</param>
    /// <returns>quantity measured in Picometre</returns>
	public static Quantity<double, Picometre> ToPicometre<T>(this Quantity<T, Hectometre> val) where T:IConvertible {
        return new Quantity<double, Picometre>(
            Convert.ToDouble(val.Value) * 10e2
        );
    }
	/// <summary>
    /// Extension method to convert Hectometre to Femtometre
    /// </summary>
    /// <param name="val">quantity measured in Hectometre</param>
    /// <returns>quantity measured in Femtometre</returns>
	public static Quantity<double, Femtometre> ToFemtometre<T>(this Quantity<T, Hectometre> val) where T:IConvertible {
        return new Quantity<double, Femtometre>(
            Convert.ToDouble(val.Value) * 10e2
        );
    }
	/// <summary>
    /// Extension method to convert Hectometre to Attometre
    /// </summary>
    /// <param name="val">quantity measured in Hectometre</param>
    /// <returns>quantity measured in Attometre</returns>
	public static Quantity<double, Attometre> ToAttometre<T>(this Quantity<T, Hectometre> val) where T:IConvertible {
        return new Quantity<double, Attometre>(
            Convert.ToDouble(val.Value) * 10e2
        );
    }
	/// <summary>
    /// Extension method to convert Hectometre to Zeptometre
    /// </summary>
    /// <param name="val">quantity measured in Hectometre</param>
    /// <returns>quantity measured in Zeptometre</returns>
	public static Quantity<double, Zeptometre> ToZeptometre<T>(this Quantity<T, Hectometre> val) where T:IConvertible {
        return new Quantity<double, Zeptometre>(
            Convert.ToDouble(val.Value) * 10e2
        );
    }
	/// <summary>
    /// Extension method to convert Hectometre to Yoctometre
    /// </summary>
    /// <param name="val">quantity measured in Hectometre</param>
    /// <returns>quantity measured in Yoctometre</returns>
	public static Quantity<double, Yoctometre> ToYoctometre<T>(this Quantity<T, Hectometre> val) where T:IConvertible {
        return new Quantity<double, Yoctometre>(
            Convert.ToDouble(val.Value) * 10e2
        );
    }
	/// <summary>
    /// Extension method to convert Dekametre to Yottametre
    /// </summary>
    /// <param name="val">quantity measured in Dekametre</param>
    /// <returns>quantity measured in Yottametre</returns>
	public static Quantity<double, Yottametre> ToYottametre<T>(this Quantity<T, Dekametre> val) where T:IConvertible {
        return new Quantity<double, Yottametre>(
            Convert.ToDouble(val.Value) * 10e1
        );
    }
	/// <summary>
    /// Extension method to convert Dekametre to Zettametre
    /// </summary>
    /// <param name="val">quantity measured in Dekametre</param>
    /// <returns>quantity measured in Zettametre</returns>
	public static Quantity<double, Zettametre> ToZettametre<T>(this Quantity<T, Dekametre> val) where T:IConvertible {
        return new Quantity<double, Zettametre>(
            Convert.ToDouble(val.Value) * 10e1
        );
    }
	/// <summary>
    /// Extension method to convert Dekametre to Exametre
    /// </summary>
    /// <param name="val">quantity measured in Dekametre</param>
    /// <returns>quantity measured in Exametre</returns>
	public static Quantity<double, Exametre> ToExametre<T>(this Quantity<T, Dekametre> val) where T:IConvertible {
        return new Quantity<double, Exametre>(
            Convert.ToDouble(val.Value) * 10e1
        );
    }
	/// <summary>
    /// Extension method to convert Dekametre to Petametre
    /// </summary>
    /// <param name="val">quantity measured in Dekametre</param>
    /// <returns>quantity measured in Petametre</returns>
	public static Quantity<double, Petametre> ToPetametre<T>(this Quantity<T, Dekametre> val) where T:IConvertible {
        return new Quantity<double, Petametre>(
            Convert.ToDouble(val.Value) * 10e1
        );
    }
	/// <summary>
    /// Extension method to convert Dekametre to Terametre
    /// </summary>
    /// <param name="val">quantity measured in Dekametre</param>
    /// <returns>quantity measured in Terametre</returns>
	public static Quantity<double, Terametre> ToTerametre<T>(this Quantity<T, Dekametre> val) where T:IConvertible {
        return new Quantity<double, Terametre>(
            Convert.ToDouble(val.Value) * 10e1
        );
    }
	/// <summary>
    /// Extension method to convert Dekametre to Gigametre
    /// </summary>
    /// <param name="val">quantity measured in Dekametre</param>
    /// <returns>quantity measured in Gigametre</returns>
	public static Quantity<double, Gigametre> ToGigametre<T>(this Quantity<T, Dekametre> val) where T:IConvertible {
        return new Quantity<double, Gigametre>(
            Convert.ToDouble(val.Value) * 10e1
        );
    }
	/// <summary>
    /// Extension method to convert Dekametre to Megametre
    /// </summary>
    /// <param name="val">quantity measured in Dekametre</param>
    /// <returns>quantity measured in Megametre</returns>
	public static Quantity<double, Megametre> ToMegametre<T>(this Quantity<T, Dekametre> val) where T:IConvertible {
        return new Quantity<double, Megametre>(
            Convert.ToDouble(val.Value) * 10e1
        );
    }
	/// <summary>
    /// Extension method to convert Dekametre to Kilometre
    /// </summary>
    /// <param name="val">quantity measured in Dekametre</param>
    /// <returns>quantity measured in Kilometre</returns>
	public static Quantity<double, Kilometre> ToKilometre<T>(this Quantity<T, Dekametre> val) where T:IConvertible {
        return new Quantity<double, Kilometre>(
            Convert.ToDouble(val.Value) * 10e1
        );
    }
	/// <summary>
    /// Extension method to convert Dekametre to Hectometre
    /// </summary>
    /// <param name="val">quantity measured in Dekametre</param>
    /// <returns>quantity measured in Hectometre</returns>
	public static Quantity<double, Hectometre> ToHectometre<T>(this Quantity<T, Dekametre> val) where T:IConvertible {
        return new Quantity<double, Hectometre>(
            Convert.ToDouble(val.Value) * 10e1
        );
    }
	/// <summary>
    /// Extension method to convert Dekametre to Decimetre
    /// </summary>
    /// <param name="val">quantity measured in Dekametre</param>
    /// <returns>quantity measured in Decimetre</returns>
	public static Quantity<double, Decimetre> ToDecimetre<T>(this Quantity<T, Dekametre> val) where T:IConvertible {
        return new Quantity<double, Decimetre>(
            Convert.ToDouble(val.Value) * 10e1
        );
    }
	/// <summary>
    /// Extension method to convert Dekametre to Centimetre
    /// </summary>
    /// <param name="val">quantity measured in Dekametre</param>
    /// <returns>quantity measured in Centimetre</returns>
	public static Quantity<double, Centimetre> ToCentimetre<T>(this Quantity<T, Dekametre> val) where T:IConvertible {
        return new Quantity<double, Centimetre>(
            Convert.ToDouble(val.Value) * 10e1
        );
    }
	/// <summary>
    /// Extension method to convert Dekametre to Millimetre
    /// </summary>
    /// <param name="val">quantity measured in Dekametre</param>
    /// <returns>quantity measured in Millimetre</returns>
	public static Quantity<double, Millimetre> ToMillimetre<T>(this Quantity<T, Dekametre> val) where T:IConvertible {
        return new Quantity<double, Millimetre>(
            Convert.ToDouble(val.Value) * 10e1
        );
    }
	/// <summary>
    /// Extension method to convert Dekametre to Micrometre
    /// </summary>
    /// <param name="val">quantity measured in Dekametre</param>
    /// <returns>quantity measured in Micrometre</returns>
	public static Quantity<double, Micrometre> ToMicrometre<T>(this Quantity<T, Dekametre> val) where T:IConvertible {
        return new Quantity<double, Micrometre>(
            Convert.ToDouble(val.Value) * 10e1
        );
    }
	/// <summary>
    /// Extension method to convert Dekametre to Nanometre
    /// </summary>
    /// <param name="val">quantity measured in Dekametre</param>
    /// <returns>quantity measured in Nanometre</returns>
	public static Quantity<double, Nanometre> ToNanometre<T>(this Quantity<T, Dekametre> val) where T:IConvertible {
        return new Quantity<double, Nanometre>(
            Convert.ToDouble(val.Value) * 10e1
        );
    }
	/// <summary>
    /// Extension method to convert Dekametre to Picometre
    /// </summary>
    /// <param name="val">quantity measured in Dekametre</param>
    /// <returns>quantity measured in Picometre</returns>
	public static Quantity<double, Picometre> ToPicometre<T>(this Quantity<T, Dekametre> val) where T:IConvertible {
        return new Quantity<double, Picometre>(
            Convert.ToDouble(val.Value) * 10e1
        );
    }
	/// <summary>
    /// Extension method to convert Dekametre to Femtometre
    /// </summary>
    /// <param name="val">quantity measured in Dekametre</param>
    /// <returns>quantity measured in Femtometre</returns>
	public static Quantity<double, Femtometre> ToFemtometre<T>(this Quantity<T, Dekametre> val) where T:IConvertible {
        return new Quantity<double, Femtometre>(
            Convert.ToDouble(val.Value) * 10e1
        );
    }
	/// <summary>
    /// Extension method to convert Dekametre to Attometre
    /// </summary>
    /// <param name="val">quantity measured in Dekametre</param>
    /// <returns>quantity measured in Attometre</returns>
	public static Quantity<double, Attometre> ToAttometre<T>(this Quantity<T, Dekametre> val) where T:IConvertible {
        return new Quantity<double, Attometre>(
            Convert.ToDouble(val.Value) * 10e1
        );
    }
	/// <summary>
    /// Extension method to convert Dekametre to Zeptometre
    /// </summary>
    /// <param name="val">quantity measured in Dekametre</param>
    /// <returns>quantity measured in Zeptometre</returns>
	public static Quantity<double, Zeptometre> ToZeptometre<T>(this Quantity<T, Dekametre> val) where T:IConvertible {
        return new Quantity<double, Zeptometre>(
            Convert.ToDouble(val.Value) * 10e1
        );
    }
	/// <summary>
    /// Extension method to convert Dekametre to Yoctometre
    /// </summary>
    /// <param name="val">quantity measured in Dekametre</param>
    /// <returns>quantity measured in Yoctometre</returns>
	public static Quantity<double, Yoctometre> ToYoctometre<T>(this Quantity<T, Dekametre> val) where T:IConvertible {
        return new Quantity<double, Yoctometre>(
            Convert.ToDouble(val.Value) * 10e1
        );
    }
	/// <summary>
    /// Extension method to convert Decimetre to Yottametre
    /// </summary>
    /// <param name="val">quantity measured in Decimetre</param>
    /// <returns>quantity measured in Yottametre</returns>
	public static Quantity<double, Yottametre> ToYottametre<T>(this Quantity<T, Decimetre> val) where T:IConvertible {
        return new Quantity<double, Yottametre>(
            Convert.ToDouble(val.Value) * 10e-1
        );
    }
	/// <summary>
    /// Extension method to convert Decimetre to Zettametre
    /// </summary>
    /// <param name="val">quantity measured in Decimetre</param>
    /// <returns>quantity measured in Zettametre</returns>
	public static Quantity<double, Zettametre> ToZettametre<T>(this Quantity<T, Decimetre> val) where T:IConvertible {
        return new Quantity<double, Zettametre>(
            Convert.ToDouble(val.Value) * 10e-1
        );
    }
	/// <summary>
    /// Extension method to convert Decimetre to Exametre
    /// </summary>
    /// <param name="val">quantity measured in Decimetre</param>
    /// <returns>quantity measured in Exametre</returns>
	public static Quantity<double, Exametre> ToExametre<T>(this Quantity<T, Decimetre> val) where T:IConvertible {
        return new Quantity<double, Exametre>(
            Convert.ToDouble(val.Value) * 10e-1
        );
    }
	/// <summary>
    /// Extension method to convert Decimetre to Petametre
    /// </summary>
    /// <param name="val">quantity measured in Decimetre</param>
    /// <returns>quantity measured in Petametre</returns>
	public static Quantity<double, Petametre> ToPetametre<T>(this Quantity<T, Decimetre> val) where T:IConvertible {
        return new Quantity<double, Petametre>(
            Convert.ToDouble(val.Value) * 10e-1
        );
    }
	/// <summary>
    /// Extension method to convert Decimetre to Terametre
    /// </summary>
    /// <param name="val">quantity measured in Decimetre</param>
    /// <returns>quantity measured in Terametre</returns>
	public static Quantity<double, Terametre> ToTerametre<T>(this Quantity<T, Decimetre> val) where T:IConvertible {
        return new Quantity<double, Terametre>(
            Convert.ToDouble(val.Value) * 10e-1
        );
    }
	/// <summary>
    /// Extension method to convert Decimetre to Gigametre
    /// </summary>
    /// <param name="val">quantity measured in Decimetre</param>
    /// <returns>quantity measured in Gigametre</returns>
	public static Quantity<double, Gigametre> ToGigametre<T>(this Quantity<T, Decimetre> val) where T:IConvertible {
        return new Quantity<double, Gigametre>(
            Convert.ToDouble(val.Value) * 10e-1
        );
    }
	/// <summary>
    /// Extension method to convert Decimetre to Megametre
    /// </summary>
    /// <param name="val">quantity measured in Decimetre</param>
    /// <returns>quantity measured in Megametre</returns>
	public static Quantity<double, Megametre> ToMegametre<T>(this Quantity<T, Decimetre> val) where T:IConvertible {
        return new Quantity<double, Megametre>(
            Convert.ToDouble(val.Value) * 10e-1
        );
    }
	/// <summary>
    /// Extension method to convert Decimetre to Kilometre
    /// </summary>
    /// <param name="val">quantity measured in Decimetre</param>
    /// <returns>quantity measured in Kilometre</returns>
	public static Quantity<double, Kilometre> ToKilometre<T>(this Quantity<T, Decimetre> val) where T:IConvertible {
        return new Quantity<double, Kilometre>(
            Convert.ToDouble(val.Value) * 10e-1
        );
    }
	/// <summary>
    /// Extension method to convert Decimetre to Hectometre
    /// </summary>
    /// <param name="val">quantity measured in Decimetre</param>
    /// <returns>quantity measured in Hectometre</returns>
	public static Quantity<double, Hectometre> ToHectometre<T>(this Quantity<T, Decimetre> val) where T:IConvertible {
        return new Quantity<double, Hectometre>(
            Convert.ToDouble(val.Value) * 10e-1
        );
    }
	/// <summary>
    /// Extension method to convert Decimetre to Dekametre
    /// </summary>
    /// <param name="val">quantity measured in Decimetre</param>
    /// <returns>quantity measured in Dekametre</returns>
	public static Quantity<double, Dekametre> ToDekametre<T>(this Quantity<T, Decimetre> val) where T:IConvertible {
        return new Quantity<double, Dekametre>(
            Convert.ToDouble(val.Value) * 10e-1
        );
    }
	/// <summary>
    /// Extension method to convert Decimetre to Centimetre
    /// </summary>
    /// <param name="val">quantity measured in Decimetre</param>
    /// <returns>quantity measured in Centimetre</returns>
	public static Quantity<double, Centimetre> ToCentimetre<T>(this Quantity<T, Decimetre> val) where T:IConvertible {
        return new Quantity<double, Centimetre>(
            Convert.ToDouble(val.Value) * 10e-1
        );
    }
	/// <summary>
    /// Extension method to convert Decimetre to Millimetre
    /// </summary>
    /// <param name="val">quantity measured in Decimetre</param>
    /// <returns>quantity measured in Millimetre</returns>
	public static Quantity<double, Millimetre> ToMillimetre<T>(this Quantity<T, Decimetre> val) where T:IConvertible {
        return new Quantity<double, Millimetre>(
            Convert.ToDouble(val.Value) * 10e-1
        );
    }
	/// <summary>
    /// Extension method to convert Decimetre to Micrometre
    /// </summary>
    /// <param name="val">quantity measured in Decimetre</param>
    /// <returns>quantity measured in Micrometre</returns>
	public static Quantity<double, Micrometre> ToMicrometre<T>(this Quantity<T, Decimetre> val) where T:IConvertible {
        return new Quantity<double, Micrometre>(
            Convert.ToDouble(val.Value) * 10e-1
        );
    }
	/// <summary>
    /// Extension method to convert Decimetre to Nanometre
    /// </summary>
    /// <param name="val">quantity measured in Decimetre</param>
    /// <returns>quantity measured in Nanometre</returns>
	public static Quantity<double, Nanometre> ToNanometre<T>(this Quantity<T, Decimetre> val) where T:IConvertible {
        return new Quantity<double, Nanometre>(
            Convert.ToDouble(val.Value) * 10e-1
        );
    }
	/// <summary>
    /// Extension method to convert Decimetre to Picometre
    /// </summary>
    /// <param name="val">quantity measured in Decimetre</param>
    /// <returns>quantity measured in Picometre</returns>
	public static Quantity<double, Picometre> ToPicometre<T>(this Quantity<T, Decimetre> val) where T:IConvertible {
        return new Quantity<double, Picometre>(
            Convert.ToDouble(val.Value) * 10e-1
        );
    }
	/// <summary>
    /// Extension method to convert Decimetre to Femtometre
    /// </summary>
    /// <param name="val">quantity measured in Decimetre</param>
    /// <returns>quantity measured in Femtometre</returns>
	public static Quantity<double, Femtometre> ToFemtometre<T>(this Quantity<T, Decimetre> val) where T:IConvertible {
        return new Quantity<double, Femtometre>(
            Convert.ToDouble(val.Value) * 10e-1
        );
    }
	/// <summary>
    /// Extension method to convert Decimetre to Attometre
    /// </summary>
    /// <param name="val">quantity measured in Decimetre</param>
    /// <returns>quantity measured in Attometre</returns>
	public static Quantity<double, Attometre> ToAttometre<T>(this Quantity<T, Decimetre> val) where T:IConvertible {
        return new Quantity<double, Attometre>(
            Convert.ToDouble(val.Value) * 10e-1
        );
    }
	/// <summary>
    /// Extension method to convert Decimetre to Zeptometre
    /// </summary>
    /// <param name="val">quantity measured in Decimetre</param>
    /// <returns>quantity measured in Zeptometre</returns>
	public static Quantity<double, Zeptometre> ToZeptometre<T>(this Quantity<T, Decimetre> val) where T:IConvertible {
        return new Quantity<double, Zeptometre>(
            Convert.ToDouble(val.Value) * 10e-1
        );
    }
	/// <summary>
    /// Extension method to convert Decimetre to Yoctometre
    /// </summary>
    /// <param name="val">quantity measured in Decimetre</param>
    /// <returns>quantity measured in Yoctometre</returns>
	public static Quantity<double, Yoctometre> ToYoctometre<T>(this Quantity<T, Decimetre> val) where T:IConvertible {
        return new Quantity<double, Yoctometre>(
            Convert.ToDouble(val.Value) * 10e-1
        );
    }
	/// <summary>
    /// Extension method to convert Centimetre to Yottametre
    /// </summary>
    /// <param name="val">quantity measured in Centimetre</param>
    /// <returns>quantity measured in Yottametre</returns>
	public static Quantity<double, Yottametre> ToYottametre<T>(this Quantity<T, Centimetre> val) where T:IConvertible {
        return new Quantity<double, Yottametre>(
            Convert.ToDouble(val.Value) * 10e-2
        );
    }
	/// <summary>
    /// Extension method to convert Centimetre to Zettametre
    /// </summary>
    /// <param name="val">quantity measured in Centimetre</param>
    /// <returns>quantity measured in Zettametre</returns>
	public static Quantity<double, Zettametre> ToZettametre<T>(this Quantity<T, Centimetre> val) where T:IConvertible {
        return new Quantity<double, Zettametre>(
            Convert.ToDouble(val.Value) * 10e-2
        );
    }
	/// <summary>
    /// Extension method to convert Centimetre to Exametre
    /// </summary>
    /// <param name="val">quantity measured in Centimetre</param>
    /// <returns>quantity measured in Exametre</returns>
	public static Quantity<double, Exametre> ToExametre<T>(this Quantity<T, Centimetre> val) where T:IConvertible {
        return new Quantity<double, Exametre>(
            Convert.ToDouble(val.Value) * 10e-2
        );
    }
	/// <summary>
    /// Extension method to convert Centimetre to Petametre
    /// </summary>
    /// <param name="val">quantity measured in Centimetre</param>
    /// <returns>quantity measured in Petametre</returns>
	public static Quantity<double, Petametre> ToPetametre<T>(this Quantity<T, Centimetre> val) where T:IConvertible {
        return new Quantity<double, Petametre>(
            Convert.ToDouble(val.Value) * 10e-2
        );
    }
	/// <summary>
    /// Extension method to convert Centimetre to Terametre
    /// </summary>
    /// <param name="val">quantity measured in Centimetre</param>
    /// <returns>quantity measured in Terametre</returns>
	public static Quantity<double, Terametre> ToTerametre<T>(this Quantity<T, Centimetre> val) where T:IConvertible {
        return new Quantity<double, Terametre>(
            Convert.ToDouble(val.Value) * 10e-2
        );
    }
	/// <summary>
    /// Extension method to convert Centimetre to Gigametre
    /// </summary>
    /// <param name="val">quantity measured in Centimetre</param>
    /// <returns>quantity measured in Gigametre</returns>
	public static Quantity<double, Gigametre> ToGigametre<T>(this Quantity<T, Centimetre> val) where T:IConvertible {
        return new Quantity<double, Gigametre>(
            Convert.ToDouble(val.Value) * 10e-2
        );
    }
	/// <summary>
    /// Extension method to convert Centimetre to Megametre
    /// </summary>
    /// <param name="val">quantity measured in Centimetre</param>
    /// <returns>quantity measured in Megametre</returns>
	public static Quantity<double, Megametre> ToMegametre<T>(this Quantity<T, Centimetre> val) where T:IConvertible {
        return new Quantity<double, Megametre>(
            Convert.ToDouble(val.Value) * 10e-2
        );
    }
	/// <summary>
    /// Extension method to convert Centimetre to Kilometre
    /// </summary>
    /// <param name="val">quantity measured in Centimetre</param>
    /// <returns>quantity measured in Kilometre</returns>
	public static Quantity<double, Kilometre> ToKilometre<T>(this Quantity<T, Centimetre> val) where T:IConvertible {
        return new Quantity<double, Kilometre>(
            Convert.ToDouble(val.Value) * 10e-2
        );
    }
	/// <summary>
    /// Extension method to convert Centimetre to Hectometre
    /// </summary>
    /// <param name="val">quantity measured in Centimetre</param>
    /// <returns>quantity measured in Hectometre</returns>
	public static Quantity<double, Hectometre> ToHectometre<T>(this Quantity<T, Centimetre> val) where T:IConvertible {
        return new Quantity<double, Hectometre>(
            Convert.ToDouble(val.Value) * 10e-2
        );
    }
	/// <summary>
    /// Extension method to convert Centimetre to Dekametre
    /// </summary>
    /// <param name="val">quantity measured in Centimetre</param>
    /// <returns>quantity measured in Dekametre</returns>
	public static Quantity<double, Dekametre> ToDekametre<T>(this Quantity<T, Centimetre> val) where T:IConvertible {
        return new Quantity<double, Dekametre>(
            Convert.ToDouble(val.Value) * 10e-2
        );
    }
	/// <summary>
    /// Extension method to convert Centimetre to Decimetre
    /// </summary>
    /// <param name="val">quantity measured in Centimetre</param>
    /// <returns>quantity measured in Decimetre</returns>
	public static Quantity<double, Decimetre> ToDecimetre<T>(this Quantity<T, Centimetre> val) where T:IConvertible {
        return new Quantity<double, Decimetre>(
            Convert.ToDouble(val.Value) * 10e-2
        );
    }
	/// <summary>
    /// Extension method to convert Centimetre to Millimetre
    /// </summary>
    /// <param name="val">quantity measured in Centimetre</param>
    /// <returns>quantity measured in Millimetre</returns>
	public static Quantity<double, Millimetre> ToMillimetre<T>(this Quantity<T, Centimetre> val) where T:IConvertible {
        return new Quantity<double, Millimetre>(
            Convert.ToDouble(val.Value) * 10e-2
        );
    }
	/// <summary>
    /// Extension method to convert Centimetre to Micrometre
    /// </summary>
    /// <param name="val">quantity measured in Centimetre</param>
    /// <returns>quantity measured in Micrometre</returns>
	public static Quantity<double, Micrometre> ToMicrometre<T>(this Quantity<T, Centimetre> val) where T:IConvertible {
        return new Quantity<double, Micrometre>(
            Convert.ToDouble(val.Value) * 10e-2
        );
    }
	/// <summary>
    /// Extension method to convert Centimetre to Nanometre
    /// </summary>
    /// <param name="val">quantity measured in Centimetre</param>
    /// <returns>quantity measured in Nanometre</returns>
	public static Quantity<double, Nanometre> ToNanometre<T>(this Quantity<T, Centimetre> val) where T:IConvertible {
        return new Quantity<double, Nanometre>(
            Convert.ToDouble(val.Value) * 10e-2
        );
    }
	/// <summary>
    /// Extension method to convert Centimetre to Picometre
    /// </summary>
    /// <param name="val">quantity measured in Centimetre</param>
    /// <returns>quantity measured in Picometre</returns>
	public static Quantity<double, Picometre> ToPicometre<T>(this Quantity<T, Centimetre> val) where T:IConvertible {
        return new Quantity<double, Picometre>(
            Convert.ToDouble(val.Value) * 10e-2
        );
    }
	/// <summary>
    /// Extension method to convert Centimetre to Femtometre
    /// </summary>
    /// <param name="val">quantity measured in Centimetre</param>
    /// <returns>quantity measured in Femtometre</returns>
	public static Quantity<double, Femtometre> ToFemtometre<T>(this Quantity<T, Centimetre> val) where T:IConvertible {
        return new Quantity<double, Femtometre>(
            Convert.ToDouble(val.Value) * 10e-2
        );
    }
	/// <summary>
    /// Extension method to convert Centimetre to Attometre
    /// </summary>
    /// <param name="val">quantity measured in Centimetre</param>
    /// <returns>quantity measured in Attometre</returns>
	public static Quantity<double, Attometre> ToAttometre<T>(this Quantity<T, Centimetre> val) where T:IConvertible {
        return new Quantity<double, Attometre>(
            Convert.ToDouble(val.Value) * 10e-2
        );
    }
	/// <summary>
    /// Extension method to convert Centimetre to Zeptometre
    /// </summary>
    /// <param name="val">quantity measured in Centimetre</param>
    /// <returns>quantity measured in Zeptometre</returns>
	public static Quantity<double, Zeptometre> ToZeptometre<T>(this Quantity<T, Centimetre> val) where T:IConvertible {
        return new Quantity<double, Zeptometre>(
            Convert.ToDouble(val.Value) * 10e-2
        );
    }
	/// <summary>
    /// Extension method to convert Centimetre to Yoctometre
    /// </summary>
    /// <param name="val">quantity measured in Centimetre</param>
    /// <returns>quantity measured in Yoctometre</returns>
	public static Quantity<double, Yoctometre> ToYoctometre<T>(this Quantity<T, Centimetre> val) where T:IConvertible {
        return new Quantity<double, Yoctometre>(
            Convert.ToDouble(val.Value) * 10e-2
        );
    }
	/// <summary>
    /// Extension method to convert Millimetre to Yottametre
    /// </summary>
    /// <param name="val">quantity measured in Millimetre</param>
    /// <returns>quantity measured in Yottametre</returns>
	public static Quantity<double, Yottametre> ToYottametre<T>(this Quantity<T, Millimetre> val) where T:IConvertible {
        return new Quantity<double, Yottametre>(
            Convert.ToDouble(val.Value) * 10e-3
        );
    }
	/// <summary>
    /// Extension method to convert Millimetre to Zettametre
    /// </summary>
    /// <param name="val">quantity measured in Millimetre</param>
    /// <returns>quantity measured in Zettametre</returns>
	public static Quantity<double, Zettametre> ToZettametre<T>(this Quantity<T, Millimetre> val) where T:IConvertible {
        return new Quantity<double, Zettametre>(
            Convert.ToDouble(val.Value) * 10e-3
        );
    }
	/// <summary>
    /// Extension method to convert Millimetre to Exametre
    /// </summary>
    /// <param name="val">quantity measured in Millimetre</param>
    /// <returns>quantity measured in Exametre</returns>
	public static Quantity<double, Exametre> ToExametre<T>(this Quantity<T, Millimetre> val) where T:IConvertible {
        return new Quantity<double, Exametre>(
            Convert.ToDouble(val.Value) * 10e-3
        );
    }
	/// <summary>
    /// Extension method to convert Millimetre to Petametre
    /// </summary>
    /// <param name="val">quantity measured in Millimetre</param>
    /// <returns>quantity measured in Petametre</returns>
	public static Quantity<double, Petametre> ToPetametre<T>(this Quantity<T, Millimetre> val) where T:IConvertible {
        return new Quantity<double, Petametre>(
            Convert.ToDouble(val.Value) * 10e-3
        );
    }
	/// <summary>
    /// Extension method to convert Millimetre to Terametre
    /// </summary>
    /// <param name="val">quantity measured in Millimetre</param>
    /// <returns>quantity measured in Terametre</returns>
	public static Quantity<double, Terametre> ToTerametre<T>(this Quantity<T, Millimetre> val) where T:IConvertible {
        return new Quantity<double, Terametre>(
            Convert.ToDouble(val.Value) * 10e-3
        );
    }
	/// <summary>
    /// Extension method to convert Millimetre to Gigametre
    /// </summary>
    /// <param name="val">quantity measured in Millimetre</param>
    /// <returns>quantity measured in Gigametre</returns>
	public static Quantity<double, Gigametre> ToGigametre<T>(this Quantity<T, Millimetre> val) where T:IConvertible {
        return new Quantity<double, Gigametre>(
            Convert.ToDouble(val.Value) * 10e-3
        );
    }
	/// <summary>
    /// Extension method to convert Millimetre to Megametre
    /// </summary>
    /// <param name="val">quantity measured in Millimetre</param>
    /// <returns>quantity measured in Megametre</returns>
	public static Quantity<double, Megametre> ToMegametre<T>(this Quantity<T, Millimetre> val) where T:IConvertible {
        return new Quantity<double, Megametre>(
            Convert.ToDouble(val.Value) * 10e-3
        );
    }
	/// <summary>
    /// Extension method to convert Millimetre to Kilometre
    /// </summary>
    /// <param name="val">quantity measured in Millimetre</param>
    /// <returns>quantity measured in Kilometre</returns>
	public static Quantity<double, Kilometre> ToKilometre<T>(this Quantity<T, Millimetre> val) where T:IConvertible {
        return new Quantity<double, Kilometre>(
            Convert.ToDouble(val.Value) * 10e-3
        );
    }
	/// <summary>
    /// Extension method to convert Millimetre to Hectometre
    /// </summary>
    /// <param name="val">quantity measured in Millimetre</param>
    /// <returns>quantity measured in Hectometre</returns>
	public static Quantity<double, Hectometre> ToHectometre<T>(this Quantity<T, Millimetre> val) where T:IConvertible {
        return new Quantity<double, Hectometre>(
            Convert.ToDouble(val.Value) * 10e-3
        );
    }
	/// <summary>
    /// Extension method to convert Millimetre to Dekametre
    /// </summary>
    /// <param name="val">quantity measured in Millimetre</param>
    /// <returns>quantity measured in Dekametre</returns>
	public static Quantity<double, Dekametre> ToDekametre<T>(this Quantity<T, Millimetre> val) where T:IConvertible {
        return new Quantity<double, Dekametre>(
            Convert.ToDouble(val.Value) * 10e-3
        );
    }
	/// <summary>
    /// Extension method to convert Millimetre to Decimetre
    /// </summary>
    /// <param name="val">quantity measured in Millimetre</param>
    /// <returns>quantity measured in Decimetre</returns>
	public static Quantity<double, Decimetre> ToDecimetre<T>(this Quantity<T, Millimetre> val) where T:IConvertible {
        return new Quantity<double, Decimetre>(
            Convert.ToDouble(val.Value) * 10e-3
        );
    }
	/// <summary>
    /// Extension method to convert Millimetre to Centimetre
    /// </summary>
    /// <param name="val">quantity measured in Millimetre</param>
    /// <returns>quantity measured in Centimetre</returns>
	public static Quantity<double, Centimetre> ToCentimetre<T>(this Quantity<T, Millimetre> val) where T:IConvertible {
        return new Quantity<double, Centimetre>(
            Convert.ToDouble(val.Value) * 10e-3
        );
    }
	/// <summary>
    /// Extension method to convert Millimetre to Micrometre
    /// </summary>
    /// <param name="val">quantity measured in Millimetre</param>
    /// <returns>quantity measured in Micrometre</returns>
	public static Quantity<double, Micrometre> ToMicrometre<T>(this Quantity<T, Millimetre> val) where T:IConvertible {
        return new Quantity<double, Micrometre>(
            Convert.ToDouble(val.Value) * 10e-3
        );
    }
	/// <summary>
    /// Extension method to convert Millimetre to Nanometre
    /// </summary>
    /// <param name="val">quantity measured in Millimetre</param>
    /// <returns>quantity measured in Nanometre</returns>
	public static Quantity<double, Nanometre> ToNanometre<T>(this Quantity<T, Millimetre> val) where T:IConvertible {
        return new Quantity<double, Nanometre>(
            Convert.ToDouble(val.Value) * 10e-3
        );
    }
	/// <summary>
    /// Extension method to convert Millimetre to Picometre
    /// </summary>
    /// <param name="val">quantity measured in Millimetre</param>
    /// <returns>quantity measured in Picometre</returns>
	public static Quantity<double, Picometre> ToPicometre<T>(this Quantity<T, Millimetre> val) where T:IConvertible {
        return new Quantity<double, Picometre>(
            Convert.ToDouble(val.Value) * 10e-3
        );
    }
	/// <summary>
    /// Extension method to convert Millimetre to Femtometre
    /// </summary>
    /// <param name="val">quantity measured in Millimetre</param>
    /// <returns>quantity measured in Femtometre</returns>
	public static Quantity<double, Femtometre> ToFemtometre<T>(this Quantity<T, Millimetre> val) where T:IConvertible {
        return new Quantity<double, Femtometre>(
            Convert.ToDouble(val.Value) * 10e-3
        );
    }
	/// <summary>
    /// Extension method to convert Millimetre to Attometre
    /// </summary>
    /// <param name="val">quantity measured in Millimetre</param>
    /// <returns>quantity measured in Attometre</returns>
	public static Quantity<double, Attometre> ToAttometre<T>(this Quantity<T, Millimetre> val) where T:IConvertible {
        return new Quantity<double, Attometre>(
            Convert.ToDouble(val.Value) * 10e-3
        );
    }
	/// <summary>
    /// Extension method to convert Millimetre to Zeptometre
    /// </summary>
    /// <param name="val">quantity measured in Millimetre</param>
    /// <returns>quantity measured in Zeptometre</returns>
	public static Quantity<double, Zeptometre> ToZeptometre<T>(this Quantity<T, Millimetre> val) where T:IConvertible {
        return new Quantity<double, Zeptometre>(
            Convert.ToDouble(val.Value) * 10e-3
        );
    }
	/// <summary>
    /// Extension method to convert Millimetre to Yoctometre
    /// </summary>
    /// <param name="val">quantity measured in Millimetre</param>
    /// <returns>quantity measured in Yoctometre</returns>
	public static Quantity<double, Yoctometre> ToYoctometre<T>(this Quantity<T, Millimetre> val) where T:IConvertible {
        return new Quantity<double, Yoctometre>(
            Convert.ToDouble(val.Value) * 10e-3
        );
    }
	/// <summary>
    /// Extension method to convert Micrometre to Yottametre
    /// </summary>
    /// <param name="val">quantity measured in Micrometre</param>
    /// <returns>quantity measured in Yottametre</returns>
	public static Quantity<double, Yottametre> ToYottametre<T>(this Quantity<T, Micrometre> val) where T:IConvertible {
        return new Quantity<double, Yottametre>(
            Convert.ToDouble(val.Value) * 10e-6
        );
    }
	/// <summary>
    /// Extension method to convert Micrometre to Zettametre
    /// </summary>
    /// <param name="val">quantity measured in Micrometre</param>
    /// <returns>quantity measured in Zettametre</returns>
	public static Quantity<double, Zettametre> ToZettametre<T>(this Quantity<T, Micrometre> val) where T:IConvertible {
        return new Quantity<double, Zettametre>(
            Convert.ToDouble(val.Value) * 10e-6
        );
    }
	/// <summary>
    /// Extension method to convert Micrometre to Exametre
    /// </summary>
    /// <param name="val">quantity measured in Micrometre</param>
    /// <returns>quantity measured in Exametre</returns>
	public static Quantity<double, Exametre> ToExametre<T>(this Quantity<T, Micrometre> val) where T:IConvertible {
        return new Quantity<double, Exametre>(
            Convert.ToDouble(val.Value) * 10e-6
        );
    }
	/// <summary>
    /// Extension method to convert Micrometre to Petametre
    /// </summary>
    /// <param name="val">quantity measured in Micrometre</param>
    /// <returns>quantity measured in Petametre</returns>
	public static Quantity<double, Petametre> ToPetametre<T>(this Quantity<T, Micrometre> val) where T:IConvertible {
        return new Quantity<double, Petametre>(
            Convert.ToDouble(val.Value) * 10e-6
        );
    }
	/// <summary>
    /// Extension method to convert Micrometre to Terametre
    /// </summary>
    /// <param name="val">quantity measured in Micrometre</param>
    /// <returns>quantity measured in Terametre</returns>
	public static Quantity<double, Terametre> ToTerametre<T>(this Quantity<T, Micrometre> val) where T:IConvertible {
        return new Quantity<double, Terametre>(
            Convert.ToDouble(val.Value) * 10e-6
        );
    }
	/// <summary>
    /// Extension method to convert Micrometre to Gigametre
    /// </summary>
    /// <param name="val">quantity measured in Micrometre</param>
    /// <returns>quantity measured in Gigametre</returns>
	public static Quantity<double, Gigametre> ToGigametre<T>(this Quantity<T, Micrometre> val) where T:IConvertible {
        return new Quantity<double, Gigametre>(
            Convert.ToDouble(val.Value) * 10e-6
        );
    }
	/// <summary>
    /// Extension method to convert Micrometre to Megametre
    /// </summary>
    /// <param name="val">quantity measured in Micrometre</param>
    /// <returns>quantity measured in Megametre</returns>
	public static Quantity<double, Megametre> ToMegametre<T>(this Quantity<T, Micrometre> val) where T:IConvertible {
        return new Quantity<double, Megametre>(
            Convert.ToDouble(val.Value) * 10e-6
        );
    }
	/// <summary>
    /// Extension method to convert Micrometre to Kilometre
    /// </summary>
    /// <param name="val">quantity measured in Micrometre</param>
    /// <returns>quantity measured in Kilometre</returns>
	public static Quantity<double, Kilometre> ToKilometre<T>(this Quantity<T, Micrometre> val) where T:IConvertible {
        return new Quantity<double, Kilometre>(
            Convert.ToDouble(val.Value) * 10e-6
        );
    }
	/// <summary>
    /// Extension method to convert Micrometre to Hectometre
    /// </summary>
    /// <param name="val">quantity measured in Micrometre</param>
    /// <returns>quantity measured in Hectometre</returns>
	public static Quantity<double, Hectometre> ToHectometre<T>(this Quantity<T, Micrometre> val) where T:IConvertible {
        return new Quantity<double, Hectometre>(
            Convert.ToDouble(val.Value) * 10e-6
        );
    }
	/// <summary>
    /// Extension method to convert Micrometre to Dekametre
    /// </summary>
    /// <param name="val">quantity measured in Micrometre</param>
    /// <returns>quantity measured in Dekametre</returns>
	public static Quantity<double, Dekametre> ToDekametre<T>(this Quantity<T, Micrometre> val) where T:IConvertible {
        return new Quantity<double, Dekametre>(
            Convert.ToDouble(val.Value) * 10e-6
        );
    }
	/// <summary>
    /// Extension method to convert Micrometre to Decimetre
    /// </summary>
    /// <param name="val">quantity measured in Micrometre</param>
    /// <returns>quantity measured in Decimetre</returns>
	public static Quantity<double, Decimetre> ToDecimetre<T>(this Quantity<T, Micrometre> val) where T:IConvertible {
        return new Quantity<double, Decimetre>(
            Convert.ToDouble(val.Value) * 10e-6
        );
    }
	/// <summary>
    /// Extension method to convert Micrometre to Centimetre
    /// </summary>
    /// <param name="val">quantity measured in Micrometre</param>
    /// <returns>quantity measured in Centimetre</returns>
	public static Quantity<double, Centimetre> ToCentimetre<T>(this Quantity<T, Micrometre> val) where T:IConvertible {
        return new Quantity<double, Centimetre>(
            Convert.ToDouble(val.Value) * 10e-6
        );
    }
	/// <summary>
    /// Extension method to convert Micrometre to Millimetre
    /// </summary>
    /// <param name="val">quantity measured in Micrometre</param>
    /// <returns>quantity measured in Millimetre</returns>
	public static Quantity<double, Millimetre> ToMillimetre<T>(this Quantity<T, Micrometre> val) where T:IConvertible {
        return new Quantity<double, Millimetre>(
            Convert.ToDouble(val.Value) * 10e-6
        );
    }
	/// <summary>
    /// Extension method to convert Micrometre to Nanometre
    /// </summary>
    /// <param name="val">quantity measured in Micrometre</param>
    /// <returns>quantity measured in Nanometre</returns>
	public static Quantity<double, Nanometre> ToNanometre<T>(this Quantity<T, Micrometre> val) where T:IConvertible {
        return new Quantity<double, Nanometre>(
            Convert.ToDouble(val.Value) * 10e-6
        );
    }
	/// <summary>
    /// Extension method to convert Micrometre to Picometre
    /// </summary>
    /// <param name="val">quantity measured in Micrometre</param>
    /// <returns>quantity measured in Picometre</returns>
	public static Quantity<double, Picometre> ToPicometre<T>(this Quantity<T, Micrometre> val) where T:IConvertible {
        return new Quantity<double, Picometre>(
            Convert.ToDouble(val.Value) * 10e-6
        );
    }
	/// <summary>
    /// Extension method to convert Micrometre to Femtometre
    /// </summary>
    /// <param name="val">quantity measured in Micrometre</param>
    /// <returns>quantity measured in Femtometre</returns>
	public static Quantity<double, Femtometre> ToFemtometre<T>(this Quantity<T, Micrometre> val) where T:IConvertible {
        return new Quantity<double, Femtometre>(
            Convert.ToDouble(val.Value) * 10e-6
        );
    }
	/// <summary>
    /// Extension method to convert Micrometre to Attometre
    /// </summary>
    /// <param name="val">quantity measured in Micrometre</param>
    /// <returns>quantity measured in Attometre</returns>
	public static Quantity<double, Attometre> ToAttometre<T>(this Quantity<T, Micrometre> val) where T:IConvertible {
        return new Quantity<double, Attometre>(
            Convert.ToDouble(val.Value) * 10e-6
        );
    }
	/// <summary>
    /// Extension method to convert Micrometre to Zeptometre
    /// </summary>
    /// <param name="val">quantity measured in Micrometre</param>
    /// <returns>quantity measured in Zeptometre</returns>
	public static Quantity<double, Zeptometre> ToZeptometre<T>(this Quantity<T, Micrometre> val) where T:IConvertible {
        return new Quantity<double, Zeptometre>(
            Convert.ToDouble(val.Value) * 10e-6
        );
    }
	/// <summary>
    /// Extension method to convert Micrometre to Yoctometre
    /// </summary>
    /// <param name="val">quantity measured in Micrometre</param>
    /// <returns>quantity measured in Yoctometre</returns>
	public static Quantity<double, Yoctometre> ToYoctometre<T>(this Quantity<T, Micrometre> val) where T:IConvertible {
        return new Quantity<double, Yoctometre>(
            Convert.ToDouble(val.Value) * 10e-6
        );
    }
	/// <summary>
    /// Extension method to convert Nanometre to Yottametre
    /// </summary>
    /// <param name="val">quantity measured in Nanometre</param>
    /// <returns>quantity measured in Yottametre</returns>
	public static Quantity<double, Yottametre> ToYottametre<T>(this Quantity<T, Nanometre> val) where T:IConvertible {
        return new Quantity<double, Yottametre>(
            Convert.ToDouble(val.Value) * 10e-9
        );
    }
	/// <summary>
    /// Extension method to convert Nanometre to Zettametre
    /// </summary>
    /// <param name="val">quantity measured in Nanometre</param>
    /// <returns>quantity measured in Zettametre</returns>
	public static Quantity<double, Zettametre> ToZettametre<T>(this Quantity<T, Nanometre> val) where T:IConvertible {
        return new Quantity<double, Zettametre>(
            Convert.ToDouble(val.Value) * 10e-9
        );
    }
	/// <summary>
    /// Extension method to convert Nanometre to Exametre
    /// </summary>
    /// <param name="val">quantity measured in Nanometre</param>
    /// <returns>quantity measured in Exametre</returns>
	public static Quantity<double, Exametre> ToExametre<T>(this Quantity<T, Nanometre> val) where T:IConvertible {
        return new Quantity<double, Exametre>(
            Convert.ToDouble(val.Value) * 10e-9
        );
    }
	/// <summary>
    /// Extension method to convert Nanometre to Petametre
    /// </summary>
    /// <param name="val">quantity measured in Nanometre</param>
    /// <returns>quantity measured in Petametre</returns>
	public static Quantity<double, Petametre> ToPetametre<T>(this Quantity<T, Nanometre> val) where T:IConvertible {
        return new Quantity<double, Petametre>(
            Convert.ToDouble(val.Value) * 10e-9
        );
    }
	/// <summary>
    /// Extension method to convert Nanometre to Terametre
    /// </summary>
    /// <param name="val">quantity measured in Nanometre</param>
    /// <returns>quantity measured in Terametre</returns>
	public static Quantity<double, Terametre> ToTerametre<T>(this Quantity<T, Nanometre> val) where T:IConvertible {
        return new Quantity<double, Terametre>(
            Convert.ToDouble(val.Value) * 10e-9
        );
    }
	/// <summary>
    /// Extension method to convert Nanometre to Gigametre
    /// </summary>
    /// <param name="val">quantity measured in Nanometre</param>
    /// <returns>quantity measured in Gigametre</returns>
	public static Quantity<double, Gigametre> ToGigametre<T>(this Quantity<T, Nanometre> val) where T:IConvertible {
        return new Quantity<double, Gigametre>(
            Convert.ToDouble(val.Value) * 10e-9
        );
    }
	/// <summary>
    /// Extension method to convert Nanometre to Megametre
    /// </summary>
    /// <param name="val">quantity measured in Nanometre</param>
    /// <returns>quantity measured in Megametre</returns>
	public static Quantity<double, Megametre> ToMegametre<T>(this Quantity<T, Nanometre> val) where T:IConvertible {
        return new Quantity<double, Megametre>(
            Convert.ToDouble(val.Value) * 10e-9
        );
    }
	/// <summary>
    /// Extension method to convert Nanometre to Kilometre
    /// </summary>
    /// <param name="val">quantity measured in Nanometre</param>
    /// <returns>quantity measured in Kilometre</returns>
	public static Quantity<double, Kilometre> ToKilometre<T>(this Quantity<T, Nanometre> val) where T:IConvertible {
        return new Quantity<double, Kilometre>(
            Convert.ToDouble(val.Value) * 10e-9
        );
    }
	/// <summary>
    /// Extension method to convert Nanometre to Hectometre
    /// </summary>
    /// <param name="val">quantity measured in Nanometre</param>
    /// <returns>quantity measured in Hectometre</returns>
	public static Quantity<double, Hectometre> ToHectometre<T>(this Quantity<T, Nanometre> val) where T:IConvertible {
        return new Quantity<double, Hectometre>(
            Convert.ToDouble(val.Value) * 10e-9
        );
    }
	/// <summary>
    /// Extension method to convert Nanometre to Dekametre
    /// </summary>
    /// <param name="val">quantity measured in Nanometre</param>
    /// <returns>quantity measured in Dekametre</returns>
	public static Quantity<double, Dekametre> ToDekametre<T>(this Quantity<T, Nanometre> val) where T:IConvertible {
        return new Quantity<double, Dekametre>(
            Convert.ToDouble(val.Value) * 10e-9
        );
    }
	/// <summary>
    /// Extension method to convert Nanometre to Decimetre
    /// </summary>
    /// <param name="val">quantity measured in Nanometre</param>
    /// <returns>quantity measured in Decimetre</returns>
	public static Quantity<double, Decimetre> ToDecimetre<T>(this Quantity<T, Nanometre> val) where T:IConvertible {
        return new Quantity<double, Decimetre>(
            Convert.ToDouble(val.Value) * 10e-9
        );
    }
	/// <summary>
    /// Extension method to convert Nanometre to Centimetre
    /// </summary>
    /// <param name="val">quantity measured in Nanometre</param>
    /// <returns>quantity measured in Centimetre</returns>
	public static Quantity<double, Centimetre> ToCentimetre<T>(this Quantity<T, Nanometre> val) where T:IConvertible {
        return new Quantity<double, Centimetre>(
            Convert.ToDouble(val.Value) * 10e-9
        );
    }
	/// <summary>
    /// Extension method to convert Nanometre to Millimetre
    /// </summary>
    /// <param name="val">quantity measured in Nanometre</param>
    /// <returns>quantity measured in Millimetre</returns>
	public static Quantity<double, Millimetre> ToMillimetre<T>(this Quantity<T, Nanometre> val) where T:IConvertible {
        return new Quantity<double, Millimetre>(
            Convert.ToDouble(val.Value) * 10e-9
        );
    }
	/// <summary>
    /// Extension method to convert Nanometre to Micrometre
    /// </summary>
    /// <param name="val">quantity measured in Nanometre</param>
    /// <returns>quantity measured in Micrometre</returns>
	public static Quantity<double, Micrometre> ToMicrometre<T>(this Quantity<T, Nanometre> val) where T:IConvertible {
        return new Quantity<double, Micrometre>(
            Convert.ToDouble(val.Value) * 10e-9
        );
    }
	/// <summary>
    /// Extension method to convert Nanometre to Picometre
    /// </summary>
    /// <param name="val">quantity measured in Nanometre</param>
    /// <returns>quantity measured in Picometre</returns>
	public static Quantity<double, Picometre> ToPicometre<T>(this Quantity<T, Nanometre> val) where T:IConvertible {
        return new Quantity<double, Picometre>(
            Convert.ToDouble(val.Value) * 10e-9
        );
    }
	/// <summary>
    /// Extension method to convert Nanometre to Femtometre
    /// </summary>
    /// <param name="val">quantity measured in Nanometre</param>
    /// <returns>quantity measured in Femtometre</returns>
	public static Quantity<double, Femtometre> ToFemtometre<T>(this Quantity<T, Nanometre> val) where T:IConvertible {
        return new Quantity<double, Femtometre>(
            Convert.ToDouble(val.Value) * 10e-9
        );
    }
	/// <summary>
    /// Extension method to convert Nanometre to Attometre
    /// </summary>
    /// <param name="val">quantity measured in Nanometre</param>
    /// <returns>quantity measured in Attometre</returns>
	public static Quantity<double, Attometre> ToAttometre<T>(this Quantity<T, Nanometre> val) where T:IConvertible {
        return new Quantity<double, Attometre>(
            Convert.ToDouble(val.Value) * 10e-9
        );
    }
	/// <summary>
    /// Extension method to convert Nanometre to Zeptometre
    /// </summary>
    /// <param name="val">quantity measured in Nanometre</param>
    /// <returns>quantity measured in Zeptometre</returns>
	public static Quantity<double, Zeptometre> ToZeptometre<T>(this Quantity<T, Nanometre> val) where T:IConvertible {
        return new Quantity<double, Zeptometre>(
            Convert.ToDouble(val.Value) * 10e-9
        );
    }
	/// <summary>
    /// Extension method to convert Nanometre to Yoctometre
    /// </summary>
    /// <param name="val">quantity measured in Nanometre</param>
    /// <returns>quantity measured in Yoctometre</returns>
	public static Quantity<double, Yoctometre> ToYoctometre<T>(this Quantity<T, Nanometre> val) where T:IConvertible {
        return new Quantity<double, Yoctometre>(
            Convert.ToDouble(val.Value) * 10e-9
        );
    }
	/// <summary>
    /// Extension method to convert Picometre to Yottametre
    /// </summary>
    /// <param name="val">quantity measured in Picometre</param>
    /// <returns>quantity measured in Yottametre</returns>
	public static Quantity<double, Yottametre> ToYottametre<T>(this Quantity<T, Picometre> val) where T:IConvertible {
        return new Quantity<double, Yottametre>(
            Convert.ToDouble(val.Value) * 10e-12
        );
    }
	/// <summary>
    /// Extension method to convert Picometre to Zettametre
    /// </summary>
    /// <param name="val">quantity measured in Picometre</param>
    /// <returns>quantity measured in Zettametre</returns>
	public static Quantity<double, Zettametre> ToZettametre<T>(this Quantity<T, Picometre> val) where T:IConvertible {
        return new Quantity<double, Zettametre>(
            Convert.ToDouble(val.Value) * 10e-12
        );
    }
	/// <summary>
    /// Extension method to convert Picometre to Exametre
    /// </summary>
    /// <param name="val">quantity measured in Picometre</param>
    /// <returns>quantity measured in Exametre</returns>
	public static Quantity<double, Exametre> ToExametre<T>(this Quantity<T, Picometre> val) where T:IConvertible {
        return new Quantity<double, Exametre>(
            Convert.ToDouble(val.Value) * 10e-12
        );
    }
	/// <summary>
    /// Extension method to convert Picometre to Petametre
    /// </summary>
    /// <param name="val">quantity measured in Picometre</param>
    /// <returns>quantity measured in Petametre</returns>
	public static Quantity<double, Petametre> ToPetametre<T>(this Quantity<T, Picometre> val) where T:IConvertible {
        return new Quantity<double, Petametre>(
            Convert.ToDouble(val.Value) * 10e-12
        );
    }
	/// <summary>
    /// Extension method to convert Picometre to Terametre
    /// </summary>
    /// <param name="val">quantity measured in Picometre</param>
    /// <returns>quantity measured in Terametre</returns>
	public static Quantity<double, Terametre> ToTerametre<T>(this Quantity<T, Picometre> val) where T:IConvertible {
        return new Quantity<double, Terametre>(
            Convert.ToDouble(val.Value) * 10e-12
        );
    }
	/// <summary>
    /// Extension method to convert Picometre to Gigametre
    /// </summary>
    /// <param name="val">quantity measured in Picometre</param>
    /// <returns>quantity measured in Gigametre</returns>
	public static Quantity<double, Gigametre> ToGigametre<T>(this Quantity<T, Picometre> val) where T:IConvertible {
        return new Quantity<double, Gigametre>(
            Convert.ToDouble(val.Value) * 10e-12
        );
    }
	/// <summary>
    /// Extension method to convert Picometre to Megametre
    /// </summary>
    /// <param name="val">quantity measured in Picometre</param>
    /// <returns>quantity measured in Megametre</returns>
	public static Quantity<double, Megametre> ToMegametre<T>(this Quantity<T, Picometre> val) where T:IConvertible {
        return new Quantity<double, Megametre>(
            Convert.ToDouble(val.Value) * 10e-12
        );
    }
	/// <summary>
    /// Extension method to convert Picometre to Kilometre
    /// </summary>
    /// <param name="val">quantity measured in Picometre</param>
    /// <returns>quantity measured in Kilometre</returns>
	public static Quantity<double, Kilometre> ToKilometre<T>(this Quantity<T, Picometre> val) where T:IConvertible {
        return new Quantity<double, Kilometre>(
            Convert.ToDouble(val.Value) * 10e-12
        );
    }
	/// <summary>
    /// Extension method to convert Picometre to Hectometre
    /// </summary>
    /// <param name="val">quantity measured in Picometre</param>
    /// <returns>quantity measured in Hectometre</returns>
	public static Quantity<double, Hectometre> ToHectometre<T>(this Quantity<T, Picometre> val) where T:IConvertible {
        return new Quantity<double, Hectometre>(
            Convert.ToDouble(val.Value) * 10e-12
        );
    }
	/// <summary>
    /// Extension method to convert Picometre to Dekametre
    /// </summary>
    /// <param name="val">quantity measured in Picometre</param>
    /// <returns>quantity measured in Dekametre</returns>
	public static Quantity<double, Dekametre> ToDekametre<T>(this Quantity<T, Picometre> val) where T:IConvertible {
        return new Quantity<double, Dekametre>(
            Convert.ToDouble(val.Value) * 10e-12
        );
    }
	/// <summary>
    /// Extension method to convert Picometre to Decimetre
    /// </summary>
    /// <param name="val">quantity measured in Picometre</param>
    /// <returns>quantity measured in Decimetre</returns>
	public static Quantity<double, Decimetre> ToDecimetre<T>(this Quantity<T, Picometre> val) where T:IConvertible {
        return new Quantity<double, Decimetre>(
            Convert.ToDouble(val.Value) * 10e-12
        );
    }
	/// <summary>
    /// Extension method to convert Picometre to Centimetre
    /// </summary>
    /// <param name="val">quantity measured in Picometre</param>
    /// <returns>quantity measured in Centimetre</returns>
	public static Quantity<double, Centimetre> ToCentimetre<T>(this Quantity<T, Picometre> val) where T:IConvertible {
        return new Quantity<double, Centimetre>(
            Convert.ToDouble(val.Value) * 10e-12
        );
    }
	/// <summary>
    /// Extension method to convert Picometre to Millimetre
    /// </summary>
    /// <param name="val">quantity measured in Picometre</param>
    /// <returns>quantity measured in Millimetre</returns>
	public static Quantity<double, Millimetre> ToMillimetre<T>(this Quantity<T, Picometre> val) where T:IConvertible {
        return new Quantity<double, Millimetre>(
            Convert.ToDouble(val.Value) * 10e-12
        );
    }
	/// <summary>
    /// Extension method to convert Picometre to Micrometre
    /// </summary>
    /// <param name="val">quantity measured in Picometre</param>
    /// <returns>quantity measured in Micrometre</returns>
	public static Quantity<double, Micrometre> ToMicrometre<T>(this Quantity<T, Picometre> val) where T:IConvertible {
        return new Quantity<double, Micrometre>(
            Convert.ToDouble(val.Value) * 10e-12
        );
    }
	/// <summary>
    /// Extension method to convert Picometre to Nanometre
    /// </summary>
    /// <param name="val">quantity measured in Picometre</param>
    /// <returns>quantity measured in Nanometre</returns>
	public static Quantity<double, Nanometre> ToNanometre<T>(this Quantity<T, Picometre> val) where T:IConvertible {
        return new Quantity<double, Nanometre>(
            Convert.ToDouble(val.Value) * 10e-12
        );
    }
	/// <summary>
    /// Extension method to convert Picometre to Femtometre
    /// </summary>
    /// <param name="val">quantity measured in Picometre</param>
    /// <returns>quantity measured in Femtometre</returns>
	public static Quantity<double, Femtometre> ToFemtometre<T>(this Quantity<T, Picometre> val) where T:IConvertible {
        return new Quantity<double, Femtometre>(
            Convert.ToDouble(val.Value) * 10e-12
        );
    }
	/// <summary>
    /// Extension method to convert Picometre to Attometre
    /// </summary>
    /// <param name="val">quantity measured in Picometre</param>
    /// <returns>quantity measured in Attometre</returns>
	public static Quantity<double, Attometre> ToAttometre<T>(this Quantity<T, Picometre> val) where T:IConvertible {
        return new Quantity<double, Attometre>(
            Convert.ToDouble(val.Value) * 10e-12
        );
    }
	/// <summary>
    /// Extension method to convert Picometre to Zeptometre
    /// </summary>
    /// <param name="val">quantity measured in Picometre</param>
    /// <returns>quantity measured in Zeptometre</returns>
	public static Quantity<double, Zeptometre> ToZeptometre<T>(this Quantity<T, Picometre> val) where T:IConvertible {
        return new Quantity<double, Zeptometre>(
            Convert.ToDouble(val.Value) * 10e-12
        );
    }
	/// <summary>
    /// Extension method to convert Picometre to Yoctometre
    /// </summary>
    /// <param name="val">quantity measured in Picometre</param>
    /// <returns>quantity measured in Yoctometre</returns>
	public static Quantity<double, Yoctometre> ToYoctometre<T>(this Quantity<T, Picometre> val) where T:IConvertible {
        return new Quantity<double, Yoctometre>(
            Convert.ToDouble(val.Value) * 10e-12
        );
    }
	/// <summary>
    /// Extension method to convert Femtometre to Yottametre
    /// </summary>
    /// <param name="val">quantity measured in Femtometre</param>
    /// <returns>quantity measured in Yottametre</returns>
	public static Quantity<double, Yottametre> ToYottametre<T>(this Quantity<T, Femtometre> val) where T:IConvertible {
        return new Quantity<double, Yottametre>(
            Convert.ToDouble(val.Value) * 10e-15
        );
    }
	/// <summary>
    /// Extension method to convert Femtometre to Zettametre
    /// </summary>
    /// <param name="val">quantity measured in Femtometre</param>
    /// <returns>quantity measured in Zettametre</returns>
	public static Quantity<double, Zettametre> ToZettametre<T>(this Quantity<T, Femtometre> val) where T:IConvertible {
        return new Quantity<double, Zettametre>(
            Convert.ToDouble(val.Value) * 10e-15
        );
    }
	/// <summary>
    /// Extension method to convert Femtometre to Exametre
    /// </summary>
    /// <param name="val">quantity measured in Femtometre</param>
    /// <returns>quantity measured in Exametre</returns>
	public static Quantity<double, Exametre> ToExametre<T>(this Quantity<T, Femtometre> val) where T:IConvertible {
        return new Quantity<double, Exametre>(
            Convert.ToDouble(val.Value) * 10e-15
        );
    }
	/// <summary>
    /// Extension method to convert Femtometre to Petametre
    /// </summary>
    /// <param name="val">quantity measured in Femtometre</param>
    /// <returns>quantity measured in Petametre</returns>
	public static Quantity<double, Petametre> ToPetametre<T>(this Quantity<T, Femtometre> val) where T:IConvertible {
        return new Quantity<double, Petametre>(
            Convert.ToDouble(val.Value) * 10e-15
        );
    }
	/// <summary>
    /// Extension method to convert Femtometre to Terametre
    /// </summary>
    /// <param name="val">quantity measured in Femtometre</param>
    /// <returns>quantity measured in Terametre</returns>
	public static Quantity<double, Terametre> ToTerametre<T>(this Quantity<T, Femtometre> val) where T:IConvertible {
        return new Quantity<double, Terametre>(
            Convert.ToDouble(val.Value) * 10e-15
        );
    }
	/// <summary>
    /// Extension method to convert Femtometre to Gigametre
    /// </summary>
    /// <param name="val">quantity measured in Femtometre</param>
    /// <returns>quantity measured in Gigametre</returns>
	public static Quantity<double, Gigametre> ToGigametre<T>(this Quantity<T, Femtometre> val) where T:IConvertible {
        return new Quantity<double, Gigametre>(
            Convert.ToDouble(val.Value) * 10e-15
        );
    }
	/// <summary>
    /// Extension method to convert Femtometre to Megametre
    /// </summary>
    /// <param name="val">quantity measured in Femtometre</param>
    /// <returns>quantity measured in Megametre</returns>
	public static Quantity<double, Megametre> ToMegametre<T>(this Quantity<T, Femtometre> val) where T:IConvertible {
        return new Quantity<double, Megametre>(
            Convert.ToDouble(val.Value) * 10e-15
        );
    }
	/// <summary>
    /// Extension method to convert Femtometre to Kilometre
    /// </summary>
    /// <param name="val">quantity measured in Femtometre</param>
    /// <returns>quantity measured in Kilometre</returns>
	public static Quantity<double, Kilometre> ToKilometre<T>(this Quantity<T, Femtometre> val) where T:IConvertible {
        return new Quantity<double, Kilometre>(
            Convert.ToDouble(val.Value) * 10e-15
        );
    }
	/// <summary>
    /// Extension method to convert Femtometre to Hectometre
    /// </summary>
    /// <param name="val">quantity measured in Femtometre</param>
    /// <returns>quantity measured in Hectometre</returns>
	public static Quantity<double, Hectometre> ToHectometre<T>(this Quantity<T, Femtometre> val) where T:IConvertible {
        return new Quantity<double, Hectometre>(
            Convert.ToDouble(val.Value) * 10e-15
        );
    }
	/// <summary>
    /// Extension method to convert Femtometre to Dekametre
    /// </summary>
    /// <param name="val">quantity measured in Femtometre</param>
    /// <returns>quantity measured in Dekametre</returns>
	public static Quantity<double, Dekametre> ToDekametre<T>(this Quantity<T, Femtometre> val) where T:IConvertible {
        return new Quantity<double, Dekametre>(
            Convert.ToDouble(val.Value) * 10e-15
        );
    }
	/// <summary>
    /// Extension method to convert Femtometre to Decimetre
    /// </summary>
    /// <param name="val">quantity measured in Femtometre</param>
    /// <returns>quantity measured in Decimetre</returns>
	public static Quantity<double, Decimetre> ToDecimetre<T>(this Quantity<T, Femtometre> val) where T:IConvertible {
        return new Quantity<double, Decimetre>(
            Convert.ToDouble(val.Value) * 10e-15
        );
    }
	/// <summary>
    /// Extension method to convert Femtometre to Centimetre
    /// </summary>
    /// <param name="val">quantity measured in Femtometre</param>
    /// <returns>quantity measured in Centimetre</returns>
	public static Quantity<double, Centimetre> ToCentimetre<T>(this Quantity<T, Femtometre> val) where T:IConvertible {
        return new Quantity<double, Centimetre>(
            Convert.ToDouble(val.Value) * 10e-15
        );
    }
	/// <summary>
    /// Extension method to convert Femtometre to Millimetre
    /// </summary>
    /// <param name="val">quantity measured in Femtometre</param>
    /// <returns>quantity measured in Millimetre</returns>
	public static Quantity<double, Millimetre> ToMillimetre<T>(this Quantity<T, Femtometre> val) where T:IConvertible {
        return new Quantity<double, Millimetre>(
            Convert.ToDouble(val.Value) * 10e-15
        );
    }
	/// <summary>
    /// Extension method to convert Femtometre to Micrometre
    /// </summary>
    /// <param name="val">quantity measured in Femtometre</param>
    /// <returns>quantity measured in Micrometre</returns>
	public static Quantity<double, Micrometre> ToMicrometre<T>(this Quantity<T, Femtometre> val) where T:IConvertible {
        return new Quantity<double, Micrometre>(
            Convert.ToDouble(val.Value) * 10e-15
        );
    }
	/// <summary>
    /// Extension method to convert Femtometre to Nanometre
    /// </summary>
    /// <param name="val">quantity measured in Femtometre</param>
    /// <returns>quantity measured in Nanometre</returns>
	public static Quantity<double, Nanometre> ToNanometre<T>(this Quantity<T, Femtometre> val) where T:IConvertible {
        return new Quantity<double, Nanometre>(
            Convert.ToDouble(val.Value) * 10e-15
        );
    }
	/// <summary>
    /// Extension method to convert Femtometre to Picometre
    /// </summary>
    /// <param name="val">quantity measured in Femtometre</param>
    /// <returns>quantity measured in Picometre</returns>
	public static Quantity<double, Picometre> ToPicometre<T>(this Quantity<T, Femtometre> val) where T:IConvertible {
        return new Quantity<double, Picometre>(
            Convert.ToDouble(val.Value) * 10e-15
        );
    }
	/// <summary>
    /// Extension method to convert Femtometre to Attometre
    /// </summary>
    /// <param name="val">quantity measured in Femtometre</param>
    /// <returns>quantity measured in Attometre</returns>
	public static Quantity<double, Attometre> ToAttometre<T>(this Quantity<T, Femtometre> val) where T:IConvertible {
        return new Quantity<double, Attometre>(
            Convert.ToDouble(val.Value) * 10e-15
        );
    }
	/// <summary>
    /// Extension method to convert Femtometre to Zeptometre
    /// </summary>
    /// <param name="val">quantity measured in Femtometre</param>
    /// <returns>quantity measured in Zeptometre</returns>
	public static Quantity<double, Zeptometre> ToZeptometre<T>(this Quantity<T, Femtometre> val) where T:IConvertible {
        return new Quantity<double, Zeptometre>(
            Convert.ToDouble(val.Value) * 10e-15
        );
    }
	/// <summary>
    /// Extension method to convert Femtometre to Yoctometre
    /// </summary>
    /// <param name="val">quantity measured in Femtometre</param>
    /// <returns>quantity measured in Yoctometre</returns>
	public static Quantity<double, Yoctometre> ToYoctometre<T>(this Quantity<T, Femtometre> val) where T:IConvertible {
        return new Quantity<double, Yoctometre>(
            Convert.ToDouble(val.Value) * 10e-15
        );
    }
	/// <summary>
    /// Extension method to convert Attometre to Yottametre
    /// </summary>
    /// <param name="val">quantity measured in Attometre</param>
    /// <returns>quantity measured in Yottametre</returns>
	public static Quantity<double, Yottametre> ToYottametre<T>(this Quantity<T, Attometre> val) where T:IConvertible {
        return new Quantity<double, Yottametre>(
            Convert.ToDouble(val.Value) * 10e-18
        );
    }
	/// <summary>
    /// Extension method to convert Attometre to Zettametre
    /// </summary>
    /// <param name="val">quantity measured in Attometre</param>
    /// <returns>quantity measured in Zettametre</returns>
	public static Quantity<double, Zettametre> ToZettametre<T>(this Quantity<T, Attometre> val) where T:IConvertible {
        return new Quantity<double, Zettametre>(
            Convert.ToDouble(val.Value) * 10e-18
        );
    }
	/// <summary>
    /// Extension method to convert Attometre to Exametre
    /// </summary>
    /// <param name="val">quantity measured in Attometre</param>
    /// <returns>quantity measured in Exametre</returns>
	public static Quantity<double, Exametre> ToExametre<T>(this Quantity<T, Attometre> val) where T:IConvertible {
        return new Quantity<double, Exametre>(
            Convert.ToDouble(val.Value) * 10e-18
        );
    }
	/// <summary>
    /// Extension method to convert Attometre to Petametre
    /// </summary>
    /// <param name="val">quantity measured in Attometre</param>
    /// <returns>quantity measured in Petametre</returns>
	public static Quantity<double, Petametre> ToPetametre<T>(this Quantity<T, Attometre> val) where T:IConvertible {
        return new Quantity<double, Petametre>(
            Convert.ToDouble(val.Value) * 10e-18
        );
    }
	/// <summary>
    /// Extension method to convert Attometre to Terametre
    /// </summary>
    /// <param name="val">quantity measured in Attometre</param>
    /// <returns>quantity measured in Terametre</returns>
	public static Quantity<double, Terametre> ToTerametre<T>(this Quantity<T, Attometre> val) where T:IConvertible {
        return new Quantity<double, Terametre>(
            Convert.ToDouble(val.Value) * 10e-18
        );
    }
	/// <summary>
    /// Extension method to convert Attometre to Gigametre
    /// </summary>
    /// <param name="val">quantity measured in Attometre</param>
    /// <returns>quantity measured in Gigametre</returns>
	public static Quantity<double, Gigametre> ToGigametre<T>(this Quantity<T, Attometre> val) where T:IConvertible {
        return new Quantity<double, Gigametre>(
            Convert.ToDouble(val.Value) * 10e-18
        );
    }
	/// <summary>
    /// Extension method to convert Attometre to Megametre
    /// </summary>
    /// <param name="val">quantity measured in Attometre</param>
    /// <returns>quantity measured in Megametre</returns>
	public static Quantity<double, Megametre> ToMegametre<T>(this Quantity<T, Attometre> val) where T:IConvertible {
        return new Quantity<double, Megametre>(
            Convert.ToDouble(val.Value) * 10e-18
        );
    }
	/// <summary>
    /// Extension method to convert Attometre to Kilometre
    /// </summary>
    /// <param name="val">quantity measured in Attometre</param>
    /// <returns>quantity measured in Kilometre</returns>
	public static Quantity<double, Kilometre> ToKilometre<T>(this Quantity<T, Attometre> val) where T:IConvertible {
        return new Quantity<double, Kilometre>(
            Convert.ToDouble(val.Value) * 10e-18
        );
    }
	/// <summary>
    /// Extension method to convert Attometre to Hectometre
    /// </summary>
    /// <param name="val">quantity measured in Attometre</param>
    /// <returns>quantity measured in Hectometre</returns>
	public static Quantity<double, Hectometre> ToHectometre<T>(this Quantity<T, Attometre> val) where T:IConvertible {
        return new Quantity<double, Hectometre>(
            Convert.ToDouble(val.Value) * 10e-18
        );
    }
	/// <summary>
    /// Extension method to convert Attometre to Dekametre
    /// </summary>
    /// <param name="val">quantity measured in Attometre</param>
    /// <returns>quantity measured in Dekametre</returns>
	public static Quantity<double, Dekametre> ToDekametre<T>(this Quantity<T, Attometre> val) where T:IConvertible {
        return new Quantity<double, Dekametre>(
            Convert.ToDouble(val.Value) * 10e-18
        );
    }
	/// <summary>
    /// Extension method to convert Attometre to Decimetre
    /// </summary>
    /// <param name="val">quantity measured in Attometre</param>
    /// <returns>quantity measured in Decimetre</returns>
	public static Quantity<double, Decimetre> ToDecimetre<T>(this Quantity<T, Attometre> val) where T:IConvertible {
        return new Quantity<double, Decimetre>(
            Convert.ToDouble(val.Value) * 10e-18
        );
    }
	/// <summary>
    /// Extension method to convert Attometre to Centimetre
    /// </summary>
    /// <param name="val">quantity measured in Attometre</param>
    /// <returns>quantity measured in Centimetre</returns>
	public static Quantity<double, Centimetre> ToCentimetre<T>(this Quantity<T, Attometre> val) where T:IConvertible {
        return new Quantity<double, Centimetre>(
            Convert.ToDouble(val.Value) * 10e-18
        );
    }
	/// <summary>
    /// Extension method to convert Attometre to Millimetre
    /// </summary>
    /// <param name="val">quantity measured in Attometre</param>
    /// <returns>quantity measured in Millimetre</returns>
	public static Quantity<double, Millimetre> ToMillimetre<T>(this Quantity<T, Attometre> val) where T:IConvertible {
        return new Quantity<double, Millimetre>(
            Convert.ToDouble(val.Value) * 10e-18
        );
    }
	/// <summary>
    /// Extension method to convert Attometre to Micrometre
    /// </summary>
    /// <param name="val">quantity measured in Attometre</param>
    /// <returns>quantity measured in Micrometre</returns>
	public static Quantity<double, Micrometre> ToMicrometre<T>(this Quantity<T, Attometre> val) where T:IConvertible {
        return new Quantity<double, Micrometre>(
            Convert.ToDouble(val.Value) * 10e-18
        );
    }
	/// <summary>
    /// Extension method to convert Attometre to Nanometre
    /// </summary>
    /// <param name="val">quantity measured in Attometre</param>
    /// <returns>quantity measured in Nanometre</returns>
	public static Quantity<double, Nanometre> ToNanometre<T>(this Quantity<T, Attometre> val) where T:IConvertible {
        return new Quantity<double, Nanometre>(
            Convert.ToDouble(val.Value) * 10e-18
        );
    }
	/// <summary>
    /// Extension method to convert Attometre to Picometre
    /// </summary>
    /// <param name="val">quantity measured in Attometre</param>
    /// <returns>quantity measured in Picometre</returns>
	public static Quantity<double, Picometre> ToPicometre<T>(this Quantity<T, Attometre> val) where T:IConvertible {
        return new Quantity<double, Picometre>(
            Convert.ToDouble(val.Value) * 10e-18
        );
    }
	/// <summary>
    /// Extension method to convert Attometre to Femtometre
    /// </summary>
    /// <param name="val">quantity measured in Attometre</param>
    /// <returns>quantity measured in Femtometre</returns>
	public static Quantity<double, Femtometre> ToFemtometre<T>(this Quantity<T, Attometre> val) where T:IConvertible {
        return new Quantity<double, Femtometre>(
            Convert.ToDouble(val.Value) * 10e-18
        );
    }
	/// <summary>
    /// Extension method to convert Attometre to Zeptometre
    /// </summary>
    /// <param name="val">quantity measured in Attometre</param>
    /// <returns>quantity measured in Zeptometre</returns>
	public static Quantity<double, Zeptometre> ToZeptometre<T>(this Quantity<T, Attometre> val) where T:IConvertible {
        return new Quantity<double, Zeptometre>(
            Convert.ToDouble(val.Value) * 10e-18
        );
    }
	/// <summary>
    /// Extension method to convert Attometre to Yoctometre
    /// </summary>
    /// <param name="val">quantity measured in Attometre</param>
    /// <returns>quantity measured in Yoctometre</returns>
	public static Quantity<double, Yoctometre> ToYoctometre<T>(this Quantity<T, Attometre> val) where T:IConvertible {
        return new Quantity<double, Yoctometre>(
            Convert.ToDouble(val.Value) * 10e-18
        );
    }
	/// <summary>
    /// Extension method to convert Zeptometre to Yottametre
    /// </summary>
    /// <param name="val">quantity measured in Zeptometre</param>
    /// <returns>quantity measured in Yottametre</returns>
	public static Quantity<double, Yottametre> ToYottametre<T>(this Quantity<T, Zeptometre> val) where T:IConvertible {
        return new Quantity<double, Yottametre>(
            Convert.ToDouble(val.Value) * 10e-21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptometre to Zettametre
    /// </summary>
    /// <param name="val">quantity measured in Zeptometre</param>
    /// <returns>quantity measured in Zettametre</returns>
	public static Quantity<double, Zettametre> ToZettametre<T>(this Quantity<T, Zeptometre> val) where T:IConvertible {
        return new Quantity<double, Zettametre>(
            Convert.ToDouble(val.Value) * 10e-21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptometre to Exametre
    /// </summary>
    /// <param name="val">quantity measured in Zeptometre</param>
    /// <returns>quantity measured in Exametre</returns>
	public static Quantity<double, Exametre> ToExametre<T>(this Quantity<T, Zeptometre> val) where T:IConvertible {
        return new Quantity<double, Exametre>(
            Convert.ToDouble(val.Value) * 10e-21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptometre to Petametre
    /// </summary>
    /// <param name="val">quantity measured in Zeptometre</param>
    /// <returns>quantity measured in Petametre</returns>
	public static Quantity<double, Petametre> ToPetametre<T>(this Quantity<T, Zeptometre> val) where T:IConvertible {
        return new Quantity<double, Petametre>(
            Convert.ToDouble(val.Value) * 10e-21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptometre to Terametre
    /// </summary>
    /// <param name="val">quantity measured in Zeptometre</param>
    /// <returns>quantity measured in Terametre</returns>
	public static Quantity<double, Terametre> ToTerametre<T>(this Quantity<T, Zeptometre> val) where T:IConvertible {
        return new Quantity<double, Terametre>(
            Convert.ToDouble(val.Value) * 10e-21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptometre to Gigametre
    /// </summary>
    /// <param name="val">quantity measured in Zeptometre</param>
    /// <returns>quantity measured in Gigametre</returns>
	public static Quantity<double, Gigametre> ToGigametre<T>(this Quantity<T, Zeptometre> val) where T:IConvertible {
        return new Quantity<double, Gigametre>(
            Convert.ToDouble(val.Value) * 10e-21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptometre to Megametre
    /// </summary>
    /// <param name="val">quantity measured in Zeptometre</param>
    /// <returns>quantity measured in Megametre</returns>
	public static Quantity<double, Megametre> ToMegametre<T>(this Quantity<T, Zeptometre> val) where T:IConvertible {
        return new Quantity<double, Megametre>(
            Convert.ToDouble(val.Value) * 10e-21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptometre to Kilometre
    /// </summary>
    /// <param name="val">quantity measured in Zeptometre</param>
    /// <returns>quantity measured in Kilometre</returns>
	public static Quantity<double, Kilometre> ToKilometre<T>(this Quantity<T, Zeptometre> val) where T:IConvertible {
        return new Quantity<double, Kilometre>(
            Convert.ToDouble(val.Value) * 10e-21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptometre to Hectometre
    /// </summary>
    /// <param name="val">quantity measured in Zeptometre</param>
    /// <returns>quantity measured in Hectometre</returns>
	public static Quantity<double, Hectometre> ToHectometre<T>(this Quantity<T, Zeptometre> val) where T:IConvertible {
        return new Quantity<double, Hectometre>(
            Convert.ToDouble(val.Value) * 10e-21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptometre to Dekametre
    /// </summary>
    /// <param name="val">quantity measured in Zeptometre</param>
    /// <returns>quantity measured in Dekametre</returns>
	public static Quantity<double, Dekametre> ToDekametre<T>(this Quantity<T, Zeptometre> val) where T:IConvertible {
        return new Quantity<double, Dekametre>(
            Convert.ToDouble(val.Value) * 10e-21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptometre to Decimetre
    /// </summary>
    /// <param name="val">quantity measured in Zeptometre</param>
    /// <returns>quantity measured in Decimetre</returns>
	public static Quantity<double, Decimetre> ToDecimetre<T>(this Quantity<T, Zeptometre> val) where T:IConvertible {
        return new Quantity<double, Decimetre>(
            Convert.ToDouble(val.Value) * 10e-21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptometre to Centimetre
    /// </summary>
    /// <param name="val">quantity measured in Zeptometre</param>
    /// <returns>quantity measured in Centimetre</returns>
	public static Quantity<double, Centimetre> ToCentimetre<T>(this Quantity<T, Zeptometre> val) where T:IConvertible {
        return new Quantity<double, Centimetre>(
            Convert.ToDouble(val.Value) * 10e-21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptometre to Millimetre
    /// </summary>
    /// <param name="val">quantity measured in Zeptometre</param>
    /// <returns>quantity measured in Millimetre</returns>
	public static Quantity<double, Millimetre> ToMillimetre<T>(this Quantity<T, Zeptometre> val) where T:IConvertible {
        return new Quantity<double, Millimetre>(
            Convert.ToDouble(val.Value) * 10e-21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptometre to Micrometre
    /// </summary>
    /// <param name="val">quantity measured in Zeptometre</param>
    /// <returns>quantity measured in Micrometre</returns>
	public static Quantity<double, Micrometre> ToMicrometre<T>(this Quantity<T, Zeptometre> val) where T:IConvertible {
        return new Quantity<double, Micrometre>(
            Convert.ToDouble(val.Value) * 10e-21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptometre to Nanometre
    /// </summary>
    /// <param name="val">quantity measured in Zeptometre</param>
    /// <returns>quantity measured in Nanometre</returns>
	public static Quantity<double, Nanometre> ToNanometre<T>(this Quantity<T, Zeptometre> val) where T:IConvertible {
        return new Quantity<double, Nanometre>(
            Convert.ToDouble(val.Value) * 10e-21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptometre to Picometre
    /// </summary>
    /// <param name="val">quantity measured in Zeptometre</param>
    /// <returns>quantity measured in Picometre</returns>
	public static Quantity<double, Picometre> ToPicometre<T>(this Quantity<T, Zeptometre> val) where T:IConvertible {
        return new Quantity<double, Picometre>(
            Convert.ToDouble(val.Value) * 10e-21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptometre to Femtometre
    /// </summary>
    /// <param name="val">quantity measured in Zeptometre</param>
    /// <returns>quantity measured in Femtometre</returns>
	public static Quantity<double, Femtometre> ToFemtometre<T>(this Quantity<T, Zeptometre> val) where T:IConvertible {
        return new Quantity<double, Femtometre>(
            Convert.ToDouble(val.Value) * 10e-21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptometre to Attometre
    /// </summary>
    /// <param name="val">quantity measured in Zeptometre</param>
    /// <returns>quantity measured in Attometre</returns>
	public static Quantity<double, Attometre> ToAttometre<T>(this Quantity<T, Zeptometre> val) where T:IConvertible {
        return new Quantity<double, Attometre>(
            Convert.ToDouble(val.Value) * 10e-21
        );
    }
	/// <summary>
    /// Extension method to convert Zeptometre to Yoctometre
    /// </summary>
    /// <param name="val">quantity measured in Zeptometre</param>
    /// <returns>quantity measured in Yoctometre</returns>
	public static Quantity<double, Yoctometre> ToYoctometre<T>(this Quantity<T, Zeptometre> val) where T:IConvertible {
        return new Quantity<double, Yoctometre>(
            Convert.ToDouble(val.Value) * 10e-21
        );
    }
	/// <summary>
    /// Extension method to convert Yoctometre to Yottametre
    /// </summary>
    /// <param name="val">quantity measured in Yoctometre</param>
    /// <returns>quantity measured in Yottametre</returns>
	public static Quantity<double, Yottametre> ToYottametre<T>(this Quantity<T, Yoctometre> val) where T:IConvertible {
        return new Quantity<double, Yottametre>(
            Convert.ToDouble(val.Value) * 10e-24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctometre to Zettametre
    /// </summary>
    /// <param name="val">quantity measured in Yoctometre</param>
    /// <returns>quantity measured in Zettametre</returns>
	public static Quantity<double, Zettametre> ToZettametre<T>(this Quantity<T, Yoctometre> val) where T:IConvertible {
        return new Quantity<double, Zettametre>(
            Convert.ToDouble(val.Value) * 10e-24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctometre to Exametre
    /// </summary>
    /// <param name="val">quantity measured in Yoctometre</param>
    /// <returns>quantity measured in Exametre</returns>
	public static Quantity<double, Exametre> ToExametre<T>(this Quantity<T, Yoctometre> val) where T:IConvertible {
        return new Quantity<double, Exametre>(
            Convert.ToDouble(val.Value) * 10e-24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctometre to Petametre
    /// </summary>
    /// <param name="val">quantity measured in Yoctometre</param>
    /// <returns>quantity measured in Petametre</returns>
	public static Quantity<double, Petametre> ToPetametre<T>(this Quantity<T, Yoctometre> val) where T:IConvertible {
        return new Quantity<double, Petametre>(
            Convert.ToDouble(val.Value) * 10e-24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctometre to Terametre
    /// </summary>
    /// <param name="val">quantity measured in Yoctometre</param>
    /// <returns>quantity measured in Terametre</returns>
	public static Quantity<double, Terametre> ToTerametre<T>(this Quantity<T, Yoctometre> val) where T:IConvertible {
        return new Quantity<double, Terametre>(
            Convert.ToDouble(val.Value) * 10e-24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctometre to Gigametre
    /// </summary>
    /// <param name="val">quantity measured in Yoctometre</param>
    /// <returns>quantity measured in Gigametre</returns>
	public static Quantity<double, Gigametre> ToGigametre<T>(this Quantity<T, Yoctometre> val) where T:IConvertible {
        return new Quantity<double, Gigametre>(
            Convert.ToDouble(val.Value) * 10e-24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctometre to Megametre
    /// </summary>
    /// <param name="val">quantity measured in Yoctometre</param>
    /// <returns>quantity measured in Megametre</returns>
	public static Quantity<double, Megametre> ToMegametre<T>(this Quantity<T, Yoctometre> val) where T:IConvertible {
        return new Quantity<double, Megametre>(
            Convert.ToDouble(val.Value) * 10e-24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctometre to Kilometre
    /// </summary>
    /// <param name="val">quantity measured in Yoctometre</param>
    /// <returns>quantity measured in Kilometre</returns>
	public static Quantity<double, Kilometre> ToKilometre<T>(this Quantity<T, Yoctometre> val) where T:IConvertible {
        return new Quantity<double, Kilometre>(
            Convert.ToDouble(val.Value) * 10e-24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctometre to Hectometre
    /// </summary>
    /// <param name="val">quantity measured in Yoctometre</param>
    /// <returns>quantity measured in Hectometre</returns>
	public static Quantity<double, Hectometre> ToHectometre<T>(this Quantity<T, Yoctometre> val) where T:IConvertible {
        return new Quantity<double, Hectometre>(
            Convert.ToDouble(val.Value) * 10e-24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctometre to Dekametre
    /// </summary>
    /// <param name="val">quantity measured in Yoctometre</param>
    /// <returns>quantity measured in Dekametre</returns>
	public static Quantity<double, Dekametre> ToDekametre<T>(this Quantity<T, Yoctometre> val) where T:IConvertible {
        return new Quantity<double, Dekametre>(
            Convert.ToDouble(val.Value) * 10e-24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctometre to Decimetre
    /// </summary>
    /// <param name="val">quantity measured in Yoctometre</param>
    /// <returns>quantity measured in Decimetre</returns>
	public static Quantity<double, Decimetre> ToDecimetre<T>(this Quantity<T, Yoctometre> val) where T:IConvertible {
        return new Quantity<double, Decimetre>(
            Convert.ToDouble(val.Value) * 10e-24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctometre to Centimetre
    /// </summary>
    /// <param name="val">quantity measured in Yoctometre</param>
    /// <returns>quantity measured in Centimetre</returns>
	public static Quantity<double, Centimetre> ToCentimetre<T>(this Quantity<T, Yoctometre> val) where T:IConvertible {
        return new Quantity<double, Centimetre>(
            Convert.ToDouble(val.Value) * 10e-24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctometre to Millimetre
    /// </summary>
    /// <param name="val">quantity measured in Yoctometre</param>
    /// <returns>quantity measured in Millimetre</returns>
	public static Quantity<double, Millimetre> ToMillimetre<T>(this Quantity<T, Yoctometre> val) where T:IConvertible {
        return new Quantity<double, Millimetre>(
            Convert.ToDouble(val.Value) * 10e-24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctometre to Micrometre
    /// </summary>
    /// <param name="val">quantity measured in Yoctometre</param>
    /// <returns>quantity measured in Micrometre</returns>
	public static Quantity<double, Micrometre> ToMicrometre<T>(this Quantity<T, Yoctometre> val) where T:IConvertible {
        return new Quantity<double, Micrometre>(
            Convert.ToDouble(val.Value) * 10e-24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctometre to Nanometre
    /// </summary>
    /// <param name="val">quantity measured in Yoctometre</param>
    /// <returns>quantity measured in Nanometre</returns>
	public static Quantity<double, Nanometre> ToNanometre<T>(this Quantity<T, Yoctometre> val) where T:IConvertible {
        return new Quantity<double, Nanometre>(
            Convert.ToDouble(val.Value) * 10e-24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctometre to Picometre
    /// </summary>
    /// <param name="val">quantity measured in Yoctometre</param>
    /// <returns>quantity measured in Picometre</returns>
	public static Quantity<double, Picometre> ToPicometre<T>(this Quantity<T, Yoctometre> val) where T:IConvertible {
        return new Quantity<double, Picometre>(
            Convert.ToDouble(val.Value) * 10e-24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctometre to Femtometre
    /// </summary>
    /// <param name="val">quantity measured in Yoctometre</param>
    /// <returns>quantity measured in Femtometre</returns>
	public static Quantity<double, Femtometre> ToFemtometre<T>(this Quantity<T, Yoctometre> val) where T:IConvertible {
        return new Quantity<double, Femtometre>(
            Convert.ToDouble(val.Value) * 10e-24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctometre to Attometre
    /// </summary>
    /// <param name="val">quantity measured in Yoctometre</param>
    /// <returns>quantity measured in Attometre</returns>
	public static Quantity<double, Attometre> ToAttometre<T>(this Quantity<T, Yoctometre> val) where T:IConvertible {
        return new Quantity<double, Attometre>(
            Convert.ToDouble(val.Value) * 10e-24
        );
    }
	/// <summary>
    /// Extension method to convert Yoctometre to Zeptometre
    /// </summary>
    /// <param name="val">quantity measured in Yoctometre</param>
    /// <returns>quantity measured in Zeptometre</returns>
	public static Quantity<double, Zeptometre> ToZeptometre<T>(this Quantity<T, Yoctometre> val) where T:IConvertible {
        return new Quantity<double, Zeptometre>(
            Convert.ToDouble(val.Value) * 10e-24
        );
    }
}

}