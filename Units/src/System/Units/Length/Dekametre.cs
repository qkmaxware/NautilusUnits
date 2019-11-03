namespace System.Units.Length {
	/// <summary>
	/// Unit of measurement for the DekaMetre (dam)
	/// </summary>
	public struct DekaMetre : ILength {
        public static string Name => "DekaMetre";
        public static string Symbol => "dam";
    }
	
	/// <summary>
	///Extension method factory for generating DekaMetre (dam)
	/// </summary>
	public static class DekaMetreFactory {
		/// <summary>
        /// Create a quantity measured in DekaMetres
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DekaMetre> dam<T>(this T value) {
            return new Quantity<T, DekaMetre> (value);
        }
	}
}