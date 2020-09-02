namespace Qkmaxware.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for MegaLumen (Mlm)
	/// </summary>
	public struct MegaLumen : ILuminosity {
        public static string Name => "MegaLumen";
        public static string Symbol => "Mlm";
    }
	
	/// <summary>
	/// Extension method factory for generating MegaLumen (Mlm)
	/// </summary>
	public static class MegaLumenFactory {
		/// <summary>
        /// Create a quantity measured in MegaLumens
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MegaLumen> Mlm<T>(this T value) {
            return new Quantity<T, MegaLumen> (value);
        }
	}
}