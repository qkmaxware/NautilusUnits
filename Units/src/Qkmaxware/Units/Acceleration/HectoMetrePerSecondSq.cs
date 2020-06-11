namespace Qkmaxware.Units.Acceleration {
	/// <summary>
	/// Unit of measurement for the HectoMetrePerSecondSq (hm/s^2)
	/// </summary>
	public struct HectoMetrePerSecondSq : IAcceleration {
        public static string Name => "HectoMetrePerSecondSq";
        public static string Symbol => "hm/s^2";
    }
	
    /// <summary>
	/// Extension method factory for generating HectoMetrePerSecondSq (hm/s^2) 
	/// </summary>
	public static class HectoMetrePerSecondSqFactory {
		/// <summary>
        /// Create a quantity measured in HectoMetrePerSecondSqs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, HectoMetrePerSecondSq> hm_s2<T>(this T value) {
            return new Quantity<T, HectoMetrePerSecondSq> (value);
        }
	}
}