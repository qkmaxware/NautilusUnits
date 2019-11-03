namespace System.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the MilliPascal (mPa)
	/// </summary>
	public struct MilliPascal : IPressure {
        public static string Name => "MilliPascal";
        public static string Symbol => "mPa";
    }
	
	/// <summary>
	///Extension method factory for generating MilliPascal (mPa)
	/// </summary>
	public static class MilliPascalFactory {
		/// <summary>
        /// Create a quantity measured in MilliPascals
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MilliPascal> mPa<T>(this T value) {
            return new Quantity<T, MilliPascal> (value);
        }
	}
}