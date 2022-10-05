namespace U.Types.Identities;
public interface Definition
{
    public Guid id { get; set; }
    public ServiceTypes serviceType { get; }

}