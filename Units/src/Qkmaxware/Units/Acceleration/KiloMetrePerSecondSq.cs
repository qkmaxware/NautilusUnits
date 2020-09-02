namespace Qkmaxware.Units.Acceleration {
	/// <summary>
	/// Unit of measurement for KiloMetrePerSecondSq (km/s^2)
	/// </summary>
	public struct KiloMetrePerSecondSq : IAcceleration {
        public static string Name => "KiloMetrePerSecondSq";
        public static string Symbol => "km/s^2";
    }
	
	/// <summary>
	/// Extension method factory for generating KiloMetrePerSecondSq (km/s^2)
	/// </summary>
	public static class KiloMetrePerSecondSqFactory {
		/// <summary>
        /// Create a quantity measured in KiloMetrePerSecondSqs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, KiloMetrePerSecondSq> km_s2<T>(this T value) {
            return new Quantity<T, KiloMetrePerSecondSq> (value);
        }
	}
}