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
        var person = await _client.GetPersonAsync(TestData.NadiaWhittome.PersonId);
        person.Should().NotBeNull();
    }

    [Fact]
    public async Task Id_should_be_populated()
    {
        var person = await _client.GetPersonAsync(TestData.NadiaWhittome.PersonId);
        person.Id.Should().Be(TestData.NadiaWhittome.PersonId);
    }

    private static class TestData
    {
        public static class NadiaWhittome
        {
            public const string PersonId = "25845";
        }
    }
}