using OpenTemenos.FundAdministrations.GlobalInvestor.Product;
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
using OpenTemenos.Shared.Data;

namespace OpenTemenos.FundAdministrations.GlobalInvestor;

public class ProductClient : IProductClient
{
    private readonly HttpClient _httpClient;

    public ProductClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public IAdlDealingDetailService AntiDilutionLevyDealingService => new AdlDealingDetailService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IApproExproDefinitionService ApproOrExproDefinitionService => new ApproExproDefinitionService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICommissionGroupService CommissionGroupService => new CommissionGroupService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IDelayDayService DelayDayService => new DelayDayService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IEscalationCheckService EscalationCheckService => new EscalationCheckService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IExchangeGroupService ExchangeGroupService => new ExchangeGroupService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFixedCalendarService FixedCalendarService => new FixedCalendarService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFrequencyExceptionDayService FrequentExceptionDayService => new FrequencyExceptionDayService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFrequencyExceptionService FrequentExceptionService => new FrequencyExceptionService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFundCutoffTimeService FundCutoffTimeService => new FundCutoffTimeService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFundEscalationCheckService FundEscalationCheckService => new FundEscalationCheckService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFundGroupCutoffService CutoffByFundGroupService => new FundGroupCutoffService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFundManagerService FundManagerService => new FundManagerService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFundOfFundService FundOfFundService => new FundOfFundService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFundPromoterService FundPromoterService => new FundPromoterService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFundTradingDeskTranService FundTradingDeskService => new FundTradingDeskTranService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFundValueDateService FundValueDateService => new FundValueDateService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFxDetailService ForexService => new FxDetailService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IHoldingLimitService HoldingLimitService => new HoldingLimitService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IHolidayService HolidayService => new HolidayService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IInitialSubscriptionService InitialSubscriptionService => new InitialSubscriptionService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IMinDivPaymentService MinDivPaymentService => new MinDivPaymentService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IMasterFund MasterFund => new MasterFund(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPerformanceFeeSetupService PerformanceFeeService => new PerformanceFeeSetupService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPermissionCountryService PermissionCountryService => new PermissionCountryService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISecurityDescService SecurityDescService => new SecurityDescService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISecurityIdService SecurityIdService => new SecurityIdService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISecurityService SecurityService => new SecurityService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IShareClasseService TransferAgentFundShareClasService => new ShareClasseService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISimulationCalendarService SimulationCalendarService => new SimulationCalendarService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISoftClosureService SoftClosureService => new SoftClosureService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IStpCounterPartService StraightThroughProcessingCounterpartService => new StpCounterPartService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITaFundService TransferAgentFundService => new TaFundService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IShareValueService TransferAgentFundShareValueService => new ShareValueService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITradeDateExceptionService TradeDateExceptionService => new TradeDateExceptionService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITradeDateExceptionService FundCalendarExceptionService => new TradeDateExceptionService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITransactionLimitService TransactionLimitService => new TransactionLimitService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITransactionRestrictionService TransactionRestrictionService =>
        new TransactionRestrictionService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}