namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the GigaElectronvolt (GeV)
	/// </summary>
	public struct GigaElectronvolt : IEnergy {
        public static string Name => "GigaElectronvolt";
        public static string Symbol => "GeV";
    }
	
	public static class GigaElectronvoltFactory {
		/// <summary>
        /// Create a quantity measured in GigaElectronvolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, GigaElectronvolt> GeV<T>(this T value) {
            return new Quantity<T, GigaElectronvolt> (value);
        }
	}
}