using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Order;

[TestClass]
public class RejectedCollectionsServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetRejectedCollectionsAsync()
    {
        var result = _client.OrderRejectedCollectionService.GetRejectedCollectionsAsync(null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}