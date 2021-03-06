namespace Qkmaxware.Units.Energy {
	/// <summary>
	/// Unit of measurement for AttoJoule (aJ)
	/// </summary>
	public struct AttoJoule : IEnergy {
        public static string Name => "AttoJoule";
        public static string Symbol => "aJ";
    }
	
	/// <summary>
	/// Extension method factory for generating AttoJoule (aJ)
	/// </summary>
	public static class AttoJouleFactory {
		/// <summary>
        /// Create a quantity measured in AttoJoules
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, AttoJoule> aJ<T>(this T value) {
            return new Quantity<T, AttoJoule> (value);
        }
	}
}