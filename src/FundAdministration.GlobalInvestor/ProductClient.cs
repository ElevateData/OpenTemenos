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

public class ProductClient : IProductClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public ProductClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IAdlDealingDetailService AntiDilutionLevyDealingService => new AdlDealingDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IApproExproDefinitionService ApproOrExproDefinitionService => new ApproExproDefinitionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICommissionGroupService CommissionGroupService => new CommissionGroupService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IDelayDayService DelayDayService => new DelayDayService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IEscalationCheckService EscalationCheckService => new EscalationCheckService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IExchangeGroupService ExchangeGroupService => new ExchangeGroupService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFixedCalendarService FixedCalendarService => new FixedCalendarService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFrequencyExceptionDayService FrequentExceptionDayService => new FrequencyExceptionDayService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFrequencyExceptionService FrequentExceptionService => new FrequencyExceptionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFundCutoffTimeService FundCutoffTimeService => new FundCutoffTimeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFundEscalationCheckService FundEscalationCheckService => new FundEscalationCheckService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFundGroupCutoffService CutoffByFundGroupService => new FundGroupCutoffService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFundManagerService FundManagerService => new FundManagerService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFundOfFundService FundOfFundService => new FundOfFundService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFundPromoterService FundPromoterService => new FundPromoterService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFundTradingDeskTranService FundTradingDeskService => new FundTradingDeskTranService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFundValueDateService FundValueDateService => new FundValueDateService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFxDetailService ForexService => new FxDetailService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IHoldingLimitService HoldingLimitService => new HoldingLimitService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IHolidayService HolidayService => new HolidayService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IInitialSubscriptionService InitialSubscriptionService => new InitialSubscriptionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IMinDivPaymentService MinDivPaymentService => new MinDivPaymentService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IMasterFund MasterFund => new MasterFund(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPerformanceFeeSetupService PerformanceFeeService => new PerformanceFeeSetupService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPermissionCountryService PermissionCountryService => new PermissionCountryService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISecurityDescService SecurityDescService => new SecurityDescService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISecurityIdService SecurityIdService => new SecurityIdService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISecurityService SecurityService => new SecurityService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IShareClasseService TransferAgentFundShareClasService => new ShareClasseService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISimulationCalendarService SimulationCalendarService => new SimulationCalendarService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISoftClosureService SoftClosureService => new SoftClosureService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IStpCounterPartService StraightThroughProcessingCounterpartService => new StpCounterPartService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITaFundService TransferAgentFundService => new TaFundService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IShareValueService TransferAgentFundShareValueService => new ShareValueService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITradeDateExceptionService TradeDateExceptionService => new TradeDateExceptionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITradeDateExceptionService FundCalendarExceptionService => new TradeDateExceptionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITransactionLimitService TransactionLimitService => new TransactionLimitService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITransactionRestrictionService TransactionRestrictionService => new TransactionRestrictionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
