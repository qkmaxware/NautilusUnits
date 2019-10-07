namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the ExaGram (Eg)
	/// </summary>
	public struct ExaGram : IMass {
        public static string Name => "ExaGram";
        public static string Symbol => "Eg";
    }
	
	public static class ExaGramFactory {
		/// <summary>
        /// Create a quantity measured in ExaGrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ExaGram> Eg<T>(this T value) {
            return new Quantity<T, ExaGram> (value);
        }
	}
}