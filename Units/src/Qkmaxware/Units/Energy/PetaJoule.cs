namespace Qkmaxware.Units.Energy {
	/// <summary>
	/// Unit of measurement for the PetaJoule (PJ)
	/// </summary>
	public struct PetaJoule : IEnergy {
        public static string Name => "PetaJoule";
        public static string Symbol => "PJ";
    }
	
	/// <summary>
	///Extension method factory for generating PetaJoule (PJ)
	/// </summary>
	public static class PetaJouleFactory {
		/// <summary>
        /// Create a quantity measured in PetaJoules
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PetaJoule> PJ<T>(this T value) {
            return new Quantity<T, PetaJoule> (value);
        }
	}
}