namespace System.Units.Angle {

    public struct Radians : IAngle {
        public static string Name => "Radians";
        public static string Symbol => "rad";
    }

    public static class RadianFactory {
        /// <summary>
        /// Create a quantity measured in Radians
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Radians> rad<T>(this T value) {
            return value.As<T, Radians>();
        }
    }

}