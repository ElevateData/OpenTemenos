using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transact;

namespace OpenTemenos.Tests.Transact.Reference;

[TestClass]
public class BundleRatesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);
    private readonly string _bundleId = string.Empty;

    [TestMethod]
    public void GetBundleExchangeRatesAsync()
    {
        var result = _client.BundleRatesService.GetBundleExchangeRatesAsync(_bundleId, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
    [TestMethod]
    public void GetBundleInternalRatesAsync()
    {
        var result = _client.BundleRatesService.GetBundleInternalRatesAsync(_bundleId, null, null, null, null, null, null, null).Result;
        Assert.IsNotNull(result.Body);
    }
}