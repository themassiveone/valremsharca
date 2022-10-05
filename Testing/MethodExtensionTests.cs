using System;
using NSubstitute;
using U.Types.Interfaces;
using U.Types.ObservableMathematics;
using U.Types.Util;
using Xunit;

namespace U.Testing;

public class MethodExtensionTests
{
    private readonly Tree tree = Substitute.For<Tree>();
    private readonly Trunk trunk = Substitute.For<Trunk>();

    public MethodExtensionTests()
    {

    }

    [Fact]
    public void GrowTree_ShouldGrow()
    {
        //Arrange

        //Act
        trunk.Execute<OInt>(trunk.Grow, (OInt)40);

        //Assert
        Assert.Equal(40, trunk.lenght);

    }

}