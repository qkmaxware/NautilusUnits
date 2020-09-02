namespace Qkmaxware.Units.Length {
	/// <summary>
	/// Unit of measurement for DeciMetre (dm)
	/// </summary>
	public struct DeciMetre : ILength {
        public static string Name => "DeciMetre";
        public static string Symbol => "dm";
    }
	
	/// <summary>
	/// Extension method factory for generating DeciMetre (dm)
	/// </summary>
	public static class DeciMetreFactory {
		/// <summary>
        /// Create a quantity measured in DeciMetres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DeciMetre> dm<T>(this T value) {
            return new Quantity<T, DeciMetre> (value);
        }
	}
}