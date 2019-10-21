namespace System.Units.MagneticFlux {
	/// <summary>
	/// Unit of measurement for the MicroTesla (uT)
	/// </summary>
	public struct MicroTesla : IMagneticFlux {
        public static string Name => "MicroTesla";
        public static string Symbol => "uT";
    }
	
	public static class MicroTeslaFactory {
		/// <summary>
        /// Create a quantity measured in MicroTeslas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MicroTesla> uT<T>(this T value) {
            return new Quantity<T, MicroTesla> (value);
        }
	}
}