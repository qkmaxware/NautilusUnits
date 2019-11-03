namespace System.Units.Data {
/// <summary>
/// Unit of measurement for ExaByte (EB)
/// </summary>
public struct ExaByte : IData {
    public static string Name => "ExaByte";
    public static string Symbol => "EB";
}

/// <summary>
/// Extension method factory for generating ExaByte (EB)
/// </summary>
public static class ExaByteFactory {
    /// <summary>
    /// Create a quantity measured in ExaBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, ExaByte> EB<T>(this T value) {
        return new Quantity<T, ExaByte> (value);
    }
}
}