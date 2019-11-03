namespace System.Units.Data {
/// <summary>
/// Unit of measurement for ZettaByte (ZB)
/// </summary>
public struct ZettaByte : IData {
    public static string Name => "ZettaByte";
    public static string Symbol => "ZB";
}

/// <summary>
/// Extension method factory for generating ZettaByte (ZB)
/// </summary>
public static class ZettaByteFactory {
    /// <summary>
    /// Create a quantity measured in ZettaBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, ZettaByte> ZB<T>(this T value) {
        return new Quantity<T, ZettaByte> (value);
    }
}
}