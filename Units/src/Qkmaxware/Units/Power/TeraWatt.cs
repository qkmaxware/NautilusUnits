namespace Qkmaxware.Units.Power {
	/// <summary>
	/// Unit of measurement for TeraWatt (TW)
	/// </summary>
	public struct TeraWatt : IPower {
        public static string Name => "TeraWatt";
        public static string Symbol => "TW";
    }
	
	/// <summary>
	/// Extension method factory for generating TeraWatt (TW)
	/// </summary>
	public static class TeraWattFactory {
		/// <summary>
        /// Create a quantity measured in TeraWatts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, TeraWatt> TW<T>(this T value) {
            return new Quantity<T, TeraWatt> (value);
        }
	}
}