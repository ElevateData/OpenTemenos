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
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;

    public ProductClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IAdlDealingDetailsService AntiDilutionLevyDealingService => new AdlDealingDetailsService(_httpClient){BaseUrl = BaseUrl};
    public IApproExproDefinitionsService ApproOrExproDefinitionService => new ApproExproDefinitionsService(_httpClient){BaseUrl = BaseUrl};
    public ICommissionGroupsService CommissionGroupService => new CommissionGroupsService(_httpClient){BaseUrl = BaseUrl};
    public IDelayDaysService DelayDayService => new DelayDaysService(_httpClient){BaseUrl = BaseUrl};
    public IEscalationChecksService EscalationCheckService => new EscalationChecksService(_httpClient){BaseUrl = BaseUrl};
    public IExchangeGroupsService ExchangeGroupService => new ExchangeGroupsService(_httpClient){BaseUrl = BaseUrl};
    public IFixedCalendarsService FixedCalendarService => new FixedCalendarsService(_httpClient){BaseUrl = BaseUrl};
    public IFrequencyExceptionDaysService FrequentExceptionDayService => new FrequencyExceptionDaysService(_httpClient){BaseUrl = BaseUrl};
    public IFrequencyExceptionsService FrequentExceptionService => new FrequencyExceptionsService(_httpClient){BaseUrl = BaseUrl};
    public IFundCutoffTimesService FundCutoffTimeService => new FundCutoffTimesService(_httpClient){BaseUrl = BaseUrl};
    public IFundEscalationChecksService FundEscalationCheckService => new FundEscalationChecksService(_httpClient){BaseUrl = BaseUrl};
    public IFundGroupCutoffService CutoffByFundGroupService => new FundGroupCutoffService(_httpClient){BaseUrl = BaseUrl};
    public IFundManagersService FundManagerService => new FundManagersService(_httpClient){BaseUrl = BaseUrl};
    public IFundOfFundsService FundOfFundService => new FundOfFundsService(_httpClient){BaseUrl = BaseUrl};
    public IFundPromotersService FundPromoterService => new FundPromotersService(_httpClient){BaseUrl = BaseUrl};

    public IFundTradingDeskTransService FundTradingDeskService => new FundTradingDeskTransService(_httpClient){BaseUrl = BaseUrl};

    public IFundValueDatesService FundValueDateService => new FundValueDatesService(_httpClient){BaseUrl = BaseUrl};
    public IFxDetailsService ForexService => new FxDetailsService(_httpClient){BaseUrl = BaseUrl};
    public IHoldingLimitsService HoldingLimitService => new HoldingLimitsService(_httpClient){BaseUrl = BaseUrl};
    public IHolidaysService HolidayService => new HolidaysService(_httpClient){BaseUrl = BaseUrl};
    public IInitialSubscriptionsService InitialSubscriptionService => new InitialSubscriptionsService(_httpClient){BaseUrl = BaseUrl};

    public IMasterFund MasterFund => new MasterFund(_httpClient){BaseUrl = BaseUrl};

    public IPerformanceFeeSetupsService PerformanceFeeService => new PerformanceFeeSetupsService(_httpClient){BaseUrl = BaseUrl};
    public IPermissionCountriesService PermissionCountryService => new PermissionCountriesService(_httpClient){BaseUrl = BaseUrl};
    public ISecurityIdsService SecurityIdService => new SecurityIdsService(_httpClient){BaseUrl = BaseUrl};
    public ISecurityService SecurityService => new SecurityService(_httpClient){BaseUrl = BaseUrl};
    public IShareClassesService TransferAgentFundShareclassService => new ShareClassesService(_httpClient){BaseUrl = BaseUrl};
    public ISimulationCalendarsService SimulationCalendarService => new SimulationCalendarsService(_httpClient){BaseUrl = BaseUrl};
    public ISoftClosuresService SoftClosureService => new SoftClosuresService(_httpClient){BaseUrl = BaseUrl};
    public IStpCounterPartsService StraightThroughProcessingCounterpartService => new StpCounterPartsService(_httpClient){BaseUrl = BaseUrl};
    public ITaFundsService TransferAgentFundService => new TaFundsService(_httpClient){BaseUrl = BaseUrl};
    public ITradeDateExceptionsService FundCalendarExceptionService => new TradeDateExceptionsService(_httpClient){BaseUrl = BaseUrl};
    public ITransactionLimitsService TransactionLimitService => new TransactionLimitsService(_httpClient){BaseUrl = BaseUrl};
    public ITransactionRestrictionsService TransactionRestrictionService => new TransactionRestrictionsService(_httpClient){BaseUrl = BaseUrl};
}
