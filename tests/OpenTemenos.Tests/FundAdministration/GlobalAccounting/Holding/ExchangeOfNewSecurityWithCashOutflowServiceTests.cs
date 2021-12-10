using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.ExchangeOfNewSecurityWithCashOutflows;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass, TestCategory("FundAdministration/GlobalAccounting")]
public class ExchangeOfNewSecurityWithCashOutflowServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateExchangeOfNewSecurityWithCashOutflowAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.ExchangeOfSecurity.NewSecurityWithCashOutflowService
            .CreateExchangeOfNewSecurityWithCashOutflowAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}