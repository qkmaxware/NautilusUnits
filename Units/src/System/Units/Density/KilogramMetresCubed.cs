namespace System.Units.Density {
/// <summary>
/// Unit of measurement for KilogramMetresCubed (km·m^3)
/// </summary>
public struct KilogramMetresCubed : IUnit {
    public static string Name => "KilogramMetresCubed";
    public static string Symbol => "km·m^3";
}

/// <summary>
/// Extension method factory for generating KilogramMetresCubed (km·m^3)
/// </summary>
public static class KilogramMetresCubedFactory {
    /// <summary>
    /// Create a quantity measured in KilogramMetresCubed
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, KilogramMetresCubed> kgm3<T>(this T value) {
        return new Quantity<T, KilogramMetresCubed> (value);
    }
}
}