using DataHub.AnalyticDataStore;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;

[TestClass]
public class CustomerAccountBalanceOverdrawnServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient);


    [TestMethod]
    public void GetCustomerAccountBalanceOverdrawnAsync()
    {
        var result = _client.CustomerOverdrawnAccountBalanceService
            .GetCustomerAccountBalanceOverdrawnAsync(null, null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}