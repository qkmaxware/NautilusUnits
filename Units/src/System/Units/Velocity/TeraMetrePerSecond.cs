namespace System.Units.Velocity {
	/// <summary>
	/// Unit of measurement for the TeraMetrePerSecond (Tm/s)
	/// </summary>
	public struct TeraMetrePerSecond : IVelocity {
        public static string Name => "TeraMetrePerSecond";
        public static string Symbol => "Tm/s";
    }
	
	public static class TeraMetrePerSecondFactory {
		/// <summary>
        /// Create a quantity measured in TeraMetrePerSeconds
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, TeraMetrePerSecond> Tm_s<T>(this T value) {
            return new Quantity<T, TeraMetrePerSecond> (value);
        }
	}
}