namespace System.Units.MagneticFlux {
	/// <summary>
	/// Unit of measurement for the CentiTesla (cT)
	/// </summary>
	public struct CentiTesla : IMagneticFlux {
        public static string Name => "CentiTesla";
        public static string Symbol => "cT";
    }
	
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