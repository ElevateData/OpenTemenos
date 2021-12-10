using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Order;

[TestClass, TestCategory("DataHub.OperationalDataStore")]
public class ForexOrderDetailServiceTests : CredentialManagement
{
    private const string CounterPartyId = "";
    private const string RecordId = "";
    private readonly IOrderClient _client = new OrderClient(HttpClient) { ReadResponseAsString = true };

    [TestMethod]
    public void GetForexDealsAsync()
    {
        var result = _client.TreasuryForexOrderService.GetForexDealsAsync(CounterPartyId).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetCustomerForexLimitOrdersAsync()
    {
        var result = _client.TreasuryForexOrderService.GetCustomerForexLimitOrdersAsync(RecordId).Result;
        Assert.IsNotNull(result.Data);
    }
}