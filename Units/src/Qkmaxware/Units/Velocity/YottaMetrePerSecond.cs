namespace Qkmaxware.Units.Velocity {
	/// <summary>
	/// Unit of measurement for YottaMetrePerSecond (Ym/s)
	/// </summary>
	public struct YottaMetrePerSecond : IVelocity {
        public static string Name => "YottaMetrePerSecond";
        public static string Symbol => "Ym/s";
    }
	
	/// <summary>
	/// Extension method factory for generating YottaMetrePerSecond (Ym/s)
	/// </summary>
	public static class YottaMetrePerSecondFactory {
		/// <summary>
        /// Create a quantity measured in YottaMetrePerSeconds
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YottaMetrePerSecond> Ym_s<T>(this T value) {
            return new Quantity<T, YottaMetrePerSecond> (value);
        }
	}
}