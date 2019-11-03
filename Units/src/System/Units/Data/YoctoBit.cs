namespace System.Units.Data {
/// <summary>
/// Unit of measurement for YoctoBit (ybit)
/// </summary>
public struct YoctoBit : IData {
    public static string Name => "YoctoBit";
    public static string Symbol => "ybit";
}

/// <summary>
/// Extension method factory for generating YoctoBit (ybit)
/// </summary>
public static class YoctoBitFactory {
    /// <summary>
    /// Create a quantity measured in YoctoBits
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, YoctoBit> ybit<T>(this T value) {
        return new Quantity<T, YoctoBit> (value);
    }
}
}