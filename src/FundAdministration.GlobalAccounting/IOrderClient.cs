using OpenTemenos.FundAdministrations.GlobalAccounting.Order.StockExchangeTransactions;

namespace OpenTemenos.FundAdministrations.GlobalAccounting;

public interface IOrderClient
{
    public IStockExchangeTransactionService StockExchangeTransactionBookingService { get; }
}