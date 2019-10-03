namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for Yottacandela (Ycd)
	/// </summary>
	public struct Yottacandela : ILuminosity {
        public static string Name => "Yottacandela";
        public static string Symbol => "Ycd";
    }
	
	public static class YottacandelaFactory {
		/// <summary>
        /// Create a quantity measured in Yottacandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Yottacandela> Ycd<T>(this T value) {
            return value.As<Yottacandela, T>();
        }
	}
}