using U.Types.Components;
using U.Types.Identities;

namespace U.Providers.Proxying;
public class Proxying : ProxyBase
{
    private IServiceIdentity serviceIdentity;
    public Proxying(IServiceIdentity serviceIdentity)
    {
        this.serviceIdentity = serviceIdentity;
        single = this;
        Console.WriteLine($"proxy created: {ProxyBase.GetInstance()}");
    }

    public override T Create<Actual, T>(Actual creator)
    {
        return new T() { id = Guid.Parse("4e61fdb0535f4a5f91ac88c5f1e27f0f") };
    }

    public override void ExecuteAction(Action action)
    {
        if (action.Target is Identity identity)
        {
            if (identity.serviceType != serviceIdentity.currentService.serviceType)
                throw new NotImplementedException("do remote invocation");
            if (identity.shard != serviceIdentity.currentService.shard)
                throw new NotImplementedException("do remote invocation");

            //Invoke locally
            action.Invoke();

            throw new NotImplementedException("Persistence Log missing");

        }
    }

    public override void ExecuteAction<T1>(Action action, T1 t1)
    {
        throw new NotImplementedException();
    }

    public override void ExecuteAction<T1, T2>(Action action, T1 t1, T2 t2)
    {
        throw new NotImplementedException();
    }

    public override void ExecuteAction<T1, T2, T3>(Action action, T1 t1, T2 t2, T3 t3)
    {
        throw new NotImplementedException();
    }

    public override T Get<Actual, T>(T current, Actual accessor)
    {
        return current;
    }

    public override T Set<Actual, T, IT>(T current, IT value, Actual allocator)
    {
        return (dynamic)value;
    }




    // public override T Get<T>(T proxy)
    // {

    //     //this should also happen on proxying provider
    //     //not on this service?

    //     if (proxy.serviceType != serviceIdentity.currentService.serviceType)
    //         throw new NotImplementedException("Should go to other Services Loadbalancer and / get shard?");

    //     //not on this shard
    //     if (proxy.shard is null)
    //         throw new NotImplementedException("go get shard from identity provider");


    //     //this is the actual one
    //     return proxy;
    // }

}