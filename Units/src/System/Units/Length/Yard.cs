namespace System.Units.Length {
/// <summary>
/// Unit of measurement for the Yard (yd)
/// </summary>
public struct Yard : ILength {
    public static string Name => "Yard";
    public static string Symbol => "yd";
}

/// <summary>
	///Extension method factory for generating Yard (yd)
	/// </summary>
	public static class YardFactory {
    /// <summary>
    /// Create a quantity measured in Yards
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, Yard> yd<T>(this T value) {
        return new Quantity<T, Yard> (value);
    }
}
}