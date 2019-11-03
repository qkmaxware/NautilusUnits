namespace System.Units.Data {
/// <summary>
/// Unit of measurement for DeciBit (dbit)
/// </summary>
public struct DeciBit : IData {
    public static string Name => "DeciBit";
    public static string Symbol => "dbit";
}

/// <summary>
/// Extension method factory for generating DeciBit (dbit)
/// </summary>
public static class DeciBitFactory {
    /// <summary>
    /// Create a quantity measured in DeciBits
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, DeciBit> dbit<T>(this T value) {
        return new Quantity<T, DeciBit> (value);
    }
}
}