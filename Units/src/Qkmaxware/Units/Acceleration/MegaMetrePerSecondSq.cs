namespace Qkmaxware.Units.Acceleration {
	/// <summary>
	/// Unit of measurement for MegaMetrePerSecondSq (Mm/s^2)
	/// </summary>
	public struct MegaMetrePerSecondSq : IAcceleration {
        public static string Name => "MegaMetrePerSecondSq";
        public static string Symbol => "Mm/s^2";
    }
	
	/// <summary>
	/// Extension method factory for generating MegaMetrePerSecondSq (Mm/s^2)
	/// </summary>
	public static class MegaMetrePerSecondSqFactory {
		/// <summary>
        /// Create a quantity measured in MegaMetrePerSecondSqs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MegaMetrePerSecondSq> Mm_s2<T>(this T value) {
            return new Quantity<T, MegaMetrePerSecondSq> (value);
        }
	}
}