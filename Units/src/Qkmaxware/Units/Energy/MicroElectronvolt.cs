namespace Qkmaxware.Units.Energy {
	/// <summary>
	/// Unit of measurement for MicroElectronvolt (ueV)
	/// </summary>
	public struct MicroElectronvolt : IEnergy {
        public static string Name => "MicroElectronvolt";
        public static string Symbol => "ueV";
    }
	
	/// <summary>
	/// Extension method factory for generating MicroElectronvolt (ueV)
	/// </summary>
	public static class MicroElectronvoltFactory {
		/// <summary>
        /// Create a quantity measured in MicroElectronvolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MicroElectronvolt> ueV<T>(this T value) {
            return new Quantity<T, MicroElectronvolt> (value);
        }
	}
}