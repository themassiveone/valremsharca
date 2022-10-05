namespace U.Types.Identities;

public class Service
{
    //Has to be requested on startup
    public ServiceTypes serviceType;
    public Shard shard;
    public Service(ServiceTypes service, Shard shard)
    {
        this.serviceType = service;
        this.shard = shard;
    }

}

public enum ServiceTypes
{
    Resources,
    Nature,
    Landscaping,
}