namespace Qkmaxware.Units.Acceleration {
	/// <summary>
	/// Unit of measurement for the AttoMetrePerSecondSq (am/s^2)
	/// </summary>
	public struct AttoMetrePerSecondSq : IAcceleration {
        public static string Name => "AttoMetrePerSecondSq";
        public static string Symbol => "am/s^2";
    }
	
    /// <summary>
	/// Extension method factory for generating AttoMetrePerSecondSq (am/s^2)
	/// </summary>
	public static class AttoMetrePerSecondSqFactory {
		/// <summary>
        /// Create a quantity measured in AttoMetrePerSecondSqs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, AttoMetrePerSecondSq> am_s2<T>(this T value) {
            return new Quantity<T, AttoMetrePerSecondSq> (value);
        }
	}
}