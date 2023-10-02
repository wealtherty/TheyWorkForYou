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
    public async Task Get_Persons_should_return_Nadia_Whittome()
    {
        var persons = await _client.GetPersonAsync(TestData.NadiaWhittome.Id);
        persons.Should().NotBeNull();
        persons.Length.Should().Be(1);
        persons[0].Should().BeEquivalentTo(TestData.NadiaWhittome);
    }

    [Fact]
    public async Task Get_Persons_should_return_Jacob_Rees_Mogg()
    {
        var persons = await _client.GetPersonAsync(TestData.JacobReesMogg.Id);
        persons.Should().NotBeNull();
        persons.Length.Should().BeGreaterThan(1);

        foreach (var person in persons)
        {
            person.Should().BeEquivalentTo(TestData.JacobReesMogg);
        }
    }
    
    private static class TestData
    {
        public static readonly Person NadiaWhittome = new()
        {
            Id = "25845",
            FullName = "Nadia Whittome"
        };

        public static readonly Person JacobReesMogg = new()
        {
            Id = "24926",
            FullName = "Jacob Rees-Mogg"
        };
    }
}