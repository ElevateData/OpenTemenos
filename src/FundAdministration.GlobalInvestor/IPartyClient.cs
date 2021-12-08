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

public interface IPartyClient
{
    public IAddressesService AddressService { get; }
    public IAntiMoneyLaundering AntiMoneyLaundering { get; }
    public IBankAccountsService BankAccountService { get; }
    public ICentralRegistersService CentralRegisterService { get; }
    public IContactHistoryService ContactHistoryService { get; }
    public IDistributionAgreementService DistributionAgreementService { get; }
    public ICommissionPaymentCurrencyService DistributorExceptionCommissionPaymentCurrencyService { get; }
    public IAgentsService DistributorService { get; }
    public IDocumentCopiesService DocumentCopyService { get; }
    public IElectronicAddressesService ElectronicAddressService { get; }
    public IAgentExceptionCutoffTimesService ExceptionCutoffPerDistributorService { get; }
    public IAgentVdExceptionsService ExceptionValueDateService { get; }
    public IAgentCutoffExceptionsService ExceptionCutoffForDistributorService { get; }
    public IFatcaCrs FatcaCrs { get; }
    public IAgentDistributionsService HierarchyTreeForAgentDistributionService { get; }
    public IImaDetailsService InvestmentManagementAccountService { get; }
    public IRegistersService InvestorAccountService { get; }
    public IClientsService InvestorService { get; }
    public IMinLimitsExpiryService InvestorMinLimitExpiryService { get; }
    public IJointAccountsService JointAccountService { get; }
    public ITfParentSubAgentLinksService ParentOrSubAgentLinkService { get; }
    public IProfilesService ProfileService { get; }
    public IProfileSecurityService ProfileSecurityService { get; }
    public IInstructionsService ReinvestOrPayAllService { get; }
    public IReinvestPayService ReinvestOrPayService { get; }
    public IRelationshipsService RelationshipService { get; }
    public ISecClearingAccountsService SecurityClearingAccountService { get; }
    public ISettlementExceptionsService SettlementExceptionService { get; }
    public ITaxIdDocumentsService TaxResidenceDocumentService { get; }
    public IFatcaTaxIdService TaxResidenceIdService { get; }
    public ITfAgentLinksService TrailerFreeAgentLinkService { get; }
    public ICommDistributionsService TransferAgentDistributionCommissionService { get; }
    public IGroupCommDistributionsService TransferAgentGroupCommissionService { get; }
    public IUsTaxOptionsService UsTaxOptionService { get; }
}
