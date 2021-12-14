using OpenTemenos.FundAdministrations.GlobalAccounting.Holding;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.CallDepositTransactions;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.CapitalDecreaseByNewSecurities;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.CapitalDecreaseCollectionOfShares;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.CapitalDecreaseOfParValuesDomesticShares;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.CapitalDecreaseOfParValuesForeignShares;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.CapitalDecreaseOfParValuesWithRealizedGains;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.CapitalIIncreaseWithExerciseOfSubscriptionRights;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.CapitalIncreaseWithoutIssueOfSubscriptionRights;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.CashDividendAnnouncements;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.CiaSubscriptionRights;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.CouponDividendTransactions;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.DebitCreditTransactions;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.EosCashCompensations;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.EosMultipleSecurities;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.EosNewSecurityWithoutCash;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.EosSameSecurities;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.Equities;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.ExchangeOfNewSecurityWithCashInflows;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.ExchangeOfNewSecurityWithCashOutflows;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.FixedBonds;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.FixedMbsIpbs;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.FloatingVariableBonds;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.FloatOrRateFactors;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.ForwardForeignExchangeRepayments;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.ForwardForeignExchanges;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.FundShareTransactions;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.FutureFees;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.FutureMaturities;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.Futures;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.FutureTransactions;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.FutureTransactionsRebookings;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.IrsTransactions;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.OptionExercises;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.OptionFees;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.OptionMaturities;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.OptionTransactions;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.OptionTransactionsRebookings;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.PikBonds;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.ReverseStockSplits;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.SecurityTransactionRebookings;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.SpinOffs;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.SpotForeignExchanges;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.StockDividends;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.StockExchangeTransactionFees;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.StockSplits;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.TermDepositTransactions;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.VariableMbs;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.ZeroCoupons;
using OpenTemenos.Shared.Data;

namespace OpenTemenos.FundAdministrations.GlobalAccounting;

public class HoldingClient : IHoldingClient
{
    private readonly HttpClient _httpClient;

    public HoldingClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public IEosCashCompensationService ExchangeOfSecurityNewSecurityWithCashCompensationService =>
        new EosCashCompensationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IEosMultipleSecurityService EosMultipleSecurityService => new EosMultipleSecurityService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IEosNewSecurityWithoutCashService ExchangeOfSecurityNewSecurityWithoutCashCompensationService =>
        new EosNewSecurityWithoutCashService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IEosSameSecurityService ExchangeOfSecuritySameSecurityService => new EosSameSecurityService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IExchangeOfNewSecurityWithCashInflowService ExchangeOfNewSecurityWithCashInflowService =>
        new ExchangeOfNewSecurityWithCashInflowService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IExchangeOfNewSecurityWithCashOutflowService ExchangeOfNewSecurityWithCashOutflowService =>
        new ExchangeOfNewSecurityWithCashOutflowService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICallDepositTransactionService CallDepositTransactionService =>
        new CallDepositTransactionService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICapitalDecreaseByNewSecurityService CapitalDecreaseByNewSecurityService =>
        new CapitalDecreaseByNewSecurityService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICapitalDecreaseCollectionOfShareService CapitalDecreaseCollectionOfShareService =>
        new CapitalDecreaseCollectionOfShareService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICapitalDecreaseOfParValuesDomesticShareService CapitalDecreaseOfParValueDomesticShareService =>
        new CapitalDecreaseOfParValuesDomesticShareService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICapitalDecreaseOfParValuesForeignShareService CapitalDecreaseOfParValueForeignShareService =>
        new CapitalDecreaseOfParValuesForeignShareService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICapitalDecreaseOfParValuesWithRealizedGainService CapitalDecreaseOfParValueDomesticSharesTaxablePayment =>
        new CapitalDecreaseOfParValuesWithRealizedGainService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICapitalIIncreaseWithExerciseOfSubscriptionRightService
        CapitalIIncreaseWithExerciseOfSubscriptionRightService =>
        new CapitalIIncreaseWithExerciseOfSubscriptionRightService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICapitalIncreaseWithoutIssueOfSubscriptionRightService
        CapitalIncreaseWithoutIssueOfSubscriptionRightService =>
        new CapitalIncreaseWithoutIssueOfSubscriptionRightService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICashDividendAnnouncementService CashDividendAnnouncementService =>
        new CashDividendAnnouncementService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICiaSubscriptionRightService CapitalIncreaseAllotmentSubscriptionRightService =>
        new CiaSubscriptionRightService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ICouponDividendTransactionService CouponDividendTransactionService =>
        new CouponDividendTransactionService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IDebitCreditTransactionService DebitCreditTransactionService =>
        new DebitCreditTransactionService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IEquityService EquityService => new EquityService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFixedBondService FixedBondService => new FixedBondService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFixedMbsIpbService FixedMortgageBackedSecurityOrInflationProtectedBondService =>
        new FixedMbsIpbService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFloatingVariableBondService FloatingVariableRateBondService => new FloatingVariableBondService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFloatOrRateFactorService FloatingRateOrFactorLoadService => new FloatOrRateFactorService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IForwardForeignExchangeRepaymentService ForwardForeignExchangeRepaymentService =>
        new ForwardForeignExchangeRepaymentService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IForwardForeignExchangeService ForwardForeignExchangeService =>
        new ForwardForeignExchangeService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFundShareTransactionService ShareholderService => new FundShareTransactionService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFutureFeeService FutureFeeService => new FutureFeeService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFutureMaturityService FutureMaturityService => new FutureMaturityService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFutureService FutureService => new FutureService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFutureTransactionService FutureTransactionService => new FutureTransactionService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IFutureTransactionsRebookingService FutureTransactionRebookingService =>
        new FutureTransactionsRebookingService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IIrsTransactionService SwapService => new IrsTransactionService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IOptionExerciseService OptionExerciseService => new OptionExerciseService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IOptionFeeService OptionFeeService => new OptionFeeService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IOptionMaturityService OptionMaturityService => new OptionMaturityService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IOptionTransactionService OptionTransactionService => new OptionTransactionService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IOptionTransactionsRebookingService OptionTransactionRebookingService =>
        new OptionTransactionsRebookingService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IPikBondService PikBondService => new PikBondService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IReverseStockSplitService ReverseStockSplitService => new ReverseStockSplitService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISecurityTransactionRebookingService SecurityTransactionRebookingService =>
        new SecurityTransactionRebookingService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISpinOffService SpinOffService => new SpinOffService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ISpotForeignExchangeService SpotForeignExchangeService => new SpotForeignExchangeService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IStockDividendService StockDividendService => new StockDividendService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IStockExchangeTransactionFeeService StockExchangeFeeService =>
        new StockExchangeTransactionFeeService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IStockSplitService StockSplitService => new StockSplitService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public ITermDepositTransactionService TimeTermDepositService => new TermDepositTransactionService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IVariableMbService VariableMortgageBackedSecurityService => new VariableMbService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IZeroCouponService ZeroCouponService => new ZeroCouponService(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IExchangeOfSecurity ExchangeOfSecurity => new ExchangeOfSecurity(_httpClient)
        { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}