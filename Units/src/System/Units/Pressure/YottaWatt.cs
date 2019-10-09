namespace System.Units.Power {
	/// <summary>
	/// Unit of measurement for the YottaWatt (YW)
	/// </summary>
	public struct YottaWatt : IPower {
        public static string Name => "YottaWatt";
        public static string Symbol => "YW";
    }
	
	public static class YottaWattFactory {
		/// <summary>
        /// Create a quantity measured in YottaWatts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YottaWatt> YW<T>(this T value) {
            return new Quantity<T, YottaWatt> (value);
        }
	}
}