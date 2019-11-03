namespace System.Units.Velocity {
	/// <summary>
	/// Unit of measurement for the YoctoMetrePerSecond (ym/s)
	/// </summary>
	public struct YoctoMetrePerSecond : IVelocity {
        public static string Name => "YoctoMetrePerSecond";
        public static string Symbol => "ym/s";
    }
	
	/// <summary>
	///Extension method factory for generating YoctoMetrePerSecond (ym/s)
	/// </summary>
	public static class YoctoMetrePerSecondFactory {
		/// <summary>
        /// Create a quantity measured in YoctoMetrePerSeconds
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YoctoMetrePerSecond> ym_s<T>(this T value) {
            return new Quantity<T, YoctoMetrePerSecond> (value);
        }
	}
}