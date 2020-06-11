namespace Qkmaxware.Units.Velocity {
	/// <summary>
	/// Unit of measurement for the MetrePerSecond (m/s)
	/// </summary>
	public struct MetrePerSecond : IVelocity {
        public static string Name => "MetrePerSecond";
        public static string Symbol => "m/s";
    }
	
	/// <summary>
	///Extension method factory for generating MetrePerSecond (m/s)
	/// </summary>
	public static class MetrePerSecondFactory {
		/// <summary>
        /// Create a quantity measured in MetrePerSeconds
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MetrePerSecond> m_s<T>(this T value) {
            return new Quantity<T, MetrePerSecond> (value);
        }
	}
}