using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class HoldTypesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetHoldTypesAsync()
    {
        var result = _client.UsModelBankHoldTypeService.GetHoldTypesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}