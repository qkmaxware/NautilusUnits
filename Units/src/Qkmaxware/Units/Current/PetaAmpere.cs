namespace Qkmaxware.Units.Current {
	/// <summary>
	/// Unit of measurement for PetaAmpere (PA)
	/// </summary>
	public struct PetaAmpere : ICurrent {
        public static string Name => "PetaAmpere";
        public static string Symbol => "PA";
    }
	
	/// <summary>
	/// Extension method factory for generating PetaAmpere (PA)
	/// </summary>
	public static class PetaAmpereFactory {
		/// <summary>
        /// Create a quantity measured in PetaAmperes
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PetaAmpere> PA<T>(this T value) {
            return new Quantity<T, PetaAmpere> (value);
        }
	}
}