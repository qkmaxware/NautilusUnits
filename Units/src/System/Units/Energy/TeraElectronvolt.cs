namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the TeraElectronvolt (TeV)
	/// </summary>
	public struct TeraElectronvolt : IEnergy {
        public static string Name => "TeraElectronvolt";
        public static string Symbol => "TeV";
    }
	
	public static class TeraElectronvoltFactory {
		/// <summary>
        /// Create a quantity measured in TeraElectronvolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, TeraElectronvolt> TeV<T>(this T value) {
            return new Quantity<T, TeraElectronvolt> (value);
        }
	}
}