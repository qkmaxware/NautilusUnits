namespace Qkmaxware.Units.ElectricPotential {
	/// <summary>
	/// Unit of measurement for Volt (V)
	/// </summary>
	public struct Volt : IElectricPotential {
        public static string Name => "Volt";
        public static string Symbol => "V";
    }
	
	/// <summary>
	/// Extension method factory for generating Volt (V)
	/// </summary>
	public static class VoltFactory {
		/// <summary>
        /// Create a quantity measured in Volts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Volt> V<T>(this T value) {
            return new Quantity<T, Volt> (value);
        }
	}
}