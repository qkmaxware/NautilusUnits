namespace Qkmaxware.Units.Acceleration {
	/// <summary>
	/// Unit of measurement for the MilliMetrePerSecondSq (mm/s^2)
	/// </summary>
	public struct MilliMetrePerSecondSq : IAcceleration {
        public static string Name => "MilliMetrePerSecondSq";
        public static string Symbol => "mm/s^2";
    }
	
    /// <summary>
	/// Extension method factory for generating MilliMetrePerSecondSq (mm/s^2) 
	/// </summary>
	public static class MilliMetrePerSecondSqFactory {
		/// <summary>
        /// Create a quantity measured in MilliMetrePerSecondSqs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MilliMetrePerSecondSq> mm_s2<T>(this T value) {
            return new Quantity<T, MilliMetrePerSecondSq> (value);
        }
	}
}