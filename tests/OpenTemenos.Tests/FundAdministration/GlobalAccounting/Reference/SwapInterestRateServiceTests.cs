using OpenTemenos.FundAdministrations.GlobalAccounting;
using OpenTemenos.FundAdministrations.GlobalAccounting.Reference.SwapInterestRates;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Reference;

[TestClass]
[TestCategory("FundAdministration/GlobalAccounting")]
public class SwapInterestRateServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateSwapInterestRateAsync()
    {
        var body = new _0BULKPayload();
        var result = _client.SwapInterestRateService.CreateSwapInterestRateAsync(body)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}