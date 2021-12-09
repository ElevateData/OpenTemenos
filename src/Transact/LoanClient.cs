namespace Transact;

public class LoanClient : ILoanClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public LoanClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
}
