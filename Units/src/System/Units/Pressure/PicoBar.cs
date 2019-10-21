namespace System.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the PicoBar (pbar)
	/// </summary>
	public struct PicoBar : IPressure {
        public static string Name => "PicoBar";
        public static string Symbol => "pbar";
    }
	
	public static class PicoBarFactory {
		/// <summary>
        /// Create a quantity measured in PicoBars
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PicoBar> pbar<T>(this T value) {
            return new Quantity<T, PicoBar> (value);
        }
	}
}