using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass, TestCategory("Transact")]
public class BundleRateServiceTests : CredentialManagement
{
    private const string BundleId = "1";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetBundleExchangeRatesAsync()
    {
        var result = _client.BundleRateService
            .GetBundleExchangeRatesAsync(BundleId).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetBundleInternalRatesAsync()
    {
        var result = _client.BundleRateService
            .GetBundleInternalRatesAsync(BundleId).Result;
        Assert.IsNotNull(result.Body);
    }
}