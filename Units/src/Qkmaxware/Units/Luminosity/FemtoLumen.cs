namespace Qkmaxware.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the FemtoLumen (flm)
	/// </summary>
	public struct FemtoLumen : ILuminosity {
        public static string Name => "FemtoLumen";
        public static string Symbol => "flm";
    }
	
	/// <summary>
	///Extension method factory for generating FemtoLumen (flm)
	/// </summary>
	public static class FemtoLumenFactory {
		/// <summary>
        /// Create a quantity measured in FemtoLumens
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, FemtoLumen> flm<T>(this T value) {
            return new Quantity<T, FemtoLumen> (value);
        }
	}
}