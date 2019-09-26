namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for Centimetre (cm)
	/// </summary>
	public struct Centimetre : ILength {
        public static string Name => "Centimetre";
        public static string Symbol => "cm";
    }
	
	public static class CentimetreFactory {
		/// <summary>
        /// Create a quantity measured in Centimetres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Centimetre> cm<T>(this T value) {
            return value.As<T, Centimetre>();
        }
	}
}