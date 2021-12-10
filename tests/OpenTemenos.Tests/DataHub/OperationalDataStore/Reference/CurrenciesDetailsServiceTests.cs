using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class CurrenciesDetailsServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };
    private readonly string _recordId = string.Empty;

    [TestMethod]
    public void GetCurrenciesAsync()
    {
        var result = _client.CurrencyCodeService.GetCurrenciesAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetCurrencyAsync()
    {
        var result = _client.CurrencyCodeService.GetCurrencyAsync(_recordId).Result;
        Assert.IsNotNull(result.Data);
    }
}