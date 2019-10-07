namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the HectoElectronvolt (heV)
	/// </summary>
	public struct HectoElectronvolt : IEnergy {
        public static string Name => "HectoElectronvolt";
        public static string Symbol => "heV";
    }
	
	public static class HectoElectronvoltFactory {
		/// <summary>
        /// Create a quantity measured in HectoElectronvolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, HectoElectronvolt> heV<T>(this T value) {
            return new Quantity<T, HectoElectronvolt> (value);
        }
	}
}