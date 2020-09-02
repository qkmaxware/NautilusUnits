namespace Qkmaxware.Units.Velocity {
	/// <summary>
	/// Unit of measurement for DekaMetrePerSecond (dam/s)
	/// </summary>
	public struct DekaMetrePerSecond : IVelocity {
        public static string Name => "DekaMetrePerSecond";
        public static string Symbol => "dam/s";
    }
	
	/// <summary>
	/// Extension method factory for generating DekaMetrePerSecond (dam/s)
	/// </summary>
	public static class DekaMetrePerSecondFactory {
		/// <summary>
        /// Create a quantity measured in DekaMetrePerSeconds
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DekaMetrePerSecond> dam_s<T>(this T value) {
            return new Quantity<T, DekaMetrePerSecond> (value);
        }
	}
}