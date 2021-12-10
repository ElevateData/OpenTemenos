using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Order;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class InvestigationItemServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetInvestigationItemsAsync()
    {
        var result = _client.TransactionStopService.GetInvestigationItemsAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}