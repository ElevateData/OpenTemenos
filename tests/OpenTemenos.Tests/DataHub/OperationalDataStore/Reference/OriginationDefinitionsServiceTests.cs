using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class OriginationDefinitionsServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient);
    private readonly string _recordId = string.Empty;

    [TestMethod]
    public void GetOriginationDefinitionsAsync()
    {
        var result = _client.OriginationDefinitionService.GetOriginationDefinitionsAsync(_recordId).Result;
        Assert.IsNotNull(result.Data);
    }
}