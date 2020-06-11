namespace Qkmaxware.Units.Acceleration {
	/// <summary>
	/// Unit of measurement for the PetaMetrePerSecondSq (Pm/s^2)
	/// </summary>
	public struct PetaMetrePerSecondSq : IAcceleration {
        public static string Name => "PetaMetrePerSecondSq";
        public static string Symbol => "Pm/s^2";
    }
	
    /// <summary>
	/// Extension method factory for generating PetaMetrePerSecondSq (Pm/s^2) 
	/// </summary>
	public static class PetaMetrePerSecondSqFactory {
		/// <summary>
        /// Create a quantity measured in PetaMetrePerSecondSqs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PetaMetrePerSecondSq> Pm_s2<T>(this T value) {
            return new Quantity<T, PetaMetrePerSecondSq> (value);
        }
	}
}