namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for Zettametre (Zm)
	/// </summary>
	public struct Zettametre : ILength {
        public static string Name => "Zettametre";
        public static string Symbol => "Zm";
    }
	
	public static class ZettametreFactory {
		/// <summary>
        /// Create a quantity measured in Zettametres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Zettametre> Zm<T>(this T value) {
            return value.As<T, Zettametre>();
        }
	}
}