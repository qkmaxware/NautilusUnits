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
    public static implicit operator T(BaseQuantity<T, U> quantity) {
        return quantity.Value;
    }
}

/// <summary>
/// Simple quantity of type double measured in the given units
/// </summary>
public class Quantity<U>: BaseQuantity<double, U> where U:IUnit {

    public Quantity() : base(0) {}
    public Quantity(double value) : base(value) {}

    public static implicit operator Quantity<U> (Quantity<double, U> quanta) {
        return new Quantity<U>(quanta.Value);
    }
    public static implicit operator Quantity<U> (Quantity<float, U> quanta) {
        return new Quantity<U>(quanta.Value);
    }

    public static implicit operator Quantity<U> (Quantity<long, U> quanta) {
        return new Quantity<U>(quanta.Value);
    }
    public static implicit operator Quantity<U> (Quantity<int, U> quanta) {
        return new Quantity<U>(quanta.Value);
    }

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