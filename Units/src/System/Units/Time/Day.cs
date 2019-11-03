namespace System.Units.Time {
/// <summary>
/// Unit of measurement for the Day (day)
/// </summary>
public struct Day : ITime {
    public static string Name => "Day";
    public static string Symbol => "day";
}

/// <summary>
	///Extension method factory for generating Day (day)
	/// </summary>
	public static class DayFactory {
    /// <summary>
    /// Create a quantity measured in Days
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, Day> day<T>(this T value) {
        return new Quantity<T, Day> (value);
    }
}
}