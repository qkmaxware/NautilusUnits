namespace System.Units {

/// <summary>
/// Extension methods for quantity arithmetic
/// </summary>
public static class QuantityArithmetic {
    
    /// <summary>
    /// Negate a quantity
    /// </summary>
    /// <param name="quantity1">quantity to negate</param>
    /// <typeparam name="U">units of measure</typeparam>
    /// <returns>quantity with its value negated</returns>
    public static Quantity<double, U> Negate<T, U>(this Quantity<T, U> quantity1) where U:IUnit where T:IConvertible {
        return new Quantity<double, U>(-Convert.ToDouble(quantity1.Value));
    }

    /// <summary>
    /// Negate a quantity
    /// </summary>
    /// <param name="quantity1">quantity to negate</param>
    /// <typeparam name="U">units of measure</typeparam>
    /// <returns>quantity with its value negated</returns>
    public static Quantity<R, U> Negate<R, T, U>(this Quantity<T, U> quantity1) where U:IUnit where T:INegateable<R> {
        return new Quantity<R, U>(quantity1.Value.Negate());
    }

    /// <summary>
    /// Add two quantities as doubles
    /// </summary>
    /// <param name="quantity1">first quantity</param>
    /// <param name="quantity2">second quantity</param>
    /// <typeparam name="U">units of measure</typeparam>
    /// <returns>sum of two quantities with the same units of measure.</returns>
    public static Quantity<double, U> Add<T, U>(this Quantity<T, U> quantity1, Quantity<T, U> quantity2) where U:IUnit where T:IConvertible {
        return new Quantity<double, U>(Convert.ToDouble(quantity1.Value) + Convert.ToDouble(quantity2.Value));
    }

    /// <summary>
    /// Add two quantities as the specified type
    /// </summary>
    /// <param name="quantity1">first quantity</param>
    /// <param name="quantity2">second quantity</param>
    /// <typeparam name="T">input type</typeparam>
    /// <typeparam name="R">return type</typeparam>
    /// <typeparam name="U">units of measure</typeparam>
    /// <returns>sum of two quantities with the same units of measure.</returns>
    public static Quantity<R, U> Add <R,T,U> (this Quantity<T,U> quantity1, Quantity<T,U> quantity2) where U:IUnit where T:IAddable<R,T> {
        return new Quantity<R, U>(quantity1.Value.Add(quantity2.Value));
    }

    /// <summary>
    /// Subtract two quantities as doubles
    /// </summary>
    /// <param name="quantity1">first quantity</param>
    /// <param name="quantity2">second quantity</param>
    /// <typeparam name="U">units of measure</typeparam>
    /// <returns>difference of two quantities with the same units of measure.</returns>
    public static Quantity<double, U> Sub<T, U>(this Quantity<T, U> quantity1, Quantity<T, U> quantity2) where U:IUnit where T:IConvertible {
        return new Quantity<double, U>(Convert.ToDouble(quantity1.Value) - Convert.ToDouble(quantity2.Value));
    }

    /// <summary>
    /// Subtract two quantities as the specified type
    /// </summary>
    /// <param name="quantity1">first quantity</param>
    /// <param name="quantity2">second quantity</param>
    /// <typeparam name="T">input type</typeparam>
    /// <typeparam name="R">return type</typeparam>
    /// <typeparam name="U">units of measure</typeparam>
    /// <returns>sum of two quantities with the same units of measure.</returns>
    public static Quantity<R, U> Sub <R,T,U> (this Quantity<T,U> quantity1, Quantity<T,U> quantity2) where U:IUnit where T:ISubtractable<R,T> {
        return new Quantity<R, U>(quantity1.Value.Sub(quantity2.Value));
    }

    /// <summary>
    /// Multiply two quantities as doubles
    /// </summary>
    /// <param name="quantity1">first quantity</param>
    /// <param name="quantity2">second quantity</param>
    /// <typeparam name="U">units of measure</typeparam>
    /// <returns>product of two quantity values with the same units of measure.</returns>
    public static Quantity<double, U> MulValues<T, U>(this Quantity<T, U> quantity1, Quantity<T, U> quantity2) where U:IUnit where T:IConvertible {
        return new Quantity<double, U>(Convert.ToDouble(quantity1.Value) * Convert.ToDouble(quantity2.Value));
    }

    /// <summary>
    /// Multiply two quantities as the specified type
    /// </summary>
    /// <param name="quantity1">first quantity</param>
    /// <param name="quantity2">second quantity</param>
    /// <typeparam name="T">input type</typeparam>
    /// <typeparam name="R">return type</typeparam>
    /// <typeparam name="U">units of measure</typeparam>
    /// <returns>product of two quantity values with the same units of measure.</returns>
    public static Quantity<R, U> MulValues <R,T,U> (this Quantity<T,U> quantity1, Quantity<T,U> quantity2) where U:IUnit where T:IMultipliable<R,T> {
        return new Quantity<R, U>(quantity1.Value.Mul(quantity2.Value));
    }

    /// <summary>
    /// Divide two quantities as doubles
    /// </summary>
    /// <param name="quantity1">first quantity</param>
    /// <param name="quantity2">second quantity</param>
    /// <typeparam name="U">units of measure</typeparam>
    /// <returns>division of two quantity values with the same units of measure.</returns>
    public static Quantity<double, U> DivValues<T, U>(this Quantity<T, U> quantity1, Quantity<T, U> quantity2) where U:IUnit where T:IConvertible {
        return new Quantity<double, U>  (Convert.ToDouble(quantity1.Value) / Convert.ToDouble(quantity2.Value));
    }

    /// <summary>
    /// Divide two quantities as the specified type
    /// </summary>
    /// <param name="quantity1">first quantity</param>
    /// <param name="quantity2">second quantity</param>
    /// <typeparam name="T">input type</typeparam>
    /// <typeparam name="R">return type</typeparam>
    /// <typeparam name="U">units of measure</typeparam>
    /// <returns>division of two quantity values with the same units of measure.</returns>
    public static Quantity<R, U> DivValues <R,T,U> (this Quantity<T,U> quantity1, Quantity<T,U> quantity2) where U:IUnit where T:IDivisible<R,T> {
        return new Quantity<R, U>(quantity1.Value.Div(quantity2.Value));
    }

    /// <summary>
    /// Divide two quantities as doubles
    /// </summary>
    /// <param name="quantity1">first quantity</param>
    /// <param name="quantity2">second quantity</param>
    /// <typeparam name="U">units of measure</typeparam>
    /// <returns>division of two quantities. Units will cancel.</returns>
    public static double Div<T, U>(this Quantity<T, U> quantity1, Quantity<T, U> quantity2) where U:IUnit where T:IConvertible {
        return Convert.ToDouble(quantity1.Value) / Convert.ToDouble(quantity2.Value);
    }

    /// <summary>
    /// Divide two quantities as the specified type
    /// </summary>
    /// <param name="quantity1">first quantity</param>
    /// <param name="quantity2">second quantity</param>
    /// <typeparam name="T">input type</typeparam>
    /// <typeparam name="R">return type</typeparam>
    /// <typeparam name="U">units of measure</typeparam>
    /// <returns>division of two quantities. Units will cancel.</returns>
    public static R Div <R,T,U> (this Quantity<T,U> quantity1, Quantity<T,U> quantity2) where U:IUnit where T:IDivisible<R,T> {
        return quantity1.Value.Div(quantity2.Value);
    }

    /// <summary>
    /// Map the value in a quantity to another value
    /// </summary>
    /// <param name="quantity1">first quantity</param>
    /// <param name="fn">mapping function</param>
    /// <typeparam name="U">units of measure</typeparam>
    /// <typeparam name="T1">original stored type</typeparam>
    /// <typeparam name="T2">new stored type</typeparam>
    /// <returns>quantities with the same units of measure but the value is a different type.</returns>
    public static Quantity<T2, U> Map<T1, T2, U>(this Quantity<T1, U> quantity1, Func<T1, T2> fn) where U:IUnit {
        return new Quantity<T2, U>(fn.Invoke(quantity1.Value));
    }

}

}