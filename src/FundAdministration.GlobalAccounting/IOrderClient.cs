using FundAdministration.GlobalAccounting.Order.StockExchangeTransaction;

namespace FundAdministration.GlobalAccounting;

public interface IOrderClient
{
    public IStockExchangeTransactionService StockExchangeTransactionBookingService { get; }
}
