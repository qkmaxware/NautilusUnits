namespace Qkmaxware.Units.Velocity {
	/// <summary>
	/// Unit of measurement for the MilliMetrePerSecond (mm/s)
	/// </summary>
	public struct MilliMetrePerSecond : IVelocity {
        public static string Name => "MilliMetrePerSecond";
        public static string Symbol => "mm/s";
    }
	
	/// <summary>
	///Extension method factory for generating MilliMetrePerSecond (mm/s)
	/// </summary>
	public static class MilliMetrePerSecondFactory {
		/// <summary>
        /// Create a quantity measured in MilliMetrePerSeconds
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MilliMetrePerSecond> mm_s<T>(this T value) {
            return new Quantity<T, MilliMetrePerSecond> (value);
        }
	}
}