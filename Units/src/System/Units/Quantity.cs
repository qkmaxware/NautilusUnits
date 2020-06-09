namespace System.Units {

/// <summary>
/// Abstract baseclass with shared functionality between quantity types
/// </summary>
public abstract class BaseQuantity<T, U> where U:IUnit {
    /// <summary>
    /// The units this quantity is measured in
    /// </summary>
    /// <value>Units of measure for this quantity</value>
    public Type Units => typeof(U);

    /// <summary>
    /// The measured value of this quantity
    /// </summary>
    /// <value>Measured value</value>
    public T Value {get; private set;}

    public BaseQuantity(T value) {
        this.Value = value;
    }

    /// <summary>
    /// Print this quantity as a string with the value and units
    /// </summary>
    /// <returns>string representing the value and units</returns>
    public override string ToString() {
        return 
            (this.Value?.ToString() ?? string.Empty) + 
            (this.Units?.GetProperty("Symbol")?.GetValue(null) ?? string.Empty); // This is dumb, ask how to do it properly
    }

    /// <summary>
    /// Cast a measured quantity back to an unmeasured value
    /// </summary>
    /// <param name="quantity">Measured quantity</param>
    public static explicit operator T(BaseQuantity<T, U> quantity) {
        return quantity.Value;
    }
}

/// <summary>
/// Simple quantity of type double measured in the given units
/// </summary>
public class Quantity<U>: BaseQuantity<double, U> where U:IUnit {

    public Quantity() : base(0) {}
    public Quantity(double value) : base(value) {}


    /// <summary>
    /// Quantity unitary addition
    /// </summary>
    public static Quantity<U> operator + (Quantity<U> rhs) {
        return new Quantity<U>(rhs.Value);
    }

    /// <summary>
    /// Quantity unitary negation
    /// </summary>
    public static Quantity<U> operator - (Quantity<U> rhs) {
        return new Quantity<U>(-rhs.Value);
    }

    /// <summary>
    /// Scalar multiplication
    /// </summary>
    public static Quantity<U> operator * (double lhs, Quantity<U> rhs) {
        return new Quantity<U>(lhs * rhs.Value);
    }

    /// <summary>
    /// Scalar multiplication
    /// </summary>
    public static Quantity<U> operator * (Quantity<U> lhs, double rhs) {
        return new Quantity<U>(lhs.Value * rhs);
    }

    /// <summary>
    /// Scalar division
    /// </summary>
    public static Quantity<U> operator / (Quantity<U> lhs, double rhs) {
        return new Quantity<U>(lhs.Value / rhs);
    }

    /// <summary>
    /// Quantity addition
    /// </summary>
    public static Quantity<U> operator + (Quantity<U> lhs, Quantity<U> rhs) {
        return new Quantity<U>(lhs.Value + rhs.Value);
    }

    /// <summary>
    /// Quantity subtraction
    /// </summary>
    public static Quantity<U> operator - (Quantity<U> lhs, Quantity<U> rhs) {
        return new Quantity<U>(lhs.Value - rhs.Value);
    }

    /// <summary>
    /// Quantity division. Cancels units
    /// </summary>
    public static double operator / (Quantity<U> lhs, Quantity<U> rhs) {
        return lhs.Value / rhs.Value; // Division cancels out units
    }

    /// <summary>
    /// Conversion from generic quantity
    /// </summary>
    public static implicit operator Quantity<U> (Quantity<double, U> quanta) {
        return new Quantity<U>(quanta.Value);
    }
    /// <summary>
    /// Conversion from generic quantity
    /// </summary>
    public static implicit operator Quantity<U> (Quantity<float, U> quanta) {
        return new Quantity<U>(quanta.Value);
    }
    /// <summary>
    /// Conversion from generic quantity
    /// </summary>
    public static implicit operator Quantity<U> (Quantity<long, U> quanta) {
        return new Quantity<U>(quanta.Value);
    }
    /// <summary>
    /// Conversion from generic quantity
    /// </summary>
    public static implicit operator Quantity<U> (Quantity<int, U> quanta) {
        return new Quantity<U>(quanta.Value);
    }

    /// <summary>
    /// Conversion to generic quantity
    /// </summary>
    public static implicit operator Quantity<double,U> (Quantity<U> quanta) {
        return new Quantity<double, U>(quanta.Value);
    }
}

/// <summary>
/// Measured quantity of any type represented by a value in the given units
/// </summary>
public class Quantity<T, U> : BaseQuantity<T, U> where U:IUnit {

    /// <summary>
    /// Create a new quantity with the given value
    /// </summary>
    /// <param name="value"></param>
    public Quantity(T value) : base(value) {}
    
}

}