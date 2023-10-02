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
    public async Task Get_Person_should_return_Nadia_Whittome()
    {
        var person = await _client.GetPersonAsync(TestData.NadiaWhittome.PersonId);
        person.Should().NotBeNull();
        person.Id.Should().Be(TestData.NadiaWhittome.PersonId);
        person.FullName.Should().Be(TestData.NadiaWhittome.FullName);
    }
    
    private static class TestData
    {
        public static class NadiaWhittome
        {
            public const string PersonId = "25845";
            public const string FullName = "Nadia Whittome";
        }
    }
}