namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for the ZeptoMetre (zm)
	/// </summary>
	public struct ZeptoMetre : ILength {
        public static string Name => "ZeptoMetre";
        public static string Symbol => "zm";
    }
	
	public static class ZeptoMetreFactory {
		/// <summary>
        /// Create a quantity measured in ZeptoMetres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZeptoMetre> zm<T>(this T value) {
            return new Quantity<T, ZeptoMetre> (value);
        }
	}
}