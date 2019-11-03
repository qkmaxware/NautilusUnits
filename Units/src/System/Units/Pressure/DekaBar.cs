namespace System.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the DekaBar (dabar)
	/// </summary>
	public struct DekaBar : IPressure {
        public static string Name => "DekaBar";
        public static string Symbol => "dabar";
    }
	
	/// <summary>
	///Extension method factory for generating DekaBar (dabar)
	/// </summary>
	public static class DekaBarFactory {
		/// <summary>
        /// Create a quantity measured in DekaBars
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, DekaBar> dabar<T>(this T value) {
            return new Quantity<T, DekaBar> (value);
        }
	}
}