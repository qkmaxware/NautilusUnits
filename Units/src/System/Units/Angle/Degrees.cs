namespace System.Units.Angle {

    public struct Degrees : IAngle {
        public static string Name => "Degrees";
        public static string Symbol => "°";
    }

    public static class DegreeFactory {
        /// <summary>
        /// Create a quantity measured in Degrees
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Degrees> deg<T>(this T value) {
            return value.As<Degrees, T>();
        }
    }

}