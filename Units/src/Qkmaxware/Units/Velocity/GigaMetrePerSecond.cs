namespace Qkmaxware.Units.Velocity {
	/// <summary>
	/// Unit of measurement for the GigaMetrePerSecond (Gm/s)
	/// </summary>
	public struct GigaMetrePerSecond : IVelocity {
        public static string Name => "GigaMetrePerSecond";
        public static string Symbol => "Gm/s";
    }
	
	/// <summary>
	///Extension method factory for generating GigaMetrePerSecond (Gm/s)
	/// </summary>
	public static class GigaMetrePerSecondFactory {
		/// <summary>
        /// Create a quantity measured in GigaMetrePerSeconds
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, GigaMetrePerSecond> Gm_s<T>(this T value) {
            return new Quantity<T, GigaMetrePerSecond> (value);
        }
	}
}