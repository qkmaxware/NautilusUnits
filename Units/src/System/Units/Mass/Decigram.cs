namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the Decigram (dg)
	/// </summary>
	public struct Decigram : IMass {
        public static string Name => "Decigram";
        public static string Symbol => "dg";
    }
	
	public static class DecigramFactory {
		/// <summary>
        /// Create a quantity measured in Decigrams
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Decigram> dg<T>(this T value) {
            return value.As<Decigram, T>();
        }
	}
}