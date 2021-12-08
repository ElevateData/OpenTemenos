using DataHub.AnalyticDataStore.Party;
using DataHub.AnalyticDataStore.Party.AllCustomerSegmentationDetails;

namespace DataHub.AnalyticDataStore;

public class PartyClient : IPartyClient
{
    private readonly HttpClient _httpClient;

    public PartyClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public IAllCustomerSegmentationDetailsService CustomerSegmentationService =>
        new AllCustomerSegmentationDetailsService(_httpClient);
}
