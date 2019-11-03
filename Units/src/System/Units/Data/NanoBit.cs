namespace System.Units.Data {
/// <summary>
/// Unit of measurement for NanoBit (nbit)
/// </summary>
public struct NanoBit : IData {
    public static string Name => "NanoBit";
    public static string Symbol => "nbit";
}

/// <summary>
/// Extension method factory for generating NanoBit (nbit)
/// </summary>
public static class NanoBitFactory {
    /// <summary>
    /// Create a quantity measured in NanoBits
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, NanoBit> nbit<T>(this T value) {
        return new Quantity<T, NanoBit> (value);
    }
}
}