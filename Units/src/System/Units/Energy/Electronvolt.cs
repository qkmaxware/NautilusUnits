namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the Electronvolt (eV)
	/// </summary>
	public struct Electronvolt : IEnergy {
        public static string Name => "Electronvolt";
        public static string Symbol => "eV";
    }
	
	/// <summary>
	///Extension method factory for generating Electronvolt (eV)
	/// </summary>
	public static class ElectronvoltFactory {
		/// <summary>
        /// Create a quantity measured in Electronvolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Electronvolt> eV<T>(this T value) {
            return new Quantity<T, Electronvolt> (value);
        }
	}
}