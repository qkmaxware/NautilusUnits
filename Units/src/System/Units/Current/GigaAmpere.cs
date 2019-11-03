namespace System.Units.Current {
	/// <summary>
	/// Unit of measurement for the GigaAmpere (GA)
	/// </summary>
	public struct GigaAmpere : ICurrent {
        public static string Name => "GigaAmpere";
        public static string Symbol => "GA";
    }
	
	/// <summary>
	///Extension method factory for generating GigaAmpere (GA)
	/// </summary>
	public static class GigaAmpereFactory {
		/// <summary>
        /// Create a quantity measured in GigaAmperes
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, GigaAmpere> GA<T>(this T value) {
            return new Quantity<T, GigaAmpere> (value);
        }
	}
}