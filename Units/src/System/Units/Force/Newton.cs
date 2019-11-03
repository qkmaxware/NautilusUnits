namespace System.Units.Force {
	/// <summary>
	/// Unit of measurement for the Newton (N)
	/// </summary>
	public struct Newton : IForce {
        public static string Name => "Newton";
        public static string Symbol => "N";
    }
	
	/// <summary>
	///Extension method factory for generating Newton (N)
	/// </summary>
	public static class NewtonFactory {
		/// <summary>
        /// Create a quantity measured in Newtons
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Newton> N<T>(this T value) {
            return new Quantity<T, Newton> (value);
        }
	}
}