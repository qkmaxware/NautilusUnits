namespace Qkmaxware.Units.Data {
/// <summary>
/// Unit of measurement for PebiByte (PiB)
/// </summary>
public struct PebiByte : IData {
    public static string Name => "PebiByte";
    public static string Symbol => "PiB";
}

/// <summary>
/// Extension method factory for generating PebiByte (PiB)
/// </summary>
public static class PebiByteFactory {
    /// <summary>
    /// Create a quantity measured in PebiBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, PebiByte> PiB<T>(this T value) {
        return new Quantity<T, PebiByte> (value);
    }
}
}