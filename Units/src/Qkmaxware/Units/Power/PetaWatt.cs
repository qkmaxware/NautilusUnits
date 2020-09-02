namespace Qkmaxware.Units.Power {
	/// <summary>
	/// Unit of measurement for PetaWatt (PW)
	/// </summary>
	public struct PetaWatt : IPower {
        public static string Name => "PetaWatt";
        public static string Symbol => "PW";
    }
	
	/// <summary>
	/// Extension method factory for generating PetaWatt (PW)
	/// </summary>
	public static class PetaWattFactory {
		/// <summary>
        /// Create a quantity measured in PetaWatts
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PetaWatt> PW<T>(this T value) {
            return new Quantity<T, PetaWatt> (value);
        }
	}
}