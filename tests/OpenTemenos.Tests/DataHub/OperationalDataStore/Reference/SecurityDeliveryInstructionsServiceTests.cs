using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class SecurityDeliveryInstructionServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetSecurityDeliveryInstructionsAsync()
    {
        var result = _client.SecurityDeliveryInstructionService.GetSecurityDeliveryInstructionsAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}