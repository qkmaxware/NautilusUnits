namespace System.Units.Frequency {
	/// <summary>
	/// Unit of measurement for the HectoHertz (hHz)
	/// </summary>
	public struct HectoHertz : IFrequency {
        public static string Name => "HectoHertz";
        public static string Symbol => "hHz";
    }
	
	/// <summary>
	///Extension method factory for generating HectoHertz (hHz)
	/// </summary>
	public static class HectoHertzFactory {
		/// <summary>
        /// Create a quantity measured in HectoHertzs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, HectoHertz> hHz<T>(this T value) {
            return new Quantity<T, HectoHertz> (value);
        }
	}
}