namespace System.Units {

/// <summary>
/// Extension methods for quantity arithmetic
/// </summary>
public static class QuantityArithmetic {
    
    /// <summary>
    /// Add two quantities as doubles
    /// </summary>
    /// <param name="quantity1">first quantity</param>
    /// <param name="quantity2">second quantity</param>
    /// <typeparam name="U">units of measure</typeparam>
    /// <returns>sum of two quantities with the same units of measure</returns>
    public static Quantity<double, U> Add<T, U>(this Quantity<T, U> quantity1, Quantity<T, U> quantity2) where U:IUnit where T:IConvertible {
        return new Quantity<double, U>(Convert.ToDouble(quantity1.Value) + Convert.ToDouble(quantity2.Value));
    }

    /// <summary>
    /// Subtract two quantities as doubles
    /// </summary>
    /// <param name="quantity1">first quantity</param>
    /// <param name="quantity2">second quantity</param>
    /// <typeparam name="U">units of measure</typeparam>
    /// <returns>difference of two quantities with the same units of measure</returns>
    public static Quantity<double, U> Sub<T, U>(this Quantity<T, U> quantity1, Quantity<T, U> quantity2) where U:IUnit where T:IConvertible {
        return new Quantity<double, U>(Convert.ToDouble(quantity1.Value) - Convert.ToDouble(quantity2.Value));
    }

    /// <summary>
    /// Multiply two quantities as doubles
    /// </summary>
    /// <param name="quantity1">first quantity</param>
    /// <param name="quantity2">second quantity</param>
    /// <typeparam name="U">units of measure</typeparam>
    /// <returns>product of two quantities with the same units of measure</returns>
    public static Quantity<double, U> Mul<T, U>(this Quantity<T, U> quantity1, Quantity<T, U> quantity2) where U:IUnit where T:IConvertible {
        return new Quantity<double, U>(Convert.ToDouble(quantity1.Value) * Convert.ToDouble(quantity2.Value));
    }

    /// <summary>
    /// Divide two quantities as doubles
    /// </summary>
    /// <param name="quantity1">first quantity</param>
    /// <param name="quantity2">second quantity</param>
    /// <typeparam name="U">units of measure</typeparam>
    /// <returns>division of two quantities with the same units of measure</returns>
    public static Quantity<double, U> Div<T, U>(this Quantity<T, U> quantity1, Quantity<T, U> quantity2) where U:IUnit where T:IConvertible {
        return new Quantity<double, U>(Convert.ToDouble(quantity1.Value) / Convert.ToDouble(quantity2.Value));
    }

    /// <summary>
    /// Map the value in a quantity to another value
    /// </summary>
    /// <param name="quantity1">first quantity</param>
    /// <param name="fn">mapping function</param>
    /// <typeparam name="U">units of measure</typeparam>
    /// <typeparam name="T1">original stored type</typeparam>
    /// <typeparam name="T2">new stored type</typeparam>
    /// <returns>quantities with the same units of measure but the value is a different type</returns>
    public static Quantity<T2, U> Map<T1, T2, U>(this Quantity<T1, U> quantity1, Func<T1, T2> fn) where U:IUnit {
        return new Quantity<T2, U>(fn.Invoke(quantity1.Value));
    }

}

}