namespace Qkmaxware.Units.Current {
	/// <summary>
	/// Unit of measurement for DeciAmpere (dA)
	/// </summary>
	public struct DeciAmpere : ICurrent {
        public static string Name => "DeciAmpere";
        public static string Symbol => "dA";
    }
	
	/// <summary>
	/// Extension method factory for generating DeciAmpere (dA)
	/// </summary>
	public static class DeciAmpereFactory {
		/// <summary>
        /// Create a quantity measured in DeciAmperes
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DeciAmpere> dA<T>(this T value) {
            return new Quantity<T, DeciAmpere> (value);
        }
	}
}