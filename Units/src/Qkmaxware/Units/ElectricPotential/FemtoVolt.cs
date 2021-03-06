namespace Qkmaxware.Units.ElectricPotential {
	/// <summary>
	/// Unit of measurement for FemtoVolt (fV)
	/// </summary>
	public struct FemtoVolt : IElectricPotential {
        public static string Name => "FemtoVolt";
        public static string Symbol => "fV";
    }
	
	/// <summary>
	/// Extension method factory for generating FemtoVolt (fV)
	/// </summary>
	public static class FemtoVoltFactory {
		/// <summary>
        /// Create a quantity measured in FemtoVolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, FemtoVolt> fV<T>(this T value) {
            return new Quantity<T, FemtoVolt> (value);
        }
	}
}