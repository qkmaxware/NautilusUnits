namespace Qkmaxware.Units.Data {
/// <summary>
/// Unit of measurement for MilliBit (mbit)
/// </summary>
public struct MilliBit : IData {
    public static string Name => "MilliBit";
    public static string Symbol => "mbit";
}

/// <summary>
/// Extension method factory for generating MilliBit (mbit)
/// </summary>
public static class MilliBitFactory {
    /// <summary>
    /// Create a quantity measured in MilliBits
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, MilliBit> mbit<T>(this T value) {
        return new Quantity<T, MilliBit> (value);
    }
}
}