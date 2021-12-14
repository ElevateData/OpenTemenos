using OpenTemenos.DataHubs.AnalyticDataStore;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;

[TestClass]
[TestCategory("DataHub.AnalyticDataStore")]
public class CustomerAccountBalanceOverdrawnServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetCustomerAccountBalanceOverdrawnAsync()
    {
        var result = _client.CustomerOverdrawnAccountBalanceService
            .GetCustomerAccountBalanceOverdrawnAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}