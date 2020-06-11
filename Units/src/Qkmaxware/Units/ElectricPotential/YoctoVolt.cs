namespace Qkmaxware.Units.ElectricPotential {
	/// <summary>
	/// Unit of measurement for the YoctoVolt (yV)
	/// </summary>
	public struct YoctoVolt : IElectricPotential {
        public static string Name => "YoctoVolt";
        public static string Symbol => "yV";
    }
	
	/// <summary>
	///Extension method factory for generating YoctoVolt (yV)
	/// </summary>
	public static class YoctoVoltFactory {
		/// <summary>
        /// Create a quantity measured in YoctoVolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YoctoVolt> yV<T>(this T value) {
            return new Quantity<T, YoctoVolt> (value);
        }
	}
}