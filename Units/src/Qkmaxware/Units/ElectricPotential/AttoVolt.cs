namespace Qkmaxware.Units.ElectricPotential {
	/// <summary>
	/// Unit of measurement for the AttoVolt (aV)
	/// </summary>
	public struct AttoVolt : IElectricPotential {
        public static string Name => "AttoVolt";
        public static string Symbol => "aV";
    }
	
	/// <summary>
	///Extension method factory for generating AttoVolt (aV)
	/// </summary>
	public static class AttoVoltFactory {
		/// <summary>
        /// Create a quantity measured in AttoVolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, AttoVolt> aV<T>(this T value) {
            return new Quantity<T, AttoVolt> (value);
        }
	}
}