using U.Types.Identities;
using U.Types.ObservableMathematics;

namespace U.Types.Interfaces;
public interface Tree : Identity
{
    public Trunk trunk { get; set; }
}


public interface Trunk : Identity
{
    public string name { get; set; }
    public OInt lenght { get; set; }

    public List<Branch> branches { get; set; }

    public void Grow(OInt value);
}

public interface Branch : Identity
{

}

public interface Leaf : Identity
{

}