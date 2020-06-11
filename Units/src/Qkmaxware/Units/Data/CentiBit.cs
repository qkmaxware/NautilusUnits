namespace Qkmaxware.Units.Data {
/// <summary>
/// Unit of measurement for CentiBit (cbit)
/// </summary>
public struct CentiBit : IData {
    public static string Name => "CentiBit";
    public static string Symbol => "cbit";
}

/// <summary>
/// Extension method factory for generating CentiBit (cbit)
/// </summary>
public static class CentiBitFactory {
    /// <summary>
    /// Create a quantity measured in CentiBits
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, CentiBit> cbit<T>(this T value) {
        return new Quantity<T, CentiBit> (value);
    }
}
}