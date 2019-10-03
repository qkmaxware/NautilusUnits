namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for Picometre (pm)
	/// </summary>
	public struct Picometre : ILength {
        public static string Name => "Picometre";
        public static string Symbol => "pm";
    }
	
	public static class PicometreFactory {
		/// <summary>
        /// Create a quantity measured in Picometres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Picometre> pm<T>(this T value) {
            return value.As<Picometre, T>();
        }
	}
}