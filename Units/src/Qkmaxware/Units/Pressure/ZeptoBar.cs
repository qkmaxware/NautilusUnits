namespace Qkmaxware.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the ZeptoBar (zbar)
	/// </summary>
	public struct ZeptoBar : IPressure {
        public static string Name => "ZeptoBar";
        public static string Symbol => "zbar";
    }
	
	/// <summary>
	///Extension method factory for generating ZeptoBar (zbar)
	/// </summary>
	public static class ZeptoBarFactory {
		/// <summary>
        /// Create a quantity measured in ZeptoBars
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZeptoBar> zbar<T>(this T value) {
            return new Quantity<T, ZeptoBar> (value);
        }
	}
}