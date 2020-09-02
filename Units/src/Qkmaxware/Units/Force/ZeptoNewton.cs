namespace Qkmaxware.Units.Force {
	/// <summary>
	/// Unit of measurement for ZeptoNewton (zN)
	/// </summary>
	public struct ZeptoNewton : IForce {
        public static string Name => "ZeptoNewton";
        public static string Symbol => "zN";
    }
	
	/// <summary>
	/// Extension method factory for generating ZeptoNewton (zN)
	/// </summary>
	public static class ZeptoNewtonFactory {
		/// <summary>
        /// Create a quantity measured in ZeptoNewtons
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZeptoNewton> zN<T>(this T value) {
            return new Quantity<T, ZeptoNewton> (value);
        }
	}
}