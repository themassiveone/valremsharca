using U.Implementation.Nature;
using U.Types.Components;
using U.Types.Identities;
using U.Types.Interfaces;
using U.Types.Util;

namespace U.Implementations.Nature;
public class NatureStore : IStore
{
    public Dictionary<Guid, Identity> identities { get; set; } = new Dictionary<Guid, Identity>();

    public List<Tree> trees = new List<Tree>();

    public void OnTick()
    {
        //trees.Add(new Tree());
        Tree tree = new ATree();
        if (tree.trunk == null)
            tree.trunk = new ATrunk()
            {
                name = "test"
            };
        
        // tree.trunk




    }

}