namespace Qkmaxware.Units.Energy {
	/// <summary>
	/// Unit of measurement for the DekaElectronvolt (daeV)
	/// </summary>
	public struct DekaElectronvolt : IEnergy {
        public static string Name => "DekaElectronvolt";
        public static string Symbol => "daeV";
    }
	
	/// <summary>
	///Extension method factory for generating DekaElectronvolt (daeV)
	/// </summary>
	public static class DekaElectronvoltFactory {
		/// <summary>
        /// Create a quantity measured in DekaElectronvolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DekaElectronvolt> daeV<T>(this T value) {
            return new Quantity<T, DekaElectronvolt> (value);
        }
	}
}