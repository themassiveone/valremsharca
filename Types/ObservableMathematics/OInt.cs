using U.Types.Identities;

namespace U.Types.ObservableMathematics;

public struct OInt : IEquatable<int>//, IComparable, IComparable<Int32>//, IConvertible
{
    private int backing { get; set; }
    public OInt(int value)
    {
        backing = value;
    }
    public static OInt operator +(OInt left, OInt right)
    {
        return new OInt(left.backing + right.backing);
    }

    public bool Equals(int other) => other == backing;

    public static explicit operator OInt(int value) => new OInt(value);
    public static implicit operator int(OInt me) => me.backing;
    public static implicit operator int?(OInt me) => me.backing;
}
