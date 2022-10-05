using Microsoft.Extensions.Configuration;
using U.Types.Components;
using U.Types.Identities;

namespace U.Providers.ServiceIdentity;
public class ServiceIdentity : IServiceIdentity
{
    public Service currentService { get; init; }
    private IConfiguration configuration;
    public ServiceIdentity(IConfiguration configuration)
    {
        this.configuration = configuration;

        //TODO Try block this and log!!!
        var serviceSection = configuration.GetSection("Service");
        var serviceType = Enum.Parse<ServiceTypes>(serviceSection.GetSection("ServiceType").Value);
        var shardId = serviceSection.GetSection("Shard").Value;
        this.currentService = new Service(serviceType, new Shard(Convert.ToInt32(shardId)));
    }
    public Dictionary<Guid, Identity> identities { get; init; } = new Dictionary<Guid, Identity>();


    public object GetByIdentity(Guid id, string type)
    {
        throw new NotImplementedException();
    }
}