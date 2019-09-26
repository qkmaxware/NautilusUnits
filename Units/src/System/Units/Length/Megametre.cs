namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for Megametre (Mm)
	/// </summary>
	public struct Megametre : ILength {
        public static string Name => "Megametre";
        public static string Symbol => "Mm";
    }
	
	public static class MegametreFactory {
		/// <summary>
        /// Create a quantity measured in Megametres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Megametre> Mm<T>(this T value) {
            return value.As<T, Megametre>();
        }
	}
}