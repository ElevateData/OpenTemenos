using DataHub.AnalyticDataStore;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Product;

[TestClass]
public class RetailDepositProductBalancesServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetRetailDepositProductBalancesAsync()
    {
        var result = _client.RetailDepositProductBalanceService.GetRetailDepositProductBalancesAsync(null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}