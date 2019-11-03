namespace System.Units.Velocity {
	/// <summary>
	/// Unit of measurement for the PetaMetrePerSecond (Pm/s)
	/// </summary>
	public struct PetaMetrePerSecond : IVelocity {
        public static string Name => "PetaMetrePerSecond";
        public static string Symbol => "Pm/s";
    }
	
	/// <summary>
	///Extension method factory for generating PetaMetrePerSecond (Pm/s)
	/// </summary>
	public static class PetaMetrePerSecondFactory {
		/// <summary>
        /// Create a quantity measured in PetaMetrePerSeconds
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PetaMetrePerSecond> Pm_s<T>(this T value) {
            return new Quantity<T, PetaMetrePerSecond> (value);
        }
	}
}