namespace System.Units.Time {
/// <summary>
/// Unit of measurement for the Second (s)
/// </summary>
public struct Second : ITime {
    public static string Name => "Second";
    public static string Symbol => "s";
}

/// <summary>
	///Extension method factory for generating Second (s)
	/// </summary>
	public static class SecondFactory {
    /// <summary>
    /// Create a quantity measured in Seconds
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, Second> s<T>(this T value) {
        return new Quantity<T, Second> (value);
    }
}
}