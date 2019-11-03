namespace System.Units.Current {
	/// <summary>
	/// Unit of measurement for the HectoAmpere (hA)
	/// </summary>
	public struct HectoAmpere : ICurrent {
        public static string Name => "HectoAmpere";
        public static string Symbol => "hA";
    }
	
	/// <summary>
	///Extension method factory for generating HectoAmpere (hA)
	/// </summary>
	public static class HectoAmpereFactory {
		/// <summary>
        /// Create a quantity measured in HectoAmperes
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, HectoAmpere> hA<T>(this T value) {
            return new Quantity<T, HectoAmpere> (value);
        }
	}
}