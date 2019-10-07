namespace System.Units.Current {
	/// <summary>
	/// Unit of measurement for the ZettaAmpere (ZA)
	/// </summary>
	public struct ZettaAmpere : ICurrent {
        public static string Name => "ZettaAmpere";
        public static string Symbol => "ZA";
    }
	
	public static class ZettaAmpereFactory {
		/// <summary>
        /// Create a quantity measured in ZettaAmperes
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZettaAmpere> ZA<T>(this T value) {
            return new Quantity<T, ZettaAmpere> (value);
        }
	}
}