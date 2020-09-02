namespace Qkmaxware.Units.Energy {
	/// <summary>
	/// Unit of measurement for Joule (J)
	/// </summary>
	public struct Joule : IEnergy {
        public static string Name => "Joule";
        public static string Symbol => "J";
    }
	
	/// <summary>
	/// Extension method factory for generating Joule (J)
	/// </summary>
	public static class JouleFactory {
		/// <summary>
        /// Create a quantity measured in Joules
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Joule> J<T>(this T value) {
            return new Quantity<T, Joule> (value);
        }
	}
}