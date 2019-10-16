namespace System.Units.MagneticFlux {
	/// <summary>
	/// Unit of measurement for the TeraTesla (TT)
	/// </summary>
	public struct TeraTesla : IMagneticFlux {
        public static string Name => "TeraTesla";
        public static string Symbol => "TT";
    }
	
	public static class TeraTeslaFactory {
		/// <summary>
        /// Create a quantity measured in TeraTeslas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, TeraTesla> TT<T>(this T value) {
            return new Quantity<T, TeraTesla> (value);
        }
	}
}