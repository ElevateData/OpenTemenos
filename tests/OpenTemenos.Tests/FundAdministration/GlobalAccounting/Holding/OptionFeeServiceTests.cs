using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Holding.OptionFee;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Holding;

[TestClass]
public class OptionFeeServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod]
    [Ignore("POST method")]
    public void CreateOptionFeeAsync()
    {
        var payload = new _0BULKPayload();
        var result = _client.OptionFeeService.CreateOptionFeeAsync(null, null, null, null, null, payload).Result;
        Assert.IsNotNull(result.Body);
    }
}