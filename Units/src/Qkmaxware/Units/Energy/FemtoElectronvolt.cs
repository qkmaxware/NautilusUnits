namespace Qkmaxware.Units.Energy {
	/// <summary>
	/// Unit of measurement for FemtoElectronvolt (feV)
	/// </summary>
	public struct FemtoElectronvolt : IEnergy {
        public static string Name => "FemtoElectronvolt";
        public static string Symbol => "feV";
    }
	
	/// <summary>
	/// Extension method factory for generating FemtoElectronvolt (feV)
	/// </summary>
	public static class FemtoElectronvoltFactory {
		/// <summary>
        /// Create a quantity measured in FemtoElectronvolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, FemtoElectronvolt> feV<T>(this T value) {
            return new Quantity<T, FemtoElectronvolt> (value);
        }
	}
}