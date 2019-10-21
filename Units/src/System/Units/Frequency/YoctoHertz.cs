namespace System.Units.Frequency {
	/// <summary>
	/// Unit of measurement for the YoctoHertz (yHz)
	/// </summary>
	public struct YoctoHertz : IFrequency {
        public static string Name => "YoctoHertz";
        public static string Symbol => "yHz";
    }
	
	public static class YoctoHertzFactory {
		/// <summary>
        /// Create a quantity measured in YoctoHertzs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YoctoHertz> yHz<T>(this T value) {
            return new Quantity<T, YoctoHertz> (value);
        }
	}
}