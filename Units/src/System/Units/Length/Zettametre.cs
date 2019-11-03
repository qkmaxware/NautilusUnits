namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for the ZettaMetre (Zm)
	/// </summary>
	public struct ZettaMetre : ILength {
        public static string Name => "ZettaMetre";
        public static string Symbol => "Zm";
    }
	
	/// <summary>
	///Extension method factory for generating ZettaMetre (Zm)
	/// </summary>
	public static class ZettaMetreFactory {
		/// <summary>
        /// Create a quantity measured in ZettaMetres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZettaMetre> Zm<T>(this T value) {
            return new Quantity<T, ZettaMetre> (value);
        }
	}
}