namespace Qkmaxware.Units.Energy {
	/// <summary>
	/// Unit of measurement for HectoElectronvolt (heV)
	/// </summary>
	public struct HectoElectronvolt : IEnergy {
        public static string Name => "HectoElectronvolt";
        public static string Symbol => "heV";
    }
	
	/// <summary>
	/// Extension method factory for generating HectoElectronvolt (heV)
	/// </summary>
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