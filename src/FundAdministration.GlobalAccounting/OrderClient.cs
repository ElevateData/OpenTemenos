using OpenTemenos.FundAdministrations.GlobalAccounting.Order;
using OpenTemenos.FundAdministrations.GlobalAccounting.Order.StockExchangeTransactions;
using OpenTemenos.Shared.Data;

namespace OpenTemenos.FundAdministrations.GlobalAccounting;

public class OrderClient : IOrderClient
{
    private readonly HttpClient _httpClient;

    public OrderClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public string BaseUrl { get; set; } = DefaultConfig.BaseUrl;
    public bool ReadResponseAsString { get; set; } = DefaultConfig.ReadResponseAsString;

    public IStockExchangeTransactionService StockExchangeTransactionBookingService =>
        new StockExchangeTransactionService(_httpClient)
            { BaseUrl = BaseUrl, ReadResponseAsString = ReadResponseAsString };
}