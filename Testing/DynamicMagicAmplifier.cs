using NSubstitute;
using U.Providers.DynamicMagicAmplifier;
using U.Types.Interfaces;
using U.Types.ObservableMathematics;
using Xunit;

namespace U.Testing;

public class DynamicMagicAmplifier
{
    private readonly MagicMethodReplacer magic = new MagicMethodReplacer();

    private readonly Trunk tree = Substitute.For<Trunk>();

    public DynamicMagicAmplifier()
    {



    }

    [Fact]
    public void DoctorInjectsThings()
    {
        magic.Start();

        tree.Grow(new OInt(3445));

    }
}