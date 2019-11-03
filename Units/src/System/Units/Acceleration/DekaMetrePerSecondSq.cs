namespace System.Units.Acceleration {
	/// <summary>
	/// Unit of measurement for the DekaMetrePerSecondSq (dam/s^2)
	/// </summary>
	public struct DekaMetrePerSecondSq : IAcceleration {
        public static string Name => "DekaMetrePerSecondSq";
        public static string Symbol => "dam/s^2";
    }
	
    /// <summary>
	/// Extension method factory for generating DekaMetrePerSecondSq (dam/s^2)
	/// </summary>
	public static class DekaMetrePerSecondSqFactory {
		/// <summary>
        /// Create a quantity measured in DekaMetrePerSecondSqs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DekaMetrePerSecondSq> dam_s2<T>(this T value) {
            return new Quantity<T, DekaMetrePerSecondSq> (value);
        }
	}
}