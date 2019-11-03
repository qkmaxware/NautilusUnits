namespace System.Units.Data {
/// <summary>
/// Unit of measurement for DekaByte (daB)
/// </summary>
public struct DekaByte : IData {
    public static string Name => "DekaByte";
    public static string Symbol => "daB";
}

/// <summary>
/// Extension method factory for generating DekaByte (daB)
/// </summary>
public static class DekaByteFactory {
    /// <summary>
    /// Create a quantity measured in DekaBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, DekaByte> daB<T>(this T value) {
        return new Quantity<T, DekaByte> (value);
    }
}
}