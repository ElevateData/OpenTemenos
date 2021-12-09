using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Reference.SwapsPrice;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Reference;

[TestClass]
public class SwapsPriceServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateSwapPriceAsync()
    {
        var body = new _0BULKPayload();
        var result = _client.SwapsPriceService.CreateSwapPriceAsync(null, null, null, null, null, body).Result;
        Assert.IsNotNull(result.Body);
    }
}