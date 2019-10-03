namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for Kilometre (km)
	/// </summary>
	public struct Kilometre : ILength {
        public static string Name => "Kilometre";
        public static string Symbol => "km";
    }
	
	public static class KilometreFactory {
		/// <summary>
        /// Create a quantity measured in Kilometres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Kilometre> km<T>(this T value) {
            return value.As<Kilometre, T>();
        }
	}
}