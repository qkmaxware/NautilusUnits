namespace Qkmaxware.Units.Data {
/// <summary>
/// Unit of measurement for ZettaBit (Zbit)
/// </summary>
public struct ZettaBit : IData {
    public static string Name => "ZettaBit";
    public static string Symbol => "Zbit";
}

/// <summary>
/// Extension method factory for generating ZettaBit (Zbit)
/// </summary>
public static class ZettaBitFactory {
    /// <summary>
    /// Create a quantity measured in ZettaBits
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, ZettaBit> Zbit<T>(this T value) {
        return new Quantity<T, ZettaBit> (value);
    }
}
}