namespace Qkmaxware.Units.Energy {
	/// <summary>
	/// Unit of measurement for YoctoJoule (yJ)
	/// </summary>
	public struct YoctoJoule : IEnergy {
        public static string Name => "YoctoJoule";
        public static string Symbol => "yJ";
    }
	
	/// <summary>
	/// Extension method factory for generating YoctoJoule (yJ)
	/// </summary>
	public static class YoctoJouleFactory {
		/// <summary>
        /// Create a quantity measured in YoctoJoules
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YoctoJoule> yJ<T>(this T value) {
            return new Quantity<T, YoctoJoule> (value);
        }
	}
}