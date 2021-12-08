namespace Transact;

public class LoanClient : ILoanClient
{
    private readonly HttpClient _httpClient;

    public LoanClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
}
