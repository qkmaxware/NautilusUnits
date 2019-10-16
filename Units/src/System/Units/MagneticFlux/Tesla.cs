namespace System.Units.MagneticFlux {
	/// <summary>
	/// Unit of measurement for the Tesla (T)
	/// </summary>
	public struct Tesla : IMagneticFlux {
        public static string Name => "Tesla";
        public static string Symbol => "T";
    }
	
	public static class TeslaFactory {
		/// <summary>
        /// Create a quantity measured in Teslas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Tesla> T<T>(this T value) {
            return new Quantity<T, Tesla> (value);
        }
	}
}