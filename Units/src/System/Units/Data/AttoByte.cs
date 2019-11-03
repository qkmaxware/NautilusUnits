namespace System.Units.Data {
/// <summary>
/// Unit of measurement for AttoByte (aB)
/// </summary>
public struct AttoByte : IData {
    public static string Name => "AttoByte";
    public static string Symbol => "aB";
}

/// <summary>
/// Extension method factory for generating AttoByte (aB)
/// </summary>
public static class AttoByteFactory {
    /// <summary>
    /// Create a quantity measured in AttoBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, AttoByte> aB<T>(this T value) {
        return new Quantity<T, AttoByte> (value);
    }
}
}