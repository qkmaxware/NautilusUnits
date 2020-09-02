namespace Qkmaxware.Units.Length {
	/// <summary>
	/// Unit of measurement for YottaMetre (Ym)
	/// </summary>
	public struct YottaMetre : ILength {
        public static string Name => "YottaMetre";
        public static string Symbol => "Ym";
    }
	
	/// <summary>
	/// Extension method factory for generating YottaMetre (Ym)
	/// </summary>
	public static class YottaMetreFactory {
		/// <summary>
        /// Create a quantity measured in YottaMetres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YottaMetre> Ym<T>(this T value) {
            return new Quantity<T, YottaMetre> (value);
        }
	}
}