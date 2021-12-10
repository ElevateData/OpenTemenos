using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.CouponDividendTransactions;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass, TestCategory("FundAdministration/GlobalAccounting")]
public class CouponDividendTransactionServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CouponDividendTransactionAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.CouponDividendTransactionService
            .CouponDividendTransactionAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}