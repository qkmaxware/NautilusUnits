namespace Qkmaxware.Units.Length {
	/// <summary>
	/// Unit of measurement for PicoMetre (pm)
	/// </summary>
	public struct PicoMetre : ILength {
        public static string Name => "PicoMetre";
        public static string Symbol => "pm";
    }
	
	/// <summary>
	/// Extension method factory for generating PicoMetre (pm)
	/// </summary>
	public static class PicoMetreFactory {
		/// <summary>
        /// Create a quantity measured in PicoMetres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PicoMetre> pm<T>(this T value) {
            return new Quantity<T, PicoMetre> (value);
        }
	}
}