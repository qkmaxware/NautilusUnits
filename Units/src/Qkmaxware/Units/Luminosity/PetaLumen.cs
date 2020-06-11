namespace Qkmaxware.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the PetaLumen (Plm)
	/// </summary>
	public struct PetaLumen : ILuminosity {
        public static string Name => "PetaLumen";
        public static string Symbol => "Plm";
    }
	
	/// <summary>
	///Extension method factory for generating PetaLumen (Plm)
	/// </summary>
	public static class PetaLumenFactory {
		/// <summary>
        /// Create a quantity measured in PetaLumens
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PetaLumen> Plm<T>(this T value) {
            return new Quantity<T, PetaLumen> (value);
        }
	}
}