namespace Qkmaxware.Units.Data {
/// <summary>
/// Unit of measurement for GibiByte (GiB)
/// </summary>
public struct GibiByte : IData {
    public static string Name => "GibiByte";
    public static string Symbol => "GiB";
}

/// <summary>
/// Extension method factory for generating GibiByte (GiB)
/// </summary>
public static class GibiByteFactory {
    /// <summary>
    /// Create a quantity measured in GibiBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, GibiByte> GiB<T>(this T value) {
        return new Quantity<T, GibiByte> (value);
    }
}
}