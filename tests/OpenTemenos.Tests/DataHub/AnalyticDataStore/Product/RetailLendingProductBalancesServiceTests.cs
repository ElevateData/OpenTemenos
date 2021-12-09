using DataHub.AnalyticDataStore;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Product;

[TestClass]
public class RetailLendingProductBalancesServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient){ ReadResponseAsString = true };


    [TestMethod]
    public void GetRetailLendingProductBalancesAsync()
    {
        var result = _client.RetailLendingProductBalanceService.GetRetailLendingProductBalancesAsync(null, null, null)
            .Result;
        Assert.IsNotNull(result.Data);
    }
}