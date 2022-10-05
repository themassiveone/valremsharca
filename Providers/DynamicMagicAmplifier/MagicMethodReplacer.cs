using System.Reflection;
using U.Types;
using U.Types.Identities;
using HarmonyLib;
using U.Types.Interfaces;

namespace U.Providers.DynamicMagicAmplifier;

public class MagicMethodReplacer
{
    Harmony harmony;
    public MagicMethodReplacer()
    {
        harmony = new Harmony("0");

    }



    public void InjectIntoMethod(MethodInfo method)
    {
        //check later, lets try void without args first
        //method.GetGenericArguments();

        var needle = typeof(Doctor).GetMethod("InjectionSubstance");
        HarmonyMethod needleStich = new HarmonyMethod(needle);

        harmony.Patch(needle, needleStich);
    }

    public void Start()
    {
        Assembly typesAssembly = typeof(Identity).Assembly;
        Type[] types = typesAssembly.GetTypes().Where(x => x.IsAssignableTo(typeof(Identity))).ToArray();



        var needle = typeof(Doctor).GetMethod("InjectionSubstance");
        HarmonyMethod needleStich = new HarmonyMethod(needle);

        MethodInfo grow = typeof(Trunk).GetMethod("Grow");

        harmony.Patch(grow, needleStich);

        /*
        foreach (var type in types)
        {
            MethodInfo[] methods = type.GetMethods();
            foreach (var method in methods)
            {
                harmony.Patch(method, prefix: needleStich);
            }
        }

        */
    }
}

public class Doctor
{
    private static int needleCount = 0;
    public void InjectionSubstance()
    {
        //Console.WriteLine("Needle this: " + (++needleCount).ToString());

        int i = 3;
    }
}