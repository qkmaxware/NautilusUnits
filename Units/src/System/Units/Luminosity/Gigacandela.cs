namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the GigaCandela (Gcd)
	/// </summary>
	public struct GigaCandela : ILuminosity {
        public static string Name => "GigaCandela";
        public static string Symbol => "Gcd";
    }
	
	/// <summary>
	///Extension method factory for generating GigaCandela (Gcd)
	/// </summary>
	public static class GigaCandelaFactory {
		/// <summary>
        /// Create a quantity measured in GigaCandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, GigaCandela> Gcd<T>(this T value) {
            return new Quantity<T, GigaCandela> (value);
        }
	}
}