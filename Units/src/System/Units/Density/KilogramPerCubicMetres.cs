namespace System.Units.Density {
/// <summary>
/// Unit of measurement for KilogramPerCubicMetres (km·m^3)
/// </summary>
public struct KilogramPerCubicMetres : IUnit {
    public static string Name => "KilogramPerCubicMetres";
    public static string Symbol => "km/m^3";
}

/// <summary>
/// Extension method factory for generating KilogramPerCubicMetres (km·m^3)
/// </summary>
public static class KilogramPerCubicMetresFactory {
    /// <summary>
    /// Create a quantity measured in KilogramPerCubicMetres
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, KilogramPerCubicMetres> kg_m3<T>(this T value) {
        return new Quantity<T, KilogramPerCubicMetres> (value);
    }
}
}