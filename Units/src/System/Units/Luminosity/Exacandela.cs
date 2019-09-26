namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for Exacandela (Ecd)
	/// </summary>
	public struct Exacandela : ILuminosity {
        public static string Name => "Exacandela";
        public static string Symbol => "Ecd";
    }
	
	public static class ExacandelaFactory {
		/// <summary>
        /// Create a quantity measured in Exacandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Exacandela> Ecd<T>(this T value) {
            return value.As<T, Exacandela>();
        }
	}
}