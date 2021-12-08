using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class CountriesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetCountriesAsync()
    {
        var result = _client.CountryCodeService.GetCountriesAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }
}