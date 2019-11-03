namespace System.Units.ElectricPotential {
	/// <summary>
	/// Unit of measurement for the KiloVolt (kV)
	/// </summary>
	public struct KiloVolt : IElectricPotential {
        public static string Name => "KiloVolt";
        public static string Symbol => "kV";
    }
	
	/// <summary>
	///Extension method factory for generating KiloVolt (kV)
	/// </summary>
	public static class KiloVoltFactory {
		/// <summary>
        /// Create a quantity measured in KiloVolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, KiloVolt> kV<T>(this T value) {
            return new Quantity<T, KiloVolt> (value);
        }
	}
}