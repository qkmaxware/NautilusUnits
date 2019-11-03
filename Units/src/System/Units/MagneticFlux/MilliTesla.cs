namespace System.Units.MagneticFlux {
	/// <summary>
	/// Unit of measurement for the MilliTesla (mT)
	/// </summary>
	public struct MilliTesla : IMagneticFlux {
        public static string Name => "MilliTesla";
        public static string Symbol => "mT";
    }
	
	/// <summary>
	///Extension method factory for generating MilliTesla (mT)
	/// </summary>
	public static class MilliTeslaFactory {
		/// <summary>
        /// Create a quantity measured in MilliTeslas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MilliTesla> mT<T>(this T value) {
            return new Quantity<T, MilliTesla> (value);
        }
	}
}