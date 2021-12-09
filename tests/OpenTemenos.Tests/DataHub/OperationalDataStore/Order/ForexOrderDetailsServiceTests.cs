using DataHub.OperationalDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.OperationalDataStore.Order;

[TestClass]
public class ForexOrderDetailsServiceTests : CredentialManagement
{
    private readonly IOrderClient _client = new OrderClient(HttpClient);
    private const string CounterPartyId = "";
    private const string RecordId = "";

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