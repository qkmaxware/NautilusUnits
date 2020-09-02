namespace Qkmaxware.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for YottaCandela (Ycd)
	/// </summary>
	public struct YottaCandela : ILuminosity {
        public static string Name => "YottaCandela";
        public static string Symbol => "Ycd";
    }
	
	/// <summary>
	/// Extension method factory for generating YottaCandela (Ycd)
	/// </summary>
	public static class YottaCandelaFactory {
		/// <summary>
        /// Create a quantity measured in YottaCandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YottaCandela> Ycd<T>(this T value) {
            return new Quantity<T, YottaCandela> (value);
        }
	}
}