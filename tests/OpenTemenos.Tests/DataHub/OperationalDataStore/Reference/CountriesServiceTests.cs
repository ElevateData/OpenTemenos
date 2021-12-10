using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class CountryServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetCountriesAsync()
    {
        var result = _client.CountryCodeService.GetCountriesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}