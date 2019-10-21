namespace System.Units.MagneticFlux {
	/// <summary>
	/// Unit of measurement for the YottaTesla (YT)
	/// </summary>
	public struct YottaTesla : IMagneticFlux {
        public static string Name => "YottaTesla";
        public static string Symbol => "YT";
    }
	
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