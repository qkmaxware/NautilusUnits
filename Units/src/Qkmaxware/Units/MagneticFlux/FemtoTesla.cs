namespace Qkmaxware.Units.MagneticFlux {
	/// <summary>
	/// Unit of measurement for FemtoTesla (fT)
	/// </summary>
	public struct FemtoTesla : IMagneticFlux {
        public static string Name => "FemtoTesla";
        public static string Symbol => "fT";
    }
	
	/// <summary>
	/// Extension method factory for generating FemtoTesla (fT)
	/// </summary>
	public static class FemtoTeslaFactory {
		/// <summary>
        /// Create a quantity measured in FemtoTeslas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, FemtoTesla> fT<T>(this T value) {
            return new Quantity<T, FemtoTesla> (value);
        }
	}
}