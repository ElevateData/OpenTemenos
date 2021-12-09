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
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public PartyClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IAddressesService AddressService => new AddressesService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAntiMoneyLaundering AntiMoneyLaundering => new AntiMoneyLaundering(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAgentCutoffExceptionsService ExceptionCutoffForDistributorService => new AgentCutoffExceptionsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFatcaCrs FatcaCrs => new FatcaCrs(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAgentDistributionsService HierarchyTreeForAgentDistributionService => new AgentDistributionsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IAgentExceptionCutoffTimesService ExceptionCutoffPerDistributorService => new AgentExceptionCutoffTimesService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IAgentsService DistributorService => new AgentsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IAgentVdExceptionsService ExceptionValueDateService => new AgentVdExceptionsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IBankAccountsService BankAccountService => new BankAccountsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICentralRegistersService CentralRegisterService => new CentralRegistersService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IClientsService InvestorService => new ClientsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICommDistributionsService TransferAgentDistributionCommissionService => new CommDistributionsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICommissionPaymentCurrencyService DistributorExceptionCommissionPaymentCurrencyService => new CommissionPaymentCurrencyService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IContactHistoryService ContactHistoryService => new ContactHistoryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IDistributionAgreementService DistributionAgreementService => new DistributionAgreementService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IDocumentCopiesService DocumentCopyService => new DocumentCopiesService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IElectronicAddressesService ElectronicAddressService => new ElectronicAddressesService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFatcaTaxIdService TaxResidenceIdService => new FatcaTaxIdService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IGroupCommDistributionsService TransferAgentGroupCommissionService => new GroupCommDistributionsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IImaDetailsService InvestmentManagementAccountService => new ImaDetailsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IInstructionsService ReinvestOrPayAllService => new InstructionsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IJointAccountsService JointAccountService => new JointAccountsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IMinLimitsExpiryService InvestorMinLimitExpiryService => new MinLimitsExpiryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IProfileSecurityService ProfileSecurityService => new ProfileSecurityService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IProfilesService ProfileService => new ProfilesService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IRegistersService InvestorAccountService => new RegistersService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IReinvestPayService ReinvestOrPayService => new ReinvestPayService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IRelationshipsService RelationshipService => new RelationshipsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISecClearingAccountsService SecurityClearingAccountService => new SecClearingAccountsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISettlementExceptionsService SettlementExceptionService => new SettlementExceptionsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITaxIdDocumentsService TaxResidenceDocumentService => new TaxIdDocumentsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITfAgentLinksService TrailerFreeAgentLinkService => new TfAgentLinksService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITfParentSubAgentLinksService ParentOrSubAgentLinkService => new TfParentSubAgentLinksService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsTaxOptionsService UsTaxOptionService => new UsTaxOptionsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
