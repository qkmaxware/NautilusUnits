namespace Qkmaxware.Units.Acceleration {
	/// <summary>
	/// Unit of measurement for YottaMetrePerSecondSq (Ym/s^2)
	/// </summary>
	public struct YottaMetrePerSecondSq : IAcceleration {
        public static string Name => "YottaMetrePerSecondSq";
        public static string Symbol => "Ym/s^2";
    }
	
	/// <summary>
	/// Extension method factory for generating YottaMetrePerSecondSq (Ym/s^2)
	/// </summary>
	public static class YottaMetrePerSecondSqFactory {
		/// <summary>
        /// Create a quantity measured in YottaMetrePerSecondSqs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YottaMetrePerSecondSq> Ym_s2<T>(this T value) {
            return new Quantity<T, YottaMetrePerSecondSq> (value);
        }
	}
}