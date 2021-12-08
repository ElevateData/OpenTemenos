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

    public PartyClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IBeneficiariesService BeneficiariesService => new BeneficiariesService(_httpClient);
    public ICustomerAdvertsService CustomerAdvertsService => new CustomerAdvertsService(_httpClient);
    public ICustomerArrangementsService CustomerArrangementsService => new CustomerArrangementsService(_httpClient);
    public ICustomerDeliveryPreferencesService CustomerDeliveryPreferencesService => new CustomerDeliveryPreferencesService(_httpClient);
    public ICustomerMandatesService CustomerMandatesService => new CustomerMandatesService(_httpClient);
    public ICustomerOpenBankingConnectionsService CustomerOpenBankingConnectionsService => new CustomerOpenBankingConnectionsService(_httpClient);
    public ICustomersContactHistoryService CustomersContactHistoryService => new CustomersContactHistoryService(_httpClient);
    public ICustomersDocumentsService CustomersDocumentsService => new CustomersDocumentsService(_httpClient);
    public ICustomerServicesService CustomerServicesService => new CustomerServicesService(_httpClient);
    public ICustomersMiFIDService CustomersMiFIDService => new CustomersMiFIDService(_httpClient);
    public IExternalUsersService ExternalUsersService => new ExternalUsersService(_httpClient);
    public IOnboardingCustomerService OnboardingCustomerService => new OnboardingCustomerService(_httpClient);
    public IParticipantListService ParticipantListService => new ParticipantListService(_httpClient);
    public ISaasBeneficiaryService SaasBeneficiaryService => new SaasBeneficiaryService(_httpClient);
    public ISecuritiesCustomerService SecuritiesCustomerService => new SecuritiesCustomerService(_httpClient);
    public ITravelNotificationsService TravelNotificationsService => new TravelNotificationsService(_httpClient);
    public IUsCustomerInformationService UsCustomerInformationService => new UsCustomerInformationService(_httpClient);
    public IUserAdminService UserAdminService => new UserAdminService(_httpClient);
}
