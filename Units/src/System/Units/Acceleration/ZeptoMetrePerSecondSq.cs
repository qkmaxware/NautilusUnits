namespace System.Units.Acceleration {
	/// <summary>
	/// Unit of measurement for the ZeptoMetrePerSecondSq (zm/s^2)
	/// </summary>
	public struct ZeptoMetrePerSecondSq : IAcceleration {
        public static string Name => "ZeptoMetrePerSecondSq";
        public static string Symbol => "zm/s^2";
    }
	
	public static class ZeptoMetrePerSecondSqFactory {
		/// <summary>
        /// Create a quantity measured in ZeptoMetrePerSecondSqs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZeptoMetrePerSecondSq> zm_s2<T>(this T value) {
            return new Quantity<T, ZeptoMetrePerSecondSq> (value);
        }
	}
}