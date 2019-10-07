namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the NanoJoule (nJ)
	/// </summary>
	public struct NanoJoule : IEnergy {
        public static string Name => "NanoJoule";
        public static string Symbol => "nJ";
    }
	
	public static class NanoJouleFactory {
		/// <summary>
        /// Create a quantity measured in NanoJoules
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, NanoJoule> nJ<T>(this T value) {
            return new Quantity<T, NanoJoule> (value);
        }
	}
}