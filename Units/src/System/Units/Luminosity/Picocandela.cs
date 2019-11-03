namespace System.Units.Luminosity {
	/// <summary>
	/// Unit of measurement for the PicoCandela (pcd)
	/// </summary>
	public struct PicoCandela : ILuminosity {
        public static string Name => "PicoCandela";
        public static string Symbol => "pcd";
    }
	
	/// <summary>
	///Extension method factory for generating PicoCandela (pcd)
	/// </summary>
	public static class PicoCandelaFactory {
		/// <summary>
        /// Create a quantity measured in PicoCandelas
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, PicoCandela> pcd<T>(this T value) {
            return new Quantity<T, PicoCandela> (value);
        }
	}
}