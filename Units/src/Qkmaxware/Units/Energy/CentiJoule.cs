namespace Qkmaxware.Units.Energy {
	/// <summary>
	/// Unit of measurement for the CentiJoule (cJ)
	/// </summary>
	public struct CentiJoule : IEnergy {
        public static string Name => "CentiJoule";
        public static string Symbol => "cJ";
    }
	
	/// <summary>
	///Extension method factory for generating CentiJoule (cJ)
	/// </summary>
	public static class CentiJouleFactory {
		/// <summary>
        /// Create a quantity measured in CentiJoules
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, CentiJoule> cJ<T>(this T value) {
            return new Quantity<T, CentiJoule> (value);
        }
	}
}