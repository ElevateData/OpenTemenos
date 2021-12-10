using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.ForwardForeignExchanges;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass, TestCategory("FundAdministration/GlobalAccounting")]
public class ForwardForeignExchangeServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateForwardForeignExchangeAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ForwardForeignExchangeService
            .CreateForwardForeignExchangeAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}