namespace TheyWorkForYou;

public class Client
{
    private readonly Settings _settings;

    public Client(Settings settings)
    {
        _settings = settings;
    }

    public Task<string> GetApiKeyAsync()
    {
        return Task.FromResult(_settings.ApiKey);
    }

    public Task<Person> GetPersonAsync(string id)
    {
        return Task.FromResult(new Person
        {
            Id = id
        });
    }
}

public class Person
{
    public string Id { get; set; }
}