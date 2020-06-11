namespace Qkmaxware.Units.MagneticFlux {
	/// <summary>
	/// Unit of measurement for the MegaTesla (MT)
	/// </summary>
	public struct MegaTesla : IMagneticFlux {
        public static string Name => "MegaTesla";
        public static string Symbol => "MT";
    }
	
	/// <summary>
	///Extension method factory for generating MegaTesla (MT)
	/// </summary>
	public static class MegaTeslaFactory {
		/// <summary>
        /// Create a quantity measured in MegaTeslas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MegaTesla> MT<T>(this T value) {
            return new Quantity<T, MegaTesla> (value);
        }
	}
}