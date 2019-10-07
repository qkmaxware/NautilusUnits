namespace System.Units.Energy {
	/// <summary>
	/// Unit of measurement for the YottaJoule (YJ)
	/// </summary>
	public struct YottaJoule : IEnergy {
        public static string Name => "YottaJoule";
        public static string Symbol => "YJ";
    }
	
	public static class YottaJouleFactory {
		/// <summary>
        /// Create a quantity measured in YottaJoules
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YottaJoule> YJ<T>(this T value) {
            return new Quantity<T, YottaJoule> (value);
        }
	}
}