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
using FundAdministration.GlobalInvestor.Product.MinDivPayments;
using FundAdministration.GlobalInvestor.Product.PerformanceFeeSetups;
using FundAdministration.GlobalInvestor.Product.PermissionCountries;
using FundAdministration.GlobalInvestor.Product.Security;
using FundAdministration.GlobalInvestor.Product.SecurityDesc;
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

public class ProductClient : IProductClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public ProductClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IAdlDealingDetailsService AntiDilutionLevyDealingService => new AdlDealingDetailsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IApproExproDefinitionsService ApproOrExproDefinitionService => new ApproExproDefinitionsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICommissionGroupsService CommissionGroupService => new CommissionGroupsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IDelayDaysService DelayDayService => new DelayDaysService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IEscalationChecksService EscalationCheckService => new EscalationChecksService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IExchangeGroupsService ExchangeGroupService => new ExchangeGroupsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFixedCalendarsService FixedCalendarService => new FixedCalendarsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFrequencyExceptionDaysService FrequentExceptionDayService => new FrequencyExceptionDaysService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFrequencyExceptionsService FrequentExceptionService => new FrequencyExceptionsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFundCutoffTimesService FundCutoffTimeService => new FundCutoffTimesService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFundEscalationChecksService FundEscalationCheckService => new FundEscalationChecksService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFundGroupCutoffService CutoffByFundGroupService => new FundGroupCutoffService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFundManagersService FundManagerService => new FundManagersService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFundOfFundsService FundOfFundService => new FundOfFundsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFundPromotersService FundPromoterService => new FundPromotersService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFundTradingDeskTransService FundTradingDeskService => new FundTradingDeskTransService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFundValueDatesService FundValueDateService => new FundValueDatesService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFxDetailsService ForexService => new FxDetailsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IHoldingLimitsService HoldingLimitService => new HoldingLimitsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IHolidaysService HolidayService => new HolidaysService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IInitialSubscriptionsService InitialSubscriptionService => new InitialSubscriptionsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IMinDivPaymentsService MinDivPaymentService => new MinDivPaymentsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IMasterFund MasterFund => new MasterFund(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPerformanceFeeSetupsService PerformanceFeeService => new PerformanceFeeSetupsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPermissionCountriesService PermissionCountryService => new PermissionCountriesService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISecurityDescService SecurityDescService => new SecurityDescService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISecurityIdsService SecurityIdService => new SecurityIdsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISecurityService SecurityService => new SecurityService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IShareClassesService TransferAgentFundShareClassService => new ShareClassesService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISimulationCalendarsService SimulationCalendarService => new SimulationCalendarsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISoftClosuresService SoftClosureService => new SoftClosuresService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IStpCounterPartsService StraightThroughProcessingCounterpartService => new StpCounterPartsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITaFundsService TransferAgentFundService => new TaFundsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IShareValuesService TransferAgentFundShareValueService => new ShareValuesService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITradeDateExceptionsService TradeDateExceptionService => new TradeDateExceptionsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITradeDateExceptionsService FundCalendarExceptionService => new TradeDateExceptionsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITransactionLimitsService TransactionLimitService => new TransactionLimitsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITransactionRestrictionsService TransactionRestrictionService => new TransactionRestrictionsService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
