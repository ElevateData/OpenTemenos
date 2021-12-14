using OpenTemenos.DataHubs.AnalyticDataStore;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;

[TestClass]
[TestCategory("DataHub.AnalyticDataStore")]
public class RetailDepositsCustomerDetailServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetRetailDepositsCustomerDetailsAsync()
    {
        var result = _client.DepositCustomerBalanceService.GetRetailDepositsCustomerDetailsAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}