using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class CountriesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    public void GetCountriesAsync()
    {
        var result = _client.CountryCodeService.GetCountriesAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }
}