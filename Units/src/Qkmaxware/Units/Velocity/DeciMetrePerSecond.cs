namespace Qkmaxware.Units.Velocity {
	/// <summary>
	/// Unit of measurement for DeciMetrePerSecond (dm/s)
	/// </summary>
	public struct DeciMetrePerSecond : IVelocity {
        public static string Name => "DeciMetrePerSecond";
        public static string Symbol => "dm/s";
    }
	
	/// <summary>
	/// Extension method factory for generating DeciMetrePerSecond (dm/s)
	/// </summary>
	public static class DeciMetrePerSecondFactory {
		/// <summary>
        /// Create a quantity measured in DeciMetrePerSeconds
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DeciMetrePerSecond> dm_s<T>(this T value) {
            return new Quantity<T, DeciMetrePerSecond> (value);
        }
	}
}