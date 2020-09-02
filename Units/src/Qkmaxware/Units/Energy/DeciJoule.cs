namespace Qkmaxware.Units.Energy {
	/// <summary>
	/// Unit of measurement for DeciJoule (dJ)
	/// </summary>
	public struct DeciJoule : IEnergy {
        public static string Name => "DeciJoule";
        public static string Symbol => "dJ";
    }
	
	/// <summary>
	/// Extension method factory for generating DeciJoule (dJ)
	/// </summary>
	public static class DeciJouleFactory {
		/// <summary>
        /// Create a quantity measured in DeciJoules
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DeciJoule> dJ<T>(this T value) {
            return new Quantity<T, DeciJoule> (value);
        }
	}
}