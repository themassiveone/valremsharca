using U.Types.Interfaces;
using U.Types.Identities;
using U.Types.Util;
using U.Types.StorageEngine;
using U.Types.ObservableMathematics;

namespace U.Implementation.Nature;

public class ATree : AT1<Tree, ATrunk, Trunk>, Tree
{
    public override ServiceTypes serviceType => ServiceTypes.Nature;

    public Trunk trunk
    {
        get => t1Get();
        set => t1Set(value);
    }


}
public class ATrunk : T0<Trunk>, Trunk
{
    public string name { get; set; }

    public override ServiceTypes serviceType => ServiceTypes.Nature;

    public List<Branch> branches { get; set; }
    public OInt lenght { get; set; }

    public void Grow(OInt value)
    {
        lenght += value;
    }
}
