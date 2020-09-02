namespace Qkmaxware.Units.Pressure {
	/// <summary>
	/// Unit of measurement for YoctoBar (ybar)
	/// </summary>
	public struct YoctoBar : IPressure {
        public static string Name => "YoctoBar";
        public static string Symbol => "ybar";
    }
	
	/// <summary>
	/// Extension method factory for generating YoctoBar (ybar)
	/// </summary>
	public static class YoctoBarFactory {
		/// <summary>
        /// Create a quantity measured in YoctoBars
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YoctoBar> ybar<T>(this T value) {
            return new Quantity<T, YoctoBar> (value);
        }
	}
}