namespace Qkmaxware.Units.Data {
/// <summary>
/// Unit of measurement for MegaBit (Mbit)
/// </summary>
public struct MegaBit : IData {
    public static string Name => "MegaBit";
    public static string Symbol => "Mbit";
}

/// <summary>
/// Extension method factory for generating MegaBit (Mbit)
/// </summary>
public static class MegaBitFactory {
    /// <summary>
    /// Create a quantity measured in MegaBits
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, MegaBit> Mbit<T>(this T value) {
        return new Quantity<T, MegaBit> (value);
    }
}
}