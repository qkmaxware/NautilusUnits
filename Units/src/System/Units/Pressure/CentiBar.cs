namespace System.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the CentiBar (cbar)
	/// </summary>
	public struct CentiBar : IPressure {
        public static string Name => "CentiBar";
        public static string Symbol => "cbar";
    }
	
	public static class CentiBarFactory {
		/// <summary>
        /// Create a quantity measured in CentiBars
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, CentiBar> cbar<T>(this T value) {
            return new Quantity<T, CentiBar> (value);
        }
	}
}