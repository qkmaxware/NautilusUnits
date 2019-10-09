namespace System.Units.Acceleration {
	/// <summary>
	/// Unit of measurement for the YoctoMetrePerSecondSq (ym/s^2)
	/// </summary>
	public struct YoctoMetrePerSecondSq : IAcceleration {
        public static string Name => "YoctoMetrePerSecondSq";
        public static string Symbol => "ym/s^2";
    }
	
	public static class YoctoMetrePerSecondSqFactory {
		/// <summary>
        /// Create a quantity measured in YoctoMetrePerSecondSqs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YoctoMetrePerSecondSq> ym_s2<T>(this T value) {
            return new Quantity<T, YoctoMetrePerSecondSq> (value);
        }
	}
}