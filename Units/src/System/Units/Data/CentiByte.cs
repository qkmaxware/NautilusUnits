namespace System.Units.Data {
/// <summary>
/// Unit of measurement for CentiByte (cB)
/// </summary>
public struct CentiByte : IData {
    public static string Name => "CentiByte";
    public static string Symbol => "cB";
}

/// <summary>
/// Extension method factory for generating CentiByte (cB)
/// </summary>
public static class CentiByteFactory {
    /// <summary>
    /// Create a quantity measured in CentiBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, CentiByte> cB<T>(this T value) {
        return new Quantity<T, CentiByte> (value);
    }
}
}