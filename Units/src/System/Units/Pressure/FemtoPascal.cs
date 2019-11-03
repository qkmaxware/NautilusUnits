namespace System.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the FemtoPascal (fPa)
	/// </summary>
	public struct FemtoPascal : IPressure {
        public static string Name => "FemtoPascal";
        public static string Symbol => "fPa";
    }
	
	/// <summary>
	///Extension method factory for generating FemtoPascal (fPa)
	/// </summary>
	public static class FemtoPascalFactory {
		/// <summary>
        /// Create a quantity measured in FemtoPascals
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, FemtoPascal> fPa<T>(this T value) {
            return new Quantity<T, FemtoPascal> (value);
        }
	}
}