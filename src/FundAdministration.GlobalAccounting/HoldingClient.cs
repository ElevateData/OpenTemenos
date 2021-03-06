using FundAdministration.GlobalAccounting.Holding;
using FundAdministration.GlobalAccounting.Holding.CallDepositTransactions;
using FundAdministration.GlobalAccounting.Holding.CapitalDecreaseByNewSecurities;
using FundAdministration.GlobalAccounting.Holding.CapitalDecreaseCollectionOfShares;
using FundAdministration.GlobalAccounting.Holding.CapitalDecreaseOfParValuesDomesticShares;
using FundAdministration.GlobalAccounting.Holding.CapitalDecreaseOfParValuesForeignShares;
using FundAdministration.GlobalAccounting.Holding.CapitalDecreaseOfParValuesWithRealizedGains;
using FundAdministration.GlobalAccounting.Holding.CapitalIIncreaseWithExerciseOfSubscriptionRights;
using FundAdministration.GlobalAccounting.Holding.CapitalIncreaseWithoutIssueOfSubscriptionRights;
using FundAdministration.GlobalAccounting.Holding.CashDividendAnnouncements;
using FundAdministration.GlobalAccounting.Holding.CiaSubscriptionRights;
using FundAdministration.GlobalAccounting.Holding.CouponDividendTransactions;
using FundAdministration.GlobalAccounting.Holding.DebitCreditTransactions;
using FundAdministration.GlobalAccounting.Holding.EosCashCompensations;
using FundAdministration.GlobalAccounting.Holding.EosMultipleSecurities;
using FundAdministration.GlobalAccounting.Holding.EosNewSecurityWithoutCash;
using FundAdministration.GlobalAccounting.Holding.EosSameSecurities;
using FundAdministration.GlobalAccounting.Holding.Equities;
using FundAdministration.GlobalAccounting.Holding.ExchangeOfNewSecurityWithCashInflows;
using FundAdministration.GlobalAccounting.Holding.ExchangeOfNewSecurityWithCashOutflows;
using FundAdministration.GlobalAccounting.Holding.FixedBonds;
using FundAdministration.GlobalAccounting.Holding.FixedMbsIpbs;
using FundAdministration.GlobalAccounting.Holding.FloatingVariableBonds;
using FundAdministration.GlobalAccounting.Holding.FloatOrRateFactors;
using FundAdministration.GlobalAccounting.Holding.ForwardForeignExchangeRepayments;
using FundAdministration.GlobalAccounting.Holding.ForwardForeignExchanges;
using FundAdministration.GlobalAccounting.Holding.FundShareTransactions;
using FundAdministration.GlobalAccounting.Holding.FutureFees;
using FundAdministration.GlobalAccounting.Holding.FutureMaturities;
using FundAdministration.GlobalAccounting.Holding.Futures;
using FundAdministration.GlobalAccounting.Holding.FutureTransactions;
using FundAdministration.GlobalAccounting.Holding.FutureTransactionsRebookings;
using FundAdministration.GlobalAccounting.Holding.IrsTransactions;
using FundAdministration.GlobalAccounting.Holding.OptionExercises;
using FundAdministration.GlobalAccounting.Holding.OptionFees;
using FundAdministration.GlobalAccounting.Holding.OptionMaturities;
using FundAdministration.GlobalAccounting.Holding.OptionTransactions;
using FundAdministration.GlobalAccounting.Holding.OptionTransactionsRebookings;
using FundAdministration.GlobalAccounting.Holding.PikBonds;
using FundAdministration.GlobalAccounting.Holding.ReverseStockSplits;
using FundAdministration.GlobalAccounting.Holding.SecurityTransactionRebookings;
using FundAdministration.GlobalAccounting.Holding.SpinOffs;
using FundAdministration.GlobalAccounting.Holding.SpotForeignExchanges;
using FundAdministration.GlobalAccounting.Holding.StockDividends;
using FundAdministration.GlobalAccounting.Holding.StockExchangeTransactionFees;
using FundAdministration.GlobalAccounting.Holding.StockSplits;
using FundAdministration.GlobalAccounting.Holding.TermDepositTransactions;
using FundAdministration.GlobalAccounting.Holding.VariableMbs;
using FundAdministration.GlobalAccounting.Holding.ZeroCoupons;

namespace FundAdministration.GlobalAccounting;

public class HoldingClient : IHoldingClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public HoldingClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public ICallDepositTransactionService CallDepositTransactionService => new CallDepositTransactionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICapitalDecreaseByNewSecurityService CapitalDecreaseByNewSecurityService => new CapitalDecreaseByNewSecurityService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICapitalDecreaseCollectionOfShareService CapitalDecreaseCollectionOfShareService => new CapitalDecreaseCollectionOfShareService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICapitalDecreaseOfParValuesDomesticShareService CapitalDecreaseOfParValueDomesticShareService => new CapitalDecreaseOfParValuesDomesticShareService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICapitalDecreaseOfParValuesForeignShareService CapitalDecreaseOfParValueForeignShareService => new CapitalDecreaseOfParValuesForeignShareService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICapitalDecreaseOfParValuesWithRealizedGainService CapitalDecreaseOfParValueDomesticSharesTaxablePayment => new CapitalDecreaseOfParValuesWithRealizedGainService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICapitalIIncreaseWithExerciseOfSubscriptionRightService CapitalIIncreaseWithExerciseOfSubscriptionRightService => new CapitalIIncreaseWithExerciseOfSubscriptionRightService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICapitalIncreaseWithoutIssueOfSubscriptionRightService CapitalIncreaseWithoutIssueOfSubscriptionRightService => new CapitalIncreaseWithoutIssueOfSubscriptionRightService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICashDividendAnnouncementService CashDividendAnnouncementService => new CashDividendAnnouncementService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICiaSubscriptionRightService CapitalIncreaseAllotmentSubscriptionRightService => new CiaSubscriptionRightService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ICouponDividendTransactionService CouponDividendTransactionService => new CouponDividendTransactionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IDebitCreditTransactionService DebitCreditTransactionService => new DebitCreditTransactionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IEosCashCompensationService ExchangeOfSecurityNewSecurityWithCashCompensationService => new EosCashCompensationService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IEosMultipleSecurityService EosMultipleSecurityService => new EosMultipleSecurityService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IEosNewSecurityWithoutCashService ExchangeOfSecurityNewSecurityWithoutCashCompensationService => new EosNewSecurityWithoutCashService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IEosSameSecurityService ExchangeOfSecuritySameSecurityService => new EosSameSecurityService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IEquityService EquityService => new EquityService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IExchangeOfNewSecurityWithCashInflowService ExchangeOfNewSecurityWithCashInflowService => new ExchangeOfNewSecurityWithCashInflowService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IExchangeOfNewSecurityWithCashOutflowService ExchangeOfNewSecurityWithCashOutflowService => new ExchangeOfNewSecurityWithCashOutflowService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFixedBondService FixedBondService => new FixedBondService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFixedMbsIpbService FixedMortgageBackedSecurityOrInflationProtectedBondService => new FixedMbsIpbService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFloatingVariableBondService FloatingVariableRateBondService => new FloatingVariableBondService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFloatOrRateFactorService FloatingRateOrFactorLoadService => new FloatOrRateFactorService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IForwardForeignExchangeRepaymentService ForwardForeignExchangeRepaymentService => new ForwardForeignExchangeRepaymentService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IForwardForeignExchangeService ForwardForeignExchangeService => new ForwardForeignExchangeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFundShareTransactionService ShareholderService => new FundShareTransactionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFutureFeeService FutureFeeService => new FutureFeeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFutureMaturityService FutureMaturityService => new FutureMaturityService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFutureService FutureService => new FutureService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFutureTransactionService FutureTransactionService => new FutureTransactionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IFutureTransactionsRebookingService FutureTransactionRebookingService => new FutureTransactionsRebookingService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IIrsTransactionService SwapService => new IrsTransactionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IOptionExerciseService OptionExerciseService => new OptionExerciseService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IOptionFeeService OptionFeeService => new OptionFeeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IOptionMaturityService OptionMaturityService => new OptionMaturityService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IOptionTransactionService OptionTransactionService => new OptionTransactionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IOptionTransactionsRebookingService OptionTransactionRebookingService => new OptionTransactionsRebookingService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IPikBondService PikBondService => new PikBondService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IReverseStockSplitService ReverseStockSplitService => new ReverseStockSplitService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISecurityTransactionRebookingService SecurityTransactionRebookingService => new SecurityTransactionRebookingService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISpinOffService SpinOffService => new SpinOffService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ISpotForeignExchangeService SpotForeignExchangeService => new SpotForeignExchangeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IStockDividendService StockDividendService => new StockDividendService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IStockExchangeTransactionFeeService StockExchangeFeeService => new StockExchangeTransactionFeeService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IStockSplitService StockSplitService => new StockSplitService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public ITermDepositTransactionService TimeTermDepositService => new TermDepositTransactionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IVariableMbService VariableMortgageBackedSecurityService => new VariableMbService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
    public IZeroCouponService ZeroCouponService => new ZeroCouponService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };

    public IExchangeOfSecurity ExchangeOfSecurity => new ExchangeOfSecurity(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
