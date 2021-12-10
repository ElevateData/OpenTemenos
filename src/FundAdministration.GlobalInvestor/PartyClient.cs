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
using FundAdministration.GlobalInvestor.Party.CommissionPaymentCurrencies;
using FundAdministration.GlobalInvestor.Party.ContactHistories;
using FundAdministration.GlobalInvestor.Party.DistributionAgreements;
using FundAdministration.GlobalInvestor.Party.DocumentCopies;
using FundAdministration.GlobalInvestor.Party.ElectronicAddresses;
using FundAdministration.GlobalInvestor.Party.FatcaTaxIds;
using FundAdministration.GlobalInvestor.Party.GroupCommDistributions;
using FundAdministration.GlobalInvestor.Party.ImaDetails;
using FundAdministration.GlobalInvestor.Party.Instructions;
using FundAdministration.GlobalInvestor.Party.JointAccounts;
using FundAdministration.GlobalInvestor.Party.MinLimitsExpiries;
using FundAdministration.GlobalInvestor.Party.Profiles;
using FundAdministration.GlobalInvestor.Party.ProfileSecurities;
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
    public IAddressService AddressService => new AddressService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAntiMoneyLaundering AntiMoneyLaundering => new AntiMoneyLaundering(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAgentCutoffExceptionService ExceptionCutoffForDistributorService => new AgentCutoffExceptionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFatcaCrs FatcaCrs => new FatcaCrs(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAgentDistributionService HierarchyTreeForAgentDistributionService => new AgentDistributionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IAgentExceptionCutoffTimeService ExceptionCutoffPerDistributorService => new AgentExceptionCutoffTimeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IAgentService DistributorService => new AgentService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IAgentVdExceptionService ExceptionValueDateService => new AgentVdExceptionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IBankAccountService BankAccountService => new BankAccountService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICentralRegisterService CentralRegisterService => new CentralRegisterService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IClientService InvestorService => new ClientService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICommDistributionService TransferAgentDistributionCommissionService => new CommDistributionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICommissionPaymentCurrencyService DistributorExceptionCommissionPaymentCurrencyService => new CommissionPaymentCurrencyService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IContactHistoryService ContactHistoryService => new ContactHistoryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IDistributionAgreementService DistributionAgreementService => new DistributionAgreementService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IDocumentCopyService DocumentCopyService => new DocumentCopyService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IElectronicAddressService ElectronicAddressService => new ElectronicAddressService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFatcaTaxIdService TaxResidenceIdService => new FatcaTaxIdService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IGroupCommDistributionService TransferAgentGroupCommissionService => new GroupCommDistributionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IImaDetailService InvestmentManagementAccountService => new ImaDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IInstructionService ReinvestOrPayAllService => new InstructionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IJointAccountService JointAccountService => new JointAccountService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IMinLimitsExpiryService InvestorMinLimitExpiryService => new MinLimitsExpiryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IProfileSecurityService ProfileSecurityService => new ProfileSecurityService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IProfileService ProfileService => new ProfileService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IRegisterService InvestorAccountService => new RegisterService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IReinvestPayService ReinvestOrPayService => new ReinvestPayService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IRelationshipService RelationshipService => new RelationshipService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISecClearingAccountService SecurityClearingAccountService => new SecClearingAccountService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISettlementExceptionService SettlementExceptionService => new SettlementExceptionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITaxIdDocumentService TaxResidenceDocumentService => new TaxIdDocumentService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITfAgentLinkService TrailerFreeAgentLinkService => new TfAgentLinkService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITfParentSubAgentLinkService ParentOrSubAgentLinkService => new TfParentSubAgentLinkService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IUsTaxOptionService UsTaxOptionService => new UsTaxOptionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
