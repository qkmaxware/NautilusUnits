namespace System.Units.Current {
	/// <summary>
	/// Unit of measurement for the PicoAmpere (pA)
	/// </summary>
	public struct PicoAmpere : ICurrent {
        public static string Name => "PicoAmpere";
        public static string Symbol => "pA";
    }
	
	/// <summary>
	///Extension method factory for generating PicoAmpere (pA)
	/// </summary>
	public static class PicoAmpereFactory {
		/// <summary>
        /// Create a quantity measured in PicoAmperes
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PicoAmpere> pA<T>(this T value) {
            return new Quantity<T, PicoAmpere> (value);
        }
	}
}