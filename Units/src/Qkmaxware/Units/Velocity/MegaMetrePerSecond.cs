namespace Qkmaxware.Units.Velocity {
	/// <summary>
	/// Unit of measurement for the MegaMetrePerSecond (Mm/s)
	/// </summary>
	public struct MegaMetrePerSecond : IVelocity {
        public static string Name => "MegaMetrePerSecond";
        public static string Symbol => "Mm/s";
    }
	
	/// <summary>
	///Extension method factory for generating MegaMetrePerSecond (Mm/s)
	/// </summary>
	public static class MegaMetrePerSecondFactory {
		/// <summary>
        /// Create a quantity measured in MegaMetrePerSeconds
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MegaMetrePerSecond> Mm_s<T>(this T value) {
            return new Quantity<T, MegaMetrePerSecond> (value);
        }
	}
}