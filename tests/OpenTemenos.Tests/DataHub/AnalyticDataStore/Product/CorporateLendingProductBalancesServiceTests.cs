using DataHub.AnalyticDataStore;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Product;

[TestClass]
public class CorporateLendingProductBalancesServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient) { ReadResponseAsString = true };


    [TestMethod]
    public void GetCorporateLendingProductBalancesAsync()
    {
        var result = _client.CorporateLendingProductService.GetCorporateLendingProductBalancesAsync()
            .Result;
        Assert.IsNotNull(result.Data);
    }
}