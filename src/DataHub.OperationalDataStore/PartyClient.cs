using DataHub.OperationalDataStore.Party;
using DataHub.OperationalDataStore.Party.CustomerDetails;
using DataHub.OperationalDataStore.Party.ExternalUserDetails;
using DataHub.OperationalDataStore.Party.ParticipantList;
using DataHub.OperationalDataStore.Party.UsCustomerDetails;

namespace DataHub.OperationalDataStore;

public class PartyClient : IPartyClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public PartyClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public ICustomerDetailsService CustomerDetailService => new CustomerDetailsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IExternalUserDetailsService ExternalUserDetailService => new ExternalUserDetailsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IParticipantListService ParticipantListService => new ParticipantListService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IUsCustomerDetailsService UsModelBankCustomerDetailService =>
        new UsCustomerDetailsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
