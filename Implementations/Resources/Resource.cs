using U.Types.Identities;
using U.Types.Interfaces;

namespace U.Implementations.Resources;
public class AResource : T0<Resource>, Resource
{
    public float value { get; set; }
    public float currentMax { get; set; }
    public float regen { get; set; }

    public override ServiceTypes serviceType => ServiceTypes.Resources;
}