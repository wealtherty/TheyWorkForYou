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
            person.Id.Should().Be(TestData.JacobReesMogg.Id);
            person.GivenName.Should().Be(TestData.JacobReesMogg.GivenName);
            person.FamilyName.Should().Be(TestData.JacobReesMogg.FamilyName);
            person.FullName.Should().Be(TestData.JacobReesMogg.FullName);
            person.Constituency.Should().Be(TestData.JacobReesMogg.Constituency);
            person.House.Should().Be(TestData.JacobReesMogg.House);
            person.Party.Should().Be(TestData.JacobReesMogg.Party);

            person.MemberId.Should().NotBeNullOrEmpty();
            person.EnteredReason.Should().NotBeNullOrEmpty();
        }
    }
    
    private static class TestData
    {
        public static readonly Person NadiaWhittome = new()
        {
            Id = "25845",
            Title = string.Empty,
            GivenName = "Nadia",
            FamilyName = "Whittome",
            FullName = "Nadia Whittome",
            Constituency = "Nottingham East",
            House = House.HouseOfCommons,
            Party = "Labour",
            MemberId = "42304",
            EnteredHouse = new DateTime(2019, 12, 13),
            EnteredReason = "general_election",
            LeftHouse = null,
            LeftReason = "still_in_office",
            Url = "https://www.theyworkforyou.com/mp/25845/nadia_whittome/nottingham_east",
            Image = "https://www.theyworkforyou.com/people-images/mpsL/25845.jpg"
        };

        public static readonly Person JacobReesMogg = new()
        {
            Id = "24926",
            GivenName = "Jacob",
            FamilyName = "Rees-Mogg",
            FullName = "Jacob Rees-Mogg",
            Constituency = "North East Somerset",
            House = House.HouseOfCommons,
            Party = "Conservative",
        };
    }
}