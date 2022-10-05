using U.Types.Identities;

namespace U.Types.Components;
public interface IStore
{
    public Dictionary<Guid, Identity> identities { get; set; }
    public void OnTick();


}