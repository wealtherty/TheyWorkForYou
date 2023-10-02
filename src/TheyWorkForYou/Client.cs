using TheyWorkForYou.Model;

namespace TheyWorkForYou;

public class Client
{
    private readonly Settings _settings;
    private readonly HttpClient _httpClient;

    public Client(Settings settings)
    {
        _settings = settings;
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri(settings.Domain)
        };
    }
    
    public async Task<Person[]> GetPersonAsync(string id, CancellationToken cancellationToken = default)
    {
        var requestUri = $"/api/getPerson?id={id}&output=json&key={_settings.ApiKey}";
        
        var response = await _httpClient.GetAsync(requestUri, cancellationToken).ConfigureAwait(false);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsJsonAsync<Person[]>();
    }
}