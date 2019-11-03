namespace System.Units.Data {
/// <summary>
/// Unit of measurement for MegaByte (MB)
/// </summary>
public struct MegaByte : IData {
    public static string Name => "MegaByte";
    public static string Symbol => "MB";
}

/// <summary>
/// Extension method factory for generating MegaByte (MB)
/// </summary>
public static class MegaByteFactory {
    /// <summary>
    /// Create a quantity measured in MegaBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, MegaByte> MB<T>(this T value) {
        return new Quantity<T, MegaByte> (value);
    }
}
}