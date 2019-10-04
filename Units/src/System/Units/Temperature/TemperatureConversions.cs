using System;

namespace System.Units.Temperature {

public static class TemperatureConversions {

    /// <summary>
    /// Convert celsius to kelvin
    /// </summary>
    /// <param name="val">temperature in celsius</param>
    /// <returns>temperature in kelvin</returns>
    public static Quantity<double, Kelvin> ToKelvins<T>(this Quantity<T, Celsius> val) where T:IConvertible {
        return new Quantity<double, Kelvin>(
            Convert.ToDouble(val.Value) + 273.15
        );
    }

    /// <summary>
    /// Convert fahrenheit to kelvin
    /// </summary>
    /// <param name="val">temperature in fahrenheit</param>
    /// <returns>temperature in kelvin</returns>
    public static Quantity<double, Kelvin> ToKelvins<T>(this Quantity<T, Fahrenheit> val) where T:IConvertible {
        return new Quantity<double, Kelvin>(
            (Convert.ToDouble(val.Value) - 32) * (5d/9d) + 273.15
        );
    }

    /// <summary>
    /// Convert rankine to kelvin
    /// </summary>
    /// <param name="val">temperature in rankine</param>
    /// <returns>temperature in kelvin</returns>
    public static Quantity<double, Kelvin> ToKelvins<T>(this Quantity<T, Rankine> val) where T:IConvertible {
        return new Quantity<double, Kelvin>(
            Convert.ToDouble(val.Value) * (5d/9d)
        );
    }

    /// <summary>
    /// Convert kelvin to celsius
    /// </summary>
    /// <param name="val">temperature in kelvin</param>
    /// <returns>temperature in celsius</returns>
    public static Quantity<double, Celsius> ToCelsius<T>(this Quantity<T, Kelvin> val) where T:IConvertible {
        return new Quantity<double, Celsius>(
            Convert.ToDouble(val.Value) - 273.15
        );
    }

    /// <summary>
    /// Convert fahrenheit to celsius
    /// </summary>
    /// <param name="val">temperature in kelvin</param>
    /// <returns>temperature in celsius</returns>
    public static Quantity<double, Celsius> ToCelsius<T>(this Quantity<T, Fahrenheit> val) where T:IConvertible {
        return new Quantity<double, Celsius>(
            (Convert.ToDouble(val.Value) - 32) * (5d/9d)
        );
    }

    /// <summary>
    /// Convert rankine to celsius
    /// </summary>
    /// <param name="val">temperature in rankine</param>
    /// <returns>temperature in celsius</returns>
    public static Quantity<double, Celsius> ToCelsius<T>(this Quantity<T, Rankine> val) where T:IConvertible {
        return new Quantity<double, Celsius>(
            (Convert.ToDouble(val.Value) - 491.67) * (5d/9d)
        );
    }

    /// <summary>
    /// Convert kelvin to fahrenheit
    /// </summary>
    /// <param name="val">temperature in kelvin</param>
    /// <returns>temperature in fahrenheit</returns>
    public static Quantity<double, Fahrenheit> ToFahrenheit<T>(this Quantity<T, Kelvin> val) where T:IConvertible {
        return new Quantity<double, Fahrenheit>(
            (Convert.ToDouble(val.Value) - 273.15) * (9d/5d) + 32
        );
    }

    /// <summary>
    /// Convert rankine to fahrenheit
    /// </summary>
    /// <param name="val">temperature in rankine</param>
    /// <returns>temperature in fahrenheit</returns>
    public static Quantity<double, Fahrenheit> ToFahrenheit<T>(this Quantity<T, Rankine> val) where T:IConvertible {
        return new Quantity<double, Fahrenheit>(
            (Convert.ToDouble(val.Value) -459.67)
        );
    }

    /// <summary>
    /// Convert celsius to fahrenheit
    /// </summary>
    /// <param name="val">temperature in celsius</param>
    /// <returns>temperature in fahrenheit</returns>
    public static Quantity<double, Fahrenheit> ToFahrenheit<T>(this Quantity<T, Celsius> val) where T:IConvertible {
        return new Quantity<double, Fahrenheit>(
            (Convert.ToDouble(val.Value) * (9d/5d)) + 32
        );
    }

    /// <summary>
    /// Convert kelvin to rankine
    /// </summary>
    /// <param name="val">temperature in kelvin</param>
    /// <returns>temperature in rankine</returns>
    public static Quantity<double, Rankine> ToRankine<T>(this Quantity<T, Kelvin> val) where T:IConvertible {
        return new Quantity<double, Rankine>(
            (Convert.ToDouble(val.Value) * (9d/5d))
        );
    }

    /// <summary>
    /// Convert celsius to rankine
    /// </summary>
    /// <param name="val">temperature in celsius</param>
    /// <returns>temperature in rankine</returns>
    public static Quantity<double, Rankine> ToRankine<T>(this Quantity<T, Celsius> val) where T:IConvertible {
        return new Quantity<double, Rankine>(
            (Convert.ToDouble(val.Value) * (9d/5d)) + 491.67
        );
    }

    /// <summary>
    /// Convert fahrenheit to rankine
    /// </summary>
    /// <param name="val">temperature in fahrenheit</param>
    /// <returns>temperature in rankine</returns>
    public static Quantity<double, Rankine> ToRankine<T>(this Quantity<T, Fahrenheit> val) where T:IConvertible {
        return new Quantity<double, Rankine>(
            (Convert.ToDouble(val.Value)) + 459.67
        );
    }

}

}