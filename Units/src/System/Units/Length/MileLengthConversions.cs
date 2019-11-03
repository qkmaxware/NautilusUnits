using System;

namespace System.Units.Length {
/// <summary>
/// Static class housing conversions to and from the unit "Mile"
/// </summary>
public static class MileLengthConversions {
	/// <summary>
    /// Extension method to convert Mile to Inch
    /// </summary>
    /// <param name="val">quantity measured in Mile</param>
    /// <returns>quantity measured in Inch</returns>
    public static Quantity<double, Inch> ToInch<T>(this Quantity<T, Mile> val) where T:IConvertible {
        return new Quantity<double, Inch>(
            Convert.ToDouble(val.Value) * 63360
        );
    }
	/// <summary>
    /// Extension method to convert Inch to Mile
    /// </summary>
    /// <param name="val">quantity measured in Inch</param>
    /// <returns>quantity measured in Mile</returns>
    public static Quantity<double, Mile> ToMile<T>(this Quantity<T, Inch> val) where T:IConvertible {
        return new Quantity<double, Mile>(
            Convert.ToDouble(val.Value) * (1d/(63360))
        );
    }
	/// <summary>
    /// Extension method to convert Inch to Foot
    /// </summary>
    /// <param name="val">quantity measured in Inch</param>
    /// <returns>quantity measured in Foot</returns>
    public static Quantity<double, Foot> ToFoot<T>(this Quantity<T, Inch> val) where T:IConvertible {
        return new Quantity<double, Foot>(
            Convert.ToDouble(val.Value) * ((1d/(63360)) * (5280))
        );
    }
	/// <summary>
    /// Extension method to convert Inch to Yard
    /// </summary>
    /// <param name="val">quantity measured in Inch</param>
    /// <returns>quantity measured in Yard</returns>
    public static Quantity<double, Yard> ToYard<T>(this Quantity<T, Inch> val) where T:IConvertible {
        return new Quantity<double, Yard>(
            Convert.ToDouble(val.Value) * ((1d/(63360)) * (1760))
        );
    }
	/// <summary>
    /// Extension method to convert Inch to League
    /// </summary>
    /// <param name="val">quantity measured in Inch</param>
    /// <returns>quantity measured in League</returns>
    public static Quantity<double, League> ToLeague<T>(this Quantity<T, Inch> val) where T:IConvertible {
        return new Quantity<double, League>(
            Convert.ToDouble(val.Value) * ((1d/(63360)) * (0.289659))
        );
    }
	/// <summary>
    /// Extension method to convert Mile to Foot
    /// </summary>
    /// <param name="val">quantity measured in Mile</param>
    /// <returns>quantity measured in Foot</returns>
    public static Quantity<double, Foot> ToFoot<T>(this Quantity<T, Mile> val) where T:IConvertible {
        return new Quantity<double, Foot>(
            Convert.ToDouble(val.Value) * 5280
        );
    }
	/// <summary>
    /// Extension method to convert Foot to Mile
    /// </summary>
    /// <param name="val">quantity measured in Foot</param>
    /// <returns>quantity measured in Mile</returns>
    public static Quantity<double, Mile> ToMile<T>(this Quantity<T, Foot> val) where T:IConvertible {
        return new Quantity<double, Mile>(
            Convert.ToDouble(val.Value) * (1d/(5280))
        );
    }
	/// <summary>
    /// Extension method to convert Foot to Inch
    /// </summary>
    /// <param name="val">quantity measured in Foot</param>
    /// <returns>quantity measured in Inch</returns>
    public static Quantity<double, Inch> ToInch<T>(this Quantity<T, Foot> val) where T:IConvertible {
        return new Quantity<double, Inch>(
            Convert.ToDouble(val.Value) * ((1d/(5280)) * (63360))
        );
    }
	/// <summary>
    /// Extension method to convert Foot to Yard
    /// </summary>
    /// <param name="val">quantity measured in Foot</param>
    /// <returns>quantity measured in Yard</returns>
    public static Quantity<double, Yard> ToYard<T>(this Quantity<T, Foot> val) where T:IConvertible {
        return new Quantity<double, Yard>(
            Convert.ToDouble(val.Value) * ((1d/(5280)) * (1760))
        );
    }
	/// <summary>
    /// Extension method to convert Foot to League
    /// </summary>
    /// <param name="val">quantity measured in Foot</param>
    /// <returns>quantity measured in League</returns>
    public static Quantity<double, League> ToLeague<T>(this Quantity<T, Foot> val) where T:IConvertible {
        return new Quantity<double, League>(
            Convert.ToDouble(val.Value) * ((1d/(5280)) * (0.289659))
        );
    }
	/// <summary>
    /// Extension method to convert Mile to Yard
    /// </summary>
    /// <param name="val">quantity measured in Mile</param>
    /// <returns>quantity measured in Yard</returns>
    public static Quantity<double, Yard> ToYard<T>(this Quantity<T, Mile> val) where T:IConvertible {
        return new Quantity<double, Yard>(
            Convert.ToDouble(val.Value) * 1760
        );
    }
	/// <summary>
    /// Extension method to convert Yard to Mile
    /// </summary>
    /// <param name="val">quantity measured in Yard</param>
    /// <returns>quantity measured in Mile</returns>
    public static Quantity<double, Mile> ToMile<T>(this Quantity<T, Yard> val) where T:IConvertible {
        return new Quantity<double, Mile>(
            Convert.ToDouble(val.Value) * (1d/(1760))
        );
    }
	/// <summary>
    /// Extension method to convert Yard to Inch
    /// </summary>
    /// <param name="val">quantity measured in Yard</param>
    /// <returns>quantity measured in Inch</returns>
    public static Quantity<double, Inch> ToInch<T>(this Quantity<T, Yard> val) where T:IConvertible {
        return new Quantity<double, Inch>(
            Convert.ToDouble(val.Value) * ((1d/(1760)) * (63360))
        );
    }
	/// <summary>
    /// Extension method to convert Yard to Foot
    /// </summary>
    /// <param name="val">quantity measured in Yard</param>
    /// <returns>quantity measured in Foot</returns>
    public static Quantity<double, Foot> ToFoot<T>(this Quantity<T, Yard> val) where T:IConvertible {
        return new Quantity<double, Foot>(
            Convert.ToDouble(val.Value) * ((1d/(1760)) * (5280))
        );
    }
	/// <summary>
    /// Extension method to convert Yard to League
    /// </summary>
    /// <param name="val">quantity measured in Yard</param>
    /// <returns>quantity measured in League</returns>
    public static Quantity<double, League> ToLeague<T>(this Quantity<T, Yard> val) where T:IConvertible {
        return new Quantity<double, League>(
            Convert.ToDouble(val.Value) * ((1d/(1760)) * (0.289659))
        );
    }
	/// <summary>
    /// Extension method to convert Mile to League
    /// </summary>
    /// <param name="val">quantity measured in Mile</param>
    /// <returns>quantity measured in League</returns>
    public static Quantity<double, League> ToLeague<T>(this Quantity<T, Mile> val) where T:IConvertible {
        return new Quantity<double, League>(
            Convert.ToDouble(val.Value) * 0.289659
        );
    }
	/// <summary>
    /// Extension method to convert League to Mile
    /// </summary>
    /// <param name="val">quantity measured in League</param>
    /// <returns>quantity measured in Mile</returns>
    public static Quantity<double, Mile> ToMile<T>(this Quantity<T, League> val) where T:IConvertible {
        return new Quantity<double, Mile>(
            Convert.ToDouble(val.Value) * (1d/(0.289659))
        );
    }
	/// <summary>
    /// Extension method to convert League to Inch
    /// </summary>
    /// <param name="val">quantity measured in League</param>
    /// <returns>quantity measured in Inch</returns>
    public static Quantity<double, Inch> ToInch<T>(this Quantity<T, League> val) where T:IConvertible {
        return new Quantity<double, Inch>(
            Convert.ToDouble(val.Value) * ((1d/(0.289659)) * (63360))
        );
    }
	/// <summary>
    /// Extension method to convert League to Foot
    /// </summary>
    /// <param name="val">quantity measured in League</param>
    /// <returns>quantity measured in Foot</returns>
    public static Quantity<double, Foot> ToFoot<T>(this Quantity<T, League> val) where T:IConvertible {
        return new Quantity<double, Foot>(
            Convert.ToDouble(val.Value) * ((1d/(0.289659)) * (5280))
        );
    }
	/// <summary>
    /// Extension method to convert League to Yard
    /// </summary>
    /// <param name="val">quantity measured in League</param>
    /// <returns>quantity measured in Yard</returns>
    public static Quantity<double, Yard> ToYard<T>(this Quantity<T, League> val) where T:IConvertible {
        return new Quantity<double, Yard>(
            Convert.ToDouble(val.Value) * ((1d/(0.289659)) * (1760))
        );
    }
}
}