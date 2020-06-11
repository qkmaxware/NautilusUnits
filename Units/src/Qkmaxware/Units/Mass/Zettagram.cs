namespace Qkmaxware.Units.Mass {
	/// <summary>
	/// Unit of measurement for the ZettaGram (Zg)
	/// </summary>
	public struct ZettaGram : IMass {
        public static string Name => "ZettaGram";
        public static string Symbol => "Zg";
    }
	
	/// <summary>
	///Extension method factory for generating ZettaGram (Zg)
	/// </summary>
	public static class ZettaGramFactory {
		/// <summary>
        /// Create a quantity measured in ZettaGrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZettaGram> Zg<T>(this T value) {
            return new Quantity<T, ZettaGram> (value);
        }
	}
}