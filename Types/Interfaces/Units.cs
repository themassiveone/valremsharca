using U.Types.Identities;

namespace U.Types.Interfaces;
public interface Unit : Identity
{
    public UnitType type { get; set; }
}

public interface UnitType : Definition
{
    public List<UnitTypeResourceDefinition> resourceDefinitions { get; set; }
}