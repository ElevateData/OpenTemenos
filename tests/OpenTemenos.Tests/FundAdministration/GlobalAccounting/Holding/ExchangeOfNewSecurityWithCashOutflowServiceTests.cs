using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.ExchangeOfNewSecurityWithCashOutflow;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class ExchangeOfNewSecurityWithCashOutflowServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod]
    [Ignore("POST method")]
    public void CreateExchangeOfNewSecurityWithCashOutflowAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExchangeOfSecurity.NewSecurityWithCashOutflowService
            .CreateExchangeOfNewSecurityWithCashOutflowAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}