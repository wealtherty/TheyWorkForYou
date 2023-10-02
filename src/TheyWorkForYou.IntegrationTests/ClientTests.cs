using FluentAssertions;
using Xunit;

namespace TheyWorkForYou.IntegrationTests;

public class ClientTests
{
    [Fact]
    public async Task Get_bool_should_be_true()
    {
        var client = new Client();
        var result = await client.GetBoolAsync();
        result.Should().BeTrue();
    }
}