using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class EvidenceTypeServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetEvidenceTypesAsync()
    {
        var result = _client.EvidenceTypeService.GetEvidenceTypesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}