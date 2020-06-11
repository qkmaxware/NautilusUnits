namespace Qkmaxware.Units.Data {
/// <summary>
/// Unit of measurement for PicoBit (pbit)
/// </summary>
public struct PicoBit : IData {
    public static string Name => "PicoBit";
    public static string Symbol => "pbit";
}

/// <summary>
/// Extension method factory for generating PicoBit (pbit)
/// </summary>
public static class PicoBitFactory {
    /// <summary>
    /// Create a quantity measured in PicoBits
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, PicoBit> pbit<T>(this T value) {
        return new Quantity<T, PicoBit> (value);
    }
}
}