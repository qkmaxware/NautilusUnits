namespace Qkmaxware.Units.Mass {
	/// <summary>
	/// Unit of measurement for TeraGram (Tg)
	/// </summary>
	public struct TeraGram : IMass {
        public static string Name => "TeraGram";
        public static string Symbol => "Tg";
    }
	
	/// <summary>
	/// Extension method factory for generating TeraGram (Tg)
	/// </summary>
	public static class TeraGramFactory {
		/// <summary>
        /// Create a quantity measured in TeraGrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, TeraGram> Tg<T>(this T value) {
            return new Quantity<T, TeraGram> (value);
        }
	}
}