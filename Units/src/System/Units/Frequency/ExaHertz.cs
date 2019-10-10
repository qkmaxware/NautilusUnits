namespace System.Units.Frequency {
	/// <summary>
	/// Unit of measurement for the ExaHertz (EHz)
	/// </summary>
	public struct ExaHertz : IFrequency {
        public static string Name => "ExaHertz";
        public static string Symbol => "EHz";
    }
	
	public static class ExaHertzFactory {
		/// <summary>
        /// Create a quantity measured in ExaHertzs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ExaHertz> EHz<T>(this T value) {
            return new Quantity<T, ExaHertz> (value);
        }
	}
}