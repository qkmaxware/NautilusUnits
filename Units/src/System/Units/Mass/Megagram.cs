namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the MegaGram (Mg)
	/// </summary>
	public struct MegaGram : IMass {
        public static string Name => "MegaGram";
        public static string Symbol => "Mg";
    }
	
	/// <summary>
	///Extension method factory for generating MegaGram (Mg)
	/// </summary>
	public static class MegaGramFactory {
		/// <summary>
        /// Create a quantity measured in MegaGrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MegaGram> Mg<T>(this T value) {
            return new Quantity<T, MegaGram> (value);
        }
	}
}