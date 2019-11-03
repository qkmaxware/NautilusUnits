namespace System.Units.MagneticFlux {
	/// <summary>
	/// Unit of measurement for the NanoTesla (nT)
	/// </summary>
	public struct NanoTesla : IMagneticFlux {
        public static string Name => "NanoTesla";
        public static string Symbol => "nT";
    }
	
	/// <summary>
	///Extension method factory for generating NanoTesla (nT)
	/// </summary>
	public static class NanoTeslaFactory {
		/// <summary>
        /// Create a quantity measured in NanoTeslas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, NanoTesla> nT<T>(this T value) {
            return new Quantity<T, NanoTesla> (value);
        }
	}
}