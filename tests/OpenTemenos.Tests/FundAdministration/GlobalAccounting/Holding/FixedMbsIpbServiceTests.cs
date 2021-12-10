using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.FixedMbsIpbs;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass, TestCategory("FundAdministration/GlobalAccounting")]
public class FixedMbsIpbServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateFixedMbsOrIpbAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.FixedMortgageBackedSecurityOrInflationProtectedBondService
            .CreateFixedMbsOrIpbAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}