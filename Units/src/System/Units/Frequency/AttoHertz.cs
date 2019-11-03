namespace System.Units.Frequency {
	/// <summary>
	/// Unit of measurement for the AttoHertz (aHz)
	/// </summary>
	public struct AttoHertz : IFrequency {
        public static string Name => "AttoHertz";
        public static string Symbol => "aHz";
    }
	
	/// <summary>
	///Extension method factory for generating AttoHertz (aHz)
	/// </summary>
	public static class AttoHertzFactory {
		/// <summary>
        /// Create a quantity measured in AttoHertzs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, AttoHertz> aHz<T>(this T value) {
            return new Quantity<T, AttoHertz> (value);
        }
	}
}