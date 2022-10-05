using U.Types.Identities;

namespace U.Types.Components;
public interface WebClient
{
    public Task<T> Get<T>(Service service);
}