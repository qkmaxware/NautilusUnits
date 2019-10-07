namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the Lumen (lm)
	/// </summary>
	public struct Lumen : ILuminosity {
        public static string Name => "Lumen";
        public static string Symbol => "lm";
    }
	
	public static class LumenFactory {
		/// <summary>
        /// Create a quantity measured in Lumens
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Lumen> lm<T>(this T value) {
            return new Quantity<T, Lumen> (value);
        }
	}
}