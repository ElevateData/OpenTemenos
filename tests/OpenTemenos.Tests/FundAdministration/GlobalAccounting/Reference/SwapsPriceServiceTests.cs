using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Reference.SwapsPrice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Reference;

[TestClass]
public class SwapsPriceServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod, Ignore("POST method")]
    public void CreateSwapPriceAsync()
    {
        var body = new _0BULKPayload() { };
        var result = _client.SwapsPriceService.CreateSwapPriceAsync(null, null, null, null, null, body).Result;
        Assert.IsNotNull(result.Body);
    }
}