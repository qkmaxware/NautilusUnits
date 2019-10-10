namespace System.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the KiloBar (kbar)
	/// </summary>
	public struct KiloBar : IPressure {
        public static string Name => "KiloBar";
        public static string Symbol => "kbar";
    }
	
	public static class KiloBarFactory {
		/// <summary>
        /// Create a quantity measured in KiloBars
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, KiloBar> kbar<T>(this T value) {
            return new Quantity<T, KiloBar> (value);
        }
	}
}