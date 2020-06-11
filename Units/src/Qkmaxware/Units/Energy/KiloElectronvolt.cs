namespace Qkmaxware.Units.Energy {
	/// <summary>
	/// Unit of measurement for the KiloElectronvolt (keV)
	/// </summary>
	public struct KiloElectronvolt : IEnergy {
        public static string Name => "KiloElectronvolt";
        public static string Symbol => "keV";
    }
	
	/// <summary>
	///Extension method factory for generating KiloElectronvolt (keV)
	/// </summary>
	public static class KiloElectronvoltFactory {
		/// <summary>
        /// Create a quantity measured in KiloElectronvolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, KiloElectronvolt> keV<T>(this T value) {
            return new Quantity<T, KiloElectronvolt> (value);
        }
	}
}