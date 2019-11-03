namespace System.Units.Data {
/// <summary>
/// Unit of measurement for MicroBit (ubit)
/// </summary>
public struct MicroBit : IData {
    public static string Name => "MicroBit";
    public static string Symbol => "ubit";
}

/// <summary>
/// Extension method factory for generating MicroBit (ubit)
/// </summary>
public static class MicroBitFactory {
    /// <summary>
    /// Create a quantity measured in MicroBits
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, MicroBit> ubit<T>(this T value) {
        return new Quantity<T, MicroBit> (value);
    }
}
}