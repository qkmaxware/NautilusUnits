namespace System.Units.Power {
	/// <summary>
	/// Unit of measurement for the ZeptoWatt (zW)
	/// </summary>
	public struct ZeptoWatt : IPower {
        public static string Name => "ZeptoWatt";
        public static string Symbol => "zW";
    }
	
	public static class ZeptoWattFactory {
		/// <summary>
        /// Create a quantity measured in ZeptoWatts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZeptoWatt> zW<T>(this T value) {
            return new Quantity<T, ZeptoWatt> (value);
        }
	}
}