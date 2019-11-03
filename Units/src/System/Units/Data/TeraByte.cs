namespace System.Units.Data {
/// <summary>
/// Unit of measurement for TeraByte (TB)
/// </summary>
public struct TeraByte : IData {
    public static string Name => "TeraByte";
    public static string Symbol => "TB";
}

/// <summary>
/// Extension method factory for generating TeraByte (TB)
/// </summary>
public static class TeraByteFactory {
    /// <summary>
    /// Create a quantity measured in TeraBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, TeraByte> TB<T>(this T value) {
        return new Quantity<T, TeraByte> (value);
    }
}
}