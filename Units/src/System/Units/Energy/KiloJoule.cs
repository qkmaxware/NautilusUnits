namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the KiloJoule (kJ)
	/// </summary>
	public struct KiloJoule : IEnergy {
        public static string Name => "KiloJoule";
        public static string Symbol => "kJ";
    }
	
	/// <summary>
	///Extension method factory for generating KiloJoule (kJ)
	/// </summary>
	public static class KiloJouleFactory {
		/// <summary>
        /// Create a quantity measured in KiloJoules
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, KiloJoule> kJ<T>(this T value) {
            return new Quantity<T, KiloJoule> (value);
        }
	}
}