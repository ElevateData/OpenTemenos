using OpenTemenos.FundAdministrations.GlobalAccounting;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.StockExchangeTransactionFees;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
[TestCategory("FundAdministration/GlobalAccounting")]
public class StockExchangeTransactionFeeServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateStockExchangeTransactionFeeAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.StockExchangeFeeService
            .CreateStockExchangeTransactionFeeAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}