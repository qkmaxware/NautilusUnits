namespace System.Units.ElectricPotential {
	/// <summary>
	/// Unit of measurement for the YottaVolt (YV)
	/// </summary>
	public struct YottaVolt : IElectricPotential {
        public static string Name => "YottaVolt";
        public static string Symbol => "YV";
    }
	
	public static class YottaVoltFactory {
		/// <summary>
        /// Create a quantity measured in YottaVolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YottaVolt> YV<T>(this T value) {
            return new Quantity<T, YottaVolt> (value);
        }
	}
}