using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.Equities;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass, TestCategory("FundAdministration/GlobalAccounting")]
public class EquityServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void DebitCreditTransactionAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.EquityService
            .CreateEquityAsync(payload)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}