namespace Qkmaxware.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the MicroBar (ubar)
	/// </summary>
	public struct MicroBar : IPressure {
        public static string Name => "MicroBar";
        public static string Symbol => "ubar";
    }
	
	/// <summary>
	///Extension method factory for generating MicroBar (ubar)
	/// </summary>
	public static class MicroBarFactory {
		/// <summary>
        /// Create a quantity measured in MicroBars
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MicroBar> ubar<T>(this T value) {
            return new Quantity<T, MicroBar> (value);
        }
	}
}