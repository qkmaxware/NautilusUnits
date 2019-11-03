namespace System.Units.Data {
/// <summary>
/// Unit of measurement for YottaByte (YB)
/// </summary>
public struct YottaByte : IData {
    public static string Name => "YottaByte";
    public static string Symbol => "YB";
}

/// <summary>
/// Extension method factory for generating YottaByte (YB)
/// </summary>
public static class YottaByteFactory {
    /// <summary>
    /// Create a quantity measured in YottaBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, YottaByte> YB<T>(this T value) {
        return new Quantity<T, YottaByte> (value);
    }
}
}