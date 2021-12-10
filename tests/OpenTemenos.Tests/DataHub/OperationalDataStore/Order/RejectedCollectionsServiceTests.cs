using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Order;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class RejectedCollectionServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetRejectedCollectionsAsync()
    {
        var result = _client.OrderRejectedCollectionService.GetRejectedCollectionsAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}