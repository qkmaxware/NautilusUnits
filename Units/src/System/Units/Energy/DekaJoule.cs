namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the DekaJoule (daJ)
	/// </summary>
	public struct DekaJoule : IEnergy {
        public static string Name => "DekaJoule";
        public static string Symbol => "daJ";
    }
	
	/// <summary>
	///Extension method factory for generating DekaJoule (daJ)
	/// </summary>
	public static class DekaJouleFactory {
		/// <summary>
        /// Create a quantity measured in DekaJoules
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DekaJoule> daJ<T>(this T value) {
            return new Quantity<T, DekaJoule> (value);
        }
	}
}