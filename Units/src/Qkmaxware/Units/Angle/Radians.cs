namespace Qkmaxware.Units.Angle {

    public struct Radians : IAngle {
        public static string Name => "Radians";
        public static string Symbol => "rad";
    }

    /// <summary>
	///Extension method factory for generating Radian (rad)
	/// </summary>
	public static class RadianFactory {
        /// <summary>
        /// Create a quantity measured in Radians
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Radians> rad<T>(this T value) {
            return value.As<Radians, T>();
        }
    }

}