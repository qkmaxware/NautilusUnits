namespace System.Units.ElectricPotential {
	/// <summary>
	/// Unit of measurement for the ZettaVolt (ZV)
	/// </summary>
	public struct ZettaVolt : IElectricPotential {
        public static string Name => "ZettaVolt";
        public static string Symbol => "ZV";
    }
	
	/// <summary>
	///Extension method factory for generating ZettaVolt (ZV)
	/// </summary>
	public static class ZettaVoltFactory {
		/// <summary>
        /// Create a quantity measured in ZettaVolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZettaVolt> ZV<T>(this T value) {
            return new Quantity<T, ZettaVolt> (value);
        }
	}
}