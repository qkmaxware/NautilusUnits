namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the ZeptoLumen (zlm)
	/// </summary>
	public struct ZeptoLumen : ILuminosity {
        public static string Name => "ZeptoLumen";
        public static string Symbol => "zlm";
    }
	
	/// <summary>
	///Extension method factory for generating ZeptoLumen (zlm)
	/// </summary>
	public static class ZeptoLumenFactory {
		/// <summary>
        /// Create a quantity measured in ZeptoLumens
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZeptoLumen> zlm<T>(this T value) {
            return new Quantity<T, ZeptoLumen> (value);
        }
	}
}