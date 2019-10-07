namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the YoctoCandela (ycd)
	/// </summary>
	public struct YoctoCandela : ILuminosity {
        public static string Name => "YoctoCandela";
        public static string Symbol => "ycd";
    }
	
	public static class YoctoCandelaFactory {
		/// <summary>
        /// Create a quantity measured in YoctoCandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YoctoCandela> ycd<T>(this T value) {
            return new Quantity<T, YoctoCandela> (value);
        }
	}
}