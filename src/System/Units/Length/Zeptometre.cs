namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for Zeptometre (zm)
	/// </summary>
	public struct Zeptometre : ILength {
        public static string Name => "Zeptometre";
        public static string Symbol => "zm";
    }
	
	public static class ZeptometreFactory {
		/// <summary>
        /// Create a quantity measured in Zeptometres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Zeptometre> zm<T>(this T value) {
            return value.As<T, Zeptometre>();
        }
	}
}