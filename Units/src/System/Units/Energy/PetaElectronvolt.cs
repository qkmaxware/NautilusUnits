namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the PetaElectronvolt (PeV)
	/// </summary>
	public struct PetaElectronvolt : IEnergy {
        public static string Name => "PetaElectronvolt";
        public static string Symbol => "PeV";
    }
	
	/// <summary>
	///Extension method factory for generating PetaElectronvolt (PeV)
	/// </summary>
	public static class PetaElectronvoltFactory {
		/// <summary>
        /// Create a quantity measured in PetaElectronvolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PetaElectronvolt> PeV<T>(this T value) {
            return new Quantity<T, PetaElectronvolt> (value);
        }
	}
}