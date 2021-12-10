using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class InterestBasiServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetInterestBasisAsync()
    {
        var result = _client.InterestBaseService.GetInterestBasisAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}