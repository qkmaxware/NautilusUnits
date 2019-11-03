namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the DeciGram (dg)
	/// </summary>
	public struct DeciGram : IMass {
        public static string Name => "DeciGram";
        public static string Symbol => "dg";
    }
	
	/// <summary>
	///Extension method factory for generating DeciGram (dg)
	/// </summary>
	public static class DeciGramFactory {
		/// <summary>
        /// Create a quantity measured in DeciGrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DeciGram> dg<T>(this T value) {
            return new Quantity<T, DeciGram> (value);
        }
	}
}