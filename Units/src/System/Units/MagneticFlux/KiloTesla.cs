namespace System.Units.MagneticFlux {
	/// <summary>
	/// Unit of measurement for the KiloTesla (kT)
	/// </summary>
	public struct KiloTesla : IMagneticFlux {
        public static string Name => "KiloTesla";
        public static string Symbol => "kT";
    }
	
	public static class KiloTeslaFactory {
		/// <summary>
        /// Create a quantity measured in KiloTeslas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, KiloTesla> kT<T>(this T value) {
            return new Quantity<T, KiloTesla> (value);
        }
	}
}