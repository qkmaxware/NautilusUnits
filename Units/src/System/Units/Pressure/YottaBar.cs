namespace System.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the YottaBar (Ybar)
	/// </summary>
	public struct YottaBar : IPressure {
        public static string Name => "YottaBar";
        public static string Symbol => "Ybar";
    }
	
	/// <summary>
	///Extension method factory for generating YottaBar (Ybar)
	/// </summary>
	public static class YottaBarFactory {
		/// <summary>
        /// Create a quantity measured in YottaBars
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YottaBar> Ybar<T>(this T value) {
            return new Quantity<T, YottaBar> (value);
        }
	}
}