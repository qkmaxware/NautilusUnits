namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the PetaGram (Pg)
	/// </summary>
	public struct PetaGram : IMass {
        public static string Name => "PetaGram";
        public static string Symbol => "Pg";
    }
	
	/// <summary>
	///Extension method factory for generating PetaGram (Pg)
	/// </summary>
	public static class PetaGramFactory {
		/// <summary>
        /// Create a quantity measured in PetaGrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PetaGram> Pg<T>(this T value) {
            return new Quantity<T, PetaGram> (value);
        }
	}
}