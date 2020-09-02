namespace Qkmaxware.Units.Pressure {
	/// <summary>
	/// Unit of measurement for MilliBar (mbar)
	/// </summary>
	public struct MilliBar : IPressure {
        public static string Name => "MilliBar";
        public static string Symbol => "mbar";
    }
	
	/// <summary>
	/// Extension method factory for generating MilliBar (mbar)
	/// </summary>
	public static class MilliBarFactory {
		/// <summary>
        /// Create a quantity measured in MilliBars
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MilliBar> mbar<T>(this T value) {
            return new Quantity<T, MilliBar> (value);
        }
	}
}