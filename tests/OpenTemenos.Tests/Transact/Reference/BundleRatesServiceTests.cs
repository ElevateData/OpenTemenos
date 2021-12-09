using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class BundleRatesServiceTests : CredentialManagement
{
    private const string BundleId = "1";
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetBundleExchangeRatesAsync()
    {
        var result = _client.BundleRatesService
            .GetBundleExchangeRatesAsync(BundleId, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }

    [TestMethod]
    public void GetBundleInternalRatesAsync()
    {
        var result = _client.BundleRatesService
            .GetBundleInternalRatesAsync(BundleId, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
}