namespace Qkmaxware.Units.MagneticFlux {
	/// <summary>
	/// Unit of measurement for CentiTesla (cT)
	/// </summary>
	public struct CentiTesla : IMagneticFlux {
        public static string Name => "CentiTesla";
        public static string Symbol => "cT";
    }
	
	/// <summary>
	/// Extension method factory for generating CentiTesla (cT)
	/// </summary>
	public static class CentiTeslaFactory {
		/// <summary>
        /// Create a quantity measured in CentiTeslas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, CentiTesla> cT<T>(this T value) {
            return new Quantity<T, CentiTesla> (value);
        }
	}
}