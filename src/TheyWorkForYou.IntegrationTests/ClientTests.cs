using FluentAssertions;
using Xunit;

namespace TheyWorkForYou.IntegrationTests;

public class ClientTests
{
    private readonly Client _client;

    public ClientTests(Client client)
    {
        _client = client;
    }

    [Fact]
    public async Task Get_bool_should_be_true()
    {
        var result = await _client.GetBoolAsync();
        result.Should().BeTrue();
    }
}