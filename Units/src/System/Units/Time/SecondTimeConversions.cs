using System;

namespace System.Units.Time {
public static class SecondTimeConversions {
	/// <summary>
    /// Extension method to convert Second to Minute
    /// </summary>
    /// <param name="val">quantity measured in Second</param>
    /// <returns>quantity measured in Minute</returns>
    public static Quantity<double, Minute> ToMinute<T>(this Quantity<T, Second> val) where T:IConvertible {
        return new Quantity<double, Minute>(
            Convert.ToDouble(val.Value) * (1d/60)
        );
    }
	/// <summary>
    /// Extension method to convert Minute to Second
    /// </summary>
    /// <param name="val">quantity measured in Minute</param>
    /// <returns>quantity measured in Second</returns>
    public static Quantity<double, Second> ToSecond<T>(this Quantity<T, Minute> val) where T:IConvertible {
        return new Quantity<double, Second>(
            Convert.ToDouble(val.Value) * (1d/(1d/60))
        );
    }
	/// <summary>
    /// Extension method to convert Minute to Hour
    /// </summary>
    /// <param name="val">quantity measured in Minute</param>
    /// <returns>quantity measured in Hour</returns>
    public static Quantity<double, Hour> ToHour<T>(this Quantity<T, Minute> val) where T:IConvertible {
        return new Quantity<double, Hour>(
            Convert.ToDouble(val.Value) * ((1d/(1d/60)) * (1d/3600))
        );
    }
	/// <summary>
    /// Extension method to convert Minute to Day
    /// </summary>
    /// <param name="val">quantity measured in Minute</param>
    /// <returns>quantity measured in Day</returns>
    public static Quantity<double, Day> ToDay<T>(this Quantity<T, Minute> val) where T:IConvertible {
        return new Quantity<double, Day>(
            Convert.ToDouble(val.Value) * ((1d/(1d/60)) * (1d/86400))
        );
    }
	/// <summary>
    /// Extension method to convert Minute to SiderealDay
    /// </summary>
    /// <param name="val">quantity measured in Minute</param>
    /// <returns>quantity measured in SiderealDay</returns>
    public static Quantity<double, SiderealDay> ToSiderealDay<T>(this Quantity<T, Minute> val) where T:IConvertible {
        return new Quantity<double, SiderealDay>(
            Convert.ToDouble(val.Value) * ((1d/(1d/60)) * (1d/86164.1))
        );
    }
	/// <summary>
    /// Extension method to convert Minute to Year
    /// </summary>
    /// <param name="val">quantity measured in Minute</param>
    /// <returns>quantity measured in Year</returns>
    public static Quantity<double, Year> ToYear<T>(this Quantity<T, Minute> val) where T:IConvertible {
        return new Quantity<double, Year>(
            Convert.ToDouble(val.Value) * ((1d/(1d/60)) * (1d/3.1709791983765E-8))
        );
    }
	/// <summary>
    /// Extension method to convert Minute to SiderealYear
    /// </summary>
    /// <param name="val">quantity measured in Minute</param>
    /// <returns>quantity measured in SiderealYear</returns>
    public static Quantity<double, SiderealYear> ToSiderealYear<T>(this Quantity<T, Minute> val) where T:IConvertible {
        return new Quantity<double, SiderealYear>(
            Convert.ToDouble(val.Value) * ((1d/(1d/60)) * (1d/31558149.504))
        );
    }
	/// <summary>
    /// Extension method to convert Second to Hour
    /// </summary>
    /// <param name="val">quantity measured in Second</param>
    /// <returns>quantity measured in Hour</returns>
    public static Quantity<double, Hour> ToHour<T>(this Quantity<T, Second> val) where T:IConvertible {
        return new Quantity<double, Hour>(
            Convert.ToDouble(val.Value) * (1d/3600)
        );
    }
	/// <summary>
    /// Extension method to convert Hour to Second
    /// </summary>
    /// <param name="val">quantity measured in Hour</param>
    /// <returns>quantity measured in Second</returns>
    public static Quantity<double, Second> ToSecond<T>(this Quantity<T, Hour> val) where T:IConvertible {
        return new Quantity<double, Second>(
            Convert.ToDouble(val.Value) * (1d/(1d/3600))
        );
    }
	/// <summary>
    /// Extension method to convert Hour to Minute
    /// </summary>
    /// <param name="val">quantity measured in Hour</param>
    /// <returns>quantity measured in Minute</returns>
    public static Quantity<double, Minute> ToMinute<T>(this Quantity<T, Hour> val) where T:IConvertible {
        return new Quantity<double, Minute>(
            Convert.ToDouble(val.Value) * ((1d/(1d/3600)) * (1d/60))
        );
    }
	/// <summary>
    /// Extension method to convert Hour to Day
    /// </summary>
    /// <param name="val">quantity measured in Hour</param>
    /// <returns>quantity measured in Day</returns>
    public static Quantity<double, Day> ToDay<T>(this Quantity<T, Hour> val) where T:IConvertible {
        return new Quantity<double, Day>(
            Convert.ToDouble(val.Value) * ((1d/(1d/3600)) * (1d/86400))
        );
    }
	/// <summary>
    /// Extension method to convert Hour to SiderealDay
    /// </summary>
    /// <param name="val">quantity measured in Hour</param>
    /// <returns>quantity measured in SiderealDay</returns>
    public static Quantity<double, SiderealDay> ToSiderealDay<T>(this Quantity<T, Hour> val) where T:IConvertible {
        return new Quantity<double, SiderealDay>(
            Convert.ToDouble(val.Value) * ((1d/(1d/3600)) * (1d/86164.1))
        );
    }
	/// <summary>
    /// Extension method to convert Hour to Year
    /// </summary>
    /// <param name="val">quantity measured in Hour</param>
    /// <returns>quantity measured in Year</returns>
    public static Quantity<double, Year> ToYear<T>(this Quantity<T, Hour> val) where T:IConvertible {
        return new Quantity<double, Year>(
            Convert.ToDouble(val.Value) * ((1d/(1d/3600)) * (1d/3.1709791983765E-8))
        );
    }
	/// <summary>
    /// Extension method to convert Hour to SiderealYear
    /// </summary>
    /// <param name="val">quantity measured in Hour</param>
    /// <returns>quantity measured in SiderealYear</returns>
    public static Quantity<double, SiderealYear> ToSiderealYear<T>(this Quantity<T, Hour> val) where T:IConvertible {
        return new Quantity<double, SiderealYear>(
            Convert.ToDouble(val.Value) * ((1d/(1d/3600)) * (1d/31558149.504))
        );
    }
	/// <summary>
    /// Extension method to convert Second to Day
    /// </summary>
    /// <param name="val">quantity measured in Second</param>
    /// <returns>quantity measured in Day</returns>
    public static Quantity<double, Day> ToDay<T>(this Quantity<T, Second> val) where T:IConvertible {
        return new Quantity<double, Day>(
            Convert.ToDouble(val.Value) * (1d/86400)
        );
    }
	/// <summary>
    /// Extension method to convert Day to Second
    /// </summary>
    /// <param name="val">quantity measured in Day</param>
    /// <returns>quantity measured in Second</returns>
    public static Quantity<double, Second> ToSecond<T>(this Quantity<T, Day> val) where T:IConvertible {
        return new Quantity<double, Second>(
            Convert.ToDouble(val.Value) * (1d/(1d/86400))
        );
    }
	/// <summary>
    /// Extension method to convert Day to Minute
    /// </summary>
    /// <param name="val">quantity measured in Day</param>
    /// <returns>quantity measured in Minute</returns>
    public static Quantity<double, Minute> ToMinute<T>(this Quantity<T, Day> val) where T:IConvertible {
        return new Quantity<double, Minute>(
            Convert.ToDouble(val.Value) * ((1d/(1d/86400)) * (1d/60))
        );
    }
	/// <summary>
    /// Extension method to convert Day to Hour
    /// </summary>
    /// <param name="val">quantity measured in Day</param>
    /// <returns>quantity measured in Hour</returns>
    public static Quantity<double, Hour> ToHour<T>(this Quantity<T, Day> val) where T:IConvertible {
        return new Quantity<double, Hour>(
            Convert.ToDouble(val.Value) * ((1d/(1d/86400)) * (1d/3600))
        );
    }
	/// <summary>
    /// Extension method to convert Day to SiderealDay
    /// </summary>
    /// <param name="val">quantity measured in Day</param>
    /// <returns>quantity measured in SiderealDay</returns>
    public static Quantity<double, SiderealDay> ToSiderealDay<T>(this Quantity<T, Day> val) where T:IConvertible {
        return new Quantity<double, SiderealDay>(
            Convert.ToDouble(val.Value) * ((1d/(1d/86400)) * (1d/86164.1))
        );
    }
	/// <summary>
    /// Extension method to convert Day to Year
    /// </summary>
    /// <param name="val">quantity measured in Day</param>
    /// <returns>quantity measured in Year</returns>
    public static Quantity<double, Year> ToYear<T>(this Quantity<T, Day> val) where T:IConvertible {
        return new Quantity<double, Year>(
            Convert.ToDouble(val.Value) * ((1d/(1d/86400)) * (1d/3.1709791983765E-8))
        );
    }
	/// <summary>
    /// Extension method to convert Day to SiderealYear
    /// </summary>
    /// <param name="val">quantity measured in Day</param>
    /// <returns>quantity measured in SiderealYear</returns>
    public static Quantity<double, SiderealYear> ToSiderealYear<T>(this Quantity<T, Day> val) where T:IConvertible {
        return new Quantity<double, SiderealYear>(
            Convert.ToDouble(val.Value) * ((1d/(1d/86400)) * (1d/31558149.504))
        );
    }
	/// <summary>
    /// Extension method to convert Second to SiderealDay
    /// </summary>
    /// <param name="val">quantity measured in Second</param>
    /// <returns>quantity measured in SiderealDay</returns>
    public static Quantity<double, SiderealDay> ToSiderealDay<T>(this Quantity<T, Second> val) where T:IConvertible {
        return new Quantity<double, SiderealDay>(
            Convert.ToDouble(val.Value) * (1d/86164.1)
        );
    }
	/// <summary>
    /// Extension method to convert SiderealDay to Second
    /// </summary>
    /// <param name="val">quantity measured in SiderealDay</param>
    /// <returns>quantity measured in Second</returns>
    public static Quantity<double, Second> ToSecond<T>(this Quantity<T, SiderealDay> val) where T:IConvertible {
        return new Quantity<double, Second>(
            Convert.ToDouble(val.Value) * (1d/(1d/86164.1))
        );
    }
	/// <summary>
    /// Extension method to convert SiderealDay to Minute
    /// </summary>
    /// <param name="val">quantity measured in SiderealDay</param>
    /// <returns>quantity measured in Minute</returns>
    public static Quantity<double, Minute> ToMinute<T>(this Quantity<T, SiderealDay> val) where T:IConvertible {
        return new Quantity<double, Minute>(
            Convert.ToDouble(val.Value) * ((1d/(1d/86164.1)) * (1d/60))
        );
    }
	/// <summary>
    /// Extension method to convert SiderealDay to Hour
    /// </summary>
    /// <param name="val">quantity measured in SiderealDay</param>
    /// <returns>quantity measured in Hour</returns>
    public static Quantity<double, Hour> ToHour<T>(this Quantity<T, SiderealDay> val) where T:IConvertible {
        return new Quantity<double, Hour>(
            Convert.ToDouble(val.Value) * ((1d/(1d/86164.1)) * (1d/3600))
        );
    }
	/// <summary>
    /// Extension method to convert SiderealDay to Day
    /// </summary>
    /// <param name="val">quantity measured in SiderealDay</param>
    /// <returns>quantity measured in Day</returns>
    public static Quantity<double, Day> ToDay<T>(this Quantity<T, SiderealDay> val) where T:IConvertible {
        return new Quantity<double, Day>(
            Convert.ToDouble(val.Value) * ((1d/(1d/86164.1)) * (1d/86400))
        );
    }
	/// <summary>
    /// Extension method to convert SiderealDay to Year
    /// </summary>
    /// <param name="val">quantity measured in SiderealDay</param>
    /// <returns>quantity measured in Year</returns>
    public static Quantity<double, Year> ToYear<T>(this Quantity<T, SiderealDay> val) where T:IConvertible {
        return new Quantity<double, Year>(
            Convert.ToDouble(val.Value) * ((1d/(1d/86164.1)) * (1d/3.1709791983765E-8))
        );
    }
	/// <summary>
    /// Extension method to convert SiderealDay to SiderealYear
    /// </summary>
    /// <param name="val">quantity measured in SiderealDay</param>
    /// <returns>quantity measured in SiderealYear</returns>
    public static Quantity<double, SiderealYear> ToSiderealYear<T>(this Quantity<T, SiderealDay> val) where T:IConvertible {
        return new Quantity<double, SiderealYear>(
            Convert.ToDouble(val.Value) * ((1d/(1d/86164.1)) * (1d/31558149.504))
        );
    }
	/// <summary>
    /// Extension method to convert Second to Year
    /// </summary>
    /// <param name="val">quantity measured in Second</param>
    /// <returns>quantity measured in Year</returns>
    public static Quantity<double, Year> ToYear<T>(this Quantity<T, Second> val) where T:IConvertible {
        return new Quantity<double, Year>(
            Convert.ToDouble(val.Value) * (1d/3.1709791983765E-8)
        );
    }
	/// <summary>
    /// Extension method to convert Year to Second
    /// </summary>
    /// <param name="val">quantity measured in Year</param>
    /// <returns>quantity measured in Second</returns>
    public static Quantity<double, Second> ToSecond<T>(this Quantity<T, Year> val) where T:IConvertible {
        return new Quantity<double, Second>(
            Convert.ToDouble(val.Value) * (1d/(1d/3.1709791983765E-8))
        );
    }
	/// <summary>
    /// Extension method to convert Year to Minute
    /// </summary>
    /// <param name="val">quantity measured in Year</param>
    /// <returns>quantity measured in Minute</returns>
    public static Quantity<double, Minute> ToMinute<T>(this Quantity<T, Year> val) where T:IConvertible {
        return new Quantity<double, Minute>(
            Convert.ToDouble(val.Value) * ((1d/(1d/3.1709791983765E-8)) * (1d/60))
        );
    }
	/// <summary>
    /// Extension method to convert Year to Hour
    /// </summary>
    /// <param name="val">quantity measured in Year</param>
    /// <returns>quantity measured in Hour</returns>
    public static Quantity<double, Hour> ToHour<T>(this Quantity<T, Year> val) where T:IConvertible {
        return new Quantity<double, Hour>(
            Convert.ToDouble(val.Value) * ((1d/(1d/3.1709791983765E-8)) * (1d/3600))
        );
    }
	/// <summary>
    /// Extension method to convert Year to Day
    /// </summary>
    /// <param name="val">quantity measured in Year</param>
    /// <returns>quantity measured in Day</returns>
    public static Quantity<double, Day> ToDay<T>(this Quantity<T, Year> val) where T:IConvertible {
        return new Quantity<double, Day>(
            Convert.ToDouble(val.Value) * ((1d/(1d/3.1709791983765E-8)) * (1d/86400))
        );
    }
	/// <summary>
    /// Extension method to convert Year to SiderealDay
    /// </summary>
    /// <param name="val">quantity measured in Year</param>
    /// <returns>quantity measured in SiderealDay</returns>
    public static Quantity<double, SiderealDay> ToSiderealDay<T>(this Quantity<T, Year> val) where T:IConvertible {
        return new Quantity<double, SiderealDay>(
            Convert.ToDouble(val.Value) * ((1d/(1d/3.1709791983765E-8)) * (1d/86164.1))
        );
    }
	/// <summary>
    /// Extension method to convert Year to SiderealYear
    /// </summary>
    /// <param name="val">quantity measured in Year</param>
    /// <returns>quantity measured in SiderealYear</returns>
    public static Quantity<double, SiderealYear> ToSiderealYear<T>(this Quantity<T, Year> val) where T:IConvertible {
        return new Quantity<double, SiderealYear>(
            Convert.ToDouble(val.Value) * ((1d/(1d/3.1709791983765E-8)) * (1d/31558149.504))
        );
    }
	/// <summary>
    /// Extension method to convert Second to SiderealYear
    /// </summary>
    /// <param name="val">quantity measured in Second</param>
    /// <returns>quantity measured in SiderealYear</returns>
    public static Quantity<double, SiderealYear> ToSiderealYear<T>(this Quantity<T, Second> val) where T:IConvertible {
        return new Quantity<double, SiderealYear>(
            Convert.ToDouble(val.Value) * (1d/31558149.504)
        );
    }
	/// <summary>
    /// Extension method to convert SiderealYear to Second
    /// </summary>
    /// <param name="val">quantity measured in SiderealYear</param>
    /// <returns>quantity measured in Second</returns>
    public static Quantity<double, Second> ToSecond<T>(this Quantity<T, SiderealYear> val) where T:IConvertible {
        return new Quantity<double, Second>(
            Convert.ToDouble(val.Value) * (1d/(1d/31558149.504))
        );
    }
	/// <summary>
    /// Extension method to convert SiderealYear to Minute
    /// </summary>
    /// <param name="val">quantity measured in SiderealYear</param>
    /// <returns>quantity measured in Minute</returns>
    public static Quantity<double, Minute> ToMinute<T>(this Quantity<T, SiderealYear> val) where T:IConvertible {
        return new Quantity<double, Minute>(
            Convert.ToDouble(val.Value) * ((1d/(1d/31558149.504)) * (1d/60))
        );
    }
	/// <summary>
    /// Extension method to convert SiderealYear to Hour
    /// </summary>
    /// <param name="val">quantity measured in SiderealYear</param>
    /// <returns>quantity measured in Hour</returns>
    public static Quantity<double, Hour> ToHour<T>(this Quantity<T, SiderealYear> val) where T:IConvertible {
        return new Quantity<double, Hour>(
            Convert.ToDouble(val.Value) * ((1d/(1d/31558149.504)) * (1d/3600))
        );
    }
	/// <summary>
    /// Extension method to convert SiderealYear to Day
    /// </summary>
    /// <param name="val">quantity measured in SiderealYear</param>
    /// <returns>quantity measured in Day</returns>
    public static Quantity<double, Day> ToDay<T>(this Quantity<T, SiderealYear> val) where T:IConvertible {
        return new Quantity<double, Day>(
            Convert.ToDouble(val.Value) * ((1d/(1d/31558149.504)) * (1d/86400))
        );
    }
	/// <summary>
    /// Extension method to convert SiderealYear to SiderealDay
    /// </summary>
    /// <param name="val">quantity measured in SiderealYear</param>
    /// <returns>quantity measured in SiderealDay</returns>
    public static Quantity<double, SiderealDay> ToSiderealDay<T>(this Quantity<T, SiderealYear> val) where T:IConvertible {
        return new Quantity<double, SiderealDay>(
            Convert.ToDouble(val.Value) * ((1d/(1d/31558149.504)) * (1d/86164.1))
        );
    }
	/// <summary>
    /// Extension method to convert SiderealYear to Year
    /// </summary>
    /// <param name="val">quantity measured in SiderealYear</param>
    /// <returns>quantity measured in Year</returns>
    public static Quantity<double, Year> ToYear<T>(this Quantity<T, SiderealYear> val) where T:IConvertible {
        return new Quantity<double, Year>(
            Convert.ToDouble(val.Value) * ((1d/(1d/31558149.504)) * (1d/3.1709791983765E-8))
        );
    }
}
}