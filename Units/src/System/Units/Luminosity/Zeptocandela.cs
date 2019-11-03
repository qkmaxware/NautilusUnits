namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the ZeptoCandela (zcd)
	/// </summary>
	public struct ZeptoCandela : ILuminosity {
        public static string Name => "ZeptoCandela";
        public static string Symbol => "zcd";
    }
	
	/// <summary>
	///Extension method factory for generating ZeptoCandela (zcd)
	/// </summary>
	public static class ZeptoCandelaFactory {
		/// <summary>
        /// Create a quantity measured in ZeptoCandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZeptoCandela> zcd<T>(this T value) {
            return new Quantity<T, ZeptoCandela> (value);
        }
	}
}