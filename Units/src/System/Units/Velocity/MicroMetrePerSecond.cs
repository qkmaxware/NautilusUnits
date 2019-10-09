namespace System.Units.Velocity {
	/// <summary>
	/// Unit of measurement for the MicroMetrePerSecond (um/s)
	/// </summary>
	public struct MicroMetrePerSecond : IVelocity {
        public static string Name => "MicroMetrePerSecond";
        public static string Symbol => "um/s";
    }
	
	public static class MicroMetrePerSecondFactory {
		/// <summary>
        /// Create a quantity measured in MicroMetrePerSeconds
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, MicroMetrePerSecond> um_s<T>(this T value) {
            return new Quantity<T, MicroMetrePerSecond> (value);
        }
	}
}