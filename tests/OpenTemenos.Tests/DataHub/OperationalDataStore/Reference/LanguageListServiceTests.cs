using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class LanguageListServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);

    [TestMethod]
    public void GetLanguageListAsync()
    {
        var result = _client.LanguageCodeService.GetLanguageListAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}