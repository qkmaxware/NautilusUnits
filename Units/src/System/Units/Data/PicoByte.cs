namespace System.Units.Data {
/// <summary>
/// Unit of measurement for PicoByte (pB)
/// </summary>
public struct PicoByte : IData {
    public static string Name => "PicoByte";
    public static string Symbol => "pB";
}

/// <summary>
/// Extension method factory for generating PicoByte (pB)
/// </summary>
public static class PicoByteFactory {
    /// <summary>
    /// Create a quantity measured in PicoBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, PicoByte> pB<T>(this T value) {
        return new Quantity<T, PicoByte> (value);
    }
}
}