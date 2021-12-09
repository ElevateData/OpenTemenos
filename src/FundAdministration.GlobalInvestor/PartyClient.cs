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
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public PartyClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IAddressesService AddressService => new AddressesService(_httpClient){BaseUrl = BaseUrl};

    public IAntiMoneyLaundering AntiMoneyLaundering => new AntiMoneyLaundering(_httpClient){BaseUrl = BaseUrl};

    public IAgentCutoffExceptionsService ExceptionCutoffForDistributorService => new AgentCutoffExceptionsService(_httpClient){BaseUrl = BaseUrl};

    public IFatcaCrs FatcaCrs => new FatcaCrs(_httpClient){BaseUrl = BaseUrl};

    public IAgentDistributionsService HierarchyTreeForAgentDistributionService => new AgentDistributionsService(_httpClient){BaseUrl = BaseUrl};
    public IAgentExceptionCutoffTimesService ExceptionCutoffPerDistributorService => new AgentExceptionCutoffTimesService(_httpClient){BaseUrl = BaseUrl};
    public IAgentsService DistributorService => new AgentsService(_httpClient){BaseUrl = BaseUrl};
    public IAgentVdExceptionsService ExceptionValueDateService => new AgentVdExceptionsService(_httpClient){BaseUrl = BaseUrl};
    public IBankAccountsService BankAccountService => new BankAccountsService(_httpClient){BaseUrl = BaseUrl};
    public ICentralRegistersService CentralRegisterService => new CentralRegistersService(_httpClient){BaseUrl = BaseUrl};
    public IClientsService InvestorService => new ClientsService(_httpClient){BaseUrl = BaseUrl};
    public ICommDistributionsService TransferAgentDistributionCommissionService => new CommDistributionsService(_httpClient){BaseUrl = BaseUrl};
    public ICommissionPaymentCurrencyService DistributorExceptionCommissionPaymentCurrencyService => new CommissionPaymentCurrencyService(_httpClient){BaseUrl = BaseUrl};
    public IContactHistoryService ContactHistoryService => new ContactHistoryService(_httpClient){BaseUrl = BaseUrl};
    public IDistributionAgreementService DistributionAgreementService => new DistributionAgreementService(_httpClient){BaseUrl = BaseUrl};
    public IDocumentCopiesService DocumentCopyService => new DocumentCopiesService(_httpClient){BaseUrl = BaseUrl};
    public IElectronicAddressesService ElectronicAddressService => new ElectronicAddressesService(_httpClient){BaseUrl = BaseUrl};
    public IFatcaTaxIdService TaxResidenceIdService => new FatcaTaxIdService(_httpClient){BaseUrl = BaseUrl};
    public IGroupCommDistributionsService TransferAgentGroupCommissionService => new GroupCommDistributionsService(_httpClient){BaseUrl = BaseUrl};
    public IImaDetailsService InvestmentManagementAccountService => new ImaDetailsService(_httpClient){BaseUrl = BaseUrl};
    public IInstructionsService ReinvestOrPayAllService => new InstructionsService(_httpClient){BaseUrl = BaseUrl};
    public IJointAccountsService JointAccountService => new JointAccountsService(_httpClient){BaseUrl = BaseUrl};
    public IMinLimitsExpiryService InvestorMinLimitExpiryService => new MinLimitsExpiryService(_httpClient){BaseUrl = BaseUrl};
    public IProfileSecurityService ProfileSecurityService => new ProfileSecurityService(_httpClient){BaseUrl = BaseUrl};
    public IProfilesService ProfileService => new ProfilesService(_httpClient){BaseUrl = BaseUrl};
    public IRegistersService InvestorAccountService => new RegistersService(_httpClient){BaseUrl = BaseUrl};
    public IReinvestPayService ReinvestOrPayService => new ReinvestPayService(_httpClient){BaseUrl = BaseUrl};
    public IRelationshipsService RelationshipService => new RelationshipsService(_httpClient){BaseUrl = BaseUrl};
    public ISecClearingAccountsService SecurityClearingAccountService => new SecClearingAccountsService(_httpClient){BaseUrl = BaseUrl};
    public ISettlementExceptionsService SettlementExceptionService => new SettlementExceptionsService(_httpClient){BaseUrl = BaseUrl};
    public ITaxIdDocumentsService TaxResidenceDocumentService => new TaxIdDocumentsService(_httpClient){BaseUrl = BaseUrl};
    public ITfAgentLinksService TrailerFreeAgentLinkService => new TfAgentLinksService(_httpClient){BaseUrl = BaseUrl};
    public ITfParentSubAgentLinksService ParentOrSubAgentLinkService => new TfParentSubAgentLinksService(_httpClient){BaseUrl = BaseUrl};
    public IUsTaxOptionsService UsTaxOptionService => new UsTaxOptionsService(_httpClient){BaseUrl = BaseUrl};
}
