namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for Dekacandela (dacd)
	/// </summary>
	public struct Dekacandela : ILuminosity {
        public static string Name => "Dekacandela";
        public static string Symbol => "dacd";
    }
	
	public static class DekacandelaFactory {
		/// <summary>
        /// Create a quantity measured in Dekacandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Dekacandela> dacd<T>(this T value) {
            return value.As<T, Dekacandela>();
        }
	}
}