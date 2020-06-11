namespace Qkmaxware.Units.Velocity {
	/// <summary>
	/// Unit of measurement for the ZettaMetrePerSecond (Zm/s)
	/// </summary>
	public struct ZettaMetrePerSecond : IVelocity {
        public static string Name => "ZettaMetrePerSecond";
        public static string Symbol => "Zm/s";
    }
	
	/// <summary>
	///Extension method factory for generating ZettaMetrePerSecond (Zm/s)
	/// </summary>
	public static class ZettaMetrePerSecondFactory {
		/// <summary>
        /// Create a quantity measured in ZettaMetrePerSeconds
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZettaMetrePerSecond> Zm_s<T>(this T value) {
            return new Quantity<T, ZettaMetrePerSecond> (value);
        }
	}
}