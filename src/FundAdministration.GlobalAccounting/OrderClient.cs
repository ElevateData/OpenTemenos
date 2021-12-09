using FundAdministration.GlobalAccounting.Order;
using FundAdministration.GlobalAccounting.Order.StockExchangeTransaction;

namespace FundAdministration.GlobalAccounting;

public class OrderClient : IOrderClient
{
    private readonly HttpClient _httpClient;
    public string BaseUrl { get; set; } = Shared.Data.DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = Shared.Data.DefaultConfig.ReadResponseAsString;

    public OrderClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public IStockExchangeTransactionService StockExchangeTransactionBookingService => new StockExchangeTransactionService(_httpClient) { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}
