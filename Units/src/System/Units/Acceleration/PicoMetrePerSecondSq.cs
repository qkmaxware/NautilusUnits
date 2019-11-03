namespace System.Units.Acceleration {
	/// <summary>
	/// Unit of measurement for the PicoMetrePerSecondSq (pm/s^2)
	/// </summary>
	public struct PicoMetrePerSecondSq : IAcceleration {
        public static string Name => "PicoMetrePerSecondSq";
        public static string Symbol => "pm/s^2";
    }
	
    /// <summary>
	/// Extension method factory for generating PicoMetrePerSecondSq (pm/s^2) 
	/// </summary>
	public static class PicoMetrePerSecondSqFactory {
		/// <summary>
        /// Create a quantity measured in PicoMetrePerSecondSqs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PicoMetrePerSecondSq> pm_s2<T>(this T value) {
            return new Quantity<T, PicoMetrePerSecondSq> (value);
        }
	}
}