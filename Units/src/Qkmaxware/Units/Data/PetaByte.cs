namespace Qkmaxware.Units.Data {
/// <summary>
/// Unit of measurement for PetaByte (PB)
/// </summary>
public struct PetaByte : IData {
    public static string Name => "PetaByte";
    public static string Symbol => "PB";
}

/// <summary>
/// Extension method factory for generating PetaByte (PB)
/// </summary>
public static class PetaByteFactory {
    /// <summary>
    /// Create a quantity measured in PetaBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, PetaByte> PB<T>(this T value) {
        return new Quantity<T, PetaByte> (value);
    }
}
}