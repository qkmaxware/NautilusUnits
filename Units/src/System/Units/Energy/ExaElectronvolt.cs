namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the ExaElectronvolt (EeV)
	/// </summary>
	public struct ExaElectronvolt : IEnergy {
        public static string Name => "ExaElectronvolt";
        public static string Symbol => "EeV";
    }
	
	public static class ExaElectronvoltFactory {
		/// <summary>
        /// Create a quantity measured in ExaElectronvolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ExaElectronvolt> EeV<T>(this T value) {
            return new Quantity<T, ExaElectronvolt> (value);
        }
	}
}