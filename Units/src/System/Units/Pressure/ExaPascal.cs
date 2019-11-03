namespace System.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the ExaPascal (EPa)
	/// </summary>
	public struct ExaPascal : IPressure {
        public static string Name => "ExaPascal";
        public static string Symbol => "EPa";
    }
	
	/// <summary>
	///Extension method factory for generating ExaPascal (EPa)
	/// </summary>
	public static class ExaPascalFactory {
		/// <summary>
        /// Create a quantity measured in ExaPascals
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ExaPascal> EPa<T>(this T value) {
            return new Quantity<T, ExaPascal> (value);
        }
	}
}