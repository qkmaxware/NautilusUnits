namespace System.Units.ElectricPotential {
	/// <summary>
	/// Unit of measurement for the NanoVolt (nV)
	/// </summary>
	public struct NanoVolt : IElectricPotential {
        public static string Name => "NanoVolt";
        public static string Symbol => "nV";
    }
	
	public static class NanoVoltFactory {
		/// <summary>
        /// Create a quantity measured in NanoVolts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, NanoVolt> nV<T>(this T value) {
            return new Quantity<T, NanoVolt> (value);
        }
	}
}