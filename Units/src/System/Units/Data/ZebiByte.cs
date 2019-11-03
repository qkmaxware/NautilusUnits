namespace System.Units.Data {
/// <summary>
/// Unit of measurement for ZebiByte (ZiB)
/// </summary>
public struct ZebiByte : IData {
    public static string Name => "ZebiByte";
    public static string Symbol => "ZiB";
}

/// <summary>
/// Extension method factory for generating ZebiByte (ZiB)
/// </summary>
public static class ZebiByteFactory {
    /// <summary>
    /// Create a quantity measured in ZebiBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, ZebiByte> ZiB<T>(this T value) {
        return new Quantity<T, ZebiByte> (value);
    }
}
}