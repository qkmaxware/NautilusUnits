namespace System.Units.Velocity {
	/// <summary>
	/// Unit of measurement for the HectoMetrePerSecond (hm/s)
	/// </summary>
	public struct HectoMetrePerSecond : IVelocity {
        public static string Name => "HectoMetrePerSecond";
        public static string Symbol => "hm/s";
    }
	
	/// <summary>
	///Extension method factory for generating HectoMetrePerSecond (hm/s)
	/// </summary>
	public static class HectoMetrePerSecondFactory {
		/// <summary>
        /// Create a quantity measured in HectoMetrePerSeconds
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, HectoMetrePerSecond> hm_s<T>(this T value) {
            return new Quantity<T, HectoMetrePerSecond> (value);
        }
	}
}