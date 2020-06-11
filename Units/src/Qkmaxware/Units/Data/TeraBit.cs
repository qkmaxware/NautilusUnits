namespace Qkmaxware.Units.Data {
/// <summary>
/// Unit of measurement for TeraBit (Tbit)
/// </summary>
public struct TeraBit : IData {
    public static string Name => "TeraBit";
    public static string Symbol => "Tbit";
}

/// <summary>
/// Extension method factory for generating TeraBit (Tbit)
/// </summary>
public static class TeraBitFactory {
    /// <summary>
    /// Create a quantity measured in TeraBits
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, TeraBit> Tbit<T>(this T value) {
        return new Quantity<T, TeraBit> (value);
    }
}
}