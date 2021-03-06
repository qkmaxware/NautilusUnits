namespace Qkmaxware.Units.ElectricPotential {
	/// <summary>
	/// Unit of measurement for GigaVolt (GV)
	/// </summary>
	public struct GigaVolt : IElectricPotential {
        public static string Name => "GigaVolt";
        public static string Symbol => "GV";
    }
	
	/// <summary>
	/// Extension method factory for generating GigaVolt (GV)
	/// </summary>
	public static class GigaVoltFactory {
		/// <summary>
        /// Create a quantity measured in GigaVolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, GigaVolt> GV<T>(this T value) {
            return new Quantity<T, GigaVolt> (value);
        }
	}
}