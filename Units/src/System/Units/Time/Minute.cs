namespace System.Units.Time {
/// <summary>
/// Unit of measurement for the Minute (min)
/// </summary>
public struct Minute : ITime {
    public static string Name => "Minute";
    public static string Symbol => "min";
}

public static class MinuteFactory {
    /// <summary>
    /// Create a quantity measured in Minutes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, Minute> min<T>(this T value) {
        return new Quantity<T, Minute> (value);
    }
}
}