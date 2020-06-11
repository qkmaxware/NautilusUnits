namespace Qkmaxware.Units.Acceleration {
	/// <summary>
	/// Unit of measurement for the G (g)
	/// </summary>
	public struct G : IAcceleration {
        public static string Name => "G";
        public static string Symbol => "g";
    }
	
    /// <summary>
	/// Extension method factory for generating G (g) 
	/// </summary>
	public static class GFactory {
		/// <summary>
        /// Create a quantity measured in G's
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, G> g<T>(this T value) {
            return new Quantity<T, G> (value);
        }
	}
}