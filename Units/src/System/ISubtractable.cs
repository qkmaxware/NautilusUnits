namespace System {

/// <summary>
/// Interface representing a quantity than can be subtracted with another
/// </summary>
/// <typeparam name="R">Type which can be subtracted</typeparam>
/// <typeparam name="T">Type of the result from subtraction</typeparam>
public interface ISubtractable<R,T> {
    R Sub(T value);
}

}