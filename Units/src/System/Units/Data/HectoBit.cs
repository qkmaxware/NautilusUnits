namespace System.Units.Data {
/// <summary>
/// Unit of measurement for HectoBit (hbit)
/// </summary>
public struct HectoBit : IData {
    public static string Name => "HectoBit";
    public static string Symbol => "hbit";
}

/// <summary>
/// Extension method factory for generating HectoBit (hbit)
/// </summary>
public static class HectoBitFactory {
    /// <summary>
    /// Create a quantity measured in HectoBits
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, HectoBit> hbit<T>(this T value) {
        return new Quantity<T, HectoBit> (value);
    }
}
}