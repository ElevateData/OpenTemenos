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
