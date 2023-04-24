using System.Numerics;

namespace Calculators.Features;

public class SimpleCalculator<T> : ISimpleCalculator<T>
    where T : struct, IComparable, IConvertible, IEquatable<T>, IFormattable, INumberBase<T>
{
    public T Add(T a, T b)
    {
        return a + b;
    }

    public T Subtract(T a, T b)
    {
        return a - b;
    }

    public T Multiply(T a, T b)
    {
        return a * b;
    }

    public T Divide(T a, T b)
    {
        return a / b;
    }
}
