namespace Qkmaxware.Units.Acceleration {
	/// <summary>
	/// Unit of measurement for MetrePerSecondSq (m/s^2)
	/// </summary>
	public struct MetrePerSecondSq : IAcceleration {
        public static string Name => "MetrePerSecondSq";
        public static string Symbol => "m/s^2";
    }
	
	/// <summary>
	/// Extension method factory for generating MetrePerSecondSq (m/s^2)
	/// </summary>
	public static class MetrePerSecondSqFactory {
		/// <summary>
        /// Create a quantity measured in MetrePerSecondSqs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MetrePerSecondSq> m_s2<T>(this T value) {
            return new Quantity<T, MetrePerSecondSq> (value);
        }
	}
}