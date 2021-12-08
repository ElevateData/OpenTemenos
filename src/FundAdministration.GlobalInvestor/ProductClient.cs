using FundAdministration.GlobalInvestor.Product;
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
using FundAdministration.GlobalInvestor.Product.Security;
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

public class ProductClient : IProductClient
{
    private readonly HttpClient _httpClient;

    public ProductClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IAdlDealingDetailsService AntiDilutionLevyDealingService => new AdlDealingDetailsService(_httpClient);
    public IApproExproDefinitionsService ApproOrExproDefinitionService => new ApproExproDefinitionsService(_httpClient);
    public ICommissionGroupsService CommissionGroupService => new CommissionGroupsService(_httpClient);
    public IDelayDaysService DelayDayService => new DelayDaysService(_httpClient);
    public IEscalationChecksService EscalationCheckService => new EscalationChecksService(_httpClient);
    public IExchangeGroupsService ExchangeGroupService => new ExchangeGroupsService(_httpClient);
    public IFixedCalendarsService FixedCalendarService => new FixedCalendarsService(_httpClient);
    public IFrequencyExceptionDaysService FrequentExceptionDayService => new FrequencyExceptionDaysService(_httpClient);
    public IFrequencyExceptionsService FrequentExceptionService => new FrequencyExceptionsService(_httpClient);
    public IFundCutoffTimesService FundCutoffTimeService => new FundCutoffTimesService(_httpClient);
    public IFundEscalationChecksService FundEscalationCheckService => new FundEscalationChecksService(_httpClient);
    public IFundGroupCutoffService CutoffByFundGroupService => new FundGroupCutoffService(_httpClient);
    public IFundManagersService FundManagerService => new FundManagersService(_httpClient);
    public IFundOfFundsService FundOfFundService => new FundOfFundsService(_httpClient);
    public IFundPromotersService FundPromoterService => new FundPromotersService(_httpClient);

    public IFundTradingDeskTransService FundTradingDeskService => new FundTradingDeskTransService(_httpClient);

    public IFundValueDatesService FundValueDateService => new FundValueDatesService(_httpClient);
    public IFxDetailsService ForexService => new FxDetailsService(_httpClient);
    public IHoldingLimitsService HoldingLimitService => new HoldingLimitsService(_httpClient);
    public IHolidaysService HolidayService => new HolidaysService(_httpClient);
    public IInitialSubscriptionsService InitialSubscriptionService => new InitialSubscriptionsService(_httpClient);

    public IMasterFund MasterFund => new MasterFund(_httpClient);

    public IPerformanceFeeSetupsService PerformanceFeeService => new PerformanceFeeSetupsService(_httpClient);
    public IPermissionCountriesService PermissionCountryService => new PermissionCountriesService(_httpClient);
    public ISecurityIdsService SecurityIdService => new SecurityIdsService(_httpClient);
    public ISecurityService SecurityService => new SecurityService(_httpClient);
    public IShareClassesService TransferAgentFundShareclassService => new ShareClassesService(_httpClient);
    public ISimulationCalendarsService SimulationCalendarService => new SimulationCalendarsService(_httpClient);
    public ISoftClosuresService SoftClosureService => new SoftClosuresService(_httpClient);
    public IStpCounterPartsService StraightThroughProcessingCounterpartService => new StpCounterPartsService(_httpClient);
    public ITaFundsService TransferAgentFundService => new TaFundsService(_httpClient);
    public ITradeDateExceptionsService FundCalendarExceptionService => new TradeDateExceptionsService(_httpClient);
    public ITransactionLimitsService TransactionLimitService => new TransactionLimitsService(_httpClient);
    public ITransactionRestrictionsService TransactionRestrictionService => new TransactionRestrictionsService(_httpClient);
}
