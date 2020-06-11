namespace Qkmaxware.Units.Energy {
	/// <summary>
	/// Unit of measurement for the DeciElectronvolt (deV)
	/// </summary>
	public struct DeciElectronvolt : IEnergy {
        public static string Name => "DeciElectronvolt";
        public static string Symbol => "deV";
    }
	
	/// <summary>
	///Extension method factory for generating DeciElectronvolt (deV)
	/// </summary>
	public static class DeciElectronvoltFactory {
		/// <summary>
        /// Create a quantity measured in DeciElectronvolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DeciElectronvolt> deV<T>(this T value) {
            return new Quantity<T, DeciElectronvolt> (value);
        }
	}
}