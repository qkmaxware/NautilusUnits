namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the GigaLumen (Glm)
	/// </summary>
	public struct GigaLumen : ILuminosity {
        public static string Name => "GigaLumen";
        public static string Symbol => "Glm";
    }
	
	/// <summary>
	///Extension method factory for generating GigaLumen (Glm)
	/// </summary>
	public static class GigaLumenFactory {
		/// <summary>
        /// Create a quantity measured in GigaLumens
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, GigaLumen> Glm<T>(this T value) {
            return new Quantity<T, GigaLumen> (value);
        }
	}
}