namespace Qkmaxware.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for FemtoCandela (fcd)
	/// </summary>
	public struct FemtoCandela : ILuminosity {
        public static string Name => "FemtoCandela";
        public static string Symbol => "fcd";
    }
	
	/// <summary>
	/// Extension method factory for generating FemtoCandela (fcd)
	/// </summary>
	public static class FemtoCandelaFactory {
		/// <summary>
        /// Create a quantity measured in FemtoCandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, FemtoCandela> fcd<T>(this T value) {
            return new Quantity<T, FemtoCandela> (value);
        }
	}
}