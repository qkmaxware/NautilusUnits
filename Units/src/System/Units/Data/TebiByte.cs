namespace System.Units.Data {
/// <summary>
/// Unit of measurement for TebiByte (TiB)
/// </summary>
public struct TebiByte : IData {
    public static string Name => "TebiByte";
    public static string Symbol => "TiB";
}

/// <summary>
/// Extension method factory for generating TebiByte (TiB)
/// </summary>
public static class TebiByteFactory {
    /// <summary>
    /// Create a quantity measured in TebiBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, TebiByte> TiB<T>(this T value) {
        return new Quantity<T, TebiByte> (value);
    }
}
}