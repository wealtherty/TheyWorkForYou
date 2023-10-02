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
    public async Task ApiKey_should_be_populated_by_user_secrets()
    {
        var result = await _client.GetApiKeyAsync();
        result.Should().NotBeNullOrEmpty();
    }
}