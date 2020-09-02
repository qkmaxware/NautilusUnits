namespace Qkmaxware.Units.ElectricPotential {
	/// <summary>
	/// Unit of measurement for MilliVolt (mV)
	/// </summary>
	public struct MilliVolt : IElectricPotential {
        public static string Name => "MilliVolt";
        public static string Symbol => "mV";
    }
	
	/// <summary>
	/// Extension method factory for generating MilliVolt (mV)
	/// </summary>
	public static class MilliVoltFactory {
		/// <summary>
        /// Create a quantity measured in MilliVolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MilliVolt> mV<T>(this T value) {
            return new Quantity<T, MilliVolt> (value);
        }
	}
}