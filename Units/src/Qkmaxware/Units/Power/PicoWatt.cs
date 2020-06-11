namespace Qkmaxware.Units.Power {
	/// <summary>
	/// Unit of measurement for the PicoWatt (pW)
	/// </summary>
	public struct PicoWatt : IPower {
        public static string Name => "PicoWatt";
        public static string Symbol => "pW";
    }
	
	/// <summary>
	///Extension method factory for generating PicoWatt (pW)
	/// </summary>
	public static class PicoWattFactory {
		/// <summary>
        /// Create a quantity measured in PicoWatts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PicoWatt> pW<T>(this T value) {
            return new Quantity<T, PicoWatt> (value);
        }
	}
}