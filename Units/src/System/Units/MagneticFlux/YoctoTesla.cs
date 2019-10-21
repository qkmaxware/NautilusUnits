namespace System.Units.MagneticFlux {
	/// <summary>
	/// Unit of measurement for the YoctoTesla (yT)
	/// </summary>
	public struct YoctoTesla : IMagneticFlux {
        public static string Name => "YoctoTesla";
        public static string Symbol => "yT";
    }
	
	public static class YoctoTeslaFactory {
		/// <summary>
        /// Create a quantity measured in YoctoTeslas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YoctoTesla> yT<T>(this T value) {
            return new Quantity<T, YoctoTesla> (value);
        }
	}
}