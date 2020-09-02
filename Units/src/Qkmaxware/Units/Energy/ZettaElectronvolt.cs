namespace Qkmaxware.Units.Energy {
	/// <summary>
	/// Unit of measurement for ZettaElectronvolt (ZeV)
	/// </summary>
	public struct ZettaElectronvolt : IEnergy {
        public static string Name => "ZettaElectronvolt";
        public static string Symbol => "ZeV";
    }
	
	/// <summary>
	/// Extension method factory for generating ZettaElectronvolt (ZeV)
	/// </summary>
	public static class ZettaElectronvoltFactory {
		/// <summary>
        /// Create a quantity measured in ZettaElectronvolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZettaElectronvolt> ZeV<T>(this T value) {
            return new Quantity<T, ZettaElectronvolt> (value);
        }
	}
}