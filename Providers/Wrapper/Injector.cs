using System.Reflection;
using U.Providers.DynamicMagicAmplifier;

namespace U.Providers.Wrapper;

public class Injector
{
    private MagicMethodReplacer magicMethodReplacer;
    public Injector()
    {
        this.magicMethodReplacer = new MagicMethodReplacer();
    }


    public void InjectIntoMethods(List<Assembly> assemblies)
    {
        foreach (var assembly in assemblies)
        {

        }
    }

    public void InjectIntoProperties(List<Assembly> assemblies)
    {

    }

    public void InjectMethod(MethodInfo method)
    {
        magicMethodReplacer.InjectIntoMethod(method);


    }
}