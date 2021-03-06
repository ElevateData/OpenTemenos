using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.OptionFees;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass, TestCategory("FundAdministration/GlobalAccounting")]
public class OptionFeeServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    [Ignore("POST method")]
    public void CreateOptionFeeAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.OptionFeeService.CreateOptionFeeAsync(payload).Result;
        Assert.IsNotNull(result.Body);
    }
}