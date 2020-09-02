namespace Qkmaxware.Units.Acceleration {
	/// <summary>
	/// Unit of measurement for MicroMetrePerSecondSq (um/s^2)
	/// </summary>
	public struct MicroMetrePerSecondSq : IAcceleration {
        public static string Name => "MicroMetrePerSecondSq";
        public static string Symbol => "um/s^2";
    }
	
	/// <summary>
	/// Extension method factory for generating MicroMetrePerSecondSq (um/s^2)
	/// </summary>
	public static class MicroMetrePerSecondSqFactory {
		/// <summary>
        /// Create a quantity measured in MicroMetrePerSecondSqs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MicroMetrePerSecondSq> um_s2<T>(this T value) {
            return new Quantity<T, MicroMetrePerSecondSq> (value);
        }
	}
}