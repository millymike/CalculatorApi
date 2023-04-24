using System.Numerics;

namespace Calculators.Features;

public interface ISimpleCalculator<T>
    where T : struct, IComparable, IConvertible, IEquatable<T>, IFormattable, INumberBase<T>
{
    T Add(T a, T b);
    T Subtract(T a, T b);
    T Multiply(T a, T b);
    T Divide(T a, T b);
}
