namespace U.Types.Components;
public interface ValidationProvider
{
    public bool Validate<T>(T accessed);
}