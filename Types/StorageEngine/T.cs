using U.Types.Identities;
using U.Types.Util;

namespace U.Types.StorageEngine;
public abstract class AT1<Actual, T1, IT1> : T0<Actual>
where Actual : Identity
where T1 : class, Identity, IT1, new()
where IT1 : Identity
{
    public AT1(
        T1 t1 = null
        )
    {
        _t1 = t1 == null ? IdentityFactory<T1, IT1>.Create(this) : t1;

    }
    private T1 _t1;
    protected IT1 t1Get() => IdentityFactory<T1, IT1>.Get(_t1, this);
    protected void t1Set(IT1 t1) => _t1 = IdentityFactory<T1, IT1>.Set(_t1, t1, this);

}
