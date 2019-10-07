namespace System.Units.Force {
	/// <summary>
	/// Unit of measurement for the YottaNewton (YN)
	/// </summary>
	public struct YottaNewton : IForce {
        public static string Name => "YottaNewton";
        public static string Symbol => "YN";
    }
	
	public static class YottaNewtonFactory {
		/// <summary>
        /// Create a quantity measured in YottaNewtons
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YottaNewton> YN<T>(this T value) {
            return new Quantity<T, YottaNewton> (value);
        }
	}
}