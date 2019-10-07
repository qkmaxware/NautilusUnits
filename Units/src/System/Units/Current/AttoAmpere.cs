namespace System.Units.Current {
	/// <summary>
	/// Unit of measurement for the AttoAmpere (aA)
	/// </summary>
	public struct AttoAmpere : ICurrent {
        public static string Name => "AttoAmpere";
        public static string Symbol => "aA";
    }
	
	public static class AttoAmpereFactory {
		/// <summary>
        /// Create a quantity measured in AttoAmperes
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, AttoAmpere> aA<T>(this T value) {
            return new Quantity<T, AttoAmpere> (value);
        }
	}
}