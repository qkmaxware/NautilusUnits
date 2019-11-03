namespace System.Units.Data {
/// <summary>
/// Unit of measurement for NanoByte (nB)
/// </summary>
public struct NanoByte : IData {
    public static string Name => "NanoByte";
    public static string Symbol => "nB";
}

/// <summary>
/// Extension method factory for generating NanoByte (nB)
/// </summary>
public static class NanoByteFactory {
    /// <summary>
    /// Create a quantity measured in NanoBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, NanoByte> nB<T>(this T value) {
        return new Quantity<T, NanoByte> (value);
    }
}
}