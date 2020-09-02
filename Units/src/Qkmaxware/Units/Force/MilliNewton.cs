namespace Qkmaxware.Units.Force {
	/// <summary>
	/// Unit of measurement for MilliNewton (mN)
	/// </summary>
	public struct MilliNewton : IForce {
        public static string Name => "MilliNewton";
        public static string Symbol => "mN";
    }
	
	/// <summary>
	/// Extension method factory for generating MilliNewton (mN)
	/// </summary>
	public static class MilliNewtonFactory {
		/// <summary>
        /// Create a quantity measured in MilliNewtons
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MilliNewton> mN<T>(this T value) {
            return new Quantity<T, MilliNewton> (value);
        }
	}
}