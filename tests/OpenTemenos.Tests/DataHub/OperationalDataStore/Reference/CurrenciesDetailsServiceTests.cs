using OpenTemenos.DataHubs.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
[TestCategory("DataHub.OperationalDataStore")]
public class CurrenciesDetailServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };
    private readonly string _recordId = string.Empty;

    [TestMethod]
    public void GetCurrenciesAsync()
    {
        var result = _client.CurrencyCodeService.GetCurrenciesAsync().Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetCurrencyAsync()
    {
        var result = _client.CurrencyCodeService.GetCurrencyAsync(_recordId).Result;
        Assert.IsNotNull(result.Data);
    }
}