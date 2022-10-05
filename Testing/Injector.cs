using System;
using System.Reflection;
using NSubstitute;
using U.Providers.DynamicMagicAmplifier;
using U.Types.Interfaces;
using U.Types.ObservableMathematics;
using Xunit;

namespace U.Testing;

public class Injector
{
    private readonly U.Providers.Wrapper.Injector magic = new U.Providers.Wrapper.Injector();

    private readonly Trunk tree = Substitute.For<Trunk>();

    public Injector()
    {



    }
    private static int count;

    [Fact]
    public void DoctorInjectsThings()
    {
        MethodInfo method = GetType().GetMethod("Injection");
        magic.InjectMethod(method);


        Injection();
        Injection();
        Injection();
    }

    public void Injection()
    {
        Console.WriteLine("Normal" + count);

    }
}