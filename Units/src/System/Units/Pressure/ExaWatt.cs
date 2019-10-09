namespace System.Units.Power {
	/// <summary>
	/// Unit of measurement for the ExaWatt (EW)
	/// </summary>
	public struct ExaWatt : IPower {
        public static string Name => "ExaWatt";
        public static string Symbol => "EW";
    }
	
	public static class ExaWattFactory {
		/// <summary>
        /// Create a quantity measured in ExaWatts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ExaWatt> EW<T>(this T value) {
            return new Quantity<T, ExaWatt> (value);
        }
	}
}