namespace Qkmaxware.Units.Data {
/// <summary>
/// Unit of measurement for KibiByte (kiB)
/// </summary>
public struct KibiByte : IData {
    public static string Name => "KibiByte";
    public static string Symbol => "kiB";
}

/// <summary>
/// Extension method factory for generating KibiByte (kiB)
/// </summary>
public static class KibiByteFactory {
    /// <summary>
    /// Create a quantity measured in KibiBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, KibiByte> kiB<T>(this T value) {
        return new Quantity<T, KibiByte> (value);
    }
}
}