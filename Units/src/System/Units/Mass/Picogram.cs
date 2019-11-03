namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the PicoGram (pg)
	/// </summary>
	public struct PicoGram : IMass {
        public static string Name => "PicoGram";
        public static string Symbol => "pg";
    }
	
	/// <summary>
	///Extension method factory for generating PicoGram (pg)
	/// </summary>
	public static class PicoGramFactory {
		/// <summary>
        /// Create a quantity measured in PicoGrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PicoGram> pg<T>(this T value) {
            return new Quantity<T, PicoGram> (value);
        }
	}
}