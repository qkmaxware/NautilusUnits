namespace System.Units.Data {
/// <summary>
/// Unit of measurement for GigaBit (Gbit)
/// </summary>
public struct GigaBit : IData {
    public static string Name => "GigaBit";
    public static string Symbol => "Gbit";
}

/// <summary>
/// Extension method factory for generating GigaBit (Gbit)
/// </summary>
public static class GigaBitFactory {
    /// <summary>
    /// Create a quantity measured in GigaBits
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, GigaBit> Gbit<T>(this T value) {
        return new Quantity<T, GigaBit> (value);
    }
}
}