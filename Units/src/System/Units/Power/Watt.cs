namespace System.Units.Power {
	/// <summary>
	/// Unit of measurement for the Watt (W)
	/// </summary>
	public struct Watt : IPower {
        public static string Name => "Watt";
        public static string Symbol => "W";
    }
	
	/// <summary>
	///Extension method factory for generating Watt (W)
	/// </summary>
	public static class WattFactory {
		/// <summary>
        /// Create a quantity measured in Watts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Watt> W<T>(this T value) {
            return new Quantity<T, Watt> (value);
        }
	}
}