using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class CompaniesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient){ ReadResponseAsString = true };

    [TestMethod]
    public void GetCompaniesAsync()
    {
        var result = _client.LegalEntityService.GetCompaniesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}