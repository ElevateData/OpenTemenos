using OpenTemenos.FundAdministrations.GlobalInvestor.Product.AdlDealingDetails;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.ApproExproDefinitions;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.CommissionGroups;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.DelayDays;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.EscalationChecks;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.ExchangeGroups;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.FixedCalendars;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.FrequencyExceptionDays;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.FrequencyExceptions;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.FundCutoffTimes;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.FundEscalationChecks;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.FundGroupCutoffs;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.FundManagers;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.FundOfFunds;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.FundPromoters;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.FundTradingDeskTrans;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.FundValueDates;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.FxDetails;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.HoldingLimits;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.Holidays;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.InitialSubscriptions;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.MinDivPayments;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.PerformanceFeeSetups;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.PermissionCountries;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.Securities;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.SecurityDescs;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.SecurityIds;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.ShareClasses;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.ShareValues;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.SimulationCalendars;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.SoftClosures;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.StpCounterParts;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.TaFunds;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.TradeDateExceptions;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.TransactionLimits;
using OpenTemenos.FundAdministrations.GlobalInvestor.Product.TransactionRestrictions;

namespace OpenTemenos.FundAdministrations.GlobalInvestor;

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