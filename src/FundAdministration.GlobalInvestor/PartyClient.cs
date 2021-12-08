using FundAdministration.GlobalInvestor.Party;
using FundAdministration.GlobalInvestor.Party.Addresses;
using FundAdministration.GlobalInvestor.Party.AgentCutoffExceptions;
using FundAdministration.GlobalInvestor.Party.AgentDistributions;
using FundAdministration.GlobalInvestor.Party.AgentExceptionCutoffTimes;
using FundAdministration.GlobalInvestor.Party.Agents;
using FundAdministration.GlobalInvestor.Party.AgentVdExceptions;
using FundAdministration.GlobalInvestor.Party.BankAccounts;
using FundAdministration.GlobalInvestor.Party.CentralRegisters;
using FundAdministration.GlobalInvestor.Party.Clients;
using FundAdministration.GlobalInvestor.Party.CommDistributions;
using FundAdministration.GlobalInvestor.Party.CommissionPaymentCurrency;
using FundAdministration.GlobalInvestor.Party.ContactHistory;
using FundAdministration.GlobalInvestor.Party.DistributionAgreement;
using FundAdministration.GlobalInvestor.Party.DocumentCopies;
using FundAdministration.GlobalInvestor.Party.ElectronicAddresses;
using FundAdministration.GlobalInvestor.Party.FatcaTaxId;
using FundAdministration.GlobalInvestor.Party.GroupCommDistributions;
using FundAdministration.GlobalInvestor.Party.ImaDetails;
using FundAdministration.GlobalInvestor.Party.Instructions;
using FundAdministration.GlobalInvestor.Party.JointAccounts;
using FundAdministration.GlobalInvestor.Party.MinLimitsExpiry;
using FundAdministration.GlobalInvestor.Party.Profiles;
using FundAdministration.GlobalInvestor.Party.ProfileSecurity;
using FundAdministration.GlobalInvestor.Party.Registers;
using FundAdministration.GlobalInvestor.Party.ReinvestPay;
using FundAdministration.GlobalInvestor.Party.Relationships;
using FundAdministration.GlobalInvestor.Party.SecClearingAccounts;
using FundAdministration.GlobalInvestor.Party.SettlementExceptions;
using FundAdministration.GlobalInvestor.Party.TaxIdDocuments;
using FundAdministration.GlobalInvestor.Party.TfAgentLinks;
using FundAdministration.GlobalInvestor.Party.TfParentSubAgentLinks;
using FundAdministration.GlobalInvestor.Party.UsTaxOptions;

namespace FundAdministration.GlobalInvestor;

public class PartyClient : IPartyClient
{
    private readonly HttpClient _httpClient;

    public PartyClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IAddressesService AddressService => new AddressesService(_httpClient);

    public IAntiMoneyLaundering AntiMoneyLaundering => new AntiMoneyLaundering(_httpClient);

    public IAgentCutoffExceptionsService ExceptionCutoffForDistributorService => new AgentCutoffExceptionsService(_httpClient);

    public IFatcaCrs FatcaCrs => new FatcaCrs(_httpClient);

    public IAgentDistributionsService HierarchyTreeForAgentDistributionService => new AgentDistributionsService(_httpClient);
    public IAgentExceptionCutoffTimesService ExceptionCutoffPerDistributorService => new AgentExceptionCutoffTimesService(_httpClient);
    public IAgentsService DistributorService => new AgentsService(_httpClient);
    public IAgentVdExceptionsService ExceptionValueDateService => new AgentVdExceptionsService(_httpClient);
    public IBankAccountsService BankAccountService => new BankAccountsService(_httpClient);
    public ICentralRegistersService CentralRegisterService => new CentralRegistersService(_httpClient);
    public IClientsService InvestorService => new ClientsService(_httpClient);
    public ICommDistributionsService TransferAgentDistributionCommissionService => new CommDistributionsService(_httpClient);
    public ICommissionPaymentCurrencyService DistributorExceptionCommissionPaymentCurrencyService => new CommissionPaymentCurrencyService(_httpClient);
    public IContactHistoryService ContactHistoryService => new ContactHistoryService(_httpClient);
    public IDistributionAgreementService DistributionAgreementService => new DistributionAgreementService(_httpClient);
    public IDocumentCopiesService DocumentCopyService => new DocumentCopiesService(_httpClient);
    public IElectronicAddressesService ElectronicAddressService => new ElectronicAddressesService(_httpClient);
    public IFatcaTaxIdService TaxResidenceIdService => new FatcaTaxIdService(_httpClient);
    public IGroupCommDistributionsService TransferAgentGroupCommissionService => new GroupCommDistributionsService(_httpClient);
    public IImaDetailsService InvestmentManagementAccountService => new ImaDetailsService(_httpClient);
    public IInstructionsService ReinvestOrPayAllService => new InstructionsService(_httpClient);
    public IJointAccountsService JointAccountService => new JointAccountsService(_httpClient);
    public IMinLimitsExpiryService InvestorMinLimitExpiryService => new MinLimitsExpiryService(_httpClient);
    public IProfileSecurityService ProfileSecurityService => new ProfileSecurityService(_httpClient);
    public IProfilesService ProfileService => new ProfilesService(_httpClient);
    public IRegistersService InvestorAccountService => new RegistersService(_httpClient);
    public IReinvestPayService ReinvestOrPayService => new ReinvestPayService(_httpClient);
    public IRelationshipsService RelationshipService => new RelationshipsService(_httpClient);
    public ISecClearingAccountsService SecurityClearingAccountService => new SecClearingAccountsService(_httpClient);
    public ISettlementExceptionsService SettlementExceptionService => new SettlementExceptionsService(_httpClient);
    public ITaxIdDocumentsService TaxResidenceDocumentService => new TaxIdDocumentsService(_httpClient);
    public ITfAgentLinksService TrailerFreeAgentLinkService => new TfAgentLinksService(_httpClient);
    public ITfParentSubAgentLinksService ParentOrSubAgentLinkService => new TfParentSubAgentLinksService(_httpClient);
    public IUsTaxOptionsService UsTaxOptionService => new UsTaxOptionsService(_httpClient);
}
