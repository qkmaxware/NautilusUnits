namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the MilliElectronvolt (meV)
	/// </summary>
	public struct MilliElectronvolt : IEnergy {
        public static string Name => "MilliElectronvolt";
        public static string Symbol => "meV";
    }
	
	public static class MilliElectronvoltFactory {
		/// <summary>
        /// Create a quantity measured in MilliElectronvolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MilliElectronvolt> meV<T>(this T value) {
            return new Quantity<T, MilliElectronvolt> (value);
        }
	}
}