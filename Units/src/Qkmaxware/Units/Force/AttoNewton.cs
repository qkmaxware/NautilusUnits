namespace Qkmaxware.Units.Force {
	/// <summary>
	/// Unit of measurement for the AttoNewton (aN)
	/// </summary>
	public struct AttoNewton : IForce {
        public static string Name => "AttoNewton";
        public static string Symbol => "aN";
    }
	
	/// <summary>
	///Extension method factory for generating AttoNewton (aN)
	/// </summary>
	public static class AttoNewtonFactory {
		/// <summary>
        /// Create a quantity measured in AttoNewtons
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, AttoNewton> aN<T>(this T value) {
            return new Quantity<T, AttoNewton> (value);
        }
	}
}