namespace System.Units.Power {
	/// <summary>
	/// Unit of measurement for the GigaWatt (GW)
	/// </summary>
	public struct GigaWatt : IPower {
        public static string Name => "GigaWatt";
        public static string Symbol => "GW";
    }
	
	/// <summary>
	///Extension method factory for generating GigaWatt (GW)
	/// </summary>
	public static class GigaWattFactory {
		/// <summary>
        /// Create a quantity measured in GigaWatts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, GigaWatt> GW<T>(this T value) {
            return new Quantity<T, GigaWatt> (value);
        }
	}
}