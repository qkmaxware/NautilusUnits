namespace Qkmaxware.Units.Power {
	/// <summary>
	/// Unit of measurement for KiloWatt (kW)
	/// </summary>
	public struct KiloWatt : IPower {
        public static string Name => "KiloWatt";
        public static string Symbol => "kW";
    }
	
	/// <summary>
	/// Extension method factory for generating KiloWatt (kW)
	/// </summary>
	public static class KiloWattFactory {
		/// <summary>
        /// Create a quantity measured in KiloWatts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, KiloWatt> kW<T>(this T value) {
            return new Quantity<T, KiloWatt> (value);
        }
	}
}