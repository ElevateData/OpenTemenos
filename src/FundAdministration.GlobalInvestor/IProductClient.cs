using FundAdministration.GlobalInvestor.Product.AdlDealingDetails;
using FundAdministration.GlobalInvestor.Product.ApproExproDefinitions;
using FundAdministration.GlobalInvestor.Product.CommissionGroups;
using FundAdministration.GlobalInvestor.Product.DelayDays;
using FundAdministration.GlobalInvestor.Product.EscalationChecks;
using FundAdministration.GlobalInvestor.Product.ExchangeGroups;
using FundAdministration.GlobalInvestor.Product.FixedCalendars;
using FundAdministration.GlobalInvestor.Product.FrequencyExceptionDays;
using FundAdministration.GlobalInvestor.Product.FrequencyExceptions;
using FundAdministration.GlobalInvestor.Product.FundCutoffTimes;
using FundAdministration.GlobalInvestor.Product.FundEscalationChecks;
using FundAdministration.GlobalInvestor.Product.FundGroupCutoffs;
using FundAdministration.GlobalInvestor.Product.FundManagers;
using FundAdministration.GlobalInvestor.Product.FundOfFunds;
using FundAdministration.GlobalInvestor.Product.FundPromoters;
using FundAdministration.GlobalInvestor.Product.FundTradingDeskTrans;
using FundAdministration.GlobalInvestor.Product.FundValueDates;
using FundAdministration.GlobalInvestor.Product.FxDetails;
using FundAdministration.GlobalInvestor.Product.HoldingLimits;
using FundAdministration.GlobalInvestor.Product.Holidays;
using FundAdministration.GlobalInvestor.Product.InitialSubscriptions;
using FundAdministration.GlobalInvestor.Product.MinDivPayments;
using FundAdministration.GlobalInvestor.Product.PerformanceFeeSetups;
using FundAdministration.GlobalInvestor.Product.PermissionCountries;
using FundAdministration.GlobalInvestor.Product.Securities;
using FundAdministration.GlobalInvestor.Product.SecurityDescs;
using FundAdministration.GlobalInvestor.Product.SecurityIds;
using FundAdministration.GlobalInvestor.Product.ShareClasses;
using FundAdministration.GlobalInvestor.Product.ShareValues;
using FundAdministration.GlobalInvestor.Product.SimulationCalendars;
using FundAdministration.GlobalInvestor.Product.SoftClosures;
using FundAdministration.GlobalInvestor.Product.StpCounterParts;
using FundAdministration.GlobalInvestor.Product.TaFunds;
using FundAdministration.GlobalInvestor.Product.TradeDateExceptions;
using FundAdministration.GlobalInvestor.Product.TransactionLimits;
using FundAdministration.GlobalInvestor.Product.TransactionRestrictions;

namespace FundAdministration.GlobalInvestor;

public interface IProductClient
{
    public IAdlDealingDetailService AntiDilutionLevyDealingService { get; }
    public IApproExproDefinitionService ApproOrExproDefinitionService { get; }
    public ICommissionGroupService CommissionGroupService { get; }
    public IFundGroupCutoffService CutoffByFundGroupService { get; }
    public IDelayDayService DelayDayService { get; }
    public IEscalationCheckService EscalationCheckService { get; }
    public IExchangeGroupService ExchangeGroupService { get; }
    public IFixedCalendarService FixedCalendarService { get; }
    public IFxDetailService ForexService { get; }
    public IFrequencyExceptionDayService FrequentExceptionDayService { get; }
    public IFrequencyExceptionService FrequentExceptionService { get; }
    public ITradeDateExceptionService FundCalendarExceptionService { get; }
    public IFundCutoffTimeService FundCutoffTimeService { get; }
    public IFundEscalationCheckService FundEscalationCheckService { get; }
    public IFundManagerService FundManagerService { get; }
    public IFundOfFundService FundOfFundService { get; }
    public IFundPromoterService FundPromoterService { get; }
    public IFundTradingDeskTranService FundTradingDeskService { get; }
    public IFundValueDateService FundValueDateService { get; }
    public IHoldingLimitService HoldingLimitService { get; }
    public IHolidayService HolidayService { get; }
    public IInitialSubscriptionService InitialSubscriptionService { get; }
    public IMinDivPaymentService MinDivPaymentService { get; }
    public IMasterFund MasterFund { get; }
    public IPerformanceFeeSetupService PerformanceFeeService { get; }
    public IPermissionCountryService PermissionCountryService { get; }
    public ISecurityDescService SecurityDescService { get; }
    public ISecurityIdService SecurityIdService { get; }
    public ISecurityService SecurityService { get; }
    public ISimulationCalendarService SimulationCalendarService { get; }
    public ISoftClosureService SoftClosureService { get; }
    public IStpCounterPartService StraightThroughProcessingCounterpartService { get; }
    public ITransactionLimitService TransactionLimitService { get; }
    public ITransactionRestrictionService TransactionRestrictionService { get; }
    public ITaFundService TransferAgentFundService { get; }
    public IShareClasseService TransferAgentFundShareClasService { get; }
    public IShareValueService TransferAgentFundShareValueService { get; }
    public ITradeDateExceptionService TradeDateExceptionService { get; }
    //public ITfcService TrustFundCompanyService { get; }
}
