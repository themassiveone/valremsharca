namespace U.Types.Identities;


public interface Identity
{
    //always create amongs subsidiary Identities:
    //Tree1 has all of its leaves and Trunk on the Same Service
    public Guid id { get; init; }

    //if shard is null => fetch shard by id first
    public Shard? shard { get; set; }
    public ServiceTypes serviceType { get; }

}


