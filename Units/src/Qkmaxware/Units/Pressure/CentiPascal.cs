namespace Qkmaxware.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the CentiPascal (cPa)
	/// </summary>
	public struct CentiPascal : IPressure {
        public static string Name => "CentiPascal";
        public static string Symbol => "cPa";
    }
	
	/// <summary>
	///Extension method factory for generating CentiPascal (cPa)
	/// </summary>
	public static class CentiPascalFactory {
		/// <summary>
        /// Create a quantity measured in CentiPascals
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, CentiPascal> cPa<T>(this T value) {
            return new Quantity<T, CentiPascal> (value);
        }
	}
}