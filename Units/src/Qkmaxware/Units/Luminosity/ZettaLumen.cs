namespace Qkmaxware.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the ZettaLumen (Zlm)
	/// </summary>
	public struct ZettaLumen : ILuminosity {
        public static string Name => "ZettaLumen";
        public static string Symbol => "Zlm";
    }
	
	/// <summary>
	///Extension method factory for generating ZettaLumen (Zlm)
	/// </summary>
	public static class ZettaLumenFactory {
		/// <summary>
        /// Create a quantity measured in ZettaLumens
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZettaLumen> Zlm<T>(this T value) {
            return new Quantity<T, ZettaLumen> (value);
        }
	}
}