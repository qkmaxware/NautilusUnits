namespace Qkmaxware.Units.Energy {
	/// <summary>
	/// Unit of measurement for the MegaElectronvolt (MeV)
	/// </summary>
	public struct MegaElectronvolt : IEnergy {
        public static string Name => "MegaElectronvolt";
        public static string Symbol => "MeV";
    }
	
	/// <summary>
	///Extension method factory for generating MegaElectronvolt (MeV)
	/// </summary>
	public static class MegaElectronvoltFactory {
		/// <summary>
        /// Create a quantity measured in MegaElectronvolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MegaElectronvolt> MeV<T>(this T value) {
            return new Quantity<T, MegaElectronvolt> (value);
        }
	}
}