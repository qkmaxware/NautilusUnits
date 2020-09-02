namespace Qkmaxware.Units.Acceleration {
	/// <summary>
	/// Unit of measurement for FemtoMetrePerSecondSq (fm/s^2)
	/// </summary>
	public struct FemtoMetrePerSecondSq : IAcceleration {
        public static string Name => "FemtoMetrePerSecondSq";
        public static string Symbol => "fm/s^2";
    }
	
	/// <summary>
	/// Extension method factory for generating FemtoMetrePerSecondSq (fm/s^2)
	/// </summary>
	public static class FemtoMetrePerSecondSqFactory {
		/// <summary>
        /// Create a quantity measured in FemtoMetrePerSecondSqs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, FemtoMetrePerSecondSq> fm_s2<T>(this T value) {
            return new Quantity<T, FemtoMetrePerSecondSq> (value);
        }
	}
}