namespace System.Units.Power {
	/// <summary>
	/// Unit of measurement for the CentiWatt (cW)
	/// </summary>
	public struct CentiWatt : IPower {
        public static string Name => "CentiWatt";
        public static string Symbol => "cW";
    }
	
	public static class CentiWattFactory {
		/// <summary>
        /// Create a quantity measured in CentiWatts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, CentiWatt> cW<T>(this T value) {
            return new Quantity<T, CentiWatt> (value);
        }
	}
}