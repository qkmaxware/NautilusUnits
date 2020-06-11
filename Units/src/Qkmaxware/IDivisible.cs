namespace Qkmaxware {

/// <summary>
/// Interface representing a quantity than can be divided with another
/// </summary>
/// <typeparam name="R">Type which can be divided</typeparam>
/// <typeparam name="T">Type of the result from division</typeparam>
public interface IDivisible<R,T> {
    R Div(T value);
}

}