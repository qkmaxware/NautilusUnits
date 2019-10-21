namespace System.Units.ElectricPotential {
	/// <summary>
	/// Unit of measurement for the ExaVolt (EV)
	/// </summary>
	public struct ExaVolt : IElectricPotential {
        public static string Name => "ExaVolt";
        public static string Symbol => "EV";
    }
	
	public static class ExaVoltFactory {
		/// <summary>
        /// Create a quantity measured in ExaVolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ExaVolt> EV<T>(this T value) {
            return new Quantity<T, ExaVolt> (value);
        }
	}
}