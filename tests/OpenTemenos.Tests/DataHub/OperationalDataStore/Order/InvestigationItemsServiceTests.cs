using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Order;

[TestClass]
public class InvestigationItemsServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);


    [TestMethod]
    public void GetInvestigationItemsAsync()
    {
        var result = _client.TransactionStopService.GetInvestigationItemsAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}