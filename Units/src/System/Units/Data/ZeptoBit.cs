namespace System.Units.Data {
/// <summary>
/// Unit of measurement for ZeptoBit (zbit)
/// </summary>
public struct ZeptoBit : IData {
    public static string Name => "ZeptoBit";
    public static string Symbol => "zbit";
}

/// <summary>
/// Extension method factory for generating ZeptoBit (zbit)
/// </summary>
public static class ZeptoBitFactory {
    /// <summary>
    /// Create a quantity measured in ZeptoBits
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, ZeptoBit> zbit<T>(this T value) {
        return new Quantity<T, ZeptoBit> (value);
    }
}
}