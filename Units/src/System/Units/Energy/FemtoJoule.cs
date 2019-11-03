namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the FemtoJoule (fJ)
	/// </summary>
	public struct FemtoJoule : IEnergy {
        public static string Name => "FemtoJoule";
        public static string Symbol => "fJ";
    }
	
	/// <summary>
	///Extension method factory for generating FemtoJoule (fJ)
	/// </summary>
	public static class FemtoJouleFactory {
		/// <summary>
        /// Create a quantity measured in FemtoJoules
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, FemtoJoule> fJ<T>(this T value) {
            return new Quantity<T, FemtoJoule> (value);
        }
	}
}