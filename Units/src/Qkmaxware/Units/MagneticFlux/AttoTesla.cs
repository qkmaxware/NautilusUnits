namespace Qkmaxware.Units.MagneticFlux {
	/// <summary>
	/// Unit of measurement for the AttoTesla (aT)
	/// </summary>
	public struct AttoTesla : IMagneticFlux {
        public static string Name => "AttoTesla";
        public static string Symbol => "aT";
    }
	
	/// <summary>
	///Extension method factory for generating AttoTesla (aT)
	/// </summary>
	public static class AttoTeslaFactory {
		/// <summary>
        /// Create a quantity measured in AttoTeslas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, AttoTesla> aT<T>(this T value) {
            return new Quantity<T, AttoTesla> (value);
        }
	}
}