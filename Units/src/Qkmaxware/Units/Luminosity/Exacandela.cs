namespace Qkmaxware.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the ExaCandela (Ecd)
	/// </summary>
	public struct ExaCandela : ILuminosity {
        public static string Name => "ExaCandela";
        public static string Symbol => "Ecd";
    }
	
	/// <summary>
	///Extension method factory for generating ExaCandela (Ecd)
	/// </summary>
	public static class ExaCandelaFactory {
		/// <summary>
        /// Create a quantity measured in ExaCandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ExaCandela> Ecd<T>(this T value) {
            return new Quantity<T, ExaCandela> (value);
        }
	}
}