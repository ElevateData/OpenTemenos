using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class LanguageListServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetLanguageListAsync()
    {
        var result = _client.LanguageCodeService.GetLanguageListAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}