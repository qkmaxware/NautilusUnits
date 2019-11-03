namespace System.Units.ElectricPotential {
	/// <summary>
	/// Unit of measurement for the PetaVolt (PV)
	/// </summary>
	public struct PetaVolt : IElectricPotential {
        public static string Name => "PetaVolt";
        public static string Symbol => "PV";
    }
	
	/// <summary>
	///Extension method factory for generating PetaVolt (PV)
	/// </summary>
	public static class PetaVoltFactory {
		/// <summary>
        /// Create a quantity measured in PetaVolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PetaVolt> PV<T>(this T value) {
            return new Quantity<T, PetaVolt> (value);
        }
	}
}