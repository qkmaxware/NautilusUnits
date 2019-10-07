namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for the DeciMetre (dm)
	/// </summary>
	public struct DeciMetre : ILength {
        public static string Name => "DeciMetre";
        public static string Symbol => "dm";
    }
	
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