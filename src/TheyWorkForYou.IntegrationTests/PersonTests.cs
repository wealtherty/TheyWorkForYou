using FluentAssertions;
using TheyWorkForYou.Model;
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
    public async Task Get_Person_should_return_Nadia_Whittome()
    {
        var person = await _client.GetPersonAsync(TestData.NadiaWhittome.Id);
        person.Should().NotBeNull();
        person.Should().BeEquivalentTo(TestData.NadiaWhittome);
    }
    
    private static class TestData
    {
        public static readonly Person NadiaWhittome = new()
        {
            Id = "25845",
            FullName = "Nadia Whittome"
        };
    }
}