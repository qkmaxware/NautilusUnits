namespace Qkmaxware.Units.Energy {
	/// <summary>
	/// Unit of measurement for the NanoElectronvolt (neV)
	/// </summary>
	public struct NanoElectronvolt : IEnergy {
        public static string Name => "NanoElectronvolt";
        public static string Symbol => "neV";
    }
	
	/// <summary>
	///Extension method factory for generating NanoElectronvolt (neV)
	/// </summary>
	public static class NanoElectronvoltFactory {
		/// <summary>
        /// Create a quantity measured in NanoElectronvolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, NanoElectronvolt> neV<T>(this T value) {
            return new Quantity<T, NanoElectronvolt> (value);
        }
	}
}