using DataHub.AnalyticDataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenTemenos.Tests.DataHub.AnalyticDataStore.Product;

[TestClass]
public class CorporateLendingProductBalancesServiceTests : CredentialManagement
{
    private readonly IProductClient _client = new ProductClient(HttpClient);


    [TestMethod]
    public void GetCorporateLendingProductBalancesAsync()
    {
        var result = _client.CorporateLendingProductService.GetCorporateLendingProductBalancesAsync(null, null, null).Result;
        Assert.IsNotNull(result.Data);
    }
}