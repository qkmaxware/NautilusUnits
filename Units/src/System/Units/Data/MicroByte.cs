namespace System.Units.Data {
/// <summary>
/// Unit of measurement for MicroByte (uB)
/// </summary>
public struct MicroByte : IData {
    public static string Name => "MicroByte";
    public static string Symbol => "uB";
}

/// <summary>
/// Extension method factory for generating MicroByte (uB)
/// </summary>
public static class MicroByteFactory {
    /// <summary>
    /// Create a quantity measured in MicroBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, MicroByte> uB<T>(this T value) {
        return new Quantity<T, MicroByte> (value);
    }
}
}