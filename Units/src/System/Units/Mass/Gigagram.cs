namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the GigaGram (Gg)
	/// </summary>
	public struct GigaGram : IMass {
        public static string Name => "GigaGram";
        public static string Symbol => "Gg";
    }
	
	/// <summary>
	///Extension method factory for generating GigaGram (Gg)
	/// </summary>
	public static class GigaGramFactory {
		/// <summary>
        /// Create a quantity measured in GigaGrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, GigaGram> Gg<T>(this T value) {
            return new Quantity<T, GigaGram> (value);
        }
	}
}