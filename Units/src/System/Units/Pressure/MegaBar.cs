namespace System.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the MegaBar (Mbar)
	/// </summary>
	public struct MegaBar : IPressure {
        public static string Name => "MegaBar";
        public static string Symbol => "Mbar";
    }
	
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