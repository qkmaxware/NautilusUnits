namespace System.Units.MagneticFlux {
	/// <summary>
	/// Unit of measurement for the PicoTesla (pT)
	/// </summary>
	public struct PicoTesla : IMagneticFlux {
        public static string Name => "PicoTesla";
        public static string Symbol => "pT";
    }
	
	/// <summary>
	///Extension method factory for generating PicoTesla (pT)
	/// </summary>
	public static class PicoTeslaFactory {
		/// <summary>
        /// Create a quantity measured in PicoTeslas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PicoTesla> pT<T>(this T value) {
            return new Quantity<T, PicoTesla> (value);
        }
	}
}