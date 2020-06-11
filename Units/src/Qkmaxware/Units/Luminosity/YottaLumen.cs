namespace Qkmaxware.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the YottaLumen (Ylm)
	/// </summary>
	public struct YottaLumen : ILuminosity {
        public static string Name => "YottaLumen";
        public static string Symbol => "Ylm";
    }
	
	/// <summary>
	///Extension method factory for generating YottaLumen (Ylm)
	/// </summary>
	public static class YottaLumenFactory {
		/// <summary>
        /// Create a quantity measured in YottaLumens
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YottaLumen> Ylm<T>(this T value) {
            return new Quantity<T, YottaLumen> (value);
        }
	}
}