namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the PicoElectronvolt (peV)
	/// </summary>
	public struct PicoElectronvolt : IEnergy {
        public static string Name => "PicoElectronvolt";
        public static string Symbol => "peV";
    }
	
	/// <summary>
	///Extension method factory for generating PicoElectronvolt (peV)
	/// </summary>
	public static class PicoElectronvoltFactory {
		/// <summary>
        /// Create a quantity measured in PicoElectronvolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PicoElectronvolt> peV<T>(this T value) {
            return new Quantity<T, PicoElectronvolt> (value);
        }
	}
}