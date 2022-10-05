using U.Types.Components;
using U.Types.Identities;
using U.Types.Interfaces;
using U.Types.Util;

namespace U.Implementations.Resources;


public class ResourceStore : IStore
{

    public Dictionary<Guid, Identity> identities { get; set; } = new Dictionary<Guid, Identity>();

    public void OnTick()
    {
        //testing only; no one would actually create stuff from the store
        Identity i = IdentityFactory<AResource, Resource>.Create(null);
        identities.Add(i.id, i);
    }
}