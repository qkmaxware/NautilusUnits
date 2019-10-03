namespace System.Units.Time {

    public struct Day : ITime {
        public static string Name => "Day";
        public static string Symbol => "day";
    }

    public static class DayFactory {
        /// <summary>
        /// Create a quantity measured in Days
        /// </summary>
        /// <param name="value">measured value</param>
        /// <typeparam name="T">type of measured value</typeparam>
        /// <returns>quantity with value and units</returns>
        public static Quantity<T, Day> days<T>(this T value) {
            return value.As<Day, T>();
        }
    }

}