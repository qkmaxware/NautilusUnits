namespace Qkmaxware.Units.Acceleration {
	/// <summary>
	/// Unit of measurement for CentiMetrePerSecondSq (cm/s^2)
	/// </summary>
	public struct CentiMetrePerSecondSq : IAcceleration {
        public static string Name => "CentiMetrePerSecondSq";
        public static string Symbol => "cm/s^2";
    }
	
	/// <summary>
	/// Extension method factory for generating CentiMetrePerSecondSq (cm/s^2)
	/// </summary>
	public static class CentiMetrePerSecondSqFactory {
		/// <summary>
        /// Create a quantity measured in CentiMetrePerSecondSqs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, CentiMetrePerSecondSq> cm_s2<T>(this T value) {
            return new Quantity<T, CentiMetrePerSecondSq> (value);
        }
	}
}