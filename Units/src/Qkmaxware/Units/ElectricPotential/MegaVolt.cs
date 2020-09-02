namespace Qkmaxware.Units.ElectricPotential {
	/// <summary>
	/// Unit of measurement for MegaVolt (MV)
	/// </summary>
	public struct MegaVolt : IElectricPotential {
        public static string Name => "MegaVolt";
        public static string Symbol => "MV";
    }
	
	/// <summary>
	/// Extension method factory for generating MegaVolt (MV)
	/// </summary>
	public static class MegaVoltFactory {
		/// <summary>
        /// Create a quantity measured in MegaVolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MegaVolt> MV<T>(this T value) {
            return new Quantity<T, MegaVolt> (value);
        }
	}
}