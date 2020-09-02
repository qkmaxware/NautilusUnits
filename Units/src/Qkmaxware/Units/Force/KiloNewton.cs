namespace Qkmaxware.Units.Force {
	/// <summary>
	/// Unit of measurement for KiloNewton (kN)
	/// </summary>
	public struct KiloNewton : IForce {
        public static string Name => "KiloNewton";
        public static string Symbol => "kN";
    }
	
	/// <summary>
	/// Extension method factory for generating KiloNewton (kN)
	/// </summary>
	public static class KiloNewtonFactory {
		/// <summary>
        /// Create a quantity measured in KiloNewtons
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, KiloNewton> kN<T>(this T value) {
            return new Quantity<T, KiloNewton> (value);
        }
	}
}