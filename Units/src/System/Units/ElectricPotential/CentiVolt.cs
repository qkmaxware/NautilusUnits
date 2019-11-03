namespace System.Units.ElectricPotential {
	/// <summary>
	/// Unit of measurement for the CentiVolt (cV)
	/// </summary>
	public struct CentiVolt : IElectricPotential {
        public static string Name => "CentiVolt";
        public static string Symbol => "cV";
    }
	
	/// <summary>
	///Extension method factory for generating CentiVolt (cV)
	/// </summary>
	public static class CentiVoltFactory {
		/// <summary>
        /// Create a quantity measured in CentiVolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, CentiVolt> cV<T>(this T value) {
            return new Quantity<T, CentiVolt> (value);
        }
	}
}