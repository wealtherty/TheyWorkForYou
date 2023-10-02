namespace TheyWorkForYou;

public class Client
{
    public Task<bool> GetBoolAsync()
    {
        return Task.FromResult(true);
    }
}