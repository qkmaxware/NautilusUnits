namespace System.Units.Velocity {
	/// <summary>
	/// Unit of measurement for the AttoMetrePerSecond (am/s)
	/// </summary>
	public struct AttoMetrePerSecond : IVelocity {
        public static string Name => "AttoMetrePerSecond";
        public static string Symbol => "am/s";
    }
	
	/// <summary>
	///Extension method factory for generating AttoMetrePerSecond (am/s)
	/// </summary>
	public static class AttoMetrePerSecondFactory {
		/// <summary>
        /// Create a quantity measured in AttoMetrePerSeconds
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, AttoMetrePerSecond> am_s<T>(this T value) {
            return new Quantity<T, AttoMetrePerSecond> (value);
        }
	}
}