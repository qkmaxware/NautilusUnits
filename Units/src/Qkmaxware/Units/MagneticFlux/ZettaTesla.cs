namespace Qkmaxware.Units.MagneticFlux {
	/// <summary>
	/// Unit of measurement for the ZettaTesla (ZT)
	/// </summary>
	public struct ZettaTesla : IMagneticFlux {
        public static string Name => "ZettaTesla";
        public static string Symbol => "ZT";
    }
	
	/// <summary>
	///Extension method factory for generating ZettaTesla (ZT)
	/// </summary>
	public static class ZettaTeslaFactory {
		/// <summary>
        /// Create a quantity measured in ZettaTeslas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZettaTesla> ZT<T>(this T value) {
            return new Quantity<T, ZettaTesla> (value);
        }
	}
}