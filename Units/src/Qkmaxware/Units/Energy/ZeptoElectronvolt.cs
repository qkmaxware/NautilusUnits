namespace Qkmaxware.Units.Energy {
	/// <summary>
	/// Unit of measurement for the ZeptoElectronvolt (zeV)
	/// </summary>
	public struct ZeptoElectronvolt : IEnergy {
        public static string Name => "ZeptoElectronvolt";
        public static string Symbol => "zeV";
    }
	
	/// <summary>
	///Extension method factory for generating ZeptoElectronvolt (zeV)
	/// </summary>
	public static class ZeptoElectronvoltFactory {
		/// <summary>
        /// Create a quantity measured in ZeptoElectronvolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZeptoElectronvolt> zeV<T>(this T value) {
            return new Quantity<T, ZeptoElectronvolt> (value);
        }
	}
}