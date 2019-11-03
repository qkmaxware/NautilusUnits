namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the MicroJoule (uJ)
	/// </summary>
	public struct MicroJoule : IEnergy {
        public static string Name => "MicroJoule";
        public static string Symbol => "uJ";
    }
	
	/// <summary>
	///Extension method factory for generating MicroJoule (uJ)
	/// </summary>
	public static class MicroJouleFactory {
		/// <summary>
        /// Create a quantity measured in MicroJoules
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MicroJoule> uJ<T>(this T value) {
            return new Quantity<T, MicroJoule> (value);
        }
	}
}