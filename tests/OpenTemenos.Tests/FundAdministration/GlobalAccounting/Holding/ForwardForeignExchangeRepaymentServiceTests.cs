using OpenTemenos.FundAdministrations.GlobalAccounting;
using OpenTemenos.FundAdministrations.GlobalAccounting.Holding.ForwardForeignExchangeRepayments;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
[TestCategory("FundAdministration/GlobalAccounting")]
public class ForwardForeignExchangeRepaymentServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateForwardForeignExchangeRepaymentAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ForwardForeignExchangeRepaymentService
            .CreateForwardForeignExchangeRepaymentAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}