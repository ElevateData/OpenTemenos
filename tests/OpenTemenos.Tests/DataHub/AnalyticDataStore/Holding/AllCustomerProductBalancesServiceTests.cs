using OpenTemenos.DataHubs.AnalyticDataStore;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;

[TestClass]
[TestCategory("DataHub.AnalyticDataStore")]
public class AllCustomerProductBalanceServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetAllCustomerProductBalancesAsync()
    {
        var result = _client.CustomerProductBalanceService
            .GetAllCustomerProductBalancesAsync()
            .Result;
        Assert.IsNotNull(result.Data);
    }
}