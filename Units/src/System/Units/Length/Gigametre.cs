namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for Gigametre (Gm)
	/// </summary>
	public struct Gigametre : ILength {
        public static string Name => "Gigametre";
        public static string Symbol => "Gm";
    }
	
	public static class GigametreFactory {
		/// <summary>
        /// Create a quantity measured in Gigametres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Gigametre> Gm<T>(this T value) {
            return value.As<Gigametre, T>();
        }
	}
}