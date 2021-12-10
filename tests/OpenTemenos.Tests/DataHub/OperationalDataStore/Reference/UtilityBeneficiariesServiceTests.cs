using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class UtilityBeneficiariesServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetUtilityBeneficiariesAsync()
    {
        var result = _client.UtilityBeneficiaryService
            .GetUtilityBeneficiariesAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}