namespace System.Units.Data {
/// <summary>
/// Unit of measurement for YottaBit (Ybit)
/// </summary>
public struct YottaBit : IData {
    public static string Name => "YottaBit";
    public static string Symbol => "Ybit";
}

/// <summary>
/// Extension method factory for generating YottaBit (Ybit)
/// </summary>
public static class YottaBitFactory {
    /// <summary>
    /// Create a quantity measured in YottaBits
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, YottaBit> Ybit<T>(this T value) {
        return new Quantity<T, YottaBit> (value);
    }
}
}