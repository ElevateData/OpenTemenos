using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.ExchangeOfNewSecurityWithCashInflows;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass, TestCategory("FundAdministration/GlobalAccounting")]
public class ExchangeOfNewSecurityWithCashInflowServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateExchangeOfNewSecurityWithCashInflowAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExchangeOfSecurity.NewSecurityWithCashInflowService
            .CreateExchangeOfNewSecurityWithCashInflowAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}