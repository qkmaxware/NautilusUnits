namespace Qkmaxware.Units.Mass {
	/// <summary>
	/// Unit of measurement for the FemtoGram (fg)
	/// </summary>
	public struct FemtoGram : IMass {
        public static string Name => "FemtoGram";
        public static string Symbol => "fg";
    }
	
	/// <summary>
	///Extension method factory for generating FemtoGram (fg)
	/// </summary>
	public static class FemtoGramFactory {
		/// <summary>
        /// Create a quantity measured in FemtoGrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, FemtoGram> fg<T>(this T value) {
            return new Quantity<T, FemtoGram> (value);
        }
	}
}