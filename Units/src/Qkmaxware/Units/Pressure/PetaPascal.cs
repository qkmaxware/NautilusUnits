namespace Qkmaxware.Units.Pressure {
	/// <summary>
	/// Unit of measurement for PetaPascal (PPa)
	/// </summary>
	public struct PetaPascal : IPressure {
        public static string Name => "PetaPascal";
        public static string Symbol => "PPa";
    }
	
	/// <summary>
	/// Extension method factory for generating PetaPascal (PPa)
	/// </summary>
	public static class PetaPascalFactory {
		/// <summary>
        /// Create a quantity measured in PetaPascals
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PetaPascal> PPa<T>(this T value) {
            return new Quantity<T, PetaPascal> (value);
        }
	}
}