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
using FundAdministration.GlobalInvestor.Product.FundGroupCutoff;
using FundAdministration.GlobalInvestor.Product.FundManagers;
using FundAdministration.GlobalInvestor.Product.FundOfFunds;
using FundAdministration.GlobalInvestor.Product.FundPromoters;
using FundAdministration.GlobalInvestor.Product.FundTradingDeskTrans;
using FundAdministration.GlobalInvestor.Product.FundValueDates;
using FundAdministration.GlobalInvestor.Product.FxDetails;
using FundAdministration.GlobalInvestor.Product.HoldingLimits;
using FundAdministration.GlobalInvestor.Product.Holidays;
using FundAdministration.GlobalInvestor.Product.InitialSubscriptions;
using FundAdministration.GlobalInvestor.Product.PerformanceFeeSetups;
using FundAdministration.GlobalInvestor.Product.PermissionCountries;
using FundAdministration.GlobalInvestor.Product.SecurityIds;
using FundAdministration.GlobalInvestor.Product.ShareClasses;
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
    public IAdlDealingDetailsService AntiDilutionLevyDealingService { get; }
    public IApproExproDefinitionsService ApproOrExproDefinitionService { get; }
    public ICommissionGroupsService CommissionGroupService { get; }
    public IFundGroupCutoffService CutoffByFundGroupService { get; }
    public IDelayDaysService DelayDayService { get; }
    public IEscalationChecksService EscalationCheckService { get; }
    public IExchangeGroupsService ExchangeGroupService { get; }
    public IFixedCalendarsService FixedCalendarService { get; }
    public IFxDetailsService ForexService { get; }
    public IFrequencyExceptionDaysService FrequentExceptionDayService { get; }
    public IFrequencyExceptionsService FrequentExceptionService { get; }
    public ITradeDateExceptionsService FundCalendarExceptionService { get; }
    public IFundCutoffTimesService FundCutoffTimeService { get; }
    public IFundEscalationChecksService FundEscalationCheckService { get; }
    public IFundManagersService FundManagerService { get; }
    public IFundOfFundsService FundOfFundService { get; }
    public IFundPromotersService FundPromoterService { get; }
    public IFundTradingDeskTransService FundTradingDeskService { get; }
    public IFundValueDatesService FundValueDateService { get; }
    public IHoldingLimitsService HoldingLimitService { get; }
    public IHolidaysService HolidayService { get; }
    public IInitialSubscriptionsService InitialSubscriptionService { get; }
    public IMasterFund MasterFund { get; }
    public IPerformanceFeeSetupsService PerformanceFeeService { get; }
    public IPermissionCountriesService PermissionCountryService { get; }
    public ISecurityIdsService SecurityIdService { get; }
    public ISimulationCalendarsService SimulationCalendarService { get; }
    public ISoftClosuresService SoftClosureService { get; }
    public IStpCounterPartsService StraightThroughProcessingCounterpartService { get; }
    public ITransactionLimitsService TransactionLimitService { get; }
    public ITransactionRestrictionsService TransactionRestrictionService { get; }
    public ITaFundsService TransferAgentFundService { get; }
    public IShareClassesService TransferAgentFundShareclassService { get; }
    //public ITfcsService TrustFundCompanyService { get; }
}
