using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class IndustryListServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetIndustryListAsync()
    {
        var result = _client.IndustryService.GetIndustryListAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}