using FundAdministration.GlobalAccounting;
using FundAdministration.GlobalAccounting.Reference.SwapInterestRate;

namespace OpenTemenos.Tests.FundAdministration.GlobalAccounting.Reference;

[TestClass]
public class SwapInterestRateServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    [Ignore("POST method")]
    public void CreateSwapInterestRateAsync()
    {
        var body = new _0BULKPayload();
        var result = _client.SwapInterestRateService.CreateSwapInterestRateAsync(null, null, null, null, null, body)
            .Result;
        Assert.IsNotNull(result.Body);
    }
}