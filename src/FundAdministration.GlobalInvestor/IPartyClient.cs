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

namespace OpenTemenos.FundAdministrations.GlobalInvestor;

public interface IPartyClient
{
    public IAddressService AddressService { get; }
    public IAntiMoneyLaundering AntiMoneyLaundering { get; }
    public IBankAccountService BankAccountService { get; }
    public ICentralRegisterService CentralRegisterService { get; }
    public IContactHistoryService ContactHistoryService { get; }
    public IDistributionAgreementService DistributionAgreementService { get; }
    public ICommissionPaymentCurrencyService DistributorExceptionCommissionPaymentCurrencyService { get; }
    public IAgentService DistributorService { get; }
    public IDocumentCopyService DocumentCopyService { get; }
    public IElectronicAddressService ElectronicAddressService { get; }
    public IAgentExceptionCutoffTimeService ExceptionCutoffPerDistributorService { get; }
    public IAgentVdExceptionService ExceptionValueDateService { get; }
    public IAgentCutoffExceptionService ExceptionCutoffForDistributorService { get; }
    public IFatcaCrs FatcaCrs { get; }
    public IAgentDistributionService HierarchyTreeForAgentDistributionService { get; }
    public IImaDetailService InvestmentManagementAccountService { get; }
    public IRegisterService InvestorAccountService { get; }
    public IClientService InvestorService { get; }
    public IMinLimitsExpiryService InvestorMinLimitExpiryService { get; }
    public IJointAccountService JointAccountService { get; }
    public ITfParentSubAgentLinkService ParentOrSubAgentLinkService { get; }
    public IProfileService ProfileService { get; }
    public IProfileSecurityService ProfileSecurityService { get; }
    public IInstructionService ReinvestOrPayAllService { get; }
    public IReinvestPayService ReinvestOrPayService { get; }
    public IRelationshipService RelationshipService { get; }
    public ISecClearingAccountService SecurityClearingAccountService { get; }
    public ISettlementExceptionService SettlementExceptionService { get; }
    public ITaxIdDocumentService TaxResidenceDocumentService { get; }
    public IFatcaTaxIdService TaxResidenceIdService { get; }
    public ITfAgentLinkService TrailerFreeAgentLinkService { get; }
    public ICommDistributionService TransferAgentDistributionCommissionService { get; }
    public IGroupCommDistributionService TransferAgentGroupCommissionService { get; }
    public IUsTaxOptionService UsTaxOptionService { get; }
}