namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for the GigaMetre (Gm)
	/// </summary>
	public struct GigaMetre : ILength {
        public static string Name => "GigaMetre";
        public static string Symbol => "Gm";
    }
	
	/// <summary>
	///Extension method factory for generating GigaMetre (Gm)
	/// </summary>
	public static class GigaMetreFactory {
		/// <summary>
        /// Create a quantity measured in GigaMetres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, GigaMetre> Gm<T>(this T value) {
            return new Quantity<T, GigaMetre> (value);
        }
	}
}