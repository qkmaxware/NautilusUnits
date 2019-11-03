namespace System.Units.Data {
/// <summary>
/// Unit of measurement for AttoBit (abit)
/// </summary>
public struct AttoBit : IData {
    public static string Name => "AttoBit";
    public static string Symbol => "abit";
}

/// <summary>
/// Extension method factory for generating AttoBit (abit)
/// </summary>
public static class AttoBitFactory {
    /// <summary>
    /// Create a quantity measured in AttoBits
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, AttoBit> abit<T>(this T value) {
        return new Quantity<T, AttoBit> (value);
    }
}
}