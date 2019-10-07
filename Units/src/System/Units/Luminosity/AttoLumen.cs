namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the AttoLumen (alm)
	/// </summary>
	public struct AttoLumen : ILuminosity {
        public static string Name => "AttoLumen";
        public static string Symbol => "alm";
    }
	
	public static class AttoLumenFactory {
		/// <summary>
        /// Create a quantity measured in AttoLumens
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, AttoLumen> alm<T>(this T value) {
            return new Quantity<T, AttoLumen> (value);
        }
	}
}