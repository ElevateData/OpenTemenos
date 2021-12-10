using Transact.Party;
using Transact.Party.Beneficiaries;
using Transact.Party.CustomerAdverts;
using Transact.Party.CustomerArrangements;
using Transact.Party.CustomerDeliveryPreferences;
using Transact.Party.CustomerMandates;
using Transact.Party.CustomerOpenBankingConnections;
using Transact.Party.Customers;
using Transact.Party.CustomersContactHistories;
using Transact.Party.CustomersDocuments;
using Transact.Party.CustomersMiFIDs;
using Transact.Party.ExternalUsers;
using Transact.Party.OnboardingCustomers;
using Transact.Party.ParticipantLists;
using Transact.Party.SaasBeneficiaries;
using Transact.Party.SecuritiesCustomers;
using Transact.Party.TravelNotifications;
using Transact.Party.UsCustomerInformations;
using Transact.Party.UserAdmins;

namespace Transact;

public class PartyClient : IPartyClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public PartyClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IBeneficiaryService BeneficiaryService => new BeneficiaryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICustomerAdvertService CustomerAdvertService => new CustomerAdvertService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICustomerArrangementService CustomerArrangementService => new CustomerArrangementService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICustomerDeliveryPreferenceService CustomerDeliveryPreferenceService => new CustomerDeliveryPreferenceService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICustomerMandateService CustomerMandateService => new CustomerMandateService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICustomerOpenBankingConnectionService CustomerOpenBankingConnectionService => new CustomerOpenBankingConnectionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICustomersContactHistoryService CustomersContactHistoryService => new CustomersContactHistoryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICustomersDocumentService CustomersDocumentService => new CustomersDocumentService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICustomerService CustomerService => new CustomerService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICustomersMiFIDService CustomersMiFIDService => new CustomersMiFIDService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IExternalUserService ExternalUserService => new ExternalUserService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IOnboardingCustomerService OnboardingCustomerService => new OnboardingCustomerService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IParticipantListService ParticipantListService => new ParticipantListService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISaasBeneficiaryService SaasBeneficiaryService => new SaasBeneficiaryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISecuritiesCustomerService SecuritiesCustomerService => new SecuritiesCustomerService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITravelNotificationService TravelNotificationService => new TravelNotificationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsCustomerInformationService UsCustomerInformationService => new UsCustomerInformationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUserAdminService UserAdminService => new UserAdminService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
