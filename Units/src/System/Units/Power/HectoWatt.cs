namespace System.Units.Power {
	/// <summary>
	/// Unit of measurement for the HectoWatt (hW)
	/// </summary>
	public struct HectoWatt : IPower {
        public static string Name => "HectoWatt";
        public static string Symbol => "hW";
    }
	
	public static class HectoWattFactory {
		/// <summary>
        /// Create a quantity measured in HectoWatts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, HectoWatt> hW<T>(this T value) {
            return new Quantity<T, HectoWatt> (value);
        }
	}
}