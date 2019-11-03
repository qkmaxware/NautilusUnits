namespace System.Units.Data {
/// <summary>
/// Unit of measurement for KiloBit (kbit)
/// </summary>
public struct KiloBit : IData {
    public static string Name => "KiloBit";
    public static string Symbol => "kbit";
}

/// <summary>
/// Extension method factory for generating KiloBit (kbit)
/// </summary>
public static class KiloBitFactory {
    /// <summary>
    /// Create a quantity measured in KiloBits
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, KiloBit> kbit<T>(this T value) {
        return new Quantity<T, KiloBit> (value);
    }
}
}