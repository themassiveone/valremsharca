using U.Types.Identities;

namespace U.Types.Components;



public abstract class ProxyBase
{
    protected static ProxyBase single;
    public static ProxyBase GetInstance()
    {
        return single;
    }

    public abstract T Get<Actual, T>(T current, Actual accessor)
    where T : class, Identity, new();
    public abstract T Create<Actual, T>(Actual creator)
    where T : class, Identity, new();
    public abstract T Set<Actual, T, IT>(T current, IT value, Actual allocator)
    where T : class, Identity, new();

    public abstract void ExecuteAction(Action action);
    public abstract void ExecuteAction<T1>(Action action, T1 t1);
    public abstract void ExecuteAction<T1, T2>(Action action, T1 t1, T2 t2);
    public abstract void ExecuteAction<T1, T2, T3>(Action action, T1 t1, T2 t2, T3 t3);




}