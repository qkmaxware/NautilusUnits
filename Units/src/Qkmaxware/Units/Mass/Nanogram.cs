namespace Qkmaxware.Units.Mass {
	/// <summary>
	/// Unit of measurement for the NanoGram (ng)
	/// </summary>
	public struct NanoGram : IMass {
        public static string Name => "NanoGram";
        public static string Symbol => "ng";
    }
	
	/// <summary>
	///Extension method factory for generating NanoGram (ng)
	/// </summary>
	public static class NanoGramFactory {
		/// <summary>
        /// Create a quantity measured in NanoGrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, NanoGram> ng<T>(this T value) {
            return new Quantity<T, NanoGram> (value);
        }
	}
}