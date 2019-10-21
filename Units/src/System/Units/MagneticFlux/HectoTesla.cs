namespace System.Units.MagneticFlux {
	/// <summary>
	/// Unit of measurement for the HectoTesla (hT)
	/// </summary>
	public struct HectoTesla : IMagneticFlux {
        public static string Name => "HectoTesla";
        public static string Symbol => "hT";
    }
	
	public static class HectoTeslaFactory {
		/// <summary>
        /// Create a quantity measured in HectoTeslas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, HectoTesla> hT<T>(this T value) {
            return new Quantity<T, HectoTesla> (value);
        }
	}
}