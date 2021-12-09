using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.StockExchangeTransactionFee;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class StockExchangeTransactionFeeServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod]
    [Ignore("POST method")]
    public void CreateStockExchangeTransactionFeeAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.StockExchangeFeeService
            .CreateStockExchangeTransactionFeeAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}