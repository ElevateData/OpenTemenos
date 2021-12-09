using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.ExchangeOfNewSecurityWithCashInflow;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class ExchangeOfNewSecurityWithCashInflowServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient){ ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateExchangeOfNewSecurityWithCashInflowAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExchangeOfSecurity.NewSecurityWithCashInflowService
            .CreateExchangeOfNewSecurityWithCashInflowAsync(null, null, null, null, null, payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}