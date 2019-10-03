namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for Zeptocandela (zcd)
	/// </summary>
	public struct Zeptocandela : ILuminosity {
        public static string Name => "Zeptocandela";
        public static string Symbol => "zcd";
    }
	
	public static class ZeptocandelaFactory {
		/// <summary>
        /// Create a quantity measured in Zeptocandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Zeptocandela> zcd<T>(this T value) {
            return value.As<Zeptocandela, T>();
        }
	}
}