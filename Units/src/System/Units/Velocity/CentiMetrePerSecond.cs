namespace System.Units.Velocity {
	/// <summary>
	/// Unit of measurement for the CentiMetrePerSecond (cm/s)
	/// </summary>
	public struct CentiMetrePerSecond : IVelocity {
        public static string Name => "CentiMetrePerSecond";
        public static string Symbol => "cm/s";
    }
	
	public static class CentiMetrePerSecondFactory {
		/// <summary>
        /// Create a quantity measured in CentiMetrePerSeconds
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, CentiMetrePerSecond> cm_s<T>(this T value) {
            return new Quantity<T, CentiMetrePerSecond> (value);
        }
	}
}