namespace Qkmaxware.Units.Mass {
	/// <summary>
	/// Unit of measurement for MicroGram (ug)
	/// </summary>
	public struct MicroGram : IMass {
        public static string Name => "MicroGram";
        public static string Symbol => "ug";
    }
	
	/// <summary>
	/// Extension method factory for generating MicroGram (ug)
	/// </summary>
	public static class MicroGramFactory {
		/// <summary>
        /// Create a quantity measured in MicroGrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MicroGram> ug<T>(this T value) {
            return new Quantity<T, MicroGram> (value);
        }
	}
}