namespace Qkmaxware.Units.Time {
/// <summary>
/// Unit of measurement for the Year (yr)
/// </summary>
public struct Year : ITime {
    public static string Name => "Year";
    public static string Symbol => "yr";
}

/// <summary>
	///Extension method factory for generating Year (yr)
	/// </summary>
	public static class YearFactory {
    /// <summary>
    /// Create a quantity measured in Years
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, Year> yr<T>(this T value) {
        return new Quantity<T, Year> (value);
    }
}
}