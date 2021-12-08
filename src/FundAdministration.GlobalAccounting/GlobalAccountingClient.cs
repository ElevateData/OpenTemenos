namespace FundAdministration.GlobalAccounting;

public class GlobalAccountingClient : IGlobalAccountingClient
{
    private readonly HttpClient _httpClient;

    public GlobalAccountingClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IHoldingClient Holding => new HoldingClient(_httpClient);

    public IOrderClient Order => new OrderClient(_httpClient);

    public IReferenceClient Reference => new ReferenceClient(_httpClient);
}
