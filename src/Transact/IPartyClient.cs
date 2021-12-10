using Transact.Party.Beneficiaries;
using Transact.Party.CustomerAdverts;
using Transact.Party.CustomerArrangements;
using Transact.Party.CustomerDeliveryPreferences;
using Transact.Party.CustomerMandates;
using Transact.Party.CustomerOpenBankingConnections;
using Transact.Party.CustomersContactHistory;
using Transact.Party.CustomersDocuments;
using Transact.Party.CustomersMiFID;
using Transact.Party.CustomerX;
using Transact.Party.ExternalUsers;
using Transact.Party.OnboardingCustomerX;
using Transact.Party.ParticipantList;
using Transact.Party.SaasBeneficiary;
using Transact.Party.SecuritiesCustomerX;
using Transact.Party.TravelNotifications;
using Transact.Party.UsCustomerInformation;
using Transact.Party.UserAdmin;

namespace Transact;

//TODO: Rename Transact.IPartyClient methods
public interface IPartyClient
{
    public IBeneficiariesService BeneficiariesService { get; }
    public ICustomerAdvertsService CustomerAdvertsService { get; }
    public ICustomerArrangementsService CustomerArrangementsService { get; }
    public ICustomerDeliveryPreferencesService CustomerDeliveryPreferencesService { get; }
    public ICustomerMandatesService CustomerMandatesService { get; }
    public ICustomerOpenBankingConnectionsService CustomerOpenBankingConnectionsService { get; }
    public ICustomersContactHistoryService CustomersContactHistoryService { get; }
    public ICustomersDocumentsService CustomersDocumentsService { get; }
    public ICustomerService CustomerService { get; }
    public ICustomersMiFIDService CustomersMiFIDService { get; }
    public IExternalUsersService ExternalUsersService { get; }
    public IOnboardingCustomerService OnboardingCustomerService { get; }
    public IParticipantListService ParticipantListService { get; }
    public ISaasBeneficiaryService SaasBeneficiaryService { get; }
    public ISecuritiesCustomerService SecuritiesCustomerService { get; }
    public ITravelNotificationsService TravelNotificationsService { get; }
    public IUsCustomerInformationService UsCustomerInformationService { get; }
    public IUserAdminService UserAdminService { get; }
}