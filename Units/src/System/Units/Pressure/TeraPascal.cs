namespace System.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the TeraPascal (TPa)
	/// </summary>
	public struct TeraPascal : IPressure {
        public static string Name => "TeraPascal";
        public static string Symbol => "TPa";
    }
	
	/// <summary>
	///Extension method factory for generating TeraPascal (TPa)
	/// </summary>
	public static class TeraPascalFactory {
		/// <summary>
        /// Create a quantity measured in TeraPascals
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, TeraPascal> TPa<T>(this T value) {
            return new Quantity<T, TeraPascal> (value);
        }
	}
}