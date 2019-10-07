namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the NanoLumen (nlm)
	/// </summary>
	public struct NanoLumen : ILuminosity {
        public static string Name => "NanoLumen";
        public static string Symbol => "nlm";
    }
	
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