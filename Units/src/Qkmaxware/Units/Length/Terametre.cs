namespace Qkmaxware.Units.Length {
	/// <summary>
	/// Unit of measurement for the TeraMetre (Tm)
	/// </summary>
	public struct TeraMetre : ILength {
        public static string Name => "TeraMetre";
        public static string Symbol => "Tm";
    }
	
	/// <summary>
	///Extension method factory for generating TeraMetre (Tm)
	/// </summary>
	public static class TeraMetreFactory {
		/// <summary>
        /// Create a quantity measured in TeraMetres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, TeraMetre> Tm<T>(this T value) {
            return new Quantity<T, TeraMetre> (value);
        }
	}
}