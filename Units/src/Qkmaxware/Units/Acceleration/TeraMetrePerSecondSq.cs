namespace Qkmaxware.Units.Acceleration {
	/// <summary>
	/// Unit of measurement for TeraMetrePerSecondSq (Tm/s^2)
	/// </summary>
	public struct TeraMetrePerSecondSq : IAcceleration {
        public static string Name => "TeraMetrePerSecondSq";
        public static string Symbol => "Tm/s^2";
    }
	
	/// <summary>
	/// Extension method factory for generating TeraMetrePerSecondSq (Tm/s^2)
	/// </summary>
	public static class TeraMetrePerSecondSqFactory {
		/// <summary>
        /// Create a quantity measured in TeraMetrePerSecondSqs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, TeraMetrePerSecondSq> Tm_s2<T>(this T value) {
            return new Quantity<T, TeraMetrePerSecondSq> (value);
        }
	}
}