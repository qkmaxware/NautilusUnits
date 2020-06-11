namespace Qkmaxware.Units.Data {
/// <summary>
/// Unit of measurement for GigaByte (GB)
/// </summary>
public struct GigaByte : IData {
    public static string Name => "GigaByte";
    public static string Symbol => "GB";
}

/// <summary>
/// Extension method factory for generating GigaByte (GB)
/// </summary>
public static class GigaByteFactory {
    /// <summary>
    /// Create a quantity measured in GigaBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, GigaByte> GB<T>(this T value) {
        return new Quantity<T, GigaByte> (value);
    }
}
}