namespace Qkmaxware.Units.Data {
/// <summary>
/// Unit of measurement for DekaBit (dabit)
/// </summary>
public struct DekaBit : IData {
    public static string Name => "DekaBit";
    public static string Symbol => "dabit";
}

/// <summary>
/// Extension method factory for generating DekaBit (dabit)
/// </summary>
public static class DekaBitFactory {
    /// <summary>
    /// Create a quantity measured in DekaBits
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, DekaBit> dabit<T>(this T value) {
        return new Quantity<T, DekaBit> (value);
    }
}
}