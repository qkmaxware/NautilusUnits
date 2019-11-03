namespace System.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the ExaBar (Ebar)
	/// </summary>
	public struct ExaBar : IPressure {
        public static string Name => "ExaBar";
        public static string Symbol => "Ebar";
    }
	
	/// <summary>
	///Extension method factory for generating ExaBar (Ebar)
	/// </summary>
	public static class ExaBarFactory {
		/// <summary>
        /// Create a quantity measured in ExaBars
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ExaBar> Ebar<T>(this T value) {
            return new Quantity<T, ExaBar> (value);
        }
	}
}