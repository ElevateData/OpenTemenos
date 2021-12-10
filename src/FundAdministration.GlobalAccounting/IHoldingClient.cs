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
using FundAdministration.GlobalAccounting.Holding.Equities;
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

public interface IHoldingClient
{
    public ICallDepositTransactionService CallDepositTransactionService { get; }
    public ICapitalDecreaseByNewSecurityService CapitalDecreaseByNewSecurityService { get; }
    public ICapitalDecreaseCollectionOfShareService CapitalDecreaseCollectionOfShareService { get; }
    public ICapitalDecreaseOfParValuesForeignShareService CapitalDecreaseOfParValueForeignShareService { get; }
    public ICapitalDecreaseOfParValuesDomesticShareService CapitalDecreaseOfParValueDomesticShareService { get; }
    public ICapitalDecreaseOfParValuesWithRealizedGainService CapitalDecreaseOfParValueDomesticSharesTaxablePayment { get; }
    public ICiaSubscriptionRightService CapitalIncreaseAllotmentSubscriptionRightService { get; }
    public ICapitalIIncreaseWithExerciseOfSubscriptionRightService CapitalIIncreaseWithExerciseOfSubscriptionRightService { get; }
    public ICapitalIncreaseWithoutIssueOfSubscriptionRightService CapitalIncreaseWithoutIssueOfSubscriptionRightService { get; }
    public ICashDividendAnnouncementService CashDividendAnnouncementService { get; }
    public ICouponDividendTransactionService CouponDividendTransactionService { get; }
    public IDebitCreditTransactionService DebitCreditTransactionService { get; }
    public IEquityService EquityService { get; }
    public IExchangeOfSecurity ExchangeOfSecurity { get; }
    public IFixedBondService FixedBondService { get; }
    public IFloatOrRateFactorService FloatingRateOrFactorLoadService { get; }
    public IFloatingVariableBondService FloatingVariableRateBondService { get; }
    public IForwardForeignExchangeRepaymentService ForwardForeignExchangeRepaymentService { get; }
    public IForwardForeignExchangeService ForwardForeignExchangeService { get; }
    public IFutureService FutureService { get; }
    public IFutureMaturityService FutureMaturityService { get; }
    public IFutureFeeService FutureFeeService { get; }
    public IFutureTransactionService FutureTransactionService { get; }
    public IFutureTransactionsRebookingService FutureTransactionRebookingService { get; }
    public IFixedMbsIpbService FixedMortgageBackedSecurityOrInflationProtectedBondService { get; }
    public IOptionExerciseService OptionExerciseService { get; }
    public IOptionMaturityService OptionMaturityService { get; }
    public IOptionFeeService OptionFeeService { get; }
    public IOptionTransactionService OptionTransactionService { get; }
    public IPikBondService PikBondService { get; }
    public IReverseStockSplitService ReverseStockSplitService { get; }
    public ISecurityTransactionRebookingService SecurityTransactionRebookingService { get; }
    public IFundShareTransactionService ShareholderService { get; }
    public ISpinOffService SpinOffService { get; }
    public ISpotForeignExchangeService SpotForeignExchangeService { get; }
    public IStockDividendService StockDividendService { get; }
    public IStockExchangeTransactionFeeService StockExchangeFeeService { get; }
    public IStockSplitService StockSplitService { get; }
    public IIrsTransactionService SwapService { get; }
    public ITermDepositTransactionService TimeTermDepositService { get; }
    public IVariableMbService VariableMortgageBackedSecurityService { get; }
    public IZeroCouponService ZeroCouponService { get; }


    public IOptionTransactionsRebookingService OptionTransactionRebookingService { get; }
}
