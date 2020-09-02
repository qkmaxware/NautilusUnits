namespace Qkmaxware.Units.Frequency {
	/// <summary>
	/// Unit of measurement for PetaHertz (PHz)
	/// </summary>
	public struct PetaHertz : IFrequency {
        public static string Name => "PetaHertz";
        public static string Symbol => "PHz";
    }
	
	/// <summary>
	/// Extension method factory for generating PetaHertz (PHz)
	/// </summary>
	public static class PetaHertzFactory {
		/// <summary>
        /// Create a quantity measured in PetaHertzs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PetaHertz> PHz<T>(this T value) {
            return new Quantity<T, PetaHertz> (value);
        }
	}
}