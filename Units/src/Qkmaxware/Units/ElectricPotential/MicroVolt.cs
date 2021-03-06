namespace Qkmaxware.Units.ElectricPotential {
	/// <summary>
	/// Unit of measurement for MicroVolt (uV)
	/// </summary>
	public struct MicroVolt : IElectricPotential {
        public static string Name => "MicroVolt";
        public static string Symbol => "uV";
    }
	
	/// <summary>
	/// Extension method factory for generating MicroVolt (uV)
	/// </summary>
	public static class MicroVoltFactory {
		/// <summary>
        /// Create a quantity measured in MicroVolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MicroVolt> uV<T>(this T value) {
            return new Quantity<T, MicroVolt> (value);
        }
	}
}