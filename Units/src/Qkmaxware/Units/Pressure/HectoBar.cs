namespace Qkmaxware.Units.Pressure {
	/// <summary>
	/// Unit of measurement for HectoBar (hbar)
	/// </summary>
	public struct HectoBar : IPressure {
        public static string Name => "HectoBar";
        public static string Symbol => "hbar";
    }
	
	/// <summary>
	/// Extension method factory for generating HectoBar (hbar)
	/// </summary>
	public static class HectoBarFactory {
		/// <summary>
        /// Create a quantity measured in HectoBars
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, HectoBar> hbar<T>(this T value) {
            return new Quantity<T, HectoBar> (value);
        }
	}
}