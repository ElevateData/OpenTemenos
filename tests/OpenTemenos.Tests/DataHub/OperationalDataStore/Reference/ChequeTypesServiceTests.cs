using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class ChequeTypeServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetChequeTypesAsync()
    {
        var result = _client.ChequeTypeService.GetChequeTypesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}