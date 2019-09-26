namespace System.Units {

/// <summary>
/// Measured quantity represented by a value in the given units
/// </summary>
public struct Quantity<T, U> where U:IUnit {

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

    /// <summary>
    /// Create a new quantity with the given value
    /// </summary>
    /// <param name="value"></param>
    public Quantity(T value) {
        this.Value = value;
    }

    /// <summary>
    /// Cast a measured quantity back to an unmeasured value
    /// </summary>
    /// <param name="quantity">Measured quantity</param>
    public static implicit operator T(Quantity<T, U> quantity) {
        return quantity.Value;
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

}

}