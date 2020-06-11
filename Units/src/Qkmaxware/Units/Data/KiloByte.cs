namespace Qkmaxware.Units.Data {
/// <summary>
/// Unit of measurement for KiloByte (kB)
/// </summary>
public struct KiloByte : IData {
    public static string Name => "KiloByte";
    public static string Symbol => "kB";
}

/// <summary>
/// Extension method factory for generating KiloByte (kB)
/// </summary>
public static class KiloByteFactory {
    /// <summary>
    /// Create a quantity measured in KiloBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, KiloByte> kB<T>(this T value) {
        return new Quantity<T, KiloByte> (value);
    }
}
}