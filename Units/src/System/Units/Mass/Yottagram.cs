namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the YottaGram (Yg)
	/// </summary>
	public struct YottaGram : IMass {
        public static string Name => "YottaGram";
        public static string Symbol => "Yg";
    }
	
	/// <summary>
	///Extension method factory for generating YottaGram (Yg)
	/// </summary>
	public static class YottaGramFactory {
		/// <summary>
        /// Create a quantity measured in YottaGrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YottaGram> Yg<T>(this T value) {
            return new Quantity<T, YottaGram> (value);
        }
	}
}