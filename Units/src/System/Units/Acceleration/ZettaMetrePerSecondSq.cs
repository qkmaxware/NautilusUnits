namespace System.Units.Acceleration {
	/// <summary>
	/// Unit of measurement for the ZettaMetrePerSecondSq (Zm/s^2)
	/// </summary>
	public struct ZettaMetrePerSecondSq : IAcceleration {
        public static string Name => "ZettaMetrePerSecondSq";
        public static string Symbol => "Zm/s^2";
    }
	
    /// <summary>
	/// Extension method factory for generating ZettaMetrePerSecondSq (Zm/s^2)
	/// </summary>
	public static class ZettaMetrePerSecondSqFactory {
		/// <summary>
        /// Create a quantity measured in ZettaMetrePerSecondSqs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZettaMetrePerSecondSq> Zm_s2<T>(this T value) {
            return new Quantity<T, ZettaMetrePerSecondSq> (value);
        }
	}
}