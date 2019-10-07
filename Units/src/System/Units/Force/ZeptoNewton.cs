namespace System.Units.Force {
	/// <summary>
	/// Unit of measurement for the ZeptoNewton (zN)
	/// </summary>
	public struct ZeptoNewton : IForce {
        public static string Name => "ZeptoNewton";
        public static string Symbol => "zN";
    }
	
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