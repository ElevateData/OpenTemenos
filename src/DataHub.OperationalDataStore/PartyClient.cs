using OpenTemenos.DataHubs.OperationalDataStore.Party;
using OpenTemenos.DataHubs.OperationalDataStore.Party.CustomerDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Party.ExternalUserDetails;
using OpenTemenos.DataHubs.OperationalDataStore.Party.ParticipantLists;
using OpenTemenos.DataHubs.OperationalDataStore.Party.UsCustomerDetails;
using OpenTemenos.Shared.Data;

namespace OpenTemenos.DataHubs.OperationalDataStore;

public class PartyClient : IPartyClient
{
    private readonly HttpClient _httpClient;

    public PartyClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public ICustomerDetailService CustomerDetailService => new CustomerDetailService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IExternalUserDetailService ExternalUserDetailService => new ExternalUserDetailService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IParticipantListService ParticipantListService => new ParticipantListService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IUsCustomerDetailService UsModelBankCustomerDetailService =>
        new UsCustomerDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}