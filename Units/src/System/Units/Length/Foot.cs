namespace System.Units.Length {
/// <summary>
/// Unit of measurement for the Foot (ft)
/// </summary>
public struct Foot : ILength {
    public static string Name => "Foot";
    public static string Symbol => "ft";
}

/// <summary>
	///Extension method factory for generating Foot (ft)
	/// </summary>
	public static class FootFactory {
    /// <summary>
    /// Create a quantity measured in Foots
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, Foot> ft<T>(this T value) {
        return new Quantity<T, Foot> (value);
    }
}
}