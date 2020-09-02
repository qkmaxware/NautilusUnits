namespace Qkmaxware.Units.Energy {
	/// <summary>
	/// Unit of measurement for CentiElectronvolt (ceV)
	/// </summary>
	public struct CentiElectronvolt : IEnergy {
        public static string Name => "CentiElectronvolt";
        public static string Symbol => "ceV";
    }
	
	/// <summary>
	/// Extension method factory for generating CentiElectronvolt (ceV)
	/// </summary>
	public static class CentiElectronvoltFactory {
		/// <summary>
        /// Create a quantity measured in CentiElectronvolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, CentiElectronvolt> ceV<T>(this T value) {
            return new Quantity<T, CentiElectronvolt> (value);
        }
	}
}