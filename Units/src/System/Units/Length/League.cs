namespace System.Units.Length {
/// <summary>
/// Unit of measurement for the League (lea)
/// </summary>
public struct League : ILength {
    public static string Name => "League";
    public static string Symbol => "lea";
}

public static class LeagueFactory {
    /// <summary>
    /// Create a quantity measured in Leagues
    /// </summary>
    /// <param name="value">measured value</param>
    /// <typeparam name="T">type of measured value</typeparam>
    /// <returns>quantity with value and units</returns>
    public static Quantity<T, League> lea<T>(this T value) {
        return new Quantity<T, League> (value);
    }
}
}