namespace Qkmaxware.Units.Force {
	/// <summary>
	/// Unit of measurement for MegaNewton (MN)
	/// </summary>
	public struct MegaNewton : IForce {
        public static string Name => "MegaNewton";
        public static string Symbol => "MN";
    }
	
	/// <summary>
	/// Extension method factory for generating MegaNewton (MN)
	/// </summary>
	public static class MegaNewtonFactory {
		/// <summary>
        /// Create a quantity measured in MegaNewtons
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MegaNewton> MN<T>(this T value) {
            return new Quantity<T, MegaNewton> (value);
        }
	}
}