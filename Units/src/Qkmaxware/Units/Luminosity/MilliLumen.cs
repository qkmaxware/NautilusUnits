namespace Qkmaxware.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for MilliLumen (mlm)
	/// </summary>
	public struct MilliLumen : ILuminosity {
        public static string Name => "MilliLumen";
        public static string Symbol => "mlm";
    }
	
	/// <summary>
	/// Extension method factory for generating MilliLumen (mlm)
	/// </summary>
	public static class MilliLumenFactory {
		/// <summary>
        /// Create a quantity measured in MilliLumens
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MilliLumen> mlm<T>(this T value) {
            return new Quantity<T, MilliLumen> (value);
        }
	}
}