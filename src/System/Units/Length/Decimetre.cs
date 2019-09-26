namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for Decimetre (dm)
	/// </summary>
	public struct Decimetre : ILength {
        public static string Name => "Decimetre";
        public static string Symbol => "dm";
    }
	
	public static class DecimetreFactory {
		/// <summary>
        /// Create a quantity measured in Decimetres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Decimetre> dm<T>(this T value) {
            return value.As<T, Decimetre>();
        }
	}
}