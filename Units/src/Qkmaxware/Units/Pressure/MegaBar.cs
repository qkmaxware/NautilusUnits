namespace Qkmaxware.Units.Pressure {
	/// <summary>
	/// Unit of measurement for MegaBar (Mbar)
	/// </summary>
	public struct MegaBar : IPressure {
        public static string Name => "MegaBar";
        public static string Symbol => "Mbar";
    }
	
	/// <summary>
	/// Extension method factory for generating MegaBar (Mbar)
	/// </summary>
	public static class MegaBarFactory {
		/// <summary>
        /// Create a quantity measured in MegaBars
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MegaBar> Mbar<T>(this T value) {
            return new Quantity<T, MegaBar> (value);
        }
	}
}