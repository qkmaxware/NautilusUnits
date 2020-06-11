namespace Qkmaxware.Units.Current {
	/// <summary>
	/// Unit of measurement for the CentiAmpere (cA)
	/// </summary>
	public struct CentiAmpere : ICurrent {
        public static string Name => "CentiAmpere";
        public static string Symbol => "cA";
    }
	
	/// <summary>
	///Extension method factory for generating CentiAmpere (cA)
	/// </summary>
	public static class CentiAmpereFactory {
		/// <summary>
        /// Create a quantity measured in CentiAmperes
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, CentiAmpere> cA<T>(this T value) {
            return new Quantity<T, CentiAmpere> (value);
        }
	}
}