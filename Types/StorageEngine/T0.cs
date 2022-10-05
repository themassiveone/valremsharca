using U.Types.Identities;

public abstract class T0<Actual> : Identity
where Actual : Identity
{

    public Guid id { get; init; }
    public Shard? shard { get; set; }

    public abstract ServiceTypes serviceType { get; }
}