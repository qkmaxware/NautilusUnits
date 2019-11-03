namespace System.Units.Pressure {
	/// <summary>
	/// Unit of measurement for the FemtoBar (fbar)
	/// </summary>
	public struct FemtoBar : IPressure {
        public static string Name => "FemtoBar";
        public static string Symbol => "fbar";
    }
	
	/// <summary>
	///Extension method factory for generating FemtoBar (fbar)
	/// </summary>
	public static class FemtoBarFactory {
		/// <summary>
        /// Create a quantity measured in FemtoBars
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, FemtoBar> fbar<T>(this T value) {
            return new Quantity<T, FemtoBar> (value);
        }
	}
}