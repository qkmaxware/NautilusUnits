namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the MegaJoule (MJ)
	/// </summary>
	public struct MegaJoule : IEnergy {
        public static string Name => "MegaJoule";
        public static string Symbol => "MJ";
    }
	
	/// <summary>
	///Extension method factory for generating MegaJoule (MJ)
	/// </summary>
	public static class MegaJouleFactory {
		/// <summary>
        /// Create a quantity measured in MegaJoules
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MegaJoule> MJ<T>(this T value) {
            return new Quantity<T, MegaJoule> (value);
        }
	}
}