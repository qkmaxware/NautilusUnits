namespace Qkmaxware.Units.Length {
	/// <summary>
	/// Unit of measurement for AttoMetre (am)
	/// </summary>
	public struct AttoMetre : ILength {
        public static string Name => "AttoMetre";
        public static string Symbol => "am";
    }
	
	/// <summary>
	/// Extension method factory for generating AttoMetre (am)
	/// </summary>
	public static class AttoMetreFactory {
		/// <summary>
        /// Create a quantity measured in AttoMetres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, AttoMetre> am<T>(this T value) {
            return new Quantity<T, AttoMetre> (value);
        }
	}
}