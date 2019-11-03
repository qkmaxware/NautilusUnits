namespace System.Units.Data {
/// <summary>
/// Unit of measurement for ExbiByte (EiB)
/// </summary>
public struct ExbiByte : IData {
    public static string Name => "ExbiByte";
    public static string Symbol => "EiB";
}

/// <summary>
/// Extension method factory for generating ExbiByte (EiB)
/// </summary>
public static class ExbiByteFactory {
    /// <summary>
    /// Create a quantity measured in ExbiBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, ExbiByte> EiB<T>(this T value) {
        return new Quantity<T, ExbiByte> (value);
    }
}
}