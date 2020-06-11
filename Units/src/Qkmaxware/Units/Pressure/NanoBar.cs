namespace Qkmaxware.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the NanoBar (nbar)
	/// </summary>
	public struct NanoBar : IPressure {
        public static string Name => "NanoBar";
        public static string Symbol => "nbar";
    }
	
	/// <summary>
	///Extension method factory for generating NanoBar (nbar)
	/// </summary>
	public static class NanoBarFactory {
		/// <summary>
        /// Create a quantity measured in NanoBars
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, NanoBar> nbar<T>(this T value) {
            return new Quantity<T, NanoBar> (value);
        }
	}
}