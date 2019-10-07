namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the CentiElectronvolt (ceV)
	/// </summary>
	public struct CentiElectronvolt : IEnergy {
        public static string Name => "CentiElectronvolt";
        public static string Symbol => "ceV";
    }
	
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