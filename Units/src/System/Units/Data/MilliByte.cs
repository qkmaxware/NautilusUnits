namespace System.Units.Data {
/// <summary>
/// Unit of measurement for MilliByte (mB)
/// </summary>
public struct MilliByte : IData {
    public static string Name => "MilliByte";
    public static string Symbol => "mB";
}

/// <summary>
/// Extension method factory for generating MilliByte (mB)
/// </summary>
public static class MilliByteFactory {
    /// <summary>
    /// Create a quantity measured in MilliBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, MilliByte> mB<T>(this T value) {
        return new Quantity<T, MilliByte> (value);
    }
}
}