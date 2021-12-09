using DataHub.AnalyticDataStore.Party;
using DataHub.AnalyticDataStore.Party.AllCustomerSegmentationDetails;

namespace DataHub.AnalyticDataStore;

public class PartyClient : IPartyClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public PartyClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IAllCustomerSegmentationDetailsService CustomerSegmentationService =>
        new AllCustomerSegmentationDetailsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
