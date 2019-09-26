namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for Gigacandela (Gcd)
	/// </summary>
	public struct Gigacandela : ILuminosity {
        public static string Name => "Gigacandela";
        public static string Symbol => "Gcd";
    }
	
	public static class GigacandelaFactory {
		/// <summary>
        /// Create a quantity measured in Gigacandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Gigacandela> Gcd<T>(this T value) {
            return value.As<T, Gigacandela>();
        }
	}
}