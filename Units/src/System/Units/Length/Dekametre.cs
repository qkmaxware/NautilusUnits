namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for Dekametre (dam)
	/// </summary>
	public struct Dekametre : ILength {
        public static string Name => "Dekametre";
        public static string Symbol => "dam";
    }
	
	public static class DekametreFactory {
		/// <summary>
        /// Create a quantity measured in Dekametres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Dekametre> dam<T>(this T value) {
            return value.As<T, Dekametre>();
        }
	}
}