using U.Types.Identities;

namespace U.Types.Components;
public interface IServiceIdentity
{
    public Service currentService { get; init; }
    public object GetByIdentity(Guid id, string type);
}