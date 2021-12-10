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

//TODO: Rename Transact.IPartyClient methods
public interface IPartyClient
{
    public IBeneficiaryService BeneficiaryService { get; }
    public ICustomerAdvertService CustomerAdvertService { get; }
    public ICustomerArrangementService CustomerArrangementService { get; }
    public ICustomerDeliveryPreferenceService CustomerDeliveryPreferenceService { get; }
    public ICustomerMandateService CustomerMandateService { get; }
    public ICustomerOpenBankingConnectionService CustomerOpenBankingConnectionService { get; }
    public ICustomersContactHistoryService CustomersContactHistoryService { get; }
    public ICustomersDocumentService CustomersDocumentService { get; }
    public ICustomerService CustomerService { get; }
    public ICustomersMiFIDService CustomersMiFIDService { get; }
    public IExternalUserService ExternalUserService { get; }
    public IOnboardingCustomerService OnboardingCustomerService { get; }
    public IParticipantListService ParticipantListService { get; }
    public ISaasBeneficiaryService SaasBeneficiaryService { get; }
    public ISecuritiesCustomerService SecuritiesCustomerService { get; }
    public ITravelNotificationService TravelNotificationService { get; }
    public IUsCustomerInformationService UsCustomerInformationService { get; }
    public IUserAdminService UserAdminService { get; }
}