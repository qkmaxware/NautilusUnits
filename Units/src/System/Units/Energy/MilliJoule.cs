namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the MilliJoule (mJ)
	/// </summary>
	public struct MilliJoule : IEnergy {
        public static string Name => "MilliJoule";
        public static string Symbol => "mJ";
    }
	
	/// <summary>
	///Extension method factory for generating MilliJoule (mJ)
	/// </summary>
	public static class MilliJouleFactory {
		/// <summary>
        /// Create a quantity measured in MilliJoules
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MilliJoule> mJ<T>(this T value) {
            return new Quantity<T, MilliJoule> (value);
        }
	}
}