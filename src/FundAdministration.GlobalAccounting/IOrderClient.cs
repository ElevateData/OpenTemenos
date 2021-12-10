using FundAdministration.GlobalAccounting.Order.StockExchangeTransactions;

namespace FundAdministration.GlobalAccounting;

public interface IOrderClient
{
    public IStockExchangeTransactionService StockExchangeTransactionBookingService { get; }
}
