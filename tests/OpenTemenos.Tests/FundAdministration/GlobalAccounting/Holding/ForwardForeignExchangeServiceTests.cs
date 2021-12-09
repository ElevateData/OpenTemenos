using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.ForwardForeignExchange;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class ForwardForeignExchangeServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod]
    [Ignore("POST method")]
    public void CreateForwardForeignExchangeAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ForwardForeignExchangeService
            .CreateForwardForeignExchangeAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}