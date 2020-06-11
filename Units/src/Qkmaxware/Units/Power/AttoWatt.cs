namespace Qkmaxware.Units.Power {
	/// <summary>
	/// Unit of measurement for the AttoWatt (aW)
	/// </summary>
	public struct AttoWatt : IPower {
        public static string Name => "AttoWatt";
        public static string Symbol => "aW";
    }
	
	/// <summary>
	///Extension method factory for generating AttoWatt (aW)
	/// </summary>
	public static class AttoWattFactory {
		/// <summary>
        /// Create a quantity measured in AttoWatts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, AttoWatt> aW<T>(this T value) {
            return new Quantity<T, AttoWatt> (value);
        }
	}
}