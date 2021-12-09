using Transact.Party;
using Transact.Party.Beneficiaries;
using Transact.Party.CustomerAdverts;
using Transact.Party.CustomerArrangements;
using Transact.Party.CustomerDeliveryPreferences;
using Transact.Party.CustomerMandates;
using Transact.Party.CustomerOpenBankingConnections;
using Transact.Party.CustomersContactHistory;
using Transact.Party.CustomersDocuments;
using Transact.Party.CustomerServices;
using Transact.Party.CustomersMiFID;
using Transact.Party.ExternalUsers;
using Transact.Party.OnboardingCustomerX;
using Transact.Party.ParticipantList;
using Transact.Party.SaasBeneficiary;
using Transact.Party.SecuritiesCustomerX;
using Transact.Party.TravelNotifications;
using Transact.Party.UsCustomerInformation;
using Transact.Party.UserAdmin;

namespace Transact;

public class PartyClient : IPartyClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public PartyClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IBeneficiariesService BeneficiariesService => new BeneficiariesService(_httpClient) { BaseUrl = BaseUrl };
    public ICustomerAdvertsService CustomerAdvertsService => new CustomerAdvertsService(_httpClient) { BaseUrl = BaseUrl };
    public ICustomerArrangementsService CustomerArrangementsService => new CustomerArrangementsService(_httpClient) { BaseUrl = BaseUrl };
    public ICustomerDeliveryPreferencesService CustomerDeliveryPreferencesService => new CustomerDeliveryPreferencesService(_httpClient) { BaseUrl = BaseUrl };
    public ICustomerMandatesService CustomerMandatesService => new CustomerMandatesService(_httpClient) { BaseUrl = BaseUrl };
    public ICustomerOpenBankingConnectionsService CustomerOpenBankingConnectionsService => new CustomerOpenBankingConnectionsService(_httpClient) { BaseUrl = BaseUrl };
    public ICustomersContactHistoryService CustomersContactHistoryService => new CustomersContactHistoryService(_httpClient) { BaseUrl = BaseUrl };
    public ICustomersDocumentsService CustomersDocumentsService => new CustomersDocumentsService(_httpClient) { BaseUrl = BaseUrl };
    public ICustomerServicesService CustomerServicesService => new CustomerServicesService(_httpClient) { BaseUrl = BaseUrl };
    public ICustomersMiFIDService CustomersMiFIDService => new CustomersMiFIDService(_httpClient) { BaseUrl = BaseUrl };
    public IExternalUsersService ExternalUsersService => new ExternalUsersService(_httpClient) { BaseUrl = BaseUrl };
    public IOnboardingCustomerService OnboardingCustomerService => new OnboardingCustomerService(_httpClient) { BaseUrl = BaseUrl };
    public IParticipantListService ParticipantListService => new ParticipantListService(_httpClient) { BaseUrl = BaseUrl };
    public ISaasBeneficiaryService SaasBeneficiaryService => new SaasBeneficiaryService(_httpClient) { BaseUrl = BaseUrl };
    public ISecuritiesCustomerService SecuritiesCustomerService => new SecuritiesCustomerService(_httpClient) { BaseUrl = BaseUrl };
    public ITravelNotificationsService TravelNotificationsService => new TravelNotificationsService(_httpClient) { BaseUrl = BaseUrl };
    public IUsCustomerInformationService UsCustomerInformationService => new UsCustomerInformationService(_httpClient) { BaseUrl = BaseUrl };
    public IUserAdminService UserAdminService => new UserAdminService(_httpClient) { BaseUrl = BaseUrl };
}
