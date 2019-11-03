namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the DekaGram (dag)
	/// </summary>
	public struct DekaGram : IMass {
        public static string Name => "DekaGram";
        public static string Symbol => "dag";
    }
	
	/// <summary>
	///Extension method factory for generating DekaGram (dag)
	/// </summary>
	public static class DekaGramFactory {
		/// <summary>
        /// Create a quantity measured in DekaGrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DekaGram> dag<T>(this T value) {
            return new Quantity<T, DekaGram> (value);
        }
	}
}