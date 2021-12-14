using OpenTemenos.DataHubs.AnalyticDataStore.Party;
using OpenTemenos.DataHubs.AnalyticDataStore.Party.AllCustomerSegmentationDetails;
using OpenTemenos.Shared.Data;

namespace OpenTemenos.DataHubs.AnalyticDataStore;

public class PartyClient : IPartyClient
{
    private readonly HttpClient _httpClient;

    public PartyClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public IAllCustomerSegmentationDetailService CustomerSegmentationService =>
        new AllCustomerSegmentationDetailService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}