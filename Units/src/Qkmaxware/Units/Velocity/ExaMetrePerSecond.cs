namespace Qkmaxware.Units.Velocity {
	/// <summary>
	/// Unit of measurement for the ExaMetrePerSecond (Em/s)
	/// </summary>
	public struct ExaMetrePerSecond : IVelocity {
        public static string Name => "ExaMetrePerSecond";
        public static string Symbol => "Em/s";
    }
	
	/// <summary>
	///Extension method factory for generating ExaMetrePerSecond (Em/s)
	/// </summary>
	public static class ExaMetrePerSecondFactory {
		/// <summary>
        /// Create a quantity measured in ExaMetrePerSeconds
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ExaMetrePerSecond> Em_s<T>(this T value) {
            return new Quantity<T, ExaMetrePerSecond> (value);
        }
	}
}