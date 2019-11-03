namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the MicroLumen (ulm)
	/// </summary>
	public struct MicroLumen : ILuminosity {
        public static string Name => "MicroLumen";
        public static string Symbol => "ulm";
    }
	
	/// <summary>
	///Extension method factory for generating MicroLumen (ulm)
	/// </summary>
	public static class MicroLumenFactory {
		/// <summary>
        /// Create a quantity measured in MicroLumens
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MicroLumen> ulm<T>(this T value) {
            return new Quantity<T, MicroLumen> (value);
        }
	}
}