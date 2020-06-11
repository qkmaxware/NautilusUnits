namespace Qkmaxware.Units.Velocity {
	/// <summary>
	/// Unit of measurement for the FemtoMetrePerSecond (fm/s)
	/// </summary>
	public struct FemtoMetrePerSecond : IVelocity {
        public static string Name => "FemtoMetrePerSecond";
        public static string Symbol => "fm/s";
    }
	
	/// <summary>
	///Extension method factory for generating FemtoMetrePerSecond (fm/s)
	/// </summary>
	public static class FemtoMetrePerSecondFactory {
		/// <summary>
        /// Create a quantity measured in FemtoMetrePerSeconds
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, FemtoMetrePerSecond> fm_s<T>(this T value) {
            return new Quantity<T, FemtoMetrePerSecond> (value);
        }
	}
}