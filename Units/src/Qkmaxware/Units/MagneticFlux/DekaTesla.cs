namespace Qkmaxware.Units.MagneticFlux {
	/// <summary>
	/// Unit of measurement for the DekaTesla (daT)
	/// </summary>
	public struct DekaTesla : IMagneticFlux {
        public static string Name => "DekaTesla";
        public static string Symbol => "daT";
    }
	
	/// <summary>
	///Extension method factory for generating DekaTesla (daT)
	/// </summary>
	public static class DekaTeslaFactory {
		/// <summary>
        /// Create a quantity measured in DekaTeslas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DekaTesla> daT<T>(this T value) {
            return new Quantity<T, DekaTesla> (value);
        }
	}
}