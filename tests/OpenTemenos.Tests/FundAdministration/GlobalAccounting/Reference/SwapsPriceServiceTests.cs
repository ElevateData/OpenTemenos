using OpenTemenos.FundAdministrations.GlobalAccounting;
using OpenTemenos.FundAdministrations.GlobalAccounting.Reference.SwapsPrices;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Reference;

[TestClass]
[TestCategory("FundAdministration/GlobalAccounting")]
public class SwapsPriceServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateSwapPriceAsync()
    {
        var body = new _0BULKPayload();
        var result = _client.SwapsPriceService.CreateSwapPriceAsync(body).Result;
        Assert.IsNotNull(result.Body);
    }
}