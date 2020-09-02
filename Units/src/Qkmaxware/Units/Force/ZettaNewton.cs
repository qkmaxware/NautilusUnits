namespace Qkmaxware.Units.Force {
	/// <summary>
	/// Unit of measurement for ZettaNewton (ZN)
	/// </summary>
	public struct ZettaNewton : IForce {
        public static string Name => "ZettaNewton";
        public static string Symbol => "ZN";
    }
	
	/// <summary>
	/// Extension method factory for generating ZettaNewton (ZN)
	/// </summary>
	public static class ZettaNewtonFactory {
		/// <summary>
        /// Create a quantity measured in ZettaNewtons
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ZettaNewton> ZN<T>(this T value) {
            return new Quantity<T, ZettaNewton> (value);
        }
	}
}