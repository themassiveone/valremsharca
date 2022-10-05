using U.Types.Identities;

namespace U.Types.Interfaces;

public interface Resource : Identity
{
    //public ResourceType type { get; set; }
    public float value { get; set; }
    public float currentMax { get; set; }
    public float regen { get; set; }
}

public interface ResourceType : Identity { }

public interface UnitTypeResourceDefinition : Definition
{
    public bool isPrimary { get; set; }
    public ResourceType resourceType { get; set; }
}
public interface Effector : Identity
{

}