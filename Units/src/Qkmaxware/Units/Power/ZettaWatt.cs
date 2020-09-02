namespace Qkmaxware.Units.Power {
	/// <summary>
	/// Unit of measurement for ZettaWatt (ZW)
	/// </summary>
	public struct ZettaWatt : IPower {
        public static string Name => "ZettaWatt";
        public static string Symbol => "ZW";
    }
	
	/// <summary>
	/// Extension method factory for generating ZettaWatt (ZW)
	/// </summary>
	public static class ZettaWattFactory {
		/// <summary>
        /// Create a quantity measured in ZettaWatts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZettaWatt> ZW<T>(this T value) {
            return new Quantity<T, ZettaWatt> (value);
        }
	}
}