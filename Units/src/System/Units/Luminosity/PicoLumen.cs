namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the PicoLumen (plm)
	/// </summary>
	public struct PicoLumen : ILuminosity {
        public static string Name => "PicoLumen";
        public static string Symbol => "plm";
    }
	
	/// <summary>
	///Extension method factory for generating PicoLumen (plm)
	/// </summary>
	public static class PicoLumenFactory {
		/// <summary>
        /// Create a quantity measured in PicoLumens
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PicoLumen> plm<T>(this T value) {
            return new Quantity<T, PicoLumen> (value);
        }
	}
}