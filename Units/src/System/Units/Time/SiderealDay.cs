namespace System.Units.Time {
/// <summary>
/// Unit of measurement for the SiderealDay (sday)
/// </summary>
public struct SiderealDay : ITime {
    public static string Name => "SiderealDay";
    public static string Symbol => "sday";
}

/// <summary>
	///Extension method factory for generating SiderealDay (sday)
	/// </summary>
	public static class SiderealDayFactory {
    /// <summary>
    /// Create a quantity measured in SiderealDays
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, SiderealDay> sday<T>(this T value) {
        return new Quantity<T, SiderealDay> (value);
    }
}
}