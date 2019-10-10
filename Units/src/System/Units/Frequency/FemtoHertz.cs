namespace System.Units.Frequency {
	/// <summary>
	/// Unit of measurement for the FemtoHertz (fHz)
	/// </summary>
	public struct FemtoHertz : IFrequency {
        public static string Name => "FemtoHertz";
        public static string Symbol => "fHz";
    }
	
	public static class FemtoHertzFactory {
		/// <summary>
        /// Create a quantity measured in FemtoHertzs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, FemtoHertz> fHz<T>(this T value) {
            return new Quantity<T, FemtoHertz> (value);
        }
	}
}