namespace Qkmaxware.Units.Velocity {
	/// <summary>
	/// Unit of measurement for KiloMetrePerSecond (km/s)
	/// </summary>
	public struct KiloMetrePerSecond : IVelocity {
        public static string Name => "KiloMetrePerSecond";
        public static string Symbol => "km/s";
    }
	
	/// <summary>
	/// Extension method factory for generating KiloMetrePerSecond (km/s)
	/// </summary>
	public static class KiloMetrePerSecondFactory {
		/// <summary>
        /// Create a quantity measured in KiloMetrePerSeconds
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, KiloMetrePerSecond> km_s<T>(this T value) {
            return new Quantity<T, KiloMetrePerSecond> (value);
        }
	}
}