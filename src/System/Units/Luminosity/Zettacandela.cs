namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for Zettacandela (Zcd)
	/// </summary>
	public struct Zettacandela : ILuminosity {
        public static string Name => "Zettacandela";
        public static string Symbol => "Zcd";
    }
	
	public static class ZettacandelaFactory {
		/// <summary>
        /// Create a quantity measured in Zettacandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Zettacandela> Zcd<T>(this T value) {
            return value.As<T, Zettacandela>();
        }
	}
}