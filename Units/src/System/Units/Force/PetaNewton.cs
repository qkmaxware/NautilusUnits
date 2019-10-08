namespace System.Units.Force {
	/// <summary>
	/// Unit of measurement for the PetaNewton (PN)
	/// </summary>
	public struct PetaNewton : IForce {
        public static string Name => "PetaNewton";
        public static string Symbol => "PN";
    }
	
	public static class PetaNewtonFactory {
		/// <summary>
        /// Create a quantity measured in PetaNewtons
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PetaNewton> PN<T>(this T value) {
            return new Quantity<T, PetaNewton> (value);
        }
	}
}