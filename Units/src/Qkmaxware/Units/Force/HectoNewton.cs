namespace Qkmaxware.Units.Force {
	/// <summary>
	/// Unit of measurement for HectoNewton (hN)
	/// </summary>
	public struct HectoNewton : IForce {
        public static string Name => "HectoNewton";
        public static string Symbol => "hN";
    }
	
	/// <summary>
	/// Extension method factory for generating HectoNewton (hN)
	/// </summary>
	public static class HectoNewtonFactory {
		/// <summary>
        /// Create a quantity measured in HectoNewtons
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, HectoNewton> hN<T>(this T value) {
            return new Quantity<T, HectoNewton> (value);
        }
	}
}