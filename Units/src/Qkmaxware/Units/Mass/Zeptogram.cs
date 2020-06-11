namespace Qkmaxware.Units.Mass {
	/// <summary>
	/// Unit of measurement for the ZeptoGram (zg)
	/// </summary>
	public struct ZeptoGram : IMass {
        public static string Name => "ZeptoGram";
        public static string Symbol => "zg";
    }
	
	/// <summary>
	///Extension method factory for generating ZeptoGram (zg)
	/// </summary>
	public static class ZeptoGramFactory {
		/// <summary>
        /// Create a quantity measured in ZeptoGrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZeptoGram> zg<T>(this T value) {
            return new Quantity<T, ZeptoGram> (value);
        }
	}
}