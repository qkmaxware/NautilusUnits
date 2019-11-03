namespace System.Units.Data {
/// <summary>
/// Unit of measurement for FemtoByte (fB)
/// </summary>
public struct FemtoByte : IData {
    public static string Name => "FemtoByte";
    public static string Symbol => "fB";
}

/// <summary>
/// Extension method factory for generating FemtoByte (fB)
/// </summary>
public static class FemtoByteFactory {
    /// <summary>
    /// Create a quantity measured in FemtoBytes
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, FemtoByte> fB<T>(this T value) {
        return new Quantity<T, FemtoByte> (value);
    }
}
}