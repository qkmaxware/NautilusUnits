namespace Qkmaxware.Units.Pressure {
	/// <summary>
	/// Unit of measurement for GigaBar (Gbar)
	/// </summary>
	public struct GigaBar : IPressure {
        public static string Name => "GigaBar";
        public static string Symbol => "Gbar";
    }
	
	/// <summary>
	/// Extension method factory for generating GigaBar (Gbar)
	/// </summary>
	public static class GigaBarFactory {
		/// <summary>
        /// Create a quantity measured in GigaBars
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, GigaBar> Gbar<T>(this T value) {
            return new Quantity<T, GigaBar> (value);
        }
	}
}