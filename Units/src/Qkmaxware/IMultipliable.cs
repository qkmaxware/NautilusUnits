namespace Qkmaxware {

/// <summary>
/// Interface representing a quantity than can be multiplied with another
/// </summary>
/// <typeparam name="R">Type which can be multiplied</typeparam>
/// <typeparam name="T">Type of the result from multiplication</typeparam>
public interface IMultipliable<R,T> {
    R Mul(T value);
}

}