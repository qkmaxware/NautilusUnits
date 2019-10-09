namespace System.Units.Velocity {
	/// <summary>
	/// Unit of measurement for the ZeptoMetrePerSecond (zm/s)
	/// </summary>
	public struct ZeptoMetrePerSecond : IVelocity {
        public static string Name => "ZeptoMetrePerSecond";
        public static string Symbol => "zm/s";
    }
	
	public static class ZeptoMetrePerSecondFactory {
		/// <summary>
        /// Create a quantity measured in ZeptoMetrePerSeconds
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZeptoMetrePerSecond> zm_s<T>(this T value) {
            return new Quantity<T, ZeptoMetrePerSecond> (value);
        }
	}
}