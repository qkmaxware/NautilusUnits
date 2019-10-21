namespace System.Units.Time {
/// <summary>
/// Unit of measurement for the SiderealYear (syr)
/// </summary>
public struct SiderealYear : ITime {
    public static string Name => "SiderealYear";
    public static string Symbol => "syr";
}

public static class SiderealYearFactory {
    /// <summary>
    /// Create a quantity measured in SiderealYears
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, SiderealYear> syr<T>(this T value) {
        return new Quantity<T, SiderealYear> (value);
    }
}
}