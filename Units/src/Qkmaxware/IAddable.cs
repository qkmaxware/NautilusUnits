namespace Qkmaxware {

/// <summary>
/// Interface representing a quantity than can be added with another
/// </summary>
/// <typeparam name="R">Type which can be added</typeparam>
/// <typeparam name="T">Type of the result from addition</typeparam>
public interface IAddable<R,T> {
    R Add(T value);
}

}