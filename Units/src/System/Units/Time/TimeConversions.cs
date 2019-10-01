using System;

namespace System.Units.Time {

public static class TimeConversions {

    // --- s

    public static Quantity<double, Second> ToSeconds<T>(this Quantity<T, Minute> val) where T:IConvertible {
        return new Quantity<double, Second>(
            Convert.ToDouble(val.Value) * 60
        );
    }

    public static Quantity<double, Second> ToSeconds<T>(this Quantity<T, Hour> val) where T:IConvertible {
        return new Quantity<double, Second>(
            Convert.ToDouble(val.Value) * 3600 // 60 * 60
        );
    }

    public static Quantity<double, Second> ToSeconds<T>(this Quantity<T, Day> val) where T:IConvertible {
        return new Quantity<double, Second>(
            Convert.ToDouble(val.Value) * 86400 // 60 * 60 * 24
        );
    }

    public static Quantity<double, Second> ToSeconds<T>(this Quantity<T, Year> val) where T:IConvertible {
        return new Quantity<double, Second>(
            Convert.ToDouble(val.Value) * 31536000 // 60 * 60 * 24 * 365
        );
    }

    // --- min
    public static Quantity<double, Minute> ToMinutes<T>(this Quantity<T, Second> val) where T:IConvertible {
        return new Quantity<double, Minute>(
            Convert.ToDouble(val.Value) / 60
        );
    }

    public static Quantity<double, Minute> ToMinutes<T>(this Quantity<T, Hour> val) where T:IConvertible {
        return new Quantity<double, Minute>(
            Convert.ToDouble(val.Value) * 60
        );
    }

    public static Quantity<double, Minute> ToMinutes<T>(this Quantity<T, Day> val) where T:IConvertible {
        return new Quantity<double, Minute>(
            Convert.ToDouble(val.Value) * 1440 // 60 * 24
        );
    }

    public static Quantity<double, Minute> ToMinutes<T>(this Quantity<T, Year> val) where T:IConvertible {
        return new Quantity<double, Minute>(
            Convert.ToDouble(val.Value) * 525600 // 60 * 24 * 365
        );
    }

    // --- hours

    public static Quantity<double, Hour> ToHours<T>(this Quantity<T, Second> val) where T:IConvertible {
        return new Quantity<double, Hour>(
            Convert.ToDouble(val.Value) / 3600 // 60 * 60
        );
    }

    public static Quantity<double, Hour> ToHours<T>(this Quantity<T, Minute> val) where T:IConvertible {
        return new Quantity<double, Hour>(
            Convert.ToDouble(val.Value) / 60 // 60
        );
    }

    public static Quantity<double, Hour> ToHours<T>(this Quantity<T, Day> val) where T:IConvertible {
        return new Quantity<double, Hour>(
            Convert.ToDouble(val.Value) * 24 // 24
        );
    }

    public static Quantity<double, Hour> ToHours<T>(this Quantity<T, Year> val) where T:IConvertible {
        return new Quantity<double, Hour>(
            Convert.ToDouble(val.Value) * 8760 // 24 * 365
        );
    }

    // --- days

    public static Quantity<double, Day> ToDays<T>(this Quantity<T, Second> val) where T:IConvertible {
        return new Quantity<double, Day>(
            Convert.ToDouble(val.Value) / 86400 // 60 * 60 * 24
        );
    }

    public static Quantity<double, Day> ToDays<T>(this Quantity<T, Minute> val) where T:IConvertible {
        return new Quantity<double, Day>(
            Convert.ToDouble(val.Value) / 1440 // 60 * 24
        );
    }

    public static Quantity<double, Day> ToDays<T>(this Quantity<T, Hour> val) where T:IConvertible {
        return new Quantity<double, Day>(
            Convert.ToDouble(val.Value) / 24 // 24
        );
    }

    public static Quantity<double, Day> ToDays<T>(this Quantity<T, Year> val) where T:IConvertible {
        return new Quantity<double, Day>(
            Convert.ToDouble(val.Value) * 365 // 365
        );
    }

    // --- years

    public static Quantity<double, Year> ToYears<T>(this Quantity<T, Second> val) where T:IConvertible {
        return new Quantity<double, Year>(
            Convert.ToDouble(val.Value) / 31536000 // 60 * 60 * 24 * 365
        );
    }

    public static Quantity<double, Year> ToYears<T>(this Quantity<T, Minute> val) where T:IConvertible {
        return new Quantity<double, Year>(
            Convert.ToDouble(val.Value) / 525600 // 60 * 24 * 365
        );
    }

    public static Quantity<double, Year> ToYears<T>(this Quantity<T, Hour> val) where T:IConvertible {
        return new Quantity<double, Year>(
            Convert.ToDouble(val.Value) / 8760 // 24 * 365
        );
    }

    public static Quantity<double, Year> ToYears<T>(this Quantity<T, Day> val) where T:IConvertible {
        return new Quantity<double, Year>(
            Convert.ToDouble(val.Value) / 365 // 365
        );
    }

}

}