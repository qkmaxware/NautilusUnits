namespace System.Units.Data {
/// <summary>
/// Unit of measurement for FemtoBit (fbit)
/// </summary>
public struct FemtoBit : IData {
    public static string Name => "FemtoBit";
    public static string Symbol => "fbit";
}

/// <summary>
/// Extension method factory for generating FemtoBit (fbit)
/// </summary>
public static class FemtoBitFactory {
    /// <summary>
    /// Create a quantity measured in FemtoBits
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, FemtoBit> fbit<T>(this T value) {
        return new Quantity<T, FemtoBit> (value);
    }
}
}