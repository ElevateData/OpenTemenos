using FundAdministration.GlobalAccounting.Holding.CallDepositTransactions;
using FundAdministration.GlobalAccounting.Holding.CapitalDecreaseByNewSecurity;
using FundAdministration.GlobalAccounting.Holding.CapitalDecreaseCollectionOfShares;
using FundAdministration.GlobalAccounting.Holding.CapitalDecreaseOfParValuesDomesticShare;
using FundAdministration.GlobalAccounting.Holding.CapitalDecreaseOfParValuesForeignShare;
using FundAdministration.GlobalAccounting.Holding.CapitalDecreaseOfParValuesWithRealizedGain;
using FundAdministration.GlobalAccounting.Holding.CapitalIIncreaseWithExerciseOfSubscriptionRights;
using FundAdministration.GlobalAccounting.Holding.CapitalIncreaseWithoutIssueOfSubscriptionRights;
using FundAdministration.GlobalAccounting.Holding.CashDividendAnnouncement;
using FundAdministration.GlobalAccounting.Holding.CiaSubscriptionRight;
using FundAdministration.GlobalAccounting.Holding.CouponDividendTransaction;
using FundAdministration.GlobalAccounting.Holding.DebitCreditTransaction;
using FundAdministration.GlobalAccounting.Holding.Equity;
using FundAdministration.GlobalAccounting.Holding.FixedBond;
using FundAdministration.GlobalAccounting.Holding.FixedMbsIpb;
using FundAdministration.GlobalAccounting.Holding.FloatingVariableBond;
using FundAdministration.GlobalAccounting.Holding.FloatOrRateFactor;
using FundAdministration.GlobalAccounting.Holding.ForwardForeignExchange;
using FundAdministration.GlobalAccounting.Holding.ForwardForeignExchangeRepayment;
using FundAdministration.GlobalAccounting.Holding.FundShareTransaction;
using FundAdministration.GlobalAccounting.Holding.Future;
using FundAdministration.GlobalAccounting.Holding.FutureFee;
using FundAdministration.GlobalAccounting.Holding.FutureMaturity;
using FundAdministration.GlobalAccounting.Holding.FutureTransaction;
using FundAdministration.GlobalAccounting.Holding.FutureTransactionsRebooking;
using FundAdministration.GlobalAccounting.Holding.IrsTransactions;
using FundAdministration.GlobalAccounting.Holding.OptionExercise;
using FundAdministration.GlobalAccounting.Holding.OptionFee;
using FundAdministration.GlobalAccounting.Holding.OptionMaturity;
using FundAdministration.GlobalAccounting.Holding.OptionTransaction;
using FundAdministration.GlobalAccounting.Holding.OptionTransactionsRebooking;
using FundAdministration.GlobalAccounting.Holding.PikBond;
using FundAdministration.GlobalAccounting.Holding.ReverseStockSplit;
using FundAdministration.GlobalAccounting.Holding.SecurityTransactionRebooking;
using FundAdministration.GlobalAccounting.Holding.SpinOff;
using FundAdministration.GlobalAccounting.Holding.SpotForeignExchange;
using FundAdministration.GlobalAccounting.Holding.StockDividend;
using FundAdministration.GlobalAccounting.Holding.StockExchangeTransactionFee;
using FundAdministration.GlobalAccounting.Holding.StockSplit;
using FundAdministration.GlobalAccounting.Holding.TermDepositTransaction;
using FundAdministration.GlobalAccounting.Holding.VariableMbs;
using FundAdministration.GlobalAccounting.Holding.ZeroCoupon;

namespace FundAdministration.GlobalAccounting;

public interface IHoldingClient
{
    public ICallDepositTransactionsService CallDepositTransactionService { get; }
    public ICapitalDecreaseByNewSecurityService CapitalDecreaseByNewSecurityService { get; }
    public ICapitalDecreaseCollectionOfSharesService CapitalDecreaseCollectionOfShareService { get; }
    public ICapitalDecreaseOfParValuesForeignShareService CapitalDecreaseOfParValueForeignShareService { get; }
    public ICapitalDecreaseOfParValuesDomesticShareService CapitalDecreaseOfParValueDomesticShareService { get; }
    public ICapitalDecreaseOfParValuesWithRealizedGainService CapitalDecreaseOfParValueDomesticSharesTaxablePayment { get; }
    public ICiaSubscriptionRightService CapitalIncreaseAllotmentSubscriptionRightService { get; }
    public ICapitalIIncreaseWithExerciseOfSubscriptionRightsService CapitalIIncreaseWithExerciseOfSubscriptionRightService { get; }
    public ICapitalIncreaseWithoutIssueOfSubscriptionRightsService CapitalIncreaseWithoutIssueOfSubscriptionRightService { get; }
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
    public IIrsTransactionsService SwapService { get; }
    public ITermDepositTransactionService TimeTermDepositService { get; }
    public IVariableMbsService VariableMortgageBackedSecurityService { get; }
    public IZeroCouponService ZeroCouponService { get; }


    public IOptionTransactionsRebookingService OptionTransactionRebookingService { get; }
}
