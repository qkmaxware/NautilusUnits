namespace Qkmaxware.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for KiloLumen (klm)
	/// </summary>
	public struct KiloLumen : ILuminosity {
        public static string Name => "KiloLumen";
        public static string Symbol => "klm";
    }
	
	/// <summary>
	/// Extension method factory for generating KiloLumen (klm)
	/// </summary>
	public static class KiloLumenFactory {
		/// <summary>
        /// Create a quantity measured in KiloLumens
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, KiloLumen> klm<T>(this T value) {
            return new Quantity<T, KiloLumen> (value);
        }
	}
}