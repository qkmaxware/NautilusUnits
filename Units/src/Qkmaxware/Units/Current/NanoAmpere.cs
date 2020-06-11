namespace Qkmaxware.Units.Current {
	/// <summary>
	/// Unit of measurement for the NanoAmpere (nA)
	/// </summary>
	public struct NanoAmpere : ICurrent {
        public static string Name => "NanoAmpere";
        public static string Symbol => "nA";
    }
	
	/// <summary>
	///Extension method factory for generating NanoAmpere (nA)
	/// </summary>
	public static class NanoAmpereFactory {
		/// <summary>
        /// Create a quantity measured in NanoAmperes
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, NanoAmpere> nA<T>(this T value) {
            return new Quantity<T, NanoAmpere> (value);
        }
	}
}