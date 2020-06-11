namespace Qkmaxware.Units.Acceleration {
	/// <summary>
	/// Unit of measurement for the DeciMetrePerSecondSq (dm/s^2)
	/// </summary>
	public struct DeciMetrePerSecondSq : IAcceleration {
        public static string Name => "DeciMetrePerSecondSq";
        public static string Symbol => "dm/s^2";
    }

    /// <summary>
	/// Extension method factory for generating DeciMetrePerSecondSq (dm/s^2) 
	/// </summary>
	public static class DeciMetrePerSecondSqFactory {
		/// <summary>
        /// Create a quantity measured in DeciMetrePerSecondSqs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DeciMetrePerSecondSq> dm_s2<T>(this T value) {
            return new Quantity<T, DeciMetrePerSecondSq> (value);
        }
	}
}