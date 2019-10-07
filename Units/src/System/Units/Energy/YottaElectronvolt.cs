namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the YottaElectronvolt (YeV)
	/// </summary>
	public struct YottaElectronvolt : IEnergy {
        public static string Name => "YottaElectronvolt";
        public static string Symbol => "YeV";
    }
	
	public static class YottaElectronvoltFactory {
		/// <summary>
        /// Create a quantity measured in YottaElectronvolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YottaElectronvolt> YeV<T>(this T value) {
            return new Quantity<T, YottaElectronvolt> (value);
        }
	}
}