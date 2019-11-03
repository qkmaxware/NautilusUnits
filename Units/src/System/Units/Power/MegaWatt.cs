namespace System.Units.Power {
	/// <summary>
	/// Unit of measurement for the MegaWatt (MW)
	/// </summary>
	public struct MegaWatt : IPower {
        public static string Name => "MegaWatt";
        public static string Symbol => "MW";
    }
	
	/// <summary>
	///Extension method factory for generating MegaWatt (MW)
	/// </summary>
	public static class MegaWattFactory {
		/// <summary>
        /// Create a quantity measured in MegaWatts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MegaWatt> MW<T>(this T value) {
            return new Quantity<T, MegaWatt> (value);
        }
	}
}