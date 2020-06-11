namespace Qkmaxware.Units.Acceleration {
	/// <summary>
	/// Unit of measurement for the GigaMetrePerSecondSq (Gm/s^2)
	/// </summary>
	public struct GigaMetrePerSecondSq : IAcceleration {
        public static string Name => "GigaMetrePerSecondSq";
        public static string Symbol => "Gm/s^2";
    }
	
    /// <summary>
	/// Extension method factory for generating GigaMetrePerSecondSq (Gm/s^2) 
	/// </summary>
	public static class GigaMetrePerSecondSqFactory {
		/// <summary>
        /// Create a quantity measured in GigaMetrePerSecondSqs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, GigaMetrePerSecondSq> Gm_s2<T>(this T value) {
            return new Quantity<T, GigaMetrePerSecondSq> (value);
        }
	}
}