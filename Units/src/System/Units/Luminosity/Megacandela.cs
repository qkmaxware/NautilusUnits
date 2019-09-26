namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for Megacandela (Mcd)
	/// </summary>
	public struct Megacandela : ILuminosity {
        public static string Name => "Megacandela";
        public static string Symbol => "Mcd";
    }
	
	public static class MegacandelaFactory {
		/// <summary>
        /// Create a quantity measured in Megacandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Megacandela> Mcd<T>(this T value) {
            return value.As<T, Megacandela>();
        }
	}
}