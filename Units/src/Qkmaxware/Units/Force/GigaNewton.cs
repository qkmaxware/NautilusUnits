namespace Qkmaxware.Units.Force {
	/// <summary>
	/// Unit of measurement for the GigaNewton (GN)
	/// </summary>
	public struct GigaNewton : IForce {
        public static string Name => "GigaNewton";
        public static string Symbol => "GN";
    }
	
	/// <summary>
	///Extension method factory for generating GigaNewton (GN)
	/// </summary>
	public static class GigaNewtonFactory {
		/// <summary>
        /// Create a quantity measured in GigaNewtons
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, GigaNewton> GN<T>(this T value) {
            return new Quantity<T, GigaNewton> (value);
        }
	}
}