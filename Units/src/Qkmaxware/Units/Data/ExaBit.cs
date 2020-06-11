namespace Qkmaxware.Units.Data {
/// <summary>
/// Unit of measurement for ExaBit (Ebit)
/// </summary>
public struct ExaBit : IData {
    public static string Name => "ExaBit";
    public static string Symbol => "Ebit";
}

/// <summary>
/// Extension method factory for generating ExaBit (Ebit)
/// </summary>
public static class ExaBitFactory {
    /// <summary>
    /// Create a quantity measured in ExaBits
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, ExaBit> Ebit<T>(this T value) {
        return new Quantity<T, ExaBit> (value);
    }
}
}