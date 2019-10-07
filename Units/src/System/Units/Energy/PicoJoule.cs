namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the PicoJoule (pJ)
	/// </summary>
	public struct PicoJoule : IEnergy {
        public static string Name => "PicoJoule";
        public static string Symbol => "pJ";
    }
	
	public static class PicoJouleFactory {
		/// <summary>
        /// Create a quantity measured in PicoJoules
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PicoJoule> pJ<T>(this T value) {
            return new Quantity<T, PicoJoule> (value);
        }
	}
}