namespace Qkmaxware.Units.Power {
	/// <summary>
	/// Unit of measurement for DekaWatt (daW)
	/// </summary>
	public struct DekaWatt : IPower {
        public static string Name => "DekaWatt";
        public static string Symbol => "daW";
    }
	
	/// <summary>
	/// Extension method factory for generating DekaWatt (daW)
	/// </summary>
	public static class DekaWattFactory {
		/// <summary>
        /// Create a quantity measured in DekaWatts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DekaWatt> daW<T>(this T value) {
            return new Quantity<T, DekaWatt> (value);
        }
	}
}