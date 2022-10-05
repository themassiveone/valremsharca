using U.Types.Identities;

namespace U.Types.Util;

//should be part of validation component
//too vague
public interface AccessedBy<T>
where T : Identity
{
    public bool Access(T accessor);
}