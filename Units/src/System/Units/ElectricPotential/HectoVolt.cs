namespace System.Units.ElectricPotential {
	/// <summary>
	/// Unit of measurement for the HectoVolt (hV)
	/// </summary>
	public struct HectoVolt : IElectricPotential {
        public static string Name => "HectoVolt";
        public static string Symbol => "hV";
    }
	
	/// <summary>
	///Extension method factory for generating HectoVolt (hV)
	/// </summary>
	public static class HectoVoltFactory {
		/// <summary>
        /// Create a quantity measured in HectoVolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, HectoVolt> hV<T>(this T value) {
            return new Quantity<T, HectoVolt> (value);
        }
	}
}