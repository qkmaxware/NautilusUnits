namespace Qkmaxware.Units.Data {
/// <summary>
/// Unit of measurement for Byte (B)
/// </summary>
public struct Byte : IData {
    public static string Name => "Byte";
    public static string Symbol => "B";
}

/// <summary>
/// Extension method factory for generating Byte (B)
/// </summary>
public static class ByteFactory {
    /// <summary>
    /// Create a quantity measured in Bytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, Byte> B<T>(this T value) {
        return new Quantity<T, Byte> (value);
    }
}
}