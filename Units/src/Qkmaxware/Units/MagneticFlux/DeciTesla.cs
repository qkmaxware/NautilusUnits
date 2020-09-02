namespace Qkmaxware.Units.MagneticFlux {
	/// <summary>
	/// Unit of measurement for DeciTesla (dT)
	/// </summary>
	public struct DeciTesla : IMagneticFlux {
        public static string Name => "DeciTesla";
        public static string Symbol => "dT";
    }
	
	/// <summary>
	/// Extension method factory for generating DeciTesla (dT)
	/// </summary>
	public static class DeciTeslaFactory {
		/// <summary>
        /// Create a quantity measured in DeciTeslas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DeciTesla> dT<T>(this T value) {
            return new Quantity<T, DeciTesla> (value);
        }
	}
}