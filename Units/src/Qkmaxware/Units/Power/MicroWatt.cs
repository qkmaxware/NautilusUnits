namespace Qkmaxware.Units.Power {
	/// <summary>
	/// Unit of measurement for MicroWatt (uW)
	/// </summary>
	public struct MicroWatt : IPower {
        public static string Name => "MicroWatt";
        public static string Symbol => "uW";
    }
	
	/// <summary>
	/// Extension method factory for generating MicroWatt (uW)
	/// </summary>
	public static class MicroWattFactory {
		/// <summary>
        /// Create a quantity measured in MicroWatts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MicroWatt> uW<T>(this T value) {
            return new Quantity<T, MicroWatt> (value);
        }
	}
}