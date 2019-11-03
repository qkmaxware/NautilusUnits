namespace System.Units.MagneticFlux {
	/// <summary>
	/// Unit of measurement for the PetaTesla (PT)
	/// </summary>
	public struct PetaTesla : IMagneticFlux {
        public static string Name => "PetaTesla";
        public static string Symbol => "PT";
    }
	
	/// <summary>
	///Extension method factory for generating PetaTesla (PT)
	/// </summary>
	public static class PetaTeslaFactory {
		/// <summary>
        /// Create a quantity measured in PetaTeslas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PetaTesla> PT<T>(this T value) {
            return new Quantity<T, PetaTesla> (value);
        }
	}
}