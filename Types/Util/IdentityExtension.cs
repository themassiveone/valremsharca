using U.Types.Components;
using U.Types.Identities;

namespace U.Types.Util;
public static class IdentityExtension
{
    // public static T Get<T>(this T proxy)
    // where T : Identity => ProxyBase.GetInstance().Get(proxy);


    public static void Execute<T1, T2, T3>(this Identity identity, Action<T1, T2, T3> method, T1 t1, T2 t2, T3 t3)
    {

    }
    public static void Execute<T1, T2>(this Identity identity, Action<T1, T2> method, T1 t1, T2 t2)
    {

    }
    public static void Execute<T1>(this Identity identity, Action<T1> method, T1 t1)
    {

    }
    public static void Execute(this Identity identity, Action method)
    {

    }




}

public static class IdentityFactory<T, IT>
where T : class, Identity, IT, new()
where IT : Identity
{
    public static T Create(Identity creator) => ProxyBase.GetInstance().Create<Identity, T>(creator);
    public static T Get(T current, Identity accessor) => ProxyBase.GetInstance().Get<Identity, T>(current, accessor);
    public static T Set(T current, IT value, Identity allocator) => ProxyBase.GetInstance().Set<Identity, T, IT>(current, value, allocator);
}



public class VoidCall
{
    public Identity identity;
    public List<Argument> arguments = new List<Argument>();

}

public class Argument
{
    public string assemblyQualifiedTypeName;
    public object value;

}