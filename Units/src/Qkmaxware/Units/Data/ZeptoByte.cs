namespace Qkmaxware.Units.Data {
/// <summary>
/// Unit of measurement for ZeptoByte (zB)
/// </summary>
public struct ZeptoByte : IData {
    public static string Name => "ZeptoByte";
    public static string Symbol => "zB";
}

/// <summary>
/// Extension method factory for generating ZeptoByte (zB)
/// </summary>
public static class ZeptoByteFactory {
    /// <summary>
    /// Create a quantity measured in ZeptoBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, ZeptoByte> zB<T>(this T value) {
        return new Quantity<T, ZeptoByte> (value);
    }
}
}