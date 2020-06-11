namespace Qkmaxware.Units.Length {
/// <summary>
/// Unit of measurement for the Mile (mi)
/// </summary>
public struct Mile : ILength {
    public static string Name => "Mile";
    public static string Symbol => "mi";
}

/// <summary>
	///Extension method factory for generating Mile (mi)
	/// </summary>
	public static class MileFactory {
    /// <summary>
    /// Create a quantity measured in Miles
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, Mile> mi<T>(this T value) {
        return new Quantity<T, Mile> (value);
    }
}
}