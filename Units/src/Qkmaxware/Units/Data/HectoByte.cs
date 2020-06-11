namespace Qkmaxware.Units.Data {
/// <summary>
/// Unit of measurement for HectoByte (hB)
/// </summary>
public struct HectoByte : IData {
    public static string Name => "HectoByte";
    public static string Symbol => "hB";
}

/// <summary>
/// Extension method factory for generating HectoByte (hB)
/// </summary>
public static class HectoByteFactory {
    /// <summary>
    /// Create a quantity measured in HectoBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, HectoByte> hB<T>(this T value) {
        return new Quantity<T, HectoByte> (value);
    }
}
}