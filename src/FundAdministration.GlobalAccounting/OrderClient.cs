using FundAdministration.GlobalAccounting.Order;
using FundAdministration.GlobalAccounting.Order.StockExchangeTransaction;

namespace FundAdministration.GlobalAccounting;

public class OrderClient : IOrderClient
{
    private readonly HttpClient _httpClient;

    public OrderClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IStockExchangeTransactionService StockExchangeTransactionBookingService => new StockExchangeTransactionService(_httpClient);
}
