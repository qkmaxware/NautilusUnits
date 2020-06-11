namespace Qkmaxware.Units.Data {
/// <summary>
/// Unit of measurement for YoctoByte (yB)
/// </summary>
public struct YoctoByte : IData {
    public static string Name => "YoctoByte";
    public static string Symbol => "yB";
}

/// <summary>
/// Extension method factory for generating YoctoByte (yB)
/// </summary>
public static class YoctoByteFactory {
    /// <summary>
    /// Create a quantity measured in YoctoBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, YoctoByte> yB<T>(this T value) {
        return new Quantity<T, YoctoByte> (value);
    }
}
}