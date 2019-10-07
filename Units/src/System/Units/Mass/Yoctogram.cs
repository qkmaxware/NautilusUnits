namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the YoctoGram (yg)
	/// </summary>
	public struct YoctoGram : IMass {
        public static string Name => "YoctoGram";
        public static string Symbol => "yg";
    }
	
	public static class YoctoGramFactory {
		/// <summary>
        /// Create a quantity measured in YoctoGrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YoctoGram> yg<T>(this T value) {
            return new Quantity<T, YoctoGram> (value);
        }
	}
}