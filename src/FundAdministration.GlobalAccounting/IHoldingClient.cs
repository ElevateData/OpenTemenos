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
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.Equities;
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

namespace OpenTemenos.FundAdministrations.GlobalAccounting;

public interface IHoldingClient
{
    public ICallDepositTransactionService CallDepositTransactionService { get; }
    public ICapitalDecreaseByNewSecurityService CapitalDecreaseByNewSecurityService { get; }
    public ICapitalDecreaseCollectionOfShareService CapitalDecreaseCollectionOfShareService { get; }
    public ICapitalDecreaseOfParValuesForeignShareService CapitalDecreaseOfParValueForeignShareService { get; }
    public ICapitalDecreaseOfParValuesDomesticShareService CapitalDecreaseOfParValueDomesticShareService { get; }

    public ICapitalDecreaseOfParValuesWithRealizedGainService CapitalDecreaseOfParValueDomesticSharesTaxablePayment {
        get;
    }

    public ICiaSubscriptionRightService CapitalIncreaseAllotmentSubscriptionRightService { get; }

    public ICapitalIIncreaseWithExerciseOfSubscriptionRightService
        CapitalIIncreaseWithExerciseOfSubscriptionRightService { get; }

    public ICapitalIncreaseWithoutIssueOfSubscriptionRightService
        CapitalIncreaseWithoutIssueOfSubscriptionRightService { get; }

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