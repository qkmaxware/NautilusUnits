namespace Qkmaxware.Units.Current {
	/// <summary>
	/// Unit of measurement for ZeptoAmpere (zA)
	/// </summary>
	public struct ZeptoAmpere : ICurrent {
        public static string Name => "ZeptoAmpere";
        public static string Symbol => "zA";
    }
	
	/// <summary>
	/// Extension method factory for generating ZeptoAmpere (zA)
	/// </summary>
	public static class ZeptoAmpereFactory {
		/// <summary>
        /// Create a quantity measured in ZeptoAmperes
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZeptoAmpere> zA<T>(this T value) {
            return new Quantity<T, ZeptoAmpere> (value);
        }
	}
}