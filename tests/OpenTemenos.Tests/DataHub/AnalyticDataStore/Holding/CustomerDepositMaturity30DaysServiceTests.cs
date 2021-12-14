using OpenTemenos.DataHubs.AnalyticDataStore;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;

[TestClass]
[TestCategory("DataHub.AnalyticDataStore")]
public class CustomerDepositMaturity30DayServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetCustomerDepositMaturity30DaysAsync()
    {
        var result = _client.CustomerDepositService.GetCustomerDepositMaturity30DaysAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}