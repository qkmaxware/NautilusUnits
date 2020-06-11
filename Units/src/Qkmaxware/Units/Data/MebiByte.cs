namespace Qkmaxware.Units.Data {
/// <summary>
/// Unit of measurement for MebiByte (MiB)
/// </summary>
public struct MebiByte : IData {
    public static string Name => "MebiByte";
    public static string Symbol => "MiB";
}

/// <summary>
/// Extension method factory for generating MebiByte (MiB)
/// </summary>
public static class MebiByteFactory {
    /// <summary>
    /// Create a quantity measured in MebiBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, MebiByte> MiB<T>(this T value) {
        return new Quantity<T, MebiByte> (value);
    }
}
}