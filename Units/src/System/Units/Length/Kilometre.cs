namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for the KiloMetre (km)
	/// </summary>
	public struct KiloMetre : ILength {
        public static string Name => "KiloMetre";
        public static string Symbol => "km";
    }
	
	/// <summary>
	///Extension method factory for generating KiloMetre (km)
	/// </summary>
	public static class KiloMetreFactory {
		/// <summary>
        /// Create a quantity measured in KiloMetres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, KiloMetre> km<T>(this T value) {
            return new Quantity<T, KiloMetre> (value);
        }
	}
}