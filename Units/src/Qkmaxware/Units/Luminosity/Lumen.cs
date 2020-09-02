namespace Qkmaxware.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for Lumen (lm)
	/// </summary>
	public struct Lumen : ILuminosity {
        public static string Name => "Lumen";
        public static string Symbol => "lm";
    }
	
	/// <summary>
	/// Extension method factory for generating Lumen (lm)
	/// </summary>
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