using OpenTemenos.FundAdministrations.GlobalInvestor.Party;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.Addresses;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.AgentCutoffExceptions;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.AgentDistributions;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.AgentExceptionCutoffTimes;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.Agents;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.AgentVdExceptions;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.BankAccounts;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.CentralRegisters;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.Clients;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.CommDistributions;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.CommissionPaymentCurrencies;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.ContactHistories;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.DistributionAgreements;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.DocumentCopies;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.ElectronicAddresses;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.FatcaTaxIds;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.GroupCommDistributions;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.ImaDetails;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.Instructions;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.JointAccounts;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.MinLimitsExpiries;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.Profiles;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.ProfileSecurities;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.Registers;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.ReinvestPay;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.Relationships;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.SecClearingAccounts;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.SettlementExceptions;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.TaxIdDocuments;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.TfAgentLinks;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.TfParentSubAgentLinks;
using OpenTemenos.FundAdministrations.GlobalInvestor.Party.UsTaxOptions;
using OpenTemenos.Shared.Data;

namespace OpenTemenos.FundAdministrations.GlobalInvestor;

public class PartyClient : IPartyClient
{
    private readonly HttpClient _httpClient;

    public PartyClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public IAddressService AddressService => new AddressService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAntiMoneyLaundering AntiMoneyLaundering => new AntiMoneyLaundering(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAgentCutoffExceptionService ExceptionCutoffForDistributorService =>
        new AgentCutoffExceptionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFatcaCrs FatcaCrs => new FatcaCrs(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAgentDistributionService HierarchyTreeForAgentDistributionService =>
        new AgentDistributionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAgentExceptionCutoffTimeService ExceptionCutoffPerDistributorService =>
        new AgentExceptionCutoffTimeService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAgentService DistributorService => new AgentService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IAgentVdExceptionService ExceptionValueDateService => new AgentVdExceptionService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IBankAccountService BankAccountService => new BankAccountService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICentralRegisterService CentralRegisterService => new CentralRegisterService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IClientService InvestorService => new ClientService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICommDistributionService TransferAgentDistributionCommissionService =>
        new CommDistributionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICommissionPaymentCurrencyService DistributorExceptionCommissionPaymentCurrencyService =>
        new CommissionPaymentCurrencyService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IContactHistoryService ContactHistoryService => new ContactHistoryService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IDistributionAgreementService DistributionAgreementService => new DistributionAgreementService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IDocumentCopyService DocumentCopyService => new DocumentCopyService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IElectronicAddressService ElectronicAddressService => new ElectronicAddressService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFatcaTaxIdService TaxResidenceIdService => new FatcaTaxIdService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IGroupCommDistributionService TransferAgentGroupCommissionService =>
        new GroupCommDistributionService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IImaDetailService InvestmentManagementAccountService => new ImaDetailService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IInstructionService ReinvestOrPayAllService => new InstructionService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IJointAccountService JointAccountService => new JointAccountService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IMinLimitsExpiryService InvestorMinLimitExpiryService => new MinLimitsExpiryService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IProfileSecurityService ProfileSecurityService => new ProfileSecurityService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IProfileService ProfileService => new ProfileService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRegisterService InvestorAccountService => new RegisterService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IReinvestPayService ReinvestOrPayService => new ReinvestPayService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IRelationshipService RelationshipService => new RelationshipService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISecClearingAccountService SecurityClearingAccountService => new SecClearingAccountService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISettlementExceptionService SettlementExceptionService => new SettlementExceptionService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITaxIdDocumentService TaxResidenceDocumentService => new TaxIdDocumentService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITfAgentLinkService TrailerFreeAgentLinkService => new TfAgentLinkService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITfParentSubAgentLinkService ParentOrSubAgentLinkService => new TfParentSubAgentLinkService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IUsTaxOptionService UsTaxOptionService => new UsTaxOptionService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}