namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for Terametre (Tm)
	/// </summary>
	public struct Terametre : ILength {
        public static string Name => "Terametre";
        public static string Symbol => "Tm";
    }
	
	public static class TerametreFactory {
		/// <summary>
        /// Create a quantity measured in Terametres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Terametre> Tm<T>(this T value) {
            return value.As<Terametre, T>();
        }
	}
}