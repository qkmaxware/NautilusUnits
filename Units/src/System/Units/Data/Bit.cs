namespace System.Units.Data {
/// <summary>
/// Unit of measurement for Bit (bit)
/// </summary>
public struct Bit : IData {
    public static string Name => "Bit";
    public static string Symbol => "bit";
}

/// <summary>
/// Extension method factory for generating Bit (bit)
/// </summary>
public static class BitFactory {
    /// <summary>
    /// Create a quantity measured in Bits
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, Bit> bit<T>(this T value) {
        return new Quantity<T, Bit> (value);
    }
}
}