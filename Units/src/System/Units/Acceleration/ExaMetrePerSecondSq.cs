namespace System.Units.Acceleration {
	/// <summary>
	/// Unit of measurement for the ExaMetrePerSecondSq (Em/s^2)
	/// </summary>
	public struct ExaMetrePerSecondSq : IAcceleration {
        public static string Name => "ExaMetrePerSecondSq";
        public static string Symbol => "Em/s^2";
    }
	
    /// <summary>
	/// Extension method factory for generating ExaMetrePerSecondSq (Em/s^2) 
	/// </summary>
	public static class ExaMetrePerSecondSqFactory {
		/// <summary>
        /// Create a quantity measured in ExaMetrePerSecondSqs
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ExaMetrePerSecondSq> Em_s2<T>(this T value) {
            return new Quantity<T, ExaMetrePerSecondSq> (value);
        }
	}
}