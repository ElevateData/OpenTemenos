using DataHub.AnalyticDataStore;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Product;

[TestClass]
[TestCategory("DataHub.AnalyticDataStore")]
public class RetailLendingProductBalanceServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetRetailLendingProductBalancesAsync()
    {
        var result = _client.RetailLendingProductBalanceService.GetRetailLendingProductBalancesAsync()
            .Result;
        Assert.IsNotNull(result.Data);
    }
}