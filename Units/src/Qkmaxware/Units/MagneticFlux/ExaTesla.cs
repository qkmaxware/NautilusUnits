namespace Qkmaxware.Units.MagneticFlux {
	/// <summary>
	/// Unit of measurement for the ExaTesla (ET)
	/// </summary>
	public struct ExaTesla : IMagneticFlux {
        public static string Name => "ExaTesla";
        public static string Symbol => "ET";
    }
	
	/// <summary>
	///Extension method factory for generating ExaTesla (ET)
	/// </summary>
	public static class ExaTeslaFactory {
		/// <summary>
        /// Create a quantity measured in ExaTeslas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ExaTesla> ET<T>(this T value) {
            return new Quantity<T, ExaTesla> (value);
        }
	}
}