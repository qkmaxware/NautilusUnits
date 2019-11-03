namespace System.Units.ElectricPotential {
	/// <summary>
	/// Unit of measurement for the DeciVolt (dV)
	/// </summary>
	public struct DeciVolt : IElectricPotential {
        public static string Name => "DeciVolt";
        public static string Symbol => "dV";
    }
	
	/// <summary>
	///Extension method factory for generating DeciVolt (dV)
	/// </summary>
	public static class DeciVoltFactory {
		/// <summary>
        /// Create a quantity measured in DeciVolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DeciVolt> dV<T>(this T value) {
            return new Quantity<T, DeciVolt> (value);
        }
	}
}