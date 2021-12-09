using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class BundleRatesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);
    private const string BundleId = "1";

    [TestMethod]
    public void GetBundleExchangeRatesAsync()
    {
        var result = _client.BundleRatesService.GetBundleExchangeRatesAsync(BundleId, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
    [TestMethod]
    public void GetBundleInternalRatesAsync()
    {
        var result = _client.BundleRatesService.GetBundleInternalRatesAsync(BundleId, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
}