using DataHub.AnalyticDataStore;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Holding;

[TestClass]
[TestCategory("DataHub.AnalyticDataStore")]
public class RetailLendingCustomerDetailServiceTests : CredentialManagement
{
    private readonly IHoldingClient _client = new HoldingClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetRetailLendingCustomerDetailsAsync()
    {
        var result = _client.LendingCustomerBalanceService.GetRetailLendingCustomerDetailsAsync().Result;
        Assert.IsNotNull(result.Data);
    }
}