namespace Qkmaxware.Units.Energy {
	/// <summary>
	/// Unit of measurement for the YoctoElectronvolt (yeV)
	/// </summary>
	public struct YoctoElectronvolt : IEnergy {
        public static string Name => "YoctoElectronvolt";
        public static string Symbol => "yeV";
    }
	
	/// <summary>
	///Extension method factory for generating YoctoElectronvolt (yeV)
	/// </summary>
	public static class YoctoElectronvoltFactory {
		/// <summary>
        /// Create a quantity measured in YoctoElectronvolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YoctoElectronvolt> yeV<T>(this T value) {
            return new Quantity<T, YoctoElectronvolt> (value);
        }
	}
}