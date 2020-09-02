namespace Qkmaxware.Units.MagneticFlux {
	/// <summary>
	/// Unit of measurement for YottaTesla (YT)
	/// </summary>
	public struct YottaTesla : IMagneticFlux {
        public static string Name => "YottaTesla";
        public static string Symbol => "YT";
    }
	
	/// <summary>
	/// Extension method factory for generating YottaTesla (YT)
	/// </summary>
	public static class YottaTeslaFactory {
		/// <summary>
        /// Create a quantity measured in YottaTeslas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YottaTesla> YT<T>(this T value) {
            return new Quantity<T, YottaTesla> (value);
        }
	}
}