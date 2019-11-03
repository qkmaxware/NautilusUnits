namespace System.Units.Data {
/// <summary>
/// Unit of measurement for DeciByte (dB)
/// </summary>
public struct DeciByte : IData {
    public static string Name => "DeciByte";
    public static string Symbol => "dB";
}

/// <summary>
/// Extension method factory for generating DeciByte (dB)
/// </summary>
public static class DeciByteFactory {
    /// <summary>
    /// Create a quantity measured in DeciBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, DeciByte> dB<T>(this T value) {
        return new Quantity<T, DeciByte> (value);
    }
}
}