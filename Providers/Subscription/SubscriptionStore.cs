using U.Types.Identities;
using U.Types.Components;

namespace UI.Providers.Subscription;

public class SubscriptionStore : IStore
{
    public Dictionary<Guid, SubscriptionElement> Identities = new Dictionary<Guid, SubscriptionElement>();

    public Dictionary<Guid, Identity> identities { get; set; }

    public void OnTick()
    {
    }
}


public class SubscriptionElement
{
    //actual object
    public Identity identity { get; set; }
    public Service service { get; set; }
    public Shard shard { get; set; }
}
