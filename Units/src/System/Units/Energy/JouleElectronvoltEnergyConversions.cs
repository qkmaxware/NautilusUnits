using System;

namespace System.Units.Energy {
public static class JouleElectronvoltEnergyConversions {
    /// <summary>
    /// Extension method to convert Joule to Electronvolt
    /// </summary>
    /// <param name="val">quantity measured in Joule</param>
    /// <returns>quantity measured in Electronvolt</returns>
    public static Quantity<double, Electronvolt> ToElectronvolt<T>(this Quantity<T, Joule> val) where T:IConvertible {
        return new Quantity<double, Electronvolt>(
            Convert.ToDouble(val.Value) *  6.242E+18
        );
    }

    /// <summary>
    /// Extension method to convert Electronvolt to Joule
    /// </summary>
    /// <param name="val">quantity measured in Electronvolt</param>
    /// <returns>quantity measured in Joule</returns>
    public static Quantity<double, Joule> ToJoule<T>(this Quantity<T, Electronvolt> val) where T:IConvertible {
        return new Quantity<double, Joule>(
            Convert.ToDouble(val.Value) *  6.242E-18
        );
    }

}

}