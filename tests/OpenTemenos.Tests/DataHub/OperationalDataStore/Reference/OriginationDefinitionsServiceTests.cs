using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class OriginationDefinitionsServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient){ ReadResponseAsString = true };
    private readonly string _recordId = string.Empty;

    [TestMethod]
    public void GetOriginationDefinitionsAsync()
    {
        var result = _client.OriginationDefinitionService.GetOriginationDefinitionsAsync(_recordId).Result;
        Assert.IsNotNull(result.Data);
    }
}