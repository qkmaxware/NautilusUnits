namespace System.Units.MagneticFlux {
	/// <summary>
	/// Unit of measurement for the GigaTesla (GT)
	/// </summary>
	public struct GigaTesla : IMagneticFlux {
        public static string Name => "GigaTesla";
        public static string Symbol => "GT";
    }
	
	public static class GigaTeslaFactory {
		/// <summary>
        /// Create a quantity measured in GigaTeslas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, GigaTesla> GT<T>(this T value) {
            return new Quantity<T, GigaTesla> (value);
        }
	}
}