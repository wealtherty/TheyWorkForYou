using FluentAssertions;
using Xunit;

namespace TheyWorkForYou.IntegrationTests;

public class PersonTests
{
    private readonly Client _client;

    public PersonTests(Client client)
    {
        _client = client;
    }

    [Fact]
    public async Task Person_should_not_be_null()
    {
        const string id = "bob";

        var person = await _client.GetPersonAsync(id);
        person.Should().NotBeNull();
    }

    [Fact]
    public async Task Id_should_be_populated()
    {
        const string id = "bob";
        
        var person = await _client.GetPersonAsync(id);
        person.Id.Should().Be(id);
    }
}