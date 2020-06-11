namespace Qkmaxware.Units.Data {
/// <summary>
/// Unit of measurement for YobiByte (YiB)
/// </summary>
public struct YobiByte : IData {
    public static string Name => "YobiByte";
    public static string Symbol => "YiB";
}

/// <summary>
/// Extension method factory for generating YobiByte (YiB)
/// </summary>
public static class YobiByteFactory {
    /// <summary>
    /// Create a quantity measured in YobiBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, YobiByte> YiB<T>(this T value) {
        return new Quantity<T, YobiByte> (value);
    }
}
}