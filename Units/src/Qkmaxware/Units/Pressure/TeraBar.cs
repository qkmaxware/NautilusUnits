namespace Qkmaxware.Units.Pressure {
	/// <summary>
	/// Unit of measurement for TeraBar (Tbar)
	/// </summary>
	public struct TeraBar : IPressure {
        public static string Name => "TeraBar";
        public static string Symbol => "Tbar";
    }
	
	/// <summary>
	/// Extension method factory for generating TeraBar (Tbar)
	/// </summary>
	public static class TeraBarFactory {
		/// <summary>
        /// Create a quantity measured in TeraBars
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, TeraBar> Tbar<T>(this T value) {
            return new Quantity<T, TeraBar> (value);
        }
	}
}