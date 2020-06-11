namespace Qkmaxware.Units.Mass {
	/// <summary>
	/// Unit of measurement for the CentiGram (cg)
	/// </summary>
	public struct CentiGram : IMass {
        public static string Name => "CentiGram";
        public static string Symbol => "cg";
    }
	
	/// <summary>
	///Extension method factory for generating CentiGram (cg)
	/// </summary>
	public static class CentiGramFactory {
		/// <summary>
        /// Create a quantity measured in CentiGrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, CentiGram> cg<T>(this T value) {
            return new Quantity<T, CentiGram> (value);
        }
	}
}