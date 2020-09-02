namespace Qkmaxware.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for DeciLumen (dlm)
	/// </summary>
	public struct DeciLumen : ILuminosity {
        public static string Name => "DeciLumen";
        public static string Symbol => "dlm";
    }
	
	/// <summary>
	/// Extension method factory for generating DeciLumen (dlm)
	/// </summary>
	public static class DeciLumenFactory {
		/// <summary>
        /// Create a quantity measured in DeciLumens
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DeciLumen> dlm<T>(this T value) {
            return new Quantity<T, DeciLumen> (value);
        }
	}
}