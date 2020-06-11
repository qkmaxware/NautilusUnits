namespace Qkmaxware.Units.Power {
	/// <summary>
	/// Unit of measurement for the MilliWatt (mW)
	/// </summary>
	public struct MilliWatt : IPower {
        public static string Name => "MilliWatt";
        public static string Symbol => "mW";
    }
	
	/// <summary>
	///Extension method factory for generating MilliWatt (mW)
	/// </summary>
	public static class MilliWattFactory {
		/// <summary>
        /// Create a quantity measured in MilliWatts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MilliWatt> mW<T>(this T value) {
            return new Quantity<T, MilliWatt> (value);
        }
	}
}