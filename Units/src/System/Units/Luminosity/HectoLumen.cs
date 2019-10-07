namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the HectoLumen (hlm)
	/// </summary>
	public struct HectoLumen : ILuminosity {
        public static string Name => "HectoLumen";
        public static string Symbol => "hlm";
    }
	
	public static class HectoLumenFactory {
		/// <summary>
        /// Create a quantity measured in HectoLumens
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, HectoLumen> hlm<T>(this T value) {
            return new Quantity<T, HectoLumen> (value);
        }
	}
}