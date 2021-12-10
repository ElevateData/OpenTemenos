using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class ChequeTypesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetChequeTypesAsync()
    {
        var result = _client.ChequeTypeService.GetChequeTypesAsync(null).Result;
        Assert.IsNotNull(result.Data);
    }
}