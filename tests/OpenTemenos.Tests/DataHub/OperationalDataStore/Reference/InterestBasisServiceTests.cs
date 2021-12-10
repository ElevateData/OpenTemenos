using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Reference;

[TestClass]
public class InterestBasisServiceTests : CredentialManagement
{
    private readonly IReferenceClient _client = new ReferenceClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetInterestBasisAsync()
    {
        var result = _client.InterestBaseService.GetInterestBasisAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}