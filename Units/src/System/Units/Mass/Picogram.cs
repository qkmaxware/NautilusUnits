namespace System.Units.Mass {
	/// <summary>
	/// Unit of measurement for the Picogram (pg)
	/// </summary>
	public struct Picogram : IMass {
        public static string Name => "Picogram";
        public static string Symbol => "pg";
    }
	
	public static class PicogramFactory {
		/// <summary>
        /// Create a quantity measured in Picograms
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Picogram> pg<T>(this T value) {
            return value.As<Picogram, T>();
        }
	}
}