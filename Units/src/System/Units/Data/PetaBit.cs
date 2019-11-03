namespace System.Units.Data {
/// <summary>
/// Unit of measurement for PetaBit (Pbit)
/// </summary>
public struct PetaBit : IData {
    public static string Name => "PetaBit";
    public static string Symbol => "Pbit";
}

/// <summary>
/// Extension method factory for generating PetaBit (Pbit)
/// </summary>
public static class PetaBitFactory {
    /// <summary>
    /// Create a quantity measured in PetaBits
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, PetaBit> Pbit<T>(this T value) {
        return new Quantity<T, PetaBit> (value);
    }
}
}