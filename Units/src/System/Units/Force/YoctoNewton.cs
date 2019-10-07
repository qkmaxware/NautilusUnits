namespace System.Units.Force {
	/// <summary>
	/// Unit of measurement for the YoctoNewton (yN)
	/// </summary>
	public struct YoctoNewton : IForce {
        public static string Name => "YoctoNewton";
        public static string Symbol => "yN";
    }
	
	public static class YoctoNewtonFactory {
		/// <summary>
        /// Create a quantity measured in YoctoNewtons
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, YoctoNewton> yN<T>(this T value) {
            return new Quantity<T, YoctoNewton> (value);
        }
	}
}