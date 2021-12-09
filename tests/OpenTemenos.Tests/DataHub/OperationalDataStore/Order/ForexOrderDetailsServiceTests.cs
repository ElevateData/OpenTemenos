using DataHub.OperationalDataStore;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Order;

[TestClass]
public class ForexOrderDetailsServiceTests : CredentialManagement
{
    private const string CounterPartyId = "";
    private const string RecordId = "";
    private readonly IOrderClient _client = new OrderClient(HttpClient);

    [TestMethod]
    public void GetForexDealsAsync()
    {
        var result = _client.TreasuryForexOrderService.GetForexDealsAsync(CounterPartyId, null).Result;
        Assert.IsNotNull(result.Data);
    }

    [TestMethod]
    public void GetCustomerForexLimitOrdersAsync()
    {
        var result = _client.TreasuryForexOrderService.GetCustomerForexLimitOrdersAsync(RecordId, null).Result;
        Assert.IsNotNull(result.Data);
    }
}