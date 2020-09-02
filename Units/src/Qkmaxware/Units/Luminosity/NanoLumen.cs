namespace Qkmaxware.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for NanoLumen (nlm)
	/// </summary>
	public struct NanoLumen : ILuminosity {
        public static string Name => "NanoLumen";
        public static string Symbol => "nlm";
    }
	
	/// <summary>
	/// Extension method factory for generating NanoLumen (nlm)
	/// </summary>
	public static class NanoLumenFactory {
		/// <summary>
        /// Create a quantity measured in NanoLumens
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, NanoLumen> nlm<T>(this T value) {
            return new Quantity<T, NanoLumen> (value);
        }
	}
}