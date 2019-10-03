namespace System.Units.Time {

    public struct Year : ITime {
        public static string Name => "Year";
        public static string Symbol => "yr";
    }

    public static class YearFactory {
        /// <summary>
        /// Create a quantity measured in Years
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Year> yr<T>(this T value) {
            return value.As<Year, T>();
        }
    }

}