using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Order.StockExchangeTransactions;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Order;

[TestClass, TestCategory("FundAdministration/GlobalAccounting")]
public class StockExchangeTransactionServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateStockExchangeTransactionAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.StockExchangeTransactionBookingService
            .CreateStockExchangeTransactionAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}