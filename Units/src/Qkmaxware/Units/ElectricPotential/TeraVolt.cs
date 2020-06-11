namespace Qkmaxware.Units.ElectricPotential {
	/// <summary>
	/// Unit of measurement for the TeraVolt (TV)
	/// </summary>
	public struct TeraVolt : IElectricPotential {
        public static string Name => "TeraVolt";
        public static string Symbol => "TV";
    }
	
	/// <summary>
	///Extension method factory for generating TeraVolt (TV)
	/// </summary>
	public static class TeraVoltFactory {
		/// <summary>
        /// Create a quantity measured in TeraVolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, TeraVolt> TV<T>(this T value) {
            return new Quantity<T, TeraVolt> (value);
        }
	}
}