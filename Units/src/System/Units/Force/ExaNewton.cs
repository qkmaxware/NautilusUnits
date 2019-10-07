namespace System.Units.Force {
	/// <summary>
	/// Unit of measurement for the ExaNewton (EN)
	/// </summary>
	public struct ExaNewton : IForce {
        public static string Name => "ExaNewton";
        public static string Symbol => "EN";
    }
	
	public static class ExaNewtonFactory {
		/// <summary>
        /// Create a quantity measured in ExaNewtons
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, ExaNewton> EN<T>(this T value) {
            return new Quantity<T, ExaNewton> (value);
        }
	}
}